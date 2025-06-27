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
using FruitBox.My;
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
	// Token: 0x02000140 RID: 320
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Barzamin : Form
	{
		// Token: 0x06002EEF RID: 12015 RVA: 0x00229EAC File Offset: 0x002280AC
		public Frm_SuratHesab_Barzamin()
		{
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Moshtari_KeyDown);
			Frm_SuratHesab_Barzamin.__ENCAddToList(this);
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x00229F04 File Offset: 0x00228104
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Barzamin.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Barzamin.__ENCList.Count == Frm_SuratHesab_Barzamin.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Barzamin.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Barzamin.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Barzamin.__ENCList[num] = Frm_SuratHesab_Barzamin.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Barzamin.__ENCList.RemoveRange(num, Frm_SuratHesab_Barzamin.__ENCList.Count - num);
						Frm_SuratHesab_Barzamin.__ENCList.Capacity = Frm_SuratHesab_Barzamin.__ENCList.Count;
					}
					Frm_SuratHesab_Barzamin.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x0022AD9C File Offset: 0x00228F9C
		// (set) Token: 0x06002EF4 RID: 12020 RVA: 0x0000BD01 File Offset: 0x00009F01
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

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06002EF5 RID: 12021 RVA: 0x0022ADB4 File Offset: 0x00228FB4
		// (set) Token: 0x06002EF6 RID: 12022 RVA: 0x0022ADCC File Offset: 0x00228FCC
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				RowLoadEventHandler value3 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.LoadingRow -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.LoadingRow += value3;
				}
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x0022AE54 File Offset: 0x00229054
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x0000BD0B File Offset: 0x00009F0B
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
				this._txt_moshtari = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x0022AE6C File Offset: 0x0022906C
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x0000BD15 File Offset: 0x00009F15
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

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x0022AE84 File Offset: 0x00229084
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x0022AE9C File Offset: 0x0022909C
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

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002EFD RID: 12029 RVA: 0x0022AEFC File Offset: 0x002290FC
		// (set) Token: 0x06002EFE RID: 12030 RVA: 0x0022AF14 File Offset: 0x00229114
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

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x06002EFF RID: 12031 RVA: 0x0022AF74 File Offset: 0x00229174
		// (set) Token: 0x06002F00 RID: 12032 RVA: 0x0000BD1F File Offset: 0x00009F1F
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x0022AF8C File Offset: 0x0022918C
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x0022AFA4 File Offset: 0x002291A4
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

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x0022B004 File Offset: 0x00229204
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x0022B01C File Offset: 0x0022921C
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

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x0022B07C File Offset: 0x0022927C
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x0022B094 File Offset: 0x00229294
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

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x0022B0F4 File Offset: 0x002292F4
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x0000BD29 File Offset: 0x00009F29
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

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x0022B10C File Offset: 0x0022930C
		// (set) Token: 0x06002F0A RID: 12042 RVA: 0x0022B124 File Offset: 0x00229324
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

		// Token: 0x06002F0B RID: 12043 RVA: 0x00211A40 File Offset: 0x0020FC40
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
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
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

		// Token: 0x06002F0C RID: 12044 RVA: 0x0022B184 File Offset: 0x00229384
		private void loaddata()
		{
			string command = " SELECT    0 as sorting,  Furush_Hag_Detail.Furush_Hug_ID, Furush_Hag_Detail.Moshtari_ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tarikh,    Furush_Hag_Detail.Tarikh_Fa, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf, Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol,  Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol AS Bes,0 as bed,  Kala.Name AS Kala_Name,   Furush_Hag.Num,'بارروی زمین' as moshtari_name,NULL as tozih FROM         Furush_Hag_Detail INNER JOIN   Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN    Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID   WHERE Furush_Hag_Detail.Moshtari_ID = -2  union all  SELECT  1 as sorting, NULL as Furush_Hug_ID,DaryaftPardakht.Moshtari_ID,NULL as Kala_ID,  DaryaftPardakht.Tarikh, DaryaftPardakht.Tarikh_Fa, NULL as Tedad,null as Vazn_Ba_Zarf,null as Zarf,null as Vazn_Kol,null as fee,0 as bes,DaryaftPardakht.Mablagh as Bed,null as Kala_Name,null as num  , Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name,Tozih  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   where dptype_id = 28  union all  select 2 as sorting ,NULL as Furush_Hug_ID,null as Moshtari_ID,NULL as Kala_ID,  sanad.Tarikh, sanad.Tarikh_Fa, NULL as Tedad,null as Vazn_Ba_Zarf,null as Zarf,null as Vazn_Kol,null as fee,bes as bes,bed as Bed,null as Kala_Name,null as num, 'محاسبه درآمد' as moshtari_name,null as tozih from sanad where codehesab_id in(40,41)  union all  select -1 as sorting ,NULL as Furush_Hug_ID,null as Moshtari_ID,NULL as Kala_ID,  sanad.Tarikh, sanad.Tarikh_Fa, NULL as Tedad,null as Vazn_Ba_Zarf,null as Zarf,null as Vazn_Kol,null as fee,bes as bes,bed as Bed,null as Kala_Name,null as num, 'الباقی سال قبل ' as moshtari_name,null as tozih from sanad where codehesab_id=42  order by tarikh,sorting ";
			DataTable dataTable = Public_Function.FillData(command);
			this.RemoveZero(dataTable);
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			bool flag;
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
						flag = (num < 0L);
						if (flag)
						{
							dataRow["stat"] = "بس";
						}
						else
						{
							dataRow["stat"] = "ت";
						}
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
			flag = (dataTable.Rows.Count > 0);
			checked
			{
				bool flag3;
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[dataTable.Rows.Count - 1]["stat"], "ت", false);
					if (flag2)
					{
						flag3 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[dataTable.Rows.Count - 1]["stat"], "بد", false);
						if (flag3)
						{
							dataTable.Rows[dataTable.Rows.Count - 1]["stat"] = "سود";
						}
						else
						{
							dataTable.Rows[dataTable.Rows.Count - 1]["stat"] = "زیان";
						}
					}
					else
					{
						dataTable.Rows[dataTable.Rows.Count - 1]["stat"] = "بیحساب";
					}
				}
				this.GridEX1.DataSource = dataTable;
				flag3 = (dataTable.Rows.Count > 0);
				if (flag3)
				{
					this.mande = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["mande"]);
				}
				else
				{
					this.mande = Conversions.ToString(0);
				}
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag3 = (dataRow2["Kala_Name"] == DBNull.Value);
						if (flag3)
						{
							dataRow2["kala_Name"] = string.Empty;
						}
						flag3 = (dataRow2["Tozih"] != DBNull.Value);
						if (flag3)
						{
							string[] array = dataRow2["Tozih"].ToString().Split(new char[]
							{
								'-'
							});
							flag3 = (array.Length == 3);
							if (flag3)
							{
								dataRow2["kala_name"] = array[0];
								flag3 = (Operators.CompareString(array[1], string.Empty, false) != 0);
								if (flag3)
								{
									dataRow2["tedad"] = Conversions.ToDecimal(array[1]);
								}
								flag3 = (Operators.CompareString(array[2], string.Empty, false) != 0);
								if (flag3)
								{
									dataRow2["vazn_kol"] = array[2];
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag3 = (enumerator2 is IDisposable);
					if (flag3)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.Add();
				this.UiCheckBox2.Checked = false;
				this.txt_az_tarikh.SetNew();
				this.txt_ta_tarikh.SetNew();
				flag3 = (dataTable.Rows.Count > 0);
				if (flag3)
				{
					this.GridEX1.GetTotalRow().Cells["stat"].Text = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["stat"]);
				}
			}
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x0022B63C File Offset: 0x0022983C
		public void Add()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = !dataTable.Columns.Contains("Filter");
				if (flag)
				{
					dataTable.Columns.Add("Filter", typeof(string));
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						try
						{
							IEnumerator enumerator2 = this.GridEX1.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								text += dataRow[gridEXColumn.DataMember].ToString();
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						dataRow["filter"] = text;
						text = string.Empty;
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
			}
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x0000BD33 File Offset: 0x00009F33
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.loaddata();
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x0022B7A8 File Offset: 0x002299A8
		private void Frm_SuratHesab_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
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

		// Token: 0x06002F10 RID: 12048 RVA: 0x0022B7EC File Offset: 0x002299EC
		private void ShowFurush(DataRowView row)
		{
			bool flag = row["num"] != DBNull.Value;
			if (flag)
			{
				int num = Conversions.ToInteger(row["Num"]);
				frm_Frush_hag frm_Frush_hag = new frm_Frush_hag();
				frm_Frush_hag.Num = num;
				frm_Frush_hag.Show_Preview = true;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Frush_hag);
			}
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x0022B84C File Offset: 0x00229A4C
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(this.mande);
			}
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x0022B894 File Offset: 0x00229A94
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				DataRowView row = (DataRowView)this.GridEX1.CurrentRow.DataRow;
				this.ShowFurush(row);
			}
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x0022B8D8 File Offset: 0x00229AD8
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab showFrm = new Frm_Moshtari_Hesab
			{
				Moshtari_ID = Conversions.ToString(this.txt_moshtari.Value)
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x0022B918 File Offset: 0x00229B18
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkDaryafti frm_rpt_checkDaryafti = new Frm_rpt_checkDaryafti();
			Frm_rpt_checkDaryafti arg_25_0 = frm_rpt_checkDaryafti;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkDaryafti.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkDaryafti showFrm = frm_rpt_checkDaryafti;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x0022B978 File Offset: 0x00229B78
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkPardakhtani frm_rpt_checkPardakhtani = new Frm_rpt_checkPardakhtani();
			Frm_rpt_checkPardakhtani arg_25_0 = frm_rpt_checkPardakhtani;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkPardakhtani.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkPardakhtani showFrm = frm_rpt_checkPardakhtani;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06002F16 RID: 12054 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002F17 RID: 12055 RVA: 0x0022B9D8 File Offset: 0x00229BD8
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\surathesabbarzamin.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			stiReport.RegData(dataTable2.DefaultView);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			Public_Function.setReportFont(stiReport, "Text14,Text15,Text17,Text12,Text19,Text9,Text10,Text13,Text24,Text25,Text23");
			Public_Function.SetReport_MarginTop(stiReport);
			stiReport.Print(false);
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x0000BD3E File Offset: 0x00009F3E
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x0022BA54 File Offset: 0x00229C54
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox2.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox2.Checked;
			bool @checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.SelectionLength = 0;
				this.txt_az_tarikh.SelectionStart = 5;
				this.txt_az_tarikh.SelectionLength = 2;
			}
			else
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				dataTable.DefaultView.RowFilter = string.Empty;
			}
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x0022BAFC File Offset: 0x00229CFC
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = !this.UiCheckBox2.Checked;
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
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

		// Token: 0x06002F1B RID: 12059 RVA: 0x0022BBA8 File Offset: 0x00229DA8
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x06002F1C RID: 12060 RVA: 0x0000BD59 File Offset: 0x00009F59
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x04001237 RID: 4663
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001239 RID: 4665
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400123A RID: 4666
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400123B RID: 4667
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x0400123C RID: 4668
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400123D RID: 4669
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400123E RID: 4670
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400123F RID: 4671
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04001240 RID: 4672
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001241 RID: 4673
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001242 RID: 4674
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001243 RID: 4675
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04001244 RID: 4676
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001245 RID: 4677
		private string mande;

		// Token: 0x02000141 RID: 321
		public enum bedbes
		{
			// Token: 0x04001247 RID: 4679
			bed,
			// Token: 0x04001248 RID: 4680
			bes
		}
	}
}
