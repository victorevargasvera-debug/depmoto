using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public interface ITetraSeqMgrSpecialOperation : global::System.IDisposable
	{
		// Token: 0x060000CA RID: 202
		void SwitchModeNoWait(global::Motorola.Common.Communication.CommonUtil.DeviceMode mode);

		// Token: 0x060000CB RID: 203
		void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.TetraGeneralCommandCode commandCode, byte[] inputBuffer, out byte[] outputBuffer);

		// Token: 0x060000CC RID: 204
		void WriteSoftware(string swPath, bool bResetProgress = true);

		// Token: 0x060000CD RID: 205
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks();

		// Token: 0x060000CE RID: 206
		byte[] ReadCPData(string blockID, uint offset, ushort size);

		// Token: 0x060000CF RID: 207
		bool IsLLPAvailable();

		// Token: 0x060000D0 RID: 208
		bool TurnOffRadio();

		// Token: 0x060000D1 RID: 209
		void UpgradeFlashStrap(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool bResetProgress = true);

		// Token: 0x060000D2 RID: 210
		void EraseRadioFromTo(uint startAddress, uint size, bool bForceErase = false);

		// Token: 0x060000D3 RID: 211
		global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageWithProgressUpdate(string address, uint size);

		// Token: 0x060000D4 RID: 212
		void WriteImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status = global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteImage, bool bResetProgress = false);

		// Token: 0x060000D5 RID: 213
		global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.FDTType fdtType);

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000D6 RID: 214
		// (set) Token: 0x060000D7 RID: 215
		string CpuID { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D8 RID: 216
		// (set) Token: 0x060000D9 RID: 217
		global::Motorola.Common.Communication.IRadioProfile Profile { get; set; }

		// Token: 0x060000DA RID: 218
		void Invalidate(bool onlyCPInfo);

		// Token: 0x060000DB RID: 219
		void EraseRadio(global::System.Collections.Generic.List<string> sections);

		// Token: 0x060000DC RID: 220
		void WaitForCancelReading();
	}
}
