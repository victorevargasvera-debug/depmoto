using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace CommunicationController
{
	// Token: 0x02000015 RID: 21
	public static class ObjectSerializer
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002B18 File Offset: 0x00001B18
		public static byte[] BinarySerialize(object instance)
		{
			byte[] result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (true)
				{
				}
				if (false)
				{
				}
				switch (0)
				{
				default:
				{
					global::System.IO.MemoryStream memoryStream = null;
					try
					{
						memoryStream = new global::System.IO.MemoryStream();
						global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
						binaryFormatter.Serialize(memoryStream, instance);
						byte[] array = memoryStream.ToArray();
						result = array;
					}
					finally
					{
						for (;;)
						{
							int num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									memoryStream.Close();
									num = 2;
									continue;
								case 1:
									if (memoryStream != null)
									{
										num = 0;
										continue;
									}
									goto IL_9E;
								case 2:
									goto IL_9C;
								}
								break;
							}
						}
						IL_9C:
						IL_9E:
						memoryStream = null;
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002BD8 File Offset: 0x00001BD8
		public static T BinaryDeserialize<T>(byte[] array)
		{
			global::System.IO.MemoryStream memoryStream = null;
			T result;
			try
			{
				if (true)
				{
				}
				memoryStream = new global::System.IO.MemoryStream(array);
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				result = (T)((object)binaryFormatter.Deserialize(memoryStream));
			}
			finally
			{
				for (;;)
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							memoryStream.Close();
							num = 2;
							continue;
						case 1:
							if (memoryStream == null)
							{
								goto IL_7F;
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7D;
							default:
								if (false)
								{
								}
								num = 0;
								continue;
							}
							break;
						case 2:
							goto IL_7D;
						}
						break;
					}
				}
				IL_7D:
				IL_7F:
				memoryStream = null;
			}
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002C84 File Offset: 0x00001C84
		public static void BinarySerializeToFile(object instance, string filePath)
		{
			global::System.IO.Stream stream = null;
			try
			{
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
				stream.SetLength(0L);
				binaryFormatter.Serialize(stream, instance);
			}
			finally
			{
				for (;;)
				{
					for (;;)
					{
						int num = 1;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									stream.Close();
									num = 2;
									continue;
								}
								break;
							case 1:
								if (stream != null)
								{
									num = 0;
									continue;
								}
								goto IL_7E;
							case 2:
								goto IL_7C;
							}
							break;
						}
					}
				}
				IL_7C:
				IL_7E:;
			}
			if (true)
			{
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002D34 File Offset: 0x00001D34
		public static T BinaryDeserializeFromFile<T>(string filePath)
		{
			global::System.IO.Stream stream = null;
			T result;
			try
			{
				stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				result = (T)((object)binaryFormatter.Deserialize(stream));
			}
			finally
			{
				for (;;)
				{
					for (;;)
					{
						if (true)
						{
						}
						int num = 2;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									if (false)
									{
									}
									stream.Close();
									num = 1;
									continue;
								}
								break;
							case 1:
								goto IL_81;
							case 2:
								if (stream != null)
								{
									num = 0;
									continue;
								}
								goto IL_83;
							}
							break;
						}
					}
				}
				IL_81:
				IL_83:
				stream = null;
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002DE4 File Offset: 0x00001DE4
		public static T BinaryCloneInstance<T>(T input)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				if (true)
				{
				}
				switch (0)
				{
				}
				break;
			}
			byte[] buffer = null;
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			try
			{
				global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
				binaryFormatter.Serialize(memoryStream, input);
				buffer = memoryStream.ToArray();
				goto IL_A1;
			}
			finally
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						((global::System.IDisposable)memoryStream).Dispose();
						num = 1;
						continue;
					case 1:
						goto IL_102;
					}
					if (memoryStream == null)
					{
						break;
					}
					num = 0;
				}
				IL_102:;
			}
			T result;
			return result;
			for (;;)
			{
				IL_A1:
				global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(buffer);
				try
				{
					global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter2 = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
					result = (T)((object)binaryFormatter2.Deserialize(memoryStream2));
					break;
				}
				finally
				{
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 1:
							((global::System.IDisposable)memoryStream2).Dispose();
							num = 2;
							continue;
						case 2:
							goto IL_9E;
						}
						if (memoryStream2 == null)
						{
							break;
						}
						num = 1;
					}
					IL_9E:;
				}
			}
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F14 File Offset: 0x00001F14
		public static byte[] XmlSerialize(object instance)
		{
			global::System.IO.MemoryStream memoryStream;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				if (false)
				{
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(instance.GetType());
				memoryStream = new global::System.IO.MemoryStream();
				try
				{
					if (true)
					{
					}
					xmlSerializer.Serialize(memoryStream, instance);
				}
				finally
				{
					memoryStream.Close();
				}
				break;
			}
			}
			return memoryStream.ToArray();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002F90 File Offset: 0x00001F90
		public static T XmlDeserialize<T>(byte[] array)
		{
			T result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			}
			if (false)
			{
			}
			global::System.IO.MemoryStream memoryStream = null;
			try
			{
				memoryStream = new global::System.IO.MemoryStream(array);
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
				result = (T)((object)xmlSerializer.Deserialize(memoryStream));
			}
			finally
			{
				if (true)
				{
				}
				for (;;)
				{
					int num = 1;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_91;
						case 1:
							if (memoryStream != null)
							{
								num = 2;
								continue;
							}
							goto IL_93;
						case 2:
							memoryStream.Close();
							num = 0;
							continue;
						}
						break;
					}
				}
				IL_91:
				IL_93:
				memoryStream = null;
			}
			return result;
		}
	}
}
