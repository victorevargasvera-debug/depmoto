using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Security
{
	// Token: 0x0200000E RID: 14
	public struct AuthenticationMaterials
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x0002022C File Offset: 0x0001F62C
		public AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode Mode, int CertType, int StrType, string CertFile, string PublicKey, string Pswd)
		{
			this.EndpointMode = Mode;
			this.CertType = (global::Motorola.Common.Communication.Security.AuthenType)CertType;
			this.StrType = (global::Motorola.Common.Communication.Security.StreamType)StrType;
			this.Certificate_File = global::System.Text.Encoding.ASCII.GetBytes(CertFile);
			this.Public_Key = global::System.Text.Encoding.ASCII.GetBytes(PublicKey);
			this.Password = global::System.Text.Encoding.ASCII.GetBytes(Pswd);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000201CC File Offset: 0x0001F5CC
		public AuthenticationMaterials(global::Motorola.Common.Communication.Security.SecurityEndpointMode Mode, string authMaterials1, string authMaterials2)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(authMaterials1);
			this.AuthMaterials1 = bytes;
			this.AuthMaterials1_len = bytes.Length;
			if (Mode == global::Motorola.Common.Communication.Security.SecurityEndpointMode.CLIENT)
			{
				this.AuthMaterials2 = global::Motorola.Common.Communication.CommonUtil.UtilityMethods.HexString2ByteArray(authMaterials2);
			}
			else
			{
				this.AuthMaterials2 = global::System.Text.Encoding.ASCII.GetBytes(authMaterials2);
			}
			this.AuthMaterials2_len = this.AuthMaterials2.Length;
			this.EndpointMode = Mode;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0001FF20 File Offset: 0x0001F320
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0001FF04 File Offset: 0x0001F304
		public byte[] PSK_VALUE
		{
			get
			{
				return this.AuthMaterials2;
			}
			set
			{
				this.AuthMaterials2 = value;
				this.AuthMaterials2_len = value.Length;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0001FF50 File Offset: 0x0001F350
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0001FF34 File Offset: 0x0001F334
		public byte[] PSK_ID
		{
			get
			{
				return this.AuthMaterials1;
			}
			set
			{
				this.AuthMaterials1 = value;
				this.AuthMaterials1_len = value.Length;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0001FF64 File Offset: 0x0001F364
		public int KEY_LEN
		{
			get
			{
				return this.AuthMaterials2_len;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0001FF78 File Offset: 0x0001F378
		public int KEY_ID_LEN
		{
			get
			{
				return this.AuthMaterials1_len;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0001FF20 File Offset: 0x0001F320
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0001FF04 File Offset: 0x0001F304
		public byte[] CERT_PSWD
		{
			get
			{
				return this.AuthMaterials2;
			}
			set
			{
				this.AuthMaterials2 = value;
				this.AuthMaterials2_len = value.Length;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0001FF50 File Offset: 0x0001F350
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0001FF34 File Offset: 0x0001F334
		public byte[] CERT_FILE
		{
			get
			{
				return this.AuthMaterials1;
			}
			set
			{
				this.AuthMaterials1 = value;
				this.AuthMaterials1_len = value.Length;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0001FF64 File Offset: 0x0001F364
		public int CERT_PSWD_LEN
		{
			get
			{
				return this.AuthMaterials2_len;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0001FF78 File Offset: 0x0001F378
		public int CERT_FILE_LEN
		{
			get
			{
				return this.AuthMaterials1_len;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0001FFA0 File Offset: 0x0001F3A0
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0001FF8C File Offset: 0x0001F38C
		public global::Motorola.Common.Communication.Security.SecurityEndpointMode Mode
		{
			get
			{
				return this.EndpointMode;
			}
			set
			{
				this.EndpointMode = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0001FFC8 File Offset: 0x0001F3C8
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0001FFB4 File Offset: 0x0001F3B4
		public global::Motorola.Common.Communication.Security.AuthenType CERTTYPE
		{
			get
			{
				return this.CertType;
			}
			set
			{
				this.CertType = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0001FFF0 File Offset: 0x0001F3F0
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0001FFDC File Offset: 0x0001F3DC
		public global::Motorola.Common.Communication.Security.StreamType STREAMTYPE
		{
			get
			{
				return this.StrType;
			}
			set
			{
				this.StrType = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00020018 File Offset: 0x0001F418
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00020004 File Offset: 0x0001F404
		public global::System.ValueType SELF
		{
			get
			{
				return this.self;
			}
			set
			{
				this.self = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00020040 File Offset: 0x0001F440
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0002002C File Offset: 0x0001F42C
		public byte[] CERTIFICATE_FILE
		{
			get
			{
				return this.Certificate_File;
			}
			set
			{
				this.Certificate_File = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00020068 File Offset: 0x0001F468
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00020054 File Offset: 0x0001F454
		public byte[] PUBLIC_KEY
		{
			get
			{
				return this.Public_Key;
			}
			set
			{
				this.Public_Key = value;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00020090 File Offset: 0x0001F490
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0002007C File Offset: 0x0001F47C
		public byte[] PASSWORD
		{
			get
			{
				return this.Password;
			}
			set
			{
				this.Password = value;
			}
		}

		// Token: 0x04000060 RID: 96
		private byte[] AuthMaterials2;

		// Token: 0x04000061 RID: 97
		private int AuthMaterials2_len;

		// Token: 0x04000062 RID: 98
		private byte[] AuthMaterials1;

		// Token: 0x04000063 RID: 99
		private int AuthMaterials1_len;

		// Token: 0x04000064 RID: 100
		private global::Motorola.Common.Communication.Security.AuthenType CertType;

		// Token: 0x04000065 RID: 101
		private global::Motorola.Common.Communication.Security.StreamType StrType;

		// Token: 0x04000066 RID: 102
		private byte[] Certificate_File;

		// Token: 0x04000067 RID: 103
		private byte[] Public_Key;

		// Token: 0x04000068 RID: 104
		private byte[] Password;

		// Token: 0x04000069 RID: 105
		private global::Motorola.Common.Communication.Security.SecurityEndpointMode EndpointMode;

		// Token: 0x0400006A RID: 106
		private global::System.ValueType self;
	}
}
