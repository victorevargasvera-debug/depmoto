using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public class AstroOtapCpsSequenceManager : global::Motorola.Common.Communication.AstroCpsSequenceManager
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x0000814E File Offset: 0x0000634E
		public AstroOtapCpsSequenceManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam) : base(rcmpWrapper, sessionParam)
		{
			this._OtapInactivityTimer = inactivityTimer;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000816A File Offset: 0x0000636A
		public override void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				this.ExitReadProgramMode();
				return;
			}
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program && !pendingDeploy)
			{
				this.ExitWriteProgramMode();
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008186 File Offset: 0x00006386
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			base.UnlockRadioPartition(212);
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
			{
				this.EnterReadProgramMode();
				return;
			}
			if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
			{
				this.EnterWriteProgramMode();
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000081AC File Offset: 0x000063AC
		protected override void EnterReadProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._OtapInactivityTimer / 256),
				(byte)(this._OtapInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(5, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008200 File Offset: 0x00006400
		protected override void ExitReadProgramMode()
		{
			global::Motorola.Common.Communication.IshHandler.IOController iocontroller = base.IOController;
			byte exit = 6;
			byte[] data = new byte[2];
			iocontroller.ExitProgramMode(exit, data);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008224 File Offset: 0x00006424
		protected override void EnterWriteProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._OtapInactivityTimer / 256),
				(byte)(this._OtapInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008278 File Offset: 0x00006478
		protected override void ExitWriteProgramMode()
		{
			ushort checksum = ((global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
		}

		// Token: 0x04000075 RID: 117
		private int _OtapInactivityTimer = 180;
	}
}
