using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Threading;
using System.Xml;
using Home.Andir.Cryptography;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.SequenceManager;
using Motorola.Common.CustomException;

namespace fxpcommunication
{
	// Token: 0x02000006 RID: 6
	public sealed class FxpCommunication : global::fxpcommunication.IExchangeCommunication
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002738 File Offset: 0x00000938
		public FxpCommunication(string fwVersion, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, int timeout, int retryTimes = 3)
		{
			this._commPipe = commPipe;
			this.ReceiveTimeout = timeout;
			this.CommRetryTimes = retryTimes;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027A4 File Offset: 0x000009A4
		public FxpCommunication(string fwVersion, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe commPipe, global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor messageExecutor) : this(fwVersion, commPipe, 1000, 3)
		{
			this._msgExecutor = messageExecutor;
			this.isRemote = true;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000027C8 File Offset: 0x000009C8
		private bool IsOpen
		{
			get
			{
				return this._commPipe != null;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000027E8 File Offset: 0x000009E8
		public void Enable(string fwVersion, string radioSN, byte[] hashInput, byte[] featureCodeID)
		{
			this.protocolVersion = global::fxpcommunication.VersionMapping.GetProtocolVersionByFWVersion(fwVersion);
			if (!global::fxpcommunication.VersionMapping.IsProtocolVersionSupport(this.protocolVersion))
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_DEVICE_NOT_SUPPORT);
			}
			this.FeatureExchange(radioSN, hashInput, featureCodeID, true);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002829 File Offset: 0x00000A29
		public void Disable(string radioSN, byte[] hashInput, byte[] featureCodeID)
		{
			this.FeatureExchange(radioSN, hashInput, featureCodeID, false);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002838 File Offset: 0x00000A38
		public byte[] CreateHashInput(string xmlInputBuffer)
		{
			byte[] array = new byte[128];
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.LoadXml(xmlInputBuffer);
			global::System.Xml.XmlNode xmlNode = xmlDocument.SelectSingleNode("UPDATES");
			if (xmlNode == null || xmlNode.ChildNodes == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_INVALID_XML_INPUT);
			}
			int num = 0;
			foreach (object obj in xmlNode.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
				string innerText = xmlNode2.InnerText;
				if (!string.IsNullOrEmpty(innerText))
				{
					int num2 = (innerText.Length % 2 == 0) ? innerText.Length : (innerText.Length - 1);
					for (int i = 0; i < num2; i += 2)
					{
						string s = innerText.Substring(i, 2);
						try
						{
							array[num++] = byte.Parse(s, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						catch (global::System.Exception)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_INVALID_XML_INPUT);
						}
					}
				}
			}
			for (int j = num; j < array.Length; j++)
			{
				array[j] = 165;
			}
			return array;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000029B8 File Offset: 0x00000BB8
		private void ResetPrevRecvSeqNum()
		{
			this.prevRecvSeqNum = uint.MaxValue;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000029C4 File Offset: 0x00000BC4
		private void RandomSendDiscardMessage(byte[] key, int nMinToSend, int nMaxToSend)
		{
			int num = this.rand.Next(nMinToSend, nMaxToSend);
			for (int i = 0; i < num; i++)
			{
				byte[] array = new byte[16];
				this.rand.NextBytes(array);
				using (global::fxpcommunication.FxpMessage fxpMessage = this.CreateFXPMessage(global::fxpcommunication.OperationEnum.eDiscard, array))
				{
					using (global::fxpcommunication.FxpMessage fxpMessage2 = this.TransferMessage(fxpMessage, key, key))
					{
						if (fxpMessage2.Operation != global::fxpcommunication.OperationEnum.eDiscardAck || fxpMessage2.PayloadLength < 1)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_DCACK_ERROR);
						}
					}
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002A9C File Offset: 0x00000C9C
		private void RandomSendDiscardMessage(byte[] key)
		{
			this.RandomSendDiscardMessage(key, 0, 2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002AAC File Offset: 0x00000CAC
		private void FeatureExchange(string radioSN, byte[] hashInput, byte[] featureCodeID, bool bEnable)
		{
			if (!this.IsOpen)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_COMM_NOT_OPEN);
			}
			if (string.IsNullOrEmpty(radioSN) || featureCodeID == null || hashInput == null || hashInput.Length != 128)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_INVALID_ARGUMENT);
			}
			this.ResetPrevRecvSeqNum();
			byte[] array = null;
			byte[] array2 = null;
			try
			{
				using (global::System.Security.Cryptography.HashAlgorithm hashAlgorithm = new global::Home.Andir.Cryptography.Haval256(global::Home.Andir.Cryptography.HavalPassCount.Pass4))
				{
					array2 = hashAlgorithm.ComputeHash(hashInput);
				}
				this.RandomSendDiscardMessage(array2);
				array = this.FeatureSessionRequest(array2);
				byte keyPosition = this.FeatureCodeTransfer(array, featureCodeID);
				this.RandomSendDiscardMessage(array);
				this.FeatureLockUnlockRequest(array, keyPosition, !bEnable);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_COMM_ERROR);
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
				global::fxpcommunication.FxpMessage.ZeroBuff(array2);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002BC0 File Offset: 0x00000DC0
		private byte[] FeatureSessionRequest(byte[] hashedProductID)
		{
			global::System.Security.Cryptography.SymmetricAlgorithm cryptoByProtocolVersion = global::fxpcommunication.VersionMapping.GetCryptoByProtocolVersion(this.protocolVersion);
			cryptoByProtocolVersion.GenerateKey();
			byte[] array = (byte[])cryptoByProtocolVersion.Key.Clone();
			byte[] result;
			using (global::fxpcommunication.FxpMessage fxpMessage = this.CreateFXPMessage(global::fxpcommunication.OperationEnum.eFeatureSessionRequest, array))
			{
				using (global::fxpcommunication.FxpMessage fxpMessage2 = this.TransferMessage(fxpMessage, hashedProductID, array))
				{
					int num = 32;
					if (fxpMessage2.Operation != global::fxpcommunication.OperationEnum.eFeatureSessionRequestAck || fxpMessage2.PayloadLength != num + 1 || fxpMessage2.Payload[0] != 1)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_FSREQACK_ERROR);
					}
					byte[] array2 = new byte[num];
					global::System.Array.Copy(fxpMessage2.Payload, 1, array2, 0, array2.Length);
					result = array2;
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002CA8 File Offset: 0x00000EA8
		private byte FeatureCodeTransfer(byte[] RADSK, byte[] featureCode)
		{
			if (featureCode == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_INVALID_ARGUMENT);
			}
			int num = this.rand.Next(1, 9);
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (byte)this.rand.Next(0, 6);
			}
			byte b = array[this.rand.Next(0, num)];
			int num2 = 0;
			for (int i = num - 1; i >= 0; i--)
			{
				if (b == array[i])
				{
					num2 = i;
					break;
				}
			}
			byte[] array2 = null;
			byte result;
			try
			{
				if (featureCode == null)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_INVALID_FEATURE);
				}
				array2 = new byte[1 + featureCode.Length];
				array2[0] = b;
				featureCode.CopyTo(array2, 1);
				for (int i = 0; i < num; i++)
				{
					byte[] array3;
					if (i == num2)
					{
						array3 = array2;
					}
					else
					{
						array3 = new byte[1 + featureCode.Length];
						this.rand.NextBytes(array3);
						array3[0] = array[i];
					}
					this.RandomSendDiscardMessage(RADSK);
					using (global::fxpcommunication.FxpMessage fxpMessage = this.CreateFXPMessage(global::fxpcommunication.OperationEnum.eFeatureCodeTransfer, array3))
					{
						using (global::fxpcommunication.FxpMessage fxpMessage2 = this.TransferMessage(fxpMessage, RADSK, RADSK))
						{
							if (fxpMessage2.Operation != global::fxpcommunication.OperationEnum.eFeatureCodeTransferAck || fxpMessage2.PayloadLength != 1 || fxpMessage2.Payload[0] != 1)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_FCACK_ERROR);
							}
						}
					}
				}
				result = b;
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array2);
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002EC4 File Offset: 0x000010C4
		private void FeatureLockUnlockRequest(byte[] RADSK, byte keyPosition, bool bLock)
		{
			byte[] array;
			global::fxpcommunication.OperationEnum operation;
			if (bLock)
			{
				array = new byte[1];
				operation = global::fxpcommunication.OperationEnum.eFeatureLockRequest;
			}
			else
			{
				array = new byte[129];
				operation = global::fxpcommunication.OperationEnum.eFeatureUnlockRequest;
			}
			array[0] = keyPosition;
			using (global::fxpcommunication.FxpMessage fxpMessage = this.CreateFXPMessage(operation, array))
			{
				using (global::fxpcommunication.FxpMessage fxpMessage2 = this.TransferMessage(fxpMessage, RADSK, RADSK))
				{
					global::fxpcommunication.OperationEnum operationEnum = bLock ? global::fxpcommunication.OperationEnum.eFeatureLockRequestAck : global::fxpcommunication.OperationEnum.eFeatureUnlockRequestAck;
					if (fxpMessage2.Operation != operationEnum || fxpMessage2.PayloadLength != 1)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_LULACK_ERROR);
					}
					if (fxpMessage2.Payload[0] != 1)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_FEATURE_FAILED);
					}
				}
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002FB0 File Offset: 0x000011B0
		private global::fxpcommunication.FxpMessage TransferMessage(global::fxpcommunication.FxpMessage message, byte[] encryptKey, byte[] decryptKey)
		{
			byte[] array = null;
			byte[] array2 = null;
			byte[] array3 = null;
			global::fxpcommunication.FxpMessage fxpMessage = null;
			global::fxpcommunication.FxpMessage result;
			try
			{
				array = message.ToMessageBytes(encryptKey, this.rand);
				for (int i = 0; i < this.CommRetryTimes; i++)
				{
					try
					{
						if (this.isRemote)
						{
							global::Motorola.Common.Communication.XcmpTransferData xcmpTransferData = new global::Motorola.Common.Communication.XcmpTransferData(0, 4, (ushort)array.Length, array);
							this._msgExecutor.SendAndReceiveMessage(xcmpTransferData);
							if (xcmpTransferData.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
							{
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_COMM_FAILED);
							}
							byte[] data = xcmpTransferData.Data;
							array2 = new byte[(int)(xcmpTransferData.Length - 2)];
							global::System.Array.Copy(data, 2, array2, 0, (int)(xcmpTransferData.Length - 2));
						}
						else
						{
							this._commPipe.SendData(array, 0, array.Length);
						}
						for (int j = 0; j < 5; j++)
						{
							try
							{
								byte[] array4 = new byte[2];
								array3 = new byte[1024];
								if (!this.isRemote)
								{
									int num = this._commPipe.ReceiveData(array3, 0, this.ReceiveTimeout);
									ushort num2 = global::fxpcommunication.FxpMessage.FromBigEndianBytes(array3, 0);
									array2 = new byte[(int)num2];
									global::System.Buffer.BlockCopy(array3, 2, array2, 0, (int)num2);
								}
								fxpMessage = global::fxpcommunication.FxpMessage.ParseMessageBytes(decryptKey, array2, this.prevRecvSeqNum);
								this.prevRecvSeqNum = (uint)fxpMessage.SequenceNumber;
								break;
							}
							catch (global::Motorola.Common.CustomException.CommonException ex)
							{
								if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_DUP_MSG || j >= 4)
								{
									throw;
								}
							}
						}
						break;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadTimeout && ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_COMM_FAILED);
						}
						if (i >= this.CommRetryTimes - 1)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_FEATURE_TIMEOUT);
						}
						if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure)
						{
							global::System.Threading.Thread.Sleep(3000);
						}
					}
					catch (global::System.Exception)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_COMM_FAILED);
					}
				}
				result = fxpMessage;
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array3);
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
				global::fxpcommunication.FxpMessage.ZeroBuff(array2);
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003254 File Offset: 0x00001454
		private global::fxpcommunication.FxpMessage CreateFXPMessage(global::fxpcommunication.OperationEnum Operation, byte[] payload)
		{
			global::fxpcommunication.FxpMessage result = null;
			global::fxpcommunication.FxpMessage fxpMessage = null;
			try
			{
				fxpMessage = new global::fxpcommunication.FxpMessage();
				global::fxpcommunication.RandomizationEnum[] array = (global::fxpcommunication.RandomizationEnum[])global::System.Enum.GetValues(typeof(global::fxpcommunication.RandomizationEnum));
				int num = this.rand.Next(0, array.Length);
				fxpMessage.Randomization = array[num];
				fxpMessage.ProtocolVersion = this.protocolVersion;
				fxpMessage.SequenceNumber = this.GetNextSequenceNumber();
				fxpMessage.Operation = Operation;
				fxpMessage.Payload = payload;
				result = fxpMessage;
				fxpMessage = null;
			}
			finally
			{
				if (fxpMessage != null)
				{
					fxpMessage.Dispose();
				}
			}
			return result;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000032FC File Offset: 0x000014FC
		private ushort GetNextSequenceNumber()
		{
			if (this.SequenceNumberCounter == 65535)
			{
				this.SequenceNumberCounter = 0;
			}
			ushort sequenceNumberCounter;
			this.SequenceNumberCounter = (sequenceNumberCounter = this.SequenceNumberCounter) + 1;
			return sequenceNumberCounter;
		}

		// Token: 0x04000009 RID: 9
		private global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe _commPipe = null;

		// Token: 0x0400000A RID: 10
		private global::fxpcommunication.ProtocolVersionEnum protocolVersion = global::fxpcommunication.ProtocolVersionEnum.eAes256;

		// Token: 0x0400000B RID: 11
		private global::System.Random rand = new global::System.Random();

		// Token: 0x0400000C RID: 12
		private ushort SequenceNumberCounter = 0;

		// Token: 0x0400000D RID: 13
		private uint prevRecvSeqNum = 0U;

		// Token: 0x0400000E RID: 14
		private bool isRemote = false;

		// Token: 0x0400000F RID: 15
		private global::Motorola.Common.Communication.SequenceManager.PcrRcmpMessageExecutor _msgExecutor;

		// Token: 0x04000010 RID: 16
		private int ReceiveTimeout = 1000;

		// Token: 0x04000011 RID: 17
		private int CommRetryTimes = 3;
	}
}
