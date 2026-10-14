using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace SSLAdminTool
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.None)]
	[global::System.Runtime.InteropServices.Guid("f53ee959-1fc6-3d51-851f-68c583f4a0e1")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	public sealed class DataStoreDecryptHandler : global::SSLAdminTool.IDataStoreDecryptHandler
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000020D0 File Offset: 0x000002D0
		public static global::SSLAdminTool.DataStoreDecryptHandler Instance
		{
			get
			{
				return global::SSLAdminTool.DataStoreDecryptHandler.DSInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020E8 File Offset: 0x000002E8
		public bool XStoreAvailable
		{
			get
			{
				return global::System.IO.File.Exists(this.mFileStoreName);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002108 File Offset: 0x00000308
		public bool IsXStoreValid()
		{
			bool result = true;
			try
			{
				this.XStoreRead();
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002140 File Offset: 0x00000340
		public global::System.Collections.Generic.List<global::PNServer> XStoreRead()
		{
			global::System.Collections.Generic.List<global::PNServer> list = new global::System.Collections.Generic.List<global::PNServer>();
			global::System.Xml.Linq.XDocument xdocument = this.dataStoreDecryption();
			if (xdocument != null)
			{
				foreach (global::System.Xml.Linq.XElement xelement in xdocument.Elements("Servers").Elements<global::System.Xml.Linq.XElement>())
				{
					global::PNServer pnserver = new global::PNServer();
					pnserver.PNSName = xelement.Element("ServerName").Value;
					pnserver.PNServerIP = global::System.Net.IPAddress.Parse(xelement.Element("ServerIP").Value);
					pnserver.PassWordPhrase = xelement.Element("PassworPhrase").Value;
					pnserver.CipherSuite = xelement.Element("CipherSuite").Value;
					pnserver.UDPConn = bool.Parse(xelement.Element("ConnTypeUDP").Value);
					pnserver.SecureConn = bool.Parse(xelement.Element("ConnTypeSecure").Value);
					pnserver.PortNum = ushort.Parse(xelement.Element("PortNumber").Value);
					pnserver.CACert = xelement.Element("CACertRawData").Value;
					pnserver.ClientCert = xelement.Element("ClientCertRawData").Value;
					pnserver.PNSIp1 = pnserver.PNServerIP.GetAddressBytes().ElementAt(0).ToString();
					pnserver.PNSIp2 = pnserver.PNServerIP.GetAddressBytes().ElementAt(1).ToString();
					pnserver.PNSIp3 = pnserver.PNServerIP.GetAddressBytes().ElementAt(2).ToString();
					pnserver.PNSIp4 = pnserver.PNServerIP.GetAddressBytes().ElementAt(3).ToString();
					list.Add(pnserver);
				}
			}
			return list;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002384 File Offset: 0x00000584
		public string PatDataStoreRead()
		{
			byte[] bytes = this.DecDPAPI();
			return global::System.Text.Encoding.ASCII.GetString(bytes);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023AC File Offset: 0x000005AC
		public global::System.Xml.Linq.XDocument dataStoreDecryption()
		{
			global::System.Xml.Linq.XDocument result = new global::System.Xml.Linq.XDocument();
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.DecDPAPI());
				result = global::System.Xml.Linq.XDocument.Load(global::System.Xml.XmlReader.Create(memoryStream), global::System.Xml.Linq.LoadOptions.None);
				memoryStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002400 File Offset: 0x00000600
		private byte[] DecDPAPI()
		{
			byte[] result = null;
			try
			{
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(this.mFileStoreName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				byte[] array = new byte[fileStream.Length];
				int num = fileStream.Read(array, 0, (int)fileStream.Length);
				fileStream.Close();
				result = global::System.Security.Cryptography.ProtectedData.Unprotect(array, global::System.Text.Encoding.UTF8.GetBytes("ServersPortNumber"), global::System.Security.Cryptography.DataProtectionScope.LocalMachine);
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000247C File Offset: 0x0000067C
		public global::RawData GetRawCertData(string SerName)
		{
			global::RawData rawData = new global::RawData();
			global::System.Xml.Linq.XDocument xdocument = this.dataStoreDecryption();
			foreach (global::System.Xml.Linq.XElement xelement in xdocument.Elements("Servers").Elements<global::System.Xml.Linq.XElement>())
			{
				if (xelement.Element("ServerName").Value == SerName)
				{
					rawData.mRawCACert = xelement.Element("CACertRawData").Value;
					rawData.mRawCliCert = xelement.Element("ClientCertRawData").Value;
					rawData.mPassPhrase = xelement.Element("PassworPhrase").Value;
					rawData.mServerName = xelement.Element("ServerName").Value;
				}
			}
			return rawData;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002594 File Offset: 0x00000794
		public void dhUpdateEventThread()
		{
			try
			{
				string text = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + "\\Motorola\\ARSDataAdmin\\Motorola Default Certificate\\dhparam.pem";
				global::OpenSSL.Crypto.DH dh = new global::OpenSSL.Crypto.DH(2048, 5);
				dh.GenerateKeys();
				global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(text);
				fileInfo.IsReadOnly = false;
				global::OpenSSL.Core.BIO bio = global::OpenSSL.Core.BIO.File(text, "w");
				dh.WriteParametersPEM(bio);
				bio.SetClose(global::OpenSSL.Core.BIO.CloseOption.Close);
				bio.Dispose();
				dh.Dispose();
			}
			catch (global::System.Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000261C File Offset: 0x0000081C
		public bool isDHkeyExpired()
		{
			bool result = false;
			string folderPath = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
			string str = "\\Motorola\\ARSDataAdmin\\Motorola Default Certificate\\dhparam.pem";
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(folderPath + str);
			if (global::System.IO.File.Exists(folderPath + str))
			{
				if ((global::System.DateTime.Today - fileInfo.CreationTime).Days > 30)
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const string sServers = "Servers";

		// Token: 0x04000002 RID: 2
		private const string sSer = "Server";

		// Token: 0x04000003 RID: 3
		private const string sSerIP = "ServerIP";

		// Token: 0x04000004 RID: 4
		private const string sSerName = "ServerName";

		// Token: 0x04000005 RID: 5
		private const string sCARaw = "CACertRawData";

		// Token: 0x04000006 RID: 6
		private const string sCliRaw = "ClientCertRawData";

		// Token: 0x04000007 RID: 7
		private const string sPassPhrase = "PassworPhrase";

		// Token: 0x04000008 RID: 8
		private const string sCipher = "CipherSuite";

		// Token: 0x04000009 RID: 9
		private const string sUDPConn = "ConnTypeUDP";

		// Token: 0x0400000A RID: 10
		private const string sRelConn = "ConnectionTypeReliable";

		// Token: 0x0400000B RID: 11
		private const string sSecConn = "ConnTypeSecure";

		// Token: 0x0400000C RID: 12
		private const string sPNum = "PortNumber";

		// Token: 0x0400000D RID: 13
		private static readonly global::SSLAdminTool.DataStoreDecryptHandler DSInstance = new global::SSLAdminTool.DataStoreDecryptHandler();

		// Token: 0x0400000E RID: 14
		private string mFileStoreName = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData) + "\\Motorola\\ARSDataAdmin\\Data store\\ARSData.xml";
	}
}
