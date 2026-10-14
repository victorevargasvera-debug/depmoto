using System;
using System.Reflection;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000081 RID: 129
	internal class WeakDelegate
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		public WeakDelegate(global::System.Delegate del)
		{
			if (del == null)
			{
				return;
			}
			this._method = del.Method;
			this._target = new global::System.WeakReference(del.Target);
			this._delType = del.GetType();
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000FDE5 File Offset: 0x0000DFE5
		public object Target
		{
			get
			{
				return this._target.Target;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000FDF2 File Offset: 0x0000DFF2
		public global::System.Reflection.MethodInfo Method
		{
			get
			{
				return this._method;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000FDFA File Offset: 0x0000DFFA
		public global::System.Type DelegateType
		{
			get
			{
				return this._delType;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000FE02 File Offset: 0x0000E002
		public bool IsValid
		{
			get
			{
				return !(this.Method == null) && (this.Method.IsStatic || this.Target != null);
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000FE30 File Offset: 0x0000E030
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (object.ReferenceEquals(this, obj))
			{
				return true;
			}
			if (base.GetType() != obj.GetType())
			{
				return false;
			}
			global::Motorola.Common.Communication.TetraUtility.WeakDelegate weakDelegate = obj as global::Motorola.Common.Communication.TetraUtility.WeakDelegate;
			return object.ReferenceEquals(this.Target, weakDelegate.Target) && this.Method.Equals(weakDelegate.Method) && this.DelegateType.Equals(weakDelegate.DelegateType);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000FEA2 File Offset: 0x0000E0A2
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x040003EC RID: 1004
		private global::System.Reflection.MethodInfo _method;

		// Token: 0x040003ED RID: 1005
		private global::System.WeakReference _target;

		// Token: 0x040003EE RID: 1006
		private global::System.Type _delType;
	}
}
