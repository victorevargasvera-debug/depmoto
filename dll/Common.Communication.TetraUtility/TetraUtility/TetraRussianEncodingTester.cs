using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000005 RID: 5
	public class TetraRussianEncodingTester
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00004804 File Offset: 0x00002A04
		public void Run()
		{
			this.BuildMap();
			global::System.Text.Encoding encoding = global::Motorola.Common.Communication.TetraUtility.CodepageUtil.GetEncoding(9999);
			for (ushort num = 0; num < 65535; num += 1)
			{
				this.DoTest(encoding, num, this.map.ContainsKey(num));
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004848 File Offset: 0x00002A48
		private void DoTest(global::System.Text.Encoding encoding, ushort i, bool isValid)
		{
			string @string = global::System.Text.Encoding.Unicode.GetString(global::System.BitConverter.GetBytes(i));
			byte[] bytes = encoding.GetBytes(@string);
			@string = encoding.GetString(bytes);
			bytes = global::System.Text.Encoding.Unicode.GetBytes(@string);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004884 File Offset: 0x00002A84
		private void BuildMap()
		{
			lock (this.map)
			{
				if (this.map.Count <= 0)
				{
					using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(global::System.IO.Path.Combine(global::Motorola.Common.Communication.TetraUtility.FileSystem.BinDir, "__codepage_9999.txt")))
					{
						foreach (global::Motorola.Common.Communication.TetraUtility.CodeAllowPair codeAllowPair in global::Motorola.Common.Communication.TetraUtility.CodepageDef.TetraRussianCodepageTable)
						{
							streamWriter.WriteLine(string.Format("Code:[0x{0:X4}], Char[{1}]", codeAllowPair.Code, global::System.Text.Encoding.Unicode.GetString(global::System.BitConverter.GetBytes(codeAllowPair.Code))));
							if (codeAllowPair.IsInputable && !this.map.ContainsKey(codeAllowPair.Code))
							{
								this.map[codeAllowPair.Code] = codeAllowPair;
							}
						}
					}
				}
			}
		}

		// Token: 0x0400000E RID: 14
		private global::System.Collections.Generic.Dictionary<ushort, global::Motorola.Common.Communication.TetraUtility.CodeAllowPair> map = new global::System.Collections.Generic.Dictionary<ushort, global::Motorola.Common.Communication.TetraUtility.CodeAllowPair>();
	}
}
