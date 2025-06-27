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
	// Token: 0x02000155 RID: 341
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Tankhah : Form
	{
		// Token: 0x0600337E RID: 13182 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
		[DebuggerNonUserCode]
		public Frm_SuratHesab_Tankhah()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Hazine_KeyDown);
			Frm_SuratHesab_Tankhah.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00254A74 File Offset: 0x00252C74
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Tankhah.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Tankhah.__ENCList.Count == Frm_SuratHesab_Tankhah.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Tankhah.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Tankhah.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Tankhah.__ENCList[num] = Frm_SuratHesab_Tankhah.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Tankhah.__ENCList.RemoveRange(num, Frm_SuratHesab_Tankhah.__ENCList.Count - num);
						Frm_SuratHesab_Tankhah.__ENCList.Capacity = Frm_SuratHesab_Tankhah.__ENCList.Count;
					}
					Frm_SuratHesab_Tankhah.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000FCD RID: 4045
		// (get) Token: 0x06003382 RID: 13186 RVA: 0x00255DD8 File Offset: 0x00253FD8
		// (set) Token: 0x06003383 RID: 13187 RVA: 0x0000CFE1 File Offset: 0x0000B1E1
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

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003384 RID: 13188 RVA: 0x00255DF0 File Offset: 0x00253FF0
		// (set) Token: 0x06003385 RID: 13189 RVA: 0x0000CFEB File Offset: 0x0000B1EB
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

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x00255E08 File Offset: 0x00254008
		// (set) Token: 0x06003387 RID: 13191 RVA: 0x00255E20 File Offset: 0x00254020
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

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x00255E80 File Offset: 0x00254080
		// (set) Token: 0x06003389 RID: 13193 RVA: 0x00255E98 File Offset: 0x00254098
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

		// Token: 0x17000FD1 RID: 4049
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x00255EF8 File Offset: 0x002540F8
		// (set) Token: 0x0600338B RID: 13195 RVA: 0x00255F10 File Offset: 0x00254110
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

		// Token: 0x17000FD2 RID: 4050
		// (get) Token: 0x0600338C RID: 13196 RVA: 0x00255F70 File Offset: 0x00254170
		// (set) Token: 0x0600338D RID: 13197 RVA: 0x0000CFF5 File Offset: 0x0000B1F5
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

		// Token: 0x17000FD3 RID: 4051
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x00255F88 File Offset: 0x00254188
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x00255FA0 File Offset: 0x002541A0
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

		// Token: 0x17000FD4 RID: 4052
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x00256000 File Offset: 0x00254200
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x0000CFFF File Offset: 0x0000B1FF
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

		// Token: 0x17000FD5 RID: 4053
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x00256018 File Offset: 0x00254218
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x00256030 File Offset: 0x00254230
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

		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x00256090 File Offset: 0x00254290
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x002560A8 File Offset: 0x002542A8
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

		// Token: 0x17000FD7 RID: 4055
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x00256108 File Offset: 0x00254308
		// (set) Token: 0x06003397 RID: 13207 RVA: 0x0000D009 File Offset: 0x0000B209
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

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003398 RID: 13208 RVA: 0x00256120 File Offset: 0x00254320
		// (set) Token: 0x06003399 RID: 13209 RVA: 0x00256138 File Offset: 0x00254338
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged -= obj;
					this._SelectItem1.ValueDeleted -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged += obj;
					this._SelectItem1.ValueDeleted += obj2;
				}
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x0600339A RID: 13210 RVA: 0x002561C0 File Offset: 0x002543C0
		// (set) Token: 0x0600339B RID: 13211 RVA: 0x0000D013 File Offset: 0x0000B213
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

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x002561D8 File Offset: 0x002543D8
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x002561F0 File Offset: 0x002543F0
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

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x00256250 File Offset: 0x00254450
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x00256268 File Offset: 0x00254468
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

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x002562F0 File Offset: 0x002544F0
		// (set) Token: 0x060033A1 RID: 13217 RVA: 0x0000D01D File Offset: 0x0000B21D
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

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x060033A2 RID: 13218 RVA: 0x00256308 File Offset: 0x00254508
		// (set) Token: 0x060033A3 RID: 13219 RVA: 0x0000D027 File Offset: 0x0000B227
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

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x060033A4 RID: 13220 RVA: 0x00256320 File Offset: 0x00254520
		// (set) Token: 0x060033A5 RID: 13221 RVA: 0x0000D031 File Offset: 0x0000B231
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

		// Token: 0x060033A6 RID: 13222 RVA: 0x00256338 File Offset: 0x00254538
		private void LoadData(string Moshtari_ID)
		{
			string text = string.Empty;
			bool flag = Operators.CompareString(Moshtari_ID, string.Empty, false) == 0;
			if (!flag)
			{
				text = " AND Moshtari_ID= " + Moshtari_ID;
			}
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID,1 as [type], DaryaftPardakht.Mablagh AS bed, 0 AS bes, DaryaftPardakht.Tarikh, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Tozih  FROM         DaryaftPardakht INNER JOIN  Sanad ON DaryaftPardakht.SanadBed_ID = Sanad.ID  where DaryaftPardakht.dptype_ID = 38 ",
				text,
				" union all  SELECT     DaryaftPardakht.ID,2 as [type] ,0 AS bed, DaryaftPardakht.Mablagh AS bes, DaryaftPardakht.Tarikh, DaryaftPardakht.Tarikh_Fa, Sanad.Tozih  FROM         DaryaftPardakht INNER JOIN  Sanad ON DaryaftPardakht.SanadBes_ID = Sanad.ID  where dptype_id = 15 And moshtari_id Is Not null ",
				text,
				" order by tarikh,type"
			}));
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			bool flag2;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], 0, false);
					if (flag)
					{
						flag2 = (dataRow["tozih"] == DBNull.Value);
						if (flag2)
						{
							dataRow["tozih"] = "دریافت تنخواه";
						}
						else
						{
							dataRow["tozih"] = Operators.ConcatenateObject("دریافت تنخواه - ", dataRow["tozih"]);
						}
					}
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["bes"]));
					dataRow["mande"] = Math.Abs(num);
					flag2 = (num > 0L);
					if (flag2)
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
				flag2 = (enumerator is IDisposable);
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
			flag2 = (dataTable.Rows.Count > 0);
			if (flag2)
			{
				this.mande = Conversions.ToString(dataTable.Rows[checked(dataTable.Rows.Count - 1)]["mande"]);
			}
			this.EditBox1.Focus();
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x002565AC File Offset: 0x002547AC
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
					flag = (dataRow["bed"] != DBNull.Value);
					if (flag)
					{
						DataRow dataRow3 = dataRow;
						DataRow arg_148_0 = dataRow3;
						string columnName = "bed";
						arg_148_0[columnName] = Operators.AddObject(dataRow3[columnName], num);
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

		// Token: 0x060033A8 RID: 13224 RVA: 0x002568E4 File Offset: 0x00254AE4
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x0025690C File Offset: 0x00254B0C
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

		// Token: 0x060033AA RID: 13226 RVA: 0x002569FC File Offset: 0x00254BFC
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

		// Token: 0x060033AB RID: 13227 RVA: 0x0000D03B File Offset: 0x0000B23B
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x060033AD RID: 13229 RVA: 0x00256A3C File Offset: 0x00254C3C
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
			stiReport.Print(false);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x0000D057 File Offset: 0x0000B257
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x0000D072 File Offset: 0x0000B272
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData(Conversions.ToString(this.SelectItem1.SelectedRow["codehesab_id"]));
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x0000D097 File Offset: 0x0000B297
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData(string.Empty);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x0000205D File Offset: 0x0000025D
		private void Timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00256B54 File Offset: 0x00254D54
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x0000D0A7 File Offset: 0x0000B2A7
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData(Conversions.ToString(this.txt_moshtari.Value));
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x0000D0C2 File Offset: 0x0000B2C2
		private void txt_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.GridEX1.DataSource = null;
		}

		// Token: 0x040013FA RID: 5114
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040013FC RID: 5116
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040013FD RID: 5117
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040013FE RID: 5118
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040013FF RID: 5119
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001400 RID: 5120
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001401 RID: 5121
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001402 RID: 5122
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001403 RID: 5123
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001404 RID: 5124
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001405 RID: 5125
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001406 RID: 5126
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001407 RID: 5127
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x04001408 RID: 5128
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001409 RID: 5129
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x0400140A RID: 5130
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x0400140B RID: 5131
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x0400140C RID: 5132
		[CompilerGenerated]
		private int? _BankHesab_ID;

		// Token: 0x0400140D RID: 5133
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x0400140E RID: 5134
		private string mande;
	}
}
