using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000091 RID: 145
	public class DateBox : MaskedEditBox
	{
		// Token: 0x06000CCC RID: 3276 RVA: 0x0009F440 File Offset: 0x0009D640
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DateBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DateBox.__ENCList.Count == DateBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DateBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DateBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DateBox.__ENCList[num] = DateBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DateBox.__ENCList.RemoveRange(num, DateBox.__ENCList.Count - num);
						DateBox.__ENCList.Capacity = DateBox.__ENCList.Count;
					}
					DateBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0009F544 File Offset: 0x0009D744
		[DebuggerNonUserCode]
		public DateBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x0009F570 File Offset: 0x0009D770
		[DebuggerNonUserCode]
		public DateBox()
		{
			DateBox.__ENCAddToList(this);
			this.ShortcutsEnabled = false;
			this.Nullable = true;
			this.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.AllowNew = true;
			this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Mask = "####/##/##";
			this.RightToLeft = RightToLeft.No;
			this.TextAlignment = TextAlignment.Near;
			this.InitializeComponent();
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x000048E0 File Offset: 0x00002AE0
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x0009F62C File Offset: 0x0009D82C
		// (set) Token: 0x06000CD2 RID: 3282 RVA: 0x000048EF File Offset: 0x00002AEF
		[Category("ExtendProperty")]
		public bool AllowNew
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowNew;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowNew = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x0009F644 File Offset: 0x0009D844
		// (set) Token: 0x06000CD4 RID: 3284 RVA: 0x000048F9 File Offset: 0x00002AF9
		[Category("ExtendProperty")]
		public bool Nullable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Nullable;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Nullable = value;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x0009F65C File Offset: 0x0009D85C
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00004903 File Offset: 0x00002B03
		[Category("ExtendProperty")]
		public string NullToolTipText
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NullToolTipText;
			}
			[DebuggerNonUserCode]
			set
			{
				this._NullToolTipText = value;
			}
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0000490D File Offset: 0x00002B0D
		public void SetNew()
		{
			this.Text = string.Empty;
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0009F674 File Offset: 0x0009D874
		public void RaiseSoftError()
		{
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.BodyWidth = 250;
			janusSuperTip.RightToLeft = true;
			janusSuperTip.AutoPopDelay = 0;
			janusSuperTip.InitialDelay = 0;
			janusSuperTip.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.Text = this.NullToolTipText;
			Rectangle bounds = this.Bounds;
			bounds.Location = this.Parent.PointToScreen(bounds.Location);
			superTipSettings.HeaderImage = Resources.onebit_36;
			superTipSettings.HeaderText = "خطا";
			JanusSuperTip arg_B4_0 = janusSuperTip;
			SuperTipSettings arg_B4_1 = superTipSettings;
			Point position = new Point(bounds.Left, bounds.Bottom);
			arg_B4_0.Show(arg_B4_1, this, position, 1500);
			this.Focus();
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0009F744 File Offset: 0x0009D944
		public bool NullCheck()
		{
			bool flag = this.Visible && this.Nullable && Operators.CompareString(this.Text, string.Empty, false) != 0;
			bool flag2;
			bool result;
			if (flag)
			{
				flag2 = !Public_Function.IsValidShamsiDate(this.Text);
				if (flag2)
				{
					this.ShowTip("تاریخ وارد شده معتبر نمیباشد");
					this.Focus();
					result = true;
					return result;
				}
			}
			flag2 = (this.Visible && !this.Nullable);
			if (flag2)
			{
				flag = (Operators.CompareString(this.Text, string.Empty, false) == 0);
				if (flag)
				{
					this.RaiseSoftError();
					result = true;
					return result;
				}
				flag2 = !Public_Function.IsValidShamsiDate(this.Text);
				if (flag2)
				{
					this.ShowTip("تاریخ وارد شده معتبر نمیباشد");
					this.Focus();
					result = true;
					return result;
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0009F81C File Offset: 0x0009DA1C
		public void ShowTip(string Text)
		{
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.RightToLeft = true;
			janusSuperTip.AutoPopDelay = 0;
			janusSuperTip.InitialDelay = 0;
			janusSuperTip.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.Text = Text;
			Rectangle bounds = this.Bounds;
			bounds.Location = this.Parent.PointToScreen(bounds.Location);
			JanusSuperTip arg_8B_0 = janusSuperTip;
			SuperTipSettings arg_8B_1 = superTipSettings;
			Point position = new Point(bounds.Left, bounds.Bottom);
			arg_8B_0.Show(arg_8B_1, this, position, 1500);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0009F8BC File Offset: 0x0009DABC
		public virtual void me_keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.Parent.SelectNextControl((Control)sender, true, true, true, true);
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0009F8F0 File Offset: 0x0009DAF0
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 770;
			if (flag)
			{
				base.WndProc(ref m);
			}
		}

		// Token: 0x040004E6 RID: 1254
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004E7 RID: 1255
		private IContainer components;

		// Token: 0x040004E8 RID: 1256
		[CompilerGenerated]
		private bool _AllowNew;

		// Token: 0x040004E9 RID: 1257
		[CompilerGenerated]
		private bool _Nullable;

		// Token: 0x040004EA RID: 1258
		[CompilerGenerated]
		private string _NullToolTipText;
	}
}
