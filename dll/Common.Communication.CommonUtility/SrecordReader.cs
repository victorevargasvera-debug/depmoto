using System;
using System.IO;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000F RID: 15
	internal class SrecordReader : global::System.IDisposable
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002EBC File Offset: 0x000010BC
		public SrecordReader(string strData)
		{
			if (string.IsNullOrEmpty(strData))
			{
				throw new global::System.ArgumentNullException("strData");
			}
			this.srecStrReader = new global::System.IO.StringReader(strData);
			this.srecordLength = strData.Length;
			this.eol = "";
			this.disposed = false;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F18 File Offset: 0x00001118
		~SrecordReader()
		{
			this.Dispose(false);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002F4C File Offset: 0x0000114C
		public global::Motorola.Common.Communication.SrecLine Record
		{
			get
			{
				return this.record;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002F64 File Offset: 0x00001164
		private bool EOS
		{
			get
			{
				return this.eol == null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00002F80 File Offset: 0x00001180
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00002F97 File Offset: 0x00001197
		public bool verifyChecksum { private get; set; }

		// Token: 0x06000043 RID: 67 RVA: 0x00002FA0 File Offset: 0x000011A0
		public bool Read()
		{
			bool result;
			if (this.srecordLength == 0 || this.EOS)
			{
				result = false;
			}
			else
			{
				try
				{
					global::Motorola.Common.Communication.SrecType srecType = this.ReadType();
					byte b = this.ReadByte();
					if (b <= 1)
					{
						throw new global::System.IO.InvalidDataException();
					}
					int addressSize = global::Motorola.Common.Communication.SrecTypeInfo.GetAddressSize(srecType);
					uint address = this.ReadAddress(addressSize);
					byte[] array = null;
					if (srecType != global::Motorola.Common.Communication.SrecType.S7)
					{
						int num = (int)(b - 1) - addressSize;
						array = new byte[num];
						for (int i = 0; i < num; i++)
						{
							array[i] = this.ReadByte();
						}
					}
					byte b2 = this.ReadByte();
					this.record = new global::Motorola.Common.Communication.SrecLine(srecType, b, address, array, b2);
					if (b2 != global::Motorola.Common.Communication.SrecordReader.CalculateChecksum(this.record) && this.verifyChecksum)
					{
						return false;
					}
					this.eol = this.srecStrReader.ReadLine();
				}
				catch (global::System.Exception)
				{
					this.eol = null;
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000030C4 File Offset: 0x000012C4
		private static byte CalculateChecksum(global::Motorola.Common.Communication.SrecLine record)
		{
			byte b = 0;
			b += record.RecordLen;
			b += (byte)(record.Address >> 24);
			b += (byte)(record.Address >> 16);
			b += (byte)(record.Address >> 8);
			b += (byte)record.Address;
			byte[] data = record.GetData();
			if (data != null)
			{
				for (int i = 0; i < data.Length; i++)
				{
					b += data[i];
				}
			}
			return ~b;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000314C File Offset: 0x0000134C
		private byte ReadByte()
		{
			int num = this.srecStrReader.Read();
			int num2 = this.srecStrReader.Read();
			if (num == -1 || num2 == -1)
			{
				throw new global::System.IO.IOException("end of stream");
			}
			byte[] bytes = new byte[]
			{
				(byte)num,
				(byte)num2
			};
			global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
			string @string = asciiencoding.GetString(bytes);
			return global::System.Convert.ToByte(@string, 16);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000031C8 File Offset: 0x000013C8
		private uint ReadAddress(int addressSize)
		{
			uint num = 0U;
			for (int i = 0; i < addressSize; i++)
			{
				byte b = this.ReadByte();
				num |= (uint)((uint)b << (addressSize - 1 - i) * 8);
			}
			return num;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003208 File Offset: 0x00001408
		private global::Motorola.Common.Communication.SrecType ReadType()
		{
			int num = this.srecStrReader.Read();
			int num2 = this.srecStrReader.Read();
			if (num == -1 || num2 == -1)
			{
				throw new global::System.IO.IOException("end of stream");
			}
			byte[] bytes = new byte[]
			{
				(byte)num,
				(byte)num2
			};
			global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
			string @string = asciiencoding.GetString(bytes);
			global::Motorola.Common.Communication.SrecType result;
			if (@string == "S0")
			{
				result = global::Motorola.Common.Communication.SrecType.S0;
			}
			else if (@string == "S3")
			{
				result = global::Motorola.Common.Communication.SrecType.S3;
			}
			else
			{
				if (!(@string == "S7"))
				{
					throw new global::System.NotImplementedException();
				}
				result = global::Motorola.Common.Communication.SrecType.S7;
			}
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000032D1 File Offset: 0x000014D1
		private void Close()
		{
			((global::System.IDisposable)this).Dispose();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000032DC File Offset: 0x000014DC
		void global::System.IDisposable.Dispose()
		{
			if (!this.disposed)
			{
				this.Dispose(true);
				this.disposed = true;
				this.srecStrReader.Dispose();
				global::System.GC.SuppressFinalize(this);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000331C File Offset: 0x0000151C
		protected virtual void Dispose(bool disposing)
		{
			if (this.srecStrReader != null)
			{
				this.srecStrReader.Close();
			}
		}

		// Token: 0x04000037 RID: 55
		private const int CrcLength = 1;

		// Token: 0x04000038 RID: 56
		private bool disposed;

		// Token: 0x04000039 RID: 57
		private global::System.IO.StringReader srecStrReader;

		// Token: 0x0400003A RID: 58
		private global::Motorola.Common.Communication.SrecLine record;

		// Token: 0x0400003B RID: 59
		private string eol;

		// Token: 0x0400003C RID: 60
		private int srecordLength;
	}
}
