using System;
using System.Runtime.InteropServices;
using System.Text;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.TetraUtility
{
	// Token: 0x0200001D RID: 29
	public static class Huffman
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x00008C55 File Offset: 0x00006E55
		internal unsafe static int UnhuffTablesWrapper(global::Motorola.Common.Communication.TetraUtility.HuffedStruct structInputHuffed, uint nHuffPromptDataTableSize, ushort** ppUnhuffPromptTable)
		{
			return global::Motorola.Common.Communication.TetraUtility.Huffman.UnsafeNativeMethods.UnhuffTablesWrapper(structInputHuffed, nHuffPromptDataTableSize, ppUnhuffPromptTable);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008C5F File Offset: 0x00006E5F
		internal unsafe static int HuffTablesWrapper(ushort* pUnhuffPromptTable, uint nUnhuffPromptTableSize, out global::Motorola.Common.Communication.TetraUtility.HuffedStruct pStructOutputHuffed)
		{
			return global::Motorola.Common.Communication.TetraUtility.Huffman.UnsafeNativeMethods.HuffTablesWrapper(pUnhuffPromptTable, nUnhuffPromptTableSize, out pStructOutputHuffed);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00008C69 File Offset: 0x00006E69
		internal unsafe static int FreeTablesMemoryWrapper(global::Motorola.Common.Communication.TetraUtility.HuffedStruct* pStructHuffed)
		{
			return global::Motorola.Common.Communication.TetraUtility.Huffman.UnsafeNativeMethods.FreeTablesMemoryWrapper(pStructHuffed);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00008C71 File Offset: 0x00006E71
		internal unsafe static int FreePromptMemoryWrapper(ushort* pPrompts)
		{
			return global::Motorola.Common.Communication.TetraUtility.Huffman.UnsafeNativeMethods.FreePromptMemoryWrapper(pPrompts);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00008C7C File Offset: 0x00006E7C
		public unsafe static bool UnhuffCS(global::Motorola.Common.Communication.TetraUtility.HuffedStructCS structInputHuffed, uint huffPromptDataTableSize, out string[] promptDataStringArray)
		{
			bool result;
			try
			{
				lock (global::Motorola.Common.Communication.TetraUtility.Huffman._huffmanLock)
				{
					global::Motorola.Common.Communication.TetraUtility.HuffedStruct structInputHuffed2 = default(global::Motorola.Common.Communication.TetraUtility.HuffedStruct);
					try
					{
						fixed (byte* ptr = &structInputHuffed.huffData[(int)((global::System.UIntPtr)structInputHuffed.huffPromptDataPtr)])
						{
							try
							{
								fixed (byte* ptr2 = &structInputHuffed.huffData[(int)((global::System.UIntPtr)structInputHuffed.huffDecodeTablePtr)])
								{
									try
									{
										fixed (byte* ptr3 = &structInputHuffed.huffData[(int)((global::System.UIntPtr)structInputHuffed.huffOffsetTablePtr)])
										{
											structInputHuffed2.pHuffPromptDataTable = ptr;
											structInputHuffed2.pHuffDecodeTable = ptr2;
											structInputHuffed2.pHuffOffsetTable = ptr3;
											structInputHuffed2.nHuffPromptDataTableSize = structInputHuffed.huffPromptDataTableSize;
											structInputHuffed2.nHuffDecodeTableSize = structInputHuffed.huffDecodeTableSize;
											structInputHuffed2.nHuffOffsetTableSize = structInputHuffed.huffOffsetTableSize;
											ushort* ptr4 = null;
											global::Motorola.Common.Communication.TetraUtility.Huffman.UnhuffTablesWrapper(structInputHuffed2, huffPromptDataTableSize, &ptr4);
											promptDataStringArray = new string[huffPromptDataTableSize];
											global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
											int num = 0;
											int num2 = 0;
											int num3 = 0;
											while ((long)num3 < (long)((ulong)huffPromptDataTableSize))
											{
												while (ptr4[num2] != 0)
												{
													num2++;
												}
												byte[] array = new byte[(num2 - num) * 2];
												int i = num;
												int num4 = 0;
												while (i < num2)
												{
													array[num4] = (byte)(ptr4[i] & 255);
													array[num4 + 1] = (byte)(ptr4[i] >> 8);
													i++;
													num4 += 2;
												}
												string @string = unicodeEncoding.GetString(array);
												promptDataStringArray[num3] = @string;
												num2++;
												num = num2;
												num3++;
											}
											global::Motorola.Common.Communication.TetraUtility.Huffman.FreePromptMemoryWrapper(ptr4);
											result = true;
										}
									}
									finally
									{
										byte* ptr3 = null;
									}
								}
							}
							finally
							{
								byte* ptr2 = null;
							}
						}
					}
					finally
					{
						byte* ptr = null;
					}
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception #{0}: {1}", new object[]
				{
					ex.ErrorID,
					ex
				});
				promptDataStringArray = null;
				result = false;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}", new object[]
				{
					ex2
				});
				promptDataStringArray = null;
				result = false;
			}
			return result;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00008F04 File Offset: 0x00007104
		public unsafe static bool Huff(string[] promptDataStringArray, uint nUnhuffPromptTableSize, out global::Motorola.Common.Communication.TetraUtility.HuffedStruct huffedStruct)
		{
			huffedStruct = default(global::Motorola.Common.Communication.TetraUtility.HuffedStruct);
			if (promptDataStringArray == null || promptDataStringArray.Length == 0)
			{
				return false;
			}
			bool result;
			try
			{
				lock (global::Motorola.Common.Communication.TetraUtility.Huffman._huffmanLock)
				{
					global::System.Text.UnicodeEncoding unicodeEncoding = new global::System.Text.UnicodeEncoding();
					int num = 0;
					int num2 = 0;
					for (int i = 0; i < promptDataStringArray.Length; i++)
					{
						num += promptDataStringArray[i].Length + 1;
					}
					byte[] array = new byte[num * 2];
					for (int j = 0; j < promptDataStringArray.Length; j++)
					{
						global::System.Array.Copy(unicodeEncoding.GetBytes(promptDataStringArray[j]), 0, array, num2, promptDataStringArray[j].Length * 2);
						num2 += promptDataStringArray[j].Length * 2;
						array[num2] = 0;
						array[num2 + 1] = 0;
						num2 += 2;
					}
					try
					{
						fixed (byte* ptr = &array[0])
						{
							global::Motorola.Common.Communication.TetraUtility.Huffman.HuffTablesWrapper((ushort*)ptr, nUnhuffPromptTableSize, out huffedStruct);
						}
					}
					finally
					{
						byte* ptr = null;
					}
					result = true;
				}
			}
			catch (global::Motorola.Common.Communication.TetraUtility.CCustomException ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception #{0}: {1}", new object[]
				{
					ex.ErrorID,
					ex
				});
				result = false;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError("Exception: {0}", new object[]
				{
					ex2
				});
				result = false;
			}
			return result;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000906C File Offset: 0x0000726C
		public unsafe static void FreeHuff(global::Motorola.Common.Communication.TetraUtility.HuffedStruct huff)
		{
			global::Motorola.Common.Communication.TetraUtility.Huffman.FreeTablesMemoryWrapper(&huff);
		}

		// Token: 0x04000071 RID: 113
		private static object _huffmanLock = 0;

		// Token: 0x0200001E RID: 30
		internal static class UnsafeNativeMethods
		{
			// Token: 0x060000F9 RID: 249
			[global::System.Runtime.InteropServices.DllImport("HuffmanLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "UnhuffTables")]
			internal unsafe static extern int UnhuffTablesWrapper(global::Motorola.Common.Communication.TetraUtility.HuffedStruct structInputHuffed, uint nHuffPromptDataTableSize, ushort** ppUnhuffPromptTable);

			// Token: 0x060000FA RID: 250
			[global::System.Runtime.InteropServices.DllImport("HuffmanLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "HuffTables")]
			internal unsafe static extern int HuffTablesWrapper(ushort* pUnhuffPromptTable, uint nUnhuffPromptTableSize, out global::Motorola.Common.Communication.TetraUtility.HuffedStruct pStructOutputHuffed);

			// Token: 0x060000FB RID: 251
			[global::System.Runtime.InteropServices.DllImport("HuffmanLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "FreeTablesMemory")]
			internal unsafe static extern int FreeTablesMemoryWrapper(global::Motorola.Common.Communication.TetraUtility.HuffedStruct* pStructHuffed);

			// Token: 0x060000FC RID: 252
			[global::System.Runtime.InteropServices.DllImport("HuffmanLib.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "FreePromptMemory")]
			internal unsafe static extern int FreePromptMemoryWrapper(ushort* pPrompts);
		}
	}
}
