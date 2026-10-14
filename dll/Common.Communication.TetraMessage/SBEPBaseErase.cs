using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000018 RID: 24
	public abstract class SBEPBaseErase : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00005C1B File Offset: 0x00003E1B
		protected SBEPBaseErase()
		{
			this._myAddressInfo = 0U;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00005C2C File Offset: 0x00003E2C
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

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005CB6 File Offset: 0x00003EB6
		protected uint InternalAddressInfo
		{
			get
			{
				return this._myAddressInfo;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005CC0 File Offset: 0x00003EC0
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			ushort value = 61717;
			if ((base.OperationFlag & 1U) > 0U)
			{
				value = 61765;
			}
			if (base.AddCheckSum)
			{
				base.MyCommandBuffer = new byte[3];
			}
			else
			{
				base.MyCommandBuffer = new byte[2];
			}
			byte[] bytes = global::System.BitConverter.GetBytes(value);
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 0, bytes, 0, 2);
			if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
			{
				flag = false;
			}
			if (flag && base.AddCheckSum)
			{
				global::Motorola.Common.Communication.SBEPCommon.AddCheckSum(base.MyCommandBuffer);
			}
			base.OperationResult = tetraMsgOpResult;
			return tetraMsgOpResult;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005D48 File Offset: 0x00003F48
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			int num = 3;
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
					switch (uOpCode)
					{
					case 62596:
					case 62597:
						break;
					default:
						switch (uOpCode)
						{
						case 62900:
						case 62901:
							break;
						default:
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNKNOWN_REPLY;
							goto IL_D8;
						}
						break;
					}
					if (uOpCode == 62900 || uOpCode == 62901)
					{
						num++;
					}
					if (uOpCode == 62900 || uOpCode == 62596)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS;
					}
					else if (uOpCode == 62901 || uOpCode == 62597)
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_BAD_WRITE_REPLY;
						flag = false;
					}
					else
					{
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNDEFINED_WRITE_REPLY;
						flag = false;
					}
					if (flag)
					{
						byte[] bytes = global::System.BitConverter.GetBytes(this._myAddressInfo);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 2, num);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							this._myAddressInfo = global::System.BitConverter.ToUInt32(bytes, 0);
						}
						else
						{
							flag2 = false;
						}
					}
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_REPLY;
				}
				IL_D8:
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS && flag2)
				{
					base.LogStatusInformation("SBEPBaseErase");
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x04000055 RID: 85
		private uint _myAddressInfo;
	}
}
