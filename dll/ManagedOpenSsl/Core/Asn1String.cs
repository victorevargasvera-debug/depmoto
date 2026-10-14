using System;
using System.Runtime.InteropServices;

namespace OpenSSL.Core
{
	// Token: 0x02000005 RID: 5
	public class Asn1String : global::OpenSSL.Core.BaseValueType, global::System.IComparable<global::OpenSSL.Core.Asn1String>
	{
		// Token: 0x06000019 RID: 25 RVA: 0x0000237D File Offset: 0x0000057D
		public Asn1String() : base(global::OpenSSL.Core.Native.ASN1_STRING_type_new(4), true)
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000238C File Offset: 0x0000058C
		internal Asn1String(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002396 File Offset: 0x00000596
		public Asn1String(byte[] data) : this()
		{
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.ASN1_STRING_set(this.ptr, data, data.Length));
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000023B3 File Offset: 0x000005B3
		public int Length
		{
			get
			{
				return global::OpenSSL.Core.Native.ASN1_STRING_length(this.ptr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000023C0 File Offset: 0x000005C0
		public byte[] Data
		{
			get
			{
				global::System.IntPtr source = global::OpenSSL.Core.Native.ASN1_STRING_data(this.ptr);
				byte[] array = new byte[this.Length];
				global::System.Runtime.InteropServices.Marshal.Copy(source, array, 0, array.Length);
				return array;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000023F1 File Offset: 0x000005F1
		internal override global::System.IntPtr DuplicateHandle()
		{
			return global::OpenSSL.Core.Native.ASN1_STRING_dup(this.ptr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000023FE File Offset: 0x000005FE
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.ASN1_STRING_free(this.ptr);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000240B File Offset: 0x0000060B
		public int CompareTo(global::OpenSSL.Core.Asn1String other)
		{
			return global::OpenSSL.Core.Native.ASN1_STRING_cmp(this.ptr, other.Handle);
		}
	}
}
