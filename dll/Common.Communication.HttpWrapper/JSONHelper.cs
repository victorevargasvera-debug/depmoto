using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Motorola.Common.Communication
{
	// Token: 0x02000004 RID: 4
	public class JSONHelper
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020E0 File Offset: 0x000002E0
		public static T Parse<T>(string json)
		{
			T result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(json)))
			{
				result = (T)((object)new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T)).ReadObject(memoryStream));
			}
			return result;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002138 File Offset: 0x00000338
		public static string ToString(object jsonObj)
		{
			string @string;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(jsonObj.GetType()).WriteObject(memoryStream, jsonObj);
				@string = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			return @string;
		}
	}
}
