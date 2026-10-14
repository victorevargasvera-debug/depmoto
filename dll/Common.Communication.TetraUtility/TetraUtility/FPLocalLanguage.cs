using System;
using System.Collections.Generic;
using System.Text;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000012 RID: 18
	[global::System.Serializable]
	public class FPLocalLanguage : global::Motorola.Common.Communication.TetraUtility.FPBase
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00006018 File Offset: 0x00004218
		public override byte[] Data
		{
			get
			{
				if ((long)this._data.Length < (long)((ulong)global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.LocalLanguagePackSize))
				{
					byte[] data = this._data;
					this._data = new byte[global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.LocalLanguagePackSize];
					global::System.Array.Copy(data, 0, this._data, 0, data.Length);
				}
				return this._data;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00006065 File Offset: 0x00004265
		public override uint CompareID
		{
			get
			{
				return (uint)this._llpInfo.pack_based_language;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00006072 File Offset: 0x00004272
		public override string Description
		{
			get
			{
				return "Language User Defined";
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00006079 File Offset: 0x00004279
		public override uint LanguageFontID
		{
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000607C File Offset: 0x0000427C
		public uint PromptDataPtr
		{
			get
			{
				return this._promptDataPtr;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00006084 File Offset: 0x00004284
		public uint DecodeTablePtr
		{
			get
			{
				return this._decodeTablePtr;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000608C File Offset: 0x0000428C
		public uint PromptTablePtr
		{
			get
			{
				return this._promptTablePtr;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006094 File Offset: 0x00004294
		public uint IdsTablePtr
		{
			get
			{
				return this._idsTablePtr;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000609C File Offset: 0x0000429C
		public global::Motorola.Common.Communication.CommonUtil.PackHeader PackHeader
		{
			get
			{
				return new global::Motorola.Common.Communication.CommonUtil.PackHeader
				{
					type = (global::Motorola.Common.Communication.CommonUtil.fp_pack_type_t)base.PackType,
					size = base.PackSize,
					productPlatform = base.ProductPlatform,
					releaseNumber = base.ReleaseNumber,
					revision = base.RevisionNumber,
					subRevision = base.SubRevisionNumber,
					imageName = this.GetImageName(),
					packid = "Language User Defined",
					compareID = this.CompareID,
					languageFontID = this.LanguageFontID
				};
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00006127 File Offset: 0x00004327
		public FPLocalLanguage(byte[] llpData, uint llpSize, global::Motorola.Common.Communication.TetraUtility.ByteOrder order) : base(llpData, llpSize, order)
		{
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006148 File Offset: 0x00004348
		public uint GetPromptDataSize()
		{
			return checked(this._decodeTablePtr - this._promptDataPtr);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006168 File Offset: 0x00004368
		public uint GetDecodeTableSize()
		{
			return checked(this._promptTablePtr - this._decodeTablePtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006188 File Offset: 0x00004388
		public uint GetPromptTableSize()
		{
			return checked(this._idsTablePtr - this._promptTablePtr);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000061A8 File Offset: 0x000043A8
		public uint GetIdsTableSize()
		{
			return checked(this._reserved - this._idsTablePtr);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000061C8 File Offset: 0x000043C8
		public override bool InitData()
		{
			if (this._data == null || this._size == 0U)
			{
				return false;
			}
			if (!this.IsCorrectType() || !base.IsChecksumCorrect())
			{
				return false;
			}
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();
			fp_header_t.GetHeaderfromRawData(this._data);
			if (fp_header_t.pack_product_platform == 20)
			{
				this._llpType = global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NGCHLLP;
			}
			else if (fp_header_t.pack_product_platform == 52)
			{
				this._llpType = global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.GemstoneBMPLLP;
			}
			else if (fp_header_t.pack_product_platform == 66)
			{
				this._llpType = global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP;
			}
			else
			{
				this._llpType = global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NormalLLP;
			}
			uint num = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(0U, 16U, 4);
			this._llpInfo.GetDatafromRaw(this._data, num);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				this.InfoByteReverse();
			}
			num = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(0U, 16U, 4);
			num = this.GetPrpmptDataAlignAddr(num);
			this._promptDataPtr = num;
			num = this.GetDecodeTableAlignedAddr(num, this._llpInfo.size_prompt_data);
			this._decodeTablePtr = num;
			num = this.GetPromptTableAlignedAddr(num, this._llpInfo.size_decode_table);
			this._promptTablePtr = num;
			num = this.GetIdsTableAlignedAddr(num, this._llpInfo.size_prompt_table);
			this._idsTablePtr = num;
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP)
			{
				num = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(num, this._llpInfo.size_prompt_string_ids_table, 4);
			}
			else
			{
				num = global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(num, this._llpInfo.size_prompt_string_ids_table, 1);
			}
			this._reserved = num;
			return true;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006317 File Offset: 0x00004517
		public override bool IsCorrectType()
		{
			return this._header.pack_type == 100;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000632B File Offset: 0x0000452B
		public override string GetImageName()
		{
			return global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.GetImageName(this._header, this._llpInfo);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006340 File Offset: 0x00004540
		public void GetIds(global::System.Collections.Generic.List<string> arrIds)
		{
			byte[] array = new byte[(long)this._data.Length - (long)((ulong)this._idsTablePtr)];
			global::System.Array.Copy(this._data, (long)((ulong)this._idsTablePtr), array, 0L, (long)this._data.Length - (long)((ulong)this._idsTablePtr));
			global::System.Text.Encoding ascii = global::System.Text.Encoding.ASCII;
			string text = ascii.GetString(array);
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			arrIds.Clear();
			string text2 = text;
			char[] array2 = new char[2];
			array2[0] = ' ';
			text = text2.Trim(array2);
			string[] collection = text.Split(new char[]
			{
				' '
			}, global::System.StringSplitOptions.RemoveEmptyEntries);
			arrIds.AddRange(collection);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000063DE File Offset: 0x000045DE
		public uint GetPromptDataSize(uint size)
		{
			return size;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000063E1 File Offset: 0x000045E1
		public uint GetPrpmptDataAlignAddr(uint currPtr)
		{
			return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, 24U, 1);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000063EC File Offset: 0x000045EC
		public uint GetDecodeTableSize(uint size)
		{
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NormalLLP)
			{
				return size * 6U;
			}
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.GemstoneBMPLLP)
			{
				return size * 6U;
			}
			return size * 8U;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000640C File Offset: 0x0000460C
		public uint GetDecodeTableAlignedAddr(uint currPtr, uint size)
		{
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NormalLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptDataSize(size), 2);
			}
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.GemstoneBMPLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptDataSize(size), 2);
			}
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptDataSize(size), 4);
			}
			return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptDataSize(size), 4);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000646E File Offset: 0x0000466E
		public uint GetPromptTableSize(uint size)
		{
			return size * 2U;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006473 File Offset: 0x00004673
		public uint GetPromptTableAlignedAddr(uint currPtr, uint size)
		{
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetDecodeTableSize(size), 4);
			}
			return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetDecodeTableSize(size), 2);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000649C File Offset: 0x0000469C
		public uint GetIdsTableAlignedAddr(uint currPtr, uint size)
		{
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NormalLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptTableSize(size), 2);
			}
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.GemstoneBMPLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptTableSize(size), 2);
			}
			if (this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP)
			{
				return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptTableSize(size), 4);
			}
			return global::Motorola.Common.Communication.TetraUtility.FPBase.GetByteAlignedAddress(currPtr, this.GetPromptTableSize(size), 1);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000064FE File Offset: 0x000046FE
		public uint GetInfoPromptDataSize()
		{
			return this._llpInfo.size_prompt_data;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000650B File Offset: 0x0000470B
		public uint GetInfoDecodeTableSize()
		{
			return this._llpInfo.size_decode_table;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006518 File Offset: 0x00004718
		public uint GetInfoPromptTableSize()
		{
			return this._llpInfo.size_prompt_table;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00006528 File Offset: 0x00004728
		public override bool IsConflict(global::Motorola.Common.Communication.TetraUtility.FPBase pack)
		{
			if (pack == null)
			{
				return true;
			}
			bool result = false;
			if ((uint)this._header.pack_type == pack.PackType)
			{
				result = true;
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00006552 File Offset: 0x00004752
		public static void InfoByteReverse(global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t infoHeader)
		{
			if (infoHeader == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_prompt_data);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_decode_table);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_prompt_table);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref infoHeader.size_prompt_string_ids_table);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006584 File Offset: 0x00004784
		public static void InfoByteReverse(global::Motorola.Common.Communication.CommonUtil.fp_header_t header)
		{
			if (header == null)
			{
				return;
			}
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref header.checksum);
			global::Motorola.Common.Communication.TetraUtility.ByteOrderOp.ReverseBytesRaw(ref header.pack_size);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000065A0 File Offset: 0x000047A0
		public static string GetImageName(global::Motorola.Common.Communication.CommonUtil.fp_header_t header, global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t llpInfo)
		{
			if (header == null || llpInfo == null)
			{
				return "";
			}
			return string.Format("FU{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}", new object[]
			{
				header.pack_product_platform,
				header.pack_release_number,
				llpInfo.pack_based_language,
				header.pack_revision_number,
				header.pack_sub_revision_num
			});
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00006614 File Offset: 0x00004814
		public void ParseLLPData(out global::System.Collections.Generic.List<string> arrIDs, out string[] prompts)
		{
			try
			{
				arrIDs = new global::System.Collections.Generic.List<string>();
				this.GetIds(arrIDs);
				byte[] array = this.Data.Clone() as byte[];
				global::Motorola.Common.Communication.TetraUtility.HuffedStructCS structInputHuffed = default(global::Motorola.Common.Communication.TetraUtility.HuffedStructCS);
				structInputHuffed.huffData = array;
				structInputHuffed.huffPromptDataPtr = this.PromptDataPtr;
				if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(array, this.PromptTablePtr, this.GetPromptTableSize());
				}
				if (this.IsNGCHControlHeadLLP() || this.Is4ByteAlignmentLLP())
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.RearrangeLLPDecodeTable(array, this.DecodeTablePtr, this.GetDecodeTableSize());
				}
				if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(array, this.DecodeTablePtr, this.GetDecodeTableSize());
				}
				structInputHuffed.huffDecodeTablePtr = this.DecodeTablePtr;
				structInputHuffed.huffOffsetTablePtr = this.PromptTablePtr;
				structInputHuffed.huffPromptDataTableSize = this.GetPromptDataSize();
				structInputHuffed.huffDecodeTableSize = this.GetDecodeTableSize();
				structInputHuffed.huffOffsetTableSize = this.GetPromptTableSize();
				if (!global::Motorola.Common.Communication.TetraUtility.Huffman.UnhuffCS(structInputHuffed, (uint)arrIDs.Count, out prompts))
				{
					throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5064_FP_UnHuffmanFail.ToString(), "failed parse huffman!");
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5066_FP_ParseLLPFail.ToString(), "parse llp fail!", innerException);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00006758 File Offset: 0x00004958
		public void BuildLLPData(string[] prompts)
		{
			global::Motorola.Common.Communication.TetraUtility.HuffedStruct huff;
			if (!global::Motorola.Common.Communication.TetraUtility.Huffman.Huff(prompts, (uint)prompts.Length, out huff))
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5063_FP_HuffmanFail.ToString(), "failed parse huffman!");
			}
			try
			{
				byte[] array = new byte[this.Data.Length];
				global::System.Array.Clear(array, 0, array.Length);
				this._llpHeader.GetHeaderfromRawData(this.Data);
				if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.InfoByteReverse(this._llpHeader);
				}
				if (this._llpHeader.pack_size < global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.LocalLanguagePackSize)
				{
					this._llpHeader.pack_size = global::Motorola.Common.Communication.TetraUtility.TetraCommConstants.LocalLanguagePackSize;
				}
				byte[] array2 = this.GenerateLLPHeaderRawData();
				global::System.Array.Copy(array2, 0, array, 0, array2.Length);
				uint headerSize = base.HeaderSize;
				this._llpInfo.size_prompt_data = huff.nHuffPromptDataTableSize;
				this._llpInfo.size_decode_table = huff.nHuffDecodeTableSize;
				this._llpInfo.size_prompt_table = huff.nHuffOffsetTableSize;
				byte[] array3 = this.GenerateLLPInforRawData();
				global::System.Array.Copy(array3, 0L, array, (long)((ulong)headerSize), (long)array3.Length);
				uint promptDataPtr = this.PromptDataPtr;
				uint promptDataSize = this.GetPromptDataSize(huff.nHuffPromptDataTableSize);
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.CopyData(huff.pHuffPromptDataTable, array, promptDataPtr, promptDataSize);
				uint decodeTableAlignedAddr = this.GetDecodeTableAlignedAddr(promptDataPtr, huff.nHuffPromptDataTableSize);
				uint decodeTableSize = this.GetDecodeTableSize(huff.nHuffDecodeTableSize);
				uint promptTableSize = this.GetPromptTableSize(huff.nHuffOffsetTableSize);
				byte[] array4;
				if (this.IsNGCHControlHeadLLP() || this.Is4ByteAlignmentLLP())
				{
					uint num = global::System.Math.Max(decodeTableSize, promptTableSize);
					array4 = new byte[num];
					byte[] array5 = new byte[decodeTableSize];
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.CopyData(huff.pHuffDecodeTable, array5, 0U, decodeTableSize);
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.AddPadToLLPWhenSave(array4, array5);
				}
				else
				{
					array4 = new byte[decodeTableSize];
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.CopyData(huff.pHuffDecodeTable, array4, 0U, decodeTableSize);
				}
				if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(array4);
				}
				global::System.Array.Copy(array4, 0L, array, (long)((ulong)decodeTableAlignedAddr), (long)((ulong)decodeTableSize));
				uint promptTableAlignedAddr = this.GetPromptTableAlignedAddr(decodeTableAlignedAddr, huff.nHuffDecodeTableSize);
				byte[] array6 = new byte[promptTableSize];
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.CopyData(huff.pHuffOffsetTable, array6, 0U, promptTableSize);
				if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.LittleEndian)
				{
					global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(array6);
				}
				global::System.Array.Copy(array6, 0L, array, (long)((ulong)promptTableAlignedAddr), (long)((ulong)promptTableSize));
				uint idsTableAlignedAddr = this.GetIdsTableAlignedAddr(promptTableAlignedAddr, huff.nHuffOffsetTableSize);
				uint idsTableSize = this.GetIdsTableSize();
				global::System.Array.Copy(this.Data, (int)this.IdsTablePtr, array, (int)idsTableAlignedAddr, (int)idsTableSize);
				global::System.Array.Copy(array, this.Data, array.Length);
				base.UpdateImageChecksum(this.Data);
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException)
			{
				throw;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Motorola.Common.Communication.TetraUtility.CCustomException(global::Motorola.Common.Communication.CommonUtil.CommRC.RD5065_FP_BuildLLPFail.ToString(), "build llp fail!", innerException);
			}
			finally
			{
				global::Motorola.Common.Communication.TetraUtility.Huffman.FreeHuff(huff);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00006A38 File Offset: 0x00004C38
		protected override bool InfoByteReverse()
		{
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.InfoByteReverse(this._llpInfo);
			return true;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006A48 File Offset: 0x00004C48
		private byte[] GenerateLLPInforRawData()
		{
			global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t fp_lls_pack_info_t = new global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t(this._llpInfo);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.InfoByteReverse(fp_lls_pack_info_t);
			}
			return fp_lls_pack_info_t.GenerateRawData();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00006A78 File Offset: 0x00004C78
		private byte[] GenerateLLPHeaderRawData()
		{
			global::Motorola.Common.Communication.CommonUtil.fp_header_t fp_header_t = new global::Motorola.Common.Communication.CommonUtil.fp_header_t(this._llpHeader);
			if (this._byteOrder == global::Motorola.Common.Communication.TetraUtility.ByteOrder.BigEndian)
			{
				global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.InfoByteReverse(fp_header_t);
			}
			return fp_header_t.GeneratellpHeaderData();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006AA8 File Offset: 0x00004CA8
		private unsafe static void CopyData(byte* source, byte[] des, uint desStartIndex, uint length)
		{
			try
			{
				int num = 0;
				while ((long)num < (long)((ulong)length))
				{
					des[(int)(checked((global::System.IntPtr)(unchecked((long)num + (long)((ulong)desStartIndex)))))] = source[num];
					num++;
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006AE4 File Offset: 0x00004CE4
		private static void RearrangeLLPDecodeTable(byte[] data, uint decodeTableIndex, uint byteSizeDecodeTab)
		{
			byte[] array = new byte[byteSizeDecodeTab];
			global::System.Array.Copy(data, (long)((ulong)decodeTableIndex), array, 0L, (long)((ulong)byteSizeDecodeTab));
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.RearrangeLLPDecodeTable(array);
			global::System.Array.Copy(array, 0L, data, (long)((ulong)decodeTableIndex), (long)((ulong)byteSizeDecodeTab));
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006B1C File Offset: 0x00004D1C
		private static void RearrangeLLPDecodeTable(byte[] dataWithPad)
		{
			byte[] array = new byte[dataWithPad.Length];
			int num = 0;
			for (int i = 0; i < dataWithPad.Length / 2; i++)
			{
				if (i % 4 != 3)
				{
					array[num++] = dataWithPad[2 * i];
					array[num++] = dataWithPad[2 * i + 1];
				}
			}
			array.CopyTo(dataWithPad, 0);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006B6C File Offset: 0x00004D6C
		private static void AddPadToLLPWhenSave(byte[] dataWithPad, byte[] decodeTable)
		{
			if (dataWithPad == null)
			{
				throw new global::System.NotImplementedException();
			}
			int num = decodeTable.Length;
			int num2 = 0;
			for (int i = 0; i < num / 2; i++)
			{
				if (i % 4 != 3)
				{
					dataWithPad[2 * i] = decodeTable[num2++];
					dataWithPad[2 * i + 1] = decodeTable[num2++];
				}
				else
				{
					dataWithPad[2 * i] = 0;
					dataWithPad[2 * i + 1] = 0;
				}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006BC6 File Offset: 0x00004DC6
		private static void ReverseLLPDataTable(byte[] data)
		{
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(data, 0U, (uint)data.Length);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00006BD2 File Offset: 0x00004DD2
		private static void ReverseLLPDataTable(byte[] data, uint size)
		{
			global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.ReverseLLPDataTable(data, 0U, size);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00006BDC File Offset: 0x00004DDC
		private static void ReverseLLPDataTable(byte[] data, uint startIdx, uint size)
		{
			int num = 2;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)size / (ulong)((long)num)))
			{
				long num3 = (long)(num2 * num) + (long)((ulong)startIdx);
				checked
				{
					byte b = data[(int)((global::System.IntPtr)num3)];
					data[(int)((global::System.IntPtr)num3)] = data[(int)((global::System.IntPtr)(unchecked(num3 + 1L)))];
					data[(int)((global::System.IntPtr)(unchecked(num3 + 1L)))] = b;
				}
				num2++;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00006C1C File Offset: 0x00004E1C
		private static void GetLLPMsgAbbrFromPromptTableEntry(string line, out string msg, out string abbr)
		{
			string.IsNullOrEmpty(line);
			int num = line.IndexOf('|');
			if (num >= 0)
			{
				msg = line.Substring(0, num);
				abbr = line.Substring(num + 1, line.Length - num - 1);
				return;
			}
			msg = line;
			abbr = line;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00006C63 File Offset: 0x00004E63
		private bool IsNGCHControlHeadLLP()
		{
			return this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.NGCHLLP;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006C6E File Offset: 0x00004E6E
		private bool IsGemstoneBMPLLP()
		{
			return this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.GemstoneBMPLLP;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00006C79 File Offset: 0x00004E79
		private bool Is4ByteAlignmentLLP()
		{
			return this._llpType == global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType.FourByteAlignmentLLP;
		}

		// Token: 0x0400002F RID: 47
		public const uint TYPE_SIZE_PROMPT_DATA = 1U;

		// Token: 0x04000030 RID: 48
		public const uint TYPE_SIZE_DECODE_TABLE = 6U;

		// Token: 0x04000031 RID: 49
		public const uint TYPE_SIZE_DECODE_TABLE_NGCH = 8U;

		// Token: 0x04000032 RID: 50
		public const uint TYPE_SIZE_PROMPT_TABLE = 2U;

		// Token: 0x04000033 RID: 51
		public const uint TYPE_SIZE_STRING_IDS_TABLE = 1U;

		// Token: 0x04000034 RID: 52
		public const string UDL_NAME = "Language User Defined";

		// Token: 0x04000035 RID: 53
		private global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t _llpInfo = new global::Motorola.Common.Communication.CommonUtil.fp_lls_pack_info_t();

		// Token: 0x04000036 RID: 54
		private global::Motorola.Common.Communication.CommonUtil.fp_header_t _llpHeader = new global::Motorola.Common.Communication.CommonUtil.fp_header_t();

		// Token: 0x04000037 RID: 55
		private uint _promptDataPtr;

		// Token: 0x04000038 RID: 56
		private uint _decodeTablePtr;

		// Token: 0x04000039 RID: 57
		private uint _promptTablePtr;

		// Token: 0x0400003A RID: 58
		private uint _idsTablePtr;

		// Token: 0x0400003B RID: 59
		private uint _reserved;

		// Token: 0x0400003C RID: 60
		private global::Motorola.Common.Communication.TetraUtility.FPLocalLanguage.LLPType _llpType;

		// Token: 0x02000013 RID: 19
		public enum LLPType
		{
			// Token: 0x0400003E RID: 62
			NormalLLP,
			// Token: 0x0400003F RID: 63
			NGCHLLP,
			// Token: 0x04000040 RID: 64
			GemstoneBMPLLP,
			// Token: 0x04000041 RID: 65
			FourByteAlignmentLLP
		}
	}
}
