using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000070 RID: 112
	[DesignerGenerated]
	public partial class Frm_MessageBox : Form
	{
		// Token: 0x060008AA RID: 2218 RVA: 0x000038FE File Offset: 0x00001AFE
		[DebuggerNonUserCode]
		public Frm_MessageBox()
		{
			base.Load += new EventHandler(this.Frm_MessageBox_Load);
			Frm_MessageBox.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0007890C File Offset: 0x00076B0C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_MessageBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_MessageBox.__ENCList.Count == Frm_MessageBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_MessageBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_MessageBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_MessageBox.__ENCList[num] = Frm_MessageBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_MessageBox.__ENCList.RemoveRange(num, Frm_MessageBox.__ENCList.Count - num);
						Frm_MessageBox.__ENCList.Capacity = Frm_MessageBox.__ENCList.Count;
					}
					Frm_MessageBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0007969C File Offset: 0x0007789C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x0000392A File Offset: 0x00001B2A
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x000796B4 File Offset: 0x000778B4
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00003934 File Offset: 0x00001B34
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x000796CC File Offset: 0x000778CC
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x000796E4 File Offset: 0x000778E4
		public virtual UIButton btn_no
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_no;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_no_Click);
				bool flag = this._btn_no != null;
				if (flag)
				{
					this._btn_no.Click -= value2;
				}
				this._btn_no = value;
				flag = (this._btn_no != null);
				if (flag)
				{
					this._btn_no.Click += value2;
				}
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00079744 File Offset: 0x00077944
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x0007975C File Offset: 0x0007795C
		public virtual UIButton btn_yes
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_yes;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_yes_Click);
				bool flag = this._btn_yes != null;
				if (flag)
				{
					this._btn_yes.Click -= value2;
				}
				this._btn_yes = value;
				flag = (this._btn_yes != null);
				if (flag)
				{
					this._btn_yes.Click += value2;
				}
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000797BC File Offset: 0x000779BC
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x000797D4 File Offset: 0x000779D4
		public virtual UIButton btn_cancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_cancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_cancel_Click);
				bool flag = this._btn_cancel != null;
				if (flag)
				{
					this._btn_cancel.Click -= value2;
				}
				this._btn_cancel = value;
				flag = (this._btn_cancel != null);
				if (flag)
				{
					this._btn_cancel.Click += value2;
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00079834 File Offset: 0x00077A34
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x0007984C File Offset: 0x00077A4C
		public virtual UIButton btn_ok
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_ok;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ok_Click);
				bool flag = this._btn_ok != null;
				if (flag)
				{
					this._btn_ok.Click -= value2;
				}
				this._btn_ok = value;
				flag = (this._btn_ok != null);
				if (flag)
				{
					this._btn_ok.Click += value2;
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000798AC File Offset: 0x00077AAC
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x0000393E File Offset: 0x00001B3E
		public virtual PictureBox pic_warning
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pic_warning;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pic_warning = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x000798C4 File Offset: 0x00077AC4
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00003948 File Offset: 0x00001B48
		public virtual PictureBox pic_error
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pic_error;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pic_error = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x000798DC File Offset: 0x00077ADC
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00003952 File Offset: 0x00001B52
		public virtual PictureBox pic_question
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pic_question;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pic_question = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x000798F4 File Offset: 0x00077AF4
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x0000395C File Offset: 0x00001B5C
		public virtual PictureBox pic_info
		{
			[DebuggerNonUserCode]
			get
			{
				return this._pic_info;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._pic_info = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0007990C File Offset: 0x00077B0C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00003966 File Offset: 0x00001B66
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00079924 File Offset: 0x00077B24
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0007993C File Offset: 0x00077B3C
		public virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0007999C File Offset: 0x00077B9C
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x000799B4 File Offset: 0x00077BB4
		public virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_cancel_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00079A14 File Offset: 0x00077C14
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00003970 File Offset: 0x00001B70
		public ErrorListManager ErrorList
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ErrorList;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ErrorList = value;
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0000397A File Offset: 0x00001B7A
		private void btn_yes_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Yes;
			this.Close();
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0000398D File Offset: 0x00001B8D
		private void btn_no_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x000039A0 File Offset: 0x00001BA0
		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000039B3 File Offset: 0x00001BB3
		private void btn_ok_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00079A2C File Offset: 0x00077C2C
		private void Frm_MessageBox_Load(object sender, EventArgs e)
		{
			bool flag = this.ErrorList != null;
			if (flag)
			{
				bool flag2 = this.ErrorList.List.Count > 0;
				if (flag2)
				{
					this.UiButton1.Visible = true;
				}
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00079A74 File Offset: 0x00077C74
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Frm_Error frm_Error = new Frm_Error();
			frm_Error.ShowDialog(this.ErrorList);
		}

		// Token: 0x04000361 RID: 865
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000363 RID: 867
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000364 RID: 868
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000365 RID: 869
		[AccessedThroughProperty("btn_no")]
		private UIButton _btn_no;

		// Token: 0x04000366 RID: 870
		[AccessedThroughProperty("btn_yes")]
		private UIButton _btn_yes;

		// Token: 0x04000367 RID: 871
		[AccessedThroughProperty("btn_cancel")]
		private UIButton _btn_cancel;

		// Token: 0x04000368 RID: 872
		[AccessedThroughProperty("btn_ok")]
		private UIButton _btn_ok;

		// Token: 0x04000369 RID: 873
		[AccessedThroughProperty("pic_warning")]
		private PictureBox _pic_warning;

		// Token: 0x0400036A RID: 874
		[AccessedThroughProperty("pic_error")]
		private PictureBox _pic_error;

		// Token: 0x0400036B RID: 875
		[AccessedThroughProperty("pic_question")]
		private PictureBox _pic_question;

		// Token: 0x0400036C RID: 876
		[AccessedThroughProperty("pic_info")]
		private PictureBox _pic_info;

		// Token: 0x0400036D RID: 877
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400036E RID: 878
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400036F RID: 879
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000370 RID: 880
		[CompilerGenerated]
		private ErrorListManager _ErrorList;
	}
}
