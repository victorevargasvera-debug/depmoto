using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.IshHandler;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public class AstroWifiFileSeqManager : global::Motorola.Common.Communication.AstroFileSeqManager
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00005B1F File Offset: 0x00003D1F
		public AstroWifiFileSeqManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, int inactivityTimer, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter) : base(rcmpWrapper, sessionParameter)
		{
			this._WifiInactivityTimer = inactivityTimer;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005B38 File Offset: 0x00003D38
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			base.UnlockRadioPartition(212);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00005B48 File Offset: 0x00003D48
		private void EnterProgramMode(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create && !this._isEnterProgramMode)
			{
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					this.EnterReadProgramMode();
				}
				else if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					this.EnterWriteProgramMode();
				}
				if (base.SessionParam.ArchiveSession && !base.DifferentialWriteCapableRadio)
				{
					ushort num;
					ushort num2;
					base.IOController.ComponentSession(7, sessionID, out num, out num2);
				}
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00005BA0 File Offset: 0x00003DA0
		protected override void EnterReadProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._WifiInactivityTimer / 256),
				(byte)(this._WifiInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(5, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this._isEnterProgramMode = true;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00005BFC File Offset: 0x00003DFC
		protected override void ExitReadProgramMode()
		{
			global::Motorola.Common.Communication.IshHandler.IOController iocontroller = base.IOController;
			byte exit = 6;
			byte[] data = new byte[2];
			iocontroller.ExitProgramMode(exit, data);
			this._isEnterProgramMode = false;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00005C24 File Offset: 0x00003E24
		protected override void EnterWriteProgramMode()
		{
			byte[] data = new byte[]
			{
				(byte)(this._WifiInactivityTimer / 256),
				(byte)(this._WifiInactivityTimer & 255)
			};
			base.IOController.EnterProgramMode(4, data);
			((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).ResetChecksum();
			this._isEnterProgramMode = true;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005C80 File Offset: 0x00003E80
		protected override void ExitWriteProgramMode()
		{
			ushort checksum = ((global::Motorola.Common.Communication.AstroWiFiRcmpMessageExecutor)base.RcmpWrapper).Checksum;
			byte[] data = new byte[]
			{
				(byte)(checksum / 256),
				(byte)(checksum & 255)
			};
			base.IOController.ExitProgramMode(6, data);
			this._isEnterProgramMode = false;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00005CD1 File Offset: 0x00003ED1
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			this.EnterProgramMode(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			return base.ManagedReadDevice(referencePba, sessionID);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword)
		{
			this.EnterProgramMode(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			return base.WriteDevice(writePBA, sessionID, null);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005CF8 File Offset: 0x00003EF8
		public override void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID)
		{
			this.EnterProgramMode(sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			base.ForceWriteDevice(writePBA, sessionID);
		}

		// Token: 0x0400001F RID: 31
		private int _WifiInactivityTimer = 60;

		// Token: 0x04000020 RID: 32
		private bool _isEnterProgramMode;
	}
}
