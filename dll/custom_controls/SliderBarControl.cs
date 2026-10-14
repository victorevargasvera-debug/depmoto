using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace custom_controls
{
	// Token: 0x02000096 RID: 150
	[global::System.Drawing.ToolboxBitmap(typeof(global::System.Windows.Forms.TrackBar))]
	[global::System.ComponentModel.Description("SliderBar Controlr")]
	[global::System.ComponentModel.Designer(typeof(global::custom_controls.q))]
	public class SliderBarControl : global::System.Windows.Forms.Control
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x0005B55C File Offset: 0x0005975C
		public SliderBarControl()
		{
			this.b();
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::custom_controls.SliderBarControl));
			this.m_slider_bar = (global::System.Drawing.Image)resourceManager.GetObject("slider_bar.Image");
			this.m_narrow = (global::System.Drawing.Image)resourceManager.GetObject("narrow.Image");
			this.a();
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			this.h = 0m;
			this.i = 100m;
			this.j = 1m;
			this.k = 25m;
			this.m_margin = 6;
			this.m_trackSize = 10;
			this.m_minLength = 0;
			this.m_maxLength = 0;
			this.m_textBrush = new global::System.Drawing.SolidBrush(global::System.Drawing.Color.Black);
			this.d = -1;
			this.e = false;
			this.m_trackRect = global::System.Drawing.Rectangle.Empty;
			this.m_barRect = global::System.Drawing.Rectangle.Empty;
			this.m_maxSide = global::custom_controls.Poles.Right;
			this.l = string.Empty;
			this.m = string.Empty;
			this.m_textFont = new global::System.Drawing.Font("Arial Unicode MS", 8.25f);
			this.m_bRaiseOnEnterEvent = true;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0005B680 File Offset: 0x00059880
		protected override void Dispose(bool disposing)
		{
			int num = 8;
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.f.Dispose();
					num = 6;
					continue;
				case 1:
					this.m_textFont.Dispose();
					num = 5;
					continue;
				case 2:
					if (true)
					{
					}
					num = 4;
					continue;
				case 3:
					if (this.m_textFont != null)
					{
						num = 1;
						continue;
					}
					goto IL_125;
				case 4:
					if (this.f != null)
					{
						num = 0;
						continue;
					}
					goto IL_90;
				case 5:
					goto IL_F0;
				case 6:
					goto IL_90;
				case 7:
					if (this.m_textBrush != null)
					{
						num = 9;
						continue;
					}
					goto IL_70;
				case 9:
					this.m_textBrush.Dispose();
					num = 10;
					continue;
				case 10:
					goto IL_70;
				}
				if (!disposing)
				{
					break;
				}
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_90;
				default:
					if (false)
					{
					}
					num = 2;
					continue;
				}
				IL_70:
				num = 3;
				continue;
				IL_90:
				num = 7;
			}
			IL_F0:
			IL_125:
			base.Dispose(disposing);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0005B7BC File Offset: 0x000599BC
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x0005B800 File Offset: 0x00059A00
		[global::System.ComponentModel.Category("SliderBarControl")]
		[global::System.ComponentModel.Description("Set Margin size")]
		public new int Margin
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
				return this.m_margin;
			}
			set
			{
				int num = 0;
				for (;;)
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
						switch (num)
						{
						case 1:
							if (value > global::custom_controls.SliderBarControl.MAX_MARGIN)
							{
								num = 2;
								continue;
							}
							goto IL_9F;
						case 2:
							value = global::custom_controls.SliderBarControl.MAX_MARGIN;
							num = 5;
							continue;
						case 3:
							goto IL_63;
						case 4:
							if (true)
							{
							}
							value = 0;
							num = 3;
							continue;
						case 5:
							goto IL_61;
						}
						goto IL_44;
						IL_63:
						num = 1;
						continue;
						IL_44:
						if (value > 0)
						{
							goto IL_63;
						}
						break;
					}
					num = 4;
				}
				IL_61:
				IL_9F:
				this.m_margin = value;
				this.m_trackRect = global::System.Drawing.Rectangle.Empty;
				this.m_barRect = global::System.Drawing.Rectangle.Empty;
				base.Invalidate();
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x0005B974 File Offset: 0x00059B74
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x0005B8D0 File Offset: 0x00059AD0
		[global::System.ComponentModel.Description("Set Minimum value of the SliderBarControl")]
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.ComponentModel.Category("SliderBarControl")]
		public decimal Minimum
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
				return this.h;
			}
			set
			{
				for (;;)
				{
					this.h = value;
					this.a();
					int num = 0;
					for (;;)
					{
						switch (num)
						{
						case 0:
							goto IL_29;
						case 1:
							this.k = value;
							num = 2;
							continue;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_29;
							default:
								goto IL_6B;
							}
							break;
						}
						break;
						IL_29:
						if (!(this.k < this.h))
						{
							goto IL_7B;
						}
						num = 1;
					}
				}
				IL_6B:
				if (true)
				{
				}
				if (false)
				{
				}
				IL_7B:
				this.m_trackRect = global::System.Drawing.Rectangle.Empty;
				base.Invalidate();
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0005BA58 File Offset: 0x00059C58
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0005B9B8 File Offset: 0x00059BB8
		[global::System.ComponentModel.RefreshProperties(global::System.ComponentModel.RefreshProperties.All)]
		[global::System.ComponentModel.Description("Set Maximum value of the SliderBarControl")]
		[global::System.ComponentModel.Category("SliderBarControl")]
		public decimal Maximum
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
				return this.i;
			}
			set
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_71;
					case 2:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							if (false)
							{
							}
							this.k = value;
							num = 0;
							continue;
						}
						break;
					}
					IL_26:
					if (true)
					{
					}
					if (this.k > value)
					{
						num = 2;
						continue;
					}
					break;
					goto IL_26;
				}
				IL_71:
				this.i = value;
				this.a();
				this.m_trackRect = global::System.Drawing.Rectangle.Empty;
				base.Invalidate();
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0005BC00 File Offset: 0x00059E00
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0005BA9C File Offset: 0x00059C9C
		[global::System.ComponentModel.Category("SliderBarControl")]
		[global::System.ComponentModel.Description("Set or get the Value")]
		public decimal Value
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
				return this.k;
			}
			set
			{
				int num = 8;
				for (;;)
				{
					decimal d;
					switch (num)
					{
					case 0:
						value = this.i;
						num = 4;
						continue;
					case 1:
						goto IL_138;
					case 2:
						if (true)
						{
						}
						goto IL_10F;
					case 3:
						IL_11A:
						if (value >= this.i)
						{
							num = 0;
							continue;
						}
						goto IL_59;
					case 4:
						goto IL_59;
					case 5:
						if (this.k != d)
						{
							num = 6;
							continue;
						}
						goto IL_138;
					case 6:
						this.k = d;
						this.g = true;
						base.Invalidate();
						num = 1;
						continue;
					case 7:
						value = this.h;
						num = 2;
						continue;
					}
					if (value <= this.h)
					{
						num = 7;
						continue;
					}
					goto IL_10F;
					IL_59:
					int value2 = (int)((value - this.h) / this.j);
					d = value2 * this.j + this.h;
					num = 5;
					continue;
					IL_138:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11A;
					default:
						goto IL_14E;
					}
					IL_10F:
					num = 3;
				}
				IL_14E:
				if (false)
				{
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0005BC44 File Offset: 0x00059E44
		[global::System.ComponentModel.Category("SliderBarControl")]
		[global::System.ComponentModel.Description("get the flag which notifies whether the mouse is being dragged or not")]
		public bool MouseDragged
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
				return this.e;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x0005BCE8 File Offset: 0x00059EE8
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x0005BC88 File Offset: 0x00059E88
		[global::System.ComponentModel.Category("SliderBarControl")]
		[global::System.ComponentModel.Description("Set or get the step size")]
		public decimal StepSize
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
				return this.j;
			}
			set
			{
				if (true)
				{
				}
				if (value <= 0m)
				{
					for (;;)
					{
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_38;
						}
					}
					IL_38:
					if (false)
					{
					}
					throw new global::System.ArgumentException("stepSize must be positive");
				}
				this.j = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x0005BD2C File Offset: 0x00059F2C
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x0005BD70 File Offset: 0x00059F70
		[global::System.ComponentModel.Category("SliderBarControl")]
		[global::System.ComponentModel.Description("Select the side of the control to represent the maximum range value")]
		public global::custom_controls.Poles MaximumValueSide
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
				return this.m_maxSide;
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
				this.m_maxSide = value;
				this.m_trackRect = global::System.Drawing.Rectangle.Empty;
				base.Invalidate();
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0005BDC4 File Offset: 0x00059FC4
		public static ushort LowWord(uint value)
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
			return (ushort)(value & 65535U);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0005BE08 File Offset: 0x0005A008
		public static ushort HighWord(uint value)
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
			return (ushort)(value >> 16);
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06000623 RID: 1571 RVA: 0x0005BE48 File Offset: 0x0005A048
		// (remove) Token: 0x06000624 RID: 1572 RVA: 0x0005BEDC File Offset: 0x0005A0DC
		[global::System.ComponentModel.Category("Action")]
		[global::System.ComponentModel.Description("Event fires when the Value property changes")]
		public event global::custom_controls.SliderBarControl.ValueChangedEventHandler ValueChanged
		{
			add
			{
				for (;;)
				{
					for (;;)
					{
						global::custom_controls.SliderBarControl.ValueChangedEventHandler valueChangedEventHandler = this.n;
						int num = 0;
						for (;;)
						{
							global::custom_controls.SliderBarControl.ValueChangedEventHandler valueChangedEventHandler2;
							switch (num)
							{
							case 0:
								goto IL_25;
							case 1:
								goto IL_56;
							case 2:
								if (valueChangedEventHandler == valueChangedEventHandler2)
								{
									num = 1;
									continue;
								}
								goto IL_25;
							}
							break;
							IL_25:
							valueChangedEventHandler2 = valueChangedEventHandler;
							global::custom_controls.SliderBarControl.ValueChangedEventHandler value2 = (global::custom_controls.SliderBarControl.ValueChangedEventHandler)global::System.Delegate.Combine(valueChangedEventHandler2, value);
							valueChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderBarControl.ValueChangedEventHandler>(ref this.n, value2, valueChangedEventHandler2);
							num = 2;
						}
					}
					IL_56:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_78;
					}
				}
				IL_78:
				if (true)
				{
				}
				if (false)
				{
				}
			}
			remove
			{
				for (;;)
				{
					global::custom_controls.SliderBarControl.ValueChangedEventHandler valueChangedEventHandler = this.n;
					int num = 0;
					for (;;)
					{
						global::custom_controls.SliderBarControl.ValueChangedEventHandler valueChangedEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_23;
						case 1:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								goto IL_74;
							}
							break;
						case 2:
							if (valueChangedEventHandler == valueChangedEventHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_2D;
						}
						break;
						IL_2D:
						valueChangedEventHandler2 = valueChangedEventHandler;
						global::custom_controls.SliderBarControl.ValueChangedEventHandler value2 = (global::custom_controls.SliderBarControl.ValueChangedEventHandler)global::System.Delegate.Remove(valueChangedEventHandler2, value);
						valueChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderBarControl.ValueChangedEventHandler>(ref this.n, value2, valueChangedEventHandler2);
						num = 2;
						continue;
						IL_23:
						if (true)
						{
						}
						goto IL_2D;
					}
				}
				IL_74:
				if (false)
				{
				}
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000625 RID: 1573 RVA: 0x0005BF70 File Offset: 0x0005A170
		// (remove) Token: 0x06000626 RID: 1574 RVA: 0x0005C004 File Offset: 0x0005A204
		[global::System.ComponentModel.Description("Event fires when the Trackbar position is changed")]
		[global::System.ComponentModel.Category("Behavior")]
		public event global::custom_controls.SliderBarControl.ScrollEventHandler Scroll
		{
			add
			{
				for (;;)
				{
					global::custom_controls.SliderBarControl.ScrollEventHandler scrollEventHandler = this.o;
					int num = 0;
					for (;;)
					{
						global::custom_controls.SliderBarControl.ScrollEventHandler scrollEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_23;
						case 1:
							if (scrollEventHandler == scrollEventHandler2)
							{
								num = 2;
								continue;
							}
							goto IL_25;
						case 2:
							switch ((1 == 1) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								goto IL_6C;
							}
							break;
						}
						break;
						IL_25:
						scrollEventHandler2 = scrollEventHandler;
						global::custom_controls.SliderBarControl.ScrollEventHandler value2 = (global::custom_controls.SliderBarControl.ScrollEventHandler)global::System.Delegate.Combine(scrollEventHandler2, value);
						scrollEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderBarControl.ScrollEventHandler>(ref this.o, value2, scrollEventHandler2);
						num = 1;
						continue;
						IL_23:
						goto IL_25;
					}
				}
				IL_6C:
				if (false)
				{
				}
				if (true)
				{
				}
			}
			remove
			{
				for (;;)
				{
					IL_14:
					if (true)
					{
					}
					global::custom_controls.SliderBarControl.ScrollEventHandler scrollEventHandler = this.o;
					int num = 0;
					for (;;)
					{
						global::custom_controls.SliderBarControl.ScrollEventHandler scrollEventHandler2;
						switch (num)
						{
						case 0:
							goto IL_37;
						case 1:
							return;
						case 2:
							if (scrollEventHandler == scrollEventHandler2)
							{
								num = 1;
								continue;
							}
							goto IL_37;
						}
						break;
						IL_37:
						scrollEventHandler2 = scrollEventHandler;
						global::custom_controls.SliderBarControl.ScrollEventHandler value2 = (global::custom_controls.SliderBarControl.ScrollEventHandler)global::System.Delegate.Remove(scrollEventHandler2, value);
						scrollEventHandler = global::System.Threading.Interlocked.CompareExchange<global::custom_controls.SliderBarControl.ScrollEventHandler>(ref this.o, value2, scrollEventHandler2);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							if (false)
							{
							}
							num = 2;
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0005C09C File Offset: 0x0005A29C
		protected virtual void OnScroll()
		{
			try
			{
				int num = 3;
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_71;
					case 1:
						goto IL_69;
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
							this.o(this, new global::System.EventArgs());
							num = 1;
							continue;
						}
						break;
					}
					if (this.o != null)
					{
						num = 2;
						continue;
					}
					IL_69:
					num = 0;
				}
				IL_71:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0005C144 File Offset: 0x0005A344
		protected virtual void OnValueChanged()
		{
			if (true)
			{
			}
			int num;
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
				break;
			}
			for (;;)
			{
				switch (num)
				{
				case 0:
					this.n(this, new global::System.EventArgs());
					num = 2;
					continue;
				case 2:
					goto IL_75;
				}
				if (this.n == null)
				{
					break;
				}
				num = 0;
			}
			IL_75:
			this.g = true;
			base.Invalidate();
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0005C1D8 File Offset: 0x0005A3D8
		protected override void OnGotFocus(global::System.EventArgs e)
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
			this.m_bHighlightControl = true;
			base.OnGotFocus(e);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0005C224 File Offset: 0x0005A424
		protected override void OnEnter(global::System.EventArgs e)
		{
			int num = 2;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_63;
				case 1:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						if (false)
						{
						}
						base.OnEnter(e);
						num = 0;
						continue;
					}
					break;
				}
				if (!this.m_bRaiseOnEnterEvent)
				{
					break;
				}
				num = 1;
			}
			IL_63:
			if (true)
			{
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0005C2A0 File Offset: 0x0005A4A0
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			int num = 1;
			for (;;)
			{
				switch (num)
				{
				case 0:
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_70;
					default:
						if (false)
						{
						}
						this.e = false;
						this.OnValueChanged();
						base.OnMouseUp(e);
						num = 2;
						continue;
					}
					break;
				case 2:
					goto IL_70;
				}
				if (!this.e)
				{
					return;
				}
				num = 0;
			}
			IL_70:
			if (true)
			{
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0005C328 File Offset: 0x0005A528
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			for (;;)
			{
				base.OnMouseDown(e);
				int num = 13;
				for (;;)
				{
					int num2;
					switch (num)
					{
					case 0:
						num2 = (this.m_trackRect.Left - this.m_barRect.Left) * -1;
						num = 7;
						continue;
					case 1:
						goto IL_196;
					case 2:
						return;
					case 3:
						goto IL_236;
					case 4:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_210;
						default:
							if (false)
							{
							}
							goto IL_236;
						}
						break;
					case 5:
						this.m_bRaiseOnEnterEvent = false;
						base.Focus();
						this.m_bRaiseOnEnterEvent = true;
						this.OnValueChanged();
						num = 4;
						continue;
					case 6:
						goto IL_316;
					case 7:
						goto IL_196;
					case 8:
					{
						this.e = true;
						global::System.Drawing.Point pt;
						this.d = pt.X - this.m_trackRect.X;
						base.Focus();
						num = 3;
						continue;
					}
					case 9:
						if (true)
						{
						}
						if (num2 != 0)
						{
							num = 5;
							continue;
						}
						goto IL_236;
					case 10:
					{
						global::System.Drawing.Point pt;
						if (this.m_trackRect.Right + (pt.X - this.m_trackRect.X - this.m_trackRect.Width / 2) >= this.m_barRect.Right)
						{
							num = 11;
							continue;
						}
						num = 17;
						continue;
					}
					case 11:
						num2 = this.m_barRect.Right - this.m_trackRect.Right;
						num = 1;
						continue;
					case 12:
						num = 10;
						continue;
					case 13:
						if (e.Button == global::System.Windows.Forms.MouseButtons.Left)
						{
							num = 19;
							continue;
						}
						return;
					case 14:
						this.k = (this.k - (this.i - this.h)) * -1m;
						num = 6;
						continue;
					case 15:
						goto IL_147;
					case 16:
						num = 20;
						continue;
					case 17:
					{
						global::System.Drawing.Point pt;
						if (this.m_trackRect.Left + (pt.X - this.m_trackRect.X - this.m_trackRect.Width / 2) <= this.m_barRect.Left)
						{
							num = 0;
							continue;
						}
						num2 = pt.X - this.m_trackRect.X - this.m_trackRect.Width / 2;
						num = 18;
						continue;
					}
					case 18:
						goto IL_196;
					case 19:
					{
						global::System.Drawing.Point pt = new global::System.Drawing.Point(e.X, e.Y);
						num = 21;
						continue;
					}
					case 20:
						if (!this.e)
						{
							num = 8;
							continue;
						}
						goto IL_236;
					case 21:
					{
						global::System.Drawing.Point pt;
						if (this.m_trackRect.Contains(pt))
						{
							num = 16;
							continue;
						}
						num2 = 0;
						num = 23;
						continue;
					}
					case 22:
						if (this.m_maxSide == global::custom_controls.Poles.Left)
						{
							num = 14;
							continue;
						}
						goto IL_316;
					case 23:
					{
						global::System.Drawing.Point pt;
						if (this.m_barRect.Contains(pt))
						{
							num = 12;
							continue;
						}
						goto IL_147;
					}
					}
					break;
					IL_147:
					num = 9;
					continue;
					IL_210:
					num = 22;
					continue;
					IL_196:
					this.m_trackRect.Offset(num2, 0);
					this.k = (this.m_trackRect.X - this.m_barRect.Left) * (this.i - this.h) / (this.m_barRect.Width - this.m_trackSize - 2);
					this.k += this.h;
					goto IL_210;
					IL_236:
					base.Invalidate();
					num = 2;
					continue;
					IL_316:
					this.Value = this.k;
					num = 15;
				}
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0005C750 File Offset: 0x0005A950
		protected override void OnMouseMove(global::System.Windows.Forms.MouseEventArgs e)
		{
			int num = 4;
			for (;;)
			{
				global::System.Drawing.Point pt;
				switch (num)
				{
				case 0:
					try
					{
						num = 12;
						for (;;)
						{
							int num2;
							switch (num)
							{
							case 0:
								num = 2;
								continue;
							case 1:
								goto IL_AB;
							case 2:
								if (this.m_trackRect.Right + (pt.X - this.m_trackRect.X - this.d) >= this.m_barRect.Right)
								{
									num = 10;
									continue;
								}
								num = 9;
								continue;
							case 3:
								if (this.m_maxSide == global::custom_controls.Poles.Left)
								{
									num = 13;
									continue;
								}
								goto IL_145;
							case 4:
								goto IL_AB;
							case 5:
								goto IL_2C5;
							case 6:
								goto IL_2BA;
							case 7:
								goto IL_145;
							case 8:
								num2 = (this.m_trackRect.Left - this.m_barRect.Left) * -1;
								num = 11;
								continue;
							case 9:
								if (this.m_trackRect.Left + (pt.X - this.m_trackRect.X - this.d) <= this.m_barRect.Left)
								{
									num = 8;
									continue;
								}
								num2 = pt.X - this.m_trackRect.X - this.d;
								num = 1;
								continue;
							case 10:
								num2 = this.m_barRect.Right - this.m_trackRect.Right;
								num = 4;
								continue;
							case 11:
								goto IL_AB;
							case 13:
								this.k = (this.k - (this.i - this.h)) * -1m;
								num = 7;
								continue;
							}
							if (this.m_barRect.Contains(pt))
							{
								num = 0;
								continue;
							}
							goto IL_2BA;
							IL_AB:
							this.m_trackRect.Offset(num2, 0);
							this.k = (this.m_trackRect.X - this.m_barRect.Left) * (this.i - this.h) / (this.m_barRect.Width - this.m_trackSize - 2);
							this.k += this.h;
							num = 3;
							continue;
							IL_145:
							this.Value = this.k;
							num = 6;
							continue;
							IL_2BA:
							num = 5;
						}
						IL_2C5:
						goto IL_360;
					}
					finally
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
							num = 1;
							for (;;)
							{
								switch (num)
								{
								case 0:
									this.OnValueChanged();
									num = 2;
									continue;
								case 2:
									goto IL_31D;
								}
								int num2;
								if (num2 == 0)
								{
									break;
								}
								num = 0;
							}
							IL_31D:
							break;
						}
					}
					goto IL_320;
					IL_360:
					base.OnMouseMove(e);
					if (true)
					{
					}
					num = 3;
					continue;
				case 1:
					goto IL_320;
				case 2:
				{
					int num2 = 0;
					num = 0;
					continue;
				}
				case 3:
					return;
				case 5:
					if (this.e)
					{
						num = 2;
						continue;
					}
					return;
				}
				if (e.Button == global::System.Windows.Forms.MouseButtons.Left)
				{
					num = 1;
					continue;
				}
				break;
				IL_320:
				pt = new global::System.Drawing.Point(e.X, e.Y);
				num = 5;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0005CB08 File Offset: 0x0005AD08
		protected override void OnMouseLeave(global::System.EventArgs e)
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
			this.e = false;
			base.Invalidate();
			base.OnMouseLeave(e);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0005CB58 File Offset: 0x0005AD58
		private void b()
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
			this.f = new global::System.ComponentModel.Container();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0005CBA0 File Offset: 0x0005ADA0
		public void HighlightControl(global::System.Windows.Forms.PaintEventArgs pe)
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
			global::System.Windows.Forms.ControlPaint.DrawBorder(pe.Graphics, this.m_trackRect, global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.WindowFrame), global::System.Windows.Forms.ButtonBorderStyle.Solid);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0005CBF4 File Offset: 0x0005ADF4
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs pe)
		{
			try
			{
				for (;;)
				{
					this.drawImages(pe.Graphics);
					int num = 5;
					for (;;)
					{
						switch (num)
						{
						case 0:
							num = 4;
							continue;
						case 1:
							goto IL_9F;
						case 2:
							IL_55:
							goto IL_71;
						case 3:
							goto IL_46;
						case 4:
							if (this.m_bHighlightControl)
							{
								num = 3;
								continue;
							}
							goto IL_71;
						case 5:
							if (!this.Focused)
							{
								num = 0;
								continue;
							}
							goto IL_46;
						}
						break;
						IL_46:
						this.HighlightControl(pe);
						num = 2;
						continue;
						IL_71:
						base.OnPaint(pe);
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_55;
						default:
							if (false)
							{
							}
							num = 1;
							break;
						}
					}
				}
				IL_9F:;
			}
			catch (global::System.Exception)
			{
			}
			if (true)
			{
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0005CCC8 File Offset: 0x0005AEC8
		protected void drawImages(global::System.Drawing.Graphics g)
		{
			int num = 3;
			for (;;)
			{
				int num2;
				switch (num)
				{
				case 0:
					if (!(this.m_trackRect == global::System.Drawing.Rectangle.Empty))
					{
						num = 2;
						continue;
					}
					goto IL_CC;
				case 1:
					num = 9;
					continue;
				case 2:
					num = 14;
					continue;
				case 4:
					num2 = 0;
					num = 19;
					continue;
				case 5:
					num2 = this.m_barRect.Width - this.m_trackSize;
					num = 17;
					continue;
				case 6:
					goto IL_1AD;
				case 7:
					goto IL_3C1;
				case 8:
					if (this.m_maxLength == 0)
					{
						num = 22;
						continue;
					}
					goto IL_224;
				case 9:
					if (this.m_minLength != 0)
					{
						num = 11;
						continue;
					}
					goto IL_136;
				case 10:
					if (this.m_maxSide != global::custom_controls.Poles.Right)
					{
						num = 24;
						continue;
					}
					goto IL_1AD;
				case 11:
					num = 8;
					continue;
				case 12:
					if (num2 <= 0)
					{
						num = 4;
						continue;
					}
					goto IL_99;
				case 13:
					goto IL_224;
				case 14:
					if (this.g)
					{
						num = 7;
						continue;
					}
					goto IL_3C6;
				case 15:
					if (num2 + this.m_trackSize >= this.m_barRect.Width)
					{
						num = 5;
						continue;
					}
					goto IL_154;
				case 16:
					this.m_barRect = new global::System.Drawing.Rectangle(this.m_margin + this.m_minLength + this.m_margin, this.m_margin, base.Width - 4 * this.m_margin - this.m_minLength - this.m_maxLength, base.Height - 2 * this.m_margin);
					num = 20;
					continue;
				case 17:
					goto IL_154;
				case 18:
					if (this.m_maxSide != global::custom_controls.Poles.Right)
					{
						this.m_barRect = new global::System.Drawing.Rectangle(this.m_margin + this.m_maxLength + this.m_margin, this.m_margin, base.Width - 4 * this.m_margin - this.m_minLength - this.m_maxLength, base.Height - 2 * this.m_margin);
						num = 21;
						continue;
					}
					switch ((1 == 1) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C1;
					default:
						if (false)
						{
						}
						num = 16;
						continue;
					}
					break;
				case 19:
					goto IL_99;
				case 20:
					goto IL_1F4;
				case 21:
					goto IL_1F4;
				case 22:
					goto IL_136;
				case 23:
					goto IL_1E7;
				case 24:
					num2 = (num2 - this.m_barRect.Width + this.m_trackSize) * -1;
					num = 6;
					continue;
				}
				if (this.m_barRect == global::System.Drawing.Rectangle.Empty)
				{
					num = 1;
					continue;
				}
				goto IL_1F4;
				IL_99:
				num = 15;
				continue;
				IL_CC:
				num2 = 0;
				num2 = (int)((this.k - this.h) * (this.m_barRect.Width - this.m_trackSize) / (this.i - this.h));
				num = 12;
				continue;
				IL_3C1:
				goto IL_CC;
				IL_136:
				this.m_minLength = 0;
				this.m_maxLength = 0;
				num = 13;
				continue;
				IL_154:
				num = 10;
				continue;
				IL_1AD:
				this.m_trackRect = new global::System.Drawing.Rectangle(num2 + this.m_barRect.X, 1, this.m_trackSize, base.ClientRectangle.Height - 2);
				num = 23;
				continue;
				IL_1F4:
				num = 0;
				continue;
				IL_224:
				num = 18;
			}
			IL_1E7:
			if (true)
			{
			}
			IL_3C6:
			g.DrawImage(this.m_slider_bar, this.m_barRect);
			g.DrawImage(this.m_narrow, this.m_trackRect);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0005D0C0 File Offset: 0x0005B2C0
		protected void drawMinMaxLabel(global::System.Drawing.Graphics g)
		{
			global::System.Drawing.Font font = new global::System.Drawing.Font(this.m_textFont.Name, this.m_textFont.Size * 3f / 4f);
			try
			{
				int num = 1;
				for (;;)
				{
					switch (num)
					{
					case 0:
						g.DrawString(this.l, font, this.m_textBrush, (float)this.m_margin, (float)this.m_margin);
						g.DrawString(this.m, font, this.m_textBrush, (float)(base.Width - this.m_margin - this.m_maxLength), (float)this.m_margin);
						num = 3;
						continue;
					case 1:
						switch ((1 == 1) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_135;
						default:
							if (false)
							{
							}
							break;
						}
						break;
					case 2:
						goto IL_135;
					case 3:
						goto IL_137;
					case 4:
						goto IL_142;
					}
					if (this.m_maxSide == global::custom_controls.Poles.Right)
					{
						num = 0;
						continue;
					}
					g.DrawString(this.m, font, this.m_textBrush, (float)this.m_margin, (float)this.m_margin);
					g.DrawString(this.l, font, this.m_textBrush, (float)(base.Width - this.m_margin - this.m_minLength), (float)this.m_margin);
					num = 2;
					continue;
					IL_137:
					num = 4;
					continue;
					IL_135:
					goto IL_137;
				}
				IL_142:;
			}
			finally
			{
				int num = 0;
				for (;;)
				{
					if (true)
					{
					}
					switch (num)
					{
					case 1:
						goto IL_183;
					case 2:
						((global::System.IDisposable)font).Dispose();
						num = 1;
						continue;
					}
					if (font == null)
					{
						break;
					}
					num = 2;
				}
				IL_183:;
			}
		}

		// Token: 0x17000132 RID: 306
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x0005D27C File Offset: 0x0005B47C
		public new global::System.Drawing.Font Font
		{
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
				this.m_textFont = value;
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0005D2C0 File Offset: 0x0005B4C0
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			if (true)
			{
			}
			int num = 7;
			for (;;)
			{
				switch (num)
				{
				case 0:
					goto IL_10C;
				case 1:
					if (e.KeyCode == global::System.Windows.Forms.Keys.Left)
					{
						num = 11;
						continue;
					}
					goto IL_190;
				case 2:
					this.Value -= this.j;
					num = 5;
					continue;
				case 3:
					this.Value += this.j;
					num = 12;
					continue;
				case 4:
					goto IL_6A;
				case 5:
					goto IL_85;
				case 6:
					return;
				case 8:
					goto IL_190;
				case 9:
					goto IL_139;
				case 10:
					if (e.KeyCode == global::System.Windows.Forms.Keys.Right)
					{
						num = 4;
						continue;
					}
					goto IL_1DC;
				case 11:
					num = 15;
					continue;
				case 12:
					goto IL_10C;
				case 13:
					if (this.m_maxSide == global::custom_controls.Poles.Right)
					{
						num = 3;
						continue;
					}
					this.Value -= this.j;
					num = 0;
					continue;
				case 14:
					goto IL_85;
				case 15:
					if (this.m_maxSide == global::custom_controls.Poles.Right)
					{
						num = 2;
						continue;
					}
					this.Value += this.j;
					num = 14;
					continue;
				}
				if (!e.Alt)
				{
					num = 6;
					continue;
				}
				num = 1;
				continue;
				IL_6A:
				num = 13;
				continue;
				IL_10C:
				this.OnValueChanged();
				switch ((1 == 1) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6A;
				default:
					if (false)
					{
					}
					num = 9;
					continue;
				}
				IL_85:
				this.OnValueChanged();
				num = 8;
				continue;
				IL_190:
				num = 10;
			}
			return;
			IL_139:
			IL_1DC:
			base.OnKeyDown(e);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
		private void a()
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
			this.l = this.h.ToString(global::System.Globalization.NumberFormatInfo.CurrentInfo);
			this.m = this.i.ToString(global::System.Globalization.NumberFormatInfo.CurrentInfo);
			this.m_minLength = 0;
			this.m_maxLength = 0;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0005D528 File Offset: 0x0005B728
		protected override void OnLeave(global::System.EventArgs e)
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
			this.m_bHighlightControl = false;
			base.Invalidate();
			base.OnLeave(e);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0005D578 File Offset: 0x0005B778
		// Note: this type is marked as 'beforefieldinit'.
		static SliderBarControl()
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
			global::custom_controls.SliderBarControl.a = 0;
			global::custom_controls.SliderBarControl.b = 170;
			global::custom_controls.SliderBarControl.c = 240;
			global::custom_controls.SliderBarControl.LTD_STYLE_BLUE = global::System.Drawing.Color.FromArgb(global::custom_controls.SliderBarControl.a, global::custom_controls.SliderBarControl.b, global::custom_controls.SliderBarControl.c);
			global::custom_controls.SliderBarControl.WM_LBUTTONDOWN = 513;
			global::custom_controls.SliderBarControl.WM_LBUTTONUP = 514;
			global::custom_controls.SliderBarControl.WM_MOUSEMOVE = 512;
			global::custom_controls.SliderBarControl.MAX_MARGIN = 20;
		}

		// Token: 0x040004BA RID: 1210
		private static int a;

		// Token: 0x040004BB RID: 1211
		private static int b;

		// Token: 0x040004BC RID: 1212
		private static int c;

		// Token: 0x040004BD RID: 1213
		public static global::System.Drawing.Color LTD_STYLE_BLUE;

		// Token: 0x040004BE RID: 1214
		public static int WM_LBUTTONDOWN;

		// Token: 0x040004BF RID: 1215
		public static int WM_LBUTTONUP;

		// Token: 0x040004C0 RID: 1216
		public static int WM_MOUSEMOVE;

		// Token: 0x040004C1 RID: 1217
		public static int MAX_MARGIN;

		// Token: 0x040004C2 RID: 1218
		private int d;

		// Token: 0x040004C3 RID: 1219
		private bool e;

		// Token: 0x040004C4 RID: 1220
		private global::System.ComponentModel.Container f;

		// Token: 0x040004C5 RID: 1221
		public bool m_bHighlightControl;

		// Token: 0x040004C6 RID: 1222
		public bool m_bRaiseOnEnterEvent;

		// Token: 0x040004C7 RID: 1223
		protected global::System.Drawing.Rectangle m_trackRect;

		// Token: 0x040004C8 RID: 1224
		protected global::System.Drawing.Rectangle m_barRect;

		// Token: 0x040004C9 RID: 1225
		protected global::custom_controls.Poles m_maxSide;

		// Token: 0x040004CA RID: 1226
		private bool g;

		// Token: 0x040004CB RID: 1227
		protected global::System.Drawing.Font m_textFont;

		// Token: 0x040004CC RID: 1228
		protected global::System.Drawing.Brush m_textBrush;

		// Token: 0x040004CD RID: 1229
		protected global::System.Drawing.Image m_slider_bar;

		// Token: 0x040004CE RID: 1230
		protected global::System.Drawing.Image m_narrow;

		// Token: 0x040004CF RID: 1231
		protected int m_margin;

		// Token: 0x040004D0 RID: 1232
		protected int m_minLength;

		// Token: 0x040004D1 RID: 1233
		protected int m_maxLength;

		// Token: 0x040004D2 RID: 1234
		protected int m_trackSize;

		// Token: 0x040004D3 RID: 1235
		private decimal h;

		// Token: 0x040004D4 RID: 1236
		private decimal i;

		// Token: 0x040004D5 RID: 1237
		private decimal j;

		// Token: 0x040004D6 RID: 1238
		private decimal k;

		// Token: 0x040004D7 RID: 1239
		private string l;

		// Token: 0x040004D8 RID: 1240
		private string m;

		// Token: 0x040004D9 RID: 1241
		private global::custom_controls.SliderBarControl.ValueChangedEventHandler n;

		// Token: 0x040004DA RID: 1242
		private global::custom_controls.SliderBarControl.ScrollEventHandler o;

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x0600063A RID: 1594
		public delegate void ScrollEventHandler(object sender, global::System.EventArgs e);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600063E RID: 1598
		public delegate void ValueChangedEventHandler(object sender, global::System.EventArgs e);
	}
}
