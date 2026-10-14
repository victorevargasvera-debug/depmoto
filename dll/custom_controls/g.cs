using System;
using System.Drawing;

namespace custom_controls
{
	// Token: 0x0200003B RID: 59
	internal class g : global::System.IDisposable
	{
		// Token: 0x06000305 RID: 773 RVA: 0x00036588 File Offset: 0x00034788
		public int f()
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
			return this.c;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000365D0 File Offset: 0x000347D0
		public global::System.Drawing.Rectangle c()
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
			return this.a;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00036618 File Offset: 0x00034818
		public global::System.Drawing.Rectangle b()
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
			this.a();
			return this.b;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00036660 File Offset: 0x00034860
		public void a(global::System.Drawing.Rectangle A_0)
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
			this.a();
			this.b = A_0;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000366A8 File Offset: 0x000348A8
		public global::System.Drawing.Image g()
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
			return this.d;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000366F0 File Offset: 0x000348F0
		public global::System.Drawing.Point d()
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
			return this.e;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00036738 File Offset: 0x00034938
		public g(int A_0, global::System.Drawing.Rectangle A_1, global::System.Drawing.Point A_2, global::System.Drawing.Image A_3)
		{
			this.c = A_0;
			this.a = A_1;
			this.b = A_1;
			this.e = A_2;
			this.d = A_3;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00036770 File Offset: 0x00034970
		public g(int A_0, global::System.Drawing.Rectangle A_1, global::System.Drawing.Point A_2) : this(A_0, A_1, A_2, null)
		{
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00036788 File Offset: 0x00034988
		public void e()
		{
			int num = 4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.a = global::System.Drawing.Rectangle.Empty;
					this.b = global::System.Drawing.Rectangle.Empty;
					this.c = -1;
					this.e = global::System.Drawing.Point.Empty;
					num = 2;
					continue;
				case 1:
					this.d.Dispose();
					num = 3;
					continue;
				case 2:
					if (this.d != null)
					{
						num = 1;
						continue;
					}
					goto IL_61;
				case 3:
					goto IL_61;
				case 5:
					return;
				}
				while (!this.f)
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
						num = 0;
						goto IL_0A;
					}
				}
				break;
				IL_61:
				this.f = true;
				num = 5;
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00036874 File Offset: 0x00034A74
		private void a()
		{
			if (this.f)
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
					if (true)
					{
					}
					throw new global::System.ObjectDisposedException("DraggedDataGridRow object has already been disposed.");
				}
			}
		}

		// Token: 0x040001CD RID: 461
		private global::System.Drawing.Rectangle a;

		// Token: 0x040001CE RID: 462
		private global::System.Drawing.Rectangle b;

		// Token: 0x040001CF RID: 463
		private int c;

		// Token: 0x040001D0 RID: 464
		private global::System.Drawing.Image d;

		// Token: 0x040001D1 RID: 465
		private global::System.Drawing.Point e;

		// Token: 0x040001D2 RID: 466
		private bool f;
	}
}
