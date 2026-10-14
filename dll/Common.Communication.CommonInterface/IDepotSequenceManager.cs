using System;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000B RID: 11
	public interface IDepotSequenceManager
	{
		// Token: 0x0600005D RID: 93
		void ForceWriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID);

		// Token: 0x0600005E RID: 94
		void UpdateSerialNumber(string serialNumber);

		// Token: 0x0600005F RID: 95
		void UnkillRadio(byte[] authenticationValue);

		// Token: 0x06000060 RID: 96
		byte[] ReadUnkillChallengeValue();

		// Token: 0x06000061 RID: 97
		void UpdateIMEType(byte ime);

		// Token: 0x06000062 RID: 98
		void UpdateDateCode(byte[] datecode, ushort source);

		// Token: 0x06000063 RID: 99
		void CBIProgramme();
	}
}
