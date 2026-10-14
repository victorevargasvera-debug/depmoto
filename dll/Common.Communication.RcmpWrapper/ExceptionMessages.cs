using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication
{
	// Token: 0x02000036 RID: 54
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::System.CodeDom.Compiler.GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class ExceptionMessages
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00004211 File Offset: 0x00002411
		internal ExceptionMessages()
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000421C File Offset: 0x0000241C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(global::Motorola.Common.Communication.ExceptionMessages.resourceMan, null))
				{
					global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager("Motorola.Common.Communication.ExceptionMessages", typeof(global::Motorola.Common.Communication.ExceptionMessages).Assembly);
					global::Motorola.Common.Communication.ExceptionMessages.resourceMan = resourceManager;
				}
				return global::Motorola.Common.Communication.ExceptionMessages.resourceMan;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000425B File Offset: 0x0000245B
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00004262 File Offset: 0x00002462
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.resourceCulture;
			}
			set
			{
				global::Motorola.Common.Communication.ExceptionMessages.resourceCulture = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000426A File Offset: 0x0000246A
		internal static string BuildRcmpFail
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("BuildRcmpFail", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00004280 File Offset: 0x00002480
		internal static string InsufficientMessageBuffer
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("InsufficientMessageBuffer", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004296 File Offset: 0x00002496
		internal static string InvalidRcmpReplySize
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("InvalidRcmpReplySize", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000042AC File Offset: 0x000024AC
		internal static string InvalidReplyOpcode
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("InvalidReplyOpcode", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000042C2 File Offset: 0x000024C2
		internal static string SuperBundleNotSupported
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("SuperBundleNotSupported", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000042D8 File Offset: 0x000024D8
		internal static string UnexpectedEndOfMsg
		{
			get
			{
				return global::Motorola.Common.Communication.ExceptionMessages.ResourceManager.GetString("UnexpectedEndOfMsg", global::Motorola.Common.Communication.ExceptionMessages.resourceCulture);
			}
		}

		// Token: 0x04000107 RID: 263
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000108 RID: 264
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
