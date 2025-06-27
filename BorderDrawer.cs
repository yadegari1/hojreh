using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B0 RID: 176
	[DebuggerStepThrough]
	public class BorderDrawer
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x000051E8 File Offset: 0x000033E8
		public BorderDrawer()
		{
			this._borderColor = BorderDrawer.BORDER_UNFOCUS_COLOR;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x000A75E4 File Offset: 0x000A57E4
		private void ctrl_GotFocus(object sender, EventArgs e)
		{
			this.BorderColor = BorderDrawer.BORDER_FOCUS_COLOR;
			((Control)sender).Invalidate();
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x000A760C File Offset: 0x000A580C
		private void ctrl_LostFocus(object sender, EventArgs e)
		{
			this.BorderColor = BorderDrawer.BORDER_UNFOCUS_COLOR;
			((Control)sender).Invalidate();
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x000051FD File Offset: 0x000033FD
		public void DrawBorder(ref Message message, int width, int height)
		{
			this.DrawBorder(ref message, 0, 0, width, height);
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x000A7634 File Offset: 0x000A5834
		public void DrawBorder(ref Message message, int x, int y, int width, int height)
		{
			bool flag = message.Msg == 15;
			if (flag)
			{
				IntPtr windowDC = BorderDrawer.GetWindowDC(message.HWnd);
				flag = (windowDC != IntPtr.Zero);
				if (flag)
				{
					Graphics graphics = Graphics.FromHdc(windowDC);
					Rectangle bounds = new Rectangle(x, y, width, height);
					ControlPaint.DrawBorder(graphics, bounds, this.BorderColor, ButtonBorderStyle.Solid);
					message.Result = (IntPtr)1;
					BorderDrawer.ReleaseDC(message.HWnd, windowDC);
					graphics.Dispose();
				}
			}
		}

		// Token: 0x06000E6C RID: 3692
		[DllImport("user32.dll")]
		private static extern IntPtr GetDCEx(IntPtr hwnd, IntPtr hrgnclip, uint fdwOptions);

		// Token: 0x06000E6D RID: 3693
		[DllImport("user32.dll")]
		private static extern IntPtr GetWindowDC(IntPtr hwnd);

		// Token: 0x06000E6E RID: 3694 RVA: 0x0000520D File Offset: 0x0000340D
		public void RegisterFocusHoverControl(Control ctrl)
		{
			ctrl.GotFocus += new EventHandler(this.ctrl_GotFocus);
			ctrl.LostFocus += new EventHandler(this.ctrl_LostFocus);
		}

		// Token: 0x06000E6F RID: 3695
		[DllImport("user32.dll")]
		private static extern int ReleaseDC(IntPtr hwnd, IntPtr hDC);

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E70 RID: 3696 RVA: 0x000A76B8 File Offset: 0x000A58B8
		// (set) Token: 0x06000E71 RID: 3697 RVA: 0x00005239 File Offset: 0x00003439
		public Color BorderColor
		{
			get
			{
				return this._borderColor;
			}
			set
			{
				this._borderColor = value;
			}
		}

		// Token: 0x04000582 RID: 1410
		public static Color BORDER_FOCUS_COLOR = Color.DarkGray;

		// Token: 0x04000583 RID: 1411
		public static Color BORDER_UNFOCUS_COLOR = Color.LightGray;

		// Token: 0x04000584 RID: 1412
		private Color _borderColor;
	}
}
