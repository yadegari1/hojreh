using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000DF RID: 223
	[DesignerGenerated]
	public partial class Frm_BastanSandug : Form
	{
		// Token: 0x06001422 RID: 5154 RVA: 0x000D4E20 File Offset: 0x000D3020
		public Frm_BastanSandug()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_BastanSandug_KeyDown);
			base.Load += new EventHandler(this.Frm_BastanSandug_Load);
			Frm_BastanSandug.__ENCAddToList(this);
			this.sum_daryaft = 0L;
			this.sum_pardakht = 0L;
			this.sum_kart = 0L;
			this.avaldore = false;
			this.sandug = new Sandugh();
			this.InitializeComponent();
		}

		// Token: 0x06001423 RID: 5155 RVA: 0x000D4E98 File Offset: 0x000D3098
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_BastanSandug.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_BastanSandug.__ENCList.Count == Frm_BastanSandug.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_BastanSandug.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_BastanSandug.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_BastanSandug.__ENCList[num] = Frm_BastanSandug.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_BastanSandug.__ENCList.RemoveRange(num, Frm_BastanSandug.__ENCList.Count - num);
						Frm_BastanSandug.__ENCList.Capacity = Frm_BastanSandug.__ENCList.Count;
					}
					Frm_BastanSandug.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x000D5A94 File Offset: 0x000D3C94
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00006839 File Offset: 0x00004A39
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

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001428 RID: 5160 RVA: 0x000D5AAC File Offset: 0x000D3CAC
		// (set) Token: 0x06001429 RID: 5161 RVA: 0x000D5AC4 File Offset: 0x000D3CC4
		internal virtual CurrencyBox CurrencyBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.CurrencyBox1_TextChanged);
				bool flag = this._CurrencyBox1 != null;
				if (flag)
				{
					this._CurrencyBox1.TextChanged -= value2;
				}
				this._CurrencyBox1 = value;
				flag = (this._CurrencyBox1 != null);
				if (flag)
				{
					this._CurrencyBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x000D5B24 File Offset: 0x000D3D24
		// (set) Token: 0x0600142B RID: 5163 RVA: 0x00006843 File Offset: 0x00004A43
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

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x000D5B3C File Offset: 0x000D3D3C
		// (set) Token: 0x0600142D RID: 5165 RVA: 0x0000684D File Offset: 0x00004A4D
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

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x000D5B54 File Offset: 0x000D3D54
		// (set) Token: 0x0600142F RID: 5167 RVA: 0x00006857 File Offset: 0x00004A57
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

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x000D5B6C File Offset: 0x000D3D6C
		// (set) Token: 0x06001431 RID: 5169 RVA: 0x00006861 File Offset: 0x00004A61
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

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x000D5B84 File Offset: 0x000D3D84
		// (set) Token: 0x06001433 RID: 5171 RVA: 0x0000686B File Offset: 0x00004A6B
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

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000D5B9C File Offset: 0x000D3D9C
		// (set) Token: 0x06001435 RID: 5173 RVA: 0x000D5BB4 File Offset: 0x000D3DB4
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

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x000D5C14 File Offset: 0x000D3E14
		// (set) Token: 0x06001437 RID: 5175 RVA: 0x000D5C2C File Offset: 0x000D3E2C
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

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x000D5C8C File Offset: 0x000D3E8C
		// (set) Token: 0x06001439 RID: 5177 RVA: 0x00006875 File Offset: 0x00004A75
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600143A RID: 5178 RVA: 0x000D5CA4 File Offset: 0x000D3EA4
		// (set) Token: 0x0600143B RID: 5179 RVA: 0x0000687F File Offset: 0x00004A7F
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

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600143C RID: 5180 RVA: 0x000D5CBC File Offset: 0x000D3EBC
		// (set) Token: 0x0600143D RID: 5181 RVA: 0x000D5CD4 File Offset: 0x000D3ED4
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x000D5D34 File Offset: 0x000D3F34
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x00006889 File Offset: 0x00004A89
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_BastanSandug_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000D5D4C File Offset: 0x000D3F4C
		private void Frm_BastanSandug_Load(object sender, EventArgs e)
		{
			this.sum_daryaft = this.sandug.DaryaftNaghd(this.Tarikh);
			this.sum_pardakht = this.sandug.PardakhtNaghd(this.Tarikh);
			this.ruzegabl = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 mande from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + " order by tarikh desc "));
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select count(tarikh) from mande_sandugh where tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh))));
			bool flag = Operators.ConditionalCompareObjectEqual(objectValue, 0, false);
			if (flag)
			{
				this.ruzegabl = Conversions.ToLong(Public_Function.ExecuteScalar("select top 1 bed from sanad where codehesab_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01"))));
			}
			this.Label2.Text = Public_Function.FormatPrice(Conversions.ToString(checked(this.ruzegabl + this.sum_daryaft - this.sum_pardakht)));
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x000D5E44 File Offset: 0x000D4044
		private void CurrencyBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = this.CurrencyBox1.Value.HasValue;
			checked
			{
				if (flag)
				{
					this.Label6.Text = huruf.ConvertToHuruf(Conversions.ToString((T)this.CurrencyBox1.Value), huruf.ConvertType.ریال);
					long num = this.ruzegabl + this.sum_daryaft - this.sum_pardakht;
					long? value = this.CurrencyBox1.Value;
					long? arg_C6_0;
					if (!value.HasValue)
					{
						arg_C6_0 = null;
					}
					else
					{
						long? num2 = new long?(value.GetValueOrDefault() - num);
						arg_C6_0 = num2;
					}
					this.mande = (T)arg_C6_0;
					flag = !this.avaldore;
					bool flag2;
					if (flag)
					{
						flag2 = (this.mande > 0L);
						if (flag2)
						{
							this.Label5.Text = "افزایش صندوق";
							this.Label4.Text = Public_Function.FormatPrice(Conversions.ToString(this.mande));
						}
						flag2 = (this.mande < 0L);
						if (flag2)
						{
							this.Label5.Text = "کسر صندوق";
							this.Label4.Text = Public_Function.FormatPrice(Conversions.ToString(Math.Abs(this.mande)));
						}
					}
					flag2 = (this.mande == 0L);
					if (flag2)
					{
						this.Label4.Text = string.Empty;
						this.Label5.Text = string.Empty;
					}
				}
				else
				{
					this.Label6.Text = string.Empty;
					this.Label5.Text = string.Empty;
					this.Label4.Text = string.Empty;
				}
			}
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x000D5FEC File Offset: 0x000D41EC
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = !this.CurrencyBox1.Value.HasValue;
			if (flag)
			{
				Public_Function.ShowMessage("لطفا مبلغ مانده صندوق را وارد نمایید", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
			}
			else
			{
				flag = (Public_Function.ShowMessage("آیا مایل به بستن صندوق میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					string[] array = new string[7];
					array[0] = "insert into mande_sandugh(tarikh,tarikh_fa,mande) values(";
					array[1] = Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh));
					array[2] = ",";
					array[3] = Public_Function.GetValue(this.Tarikh);
					array[4] = ",";
					string[] arg_B4_0 = array;
					int arg_B4_1 = 5;
					long? value = this.CurrencyBox1.Value;
					arg_B4_0[arg_B4_1] = (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null);
					array[6] = ")";
					string command = string.Concat(array);
					flag = !this.avaldore;
					if (flag)
					{
						this.sandug.SynckasrEzafe(this.Tarikh);
					}
					Public_Function.ExecuteNonQuery(command);
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00003A26 File Offset: 0x00001C26
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x000D60F8 File Offset: 0x000D42F8
		private void UiButton3_Click(object sender, EventArgs e)
		{
			frm_rpt_dpNaghd frm_rpt_dpNaghd = new frm_rpt_dpNaghd();
			frm_rpt_dpNaghd.Tarikh = this.Tarikh;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_rpt_dpNaghd);
		}

		// Token: 0x040007D1 RID: 2001
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007D3 RID: 2003
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040007D4 RID: 2004
		[AccessedThroughProperty("CurrencyBox1")]
		private CurrencyBox _CurrencyBox1;

		// Token: 0x040007D5 RID: 2005
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040007D6 RID: 2006
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040007D7 RID: 2007
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040007D8 RID: 2008
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040007D9 RID: 2009
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040007DA RID: 2010
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x040007DB RID: 2011
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040007DC RID: 2012
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040007DD RID: 2013
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040007DE RID: 2014
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040007DF RID: 2015
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x040007E0 RID: 2016
		private long sum_daryaft;

		// Token: 0x040007E1 RID: 2017
		private long sum_pardakht;

		// Token: 0x040007E2 RID: 2018
		private long sum_kart;

		// Token: 0x040007E3 RID: 2019
		private long ruzegabl;

		// Token: 0x040007E4 RID: 2020
		private long mande;

		// Token: 0x040007E5 RID: 2021
		private bool avaldore;

		// Token: 0x040007E6 RID: 2022
		private Sandugh sandug;
	}
}
