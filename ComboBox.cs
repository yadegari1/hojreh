using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common;
using Janus.Windows.EditControls;
using Janus.Windows.UI;

namespace FruitBox
{
	// Token: 0x0200008E RID: 142
	public class ComboBox : UIComboBox
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x0009E8DC File Offset: 0x0009CADC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = ComboBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = ComboBox.__ENCList.Count == ComboBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = ComboBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = ComboBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									ComboBox.__ENCList[num] = ComboBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						ComboBox.__ENCList.RemoveRange(num, ComboBox.__ENCList.Count - num);
						ComboBox.__ENCList.Capacity = ComboBox.__ENCList.Count;
					}
					ComboBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x0009E9E0 File Offset: 0x0009CBE0
		[DebuggerNonUserCode]
		public ComboBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x0009EA0C File Offset: 0x0009CC0C
		[DebuggerNonUserCode]
		public ComboBox()
		{
			ComboBox.__ENCAddToList(this);
			this.KeyDown += new KeyEventHandler(this.me_keydown);
			this.Nullable = true;
			this.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.AllowNew = true;
			this.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.InitializeComponent();
			base.Text = string.Empty;
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x0009EA74 File Offset: 0x0009CC74
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

		// Token: 0x06000CAD RID: 3245 RVA: 0x00004858 File Offset: 0x00002A58
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00004867 File Offset: 0x00002A67
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

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0009EADC File Offset: 0x0009CCDC
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00004871 File Offset: 0x00002A71
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

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0009EAF4 File Offset: 0x0009CCF4
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x0000487B File Offset: 0x00002A7B
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

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00004885 File Offset: 0x00002A85
		public void SetNew()
		{
			this.SelectedValue = null;
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0009EB0C File Offset: 0x0009CD0C
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

		// Token: 0x06000CB6 RID: 3254 RVA: 0x0009EBDC File Offset: 0x0009CDDC
		public bool NullCheck()
		{
			bool flag = this.Visible && !this.Nullable && this.SelectedItem == null;
			bool result;
			if (flag)
			{
				this.RaiseSoftError();
				result = true;
			}
			else
			{
				flag = (this.Visible && !this.Nullable && this.SelectedItem == null && this.SelectedValue != null);
				if (flag)
				{
					this.ShowTip("اطلاعات وارد شده نامعتبر میباشد");
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0009EC58 File Offset: 0x0009CE58
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
			JanusSuperTip arg_86_0 = janusSuperTip;
			SuperTipSettings arg_86_1 = superTipSettings;
			Point position = new Point(bounds.Left, bounds.Bottom);
			arg_86_0.Show(arg_86_1, this, position);
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x0009ECF4 File Offset: 0x0009CEF4
		public virtual void me_keydown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x0009ED28 File Offset: 0x0009CF28
		protected override void WndProc(ref Message m)
		{
			bool flag = m.Msg != 770;
			if (flag)
			{
				base.WndProc(ref m);
			}
		}

		// Token: 0x040004DC RID: 1244
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004DD RID: 1245
		private IContainer components;

		// Token: 0x040004DE RID: 1246
		[CompilerGenerated]
		private bool _AllowNew;

		// Token: 0x040004DF RID: 1247
		[CompilerGenerated]
		private bool _Nullable;

		// Token: 0x040004E0 RID: 1248
		[CompilerGenerated]
		private string _NullToolTipText;
	}
}
