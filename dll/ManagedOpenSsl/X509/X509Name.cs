using System;
using System.Text;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace OpenSSL.X509
{
	// Token: 0x02000087 RID: 135
	public class X509Name : global::OpenSSL.Core.BaseValueType, global::System.IComparable<global::OpenSSL.X509.X509Name>, global::OpenSSL.Core.IStackable
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0000A139 File Offset: 0x00008339
		internal X509Name(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000A143 File Offset: 0x00008343
		public X509Name() : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_NAME_new()), true)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000A156 File Offset: 0x00008356
		public X509Name(global::OpenSSL.X509.X509Name rhs) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.X509_NAME_dup(rhs.ptr)), true)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000A16F File Offset: 0x0000836F
		internal X509Name(global::OpenSSL.Core.IStack stack, global::System.IntPtr ptr) : base(ptr, true)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000A17C File Offset: 0x0000837C
		public X509Name(string str) : this()
		{
			if (str.IndexOf('/') == -1 && str.IndexOf('=') == -1)
			{
				this.Common = str;
				return;
			}
			string[] array = str.Split(new char[]
			{
				'/'
			});
			foreach (string text in array)
			{
				if (!(text == ""))
				{
					string[] array3 = text.Split(new char[]
					{
						'='
					});
					string name = array3[0];
					string value = array3[1];
					this.AddEntryByName(name, value);
				}
			}
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000A216 File Offset: 0x00008416
		public static implicit operator global::OpenSSL.X509.X509Name(string value)
		{
			return new global::OpenSSL.X509.X509Name(value);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0000A21E File Offset: 0x0000841E
		public string OneLine
		{
			get
			{
				return global::OpenSSL.Core.Native.PtrToStringAnsi(global::OpenSSL.Core.Native.X509_NAME_oneline(this.ptr, null, 0), true);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0000A233 File Offset: 0x00008433
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000A240 File Offset: 0x00008440
		public string Common
		{
			get
			{
				return this.GetTextByName("CN");
			}
			set
			{
				this.AddEntryByName("CN", value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0000A24E File Offset: 0x0000844E
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x0000A25B File Offset: 0x0000845B
		public string Country
		{
			get
			{
				return this.GetTextByName("C");
			}
			set
			{
				this.AddEntryByName("C", value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0000A269 File Offset: 0x00008469
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0000A276 File Offset: 0x00008476
		public string Locality
		{
			get
			{
				return this.GetTextByName("L");
			}
			set
			{
				this.AddEntryByName("L", value);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000A284 File Offset: 0x00008484
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000A291 File Offset: 0x00008491
		public string StateOrProvince
		{
			get
			{
				return this.GetTextByName("ST");
			}
			set
			{
				this.AddEntryByName("ST", value);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0000A29F File Offset: 0x0000849F
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0000A2AC File Offset: 0x000084AC
		public string Organization
		{
			get
			{
				return this.GetTextByName("O");
			}
			set
			{
				this.AddEntryByName("O", value);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0000A2BA File Offset: 0x000084BA
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000A2C7 File Offset: 0x000084C7
		public string OrganizationUnit
		{
			get
			{
				return this.GetTextByName("OU");
			}
			set
			{
				this.AddEntryByName("OU", value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0000A2D5 File Offset: 0x000084D5
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0000A2E2 File Offset: 0x000084E2
		public string Given
		{
			get
			{
				return this.GetTextByName("G");
			}
			set
			{
				this.AddEntryByName("G", value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000A2FD File Offset: 0x000084FD
		public string Surname
		{
			get
			{
				return this.GetTextByName("S");
			}
			set
			{
				this.AddEntryByName("S", value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000A30B File Offset: 0x0000850B
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000A318 File Offset: 0x00008518
		public string Initials
		{
			get
			{
				return this.GetTextByName("I");
			}
			set
			{
				this.AddEntryByName("I", value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000A326 File Offset: 0x00008526
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0000A333 File Offset: 0x00008533
		public string UniqueIdentifier
		{
			get
			{
				return this.GetTextByName("UID");
			}
			set
			{
				this.AddEntryByName("UID", value);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0000A341 File Offset: 0x00008541
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0000A34E File Offset: 0x0000854E
		public string SerialNumber
		{
			get
			{
				return this.GetTextByName("SN");
			}
			set
			{
				this.AddEntryByName("SN", value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0000A35C File Offset: 0x0000855C
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0000A369 File Offset: 0x00008569
		public string Title
		{
			get
			{
				return this.GetTextByName("T");
			}
			set
			{
				this.AddEntryByName("T", value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000A377 File Offset: 0x00008577
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0000A384 File Offset: 0x00008584
		public string Description
		{
			get
			{
				return this.GetTextByName("D");
			}
			set
			{
				this.AddEntryByName("D", value);
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000A392 File Offset: 0x00008592
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0000A39F File Offset: 0x0000859F
		public string X509
		{
			get
			{
				return this.GetTextByName("X509");
			}
			set
			{
				this.AddEntryByName("X509", value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000A3AD File Offset: 0x000085AD
		public int Count
		{
			get
			{
				return global::OpenSSL.Core.Native.X509_NAME_entry_count(this.ptr);
			}
		}

		// Token: 0x170000E8 RID: 232
		public string this[string name]
		{
			get
			{
				return this.GetTextByName(name);
			}
			set
			{
				this.AddEntryByName(name, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		public string this[int index]
		{
			get
			{
				global::OpenSSL.Core.Native.X509_NAME_get_entry(this.ptr, index);
				return null;
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000A3DD File Offset: 0x000085DD
		public void AddEntryByName(string name, string value)
		{
			this.AddEntryByNid(global::OpenSSL.Core.Native.TextToNID(name), value);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000A3EC File Offset: 0x000085EC
		public void AddEntryByNid(int nid, string value)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(value);
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_NAME_add_entry_by_NID(this.ptr, nid, 4097, bytes, bytes.Length, -1, 0));
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000A424 File Offset: 0x00008624
		public string GetTextByNid(int nid)
		{
			if (this.GetIndexByNid(nid, -1) == -1)
			{
				return null;
			}
			byte[] array = new byte[1024];
			int num = global::OpenSSL.Core.Native.X509_NAME_get_text_by_NID(this.ptr, nid, array, array.Length);
			if (num <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return global::System.Text.Encoding.ASCII.GetString(array, 0, num);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000A471 File Offset: 0x00008671
		public string GetTextByName(string name)
		{
			return this.GetTextByNid(global::OpenSSL.Core.Native.TextToNID(name));
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000A480 File Offset: 0x00008680
		public int GetIndexByNid(int nid, int lastpos)
		{
			int num = global::OpenSSL.Core.Native.X509_NAME_get_index_by_NID(this.ptr, nid, lastpos);
			if (num == lastpos)
			{
				return lastpos;
			}
			if (num < 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return num;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000A4AC File Offset: 0x000086AC
		public int IndexOf(string name, int lastpos)
		{
			return this.GetIndexByNid(global::OpenSSL.Core.Native.TextToNID(name), lastpos);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000A4BB File Offset: 0x000086BB
		public int IndexOf(string name)
		{
			return this.IndexOf(name, -1);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000A4C5 File Offset: 0x000086C5
		public bool Contains(string name)
		{
			return this.IndexOf(name) >= 0;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public global::System.ArraySegment<byte> Digest(global::OpenSSL.Crypto.MessageDigest type, int cbSize)
		{
			byte[] array = new byte[cbSize];
			uint count = (uint)cbSize;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.X509_NAME_digest(this.ptr, type.Handle, array, ref count));
			return new global::System.ArraySegment<byte>(array, 0, (int)count);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000A50C File Offset: 0x0000870C
		public override void Print(global::OpenSSL.Core.BIO bio)
		{
			int num = global::OpenSSL.Core.Native.X509_NAME_print_ex(bio.Handle, this.Handle, 0, 66335U);
			if (num <= 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000A53B File Offset: 0x0000873B
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.X509_NAME_free(this.ptr);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000A548 File Offset: 0x00008748
		internal override global::System.IntPtr DuplicateHandle()
		{
			return global::OpenSSL.Core.Native.X509_NAME_dup(this.ptr);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000A558 File Offset: 0x00008758
		public override bool Equals(object rhs)
		{
			global::OpenSSL.X509.X509Name x509Name = rhs as global::OpenSSL.X509.X509Name;
			return x509Name != null && this.CompareTo(x509Name) == 0;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000A57B File Offset: 0x0000877B
		public override int GetHashCode()
		{
			return this.ToString().GetHashCode();
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000A588 File Offset: 0x00008788
		public int CompareTo(global::OpenSSL.X509.X509Name other)
		{
			return global::OpenSSL.Core.Native.X509_NAME_cmp(this.ptr, other.ptr);
		}
	}
}
