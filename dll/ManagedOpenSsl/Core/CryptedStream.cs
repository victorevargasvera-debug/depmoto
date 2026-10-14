using System;
using System.IO;
using OpenSSL.Crypto;

namespace OpenSSL.Core
{
	// Token: 0x0200000E RID: 14
	public class CryptedStream : global::System.IO.FileStream
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00002B48 File Offset: 0x00000D48
		public CryptedStream(string fileName, global::System.IO.FileMode fileMode, global::System.IO.FileAccess fileAccess, byte[] key, byte[] iv) : base(fileName, fileMode, fileAccess, global::System.IO.FileShare.Read)
		{
			this.m_iv = iv;
			this.m_path = fileName;
			this.m_cipherContext = new global::OpenSSL.Crypto.CipherContext(global::OpenSSL.Crypto.Cipher.AES_256_CBC);
			this.m_real_key = this.SetupKey(key);
			this.m_real_iv = this.SetupIV(iv);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public new void Dispose()
		{
			if (this.m_cipherContext != null)
			{
				this.m_cipherContext.Dispose();
				this.m_cipherContext = null;
			}
			base.Dispose();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002BDC File Offset: 0x00000DDC
		public override void Close()
		{
			if (!this.m_firstWriteCall)
			{
				this.m_firstWriteCall = false;
				global::OpenSSL.Core.Native.EVP_CipherFinal_ex(this.m_cipherContext.Handle, this.m_buffer, ref this.m_lastlen);
				base.Write(this.m_buffer, 0, this.m_lastlen);
			}
			base.Close();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002C30 File Offset: 0x00000E30
		private byte[] SetupKey(byte[] key)
		{
			bool flag = (this.m_cipherContext.Cipher.Flags & 983047U) == 0U;
			byte[] array;
			if (flag)
			{
				array = new byte[this.m_cipherContext.Cipher.KeyLength];
				if (key == null)
				{
					array.Initialize();
				}
				else
				{
					global::System.Buffer.BlockCopy(key, 0, array, 0, global::System.Math.Min(key.Length, array.Length));
				}
			}
			else if (key == null)
			{
				array = new byte[this.m_cipherContext.Cipher.KeyLength];
				array.Initialize();
			}
			else if (this.m_cipherContext.Cipher.KeyLength != key.Length)
			{
				array = new byte[this.m_cipherContext.Cipher.KeyLength];
				array.Initialize();
				global::System.Buffer.BlockCopy(key, 0, array, 0, global::System.Math.Min(key.Length, array.Length));
			}
			else
			{
				array = key;
			}
			return array;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002D00 File Offset: 0x00000F00
		private byte[] SetupIV(byte[] iv)
		{
			if (this.m_cipherContext.Cipher.IVLength > iv.Length)
			{
				byte[] array = new byte[this.m_cipherContext.Cipher.IVLength];
				array.Initialize();
				global::System.Buffer.BlockCopy(iv, 0, array, 0, iv.Length);
				return array;
			}
			return iv;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002D50 File Offset: 0x00000F50
		protected void StartWriteRead(bool read)
		{
			int num = read ? 0 : 1;
			if (read)
			{
				if (!this.m_firstReadCall)
				{
					return;
				}
				this.m_firstReadCall = false;
			}
			else
			{
				if (!this.m_firstWriteCall)
				{
					return;
				}
				this.m_firstWriteCall = false;
			}
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.m_cipherContext.Handle, this.m_cipherContext.Cipher.Handle, global::System.IntPtr.Zero, null, null, num));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CIPHER_CTX_set_key_length(this.m_cipherContext.Handle, this.m_real_key.Length));
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CIPHER_CTX_set_padding(this.m_cipherContext.Handle, num));
			bool flag = (this.m_cipherContext.Cipher.Flags & 983047U) == 0U;
			if (flag)
			{
				for (int i = 0; i < global::System.Math.Min(this.m_real_key.Length, this.m_iv.Length); i++)
				{
					byte[] real_key = this.m_real_key;
					int num2 = i;
					real_key[num2] ^= this.m_iv[i];
				}
				global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.m_cipherContext.Handle, this.m_cipherContext.Cipher.Handle, global::System.IntPtr.Zero, this.m_real_key, null, num));
				return;
			}
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherInit_ex(this.m_cipherContext.Handle, this.m_cipherContext.Cipher.Handle, global::System.IntPtr.Zero, this.m_real_key, this.m_real_iv, num));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002EB8 File Offset: 0x000010B8
		protected void Write(byte[] input, int length)
		{
			if (this.m_firstWriteCall)
			{
				this.StartWriteRead(false);
			}
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherUpdate(this.m_cipherContext.Handle, this.m_buffer, out this.m_lastlen, input, length));
			base.Write(this.m_buffer, 0, this.m_lastlen);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002F0C File Offset: 0x0000110C
		public override void Write(byte[] array, int offset, int count)
		{
			int num = 0;
			byte[] array2 = new byte[1024];
			int num3;
			do
			{
				int num2 = count - num * 1024;
				num3 = ((num2 > 1024) ? 1024 : num2);
				if (num3 > 0)
				{
					if (num3 > array.Length - offset - num * 1024)
					{
						num3 = array.Length - offset - num * 1024;
					}
					global::System.Array.Copy(array, offset + num * 1024, array2, 0, num3);
					this.Write(array2, num3);
					num++;
				}
			}
			while (num3 == 1024);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002F8C File Offset: 0x0000118C
		private byte[] DecryptData(ref byte[] encryptedData, int length)
		{
			if (this.m_firstReadCall)
			{
				this.StartWriteRead(true);
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			byte[] array = new byte[(int)((double)length * 1.5)];
			int num = 0;
			global::OpenSSL.Core.Native.ExpectSuccess(global::OpenSSL.Core.Native.EVP_CipherUpdate(this.m_cipherContext.Handle, array, out num, encryptedData, length));
			memoryStream.Write(array, 0, num);
			global::OpenSSL.Core.Native.EVP_CipherFinal_ex(this.m_cipherContext.Handle, array, ref num);
			if (num > 0)
			{
				memoryStream.Write(array, 0, num);
			}
			return memoryStream.ToArray();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003010 File Offset: 0x00001210
		public override int Read(byte[] array, int offset, int count)
		{
			if (array.Length < offset + count)
			{
				throw new global::System.ArgumentException("array is too small!");
			}
			byte[] array2 = new byte[count];
			int num = 0;
			long position = this.Position;
			int num2 = base.Read(array2, 0, count);
			this.Position = position;
			if (num2 > 0)
			{
				try
				{
					byte[] array3 = this.DecryptData(ref array2, num2);
					if (array3.Length + num > count)
					{
						return num;
					}
					global::System.Array.Copy(array3, 0, array, offset, array3.Length);
					num += array3.Length;
					offset += array3.Length;
					this.Position += (long)num2;
				}
				catch (global::System.Exception ex)
				{
					this.Position = position;
					throw ex;
				}
				return num;
			}
			return num;
		}

		// Token: 0x0400000F RID: 15
		private const int BUFFERSIZE = 1024;

		// Token: 0x04000010 RID: 16
		private byte[] m_real_key;

		// Token: 0x04000011 RID: 17
		private byte[] m_iv;

		// Token: 0x04000012 RID: 18
		private byte[] m_real_iv;

		// Token: 0x04000013 RID: 19
		protected bool m_firstWriteCall = true;

		// Token: 0x04000014 RID: 20
		protected global::OpenSSL.Crypto.CipherContext m_cipherContext;

		// Token: 0x04000015 RID: 21
		private string m_path;

		// Token: 0x04000016 RID: 22
		private int m_lastlen;

		// Token: 0x04000017 RID: 23
		private byte[] m_buffer = new byte[2048];

		// Token: 0x04000018 RID: 24
		protected bool m_firstReadCall = true;
	}
}
