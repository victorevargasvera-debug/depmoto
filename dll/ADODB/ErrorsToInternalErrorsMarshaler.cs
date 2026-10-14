using System;
using System.Runtime.InteropServices;

namespace ADODB
{
	// Token: 0x0200008E RID: 142
	internal class ErrorsToInternalErrorsMarshaler : global::System.Runtime.InteropServices.ICustomMarshaler
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00005C44 File Offset: 0x00004C44
		public object MarshalNativeToManaged(global::System.IntPtr pNativeData)
		{
			if (pNativeData == (global::System.IntPtr)0)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalNativeToManaged(IntPtr pNativeData)");
			}
			return new global::ADODB.InternalErrors((global::ADODB.Errors)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pNativeData));
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00005C90 File Offset: 0x00004C90
		public global::System.IntPtr MarshalManagedToNative(object ManagedObj)
		{
			if (ManagedObj == null)
			{
				throw new global::System.ArgumentNullException(base.GetType().FullName + " .MarshalManagedToNative(IntPtr pNativeData)");
			}
			return ((global::ADODB.InternalErrors)ManagedObj).GetErrors();
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00005CCC File Offset: 0x00004CCC
		public void CleanUpNativeData(global::System.IntPtr pNativeData)
		{
			global::System.Runtime.InteropServices.Marshal.Release(pNativeData);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00005CE0 File Offset: 0x00004CE0
		public void CleanUpManagedData(object o)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00005CF0 File Offset: 0x00004CF0
		public int GetNativeDataSize()
		{
			return -1;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00005D04 File Offset: 0x00004D04
		public static global::System.Runtime.InteropServices.ICustomMarshaler GetInstance(string cookie)
		{
			if (global::ADODB.ErrorsToInternalErrorsMarshaler.m_me == null)
			{
				global::ADODB.ErrorsToInternalErrorsMarshaler.m_me = new global::ADODB.ErrorsToInternalErrorsMarshaler();
			}
			return global::ADODB.ErrorsToInternalErrorsMarshaler.m_me;
		}

		// Token: 0x0400020C RID: 524
		private static global::ADODB.ErrorsToInternalErrorsMarshaler m_me = null;
	}
}
