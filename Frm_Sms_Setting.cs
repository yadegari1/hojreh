using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Kavenegar.SDK;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200007F RID: 127
	[DesignerGenerated]
	public partial class Frm_Sms_Setting : Form
	{
		// Token: 0x06000AFB RID: 2811 RVA: 0x00004314 File Offset: 0x00002514
		[DebuggerNonUserCode]
		public Frm_Sms_Setting()
		{
			base.Load += new EventHandler(this.Frm_Sms_Setting_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Sms_Setting_KeyDown);
			Frm_Sms_Setting.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0008B6C8 File Offset: 0x000898C8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sms_Setting.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sms_Setting.__ENCList.Count == Frm_Sms_Setting.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sms_Setting.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sms_Setting.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sms_Setting.__ENCList[num] = Frm_Sms_Setting.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sms_Setting.__ENCList.RemoveRange(num, Frm_Sms_Setting.__ENCList.Count - num);
						Frm_Sms_Setting.__ENCList.Capacity = Frm_Sms_Setting.__ENCList.Count;
					}
					Frm_Sms_Setting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0008C558 File Offset: 0x0008A758
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x00004354 File Offset: 0x00002554
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

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0008C570 File Offset: 0x0008A770
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x0000435E File Offset: 0x0000255E
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

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0008C588 File Offset: 0x0008A788
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00004368 File Offset: 0x00002568
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

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x0008C5A0 File Offset: 0x0008A7A0
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00004372 File Offset: 0x00002572
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

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x0008C5B8 File Offset: 0x0008A7B8
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x0000437C File Offset: 0x0000257C
		internal virtual EditBox txt_pass
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_pass;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_pass = value;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00004386 File Offset: 0x00002586
		internal virtual EditBox txt_user
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_user;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_user = value;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00004390 File Offset: 0x00002590
		internal virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0008C600 File Offset: 0x0008A800
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0008C618 File Offset: 0x0008A818
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0008C678 File Offset: 0x0008A878
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x0000439A File Offset: 0x0000259A
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x0008C690 File Offset: 0x0008A890
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000043A4 File Offset: 0x000025A4
		internal virtual CurrencyBox txt_credit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_credit;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_credit = value;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0008C6A8 File Offset: 0x0008A8A8
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000043AE File Offset: 0x000025AE
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0008C6C0 File Offset: 0x0008A8C0
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000043B8 File Offset: 0x000025B8
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

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0008C6D8 File Offset: 0x0008A8D8
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0008C750 File Offset: 0x0008A950
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x0008C768 File Offset: 0x0008A968
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackgroundWorker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
				bool flag = this._BackgroundWorker1 != null;
				if (flag)
				{
					this._BackgroundWorker1.DoWork -= value2;
				}
				this._BackgroundWorker1 = value;
				flag = (this._BackgroundWorker1 != null);
				if (flag)
				{
					this._BackgroundWorker1.DoWork += value2;
				}
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x0008C7C8 File Offset: 0x0008A9C8
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000043C2 File Offset: 0x000025C2
		internal virtual EditBox txt_titr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_titr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_titr = value;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x000043CC File Offset: 0x000025CC
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0008C7F8 File Offset: 0x0008A9F8
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x000043D6 File Offset: 0x000025D6
		internal virtual EditBox txt_apikey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_apikey;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_apikey = value;
			}
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0008C810 File Offset: 0x0008AA10
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			setting setting = new setting();
			bool flag = Operators.CompareString(this.txt_titr.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_titr.Text = " ";
			}
			flag = (Operators.CompareString(this.txt_user.Text, string.Empty, false) == 0);
			if (flag)
			{
				this.txt_user.Text = " ";
			}
			flag = (Operators.CompareString(this.txt_pass.Text, " ", false) == 0);
			if (flag)
			{
				this.txt_pass.Text = " ";
			}
			flag = (Operators.CompareString(this.txt_apikey.Text, string.Empty, false) == 0);
			if (flag)
			{
				this.txt_apikey.Text = " ";
			}
			Public_Function.dict["sms_apikey"] = this.txt_apikey.Text;
			Public_Function.dict["sms_user"] = this.txt_user.Text;
			Public_Function.dict["sms_pass"] = this.txt_pass.Text;
			Public_Function.dict["sms_titr"] = this.txt_titr.Text;
			setting.Update("sms_apikey", this.txt_apikey.Text);
			setting.Update("sms_user", this.txt_user.Text);
			setting.Update("sms_pass", this.txt_pass.Text);
			setting.Update("sms_titr", this.txt_titr.Text);
			Public_Function.ShowMessage("اطلاعات با موفقیت ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Sms_Setting_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		private void Frm_Sms_Setting_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict.ContainsKey("sms_apikey");
			if (flag)
			{
				this.txt_apikey.Text = Public_Function.dict["sms_apikey"].Trim();
			}
			flag = Public_Function.dict.ContainsKey("sms_user");
			if (flag)
			{
				this.txt_user.Text = Public_Function.dict["sms_user"].Trim();
			}
			flag = Public_Function.dict.ContainsKey("sms_pass");
			if (flag)
			{
				this.txt_pass.Text = Public_Function.dict["sms_pass"].Trim();
			}
			flag = Public_Function.dict.ContainsKey("sms_titr");
			if (flag)
			{
				this.txt_titr.Text = Public_Function.dict["sms_titr"].Trim();
			}
			Control.CheckForIllegalCrossThreadCalls = false;
			this.BackgroundWorker1.RunWorkerAsync();
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0008CAAC File Offset: 0x0008ACAC
		private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				KavenegarApi kavenegarApi = new KavenegarApi(Public_Function.dict["sms_apikey"]);
				this.txt_credit.Text = Conversions.ToString(kavenegarApi.AccountInfo().RemainCredit);
			}
			catch (Exception expr_35)
			{
				ProjectData.SetProjectError(expr_35);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x000043E0 File Offset: 0x000025E0
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			Process.Start("https://console.kavenegar.com/membership/login?redirect=%2F");
		}

		// Token: 0x04000456 RID: 1110
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000458 RID: 1112
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000459 RID: 1113
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400045A RID: 1114
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400045B RID: 1115
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400045C RID: 1116
		[AccessedThroughProperty("txt_pass")]
		private EditBox _txt_pass;

		// Token: 0x0400045D RID: 1117
		[AccessedThroughProperty("txt_user")]
		private EditBox _txt_user;

		// Token: 0x0400045E RID: 1118
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400045F RID: 1119
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000460 RID: 1120
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000461 RID: 1121
		[AccessedThroughProperty("txt_credit")]
		private CurrencyBox _txt_credit;

		// Token: 0x04000462 RID: 1122
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000463 RID: 1123
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000464 RID: 1124
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000465 RID: 1125
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x04000466 RID: 1126
		[AccessedThroughProperty("txt_titr")]
		private EditBox _txt_titr;

		// Token: 0x04000467 RID: 1127
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000468 RID: 1128
		[AccessedThroughProperty("txt_apikey")]
		private EditBox _txt_apikey;
	}
}
