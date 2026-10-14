using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000002 RID: 2
	public sealed class BZip2
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000020D0 File Offset: 0x000010D0
		public static void Decompress(global::System.IO.Stream inStream, global::System.IO.Stream outStream)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream bzip2InputStream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream(inStream))
				{
					for (int num = bzip2InputStream.ReadByte(); num != -1; num = bzip2InputStream.ReadByte())
					{
						outStream.WriteByte((byte)num);
					}
				}
			}
			finally
			{
				if (outStream != null)
				{
					((global::System.IDisposable)outStream).Dispose();
				}
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002154 File Offset: 0x00001154
		public static void Compress(global::System.IO.Stream inStream, global::System.IO.Stream outStream, int blockSize)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream bzip2OutputStream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(outStream, blockSize))
				{
					for (int num = inStream.ReadByte(); num != -1; num = inStream.ReadByte())
					{
						bzip2OutputStream.WriteByte((byte)num);
					}
				}
			}
			finally
			{
				if (inStream != null)
				{
					((global::System.IDisposable)inStream).Dispose();
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000021D8 File Offset: 0x000011D8
		private BZip2()
		{
		}
	}
}
