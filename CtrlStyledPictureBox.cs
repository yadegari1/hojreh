using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B6 RID: 182
	public class CtrlStyledPictureBox : PictureBox, IControlWithBorder
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x000A9BC4 File Offset: 0x000A7DC4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledPictureBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledPictureBox.__ENCList.Count == CtrlStyledPictureBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledPictureBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledPictureBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledPictureBox.__ENCList[num] = CtrlStyledPictureBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledPictureBox.__ENCList.RemoveRange(num, CtrlStyledPictureBox.__ENCList.Count - num);
						CtrlStyledPictureBox.__ENCList.Capacity = CtrlStyledPictureBox.__ENCList.Count;
					}
					CtrlStyledPictureBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00005351 File Offset: 0x00003551
		public CtrlStyledPictureBox()
		{
			CtrlStyledPictureBox.__ENCAddToList(this);
			this.borderDrawer = new BorderDrawer();
			this.borderDrawer.RegisterFocusHoverControl(this);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000A9CC8 File Offset: 0x000A7EC8
		public void RefreshNullableImage(bool isNull)
		{
			if (isNull)
			{
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x000A9CE0 File Offset: 0x000A7EE0
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			bool flag = base.BorderStyle != BorderStyle.None;
			if (flag)
			{
				this.borderDrawer.DrawBorder(ref m, base.Width, base.Height);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x000A9D24 File Offset: 0x000A7F24
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x000A9D44 File Offset: 0x000A7F44
		public Color BorderColor
		{
			get
			{
				return this.borderDrawer.BorderColor;
			}
			set
			{
				this.borderDrawer.BorderColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x040005C1 RID: 1473
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005C2 RID: 1474
		protected BorderDrawer borderDrawer;
	}
}
