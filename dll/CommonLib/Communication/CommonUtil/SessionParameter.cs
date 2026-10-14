using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000040 RID: 64
	public class SessionParameter
	{
		// Token: 0x06000209 RID: 521 RVA: 0x00006A9F File Offset: 0x00004C9F
		public SessionParameter(ushort previousSessionID = 0, bool archiveSession = false)
		{
			this.PreviousSessionID = previousSessionID;
			this.ArchiveSession = archiveSession;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00006AB5 File Offset: 0x00004CB5
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00006ABD File Offset: 0x00004CBD
		public ushort PreviousSessionID { get; private set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00006AC6 File Offset: 0x00004CC6
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00006ACE File Offset: 0x00004CCE
		public bool ArchiveSession { get; private set; }
	}
}
