using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000075 RID: 117
	[DesignerGenerated]
	public partial class Frm_Register : Form
	{
		// Token: 0x06000943 RID: 2371 RVA: 0x00003BC1 File Offset: 0x00001DC1
		public Frm_Register()
		{
			base.Load += new EventHandler(this.Frm_Register_Load);
			Frm_Register.__ENCAddToList(this);
			this.fp = new fp();
			this.InitializeComponent();
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0007C958 File Offset: 0x0007AB58
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Register.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Register.__ENCList.Count == Frm_Register.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Register.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Register.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Register.__ENCList[num] = Frm_Register.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Register.__ENCList.RemoveRange(num, Frm_Register.__ENCList.Count - num);
						Frm_Register.__ENCList.Capacity = Frm_Register.__ENCList.Count;
					}
					Frm_Register.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0007DA94 File Offset: 0x0007BC94
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x00003BF8 File Offset: 0x00001DF8
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

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0007DAAC File Offset: 0x0007BCAC
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x00003C02 File Offset: 0x00001E02
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

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0007DAC4 File Offset: 0x0007BCC4
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x00003C0C File Offset: 0x00001E0C
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0007DADC File Offset: 0x0007BCDC
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0007DAF4 File Offset: 0x0007BCF4
		internal virtual EditBox EditBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_Leave);
				EventHandler value3 = new EventHandler(this.EditBox2_Enter);
				bool flag = this._EditBox2 != null;
				if (flag)
				{
					this._EditBox2.Leave -= value2;
					this._EditBox2.Enter -= value3;
				}
				this._EditBox2 = value;
				flag = (this._EditBox2 != null);
				if (flag)
				{
					this._EditBox2.Leave += value2;
					this._EditBox2.Enter += value3;
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0007DB7C File Offset: 0x0007BD7C
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0007DB94 File Offset: 0x0007BD94
		internal virtual UIButton UiButton2
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
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
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

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0007DBF4 File Offset: 0x0007BDF4
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0007DC0C File Offset: 0x0007BE0C
		internal virtual UIButton UiButton1
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

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0007DC6C File Offset: 0x0007BE6C
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x00003C16 File Offset: 0x00001E16
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

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0007DC84 File Offset: 0x0007BE84
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x00003C20 File Offset: 0x00001E20
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

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0007DC9C File Offset: 0x0007BE9C
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x00003C2A File Offset: 0x00001E2A
		internal virtual EditBox txt_head2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_head2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_head2 = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0007DCB4 File Offset: 0x0007BEB4
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x00003C34 File Offset: 0x00001E34
		internal virtual EditBox txt_head1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_head1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_head1 = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0007DCCC File Offset: 0x0007BECC
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x00003C3E File Offset: 0x00001E3E
		internal virtual EditBox txt_company
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_company;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_company = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0007DCE4 File Offset: 0x0007BEE4
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00003C48 File Offset: 0x00001E48
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0007DCFC File Offset: 0x0007BEFC
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00003C52 File Offset: 0x00001E52
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0007DD14 File Offset: 0x0007BF14
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00003C5C File Offset: 0x00001E5C
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0007DD2C File Offset: 0x0007BF2C
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00003C66 File Offset: 0x00001E66
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0007DD44 File Offset: 0x0007BF44
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00003C70 File Offset: 0x00001E70
		internal virtual Label lbl_head2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_head2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_head2 = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0007DD5C File Offset: 0x0007BF5C
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00003C7A File Offset: 0x00001E7A
		internal virtual Label lbl_head1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_head1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_head1 = value;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00003C84 File Offset: 0x00001E84
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton2_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0007DD74 File Offset: 0x0007BF74
		private void Frm_Register_Load(object sender, EventArgs e)
		{
			this.EditBox1.Text = this.fp.Value();
			Clipboard.SetText(this.EditBox1.Text);
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select value from setting where [key]=" + Public_Function.GetValue("head1")));
			bool flag = text != null && Operators.CompareString(text, "نسخه نمایشی", false) != 0 && Operators.CompareString(text, "", false) != 0;
			if (flag)
			{
				this.txt_head1.Visible = false;
				this.Label7.Visible = false;
				this.lbl_head1.Visible = false;
			}
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select value from setting where [key]=" + Public_Function.GetValue("head2")));
			flag = (text2 != null && Operators.CompareString(text2, "نسخه نمایشی", false) != 0 && Operators.CompareString(text2, "", false) != 0);
			if (flag)
			{
				this.txt_head2.Visible = false;
				this.Label8.Visible = false;
				this.lbl_head2.Visible = false;
			}
			flag = (!this.txt_head1.Visible && !this.txt_head2.Visible);
			if (flag)
			{
				this.UiGroupBox4.Visible = false;
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0007DEC0 File Offset: 0x0007C0C0
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_head1.Visible;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(this.txt_head1.Text, string.Empty, false) == 0);
				if (flag2)
				{
					this.txt_head1.ShowTip("سربرگ را وارد نمایید");
					return;
				}
			}
			flag2 = this.txt_head2.Visible;
			if (flag2)
			{
				flag = (Operators.CompareString(this.txt_head2.Text, string.Empty, false) == 0);
				if (flag)
				{
					this.txt_head2.ShowTip("سربرگ را وارد نمایید");
					return;
				}
			}
			string text = this.EditBox2.Text.ToUpper();
			text = text.Replace("_", "-");
			flag2 = (Operators.CompareString(text, this.fp.Value2(this.EditBox1.Text), false) == 0);
			if (flag2)
			{
				flag = (Public_Function.AppType == 1 | Public_Function.AppType == 3);
				if (flag)
				{
					try
					{
						File.WriteAllText(Application.StartupPath + "\\fr.snk", text);
					}
					catch (Exception expr_10E)
					{
						ProjectData.SetProjectError(expr_10E);
						Frm_RegHelp frm_RegHelp = new Frm_RegHelp();
						frm_RegHelp.ShowDialog();
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					File.WriteAllText(Application.StartupPath + "\\fr2.snk", text);
				}
				try
				{
					setting setting = new setting();
					flag2 = this.txt_head1.Visible;
					if (flag2)
					{
						setting.Update("head1", this.txt_head1.Text);
					}
					flag2 = this.txt_head2.Visible;
					if (flag2)
					{
						setting.Update("head2", this.txt_head2.Text);
					}
					flag2 = this.txt_head1.Visible;
					if (flag2)
					{
						setting.Update("owner", this.txt_head1.Text);
					}
					ProjectData.EndApp();
				}
				catch (Exception expr_1CF)
				{
					ProjectData.SetProjectError(expr_1CF);
					ProjectData.ClearProjectError();
				}
			}
			else
			{
				Public_Function.ShowMessage("سریال فعال سازی اشتباه می باشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				this.EditBox2.Focus();
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000030FB File Offset: 0x000012FB
		private void EditBox2_Enter(object sender, EventArgs e)
		{
			Public_Function.SetEnglish();
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000030F1 File Offset: 0x000012F1
		private void EditBox2_Leave(object sender, EventArgs e)
		{
			Public_Function.SetFarsi();
		}

		// Token: 0x040003A4 RID: 932
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040003A6 RID: 934
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040003A7 RID: 935
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040003A8 RID: 936
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040003A9 RID: 937
		[AccessedThroughProperty("EditBox2")]
		private EditBox _EditBox2;

		// Token: 0x040003AA RID: 938
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040003AB RID: 939
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040003AC RID: 940
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040003AD RID: 941
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040003AE RID: 942
		[AccessedThroughProperty("txt_head2")]
		private EditBox _txt_head2;

		// Token: 0x040003AF RID: 943
		[AccessedThroughProperty("txt_head1")]
		private EditBox _txt_head1;

		// Token: 0x040003B0 RID: 944
		[AccessedThroughProperty("txt_company")]
		private EditBox _txt_company;

		// Token: 0x040003B1 RID: 945
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x040003B2 RID: 946
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040003B3 RID: 947
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040003B4 RID: 948
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040003B5 RID: 949
		[AccessedThroughProperty("lbl_head2")]
		private Label _lbl_head2;

		// Token: 0x040003B6 RID: 950
		[AccessedThroughProperty("lbl_head1")]
		private Label _lbl_head1;

		// Token: 0x040003B7 RID: 951
		private fp fp;
	}
}
