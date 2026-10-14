using System;
using System.IO;
using System.Xml;

namespace AcpCryptoLib
{
	// Token: 0x0200000B RID: 11
	public interface IAcpXMLEncryptDecrypt
	{
		// Token: 0x06000036 RID: 54
		void EncryptXMLFile(string inputFileName, string outputFileName);

		// Token: 0x06000037 RID: 55
		void EncryptXMLDoc(global::System.Xml.XmlDocument Doc, string outputFileName);

		// Token: 0x06000038 RID: 56
		global::System.Xml.XmlDocument DecryptXMLFile(string inputFileName);

		// Token: 0x06000039 RID: 57
		global::System.Xml.XmlDocument DecryptXMLFile(global::System.IO.Stream inputStream);
	}
}
