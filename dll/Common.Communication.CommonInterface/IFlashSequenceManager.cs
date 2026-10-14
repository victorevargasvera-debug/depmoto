using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000C RID: 12
	public interface IFlashSequenceManager
	{
		// Token: 0x06000064 RID: 100
		void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID);

		// Token: 0x06000065 RID: 101
		void ValidateUpdate();

		// Token: 0x06000066 RID: 102
		bool WriteRamdownloader(string filepath);

		// Token: 0x06000067 RID: 103
		global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images);
	}
}
