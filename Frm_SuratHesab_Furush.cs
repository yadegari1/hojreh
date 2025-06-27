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
	// Token: 0x02000146 RID: 326
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Furush : Form
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0000C08B File Offset: 0x0000A28B
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Furush()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Furush.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x00235D68 File Offset: 0x00233F68
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Furush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Furush.__ENCList.Count == Frm_SuratHesab_Furush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Furush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Furush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Furush.__ENCList[num] = Frm_SuratHesab_Furush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Furush.__ENCList.RemoveRange(num, Frm_SuratHesab_Furush.__ENCList.Count - num);
						Frm_SuratHesab_Furush.__ENCList.Capacity = Frm_SuratHesab_Furush.__ENCList.Count;
					}
					Frm_SuratHesab_Furush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003028 RID: 12328 RVA: 0x00237090 File Offset: 0x00235290
		// (set) Token: 0x06003029 RID: 12329 RVA: 0x0000C0CB File Offset: 0x0000A2CB
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

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x002370A8 File Offset: 0x002352A8
		// (set) Token: 0x0600302B RID: 12331 RVA: 0x002370C0 File Offset: 0x002352C0
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

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x0600302C RID: 12332 RVA: 0x00237120 File Offset: 0x00235320
		// (set) Token: 0x0600302D RID: 12333 RVA: 0x0000C0D5 File Offset: 0x0000A2D5
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

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x00237138 File Offset: 0x00235338
		// (set) Token: 0x0600302F RID: 12335 RVA: 0x00237150 File Offset: 0x00235350
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

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x06003030 RID: 12336 RVA: 0x002371B0 File Offset: 0x002353B0
		// (set) Token: 0x06003031 RID: 12337 RVA: 0x002371C8 File Offset: 0x002353C8
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

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x00237228 File Offset: 0x00235428
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x0000C0DF File Offset: 0x0000A2DF
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

		// Token: 0x17000EB3 RID: 3763
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x00237240 File Offset: 0x00235440
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x00237258 File Offset: 0x00235458
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

		// Token: 0x17000EB4 RID: 3764
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x002372B8 File Offset: 0x002354B8
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x0000C0E9 File Offset: 0x0000A2E9
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

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x002372D0 File Offset: 0x002354D0
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x002372E8 File Offset: 0x002354E8
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

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x0600303A RID: 12346 RVA: 0x00237370 File Offset: 0x00235570
		// (set) Token: 0x0600303B RID: 12347 RVA: 0x00237388 File Offset: 0x00235588
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

		// Token: 0x17000EB7 RID: 3767
		// (get) Token: 0x0600303C RID: 12348 RVA: 0x00237410 File Offset: 0x00235610
		// (set) Token: 0x0600303D RID: 12349 RVA: 0x00237428 File Offset: 0x00235628
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

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x0600303E RID: 12350 RVA: 0x002374B0 File Offset: 0x002356B0
		// (set) Token: 0x0600303F RID: 12351 RVA: 0x0000C0F3 File Offset: 0x0000A2F3
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003040 RID: 12352 RVA: 0x002374C8 File Offset: 0x002356C8
		// (set) Token: 0x06003041 RID: 12353 RVA: 0x0000C0FD File Offset: 0x0000A2FD
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

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003042 RID: 12354 RVA: 0x002374E0 File Offset: 0x002356E0
		// (set) Token: 0x06003043 RID: 12355 RVA: 0x0000C107 File Offset: 0x0000A307
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003044 RID: 12356 RVA: 0x002374F8 File Offset: 0x002356F8
		// (set) Token: 0x06003045 RID: 12357 RVA: 0x00237510 File Offset: 0x00235710
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

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003046 RID: 12358 RVA: 0x00237570 File Offset: 0x00235770
		// (set) Token: 0x06003047 RID: 12359 RVA: 0x0000C111 File Offset: 0x0000A311
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

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003048 RID: 12360 RVA: 0x00237588 File Offset: 0x00235788
		// (set) Token: 0x06003049 RID: 12361 RVA: 0x0000C11B File Offset: 0x0000A31B
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

		// Token: 0x0600304A RID: 12362 RVA: 0x002375A0 File Offset: 0x002357A0
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

		// Token: 0x0600304B RID: 12363 RVA: 0x00237758 File Offset: 0x00235958
		private void LoadData()
		{
			string text = string.Empty;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND Kharid_Furush.moshtari_id=", this.txt_moshtari.Value)));
			}
			flag = (this.txt_kala.Value != null);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" AND Kharid_Furush.Kala_ID= ", this.txt_kala.Value)));
			}
			text = string.Concat(new string[]
			{
				text,
				" AND Kharid_Furush.tarikh between ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
				" AND ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
			});
			DataTable dataTable = Public_Function.FillData(" SELECT  Kharid.Num, Kharid_Furush.Kala_ID, Kala.Name as kala_name, Moshtari.Name +' '+ Moshtari.Family as moshtari_name, Kharid_Furush.Tarikh_Fa, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Ba_Zarf, Kharid_Furush.Zarf, Kharid_Furush.Vazn_Kol, Kharid_Furush.Fee,  Kharid_Furush.Jam_Kol  FROM    Kharid INNER JOIN  Kharid_Furush ON Kharid.ID = Kharid_Furush.Kharid_ID INNER JOIN  Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID   where 1=1" + text);
			this.GridEX1.DataSource = dataTable;
			this.RemoveZero(dataTable);
			Public_Function.AddFilterColumn(this.GridEX1);
			this.EditBox1.Focus();
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SuratHesab_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00237870 File Offset: 0x00235A70
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

		// Token: 0x0600304E RID: 12366 RVA: 0x0023793C File Offset: 0x00235B3C
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

		// Token: 0x0600304F RID: 12367 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06003050 RID: 12368 RVA: 0x00237A10 File Offset: 0x00235C10
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

		// Token: 0x06003051 RID: 12369 RVA: 0x0000C125 File Offset: 0x0000A325
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x0000C140 File Offset: 0x0000A340
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x0000C15D File Offset: 0x0000A35D
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x0000C168 File Offset: 0x0000A368
		private void txt_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.txt_moshtari.SetNew();
			this.LoadData();
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x0000C15D File Offset: 0x0000A35D
		private void txt_az_tarikh_Validated(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06003056 RID: 12374 RVA: 0x00237AD0 File Offset: 0x00235CD0
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

		// Token: 0x06003057 RID: 12375 RVA: 0x00237B20 File Offset: 0x00235D20
		private void txt_ta_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.EditBox1.Focus();
			}
		}

		// Token: 0x06003058 RID: 12376 RVA: 0x0000C17F File Offset: 0x0000A37F
		private void txt_kala_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.txt_az_tarikh.DatePart = 2;
			this.txt_az_tarikh.FocusDatePart = 2;
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.Focus();
		}

		// Token: 0x040012AF RID: 4783
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040012B1 RID: 4785
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040012B2 RID: 4786
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040012B3 RID: 4787
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040012B4 RID: 4788
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040012B5 RID: 4789
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040012B6 RID: 4790
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040012B7 RID: 4791
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040012B8 RID: 4792
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040012B9 RID: 4793
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040012BA RID: 4794
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040012BB RID: 4795
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040012BC RID: 4796
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040012BD RID: 4797
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040012BE RID: 4798
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040012BF RID: 4799
		[AccessedThroughProperty("txt_kala")]
		private SelectItem _txt_kala;

		// Token: 0x040012C0 RID: 4800
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040012C1 RID: 4801
		[CompilerGenerated]
		private string _BankHesab_Name;
	}
}
