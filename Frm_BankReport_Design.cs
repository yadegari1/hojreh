using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000119 RID: 281
	[DesignerGenerated]
	public partial class Frm_BankReport_Design : Form
	{
		// Token: 0x0600296A RID: 10602 RVA: 0x001F5374 File Offset: 0x001F3574
		public Frm_BankReport_Design()
		{
			base.Load += new EventHandler(this.Frm_BankReport_Design_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_BankReport_Design_KeyDown);
			Frm_BankReport_Design.__ENCAddToList(this);
			this.bank = new Bank();
			this.InitializeComponent();
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x001F53CC File Offset: 0x001F35CC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_BankReport_Design.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_BankReport_Design.__ENCList.Count == Frm_BankReport_Design.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_BankReport_Design.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_BankReport_Design.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_BankReport_Design.__ENCList[num] = Frm_BankReport_Design.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_BankReport_Design.__ENCList.RemoveRange(num, Frm_BankReport_Design.__ENCList.Count - num);
						Frm_BankReport_Design.__ENCList.Capacity = Frm_BankReport_Design.__ENCList.Count;
					}
					Frm_BankReport_Design.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x001F5D24 File Offset: 0x001F3F24
		// (set) Token: 0x0600296F RID: 10607 RVA: 0x001F5D3C File Offset: 0x001F3F3C
		internal virtual DataEntryGrid GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.SelectionChanged -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002970 RID: 10608 RVA: 0x001F5D9C File Offset: 0x001F3F9C
		// (set) Token: 0x06002971 RID: 10609 RVA: 0x001F5DB4 File Offset: 0x001F3FB4
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

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x001F5E14 File Offset: 0x001F4014
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x0000A37A File Offset: 0x0000857A
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
				this._UiButton2 = value;
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002974 RID: 10612 RVA: 0x001F5E2C File Offset: 0x001F402C
		// (set) Token: 0x06002975 RID: 10613 RVA: 0x0000A384 File Offset: 0x00008584
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
				this._UiButton3 = value;
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002976 RID: 10614 RVA: 0x001F5E44 File Offset: 0x001F4044
		// (set) Token: 0x06002977 RID: 10615 RVA: 0x001F5E5C File Offset: 0x001F405C
		internal virtual NumericBox NumericBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.NumericBox1_Validating);
				bool flag = this._NumericBox1 != null;
				if (flag)
				{
					this._NumericBox1.Validating -= value2;
				}
				this._NumericBox1 = value;
				flag = (this._NumericBox1 != null);
				if (flag)
				{
					this._NumericBox1.Validating += value2;
				}
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002978 RID: 10616 RVA: 0x001F5EBC File Offset: 0x001F40BC
		// (set) Token: 0x06002979 RID: 10617 RVA: 0x0000A38E File Offset: 0x0000858E
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600297A RID: 10618 RVA: 0x001F5ED4 File Offset: 0x001F40D4
		// (set) Token: 0x0600297B RID: 10619 RVA: 0x0000A398 File Offset: 0x00008598
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

		// Token: 0x0600297C RID: 10620 RVA: 0x001F5EEC File Offset: 0x001F40EC
		private void Frm_BankReport_Design_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x001F5F18 File Offset: 0x001F4118
		private void Frm_BankReport_Design_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			DataTable all = this.bank.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x001F5F64 File Offset: 0x001F4164
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			int value = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
			int value2 = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(vagozaricount,5) from bank where id=" + Conversions.ToString(value)));
			this.NumericBox1.Text = Conversions.ToString(value2);
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x001F5FC8 File Offset: 0x001F41C8
		private void NumericBox1_Validating(object sender, CancelEventArgs e)
		{
			int value = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
			Public_Function.ExecuteNonQuery("update bank set vagozaricount=" + this.NumericBox1.Text + " where id=" + Conversions.ToString(value));
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x001F6024 File Offset: 0x001F4224
		private void UiButton1_Click(object sender, EventArgs e)
		{
			DataTable dt = Public_Function.FillData("SELECT  top 10   DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,    DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check,    DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid,    DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,    Bank_1.Name AS CheckBank_Name, Bank.Name + '-' + Bank_Hesab.Shobe AS BankHesab_Name, DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish,    DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID, Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID,   DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.MoshtariHesab_ID, Bank_2.Name+'-'+ Moshtari_Hesab.Bank_Hesab AS MoshtariHesab_Name   FROM         Bank AS Bank_1 RIGHT OUTER JOIN   Moshtari RIGHT OUTER JOIN   Bank_Hesab RIGHT OUTER JOIN   dpType INNER JOIN   DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN   Bank AS Bank_2 INNER JOIN   Moshtari_Hesab ON Bank_2.ID = Moshtari_Hesab.Bank_ID ON DaryaftPardakht.MoshtariHesab_ID = Moshtari_Hesab.ID ON    Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID ON Bank_1.ID = DaryaftPardakht.CheckBank_ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID LEFT OUTER JOIN   Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID             WHERE     dptype_id in (-99,2) ");
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("Select top 1 isnull(id,0) from bank_hesab where bank_id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
			}, null, null, null));
			bool flag = num == 0;
			if (flag)
			{
				Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" لطفا حساب بانکی برای بانک ", this.GridEX1.CurrentRow.Cells["name"].Value), " تعریف کنید ")), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
			else
			{
				new VagozariPrint
				{
					dt = dt,
					BankHesab_ID = num
				}.ShowReport(true);
			}
		}

		// Token: 0x0400102A RID: 4138
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400102C RID: 4140
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400102D RID: 4141
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400102E RID: 4142
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400102F RID: 4143
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04001030 RID: 4144
		[AccessedThroughProperty("NumericBox1")]
		private NumericBox _NumericBox1;

		// Token: 0x04001031 RID: 4145
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001032 RID: 4146
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001033 RID: 4147
		private Bank bank;
	}
}
