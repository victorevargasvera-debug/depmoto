using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000012 RID: 18
	public static class ObjectClone
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000034F0 File Offset: 0x000016F0
		public static object Clone(object ob)
		{
			global::System.Runtime.Serialization.IFormatter formatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			global::System.IO.Stream stream = null;
			object result = null;
			try
			{
				stream = new global::System.IO.MemoryStream();
				stream.Position = 0L;
				formatter.Serialize(stream, ob);
				stream.Position = 0L;
				result = formatter.Deserialize(stream);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Error in ObjectClone. {0}", new object[]
				{
					ex.Message
				});
			}
			finally
			{
				if (stream != null)
				{
					stream.Close();
				}
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000359C File Offset: 0x0000179C
		public static global::Motorola.Common.Communication.CommonUtil.DeviceInfo Copy(this global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo)
		{
			return (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.Communication.CommonUtil.ObjectClone.Clone(devInfo);
		}
	}
}
