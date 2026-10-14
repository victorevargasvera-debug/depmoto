using System;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000027 RID: 39
	[global::System.Diagnostics.DebuggerDisplay("PrtID={PartitionID}, BlkTyp={BlockType}, BlkID={BlockID}, Content={Content.Length} bytes")]
	[global::System.Serializable]
	public class ValidationField
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00005E70 File Offset: 0x00004070
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00005E78 File Offset: 0x00004078
		[global::System.Xml.Serialization.XmlAttribute("Partition")]
		public byte PartitionID { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005E81 File Offset: 0x00004081
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00005E89 File Offset: 0x00004089
		[global::System.Xml.Serialization.XmlAttribute("BlockType")]
		public ushort BlockType { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00005E92 File Offset: 0x00004092
		// (set) Token: 0x06000192 RID: 402 RVA: 0x00005E9A File Offset: 0x0000409A
		[global::System.Xml.Serialization.XmlAttribute("BlockID")]
		public ushort BlockID { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00005EA3 File Offset: 0x000040A3
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00005EAB File Offset: 0x000040AB
		[global::System.Xml.Serialization.XmlAttribute("OffsetInBits")]
		public uint OffsetInBits { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005EB4 File Offset: 0x000040B4
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00005EBC File Offset: 0x000040BC
		[global::System.Xml.Serialization.XmlAttribute("LengthInBits")]
		public uint LengthInBits { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00005EC5 File Offset: 0x000040C5
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00005ECD File Offset: 0x000040CD
		[global::System.Xml.Serialization.XmlElement("Content")]
		public byte[] Content { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00005ED6 File Offset: 0x000040D6
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00005EDE File Offset: 0x000040DE
		[global::System.Xml.Serialization.XmlElement("BypassMissing")]
		public bool BypassMissing { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005EE7 File Offset: 0x000040E7
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00005EEF File Offset: 0x000040EF
		[global::System.Xml.Serialization.XmlElement("AutoFill")]
		public bool AutoFill { get; set; }

		// Token: 0x0600019D RID: 413 RVA: 0x00005EF8 File Offset: 0x000040F8
		public ValidationField()
		{
			this.PartitionID = 0;
			this.BlockType = 0;
			this.BlockID = 0;
			this.OffsetInBits = 0U;
			this.LengthInBits = 0U;
			this.Content = null;
			this.BypassMissing = false;
			this.AutoFill = false;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00005F38 File Offset: 0x00004138
		public ValidationField(byte partitionID, ushort blockType, ushort blockID, uint offsetInBits, uint lengthInBits, byte[] content, bool bypassMissing = false, global::Motorola.Common.CustomException.CommonErrorCode errorToThrow = global::Motorola.Common.CustomException.CommonErrorCode.None)
		{
			this.PartitionID = partitionID;
			this.BlockType = blockType;
			this.BlockID = blockID;
			this.OffsetInBits = offsetInBits;
			this.LengthInBits = lengthInBits;
			this.Content = content;
			this.BypassMissing = bypassMissing;
			this.ErrorToThrow = errorToThrow;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00005F88 File Offset: 0x00004188
		public ValidationField(global::Motorola.Common.Communication.Pba.ValidationField field)
		{
			this.PartitionID = field.PartitionID;
			this.BlockType = field.BlockType;
			this.BlockID = field.BlockID;
			this.OffsetInBits = field.OffsetInBits;
			this.LengthInBits = field.LengthInBits;
			this.Content = field.Content;
			this.BypassMissing = field.BypassMissing;
			this.ErrorToThrow = field.ErrorToThrow;
			this.BypassValidateWiredJob = field.BypassValidateWiredJob;
			this.AutoFill = field.AutoFill;
		}

		// Token: 0x04000108 RID: 264
		[global::System.Xml.Serialization.XmlAttribute("ErrorToThrow")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.CustomException.CommonErrorCode ErrorToThrow;

		// Token: 0x04000109 RID: 265
		[global::System.Xml.Serialization.XmlAttribute("BypassValidateWiredJob")]
		[global::System.Runtime.Serialization.OptionalField]
		public global::Motorola.Common.Communication.Pba.ValidateCode BypassValidateWiredJob;
	}
}
