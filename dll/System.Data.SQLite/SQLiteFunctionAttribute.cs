using System;

namespace System.Data.SQLite
{
	// Token: 0x02000045 RID: 69
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public sealed class SQLiteFunctionAttribute : global::System.Attribute
	{
		// Token: 0x0600032B RID: 811 RVA: 0x0001D88C File Offset: 0x0001CC8C
		public SQLiteFunctionAttribute() : this(string.Empty, -1, global::System.Data.SQLite.FunctionType.Scalar)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0001D8A8 File Offset: 0x0001CCA8
		public SQLiteFunctionAttribute(string name, int argumentCount, global::System.Data.SQLite.FunctionType functionType)
		{
			this._name = name;
			this._argumentCount = argumentCount;
			this._functionType = functionType;
			this._instanceType = null;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0001D8D8 File Offset: 0x0001CCD8
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0001D8EC File Offset: 0x0001CCEC
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0001D900 File Offset: 0x0001CD00
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0001D914 File Offset: 0x0001CD14
		public int Arguments
		{
			get
			{
				return this._argumentCount;
			}
			set
			{
				this._argumentCount = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0001D928 File Offset: 0x0001CD28
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0001D93C File Offset: 0x0001CD3C
		public global::System.Data.SQLite.FunctionType FuncType
		{
			get
			{
				return this._functionType;
			}
			set
			{
				this._functionType = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0001D950 File Offset: 0x0001CD50
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0001D964 File Offset: 0x0001CD64
		internal global::System.Type InstanceType
		{
			get
			{
				return this._instanceType;
			}
			set
			{
				this._instanceType = value;
			}
		}

		// Token: 0x0400018A RID: 394
		private string _name;

		// Token: 0x0400018B RID: 395
		private int _argumentCount;

		// Token: 0x0400018C RID: 396
		private global::System.Data.SQLite.FunctionType _functionType;

		// Token: 0x0400018D RID: 397
		private global::System.Type _instanceType;
	}
}
