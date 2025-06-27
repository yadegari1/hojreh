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
    // Token: 0x02000096 RID: 150
    public class EditBox : Janus.Windows.GridEX.EditControls.EditBox
    {
		// Token: 0x06000D76 RID: 3446 RVA: 0x000A4040 File Offset: 0x000A2240
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = EditBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = EditBox.__ENCList.Count == EditBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = EditBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = EditBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									EditBox.__ENCList[num] = EditBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						EditBox.__ENCList.RemoveRange(num, EditBox.__ENCList.Count - num);
						EditBox.__ENCList.Capacity = EditBox.__ENCList.Count;
					}
					EditBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000A4144 File Offset: 0x000A2344
		[DebuggerNonUserCode]
		public EditBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000A4170 File Offset: 0x000A2370
		[DebuggerNonUserCode]
		public EditBox()
		{
			EditBox.__ENCAddToList(this);
			bool flag = true;
			this.FocusColor = flag;
			flag = true;
			this.AllowEdit = flag;
			flag = true;
			this.AcceptEnter = flag;
			this.KeyDown += new KeyEventHandler(this.me_keydown);
			this.KeyPress += new KeyPressEventHandler(this.me_keypress);
			this.GotFocus += new EventHandler(this.me_gotfocus);
			this.LostFocus += new EventHandler(this.me_lostFocus);
			this.ShortcutsEnabled = false;
			this.Nullable = true;
			this.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.AllowNew = true;
			this.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
			this.InitializeComponent();
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000A4230 File Offset: 0x000A2430
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
			catch (Exception expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				ProjectData.ClearProjectError();
			}
			finally
			{
			}
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00004C91 File Offset: 0x00002E91
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000A4294 File Offset: 0x000A2494
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x00004CA0 File Offset: 0x00002EA0
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

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x000A42AC File Offset: 0x000A24AC
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x00004CAA File Offset: 0x00002EAA
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

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D7F RID: 3455 RVA: 0x000A42C4 File Offset: 0x000A24C4
		// (set) Token: 0x06000D80 RID: 3456 RVA: 0x00004CB4 File Offset: 0x00002EB4
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

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000D81 RID: 3457 RVA: 0x000A42DC File Offset: 0x000A24DC
		// (set) Token: 0x06000D82 RID: 3458 RVA: 0x00004CBE File Offset: 0x00002EBE
		[Category("ExtendProperty")]
		public bool FocusColor
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FocusColor;
			}
			[DebuggerNonUserCode]
			set
			{
				this._FocusColor = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000D83 RID: 3459 RVA: 0x000A42F4 File Offset: 0x000A24F4
		// (set) Token: 0x06000D84 RID: 3460 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Category("ExtendProperty")]
		public bool AllowEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowEdit;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowEdit = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000D85 RID: 3461 RVA: 0x000A430C File Offset: 0x000A250C
		// (set) Token: 0x06000D86 RID: 3462 RVA: 0x00004CD2 File Offset: 0x00002ED2
		[Category("ExtendProperty")]
		public bool AcceptEnter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AcceptEnter;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AcceptEnter = value;
			}
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00004CDC File Offset: 0x00002EDC
		public void SetNew()
		{
			this.Text = string.Empty;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x000A4324 File Offset: 0x000A2524
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
			arg_B4_0.Show(arg_B4_1, this, position, 2500);
			this.Focus();
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x000A43F4 File Offset: 0x000A25F4
		public bool NullCheck()
		{
			bool flag = this.Visible && !this.Nullable && Operators.CompareString(this.Text, string.Empty, false) == 0;
			bool result;
			if (flag)
			{
				this.RaiseSoftError();
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x0009D2C8 File Offset: 0x0009B4C8
		public void ShowTip(string Text)
		{
			this.Focus();
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.RightToLeft = true;
			janusSuperTip.AutoPopDelay = 0;
			janusSuperTip.InitialDelay = 0;
			janusSuperTip.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.HeaderImage = Resources.onebit_36;
			superTipSettings.HeaderText = "خطا";
			superTipSettings.Text = Text;
			Rectangle bounds = this.Bounds;
			bounds.Location = this.Parent.PointToScreen(bounds.Location);
			JanusSuperTip arg_AA_0 = janusSuperTip;
			SuperTipSettings arg_AA_1 = superTipSettings;
			Point position = new Point(bounds.Left, bounds.Bottom);
			arg_AA_0.Show(arg_AA_1, this, position, 2500);
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x0000205D File Offset: 0x0000025D
		public virtual void me_keypress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000A4444 File Offset: 0x000A2644
		public virtual void me_keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			bool flag2;
			if (flag)
			{
				flag2 = !this.AcceptEnter;
				if (flag2)
				{
					return;
				}
				flag2 = (this.Parent == null);
				if (flag2)
				{
					return;
				}
				this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
			}
			flag2 = (e.KeyCode == Keys.Up);
			if (flag2)
			{
				flag = (this.Parent == null);
				if (flag)
				{
					return;
				}
				flag2 = (this.Parent.Parent != null);
				if (flag2)
				{
					flag = (this.Parent.Parent is GridEX);
					if (flag)
					{
						return;
					}
				}
				this.ParentForm.SelectNextControl((Control)sender, false, true, true, true);
			}
			flag2 = (e.KeyCode == Keys.Down);
			if (flag2)
			{
				flag = (this.Parent == null);
				if (flag)
				{
					return;
				}
				flag2 = (this.Parent.Parent != null);
				if (flag2)
				{
					flag = (this.Parent.Parent is GridEX);
					if (flag)
					{
						return;
					}
				}
				this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
			}
			flag2 = !this.AllowEdit;
			if (flag2)
			{
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000A458C File Offset: 0x000A278C
		public virtual void me_gotfocus(object sender, EventArgs e)
		{
			bool focusColor = this.FocusColor;
			if (focusColor)
			{
				this.BackColor = Color.LightBlue;
			}
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000A45B4 File Offset: 0x000A27B4
		public virtual void me_lostFocus(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x0009F8F0 File Offset: 0x0009DAF0
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 770;
			if (flag)
			{
				base.WndProc(ref m);
			}
		}

		// Token: 0x04000536 RID: 1334
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000537 RID: 1335
		private IContainer components;

		// Token: 0x04000538 RID: 1336
		[CompilerGenerated]
		private bool _AllowNew;

		// Token: 0x04000539 RID: 1337
		[CompilerGenerated]
		private bool _Nullable;

		// Token: 0x0400053A RID: 1338
		[CompilerGenerated]
		private string _NullToolTipText;

		// Token: 0x0400053B RID: 1339
		[CompilerGenerated]
		private bool _FocusColor;

		// Token: 0x0400053C RID: 1340
		[CompilerGenerated]
		private bool _AllowEdit;

		// Token: 0x0400053D RID: 1341
		[CompilerGenerated]
		private bool _AcceptEnter;
	}
}
