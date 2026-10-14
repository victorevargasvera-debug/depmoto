using System;
using System.Collections;
using System.Text;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x0200000F RID: 15
	public class RPAuthenticationMessage : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000030DD File Offset: 0x000012DD
		public bool PASS
		{
			get
			{
				return this.AuthenticationIsPass;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000030E5 File Offset: 0x000012E5
		public RPAuthenticationMessage(string user, string pwd, bool needHdr)
		{
			this.username = user;
			this.password = pwd;
			this.needHeader = needHdr;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003118 File Offset: 0x00001318
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			global::System.Collections.ArrayList arrayList = global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationHelper.CvtUnicodeString2ByteArrayList(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.NUL_STRING);
			byte[] array = new byte[arrayList.Count];
			arrayList.CopyTo(array);
			arrayList = global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationHelper.CvtUnicodeString2ByteArrayList(this.username);
			byte[] array2 = new byte[arrayList.Count];
			arrayList.CopyTo(array2);
			arrayList = global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationHelper.CvtUnicodeString2ByteArrayList(this.password);
			byte[] array3 = new byte[arrayList.Count];
			arrayList.CopyTo(array3);
			byte[] array4;
			if (this.password != global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.NUL_STRING)
			{
				array4 = new byte[array2.Length + array3.Length + array.Length * 2];
			}
			else
			{
				array4 = new byte[array2.Length + array.Length * 2];
			}
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				array4[num] = array[i];
				num++;
			}
			for (int j = 0; j < array2.Length; j++)
			{
				array4[num] = array2[j];
				num++;
			}
			for (int k = 0; k < array.Length; k++)
			{
				array4[num] = array[k];
				num++;
			}
			if (this.password != global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.NUL_STRING)
			{
				for (int l = 0; l < array3.Length; l++)
				{
					array4[num] = array3[l];
					num++;
				}
			}
			int result;
			if (this.needHeader)
			{
				byte[] array5;
				global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationHelper.AddTCPHeader(array4, out array5);
				global::System.Array.Copy(array5, sendBuffer, array5.Length);
				result = array5.Length;
			}
			else
			{
				global::System.Array.Copy(array4, sendBuffer, array4.Length);
				result = array4.Length;
			}
			return result;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003290 File Offset: 0x00001490
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			if (length >= 2)
			{
				if (this.needHeader)
				{
					offset += 2;
				}
				string @string = global::System.Text.Encoding.ASCII.GetString(replyBuffer, offset, 2);
				if (@string == global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.OK)
				{
					this.AuthenticationIsPass = true;
				}
			}
		}

		// Token: 0x04000053 RID: 83
		private bool AuthenticationIsPass;

		// Token: 0x04000054 RID: 84
		private bool needHeader;

		// Token: 0x04000055 RID: 85
		private string username = string.Empty;

		// Token: 0x04000056 RID: 86
		private string password = string.Empty;
	}
}
