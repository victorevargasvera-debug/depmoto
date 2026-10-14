using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication.SequenceManager.TTS_Unpack
{
	// Token: 0x02000050 RID: 80
	public class TTSUnpackUtility
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00016C2C File Offset: 0x00014E2C
		public static global::System.Collections.Generic.List<string> UnpackSubPack(string filePath, string targetFolder)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			targetFolder = global::System.IO.Path.Combine(targetFolder, "tts");
			if (!global::System.IO.Directory.Exists(targetFolder))
			{
				global::System.IO.Directory.CreateDirectory(targetFolder);
			}
			if (!string.IsNullOrEmpty(filePath))
			{
				using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read))
				{
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
					{
						stream.CopyTo(memoryStream);
						using (global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(memoryStream))
						{
							binaryReader.BaseStream.Position = 0L;
							byte[] buffer = binaryReader.ReadBytes(344);
							using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(global::System.IO.Path.Combine(targetFolder, "tts_info.txt"), global::System.IO.FileMode.Create))
							{
								using (global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(fileStream))
								{
									binaryWriter.Write(buffer);
								}
							}
							list.Add(global::System.IO.Path.Combine(targetFolder, "tts_info.txt"));
							int num = binaryReader.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								int num2 = binaryReader.ReadInt32();
								long position = binaryReader.BaseStream.Position;
								binaryReader.BaseStream.Position = (long)num2;
								byte[] array = binaryReader.ReadBytes(4);
								int num3 = binaryReader.ReadInt32();
								byte[] bytes = binaryReader.ReadBytes(256);
								byte[] array2 = binaryReader.ReadBytes(100);
								byte[] array3 = binaryReader.ReadBytes(4);
								byte[] buffer2 = binaryReader.ReadBytes(num3 - 368);
								string @string = global::System.Text.Encoding.Default.GetString(bytes);
								char[] trimChars = new char[1];
								string text = @string.TrimEnd(trimChars).Split(new string[]
								{
									"tts\\"
								}, global::System.StringSplitOptions.RemoveEmptyEntries)[1];
								if (!global::System.IO.Directory.Exists(global::System.IO.Path.Combine(targetFolder, global::System.IO.Path.GetDirectoryName(text))))
								{
									global::System.IO.Directory.CreateDirectory(global::System.IO.Path.Combine(targetFolder, global::System.IO.Path.GetDirectoryName(text)));
								}
								using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(global::System.IO.Path.Combine(targetFolder, text), global::System.IO.FileMode.Create))
								{
									using (global::System.IO.BinaryWriter binaryWriter2 = new global::System.IO.BinaryWriter(fileStream2))
									{
										binaryWriter2.Write(buffer2);
									}
								}
								list.Add(global::System.IO.Path.Combine(targetFolder, text));
								binaryReader.BaseStream.Position = position;
							}
						}
					}
				}
			}
			return list;
		}
	}
}
