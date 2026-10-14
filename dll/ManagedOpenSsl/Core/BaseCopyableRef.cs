using System;
using System.Reflection;

namespace OpenSSL.Core
{
	// Token: 0x02000007 RID: 7
	public abstract class BaseCopyableRef<T> : global::OpenSSL.Core.BaseReferenceType where T : global::OpenSSL.Core.BaseCopyableRef<T>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000024C7 File Offset: 0x000006C7
		internal BaseCopyableRef(global::System.IntPtr ptr, bool takeOwnership) : base(ptr, takeOwnership)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000024D4 File Offset: 0x000006D4
		internal T CopyRef()
		{
			object[] args = new object[]
			{
				this.ptr,
				true
			};
			global::System.Reflection.BindingFlags bindingAttr = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic;
			T result = (T)((object)global::System.Activator.CreateInstance(typeof(T), bindingAttr, null, args, null));
			result.AddRef();
			return result;
		}
	}
}
