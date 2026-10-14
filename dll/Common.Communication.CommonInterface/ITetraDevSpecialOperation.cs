using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public interface ITetraDevSpecialOperation : global::System.IDisposable
	{
		// Token: 0x060000C6 RID: 198
		void WriteSoftware(string swFilePath);

		// Token: 0x060000C7 RID: 199
		global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks();

		// Token: 0x060000C8 RID: 200
		byte[] ReadCPData(string blockID, uint offset, ushort size);

		// Token: 0x060000C9 RID: 201
		void GeneralOperation(global::Motorola.Common.Communication.Pba.PbaObject pbaObj);
	}
}
