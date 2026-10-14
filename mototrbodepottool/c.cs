using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace mototrbodepottool
{
	// Token: 0x02000019 RID: 25
	internal class c
	{
		// Token: 0x060000CC RID: 204 RVA: 0x000186E0 File Offset: 0x000176E0
		public void a(global::System.Windows.Forms.ListView A_0, global::System.Windows.Forms.ListView A_1, string A_2)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::mototrbodepottool.c.a a = new global::mototrbodepottool.c.a();
					A_2 = A_2.Trim().ToLower();
					string[] array = A_2.Split(new char[]
					{
						' '
					});
					a.a = new string[]
					{
						"item",
						"package_type",
						"region",
						"tanapa_number",
						"model_number",
						"firmware_version",
						"codeplug_version"
					};
					bool flag = false;
					int num = -1;
					string text = "";
					string[] array2 = array;
					int num2 = 0;
					int num3 = 93;
					for (;;)
					{
						int num5;
						int num6;
						string text2;
						string[] array3;
						int num7;
						string[] array4;
						int num9;
						int num10;
						global::mototrbodepottool.c.b b2;
						int num11;
						string text3;
						int num12;
						string text4;
						int num14;
						global::System.Func<global::System.Windows.Forms.ListViewItem, bool> func2;
						int num15;
						int num16;
						string[] array9;
						global::System.Collections.IEnumerator enumerator6;
						switch (num3)
						{
						case 0:
							goto IL_564;
						case 1:
						{
							int num4;
							if (num4 >= num5)
							{
								num3 = 86;
								continue;
							}
							num6 = 0;
							num3 = 37;
							continue;
						}
						case 2:
						{
							bool flag2 = false;
							num3 = 48;
							continue;
						}
						case 3:
							num3 = 29;
							continue;
						case 4:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> enumerable;
							global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator = enumerable.GetEnumerator();
							num3 = 88;
							continue;
						}
						case 5:
							if (text2.Contains(':'))
							{
								num3 = 64;
								continue;
							}
							array3[num7] = "";
							array4[num7] = text2.Trim();
							num3 = 94;
							continue;
						case 6:
							goto IL_EA0;
						case 7:
						{
							int num4;
							num4++;
							num3 = 49;
							continue;
						}
						case 8:
						{
							char[,] array5;
							int num8;
							array5[num8, num9] = 'n';
							num3 = 91;
							continue;
						}
						case 9:
							goto IL_1213;
						case 10:
							num3 = 90;
							continue;
						case 11:
							if (a.a[num10].Equals(b2.b))
							{
								num3 = 67;
								continue;
							}
							goto IL_E24;
						case 12:
							text = text.Trim();
							num3 = 85;
							continue;
						case 13:
							goto IL_BFC;
						case 14:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> source = A_1.Items.Cast<global::System.Windows.Forms.ListViewItem>();
							global::System.Func<global::System.Windows.Forms.ListViewItem, bool> func;
							if (func == null)
							{
								func = new global::System.Func<global::System.Windows.Forms.ListViewItem, bool>(c.c);
							}
							global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> enumerable2 = source.Where(func);
							global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator2 = enumerable2.GetEnumerator();
							num3 = 73;
							continue;
						}
						case 15:
						{
							string[] array6;
							if (num11 >= array6.Length)
							{
								num3 = 30;
								continue;
							}
							global::System.Func<global::System.Windows.Forms.ListViewItem, bool> func = null;
							string b = array6[num11];
							num3 = 75;
							continue;
						}
						case 16:
							goto IL_8C1;
						case 17:
							goto IL_D2A;
						case 18:
							if (text3.Length > 0)
							{
								num3 = 53;
								continue;
							}
							goto IL_DE3;
						case 19:
							num6 = a.a.Length;
							num3 = 13;
							continue;
						case 20:
							if (a.a.Contains(b2.b))
							{
								num3 = 3;
								continue;
							}
							goto IL_DE3;
						case 21:
						{
							array = text.Split(new char[]
							{
								' '
							});
							bool flag2 = true;
							string[] array7 = array;
							num12 = 0;
							num3 = 61;
							continue;
						}
						case 22:
							if (num6 >= a.a.Length)
							{
								num3 = 7;
								continue;
							}
							num3 = 35;
							continue;
						case 23:
							goto IL_8DB;
						case 24:
							num3 = 54;
							continue;
						case 25:
						{
							int num4;
							A_0.Items.Add((global::System.Windows.Forms.ListViewItem)A_1.Items[num4].Clone());
							flag = true;
							num3 = 92;
							continue;
						}
						case 26:
							if (num2 >= array2.Length)
							{
								num3 = 21;
								continue;
							}
							text4 = array2[num2];
							num3 = 41;
							continue;
						case 27:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_8A0;
							default:
								if (false)
								{
								}
								goto IL_DE3;
							}
							break;
						case 28:
						{
							string text5;
							if (text5.Trim() != "")
							{
								num3 = 2;
								continue;
							}
							goto IL_BE5;
						}
						case 29:
							if (b2.c.Length > 0)
							{
								num3 = 56;
								continue;
							}
							goto IL_DE3;
						case 30:
							return;
						case 31:
							if (text4[text4.Length - 1] != ':')
							{
								num3 = 63;
								continue;
							}
							goto IL_C13;
						case 32:
							goto IL_DFA;
						case 33:
						{
							int num13 = 0;
							num14 = 0;
							num3 = 83;
							continue;
						}
						case 34:
							goto IL_564;
						case 35:
						{
							int num4;
							char[,] array5;
							if (array5[num6, num4] != '\0')
							{
								num3 = 10;
								continue;
							}
							goto IL_BFC;
						}
						case 36:
						{
							string[] array7;
							if (num12 >= array7.Length)
							{
								num3 = 68;
								continue;
							}
							string text5 = array7[num12];
							num3 = 28;
							continue;
						}
						case 37:
							goto IL_869;
						case 38:
							if (num5 > 0)
							{
								num3 = 79;
								continue;
							}
							goto IL_E89;
						case 39:
							if (num9 >= num5)
							{
								num3 = 27;
								continue;
							}
							num3 = 42;
							continue;
						case 40:
							goto IL_E24;
						case 41:
							if (text4.Length > 0)
							{
								num3 = 24;
								continue;
							}
							goto IL_C13;
						case 42:
						{
							char[,] array5;
							int num8;
							if (array5[num8, num9] == '\0')
							{
								num3 = 8;
								continue;
							}
							goto IL_246;
						}
						case 43:
							num3 = 77;
							continue;
						case 44:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> source2 = A_1.Items.Cast<global::System.Windows.Forms.ListViewItem>();
							if (func2 == null)
							{
								func2 = new global::System.Func<global::System.Windows.Forms.ListViewItem, bool>(b2.d);
							}
							global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> enumerable = source2.Where(func2);
							int num8 = -1;
							num10 = 0;
							num3 = 57;
							continue;
						}
						case 45:
						{
							string[] array8;
							if (num15 >= array8.Length)
							{
								num3 = 33;
								continue;
							}
							text3 = array8[num15];
							num3 = 18;
							continue;
						}
						case 46:
							num3 = 14;
							continue;
						case 47:
							goto IL_1213;
						case 48:
							goto IL_BE5;
						case 49:
							goto IL_EA0;
						case 50:
							goto IL_869;
						case 51:
							goto IL_6A4;
						case 52:
							if (num10 >= a.a.Length)
							{
								num3 = 4;
								continue;
							}
							num3 = 11;
							continue;
						case 53:
							goto IL_A4D;
						case 54:
							if (text4[0] == ':')
							{
								num3 = 12;
								continue;
							}
							goto IL_F59;
						case 55:
							goto IL_D2A;
						case 56:
							num3 = 44;
							continue;
						case 57:
							goto IL_DFA;
						case 58:
							goto IL_ED8;
						case 59:
						{
							int num4 = 0;
							num3 = 6;
							continue;
						}
						case 60:
						{
							int num13 = num14;
							num3 = 81;
							continue;
						}
						case 61:
							goto IL_6A4;
						case 62:
							if (num14 >= a.a.Length)
							{
								num3 = 59;
								continue;
							}
							if (true)
							{
							}
							num3 = 38;
							continue;
						case 63:
							text += ' ';
							num3 = 65;
							continue;
						case 64:
							goto IL_845;
						case 65:
							goto IL_C13;
						case 66:
							num = num7;
							num3 = 71;
							continue;
						case 67:
						{
							int num8 = num10;
							num3 = 40;
							continue;
						}
						case 68:
							num3 = 84;
							continue;
						case 69:
							A_0.Items.Clear();
							num3 = 80;
							continue;
						case 70:
						{
							int num13;
							if (num6 == num13)
							{
								num3 = 25;
								continue;
							}
							goto IL_BFC;
						}
						case 71:
							goto IL_8C1;
						case 72:
							goto IL_2BA;
						case 73:
						{
							try
							{
								num3 = 7;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										if (c.b.Equals(array4[num]))
										{
											num3 = 6;
											continue;
										}
										break;
									case 1:
										if (!flag)
										{
											num3 = 9;
											continue;
										}
										break;
									case 3:
										num3 = 5;
										continue;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num3 = 3;
											continue;
										}
										global::System.Windows.Forms.ListViewItem listViewItem = enumerator2.Current;
										bool flag3 = false;
										global::System.Collections.IEnumerator enumerator3 = A_0.Items.GetEnumerator();
										num3 = 10;
										continue;
									}
									case 5:
										goto IL_51F;
									case 6:
									{
										global::System.Windows.Forms.ListViewItem listViewItem;
										A_0.Items.Add((global::System.Windows.Forms.ListViewItem)listViewItem.Clone());
										num3 = 2;
										continue;
									}
									case 8:
										num3 = 1;
										continue;
									case 9:
										goto IL_4A1;
									case 10:
										try
										{
											num3 = 5;
											for (;;)
											{
												switch (num3)
												{
												case 0:
													num3 = 1;
													continue;
												case 1:
													goto IL_453;
												case 3:
												{
													global::System.Collections.IEnumerator enumerator3;
													if (!enumerator3.MoveNext())
													{
														num3 = 0;
														continue;
													}
													global::System.Windows.Forms.ListViewItem listViewItem2 = (global::System.Windows.Forms.ListViewItem)enumerator3.Current;
													num3 = 4;
													continue;
												}
												case 4:
												{
													global::System.Windows.Forms.ListViewItem listViewItem;
													global::System.Windows.Forms.ListViewItem listViewItem2;
													if (listViewItem.SubItems[0].Text.Equals(listViewItem2.SubItems[0].Text))
													{
														num3 = 6;
														continue;
													}
													break;
												}
												case 6:
												{
													bool flag3 = true;
													num3 = 2;
													continue;
												}
												}
												IL_424:
												num3 = 3;
												continue;
												goto IL_424;
											}
											IL_453:
											goto IL_32E;
										}
										finally
										{
											for (;;)
											{
												global::System.Collections.IEnumerator enumerator3;
												global::System.IDisposable disposable = enumerator3 as global::System.IDisposable;
												num3 = 0;
												for (;;)
												{
													switch (num3)
													{
													case 0:
														if (disposable != null)
														{
															num3 = 2;
															continue;
														}
														goto IL_4A0;
													case 1:
														goto IL_49E;
													case 2:
														disposable.Dispose();
														num3 = 1;
														continue;
													}
													break;
												}
											}
											IL_49E:
											IL_4A0:;
										}
										goto IL_4A1;
										IL_32E:
										num3 = 11;
										continue;
									case 11:
									{
										bool flag3;
										if (!flag3)
										{
											num3 = 8;
											continue;
										}
										break;
									}
									}
									goto IL_329;
									IL_4A1:
									num3 = 0;
									continue;
									IL_4ED:
									num3 = 4;
									continue;
									IL_329:
									goto IL_4ED;
								}
								IL_51F:
								goto IL_BC7;
							}
							finally
							{
								num3 = 1;
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num3 = 2;
										continue;
									case 2:
										goto IL_561;
									}
									if (enumerator2 == null)
									{
										break;
									}
									num3 = 0;
								}
								IL_561:;
							}
							goto IL_564;
							IL_BC7:
							global::System.Collections.IEnumerator enumerator4 = A_0.Items.GetEnumerator();
							num3 = 78;
							continue;
						}
						case 74:
							goto IL_8DB;
						case 75:
							if (c.b.Length > 0)
							{
								num3 = 46;
								continue;
							}
							goto IL_5F6;
						case 76:
							goto IL_8A0;
						case 77:
							if (array4[num7].Length > 0)
							{
								num3 = 66;
								continue;
							}
							goto IL_8C1;
						case 78:
							try
							{
								num3 = 7;
								for (;;)
								{
									switch (num3)
									{
									case 1:
									{
										global::System.Windows.Forms.ListViewItem listViewItem3;
										A_0.Items.Remove(listViewItem3);
										num3 = 0;
										continue;
									}
									case 2:
									{
										bool flag4;
										if (flag4)
										{
											num3 = 1;
											continue;
										}
										break;
									}
									case 3:
									{
										global::System.Collections.IEnumerator enumerator4;
										if (!enumerator4.MoveNext())
										{
											num3 = 5;
											continue;
										}
										global::System.Windows.Forms.ListViewItem listViewItem3 = (global::System.Windows.Forms.ListViewItem)enumerator4.Current;
										bool flag4 = true;
										global::System.Collections.Generic.IEnumerable<global::System.Windows.Forms.ListViewItem> enumerable2;
										global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator5 = enumerable2.GetEnumerator();
										num3 = 4;
										continue;
									}
									case 4:
										try
										{
											num3 = 5;
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													bool flag4 = false;
													num3 = 4;
													continue;
												}
												case 1:
												{
													global::System.Windows.Forms.ListViewItem listViewItem3;
													global::System.Windows.Forms.ListViewItem listViewItem4;
													if (listViewItem4.SubItems[0].Text.Equals(listViewItem3.SubItems[0].Text))
													{
														num3 = 0;
														continue;
													}
													break;
												}
												case 2:
													num3 = 3;
													continue;
												case 3:
													goto IL_10DF;
												case 6:
												{
													global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator5;
													if (!enumerator5.MoveNext())
													{
														num3 = 2;
														continue;
													}
													global::System.Windows.Forms.ListViewItem listViewItem4 = enumerator5.Current;
													num3 = 1;
													continue;
												}
												}
												IL_106B:
												num3 = 6;
												continue;
												goto IL_106B;
											}
											IL_10DF:
											goto IL_1147;
										}
										finally
										{
											num3 = 2;
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator5;
												switch (num3)
												{
												case 0:
													enumerator5.Dispose();
													num3 = 1;
													continue;
												case 1:
													goto IL_111E;
												}
												if (enumerator5 == null)
												{
													break;
												}
												num3 = 0;
											}
											IL_111E:;
										}
										break;
										IL_1147:
										num3 = 2;
										continue;
									case 5:
										num3 = 6;
										continue;
									case 6:
										goto IL_119F;
									}
									IL_1121:
									num3 = 3;
									continue;
									goto IL_1121;
								}
								IL_119F:
								goto IL_5F6;
							}
							finally
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator4;
									global::System.IDisposable disposable2 = enumerator4 as global::System.IDisposable;
									num3 = 0;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											if (disposable2 != null)
											{
												num3 = 2;
												continue;
											}
											goto IL_11EC;
										case 1:
											goto IL_11EA;
										case 2:
											disposable2.Dispose();
											num3 = 1;
											continue;
										}
										break;
									}
								}
								IL_11EA:
								IL_11EC:;
							}
							goto IL_11ED;
						case 79:
							num3 = 87;
							continue;
						case 80:
							goto IL_676;
						case 81:
							goto IL_E89;
						case 82:
							if (num16 >= array9.Length)
							{
								num3 = 76;
								continue;
							}
							text2 = array9[num16];
							num3 = 5;
							continue;
						case 83:
							goto IL_2BA;
						case 84:
						{
							bool flag2;
							if (!flag2)
							{
								num3 = 69;
								continue;
							}
							goto IL_676;
						}
						case 85:
							goto IL_F59;
						case 86:
						{
							string[] array6 = array4;
							num11 = 0;
							num3 = 9;
							continue;
						}
						case 87:
						{
							char[,] array5;
							if (array5[num14, 0] != '\0')
							{
								num3 = 60;
								continue;
							}
							goto IL_E89;
						}
						case 88:
							try
							{
								num3 = 2;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num3 = 6;
										continue;
									case 1:
										goto IL_A08;
									case 3:
									{
										int num8;
										if (num8 >= 0)
										{
											num3 = 0;
											continue;
										}
										break;
									}
									case 4:
									{
										char[,] array5;
										int num8;
										int num17;
										array5[num8, num17 - 1] = 'y';
										num3 = 8;
										continue;
									}
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator;
										if (!enumerator.MoveNext())
										{
											num3 = 7;
											continue;
										}
										global::System.Windows.Forms.ListViewItem listViewItem5 = enumerator.Current;
										int num17 = -1;
										int.TryParse(listViewItem5.SubItems[0].Text, out num17);
										num3 = 3;
										continue;
									}
									case 6:
									{
										int num17;
										if (num17 >= 0)
										{
											num3 = 4;
											continue;
										}
										break;
									}
									case 7:
										num3 = 1;
										continue;
									}
									IL_97D:
									num3 = 5;
									continue;
									goto IL_97D;
								}
								IL_A08:
								goto IL_900;
							}
							finally
							{
								num3 = 0;
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Windows.Forms.ListViewItem> enumerator;
									switch (num3)
									{
									case 1:
										goto IL_A4A;
									case 2:
										enumerator.Dispose();
										num3 = 1;
										continue;
									}
									if (enumerator == null)
									{
										break;
									}
									num3 = 2;
								}
								IL_A4A:;
							}
							goto IL_A4D;
							IL_900:
							num9 = 0;
							num3 = 34;
							continue;
						case 89:
						{
							try
							{
								num3 = 4;
								for (;;)
								{
									switch (num3)
									{
									case 1:
										goto IL_7F7;
									case 2:
									{
										if (!enumerator6.MoveNext())
										{
											num3 = 3;
											continue;
										}
										global::System.Windows.Forms.ListViewItem listViewItem6 = (global::System.Windows.Forms.ListViewItem)enumerator6.Current;
										num5++;
										num3 = 0;
										continue;
									}
									case 3:
										num3 = 1;
										continue;
									}
									IL_7B3:
									num3 = 2;
									continue;
									goto IL_7B3;
								}
								IL_7F7:
								goto IL_C72;
							}
							finally
							{
								for (;;)
								{
									global::System.IDisposable disposable3 = enumerator6 as global::System.IDisposable;
									num3 = 2;
									for (;;)
									{
										switch (num3)
										{
										case 0:
											disposable3.Dispose();
											num3 = 1;
											continue;
										case 1:
											goto IL_842;
										case 2:
											if (disposable3 != null)
											{
												num3 = 0;
												continue;
											}
											goto IL_844;
										}
										break;
									}
								}
								IL_842:
								IL_844:;
							}
							goto IL_845;
							IL_C72:
							char[,] array5 = new char[a.a.Length, num5];
							string[] array8 = array3;
							num15 = 0;
							num3 = 17;
							continue;
						}
						case 90:
						{
							int num4;
							char[,] array5;
							if (array5[num6, num4] == 'n')
							{
								num3 = 19;
								continue;
							}
							goto IL_11ED;
						}
						case 91:
							goto IL_246;
						case 92:
							goto IL_BFC;
						case 93:
							goto IL_ED8;
						case 94:
							if (num == -1)
							{
								num3 = 43;
								continue;
							}
							goto IL_8C1;
						}
						break;
						IL_246:
						num9++;
						num3 = 0;
						continue;
						IL_2BA:
						num3 = 62;
						continue;
						IL_564:
						num3 = 39;
						continue;
						IL_5F6:
						num11++;
						num3 = 47;
						continue;
						IL_676:
						array4 = new string[array.Length];
						array3 = new string[array.Length];
						num7 = 0;
						array9 = array;
						num16 = 0;
						num3 = 23;
						continue;
						IL_6A4:
						num3 = 36;
						continue;
						IL_845:
						array3[num7] = text2.Trim();
						array4[num7] = "";
						num3 = 16;
						continue;
						IL_869:
						num3 = 22;
						continue;
						IL_8A0:
						num5 = 0;
						enumerator6 = A_1.Items.GetEnumerator();
						num3 = 89;
						continue;
						IL_8C1:
						num7++;
						num16++;
						num3 = 74;
						continue;
						IL_8DB:
						num3 = 82;
						continue;
						IL_A4D:
						func2 = null;
						b2 = new global::mototrbodepottool.c.b();
						b2.a = a;
						string[] array10 = text3.Split(new char[]
						{
							':'
						});
						b2.b = array10[0].Trim();
						b2.c = array10[1].Trim();
						num3 = 20;
						continue;
						IL_BE5:
						num12++;
						num3 = 51;
						continue;
						IL_BFC:
						num6++;
						num3 = 50;
						continue;
						IL_C13:
						num2++;
						num3 = 58;
						continue;
						IL_D2A:
						num3 = 45;
						continue;
						IL_DE3:
						num15++;
						num3 = 55;
						continue;
						IL_DFA:
						num3 = 52;
						continue;
						IL_E24:
						num10++;
						num3 = 32;
						continue;
						IL_E89:
						num14++;
						num3 = 72;
						continue;
						IL_EA0:
						num3 = 1;
						continue;
						IL_ED8:
						num3 = 26;
						continue;
						IL_F59:
						text += text4;
						num3 = 31;
						continue;
						IL_11ED:
						num3 = 70;
						continue;
						IL_1213:
						num3 = 15;
					}
				}
				return;
			}
		}

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x04000259 RID: 601
			public string[] a;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000D0 RID: 208 RVA: 0x00019A24 File Offset: 0x00018A24
			public bool d(global::System.Windows.Forms.ListViewItem A_0)
			{
				switch (1 == 1)
				{
				}
				if (true)
				{
				}
				if (false)
				{
				}
				return A_0.SubItems[global::System.Array.IndexOf<string>(this.a.a, this.b)].Text.ToLower().Contains(this.c);
			}

			// Token: 0x0400025A RID: 602
			public global::mototrbodepottool.c.a a;

			// Token: 0x0400025B RID: 603
			public string b;

			// Token: 0x0400025C RID: 604
			public string c;
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060000D2 RID: 210 RVA: 0x00019AAC File Offset: 0x00018AAC
			public bool c(global::System.Windows.Forms.ListViewItem A_0)
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						if (!A_0.SubItems[3].Text.ToLower().Contains(this.b))
						{
							num = 3;
							continue;
						}
						return true;
					case 1:
						if (!A_0.SubItems[1].Text.ToLower().Contains(this.b))
						{
							num = 7;
							continue;
						}
						return true;
					case 3:
						num = 9;
						continue;
					case 4:
						goto IL_B4;
					case 5:
						num = 1;
						continue;
					case 6:
						if (!A_0.SubItems[2].Text.ToLower().Contains(this.b))
						{
							num = 10;
							continue;
						}
						return true;
					case 7:
						goto IL_164;
					case 8:
						if (!A_0.SubItems[5].Text.ToLower().Contains(this.b))
						{
							if (true)
							{
							}
							num = 4;
							continue;
						}
						return true;
					case 9:
						if (A_0.SubItems[4].Text.ToLower().Contains(this.b))
						{
							return true;
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_164;
						default:
							if (false)
							{
							}
							num = 11;
							continue;
						}
						break;
					case 10:
						num = 0;
						continue;
					case 11:
						num = 8;
						continue;
					}
					if (!A_0.SubItems[0].Text.ToLower().Contains(this.b))
					{
						num = 5;
						continue;
					}
					return true;
					IL_164:
					num = 6;
				}
				IL_B4:
				return A_0.SubItems[6].Text.ToLower().Contains(this.b);
			}

			// Token: 0x0400025D RID: 605
			public global::mototrbodepottool.c.a a;

			// Token: 0x0400025E RID: 606
			public string b;
		}
	}
}
