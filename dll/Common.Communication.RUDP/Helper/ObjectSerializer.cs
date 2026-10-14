using System;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x02000005 RID: 5
	internal abstract class ObjectSerializer : global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer
	{
		// Token: 0x0600001A RID: 26
		public abstract object[] GetObjectList();

		// Token: 0x0600001B RID: 27
		public abstract void SetObjectList(object[] list);

		// Token: 0x0600001C RID: 28 RVA: 0x000023F0 File Offset: 0x000005F0
		public int Serialize(byte[] buffer, int offset)
		{
			object[] objectList = this.GetObjectList();
			return global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ConstructBytes(buffer, offset, objectList);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000240C File Offset: 0x0000060C
		public virtual int Deserialize(byte[] buffer, int start, int len)
		{
			object[] objectList = this.GetObjectList();
			int result = global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.DecodeBytes(buffer, start, len, objectList);
			this.SetObjectList(objectList);
			return result;
		}
	}
}
