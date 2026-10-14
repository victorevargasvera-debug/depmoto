using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using custom_controls.Properties;

namespace custom_controls
{
	// Token: 0x02000035 RID: 53
	public class CCustomTextBox : global::System.Windows.Forms.RichTextBox
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0002C214 File Offset: 0x0002A414
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0002C258 File Offset: 0x0002A458
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Description("Specifies if the letter F is needed in restricted chars.")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFNeeded
		{
			get
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
				return this.aj;
			}
			set
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
				this.aj = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0002C29C File Offset: 0x0002A49C
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		public char PasswordChar
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				int num = global::custom_controls.a.SendMessage(base.Handle, 210, 0, 0);
				return (char)num;
			}
			set
			{
				for (;;)
				{
					global::custom_controls.a.SendMessage(base.Handle, 204, (int)value, 0);
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_32;
							default:
								if (false)
								{
								}
								this.bd = value;
								if (true)
								{
								}
								num = 1;
								continue;
							}
							break;
						case 1:
							return;
						case 2:
							if (value != '\0')
							{
								goto IL_32;
							}
							return;
						}
						break;
						IL_32:
						num = 0;
					}
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0002C374 File Offset: 0x0002A574
		public global::System.Windows.Forms.Button EyeButton
		{
			get
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
				return this.be;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0002C3B8 File Offset: 0x0002A5B8
		public global::custom_controls.CPanelTemplate PanelTemplate
		{
			get
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
				return this.bf;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0002C3FC File Offset: 0x0002A5FC
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0002C440 File Offset: 0x0002A640
		public string ResourceId
		{
			get
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
				return this.bg;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.bg = value;
						if (true)
						{
						}
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_08;
						}
						if (false)
						{
						}
						num = 2;
						continue;
					case 2:
						return;
					}
					IL_1C:
					if (this.bg != value)
					{
						num = 0;
						continue;
					}
					break;
					IL_08:
					goto IL_1C;
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002C4C0 File Offset: 0x0002A6C0
		// (set) Token: 0x06000277 RID: 631 RVA: 0x0002C504 File Offset: 0x0002A704
		public override string Text
		{
			get
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
				return base.Text;
			}
			set
			{
				switch (0)
				{
				default:
				{
					int num = 3;
					for (;;)
					{
						string[] array;
						int num2;
						int num3;
						int num4;
						switch (num)
						{
						case 0:
							if (!this.Focused)
							{
								num = 4;
								continue;
							}
							goto IL_3DA;
						case 1:
						{
							string text;
							array[0] = text.Substring(0, text.Length - array[0].Length) + array[0];
							num = 24;
							continue;
						}
						case 2:
						{
							global::System.DateTime now = global::System.DateTime.Now;
							string text = now.Year.ToString("0000", global::System.Globalization.CultureInfo.InvariantCulture);
							num = 19;
							continue;
						}
						case 4:
							goto IL_28B;
						case 5:
							goto IL_2B8;
						case 6:
							if (num2 == 0)
							{
								num = 20;
								continue;
							}
							goto IL_201;
						case 7:
						{
							this.@as = (global::System.Globalization.DateTimeFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
							string text2 = value;
							char[] separator = "/".ToCharArray();
							array = text2.Split(separator);
							if (true)
							{
							}
							num = 21;
							continue;
						}
						case 8:
							goto IL_1C7;
						case 9:
							num = 0;
							continue;
						case 10:
							if (num3 == 0)
							{
								num = 16;
								continue;
							}
							goto IL_37E;
						case 11:
							goto IL_37E;
						case 12:
							if (!string.IsNullOrEmpty(this.ay))
							{
								num = 26;
								continue;
							}
							goto IL_3DA;
						case 13:
						{
							global::System.DateTime now;
							num4 = now.Year;
							num = 5;
							continue;
						}
						case 14:
							if (!string.IsNullOrEmpty(this.az))
							{
								num = 25;
								continue;
							}
							goto IL_3DA;
						case 15:
							num = 23;
							continue;
						case 16:
							for (;;)
							{
								global::System.DateTime now;
								num3 = now.Day;
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_F5;
								}
							}
							IL_F5:
							if (false)
							{
							}
							num = 11;
							continue;
						case 17:
							if (this.a0)
							{
								num = 15;
								continue;
							}
							goto IL_3DA;
						case 18:
							if (num4 == 0)
							{
								num = 13;
								continue;
							}
							goto IL_2B8;
						case 19:
						{
							string text;
							if (array[0].Length < text.Length)
							{
								num = 1;
								continue;
							}
							goto IL_10C;
						}
						case 20:
						{
							global::System.DateTime now;
							num2 = now.Month;
							num = 22;
							continue;
						}
						case 21:
							if (array.Length == 5)
							{
								num = 2;
								continue;
							}
							goto IL_1C7;
						case 22:
							goto IL_201;
						case 23:
							if (this.az.Equals(value))
							{
								num = 9;
								continue;
							}
							goto IL_3DA;
						case 24:
							goto IL_10C;
						case 25:
							num = 12;
							continue;
						case 26:
							num = 17;
							continue;
						}
						if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.DateTime)
						{
							num = 7;
							continue;
						}
						goto IL_1C7;
						IL_10C:
						num4 = global::System.Convert.ToInt32(array[0], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 18;
						continue;
						IL_1C7:
						num = 14;
						continue;
						IL_201:
						num3 = global::System.Convert.ToInt32(array[2], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 10;
						continue;
						IL_2B8:
						num2 = global::System.Convert.ToInt32(array[1], global::System.Globalization.CultureInfo.InvariantCulture);
						num = 6;
						continue;
						IL_37E:
						int hour = global::System.Convert.ToInt32(array[3], global::System.Globalization.CultureInfo.InvariantCulture);
						int minute = global::System.Convert.ToInt32(array[4], global::System.Globalization.CultureInfo.InvariantCulture);
						global::System.DateTime dateTime = new global::System.DateTime(num4, num2, num3, hour, minute, 0, 0);
						value = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
						num = 8;
					}
					IL_28B:
					base.Text = this.ay;
					return;
					IL_3DA:
					base.Text = value;
					return;
				}
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0002C8F4 File Offset: 0x0002AAF4
		// (set) Token: 0x06000279 RID: 633 RVA: 0x0002C938 File Offset: 0x0002AB38
		[global::System.ComponentModel.Description("Specifies the type of the input value.")]
		[global::System.ComponentModel.DefaultValue(global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		public global::custom_controls.CCustomTextBox.valueTypes ValueType
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.am;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						return;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							if (false)
							{
							}
							this.am = value;
							base.Invalidate();
							num = 0;
							continue;
						}
						break;
					}
					if (true)
					{
					}
					if (this.am == value)
					{
						break;
					}
					num = 2;
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		public global::System.Globalization.NumberFormatInfo InvariantNumberFormat
		{
			get
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
				this.a();
				return this.a9;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0002CA04 File Offset: 0x0002AC04
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0002CA48 File Offset: 0x0002AC48
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Description("Give the restricted characters.")]
		public string RestrictedChars
		{
			get
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
				return this.an;
			}
			set
			{
				for (;;)
				{
					IL_00:
					int num = 2;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (true)
							{
							}
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								if (false)
								{
								}
								this.an = value;
								base.Invalidate();
								num = 0;
								continue;
							}
							break;
						}
						if (!(this.an != value))
						{
							return;
						}
						num = 1;
					}
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600027D RID: 637 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0002CB14 File Offset: 0x0002AD14
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Description("Indicates the restrictedChars is for valid chars or invalid chars.")]
		[global::System.ComponentModel.Category("Customization")]
		public bool IsValidChars
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.ao;
			}
			set
			{
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 1:
						this.ao = value;
						base.Invalidate();
						if (true)
						{
						}
						num = 2;
						continue;
					case 2:
						return;
					}
					if (this.ao == value)
					{
						break;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						if (false)
						{
						}
						num = 1;
						break;
					}
				}
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0002CB98 File Offset: 0x0002AD98
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		[global::System.ComponentModel.Description("Specifies the number of digits after the decimal point.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Bindable(true)]
		public int DecimalPlaces
		{
			get
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
				return this.ap;
			}
			set
			{
				for (;;)
				{
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.ap = value;
							num = 3;
							continue;
						case 1:
							this.ap = 0;
							num = 4;
							continue;
						case 2:
							goto IL_53;
						case 3:
							if (this.ap < 0)
							{
								num = 1;
								continue;
							}
							goto IL_45;
						case 4:
							goto IL_45;
						}
						if (this.ap != value)
						{
							num = 0;
							continue;
						}
						break;
						IL_45:
						base.Invalidate();
						num = 2;
					}
					IL_88:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_9E;
					}
					IL_53:
					goto IL_88;
				}
				IL_9E:
				if (false)
				{
				}
				if (true)
				{
				}
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0002CC98 File Offset: 0x0002AE98
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0002CCDC File Offset: 0x0002AEDC
		[global::System.ComponentModel.Description("used to indicate the text is modified or not.")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		public bool TextModified
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.at;
			}
			set
			{
				int num = 2;
				for (;;)
				{
					switch (num)
					{
					case 0:
						this.at = value;
						base.Invalidate();
						goto IL_46;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_46;
						default:
							goto IL_6C;
						}
						break;
					}
					if (this.at != value)
					{
						num = 0;
						continue;
					}
					return;
					IL_46:
					if (true)
					{
					}
					num = 1;
				}
				IL_6C:
				if (false)
				{
				}
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0002CD60 File Offset: 0x0002AF60
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0002CDA4 File Offset: 0x0002AFA4
		[global::System.ComponentModel.Description("used to indicate the nagative sign is needed or not.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsNegativeNeeded
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.au;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.au = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0002CDE8 File Offset: 0x0002AFE8
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0002CE2C File Offset: 0x0002B02C
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("Specifies the max value.")]
		[global::System.ComponentModel.DefaultValue(100)]
		[global::System.ComponentModel.Bindable(true)]
		public long Maximum
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.av;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.av = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0002CE70 File Offset: 0x0002B070
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		[global::System.ComponentModel.Description("Specifies the min value.")]
		[global::System.ComponentModel.DefaultValue(0)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Customization")]
		public long Minimum
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.aw;
			}
			set
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
				this.aw = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0002CEF8 File Offset: 0x0002B0F8
		// (set) Token: 0x0600028A RID: 650 RVA: 0x0002CF3C File Offset: 0x0002B13C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ConvertToUpperCase
		{
			get
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
				return this.bb;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.bb = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0002CF80 File Offset: 0x0002B180
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0002CFC4 File Offset: 0x0002B1C4
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Customization")]
		[global::System.ComponentModel.Description("used to indicate the value load from cp.")]
		[global::System.ComponentModel.Bindable(true)]
		public bool ValuefromLoad
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.bc;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.bc = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0002D008 File Offset: 0x0002B208
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0002D04C File Offset: 0x0002B24C
		public bool IsGridColumnFixed
		{
			get
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
				return this.ak;
			}
			set
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
				this.ak = value;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0002D090 File Offset: 0x0002B290
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		public global::System.Windows.Forms.ToolStripMenuItem MenuUndo
		{
			get
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
				return this.a1;
			}
			set
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
				this.a1 = value;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0002D118 File Offset: 0x0002B318
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0002D15C File Offset: 0x0002B35C
		public global::System.Windows.Forms.ToolStripMenuItem MenuSeparator1
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a2;
			}
			set
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
				this.a2 = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0002D1E4 File Offset: 0x0002B3E4
		public global::System.Windows.Forms.ToolStripMenuItem MenuCut
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a3;
			}
			set
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
				this.a3 = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0002D228 File Offset: 0x0002B428
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0002D26C File Offset: 0x0002B46C
		public string Alias
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.al;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.al = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0002D2B0 File Offset: 0x0002B4B0
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0002D2F4 File Offset: 0x0002B4F4
		public global::System.Windows.Forms.ToolStripMenuItem MenuCopy
		{
			get
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
				return this.a4;
			}
			set
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
				this.a4 = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0002D338 File Offset: 0x0002B538
		// (set) Token: 0x0600029A RID: 666 RVA: 0x0002D37C File Offset: 0x0002B57C
		public global::System.Windows.Forms.ToolStripMenuItem MenuPaste
		{
			get
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
				return this.a5;
			}
			set
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
				this.a5 = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0002D3C0 File Offset: 0x0002B5C0
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0002D40C File Offset: 0x0002B60C
		public string StandardValue
		{
			get
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
				string empty = string.Empty;
				this.FormatTextToStandard(ref empty);
				return empty;
			}
			set
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
				this.SetStandardTextToFormat(value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0002D450 File Offset: 0x0002B650
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0002D494 File Offset: 0x0002B694
		public bool FontColor
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.ax;
			}
			set
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
				this.ax = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0002D4D8 File Offset: 0x0002B6D8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0002D51C File Offset: 0x0002B71C
		public string HiddenSymbol
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.ay;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.ay = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0002D560 File Offset: 0x0002B760
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public string HiddenValue
		{
			get
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
				return this.az;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.az = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0002D5E8 File Offset: 0x0002B7E8
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0002D62C File Offset: 0x0002B82C
		public bool HiddenEnabled
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.a0;
			}
			set
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
				this.a0 = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0002D670 File Offset: 0x0002B870
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0002D6B4 File Offset: 0x0002B8B4
		public global::System.Windows.Forms.ToolStripMenuItem MenuDelete
		{
			get
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
				return this.a6;
			}
			set
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
				this.a6 = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0002D73C File Offset: 0x0002B93C
		public global::System.Windows.Forms.ToolStripSeparator MenuSeparator2
		{
			get
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				return this.a7;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.a7 = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0002D780 File Offset: 0x0002B980
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		public global::System.Windows.Forms.ToolStripMenuItem MenuSelectAll
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.a8;
			}
			set
			{
				if (true)
				{
				}
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				this.a8 = value;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0002D808 File Offset: 0x0002BA08
		public CCustomTextBox()
		{
			this.aq = false;
			this.aj = true;
			this.ax = false;
			this.al = string.Empty;
			this.ay = string.Empty;
			this.az = string.Empty;
			this.a0 = false;
			this.c();
			base.TextChanged += this.i;
			base.EnabledChanged -= this.b;
			base.EnabledChanged += this.b;
			base.ReadOnlyChanged -= this.a;
			base.ReadOnlyChanged += this.a;
			this.a3 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.a3.MergeIndex = 3;
			this.a3.ShortcutKeys = (global::System.Windows.Forms.Keys)131160;
			this.a3.ShowShortcutKeys = false;
			this.a3.Click += this.f;
			this.a3.Text = "Cu&t";
			this.a4 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.a4.MergeIndex = 4;
			this.a4.ShortcutKeys = (global::System.Windows.Forms.Keys)131139;
			this.a4.ShowShortcutKeys = false;
			this.a4.Click += this.h;
			this.a4.Text = "&Copy";
			this.a5 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.a5.MergeIndex = 5;
			this.a5.ShortcutKeys = (global::System.Windows.Forms.Keys)131158;
			this.a5.ShowShortcutKeys = false;
			this.a5.Click += this.g;
			this.a5.Text = "&Paste";
			this.a6 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.a6.MergeIndex = 6;
			this.a6.ShortcutKeys = global::System.Windows.Forms.Keys.Delete;
			this.a6.ShowShortcutKeys = false;
			this.a6.Click += this.e;
			this.a6.Text = "&Delete";
			this.a7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.a7.MergeIndex = 7;
			this.a8 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.a8.MergeIndex = 8;
			this.a8.ShortcutKeys = (global::System.Windows.Forms.Keys)131137;
			this.a8.ShowShortcutKeys = false;
			this.a8.Click += this.d;
			this.a8.Text = "Select &All";
			base.DetectUrls = false;
			this.ContextMenuStrip = new global::System.Windows.Forms.ContextMenuStrip();
			this.ContextMenuStrip.Items.Add(this.a3);
			this.ContextMenuStrip.Items.Add(this.a4);
			this.ContextMenuStrip.Items.Add(this.a5);
			this.ContextMenuStrip.Items.Add(this.a6);
			this.ContextMenuStrip.Opened += this.c;
			this.a();
			this.ba = false;
			this.bb = false;
			this.bc = false;
			this.bg = string.Empty;
			this.bi = null;
			this.hasRange = false;
			this.bh = new global::System.Collections.ArrayList();
			this.bj = false;
			this.bk = new global::System.Collections.Hashtable();
			this.be = null;
			this.bf = null;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0002DB94 File Offset: 0x0002BD94
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
		public string XmlRange
		{
			get
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
				return this.bi;
			}
			set
			{
				for (;;)
				{
					this.bi = value;
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							this.d();
							num = 1;
							continue;
						case 1:
							return;
						case 2:
							this.SetSubRange(value);
							num = 4;
							continue;
						case 3:
							if (!string.IsNullOrEmpty(value))
							{
								num = 2;
								continue;
							}
							return;
						case 4:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								if (true)
								{
								}
								if (false)
								{
								}
								if (!this.bj)
								{
									return;
								}
								break;
							}
							num = 0;
							continue;
						}
						break;
					}
				}
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0002DC84 File Offset: 0x0002BE84
		public void SetSubRange(string xmlRange)
		{
			if (true)
			{
			}
			switch (0)
			{
			default:
			{
				string value = string.Empty;
				try
				{
					for (;;)
					{
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.LoadXml(xmlRange);
						global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//SUB_RANGE");
						int num = 10;
						for (;;)
						{
							decimal num3;
							string name;
							int num5;
							global::System.Xml.XmlNodeList xmlNodeList2;
							int num6;
							switch (num)
							{
							case 0:
								num = 1;
								continue;
							case 1:
							{
								decimal num2;
								if (-1m != num2)
								{
									num = 27;
									continue;
								}
								goto IL_577;
							}
							case 2:
								goto IL_390;
							case 3:
							{
								decimal num2;
								decimal num4;
								this.bh.Add(new global::custom_controls.CCustomTextBox.RFRange(num3, num2, num4));
								num = 39;
								continue;
							}
							case 4:
								goto IL_24B;
							case 5:
								goto IL_390;
							case 6:
								goto IL_179;
							case 7:
								if (xmlNodeList.Count <= 0)
								{
									num = 9;
									continue;
								}
								goto IL_1F4;
							case 8:
								this.bh.Clear();
								num = 23;
								continue;
							case 9:
								goto IL_513;
							case 10:
								if (xmlNodeList != null)
								{
									num = 14;
									continue;
								}
								goto IL_513;
							case 11:
								num = 13;
								continue;
							case 12:
								goto IL_390;
							case 13:
							{
								if (!(name == "Max"))
								{
									num = 20;
									continue;
								}
								decimal num2 = global::System.Convert.ToDecimal(value, this.InvariantNumberFormat);
								num = 2;
								continue;
							}
							case 14:
								num = 7;
								continue;
							case 15:
								num = 40;
								continue;
							case 16:
							{
								if (num5 >= xmlNodeList.Count)
								{
									num = 21;
									continue;
								}
								num3 = -1m;
								decimal num2 = -1m;
								decimal num4 = -1m;
								xmlNodeList2 = xmlNodeList[num5].ChildNodes;
								num6 = 0;
								num = 45;
								continue;
							}
							case 17:
							{
								if (!(name == "StepSize"))
								{
									num = 15;
									continue;
								}
								decimal num4 = global::System.Convert.ToDecimal(value, this.InvariantNumberFormat);
								num = 12;
								continue;
							}
							case 18:
								goto IL_483;
							case 19:
								if (this.bh.Count > 0)
								{
									num = 8;
									continue;
								}
								goto IL_4CA;
							case 20:
								num = 17;
								continue;
							case 21:
								num = 41;
								continue;
							case 22:
								num = 37;
								continue;
							case 23:
								goto IL_4CA;
							case 24:
								goto IL_24B;
							case 25:
								if (xmlNodeList != null)
								{
									num = 22;
									continue;
								}
								goto IL_16D;
							case 26:
								num = 19;
								continue;
							case 27:
								num = 34;
								continue;
							case 28:
								if (num6 >= xmlNodeList2.Count)
								{
									num = 30;
									continue;
								}
								value = xmlNodeList2[num6].InnerText;
								num = 36;
								continue;
							case 29:
								num = 31;
								continue;
							case 30:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_3EF;
								default:
									if (false)
									{
									}
									num = 32;
									continue;
								}
								break;
							case 31:
								if (this.ValueType.Equals(global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric))
								{
									num = 42;
									continue;
								}
								goto IL_1F4;
							case 32:
								if (-1m != num3)
								{
									num = 0;
									continue;
								}
								goto IL_577;
							case 33:
								goto IL_13A;
							case 34:
							{
								decimal num4;
								if (-1m != num4)
								{
									num = 3;
									continue;
								}
								goto IL_577;
							}
							case 35:
								num = 43;
								continue;
							case 36:
								if ((name = xmlNodeList2[num6].Name) != null)
								{
									num = 35;
									continue;
								}
								goto IL_390;
							case 37:
								if (xmlNodeList.Count <= 0)
								{
									num = 46;
									continue;
								}
								num = 38;
								continue;
							case 38:
								if (!this.ValueType.Equals(global::custom_controls.CCustomTextBox.valueTypes.IntegerHex))
								{
									num = 29;
									continue;
								}
								goto IL_127;
							case 39:
								goto IL_577;
							case 40:
								goto IL_390;
							case 41:
								goto IL_59A;
							case 42:
								goto IL_127;
							case 43:
								goto IL_3EF;
							case 44:
								if (this.bh != null)
								{
									num = 26;
									continue;
								}
								goto IL_4CA;
							case 45:
								goto IL_483;
							case 46:
								goto IL_16D;
							}
							break;
							IL_127:
							this.a(xmlDocument);
							num = 33;
							continue;
							IL_16D:
							num = 6;
							continue;
							IL_1F4:
							num = 44;
							continue;
							IL_24B:
							num = 16;
							continue;
							IL_390:
							num6++;
							num = 18;
							continue;
							IL_3EF:
							if (!(name == "Min"))
							{
								num = 11;
								continue;
							}
							num3 = global::System.Convert.ToDecimal(value, this.InvariantNumberFormat);
							num = 5;
							continue;
							IL_483:
							num = 28;
							continue;
							IL_4CA:
							this.hasRange = true;
							xmlNodeList2 = null;
							num5 = 0;
							num = 24;
							continue;
							IL_513:
							xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//RANGE");
							num = 25;
							continue;
							IL_577:
							num5++;
							num = 4;
						}
					}
					IL_13A:
					IL_179:
					IL_59A:;
				}
				catch
				{
				}
				return;
			}
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0002E258 File Offset: 0x0002C458
		private void a(global::System.Xml.XmlDocument A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					global::System.Xml.XmlNode xmlNode = null;
					string value = string.Empty;
					int num = 3;
					for (;;)
					{
						switch (num)
						{
						case 0:
							return;
						case 1:
							goto IL_232;
						case 2:
							if (xmlNode == null)
							{
								num = 1;
								continue;
							}
							goto IL_4C;
						case 3:
							if (A_0 == null)
							{
								num = 0;
								continue;
							}
							xmlNode = A_0.DocumentElement.SelectSingleNode("//RANGE");
							if (true)
							{
							}
							num = 2;
							continue;
						}
						break;
					}
				}
				return;
				try
				{
					IL_4C:
					for (;;)
					{
						global::System.Xml.XmlNode xmlNode;
						global::System.Xml.XmlNodeList childNodes = xmlNode.ChildNodes;
						int num2 = 0;
						int num = 10;
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								string name;
								if (!(name == "Max"))
								{
									num = 6;
									continue;
								}
								string value;
								this.av = (long)global::System.Convert.ToDecimal(value, this.InvariantNumberFormat);
								num = 13;
								continue;
							}
							case 1:
								num = 0;
								continue;
							case 2:
							{
								if (num2 >= childNodes.Count)
								{
									num = 8;
									continue;
								}
								string value = childNodes[num2].InnerText;
								num = 12;
								continue;
							}
							case 3:
								goto IL_C3;
							case 4:
								num = 7;
								continue;
							case 5:
								goto IL_122;
							case 6:
								num = 11;
								continue;
							case 7:
							{
								string name;
								if (!(name == "Min"))
								{
									num = 1;
									continue;
								}
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1EA;
								default:
								{
									if (false)
									{
									}
									string value;
									this.aw = (long)global::System.Convert.ToDecimal(value, this.InvariantNumberFormat);
									num = 5;
									continue;
								}
								}
								break;
							}
							case 8:
								num = 9;
								continue;
							case 9:
								goto IL_1EA;
							case 10:
								goto IL_C3;
							case 11:
								goto IL_122;
							case 12:
							{
								string name;
								if ((name = childNodes[num2].Name) != null)
								{
									num = 4;
									continue;
								}
								goto IL_122;
							}
							case 13:
								goto IL_122;
							}
							break;
							IL_C3:
							num = 2;
							continue;
							IL_122:
							num2++;
							num = 3;
						}
					}
					IL_1EA:
					return;
				}
				catch
				{
					return;
				}
				return;
				IL_232:
				return;
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0002E4B8 File Offset: 0x0002C6B8
		public decimal GetValidValue(decimal enteredValue)
		{
			switch (0)
			{
			default:
			{
				decimal num = enteredValue;
				bool flag = false;
				try
				{
					for (;;)
					{
						global::custom_controls.CCustomTextBox.RFRange rfrange = (global::custom_controls.CCustomTextBox.RFRange)this.bh[0];
						int num2 = 26;
						for (;;)
						{
							decimal num3;
							decimal num4;
							int num6;
							int num8;
							switch (num2)
							{
							case 0:
							{
								decimal rfLow;
								num3 = rfLow;
								num2 = 6;
								continue;
							}
							case 1:
								goto IL_468;
							case 2:
							{
								if (num > num4)
								{
									num2 = 25;
									continue;
								}
								decimal num5 = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).RfLow;
								decimal d = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[this.bh.Count - 1]).RfHigh - ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).RfLow;
								num6 = 0;
								num2 = 18;
								continue;
							}
							case 3:
								flag = true;
								num2 = 1;
								continue;
							case 4:
							{
								decimal d;
								decimal num7;
								if (num7 < d)
								{
									num2 = 8;
									continue;
								}
								goto IL_559;
							}
							case 5:
								num = num3;
								num2 = 24;
								continue;
							case 6:
								goto IL_4E3;
							case 7:
								goto IL_48B;
							case 8:
							{
								decimal num7;
								decimal d = num7;
								decimal num5 = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num6]).RfHigh;
								num2 = 28;
								continue;
							}
							case 9:
								num2 = 10;
								continue;
							case 10:
							{
								decimal rfHigh;
								if (num <= rfHigh)
								{
									num2 = 3;
									continue;
								}
								goto IL_10A;
							}
							case 11:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_33F;
								default:
									if (false)
									{
									}
									goto IL_134;
								}
								break;
							case 12:
							{
								if (num8 > this.bh.Count - 1)
								{
									num2 = 21;
									continue;
								}
								decimal rfLow = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num8]).RfLow;
								decimal rfHigh = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num8]).RfHigh;
								num2 = 34;
								continue;
							}
							case 13:
							{
								long value = (long)global::System.Math.Floor((double)(num / ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).StepSize));
								num = value * ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).StepSize;
								goto IL_33F;
							}
							case 14:
								goto IL_5B9;
							case 15:
							{
								decimal num9;
								decimal d = num9;
								decimal num5 = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num6]).RfLow;
								num2 = 11;
								continue;
							}
							case 16:
							{
								decimal rfLow;
								if (rfLow < num3)
								{
									num2 = 0;
									continue;
								}
								goto IL_4E3;
							}
							case 17:
								goto IL_50E;
							case 18:
								goto IL_23A;
							case 19:
								goto IL_48B;
							case 20:
							{
								decimal num5;
								num = num5;
								num2 = 22;
								continue;
							}
							case 21:
								goto IL_468;
							case 22:
								goto IL_5AD;
							case 23:
								if (num < num3)
								{
									num2 = 5;
									continue;
								}
								num2 = 2;
								continue;
							case 24:
								goto IL_5AD;
							case 25:
								num = num4;
								num2 = 31;
								continue;
							case 26:
								if (true)
								{
								}
								if (rfrange.StepSize > 0m)
								{
									num2 = 13;
									continue;
								}
								goto IL_50E;
							case 27:
								if (!flag)
								{
									num2 = 30;
									continue;
								}
								goto IL_5AD;
							case 28:
								goto IL_559;
							case 29:
								goto IL_2D5;
							case 30:
								num2 = 23;
								continue;
							case 31:
								goto IL_5AD;
							case 32:
							{
								if (num6 > this.bh.Count - 1)
								{
									num2 = 20;
									continue;
								}
								decimal num9 = global::System.Math.Abs(num - ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num6]).RfLow);
								decimal num7 = global::System.Math.Abs(num - ((global::custom_controls.CCustomTextBox.RFRange)this.bh[num6]).RfHigh);
								num2 = 33;
								continue;
							}
							case 33:
							{
								decimal d;
								decimal num9;
								if (num9 < d)
								{
									num2 = 15;
									continue;
								}
								goto IL_134;
							}
							case 34:
							{
								decimal rfLow;
								if (num >= rfLow)
								{
									num2 = 9;
									continue;
								}
								goto IL_10A;
							}
							case 35:
							{
								decimal rfHigh;
								num4 = rfHigh;
								num2 = 29;
								continue;
							}
							case 36:
							{
								decimal rfHigh;
								if (rfHigh > num4)
								{
									num2 = 35;
									continue;
								}
								goto IL_2D5;
							}
							case 37:
								goto IL_23A;
							}
							break;
							IL_10A:
							num2 = 16;
							continue;
							IL_134:
							num2 = 4;
							continue;
							IL_23A:
							num2 = 32;
							continue;
							IL_2D5:
							num8++;
							num2 = 19;
							continue;
							IL_33F:
							num2 = 17;
							continue;
							IL_468:
							num2 = 27;
							continue;
							IL_48B:
							num2 = 12;
							continue;
							IL_4E3:
							num2 = 36;
							continue;
							IL_50E:
							num3 = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).RfLow;
							num4 = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).RfHigh;
							num8 = 0;
							num2 = 7;
							continue;
							IL_559:
							num6++;
							num2 = 37;
							continue;
							IL_5AD:
							num2 = 14;
						}
					}
					IL_5B9:;
				}
				catch
				{
				}
				return num;
			}
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0002EAF0 File Offset: 0x0002CCF0
		public bool IsRangePerChar
		{
			get
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				return this.bj;
			}
			set
			{
				switch (1 == 1)
				{
				}
				if (false)
				{
				}
				if (true)
				{
				}
				this.bj = value;
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0002EB34 File Offset: 0x0002CD34
		private void d()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					if (true)
					{
					}
					int num = 0;
					int num2 = 0;
					string text = string.Empty;
					int num3 = 0;
					for (;;)
					{
						global::System.IO.StringReader stringReader;
						switch (num3)
						{
						case 0:
							if (string.IsNullOrEmpty(this.bi))
							{
								num3 = 1;
								continue;
							}
							goto IL_5B3;
						case 1:
							return;
						case 2:
							try
							{
								try
								{
									for (;;)
									{
										global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
										stringReader = new global::System.IO.StringReader(this.bi);
										global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader);
										num3 = 6;
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::System.Xml.XmlNodeList xmlNodeList;
												if (xmlNodeList.Count > 0)
												{
													num3 = 5;
													continue;
												}
												goto IL_560;
											}
											case 1:
												goto IL_FC;
											case 2:
												goto IL_4EB;
											case 3:
												goto IL_56C;
											case 4:
											{
												global::System.Xml.XmlNodeList xmlNodeList;
												if (xmlNodeList != null)
												{
													num3 = 2;
													continue;
												}
												goto IL_560;
											}
											case 5:
											{
												global::System.Xml.XmlNodeList xmlNodeList;
												global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
												num3 = 1;
												continue;
											}
											case 6:
											{
												try
												{
													stringReader = null;
													xmlDocument.Load(xmlReader);
													goto IL_52C;
												}
												finally
												{
													num3 = 2;
													for (;;)
													{
														switch (num3)
														{
														case 0:
															((global::System.IDisposable)xmlReader).Dispose();
															num3 = 1;
															continue;
														case 1:
															goto IL_F9;
														}
														if (xmlReader == null)
														{
															break;
														}
														num3 = 0;
													}
													IL_F9:;
												}
												goto Block_5;
												IL_52C:
												global::System.Xml.XmlNodeList xmlNodeList = xmlDocument.DocumentElement.SelectNodes("//RANGE");
												num3 = 4;
												continue;
											}
											}
											break;
											IL_4EB:
											num3 = 0;
											continue;
											Block_5:
											try
											{
												IL_FC:
												num3 = 2;
												for (;;)
												{
													global::custom_controls.CCustomTextBox.a a;
													int num5;
													switch (num3)
													{
													case 1:
														goto IL_43E;
													case 3:
														try
														{
															num3 = 15;
															for (;;)
															{
																switch (num3)
																{
																case 1:
																{
																	global::System.Xml.XmlNode xmlNode;
																	string name;
																	if ((name = xmlNode.Name) != null)
																	{
																		num3 = 10;
																		continue;
																	}
																	goto IL_367;
																}
																case 2:
																	goto IL_367;
																case 3:
																{
																	global::System.Xml.XmlNode xmlNode;
																	if (xmlNode.Attributes["CP"] != null)
																	{
																		num3 = 14;
																		continue;
																	}
																	break;
																}
																case 4:
																	num3 = 6;
																	continue;
																case 5:
																	goto IL_3A3;
																case 6:
																{
																	string name;
																	if (!(name == "LENGTH"))
																	{
																		num3 = 7;
																		continue;
																	}
																	global::System.Xml.XmlNode xmlNode;
																	num2 = global::System.Convert.ToInt32(xmlNode.InnerText, this.InvariantNumberFormat);
																	num3 = 0;
																	continue;
																}
																case 7:
																	num3 = 2;
																	continue;
																case 10:
																	num3 = 11;
																	continue;
																case 11:
																{
																	string name;
																	if (!(name == "OFFSET"))
																	{
																		num3 = 4;
																		continue;
																	}
																	global::System.Xml.XmlNode xmlNode;
																	num = global::System.Convert.ToInt32(xmlNode.InnerText, this.InvariantNumberFormat);
																	num3 = 9;
																	continue;
																}
																case 12:
																{
																	global::System.Collections.IEnumerator enumerator2;
																	if (!enumerator2.MoveNext())
																	{
																		num3 = 13;
																		continue;
																	}
																	global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator2.Current;
																	num3 = 1;
																	continue;
																}
																case 13:
																	num3 = 5;
																	continue;
																case 14:
																{
																	global::System.Xml.XmlNode xmlNode;
																	int num4 = global::System.Convert.ToInt32(xmlNode.Attributes["CP"].Value, this.a9);
																	text += global::System.Convert.ToChar(num4, this.a9);
																	num3 = 8;
																	continue;
																}
																}
																IL_341:
																num3 = 12;
																continue;
																goto IL_341;
																IL_367:
																num3 = 3;
															}
															IL_3A3:
															goto IL_462;
														}
														finally
														{
															for (;;)
															{
																global::System.Collections.IEnumerator enumerator2;
																global::System.IDisposable disposable = enumerator2 as global::System.IDisposable;
																num3 = 2;
																for (;;)
																{
																	switch (num3)
																	{
																	case 0:
																		disposable.Dispose();
																		num3 = 1;
																		continue;
																	case 1:
																		goto IL_3EE;
																	case 2:
																		if (disposable != null)
																		{
																			num3 = 0;
																			continue;
																		}
																		goto IL_3F0;
																	}
																	break;
																}
															}
															IL_3EE:
															IL_3F0:;
														}
														goto IL_3F1;
														IL_462:
														a = new global::custom_controls.CCustomTextBox.a(num, num2, text);
														num5 = num;
														goto IL_46F;
													case 4:
														goto IL_3F1;
													case 5:
														switch ((1 == 1) ? 1 : 0)
														{
														case 0:
														case 2:
															goto IL_46F;
														default:
															if (false)
															{
															}
															if (!this.bk.ContainsKey(num5))
															{
																num3 = 4;
																continue;
															}
															goto IL_47D;
														}
														break;
													case 6:
														goto IL_49D;
													case 7:
														goto IL_47D;
													case 8:
														goto IL_43E;
													case 9:
														num3 = 6;
														continue;
													case 10:
														if (num5 >= num + num2)
														{
															num3 = 0;
															continue;
														}
														num3 = 5;
														continue;
													case 11:
													{
														global::System.Collections.IEnumerator enumerator;
														if (!enumerator.MoveNext())
														{
															num3 = 9;
															continue;
														}
														global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
														num = 0;
														num2 = 0;
														text = string.Empty;
														global::System.Collections.IEnumerator enumerator2 = xmlNode2.ChildNodes.GetEnumerator();
														num3 = 3;
														continue;
													}
													}
													goto IL_13E;
													IL_3F1:
													this.bk.Add(num5, a);
													num3 = 7;
													continue;
													IL_418:
													num3 = 11;
													continue;
													IL_13E:
													goto IL_418;
													IL_43E:
													num3 = 10;
													continue;
													IL_46F:
													num3 = 1;
													continue;
													IL_47D:
													num5++;
													num3 = 8;
												}
												IL_49D:
												goto IL_560;
											}
											finally
											{
												for (;;)
												{
													global::System.Collections.IEnumerator enumerator;
													global::System.IDisposable disposable2 = enumerator as global::System.IDisposable;
													num3 = 1;
													for (;;)
													{
														switch (num3)
														{
														case 0:
															disposable2.Dispose();
															num3 = 2;
															continue;
														case 1:
															if (disposable2 != null)
															{
																num3 = 0;
																continue;
															}
															goto IL_4EA;
														case 2:
															goto IL_4E8;
														}
														break;
													}
												}
												IL_4E8:
												IL_4EA:;
											}
											goto IL_4EB;
											IL_560:
											num3 = 3;
										}
									}
									IL_56C:;
								}
								catch
								{
								}
								return;
							}
							finally
							{
								num3 = 2;
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_5B0;
									case 1:
										stringReader.Dispose();
										num3 = 0;
										continue;
									}
									if (stringReader == null)
									{
										break;
									}
									num3 = 1;
								}
								IL_5B0:;
							}
							goto IL_5B3;
						}
						break;
						IL_5B3:
						stringReader = null;
						num3 = 2;
					}
				}
				return;
			}
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0002F190 File Offset: 0x0002D390
		private bool d(char A_0)
		{
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				switch (0)
				{
				}
				break;
			}
			if (true)
			{
			}
			bool flag = false;
			try
			{
				for (;;)
				{
					string text = this.Text.Remove(base.SelectionStart, this.SelectedText.Length);
					text = text.Insert(base.SelectionStart, A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					char[] array = text.ToCharArray();
					int num = base.SelectionStart;
					int num2 = 0;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_E9;
						case 1:
							goto IL_E9;
						case 2:
							if (this.bk.ContainsKey(num))
							{
								num2 = 6;
								continue;
							}
							goto IL_149;
						case 3:
							goto IL_149;
						case 4:
							if (num >= array.Length)
							{
								num2 = 5;
								continue;
							}
							num2 = 2;
							continue;
						case 5:
							goto IL_15B;
						case 6:
							flag = ((global::custom_controls.CCustomTextBox.a)this.bk[num]).a(array[num]);
							num2 = 8;
							continue;
						case 7:
							goto IL_167;
						case 8:
							if (flag)
							{
								num2 = 3;
								continue;
							}
							goto IL_15B;
						}
						break;
						IL_E9:
						num2 = 4;
						continue;
						IL_149:
						num++;
						num2 = 1;
						continue;
						IL_15B:
						num2 = 7;
					}
				}
				IL_167:;
			}
			catch
			{
			}
			return flag;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0002F328 File Offset: 0x0002D528
		public void LoadMenuText(string cut, string copy, string paste, string delete, string undo)
		{
			int num = 9;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.a3.Text = cut;
					num = 4;
					continue;
				case 1:
					this.a4.Text = copy;
					num = 6;
					continue;
				case 2:
					if (!string.IsNullOrEmpty(copy))
					{
						num = 1;
						continue;
					}
					goto IL_91;
				case 3:
					this.a6.Text = delete;
					num = 8;
					continue;
				case 4:
					goto IL_B1;
				case 5:
					this.a5.Text = paste;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						if (false)
						{
						}
						num = 7;
						continue;
					}
					break;
				case 6:
					goto IL_91;
				case 7:
					goto IL_104;
				case 8:
					return;
				case 10:
					if (!string.IsNullOrEmpty(paste))
					{
						num = 5;
						continue;
					}
					goto IL_104;
				case 11:
					if (true)
					{
					}
					if (!string.IsNullOrEmpty(delete))
					{
						num = 3;
						continue;
					}
					return;
				}
				if (!string.IsNullOrEmpty(cut))
				{
					num = 0;
					continue;
				}
				goto IL_B1;
				IL_91:
				num = 10;
				continue;
				IL_B1:
				num = 2;
				continue;
				IL_104:
				num = 11;
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0002F480 File Offset: 0x0002D680
		protected override void Dispose(bool disposing)
		{
			if (true)
			{
			}
			int num = 0;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_74;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 1:
					goto IL_72;
				case 2:
					if (this.ai != null)
					{
						num = 4;
						continue;
					}
					goto IL_8E;
				case 3:
					goto IL_74;
				case 4:
					this.ai.Dispose();
					num = 1;
					continue;
				}
				if (disposing)
				{
					num = 3;
					continue;
				}
				break;
				IL_74:
				num = 2;
			}
			IL_72:
			IL_8E:
			base.Dispose(disposing);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0002F524 File Offset: 0x0002D724
		private void c()
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.ai = new global::System.ComponentModel.Container();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0002F56C File Offset: 0x0002D76C
		public bool GetValidTextValue(ref object textValue)
		{
			bool result;
			switch ((1 == 1) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				if (false)
				{
				}
				switch (0)
				{
				default:
				{
					string text = (string)this.Text.Clone();
					this.a();
					if (!this.aq)
					{
						try
						{
							for (;;)
							{
								global::custom_controls.CCustomTextBox.valueTypes valueType = this.ValueType;
								int num = 46;
								for (;;)
								{
									int num2;
									int num3;
									int num5;
									switch (num)
									{
									case 0:
									{
										decimal d;
										if (d < this.Minimum)
										{
											num = 48;
											continue;
										}
										text = this.Maximum.ToString("N", this.ar);
										num = 34;
										continue;
									}
									case 1:
										num = 36;
										continue;
									case 2:
										if (num2 >= text.Length)
										{
											num = 12;
											continue;
										}
										num3 += int.Parse(text.Substring(text.Length - num2 - 1, 1), global::System.Globalization.CultureInfo.InvariantCulture) * (int)global::System.Math.Pow(8.0, (double)num2);
										num2++;
										num = 40;
										continue;
									case 3:
										goto IL_85C;
									case 4:
									{
										int num4;
										if ((long)num4 < this.Minimum)
										{
											num = 49;
											continue;
										}
										num = 29;
										continue;
									}
									case 5:
									{
										int num4 = global::System.Convert.ToInt32(this.ConvertFromStandardTextToDec(text));
										num = 4;
										continue;
									}
									case 6:
										if (string.IsNullOrEmpty(text.Trim()))
										{
											num = 15;
											continue;
										}
										text = (string)this.Text.Clone();
										text = text.Replace(" ", "");
										num = 25;
										continue;
									case 7:
										goto IL_25C;
									case 8:
										if (this.Text.IndexOf("(", global::System.StringComparison.Ordinal) == -1)
										{
											num = 43;
											continue;
										}
										goto IL_4E7;
									case 9:
										num = 52;
										continue;
									case 10:
										if (num5 >= text.Length)
										{
											num = 23;
											continue;
										}
										num3 += int.Parse(text.Substring(text.Length - num5 - 1, 1), global::System.Globalization.CultureInfo.InvariantCulture) * (int)global::System.Math.Pow(8.0, (double)num5);
										num5++;
										num = 18;
										continue;
									case 11:
										if (!string.IsNullOrEmpty(this.az))
										{
											num = 7;
											continue;
										}
										goto IL_85C;
									case 12:
										goto IL_622;
									case 13:
										if (this.Minimum != this.Maximum)
										{
											num = 33;
											continue;
										}
										goto IL_684;
									case 14:
										goto IL_802;
									case 15:
										text = this.Minimum.ToString("N", this.ar);
										num = 39;
										continue;
									case 16:
										goto IL_85C;
									case 17:
										textValue = this.az;
										num = 16;
										continue;
									case 18:
										goto IL_2A7;
									case 19:
										goto IL_868;
									case 20:
										text = this.Maximum.ToString("N", this.ar);
										num = 51;
										continue;
									case 21:
										goto IL_4E7;
									case 22:
										goto IL_684;
									case 23:
										num3 = -num3;
										num = 28;
										continue;
									case 24:
										if (this.ay.Equals(this.Text))
										{
											num = 17;
											continue;
										}
										goto IL_85C;
									case 25:
										goto IL_777;
									case 26:
										goto IL_85C;
									case 27:
										goto IL_239;
									case 28:
										goto IL_622;
									case 29:
									{
										int num4;
										if ((long)num4 > this.Maximum)
										{
											num = 20;
											continue;
										}
										goto IL_239;
									}
									case 30:
										goto IL_85C;
									case 31:
										goto IL_85C;
									case 32:
										goto IL_74D;
									case 33:
									{
										decimal d = this.ConvertFromStandardTextToDec(text);
										num = 0;
										continue;
									}
									case 34:
										goto IL_684;
									case 35:
										goto IL_2A7;
									case 36:
										if (this.Text.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) != -1)
										{
											num = 21;
											continue;
										}
										goto IL_6A4;
									case 37:
										if (!string.IsNullOrEmpty(this.ay))
										{
											num = 41;
											continue;
										}
										goto IL_85C;
									case 38:
										text = this.Minimum.ToString("N", this.ar);
										num = 44;
										continue;
									case 39:
										goto IL_777;
									case 40:
										goto IL_74D;
									case 41:
										num = 24;
										continue;
									case 42:
										if (string.IsNullOrEmpty(text.Trim()))
										{
											num = 38;
											continue;
										}
										text = (string)this.Text.Clone();
										text = text.Replace(" ", "");
										num = 14;
										continue;
									case 43:
										num = 47;
										continue;
									case 44:
										goto IL_802;
									case 45:
										if (this.Minimum != this.Maximum)
										{
											num = 5;
											continue;
										}
										goto IL_239;
									case 46:
										switch (valueType)
										{
										case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
											text = text.Replace("(", "");
											text = text.Replace(")", "");
											text = text.Replace(this.ar.NegativeSign, "");
											text = text.Replace(" ", "");
											num = 6;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
											num3 = 0;
											num = 8;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
											textValue = int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
											num = 31;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
											text = text.Replace("(", "");
											text = text.Replace(")", "");
											text = text.Replace(this.ar.NegativeSign, "");
											text = text.Replace(" ", "");
											num = 42;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric:
											num = 11;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.Date:
											textValue = this.Text.Clone();
											num = 30;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.Time:
											textValue = this.Text.Clone();
											num = 50;
											continue;
										case global::custom_controls.CCustomTextBox.valueTypes.DateTime:
											textValue = this.Text.Clone();
											num = 3;
											continue;
										default:
											num = 9;
											continue;
										}
										break;
									case 47:
										if (this.Text.IndexOf(")", global::System.StringComparison.Ordinal) == -1)
										{
											num = 1;
											continue;
										}
										goto IL_4E7;
									case 48:
										text = this.Minimum.ToString("N", this.ar);
										num = 22;
										continue;
									case 49:
										text = this.Minimum.ToString("N", this.ar);
										num = 27;
										continue;
									case 50:
										goto IL_85C;
									case 51:
										goto IL_239;
									case 52:
										goto IL_85C;
									}
									break;
									IL_25C:
									num = 37;
									continue;
									try
									{
										IL_239:
										int num6 = global::System.Convert.ToInt32(this.ConvertFromFormatTextToDec(text));
										textValue = num6;
										goto IL_85C;
									}
									catch (global::System.FormatException)
									{
										result = false;
										goto IL_874;
									}
									goto IL_25C;
									IL_2A7:
									num = 10;
									continue;
									IL_4E7:
									text = text.Replace("(", "");
									text = text.Replace(")", "");
									text = text.Replace(this.ar.NegativeSign, "");
									num5 = 0;
									num = 35;
									continue;
									IL_622:
									textValue = num3;
									num = 26;
									continue;
									IL_6A4:
									num2 = 0;
									num = 32;
									continue;
									try
									{
										IL_684:
										decimal num7 = this.ConvertFromFormatTextToDec(text);
										textValue = num7;
										goto IL_85C;
									}
									catch (global::System.FormatException)
									{
										result = false;
										goto IL_874;
									}
									goto IL_6A4;
									IL_74D:
									num = 2;
									continue;
									IL_777:
									num = 45;
									continue;
									IL_802:
									num = 13;
									continue;
									IL_85C:
									num = 19;
								}
							}
							IL_868:
							return true;
						}
						catch (global::System.Exception)
						{
							result = false;
							break;
						}
						return false;
					}
					return false;
				}
				}
				break;
			}
			IL_874:
			if (true)
			{
			}
			return result;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0002FE44 File Offset: 0x0002E044
		public void SetStandardTextToFormat(string textToFormat)
		{
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.Text = textToFormat;
					num = 12;
					continue;
				case 1:
					IL_AC:
					num = 2;
					continue;
				case 2:
					if (this.az.Equals(textToFormat))
					{
						num = 16;
						continue;
					}
					goto IL_17A;
				case 3:
					goto IL_17A;
				case 4:
					if (!string.IsNullOrEmpty(textToFormat))
					{
						num = 19;
						continue;
					}
					goto IL_260;
				case 5:
					if (!string.IsNullOrEmpty(this.ay))
					{
						num = 21;
						continue;
					}
					goto IL_17A;
				case 6:
					if (this.a0)
					{
						num = 10;
						continue;
					}
					goto IL_17A;
				case 8:
					num = 22;
					continue;
				case 9:
					num = 14;
					continue;
				case 10:
					num = 23;
					continue;
				case 11:
					goto IL_1E8;
				case 12:
					goto IL_151;
				case 13:
					goto IL_22F;
				case 14:
					if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.Decimal)
					{
						num = 11;
						continue;
					}
					goto IL_260;
				case 15:
					num = 5;
					continue;
				case 16:
					textToFormat = this.ay;
					num = 3;
					continue;
				case 17:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)
					{
						num = 9;
						continue;
					}
					goto IL_1E8;
				case 18:
					if (!string.IsNullOrEmpty(this.az))
					{
						num = 15;
						continue;
					}
					goto IL_17A;
				case 19:
					try
					{
						this.a();
						textToFormat = decimal.Parse(textToFormat, this.a9).ToString("N", this.ar);
					}
					catch (global::System.Exception)
					{
					}
					goto IL_260;
				case 20:
					if (!this.Text.Equals(textToFormat))
					{
						num = 0;
						continue;
					}
					return;
				case 21:
					num = 6;
					continue;
				case 22:
					if (this.Text.Equals(textToFormat))
					{
						num = 13;
						continue;
					}
					num = 17;
					continue;
				case 23:
					if (!string.IsNullOrEmpty(textToFormat))
					{
						num = 1;
						continue;
					}
					goto IL_17A;
				}
				if (textToFormat != null)
				{
					if (true)
					{
					}
					num = 8;
					continue;
				}
				break;
				IL_17A:
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					if (false)
					{
					}
					num = 20;
					continue;
				}
				IL_1E8:
				num = 4;
				continue;
				IL_260:
				num = 18;
			}
			return;
			IL_151:
			return;
			IL_22F:;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000300EC File Offset: 0x0002E2EC
		public void FormatTextToStandard(ref string textToStandard)
		{
			int num = 14;
			bool flag;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
					if (true)
					{
					}
					num = 13;
					continue;
				case 2:
					goto IL_212;
				case 3:
					num = 6;
					continue;
				case 4:
					goto IL_234;
				case 5:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerHex)
					{
						num = 2;
						continue;
					}
					goto IL_23E;
				case 6:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Decimal)
					{
						num = 9;
						continue;
					}
					goto IL_23E;
				case 7:
					if (this.am == global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal)
					{
						num = 4;
						continue;
					}
					num = 11;
					continue;
				case 8:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_234;
					default:
						if (false)
						{
						}
						num = 12;
						continue;
					}
					break;
				case 9:
					num = 5;
					continue;
				case 10:
					try
					{
						for (;;)
						{
							this.CommitUserChanges();
							textToStandard = this.Text;
							num = 3;
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.Decimal)
									{
										num = 5;
										continue;
									}
									goto IL_1EE;
								case 1:
									goto IL_1EE;
								case 2:
									num = 0;
									continue;
								case 3:
									if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)
									{
										num = 2;
										continue;
									}
									goto IL_1C4;
								case 4:
									goto IL_1F9;
								case 5:
									goto IL_1C4;
								}
								break;
								IL_1C4:
								textToStandard = this.ConvertFromFormatTextToDec(textToStandard).ToString("N", this.a9);
								num = 1;
								continue;
								IL_1EE:
								num = 4;
							}
						}
						IL_1F9:
						goto IL_236;
					}
					catch (global::System.Exception)
					{
						textToStandard = this.aw.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						flag = true;
						goto IL_236;
					}
					goto IL_212;
				case 11:
					if (!string.IsNullOrEmpty(this.az))
					{
						num = 1;
						continue;
					}
					goto IL_255;
				case 12:
					if (this.ay.Equals(this.Text))
					{
						num = 0;
						continue;
					}
					goto IL_255;
				case 13:
					if (!string.IsNullOrEmpty(this.ay))
					{
						num = 8;
						continue;
					}
					goto IL_255;
				}
				if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)
				{
					num = 3;
					continue;
				}
				goto IL_23E;
				IL_212:
				num = 7;
				continue;
				IL_23E:
				flag = this.at;
				num = 10;
				continue;
				IL_234:
				goto IL_23E;
			}
			IL_E1:
			textToStandard = this.az;
			return;
			IL_236:
			this.at = flag;
			return;
			IL_255:
			textToStandard = this.Text;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00030368 File Offset: 0x0002E568
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (0)
			{
			default:
			{
				int num = 19;
				for (;;)
				{
					global::custom_controls.CCustomTextBox.valueTypes valueType;
					switch (num)
					{
					case 0:
						num = 34;
						continue;
					case 1:
						goto IL_138;
					case 2:
						num = 37;
						continue;
					case 3:
					{
						char c;
						if (this.d(c))
						{
							num = 26;
							continue;
						}
						e.Handled = true;
						num = 6;
						continue;
					}
					case 4:
						if (!e.Handled)
						{
							num = 7;
							continue;
						}
						goto IL_601;
					case 5:
						if (this.bb)
						{
							num = 25;
							continue;
						}
						goto IL_4F4;
					case 6:
						goto IL_248;
					case 7:
						num = 36;
						continue;
					case 8:
						num = 10;
						continue;
					case 9:
						try
						{
							num = 11;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_44E;
								case 1:
								{
									char c;
									char c2;
									if (c == c2)
									{
										num = 7;
										continue;
									}
									break;
								}
								case 2:
									num = 9;
									continue;
								case 3:
									e.Handled = true;
									num = 10;
									continue;
								case 4:
									goto IL_442;
								case 5:
									if (!this.ao)
									{
										num = 2;
										continue;
									}
									num = 1;
									continue;
								case 6:
									goto IL_442;
								case 7:
								{
									bool flag = true;
									num = 4;
									continue;
								}
								case 8:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 6;
										continue;
									}
									char c2 = (char)enumerator.Current;
									num = 5;
									continue;
								}
								case 9:
								{
									char c;
									char c2;
									if (c == c2)
									{
										num = 3;
										continue;
									}
									break;
								}
								case 10:
									goto IL_442;
								}
								IL_3F1:
								num = 8;
								continue;
								goto IL_3F1;
								IL_442:
								num = 0;
							}
							IL_44E:
							goto IL_563;
						}
						finally
						{
							for (;;)
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator;
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 2;
									for (;;)
									{
										switch (num)
										{
										case 0:
											goto IL_4B5;
										case 1:
											disposable.Dispose();
											num = 0;
											continue;
										case 2:
											if (disposable == null)
											{
												goto IL_4B7;
											}
											switch ((1 == 1) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												if (false)
												{
												}
												num = 1;
												continue;
											}
											break;
										}
										break;
									}
								}
							}
							IL_4B5:
							IL_4B7:;
						}
						goto IL_4B8;
						IL_563:
						num = 18;
						continue;
					case 10:
					{
						bool flag;
						if (!flag)
						{
							num = 21;
							continue;
						}
						goto IL_5B1;
					}
					case 11:
						num = 22;
						continue;
					case 12:
					{
						char c = e.KeyChar;
						num = 5;
						continue;
					}
					case 13:
						goto IL_4F4;
					case 14:
						if (!char.IsControl(e.KeyChar))
						{
							num = 12;
							continue;
						}
						goto IL_601;
					case 15:
						goto IL_138;
					case 16:
						if (this.an != null)
						{
							num = 30;
							continue;
						}
						goto IL_5B1;
					case 17:
						goto IL_55E;
					case 18:
						if (this.ao)
						{
							num = 8;
							continue;
						}
						goto IL_5B1;
					case 20:
						if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric)
						{
							num = 42;
							continue;
						}
						goto IL_1E0;
					case 21:
						e.Handled = true;
						num = 24;
						continue;
					case 22:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Decimal)
						{
							num = 23;
							continue;
						}
						goto IL_120;
					case 23:
						num = 41;
						continue;
					case 24:
						goto IL_5B1;
					case 25:
					{
						char c = char.ToUpper(e.KeyChar, global::System.Globalization.CultureInfo.InvariantCulture);
						num = 13;
						continue;
					}
					case 26:
						e.Handled = false;
						num = 17;
						continue;
					case 27:
						goto IL_4B8;
					case 28:
						num = 3;
						continue;
					case 29:
						goto IL_138;
					case 30:
					{
						global::System.Array array = this.an.ToCharArray();
						bool flag = false;
						global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
						num = 9;
						continue;
					}
					case 31:
						if (true)
						{
						}
						num = 35;
						continue;
					case 32:
						if (!e.Handled)
						{
							num = 27;
							continue;
						}
						goto IL_138;
					case 33:
						goto IL_1E0;
					case 34:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal)
						{
							num = 38;
							continue;
						}
						goto IL_120;
					case 35:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)
						{
							num = 11;
							continue;
						}
						goto IL_120;
					case 36:
						if (this.bj)
						{
							num = 28;
							continue;
						}
						goto IL_601;
					case 37:
						goto IL_138;
					case 38:
						num = 20;
						continue;
					case 39:
						goto IL_138;
					case 40:
						switch (valueType)
						{
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
						{
							char c;
							e.Handled = this.c(c);
							num = 29;
							continue;
						}
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
						{
							char c;
							e.Handled = this.c(c);
							num = 1;
							continue;
						}
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
						{
							char c;
							e.Handled = this.b(c);
							num = 15;
							continue;
						}
						case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
						{
							char c;
							e.Handled = this.a(c);
							num = 39;
							continue;
						}
						default:
							num = 2;
							continue;
						}
						break;
					case 41:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerHex)
						{
							num = 0;
							continue;
						}
						goto IL_120;
					case 42:
						goto IL_120;
					}
					if (e.KeyChar == '\r')
					{
						num = 31;
						continue;
					}
					goto IL_1E0;
					IL_120:
					this.OnLeave(e);
					num = 33;
					continue;
					IL_138:
					num = 4;
					continue;
					IL_1E0:
					num = 14;
					continue;
					IL_4B8:
					valueType = this.ValueType;
					num = 40;
					continue;
					IL_4F4:
					this.b();
					num = 16;
					continue;
					IL_5B1:
					num = 32;
				}
				IL_248:
				IL_55E:
				IL_601:
				base.OnKeyPress(e);
				return;
			}
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00030990 File Offset: 0x0002EB90
		protected override void OnLeave(global::System.EventArgs e)
		{
			try
			{
				for (;;)
				{
					this.ba = false;
					int num;
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_6E:
						this.CommitUserChanges();
						base.OnLeave(e);
						num = 3;
						break;
					default:
						if (false)
						{
						}
						num = 0;
						break;
					}
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (!this.at)
							{
								if (true)
								{
								}
								num = 1;
								continue;
							}
							goto IL_6E;
						case 1:
							base.OnLeave(e);
							num = 2;
							continue;
						case 2:
							goto IL_6C;
						case 3:
							goto IL_86;
						}
						break;
					}
				}
				IL_6C:
				IL_86:;
			}
			catch (global::System.Exception)
			{
				throw;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00030A44 File Offset: 0x0002EC44
		public void CommitUserChanges()
		{
			switch (0)
			{
			default:
			{
				int num = 28;
				string text2;
				string text3;
				object obj;
				for (;;)
				{
					string text;
					int num2;
					int num3;
					switch (num)
					{
					case 0:
						num = 18;
						continue;
					case 1:
						this.Text = text;
						num = 26;
						continue;
					case 2:
						num = 3;
						continue;
					case 3:
						if (string.IsNullOrEmpty(this.Text))
						{
							num = 67;
							continue;
						}
						goto IL_7A9;
					case 4:
						text = global::System.Convert.ToString(this.Maximum, 16);
						text = text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 61;
						continue;
					case 5:
						goto IL_3FF;
					case 6:
					{
						global::custom_controls.CCustomTextBox.valueTypes valueType;
						switch (valueType)
						{
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
							goto IL_1C4;
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
							num = 63;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
							num = 10;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
							num = 62;
							continue;
						default:
							num = 44;
							continue;
						}
						break;
					}
					case 7:
						if (text2 != null)
						{
							num = 15;
							continue;
						}
						return;
					case 8:
						goto IL_74C;
					case 9:
						if (this.a0)
						{
							num = 0;
							continue;
						}
						return;
					case 10:
						if (string.IsNullOrEmpty(this.Text))
						{
							num = 56;
							continue;
						}
						goto IL_82A;
					case 11:
						goto IL_696;
					case 12:
						return;
					case 13:
						num = 40;
						continue;
					case 14:
						goto IL_88E;
					case 15:
						goto IL_770;
					case 16:
						if (num2 >= this.MaxLength - text.Length)
						{
							num = 31;
							continue;
						}
						text3 += "0";
						num2++;
						num = 29;
						continue;
					case 17:
						return;
					case 18:
						if (this.az.Equals(this.Text))
						{
							num = 48;
							continue;
						}
						return;
					case 19:
						if (this.GetValidTextValue(ref obj))
						{
							num = 57;
							continue;
						}
						return;
					case 20:
						if (this.GetValidTextValue(ref obj))
						{
							num = 66;
							continue;
						}
						return;
					case 21:
					{
						global::custom_controls.CCustomTextBox.valueTypes valueType2 = this.ValueType;
						num = 64;
						continue;
					}
					case 22:
						goto IL_2E7;
					case 23:
						num = 41;
						continue;
					case 24:
						if (!string.IsNullOrEmpty(this.az))
						{
							num = 65;
							continue;
						}
						return;
					case 25:
						goto IL_4C2;
					case 26:
						goto IL_429;
					case 27:
						if (num3 >= this.MaxLength - this.Text.Length)
						{
							num = 13;
							continue;
						}
						text2 += "0";
						num3++;
						num = 33;
						continue;
					case 29:
						goto IL_335;
					case 30:
						num = 9;
						continue;
					case 31:
						num = 72;
						continue;
					case 32:
						goto IL_2EC;
					case 33:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3FF;
						default:
							if (false)
							{
							}
							goto IL_280;
						}
						break;
					case 34:
						goto IL_82A;
					case 35:
						goto IL_3F3;
					case 36:
						goto IL_775;
					case 37:
						if (text3 != null)
						{
							num = 22;
							continue;
						}
						return;
					case 38:
						goto IL_3F3;
					case 39:
						goto IL_280;
					case 40:
						if (text2 != null)
						{
							num = 49;
							continue;
						}
						return;
					case 41:
						if (this.MaxLength > 0)
						{
							num = 70;
							continue;
						}
						goto IL_775;
					case 42:
						goto IL_4C2;
					case 43:
						if (!this.hasRange)
						{
							num = 8;
							continue;
						}
						goto IL_893;
					case 44:
						return;
					case 45:
						num = 37;
						continue;
					case 46:
						if (!string.IsNullOrEmpty(this.ay))
						{
							num = 30;
							continue;
						}
						return;
					case 47:
					{
						int num4;
						if ((long)num4 > this.Maximum)
						{
							num = 4;
							continue;
						}
						num = 54;
						continue;
					}
					case 48:
						goto IL_490;
					case 49:
						goto IL_6BA;
					case 50:
						num = 7;
						continue;
					case 51:
						this.Text = this.Minimum.ToString("N", this.ar);
						num = 32;
						continue;
					case 52:
						goto IL_7A9;
					case 53:
						return;
					case 54:
					{
						int num4;
						if ((long)num4 >= this.Minimum)
						{
							num = 2;
							continue;
						}
						goto IL_6FB;
					}
					case 55:
						if (this.Text.Length > this.MaxLength)
						{
							num = 23;
							continue;
						}
						goto IL_775;
					case 56:
						this.Text = this.Minimum.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						this.Text = this.Text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
						num = 34;
						continue;
					case 57:
						num = 59;
						continue;
					case 58:
					{
						if (!this.aq)
						{
							num = 21;
							continue;
						}
						global::custom_controls.CCustomTextBox.valueTypes valueType = this.ValueType;
						num = 6;
						continue;
					}
					case 59:
						if (this.hasRange)
						{
							num = 69;
							continue;
						}
						goto IL_5AF;
					case 60:
						goto IL_335;
					case 61:
						goto IL_7A9;
					case 62:
						if (this.hasRange)
						{
							num = 14;
							continue;
						}
						this.Text = this.Minimum.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						this.ar.NumberDecimalDigits = this.DecimalPlaces;
						this.Text = decimal.Parse(this.Text, this.a9).ToString("N", this.ar);
						num = 12;
						continue;
					case 63:
						if (string.IsNullOrEmpty(this.Text))
						{
							num = 51;
							continue;
						}
						goto IL_2EC;
					case 64:
					{
						global::custom_controls.CCustomTextBox.valueTypes valueType2;
						switch (valueType2)
						{
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
							num = 20;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
						{
							text3 = null;
							int num5 = 0;
							num = 42;
							continue;
						}
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
						{
							text = this.Text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
							int num4 = int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
							num = 47;
							continue;
						}
						case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
							num = 19;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric:
							num = 24;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Date:
							goto IL_A2E;
						case global::custom_controls.CCustomTextBox.valueTypes.Time:
							goto IL_190;
						case global::custom_controls.CCustomTextBox.valueTypes.DateTime:
							goto IL_2B6;
						default:
							num = 17;
							continue;
						}
						break;
					}
					case 65:
						num = 46;
						continue;
					case 66:
						num = 43;
						continue;
					case 67:
						goto IL_6FB;
					case 68:
						if (text != this.Text)
						{
							num = 1;
							continue;
						}
						goto IL_429;
					case 69:
						goto IL_916;
					case 70:
						this.Text = this.Text.Substring(0, this.MaxLength);
						num = 36;
						continue;
					case 71:
					{
						int num5;
						if (num5 >= this.MaxLength - this.Text.Length)
						{
							num = 45;
							continue;
						}
						text3 += "0";
						num5++;
						num = 25;
						continue;
					}
					case 72:
						if (text3 != null)
						{
							num = 11;
							continue;
						}
						return;
					}
					if (base.ReadOnly)
					{
						num = 53;
						continue;
					}
					if (true)
					{
					}
					obj = null;
					this.a();
					num = 55;
					continue;
					IL_280:
					num = 27;
					continue;
					IL_2EC:
					text2 = null;
					num3 = 0;
					num = 39;
					continue;
					IL_335:
					num = 16;
					continue;
					IL_3F3:
					num = 5;
					continue;
					IL_3FF:
					int num6;
					if (num6 >= this.MaxLength - this.Text.Length)
					{
						num = 50;
						continue;
					}
					text2 += "0";
					num6++;
					num = 38;
					continue;
					IL_429:
					text3 = null;
					num2 = 0;
					num = 60;
					continue;
					IL_4C2:
					num = 71;
					continue;
					IL_6FB:
					text = global::System.Convert.ToString(this.Minimum, 16);
					text = text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
					num = 52;
					continue;
					IL_775:
					this.f(this.Text);
					num = 58;
					continue;
					IL_7A9:
					num = 68;
					continue;
					IL_82A:
					text2 = null;
					num6 = 0;
					num = 35;
				}
				return;
				IL_190:
				this.Text = this.c(this.Text);
				return;
				IL_1C4:
				this.Text = this.Minimum.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				this.ar.NumberDecimalDigits = 0;
				this.Text = int.Parse(this.Text, global::System.Globalization.CultureInfo.InvariantCulture).ToString("N", this.ar);
				return;
				IL_2B6:
				this.Text = this.b(this.Text);
				return;
				IL_2E7:
				this.Text = this.Text.Insert(0, text3);
				return;
				IL_490:
				this.Text = this.ay;
				return;
				IL_5AF:
				this.Text = ((decimal)obj).ToString("N", this.ar);
				return;
				IL_696:
				this.Text = this.Text.Insert(0, text3);
				return;
				IL_6BA:
				this.Text = this.Text.Insert(0, text2);
				return;
				IL_74C:
				this.Text = ((int)obj).ToString("N", this.ar);
				return;
				IL_770:
				this.Text = this.Text.Insert(0, text2);
				return;
				IL_88E:
				this.Text = ((global::custom_controls.CCustomTextBox.RFRange)this.bh[0]).RfLow.ToString("N", this.ar);
				return;
				IL_893:
				decimal validValue = this.GetValidValue((int)obj);
				this.Text = ((int)validValue).ToString("N", this.ar);
				return;
				IL_916:
				this.Text = this.GetValidValue((decimal)obj).ToString("N", this.ar);
				return;
				IL_A2E:
				this.Text = this.d(this.Text);
				return;
			}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00031520 File Offset: 0x0002F720
		private bool c(char A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					IL_63:
					this.a();
					int num = 0;
					for (;;)
					{
						IL_6B:
						if (true)
						{
						}
						int num2 = 17;
						for (;;)
						{
							string a_;
							string negativeSign;
							switch (num2)
							{
							case 0:
								goto IL_AD;
							case 1:
								return true;
							case 2:
								goto IL_AD;
							case 3:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_6B;
								default:
									if (false)
									{
									}
									num = base.SelectionStart;
									num2 = 0;
									continue;
								}
								break;
							case 4:
								num2 = 18;
								continue;
							case 5:
								if (global::custom_controls.CCustomTextBox.c(num, a_))
								{
									num2 = 1;
									continue;
								}
								return false;
							case 6:
								return true;
							case 7:
								if (this.a(num, a_, A_0))
								{
									num2 = 6;
									continue;
								}
								return false;
							case 8:
								num2 = 7;
								continue;
							case 9:
								return true;
							case 10:
								num2 = 11;
								continue;
							case 11:
								switch (A_0)
								{
								case '(':
								case ')':
									num2 = 12;
									continue;
								default:
									num2 = 15;
									continue;
								}
								break;
							case 12:
								if (this.a(num, a_, A_0))
								{
									num2 = 16;
									continue;
								}
								return false;
							case 13:
								if (A_0 != ' ')
								{
									num2 = 10;
									continue;
								}
								num2 = 5;
								continue;
							case 14:
								if (A_0 == negativeSign[0])
								{
									num2 = 8;
									continue;
								}
								num2 = 13;
								continue;
							case 15:
								num2 = 4;
								continue;
							case 16:
								return true;
							case 17:
								if (string.IsNullOrEmpty(this.SelectedText))
								{
									num2 = 3;
									continue;
								}
								num = this.Text.IndexOf(this.SelectedText, global::System.StringComparison.Ordinal);
								num2 = 2;
								continue;
							case 18:
								if (this.a(num, a_))
								{
									num2 = 9;
									continue;
								}
								return false;
							}
							goto IL_63;
							IL_AD:
							a_ = this.Text.Remove(num, this.SelectedText.Length);
							negativeSign = this.ar.NegativeSign;
							num2 = 14;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00031780 File Offset: 0x0002F980
		private bool b(char A_0)
		{
			for (;;)
			{
				this.a();
				int startIndex = 0;
				int num = 5;
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						return true;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_30;
						default:
							if (true)
							{
							}
							if (false)
							{
							}
							startIndex = base.SelectionStart;
							num = 4;
							continue;
						}
						break;
					case 2:
						if ((long)num2 > this.Maximum)
						{
							num = 0;
							continue;
						}
						return false;
					case 3:
						goto IL_78;
					case 4:
						goto IL_78;
					case 5:
						goto IL_30;
					}
					break;
					IL_30:
					if (string.IsNullOrEmpty(this.SelectedText))
					{
						num = 1;
						continue;
					}
					startIndex = this.Text.IndexOf(this.SelectedText, global::System.StringComparison.Ordinal);
					num = 3;
					continue;
					IL_78:
					string text = this.Text.Remove(startIndex, this.SelectedText.Length);
					text = text.Insert(startIndex, A_0.ToString());
					num2 = int.Parse(text, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num = 2;
				}
			}
			return true;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0003189C File Offset: 0x0002FA9C
		private bool a(char A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					if (true)
					{
					}
					this.a();
					string numberDecimalSeparator = this.ar.NumberDecimalSeparator;
					int num = 0;
					int num2 = 8;
					for (;;)
					{
						string text;
						string negativeSign;
						switch (num2)
						{
						case 0:
							if (global::custom_controls.CCustomTextBox.c(num, text))
							{
								num2 = 16;
								continue;
							}
							return false;
						case 1:
							if (A_0 == negativeSign[0])
							{
								num2 = 10;
								continue;
							}
							num2 = 7;
							continue;
						case 2:
							num2 = 9;
							continue;
						case 3:
							num2 = 11;
							continue;
						case 4:
							return true;
						case 5:
							num = base.SelectionStart;
							num2 = 12;
							continue;
						case 6:
							num2 = 3;
							continue;
						case 7:
							if (A_0 != ' ')
							{
								num2 = 15;
								continue;
							}
							num2 = 0;
							continue;
						case 8:
							if (string.IsNullOrEmpty(this.SelectedText))
							{
								num2 = 5;
								continue;
							}
							num = this.Text.IndexOf(this.SelectedText, global::System.StringComparison.Ordinal);
							num2 = 20;
							continue;
						case 9:
							if (num > text.IndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal))
							{
								num2 = 13;
								continue;
							}
							return false;
						case 10:
							num2 = 23;
							continue;
						case 11:
							if (A_0 == char.Parse(numberDecimalSeparator))
							{
								num2 = 28;
								continue;
							}
							num2 = 25;
							continue;
						case 12:
							goto IL_2B4;
						case 13:
						{
							string text2 = text;
							text2 = text2.Replace("(", "");
							text2 = text2.Replace(")", "");
							text2 = text2.Replace(this.ar.NegativeSign, "");
							text2 = text2.Replace(" ", "");
							num2 = 26;
							continue;
						}
						case 14:
							return true;
						case 15:
							num2 = 21;
							continue;
						case 16:
							return true;
						case 17:
							return true;
						case 18:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2B4;
							default:
								if (false)
								{
								}
								if (this.a(num, text, A_0))
								{
									num2 = 19;
									continue;
								}
								return false;
							}
							break;
						case 19:
							return true;
						case 20:
							goto IL_10F;
						case 21:
							switch (A_0)
							{
							case '(':
							case ')':
								num2 = 18;
								continue;
							default:
								num2 = 6;
								continue;
							}
							break;
						case 22:
							if (text.IndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal) != -1)
							{
								num2 = 2;
								continue;
							}
							return false;
						case 23:
							if (this.a(num, text, A_0))
							{
								num2 = 17;
								continue;
							}
							return false;
						case 24:
							if (this.b(num, text))
							{
								num2 = 4;
								continue;
							}
							return false;
						case 25:
							if (this.a(num, text))
							{
								num2 = 27;
								continue;
							}
							num2 = 22;
							continue;
						case 26:
						{
							string text2;
							if (text2.Length - text2.IndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal) - 1 >= this.ap)
							{
								num2 = 14;
								continue;
							}
							return false;
						}
						case 27:
							return true;
						case 28:
							num2 = 24;
							continue;
						}
						break;
						IL_10F:
						text = this.Text.Remove(num, this.SelectedText.Length);
						negativeSign = this.ar.NegativeSign;
						num2 = 1;
						continue;
						IL_2B4:
						goto IL_10F;
					}
				}
				return true;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00031C78 File Offset: 0x0002FE78
		private void f(string A_0)
		{
			switch (0)
			{
			default:
				for (;;)
				{
					this.a();
					string numberDecimalSeparator = this.ar.NumberDecimalSeparator;
					this.aq = false;
					this.b();
					int num = 26;
					for (;;)
					{
						global::custom_controls.CCustomTextBox.valueTypes valueType;
						switch (num)
						{
						case 0:
							this.aq = true;
							num = 22;
							continue;
						case 1:
							if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric)
							{
								num = 12;
								continue;
							}
							goto IL_1BD;
						case 2:
							num = 18;
							continue;
						case 3:
							if (string.IsNullOrEmpty(A_0))
							{
								num = 10;
								continue;
							}
							num = 29;
							continue;
						case 4:
							this.aq = true;
							num = 20;
							continue;
						case 5:
							if (A_0.IndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal) != A_0.LastIndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal))
							{
								num = 0;
								continue;
							}
							return;
						case 6:
							if (this.e(A_0))
							{
								num = 15;
								continue;
							}
							goto IL_51B;
						case 7:
							if (string.IsNullOrEmpty(A_0))
							{
								num = 13;
								continue;
							}
							return;
						case 8:
							if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Time)
							{
								num = 21;
								continue;
							}
							goto IL_1BD;
						case 9:
							return;
						case 10:
							goto IL_13D;
						case 11:
							if (this.e(A_0))
							{
								num = 24;
								continue;
							}
							goto IL_21F;
						case 12:
							goto IL_487;
						case 13:
							goto IL_185;
						case 14:
							goto IL_2B7;
						case 15:
							num = 7;
							continue;
						case 16:
							if (this.e(A_0))
							{
								num = 2;
								continue;
							}
							goto IL_603;
						case 17:
						{
							global::System.Array array = A_0.ToCharArray();
							global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
							num = 32;
							continue;
						}
						case 18:
							if (string.IsNullOrEmpty(A_0))
							{
								num = 36;
								continue;
							}
							return;
						case 19:
							return;
						case 20:
							return;
						case 21:
							num = 25;
							continue;
						case 22:
							goto IL_23A;
						case 23:
							num = 8;
							continue;
						case 24:
							num = 3;
							continue;
						case 25:
							if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.DateTime)
							{
								num = 34;
								continue;
							}
							goto IL_1BD;
						case 26:
							if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric)
							{
								num = 14;
								continue;
							}
							goto IL_561;
						case 27:
							if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Date)
							{
								num = 23;
								continue;
							}
							goto IL_1BD;
						case 28:
							if (string.IsNullOrEmpty(A_0))
							{
								num = 19;
								continue;
							}
							goto IL_561;
						case 29:
							if (A_0.IndexOf(numberDecimalSeparator, global::System.StringComparison.Ordinal) != -1)
							{
								if (true)
								{
								}
								num = 31;
								continue;
							}
							return;
						case 30:
						{
							string text;
							if (string.IsNullOrEmpty(text))
							{
								num = 4;
								continue;
							}
							goto IL_1BD;
						}
						case 31:
							num = 5;
							continue;
						case 32:
							try
							{
								num = 11;
								for (;;)
								{
									switch (num)
									{
									case 0:
										goto IL_3BB;
									case 1:
										if (this.an != null)
										{
											num = 13;
											continue;
										}
										break;
									case 2:
										num = 5;
										continue;
									case 3:
										if (this.ao)
										{
											num = 2;
											continue;
										}
										num = 1;
										continue;
									case 4:
										num = 12;
										continue;
									case 5:
									{
										char c;
										if (this.an.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) == -1)
										{
											num = 8;
											continue;
										}
										break;
									}
									case 6:
									{
										char c;
										if (this.an.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) != -1)
										{
											num = 10;
											continue;
										}
										break;
									}
									case 7:
										goto IL_428;
									case 8:
										this.aq = true;
										num = 0;
										continue;
									case 9:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = 4;
											continue;
										}
										char c = (char)enumerator.Current;
										num = 3;
										continue;
									}
									case 10:
										this.aq = true;
										num = 7;
										continue;
									case 12:
										goto IL_439;
									case 13:
										num = 6;
										continue;
									}
									IL_3C0:
									num = 9;
									continue;
									goto IL_3C0;
								}
								IL_3BB:
								IL_428:
								return;
								IL_439:
								goto IL_1F9;
							}
							finally
							{
								for (;;)
								{
									global::System.Collections.IEnumerator enumerator;
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									num = 1;
									for (;;)
									{
										switch (num)
										{
										case 0:
											disposable.Dispose();
											num = 2;
											continue;
										case 1:
											if (disposable != null)
											{
												num = 0;
												continue;
											}
											goto IL_486;
										case 2:
											goto IL_484;
										}
										break;
									}
								}
								IL_484:
								IL_486:;
							}
							goto IL_487;
						case 33:
							if (A_0 != null)
							{
								num = 17;
								continue;
							}
							goto IL_1F9;
						case 34:
						{
							string text = A_0.Replace("(", string.Empty);
							text = text.Replace(")", string.Empty);
							text = text.Replace(this.ar.NegativeSign, string.Empty);
							text = text.Replace(numberDecimalSeparator, string.Empty);
							num = 30;
							continue;
						}
						case 35:
							switch (valueType)
							{
							case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
								num = 16;
								continue;
							case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
								num = 6;
								continue;
							case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
								return;
							case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2B7;
								default:
									if (false)
									{
									}
									num = 11;
									continue;
								}
								break;
							default:
								num = 9;
								continue;
							}
							break;
						case 36:
							goto IL_55C;
						}
						break;
						IL_1BD:
						valueType = this.ValueType;
						num = 35;
						continue;
						IL_1F9:
						num = 1;
						continue;
						IL_2B7:
						num = 28;
						continue;
						IL_487:
						num = 27;
						continue;
						IL_561:
						num = 33;
					}
				}
				IL_13D:
				goto IL_21F;
				IL_185:
				goto IL_51B;
				IL_21F:
				this.aq = true;
				return;
				IL_23A:
				return;
				IL_51B:
				this.aq = true;
				return;
				IL_55C:
				IL_603:
				this.aq = true;
				return;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000322AC File Offset: 0x000304AC
		private void b()
		{
			for (;;)
			{
				this.a();
				global::custom_controls.CCustomTextBox.valueTypes valueType = this.ValueType;
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_D1;
					case 1:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Time)
						{
							if (true)
							{
							}
							num = 28;
							continue;
						}
						return;
					case 2:
						this.an = this.an + this.@as.AMDesignator + this.@as.PMDesignator;
						this.MaxLength += this.@as.AMDesignator.Length + this.@as.PMDesignator.Length + 1;
						num = 26;
						continue;
					case 3:
						switch (valueType)
						{
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerDec:
							this.ao = true;
							this.an = "0123456789";
							num = 17;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal:
							goto IL_1BC;
						case global::custom_controls.CCustomTextBox.valueTypes.IntegerHex:
							this.ao = true;
							num = 5;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Decimal:
							this.ao = true;
							this.an = "0123456789";
							this.an = this.an.Insert(0, this.ar.NumberDecimalSeparator);
							num = 10;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric:
							num = 20;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Date:
							this.ao = true;
							this.an = "0123456789" + this.@as.DateSeparator;
							this.MaxLength = 8 + 2 * this.@as.DateSeparator.Length;
							num = 15;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.Time:
							this.ao = true;
							this.an = "0123456789" + this.@as.TimeSeparator;
							this.MaxLength = 4 + this.@as.TimeSeparator.Length;
							num = 7;
							continue;
						case global::custom_controls.CCustomTextBox.valueTypes.DateTime:
							this.ao = true;
							this.an = "0123456789" + this.@as.DateSeparator + this.@as.TimeSeparator + " ";
							this.MaxLength = 13 + 2 * this.@as.DateSeparator.Length + this.@as.TimeSeparator.Length;
							num = 9;
							continue;
						default:
							num = 14;
							continue;
						}
						break;
					case 4:
						goto IL_358;
					case 5:
						if (this.aj)
						{
							num = 6;
							continue;
						}
						this.an = "0123456789abcdeABCDE";
						num = 29;
						continue;
					case 6:
						this.an = "0123456789abcdefABCDEF";
						num = 22;
						continue;
					case 7:
						if (this.@as.ShortTimePattern.IndexOf("h", global::System.StringComparison.Ordinal) != -1)
						{
							num = 21;
							continue;
						}
						goto IL_D1;
					case 8:
						this.an = this.an.Insert(0, "()");
						this.an = this.an.Insert(0, this.ar.NegativeSign);
						this.an = this.an.Insert(0, " ");
						num = 4;
						continue;
					case 9:
						if (this.@as.ShortTimePattern.IndexOf("h", global::System.StringComparison.Ordinal) != -1)
						{
							num = 2;
							continue;
						}
						goto IL_D1;
					case 10:
						goto IL_D1;
					case 11:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.DateTime)
						{
							num = 8;
							continue;
						}
						return;
					case 12:
						if (this.IsNegativeNeeded)
						{
							num = 23;
							continue;
						}
						return;
					case 13:
						goto IL_D1;
					case 14:
						num = 0;
						continue;
					case 15:
						goto IL_D1;
					case 16:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Date)
						{
							num = 19;
							continue;
						}
						return;
					case 17:
						goto IL_D1;
					case 18:
						goto IL_D1;
					case 19:
						num = 1;
						continue;
					case 20:
						if (this.an == null)
						{
							num = 25;
							continue;
						}
						goto IL_D1;
					case 21:
						this.an = this.an + this.@as.AMDesignator + this.@as.PMDesignator;
						this.MaxLength += this.@as.AMDesignator.Length + this.@as.PMDesignator.Length + 1;
						num = 18;
						continue;
					case 22:
						goto IL_D1;
					case 23:
						num = 24;
						continue;
					case 24:
						if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric)
						{
							num = 27;
							continue;
						}
						return;
					case 25:
						return;
					case 26:
						goto IL_D1;
					case 27:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BC;
						default:
							if (false)
							{
							}
							num = 16;
							continue;
						}
						break;
					case 28:
						num = 11;
						continue;
					case 29:
						goto IL_D1;
					}
					break;
					IL_D1:
					num = 12;
					continue;
					IL_1BC:
					this.ao = true;
					this.an = "01234567";
					num = 13;
				}
			}
			IL_358:;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00032810 File Offset: 0x00030A10
		private bool e(string A_0)
		{
			for (;;)
			{
				this.a();
				int num = 11;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 1;
						continue;
					case 1:
						if (true)
						{
						}
						if (A_0.IndexOf("(", global::System.StringComparison.Ordinal) != A_0.LastIndexOf("(", global::System.StringComparison.Ordinal))
						{
							num = 8;
							continue;
						}
						goto IL_14B;
					case 2:
						num = 6;
						continue;
					case 3:
						if (A_0.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) != -1)
						{
							num = 9;
							continue;
						}
						return true;
					case 4:
						return false;
					case 5:
						if (A_0.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
						{
							num = 2;
							continue;
						}
						goto IL_62;
					case 6:
						if (A_0.IndexOf(")", global::System.StringComparison.Ordinal) != A_0.LastIndexOf(")", global::System.StringComparison.Ordinal))
						{
							num = 4;
							continue;
						}
						goto IL_62;
					case 7:
						return false;
					case 8:
						return false;
					case 9:
						num = 10;
						continue;
					case 10:
						if (A_0.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) != A_0.LastIndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal))
						{
							num = 7;
							continue;
						}
						return true;
					case 11:
						if (A_0.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
						{
							num = 0;
							continue;
						}
						goto IL_14B;
					}
					break;
					IL_62:
					num = 3;
					continue;
					IL_14B:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						if (false)
						{
						}
						num = 5;
						break;
					}
				}
			}
			return false;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000329BC File Offset: 0x00030BBC
		public global::System.Globalization.NumberFormatInfo NumberFormatInfo
		{
			get
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
				this.a();
				return this.ar;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00032A04 File Offset: 0x00030C04
		private void a()
		{
			this.@as = (global::System.Globalization.DateTimeFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
			this.ar = (global::System.Globalization.NumberFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.Clone();
			this.ar.NumberGroupSeparator = "";
			this.a9 = (global::System.Globalization.NumberFormatInfo)global::System.Globalization.NumberFormatInfo.InvariantInfo.Clone();
			this.a9.NumberGroupSeparator = "";
			if (this.am == global::custom_controls.CCustomTextBox.valueTypes.Decimal)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					break;
				}
				this.ar.NumberDecimalDigits = this.ap;
				this.a9.NumberDecimalDigits = this.ap;
				return;
			}
			if (true)
			{
			}
			this.ar.NumberDecimalDigits = 0;
			this.a9.NumberDecimalDigits = 0;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00032AF8 File Offset: 0x00030CF8
		private void i(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			default:
			{
				int num = 16;
				for (;;)
				{
					int selectionStart;
					string text;
					switch (num)
					{
					case 0:
						goto IL_307;
					case 1:
						num = 4;
						continue;
					case 2:
						goto IL_42C;
					case 3:
						if (!string.IsNullOrEmpty(this.Text))
						{
							num = 20;
							continue;
						}
						goto IL_324;
					case 4:
						if (!string.IsNullOrEmpty(this.ay))
						{
							num = 19;
							continue;
						}
						goto IL_99;
					case 5:
						if (base.ReadOnly)
						{
							num = 0;
							continue;
						}
						this.b();
						selectionStart = base.SelectionStart;
						num = 9;
						continue;
					case 6:
						num = 15;
						continue;
					case 7:
						try
						{
							num = 5;
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_296;
								case 1:
								{
									char c;
									if (this.an.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) == -1)
									{
										num = 7;
										continue;
									}
									break;
								}
								case 2:
								{
									char c;
									text = text.Replace(c.ToString(), string.Empty);
									num = 6;
									continue;
								}
								case 3:
									if (this.ao)
									{
										num = 4;
										continue;
									}
									num = 8;
									continue;
								case 4:
									num = 1;
									continue;
								case 7:
								{
									char c;
									text = text.Replace(c.ToString(), string.Empty);
									num = 11;
									continue;
								}
								case 8:
									if (this.an != null)
									{
										num = 12;
										continue;
									}
									break;
								case 9:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = 10;
										continue;
									}
									char c = (char)enumerator.Current;
									num = 3;
									continue;
								}
								case 10:
									num = 0;
									continue;
								case 12:
									num = 13;
									continue;
								case 13:
								{
									char c;
									if (this.an.IndexOf(char.ToString(c), global::System.StringComparison.Ordinal) != -1)
									{
										num = 2;
										continue;
									}
									break;
								}
								}
								IL_199:
								num = 9;
								continue;
								goto IL_199;
							}
							IL_296:
							goto IL_324;
						}
						finally
						{
							for (;;)
							{
								global::System.Collections.IEnumerator enumerator;
								global::System.IDisposable disposable = enumerator as global::System.IDisposable;
								num = 0;
								for (;;)
								{
									switch (num)
									{
									case 0:
										if (disposable != null)
										{
											num = 2;
											continue;
										}
										goto IL_2E3;
									case 1:
										goto IL_2E1;
									case 2:
										disposable.Dispose();
										num = 1;
										continue;
									}
									break;
								}
							}
							IL_2E1:
							IL_2E3:;
						}
						goto IL_2E4;
					case 8:
						return;
					case 9:
						if (!this.bb)
						{
							num = 6;
							continue;
						}
						goto IL_42C;
					case 10:
						if (!string.IsNullOrEmpty(this.az))
						{
							num = 1;
							continue;
						}
						goto IL_99;
					case 11:
						goto IL_2E4;
					case 12:
						num = 14;
						continue;
					case 13:
						goto IL_351;
					case 14:
						if (!this.bc)
						{
							num = 11;
							continue;
						}
						goto IL_11C;
					case 15:
						if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.IntegerHex)
						{
							num = 2;
							continue;
						}
						goto IL_351;
					case 17:
						text = this.Text;
						num = 18;
						continue;
					case 18:
						goto IL_324;
					case 19:
						num = 21;
						continue;
					case 20:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E4;
						default:
						{
							if (false)
							{
							}
							text = this.Text;
							global::System.Array array = text.ToCharArray();
							global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
							num = 7;
							continue;
						}
						}
						break;
					case 21:
						if (this.ay.Equals(this.Text))
						{
							num = 17;
							continue;
						}
						goto IL_99;
					}
					if (true)
					{
					}
					if (!this.ax)
					{
						num = 12;
						continue;
					}
					return;
					IL_99:
					num = 3;
					continue;
					IL_2E4:
					num = 5;
					continue;
					IL_324:
					this.Text = text;
					base.SelectionStart = selectionStart;
					this.at = true;
					this.ba = true;
					num = 8;
					continue;
					IL_351:
					text = this.Text;
					num = 10;
					continue;
					IL_42C:
					this.Text = this.Text.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
					num = 13;
				}
				IL_11C:
				this.at = false;
				return;
				IL_307:
				goto IL_11C;
			}
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00032FA4 File Offset: 0x000311A4
		private bool a(int A_0, string A_1, char A_2)
		{
			for (;;)
			{
				IL_74:
				int num;
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_262:
					num = 11;
					break;
				default:
					if (false)
					{
					}
					num = 5;
					break;
				}
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 22;
						continue;
					case 1:
						if (A_0 != A_1.Length)
						{
							num = 17;
							continue;
						}
						return false;
					case 2:
						if (A_1.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) != -1)
						{
							num = 26;
							continue;
						}
						num = 6;
						continue;
					case 3:
						num = 14;
						continue;
					case 4:
						if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) == -1)
						{
							num = 8;
							continue;
						}
						return true;
					case 5:
						switch (A_2)
						{
						case '(':
							num = 23;
							continue;
						case ')':
							num = 25;
							continue;
						default:
							num = 20;
							continue;
						}
						break;
					case 6:
						if (A_0 != A_1.Length)
						{
							num = 19;
							continue;
						}
						return false;
					case 7:
						num = 1;
						continue;
					case 8:
						if (true)
						{
						}
						num = 2;
						continue;
					case 9:
						goto IL_28A;
					case 10:
						num = 15;
						continue;
					case 11:
						if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
						{
							num = 9;
							continue;
						}
						num = 16;
						continue;
					case 12:
						goto IL_137;
					case 13:
						num = 4;
						continue;
					case 14:
						if (A_1.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) == -1)
						{
							num = 0;
							continue;
						}
						return true;
					case 15:
						if (A_1.IndexOf(this.ar.NegativeSign, global::System.StringComparison.Ordinal) == -1)
						{
							num = 24;
							continue;
						}
						return true;
					case 16:
						if (A_0 != 0)
						{
							num = 7;
							continue;
						}
						return false;
					case 17:
						return true;
					case 18:
						goto IL_E3;
					case 19:
						return true;
					case 20:
						num = 10;
						continue;
					case 21:
						if (A_1.IndexOf("(", global::System.StringComparison.Ordinal) == -1)
						{
							num = 18;
							continue;
						}
						return true;
					case 22:
						if (A_1.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
						{
							num = 12;
							continue;
						}
						return false;
					case 23:
						if (A_0 == 0)
						{
							num = 3;
							continue;
						}
						return true;
					case 24:
						num = 21;
						continue;
					case 25:
						if (A_0 != 0)
						{
							num = 13;
							continue;
						}
						return true;
					case 26:
						goto IL_2C7;
					}
					goto IL_74;
				}
				IL_E3:
				goto IL_262;
			}
			return true;
			IL_137:
			return true;
			IL_28A:
			return true;
			IL_2C7:
			return true;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00033280 File Offset: 0x00031480
		private static bool c(int A_0, string A_1)
		{
			int num = 3;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_5B;
				case 1:
					goto IL_AA;
				case 2:
					return true;
				case 3:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						if (false)
						{
						}
						break;
					}
					break;
				case 4:
					if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
					{
						num = 1;
						continue;
					}
					return false;
				case 5:
					if (A_0 >= A_1.IndexOf(")", global::System.StringComparison.Ordinal) + 1)
					{
						num = 2;
						continue;
					}
					return false;
				}
				if (A_1.IndexOf(" ", global::System.StringComparison.Ordinal) != -1)
				{
					num = 0;
					continue;
				}
				num = 4;
				continue;
				IL_AA:
				num = 5;
			}
			IL_5B:
			if (true)
			{
			}
			return true;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00033348 File Offset: 0x00031548
		private bool b(int A_0, string A_1)
		{
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
					if (A_0 == 0)
					{
						num = 5;
						continue;
					}
					goto IL_90;
				case 1:
					num = 8;
					continue;
				case 2:
					if (A_0 > A_1.IndexOf(")", global::System.StringComparison.Ordinal))
					{
						num = 4;
						continue;
					}
					return false;
				case 3:
					goto IL_14D;
				case 4:
					return true;
				case 5:
					return true;
				case 6:
					goto IL_DE;
				case 8:
					if (this.DecimalPlaces == 0)
					{
						num = 6;
						continue;
					}
					num = 11;
					continue;
				case 9:
					if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
					{
						num = 10;
						continue;
					}
					return false;
				case 10:
					num = 2;
					continue;
				case 11:
					if (A_1.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
					{
						num = 3;
						continue;
					}
					goto IL_90;
				}
				if (true)
				{
				}
				if (A_1.IndexOf(this.ar.NumberDecimalSeparator, global::System.StringComparison.Ordinal) != -1)
				{
					break;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14D;
				default:
					if (false)
					{
					}
					num = 1;
					continue;
				}
				IL_90:
				num = 9;
				continue;
				IL_14D:
				num = 0;
			}
			return true;
			IL_DE:
			return true;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000334A8 File Offset: 0x000316A8
		private bool a(int A_0, string A_1)
		{
			int num = 5;
			for (;;)
			{
				switch (num)
				{
				case 0:
					return true;
				case 1:
					return true;
				case 2:
					num = 9;
					continue;
				case 3:
				{
					string text;
					if (text.Length - text.IndexOf(this.ar.NumberDecimalSeparator, global::System.StringComparison.Ordinal) - 1 >= this.ap)
					{
						num = 0;
						continue;
					}
					return false;
				}
				case 4:
					num = 11;
					continue;
				case 6:
					if (A_1.IndexOf("(", global::System.StringComparison.Ordinal) != -1)
					{
						num = 13;
						continue;
					}
					goto IL_163;
				case 7:
				{
					string text = A_1;
					text = text.Replace("(", "");
					text = text.Replace(")", "");
					text = text.Replace(this.ar.NegativeSign, "");
					text = text.Replace(" ", "");
					num = 3;
					continue;
				}
				case 8:
					return true;
				case 9:
					if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) + 1 == A_0)
					{
						if (true)
						{
						}
						num = 8;
						continue;
					}
					goto IL_1D2;
				case 10:
					if (A_0 == 0)
					{
						num = 1;
						continue;
					}
					goto IL_163;
				case 11:
					if (A_0 > A_1.IndexOf(this.ar.NumberDecimalSeparator, global::System.StringComparison.Ordinal))
					{
						num = 7;
						continue;
					}
					return false;
				case 12:
					if (A_1.IndexOf(this.ar.NumberDecimalSeparator, global::System.StringComparison.Ordinal) != -1)
					{
						num = 4;
						continue;
					}
					return false;
				case 13:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						if (false)
						{
						}
						num = 10;
						continue;
					}
					break;
				}
				if (A_1.IndexOf(")", global::System.StringComparison.Ordinal) != -1)
				{
					num = 2;
					continue;
				}
				goto IL_1D2;
				IL_163:
				num = 12;
				continue;
				IL_1D2:
				num = 6;
			}
			return true;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000336B4 File Offset: 0x000318B4
		private string d(string A_0)
		{
			switch (0)
			{
			default:
			{
				int num4;
				int num5;
				int num6;
				for (;;)
				{
					this.@as = (global::System.Globalization.DateTimeFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
					global::System.DateTime now = global::System.DateTime.Now;
					string text = now.Year.ToString("0000", global::System.Globalization.CultureInfo.InvariantCulture);
					string value = now.Month.ToString("00", global::System.Globalization.CultureInfo.InvariantCulture);
					string value2 = now.Day.ToString("00", global::System.Globalization.CultureInfo.InvariantCulture);
					char[] separator = this.@as.DateSeparator.ToCharArray();
					string[] array = A_0.Split(separator);
					bool flag = true;
					int num = 30;
					for (;;)
					{
						int num2;
						string text2;
						int num7;
						switch (num)
						{
						case 0:
							goto IL_43F;
						case 1:
							goto IL_48A;
						case 2:
						{
							string[] array2;
							if (array2[num2].IndexOf("y", global::System.StringComparison.Ordinal) != -1)
							{
								num = 18;
								continue;
							}
							goto IL_3F8;
						}
						case 3:
							goto IL_48A;
						case 4:
							goto IL_528;
						case 5:
						{
							int num3;
							if (array[num3].Length != 0)
							{
								num = 29;
								continue;
							}
							goto IL_1FA;
						}
						case 6:
							value = array[num2];
							num = 4;
							continue;
						case 7:
							goto IL_315;
						case 8:
							if (text.Length < text2.Length)
							{
								num = 33;
								continue;
							}
							goto IL_20E;
						case 9:
							value2 = array[num2];
							num = 41;
							continue;
						case 10:
						{
							int num3;
							if (array[num3].Length > 4)
							{
								num = 20;
								continue;
							}
							num3++;
							num = 27;
							continue;
						}
						case 11:
							goto IL_1D0;
						case 12:
							goto IL_3BD;
						case 13:
							if (flag)
							{
								num = 38;
								continue;
							}
							goto IL_43F;
						case 14:
							goto IL_20E;
						case 15:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_287;
							default:
								if (false)
								{
								}
								num4 = now.Day;
								num = 24;
								continue;
							}
							break;
						case 16:
							num5 = now.Month;
							num = 11;
							continue;
						case 17:
							if (num6 == 0)
							{
								num = 21;
								continue;
							}
							goto IL_3BD;
						case 18:
							text = array[num2];
							num = 40;
							continue;
						case 19:
							if (num2 >= 3)
							{
								num = 0;
								continue;
							}
							num = 2;
							continue;
						case 20:
							goto IL_1FA;
						case 21:
							num6 = now.Year;
							num = 12;
							continue;
						case 22:
							num4 = global::System.DateTime.DaysInMonth(num6, num5);
							num = 42;
							continue;
						case 23:
							if (num4 > global::System.DateTime.DaysInMonth(num6, num5))
							{
								num = 22;
								continue;
							}
							goto IL_60C;
						case 24:
							goto IL_5E2;
						case 25:
							num = 1;
							continue;
						case 26:
							num5 = num7;
							num = 34;
							continue;
						case 27:
							goto IL_315;
						case 28:
						{
							int num3 = 0;
							num = 7;
							continue;
						}
						case 29:
							num = 10;
							continue;
						case 30:
							if (array.Length == 3)
							{
								num = 28;
								continue;
							}
							flag = false;
							num = 3;
							continue;
						case 31:
							if (num5 == 0)
							{
								num = 16;
								continue;
							}
							goto IL_1D0;
						case 32:
						{
							int num3;
							if (num3 >= 3)
							{
								num = 25;
								continue;
							}
							num = 5;
							continue;
						}
						case 33:
							text = text2.Substring(0, text2.Length - text.Length) + text;
							num = 14;
							continue;
						case 34:
							goto IL_2A0;
						case 35:
						{
							string[] array2;
							if (array2[num2].IndexOf("m", global::System.StringComparison.Ordinal) != -1)
							{
								num = 6;
								continue;
							}
							goto IL_528;
						}
						case 36:
							if (num5 > num7)
							{
								num = 26;
								continue;
							}
							goto IL_2A0;
						case 37:
							goto IL_5BD;
						case 38:
						{
							string text3 = this.@as.ShortDatePattern;
							text3 = text3.Replace(this.@as.DateSeparator, "/");
							text3 = text3.ToLowerInvariant();
							char[] separator2 = "/".ToCharArray();
							string[] array2 = text3.Split(separator2);
							num2 = 0;
							num = 45;
							continue;
						}
						case 39:
							goto IL_48A;
						case 40:
							goto IL_3F8;
						case 41:
							goto IL_287;
						case 42:
							goto IL_2E8;
						case 43:
						{
							if (true)
							{
							}
							string[] array2;
							if (array2[num2].IndexOf("d", global::System.StringComparison.Ordinal) != -1)
							{
								num = 9;
								continue;
							}
							goto IL_1A8;
						}
						case 44:
							if (num4 == 0)
							{
								num = 15;
								continue;
							}
							goto IL_5E2;
						case 45:
							goto IL_5BD;
						}
						break;
						IL_1A8:
						num2++;
						num = 37;
						continue;
						IL_287:
						goto IL_1A8;
						IL_1D0:
						num7 = 12;
						num = 36;
						continue;
						IL_1FA:
						flag = false;
						num = 39;
						continue;
						IL_20E:
						num6 = global::System.Convert.ToInt32(text, global::System.Globalization.CultureInfo.InvariantCulture);
						num = 17;
						continue;
						IL_2A0:
						num4 = global::System.Convert.ToInt32(value2, global::System.Globalization.CultureInfo.InvariantCulture);
						num = 44;
						continue;
						IL_315:
						num = 32;
						continue;
						IL_3BD:
						num5 = global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
						num = 31;
						continue;
						IL_3F8:
						num = 35;
						continue;
						IL_43F:
						text2 = now.Year.ToString("0000", global::System.Globalization.CultureInfo.InvariantCulture);
						num = 8;
						continue;
						IL_48A:
						num = 13;
						continue;
						IL_528:
						num = 43;
						continue;
						IL_5BD:
						num = 19;
						continue;
						IL_5E2:
						num = 23;
					}
				}
				IL_2E8:
				IL_60C:
				global::System.DateTime dateTime = new global::System.DateTime(num6, num5, num4, 0, 0, 0, 0);
				return dateTime.ToShortDateString();
			}
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00033CE8 File Offset: 0x00031EE8
		private string c(string A_0)
		{
			switch (0)
			{
			default:
			{
				global::System.DateTime now;
				int num2;
				int num5;
				for (;;)
				{
					this.@as = (global::System.Globalization.DateTimeFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
					now = global::System.DateTime.Now;
					string value = now.Hour.ToString("00", global::System.Globalization.CultureInfo.InvariantCulture);
					string value2 = now.Minute.ToString("00", global::System.Globalization.CultureInfo.InvariantCulture);
					string text = string.Empty;
					int num = 44;
					for (;;)
					{
						string[] array;
						bool flag;
						int num4;
						int num6;
						int num7;
						string text2;
						switch (num)
						{
						case 0:
							goto IL_5C8;
						case 1:
						{
							int num3;
							num2 += num3;
							num = 16;
							continue;
						}
						case 2:
							goto IL_4D1;
						case 3:
							goto IL_5B1;
						case 4:
						{
							int num3;
							if (num2 > num3)
							{
								num = 47;
								continue;
							}
							goto IL_409;
						}
						case 5:
							if (text.Equals(this.@as.PMDesignator))
							{
								num = 1;
								continue;
							}
							num = 20;
							continue;
						case 6:
							if (array.Length == 2)
							{
								num = 26;
								continue;
							}
							flag = false;
							num = 17;
							continue;
						case 7:
							goto IL_4D1;
						case 8:
						{
							string[] array2;
							if (array2[num4].IndexOf("m", global::System.StringComparison.Ordinal) != -1)
							{
								num = 43;
								continue;
							}
							goto IL_5B1;
						}
						case 9:
							if (num5 > num6)
							{
								num = 39;
								continue;
							}
							goto IL_6A7;
						case 10:
							goto IL_483;
						case 11:
							text = this.@as.PMDesignator;
							num = 40;
							continue;
						case 12:
							if (A_0.IndexOf(this.@as.PMDesignator, global::System.StringComparison.Ordinal) != -1)
							{
								num = 11;
								continue;
							}
							goto IL_4F6;
						case 13:
							if (flag)
							{
								num = 29;
								continue;
							}
							goto IL_24C;
						case 14:
							goto IL_626;
						case 15:
						{
							int num3;
							num2 = num3;
							num = 41;
							continue;
						}
						case 16:
							if (num2 == 24)
							{
								num = 15;
								continue;
							}
							goto IL_626;
						case 17:
							goto IL_43C;
						case 18:
						{
							string[] array2;
							if (array2[num4].IndexOf("h", global::System.StringComparison.Ordinal) != -1)
							{
								num = 45;
								continue;
							}
							goto IL_1AE;
						}
						case 19:
							goto IL_43C;
						case 20:
						{
							int num3;
							if (num2 == num3)
							{
								num = 30;
								continue;
							}
							goto IL_626;
						}
						case 21:
							if (true)
							{
							}
							num = 19;
							continue;
						case 22:
							if (num7 >= 2)
							{
								num = 21;
								continue;
							}
							num = 38;
							continue;
						case 23:
							goto IL_382;
						case 24:
							A_0 = A_0.Replace(text, "");
							A_0 = A_0.Replace(" ", "");
							num = 23;
							continue;
						case 25:
							goto IL_533;
						case 26:
							goto IL_1E1;
						case 27:
							goto IL_1AE;
						case 28:
							if (array[num7].Length > 2)
							{
								num = 25;
								continue;
							}
							num7++;
							num = 7;
							continue;
						case 29:
						{
							text2 = text2.Replace(this.@as.TimeSeparator, "/");
							text2 = text2.ToLowerInvariant();
							char[] separator = "/".ToCharArray();
							string[] array2 = text2.Split(separator);
							num4 = 0;
							num = 32;
							continue;
						}
						case 30:
							num2 = 0;
							num = 14;
							continue;
						case 31:
						{
							int num8;
							if (num2 > num8)
							{
								num = 51;
								continue;
							}
							goto IL_626;
						}
						case 32:
							goto IL_483;
						case 33:
							goto IL_626;
						case 34:
							num = 28;
							continue;
						case 35:
						{
							int num3 = 12;
							num = 4;
							continue;
						}
						case 36:
							goto IL_409;
						case 37:
						{
							if (text2.IndexOf("h", global::System.StringComparison.Ordinal) != -1)
							{
								num = 35;
								continue;
							}
							int num8 = 23;
							num = 31;
							continue;
						}
						case 38:
							if (array[num7].Length != 0)
							{
								num = 34;
								continue;
							}
							goto IL_533;
						case 39:
							num5 = num6;
							num = 52;
							continue;
						case 40:
							goto IL_4F6;
						case 41:
							goto IL_626;
						case 42:
							goto IL_43C;
						case 43:
							value2 = array[num4];
							num = 3;
							continue;
						case 44:
							if (A_0.IndexOf(this.@as.AMDesignator, global::System.StringComparison.Ordinal) != -1)
							{
								num = 49;
								continue;
							}
							goto IL_5C8;
						case 45:
							value = array[num4];
							num = 27;
							continue;
						case 46:
						{
							string[] array2;
							if (num4 >= array2.Length)
							{
								num = 48;
								continue;
							}
							num = 18;
							continue;
						}
						case 47:
						{
							int num3;
							num2 = num3;
							num = 36;
							continue;
						}
						case 48:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E1;
							default:
								if (false)
								{
								}
								goto IL_24C;
							}
							break;
						case 49:
							text = this.@as.AMDesignator;
							num = 0;
							continue;
						case 50:
							if (!string.IsNullOrEmpty(text))
							{
								num = 24;
								continue;
							}
							goto IL_382;
						case 51:
						{
							int num8;
							num2 = num8;
							num = 33;
							continue;
						}
						case 52:
							goto IL_320;
						}
						break;
						IL_1AE:
						num = 8;
						continue;
						IL_1E1:
						num7 = 0;
						num = 2;
						continue;
						IL_24C:
						num2 = global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
						num5 = global::System.Convert.ToInt32(value2, global::System.Globalization.CultureInfo.InvariantCulture);
						text2 = this.@as.ShortTimePattern;
						num = 37;
						continue;
						IL_382:
						char[] separator2 = this.@as.TimeSeparator.ToCharArray();
						array = A_0.Split(separator2);
						flag = true;
						num = 6;
						continue;
						IL_409:
						num = 5;
						continue;
						IL_43C:
						text2 = this.@as.ShortTimePattern;
						num = 13;
						continue;
						IL_483:
						num = 46;
						continue;
						IL_4D1:
						num = 22;
						continue;
						IL_4F6:
						num = 50;
						continue;
						IL_533:
						flag = false;
						num = 42;
						continue;
						IL_5B1:
						num4++;
						num = 10;
						continue;
						IL_5C8:
						num = 12;
						continue;
						IL_626:
						num6 = 59;
						num = 9;
					}
				}
				IL_320:
				IL_6A7:
				global::System.DateTime dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, num2, num5, 0, 0);
				return dateTime.ToShortTimeString();
			}
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000343C8 File Offset: 0x000325C8
		private string b(string A_0)
		{
			switch (0)
			{
			default:
			{
				string text;
				string text2;
				for (;;)
				{
					this.@as = (global::System.Globalization.DateTimeFormatInfo)global::System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.Clone();
					global::System.DateTime now = global::System.DateTime.Now;
					text = now.ToShortDateString();
					text2 = now.ToShortTimeString();
					A_0 = A_0.Replace(this.@as.DateSeparator, "/");
					A_0 = A_0.Replace(this.@as.TimeSeparator, "/");
					A_0 = A_0.Replace(" ", "/");
					string text3 = string.Empty;
					char[] separator = "/".ToCharArray();
					string[] array = A_0.Split(separator);
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							if (A_0.IndexOf(this.@as.AMDesignator, global::System.StringComparison.Ordinal) != -1)
							{
								num = 3;
								continue;
							}
							goto IL_21A;
						case 1:
							goto IL_21A;
						case 2:
							if (array.Length >= 5)
							{
								num = 6;
								continue;
							}
							goto IL_24F;
						case 3:
							text3 = this.@as.AMDesignator;
							num = 1;
							continue;
						case 4:
							text3 = this.@as.PMDesignator;
							num = 8;
							continue;
						case 5:
							if (A_0.IndexOf(this.@as.PMDesignator, global::System.StringComparison.Ordinal) != -1)
							{
								num = 4;
								continue;
							}
							goto IL_10A;
						case 6:
							for (;;)
							{
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_17B;
								}
							}
							IL_17B:
							if (false)
							{
							}
							if (true)
							{
							}
							text = string.Concat(new string[]
							{
								array[0],
								this.@as.DateSeparator,
								array[1],
								this.@as.DateSeparator,
								array[2]
							});
							text2 = string.Concat(new string[]
							{
								array[3],
								this.@as.TimeSeparator,
								array[4],
								" ",
								text3
							});
							num = 7;
							continue;
						case 7:
							goto IL_218;
						case 8:
							goto IL_10A;
						}
						break;
						IL_10A:
						num = 2;
						continue;
						IL_21A:
						num = 5;
					}
				}
				IL_218:
				IL_24F:
				text = this.d(text);
				text2 = this.c(text2);
				return text + " " + text2;
			}
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00034640 File Offset: 0x00032840
		private void h(object A_0, global::System.EventArgs A_1)
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
			base.Copy();
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00034684 File Offset: 0x00032884
		private void g(object A_0, global::System.EventArgs A_1)
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			this.Paste();
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000346C8 File Offset: 0x000328C8
		public new void Paste()
		{
			switch (0)
			{
			default:
				for (;;)
				{
					if (true)
					{
					}
					global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
					string text = string.Empty;
					int num = 0;
					for (;;)
					{
						int num2;
						switch (num)
						{
						case 0:
							if (dataObject != null)
							{
								num = 9;
								continue;
							}
							return;
						case 1:
							return;
						case 2:
							goto IL_1FF;
						case 3:
							if (this.an.Contains(text[num2].ToString()))
							{
								num = 11;
								continue;
							}
							goto IL_88;
						case 4:
							if (dataObject.GetDataPresent(global::System.Windows.Forms.DataFormats.Text))
							{
								num = 5;
								continue;
							}
							return;
						case 5:
							text = (string)dataObject.GetData(global::System.Windows.Forms.DataFormats.Text);
							num = 14;
							continue;
						case 6:
							this.b();
							num = 12;
							continue;
						case 7:
							goto IL_88;
						case 8:
						{
							string text2 = string.Empty;
							num2 = 0;
							num = 15;
							continue;
						}
						case 9:
							num = 4;
							continue;
						case 10:
							try
							{
								string text2;
								this.a(text2);
								base.Paste();
								this.a(this.ForeColor);
								goto IL_1ED;
							}
							catch
							{
								if (this.MaxLength > 0)
								{
									string text2;
									if (text2.Length > 0)
									{
										switch ((1 == 1) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											if (false)
											{
											}
											if (text2.Length <= this.MaxLength)
											{
												goto IL_177;
											}
											break;
										}
										text2 = text2.Substring(0, this.MaxLength);
									}
									IL_177:
									this.SetStandardTextToFormat(text2);
								}
								goto IL_1ED;
							}
							goto IL_182;
							try
							{
								IL_1ED:
								this.a(text);
								return;
							}
							catch
							{
								return;
							}
							goto IL_1FF;
						case 11:
						{
							string text2;
							text2 += text[num2].ToString();
							num = 7;
							continue;
						}
						case 12:
							if (!string.IsNullOrEmpty(this.an))
							{
								num = 8;
								continue;
							}
							goto IL_182;
						case 13:
							if (num2 >= text.Length)
							{
								num = 10;
								continue;
							}
							num = 3;
							continue;
						case 14:
							if (!string.IsNullOrEmpty(text))
							{
								num = 6;
								continue;
							}
							return;
						case 15:
							goto IL_1FF;
						}
						break;
						IL_88:
						num2++;
						num = 2;
						continue;
						IL_182:
						base.Paste();
						this.a(this.ForeColor);
						num = 1;
						continue;
						IL_1FF:
						num = 13;
					}
				}
				return;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00034980 File Offset: 0x00032B80
		private void a(string A_0)
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
			global::System.Windows.Forms.IDataObject dataObject = new global::System.Windows.Forms.DataObject();
			dataObject.SetData(global::System.Windows.Forms.DataFormats.Text, A_0);
			global::System.Windows.Forms.Clipboard.SetDataObject(dataObject, true);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000349D4 File Offset: 0x00032BD4
		private void f(object A_0, global::System.EventArgs A_1)
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
			base.Cut();
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00034A18 File Offset: 0x00032C18
		private void e(object A_0, global::System.EventArgs A_1)
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
			this.DeleteText();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00034A5C File Offset: 0x00032C5C
		public void DeleteText()
		{
			try
			{
				int num = 4;
				for (;;)
				{
					switch (num)
					{
					case 0:
						num = 1;
						continue;
					case 1:
						if (base.SelectionStart < this.Text.Length)
						{
							num = 5;
							continue;
						}
						goto IL_104;
					case 2:
						goto IL_104;
					case 3:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_104;
						default:
							if (false)
							{
							}
							this.SelectedText = string.Empty;
							num = 2;
							continue;
						}
						break;
					case 5:
					{
						int selectionStart = base.SelectionStart;
						this.Text = this.Text.Remove(base.SelectionStart, 1);
						base.SelectionStart = selectionStart;
						num = 8;
						continue;
					}
					case 6:
						if (!string.IsNullOrEmpty(this.Text))
						{
							num = 0;
							continue;
						}
						goto IL_104;
					case 7:
						goto IL_10F;
					case 8:
						goto IL_104;
					}
					if (!string.IsNullOrEmpty(this.SelectedText))
					{
						if (true)
						{
						}
						num = 3;
						continue;
					}
					num = 6;
					continue;
					IL_104:
					num = 7;
				}
				IL_10F:;
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00034BA4 File Offset: 0x00032DA4
		private void d(object A_0, global::System.EventArgs A_1)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			base.SelectAll();
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00034BE8 File Offset: 0x00032DE8
		private void c(object A_0, global::System.EventArgs A_1)
		{
			int num = 9;
			for (;;)
			{
				string value;
				switch (num)
				{
				case 0:
					if (string.IsNullOrEmpty(value))
					{
						goto IL_153;
					}
					this.a5.Enabled = true;
					num = 11;
					continue;
				case 1:
					this.a3.Enabled = false;
					this.a4.Enabled = false;
					this.a6.Enabled = false;
					num = 18;
					continue;
				case 2:
					if (true)
					{
					}
					if (base.ReadOnly)
					{
						num = 10;
						continue;
					}
					num = 8;
					continue;
				case 3:
					if (this.PasswordChar == '\0')
					{
						this.a3.Enabled = true;
						this.a4.Enabled = true;
						num = 15;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
						if (false)
						{
						}
						num = 16;
						continue;
					}
					break;
				case 4:
					goto IL_163;
				case 5:
					goto IL_12A;
				case 6:
					if (string.IsNullOrEmpty(this.SelectedText))
					{
						num = 13;
						continue;
					}
					goto IL_24B;
				case 7:
					goto IL_191;
				case 8:
					if (string.IsNullOrEmpty(this.SelectedText))
					{
						num = 1;
						continue;
					}
					num = 3;
					continue;
				case 10:
					this.a3.Enabled = false;
					this.a5.Enabled = false;
					this.a6.Enabled = false;
					num = 6;
					continue;
				case 11:
					goto IL_1C1;
				case 12:
					this.a5.Enabled = false;
					num = 14;
					continue;
				case 13:
					goto IL_125;
				case 14:
					goto IL_21E;
				case 15:
					goto IL_191;
				case 16:
					this.a3.Enabled = false;
					this.a4.Enabled = false;
					num = 7;
					continue;
				case 17:
					base.Focus();
					base.SelectAll();
					num = 4;
					continue;
				case 18:
					goto IL_12A;
				}
				if (!this.Focused)
				{
					num = 17;
					continue;
				}
				goto IL_163;
				IL_12A:
				value = (string)global::System.Windows.Forms.Clipboard.GetDataObject().GetData(global::System.Windows.Forms.DataFormats.UnicodeText, true);
				num = 0;
				continue;
				IL_153:
				num = 12;
				continue;
				IL_163:
				num = 2;
				continue;
				IL_191:
				this.a6.Enabled = true;
				num = 5;
			}
			IL_125:
			this.a4.Enabled = false;
			return;
			IL_1C1:
			IL_21E:
			goto IL_2AA;
			IL_24B:
			this.a4.Enabled = true;
			return;
			IL_2AA:
			this.a8.Enabled = true;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00034EAC File Offset: 0x000330AC
		public void UndoText()
		{
			int num = 2;
			for (;;)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_08;
				default:
					if (false)
					{
					}
					switch (num)
					{
					case 0:
						base.Undo();
						this.ba = false;
						this.at = false;
						num = 1;
						continue;
					case 1:
						return;
					case 2:
						goto IL_08;
					}
					break;
				}
				IL_4A:
				if (this.ba)
				{
					num = 0;
					continue;
				}
				break;
				IL_08:
				if (true)
				{
				}
				goto IL_4A;
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00034F34 File Offset: 0x00033134
		public bool CanUndoText()
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			return this.ba;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00034F78 File Offset: 0x00033178
		public void SetCanUndo(bool undoValue)
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
			this.ba = undoValue;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00034FBC File Offset: 0x000331BC
		public static global::System.Globalization.NumberStyles GetNumberFlags()
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			return global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowTrailingSign | global::System.Globalization.NumberStyles.AllowParentheses | global::System.Globalization.NumberStyles.AllowDecimalPoint;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00034FFC File Offset: 0x000331FC
		public decimal ConvertFromStandardTextToDec(string textValue)
		{
			decimal result;
			for (;;)
			{
				result = 0m;
				int num = 0;
				for (;;)
				{
					switch (num)
					{
					case 0:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							if (false)
							{
							}
							if (string.IsNullOrEmpty(textValue))
							{
								num = 1;
								continue;
							}
							goto IL_7E;
						}
						break;
					case 1:
						return result;
					case 2:
						try
						{
							return decimal.Parse(textValue, global::custom_controls.CCustomTextBox.GetNumberFlags(), this.InvariantNumberFormat);
						}
						catch (global::System.Exception)
						{
							return this.Minimum;
						}
						goto IL_7E;
					}
					break;
					IL_7E:
					textValue = textValue.Replace(" ", "");
					if (true)
					{
					}
					num = 2;
				}
			}
			return result;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000350C4 File Offset: 0x000332C4
		public decimal ConvertFromFormatTextToDec(string textValue)
		{
			decimal result;
			for (;;)
			{
				result = 0m;
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						try
						{
							return decimal.Parse(textValue, global::custom_controls.CCustomTextBox.GetNumberFlags(), this.ar);
						}
						catch (global::System.Exception)
						{
							return this.Minimum;
						}
						goto IL_7E;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							if (false)
							{
							}
							if (string.IsNullOrEmpty(textValue))
							{
								num = 2;
								continue;
							}
							goto IL_7E;
						}
						break;
					case 2:
						return result;
					}
					break;
					IL_7E:
					if (true)
					{
					}
					textValue = textValue.Replace(" ", "");
					num = 0;
				}
			}
			return result;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0003518C File Offset: 0x0003338C
		protected override bool ProcessCmdKey(ref global::System.Windows.Forms.Message msg, global::System.Windows.Forms.Keys keyData)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					num = 1;
					continue;
				case 1:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerOctal)
					{
						num = 13;
						continue;
					}
					goto IL_15C;
				case 3:
					num = 8;
					continue;
				case 4:
					if (true)
					{
					}
					if (msg.Msg == 256)
					{
						num = 9;
						continue;
					}
					goto IL_12F;
				case 5:
					return false;
				case 6:
					if (this.ValueType == global::custom_controls.CCustomTextBox.valueTypes.Alphanumeric)
					{
						num = 14;
						continue;
					}
					goto IL_12F;
				case 7:
					goto IL_172;
				case 8:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.Decimal)
					{
						num = 12;
						continue;
					}
					goto IL_15C;
				case 9:
					num = 10;
					continue;
				case 10:
					if (keyData != global::System.Windows.Forms.Keys.Tab)
					{
						num = 16;
						continue;
					}
					num = 11;
					continue;
				case 11:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerDec)
					{
						num = 3;
						continue;
					}
					goto IL_15C;
				case 12:
					num = 17;
					continue;
				case 13:
					num = 6;
					continue;
				case 14:
					goto IL_15C;
				case 15:
					if (!this.a6.Enabled)
					{
						num = 5;
						continue;
					}
					goto IL_12F;
				case 16:
					num = 19;
					continue;
				case 17:
					if (this.ValueType != global::custom_controls.CCustomTextBox.valueTypes.IntegerHex)
					{
						num = 0;
						continue;
					}
					goto IL_15C;
				case 18:
					try
					{
						num = 1;
						bool result;
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch ((1 == 1) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									goto IL_23A;
								}
								break;
							case 2:
								num = 3;
								continue;
							case 3:
								if (keyData == global::System.Windows.Forms.Keys.Delete)
								{
									num = 5;
									continue;
								}
								goto IL_242;
							case 4:
								goto IL_24A;
							case 5:
								result = true;
								num = 0;
								continue;
							}
							if (msg.Msg == 256)
							{
								num = 2;
								continue;
							}
							IL_242:
							num = 4;
						}
						IL_23A:
						if (false)
						{
						}
						return result;
						IL_24A:
						goto IL_C0;
					}
					catch (global::System.Exception)
					{
						goto IL_C0;
					}
					goto IL_255;
				case 19:
					if (keyData == global::System.Windows.Forms.Keys.Delete)
					{
						num = 20;
						continue;
					}
					goto IL_12F;
				case 20:
					goto IL_255;
				}
				if (base.ReadOnly)
				{
					num = 18;
					continue;
				}
				IL_C0:
				num = 4;
				continue;
				IL_15C:
				this.OnLeave(global::System.EventArgs.Empty);
				num = 7;
				continue;
				IL_255:
				num = 15;
			}
			IL_12F:
			return base.ProcessCmdKey(ref msg, keyData);
			IL_172:
			goto IL_12F;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0003542C File Offset: 0x0003362C
		private void b(object A_0, global::System.EventArgs A_1)
		{
			while (base.Enabled)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (true)
					{
					}
					if (false)
					{
					}
					this.a(this.ForeColor);
					return;
				}
			}
			this.a(global::System.Drawing.SystemColors.GrayText);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0003548C File Offset: 0x0003368C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			while (base.Enabled)
			{
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					if (false)
					{
					}
					this.BackColor = global::System.Drawing.SystemColors.Window;
					return;
				}
			}
			if (true)
			{
			}
			this.BackColor = global::System.Drawing.SystemColors.Control;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000354E8 File Offset: 0x000336E8
		private void a(global::System.Drawing.Color A_0)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			this.ax = true;
			base.Select(0, this.Text.Length);
			base.SelectionFont = this.Font;
			base.SelectionColor = A_0;
			base.Select(this.Text.Length, 0);
			this.SelectedText = string.Empty;
			this.ax = false;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00035574 File Offset: 0x00033774
		public void CreateEyeButton()
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			this.bf = new global::custom_controls.CPanelTemplate();
			this.be = new global::System.Windows.Forms.Button();
			this.be.BackgroundImage = global::custom_controls.Properties.Resources.EyeForPassword.ToBitmap();
			this.be.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.be.FlatAppearance.BorderSize = 0;
			this.be.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.be.ForeColor = this.ForeColor;
			this.be.BackColor = this.BackColor;
			this.be.Name = "EYE_" + base.Name;
			this.be.Tag = "EYE_" + base.Name;
			this.be.Size = new global::System.Drawing.Size(base.Height, base.Height);
			this.bf.Controls.Add(this);
			this.bf.Controls.Add(this.be);
			this.bf.Name = "PANEL_" + base.Name;
			this.bf.TabIndex = base.TabIndex;
			this.bf.Size = new global::System.Drawing.Size(base.Width + this.be.Width, base.Height);
			this.be.Location = new global::System.Drawing.Point(base.Width, base.Location.Y);
			this.be.MouseDown -= this.b;
			this.be.MouseDown += this.b;
			this.be.MouseUp -= this.a;
			this.be.MouseUp += this.a;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00035774 File Offset: 0x00033974
		private void b(object A_0, global::System.Windows.Forms.MouseEventArgs A_1)
		{
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			if (true)
			{
			}
			base.OnMouseDown(A_1);
			this.PasswordChar = '\0';
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000357C0 File Offset: 0x000339C0
		private void a(object A_0, global::System.Windows.Forms.MouseEventArgs A_1)
		{
			if (true)
			{
			}
			switch (1 == 1)
			{
			}
			if (false)
			{
			}
			base.OnMouseUp(A_1);
			this.PasswordChar = this.bd;
		}

		// Token: 0x04000170 RID: 368
		private const string a = "Min";

		// Token: 0x04000171 RID: 369
		private const string b = "Max";

		// Token: 0x04000172 RID: 370
		private const string c = "StepSize";

		// Token: 0x04000173 RID: 371
		private const string d = "(";

		// Token: 0x04000174 RID: 372
		private const string e = ")";

		// Token: 0x04000175 RID: 373
		private const string f = "()";

		// Token: 0x04000176 RID: 374
		private const string g = "";

		// Token: 0x04000177 RID: 375
		private const string h = "/";

		// Token: 0x04000178 RID: 376
		private const string i = "0123456789";

		// Token: 0x04000179 RID: 377
		private const string j = "0123456789abcdefABCDEF";

		// Token: 0x0400017A RID: 378
		private const string k = "0123456789abcdeABCDE";

		// Token: 0x0400017B RID: 379
		private const string l = "01234567";

		// Token: 0x0400017C RID: 380
		private const string m = "0.000000";

		// Token: 0x0400017D RID: 381
		private const string n = "&Undo";

		// Token: 0x0400017E RID: 382
		private const string o = "Cu&t";

		// Token: 0x0400017F RID: 383
		private const string p = "&Copy";

		// Token: 0x04000180 RID: 384
		private const string q = "&Paste";

		// Token: 0x04000181 RID: 385
		private const string r = "&Delete";

		// Token: 0x04000182 RID: 386
		private const string s = "Select &All";

		// Token: 0x04000183 RID: 387
		private const int t = 13;

		// Token: 0x04000184 RID: 388
		private const int u = 204;

		// Token: 0x04000185 RID: 389
		private const int v = 210;

		// Token: 0x04000186 RID: 390
		private const char w = '\0';

		// Token: 0x04000187 RID: 391
		private const string x = "EYE_";

		// Token: 0x04000188 RID: 392
		private const string y = "PANEL_";

		// Token: 0x04000189 RID: 393
		private const string z = "//";

		// Token: 0x0400018A RID: 394
		private const string aa = "RANGE";

		// Token: 0x0400018B RID: 395
		private const string ab = "OFFSET";

		// Token: 0x0400018C RID: 396
		private const string ac = "LENGTH";

		// Token: 0x0400018D RID: 397
		private const string ad = "CP";

		// Token: 0x0400018E RID: 398
		private const string ae = "SUB_RANGE";

		// Token: 0x0400018F RID: 399
		private const int af = 6;

		// Token: 0x04000190 RID: 400
		private const int ag = 1000000;

		// Token: 0x04000191 RID: 401
		private const int ah = 256;

		// Token: 0x04000192 RID: 402
		private global::System.ComponentModel.Container ai;

		// Token: 0x04000193 RID: 403
		private bool aj;

		// Token: 0x04000194 RID: 404
		private bool ak;

		// Token: 0x04000195 RID: 405
		private string al;

		// Token: 0x04000196 RID: 406
		private global::custom_controls.CCustomTextBox.valueTypes am;

		// Token: 0x04000197 RID: 407
		private string an;

		// Token: 0x04000198 RID: 408
		private bool ao;

		// Token: 0x04000199 RID: 409
		private int ap;

		// Token: 0x0400019A RID: 410
		private bool aq;

		// Token: 0x0400019B RID: 411
		private global::System.Globalization.NumberFormatInfo ar = new global::System.Globalization.NumberFormatInfo();

		// Token: 0x0400019C RID: 412
		private global::System.Globalization.DateTimeFormatInfo @as = new global::System.Globalization.DateTimeFormatInfo();

		// Token: 0x0400019D RID: 413
		private bool at;

		// Token: 0x0400019E RID: 414
		private bool au;

		// Token: 0x0400019F RID: 415
		private long av;

		// Token: 0x040001A0 RID: 416
		private long aw;

		// Token: 0x040001A1 RID: 417
		private bool ax;

		// Token: 0x040001A2 RID: 418
		private string ay;

		// Token: 0x040001A3 RID: 419
		private string az;

		// Token: 0x040001A4 RID: 420
		private bool a0;

		// Token: 0x040001A5 RID: 421
		private global::System.Windows.Forms.ToolStripMenuItem a1;

		// Token: 0x040001A6 RID: 422
		private global::System.Windows.Forms.ToolStripMenuItem a2;

		// Token: 0x040001A7 RID: 423
		private global::System.Windows.Forms.ToolStripMenuItem a3;

		// Token: 0x040001A8 RID: 424
		private global::System.Windows.Forms.ToolStripMenuItem a4;

		// Token: 0x040001A9 RID: 425
		private global::System.Windows.Forms.ToolStripMenuItem a5;

		// Token: 0x040001AA RID: 426
		private global::System.Windows.Forms.ToolStripMenuItem a6;

		// Token: 0x040001AB RID: 427
		private global::System.Windows.Forms.ToolStripSeparator a7;

		// Token: 0x040001AC RID: 428
		private global::System.Windows.Forms.ToolStripMenuItem a8;

		// Token: 0x040001AD RID: 429
		private global::System.Globalization.NumberFormatInfo a9;

		// Token: 0x040001AE RID: 430
		private bool ba;

		// Token: 0x040001AF RID: 431
		private bool bb;

		// Token: 0x040001B0 RID: 432
		private bool bc;

		// Token: 0x040001B1 RID: 433
		private char bd = '●';

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Forms.Button be;

		// Token: 0x040001B3 RID: 435
		private global::custom_controls.CPanelTemplate bf;

		// Token: 0x040001B4 RID: 436
		private string bg;

		// Token: 0x040001B5 RID: 437
		private global::System.Collections.ArrayList bh;

		// Token: 0x040001B6 RID: 438
		public bool hasRange;

		// Token: 0x040001B7 RID: 439
		private string bi;

		// Token: 0x040001B8 RID: 440
		private bool bj;

		// Token: 0x040001B9 RID: 441
		private global::System.Collections.Hashtable bk;

		// Token: 0x02000036 RID: 54
		public enum valueTypes
		{
			// Token: 0x040001BB RID: 443
			IntegerDec,
			// Token: 0x040001BC RID: 444
			IntegerOctal,
			// Token: 0x040001BD RID: 445
			IntegerHex,
			// Token: 0x040001BE RID: 446
			Decimal,
			// Token: 0x040001BF RID: 447
			Alphanumeric,
			// Token: 0x040001C0 RID: 448
			Date,
			// Token: 0x040001C1 RID: 449
			Time,
			// Token: 0x040001C2 RID: 450
			DateTime
		}

		// Token: 0x02000037 RID: 55
		public struct RFRange
		{
			// Token: 0x060002E4 RID: 740 RVA: 0x00035810 File Offset: 0x00033A10
			public RFRange(decimal low, decimal high, decimal stepSize)
			{
				this.a = low;
				this.b = high;
				this.c = stepSize;
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060002E5 RID: 741 RVA: 0x00035834 File Offset: 0x00033A34
			public decimal RfLow
			{
				get
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
					return this.a;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x00035878 File Offset: 0x00033A78
			public decimal RfHigh
			{
				get
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
					return this.b;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060002E7 RID: 743 RVA: 0x000358BC File Offset: 0x00033ABC
			public decimal StepSize
			{
				get
				{
					switch (1 == 1)
					{
					}
					if (false)
					{
					}
					if (true)
					{
					}
					return this.c;
				}
			}

			// Token: 0x040001C3 RID: 451
			private decimal a;

			// Token: 0x040001C4 RID: 452
			private decimal b;

			// Token: 0x040001C5 RID: 453
			private decimal c;
		}

		// Token: 0x02000038 RID: 56
		private struct a
		{
			// Token: 0x060002E8 RID: 744 RVA: 0x00035900 File Offset: 0x00033B00
			public a(int A_0, int A_1, string A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x060002E9 RID: 745 RVA: 0x00035924 File Offset: 0x00033B24
			public int b()
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
				return this.a;
			}

			// Token: 0x060002EA RID: 746 RVA: 0x00035968 File Offset: 0x00033B68
			public int a()
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
				return this.b;
			}

			// Token: 0x060002EB RID: 747 RVA: 0x000359AC File Offset: 0x00033BAC
			public bool a(char A_0)
			{
				string value = A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				if (this.c.Contains(value))
				{
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						if (false)
						{
						}
						break;
					}
					if (true)
					{
					}
					return true;
				}
				return false;
			}

			// Token: 0x040001C6 RID: 454
			private int a;

			// Token: 0x040001C7 RID: 455
			private int b;

			// Token: 0x040001C8 RID: 456
			private string c;
		}
	}
}
