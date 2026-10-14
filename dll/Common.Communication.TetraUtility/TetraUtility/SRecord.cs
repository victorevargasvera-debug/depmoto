using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TetraSecurity;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000070 RID: 112
	public class SRecord
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage Image
		{
			get
			{
				if ((this._image == null || this._image.Count == 0) && this._rowList != null && this._rowList.Count != 0 && !this.RecordToImage())
				{
					this._image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
				}
				if (this._image != null && this._image.Count != 0)
				{
					this._image.CompactUnits();
				}
				return this._image;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000CB38 File Offset: 0x0000AD38
		public string Signature
		{
			get
			{
				return this._signature;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000CB40 File Offset: 0x0000AD40
		public virtual bool LoadFromImage(global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string signature, uint maxRowLen)
		{
			if (maxRowLen == 0U || maxRowLen >= 256U)
			{
				maxRowLen = 28U;
			}
			this._rowList.Clear();
			if (image == null || !image.IsGood() || maxRowLen > 256U)
			{
				return false;
			}
			if (image.Count != 0 && image[0].GetType() != typeof(global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit))
			{
				return false;
			}
			this._image = image;
			this._image.CompactUnits();
			this._signature = (string.IsNullOrEmpty(signature) ? "" : signature);
			this._maxRowLen = maxRowLen;
			global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow = new global::Motorola.Common.Communication.TetraUtility.SRecordRow();
			srecordRow.Address = 0U;
			srecordRow.Length = (uint)signature.Length;
			srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_HEADER;
			srecordRow.Data = new byte[srecordRow.Length];
			for (int i = 0; i < signature.Length; i++)
			{
				srecordRow.Data[i] = (byte)signature[i];
			}
			this._rowList.Add(srecordRow);
			for (int j = 0; j < this._image.Count; j++)
			{
				global::Motorola.Common.Communication.CommonUtil.IMemoryUnit memoryUnit = this._image[j];
				if (memoryUnit.Size != 0U)
				{
					uint num = global::System.Convert.ToUInt32(memoryUnit.Address);
					uint num2 = memoryUnit.Size;
					uint num3 = 0U;
					while (num2 != 0U)
					{
						uint num4 = (num2 > maxRowLen) ? maxRowLen : num2;
						global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow2 = new global::Motorola.Common.Communication.TetraUtility.SRecordRow();
						srecordRow2.Address = num;
						srecordRow2.Length = num4;
						srecordRow2.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA;
						srecordRow2.Data = new byte[num4];
						global::System.Array.Copy(memoryUnit.Data, (long)((ulong)num3), srecordRow2.Data, 0L, (long)((ulong)num4));
						this._rowList.Add(srecordRow2);
						num += num4;
						num3 += num4;
						num2 -= num4;
					}
				}
			}
			global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow3 = new global::Motorola.Common.Communication.TetraUtility.SRecordRow();
			srecordRow3.Address = 0U;
			srecordRow3.Length = 0U;
			srecordRow3.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_TERMINATOR;
			srecordRow3.Data = new byte[srecordRow3.Length];
			this._rowList.Add(srecordRow3);
			this._image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();
			return true;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000CD48 File Offset: 0x0000AF48
		public bool LoadFromPlainContentStream(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream", "stream cannot be null");
			}
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
			{
				string text = streamReader.ReadLine();
				while (!string.IsNullOrEmpty(text))
				{
					if (text[1] != '5' && !this.TransformSRecord(text))
					{
						this._image.RemoveAll();
						this._rowList.Clear();
						return false;
					}
					text = streamReader.ReadLine();
				}
			}
			if (!this._dataTerminatorValid)
			{
				this._image.RemoveAll();
				this._rowList.Clear();
				return false;
			}
			if (this._rowList.Count > 0 && this._rowList[0].RowType == global::Motorola.Common.Communication.TetraUtility.S19Type.S_HEADER)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				int num = 0;
				while ((long)num < (long)((ulong)this._rowList[0].Length))
				{
					stringBuilder.Append((char)this._rowList[0].Data[num]);
					num++;
				}
				this._signature = stringBuilder.ToString();
			}
			return this.RecordToImage();
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000CE6C File Offset: 0x0000B06C
		public bool LoadFromStream(global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream", "stream cannot be null");
			}
			if (stream.GetType().IsSubclassOf(typeof(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream)))
			{
				throw new global::System.ArgumentException("We cannot directly consume any sub class of InflaterInputStream, please use SharpZipWrapperInputStream to wrap it.");
			}
			this._image.RemoveAll();
			this._rowList.Clear();
			byte[] array = null;
			byte[] array2 = null;
			int num = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.S19EncryptionHeader.Length;
			bool flag;
			if (stream.Length < (long)num)
			{
				flag = false;
			}
			else
			{
				array2 = new byte[num];
				stream.Read(array2, 0, array2.Length);
				flag = array2.SequenceEqual(global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.S19EncryptionHeader);
			}
			if (flag)
			{
				byte[] array3 = new byte[stream.Length - (long)num];
				stream.Read(array3, 0, array3.Length);
				global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.UnmixDecompressFile(array3, ref array, true, global::Motorola.Common.Communication.TetraUtility.StrangeName.DefOne, global::Motorola.Common.Communication.TetraUtility.StrangeName.DefTwo);
			}
			else
			{
				array = new byte[stream.Length];
				if (array2 != null)
				{
					global::System.Array.Copy(array2, array, array2.Length);
					stream.Read(array, array2.Length, (int)(stream.Length - (long)array2.Length));
				}
			}
			bool result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
			{
				result = this.LoadFromPlainContentStream(memoryStream);
			}
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000CF9C File Offset: 0x0000B19C
		public bool LoadFromFile(string filePath)
		{
			bool result;
			using (global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
			{
				result = this.LoadFromStream(stream);
			}
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		public bool WriteToS19(string filePath)
		{
			if ((this._rowList == null || this._rowList.Count == 0) && this._image != null && this._image.Count != 0 && !this.LoadFromImage(this._image, this._signature, this._maxRowLen))
			{
				this._rowList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SRecordRow>();
			}
			if (this._rowList == null || this._rowList.Count == 0)
			{
				return false;
			}
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(filePath))
			{
				int num = 0;
				for (string value = this.RecordToString(num++); value != null; value = this.RecordToString(num++))
				{
					streamWriter.WriteLine(value);
				}
				if (num != this._rowList.Count + 1)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		public bool WriteToS19WithCryptAndCompress(string filePath)
		{
			if ((this._rowList == null || this._rowList.Count == 0) && this._image != null && this._image.Count != 0 && !this.LoadFromImage(this._image, this._signature, this._maxRowLen))
			{
				this._rowList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SRecordRow>();
			}
			if (this._rowList == null || this._rowList.Count == 0)
			{
				return false;
			}
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream))
				{
					int num = 0;
					for (string value = this.RecordToString(num++); value != null; value = this.RecordToString(num++))
					{
						streamWriter.WriteLine(value);
					}
					if (num != this._rowList.Count + 1)
					{
						return false;
					}
					streamWriter.Flush();
					streamWriter.BaseStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					byte[] s19EncryptionHeader = global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.S19EncryptionHeader;
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
					{
						fileStream.Write(global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.S19EncryptionHeader, 0, global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.S19EncryptionHeader.Length);
						byte[] array = new byte[streamWriter.BaseStream.Length];
						streamWriter.BaseStream.Read(array, 0, array.Length);
						byte[] array2 = null;
						global::Motorola.Common.Communication.TetraSecurity.CryptAndZip.CompressMixFile(array, ref array2, true, global::Motorola.Common.Communication.TetraUtility.StrangeName.DefOne, global::Motorola.Common.Communication.TetraUtility.StrangeName.DefTwo);
						fileStream.Write(array2, 0, array2.Length);
						fileStream.Flush();
						array2 = null;
					}
				}
			}
			return true;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000D258 File Offset: 0x0000B458
		protected string RecordToString(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex > this._rowList.Count - 1)
			{
				return null;
			}
			global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow = this._rowList[rowIndex];
			if (srecordRow.Data == null)
			{
				return null;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder("S");
			switch (srecordRow.RowType)
			{
			case global::Motorola.Common.Communication.TetraUtility.S19Type.S_HEADER:
			{
				this._previousRecordType = 0;
				stringBuilder.Append("0");
				stringBuilder.Append(string.Format("{0:X2}", srecordRow.Length + 1U));
				int num = 0;
				while ((long)num < (long)((ulong)srecordRow.Length))
				{
					stringBuilder.Append(string.Format("{0:X2}", (int)srecordRow.Data[num]));
					num++;
				}
				this.AppendCRC(stringBuilder);
				break;
			}
			case global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA:
			{
				int num2;
				if (srecordRow.Address <= 65535U)
				{
					this._previousRecordType = 1;
					num2 = 2;
				}
				else if (srecordRow.Address <= 16777215U)
				{
					this._previousRecordType = 2;
					num2 = 3;
				}
				else
				{
					if (srecordRow.Address > 4294967295U)
					{
						return null;
					}
					this._previousRecordType = 3;
					num2 = 4;
				}
				stringBuilder.Append(string.Format("{0:X1}", this._previousRecordType));
				stringBuilder.Append(string.Format("{0:X2}", (long)((ulong)srecordRow.Length + (ulong)((long)num2) + 1UL)));
				for (int i = 0; i < num2; i++)
				{
					uint num3 = srecordRow.Address >> (num2 - 1 - i) * 8 & 255U;
					stringBuilder.Append(string.Format("{0:X2}", num3));
				}
				int num4 = 0;
				while ((long)num4 < (long)((ulong)srecordRow.Length))
				{
					stringBuilder.Append(string.Format("{0:X2}", (int)srecordRow.Data[num4]));
					num4++;
				}
				this.AppendCRC(stringBuilder);
				break;
			}
			case global::Motorola.Common.Communication.TetraUtility.S19Type.S_TERMINATOR:
			{
				if (this._previousRecordType == 3)
				{
					this._previousRecordType = 7;
				}
				else if (this._previousRecordType == 2)
				{
					this._previousRecordType = 8;
				}
				else
				{
					if (this._previousRecordType != 1)
					{
						return null;
					}
					this._previousRecordType = 9;
				}
				stringBuilder.Append(string.Format("{0:X1}", this._previousRecordType));
				stringBuilder.Append(string.Format("{0:X2}", srecordRow.Length + 1U));
				int num5 = 0;
				while ((long)num5 < (long)((ulong)srecordRow.Length))
				{
					stringBuilder.Append(string.Format("{0:X2}", (int)srecordRow.Data[num5]));
					num5++;
				}
				this.AppendCRC(stringBuilder);
				break;
			}
			default:
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
		private void AppendCRC(global::System.Text.StringBuilder recordStringBuilder)
		{
			string shex = recordStringBuilder.ToString().Substring(2);
			byte[] bytesall;
			global::Motorola.Common.Communication.TetraUtility.DataCvt.ConvertHexStringToByteArray(shex, out bytesall);
			byte b = this.CalculateCheckSum(bytesall);
			recordStringBuilder.Append(string.Format("{0:X2}", b));
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000D534 File Offset: 0x0000B734
		private byte CalculateCheckSum(byte[] bytesall)
		{
			byte b = 0;
			for (int i = 0; i < bytesall.Length; i++)
			{
				b += bytesall[i];
			}
			return ~b;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000D560 File Offset: 0x0000B760
		protected bool TransformSRecord(string recordString)
		{
			if (string.IsNullOrEmpty(recordString) || recordString.Length < 4)
			{
				return false;
			}
			global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow = new global::Motorola.Common.Communication.TetraUtility.SRecordRow();
			uint num;
			switch (recordString[1])
			{
			case '0':
				num = 0U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_HEADER;
				this._dataTerminatorValid = false;
				goto IL_116;
			case '1':
				num = 2U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA;
				this._previousRecordType = 1;
				this._dataTerminatorValid = false;
				goto IL_116;
			case '2':
				num = 3U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA;
				this._previousRecordType = 2;
				this._dataTerminatorValid = false;
				goto IL_116;
			case '3':
				num = 4U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA;
				this._previousRecordType = 3;
				this._dataTerminatorValid = false;
				goto IL_116;
			case '7':
				if (this._previousRecordType == 3)
				{
					this._dataTerminatorValid = true;
				}
				num = 0U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_TERMINATOR;
				goto IL_116;
			case '8':
				if (this._previousRecordType == 2)
				{
					this._dataTerminatorValid = true;
				}
				num = 0U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_TERMINATOR;
				goto IL_116;
			case '9':
				if (this._previousRecordType == 1)
				{
					this._dataTerminatorValid = true;
				}
				num = 0U;
				srecordRow.RowType = global::Motorola.Common.Communication.TetraUtility.S19Type.S_TERMINATOR;
				goto IL_116;
			}
			this._dataTerminatorValid = false;
			return false;
			IL_116:
			byte[] recordValueArray = this.CVTDataFromStringToByteArray(recordString);
			if (!this.VeryfiyChecksum(recordValueArray))
			{
				return false;
			}
			srecordRow.Address = this.CVTAddressFromArray(recordValueArray, num);
			srecordRow.Length = this.CVTRecordLengthFromArray(recordValueArray) - num - 1U;
			if (srecordRow.Length > 256U)
			{
				return false;
			}
			srecordRow.Data = this.CVTRecordDataFromArray(recordValueArray, num, srecordRow.Length);
			if (srecordRow.Data == null)
			{
				return false;
			}
			if (this._rowList.Count == 1)
			{
				bool flag = true;
				foreach (byte b in srecordRow.Data)
				{
					if (b != 255)
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					this._rowList.Add(srecordRow);
				}
			}
			else
			{
				this._rowList.Add(srecordRow);
			}
			return true;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000D740 File Offset: 0x0000B940
		private bool VeryfiyChecksum(byte[] recordValueArray)
		{
			if (recordValueArray == null || recordValueArray.Length <= 1)
			{
				return false;
			}
			uint num = 0U;
			for (int i = 0; i < recordValueArray.Length - 1; i++)
			{
				num += (uint)recordValueArray[i];
			}
			num = 255U - num % 256U;
			return num == (uint)recordValueArray[recordValueArray.Length - 1];
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000D788 File Offset: 0x0000B988
		private byte[] CVTRecordDataFromArray(byte[] recordValueArray, uint addressLen, uint dataLen)
		{
			if (recordValueArray == null || (long)recordValueArray.Length < (long)((ulong)(2U + addressLen + dataLen)))
			{
				return null;
			}
			byte[] array = new byte[dataLen];
			global::System.Array.Copy(recordValueArray, (long)((ulong)(1U + addressLen)), array, 0L, (long)((ulong)dataLen));
			return array;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		private uint CVTAddressFromArray(byte[] recordValueArray, uint addressLen)
		{
			if (recordValueArray == null || (long)recordValueArray.Length < (long)((ulong)(1U + addressLen)) || addressLen == 0U)
			{
				return 0U;
			}
			uint num = 0U;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)addressLen))
			{
				num = (num << 8) + (uint)recordValueArray[1 + num2];
				num2++;
			}
			return num;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000D7FA File Offset: 0x0000B9FA
		private uint CVTRecordLengthFromArray(byte[] recordValueArray)
		{
			if (recordValueArray == null || recordValueArray.Length == 0)
			{
				return 0U;
			}
			return (uint)recordValueArray[0];
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000D80C File Offset: 0x0000BA0C
		private byte[] CVTDataFromStringToByteArray(string recordString)
		{
			if (string.IsNullOrEmpty(recordString) || recordString.Length <= 2 || recordString.Length % 2 != 0)
			{
				return null;
			}
			byte[] array = new byte[recordString.Length / 2 - 1];
			for (int i = 0; i < array.Length; i++)
			{
				char c = recordString[i * 2 + 2];
				char c2 = recordString[i * 2 + 3];
				byte b;
				if (c >= '0' && c <= '9')
				{
					b = (byte)(c - '0');
				}
				else if (c >= 'A' && c <= 'F')
				{
					b = (byte)(c - 'A' + '\n');
				}
				else
				{
					if (c < 'a' || c > 'f')
					{
						return null;
					}
					b = (byte)(c - 'a' + '\n');
				}
				byte b2;
				if (c2 >= '0' && c2 <= '9')
				{
					b2 = (byte)(c2 - '0');
				}
				else if (c2 >= 'A' && c2 <= 'F')
				{
					b2 = (byte)(c2 - 'A' + '\n');
				}
				else
				{
					if (c2 < 'a' || c2 > 'f')
					{
						return null;
					}
					b2 = (byte)(c2 - 'a' + '\n');
				}
				array[i] = (byte)(((int)b << 4) + (int)b2);
			}
			return array;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000D904 File Offset: 0x0000BB04
		protected bool RecordToImage()
		{
			this._image.RemoveAll();
			if (this._rowList.Count == 0)
			{
				this._rowList.Clear();
				return true;
			}
			uint num = uint.MaxValue;
			uint num2 = uint.MaxValue;
			int num3 = 0;
			int num4 = 0;
			for (int i = 0; i < this._rowList.Count; i++)
			{
				global::Motorola.Common.Communication.TetraUtility.SRecordRow srecordRow = this._rowList[i];
				if (srecordRow.RowType == global::Motorola.Common.Communication.TetraUtility.S19Type.S_DATA)
				{
					num4 = i;
					if (num == 4294967295U && num2 == 4294967295U)
					{
						num = srecordRow.Address;
						num2 = srecordRow.Address + srecordRow.Length - 1U;
						num3 = i;
					}
					else if (num2 + 1U == srecordRow.Address)
					{
						num2 = srecordRow.Address + srecordRow.Length - 1U;
					}
					else
					{
						byte[] array = new byte[num2 - num + 1U];
						int num5 = 0;
						int num6 = num4 - 1;
						for (int j = num3; j <= num6; j++)
						{
							global::System.Array.Copy(this._rowList[j].Data, 0L, array, (long)num5, (long)((ulong)this._rowList[j].Length));
							num5 += (int)this._rowList[j].Length;
						}
						global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
						flashMemoryUnit.ChargeUnit(num.ToString(), array);
						this._image.AddItem(flashMemoryUnit);
						if (!this._image.IsGood())
						{
							this._image.RemoveAll();
							this._rowList.Clear();
							return false;
						}
						num = srecordRow.Address;
						num2 = srecordRow.Address + srecordRow.Length - 1U;
						num3 = i;
					}
				}
			}
			if (num != 4294967295U && num2 != 4294967295U)
			{
				byte[] array2 = new byte[num2 - num + 1U];
				int num7 = 0;
				int num8 = num4;
				for (int k = num3; k <= num8; k++)
				{
					global::System.Array.Copy(this._rowList[k].Data, 0L, array2, (long)num7, (long)((ulong)this._rowList[k].Length));
					num7 += (int)this._rowList[k].Length;
				}
				global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit flashMemoryUnit2 = new global::Motorola.Common.Communication.CommonUtil.FlashMemoryUnit();
				flashMemoryUnit2.ChargeUnit(num.ToString(), array2);
				this._image.AddItem(flashMemoryUnit2);
				if (!this._image.IsGood())
				{
					this._image.RemoveAll();
					this._rowList.Clear();
					return false;
				}
			}
			this._rowList.Clear();
			return true;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000DB6D File Offset: 0x0000BD6D
		private static int CompareSRecordRow(global::Motorola.Common.Communication.TetraUtility.SRecordRow r1, global::Motorola.Common.Communication.TetraUtility.SRecordRow r2)
		{
			if (r1.RowType > r2.RowType)
			{
				return 1;
			}
			if (r1.RowType < r2.RowType)
			{
				return -1;
			}
			return (int)(r1.Address - r2.Address);
		}

		// Token: 0x04000310 RID: 784
		protected int _previousRecordType = -1;

		// Token: 0x04000311 RID: 785
		protected bool _dataTerminatorValid;

		// Token: 0x04000312 RID: 786
		protected string _signature = string.Empty;

		// Token: 0x04000313 RID: 787
		protected uint _maxRowLen = 28U;

		// Token: 0x04000314 RID: 788
		protected global::Motorola.Common.Communication.CommonUtil.MemoryImage _image = new global::Motorola.Common.Communication.CommonUtil.MemoryImage();

		// Token: 0x04000315 RID: 789
		protected global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SRecordRow> _rowList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.TetraUtility.SRecordRow>();
	}
}
