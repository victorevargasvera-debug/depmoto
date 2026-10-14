using System;
using System.Runtime.InteropServices;

namespace XnlAuthenticationDotNet
{
	// Token: 0x020000D6 RID: 214
	public class XnlAuthentication
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00001014 File Offset: 0x00000414
		public static byte[] EncryptAuthKey(byte[] unencrypted)
		{
			byte[] array = new byte[8];
			ref byte byte& = ref array[0];
			ref byte byte&2 = ref unencrypted[0];
			if (global::<Module>.XNL.XNLAuth_EncryptAuthKey(ref byte&2, unencrypted.Length, ref byte&, array.Length) == null)
			{
				return array;
			}
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00001048 File Offset: 0x00000448
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
		public static bool ValidateEncryptedAuthKey(byte[] authenticationValue, byte[] privateValue)
		{
			ref byte byte& = ref authenticationValue[0];
			ref byte byte&2 = ref privateValue[0];
			return global::<Module>.XNL.XNLAuth_ValidateEncryptedAuthKey(ref byte&, authenticationValue.Length, ref byte&2, privateValue.Length) == 0;
		}
	}
}
