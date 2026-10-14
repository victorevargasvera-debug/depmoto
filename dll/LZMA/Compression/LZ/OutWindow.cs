using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000007 RID: 7
	public class OutWindow
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002E7B File Offset: 0x0000107B
		public void Create(uint windowSize)
		{
			if (this._windowSize != windowSize)
			{
				this._buffer = new byte[windowSize];
			}
			this._windowSize = windowSize;
			this._pos = 0U;
			this._streamPos = 0U;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002EA8 File Offset: 0x000010A8
		public void Init(global::System.IO.Stream stream, bool solid)
		{
			this.ReleaseStream();
			this._stream = stream;
			if (!solid)
			{
				this._streamPos = 0U;
				this._pos = 0U;
				this.TrainSize = 0U;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002ED0 File Offset: 0x000010D0
		public bool Train(global::System.IO.Stream stream)
		{
			long length = stream.Length;
			uint num = (length < (long)((ulong)this._windowSize)) ? ((uint)length) : this._windowSize;
			this.TrainSize = num;
			stream.Position = length - (long)((ulong)num);
			this._streamPos = (this._pos = 0U);
			while (num > 0U)
			{
				uint num2 = this._windowSize - this._pos;
				if (num < num2)
				{
					num2 = num;
				}
				int num3 = stream.Read(this._buffer, (int)this._pos, (int)num2);
				if (num3 == 0)
				{
					return false;
				}
				num -= (uint)num3;
				this._pos += (uint)num3;
				this._streamPos += (uint)num3;
				if (this._pos == this._windowSize)
				{
					this._streamPos = (this._pos = 0U);
				}
			}
			return true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002F90 File Offset: 0x00001190
		public void ReleaseStream()
		{
			this.Flush();
			this._stream = null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002FA0 File Offset: 0x000011A0
		public void Flush()
		{
			uint num = this._pos - this._streamPos;
			if (num == 0U)
			{
				return;
			}
			this._stream.Write(this._buffer, (int)this._streamPos, (int)num);
			if (this._pos >= this._windowSize)
			{
				this._pos = 0U;
			}
			this._streamPos = this._pos;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002FF8 File Offset: 0x000011F8
		public void CopyBlock(uint distance, uint len)
		{
			uint num = this._pos - distance - 1U;
			if (num >= this._windowSize)
			{
				num += this._windowSize;
			}
			while (len > 0U)
			{
				if (num >= this._windowSize)
				{
					num = 0U;
				}
				this._buffer[(int)((global::System.UIntPtr)(this._pos++))] = this._buffer[(int)((global::System.UIntPtr)(num++))];
				if (this._pos >= this._windowSize)
				{
					this.Flush();
				}
				len -= 1U;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003074 File Offset: 0x00001274
		public void PutByte(byte b)
		{
			this._buffer[(int)((global::System.UIntPtr)(this._pos++))] = b;
			if (this._pos >= this._windowSize)
			{
				this.Flush();
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000030B0 File Offset: 0x000012B0
		public byte GetByte(uint distance)
		{
			uint num = this._pos - distance - 1U;
			if (num >= this._windowSize)
			{
				num += this._windowSize;
			}
			return this._buffer[(int)((global::System.UIntPtr)num)];
		}

		// Token: 0x04000021 RID: 33
		private byte[] _buffer;

		// Token: 0x04000022 RID: 34
		private uint _pos;

		// Token: 0x04000023 RID: 35
		private uint _windowSize;

		// Token: 0x04000024 RID: 36
		private uint _streamPos;

		// Token: 0x04000025 RID: 37
		private global::System.IO.Stream _stream;

		// Token: 0x04000026 RID: 38
		public uint TrainSize;
	}
}
