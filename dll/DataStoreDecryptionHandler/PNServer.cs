using System;
using System.Linq;
using System.Net;

// Token: 0x02000005 RID: 5
public sealed class PNServer
{
	// Token: 0x06000012 RID: 18 RVA: 0x000026C4 File Offset: 0x000008C4
	public PNServer()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002774 File Offset: 0x00000974
	public PNServer(string Name, string PWPhrase, string CipherSuite, global::System.Net.IPAddress PNServerIP, bool UdpConn, bool SecConn, ushort PNum, string CACert, string ClientCert)
	{
		this.mPNSName = Name;
		this.mPassWordPhrase = PWPhrase;
		this.mCipherSuite = CipherSuite;
		this.mPNServerIP = PNServerIP;
		this.mUDPConnection = UdpConn;
		this.mSecureConnection = SecConn;
		this.mPortNum = PNum;
		this.mPNSIp1 = this.mPNServerIP.GetAddressBytes().ElementAt(0).ToString();
		this.mPNSIp2 = this.mPNServerIP.GetAddressBytes().ElementAt(1).ToString();
		this.mPNSIp3 = this.mPNServerIP.GetAddressBytes().ElementAt(2).ToString();
		this.mPNSIp4 = this.mPNServerIP.GetAddressBytes().ElementAt(3).ToString();
		this.mRawCACert = CACert;
		this.mRawClientCert = ClientCert;
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000014 RID: 20 RVA: 0x000028E4 File Offset: 0x00000AE4
	// (set) Token: 0x06000015 RID: 21 RVA: 0x000028FC File Offset: 0x00000AFC
	public string PNSName
	{
		get
		{
			return this.mPNSName;
		}
		set
		{
			this.mPNSName = value;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000016 RID: 22 RVA: 0x00002908 File Offset: 0x00000B08
	// (set) Token: 0x06000017 RID: 23 RVA: 0x00002920 File Offset: 0x00000B20
	public string PassWordPhrase
	{
		get
		{
			return this.mPassWordPhrase;
		}
		set
		{
			this.mPassWordPhrase = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0000292C File Offset: 0x00000B2C
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00002944 File Offset: 0x00000B44
	public string CipherSuite
	{
		get
		{
			return this.mCipherSuite;
		}
		set
		{
			this.mCipherSuite = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001A RID: 26 RVA: 0x00002950 File Offset: 0x00000B50
	// (set) Token: 0x0600001B RID: 27 RVA: 0x00002968 File Offset: 0x00000B68
	public global::System.Net.IPAddress PNServerIP
	{
		get
		{
			return this.mPNServerIP;
		}
		set
		{
			this.mPNServerIP = value;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001C RID: 28 RVA: 0x00002974 File Offset: 0x00000B74
	// (set) Token: 0x0600001D RID: 29 RVA: 0x0000298C File Offset: 0x00000B8C
	public string PNSIp1
	{
		get
		{
			return this.mPNSIp1;
		}
		set
		{
			this.mPNSIp1 = value;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001E RID: 30 RVA: 0x00002998 File Offset: 0x00000B98
	// (set) Token: 0x0600001F RID: 31 RVA: 0x000029B0 File Offset: 0x00000BB0
	public string PNSIp2
	{
		get
		{
			return this.mPNSIp2;
		}
		set
		{
			this.mPNSIp2 = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000020 RID: 32 RVA: 0x000029BC File Offset: 0x00000BBC
	// (set) Token: 0x06000021 RID: 33 RVA: 0x000029D4 File Offset: 0x00000BD4
	public string PNSIp3
	{
		get
		{
			return this.mPNSIp3;
		}
		set
		{
			this.mPNSIp3 = value;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000022 RID: 34 RVA: 0x000029E0 File Offset: 0x00000BE0
	// (set) Token: 0x06000023 RID: 35 RVA: 0x000029F8 File Offset: 0x00000BF8
	public string PNSIp4
	{
		get
		{
			return this.mPNSIp4;
		}
		set
		{
			this.mPNSIp4 = value;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000024 RID: 36 RVA: 0x00002A04 File Offset: 0x00000C04
	// (set) Token: 0x06000025 RID: 37 RVA: 0x00002A1C File Offset: 0x00000C1C
	public bool UDPConn
	{
		get
		{
			return this.mUDPConnection;
		}
		set
		{
			this.mUDPConnection = value;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000026 RID: 38 RVA: 0x00002A28 File Offset: 0x00000C28
	// (set) Token: 0x06000027 RID: 39 RVA: 0x00002A40 File Offset: 0x00000C40
	public bool SecureConn
	{
		get
		{
			return this.mSecureConnection;
		}
		set
		{
			this.mSecureConnection = value;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000028 RID: 40 RVA: 0x00002A4C File Offset: 0x00000C4C
	// (set) Token: 0x06000029 RID: 41 RVA: 0x00002A64 File Offset: 0x00000C64
	public ushort PortNum
	{
		get
		{
			return this.mPortNum;
		}
		set
		{
			this.mPortNum = value;
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x0600002A RID: 42 RVA: 0x00002A70 File Offset: 0x00000C70
	// (set) Token: 0x0600002B RID: 43 RVA: 0x00002A88 File Offset: 0x00000C88
	public string CACert
	{
		get
		{
			return this.mRawCACert;
		}
		set
		{
			this.mRawCACert = value;
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x0600002C RID: 44 RVA: 0x00002A94 File Offset: 0x00000C94
	// (set) Token: 0x0600002D RID: 45 RVA: 0x00002AAC File Offset: 0x00000CAC
	public string ClientCert
	{
		get
		{
			return this.mRawClientCert;
		}
		set
		{
			this.mRawClientCert = value;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002AB8 File Offset: 0x00000CB8
	public override string ToString()
	{
		return this.mPNSName;
	}

	// Token: 0x04000013 RID: 19
	private string mPNSName = "PN Server 1";

	// Token: 0x04000014 RID: 20
	private string mPassWordPhrase = string.Empty;

	// Token: 0x04000015 RID: 21
	private string mCipherSuite = "AES:3DES:!DSS:SHA:!aNULL:!eNULL:!DES:!MD5:!IDEA:!RC2:!RC4:@STRENGTH";

	// Token: 0x04000016 RID: 22
	private global::System.Net.IPAddress mPNServerIP = new global::System.Net.IPAddress(new byte[]
	{
		127,
		0,
		0,
		1
	});

	// Token: 0x04000017 RID: 23
	private string mPNSIp1 = "127";

	// Token: 0x04000018 RID: 24
	private string mPNSIp2 = "0";

	// Token: 0x04000019 RID: 25
	private string mPNSIp3 = "0";

	// Token: 0x0400001A RID: 26
	private string mPNSIp4 = "1";

	// Token: 0x0400001B RID: 27
	private bool mUDPConnection = false;

	// Token: 0x0400001C RID: 28
	private bool mSecureConnection = false;

	// Token: 0x0400001D RID: 29
	private ushort mPortNum = 3000;

	// Token: 0x0400001E RID: 30
	private string mRawCACert = string.Empty;

	// Token: 0x0400001F RID: 31
	private string mRawClientCert = string.Empty;
}
