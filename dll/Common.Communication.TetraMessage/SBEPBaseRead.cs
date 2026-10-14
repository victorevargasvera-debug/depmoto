using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	public abstract class SBEPBaseRead : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x060000F5 RID: 245 RVA: 0x00005E47 File Offset: 0x00004047
		protected SBEPBaseRead()
		{
			this._myActualReadLength = 0;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00005E58 File Offset: 0x00004058
		public override void ExecuteMessage()
		{
			bool flag = true;
			ushort uOpCode = 0;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.BaseBuildCommandMessage();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag && !base.Executor.OpenPort())
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_CANNOT_OPEN_PIPE;
			}
			if (flag)
			{
				tetraMsgOpResult = base.Executor.SendRequest(true, base.MyCommandBuffer, true, out this._myReplyMessageBuffer);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.Get_uOpCode(this._myReplyMessageBuffer, out uOpCode);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				tetraMsgOpResult = this.ParseReplyMessage(this._myReplyMessageBuffer, uOpCode);
			}
			base.OperationResult = tetraMsgOpResult;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00005EE0 File Offset: 0x000040E0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			ushort value = 62737;
			int num = 3;
			int num2 = 1;
			bool flag = true;
			if (this._myExpectedReadLength <= 0)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (flag && (base.OperationFlag & 1U) > 0U)
			{
				num = 4;
				num2 = 2;
				value = 63297;
			}
			if (flag && (2U & base.OperationFlag) > 0U)
			{
				this._myExpectedReadLength = 0;
			}
			int num3 = 2 + num2 + num;
			if (base.AddCheckSum)
			{
				base.MyCommandBuffer = new byte[num3 + 1];
			}
			else
			{
				base.MyCommandBuffer = new byte[num3];
			}
			if (flag)
			{
				byte[] bytes = global::System.BitConverter.GetBytes(value);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 0, bytes, 0, 2);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
				if (flag)
				{
					bytes = global::System.BitConverter.GetBytes(this._myExpectedReadLength);
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 2, bytes, 0, num2);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
				}
				if (flag)
				{
					bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 2 + num2, bytes, 0, num);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
				}
				if (flag && base.AddCheckSum)
				{
					global::Motorola.Common.Communication.SBEPCommon.AddCheckSum(base.MyCommandBuffer);
				}
			}
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00006008 File Offset: 0x00004208
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			ushort num = 3;
			bool flag2 = true;
			if (buffer == null || buffer.Length <= 2)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (flag)
			{
				if (uOpCode != 61830)
				{
					if (uOpCode == 65408 || uOpCode == 65456)
					{
						if (uOpCode == 65456)
						{
							num += 1;
						}
						byte[] bytes = global::System.BitConverter.GetBytes(this._myActualReadLength);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 2, 2);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							this._myActualReadLength = global::System.BitConverter.ToUInt16(bytes, 0);
							this._myActualReadLength -= num + 1;
							this._myStartAddress = 0U;
						}
						else
						{
							flag = false;
							flag2 = false;
						}
						if (flag)
						{
							bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
							tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 4, (int)num);
							if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
							{
								this._myStartAddress = global::System.BitConverter.ToUInt32(bytes, 0);
							}
							else
							{
								flag2 = false;
							}
						}
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNKNOWN_REPLY;
					}
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_REPLY;
				}
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
				if (flag)
				{
					int sourceIndex;
					if (uOpCode == 65456)
					{
						sourceIndex = 8;
					}
					else
					{
						sourceIndex = 7;
					}
					if (this._myReplyMessageBuffer.Length < (int)this._myActualReadLength)
					{
						flag = false;
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_INSUFFICIENT_BUFFER;
					}
					if (flag)
					{
						byte[] array = new byte[(int)this._myActualReadLength];
						global::System.Array.Copy(buffer, sourceIndex, array, 0, (int)this._myActualReadLength);
						this._myReplyMessageBuffer = array;
					}
				}
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS && flag2)
				{
					base.LogStatusInformation("SBEPBaseRead");
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000615C File Offset: 0x0000435C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00006164 File Offset: 0x00004364
		protected uint InternalStartAddress
		{
			get
			{
				return this._myStartAddress;
			}
			set
			{
				this._myStartAddress = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000616D File Offset: 0x0000436D
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00006175 File Offset: 0x00004375
		protected ushort ExpectedReadLength
		{
			get
			{
				return this._myExpectedReadLength;
			}
			set
			{
				this._myExpectedReadLength = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000617E File Offset: 0x0000437E
		protected byte[] ReceivedData
		{
			get
			{
				return this._myReplyMessageBuffer;
			}
		}

		// Token: 0x04000056 RID: 86
		private uint _myStartAddress;

		// Token: 0x04000057 RID: 87
		private ushort _myExpectedReadLength;

		// Token: 0x04000058 RID: 88
		private ushort _myActualReadLength;
	}
}
