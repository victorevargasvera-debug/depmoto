using System;
using System.IO;
using System.Text;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class Srecord : global::System.IDisposable
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000276C File Offset: 0x0000096C
		public Srecord()
		{
			this.srecStrBuffer = string.Empty;
			this.srecDataCollection = new global::Motorola.Common.Communication.SrecDataCollection();
			this.maxDataPayload = 0;
			this.dataCounter = 0;
			this.address = 0U;
			this.dataBuffer = null;
			this.s3CurrRec = 0;
			this.disposed = false;
			this.maxSrecDataSz = 0;
			this.signature = string.Empty;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027D4 File Offset: 0x000009D4
		~Srecord()
		{
			this.Dispose(false);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002808 File Offset: 0x00000A08
		public int MaxDataSize
		{
			get
			{
				return this.maxSrecDataSz;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002820 File Offset: 0x00000A20
		private string strData
		{
			get
			{
				return this.srecStrBuffer;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002838 File Offset: 0x00000A38
		private string Signature
		{
			get
			{
				return this.signature;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002850 File Offset: 0x00000A50
		public uint AddressLow
		{
			get
			{
				return this.addressLow;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002868 File Offset: 0x00000A68
		public uint AddressHigh
		{
			get
			{
				return this.addressHigh;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00002880 File Offset: 0x00000A80
		public global::Motorola.Common.Communication.SrecDataCollection DataRecords
		{
			get
			{
				return this.srecDataCollection;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002898 File Offset: 0x00000A98
		private void Add(global::Motorola.Common.Communication.SrecLine record)
		{
			if (record.Type == global::Motorola.Common.Communication.SrecType.S3)
			{
				int num = record.GetData().Length;
				if (this.s3CurrRec == 0)
				{
					this.addressLow = record.Address;
					this.addressHigh = record.Address + (uint)num - 1U;
					this.s3CurrRec++;
				}
				if (record.Address < this.addressLow)
				{
					this.addressLow = record.Address;
				}
				if ((ulong)record.Address + (ulong)((long)num) - 1UL > (ulong)this.addressHigh)
				{
					this.addressHigh = record.Address + (uint)num - 1U;
				}
				bool flag = false;
				bool flag2 = false;
				int num2 = 0;
				bool flag3 = false;
				if (this.dataCounter == 0)
				{
					this.address = record.Address;
				}
				else if ((ulong)record.Address != (ulong)this.address + (ulong)((long)this.dataCounter))
				{
					flag = true;
					flag3 = true;
				}
				if (!flag3)
				{
					if (num <= this.maxDataPayload - this.dataCounter)
					{
						global::System.Array.Copy(record.GetData(), 0, this.dataBuffer, this.dataCounter, num);
						this.dataCounter += num;
						if (this.dataCounter == this.maxDataPayload)
						{
							flag = true;
						}
					}
					else
					{
						global::System.Array.Copy(record.GetData(), 0, this.dataBuffer, this.dataCounter, this.maxDataPayload - this.dataCounter);
						num2 = this.maxDataPayload - this.dataCounter;
						this.dataCounter = this.maxDataPayload;
						flag = true;
						flag2 = true;
					}
				}
				if (flag)
				{
					this.maxSrecDataSz += this.dataCounter;
					global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData((uint)this.dataCounter, this.address, this.dataBuffer, global::Motorola.Common.Communication.SrecType.S3);
					this.srecDataCollection.Add(item);
					global::System.Array.Clear(this.dataBuffer, 0, this.dataBuffer.Length);
					if (flag3)
					{
						this.address = record.Address;
						this.dataCounter = 0;
						global::System.Array.Copy(record.GetData(), 0, this.dataBuffer, this.dataCounter, num);
						this.dataCounter += num;
					}
					else if (flag2)
					{
						global::System.Array.Copy(record.GetData(), num2, this.dataBuffer, 0, num - num2);
						this.address += (uint)this.dataCounter;
						this.dataCounter = num - num2;
					}
					else
					{
						this.address += (uint)this.dataCounter;
						this.dataCounter = 0;
					}
				}
			}
			else if (record.Type == global::Motorola.Common.Communication.SrecType.S0)
			{
				global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
				this.signature = asciiencoding.GetString(record.GetData());
			}
			else if (record.Type == global::Motorola.Common.Communication.SrecType.S7)
			{
				global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData(0U, record.Address, null, global::Motorola.Common.Communication.SrecType.S7);
				this.srecDataCollection.Add(item);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002BCC File Offset: 0x00000DCC
		private void EndParse()
		{
			if (this.dataCounter != 0)
			{
				this.maxSrecDataSz += this.dataCounter;
				global::Motorola.Common.Communication.SrecData item = new global::Motorola.Common.Communication.SrecData((uint)this.dataCounter, this.address, this.dataBuffer, global::Motorola.Common.Communication.SrecType.S3);
				if (this.srecDataCollection.Count == 0)
				{
					this.srecDataCollection.Add(item);
				}
				else
				{
					int index = this.srecDataCollection.Count - 1;
					global::Motorola.Common.Communication.SrecData srecData = this.srecDataCollection[index];
					if (srecData.Type == global::Motorola.Common.Communication.SrecType.S7)
					{
						this.srecDataCollection.Insert(index, item);
					}
					else
					{
						this.srecDataCollection.Add(item);
					}
				}
				global::System.Array.Clear(this.dataBuffer, 0, this.dataBuffer.Length);
				this.dataCounter = 0;
				this.address = 0U;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002CB0 File Offset: 0x00000EB0
		public void LoadSrecordData(string filePath, int maxDataPayload, bool verifyChecksum = true)
		{
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read))
			{
				byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
				global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
				string @string = asciiencoding.GetString(bytesFromStream);
				this.LoadData(@string, maxDataPayload, verifyChecksum);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D18 File Offset: 0x00000F18
		public void LoadData(string srecData, int maxDataPayload, bool verifyChecksum = true)
		{
			this.maxDataPayload = maxDataPayload;
			this.dataBuffer = new byte[maxDataPayload];
			using (global::Motorola.Common.Communication.SrecordReader srecordReader = new global::Motorola.Common.Communication.SrecordReader(srecData))
			{
				srecordReader.verifyChecksum = verifyChecksum;
				while (srecordReader.Read())
				{
					this.Add(srecordReader.Record);
				}
				this.EndParse();
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002D90 File Offset: 0x00000F90
		public static string LoadSignatureFromSrecord(string srecData)
		{
			string result = null;
			using (global::Motorola.Common.Communication.SrecordReader srecordReader = new global::Motorola.Common.Communication.SrecordReader(srecData))
			{
				while (srecordReader.Read())
				{
					if (srecordReader.Record.Type == global::Motorola.Common.Communication.SrecType.S0)
					{
						global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
						result = asciiencoding.GetString(srecordReader.Record.GetData());
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002E18 File Offset: 0x00001018
		private void Clear()
		{
			if (this.srecDataCollection != null)
			{
				this.srecDataCollection.Clear();
				this.srecDataCollection = null;
			}
			if (this.dataBuffer != null)
			{
				this.dataBuffer = null;
			}
			this.srecStrBuffer = null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002E65 File Offset: 0x00001065
		private void Close()
		{
			((global::System.IDisposable)this).Dispose();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002E6F File Offset: 0x0000106F
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E84 File Offset: 0x00001084
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					this.Clear();
				}
				this.disposed = true;
			}
		}

		// Token: 0x0400002B RID: 43
		private string srecStrBuffer;

		// Token: 0x0400002C RID: 44
		private global::Motorola.Common.Communication.SrecDataCollection srecDataCollection;

		// Token: 0x0400002D RID: 45
		private uint addressLow;

		// Token: 0x0400002E RID: 46
		private uint addressHigh;

		// Token: 0x0400002F RID: 47
		private int maxDataPayload;

		// Token: 0x04000030 RID: 48
		private int dataCounter;

		// Token: 0x04000031 RID: 49
		private byte[] dataBuffer;

		// Token: 0x04000032 RID: 50
		private uint address;

		// Token: 0x04000033 RID: 51
		private int s3CurrRec;

		// Token: 0x04000034 RID: 52
		private bool disposed;

		// Token: 0x04000035 RID: 53
		private int maxSrecDataSz;

		// Token: 0x04000036 RID: 54
		private string signature;
	}
}
