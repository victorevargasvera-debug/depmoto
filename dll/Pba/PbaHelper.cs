using System;
using System.IO;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200001F RID: 31
	public class PbaHelper
	{
		// Token: 0x06000151 RID: 337 RVA: 0x0000593C File Offset: 0x00003B3C
		public static byte[] FileToByte(string filePath)
		{
			if (!global::System.IO.File.Exists(filePath))
			{
				throw new global::System.ApplicationException();
			}
			byte[] result;
			using (global::System.IO.Stream stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read))
			{
				byte[] bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
				result = bytesFromStream;
			}
			return result;
		}
	}
}
