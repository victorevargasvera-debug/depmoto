using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000002 RID: 2
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo))]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.PcrLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.AstroFilePackInfo))]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.Common.Communication.Pba.TTSLanguagePackInfo))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.TetraLanguagePackInfo))]
	[global::System.Xml.Serialization.XmlInclude(typeof(global::Motorola.Common.Communication.Pba.AstroFilePackInfo))]
	[global::System.Serializable]
	public class LanguagePackBase
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		[global::System.Runtime.Serialization.DataMember]
		public string sourceFilePath { get; set; }
	}
}
