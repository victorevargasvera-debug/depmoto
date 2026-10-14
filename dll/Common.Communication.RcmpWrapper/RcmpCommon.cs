using System;
using System.Globalization;
using System.IO;
using System.Text;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000039 RID: 57
	internal static class RcmpCommon
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000043A0 File Offset: 0x000025A0
		public static int RcmpBasicReplyHeaderSize
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000043A3 File Offset: 0x000025A3
		public static ushort RcmpReplyOpcodeFlag
		{
			get
			{
				return 32768;
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000043AC File Offset: 0x000025AC
		public static global::Motorola.Common.Communication.RcmpReplyResult CheckReplyHeader(byte[] buffer, int offset, ushort expectedReplyOpcode)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (buffer.Length - offset < global::Motorola.Common.Communication.RcmpCommon.RcmpBasicReplyHeaderSize)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpReplySize);
			}
			ushort num = (ushort)((int)buffer[offset] * 256 + (int)buffer[offset + 1]);
			if (num != expectedReplyOpcode)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidReplyOpcode);
			}
			return (global::Motorola.Common.Communication.RcmpReplyResult)buffer[offset + 2];
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004400 File Offset: 0x00002600
		public static void DecodeBytes(byte[] buffer, int start, int length, object[] list)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (list == null)
			{
				throw new global::System.ArgumentNullException("list");
			}
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer, start, length, false))
			{
				for (int i = 0; i < list.Length; i++)
				{
					if (list[i] is byte)
					{
						list[i] = global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream);
					}
					else if (list[i] is ushort)
					{
						ushort num = (ushort)((int)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream) * 256 + (int)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream));
						list[i] = num;
					}
					else if (list[i] is uint)
					{
						uint num2 = (uint)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream) * 16777216U + (uint)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream) * 65536U + (uint)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream) * 256U + (uint)global::Motorola.Common.Communication.RcmpCommon.ReadByte(memoryStream);
						list[i] = num2;
					}
					else if (list[i] is string)
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						for (int j = memoryStream.ReadByte(); j > 0; j = memoryStream.ReadByte())
						{
							stringBuilder.Append((char)j);
						}
						list[i] = stringBuilder.ToString();
					}
					else
					{
						if (!(list[i] is byte[]))
						{
							throw new global::System.ArgumentException("Unsupported type: " + list[i].GetType().FullName);
						}
						byte[] array = list[i] as byte[];
						if (array.Length == 0)
						{
							array = (list[i] = new byte[memoryStream.Length - memoryStream.Position]);
						}
						if (memoryStream.Read(array, 0, array.Length) != array.Length)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRcmpReplySize);
						}
					}
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000045AC File Offset: 0x000027AC
		public static int ConstructBytes(byte[] buffer, int offset, params object[] list)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (list == null)
			{
				throw new global::System.ArgumentNullException("list");
			}
			int result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer, offset, buffer.Length - offset, true))
			{
				try
				{
					foreach (object obj in list)
					{
						char[] chars;
						if (obj is byte)
						{
							memoryStream.WriteByte((byte)obj);
						}
						else if (obj is ushort)
						{
							ushort num = (ushort)obj;
							memoryStream.WriteByte((byte)(num >> 8 & 255));
							memoryStream.WriteByte((byte)(num & 255));
						}
						else if (obj is uint)
						{
							uint num2 = (uint)obj;
							memoryStream.WriteByte((byte)(num2 >> 24 & 255U));
							memoryStream.WriteByte((byte)(num2 >> 16 & 255U));
							memoryStream.WriteByte((byte)(num2 >> 8 & 255U));
							memoryStream.WriteByte((byte)(num2 & 255U));
						}
						else if (obj is string)
						{
							byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(obj.ToString());
							memoryStream.Write(bytes, 0, bytes.Length);
							memoryStream.WriteByte(0);
						}
						else if ((chars = (obj as char[])) != null)
						{
							byte[] bytes2 = global::System.Text.Encoding.ASCII.GetBytes(chars);
							memoryStream.Write(bytes2, 0, bytes2.Length);
						}
						else
						{
							byte[] array;
							if ((array = (obj as byte[])) == null)
							{
								throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Unsupported type: {0}", new object[]
								{
									obj.GetType().FullName
								}));
							}
							memoryStream.Write(array, 0, array.Length);
						}
					}
					result = (int)memoryStream.Position;
				}
				catch (global::System.NotSupportedException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InsufficientMessageBuffer, systemException);
				}
			}
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000047A0 File Offset: 0x000029A0
		public static int ConstructUCS2StringToBytes(string ucs2String, byte[] buffer, int start, bool bigEndian = false)
		{
			int result;
			try
			{
				byte[] array = (!bigEndian) ? global::System.Text.Encoding.Unicode.GetBytes(ucs2String) : global::System.Text.Encoding.BigEndianUnicode.GetBytes(ucs2String);
				if (buffer.Length < start + array.Length)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				global::System.Buffer.BlockCopy(array, 0, buffer, start, array.Length);
				result = array.Length;
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			return result;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004808 File Offset: 0x00002A08
		public static int ConstructBCHStringToBytes(string bchString, ref byte[] buffer)
		{
			int result;
			try
			{
				if (bchString.Length % 2 != 0)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
				}
				buffer = new byte[bchString.Length / 2];
				for (int i = 0; i < buffer.Length; i++)
				{
					string s = bchString.Substring(i * 2, 2);
					buffer[i] = byte.Parse(s, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				result = buffer.Length;
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004884 File Offset: 0x00002A84
		public static string DecodeBytesToUCS2String(byte[] buffer, int start, int length)
		{
			string result;
			try
			{
				string @string = global::System.Text.Encoding.BigEndianUnicode.GetString(buffer, start, length);
				char[] trimChars = new char[1];
				result = @string.TrimEnd(trimChars);
			}
			catch (global::System.ArgumentNullException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull, systemException);
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
			}
			catch (global::System.ArithmeticException systemException3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument, systemException3);
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000048F4 File Offset: 0x00002AF4
		public static uint DecodeBytesToUInt32(byte[] buffer, int start)
		{
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (start < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			if (buffer.Length < start + 4)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			uint num = 0U;
			for (int i = start; i < start + 4; i++)
			{
				num <<= 8;
				num += (uint)buffer[i];
			}
			return num;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004940 File Offset: 0x00002B40
		public static ushort DecodeBytesToUInt16(byte[] buffer, int start)
		{
			if (buffer == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			if (start < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
			}
			if (buffer.Length < start + 2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			}
			return (ushort)(((int)buffer[start] << 8) + (int)buffer[start + 1]);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004974 File Offset: 0x00002B74
		private static byte ReadByte(global::System.IO.Stream strm)
		{
			int num = strm.ReadByte();
			if (num < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			}
			return (byte)num;
		}

		// Token: 0x04000113 RID: 275
		public static readonly object ushortObj = 0;

		// Token: 0x04000114 RID: 276
		public static readonly object byteObj = 0;

		// Token: 0x04000115 RID: 277
		public static readonly object byteArrayObj = new byte[0];

		// Token: 0x04000116 RID: 278
		public static readonly object uintObj = 0U;
	}
}
