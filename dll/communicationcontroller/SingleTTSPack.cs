using System;

namespace CommunicationController
{
	// Token: 0x02000011 RID: 17
	public class SingleTTSPack
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000027F8 File Offset: 0x000017F8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002854 File Offset: 0x00001854
		public string MajMinVersion
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return this.MajorVersion + "." + this.MinorVersion;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 2;
					string[] array;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (array.Length == 2)
							{
								goto IL_C5;
							}
							goto IL_49;
						case 1:
							goto IL_D1;
						case 3:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C5;
							}
							if (false)
							{
							}
							array = value.Split(new string[]
							{
								"."
							}, global::System.StringSplitOptions.None);
							num = 0;
							continue;
						}
						if (value != null)
						{
							if (true)
							{
							}
							num = 3;
							continue;
						}
						goto IL_D3;
						IL_C5:
						num = 1;
					}
					IL_49:
					throw new global::System.ArgumentException("TTS Language Pack Version not correctly formatted.");
					IL_D1:
					uint majorVersion = uint.Parse(array[0]);
					uint minorVersion = uint.Parse(array[1]);
					this.MajorVersion = majorVersion;
					this.MinorVersion = minorVersion;
					return;
					IL_D3:
					throw new global::System.ArgumentNullException("TTS Language Pack Version cannot be null.");
				}
				}
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002940 File Offset: 0x00001940
		public SingleTTSPack()
		{
			this.ID = string.Empty;
			this.MajorVersion = 0U;
			this.MinorVersion = 0U;
			this.Size = 0U;
			this.LangCode = string.Empty;
			this.VoiceGender = 0;
			this.SpeakerName = string.Empty;
			this.Name = string.Empty;
			this.PackData = null;
		}

		// Token: 0x04000036 RID: 54
		public string ID;

		// Token: 0x04000037 RID: 55
		public uint MajorVersion;

		// Token: 0x04000038 RID: 56
		public uint MinorVersion;

		// Token: 0x04000039 RID: 57
		public uint Size;

		// Token: 0x0400003A RID: 58
		public string LangCode;

		// Token: 0x0400003B RID: 59
		public byte VoiceGender;

		// Token: 0x0400003C RID: 60
		public string SpeakerName;

		// Token: 0x0400003D RID: 61
		public string Name;

		// Token: 0x0400003E RID: 62
		public byte[] PackData;
	}
}
