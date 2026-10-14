using System;

namespace AcpCryptoLib
{
	// Token: 0x02000014 RID: 20
	public class AcpSmartNetAlgorithm
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003348 File Offset: 0x00001548
		internal byte[] Encrypt(byte[] input)
		{
			int num = input.Length;
			byte[] array = new byte[10 + 2 * num];
			int num2 = 0;
			num2 += this.encryptChar(input[0], true, array, num2);
			for (int i = 1; i < num; i++)
			{
				num2 += this.encryptChar(input[i], false, array, num2);
			}
			byte[] array2 = new byte[num2];
			global::System.Array.Copy(array, array2, num2);
			array2[7] = (byte)array2.Length;
			return array2;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000033B0 File Offset: 0x000015B0
		private int encryptChar(byte in_buf, bool is_first_char, byte[] encrypt_buffer, int nPos)
		{
			long ticks = global::System.DateTime.Now.Ticks;
			int num;
			if (is_first_char)
			{
				this.acpRng = new global::AcpCryptoLib.AcpRNGenerator();
				for (int i = 0; i < 9; i++)
				{
					encrypt_buffer[i] = (byte)this.acpRng.NextSNetRandomValue;
				}
				encrypt_buffer[5] = (byte)this.acpRng.NextSNetRandomValue;
				byte b = encrypt_buffer[5];
				encrypt_buffer[6] = (byte)this.acpRng.NextSNetRandomValue;
				b = (byte)((int)(b + encrypt_buffer[6]) % 256);
				encrypt_buffer[8] = (byte)this.acpRng.NextSNetRandomValue;
				b = (byte)((int)(b - encrypt_buffer[8]) % 256);
				this.acpRng.SNetRandomValue = (int)b;
				this.working_key = (byte)this.acpRng.NextSNetRandomValue;
				num = 9;
			}
			else
			{
				num = 0;
			}
			byte b2 = in_buf ^ this.working_key;
			if (b2 == 26 || b2 == 27)
			{
				encrypt_buffer[num + nPos] = 27;
				num++;
				if (b2 == 27)
				{
					byte snetRandomValue = (byte)this.acpRng.SNetRandomValue;
					do
					{
						b2 = (byte)this.acpRng.NextSNetRandomValue;
					}
					while ((int)b2 == -27 || b2 == 27 || b2 == 26);
					this.acpRng.SNetRandomValue = (int)snetRandomValue;
				}
				else
				{
					b2 = 229;
				}
			}
			encrypt_buffer[num + nPos] = b2;
			num++;
			byte b3 = (byte)this.acpRng.NextSNetRandomValue;
			this.working_key = (byte)((int)(this.working_key + in_buf + b3) % 256);
			return num;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003510 File Offset: 0x00001710
		internal byte[] Decrypt(byte[] input)
		{
			int num = 0;
			int num2 = input.Length;
			byte[] array = new byte[num2];
			bool is_first = true;
			for (int i = 0; i < num2; i++)
			{
				num += this.decryptChar(input[i], array, is_first, num);
				is_first = false;
			}
			byte[] array2 = new byte[num];
			global::System.Array.Copy(array, array2, num);
			return array2;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003564 File Offset: 0x00001764
		public int DecryptChar(byte in_buf, out byte decrypt_buffer, bool is_first)
		{
			decrypt_buffer = 0;
			byte[] array = new byte[1];
			int num = this.decryptChar(in_buf, array, is_first, 0);
			if (num > 0)
			{
				decrypt_buffer = array[0];
			}
			return num;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003594 File Offset: 0x00001794
		private int decryptChar(byte in_buf, byte[] decrypt_buffer, bool is_first, int position)
		{
			int num = 0;
			if (is_first)
			{
				this.char_pos = 0U;
				this.was_escape = false;
				this.m_key1 = 0;
				this.m_key2 = 0;
				this.m_key3 = 0;
				this.working_key = 0;
				this.chr = 0;
				this.acpRng = new global::AcpCryptoLib.AcpRNGenerator();
			}
			if (this.char_pos < 9U)
			{
				switch (this.char_pos)
				{
				case 5U:
					this.m_key1 = in_buf;
					break;
				case 6U:
					this.m_key2 = in_buf;
					break;
				case 8U:
				{
					this.m_key3 = in_buf;
					int num2 = (int)this.m_key1;
					num2 = (num2 + (int)this.m_key2) % 256;
					num2 = (num2 - (int)this.m_key3) % 256;
					this.acpRng.SNetRandomValue = num2;
					this.working_key = (byte)this.acpRng.NextSNetRandomValue;
					break;
				}
				}
				this.char_pos += 1U;
			}
			else
			{
				if (this.was_escape)
				{
					byte b = 229;
					if (in_buf == b)
					{
						this.chr = 26;
					}
					else
					{
						this.chr = 27;
					}
					this.was_escape = false;
					num++;
				}
				else if (in_buf == 27)
				{
					this.was_escape = true;
				}
				else
				{
					this.chr = in_buf;
					num++;
				}
				if (num != 0)
				{
					this.chr ^= this.working_key;
					int nextSNetRandomValue = this.acpRng.NextSNetRandomValue;
					this.working_key = (byte)(((int)(this.working_key + this.chr) + nextSNetRandomValue) % 256);
					decrypt_buffer[position] = this.chr;
				}
			}
			return num;
		}

		// Token: 0x0400002A RID: 42
		private const int ACP_TESCAPE = 27;

		// Token: 0x0400002B RID: 43
		private const int ACP_TEOF = 26;

		// Token: 0x0400002C RID: 44
		private const int ACP_START_POS = 0;

		// Token: 0x0400002D RID: 45
		private byte working_key;

		// Token: 0x0400002E RID: 46
		private uint char_pos;

		// Token: 0x0400002F RID: 47
		private bool was_escape;

		// Token: 0x04000030 RID: 48
		private byte m_key1;

		// Token: 0x04000031 RID: 49
		private byte m_key2;

		// Token: 0x04000032 RID: 50
		private byte m_key3;

		// Token: 0x04000033 RID: 51
		private byte chr;

		// Token: 0x04000034 RID: 52
		private global::AcpCryptoLib.AcpRNGenerator acpRng;
	}
}
