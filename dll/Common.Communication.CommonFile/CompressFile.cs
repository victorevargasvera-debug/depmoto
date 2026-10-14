using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.Compression;
using Motorola.Common.CustomException;
using SevenZip;
using SevenZip.Compression.LZMA;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x02000009 RID: 9
	internal class CompressFile
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002665 File Offset: 0x00000865
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000266D File Offset: 0x0000086D
		private uint crc
		{
			get
			{
				return this._crc;
			}
			set
			{
				this._crc = value;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002678 File Offset: 0x00000878
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.CompressFrangment> ConvertToCompressFileArray(byte[] inputBytes)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.CompressFrangment> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.CompressFrangment>();
			global::Motorola.Common.Communication.CommonFile.CompressFrangment compressFrangment;
			for (long num = 0L; num < (long)(inputBytes.Length - 4); num = num + 10L + (long)compressFrangment.compressSize)
			{
				compressFrangment = new global::Motorola.Common.Communication.CommonFile.CompressFrangment();
				checked
				{
					compressFrangment.headVersion = inputBytes[(int)((global::System.IntPtr)num)];
					compressFrangment.algorithmAndLevel = inputBytes[(int)((global::System.IntPtr)(unchecked(num + 1L)))];
					compressFrangment.compressSize = global::System.BitConverter.ToInt32(new byte[]
					{
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 2L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 3L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 4L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 5L)))]
					}, 0);
					compressFrangment.uncompressSize = global::System.BitConverter.ToInt32(new byte[]
					{
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 6L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 7L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 8L)))],
						inputBytes[(int)((global::System.IntPtr)(unchecked(num + 9L)))]
					}, 0);
					compressFrangment.compressData = new byte[compressFrangment.compressSize];
				}
				global::System.Array.Copy(inputBytes, num + 10L, compressFrangment.compressData, 0L, (long)compressFrangment.compressSize);
				list.Add(compressFrangment);
			}
			return list;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002784 File Offset: 0x00000984
		public static byte[] Decompress(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonFile.CompressFrangment> cmpList)
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			foreach (global::Motorola.Common.Communication.CommonFile.CompressFrangment compressFrangment in cmpList)
			{
				byte[] collection = compressFrangment.compressData;
				byte b = compressFrangment.algorithmAndLevel / 16;
				byte b2 = compressFrangment.algorithmAndLevel & 15;
				byte[] array = new byte[compressFrangment.uncompressSize];
				if (b == 2)
				{
					uint num = 0U;
					global::Motorola.Common.Communication.Compression.FastLZWrapper.DataDecompress(compressFrangment.compressData, array, ref num);
					if ((ulong)num != (ulong)((long)compressFrangment.uncompressSize))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_Compression_FASTLZ_Decompress_Failed);
					}
				}
				else if (b == 1)
				{
					global::SevenZip.Compression.LZMA.Decoder decoder = new global::SevenZip.Compression.LZMA.Decoder();
					byte[] array2 = new byte[5];
					array2[0] = 93;
					array2[3] = 1;
					byte[] array3 = array2;
					if (b2 == 0)
					{
						byte[] array4 = new byte[5];
						array4[0] = 93;
						array4[2] = 64;
						array3 = array4;
					}
					if (b2 == 2)
					{
						byte[] array5 = new byte[5];
						array5[0] = 93;
						array5[3] = 4;
						array3 = array5;
					}
					decoder.SetDecoderProperties(array3);
					global::System.Collections.Generic.List<byte> list2 = new global::System.Collections.Generic.List<byte>();
					list2.AddRange(array3);
					list2.AddRange(global::System.BitConverter.GetBytes(compressFrangment.uncompressSize));
					global::System.Collections.Generic.List<byte> list3 = list2;
					byte[] collection2 = new byte[4];
					list3.AddRange(collection2);
					list2.AddRange(compressFrangment.compressData);
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(list2.ToArray()))
					{
						using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(compressFrangment.uncompressSize))
						{
							decoder.Train(memoryStream);
							memoryStream.Position = 13L;
							decoder.Code(memoryStream, memoryStream2, (long)compressFrangment.compressData.Length, (long)compressFrangment.uncompressSize, null);
							array = memoryStream2.ToArray();
						}
					}
				}
				collection = array;
				list.AddRange(collection);
			}
			return list.ToArray();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002998 File Offset: 0x00000B98
		public static byte[] Compress(byte[] inputBytes)
		{
			global::SevenZip.Compression.LZMA.Encoder encoder = new global::SevenZip.Compression.LZMA.Encoder();
			byte[] array = null;
			using (global::System.IO.Stream stream = new global::System.IO.MemoryStream(inputBytes))
			{
				using (global::System.IO.Stream stream2 = new global::System.IO.MemoryStream())
				{
					encoder.SetCoderProperties(global::Motorola.Common.Communication.CommonFile.CompressFile.propIDs, global::Motorola.Common.Communication.CommonFile.CompressFile.properties);
					encoder.WriteCoderProperties(stream2);
					for (int i = 0; i < 8; i++)
					{
						stream2.WriteByte((byte)(stream.Length >> 8 * i));
					}
					long outSize = 0L;
					encoder.Code(stream, stream2, stream.Length, outSize, null);
					stream2.Position = 13L;
					array = new byte[stream2.Length - 13L];
					stream2.Read(array, 0, array.Length);
				}
			}
			byte[] array2 = new byte[10];
			array2[0] = 16;
			array2[1] = 17;
			byte[] bytes = global::System.BitConverter.GetBytes(array.Length);
			global::System.Array.Copy(bytes, 0, array2, 2, bytes.Length);
			byte[] bytes2 = global::System.BitConverter.GetBytes(inputBytes.Length);
			global::System.Array.Copy(bytes2, 0, array2, 6, bytes2.Length);
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			list.AddRange(array2);
			list.AddRange(array);
			uint crc32CheckSum = global::Motorola.Common.Communication.CommonFile.CheckSumCRC32.GetCRC32CheckSum(list.ToArray());
			byte[] bytes3 = global::System.BitConverter.GetBytes((int)crc32CheckSum);
			list.AddRange(bytes3);
			return list.ToArray();
		}

		// Token: 0x0400001E RID: 30
		private static int dictionary = 65536;

		// Token: 0x0400001F RID: 31
		private static bool eos = false;

		// Token: 0x04000020 RID: 32
		private static global::SevenZip.CoderPropID[] propIDs = new global::SevenZip.CoderPropID[]
		{
			global::SevenZip.CoderPropID.DictionarySize,
			global::SevenZip.CoderPropID.PosStateBits,
			global::SevenZip.CoderPropID.LitContextBits,
			global::SevenZip.CoderPropID.LitPosBits,
			global::SevenZip.CoderPropID.Algorithm,
			global::SevenZip.CoderPropID.NumFastBytes,
			global::SevenZip.CoderPropID.MatchFinder,
			global::SevenZip.CoderPropID.EndMarker
		};

		// Token: 0x04000021 RID: 33
		private static object[] properties = new object[]
		{
			global::Motorola.Common.Communication.CommonFile.CompressFile.dictionary,
			2,
			3,
			0,
			1,
			32,
			"bt4",
			global::Motorola.Common.Communication.CommonFile.CompressFile.eos
		};

		// Token: 0x04000022 RID: 34
		private uint _crc;

		// Token: 0x0200000A RID: 10
		private static class CompressFileConstants
		{
			// Token: 0x04000023 RID: 35
			public const byte HeaderVer = 16;

			// Token: 0x04000024 RID: 36
			public const int HeaderLength = 10;

			// Token: 0x04000025 RID: 37
			public const int compressSizePos = 2;

			// Token: 0x04000026 RID: 38
			public const int unCompressSizePos = 6;
		}

		// Token: 0x0200000B RID: 11
		private enum CompressAlogorithem : byte
		{
			// Token: 0x04000028 RID: 40
			NoCompression,
			// Token: 0x04000029 RID: 41
			LZMA,
			// Token: 0x0400002A RID: 42
			FastLZ
		}

		// Token: 0x0200000C RID: 12
		private enum CompressLevel : byte
		{
			// Token: 0x0400002C RID: 44
			Level0,
			// Token: 0x0400002D RID: 45
			Level1,
			// Token: 0x0400002E RID: 46
			Level2
		}
	}
}
