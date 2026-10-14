using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001C RID: 28
	public abstract class SBEPBaseZeroFlash : global::Motorola.Common.Communication.SBEPBaseMessage
	{
		// Token: 0x0600010C RID: 268 RVA: 0x0000680C File Offset: 0x00004A0C
		public override void ExecuteMessage()
		{
			bool flag = true;
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
				byte[] array = new byte[1];
				tetraMsgOpResult = base.Executor.SendRequest(true, base.MyCommandBuffer, base.hasReply, out array);
			}
			base.OperationResult = tetraMsgOpResult;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000686C File Offset: 0x00004A6C
		protected override global::Motorola.Common.Communication.TetraMsgOpResult BaseBuildCommandMessage()
		{
			bool flag = true;
			ushort value = 61718;
			if ((base.OperationFlag & 1U) > 0U)
			{
				value = 61766;
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
	}
}
