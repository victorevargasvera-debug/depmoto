using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000086 RID: 134
	internal class ParameterToInternalParameterMarshaler : global::System.Runtime.InteropServices.ICustomMarshaler
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x0000540C File Offset: 0x0000440C
		public object MarshalNativeToManaged(global::System.IntPtr pNativeData)
		{
			if (pNativeData == (global::System.IntPtr)0)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalNativeToManaged(IntPtr pNativeData)");
			}
			return new global::ADODB.InternalParameter((global::ADODB.Parameter)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pNativeData));
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00005458 File Offset: 0x00004458
		public global::System.IntPtr MarshalManagedToNative(object ManagedObj)
		{
			if (ManagedObj == null)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalManagedToNative(IntPtr pNativeData)");
			}
			return global::System.Runtime.InteropServices.Marshal.GetIUnknownForObject(((global::ADODB.InternalParameter)ManagedObj).GetParam());
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000549C File Offset: 0x0000449C
		public void CleanUpNativeData(global::System.IntPtr pNativeData)
		{
			global::System.Runtime.InteropServices.Marshal.Release(pNativeData);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x000054B0 File Offset: 0x000044B0
		public void CleanUpManagedData(object o)
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000054C0 File Offset: 0x000044C0
		public int GetNativeDataSize()
		{
			return -1;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000054D4 File Offset: 0x000044D4
		public static global::System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
		{
			global::System.Runtime.InteropServices.ICustomMarshaler result;
			if (global::ADODB.ParameterToInternalParameterMarshaler.m_me == null)
			{
				result = new global::ADODB.ParameterToInternalParameterMarshaler();
			}
			else
			{
				result = global::ADODB.ParameterToInternalParameterMarshaler.m_me;
			}
			return result;
		}

		// Token: 0x04000200 RID: 512
		private static global::ADODB.ParameterToInternalParameterMarshaler m_me = null;
	}
}
