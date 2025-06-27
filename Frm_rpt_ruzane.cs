using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000136 RID: 310
	[DesignerGenerated]
	public partial class Frm_rpt_ruzane : Form
	{
		// Token: 0x06002CB8 RID: 11448 RVA: 0x00211F3C File Offset: 0x0021013C
		public Frm_rpt_ruzane()
		{
			base.Load += new EventHandler(this.Frm_rpt_ruzane_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_rpt_ruzane_FormClosing);
			base.Resize += new EventHandler(this.Frm_rpt_ruzane_Resize);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_ruzane_KeyDown);
			Frm_rpt_ruzane.__ENCAddToList(this);
			this.dp = new DaryaftPardakht();
			this.dbl_grid = true;
			this.InitializeComponent();
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00211FC4 File Offset: 0x002101C4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_ruzane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_ruzane.__ENCList.Count == Frm_rpt_ruzane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_ruzane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_ruzane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_ruzane.__ENCList[num] = Frm_rpt_ruzane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_ruzane.__ENCList.RemoveRange(num, Frm_rpt_ruzane.__ENCList.Count - num);
						Frm_rpt_ruzane.__ENCList.Capacity = Frm_rpt_ruzane.__ENCList.Count;
					}
					Frm_rpt_ruzane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D99 RID: 3481
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x0021305C File Offset: 0x0021125C
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x0000B4E0 File Offset: 0x000096E0
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

		// Token: 0x17000D9A RID: 3482
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x00213074 File Offset: 0x00211274
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x0021308C File Offset: 0x0021128C
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_tarikh_KeyDown);
				bool flag = this._txt_tarikh != null;
				if (flag)
				{
					this._txt_tarikh.KeyDown -= value2;
				}
				this._txt_tarikh = value;
				flag = (this._txt_tarikh != null);
				if (flag)
				{
					this._txt_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000D9B RID: 3483
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x002130EC File Offset: 0x002112EC
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x0000B4EA File Offset: 0x000096EA
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

		// Token: 0x17000D9C RID: 3484
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x00213104 File Offset: 0x00211304
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x0021311C File Offset: 0x0021131C
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

		// Token: 0x17000D9D RID: 3485
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x0021317C File Offset: 0x0021137C
		// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x00213194 File Offset: 0x00211394
		internal virtual DataEntryGrid GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridEX2_SelectionChanged);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.SelectionChanged -= value2;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x002131F4 File Offset: 0x002113F4
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x0000B4F4 File Offset: 0x000096F4
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

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x0021320C File Offset: 0x0021140C
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x00213224 File Offset: 0x00211424
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

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x00213284 File Offset: 0x00211484
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x0000B4FE File Offset: 0x000096FE
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

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x0021329C File Offset: 0x0021149C
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x0000B508 File Offset: 0x00009708
		internal virtual DataEntryGrid GridEx3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx3 = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x002132B4 File Offset: 0x002114B4
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x002132CC File Offset: 0x002114CC
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiCheckBox1_CheckedChanged);
				bool flag = this._UiCheckBox1 != null;
				if (flag)
				{
					this._UiCheckBox1.CheckedChanged -= value2;
				}
				this._UiCheckBox1 = value;
				flag = (this._UiCheckBox1 != null);
				if (flag)
				{
					this._UiCheckBox1.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x0021332C File Offset: 0x0021152C
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00213344 File Offset: 0x00211544
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

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x002133A4 File Offset: 0x002115A4
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x002133BC File Offset: 0x002115BC
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

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0021341C File Offset: 0x0021161C
		// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x00213434 File Offset: 0x00211634
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

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00213494 File Offset: 0x00211694
		private void Frm_rpt_ruzane_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			setting.Update("bedune_gardesh", Conversions.ToString(this.UiCheckBox1.Checked));
			Public_Function.dict["bedune_gardesh"] = Conversions.ToString(this.UiCheckBox1.Checked);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x002134E8 File Offset: 0x002116E8
		private void Frm_rpt_ruzane_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.Insert);
			if (flag)
			{
				this.txt_tarikh.Focus();
				this.txt_tarikh.Focus();
			}
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x00213534 File Offset: 0x00211734
		private void LoadDaramad()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT    1 as id,'درآمد فروش حق العمل' as moshtari_name, isnull(SUM(Sanad.Bes) - SUM(Sanad.Bed),0)  as mablagh,'' as Tozih  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     (Code_Hesab.ID = 11) and sanad.tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" union all SELECT   2 as id,'درآمد خرید و فروش' as moshtari_name, isnull(SUM(Sanad.Bes) - SUM(Sanad.Bed),0) as mablagh,'' as Tozih  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     (Code_Hesab.ID = 12) and sanad.tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" union all SELECT    3 as id,'درآمد ارسال بار' as moshtari_name, isnull(SUM(Sanad.Bes) - SUM(Sanad.Bed),0) as mablagh,'' as Tozih  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     (Code_Hesab.ID = 13) and sanad.tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))
			}));
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
			this.GridEX2.RootTable.Columns["tozih"].Visible = false;
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x002135F8 File Offset: 0x002117F8
		private void LoadFurushNaghd()
		{
			string arg = "jam_kol";
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				arg = "JamKol_ba_kargari";
			}
			flag = !this.UiCheckBox2.Checked;
			DataTable dataTable;
			if (flag)
			{
				dataTable = Public_Function.FillData(string.Format(string.Concat(new string[]
				{
					"SELECT     MAX(Kala.Name) AS Kala_Name, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Furush_Hag_Detail.Vazn_Kol) AS Vazn_Kol, SUM(Furush_Hag_Detail.{0}) AS mablagh, Furush_Hag.Num, max(Moshtari.Name)+' '+max( Moshtari.Family) as moshtari_name  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE     (Furush_Hag_Detail.Moshtari_ID = - 1) AND (Furush_Hag_Detail.Tarikh =",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")  GROUP BY Furush_Hag.Num, Furush_Hag_Detail.Kala_ID  UNION ALL  SELECT     MAX(Kala.Name) AS Kala_Name, SUM(Kharid_Furush.Tedad) AS Tedad, SUM(Kharid_Furush.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf, SUM(Kharid_Furush.Vazn_Kol)  AS Vazn_Kol, SUM(Kharid_Furush.{0}) AS mablagh, Kharid.Num, max(Moshtari.Name)+' '+max( Moshtari.Family) as moshtari_name  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID left outer JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID  WHERE     (Kharid_Furush.Moshtari_ID = - 1) AND (Kharid_Furush.Tarikh =",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")  GROUP BY Kharid.Num, Kharid_Furush.Kala_ID Union All    SELECT   isnull(DaryaftPardakht.Tozih,' ') as Kala_Name,null as tedad,null as vazn_ba_zarf,null as vazn_kol,      DaryaftPardakht.Mablagh,null as num,'بار روی زمین' AS Moshtari_Name     FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" AND dpType_id=28 AND DaryaftPardakht.Moshtari_ID=-1  union all   SELECT     MAX(Kala.Name) AS Kala_Name, SUM(Furush_Sardkhane_Detail.Tedad) AS Tedad, SUM(Furush_Sardkhane_Detail.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf, SUM(Furush_Sardkhane_Detail.Vazn_Kol)AS Vazn_Kol,SUM( Furush_Sardkhane_Detail.Jam_Kol) AS mablagh,       Furush_Sardkhane.Num,N'فروش سردخانه' as moshtari_name FROM         Furush_Sardkhane_Detail INNER JOIN      Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN      Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID      WHERE     (Furush_Sardkhane_Detail.Moshtari_ID = - 1) AND (Furush_Sardkhane_Detail.Tarikh = ",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")      GROUP BY Furush_Sardkhane.Num, Furush_Sardkhane_Detail.Kala_ID      order by num"
				}), arg));
				flag = !dataTable.Columns.Contains("Fee");
				if (flag)
				{
					dataTable.Columns.Add("Fee", typeof(int));
				}
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["mablagh"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = dataRow["vazn_kol"] != DBNull.Value;
							if (flag2)
							{
								bool flag3 = Operators.ConditionalCompareObjectNotEqual(dataRow["vazn_kol"], 0, false);
								if (flag3)
								{
									dataRow["Fee"] = Operators.DivideObject(dataRow["mablagh"], dataRow["vazn_kol"]);
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag3 = enumerator is IDisposable;
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			else
			{
				dataTable = Public_Function.FillData(string.Format(string.Concat(new string[]
				{
					"SELECT     Kala.Name AS Kala_Name, Furush_Hag_Detail.Tedad AS Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf AS Vazn_Ba_Zarf,  Furush_Hag_Detail.Vazn_Kol AS Vazn_Kol, Furush_Hag_Detail.{0} AS mablagh, Furush_Hag.Num, Moshtari.Name+' '+ Moshtari.Family as moshtari_name,Cast(Furush_Hag_Detail.Fee as int) as Fee  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID  WHERE     (Furush_Hag_Detail.Moshtari_ID = - 1) AND (Furush_Hag_Detail.Tarikh =",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")  UNION ALL  SELECT     Kala.Name AS Kala_Name, Kharid_Furush.Tedad AS Tedad, Kharid_Furush.Vazn_Ba_Zarf AS Vazn_Ba_Zarf, Kharid_Furush.Vazn_Kol  AS Vazn_Kol, Kharid_Furush.{0} AS mablagh, Kharid.Num, Moshtari.Name+' '+ Moshtari.Family as moshtari_name,Cast(Kharid_Furush.Fee AS int) AS Fee  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID  WHERE     (Kharid_Furush.Moshtari_ID = - 1) AND (Kharid_Furush.Tarikh =",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")  Union All    SELECT   isnull(DaryaftPardakht.Tozih,' ') as Kala_Name,null as tedad,null as vazn_ba_zarf,null as vazn_kol,      DaryaftPardakht.Mablagh,null as num,'بار روی زمین' AS Moshtari_Name,null as fee     FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					" AND dpType_id=28 AND DaryaftPardakht.Moshtari_ID=-1  union all   SELECT     Kala.Name AS Kala_Name, Furush_Sardkhane_Detail.Tedad AS Tedad, Furush_Sardkhane_Detail.Vazn_Ba_Zarf AS Vazn_Ba_Zarf, Furush_Sardkhane_Detail.Vazn_Kol AS Vazn_Kol, Furush_Sardkhane_Detail.Jam_Kol AS mablagh,       Furush_Sardkhane.Num,N'فروش سردخانه' as moshtari_name,Cast(Furush_Sardkhane_Detail.Fee AS int) AS Fee FROM         Furush_Sardkhane_Detail INNER JOIN      Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN      Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID      WHERE     (Furush_Sardkhane_Detail.Moshtari_ID = - 1) AND (Furush_Sardkhane_Detail.Tarikh = ",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
					")      order by num"
				}), arg));
			}
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					string[] array = dataRow2["Kala_Name"].ToString().Split(new char[]
					{
						'-'
					});
					bool flag3 = array.Length == 3;
					if (flag3)
					{
						dataRow2["Kala_Name"] = array[0].ToString();
						flag3 = (Operators.CompareString(array[1], string.Empty, false) != 0);
						if (flag3)
						{
							bool flag2 = Versioned.IsNumeric(array[1].ToString());
							if (flag2)
							{
								dataRow2["Tedad"] = array[1].ToString();
							}
						}
						flag3 = Versioned.IsNumeric(array[2].ToString());
						if (flag3)
						{
							bool flag2 = Operators.CompareString(array[2], string.Empty, false) != 0;
							if (flag2)
							{
								dataRow2["Vazn_Kol"] = array[2].ToString();
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag3 = enumerator2 is IDisposable;
				if (flag3)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			try
			{
				IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					bool flag3 = dataRow3["tedad"] != DBNull.Value;
					if (flag3)
					{
						dataRow3["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow3["tedad"]));
					}
					flag3 = (dataRow3["vazn_ba_zarf"] != DBNull.Value);
					if (flag3)
					{
						dataRow3["vazn_ba_zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow3["vazn_ba_zarf"]));
					}
					flag3 = (dataRow3["vazn_kol"] != DBNull.Value);
					if (flag3)
					{
						dataRow3["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow3["vazn_kol"]));
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				bool flag3 = enumerator3 is IDisposable;
				if (flag3)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			this.GridEX2.DataSource = dataTable;
			this.GridEX2.RootTable.Columns["name"].Visible = true;
			this.GridEX2.RootTable.Columns["name"].Caption = "صاحب بار";
			this.GridEX2.RootTable.Columns["num"].Visible = true;
			this.GridEX2.RootTable.Columns["tozih"].Visible = false;
			this.GridEX2.RootTable.Columns["Kala_Name"].Visible = true;
			this.GridEX2.RootTable.Columns["Tedad"].Visible = true;
			this.GridEX2.RootTable.Columns["Vazn_kol"].Visible = true;
			this.GridEX2.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX2.RootTable.Columns["Fee"].Visible = true;
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00213C98 File Offset: 0x00211E98
		private void LoadFurush()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"select 1 as id,'فروش حق العمل' AS moshtari_name,isnull(sum(jam_kol),0) AS mablagh,'' as tozih from furush_hag_detail where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" and moshtari_id>0 union all select 2 as id,'فروش خرید' AS moshtari_name,isnull(sum(jam_kol),0) AS mablagh,'' as tozih from kharid_furush where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" and moshtari_id>0 union all select 3 as id,'فروش سردخانه' AS moshtari_name,isnull(sum(jam_kol),0) AS mablagh,'' as tozih from furush_sardkhane_detail where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" and moshtari_id>0 "
			}));
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
			this.GridEX2.RootTable.Columns["tozih"].Visible = false;
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x00213D68 File Offset: 0x00211F68
		private void LoadDaramadDetail()
		{
			DataTable dataTable = Public_Function.FillData("SELECT   isnull(Sanad.Bes-Sanad.Bed,0) AS Mablagh, Sanad.CodeHesab_ID, Sanad.Tozih, Sanad.Tarikh, Sanad.Tarikh_Fa   FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID   WHERE     (Code_Hesab.Grouh_ID = 7)  AND Sanad.Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)));
			this.GridEX2.RootTable.Columns["Num"].Visible = false;
			this.GridEX2.RootTable.Columns["name"].Visible = false;
			this.GridEX2.RootTable.Columns["Kala_Name"].Visible = false;
			this.GridEX2.RootTable.Columns["Tedad"].Visible = false;
			this.GridEX2.RootTable.Columns["Vazn_kol"].Visible = false;
			this.GridEX2.RootTable.Columns["Tozih"].Visible = true;
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00213E80 File Offset: 0x00212080
		private void LoadFurushDetail()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     1 AS sanadtype, Furush_Hag_Detail.ID, CAST(Furush_Hag.Num AS nvarchar(5)) + ' / فروش' AS NUM, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,  Kala.Name AS Kala_Name, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol, Furush_Hag_Detail.Jam_Kol AS Mablagh, Moshtari_1.Name+' '+ Moshtari_1.Family AS sahebbar,Cast(Furush_Hag_Detail.Fee AS int) as Fee  FROM         Furush_Hag_Detail INNER JOIN Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID INNER JOIN  Moshtari AS Moshtari_1 ON Furush_Hag.Moshtari_ID = Moshtari_1.ID  WHERE     (Furush_Hag_Detail.Moshtari_ID > 0) AND (Furush_Hag_Detail.Tarikh =",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				")  UNION ALL  SELECT     2 AS sanadtype, Kharid_Furush.ID, CAST(Kharid.Num AS nvarchar(5)) + ' / خرید' AS NUM, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Kala.Name AS Kala_Name, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol, Kharid_Furush.Jam_Kol AS Mablagh, Moshtari_1.Name+' '+ Moshtari_1.Family AS sahebbar,Cast(Kharid_Furush.Fee AS int) as Fee   FROM         Kharid_Furush INNER JOIN  Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN  Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID left outer JOIN  Moshtari AS Moshtari_1 ON Kharid.Moshtari_ID = Moshtari_1.ID  WHERE     (Kharid_Furush.Moshtari_ID > 0) AND (Kharid_Furush.Tarikh =",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				")  UNION ALL  SELECT     3 AS sanadtype, furush_sardkhane_detail.ID, CAST(furush_sardkhane.Num AS nvarchar(5)) + ' / سردخانه' AS NUM, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,   Kala.Name AS Kala_Name, furush_sardkhane_detail.Tedad, furush_sardkhane_detail.Vazn_Kol, furush_sardkhane_detail.Jam_Kol AS Mablagh, Moshtari_1.Name+' '+ Moshtari_1.Family AS sahebbar,Cast(furush_sardkhane_detail.Fee as int) AS Fee   FROM         furush_sardkhane_detail INNER JOIN  Kala ON furush_sardkhane_detail.Kala_ID = Kala.ID INNER JOIN  Moshtari ON furush_sardkhane_detail.Moshtari_ID = Moshtari.ID INNER JOIN  furush_sardkhane ON furush_sardkhane_detail.furush_sardkhane_id = furush_sardkhane.ID INNER JOIN  Moshtari AS Moshtari_1 ON furush_sardkhane_detail.Moshtari_ID = Moshtari_1.ID  WHERE     (furush_sardkhane_detail.Moshtari_ID > 0) AND (furush_sardkhane_detail.Tarikh =",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				")  ORDER BY sanadtype, Furush_Hag_Detail.ID"
			}));
			this.GridEX2.RootTable.Columns["sahebbar"].Visible = true;
			this.GridEX2.RootTable.Columns["Num"].Visible = true;
			this.GridEX2.RootTable.Columns["Kala_Name"].Visible = true;
			this.GridEX2.RootTable.Columns["Tedad"].Visible = true;
			this.GridEX2.RootTable.Columns["Vazn_kol"].Visible = true;
			this.GridEX2.RootTable.Columns["Fee"].Visible = true;
			this.GridEX2.RootTable.Columns["Tozih"].Visible = false;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
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
			this.GridEX2.DataSource = dataTable;
			this.Addfilter(dataTable, this.GridEX2);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x002140F8 File Offset: 0x002122F8
		private void LoadCheckDetail()
		{
			string text = string.Empty;
			DataTable dt = Public_Function.FillData("select pardakhtcheck_id from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " and dptype_id=26");
			text = Public_Function.GetID(dt, "pardakhtcheck_id", "");
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				this.GridEX2.DataSource = null;
			}
			else
			{
				DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh,isnull( DaryaftPardakht.Tozih,' ') AS Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS CheckBank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status in (3) and DaryaftPardakht.id in(" + text + ") order by DaryaftPardakht.ID");
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag)
						{
							dataRow["Tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )");
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_18E_0 = dataRow2;
							string columnName = "Tozih";
							arg_18E_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )"));
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
				this.Addfilter(dataTable, this.GridEX2);
				this.GridEX2.DataSource = dataTable;
			}
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00214308 File Offset: 0x00212508
		private void LoadKeraye()
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     'فروش سند شماره ' + CAST(Furush_Hag.Num AS nvarchar(100)) AS Moshtari_Name, Furush_Keraye.Keraye AS Mablagh, Hazine_Kharid.Name AS Hazine_Name,'' as Tozih,   Kala.Name AS Kala_Name   FROM         Furush_Keraye INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID INNER JOIN  Furush_Hag ON Furush_Keraye.Furush_ID = Furush_Hag.ID LEFT OUTER JOIN  Kala ON Furush_Keraye.Kala_ID = Kala.ID  where Furush_Keraye.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" union all  SELECT     'خرید سند شماره ' + CAST(Kharid.Num AS nvarchar(10)) AS Moshtari_Name, Kharid_Keraye.Keraye AS Mablagh, Hazine_Kharid.Name AS Hazine_Name,'' as Tozih,   Kala.Name AS Kala_Name  FROM         Kharid_Keraye left outer JOIN  Kala ON Kharid_Keraye.Kala_ID = Kala.ID INNER JOIN  Kharid ON Kharid_Keraye.Kharid_ID = Kharid.ID INNER JOIN  Hazine_Kharid ON Kharid_Keraye.HazineKharid_ID = Hazine_Kharid.ID where Kharid_Keraye.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" UNION ALL  SELECT     'ارسال بار سند شماره ' + CAST(ErsalBar.Num AS nvarchar(10)) AS Moshtari_Name, ErsalBar_Keraye.Keraye AS Mablagh, Hazine_Kharid.Name AS Hazine_Name,'' as Tozih, Kala.Name AS Kala_Name   FROM         ErsalBar_Keraye INNER JOIN  ErsalBar ON ErsalBar_Keraye.ErsalBar_ID = ErsalBar.ID INNER JOIN  Hazine_Kharid ON ErsalBar_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Kala ON ErsalBar_Keraye.Kala_ID = Kala.ID where ErsalBar_Keraye.Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_Name"]);
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
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00214424 File Offset: 0x00212624
		private void LoadDetailin(string dptype_id, string whereText = "")
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Mablagh AS Mablagh2,isnull(DaryaftPardakht.Tozih,' ') AS Tozih,         DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab,   DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name,                                 cast(Moshtari.ID AS nvarchar(5)) +' - '+ Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" AND dpType_id in(",
				dptype_id,
				")",
				whereText,
				" order by DaryaftPardakht.ID"
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 6, false);
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_Name"]);
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 27, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 40, false));
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false))
					{
						goto IL_1D0;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false))
					{
						goto IL_1D0;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_1EC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_20B;
					}
					bool arg_20D_0 = false;
					IL_20C:
					flag = arg_20D_0;
					bool flag2;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag2)
						{
							dataRow["Tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )");
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_303_0 = dataRow2;
							string columnName = "Tozih";
							arg_303_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag)
						{
							dataRow["tozih"] = RuntimeHelpers.GetObjectValue(dataRow["sh_check"]);
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_39F_0 = dataRow2;
							string columnName = "tozih";
							arg_39F_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(" (", dataRow["sh_check"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false));
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 30, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					continue;
					IL_20B:
					arg_20D_0 = true;
					goto IL_20C;
					IL_1EC:
					goto IL_20B;
					IL_1D0:
					goto IL_1EC;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00214950 File Offset: 0x00212B50
		private void LoadDetail(long dptype_id, string whereText = "")
		{
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Mablagh AS Mablagh2,isnull(DaryaftPardakht.Tozih,' ') AS Tozih,         DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_ShomareHesab,   DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Parent_ID, dpType.Name AS dp_Name,                                 cast(Moshtari.ID AS nvarchar(5)) +' - '+ Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS CheckBank_Name, Bank.Name + ' ' + Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,          DaryaftPardakht.Check_Status, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.Hazine_ID,            Hazine.Name AS Hazine_Name, DaryaftPardakht.PardakhtCheck_ID, DaryaftPardakht.Daramad_ID, Daramad.Name AS Daramad_Name                                FROM         Moshtari RIGHT OUTER JOIN                                                                                                                 dpType INNER JOIN                                                                                                                                      DaryaftPardakht ON dpType.ID = DaryaftPardakht.dpType_ID LEFT OUTER JOIN                                                                               Daramad ON DaryaftPardakht.Daramad_ID = Daramad.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                                        Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN                                                                                        Bank_Hesab LEFT OUTER JOIN                                                                                                                             Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID LEFT OUTER JOIN                                                   Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID                                                                                             where Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" AND dpType_id=",
				Conversions.ToString(dptype_id),
				whereText,
				" order by DaryaftPardakht.ID"
			}));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -1, false);
					if (flag)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["tozih"]);
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 6, false);
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Daramad_Name"]);
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 27, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 40, false));
					if (flag)
					{
						dataRow["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						dataRow["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false))
					{
						goto IL_1CC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false))
					{
						goto IL_1CC;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_1E8;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false))
					{
						goto IL_207;
					}
					bool arg_209_0 = false;
					IL_208:
					flag = arg_209_0;
					bool flag2;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag2)
						{
							dataRow["Tozih"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )");
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_2FF_0 = dataRow2;
							string columnName = "Tozih";
							arg_2FF_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( ", dataRow["sh_check"]), " - "), dataRow["CheckBank_Name"]), " "), dataRow["Check_Shobe"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["tozih"], " ", false);
						if (flag)
						{
							dataRow["tozih"] = RuntimeHelpers.GetObjectValue(dataRow["sh_check"]);
						}
						else
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_39B_0 = dataRow2;
							string columnName = "tozih";
							arg_39B_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(" (", dataRow["sh_check"]), " )"));
						}
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 14, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false));
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_name"]);
					}
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 30, false);
					if (flag2)
					{
						dataRow["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["hazine_name"]);
					}
					continue;
					IL_207:
					arg_209_0 = true;
					goto IL_208;
					IL_1E8:
					goto IL_207;
					IL_1CC:
					goto IL_1E8;
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.Addfilter(dataTable, this.GridEX2);
			this.GridEX2.DataSource = dataTable;
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00214E78 File Offset: 0x00213078
		private void Addfilter(DataTable dt, GridEX Grid)
		{
			string text = string.Empty;
			DataColumn dataColumn = new DataColumn("filter", typeof(string));
			bool flag = !dt.Columns.Contains("filter");
			if (flag)
			{
				dt.Columns.Add(dataColumn);
			}
			try
			{
				IEnumerator enumerator = Grid.RootTable.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
					flag = gridEXColumn.Visible;
					if (flag)
					{
						text = text + gridEXColumn.DataMember + "+";
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
			text = Public_Function.RemoveLast(text);
			dataColumn.Expression = text;
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00214F58 File Offset: 0x00213158
		private long GetKeraye()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"select sum(mablagh) from(  SELECT isnull(sum(keraye),0) as mablagh  FROM [Furush_Keraye]  where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				" union all  SELECT isnull(sum(keraye),0)as mablagh  FROM [Kharid_Keraye]  where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"     union all  SELECT isnull(sum(keraye),0)as mablagh  FROM Kharid_Sardkhane_Keraye  where tarikh= ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"    union all   SELECT isnull(sum(keraye),0)as mablagh  FROM Furush_Sardkhane_Keraye  where tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				")t"
			})));
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x00215018 File Offset: 0x00213218
		private void LoadData(string tarikh)
		{
			DataTable dataTable = new DataTable();
			Sandugh sandugh = new Sandugh();
			dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
			dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
			dataTable.Columns.Add(new DataColumn("Mablagh", typeof(long)));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id in(2,42) and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT     isnull(SUM(Sanad.Bes) - SUM(Sanad.Bed),0)  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID  WHERE     (Code_Hesab.Grouh_ID = 7) and sanad.tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=8 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=26 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num5 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=27 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num6 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=28 and moshtari_id <> -1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num7 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=-1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			num7 = Conversions.ToLong(Operators.AddObject(num7, Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=28 and moshtari_id=-1 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)))));
			long num8 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from furush_hag_detail where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " and moshtari_id >0"));
			num8 = Conversions.ToLong(Operators.AddObject(num8, Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from Kharid_furush where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " and moshtari_id>0")));
			num8 = Conversions.ToLong(Operators.AddObject(num8, Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from furush_sardkhane_detail where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)) + " and moshtari_id>0")));
			long keraye = this.GetKeraye();
			long num9 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=10 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num10 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=12 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num11 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=11 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num12 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=14 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num13 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=15 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num14 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=18 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num15 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=20 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num16 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=22 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num17 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=29 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num18 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=30 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num19 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=31 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num20 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=5 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num21 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=16 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num22 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=32 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num23 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=3 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			long num24 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where dptype_id=40 and tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))));
			dataTable.Rows.Add(new object[]
			{
				0,
				"جمع فروش روزانه",
				checked(num7 + num8 + num6)
			});
			dataTable.Rows.Add(new object[]
			{
				1,
				"دریافت نقد از مشتری",
				num
			});
			dataTable.Rows.Add(new object[]
			{
				2,
				"دریافت چک",
				num2
			});
			dataTable.Rows.Add(new object[]
			{
				3,
				"درآمد",
				num3
			});
			dataTable.Rows.Add(new object[]
			{
				4,
				"تفاوت",
				num4
			});
			dataTable.Rows.Add(new object[]
			{
				5,
				"نقدکردن چک",
				RuntimeHelpers.GetObjectValue(objectValue)
			});
			dataTable.Rows.Add(new object[]
			{
				6,
				"دریافت کارتخوان",
				num5
			});
			dataTable.Rows.Add(new object[]
			{
				7,
				"فروش نسیه بار روی زمین",
				num6
			});
			dataTable.Rows.Add(new object[]
			{
				8,
				"فروش نقدی",
				num7
			});
			dataTable.Rows.Add(new object[]
			{
				9,
				"فروش نسیه",
				num8
			});
			dataTable.Rows.Add(new object[]
			{
				10,
				"کرایه و مخارج",
				keraye
			});
			dataTable.Rows.Add(new object[]
			{
				11,
				"پرداخت نقد",
				num9
			});
			dataTable.Rows.Add(new object[]
			{
				12,
				"پرداخت چک",
				num10
			});
			dataTable.Rows.Add(new object[]
			{
				13,
				"پرداخت دسته چک",
				num11
			});
			dataTable.Rows.Add(new object[]
			{
				14,
				"انتقال وجه به بانک",
				num12
			});
			dataTable.Rows.Add(new object[]
			{
				15,
				"پرداخت هزینه از صندوق",
				num13
			});
			dataTable.Rows.Add(new object[]
			{
				16,
				"واگذاری به بانک",
				num14
			});
			dataTable.Rows.Add(new object[]
			{
				17,
				"وصولی چک ها",
				num15
			});
			dataTable.Rows.Add(new object[]
			{
				18,
				"برگشت چک ها",
				num16
			});
			dataTable.Rows.Add(new object[]
			{
				19,
				"کارت به کارت",
				num17
			});
			dataTable.Rows.Add(new object[]
			{
				20,
				"پرداخت هزینه از بانک",
				num18
			});
			dataTable.Rows.Add(new object[]
			{
				21,
				"بانک به بانک",
				num19
			});
			dataTable.Rows.Add(new object[]
			{
				22,
				"دریافت حواله",
				num23
			});
			dataTable.Rows.Add(new object[]
			{
				23,
				"الباقی فاکتور مشتری",
				num22
			});
			dataTable.Rows.Add(new object[]
			{
				24,
				"بانک به صندوق",
				num24
			});
			dataTable.Rows.Add(new object[]
			{
				25,
				"اضافی صندوق",
				num20
			});
			dataTable.Rows.Add(new object[]
			{
				26,
				"کسری صندوق",
				num21
			});
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x00215B90 File Offset: 0x00213D90
		private void Frm_rpt_ruzane_Load(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.FilterCondition = null;
			this.txt_tarikh.SetNew();
			this.LoadData(this.txt_tarikh.Text);
			bool flag = Public_Function.dict.ContainsKey("bedune_gardesh");
			if (flag)
			{
				this.UiCheckBox1.Checked = Conversions.ToBoolean(Public_Function.dict["bedune_gardesh"]);
				this.UiCheckBox1_CheckedChanged(null, null);
			}
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x00215C0C File Offset: 0x00213E0C
		private void txt_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData(this.txt_tarikh.Text);
			}
			flag = (e.KeyCode == Keys.Insert);
			if (flag)
			{
				this.txt_tarikh.Focus();
				this.txt_tarikh.Focus();
			}
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x00215C64 File Offset: 0x00213E64
		private void Align_Grid()
		{
			bool flag = this.dbl_grid;
			checked
			{
				if (flag)
				{
					this.GridEx3.Visible = false;
					this.GridEX2.Width = (int)Math.Round(unchecked((double)this.UiGroupBox1.Width / 100.0 * 65.0));
					this.GridEX2.Left = 1;
					this.GridEX1.Left = this.GridEX2.Right + 3;
					this.GridEX1.Width = (int)Math.Round(unchecked((double)this.UiGroupBox1.Width / 100.0 * 35.0));
					this.EditBox1.Left = this.GridEX2.Right - this.EditBox1.Width;
					this.Label2.Left = this.EditBox1.Right + 2;
					this.Label1.Left = this.EditBox1.Left - this.Label1.Width - 5;
					this.UiButton2.Left = this.GridEX2.Right - this.UiButton2.Width;
					this.UiCheckBox2.Left = (int)Math.Round(unchecked((double)(checked(this.UiButton2.Left - this.UiButton2.Width)) - (double)this.UiCheckBox2.Width / 2.0));
				}
				else
				{
					this.GridEx3.Visible = true;
					this.GridEx3.Width = (int)Math.Round((double)this.UiGroupBox1.Width / 3.0);
					this.GridEx3.Left = 1;
					this.GridEX2.Width = this.GridEx3.Width - 3;
					this.GridEX1.Width = this.GridEX2.Width - 3;
					this.GridEX2.Left = this.GridEx3.Right + 3;
					this.GridEX1.Left = this.GridEX2.Right + 3;
				}
			}
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00215E8C File Offset: 0x0021408C
		private void Frm_rpt_ruzane_Resize(object sender, EventArgs e)
		{
			bool flag = MyProject.Forms.Form_Main.WindowState == FormWindowState.Minimized;
			if (!flag)
			{
				this.Align_Grid();
			}
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00215EBC File Offset: 0x002140BC
		private void LoadJamFurush()
		{
			string text = "jam_kol";
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				text = "jamkol_ba_kargari";
			}
			DataTable dataSource = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT 'فروش نقد حق العمل' as moshtari_name        ,sum([Tedad]) as Tedad       ,sum([Vazn_Kol]) as Vazn_kol       ,sum([",
				text,
				"]) as mablagh         FROM [Furush_Hag_Detail]             where moshtari_id=-1 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"         union all      SELECT 'فروش نسیه حق العمل' as moshtari_name       ,sum([Tedad]) as Tedad       ,sum([Vazn_Kol]) as Vazn_kol       ,sum([Jam_Kol]) as mablagh   FROM [Furush_Hag_Detail]   where moshtari_id>0 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"   union all   select 'فروش نقد بارروی زمین'as moshtari_name,   null as tedad,null as vazn_kol,sum(mablagh) as mablagh from daryaftpardakht   where dpType_id=28 AND DaryaftPardakht.Moshtari_ID=-1 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"   union all    SELECT 'فروش نقد خرید' as moshtari_name,     sum([Tedad]) as tedad     ,sum([Vazn_Kol]) as vazn_kol     ,sum([",
				text,
				"]) as mablagh     FROM [Kharid_Furush]     where moshtari_id=-1 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"   union all    SELECT 'فروش نسیه خرید' as moshtari_name,     sum([Tedad]) as tedad     ,sum([Vazn_Kol]) as vazn_kol     ,sum([Jam_Kol]) as mablagh     FROM [Kharid_Furush]     where moshtari_id>0 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"   union all    SELECT 'فروش نقد سردخانه' as moshtari_name,     sum([Tedad]) as tedad     ,sum([Vazn_Kol]) as vazn_kol     ,sum([Jam_Kol]) as mablagh     FROM [furush_sardkhane_detail]     where moshtari_id=-1 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text)),
				"  union all      SELECT 'فروش نسیه سردخانه' as moshtari_name       ,sum([Tedad]) as Tedad       ,sum([Vazn_Kol]) as Vazn_kol       ,sum([Jam_Kol]) as mablagh   FROM [furush_sardkhane_detail]   where moshtari_id>0 and tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh.Text))
			}));
			this.GridEX2.DataSource = dataSource;
			this.GridEX2.RootTable.Columns["name"].Visible = true;
			this.GridEX2.RootTable.Columns["name"].Caption = "عنوان";
			this.GridEX2.RootTable.Columns["num"].Visible = false;
			this.GridEX2.RootTable.Columns["tozih"].Visible = false;
			this.GridEX2.RootTable.Columns["Kala_Name"].Visible = false;
			this.GridEX2.RootTable.Columns["Tedad"].Visible = true;
			this.GridEX2.RootTable.Columns["Vazn_kol"].Visible = true;
			this.GridEX2.RootTable.Columns["vazn_ba_zarf"].Visible = false;
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00216130 File Offset: 0x00214330
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			this.GridEX2.RootTable.Columns["Tozih"].Visible = true;
			this.GridEX2.RootTable.Columns["name"].Visible = true;
			this.GridEX2.RootTable.Columns["Num"].Visible = false;
			this.GridEX2.RootTable.Columns["Kala_Name"].Visible = false;
			this.GridEX2.RootTable.Columns["Tedad"].Visible = false;
			this.GridEX2.RootTable.Columns["Vazn_kol"].Visible = false;
			this.GridEX2.RootTable.Columns["Vazn_Ba_zarf"].Visible = false;
			this.GridEX2.RootTable.Columns["sahebbar"].Visible = false;
			this.GridEX2.RootTable.Columns["Fee"].Visible = false;
			this.UiCheckBox2.Visible = false;
			this.GridEX2.RootTable.Columns["Name"].Caption = "مشتری";
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				this.Label1.Text = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
				this.dbl_grid = true;
				this.Align_Grid();
				this.GridEX2.RootTable.Columns["tozih"].Visible = true;
				object value = this.GridEX1.CurrentRow.Cells["ID"].Value;
				flag = Operators.ConditionalCompareObjectEqual(value, 0, false);
				if (flag)
				{
					this.LoadJamFurush();
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(value, 1, false);
					if (flag)
					{
						this.LoadDetail(1L, "");
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(value, 2, false);
						if (flag)
						{
							this.LoadDetailin("2,42", "");
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(value, 3, false);
							if (flag)
							{
								this.LoadDaramadDetail();
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(value, 4, false);
								if (flag)
								{
									this.LoadDetail(8L, "");
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(value, 5, false);
									if (flag)
									{
										this.LoadCheckDetail();
									}
									else
									{
										flag = Operators.ConditionalCompareObjectEqual(value, 6, false);
										if (flag)
										{
											this.LoadDetail(27L, "");
										}
										else
										{
											flag = Operators.ConditionalCompareObjectEqual(value, 7, false);
											if (flag)
											{
												this.LoadDetail(28L, " AND Moshtari_ID<> -1 ");
											}
											else
											{
												flag = Operators.ConditionalCompareObjectEqual(value, 8, false);
												if (flag)
												{
													this.UiCheckBox2.Visible = true;
													this.LoadFurushNaghd();
												}
												else
												{
													flag = Operators.ConditionalCompareObjectEqual(value, 9, false);
													if (flag)
													{
														this.LoadFurushDetail();
													}
													else
													{
														flag = Operators.ConditionalCompareObjectEqual(value, 10, false);
														if (flag)
														{
															this.LoadKeraye();
														}
														else
														{
															flag = Operators.ConditionalCompareObjectEqual(value, 11, false);
															if (flag)
															{
																this.LoadDetail(10L, "");
															}
															else
															{
																flag = Operators.ConditionalCompareObjectEqual(value, 12, false);
																if (flag)
																{
																	this.LoadDetail(12L, "");
																}
																else
																{
																	flag = Operators.ConditionalCompareObjectEqual(value, 13, false);
																	if (flag)
																	{
																		this.LoadDetail(11L, "");
																	}
																	else
																	{
																		flag = Operators.ConditionalCompareObjectEqual(value, 14, false);
																		if (flag)
																		{
																			this.LoadDetail(14L, "");
																		}
																		else
																		{
																			flag = Operators.ConditionalCompareObjectEqual(value, 15, false);
																			if (flag)
																			{
																				this.LoadDetail(15L, "");
																			}
																			else
																			{
																				flag = Operators.ConditionalCompareObjectEqual(value, 16, false);
																				if (flag)
																				{
																					this.LoadDetail(18L, "");
																				}
																				else
																				{
																					flag = Operators.ConditionalCompareObjectEqual(value, 17, false);
																					if (flag)
																					{
																						this.LoadDetail(20L, "");
																					}
																					else
																					{
																						flag = Operators.ConditionalCompareObjectEqual(value, 18, false);
																						if (flag)
																						{
																							this.LoadDetail(22L, "");
																						}
																						else
																						{
																							flag = Operators.ConditionalCompareObjectEqual(value, 19, false);
																							if (flag)
																							{
																								this.LoadDetail(29L, "");
																							}
																							else
																							{
																								flag = Operators.ConditionalCompareObjectEqual(value, 20, false);
																								if (flag)
																								{
																									this.LoadDetail(30L, "");
																								}
																								else
																								{
																									flag = Operators.ConditionalCompareObjectEqual(value, 21, false);
																									if (flag)
																									{
																										this.LoadDetail(31L, "");
																									}
																									else
																									{
																										flag = Operators.ConditionalCompareObjectEqual(value, 23, false);
																										if (flag)
																										{
																											this.LoadDetail(32L, "");
																										}
																										else
																										{
																											flag = Operators.ConditionalCompareObjectEqual(value, 24, false);
																											if (flag)
																											{
																												this.LoadDetail(40L, "");
																											}
																											else
																											{
																												flag = Operators.ConditionalCompareObjectEqual(value, 25, false);
																												if (flag)
																												{
																													this.LoadDetail(5L, "");
																												}
																												else
																												{
																													flag = Operators.ConditionalCompareObjectEqual(value, 26, false);
																													if (flag)
																													{
																														this.LoadDetail(16L, "");
																													}
																													else
																													{
																														this.GridEX2.DataSource = null;
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x0000B512 File Offset: 0x00009712
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX2, this.EditBox1.Text);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x0000205D File Offset: 0x0000025D
		private void GridEX2_SelectionChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00216700 File Offset: 0x00214900
		private void UiCheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.RootTable == null;
			if (!flag)
			{
				flag = this.UiCheckBox1.Checked;
				if (flag)
				{
					this.GridEX1.RootTable.FilterCondition = null;
					this.GridEX2.RootTable.FilterCondition = null;
				}
				else
				{
					this.GridEX1.RootTable.FilterCondition = this.GridEX1.RootTable.StoredFilters[0];
					this.GridEX2.RootTable.FilterCondition = this.GridEX2.RootTable.StoredFilters[0];
				}
			}
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x002167B0 File Offset: 0x002149B0
		private void UiButton1_Click(object sender, EventArgs e)
		{
			GridPrint gridPrint = new GridPrint();
			gridPrint.PrintGrid(this.GridEX1, "گزارش عملکرد روزانه مورخه " + this.txt_tarikh.Text);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x002167E8 File Offset: 0x002149E8
		private void UiButton2_Click(object sender, EventArgs e)
		{
			GridPrint gridPrint = new GridPrint();
			gridPrint.PrintGrid(this.GridEX2, "گزارش " + this.Label1.Text + " مورخه " + this.txt_tarikh.Text);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x0000B52D File Offset: 0x0000972D
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.LoadFurushNaghd();
		}

		// Token: 0x04001164 RID: 4452
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001166 RID: 4454
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001167 RID: 4455
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x04001168 RID: 4456
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04001169 RID: 4457
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400116A RID: 4458
		[AccessedThroughProperty("GridEX2")]
		private DataEntryGrid _GridEX2;

		// Token: 0x0400116B RID: 4459
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400116C RID: 4460
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400116D RID: 4461
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400116E RID: 4462
		[AccessedThroughProperty("GridEx3")]
		private DataEntryGrid _GridEx3;

		// Token: 0x0400116F RID: 4463
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x04001170 RID: 4464
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04001171 RID: 4465
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04001172 RID: 4466
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001173 RID: 4467
		private DaryaftPardakht dp;

		// Token: 0x04001174 RID: 4468
		private bool dbl_grid;
	}
}
