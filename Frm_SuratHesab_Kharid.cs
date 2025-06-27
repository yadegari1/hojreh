using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200014A RID: 330
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Kharid : Form
	{
		// Token: 0x060030EC RID: 12524 RVA: 0x0000C4F0 File Offset: 0x0000A6F0
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Kharid()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Kharid.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x0023CDE4 File Offset: 0x0023AFE4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Kharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Kharid.__ENCList.Count == Frm_SuratHesab_Kharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Kharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Kharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Kharid.__ENCList[num] = Frm_SuratHesab_Kharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Kharid.__ENCList.RemoveRange(num, Frm_SuratHesab_Kharid.__ENCList.Count - num);
						Frm_SuratHesab_Kharid.__ENCList.Capacity = Frm_SuratHesab_Kharid.__ENCList.Count;
					}
					Frm_SuratHesab_Kharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x0023E10C File Offset: 0x0023C30C
		// (set) Token: 0x060030F1 RID: 12529 RVA: 0x0000C530 File Offset: 0x0000A730
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

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060030F2 RID: 12530 RVA: 0x0023E124 File Offset: 0x0023C324
		// (set) Token: 0x060030F3 RID: 12531 RVA: 0x0023E13C File Offset: 0x0023C33C
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
				RowLoadEventHandler value2 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.LoadingRow -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.LoadingRow += value2;
				}
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x0023E19C File Offset: 0x0023C39C
		// (set) Token: 0x060030F5 RID: 12533 RVA: 0x0000C53A File Offset: 0x0000A73A
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

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060030F6 RID: 12534 RVA: 0x0023E1B4 File Offset: 0x0023C3B4
		// (set) Token: 0x060030F7 RID: 12535 RVA: 0x0023E1CC File Offset: 0x0023C3CC
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

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060030F8 RID: 12536 RVA: 0x0023E22C File Offset: 0x0023C42C
		// (set) Token: 0x060030F9 RID: 12537 RVA: 0x0023E244 File Offset: 0x0023C444
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
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060030FA RID: 12538 RVA: 0x0023E2A4 File Offset: 0x0023C4A4
		// (set) Token: 0x060030FB RID: 12539 RVA: 0x0000C544 File Offset: 0x0000A744
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060030FC RID: 12540 RVA: 0x0023E2BC File Offset: 0x0023C4BC
		// (set) Token: 0x060030FD RID: 12541 RVA: 0x0023E2D4 File Offset: 0x0023C4D4
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060030FE RID: 12542 RVA: 0x0023E334 File Offset: 0x0023C534
		// (set) Token: 0x060030FF RID: 12543 RVA: 0x0000C54E File Offset: 0x0000A74E
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

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003100 RID: 12544 RVA: 0x0023E34C File Offset: 0x0023C54C
		// (set) Token: 0x06003101 RID: 12545 RVA: 0x0023E364 File Offset: 0x0023C564
		internal virtual SelectItem txt_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.txt_moshtari_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.ValueDeleted -= obj;
					this._txt_moshtari.SelectedValueChanged -= obj2;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.ValueDeleted += obj;
					this._txt_moshtari.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003102 RID: 12546 RVA: 0x0023E3EC File Offset: 0x0023C5EC
		// (set) Token: 0x06003103 RID: 12547 RVA: 0x0023E404 File Offset: 0x0023C604
		internal virtual DateBox2 txt_ta_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ta_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_ta_tarikh_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_az_tarikh_Validated);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
					this._txt_ta_tarikh.Validated -= value3;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
					this._txt_ta_tarikh.Validated += value3;
				}
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003104 RID: 12548 RVA: 0x0023E48C File Offset: 0x0023C68C
		// (set) Token: 0x06003105 RID: 12549 RVA: 0x0023E4A4 File Offset: 0x0023C6A4
		internal virtual DateBox2 txt_az_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_az_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown);
				EventHandler value3 = new EventHandler(this.txt_az_tarikh_Validated);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
					this._txt_az_tarikh.Validated -= value3;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
					this._txt_az_tarikh.Validated += value3;
				}
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003106 RID: 12550 RVA: 0x0023E52C File Offset: 0x0023C72C
		// (set) Token: 0x06003107 RID: 12551 RVA: 0x0000C558 File Offset: 0x0000A758
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003108 RID: 12552 RVA: 0x0023E544 File Offset: 0x0023C744
		// (set) Token: 0x06003109 RID: 12553 RVA: 0x0000C562 File Offset: 0x0000A762
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x0023E55C File Offset: 0x0023C75C
		// (set) Token: 0x0600310B RID: 12555 RVA: 0x0000C56C File Offset: 0x0000A76C
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

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x0600310C RID: 12556 RVA: 0x0023E574 File Offset: 0x0023C774
		// (set) Token: 0x0600310D RID: 12557 RVA: 0x0023E58C File Offset: 0x0023C78C
		internal virtual SelectItem txt_kala
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kala;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_kala_SelectedValueChanged);
				bool flag = this._txt_kala != null;
				if (flag)
				{
					this._txt_kala.SelectedValueChanged -= obj;
				}
				this._txt_kala = value;
				flag = (this._txt_kala != null);
				if (flag)
				{
					this._txt_kala.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0023E5EC File Offset: 0x0023C7EC
		// (set) Token: 0x0600310F RID: 12559 RVA: 0x0000C576 File Offset: 0x0000A776
		public int? BankHesab_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_ID = value;
			}
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x0023E604 File Offset: 0x0023C804
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x0000C580 File Offset: 0x0000A780
		public string BankHesab_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_Name = value;
			}
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0023E61C File Offset: 0x0023C81C
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["zarf"] = dataRow["zarf"].ToString().Replace(".00", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".00", "");
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = dataRow["vazn_ba_zarf"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_ba_oft"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_oft"] = dataRow["vazn_ba_oft"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_oft"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_oft"] = dataRow["vazn_oft"].ToString().Replace(".0", "");
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x00237870 File Offset: 0x00235A70
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				bool flag2 = e.Row.Cells["vazn_kol"].Value != null && Operators.ConditionalCompareObjectNotEqual(e.Row.Cells["vazn_kol"].Value, 0, false);
				if (flag2)
				{
					e.Row.Cells["fee"].Text = Conversions.ToString(Operators.IntDivideObject(e.Row.Cells["jam_kol"].Value, e.Row.Cells["vazn_kol"].Value));
				}
			}
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0023E860 File Offset: 0x0023CA60
		private void LoadData()
		{
			string text = string.Empty;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND Kharid_Detail.moshtari_id=", this.txt_moshtari.Value)));
			}
			flag = (this.txt_kala.Value != null);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND Kharid_Detail.Kala_ID =", this.txt_kala.Value)));
			}
			text = string.Concat(new string[]
			{
				text,
				" AND Kharid_Detail.tarikh between ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
				" AND ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
			});
			DataTable dataTable = Public_Function.FillData("SELECT  Kharid.Num, Kharid_Detail.tarikh_fa, Moshtari.Name+' '+ Moshtari.Family as moshtari_name  , Kharid_Detail.Kala_ID, Kala.Name AS kala_name, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Ba_Zarf  ,Kharid_Detail.vazn_ba_oft,Kharid_Detail.vazn_oft , Kharid_Detail.Zarf, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee,   Kharid_Detail.Jam_Kol  FROM    Kharid_Detail INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid_Detail.moshtari_id = Moshtari.ID INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID where 1=1" + text);
			this.GridEX1.DataSource = dataTable;
			this.RemoveZero(dataTable);
			Public_Function.AddFilterColumn(this.GridEX1);
			this.txt_kala.Focus();
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SuratHesab_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x0023E978 File Offset: 0x0023CB78
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			bool flag = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				bool flag2 = !Conversions.ToBoolean(Public_Function.dict["oft_tedad"]);
				if (flag2)
				{
					this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				}
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_ba_oft"].Visible = true;
				this.GridEX1.RootTable.Columns["vazn_oft"].Visible = true;
			}
			this.LoadData();
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00128E48 File Offset: 0x00127048
		private void SetHeader(StiReport rpt)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0023EA84 File Offset: 0x0023CC84
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			GridPrint gridPrint = new GridPrint();
			gridPrint.PrintGrid(this.GridEX1, "صورتحساب خرید");
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0000C58A File Offset: 0x0000A78A
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x0000C5A5 File Offset: 0x0000A7A5
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x0000C5C2 File Offset: 0x0000A7C2
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x0000C5CD File Offset: 0x0000A7CD
		private void txt_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.txt_moshtari.SetNew();
			this.LoadData();
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x0023EAB4 File Offset: 0x0023CCB4
		private void txt_az_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_ta_tarikh.DatePart = 2;
				this.txt_ta_tarikh.FocusDatePart = 2;
				this.txt_ta_tarikh.Focus();
				this.txt_ta_tarikh.Focus();
			}
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0023EB04 File Offset: 0x0023CD04
		private void txt_ta_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.EditBox1.Focus();
			}
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0000C5C2 File Offset: 0x0000A7C2
		private void txt_az_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		private void txt_kala_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.txt_az_tarikh.DatePart = 2;
			this.txt_az_tarikh.FocusDatePart = 2;
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.Focus();
		}

		// Token: 0x040012F9 RID: 4857
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040012FB RID: 4859
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040012FC RID: 4860
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040012FD RID: 4861
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040012FE RID: 4862
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040012FF RID: 4863
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001300 RID: 4864
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001301 RID: 4865
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001302 RID: 4866
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001303 RID: 4867
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04001304 RID: 4868
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001305 RID: 4869
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001306 RID: 4870
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04001307 RID: 4871
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04001308 RID: 4872
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001309 RID: 4873
		[AccessedThroughProperty("txt_kala")]
		private SelectItem _txt_kala;

		// Token: 0x0400130A RID: 4874
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x0400130B RID: 4875
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
