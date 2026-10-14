using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class AstroOtapFileSeqManager : global::Motorola.Common.Communication.AstroFileSeqManager
	{
		// Token: 0x0600008C RID: 140 RVA: 0x000058F0 File Offset: 0x00003AF0
		public AstroOtapFileSeqManager(global::Motorola.Common.Communication.AstroOtapRcmpMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this._OtapInactivityTimer = inactivityTimer;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000590C File Offset: 0x00003B0C
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create)
			{
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					this.EnterReadProgramMode();
				}
				else if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					this.EnterWriteProgramMode();
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("Otap Open Session: " + base.SessionParam.ArchiveSession, new object[0]);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose("DifferentialWriteCapableRadio=" + base.DifferentialWriteCapableRadio, new object[0]);
				if (base.SessionParam.ArchiveSession)
				{
					if (!base.DifferentialWriteCapableRadio)
					{
						ushort num;
						ushort num2;
						base.IOController.ComponentSession(7, sessionID, out num, out num2);
						if (base.IOController.SessionCommandReply.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.InvalidParameter && base.IOController.RetryDifferentialWriteNotSupported)
						{
							base.IOController.ComponentSession(3, sessionID, out num, out num2);
							return;
						}
					}
				}
				else
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(3, sessionID, out num, out num2);
				}
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000059F4 File Offset: 0x00003BF4
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

		// Token: 0x0600008F RID: 143 RVA: 0x00005A48 File Offset: 0x00003C48
		protected override void ExitReadProgramMode()
		{
			global::Motorola.Common.Communication.IshHandler.IOController iocontroller = base.IOController;
			byte exit = 6;
			byte[] data = new byte[2];
			iocontroller.ExitProgramMode(exit, data);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00005A6C File Offset: 0x00003C6C
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

		// Token: 0x06000091 RID: 145 RVA: 0x00005AC0 File Offset: 0x00003CC0
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

		// Token: 0x0400001E RID: 30
		private int _OtapInactivityTimer = 180;
	}
}
