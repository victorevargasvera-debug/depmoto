using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200001C RID: 28
	public class EmbeddedResourceManager
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00002EAC File Offset: 0x000010AC
		public static global::System.IO.StreamReader GetStreamReader(global::System.Reflection.Assembly assembly, string resourceName)
		{
			global::System.IO.Stream decryptedStream = global::Motorola.Common.CommonLib.EmbeddedResourceManager.GetDecryptedStream(assembly, resourceName);
			if (decryptedStream == null)
			{
				return null;
			}
			return new global::System.IO.StreamReader(decryptedStream);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002ECC File Offset: 0x000010CC
		public static global::System.IO.Stream GetStream(global::System.Reflection.Assembly assembly, string resourceName)
		{
			return global::Motorola.Common.CommonLib.EmbeddedResourceManager.GetDecryptedStream(assembly, resourceName);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002ED8 File Offset: 0x000010D8
		public static T GetResource<T>(global::System.Reflection.Assembly assembly, string resourceName) where T : class
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
			global::System.IO.Stream stream = null;
			T result;
			try
			{
				stream = global::Motorola.Common.CommonLib.EmbeddedResourceManager.GetDecryptedStream(assembly, resourceName);
				if (stream == null)
				{
					result = default(T);
				}
				else
				{
					using (new global::System.IO.StreamReader(stream))
					{
						result = (T)((object)xmlSerializer.Deserialize(stream));
					}
				}
			}
			finally
			{
				if (stream != null)
				{
					stream.Dispose();
				}
			}
			return result;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002F58 File Offset: 0x00001158
		private static global::System.IO.Stream GetDecryptedStream(global::System.Reflection.Assembly assembly, string resourceName)
		{
			if (string.IsNullOrEmpty(resourceName))
			{
				return null;
			}
			string name = string.Empty;
			string text = string.Empty;
			if (resourceName.EndsWith(".rm", global::System.StringComparison.OrdinalIgnoreCase))
			{
				name = resourceName;
				text = resourceName.Replace(".IA", string.Empty).Replace(".rm", string.Empty);
			}
			else
			{
				string name2 = assembly.GetName().Name;
				name = resourceName.Replace(name2, name2 + ".IA") + ".rm";
				text = resourceName;
			}
			global::System.IO.Stream stream = assembly.GetManifestResourceStream(name);
			if (stream == null && !string.IsNullOrEmpty(text))
			{
				stream = assembly.GetManifestResourceStream(text);
			}
			else
			{
				stream = global::Motorola.Common.CommonLib.MetaDataEnDecryptHelper.Instance.DecryptStreamToStream(stream, false);
			}
			return stream;
		}

		// Token: 0x040000D2 RID: 210
		private const string ENCRYPTED_FOLDER_NAME = ".IA";

		// Token: 0x040000D3 RID: 211
		private const string ENCRYPTED_FILE_EXTENSION = ".rm";
	}
}
