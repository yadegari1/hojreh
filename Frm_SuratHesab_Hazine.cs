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
	// Token: 0x02000148 RID: 328
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Hazine : Form
	{
		// Token: 0x06003087 RID: 12423 RVA: 0x0000C2B1 File Offset: 0x0000A4B1
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Hazine()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Hazine.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06003088 RID: 12424 RVA: 0x00239300 File Offset: 0x00237500
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Hazine.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Hazine.__ENCList.Count == Frm_SuratHesab_Hazine.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Hazine.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Hazine.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Hazine.__ENCList[num] = Frm_SuratHesab_Hazine.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Hazine.__ENCList.RemoveRange(num, Frm_SuratHesab_Hazine.__ENCList.Count - num);
						Frm_SuratHesab_Hazine.__ENCList.Capacity = Frm_SuratHesab_Hazine.__ENCList.Count;
					}
					Frm_SuratHesab_Hazine.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x0023A334 File Offset: 0x00238534
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x0000C2F1 File Offset: 0x0000A4F1
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

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x0023A34C File Offset: 0x0023854C
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x0000C2FB File Offset: 0x0000A4FB
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

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x0023A364 File Offset: 0x00238564
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x0023A37C File Offset: 0x0023857C
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

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0023A3DC File Offset: 0x002385DC
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x0023A3F4 File Offset: 0x002385F4
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000ED1 RID: 3793
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0023A454 File Offset: 0x00238654
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x0023A46C File Offset: 0x0023866C
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x0023A4CC File Offset: 0x002386CC
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x0000C305 File Offset: 0x0000A505
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

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x0023A4E4 File Offset: 0x002386E4
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x0023A4FC File Offset: 0x002386FC
		internal virtual UICheckBox UiCheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiCheckBox2_CheckedChanged);
				bool flag = this._UiCheckBox2 != null;
				if (flag)
				{
					this._UiCheckBox2.CheckedChanged -= value2;
				}
				this._UiCheckBox2 = value;
				flag = (this._UiCheckBox2 != null);
				if (flag)
				{
					this._UiCheckBox2.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x0023A55C File Offset: 0x0023875C
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x0000C30F File Offset: 0x0000A50F
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

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x0023A574 File Offset: 0x00238774
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x0023A58C File Offset: 0x0023878C
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

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x0023A5EC File Offset: 0x002387EC
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x0023A604 File Offset: 0x00238804
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

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x0023A664 File Offset: 0x00238864
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x0000C319 File Offset: 0x0000A519
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

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x0023A67C File Offset: 0x0023887C
		// (set) Token: 0x060030A2 RID: 12450 RVA: 0x0023A694 File Offset: 0x00238894
		internal virtual SelectItem SelectItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.ValueDeleted -= obj;
					this._SelectItem1.SelectedValueChanged -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.ValueDeleted += obj;
					this._SelectItem1.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0023A71C File Offset: 0x0023891C
		// (set) Token: 0x060030A4 RID: 12452 RVA: 0x0000C323 File Offset: 0x0000A523
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

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060030A5 RID: 12453 RVA: 0x0023A734 File Offset: 0x00238934
		// (set) Token: 0x060030A6 RID: 12454 RVA: 0x0023A74C File Offset: 0x0023894C
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

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x0023A7AC File Offset: 0x002389AC
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x0000C32D File Offset: 0x0000A52D
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060030A9 RID: 12457 RVA: 0x0023A7C4 File Offset: 0x002389C4
		// (set) Token: 0x060030AA RID: 12458 RVA: 0x0000C337 File Offset: 0x0000A537
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

		// Token: 0x060030AB RID: 12459 RVA: 0x0023A7DC File Offset: 0x002389DC
		private void LoadData(string hazine_hesab_id)
		{
			string str = string.Empty;
			bool flag = Operators.CompareString(hazine_hesab_id, string.Empty, false) == 0;
			if (!flag)
			{
				str = " AND CodeHesab_ID= " + hazine_hesab_id;
			}
			DataTable dataTable = Public_Function.FillData("SELECT     ID, Bed, Bes,Tarikh, Tarikh_Fa, Tozih  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5)  " + str + " order by tarikh,id");
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["bes"]));
					dataRow["mande"] = Math.Abs(num);
					flag = (num > 0L);
					if (flag)
					{
						dataRow["stat"] = "بد";
					}
					else
					{
						dataRow["stat"] = "بس";
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				this.mande = Conversions.ToString(dataTable.Rows[checked(dataTable.Rows.Count - 1)]["mande"]);
			}
			this.EditBox1.Focus();
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x0023A9B0 File Offset: 0x00238BB0
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					string str = string.Empty;
					flag = (Operators.CompareString(this.SelectItem1.Text, string.Empty, false) != 0);
					if (flag)
					{
						str = Conversions.ToString(Operators.ConcatenateObject(" and CodeHesab_ID= ", this.SelectItem1.SelectedRow["codehesab_id"]));
					}
					DataRow dataRow = Public_Function.FillDataRow(" SELECT   NULL as  ID,sum( Bed) as bed, sum(Bes) as bes,max(Tarikh) as tarikh,null as Tarikh_Fa,'' as Tozih  FROM Sanad where CodeHesab_ID in (select id from code_hesab where grouh_ID=5) " + str + "  and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
					long num = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(sum(Sanad.Bed),0)  FROM         DaryaftPardakht INNER JOIN  Sanad ON DaryaftPardakht.SanadBed_ID = Sanad.ID  WHERE     (DaryaftPardakht.dpType_ID IN (15, 30))  " + str + " AND (DaryaftPardakht.Moshtari_ID IS NOT NULL) and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text))));
					dataRow["Tozih"] = "مانده از قبل";
					DataRow dataRow2 = dataTable.NewRow();
					flag = (dataRow["bed"] == DBNull.Value);
					if (flag)
					{
						dataRow["bed"] = 0;
					}
					flag = (dataRow["bes"] == DBNull.Value);
					if (flag)
					{
						dataRow["bes"] = 0;
					}
					flag = (dataRow["bed"] != DBNull.Value);
					if (flag)
					{
						DataRow dataRow3 = dataRow;
						DataRow arg_19E_0 = dataRow3;
						string columnName = "bed";
						arg_19E_0[columnName] = Operators.AddObject(dataRow3[columnName], num);
					}
					else
					{
						dataRow["bed"] = num;
					}
					flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
					if (flag)
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
						dataRow2["stat"] = "بد";
					}
					else
					{
						dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
						dataRow2["stat"] = "بس";
					}
					flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
					if (flag)
					{
						bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
						if (flag2)
						{
							dataTable.Rows[0].Delete();
						}
						dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
						dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
						dataRow2["tozih"] = "مانده از قبل";
						dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
						dataTable.Rows.InsertAt(dataRow2, 0);
					}
					dataTable.DefaultView.RowFilter = string.Concat(new string[]
					{
						"tarikh >= '",
						Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
						"' AND tarikh<='",
						Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
						"'"
					});
				}
			}
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x0023AD3C File Offset: 0x00238F3C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x0023AD64 File Offset: 0x00238F64
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool flag = this.UiCheckBox2.Checked;
			if (flag)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = (dataTable == null);
				if (!flag)
				{
					flag = (dataTable.Rows == null);
					if (!flag)
					{
						dataTable.DefaultView.RowFilter = string.Empty;
						flag = (dataTable.Rows[0]["ID"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[0].Delete();
							dataTable.AcceptChanges();
						}
					}
				}
			}
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0023AE54 File Offset: 0x00239054
		private void Frm_SuratHesab_Hazine_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0000C341 File Offset: 0x0000A541
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			this.LoadData(string.Empty);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x060030B2 RID: 12466 RVA: 0x0023AE94 File Offset: 0x00239094
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabhazine.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			string text = "صورتحساب هزینه ";
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				text = string.Concat(new string[]
				{
					text,
					"از تاریخ ",
					this.txt_az_tarikh.Text,
					" تا تاریخ ",
					this.txt_ta_tarikh.Text
				});
			}
			stiText.Text.Value = text;
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.setReportFont(stiReport, "Text10,Text12,Text13,Text14,Text17,Text19,Text21");
			stiReport.Print(false);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0000C369 File Offset: 0x0000A569
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x0000C384 File Offset: 0x0000A584
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData(Conversions.ToString(this.SelectItem1.SelectedRow["codehesab_id"]));
		}

		// Token: 0x060030B5 RID: 12469 RVA: 0x0000C3A9 File Offset: 0x0000A5A9
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData(string.Empty);
		}

		// Token: 0x060030B6 RID: 12470 RVA: 0x0000C3B9 File Offset: 0x0000A5B9
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x0023AFBC File Offset: 0x002391BC
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x040012D3 RID: 4819
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040012D5 RID: 4821
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040012D6 RID: 4822
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040012D7 RID: 4823
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040012D8 RID: 4824
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x040012D9 RID: 4825
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x040012DA RID: 4826
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040012DB RID: 4827
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x040012DC RID: 4828
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040012DD RID: 4829
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040012DE RID: 4830
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040012DF RID: 4831
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040012E0 RID: 4832
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x040012E1 RID: 4833
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040012E2 RID: 4834
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040012E3 RID: 4835
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x040012E4 RID: 4836
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x040012E5 RID: 4837
		private string mande;
	}
}
