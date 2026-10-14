using System;
using System.IO;
using System.Text;
using OpenSSL.Crypto;

namespace OpenSSL.Core
{
	// Token: 0x0200000B RID: 11
	public class BIO : global::OpenSSL.Core.Base
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00002860 File Offset: 0x00000A60
		internal BIO(global::System.IntPtr ptr, bool owner) : base(ptr, owner)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000286A File Offset: 0x00000A6A
		public BIO(byte[] buf) : base(global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_new_mem_buf(buf, buf.Length)), true)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002881 File Offset: 0x00000A81
		public BIO(string str) : this(global::System.Text.Encoding.ASCII.GetBytes(str))
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002894 File Offset: 0x00000A94
		public static global::OpenSSL.Core.BIO MemoryBuffer(bool takeOwnership)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_new(global::OpenSSL.Core.Native.BIO_s_mem()));
			return new global::OpenSSL.Core.BIO(ptr, takeOwnership);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000028B8 File Offset: 0x00000AB8
		public static global::OpenSSL.Core.BIO MemoryBuffer()
		{
			return global::OpenSSL.Core.BIO.MemoryBuffer(true);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000028C0 File Offset: 0x00000AC0
		public static global::OpenSSL.Core.BIO File(string filename, string mode)
		{
			global::System.IntPtr ptr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_new_file(filename, mode));
			return new global::OpenSSL.Core.BIO(ptr, true);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000028E4 File Offset: 0x00000AE4
		public static global::OpenSSL.Core.BIO MessageDigest(global::OpenSSL.Crypto.MessageDigest md)
		{
			global::System.IntPtr intPtr = global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_new(global::OpenSSL.Core.Native.BIO_f_md()));
			global::OpenSSL.Core.Native.BIO_set_md(intPtr, md.Handle);
			return new global::OpenSSL.Core.BIO(intPtr, true);
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002914 File Offset: 0x00000B14
		public uint NumberRead
		{
			get
			{
				return global::OpenSSL.Core.Native.BIO_number_read(this.Handle);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002921 File Offset: 0x00000B21
		public uint NumberWritten
		{
			get
			{
				return global::OpenSSL.Core.Native.BIO_number_written(this.Handle);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000292E File Offset: 0x00000B2E
		public uint BytesPending
		{
			get
			{
				return global::OpenSSL.Core.Native.BIO_ctrl_pending(this.Handle);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000293B File Offset: 0x00000B3B
		public void SetClose(global::OpenSSL.Core.BIO.CloseOption opt)
		{
			global::OpenSSL.Core.Native.BIO_set_close(this.ptr, (int)opt);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000294A File Offset: 0x00000B4A
		public void Push(global::OpenSSL.Core.BIO bio)
		{
			global::OpenSSL.Core.Native.ExpectNonNull(global::OpenSSL.Core.Native.BIO_push(this.ptr, bio.Handle));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002963 File Offset: 0x00000B63
		public void Write(byte[] buf)
		{
			if (global::OpenSSL.Core.Native.BIO_write(this.ptr, buf, buf.Length) != buf.Length)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000297F File Offset: 0x00000B7F
		public void Write(byte[] buf, int len)
		{
			if (global::OpenSSL.Core.Native.BIO_write(this.ptr, buf, len) != len)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002998 File Offset: 0x00000B98
		public void Write(byte value)
		{
			this.Write(new byte[]
			{
				value
			});
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000029B8 File Offset: 0x00000BB8
		public void Write(ushort value)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(memoryStream);
			binaryWriter.Write(value);
			byte[] buf = memoryStream.ToArray();
			this.Write(buf);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000029E8 File Offset: 0x00000BE8
		public void Write(uint value)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(memoryStream);
			binaryWriter.Write(value);
			byte[] buf = memoryStream.ToArray();
			this.Write(buf);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002A18 File Offset: 0x00000C18
		public void Write(string str)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(str);
			if (global::OpenSSL.Core.Native.BIO_puts(this.ptr, bytes) != bytes.Length)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002A48 File Offset: 0x00000C48
		public global::System.ArraySegment<byte> ReadBytes(int count)
		{
			byte[] array = new byte[count];
			int num = global::OpenSSL.Core.Native.BIO_read(this.ptr, array, array.Length);
			if (num < 0)
			{
				throw new global::OpenSSL.Core.OpenSslException();
			}
			return new global::System.ArraySegment<byte>(array, 0, num);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A80 File Offset: 0x00000C80
		public string ReadString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			byte[] array = new byte[64];
			for (;;)
			{
				int num = global::OpenSSL.Core.Native.BIO_gets(this.ptr, array, array.Length);
				if (num == 0)
				{
					goto IL_43;
				}
				if (num < 0)
				{
					break;
				}
				stringBuilder.Append(global::System.Text.Encoding.ASCII.GetString(array, 0, num));
			}
			throw new global::OpenSSL.Core.OpenSslException();
			IL_43:
			return stringBuilder.ToString();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002AD6 File Offset: 0x00000CD6
		public global::OpenSSL.Crypto.MessageDigestContext GetMessageDigestContext()
		{
			return new global::OpenSSL.Crypto.MessageDigestContext(this);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002ADE File Offset: 0x00000CDE
		protected override void OnDispose()
		{
			global::OpenSSL.Core.Native.BIO_free(this.ptr);
		}

		// Token: 0x04000009 RID: 9
		private const int FD_STDIN = 0;

		// Token: 0x0400000A RID: 10
		private const int FD_STDOUT = 1;

		// Token: 0x0400000B RID: 11
		private const int FD_STDERR = 2;

		// Token: 0x0200000C RID: 12
		public enum CloseOption
		{
			// Token: 0x0400000D RID: 13
			NoClose,
			// Token: 0x0400000E RID: 14
			Close
		}
	}
}
