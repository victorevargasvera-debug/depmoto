using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public abstract class SBEPBaseConfig : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00005A5F File Offset: 0x00003C5F
		protected SBEPBaseConfig()
		{
			this._myBufferSize = 0;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00005A70 File Offset: 0x00003C70
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005AFD File Offset: 0x00003CFD
		protected ushort InternalBufferSize
		{
			get
			{
				return this._myBufferSize;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00005B05 File Offset: 0x00003D05
		protected byte InternalReservedParam
		{
			get
			{
				return this._myReservedParam;
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005B10 File Offset: 0x00003D10
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			ushort value = 61715;
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

		// Token: 0x060000EF RID: 239 RVA: 0x00005B88 File Offset: 0x00003D88
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
					if (uOpCode == 62594)
					{
						byte[] bytes = global::System.BitConverter.GetBytes(this._myBufferSize);
						tetraMsgOpResult = global::Motorola.Common.Communication.SBEPCommon.ReverseBytesAndCopy(bytes, 0, buffer, 2, 2);
						if (tetraMsgOpResult == global::Motorola.Common.Communication.TetraMsgOpResult.SBEP_SUCCESS)
						{
							this._myBufferSize = global::System.BitConverter.ToUInt16(bytes, 0);
							this._myReservedParam = buffer[4];
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
					base.LogStatusInformation("SBEPBaseConfig");
				}
				base.OperationResult = tetraMsgOpResult;
			}
			return tetraMsgOpResult;
		}

		// Token: 0x04000053 RID: 83
		private ushort _myBufferSize;

		// Token: 0x04000054 RID: 84
		private byte _myReservedParam;
	}
}
