using System;
using System.Collections.Generic;

namespace Motorola.Common.Communication.SequenceManager.PbaFileProcessing
{
	// Token: 0x0200001C RID: 28
	public class ManifestObject : global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.IManifestItem
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00004927 File Offset: 0x00002B27
		public ManifestObject()
		{
			this.RemotePaths = new global::System.Collections.Generic.List<string>();
			this.MessageDigest = null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00004948 File Offset: 0x00002B48
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000495F File Offset: 0x00002B5F
		internal uint ObjectID { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004968 File Offset: 0x00002B68
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000497F File Offset: 0x00002B7F
		internal ushort FileNum { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004988 File Offset: 0x00002B88
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000499F File Offset: 0x00002B9F
		internal global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.CompressionMethod CompressionMethod { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000049A8 File Offset: 0x00002BA8
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000049BF File Offset: 0x00002BBF
		internal global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.EncryptionMethod EncryptionMethod { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000049C8 File Offset: 0x00002BC8
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000049DF File Offset: 0x00002BDF
		internal global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileObjectType ObjectType { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000049E8 File Offset: 0x00002BE8
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000049FF File Offset: 0x00002BFF
		internal uint OptionFlag { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004A08 File Offset: 0x00002C08
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00004A1F File Offset: 0x00002C1F
		internal string ObjectPath { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004A28 File Offset: 0x00002C28
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00004A3F File Offset: 0x00002C3F
		internal byte[] MessageDigest { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004A48 File Offset: 0x00002C48
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00004A5F File Offset: 0x00002C5F
		internal global::System.Collections.Generic.List<string> LocalPaths { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00004A68 File Offset: 0x00002C68
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00004A7F File Offset: 0x00002C7F
		internal global::System.Collections.Generic.List<string> RemotePaths { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00004A88 File Offset: 0x00002C88
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00004A9F File Offset: 0x00002C9F
		internal global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.FileType FileType { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004AA8 File Offset: 0x00002CA8
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00004ABF File Offset: 0x00002CBF
		internal bool AllowEmpty { get; set; }

		// Token: 0x06000081 RID: 129 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public void WriteToStream(global::Motorola.Common.Communication.SequenceManager.PbaFileProcessing.ManifestFileWriter writer)
		{
			writer.BeginWrite();
			writer.Write("objectID", this.ObjectID);
			writer.Write("fileNum", this.FileNum);
			writer.Write("CompressionMethod", (byte)this.CompressionMethod);
			writer.Write("EncryptionMethod", (byte)this.EncryptionMethod);
			writer.Write("ObjectType", (byte)this.ObjectType);
			writer.Write("OptionFlag", this.OptionFlag);
			writer.Write("ObjectPathLength", (byte)this.ObjectPath.Length);
			char[] array = new char[128];
			global::System.Array.Copy(this.ObjectPath.ToCharArray(), array, this.ObjectPath.Length);
			writer.Write("ObjectPath", array);
			writer.EndWrite();
			byte[] array2 = new byte[32];
			global::System.Array.Copy(this.MessageDigest, array2, this.MessageDigest.Length);
			writer.Write("MessageDigest", array2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004BCC File Offset: 0x00002DCC
		internal bool IsEmpty()
		{
			return this.FileNum == 0 && this.AllowEmpty;
		}
	}
}
