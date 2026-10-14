using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002A RID: 42
	[global::System.Runtime.Serialization.DataContract]
	public class AuthenticatePassword
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003354 File Offset: 0x00001554
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000335C File Offset: 0x0000155C
		[global::System.Runtime.Serialization.DataMember]
		public string Password { get; set; }

		// Token: 0x0600009A RID: 154 RVA: 0x00003365 File Offset: 0x00001565
		public AuthenticatePassword(string password)
		{
			this.Password = password;
		}
	}
}
