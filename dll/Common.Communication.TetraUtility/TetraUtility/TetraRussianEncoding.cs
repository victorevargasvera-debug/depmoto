using System;
using System.Text;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x02000008 RID: 8
	internal class TetraRussianEncoding : global::System.Text.Encoding
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00005108 File Offset: 0x00003308
		public override int CodePage
		{
			get
			{
				return 9999;
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000510F File Offset: 0x0000330F
		public override int GetByteCount(char[] chars, int index, int count)
		{
			return count;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005114 File Offset: 0x00003314
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex)
		{
			for (int i = 0; i < charCount; i++)
			{
				char c = chars[i + charIndex];
				byte? russianByte = global::Motorola.Common.Communication.TetraUtility.CodepageDef.GetRussianByte(c);
				if (russianByte == null)
				{
					russianByte = global::Motorola.Common.Communication.TetraUtility.CodepageDef.GetRussianByte(this.FallbackCharacter);
				}
				bytes[byteIndex + i] = russianByte.Value;
			}
			return charCount;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000515E File Offset: 0x0000335E
		public override int GetCharCount(byte[] bytes, int index, int count)
		{
			return count;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005164 File Offset: 0x00003364
		public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex)
		{
			for (int i = 0; i < byteCount; i++)
			{
				byte b = bytes[i + byteIndex];
				char? russianChar = global::Motorola.Common.Communication.TetraUtility.CodepageDef.GetRussianChar(b);
				if (russianChar == null)
				{
					russianChar = new char?(this.FallbackCharacter);
				}
				chars[charIndex + i] = russianChar.Value;
			}
			return byteCount;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000051AF File Offset: 0x000033AF
		public override int GetMaxByteCount(int charCount)
		{
			return charCount;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000051B2 File Offset: 0x000033B2
		public override int GetMaxCharCount(int byteCount)
		{
			return byteCount;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000051B5 File Offset: 0x000033B5
		private char FallbackCharacter
		{
			get
			{
				return '?';
			}
		}
	}
}
