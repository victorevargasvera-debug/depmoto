using System;
using System.Runtime.InteropServices;

// Token: 0x02000002 RID: 2
[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
[global::System.Runtime.InteropServices.ComVisible(false)]
public sealed class DotfuscatorAttribute : global::System.Attribute
{
	// Token: 0x06000001 RID: 1 RVA: 0x000020D4 File Offset: 0x000002D4
	public DotfuscatorAttribute(string a, int c)
	{
		this.a = a;
		this.c = c;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000002 RID: 2 RVA: 0x000020F8 File Offset: 0x000002F8
	public string A
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000003 RID: 3 RVA: 0x0000210C File Offset: 0x0000030C
	public int C
	{
		get
		{
			return this.c;
		}
	}

	// Token: 0x04000001 RID: 1
	private string a;

	// Token: 0x04000002 RID: 2
	private int c;
}
