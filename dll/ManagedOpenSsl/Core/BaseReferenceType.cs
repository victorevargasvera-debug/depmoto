using System;
using System.Runtime.InteropServices;

namespace OpenSSL.Core
{
	// Token: 0x02000006 RID: 6
	public abstract class BaseReferenceType : global::OpenSSL.Core.Base
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000241E File Offset: 0x0000061E
		internal BaseReferenceType(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
			this.baseOffset = global::System.Runtime.InteropServices.Marshal.OffsetOf(this.RawReferenceType, "references");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002440 File Offset: 0x00000640
		internal override void AddRef()
		{
			global::System.IntPtr referencesOffset = this.GetReferencesOffset();
			global::OpenSSL.Core.Native.CRYPTO_add_lock(referencesOffset, 1, this.LockType, "Base.cs", 0);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002468 File Offset: 0x00000668
		public void PrintRefCount()
		{
			global::System.IntPtr referencesOffset = this.GetReferencesOffset();
			int num = global::System.Runtime.InteropServices.Marshal.ReadInt32(referencesOffset);
			global::System.Console.WriteLine("{0} ptr: {1}, ref_count: {2}", base.GetType().Name, this.ptr, num);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024A9 File Offset: 0x000006A9
		private global::System.IntPtr GetReferencesOffset()
		{
			return new global::System.IntPtr((long)this.ptr + (long)this.baseOffset);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000025 RID: 37
		internal abstract global::OpenSSL.Core.CryptoLockTypes LockType { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38
		internal abstract global::System.Type RawReferenceType { get; }

		// Token: 0x04000004 RID: 4
		private global::System.IntPtr baseOffset;
	}
}
