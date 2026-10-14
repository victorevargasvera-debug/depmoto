using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001B RID: 27
	[global::System.Serializable]
	public class DataBlock
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002D8B File Offset: 0x00000F8B
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002D93 File Offset: 0x00000F93
		[global::System.Xml.Serialization.XmlAttribute("Type")]
		public ushort BlockType { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00002D9C File Offset: 0x00000F9C
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[global::System.Xml.Serialization.XmlAttribute("ID")]
		public ushort BlockID { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00002DAD File Offset: 0x00000FAD
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002DB5 File Offset: 0x00000FB5
		[global::System.Xml.Serialization.XmlAttribute("Size")]
		public int LegthInBits { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002DBE File Offset: 0x00000FBE
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002DC6 File Offset: 0x00000FC6
		public byte[] PacketValue { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002DCF File Offset: 0x00000FCF
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public int Offset { get; set; }

		// Token: 0x060000C1 RID: 193 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public DataBlock()
		{
			this.LegthInBits = 0;
			this.PacketValue = null;
			this.Offset = 0;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002E00 File Offset: 0x00001000
		public void Initialize(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> block)
		{
			this.BlockID = block.Key.IshID;
			this.BlockType = block.Key.IshType;
			this.LegthInBits = block.Value.ItemSize * 8;
			if (this.LegthInBits != 0)
			{
				this.PacketValue = new byte[block.Value.Data.Length];
				global::System.Array.Copy(block.Value.Data, this.PacketValue, block.Value.Data.Length);
				return;
			}
			this.PacketValue = null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002EA8 File Offset: 0x000010A8
		public void Initialize(global::System.Collections.Generic.KeyValuePair<ushort, byte[]> fdiBlock)
		{
			this.BlockID = fdiBlock.Key;
			this.BlockType = 0;
			this.LegthInBits = fdiBlock.Value.Length * 8;
			this.PacketValue = new byte[fdiBlock.Value.Length];
			global::System.Array.Copy(fdiBlock.Value, this.PacketValue, fdiBlock.Value.Length);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002F09 File Offset: 0x00001109
		public void Initialize(byte[] cpImage)
		{
			this.BlockID = 0;
			this.BlockType = 0;
			this.LegthInBits = cpImage.Length * 8;
			this.PacketValue = new byte[cpImage.Length];
			global::System.Array.Copy(cpImage, this.PacketValue, cpImage.Length);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002F41 File Offset: 0x00001141
		public void UpdateWithNewData(global::Motorola.Common.Communication.Pba.DataBlock newDataBlock)
		{
			this.LegthInBits = newDataBlock.LegthInBits;
			this.Offset = newDataBlock.Offset;
			this.PacketValue = newDataBlock.PacketValue;
		}
	}
}
