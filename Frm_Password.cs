using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000072 RID: 114
	[DesignerGenerated]
	public partial class Frm_Password : Form
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x0007A744 File Offset: 0x00078944
		public Frm_Password()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Password_KeyDown);
			Frm_Password.__ENCAddToList(this);
			int auth_type = 1;
			this.Auth_type = auth_type;
			this.user = new base_user();
			this.InitializeComponent();
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0007A790 File Offset: 0x00078990
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Password.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Password.__ENCList.Count == Frm_Password.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Password.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Password.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Password.__ENCList[num] = Frm_Password.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Password.__ENCList.RemoveRange(num, Frm_Password.__ENCList.Count - num);
						Frm_Password.__ENCList.Capacity = Frm_Password.__ENCList.Count;
					}
					Frm_Password.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0007AF00 File Offset: 0x00079100
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00003A3E File Offset: 0x00001C3E
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0007AF18 File Offset: 0x00079118
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00003A48 File Offset: 0x00001C48
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._EditBox1 = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0007AF30 File Offset: 0x00079130
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00003A52 File Offset: 0x00001C52
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

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0007AF48 File Offset: 0x00079148
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x0007AF60 File Offset: 0x00079160
		internal virtual ButtonX ButtonX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonX1_Click);
				bool flag = this._ButtonX1 != null;
				if (flag)
				{
					this._ButtonX1.Click -= value2;
				}
				this._ButtonX1 = value;
				flag = (this._ButtonX1 != null);
				if (flag)
				{
					this._ButtonX1.Click += value2;
				}
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0007AFC0 File Offset: 0x000791C0
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00003A5C File Offset: 0x00001C5C
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

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0007AFD8 File Offset: 0x000791D8
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x0007AFF0 File Offset: 0x000791F0
		internal virtual ButtonX ButtonX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonX2_Click);
				bool flag = this._ButtonX2 != null;
				if (flag)
				{
					this._ButtonX2.Click -= value2;
				}
				this._ButtonX2 = value;
				flag = (this._ButtonX2 != null);
				if (flag)
				{
					this._ButtonX2.Click += value2;
				}
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0007B050 File Offset: 0x00079250
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00003A66 File Offset: 0x00001C66
		public int Auth_type
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Auth_type;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Auth_type = value;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0007B068 File Offset: 0x00079268
		private void ButtonX1_Click(object sender, EventArgs e)
		{
			bool flag = this.Auth_type == 1;
			bool flag2;
			if (flag)
			{
				flag2 = this.user.Login(MyProject.Forms.Form_Main.txt_user.SelectedItem.Text, this.EditBox1.Text);
				if (flag2)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Public_Function.ShowMessage("گذر واژه اشتباه میباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					this.EditBox1.Text = string.Empty;
					this.EditBox1.Focus();
				}
			}
			flag2 = (this.Auth_type == 2);
			if (flag2)
			{
				flag = (Operators.CompareString(this.EditBox1.Text, Public_Function.dict["pidkey"], false) == 0);
				if (flag)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Public_Function.ShowMessage("گذر واژه اشتباه میباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					this.EditBox1.Text = string.Empty;
					this.EditBox1.Focus();
				}
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0007B16C File Offset: 0x0007936C
		private void Frm_Password_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x000039A0 File Offset: 0x00001BA0
		private void ButtonX2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		// Token: 0x0400037E RID: 894
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000380 RID: 896
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000381 RID: 897
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04000382 RID: 898
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000383 RID: 899
		[AccessedThroughProperty("ButtonX1")]
		private ButtonX _ButtonX1;

		// Token: 0x04000384 RID: 900
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000385 RID: 901
		[AccessedThroughProperty("ButtonX2")]
		private ButtonX _ButtonX2;

		// Token: 0x04000386 RID: 902
		[CompilerGenerated]
		private int _Auth_type;

		// Token: 0x04000387 RID: 903
		private base_user user;
	}
}
