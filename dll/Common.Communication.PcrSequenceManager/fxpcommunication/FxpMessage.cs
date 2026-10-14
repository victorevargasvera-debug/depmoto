using System;
using System.Security.Cryptography;
using Motorola.Common.CustomException;

namespace fxpcommunication
{
	// Token: 0x0200000C RID: 12
	internal sealed class FxpMessage : global::System.IDisposable
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003374 File Offset: 0x00001574
		public void Dispose()
		{
			this.protocolVersion = (global::fxpcommunication.ProtocolVersionEnum)0;
			this.randomization = global::fxpcommunication.RandomizationEnum.eNoRandom;
			this.operation = global::fxpcommunication.OperationEnum.eDiscard;
			global::fxpcommunication.FxpMessage.ZeroBuff(this.payload);
			this.Payload = null;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000033A4 File Offset: 0x000015A4
		// (set) Token: 0x06000023 RID: 35 RVA: 0x000033BC File Offset: 0x000015BC
		public global::fxpcommunication.ProtocolVersionEnum ProtocolVersion
		{
			private get
			{
				return this.protocolVersion;
			}
			set
			{
				this.protocolVersion = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000033C8 File Offset: 0x000015C8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000033E0 File Offset: 0x000015E0
		public global::fxpcommunication.RandomizationEnum Randomization
		{
			private get
			{
				return this.randomization;
			}
			set
			{
				this.randomization = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000033EC File Offset: 0x000015EC
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00003404 File Offset: 0x00001604
		public ushort SequenceNumber
		{
			get
			{
				return this.sequenceNumber;
			}
			set
			{
				this.sequenceNumber = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003410 File Offset: 0x00001610
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00003428 File Offset: 0x00001628
		public global::fxpcommunication.OperationEnum Operation
		{
			get
			{
				return this.operation;
			}
			set
			{
				this.operation = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003434 File Offset: 0x00001634
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0000344C File Offset: 0x0000164C
		public byte[] Payload
		{
			get
			{
				return this.payload;
			}
			set
			{
				this.payload = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003458 File Offset: 0x00001658
		public int PayloadLength
		{
			get
			{
				return (this.Payload == null) ? 0 : this.Payload.Length;
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003480 File Offset: 0x00001680
		public byte[] ToMessageBytes(byte[] key, global::System.Random randGenerator)
		{
			byte[] array = null;
			byte[] array2 = null;
			byte[] result;
			try
			{
				global::System.Security.Cryptography.SymmetricAlgorithm cryptoByProtocolVersion = global::fxpcommunication.VersionMapping.GetCryptoByProtocolVersion(this.ProtocolVersion);
				array = this.EncryptionLayer(cryptoByProtocolVersion, key, randGenerator);
				array2 = this.RandomizationLayer(array, randGenerator);
				ushort val = (ushort)(2 + array2.Length);
				result = global::fxpcommunication.FxpMessage.ConcatByteArrays(new byte[][]
				{
					global::fxpcommunication.FxpMessage.ToBigEndianBytes(val),
					global::fxpcommunication.FxpMessage.ToBigEndianBytes((ushort)this.Randomization),
					array2
				});
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_TOMSG_ERROR);
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
				global::fxpcommunication.FxpMessage.ZeroBuff(array2);
			}
			return result;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003538 File Offset: 0x00001738
		public static global::fxpcommunication.FxpMessage ParseMessageBytes(byte[] key, byte[] rawMessage, uint prevSeqNum)
		{
			if (rawMessage == null || rawMessage.Length < 10)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_ACKPRS_ERROR);
			}
			byte[] array = null;
			byte[] array2 = null;
			global::fxpcommunication.FxpMessage fxpMessage = null;
			try
			{
				fxpMessage = global::fxpcommunication.FxpMessage.newFxpMessage();
				int num = 0;
				fxpMessage.Randomization = (global::fxpcommunication.RandomizationEnum)global::fxpcommunication.FxpMessage.FromBigEndianBytes(rawMessage, num);
				num += 2;
				array = global::fxpcommunication.FxpMessage.Derandomize(fxpMessage.Randomization, rawMessage, num);
				num = 0;
				fxpMessage.ProtocolVersion = (global::fxpcommunication.ProtocolVersionEnum)global::fxpcommunication.FxpMessage.FromBigEndianBytes(array, num);
				num += 2;
				fxpMessage.SequenceNumber = global::fxpcommunication.FxpMessage.FromBigEndianBytes(array, num);
				num += 2;
				if ((uint)fxpMessage.SequenceNumber == prevSeqNum)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_DUP_MSG);
				}
				global::System.Security.Cryptography.SymmetricAlgorithm cryptoByProtocolVersion = global::fxpcommunication.VersionMapping.GetCryptoByProtocolVersion(fxpMessage.ProtocolVersion);
				array2 = global::fxpcommunication.FxpMessage.Decrypt(cryptoByProtocolVersion, key, array, num);
				num = 0;
				fxpMessage.Operation = (global::fxpcommunication.OperationEnum)global::fxpcommunication.FxpMessage.FromBigEndianBytes(array2, num);
				num += 2;
				ushort num2 = global::fxpcommunication.FxpMessage.FromBigEndianBytes(array2, num);
				num += 2;
				fxpMessage.Payload = new byte[(int)num2];
				global::System.Array.Copy(array2, num, fxpMessage.Payload, 0, fxpMessage.Payload.Length);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_ACKPRS_ERROR);
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
				global::fxpcommunication.FxpMessage.ZeroBuff(array2);
			}
			return fxpMessage;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003694 File Offset: 0x00001894
		private byte[] EncryptionLayer(global::System.Security.Cryptography.SymmetricAlgorithm iCryptoProvider, byte[] key, global::System.Random randGenerator)
		{
			byte[] array = null;
			byte[] result;
			try
			{
				array = global::fxpcommunication.FxpMessage.ConcatByteArrays(new byte[][]
				{
					global::fxpcommunication.FxpMessage.ToBigEndianBytes((ushort)this.Operation),
					global::fxpcommunication.FxpMessage.ToBigEndianBytes((ushort)this.PayloadLength),
					this.Payload
				});
				result = global::fxpcommunication.FxpMessage.Encrypt(iCryptoProvider, key, array, randGenerator);
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003704 File Offset: 0x00001904
		private byte[] RandomizationLayer(byte[] encryptLayer, global::System.Random randGenerator)
		{
			byte[] array = null;
			byte[] result;
			try
			{
				array = global::fxpcommunication.FxpMessage.ConcatByteArrays(new byte[][]
				{
					global::fxpcommunication.FxpMessage.ToBigEndianBytes((ushort)this.ProtocolVersion),
					global::fxpcommunication.FxpMessage.ToBigEndianBytes(this.SequenceNumber),
					encryptLayer
				});
				result = global::fxpcommunication.FxpMessage.Randomize(this.Randomization, array, randGenerator);
			}
			finally
			{
				global::fxpcommunication.FxpMessage.ZeroBuff(array);
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003770 File Offset: 0x00001970
		private static byte[] Randomize(global::fxpcommunication.RandomizationEnum randomizeType, byte[] source, global::System.Random randGenerator)
		{
			byte[] array;
			if (randomizeType <= global::fxpcommunication.RandomizationEnum.eKxxKxx)
			{
				if (randomizeType <= global::fxpcommunication.RandomizationEnum.exKxK)
				{
					if (randomizeType != global::fxpcommunication.RandomizationEnum.eNoRandom)
					{
						if (randomizeType == global::fxpcommunication.RandomizationEnum.exKxK)
						{
							return global::fxpcommunication.FxpMessage.Randomize(1, false, source, randGenerator);
						}
					}
				}
				else
				{
					if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxKx)
					{
						return global::fxpcommunication.FxpMessage.Randomize(1, true, source, randGenerator);
					}
					if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxxKxx)
					{
						return global::fxpcommunication.FxpMessage.Randomize(2, true, source, randGenerator);
					}
				}
			}
			else if (randomizeType <= global::fxpcommunication.RandomizationEnum.eKxxxKxxx)
			{
				if (randomizeType == global::fxpcommunication.RandomizationEnum.exxKxxK)
				{
					return global::fxpcommunication.FxpMessage.Randomize(2, false, source, randGenerator);
				}
				if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxxxKxxx)
				{
					return global::fxpcommunication.FxpMessage.Randomize(3, true, source, randGenerator);
				}
			}
			else
			{
				if (randomizeType == global::fxpcommunication.RandomizationEnum.exxxKxxxK)
				{
					return global::fxpcommunication.FxpMessage.Randomize(3, false, source, randGenerator);
				}
				if (randomizeType == global::fxpcommunication.RandomizationEnum.e128xK)
				{
					array = new byte[128 + source.Length];
					randGenerator.NextBytes(array);
					global::System.Array.Copy(source, 0, array, 128, source.Length);
					return array;
				}
			}
			array = global::fxpcommunication.FxpMessage.Randomize(0, true, source, randGenerator);
			return array;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003868 File Offset: 0x00001A68
		private static byte[] Randomize(int interval, bool startWithK, byte[] source, global::System.Random randGenerator)
		{
			int num = source.Length * (interval + 1);
			byte[] array = new byte[num];
			randGenerator.NextBytes(array);
			int num2 = startWithK ? 0 : interval;
			for (int i = 0; i < source.Length; i++)
			{
				int num3 = i * (interval + 1) + num2;
				array[num3] = source[i];
			}
			return array;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000038C4 File Offset: 0x00001AC4
		private static byte[] Derandomize(global::fxpcommunication.RandomizationEnum randomizeType, byte[] randomizedData, int startIndex)
		{
			if (randomizeType <= global::fxpcommunication.RandomizationEnum.eKxxKxx)
			{
				if (randomizeType <= global::fxpcommunication.RandomizationEnum.exKxK)
				{
					if (randomizeType != global::fxpcommunication.RandomizationEnum.eNoRandom)
					{
						if (randomizeType == global::fxpcommunication.RandomizationEnum.exKxK)
						{
							return global::fxpcommunication.FxpMessage.Derandomize(1, false, randomizedData, startIndex);
						}
					}
				}
				else
				{
					if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxKx)
					{
						return global::fxpcommunication.FxpMessage.Derandomize(1, true, randomizedData, startIndex);
					}
					if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxxKxx)
					{
						return global::fxpcommunication.FxpMessage.Derandomize(2, true, randomizedData, startIndex);
					}
				}
			}
			else if (randomizeType <= global::fxpcommunication.RandomizationEnum.eKxxxKxxx)
			{
				if (randomizeType == global::fxpcommunication.RandomizationEnum.exxKxxK)
				{
					return global::fxpcommunication.FxpMessage.Derandomize(2, false, randomizedData, startIndex);
				}
				if (randomizeType == global::fxpcommunication.RandomizationEnum.eKxxxKxxx)
				{
					return global::fxpcommunication.FxpMessage.Derandomize(3, true, randomizedData, startIndex);
				}
			}
			else
			{
				if (randomizeType == global::fxpcommunication.RandomizationEnum.exxxKxxxK)
				{
					return global::fxpcommunication.FxpMessage.Derandomize(3, false, randomizedData, startIndex);
				}
				if (randomizeType == global::fxpcommunication.RandomizationEnum.e128xK)
				{
					return global::fxpcommunication.FxpMessage.Derandomize(0, true, randomizedData, startIndex + 128);
				}
			}
			return global::fxpcommunication.FxpMessage.Derandomize(0, true, randomizedData, startIndex);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000039A4 File Offset: 0x00001BA4
		private static byte[] Derandomize(int interval, bool startWithK, byte[] randomizedData, int startIndex)
		{
			int num = randomizedData.Length - startIndex;
			if (num < 0 || num % (interval + 1) != 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_ACKDERAND_ERROR);
			}
			int num2 = num / (interval + 1);
			byte[] array = new byte[num2];
			int num3 = startWithK ? startIndex : (startIndex + interval);
			for (int i = 0; i < num2; i++)
			{
				int num4 = (interval + 1) * i + num3;
				array[i] = randomizedData[num4];
			}
			return array;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A24 File Offset: 0x00001C24
		private static byte[] Encrypt(global::System.Security.Cryptography.SymmetricAlgorithm iCryptoProvider, byte[] key, byte[] input, global::System.Random randGenerator)
		{
			byte[] result;
			try
			{
				int num = iCryptoProvider.BlockSize / 8;
				int num2 = input.Length % num;
				int num3 = (num2 == 0) ? input.Length : (input.Length + (num - num2));
				byte[] array = new byte[num3];
				randGenerator.NextBytes(array);
				input.CopyTo(array, 0);
				for (int i = 0; i < array.Length; i += num)
				{
					using (global::System.Security.Cryptography.ICryptoTransform cryptoTransform = iCryptoProvider.CreateEncryptor(key, new byte[num]))
					{
						byte[] array2 = cryptoTransform.TransformFinalBlock(array, i, num);
						array2.CopyTo(array, i);
						global::fxpcommunication.FxpMessage.ZeroBuff(array2);
					}
				}
				result = array;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_EN_ERROR);
			}
			return result;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003B00 File Offset: 0x00001D00
		private static byte[] Decrypt(global::System.Security.Cryptography.SymmetricAlgorithm iCryptoProvider, byte[] key, byte[] input, int startIndex)
		{
			byte[] result;
			try
			{
				int num = iCryptoProvider.BlockSize / 8;
				byte[] array = new byte[input.Length - startIndex];
				for (int i = 0; i < array.Length; i += num)
				{
					using (global::System.Security.Cryptography.ICryptoTransform cryptoTransform = iCryptoProvider.CreateDecryptor(key, new byte[num]))
					{
						byte[] array2 = cryptoTransform.TransformFinalBlock(input, i + startIndex, num);
						array2.CopyTo(array, i);
						global::fxpcommunication.FxpMessage.ZeroBuff(array2);
					}
				}
				result = array;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.EXCHANGE_DE_ERROR);
			}
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003BB0 File Offset: 0x00001DB0
		public static ushort FromBigEndianBytes(byte[] data, int index)
		{
			int num = 2;
			ushort result;
			if (data != null && data.Length >= index + num)
			{
				byte[] array = new byte[num];
				global::System.Array.Copy(data, index, array, 0, 2);
				if (global::System.BitConverter.IsLittleEndian)
				{
					global::System.Array.Reverse(array);
				}
				result = global::System.BitConverter.ToUInt16(array, 0);
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003C0C File Offset: 0x00001E0C
		private static byte[] ToBigEndianBytes(ushort val)
		{
			byte[] bytes = global::System.BitConverter.GetBytes(val);
			if (global::System.BitConverter.IsLittleEndian)
			{
				global::System.Array.Reverse(bytes);
			}
			return bytes;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003C3C File Offset: 0x00001E3C
		public static void ZeroBuff(byte[] buff)
		{
			if (buff != null)
			{
				global::System.Array.Clear(buff, 0, buff.Length);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003C60 File Offset: 0x00001E60
		private static byte[] ConcatByteArrays(params byte[][] byteArrays)
		{
			int num = 0;
			foreach (byte[] array in byteArrays)
			{
				if (array != null)
				{
					num += array.Length;
				}
			}
			byte[] result;
			if (num == 0)
			{
				result = null;
			}
			else
			{
				byte[] array2 = new byte[num];
				int num2 = 0;
				foreach (byte[] array in byteArrays)
				{
					if (array != null)
					{
						array.CopyTo(array2, num2);
						num2 += array.Length;
					}
				}
				result = array2;
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003D0C File Offset: 0x00001F0C
		private static global::fxpcommunication.FxpMessage newFxpMessage()
		{
			return new global::fxpcommunication.FxpMessage();
		}

		// Token: 0x04000054 RID: 84
		private global::fxpcommunication.RandomizationEnum randomization = global::fxpcommunication.RandomizationEnum.eNoRandom;

		// Token: 0x04000055 RID: 85
		private global::fxpcommunication.ProtocolVersionEnum protocolVersion = (global::fxpcommunication.ProtocolVersionEnum)0;

		// Token: 0x04000056 RID: 86
		private ushort sequenceNumber = 0;

		// Token: 0x04000057 RID: 87
		private global::fxpcommunication.OperationEnum operation = global::fxpcommunication.OperationEnum.eDiscard;

		// Token: 0x04000058 RID: 88
		private byte[] payload = null;
	}
}
