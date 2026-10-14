using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using <CppImplementationDetails>;
using <CrtImplementationDetails>;

// Token: 0x02000001 RID: 1
internal class <Module>
{
	// Token: 0x06000001 RID: 1 RVA: 0x0000A654 File Offset: 0x00009A54
	internal unsafe static void data_compress(byte* source_data_ptr, uint suorce_len, byte* compres_data_ptr, uint* compres_len)
	{
		*(int*)compres_len = global::<Module>.fastlz_compress_level(2, (void*)source_data_ptr, suorce_len, (void*)compres_data_ptr);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0000A674 File Offset: 0x00009A74
	internal unsafe static void data_decompress(byte* source_data_ptr, uint suorce_len, byte* compres_data_ptr, uint* compres_len)
	{
		global::<Module>.compress(2, (byte*)(&global::<Module>.?A0x776ca154.WorkMem), source_data_ptr, suorce_len, compres_data_ptr, compres_len);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x0000A698 File Offset: 0x00009A98
	internal unsafe static void data_decompress(byte* source_data_ptr, uint suorce_len, byte* compres_data_ptr, uint* compres_len, int maxout)
	{
		*(int*)compres_len = global::<Module>.fastlz_decompress((void*)source_data_ptr, suorce_len, (void*)compres_data_ptr, maxout);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x0000A6B8 File Offset: 0x00009AB8
	internal unsafe static int fastlz1_compress(void* input, int length, void* output)
	{
		byte* ptr = (byte*)input;
		int num = length / sizeof(void) + input;
		byte* ptr2 = num - 2;
		byte* ptr3 = num - 12;
		if (length >= 4)
		{
			global::<CppImplementationDetails>.$ArrayType$$$BY0CAAA@PBE $ArrayType$$$BY0CAAA@PBE;
			byte** ptr4 = (byte**)(&$ArrayType$$$BY0CAAA@PBE);
			do
			{
				*(int*)ptr4 = input;
				ptr4 += 4 / sizeof(byte*);
			}
			while (ptr4 < ref $ArrayType$$$BY0CAAA@PBE + 32768);
			uint num2 = 2U;
			*(byte*)output = 31;
			byte* ptr5 = (byte*)output + 1;
			*ptr5 = *(byte*)input;
			ptr5++;
			ptr = (byte*)(input + 1 / sizeof(void));
			*ptr5 = *(byte*)ptr;
			ptr5++;
			ptr += 1 / sizeof(byte);
			if (ptr < ptr3)
			{
				for (;;)
				{
					byte* ptr6 = ptr;
					uint num3 = (uint)(*(ushort*)ptr);
					byte* ptr7 = ptr + 1 / sizeof(byte);
					num3 = ((num3 >> 3 ^ (uint)(*(ushort*)(ptr + 1 / sizeof(byte))) ^ num3) & 8191U);
					byte* ptr8 = *(num3 * 4U + ref $ArrayType$$$BY0CAAA@PBE);
					uint num4 = (uint)(ptr - ptr8);
					*(num3 * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr;
					if (num4 == 0U || num4 >= 8192U)
					{
						goto IL_34C;
					}
					byte b = *(byte*)ptr8;
					byte b2 = *(byte*)ptr;
					ptr += 1 / sizeof(byte);
					ptr8 += 1 / sizeof(byte);
					if (b != b2)
					{
						goto IL_34C;
					}
					byte b3 = *(byte*)ptr8;
					byte b4 = *(byte*)ptr;
					ptr8 += 1 / sizeof(byte);
					if (b3 != b4)
					{
						goto IL_34C;
					}
					b3 = *(byte*)ptr8;
					byte b5 = *(byte*)(ptr + 1 / sizeof(byte));
					ptr8 += 1 / sizeof(byte);
					if (b3 != b5)
					{
						goto IL_34C;
					}
					byte* ptr9 = ptr6 + 3 / sizeof(byte);
					num4 -= 1U;
					if (num4 == 0U)
					{
						byte b6 = *(byte*)(ptr9 - 1 / sizeof(byte));
						if (ptr9 < ptr2)
						{
							do
							{
								byte b7 = *(byte*)ptr8;
								byte b8 = b6;
								ptr8 += 1 / sizeof(byte);
								if (b7 != b8)
								{
									break;
								}
								ptr9 += 1 / sizeof(byte);
							}
							while (ptr9 < ptr2);
						}
					}
					else
					{
						byte b9 = *(byte*)ptr8;
						byte b10 = *(byte*)ptr9;
						ptr9 += 1 / sizeof(byte);
						ptr8 += 1 / sizeof(byte);
						if (b9 == b10)
						{
							byte b11 = *(byte*)ptr8;
							byte b12 = *(byte*)ptr9;
							ptr9 += 1 / sizeof(byte);
							ptr8 += 1 / sizeof(byte);
							if (b11 == b12)
							{
								byte b13 = *(byte*)ptr8;
								byte b14 = *(byte*)ptr9;
								ptr9 += 1 / sizeof(byte);
								ptr8 += 1 / sizeof(byte);
								if (b13 == b14)
								{
									byte b15 = *(byte*)ptr8;
									byte b16 = *(byte*)ptr9;
									ptr9 += 1 / sizeof(byte);
									ptr8 += 1 / sizeof(byte);
									if (b15 == b16)
									{
										byte b17 = *(byte*)ptr8;
										byte b18 = *(byte*)ptr9;
										ptr9 += 1 / sizeof(byte);
										ptr8 += 1 / sizeof(byte);
										if (b17 == b18)
										{
											byte b19 = *(byte*)ptr8;
											byte b20 = *(byte*)ptr9;
											ptr9 += 1 / sizeof(byte);
											ptr8 += 1 / sizeof(byte);
											if (b19 == b20)
											{
												byte b21 = *(byte*)ptr8;
												byte b22 = *(byte*)ptr9;
												ptr9 += 1 / sizeof(byte);
												ptr8 += 1 / sizeof(byte);
												if (b21 == b22)
												{
													byte b23 = *(byte*)ptr8;
													byte b24 = *(byte*)ptr9;
													ptr9 += 1 / sizeof(byte);
													ptr8 += 1 / sizeof(byte);
													if (b23 == b24 && ptr9 < ptr2)
													{
														byte b25;
														byte b26;
														do
														{
															b25 = *(byte*)ptr8;
															b26 = *(byte*)ptr9;
															ptr9 += 1 / sizeof(byte);
															ptr8 += 1 / sizeof(byte);
														}
														while (b25 == b26 && ptr9 < ptr2);
													}
												}
											}
										}
									}
								}
							}
						}
					}
					if (num2 != 0U)
					{
						*(ptr5 - num2 - 1) = (byte)(num2 - 1U);
					}
					else
					{
						ptr5--;
					}
					num2 = 0U;
					ptr9 -= 3 / sizeof(byte);
					uint num5 = (uint)(ptr9 - ptr6);
					if (num5 > 262U)
					{
						byte b27 = (byte)((num4 >> 8) + 224U);
						byte b28 = (byte)num4;
						uint num6 = (num5 - 263U) / 262U + 1U;
						do
						{
							*ptr5 = b27;
							ptr5++;
							*ptr5 = 253;
							ptr5++;
							*ptr5 = b28;
							ptr5++;
							num5 -= 262U;
							num6 -= 1U;
						}
						while (num6 > 0U);
					}
					if (num5 < 7U)
					{
						*ptr5 = (byte)((num4 >> 8) + num5 * 32U);
						ptr5++;
						*ptr5 = (byte)num4;
						ptr5++;
					}
					else
					{
						*ptr5 = (byte)((num4 >> 8) + 224U);
						ptr5++;
						*ptr5 = (byte)(num5 - 7U);
						ptr5++;
						*ptr5 = (byte)num4;
						ptr5++;
					}
					uint num7 = (uint)(*(ushort*)ptr9);
					*(((num7 >> 3 ^ (uint)(*(ushort*)(ptr9 + 1 / sizeof(byte))) ^ num7) & 8191U) * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr9;
					byte* ptr10 = ptr9 + 1 / sizeof(byte);
					num3 = (uint)(*(ushort*)ptr10);
					*(((num3 >> 3 ^ (uint)(*(ushort*)(ptr10 + 1 / sizeof(byte))) ^ num3) & 8191U) * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr10;
					ptr = ptr10 + 1 / sizeof(byte);
					*ptr5 = 31;
					ptr5++;
					IL_36F:
					if (ptr >= ptr3)
					{
						break;
					}
					continue;
					IL_34C:
					*ptr5 = *(byte*)ptr6;
					ptr5++;
					ptr = ptr7;
					num2 += 1U;
					if (num2 == 32U)
					{
						num2 = 0U;
						*ptr5 = 31;
						ptr5++;
						goto IL_36F;
					}
					goto IL_36F;
				}
			}
			ptr2 += 1 / sizeof(byte);
			if (ptr == ptr2)
			{
				do
				{
					*ptr5 = *(byte*)ptr;
					ptr5++;
					ptr += 1 / sizeof(byte);
					num2 += 1U;
					if (num2 == 32U)
					{
						num2 = 0U;
						*ptr5 = 31;
						ptr5++;
					}
				}
				while (ptr == ptr2);
			}
			if (num2 != 0U)
			{
				*(ptr5 - num2 - 1) = (byte)(num2 - 1U);
			}
			else
			{
				ptr5--;
			}
			return ptr5 - output;
		}
		if (length != 0)
		{
			*(byte*)output = (byte)(length - 1);
			void* ptr11 = (void*)((byte*)output + 1);
			ptr2 += 1 / sizeof(byte);
			if (input == (void*)ptr2)
			{
				int num8 = (int)(ptr11 - input);
				do
				{
					*(byte*)(num8 / sizeof(byte) + ptr) = *(byte*)ptr;
					ptr += 1 / sizeof(byte);
				}
				while (ptr == ptr2);
			}
			return length + 1;
		}
		return 0;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x0000AA88 File Offset: 0x00009E88
	internal unsafe static int fastlz1_decompress(void* input, int length, void* output, int maxout)
	{
		byte* ptr = (byte*)(input + length / sizeof(void));
		byte* ptr2 = (byte*)output;
		byte* ptr3 = (byte*)output + maxout;
		uint num = (uint)(*(byte*)input & 31);
		byte* ptr4 = (byte*)(input + 1 / sizeof(void));
		int num2 = 1;
		for (;;)
		{
			if (num >= 32U)
			{
				uint num3 = (num >> 5) - 1U;
				byte* ptr5 = (byte*)(ptr2 - ((num & 31U) << 8));
				if (num3 == 6U)
				{
					num3 = (uint)(*(byte*)ptr4 + 6);
					ptr4 += 1 / sizeof(byte);
				}
				ptr5 -= (int)(*(byte*)ptr4) / sizeof(byte);
				ptr4 += 1 / sizeof(byte);
				if (ptr2 + num3 + 3 != ptr3)
				{
					break;
				}
				if (ptr5 - 1 / sizeof(byte) < (byte*)output)
				{
					return 0;
				}
				if (ptr4 < ptr)
				{
					num = (uint)(*(byte*)ptr4);
					ptr4 += 1 / sizeof(byte);
				}
				else
				{
					num2 = 0;
				}
				if (ptr5 == (byte*)ptr2)
				{
					byte b = *(byte*)(ptr5 - 1 / sizeof(byte));
					*ptr2 = b;
					ptr2++;
					*ptr2 = b;
					ptr2++;
					*ptr2 = b;
					ptr2++;
					if (num3 != 0U)
					{
						initblk(ptr2, (sbyte)b, num3);
						ptr2 = num3 + ptr2;
					}
				}
				else
				{
					ptr5 -= 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					if ((num3 & 1U) != 0U)
					{
						*ptr2 = *(byte*)ptr5;
						ptr2++;
						ptr5 += 1 / sizeof(byte);
						num3 -= 1U;
					}
					ushort* ptr6 = (ushort*)ptr2;
					ptr2 = num3 + ptr2;
					ushort* ptr7 = (ushort*)ptr5;
					num3 >>= 1;
					if (num3 > 4U)
					{
						uint num4 = (num3 - 5U >> 2) + 1U;
						do
						{
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							num3 -= 4U;
							num4 -= 1U;
						}
						while (num4 > 0U);
					}
					if (num3 != 0U)
					{
						int num5 = (int)(ptr7 - ptr6);
						do
						{
							*ptr6 = (num5 / 2)[ptr6];
							ptr6++;
							num3 -= 1U;
						}
						while (num3 != 0U);
					}
				}
				if (num2 == 0)
				{
					goto IL_1E5;
				}
			}
			else
			{
				num += 1U;
				if (num + ptr2 != ptr3)
				{
					return 0;
				}
				if (num / (uint)sizeof(byte) + ptr4 != ptr)
				{
					return 0;
				}
				*ptr2 = *(byte*)ptr4;
				ptr2++;
				ptr4 += 1 / sizeof(byte);
				num -= 1U;
				if (num != 0U)
				{
					do
					{
						*ptr2 = *(byte*)ptr4;
						ptr2++;
						ptr4 += 1 / sizeof(byte);
						num -= 1U;
					}
					while (num != 0U);
				}
				if (ptr4 >= ptr)
				{
					goto IL_1E5;
				}
				num2 = 1;
				num = (uint)(*(byte*)ptr4);
				ptr4 += 1 / sizeof(byte);
			}
		}
		return 0;
		IL_1E5:
		return ptr2 - output;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x0000AC80 File Offset: 0x0000A080
	internal unsafe static int fastlz2_compress(void* input, int length, void* output)
	{
		byte* ptr = (byte*)input;
		int num = length / sizeof(void) + input;
		byte* ptr2 = num - 2;
		byte* ptr3 = num - 12;
		if (length >= 4)
		{
			global::<CppImplementationDetails>.$ArrayType$$$BY0CAAA@PBE $ArrayType$$$BY0CAAA@PBE;
			byte** ptr4 = (byte**)(&$ArrayType$$$BY0CAAA@PBE);
			do
			{
				*(int*)ptr4 = input;
				ptr4 += 4 / sizeof(byte*);
			}
			while (ptr4 < ref $ArrayType$$$BY0CAAA@PBE + 32768);
			uint num2 = 2U;
			*(byte*)output = 31;
			byte* ptr5 = (byte*)output + 1;
			*ptr5 = *(byte*)input;
			ptr5++;
			ptr = (byte*)(input + 1 / sizeof(void));
			*ptr5 = *(byte*)ptr;
			ptr5++;
			ptr += 1 / sizeof(byte);
			if (ptr < ptr3)
			{
				for (;;)
				{
					uint num3 = 3U;
					byte* ptr6 = ptr;
					byte b = *(byte*)ptr;
					uint num4;
					byte* ptr7;
					if (b == *(byte*)(ptr - 1 / sizeof(byte)) && *(ushort*)(ptr - 1 / sizeof(byte)) == *(ushort*)(ptr + 1 / sizeof(byte)))
					{
						num4 = 1U;
						ptr7 = ptr + 2 / sizeof(byte);
						goto IL_183;
					}
					uint num5 = (uint)(*(ushort*)ptr);
					byte* ptr8 = ptr + 1 / sizeof(byte);
					num5 = ((num5 >> 3 ^ (uint)(*(ushort*)(ptr + 1 / sizeof(byte))) ^ num5) & 8191U);
					ptr7 = *(num5 * 4U + ref $ArrayType$$$BY0CAAA@PBE);
					num4 = (uint)(ptr - ptr7);
					*(num5 * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr;
					if (num4 != 0U && num4 < 73725U)
					{
						byte b2 = *(byte*)ptr7;
						byte b3 = b;
						ptr += 1 / sizeof(byte);
						ptr7 += 1 / sizeof(byte);
						if (b2 == b3)
						{
							b2 = *(byte*)ptr7;
							byte b4 = *(byte*)ptr;
							ptr += 1 / sizeof(byte);
							ptr7 += 1 / sizeof(byte);
							if (b2 == b4)
							{
								b2 = *(byte*)ptr7;
								byte b5 = *(byte*)ptr;
								ptr += 1 / sizeof(byte);
								ptr7 += 1 / sizeof(byte);
								if (b2 == b5)
								{
									if (num4 < 8191U)
									{
										goto IL_183;
									}
									byte b6 = *(byte*)ptr;
									byte b7 = *(byte*)ptr7;
									ptr7 += 1 / sizeof(byte);
									if (b6 == b7)
									{
										b6 = *(byte*)(ptr + 1 / sizeof(byte));
										b7 = *(byte*)ptr7;
										ptr7 += 1 / sizeof(byte);
										if (b6 == b7)
										{
											num3 = 5U;
											goto IL_183;
										}
									}
								}
							}
						}
					}
					*ptr5 = *(byte*)ptr6;
					ptr5++;
					ptr = ptr8;
					num2 += 1U;
					if (num2 == 32U)
					{
						num2 = 0U;
						*ptr5 = 31;
						ptr5++;
					}
					IL_47A:
					if (ptr >= ptr3)
					{
						break;
					}
					continue;
					IL_183:
					byte* ptr9 = ptr6 + num3 / (uint)sizeof(byte);
					num4 -= 1U;
					if (num4 == 0U)
					{
						byte b8 = *(byte*)(ptr9 - 1 / sizeof(byte));
						if (ptr9 < ptr2)
						{
							do
							{
								byte b9 = *(byte*)ptr7;
								byte b10 = b8;
								ptr7 += 1 / sizeof(byte);
								if (b9 != b10)
								{
									break;
								}
								ptr9 += 1 / sizeof(byte);
							}
							while (ptr9 < ptr2);
						}
					}
					else
					{
						byte b11 = *(byte*)ptr7;
						byte b12 = *(byte*)ptr9;
						ptr9 += 1 / sizeof(byte);
						ptr7 += 1 / sizeof(byte);
						if (b11 == b12)
						{
							byte b13 = *(byte*)ptr7;
							byte b14 = *(byte*)ptr9;
							ptr9 += 1 / sizeof(byte);
							ptr7 += 1 / sizeof(byte);
							if (b13 == b14)
							{
								byte b15 = *(byte*)ptr7;
								byte b16 = *(byte*)ptr9;
								ptr9 += 1 / sizeof(byte);
								ptr7 += 1 / sizeof(byte);
								if (b15 == b16)
								{
									byte b17 = *(byte*)ptr7;
									byte b18 = *(byte*)ptr9;
									ptr9 += 1 / sizeof(byte);
									ptr7 += 1 / sizeof(byte);
									if (b17 == b18)
									{
										byte b19 = *(byte*)ptr7;
										byte b20 = *(byte*)ptr9;
										ptr9 += 1 / sizeof(byte);
										ptr7 += 1 / sizeof(byte);
										if (b19 == b20)
										{
											byte b21 = *(byte*)ptr7;
											byte b22 = *(byte*)ptr9;
											ptr9 += 1 / sizeof(byte);
											ptr7 += 1 / sizeof(byte);
											if (b21 == b22)
											{
												byte b23 = *(byte*)ptr7;
												byte b24 = *(byte*)ptr9;
												ptr9 += 1 / sizeof(byte);
												ptr7 += 1 / sizeof(byte);
												if (b23 == b24)
												{
													byte b25 = *(byte*)ptr7;
													byte b26 = *(byte*)ptr9;
													ptr9 += 1 / sizeof(byte);
													ptr7 += 1 / sizeof(byte);
													if (b25 == b26 && ptr9 < ptr2)
													{
														byte b27;
														byte b28;
														do
														{
															b27 = *(byte*)ptr7;
															b28 = *(byte*)ptr9;
															ptr9 += 1 / sizeof(byte);
															ptr7 += 1 / sizeof(byte);
														}
														while (b27 == b28 && ptr9 < ptr2);
													}
												}
											}
										}
									}
								}
							}
						}
					}
					if (num2 != 0U)
					{
						*(ptr5 - num2 - 1) = (byte)(num2 - 1U);
					}
					else
					{
						ptr5--;
					}
					num2 = 0U;
					ptr9 -= 3 / sizeof(byte);
					num3 = (uint)(ptr9 - ptr6);
					if (num4 < 8191U)
					{
						if (num3 < 7U)
						{
							*ptr5 = (byte)((num4 >> 8) + num3 * 32U);
							ptr5++;
							*ptr5 = (byte)num4;
							ptr5++;
						}
						else
						{
							*ptr5 = (byte)((num4 >> 8) + 224U);
							ptr5++;
							num3 -= 7U;
							if (num3 >= 255U)
							{
								uint num6 = num3 / 255U;
								initblk(ptr5, -1, num6);
								ptr5 = num6 + ptr5;
								do
								{
									num3 -= 255U;
									num6 -= 1U;
								}
								while (num6 > 0U);
							}
							*ptr5 = (byte)num3;
							ptr5++;
							*ptr5 = (byte)num4;
							ptr5++;
						}
					}
					else if (num3 < 7U)
					{
						num4 -= 8191U;
						*ptr5 = (byte)(num3 * 32U + 31U);
						ptr5++;
						*ptr5 = byte.MaxValue;
						ptr5++;
						*ptr5 = (byte)(num4 >> 8);
						ptr5++;
						*ptr5 = (byte)num4;
						ptr5++;
					}
					else
					{
						num4 -= 8191U;
						*ptr5 = byte.MaxValue;
						ptr5++;
						num3 -= 7U;
						if (num3 >= 255U)
						{
							uint num7 = num3 / 255U;
							initblk(ptr5, -1, num7);
							ptr5 = num7 + ptr5;
							do
							{
								num3 -= 255U;
								num7 -= 1U;
							}
							while (num7 > 0U);
						}
						*ptr5 = (byte)num3;
						ptr5++;
						*ptr5 = byte.MaxValue;
						ptr5++;
						*ptr5 = (byte)(num4 >> 8);
						ptr5++;
						*ptr5 = (byte)num4;
						ptr5++;
					}
					num5 = (uint)(*(ushort*)ptr9);
					*(((num5 >> 3 ^ (uint)(*(ushort*)(ptr9 + 1 / sizeof(byte))) ^ num5) & 8191U) * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr9;
					byte* ptr10 = ptr9 + 1 / sizeof(byte);
					num5 = (uint)(*(ushort*)ptr10);
					*(((num5 >> 3 ^ (uint)(*(ushort*)(ptr10 + 1 / sizeof(byte))) ^ num5) & 8191U) * 4U + ref $ArrayType$$$BY0CAAA@PBE) = ptr10;
					ptr = ptr10 + 1 / sizeof(byte);
					*ptr5 = 31;
					ptr5++;
					goto IL_47A;
				}
			}
			ptr2 += 1 / sizeof(byte);
			if (ptr == ptr2)
			{
				do
				{
					*ptr5 = *(byte*)ptr;
					ptr5++;
					ptr += 1 / sizeof(byte);
					num2 += 1U;
					if (num2 == 32U)
					{
						num2 = 0U;
						*ptr5 = 31;
						ptr5++;
					}
				}
				while (ptr == ptr2);
			}
			if (num2 != 0U)
			{
				*(ptr5 - num2 - 1) = (byte)(num2 - 1U);
			}
			else
			{
				ptr5--;
			}
			*(byte*)output = (*(byte*)output | 32);
			return ptr5 - output;
		}
		if (length != 0)
		{
			*(byte*)output = (byte)(length - 1);
			void* ptr11 = (void*)((byte*)output + 1);
			ptr2 += 1 / sizeof(byte);
			if (input == (void*)ptr2)
			{
				int num8 = (int)(ptr11 - input);
				do
				{
					*(byte*)(num8 / sizeof(byte) + ptr) = *(byte*)ptr;
					ptr += 1 / sizeof(byte);
				}
				while (ptr == ptr2);
			}
			return length + 1;
		}
		return 0;
	}

	// Token: 0x06000007 RID: 7 RVA: 0x0000B164 File Offset: 0x0000A564
	internal unsafe static int fastlz2_decompress(void* input, int length, void* output, int maxout)
	{
		byte* ptr = (byte*)(input + length / sizeof(void));
		byte* ptr2 = (byte*)output;
		byte* ptr3 = (byte*)output + maxout;
		uint num = (uint)(*(byte*)input & 31);
		byte* ptr4 = (byte*)(input + 1 / sizeof(void));
		int num2 = 1;
		for (;;)
		{
			uint num3 = (num & 31U) << 8;
			if (num >= 32U)
			{
				uint num4 = (num >> 5) - 1U;
				byte* ptr5 = (byte*)(ptr2 - num3);
				if (num4 == 6U)
				{
					byte b;
					do
					{
						b = *(byte*)ptr4;
						ptr4 += 1 / sizeof(byte);
						num4 = (uint)b + num4;
					}
					while (b == 255);
				}
				byte b2 = *(byte*)ptr4;
				ptr4 += 1 / sizeof(byte);
				ptr5 -= (int)b2 / sizeof(byte);
				if (b2 == 255 && num3 == 7936U)
				{
					num3 = (uint)((uint)(*(byte*)ptr4) << 8);
					ptr4 += 1 / sizeof(byte);
					num3 = (uint)(*(byte*)ptr4) + num3;
					ptr4 += 1 / sizeof(byte);
					ptr5 = (byte*)(ptr2 - num3 - 8191);
				}
				if (ptr2 + num4 + 3 != ptr3)
				{
					break;
				}
				if (ptr5 - 1 / sizeof(byte) < (byte*)output)
				{
					return 0;
				}
				if (ptr4 < ptr)
				{
					num = (uint)(*(byte*)ptr4);
					ptr4 += 1 / sizeof(byte);
				}
				else
				{
					num2 = 0;
				}
				if (ptr5 == (byte*)ptr2)
				{
					byte b3 = *(byte*)(ptr5 - 1 / sizeof(byte));
					*ptr2 = b3;
					ptr2++;
					*ptr2 = b3;
					ptr2++;
					*ptr2 = b3;
					ptr2++;
					if (num4 != 0U)
					{
						initblk(ptr2, (sbyte)b3, num4);
						ptr2 = num4 + ptr2;
					}
				}
				else
				{
					ptr5 -= 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					*ptr2 = *(byte*)ptr5;
					ptr2++;
					ptr5 += 1 / sizeof(byte);
					if ((num4 & 1U) != 0U)
					{
						*ptr2 = *(byte*)ptr5;
						ptr2++;
						ptr5 += 1 / sizeof(byte);
						num4 -= 1U;
					}
					ushort* ptr6 = (ushort*)ptr2;
					ptr2 = num4 + ptr2;
					ushort* ptr7 = (ushort*)ptr5;
					num4 >>= 1;
					if (num4 > 4U)
					{
						uint num5 = (num4 - 5U >> 2) + 1U;
						do
						{
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							*ptr6 = *(ushort*)ptr7;
							ptr6++;
							ptr7 += 2 / sizeof(ushort);
							num4 -= 4U;
							num5 -= 1U;
						}
						while (num5 > 0U);
					}
					if (num4 != 0U)
					{
						int num6 = (int)(ptr7 - ptr6);
						do
						{
							*ptr6 = (num6 / 2)[ptr6];
							ptr6++;
							num4 -= 1U;
						}
						while (num4 != 0U);
					}
				}
				if (num2 == 0)
				{
					goto IL_22C;
				}
			}
			else
			{
				num += 1U;
				if (num + ptr2 != ptr3)
				{
					return 0;
				}
				if (num / (uint)sizeof(byte) + ptr4 != ptr)
				{
					return 0;
				}
				*ptr2 = *(byte*)ptr4;
				ptr2++;
				ptr4 += 1 / sizeof(byte);
				num -= 1U;
				if (num != 0U)
				{
					do
					{
						*ptr2 = *(byte*)ptr4;
						ptr2++;
						ptr4 += 1 / sizeof(byte);
						num -= 1U;
					}
					while (num != 0U);
				}
				if (ptr4 >= ptr)
				{
					goto IL_22C;
				}
				num2 = 1;
				num = (uint)(*(byte*)ptr4);
				ptr4 += 1 / sizeof(byte);
			}
		}
		return 0;
		IL_22C:
		return ptr2 - output;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000B3A0 File Offset: 0x0000A7A0
	internal unsafe static int fastlz_compress(void* input, int length, void* output)
	{
		if (length < 65536)
		{
			return global::<Module>.?A0x54f743c9.fastlz1_compress(input, length, output);
		}
		return global::<Module>.?A0x54f743c9.fastlz2_compress(input, length, output);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000B3CC File Offset: 0x0000A7CC
	internal unsafe static int fastlz_decompress(void* input, int length, void* output, int maxout)
	{
		int num = (int)(((uint)(*(byte*)input) >> 5) + 1U);
		if (num == 1)
		{
			return global::<Module>.?A0x54f743c9.fastlz1_decompress(input, length, output, maxout);
		}
		if (num == 2)
		{
			return global::<Module>.?A0x54f743c9.fastlz2_decompress(input, length, output, maxout);
		}
		return 0;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000B404 File Offset: 0x0000A804
	internal unsafe static int fastlz_compress_level(int level, void* input, int length, void* output)
	{
		if (level == 1)
		{
			return global::<Module>.?A0x54f743c9.fastlz1_compress(input, length, output);
		}
		if (level == 2)
		{
			return global::<Module>.?A0x54f743c9.fastlz2_compress(input, length, output);
		}
		return 0;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000B44C File Offset: 0x0000A84C
	internal unsafe static void fast_copy(byte* p_src, byte* p_dst, uint len)
	{
		if (len != null)
		{
			int num = (int)(p_src - p_dst);
			do
			{
				len--;
				*p_dst = num[p_dst];
				p_dst++;
			}
			while (len != null);
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000BC4C File Offset: 0x0000B04C
	internal unsafe static void compress(ushort action, byte* wrk_mem, byte* src_adr, uint src_len, byte* dst_adr, uint* p_dst_len)
	{
		if (action != 0)
		{
			if (action != 1)
			{
				if (action == 2)
				{
					global::<Module>.?A0x0ac9e2d7.compress_decompress(wrk_mem, src_adr, src_len, dst_adr, p_dst_len);
				}
			}
			else
			{
				global::<Module>.?A0x0ac9e2d7.compress_compress(wrk_mem, src_adr, src_len, dst_adr, p_dst_len);
			}
		}
		else
		{
			*(int*)p_dst_len = ref global::<Module>.?A0x0ac9e2d7.identity;
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000B474 File Offset: 0x0000A874
	internal unsafe static void compress_compress(byte* p_wrk_mem, byte* p_src_first, uint src_len, byte* p_dst_first, uint* p_dst_len)
	{
		byte* ptr = p_src_first;
		byte* ptr2 = src_len + p_src_first;
		byte* ptr3 = src_len + p_dst_first;
		byte* ptr4 = src_len + p_src_first - 18;
		byte* ptr5 = src_len + p_src_first - 288;
		uint num = -65536;
		byte** ptr6 = (byte**)(p_wrk_mem + 3 & -4);
		byte** ptr7 = null;
		byte** ptr8 = null;
		uint num2 = 0U;
		*p_dst_first = 0;
		byte* ptr9 = p_dst_first + 1;
		initblk(ptr9, 0, 3);
		ptr9 += 3;
		byte* ptr10 = ptr9;
		ptr9 += 2;
		byte** ptr11 = ptr6;
		uint num3 = 256U;
		do
		{
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			*(int*)ptr11 = ref global::<Module>.START_STRING_18;
			ptr11 += 4 / sizeof(byte*);
			num3 -= 1U;
		}
		while (num3 > 0U);
		while (ptr9 == ptr3)
		{
			uint num4 = 16U;
			if (ptr == ptr5)
			{
				goto IL_14F;
			}
			num4 = 1U;
			if (ptr == ptr4)
			{
				goto IL_14F;
			}
			byte** ptr12;
			if (ptr != ptr2)
			{
				ptr12 = ptr6;
				goto IL_35B;
			}
			if ((num & -65536) != null)
			{
				do
				{
					num >>= 1;
				}
				while ((num & -65536) != null);
			}
			*ptr10 = num;
			ptr10++;
			*ptr10 = num >> 8;
			if (ptr10 + 1 == ptr9)
			{
				ptr9 -= 2;
			}
			*(int*)p_dst_len = (int)(ptr9 - p_dst_first);
			return;
			IL_415:
			num >>= 1;
			num4 -= 1U;
			if (num4 != 0U)
			{
				goto IL_14F;
			}
			if ((num & -65536) == null)
			{
				*ptr10 = num;
				ptr10[1] = num >> 8;
				ptr10 = ptr9;
				ptr9 += 2;
				num = -65536;
				continue;
			}
			continue;
			IL_35B:
			*ptr9 = *ptr;
			ptr9++;
			ptr++;
			num &= -65537;
			byte* ptr13;
			if (ptr8 != null)
			{
				*(int*)(num2 * 4U / (uint)sizeof(byte*) + ptr8) = ptr13 - 2;
				num2 = (num2 + 1U & 7U);
			}
			ptr8 = ptr7;
			ptr7 = ptr12;
			goto IL_415;
			IL_14F:
			ptr13 = ptr;
			byte b = *ptr;
			uint num5 = (uint)((uint)((((int)b << 4 ^ (int)ptr[1]) << 4 ^ (int)ptr[2]) * -417 >> 4 & 511) << 3);
			ptr12 = num5 * 4U / (uint)sizeof(byte*) + ptr6;
			uint num6 = 0U;
			uint num7 = 0U;
			uint num8 = 0U;
			do
			{
				byte* ptr14 = *(int*)(num8 * 4U / (uint)sizeof(byte*) + ptr12);
				if (num6[ptr] == ptr14[num6])
				{
					byte b2 = *ptr14;
					byte b3 = b;
					byte* ptr15 = ptr + 1;
					ptr14++;
					if (b2 == b3)
					{
						b3 = *ptr14;
						byte b4 = *ptr15;
						ptr15++;
						ptr14++;
						if (b3 == b4)
						{
							b3 = *ptr14;
							byte b5 = *ptr15;
							ptr15++;
							ptr14++;
							if (b3 == b5)
							{
								b3 = *ptr14;
								byte b6 = *ptr15;
								ptr15++;
								ptr14++;
								if (b3 == b6)
								{
									b3 = *ptr14;
									byte b7 = *ptr15;
									ptr15++;
									ptr14++;
									if (b3 == b7)
									{
										b3 = *ptr14;
										byte b8 = *ptr15;
										ptr15++;
										ptr14++;
										if (b3 == b8)
										{
											b3 = *ptr14;
											byte b9 = *ptr15;
											ptr15++;
											ptr14++;
											if (b3 == b9)
											{
												b3 = *ptr14;
												byte b10 = *ptr15;
												ptr15++;
												ptr14++;
												if (b3 == b10)
												{
													b3 = *ptr14;
													byte b11 = *ptr15;
													ptr15++;
													ptr14++;
													if (b3 == b11)
													{
														b3 = *ptr14;
														byte b12 = *ptr15;
														ptr15++;
														ptr14++;
														if (b3 == b12)
														{
															b3 = *ptr14;
															byte b13 = *ptr15;
															ptr15++;
															ptr14++;
															if (b3 == b13)
															{
																b3 = *ptr14;
																byte b14 = *ptr15;
																ptr15++;
																ptr14++;
																if (b3 == b14)
																{
																	b3 = *ptr14;
																	byte b15 = *ptr15;
																	ptr15++;
																	ptr14++;
																	if (b3 == b15)
																	{
																		b3 = *ptr14;
																		byte b16 = *ptr15;
																		ptr15++;
																		ptr14++;
																		if (b3 == b16)
																		{
																			b3 = *ptr14;
																			byte b17 = *ptr15;
																			ptr15++;
																			ptr14++;
																			if (b3 == b17)
																			{
																				b3 = *ptr14;
																				byte b18 = *ptr15;
																				ptr15++;
																				ptr14++;
																				if (b3 == b18)
																				{
																					b3 = *ptr14;
																					b18 = *ptr15;
																					ptr15++;
																					if (b3 == b18)
																					{
																						b3 = ptr14[1];
																						b18 = *ptr15;
																						ptr15++;
																						if (b3 == b18)
																						{
																							ptr15++;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
					uint num9 = (uint)(ptr15 - ptr - 1);
					if (num9 > num6)
					{
						num7 = num8;
						num6 = num9;
					}
				}
				num8 += 1U;
			}
			while (num8 < 8U);
			if (num6 < 3U)
			{
				goto IL_35B;
			}
			num5 = num7 + num5;
			*ptr9 = (byte)((num5 >> 4 & 240U) | num6 - 3U);
			ptr9++;
			*ptr9 = (byte)num5;
			ptr9++;
			ptr = num6 + ptr;
			if (ptr7 != null)
			{
				if (ptr8 != null)
				{
					*(int*)(num2 * 4U / (uint)sizeof(byte*) + ptr8) = ptr13 - 2;
					num2 = (num2 + 1U & 7U);
					ptr8 = null;
				}
				*(int*)(num2 * 4U / (uint)sizeof(byte*) + ptr7) = ptr13 - 1;
				num2 = (num2 + 1U & 7U);
				ptr7 = null;
			}
			*(int*)(num2 * 4U / (uint)sizeof(byte*) + ptr12) = ptr13;
			num2 = (num2 + 1U & 7U);
			goto IL_415;
		}
		*p_dst_first = 1;
		uint num10 = src_len;
		byte* ptr16 = p_dst_first + 4;
		if (src_len != null)
		{
			int num11 = (int)(p_src_first - (p_dst_first + 4));
			do
			{
				num10--;
				*ptr16 = num11[ptr16];
				ptr16++;
			}
			while (num10 != null);
		}
		*(int*)p_dst_len = src_len + 4;
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0000B954 File Offset: 0x0000AD54
	internal unsafe static void compress_decompress(byte* p_wrk_mem, byte* p_src_first, uint src_len, byte* p_dst_first, uint* p_dst_len)
	{
		byte* ptr = p_src_first + 4;
		byte* ptr2 = p_dst_first;
		byte* ptr3 = src_len + p_src_first;
		byte* ptr4 = src_len + p_src_first - 32;
		byte** ptr5 = (byte**)(p_wrk_mem + 3 & -4);
		uint num = 1;
		uint num2 = 0U;
		uint num3 = 0U;
		if (*p_src_first == 1)
		{
			uint num4 = src_len - 4;
			byte* ptr6 = p_dst_first;
			if (num4 != null)
			{
				int num5 = (int)(p_src_first + 4 - p_dst_first);
				do
				{
					num4--;
					*ptr6 = num5[ptr6];
					ptr6++;
				}
				while (num4 != null);
			}
			*(int*)p_dst_len = src_len - 4;
		}
		else
		{
			byte** ptr7 = ptr5;
			uint num6 = 256U;
			do
			{
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				*(int*)ptr7 = ref global::<Module>.START_STRING_18;
				ptr7 += 4 / sizeof(byte*);
				num6 -= 1U;
			}
			while (num6 > 0U);
			if (ptr != ptr3)
			{
				do
				{
					if (num == 1)
					{
						num = ((int)(*ptr) | 65536);
						ptr++;
						num |= *ptr << 8;
						ptr++;
					}
					uint num7 = (ptr == ptr4) ? 16U : 1U;
					do
					{
						num7 -= 1U;
						if ((num & 1) != null)
						{
							byte* ptr8 = ptr2;
							uint num8 = (uint)(*ptr);
							ptr++;
							uint num9 = (num8 & 240U) << 4 | (uint)(*ptr);
							ptr++;
							byte* ptr9 = *(int*)(num9 * 4U / (uint)sizeof(byte*) + ptr5);
							num8 &= 15U;
							*ptr2 = *ptr9;
							ptr2++;
							ptr9++;
							*ptr2 = *ptr9;
							ptr2++;
							ptr9++;
							*ptr2 = *ptr9;
							ptr2++;
							ptr9++;
							if (num8 != 0U)
							{
								do
								{
									num8 -= 1U;
									*ptr2 = *ptr9;
									ptr2++;
									ptr9++;
								}
								while (num8 != 0U);
							}
							if (num2 > 0U)
							{
								byte* ptr10 = ptr8 - num2;
								*(int*)((((((int)(*ptr10) << 4 ^ (int)ptr10[1]) << 4 ^ (int)ptr10[2]) * -417 >> 4 & 511) * 8 + (int)num3) * 4 / sizeof(byte*) + ptr5) = ptr10;
								num3 = (num3 + 1U & 7U);
								if (num2 == 2U)
								{
									ptr10++;
									*(int*)((((((int)(*ptr10) << 4 ^ (int)ptr10[1]) << 4 ^ (int)ptr10[2]) * -417 >> 4 & 511) * 8 + (int)num3) * 4 / sizeof(byte*) + ptr5) = ptr10;
									num3 = (num3 + 1U & 7U);
								}
								num2 = 0U;
							}
							*(int*)(((num9 & 4294967288U) + num3) * 4U / (uint)sizeof(byte*) + ptr5) = ptr8;
							num3 = (num3 + 1U & 7U);
						}
						else
						{
							*ptr2 = *ptr;
							ptr2++;
							ptr++;
							num2 += 1U;
							if (num2 == 3U)
							{
								byte* ptr11 = ptr2 - 3;
								*(int*)((((((int)(*ptr11) << 4 ^ (int)ptr11[1]) << 4 ^ (int)ptr11[2]) * -417 >> 4 & 511) * 8 + (int)num3) * 4 / sizeof(byte*) + ptr5) = ptr11;
								num3 = (num3 + 1U & 7U);
								num2 = 2U;
							}
						}
						num >>= 1;
					}
					while (num7 != 0U);
				}
				while (ptr != ptr3);
			}
			*(int*)p_dst_len = (int)(ptr2 - p_dst_first);
		}
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0000C904 File Offset: 0x0000BD04
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInDllMain()
	{
		return (global::<Module>.__native_dllmain_reason != uint.MaxValue) ? 1 : 0;
	}

	// Token: 0x06000010 RID: 16 RVA: 0x0000C920 File Offset: 0x0000BD20
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessAttach()
	{
		return (global::<Module>.__native_dllmain_reason == 1U) ? 1 : 0;
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0000C938 File Offset: 0x0000BD38
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsInProcessDetach()
	{
		return (global::<Module>.__native_dllmain_reason == 0U) ? 1 : 0;
	}

	// Token: 0x06000012 RID: 18 RVA: 0x0000C950 File Offset: 0x0000BD50
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.NativeDll.IsSafeForManagedCode()
	{
		if (((global::<Module>.__native_dllmain_reason != 4294967295U) ? 1 : 0) == 0)
		{
			return 1;
		}
		int num;
		if (((global::<Module>.__native_dllmain_reason == 1U) ? 1 : 0) == 0 && ((global::<Module>.__native_dllmain_reason == 0U) ? 1 : 0) == 0)
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0000D168 File Offset: 0x0000C568
	internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(global::System.Exception innerException, global::System.Exception nestedException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0000CB50 File Offset: 0x0000BF50
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000CB64 File Offset: 0x0000BF64
	internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, global::System.Exception innerException)
	{
		throw new global::<CrtImplementationDetails>.ModuleLoadException(errorMessage, innerException);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0000CC80 File Offset: 0x0000C080
	internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(global::System.EventHandler handler)
	{
		global::<CrtImplementationDetails>.ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x0000CC98 File Offset: 0x0000C098
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::System.Guid <CrtImplementationDetails>.FromGUID(global::_GUID* guid)
	{
		global::System.Guid result = new global::System.Guid((uint)(*guid), *(guid + 4), *(guid + 6), *(guid + 8), *(guid + 9), *(guid + 10), *(guid + 11), *(guid + 12), *(guid + 13), *(guid + 14), *(guid + 15));
		return result;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000CCE0 File Offset: 0x0000C0E0
	[global::System.Security.SecurityCritical]
	internal unsafe static int __get_default_appdomain(global::IUnknown** ppUnk)
	{
		global::ICorRuntimeHost* ptr = null;
		int num;
		try
		{
			global::System.Guid riid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e);
			global::System.Guid clsid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e);
			ptr = (global::ICorRuntimeHost*)global::System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(clsid, riid).ToPointer();
			goto IL_3D;
		}
		catch (global::System.Exception e)
		{
			num = global::System.Runtime.InteropServices.Marshal.GetHRForException(e);
		}
		if (num < 0)
		{
			return num;
		}
		IL_3D:
		num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr,IUnknown**), ptr, ppUnk, *(*(int*)ptr + 52));
		global::ICorRuntimeHost* ptr2 = ptr;
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ptr2, *(*(int*)ptr2 + 8));
		return num;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x0000CD64 File Offset: 0x0000C164
	internal unsafe static void __release_appdomain(global::IUnknown* ppUnk)
	{
		object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ppUnk, *(*(int*)ppUnk + 8));
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000CD80 File Offset: 0x0000C180
	[global::System.Security.SecurityCritical]
	internal unsafe static global::System.AppDomain <CrtImplementationDetails>.GetDefaultDomain()
	{
		global::IUnknown* ptr = null;
		int num = global::<Module>.__get_default_appdomain(&ptr);
		if (num >= 0)
		{
			try
			{
				global::System.IntPtr pUnk = new global::System.IntPtr((void*)ptr);
				return (global::System.AppDomain)global::System.Runtime.InteropServices.Marshal.GetObjectForIUnknown(pUnk);
			}
			finally
			{
				global::<Module>.__release_appdomain(ptr);
			}
		}
		global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(num);
		return null;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000CDE0 File Offset: 0x0000C1E0
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.DoCallBackInDefaultDomain(global::method function, void* cookie)
	{
		global::System.Guid riid = global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02);
		global::ICLRRuntimeHost* ptr = (global::ICLRRuntimeHost*)global::System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeInterfaceAsIntPtr(global::<Module>.<CrtImplementationDetails>.FromGUID(ref global::<Module>._GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02), riid).ToPointer();
		try
		{
			global::System.AppDomain appDomain = global::<Module>.<CrtImplementationDetails>.GetDefaultDomain();
			int num = calli(System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr,System.UInt32 modopt(System.Runtime.CompilerServices.IsLong),System.Int32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall) (System.Void*),System.Void*), ptr, appDomain.Id, function, cookie, *(*(int*)ptr + 32));
			if (num < 0)
			{
				global::System.Runtime.InteropServices.Marshal.ThrowExceptionForHR(num);
			}
		}
		finally
		{
			global::ICLRRuntimeHost* ptr2 = ptr;
			object obj = calli(System.UInt32 modopt(System.Runtime.CompilerServices.IsLong) modopt(System.Runtime.CompilerServices.CallConvStdcall)(System.IntPtr), ptr2, *(*(int*)ptr2 + 8));
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0000CE98 File Offset: 0x0000C298
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static int <CrtImplementationDetails>.DefaultDomain.DoNothing(void* cookie)
	{
		global::System.GC.KeepAlive(int.MaxValue);
		return 0;
	}

	// Token: 0x0600001D RID: 29 RVA: 0x0000CEB8 File Offset: 0x0000C2B8
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasPerProcess()
	{
		if (global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)2)
		{
			void** ptr = (void**)(&global::<Module>.?A0xd2508fec.__xc_mp_a);
			if (ref global::<Module>.?A0xd2508fec.__xc_mp_a < ref global::<Module>.?A0xd2508fec.__xc_mp_z)
			{
				while (*(int*)ptr == 0)
				{
					ptr += 4 / sizeof(void*);
					if (ptr >= (void**)(&global::<Module>.?A0xd2508fec.__xc_mp_z))
					{
						goto IL_34;
					}
				}
				global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_34:
			global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)0;
			return 0;
		}
		return (global::<Module>.?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)(-1)) ? 1 : 0;
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0000CF0C File Offset: 0x0000C30C
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal unsafe static bool <CrtImplementationDetails>.DefaultDomain.HasNative()
	{
		if (global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)2)
		{
			void** ptr = (void**)(&global::<Module>.__xi_a);
			if (ref global::<Module>.__xi_a < ref global::<Module>.__xi_z)
			{
				while (*(int*)ptr == 0)
				{
					ptr += 4 / sizeof(void*);
					if (ptr >= (void**)(&global::<Module>.__xi_z))
					{
						goto IL_34;
					}
				}
				global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_34:
			void** ptr2 = (void**)(&global::<Module>.__xc_a);
			if (ref global::<Module>.__xc_a < ref global::<Module>.__xc_z)
			{
				while (*(int*)ptr2 == 0)
				{
					ptr2 += 4 / sizeof(void*);
					if (ptr2 >= (void**)(&global::<Module>.__xc_z))
					{
						goto IL_60;
					}
				}
				global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)(-1);
				return 1;
			}
			IL_60:
			global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A = (global::<CrtImplementationDetails>.TriBool.State)0;
			return 0;
		}
		return (global::<Module>.?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A == (global::<CrtImplementationDetails>.TriBool.State)(-1)) ? 1 : 0;
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000CF8C File Offset: 0x0000C38C
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsInitialization()
	{
		int num;
		if ((global::<Module>.<CrtImplementationDetails>.DefaultDomain.HasPerProcess() != null && !global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA) || (global::<Module>.<CrtImplementationDetails>.DefaultDomain.HasNative() != null && !global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA && global::<Module>.__native_startup_state == (global::__enative_startup_state)0))
		{
			num = 1;
		}
		else
		{
			num = 0;
		}
		return (byte)num;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0000CFC8 File Offset: 0x0000C3C8
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.DefaultDomain.NeedsUninitialization()
	{
		return global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0000CFDC File Offset: 0x0000C3DC
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.DefaultDomain.Initialize()
	{
		global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00001000 File Offset: 0x00000400
	internal static void ??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00001014 File Offset: 0x00000414
	internal static void ??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
	{
		global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00001028 File Offset: 0x00000428
	internal static void ??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000103C File Offset: 0x0000043C
	internal static void ??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00001050 File Offset: 0x00000450
	internal static void ??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00001064 File Offset: 0x00000464
	internal static void ??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00001078 File Offset: 0x00000478
	internal static void ??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
	{
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)0;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000D1BC File Offset: 0x0000C5BC
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeVtables(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during vtable initialization.\n");
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xi_vt_z));
		global::<Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000D1F0 File Offset: 0x0000C5F0
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load while attempting to initialize the default appdomain.\n");
		global::<Module>.<CrtImplementationDetails>.DefaultDomain.Initialize();
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000D210 File Offset: 0x0000C610
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeNative(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during native initialization.\n");
		global::<Module>.__security_init_cookie();
		global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
		if (global::<Module>.<CrtImplementationDetails>.NativeDll.IsSafeForManagedCode() == null)
		{
			global::<Module>._amsg_exit(33);
		}
		if (global::<Module>.__native_startup_state == (global::__enative_startup_state)1)
		{
			global::<Module>._amsg_exit(33);
		}
		else if (global::<Module>.__native_startup_state == (global::__enative_startup_state)0)
		{
			global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
			global::<Module>.__native_startup_state = (global::__enative_startup_state)1;
			if (global::<Module>._initterm_e((global::method*)(&global::<Module>.__xi_a), (global::method*)(&global::<Module>.__xi_z)) != 0)
			{
				global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0));
			}
			global::<Module>._initterm((global::method*)(&global::<Module>.__xc_a), (global::method*)(&global::<Module>.__xc_z));
			global::<Module>.__native_startup_state = (global::__enative_startup_state)2;
			global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
			global::<Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x0000D2AC File Offset: 0x0000C6AC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerProcess(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during process initialization.\n");
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_m();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_mp_z));
		global::<Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
		global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000D2EC File Offset: 0x0000C6EC
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during appdomain initialization.\n");
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)1;
		global::<Module>._initatexit_app_domain();
		global::<Module>._initterm_m((global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_a), (global::method*)(&global::<Module>.?A0xd2508fec.__xc_ma_z));
		global::<Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (global::<CrtImplementationDetails>.Progress.State)2;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000D328 File Offset: 0x0000C728
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load during registration for the unload events.\n");
		global::<Module>.<CrtImplementationDetails>.RegisterModuleUninitializer(new global::System.EventHandler(global::<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload));
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000D354 File Offset: 0x0000C754
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport._Initialize(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = global::System.AppDomain.CurrentDomain.IsDefaultAppDomain();
		if (global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA)
		{
			global::<Module>.?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA = true;
		}
		void* ptr = global::<Module>._getFiberPtrId();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			while (num2 == 0)
			{
				try
				{
				}
				finally
				{
					global::System.IntPtr comparand = (global::System.IntPtr)0;
					global::System.IntPtr value = (global::System.IntPtr)ptr;
					global::System.IntPtr value2 = global::System.Threading.Interlocked.CompareExchange(ref global::<Module>.__native_startup_lock, value, comparand);
					void* ptr2 = (void*)value2;
					if (ptr2 == null)
					{
						num2 = 1;
					}
					else if (ptr2 == ptr)
					{
						num = 1;
						num2 = 1;
					}
				}
				if (num2 == 0)
				{
					global::<Module>.Sleep(1000);
				}
			}
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeVtables(A_0);
			if (global::<Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeNative(A_0);
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerProcess(A_0);
			}
			else if (global::<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsInitialization() != null)
			{
				num3 = 1;
			}
		}
		finally
		{
			if (num == 0)
			{
				global::System.IntPtr value3 = (global::System.IntPtr)0;
				global::System.Threading.Interlocked.Exchange(ref global::<Module>.__native_startup_lock, value3);
			}
		}
		if (num3 != 0)
		{
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeDefaultAppDomain(A_0);
		}
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(A_0);
		global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 1;
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(A_0);
	}

	// Token: 0x06000030 RID: 48 RVA: 0x0000CFF4 File Offset: 0x0000C3F4
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
	{
		global::<Module>._app_exit_callback();
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0000D008 File Offset: 0x0000C408
	[global::System.Security.SecurityCritical]
	internal unsafe static int <CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(void* cookie)
	{
		global::<Module>._exit_callback();
		global::<Module>.?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		if (global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA)
		{
			global::<Module>._cexit();
			global::<Module>.__native_startup_state = (global::__enative_startup_state)0;
			global::<Module>.?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		}
		global::<Module>.?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA = false;
		return 0;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x0000D044 File Offset: 0x0000C444
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain()
	{
		if (global::<Module>.<CrtImplementationDetails>.DefaultDomain.NeedsUninitialization() != null)
		{
			if (global::System.AppDomain.CurrentDomain.IsDefaultAppDomain())
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport._UninitializeDefaultDomain(null);
			}
			else
			{
				global::<Module>.<CrtImplementationDetails>.DoCallBackInDefaultDomain(global::<Module>.__unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z, null);
			}
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x0000D078 File Offset: 0x0000C478
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.PrePrepareMethod]
	internal static void <CrtImplementationDetails>.LanguageSupport.DomainUnload(object source, global::System.EventArgs arguments)
	{
		if (global::<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA != 0 && global::System.Threading.Interlocked.Exchange(ref global::<Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA, 1) == 0)
		{
			byte b = (global::System.Threading.Interlocked.Decrement(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0;
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (b != 0)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0000D478 File Offset: 0x0000C878
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Cleanup(global::<CrtImplementationDetails>.LanguageSupport* A_0, global::System.Exception innerException)
	{
		try
		{
			bool flag = ((global::System.Threading.Interlocked.Decrement(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA) == 0) ? 1 : 0) != 0;
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeDefaultDomain();
			}
		}
		catch (global::System.Exception nestedException)
		{
			global::<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, nestedException);
		}
		catch (object obj)
		{
			global::<Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, null);
		}
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000D4EC File Offset: 0x0000C8EC
	[global::System.Security.SecurityCritical]
	internal unsafe static global::<CrtImplementationDetails>.LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{ctor}(A_0);
		return A_0;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x0000D504 File Offset: 0x0000C904
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.{dtor}(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		global::<Module>.gcroot<System::String\u0020^>.{dtor}(A_0);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0000D518 File Offset: 0x0000C918
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	internal unsafe static void <CrtImplementationDetails>.LanguageSupport.Initialize(global::<CrtImplementationDetails>.LanguageSupport* A_0)
	{
		bool flag = false;
		global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			global::<Module>.gcroot<System::String\u0020^>.=(A_0, "The C++ module failed to load.\n");
			global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
			}
			finally
			{
				global::System.Threading.Interlocked.Increment(ref global::<Module>.?Count@AllDomains@<CrtImplementationDetails>@@2HA);
				flag = true;
			}
			global::<Module>.<CrtImplementationDetails>.LanguageSupport._Initialize(A_0);
		}
		catch (global::System.Exception innerException)
		{
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, innerException);
			}
			global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), innerException);
		}
		catch (object obj)
		{
			if (flag)
			{
				global::<Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(A_0, null);
			}
			global::<Module>.<CrtImplementationDetails>.ThrowModuleLoadException(global::<Module>.gcroot<System::String\u0020^>..P$AAVString@System@@(A_0), null);
		}
	}

	// Token: 0x06000038 RID: 56 RVA: 0x0000D5D4 File Offset: 0x0000C9D4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	static unsafe <Module>()
	{
		global::<CrtImplementationDetails>.LanguageSupport languageSupport;
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.{ctor}(ref languageSupport);
		try
		{
			global::<Module>.<CrtImplementationDetails>.LanguageSupport.Initialize(ref languageSupport);
		}
		catch
		{
			global::<Module>.___CxxCallUnwindDtor(ldftn(<CrtImplementationDetails>.LanguageSupport.{dtor}), (void*)(&languageSupport));
			throw;
		}
		global::<Module>.<CrtImplementationDetails>.LanguageSupport.{dtor}(ref languageSupport);
	}

	// Token: 0x06000039 RID: 57 RVA: 0x0000D0B4 File Offset: 0x0000C4B4
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* {ctor}(global::gcroot<System::String\u0020^>* A_0)
	{
		*A_0 = ((global::System.IntPtr)global::System.Runtime.InteropServices.GCHandle.Alloc(null)).ToPointer();
		return A_0;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x0000D0D8 File Offset: 0x0000C4D8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void {dtor}(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Free();
		*A_0 = 0;
	}

	// Token: 0x0600003B RID: 59 RVA: 0x0000D100 File Offset: 0x0000C500
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static global::gcroot<System::String\u0020^>* =(global::gcroot<System::String\u0020^>* A_0, string t)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		((global::System.Runtime.InteropServices.GCHandle)value).Target = t;
		return A_0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x0000D128 File Offset: 0x0000C528
	[global::System.Security.SecuritySafeCritical]
	internal unsafe static string P$AAVString@System@@(global::gcroot<System::String\u0020^>* A_0)
	{
		global::System.IntPtr value = new global::System.IntPtr(*A_0);
		return ((global::System.Runtime.InteropServices.GCHandle)value).Target;
	}

	// Token: 0x0600003D RID: 61 RVA: 0x0000D734 File Offset: 0x0000CB34
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static global::System.ValueType <CrtImplementationDetails>.AtExitLock._handle()
	{
		if (global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA != null)
		{
			global::System.IntPtr value = new global::System.IntPtr(global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA);
			return global::System.Runtime.InteropServices.GCHandle.FromIntPtr(value);
		}
		return null;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x0000DC38 File Offset: 0x0000D038
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
	{
		global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
	}

	// Token: 0x0600003F RID: 63 RVA: 0x0000D764 File Offset: 0x0000CB64
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Set(object value)
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType == null)
		{
			valueType = global::System.Runtime.InteropServices.GCHandle.Alloc(value);
			global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = global::System.Runtime.InteropServices.GCHandle.ToIntPtr((global::System.Runtime.InteropServices.GCHandle)valueType).ToPointer();
		}
		else
		{
			((global::System.Runtime.InteropServices.GCHandle)valueType).Target = value;
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0000D7B4 File Offset: 0x0000CBB4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			return ((global::System.Runtime.InteropServices.GCHandle)valueType).Target;
		}
		return null;
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0000D7D8 File Offset: 0x0000CBD8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
	{
		global::System.ValueType valueType = global::<Module>.<CrtImplementationDetails>.AtExitLock._handle();
		if (valueType != null)
		{
			((global::System.Runtime.InteropServices.GCHandle)valueType).Free();
			global::<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = null;
		}
	}

	// Token: 0x06000042 RID: 66 RVA: 0x0000D800 File Offset: 0x0000CC00
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecuritySafeCritical]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
	{
		return (global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null) ? 1 : 0;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0000DC54 File Offset: 0x0000D054
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.AddRef()
	{
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() == null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Construct(new object());
			global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
		}
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA++;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x0000D81C File Offset: 0x0000CC1C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
	{
		global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA--;
		if (global::<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA == 0)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0000D844 File Offset: 0x0000CC44
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal static void <CrtImplementationDetails>.AtExitLock.Enter()
	{
		global::System.Threading.Monitor.Enter(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0000D85C File Offset: 0x0000CC5C
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void <CrtImplementationDetails>.AtExitLock.Exit()
	{
		global::System.Threading.Monitor.Exit(global::<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0000D874 File Offset: 0x0000CC74
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __global_lock()
	{
		bool result = false;
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() != null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock.Enter();
			result = true;
		}
		return result;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000D894 File Offset: 0x0000CC94
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __global_unlock()
	{
		bool result = false;
		if (global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized() != null)
		{
			global::<Module>.<CrtImplementationDetails>.AtExitLock.Exit();
			result = true;
		}
		return result;
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000DC84 File Offset: 0x0000D084
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.U1)]
	internal static bool __alloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
		return global::<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0000D8B4 File Offset: 0x0000CCB4
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static void __dealloc_global_lock()
	{
		global::<Module>.<CrtImplementationDetails>.AtExitLock.RemoveRef();
	}

	// Token: 0x0600004B RID: 75 RVA: 0x0000D8C8 File Offset: 0x0000CCC8
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_helper(global::method func, uint* __pexit_list_size, global::method** __ponexitend_e, global::method** __ponexitbegin_e)
	{
		global::method system.Void_u0020() = 0;
		if (func == null)
		{
			return -1;
		}
		if (global::<Module>.?A0xe62d03cb.__global_lock() == 1)
		{
			try
			{
				global::method* ptr = (global::method*)global::<Module>.DecodePointer(*(int*)__ponexitbegin_e);
				global::method* ptr2 = (global::method*)global::<Module>.DecodePointer(*(int*)__ponexitend_e);
				int num = (int)(ptr2 - ptr);
				if (*__pexit_list_size - 1U < (uint)num >> 2)
				{
					try
					{
						uint num2 = *__pexit_list_size * 4U;
						uint num3;
						if (num2 < 2048U)
						{
							num3 = num2;
						}
						else
						{
							num3 = 2048U;
						}
						global::System.IntPtr cb = new global::System.IntPtr((int)(num2 + num3));
						global::System.IntPtr pv = new global::System.IntPtr((void*)ptr);
						global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.ReAllocHGlobal(pv, cb);
						global::System.IntPtr intPtr2 = intPtr;
						ptr2 = (global::method*)((byte*)intPtr2.ToPointer() + num);
						ptr = (global::method*)intPtr2.ToPointer();
						uint num4 = *__pexit_list_size;
						uint num5;
						if (512U < num4)
						{
							num5 = 512U;
						}
						else
						{
							num5 = num4;
						}
						*__pexit_list_size = num4 + num5;
					}
					catch (global::System.OutOfMemoryException)
					{
						global::System.IntPtr cb2 = new global::System.IntPtr((int)(*__pexit_list_size * 4U + 8U));
						global::System.IntPtr pv2 = new global::System.IntPtr((void*)ptr);
						global::System.IntPtr intPtr3 = global::System.Runtime.InteropServices.Marshal.ReAllocHGlobal(pv2, cb2);
						global::System.IntPtr intPtr4 = intPtr3;
						ptr2 = (intPtr4.ToPointer() - ptr) / (global::System.IntPtr)sizeof(global::method) + ptr2;
						ptr = (global::method*)intPtr4.ToPointer();
						*__pexit_list_size += 4U;
					}
				}
				*(int*)ptr2 = func;
				ptr2 += 4 / sizeof(global::method);
				system.Void_u0020() = func;
				*(int*)__ponexitbegin_e = global::<Module>.EncodePointer((void*)ptr);
				*(int*)__ponexitend_e = global::<Module>.EncodePointer((void*)ptr2);
			}
			catch (global::System.OutOfMemoryException)
			{
			}
			finally
			{
				global::<Module>.?A0xe62d03cb.__global_unlock();
			}
			if (system.Void_u0020() != null)
			{
				return 0;
			}
		}
		return -1;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000DA4C File Offset: 0x0000CE4C
	[global::System.Security.SecurityCritical]
	internal unsafe static void _exit_callback()
	{
		if (global::<Module>.?A0xe62d03cb.__exit_list_size != 0U)
		{
			global::method* ptr = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitbegin_m);
			global::method* ptr2 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitend_m);
			if (ptr != -1 && ptr != null && ptr2 != null)
			{
				global::method* ptr3 = ptr;
				global::method* ptr4 = ptr2;
				for (;;)
				{
					ptr2 -= 4 / sizeof(global::method);
					if (ptr2 < ptr)
					{
						break;
					}
					if (*(int*)ptr2 != global::<Module>.EncodePointer(null))
					{
						void* ptr5 = global::<Module>.DecodePointer(*(int*)ptr2);
						*(int*)ptr2 = global::<Module>.EncodePointer(null);
						calli(System.Void(), ptr5);
						global::method* ptr6 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitbegin_m);
						global::method* ptr7 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.?A0xe62d03cb.__onexitend_m);
						if (ptr3 != ptr6 || ptr4 != ptr7)
						{
							ptr3 = ptr6;
							ptr = ptr6;
							ptr4 = ptr7;
							ptr2 = ptr7;
						}
					}
				}
				global::System.IntPtr hglobal = new global::System.IntPtr((void*)ptr);
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
			}
			global::<Module>.?A0xe62d03cb.__dealloc_global_lock();
		}
	}

	// Token: 0x0600004D RID: 77 RVA: 0x0000DC9C File Offset: 0x0000D09C
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _initatexit_m()
	{
		int result = 0;
		if (global::<Module>.?A0xe62d03cb.__alloc_global_lock() == 1)
		{
			global::<Module>.?A0xe62d03cb.__onexitbegin_m = (global::method*)global::<Module>.EncodePointer(global::System.Runtime.InteropServices.Marshal.AllocHGlobal(128).ToPointer());
			global::<Module>.?A0xe62d03cb.__onexitend_m = global::<Module>.?A0xe62d03cb.__onexitbegin_m;
			global::<Module>.?A0xe62d03cb.__exit_list_size = 32U;
			result = 1;
		}
		return result;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x0000DCE8 File Offset: 0x0000D0E8
	internal static global::method _onexit_m(global::method _Function)
	{
		return (global::<Module>._atexit_m(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000DAF8 File Offset: 0x0000CEF8
	[global::System.Security.SecurityCritical]
	internal unsafe static int _atexit_m(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.?A0xe62d03cb.__exit_list_size, &global::<Module>.?A0xe62d03cb.__onexitend_m, &global::<Module>.?A0xe62d03cb.__onexitbegin_m);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000DD08 File Offset: 0x0000D108
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _initatexit_app_domain()
	{
		if (global::<Module>.?A0xe62d03cb.__alloc_global_lock() == 1)
		{
			global::<Module>.__onexitbegin_app_domain = (global::method*)global::<Module>.EncodePointer(global::System.Runtime.InteropServices.Marshal.AllocHGlobal(128).ToPointer());
			global::<Module>.__onexitend_app_domain = global::<Module>.__onexitbegin_app_domain;
			global::<Module>.__exit_list_size_app_domain = 32U;
		}
		return 1;
	}

	// Token: 0x06000051 RID: 81 RVA: 0x0000DB28 File Offset: 0x0000CF28
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	internal unsafe static void _app_exit_callback()
	{
		if (global::<Module>.__exit_list_size_app_domain != 0U)
		{
			global::method* ptr = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitbegin_app_domain);
			global::method* ptr2 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitend_app_domain);
			try
			{
				if (ptr != -1 && ptr != null && ptr2 != null)
				{
					global::method* ptr3 = ptr;
					global::method* ptr4 = ptr2;
					for (;;)
					{
						do
						{
							ptr2 -= 4 / sizeof(global::method);
						}
						while (ptr2 >= ptr && *(int*)ptr2 == global::<Module>.EncodePointer(null));
						if (ptr2 < ptr)
						{
							break;
						}
						global::method system.Void_u0020() = global::<Module>.DecodePointer(*(int*)ptr2);
						*(int*)ptr2 = global::<Module>.EncodePointer(null);
						calli(System.Void(), system.Void_u0020());
						global::method* ptr5 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitbegin_app_domain);
						global::method* ptr6 = (global::method*)global::<Module>.DecodePointer((void*)global::<Module>.__onexitend_app_domain);
						if (ptr3 != ptr5 || ptr4 != ptr6)
						{
							ptr3 = ptr5;
							ptr = ptr5;
							ptr4 = ptr6;
							ptr2 = ptr6;
						}
					}
				}
			}
			finally
			{
				global::System.IntPtr hglobal = new global::System.IntPtr((void*)ptr);
				global::System.Runtime.InteropServices.Marshal.FreeHGlobal(hglobal);
				global::<Module>.?A0xe62d03cb.__dealloc_global_lock();
			}
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x0000DD54 File Offset: 0x0000D154
	[global::System.Security.SecurityCritical]
	internal static global::method _onexit_m_appdomain(global::method _Function)
	{
		return (global::<Module>._atexit_m_appdomain(_Function) == -1) ? 0 : _Function;
	}

	// Token: 0x06000053 RID: 83 RVA: 0x0000DC08 File Offset: 0x0000D008
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal unsafe static int _atexit_m_appdomain(global::method func)
	{
		return global::<Module>._atexit_helper(global::<Module>.EncodePointer(func), &global::<Module>.__exit_list_size_app_domain, &global::<Module>.__onexitend_app_domain, &global::<Module>.__onexitbegin_app_domain);
	}

	// Token: 0x06000054 RID: 84
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* DecodePointer(void* Ptr);

	// Token: 0x06000055 RID: 85
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.InteropServices.DllImport("KERNEL32.dll")]
	public unsafe static extern void* EncodePointer(void* Ptr);

	// Token: 0x06000056 RID: 86 RVA: 0x0000DDC8 File Offset: 0x0000D1C8
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static int _initterm_e(global::method* pfbegin, global::method* pfend)
	{
		int num = 0;
		if (pfbegin < pfend)
		{
			while (num == 0)
			{
				uint num2 = (uint)(*(int*)pfbegin);
				if (num2 != 0U)
				{
					num = calli(System.Int32 modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num2);
				}
				pfbegin += 4 / sizeof(global::method);
				if (pfbegin >= pfend)
				{
					break;
				}
			}
		}
		return num;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x0000DDFC File Offset: 0x0000D1FC
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	internal unsafe static void _initterm(global::method* pfbegin, global::method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				uint num = (uint)(*(int*)pfbegin);
				if (num != 0U)
				{
					calli(System.Void modopt(System.Runtime.CompilerServices.CallConvCdecl)(), num);
				}
				pfbegin += 4 / sizeof(global::method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0000DE28 File Offset: 0x0000D228
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::System.ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
	{
		return typeof(global::<CrtImplementationDetails>.ThisModule).Module.ModuleHandle;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x0000DE78 File Offset: 0x0000D278
	[global::System.Diagnostics.DebuggerStepThrough]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void _initterm_m(global::method* pfbegin, global::method* pfend)
	{
		if (pfbegin < pfend)
		{
			do
			{
				uint num = (uint)(*(int*)pfbegin);
				if (num != 0U)
				{
					object obj = calli(System.Void modopt(System.Runtime.CompilerServices.IsConst)*(), global::<Module>.<CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(num));
				}
				pfbegin += 4 / sizeof(global::method);
			}
			while (pfbegin < pfend);
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x0000DE4C File Offset: 0x0000D24C
	[global::System.Security.SecurityCritical]
	[global::System.Diagnostics.DebuggerStepThrough]
	internal static global::method <CrtImplementationDetails>.ThisModule.ResolveMethod<void\u0020const\u0020*\u0020__clrcall(void)>(global::method methodToken)
	{
		return global::<Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle(methodToken).GetFunctionPointer().ToPointer();
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0000DEB8 File Offset: 0x0000D2B8
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindDtor(global::method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x0000DF04 File Offset: 0x0000D304
	[global::System.Security.SecurityCritical]
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindDelDtor(global::method pDtor, void* pThis)
	{
		try
		{
			calli(System.Void(System.Void*), pThis, pDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005D RID: 93 RVA: 0x0000DF50 File Offset: 0x0000D350
	[global::System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
	[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
	[global::System.Security.SecurityCritical]
	[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
	internal unsafe static void ___CxxCallUnwindVecDtor(global::method pVecDtor, void* ptr, uint size, int count, global::method pDtor)
	{
		try
		{
			calli(System.Void(System.Void*,System.UInt32,System.Int32,System.Void (System.Void*)), ptr, size, count, pDtor, pVecDtor);
		}
		catch when (endfilter(global::<Module>.__FrameUnwindFilter(global::System.Runtime.InteropServices.Marshal.GetExceptionPointers()) != null))
		{
		}
	}

	// Token: 0x0600005E RID: 94 RVA: 0x0000A140 File Offset: 0x00009540
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int LZMA_Uncompress(byte**, uint*, byte*, uint);

	// Token: 0x0600005F RID: 95 RVA: 0x0000A0E0 File Offset: 0x000094E0
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern int LZMA_Compress(byte*, uint*, byte*, uint, int);

	// Token: 0x06000060 RID: 96 RVA: 0x0000CE8D File Offset: 0x0000C28D
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal unsafe static extern void* _getFiberPtrId();

	// Token: 0x06000061 RID: 97 RVA: 0x0000C4E6 File Offset: 0x0000B8E6
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _amsg_exit(int);

	// Token: 0x06000062 RID: 98 RVA: 0x0000C72B File Offset: 0x0000BB2B
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged | global::System.Runtime.CompilerServices.MethodImplOptions.PreserveSig)]
	internal static extern void __security_init_cookie();

	// Token: 0x06000063 RID: 99 RVA: 0x0000E034 File Offset: 0x0000D434
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.StdCall, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void Sleep(uint);

	// Token: 0x06000064 RID: 100 RVA: 0x0000E028 File Offset: 0x0000D428
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal static extern void _cexit();

	// Token: 0x06000065 RID: 101 RVA: 0x0000E02E File Offset: 0x0000D42E
	[global::System.Security.SuppressUnmanagedCodeSecurity]
	[global::System.Runtime.InteropServices.DllImport("", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, SetLastError = true)]
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Unmanaged)]
	internal unsafe static extern int __FrameUnwindFilter(global::_EXCEPTION_POINTERS*);

	// Token: 0x04000001 RID: 1 RVA: 0x000191E0 File Offset: 0x00016DE0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0EAAA@E WorkMem;

	// Token: 0x04000002 RID: 2 RVA: 0x0000F158 File Offset: 0x0000D758
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY07$$CBD ??_C@_07JDFGAHFC@LZRW3?9A?$AA@;

	// Token: 0x04000003 RID: 3 RVA: 0x0000F160 File Offset: 0x0000D760
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY03$$CBD ??_C@_03HLLJOCDO@1?40?$AA@;

	// Token: 0x04000004 RID: 4 RVA: 0x0000F164 File Offset: 0x0000D764
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0M@$$CBD ??_C@_0M@FFIOMECA@15?9Jul?91990?$AA@;

	// Token: 0x04000005 RID: 5 RVA: 0x0000F170 File Offset: 0x0000D770
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0O@$$CBD ??_C@_0O@JGPPPNCO@Public?5Domain?$AA@;

	// Token: 0x04000006 RID: 6 RVA: 0x0000F180 File Offset: 0x0000D780
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BB@$$CBD ??_C@_0BB@NGDGKPGD@Ross?5N?4?5Williams?$AA@;

	// Token: 0x04000007 RID: 7 RVA: 0x0000F194 File Offset: 0x0000D794
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BF@$$CBD ??_C@_0BF@IMIDJLMK@Renaissance?5Software?$AA@;

	// Token: 0x04000008 RID: 8 RVA: 0x0001904C File Offset: 0x00016C4C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0BD@E START_STRING_18;

	// Token: 0x04000009 RID: 9 RVA: 0x00019028 File Offset: 0x00016C28
	internal static global::compress_identity identity;

	// Token: 0x0400000A RID: 10 RVA: 0x0001D1E4 File Offset: 0x0001ADE4
	internal static int __@@_PchSym_@00@UBDIUFAEUhlfixvhUxlnnlmPxkhPkozguinUrnkovnvmgzgrlmUinCOAUxlnnlmPxlnnfmrxzgrlmUxlwvUxlnnlmxlnnfmrxzgrlmUxlnkivhhrlmUivovzhvUhgwzucOlyq@E1DFDF8F10D698B;

	// Token: 0x0400000B RID: 11 RVA: 0x0000F1D0 File Offset: 0x0000D7D0
	internal static global::__s_GUID _GUID_90f1a06e_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400000C RID: 12 RVA: 0x0000F200 File Offset: 0x0000D800
	internal static global::__s_GUID _GUID_cb2f6722_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400000D RID: 13 RVA: 0x0000F10C File Offset: 0x0000D70C
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_z;

	// Token: 0x0400000E RID: 14
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x0400000F RID: 15 RVA: 0x0000F0EC File Offset: 0x0000D6EC
	internal static global::method ?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000010 RID: 16 RVA: 0x0000F110 File Offset: 0x0000D710
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_a;

	// Token: 0x04000011 RID: 17
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000012 RID: 18 RVA: 0x0000F100 File Offset: 0x0000D700
	internal static global::method ?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000013 RID: 19
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;

	// Token: 0x04000014 RID: 20 RVA: 0x0000F0F0 File Offset: 0x0000D6F0
	internal static global::method ?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000015 RID: 21 RVA: 0x0000F0E4 File Offset: 0x0000D6E4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_a;

	// Token: 0x04000016 RID: 22
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000017 RID: 23 RVA: 0x0000F0F8 File Offset: 0x0000D6F8
	internal static global::method ?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000018 RID: 24
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;

	// Token: 0x04000019 RID: 25 RVA: 0x0000F0E8 File Offset: 0x0000D6E8
	internal static global::method ?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400001A RID: 26 RVA: 0x0000F104 File Offset: 0x0000D704
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_ma_z;

	// Token: 0x0400001B RID: 27
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x0400001C RID: 28 RVA: 0x0000F0F4 File Offset: 0x0000D6F4
	internal static global::method ?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x0400001D RID: 29 RVA: 0x0000F114 File Offset: 0x0000D714
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xi_vt_z;

	// Token: 0x0400001E RID: 30 RVA: 0x0000F1F0 File Offset: 0x0000D7F0
	internal static global::__s_GUID _GUID_cb2f6723_ab3a_11d2_9c40_00c04fa30a3e;

	// Token: 0x0400001F RID: 31
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static global::<CrtImplementationDetails>.Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;

	// Token: 0x04000020 RID: 32 RVA: 0x0000F0FC File Offset: 0x0000D6FC
	internal static global::method ?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;

	// Token: 0x04000021 RID: 33 RVA: 0x0001D51F File Offset: 0x0001B11F
	internal static bool ?InitializedPerProcess@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000022 RID: 34 RVA: 0x0001D51C File Offset: 0x0001B11C
	internal static bool ?Entered@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000023 RID: 35 RVA: 0x0001D51D File Offset: 0x0001B11D
	internal static bool ?InitializedNative@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x04000024 RID: 36 RVA: 0x0001D518 File Offset: 0x0001B118
	internal static int ?Count@AllDomains@<CrtImplementationDetails>@@2HA;

	// Token: 0x04000025 RID: 37 RVA: 0x0000F1BC File Offset: 0x0000D7BC
	internal static uint ?ProcessAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000026 RID: 38 RVA: 0x0000F1C0 File Offset: 0x0000D7C0
	internal static uint ?ThreadAttach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000027 RID: 39 RVA: 0x00019088 File Offset: 0x00016C88
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasNative@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x04000028 RID: 40 RVA: 0x0000F1B8 File Offset: 0x0000D7B8
	internal static uint ?ProcessDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x04000029 RID: 41 RVA: 0x0000F1C4 File Offset: 0x0000D7C4
	internal static uint ?ThreadDetach@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x0400002A RID: 42 RVA: 0x0000F1C8 File Offset: 0x0000D7C8
	internal static uint ?ProcessVerifier@NativeDll@<CrtImplementationDetails>@@0IB;

	// Token: 0x0400002B RID: 43 RVA: 0x00019084 File Offset: 0x00016C84
	internal static global::<CrtImplementationDetails>.TriBool.State ?hasPerProcess@DefaultDomain@<CrtImplementationDetails>@@0W4State@TriBool@2@A;

	// Token: 0x0400002C RID: 44 RVA: 0x0001D51E File Offset: 0x0001B11E
	internal static bool ?InitializedNativeFromCCTOR@DefaultDomain@<CrtImplementationDetails>@@2_NA;

	// Token: 0x0400002D RID: 45 RVA: 0x0000F108 File Offset: 0x0000D708
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY00Q6MPBXXZ __xc_mp_a;

	// Token: 0x0400002E RID: 46 RVA: 0x0000F1E0 File Offset: 0x0000D7E0
	internal static global::__s_GUID _GUID_90f1a06c_7712_4762_86b5_7a5eba6bdb02;

	// Token: 0x0400002F RID: 47 RVA: 0x0000F210 File Offset: 0x0000D810
	public unsafe static int** __unep@?DoNothing@DefaultDomain@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x04000030 RID: 48 RVA: 0x0000F214 File Offset: 0x0000D814
	public unsafe static int** __unep@?_UninitializeDefaultDomain@LanguageSupport@<CrtImplementationDetails>@@$$FCGJPAX@Z;

	// Token: 0x04000031 RID: 49
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static uint __exit_list_size_app_domain;

	// Token: 0x04000032 RID: 50
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitbegin_app_domain;

	// Token: 0x04000033 RID: 51 RVA: 0x0001D62C File Offset: 0x0001B22C
	internal static uint __exit_list_size;

	// Token: 0x04000034 RID: 52
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static global::method* __onexitend_app_domain;

	// Token: 0x04000035 RID: 53 RVA: 0x0001D624 File Offset: 0x0001B224
	internal unsafe static global::method* __onexitbegin_m;

	// Token: 0x04000036 RID: 54 RVA: 0x0001D628 File Offset: 0x0001B228
	internal unsafe static global::method* __onexitend_m;

	// Token: 0x04000037 RID: 55
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal unsafe static void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;

	// Token: 0x04000038 RID: 56
	[global::System.Runtime.CompilerServices.FixedAddressValueType]
	internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;

	// Token: 0x04000039 RID: 57 RVA: 0x0000F0D0 File Offset: 0x0000D6D0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_z;

	// Token: 0x0400003A RID: 58 RVA: 0x0000F0CC File Offset: 0x0000D6CC
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AXXZ __xc_a;

	// Token: 0x0400003B RID: 59 RVA: 0x0000F0D4 File Offset: 0x0000D6D4
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_a;

	// Token: 0x0400003C RID: 60 RVA: 0x0001D660 File Offset: 0x0001B260
	internal static volatile global::__enative_startup_state __native_startup_state;

	// Token: 0x0400003D RID: 61 RVA: 0x0000F0E0 File Offset: 0x0000D6E0
	internal static global::<CppImplementationDetails>.$ArrayType$$$BY0A@P6AHXZ __xi_z;

	// Token: 0x0400003E RID: 62 RVA: 0x0001D65C File Offset: 0x0001B25C
	internal unsafe static volatile void* __native_startup_lock;

	// Token: 0x0400003F RID: 63 RVA: 0x00019080 File Offset: 0x00016C80
	internal static volatile uint __native_dllmain_reason;
}
