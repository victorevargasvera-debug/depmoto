using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000011 RID: 17
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TTSLanguagePackInfo : global::Motorola.Common.Communication.Pba.LanguagePackBase
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002708 File Offset: 0x00000908
		[global::System.Runtime.Serialization.DataMember]
		public uint MajorVersion { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002711 File Offset: 0x00000911
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002719 File Offset: 0x00000919
		[global::System.Runtime.Serialization.DataMember]
		public uint MinorVersion { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002722 File Offset: 0x00000922
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000272A File Offset: 0x0000092A
		[global::System.Runtime.Serialization.DataMember]
		public uint Size { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002733 File Offset: 0x00000933
		// (set) Token: 0x06000076 RID: 118 RVA: 0x0000273B File Offset: 0x0000093B
		[global::System.Runtime.Serialization.DataMember]
		public string Name { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002744 File Offset: 0x00000944
		// (set) Token: 0x06000078 RID: 120 RVA: 0x0000274C File Offset: 0x0000094C
		[global::System.Runtime.Serialization.DataMember]
		public string PackID { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002755 File Offset: 0x00000955
		// (set) Token: 0x0600007A RID: 122 RVA: 0x0000275D File Offset: 0x0000095D
		[global::System.Runtime.Serialization.DataMember]
		public string PackFilePath { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002766 File Offset: 0x00000966
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000276E File Offset: 0x0000096E
		[global::System.Runtime.Serialization.DataMember]
		public string SpeakerName { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002777 File Offset: 0x00000977
		// (set) Token: 0x0600007E RID: 126 RVA: 0x0000277F File Offset: 0x0000097F
		[global::System.Runtime.Serialization.DataMember]
		public string LanguageCode { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002788 File Offset: 0x00000988
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002790 File Offset: 0x00000990
		[global::System.Runtime.Serialization.DataMember]
		public byte VoiceGender { get; set; }

		// Token: 0x06000081 RID: 129 RVA: 0x0000279C File Offset: 0x0000099C
		public TTSLanguagePackInfo()
		{
			this.PackFilePath = null;
			this.MajorVersion = 0U;
			this.MinorVersion = 0U;
			this.Size = 0U;
			this.PackID = null;
			this.Name = null;
			base.sourceFilePath = null;
			this.SpeakerName = null;
			this.LanguageCode = null;
			this.VoiceGender = 0;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000027F8 File Offset: 0x000009F8
		public string GetVersionString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}.{1}", new object[]
			{
				this.MajorVersion,
				this.MinorVersion
			});
		}
	}
}
