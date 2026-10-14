using System;
using System.IO;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x02000003 RID: 3
	public class AcpCryptoBase
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000023A3 File Offset: 0x000005A3
		static AcpCryptoBase()
		{
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023B4 File Offset: 0x000005B4
		internal byte[] ExtractHeader(global::System.IO.Stream stream)
		{
			if (stream.CanSeek)
			{
				byte[] array = new byte[10];
				stream.Read(array, 0, array.Length);
				int num = (int)array[7];
				stream.Seek((long)(-(long)array.Length), global::System.IO.SeekOrigin.Current);
				byte[] array2 = new byte[num];
				stream.Read(array2, 0, array2.Length);
				return array2;
			}
			throw new global::System.Exception("Seek Operation is not supported for this stream");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002414 File Offset: 0x00000614
		internal byte[] ExtractSalt(global::System.IO.Stream stream)
		{
			byte[] array = new byte[4];
			stream.Read(array, 0, array.Length);
			int saltLength = global::AcpCryptoLib.AcpRNGenerator.GetSaltLength(array);
			byte[] array2 = new byte[saltLength];
			stream.Read(array2, 4, array2.Length - 4);
			return array2;
		}
	}
}
