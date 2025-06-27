using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B8 RID: 184
	public class CtrlStyledTextBox : TextBox, IControlWithBorder, IEndEditToDataBinding
	{
		// Token: 0x06000EC9 RID: 3785 RVA: 0x000A9E84 File Offset: 0x000A8084
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStyledTextBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStyledTextBox.__ENCList.Count == CtrlStyledTextBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStyledTextBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStyledTextBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStyledTextBox.__ENCList[num] = CtrlStyledTextBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStyledTextBox.__ENCList.RemoveRange(num, CtrlStyledTextBox.__ENCList.Count - num);
						CtrlStyledTextBox.__ENCList.Capacity = CtrlStyledTextBox.__ENCList.Count;
					}
					CtrlStyledTextBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x000A9F88 File Offset: 0x000A8188
		public CtrlStyledTextBox()
		{
			CtrlStyledTextBox.__ENCAddToList(this);
			this._ConvertEnterToTab = true;
			this.borderDrawer = new BorderDrawer();
			base.BorderStyle = BorderStyle.FixedSingle;
			this.ShortcutsEnabled = true;
			this.borderDrawer.RegisterFocusHoverControl(this);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000053BB File Offset: 0x000035BB
		public void EndEditToDataBinding(ContainerControl mainControl)
		{
			mainControl.ActiveControl = null;
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000A9FD4 File Offset: 0x000A81D4
		private Color GetParentColor(Control c)
		{
			bool flag = !(c.BackColor == Color.Transparent);
			Color result;
			if (flag)
			{
				result = c.BackColor;
			}
			else
			{
				flag = (c.Parent == null);
				if (flag)
				{
					result = Color.White;
				}
				else
				{
					result = this.GetParentColor(c.Parent);
				}
			}
			return result;
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000053C7 File Offset: 0x000035C7
		protected override void OnLocationChanged(EventArgs e)
		{
			base.OnLocationChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000053DA File Offset: 0x000035DA
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Invalidate();
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000AA02C File Offset: 0x000A822C
		public Control PreviousControl()
		{
			Form form = base.FindForm();
			Control control = this;
			do
			{
				control = form.GetNextControl(control, false);
			}
			while (control != null && !control.TabStop);
			return control;
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000AA068 File Offset: 0x000A8268
		protected override bool ProcessCmdKey(ref Message m, Keys k)
		{
			bool flag = m.Msg == 256 && k == Keys.Return && !base.AcceptsReturn && this.ConvertEnterToTab;
			checked
			{
				bool result;
				if (flag)
				{
					Form form = base.FindForm();
					flag = (!this.ConvertEnterToTabForDialogs && form != null && form.AcceptButton != null);
					if (flag)
					{
						result = base.ProcessCmdKey(ref m, k);
					}
					else
					{
						SendKeys.Send("\t");
						result = true;
					}
				}
				else
				{
					flag = (m.Msg != 256 || k != (Keys.Back | Keys.Control));
					if (flag)
					{
						result = base.ProcessCmdKey(ref m, k);
					}
					else
					{
						flag = (this.Text.Length != 0);
						if (flag)
						{
							bool flag2 = this.Text.LastIndexOf(' ') == this.Text.Length - 1;
							if (flag2)
							{
								int num = this.Text.Substring(0, this.Text.Length - 1).LastIndexOf(' ');
								flag2 = (num < 0);
								if (flag2)
								{
									num = 0;
								}
								this.Text = this.Text.Remove(num);
							}
							else
							{
								this.Text = this.Text.Remove(this.Text.LastIndexOf(' ') + 1);
							}
							base.SelectionStart = this.Text.Length;
							this.SelectionLength = 0;
						}
						result = true;
					}
				}
				return result;
			}
		}

		// Token: 0x06000ED1 RID: 3793
		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		public static extern IntPtr SendMessage(HandleRef hWnd, int msg, IntPtr wParam, IntPtr lParam);

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000AA1D4 File Offset: 0x000A83D4
		public IntPtr SendMessageToMe(int msg, IntPtr wParam, IntPtr lParam)
		{
			HandleRef hWnd = new HandleRef(base.Handle, base.Handle);
			return CtrlStyledTextBox.SendMessage(hWnd, msg, wParam, lParam);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000AA208 File Offset: 0x000A8408
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			bool flag = base.BorderStyle != BorderStyle.None && base.Visible;
			if (flag)
			{
				this.borderDrawer.DrawBorder(ref m, base.Width, base.Height);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000AA254 File Offset: 0x000A8454
		// (set) Token: 0x06000ED5 RID: 3797 RVA: 0x000AA26C File Offset: 0x000A846C
		public override Color BackColor
		{
			get
			{
				return base.BackColor;
			}
			set
			{
				bool flag = value == Color.Transparent;
				if (flag)
				{
					bool flag2 = base.Parent == null;
					if (flag2)
					{
						base.BackColor = Color.White;
					}
					else
					{
						base.BackColor = this.GetParentColor(base.Parent);
					}
				}
				else
				{
					base.BackColor = value;
				}
				base.Invalidate();
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		// (set) Token: 0x06000ED7 RID: 3799 RVA: 0x0000205D File Offset: 0x0000025D
		public Color BorderColor
		{
			get
			{
				return this.borderDrawer.BorderColor;
			}
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x000AA2F0 File Offset: 0x000A84F0
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x000053ED File Offset: 0x000035ED
		public bool ConvertEnterToTab
		{
			get
			{
				return this._ConvertEnterToTab;
			}
			set
			{
				this._ConvertEnterToTab = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x000AA308 File Offset: 0x000A8508
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x000053F8 File Offset: 0x000035F8
		public bool ConvertEnterToTabForDialogs
		{
			get
			{
				return this._ConvertEnterToTabForDialogs;
			}
			set
			{
				this._ConvertEnterToTabForDialogs = value;
			}
		}

		// Token: 0x040005C4 RID: 1476
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005C5 RID: 1477
		private bool _ConvertEnterToTab;

		// Token: 0x040005C6 RID: 1478
		private bool _ConvertEnterToTabForDialogs;

		// Token: 0x040005C7 RID: 1479
		protected BorderDrawer borderDrawer;
	}
}
