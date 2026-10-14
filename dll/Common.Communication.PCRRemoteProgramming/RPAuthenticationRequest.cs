using System;
using System.Text;

namespace Motorola.Common.Communication.PCRRemoteProgramming
{
	// Token: 0x0200000E RID: 14
	public class RPAuthenticationRequest : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003072 File Offset: 0x00001272
		public RPAuthenticationRequest(bool needHdr)
		{
			base.hasReply = false;
			this.needHeader = needHdr;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00003088 File Offset: 0x00001288
		public override int BuildCommandMessage(byte[] buffer)
		{
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(global::Motorola.Common.Communication.PCRRemoteProgramming.PCRRPConstants.AUTHENTICATE_PLAIN);
			int result;
			if (this.needHeader)
			{
				byte[] array;
				global::Motorola.Common.Communication.PCRRemoteProgramming.RPAuthenticationHelper.AddTCPHeader(bytes, out array);
				global::System.Array.Copy(array, buffer, array.Length);
				result = array.Length;
			}
			else
			{
				global::System.Array.Copy(bytes, buffer, bytes.Length);
				result = bytes.Length;
			}
			return result;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000030D6 File Offset: 0x000012D6
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000052 RID: 82
		private bool needHeader;
	}
}
