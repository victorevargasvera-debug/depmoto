using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000038 RID: 56
	public class LanguagePackInfo
	{
		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000042EE File Offset: 0x000024EE
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000042F6 File Offset: 0x000024F6
		public string PackID { get; internal set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000042FF File Offset: 0x000024FF
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00004307 File Offset: 0x00002507
		public uint MajorVersion { get; internal set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004310 File Offset: 0x00002510
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00004318 File Offset: 0x00002518
		public uint MinorVersion { get; internal set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004321 File Offset: 0x00002521
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00004329 File Offset: 0x00002529
		public uint Size { get; internal set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004332 File Offset: 0x00002532
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000433A File Offset: 0x0000253A
		public string Name { get; internal set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00004343 File Offset: 0x00002543
		// (set) Token: 0x0600009C RID: 156 RVA: 0x0000434B File Offset: 0x0000254B
		public string TTSLanguageCode { get; internal set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00004354 File Offset: 0x00002554
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000435C File Offset: 0x0000255C
		public byte TTSVoiceGender { get; internal set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00004365 File Offset: 0x00002565
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000436D File Offset: 0x0000256D
		public uint TTSSpeakerNameSize { get; internal set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00004376 File Offset: 0x00002576
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000437E File Offset: 0x0000257E
		public string TTSSpeakerName { get; internal set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00004387 File Offset: 0x00002587
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000438F File Offset: 0x0000258F
		public uint TTSNameSize { get; internal set; }
	}
}
