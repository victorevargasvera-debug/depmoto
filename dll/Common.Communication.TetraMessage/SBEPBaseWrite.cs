using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001B RID: 27
	public abstract class SBEPBaseWrite : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x06000105 RID: 261 RVA: 0x000064A8 File Offset: 0x000046A8
		public override void ExecuteMessage()
		{
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			bool flag = true;
			ushort uOpCode = 0;
			if (base.InternalDataToWrite == null)
			{
				flag = false;
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
			}
			if (flag)
			{
				tetraMsgOpResult = this.BaseBuildCommandMessage();
			}
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00006545 File Offset: 0x00004745
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000654D File Offset: 0x0000474D
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

		// Token: 0x06000108 RID: 264 RVA: 0x00006558 File Offset: 0x00004758
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			if (base.InternalDataToWrite == null)
			{
				tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
				flag = false;
			}
			if (flag)
			{
				if (base.AddCheckSum)
				{
					if ((base.OperationFlag & 1U) > 0U)
					{
						if (base.InternalDataToWrite.Length > 65526)
						{
							flag = false;
							tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
						}
					}
					else if (base.InternalDataToWrite.Length > 65527)
					{
						flag = false;
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
					}
				}
				else if ((base.OperationFlag & 1U) > 0U)
				{
					if (base.InternalDataToWrite.Length > 65527)
					{
						flag = false;
						tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
					}
				}
				else if (base.InternalDataToWrite.Length > 65528)
				{
					flag = false;
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_WRONG_PARAMETER;
				}
			}
			if (flag)
			{
				ushort num = (ushort)(base.InternalDataToWrite.Length + 2 + 2 + 3);
				ushort value = 65303;
				int num2 = 3;
				if ((base.OperationFlag & 1U) > 0U)
				{
					num += 1;
					num2++;
					value = 65351;
				}
				ushort value2;
				if (base.AddCheckSum)
				{
					value2 = (ushort)(base.InternalDataToWrite.Length + num2 + 1);
					base.MyCommandBuffer = new byte[(int)(num + 1)];
				}
				else
				{
					value2 = (ushort)(base.InternalDataToWrite.Length + num2);
					base.MyCommandBuffer = new byte[(int)num];
				}
				byte[] bytes = global::System.BitConverter.GetBytes(value);
				tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 0, bytes, 0, 2);
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
					flag = false;
				}
				if (flag)
				{
					bytes = global::System.BitConverter.GetBytes(value2);
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 2, bytes, 0, 2);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
				}
				if (flag)
				{
					bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
					tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(base.MyCommandBuffer, 4, bytes, 0, num2);
					if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
					{
						flag = false;
					}
				}
				if (flag)
				{
					int destinationIndex = 4 + num2;
					global::System.Array.Copy(base.InternalDataToWrite, 0, base.MyCommandBuffer, destinationIndex, base.InternalDataToWrite.Length);
					if (base.AddCheckSum)
					{
						global::Motorola.Common.Communication.SBEPCommon.AddCheckSum(base.MyCommandBuffer);
					}
				}
			}
			return tetraMsgOpResult;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00006710 File Offset: 0x00004910
		protected override global::Motorola.Common.Communication.TetraMsgOpResult ParseReplyMessage(byte[] buffer, ushort uOpCode)
		{
			bool flag = true;
			global::Motorola.Common.Communication.TetraMsgOpResult tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.Undefined;
			int num = 3;
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
						byte[] bytes = global::System.BitConverter.GetBytes(this._myStartAddress);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 2, num);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							this._myStartAddress = global::System.BitConverter.ToUInt32(bytes, 0);
						}
					}
				}
				else
				{
					tetraMsgOpResult = global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_UNSUPPORTED_REPLY;
				}
				IL_D8:
				if (tetraMsgOpResult != global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
				{
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x0600010A RID: 266
		protected abstract global::Motorola.Common.Communication.TetraMsgOpResult BuildWriteMessageBuffer();

		// Token: 0x0400005B RID: 91
		private uint _myStartAddress;
	}
}
