using System;
using System.Collections.Generic;
using System.Text;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000014 RID: 20
	public class FileListItemStruct
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000290E File Offset: 0x00000B0E
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002916 File Offset: 0x00000B16
		public global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile FileType { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000291F File Offset: 0x00000B1F
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002927 File Offset: 0x00000B27
		public int FileSize { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002930 File Offset: 0x00000B30
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002938 File Offset: 0x00000B38
		public string FileName { get; set; }

		// Token: 0x06000098 RID: 152 RVA: 0x00002941 File Offset: 0x00000B41
		public FileListItemStruct()
		{
			this.FileType = global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile.Unknown;
			this.FileSize = 0;
			this.FileName = "";
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002964 File Offset: 0x00000B64
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> ParseTransferData(byte[] xferData)
		{
			if (xferData == null)
			{
				throw new global::System.ArgumentNullException();
			}
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileListItemStruct>();
			int i = 0;
			while (i < xferData.Length)
			{
				global::Motorola.Common.Communication.Pba.FileListItemStruct fileListItemStruct = new global::Motorola.Common.Communication.Pba.FileListItemStruct();
				fileListItemStruct.FileType = (global::Motorola.Common.Communication.Pba.FileListItemStruct.TypeOfFile)xferData[i];
				fileListItemStruct.FileSize = (int)xferData[i + 1];
				fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[i + 2];
				fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[i + 3];
				fileListItemStruct.FileSize = fileListItemStruct.FileSize * 256 + (int)xferData[i + 4];
				i += 5;
				byte[] array = new byte[xferData.Length - i];
				global::System.Array.Copy(xferData, i, array, 0, xferData.Length - i);
				string @string = global::System.Text.Encoding.UTF8.GetString(array);
				int length = @string.IndexOf('\0');
				fileListItemStruct.FileName = @string.Substring(0, length);
				int num = global::System.Text.Encoding.UTF8.GetBytes(fileListItemStruct.FileName).Length;
				i = i + num + 1;
				list.Add(fileListItemStruct);
			}
			return list;
		}

		// Token: 0x02000015 RID: 21
		public enum TypeOfFile : byte
		{
			// Token: 0x04000079 RID: 121
			Unknown,
			// Token: 0x0400007A RID: 122
			File,
			// Token: 0x0400007B RID: 123
			Directory
		}
	}
}
