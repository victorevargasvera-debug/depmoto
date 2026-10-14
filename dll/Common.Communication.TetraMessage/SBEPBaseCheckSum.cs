using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000016 RID: 22
	public abstract class SBEPBaseCheckSum : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x060000E1 RID: 225 RVA: 0x00005820 File Offset: 0x00003A20
		public override void ExecuteMessage()
		{
			bool flag = true;
			ushort uOpCode = 0;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = this.BaseBuildCommandMessage();
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (!base.Executor.OpenPort())
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_CANNOT_OPEN_PIPE;
			}
			if (flag)
			{
				tetraMsgOpResult = base.Executor.SendRequest(true, base.MyCommandBuffer, base.hasReply, out this._myReplyMessageBuffer);
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000058AA File Offset: 0x00003AAA
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000058B2 File Offset: 0x00003AB2
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

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x000058BB File Offset: 0x00003ABB
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x000058C3 File Offset: 0x00003AC3
		protected uint InternalCalculateLength
		{
			get
			{
				return this._myCalcutateLength;
			}
			set
			{
				this._myCalcutateLength = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x000058CC File Offset: 0x00003ACC
		protected ushort InternalCheckSum
		{
			get
			{
				return this._myCheckSumValue;
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000058D4 File Offset: 0x00003AD4
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			ushort value = 62994;
			int num = 3;
			ushort num2 = 2;
			if ((base.OperationFlag & 1U) > 0U)
			{
				num = 4;
				num2 = 4;
				value = 63810;
			}
			int num3 = (int)(2 + num2) + num;
			if (base.AddCheckSum)
			{
				base.MyCommandBuffer = new byte[num3 + 1];
			}
			else
			{
				base.MyCommandBuffer = new byte[num3];
			}
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 0, bytes, 0, 2);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag)
			{
				bytes = global::System.BitConverter.GetBytes(this._myCalcutateLength);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 2, bytes, 0, (int)num2);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag)
			{
				bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, (int)(2 + num2), bytes, 0, num);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
			}
			if (flag && base.AddCheckSum)
			{
				global::Motorola.Common.Communication.SBEPCommon.AddCheckSum(base.MyCommandBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000059C4 File Offset: 0x00003BC4
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
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
					if (uOpCode == 62337 || uOpCode == 62385)
					{
						byte[] bytes = global::System.BitConverter.GetBytes(this._myCheckSumValue);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 2, 2);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							this._myCheckSumValue = global::System.BitConverter.ToUInt16(bytes, 0);
						}
						else
						{
							flag2 = false;
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
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS && flag2)
				{
					base.LogStatusInformation("SBEPBaseCheckSum");
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x04000050 RID: 80
		private uint _myStartAddress;

		// Token: 0x04000051 RID: 81
		private uint _myCalcutateLength;

		// Token: 0x04000052 RID: 82
		private ushort _myCheckSumValue;
	}
}
