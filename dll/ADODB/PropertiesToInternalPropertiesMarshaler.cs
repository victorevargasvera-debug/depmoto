using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200008A RID: 138
	internal class PropertiesToInternalPropertiesMarshaler : global::System.Runtime.InteropServices.ICustomMarshaler
	{
		// Token: 0x06000471 RID: 1137 RVA: 0x00005914 File Offset: 0x00004914
		public object MarshalNativeToManaged(global::System.IntPtr pNativeData)
		{
			if (pNativeData == (global::System.IntPtr)0)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalNativeToManaged(IntPtr pNativeData)");
			}
			return new global::ADODB.InternalProperties((global::ADODB.Properties)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pNativeData));
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00005960 File Offset: 0x00004960
		public global::System.IntPtr MarshalManagedToNative(object ManagedObj)
		{
			if (ManagedObj == null)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalManagedToNative(IntPtr pNativeData)");
			}
			return ((global::ADODB.InternalProperties)ManagedObj).GetProperties();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000599C File Offset: 0x0000499C
		public void CleanUpNativeData(global::System.IntPtr pNativeData)
		{
			global::System.Runtime.InteropServices.Marshal.Release(pNativeData);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000059B0 File Offset: 0x000049B0
		public void CleanUpManagedData(object o)
		{
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000059C0 File Offset: 0x000049C0
		public int GetNativeDataSize()
		{
			return -1;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x000059D4 File Offset: 0x000049D4
		public static global::System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
		{
			if (global::ADODB.PropertiesToInternalPropertiesMarshaler.m_me == null)
			{
				global::ADODB.PropertiesToInternalPropertiesMarshaler.m_me = new global::ADODB.PropertiesToInternalPropertiesMarshaler();
			}
			return global::ADODB.PropertiesToInternalPropertiesMarshaler.m_me;
		}

		// Token: 0x04000206 RID: 518
		private static global::ADODB.PropertiesToInternalPropertiesMarshaler m_me = null;
	}
}
