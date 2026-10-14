using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.Serialization.DataContract]
	public enum SpecialValidationMethod
	{
		// Token: 0x04000124 RID: 292
		[global::System.Runtime.Serialization.EnumMember]
		PCRCodeplugPassword,
		// Token: 0x04000125 RID: 293
		[global::System.Runtime.Serialization.EnumMember]
		PCRFlashSize,
		// Token: 0x04000126 RID: 294
		[global::System.Runtime.Serialization.EnumMember]
		PCRDigitalFw,
		// Token: 0x04000127 RID: 295
		[global::System.Runtime.Serialization.EnumMember]
		PCRDigitalPhonePatch
	}
}
