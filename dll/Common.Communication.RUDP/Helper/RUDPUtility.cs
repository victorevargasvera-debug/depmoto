using System;
using System.Globalization;
using System.IO;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x0200000D RID: 13
	internal static class RUDPUtility
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x00004E7C File Offset: 0x0000307C
		public static void CombindFlag(ref byte src, bool value, byte mask)
		{
			if (value)
			{
				src |= mask;
				return;
			}
			byte b = ~mask;
			src &= b;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004EA0 File Offset: 0x000030A0
		private static byte ReadByte(global::System.IO.Stream strm)
		{
			int num = strm.ReadByte();
			if (num < 0)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UnexpectedEndOfMsg);
			}
			return (byte)num;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00004EC4 File Offset: 0x000030C4
		public static int DecodeBytes(byte[] buffer, int start, int length, object[] list)
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
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer, start, length, false))
			{
				for (int i = 0; i < list.Length; i++)
				{
					if (memoryStream.Position == memoryStream.Length)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Decode RUDP Packet: Reach the end of Packet: len={0}", new object[]
						{
							memoryStream.Length
						});
						break;
					}
					if (list[i] is byte)
					{
						list[i] = global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream);
					}
					else if (list[i] is ushort)
					{
						ushort num = (ushort)((int)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream) * 256 + (int)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream));
						list[i] = num;
					}
					else if (list[i] is uint)
					{
						uint num2 = (uint)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream) * 16777216U + (uint)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream) * 65536U + (uint)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream) * 256U + (uint)global::Motorola.Common.Communication.RUDP.Helper.RUDPUtility.ReadByte(memoryStream);
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
					else if (list[i] is byte[])
					{
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
					else
					{
						if (!(list[i] is global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer))
						{
							throw new global::System.ArgumentException("Unsupported type: " + list[i].GetType().FullName);
						}
						global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer objectSerializer = list[i] as global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer;
						if (objectSerializer != null)
						{
							byte[] array2 = new byte[memoryStream.Length - memoryStream.Position];
							if (memoryStream.Read(array2, 0, array2.Length) == array2.Length)
							{
								memoryStream.Position = (long)objectSerializer.Deserialize(array2, 0, array2.Length);
							}
						}
					}
				}
				result = (int)memoryStream.Position;
			}
			return result;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005110 File Offset: 0x00003310
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
						byte[] array;
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
						else if ((array = (obj as byte[])) != null)
						{
							memoryStream.Write(array, 0, array.Length);
						}
						else
						{
							global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer objectSerializer;
							if ((objectSerializer = (obj as global::Motorola.Common.Communication.RUDP.Helper.IObjectSerializer)) == null)
							{
								throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Unsupported type: {0}", new object[]
								{
									obj.GetType().FullName
								}));
							}
							if (objectSerializer != null)
							{
								byte[] buffer2 = new byte[10240];
								int num3 = objectSerializer.Serialize(buffer2, 0);
								if (num3 > 0)
								{
									memoryStream.Write(buffer2, 0, num3);
								}
							}
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
	}
}
