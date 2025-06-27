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
	// Token: 0x0200014B RID: 331
	[DesignerGenerated]
	public partial class Frm_SuratHesab_KharidFurush : Form
	{
		// Token: 0x06003122 RID: 12578 RVA: 0x0000C62D File Offset: 0x0000A82D
		[DebuggerNonUserCode]
		public Frm_SuratHesab_KharidFurush()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_KharidFurush.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x0023EB30 File Offset: 0x0023CD30
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_KharidFurush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_KharidFurush.__ENCList.Count == Frm_SuratHesab_KharidFurush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_KharidFurush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_KharidFurush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_KharidFurush.__ENCList[num] = Frm_SuratHesab_KharidFurush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_KharidFurush.__ENCList.RemoveRange(num, Frm_SuratHesab_KharidFurush.__ENCList.Count - num);
						Frm_SuratHesab_KharidFurush.__ENCList.Capacity = Frm_SuratHesab_KharidFurush.__ENCList.Count;
					}
					Frm_SuratHesab_KharidFurush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0023FAF4 File Offset: 0x0023DCF4
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0000C66D File Offset: 0x0000A86D
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

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x0023FB0C File Offset: 0x0023DD0C
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x0000C677 File Offset: 0x0000A877
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x17000F01 RID: 3841
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0023FB24 File Offset: 0x0023DD24
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0000C681 File Offset: 0x0000A881
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

		// Token: 0x17000F02 RID: 3842
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0023FB3C File Offset: 0x0023DD3C
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x0023FB54 File Offset: 0x0023DD54
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

		// Token: 0x17000F03 RID: 3843
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0023FBB4 File Offset: 0x0023DDB4
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x0023FBCC File Offset: 0x0023DDCC
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

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0023FC2C File Offset: 0x0023DE2C
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0000C68B File Offset: 0x0000A88B
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

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0023FC44 File Offset: 0x0023DE44
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x0023FC5C File Offset: 0x0023DE5C
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

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x0023FCBC File Offset: 0x0023DEBC
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x0023FCD4 File Offset: 0x0023DED4
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
				EventHandler value2 = new EventHandler(this.txt_az_tarikh_Validated);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.Validated -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.Validated += value2;
				}
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0023FD34 File Offset: 0x0023DF34
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0023FD4C File Offset: 0x0023DF4C
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

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x0023FDD4 File Offset: 0x0023DFD4
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x0000C695 File Offset: 0x0000A895
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

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x0023FDEC File Offset: 0x0023DFEC
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x0000C69F File Offset: 0x0000A89F
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

		// Token: 0x17000F0A RID: 3850
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x0023FE04 File Offset: 0x0023E004
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x0000C6A9 File Offset: 0x0000A8A9
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

		// Token: 0x17000F0B RID: 3851
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0023FE1C File Offset: 0x0023E01C
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x0023FE34 File Offset: 0x0023E034
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

		// Token: 0x17000F0C RID: 3852
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x0023FE94 File Offset: 0x0023E094
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
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

		// Token: 0x17000F0D RID: 3853
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x0023FEAC File Offset: 0x0023E0AC
		// (set) Token: 0x06003143 RID: 12611 RVA: 0x0000C6BD File Offset: 0x0000A8BD
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

		// Token: 0x06003144 RID: 12612 RVA: 0x002375A0 File Offset: 0x002357A0
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

		// Token: 0x06003145 RID: 12613 RVA: 0x0023FEC4 File Offset: 0x0023E0C4
		private void LoadData()
		{
			string text = string.Empty;
			string text2 = string.Empty;
			text = string.Concat(new string[]
			{
				text,
				" AND Kharid_Detail.tarikh between ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
				" AND ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
			});
			text2 = string.Concat(new string[]
			{
				text2,
				" AND Kharid_Furush.tarikh between ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
				" AND ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
			});
			bool flag = this.txt_kala.Value != null;
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND Kharid_Detail.Kala_ID=", this.txt_kala.Value)));
				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(" AND Kharid_Furush.Kala_ID= ", this.txt_kala.Value)));
			}
			string text3 = string.Empty;
			flag = !Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag)
			{
				text3 = "Kharid_Detail.Vazn_Ba_Zarf,Kharid_Detail.Zarf";
			}
			else
			{
				text3 = "Kharid_Detail.vazn_ba_oft as Vazn_Ba_Zarf,Kharid_Detail.vazn_oft as Zarf";
			}
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT 2 as kind, Kharid.Num, Kharid_Detail.tarikh_fa, Moshtari.Name+' '+ Moshtari.Family as moshtari_name  , Kharid_Detail.Kala_ID, Kala.Name AS kala_name, Kharid_Detail.Tedad,",
				text3,
				" , Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, -1 * Kharid_Detail.Jam_Kol as  Jam_Kol FROM    Kharid_Detail INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid_Detail.moshtari_id = Moshtari.ID INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID ",
				text,
				" union all  SELECT 1 as kind, Kharid.Num, Kharid_Furush.Tarikh_Fa, Moshtari.Name  +' '+ Moshtari.Family as moshtari_name  , Kharid_Furush.Kala_ID, Kala.Name AS kala_name ,-1* Kharid_Furush.Tedad,-1* Kharid_Furush.Vazn_Ba_Zarf  , Kharid_Furush.Zarf,-1* Kharid_Furush.Vazn_Kol as Vazn_Kol, Kharid_Furush.Fee,  Kharid_Furush.Jam_Kol  FROM    Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID INNER JOIN  Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID     where 1=1",
				text2,
				" order by kind"
			}));
			this.GridEX1.DataSource = dataTable;
			this.RemoveZero(dataTable);
			Public_Function.AddFilterColumn(this.GridEX1);
			this.EditBox1.Focus();
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SuratHesab_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x002400A4 File Offset: 0x0023E2A4
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
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Caption = "وزن ناخالص";
				this.GridEX1.RootTable.Columns["zarf"].Caption = "افت";
			}
			this.LoadData();
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06003149 RID: 12617 RVA: 0x00240178 File Offset: 0x0023E378
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabtafavot.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text8");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x0000C6C7 File Offset: 0x0000A8C7
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x0000C6E2 File Offset: 0x0000A8E2
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		private void txt_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x0000C6FF File Offset: 0x0000A8FF
		private void txt_az_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x0000C70A File Offset: 0x0000A90A
		private void txt_kala_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.txt_az_tarikh.DatePart = 2;
			this.txt_az_tarikh.FocusDatePart = 2;
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.Focus();
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x00240238 File Offset: 0x0023E438
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

		// Token: 0x0400130C RID: 4876
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400130E RID: 4878
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400130F RID: 4879
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001310 RID: 4880
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001311 RID: 4881
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001312 RID: 4882
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001313 RID: 4883
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001314 RID: 4884
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001315 RID: 4885
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001316 RID: 4886
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001317 RID: 4887
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04001318 RID: 4888
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04001319 RID: 4889
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400131A RID: 4890
		[AccessedThroughProperty("txt_kala")]
		private SelectItem _txt_kala;

		// Token: 0x0400131B RID: 4891
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x0400131C RID: 4892
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
