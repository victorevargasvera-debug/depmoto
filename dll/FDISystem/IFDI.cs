using System;

namespace FDISystem
{
	// Token: 0x02000003 RID: 3
	public interface IFDI : global::System.IDisposable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001C6 RID: 454
		byte[] FDIRawStream { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001C7 RID: 455
		int UnitGranularity { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060001C8 RID: 456
		global::FDISystem.FDIVersion Version { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001C9 RID: 457
		uint MaxBlocks { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060001CA RID: 458
		uint Blocks { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060001CB RID: 459
		uint BlockSize { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060001CC RID: 460
		global::FDISystem.ByteOrder FDIByteOrder { get; }

		// Token: 0x060001CD RID: 461
		int ValidateFreeSpace();
	}
}
