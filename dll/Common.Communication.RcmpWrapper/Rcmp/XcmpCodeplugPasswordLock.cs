using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000009 RID: 9
	public class XcmpCodeplugPasswordLock : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002711 File Offset: 0x00000911
		public byte Policy()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus || this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPair)
			{
				return this.policy;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002731 File Offset: 0x00000931
		public uint AlgorithmID()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				return this.alogorithmID;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002748 File Offset: 0x00000948
		public byte[] Salt()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				return this.salt;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000275F File Offset: 0x0000095F
		public byte ConfigurationLocked()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus)
			{
				return this.configurationLocked;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002776 File Offset: 0x00000976
		public byte RemainingAttempts()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus || this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword)
			{
				return this.remainingAttempts;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002796 File Offset: 0x00000996
		public byte[] OUID()
		{
			if (this.function == global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.PairDevice)
			{
				return this.ouid;
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidProperty);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000027AE File Offset: 0x000009AE
		public XcmpCodeplugPasswordLock(global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction function, string functionData = null)
		{
			base.Opcode = 1127;
			this.function = function;
			this.functionData = functionData;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000027DC File Offset: 0x000009DC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (string.IsNullOrEmpty(this.functionData))
			{
				return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.function
				});
			}
			byte[] array = null;
			global::Motorola.Common.Communication.RcmpCommon.ConstructBCHStringToBytes(this.functionData, ref array);
			return global::Motorola.Common.Communication.RcmpCommon.ConstructBytes(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.function,
				(byte)array.Length,
				array
			});
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002870 File Offset: 0x00000A70
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			base.ReplyResult = global::Motorola.Common.Communication.RcmpCommon.CheckReplyHeader(replyBuffer, offset, base.Opcode | 32768);
			offset += global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize;
			this.function = (global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction)replyBuffer[offset];
			offset++;
			switch (this.function)
			{
			case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.RequestStatus:
			{
				object[] array = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.uintObj,
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset, length - (global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1), array);
				this.policy = (byte)array[0];
				this.alogorithmID = (uint)array[1];
				byte b = (byte)array[2];
				byte[] array2 = (byte[])array[3];
				this.salt = new byte[(int)b];
				if (b > 0)
				{
					if (array2.Length < (int)b)
					{
						throw new global::System.ArgumentOutOfRangeException("saltLength", "salt size is not equal to saltLength");
					}
					global::System.Buffer.BlockCopy(array2, 0, this.salt, 0, (int)b);
				}
				this.configurationLocked = 0;
				if ((int)(b + 1) <= array2.Length)
				{
					this.configurationLocked = array2[(int)b];
				}
				this.remainingAttempts = byte.MaxValue;
				if ((int)(b + 2) <= array2.Length)
				{
					this.remainingAttempts = array2[(int)(b + 1)];
					return;
				}
				break;
			}
			case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPassword:
				this.remainingAttempts = byte.MaxValue;
				if (length - (global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1) > 0)
				{
					object[] array3 = new object[]
					{
						global::Motorola.Common.Communication.RcmpCommon.byteObj
					};
					global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset, length - (global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1), array3);
					this.remainingAttempts = (byte)array3[0];
					return;
				}
				break;
			case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.PairDevice:
			{
				object[] array4 = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj,
					global::Motorola.Common.Communication.RcmpCommon.byteArrayObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset, length - (global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1), array4);
				byte b2 = (byte)array4[0];
				this.ouid = (byte[])array4[1];
				if (this.ouid.Length != (int)b2)
				{
					throw new global::System.ArgumentOutOfRangeException("ouidLength", "ouid size is not equal to ouidLength");
				}
				break;
			}
			case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.UnpairDevice:
				break;
			case global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction.VerifyPair:
			{
				object[] array5 = new object[]
				{
					global::Motorola.Common.Communication.RcmpCommon.byteObj
				};
				global::Motorola.Common.Communication.RcmpCommon.DecodeBytes(replyBuffer, offset, length - (global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize + 1), array5);
				this.policy = (byte)array5[0];
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x04000021 RID: 33
		private global::Motorola.Common.Communication.Rcmp.CodeplugPasswordLockFunction function;

		// Token: 0x04000022 RID: 34
		private string functionData;

		// Token: 0x04000023 RID: 35
		private byte policy;

		// Token: 0x04000024 RID: 36
		private uint alogorithmID;

		// Token: 0x04000025 RID: 37
		private byte[] salt;

		// Token: 0x04000026 RID: 38
		private byte configurationLocked;

		// Token: 0x04000027 RID: 39
		private byte remainingAttempts = byte.MaxValue;

		// Token: 0x04000028 RID: 40
		private byte[] ouid;
	}
}
