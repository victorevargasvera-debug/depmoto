using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000005 RID: 5
	public class InWindow
	{
		// Token: 0x06000012 RID: 18 RVA: 0x000021DC File Offset: 0x000003DC
		public void MoveBlock()
		{
			uint num = this._bufferOffset + this._pos - this._keepSizeBefore;
			if (num > 0U)
			{
				num -= 1U;
			}
			uint num2 = this._bufferOffset + this._streamPos - num;
			for (uint num3 = 0U; num3 < num2; num3 += 1U)
			{
				this._bufferBase[(int)((global::System.UIntPtr)num3)] = this._bufferBase[(int)((global::System.UIntPtr)(num + num3))];
			}
			this._bufferOffset -= num;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002244 File Offset: 0x00000444
		public virtual void ReadBlock()
		{
			if (this._streamEndWasReached)
			{
				return;
			}
			for (;;)
			{
				int num = (int)(0U - this._bufferOffset + this._blockSize - this._streamPos);
				if (num == 0)
				{
					break;
				}
				int num2 = this._stream.Read(this._bufferBase, (int)(this._bufferOffset + this._streamPos), num);
				if (num2 == 0)
				{
					goto Block_3;
				}
				this._streamPos += (uint)num2;
				if (this._streamPos >= this._pos + this._keepSizeAfter)
				{
					this._posLimit = this._streamPos - this._keepSizeAfter;
				}
			}
			return;
			Block_3:
			this._posLimit = this._streamPos;
			uint num3 = this._bufferOffset + this._posLimit;
			if (num3 > this._pointerToLastSafePosition)
			{
				this._posLimit = this._pointerToLastSafePosition - this._bufferOffset;
			}
			this._streamEndWasReached = true;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002313 File Offset: 0x00000513
		private void Free()
		{
			this._bufferBase = null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000231C File Offset: 0x0000051C
		public void Create(uint keepSizeBefore, uint keepSizeAfter, uint keepSizeReserv)
		{
			this._keepSizeBefore = keepSizeBefore;
			this._keepSizeAfter = keepSizeAfter;
			uint num = keepSizeBefore + keepSizeAfter + keepSizeReserv;
			if (this._bufferBase == null || this._blockSize != num)
			{
				this.Free();
				this._blockSize = num;
				this._bufferBase = new byte[this._blockSize];
			}
			this._pointerToLastSafePosition = this._blockSize - keepSizeAfter;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000237B File Offset: 0x0000057B
		public void SetStream(global::System.IO.Stream stream)
		{
			this._stream = stream;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002384 File Offset: 0x00000584
		public void ReleaseStream()
		{
			this._stream = null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000238D File Offset: 0x0000058D
		public void Init()
		{
			this._bufferOffset = 0U;
			this._pos = 0U;
			this._streamPos = 0U;
			this._streamEndWasReached = false;
			this.ReadBlock();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023B4 File Offset: 0x000005B4
		public void MovePos()
		{
			this._pos += 1U;
			if (this._pos > this._posLimit)
			{
				uint num = this._bufferOffset + this._pos;
				if (num > this._pointerToLastSafePosition)
				{
					this.MoveBlock();
				}
				this.ReadBlock();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002400 File Offset: 0x00000600
		public byte GetIndexByte(int index)
		{
			return this._bufferBase[(int)(checked((global::System.IntPtr)(unchecked((ulong)(this._bufferOffset + this._pos) + (ulong)((long)index)))))];
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000241C File Offset: 0x0000061C
		public uint GetMatchLen(int index, uint distance, uint limit)
		{
			if (this._streamEndWasReached && (ulong)this._pos + (ulong)((long)index) + (ulong)limit > (ulong)this._streamPos)
			{
				limit = this._streamPos - (uint)((ulong)this._pos + (ulong)((long)index));
			}
			distance += 1U;
			uint num = this._bufferOffset + this._pos + (uint)index;
			uint num2 = 0U;
			while (num2 < limit && this._bufferBase[(int)((global::System.UIntPtr)(num + num2))] == this._bufferBase[(int)((global::System.UIntPtr)(num + num2 - distance))])
			{
				num2 += 1U;
			}
			return num2;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002497 File Offset: 0x00000697
		public uint GetNumAvailableBytes()
		{
			return this._streamPos - this._pos;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000024A6 File Offset: 0x000006A6
		public void ReduceOffsets(int subValue)
		{
			this._bufferOffset += (uint)subValue;
			this._posLimit -= (uint)subValue;
			this._pos -= (uint)subValue;
			this._streamPos -= (uint)subValue;
		}

		// Token: 0x04000003 RID: 3
		public byte[] _bufferBase;

		// Token: 0x04000004 RID: 4
		private global::System.IO.Stream _stream;

		// Token: 0x04000005 RID: 5
		private uint _posLimit;

		// Token: 0x04000006 RID: 6
		private bool _streamEndWasReached;

		// Token: 0x04000007 RID: 7
		private uint _pointerToLastSafePosition;

		// Token: 0x04000008 RID: 8
		public uint _bufferOffset;

		// Token: 0x04000009 RID: 9
		public uint _blockSize;

		// Token: 0x0400000A RID: 10
		public uint _pos;

		// Token: 0x0400000B RID: 11
		private uint _keepSizeBefore;

		// Token: 0x0400000C RID: 12
		private uint _keepSizeAfter;

		// Token: 0x0400000D RID: 13
		public uint _streamPos;
	}
}
