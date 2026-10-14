using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000085 RID: 133
	internal class ParametersToInternalParametersMarshaler : global::System.Runtime.InteropServices.ICustomMarshaler
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x000052FC File Offset: 0x000042FC
		public object MarshalNativeToManaged(global::System.IntPtr pNativeData)
		{
			if (pNativeData == (global::System.IntPtr)0)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalNativeToManaged(IntPtr pNativeData)");
			}
			return new global::ADODB.InternalParameters((global::ADODB.Parameters)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pNativeData));
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00005348 File Offset: 0x00004348
		public global::System.IntPtr MarshalManagedToNative(object ManagedObj)
		{
			if (ManagedObj == null)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalManagedToNative(IntPtr pNativeData)");
			}
			return ((global::ADODB.InternalParameters)ManagedObj).GetParms();
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00005384 File Offset: 0x00004384
		public void CleanUpNativeData(global::System.IntPtr pNativeData)
		{
			global::System.Runtime.InteropServices.Marshal.Release(pNativeData);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00005398 File Offset: 0x00004398
		public void CleanUpManagedData(object o)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000053A8 File Offset: 0x000043A8
		public int GetNativeDataSize()
		{
			return -1;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000053BC File Offset: 0x000043BC
		public static global::System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
		{
			if (global::ADODB.ParametersToInternalParametersMarshaler.m_me == null)
			{
				global::ADODB.ParametersToInternalParametersMarshaler.m_me = new global::ADODB.ParametersToInternalParametersMarshaler();
			}
			return global::ADODB.ParametersToInternalParametersMarshaler.m_me;
		}

		// Token: 0x040001FF RID: 511
		private static global::ADODB.ParametersToInternalParametersMarshaler m_me = null;
	}
}
