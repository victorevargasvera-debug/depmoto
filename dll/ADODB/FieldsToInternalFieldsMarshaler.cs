using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x02000081 RID: 129
	internal class FieldsToInternalFieldsMarshaler : global::System.Runtime.InteropServices.ICustomMarshaler
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00004D60 File Offset: 0x00003D60
		public object MarshalNativeToManaged(global::System.IntPtr pNativeData)
		{
			if (pNativeData == (global::System.IntPtr)0)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalNativeToManaged(IntPtr pNativeData)");
			}
			return new global::ADODB.InternalFields((global::ADODB.Fields)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pNativeData));
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00004DAC File Offset: 0x00003DAC
		public global::System.IntPtr MarshalManagedToNative(object ManagedObj)
		{
			if (ManagedObj == null)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalManagedToNative(IntPtr pNativeData)");
			}
			return ((global::ADODB.InternalFields)ManagedObj).GetFields();
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00004DE8 File Offset: 0x00003DE8
		public void CleanUpNativeData(global::System.IntPtr pNativeData)
		{
			global::System.Runtime.InteropServices.Marshal.Release(pNativeData);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00004DFC File Offset: 0x00003DFC
		public void CleanUpManagedData(object o)
		{
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00004E0C File Offset: 0x00003E0C
		public int GetNativeDataSize()
		{
			return -1;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00004E20 File Offset: 0x00003E20
		public static global::System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
		{
			if (global::ADODB.FieldsToInternalFieldsMarshaler.m_me == null)
			{
				global::ADODB.FieldsToInternalFieldsMarshaler.m_me = new global::ADODB.FieldsToInternalFieldsMarshaler();
			}
			return global::ADODB.FieldsToInternalFieldsMarshaler.m_me;
		}

		// Token: 0x040001F9 RID: 505
		private static global::ADODB.FieldsToInternalFieldsMarshaler m_me = null;
	}
}
