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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200012B RID: 299
	[DesignerGenerated]
	public partial class Frm_rpt_checksearch : Form
	{
		// Token: 0x06002B5F RID: 11103 RVA: 0x0000ADC5 File Offset: 0x00008FC5
		[DebuggerNonUserCode]
		public Frm_rpt_checksearch()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checksearch_KeyDown);
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			Frm_rpt_checksearch.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00205F00 File Offset: 0x00204100
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checksearch.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checksearch.__ENCList.Count == Frm_rpt_checksearch.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checksearch.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checksearch.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checksearch.__ENCList[num] = Frm_rpt_checksearch.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checksearch.__ENCList.RemoveRange(num, Frm_rpt_checksearch.__ENCList.Count - num);
						Frm_rpt_checksearch.__ENCList.Capacity = Frm_rpt_checksearch.__ENCList.Count;
					}
					Frm_rpt_checksearch.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x00206714 File Offset: 0x00204914
		// (set) Token: 0x06002B64 RID: 11108 RVA: 0x0020672C File Offset: 0x0020492C
		internal virtual GridEX GridEX1
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

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x0020678C File Offset: 0x0020498C
		// (set) Token: 0x06002B66 RID: 11110 RVA: 0x0000AE05 File Offset: 0x00009005
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

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x002067A4 File Offset: 0x002049A4
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x0000AE0F File Offset: 0x0000900F
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

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x002067BC File Offset: 0x002049BC
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x002067D4 File Offset: 0x002049D4
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

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x00206834 File Offset: 0x00204A34
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x0020684C File Offset: 0x00204A4C
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002B6D RID: 11117 RVA: 0x002068AC File Offset: 0x00204AAC
		// (set) Token: 0x06002B6E RID: 11118 RVA: 0x0000AE19 File Offset: 0x00009019
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

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002B6F RID: 11119 RVA: 0x002068C4 File Offset: 0x00204AC4
		// (set) Token: 0x06002B70 RID: 11120 RVA: 0x002068DC File Offset: 0x00204ADC
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

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0020693C File Offset: 0x00204B3C
		// (set) Token: 0x06002B72 RID: 11122 RVA: 0x0000AE23 File Offset: 0x00009023
		public int? Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002B73 RID: 11123 RVA: 0x00206954 File Offset: 0x00204B54
		// (set) Token: 0x06002B74 RID: 11124 RVA: 0x0000AE2D File Offset: 0x0000902D
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x0020696C File Offset: 0x00204B6C
		private void Add()
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

		// Token: 0x06002B76 RID: 11126 RVA: 0x00206AD8 File Offset: 0x00204CD8
		private string AddSqlFilter(string fields, string _like, bool AddWhere)
		{
			string text = string.Empty;
			if (AddWhere)
			{
				text = " where ";
			}
			else
			{
				text = " AND ( ";
			}
			string[] array = fields.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string text2 = array2[i];
					text = string.Concat(new string[]
					{
						text,
						"cast(",
						text2,
						" as nvarchar(50)) like N'%",
						_like,
						"%' OR "
					});
				}
				text = text.Remove(text.Length - 4, 4);
				bool flag = !AddWhere;
				if (flag)
				{
					text += ")";
				}
				return text;
			}
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x00206BAC File Offset: 0x00204DAC
		private void LoadData(bool haswhere, string _like)
		{
			string empty = string.Empty;
			string text = " SELECT     NULL AS ID_Last, NULL AS dpType_ID_Last, NULL AS Tarikh_Last, NULL AS Moshtari_ID_Last, NULL AS BankHesab_ID_Last, NULL AS Mablagh_Last, NULL  AS Tozih_Last, NULL AS Tarikh_Fa_Last, NULL AS Sh_Check_Last, NULL AS CheckBank_ID_Last, NULL AS Check_Shobe_Last, NULL AS Check_Sarresid_Last, NULL  AS Check_Sarresid_Fa_Last, NULL AS Check_Status_Last, NULL AS Check_ShomareHesab_Last, NULL AS CheckBarg_ID_Last, NULL AS PardakhtCheck_ID_Last,  DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid,  DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.CheckBarg_ID,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name, NULL AS Last_Moshtari_Name, NULL  AS Last_BankHesab,NULL AS LastName FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID Left Outer JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99,42)) AND (DaryaftPardakht.Check_Status = 1) ";
			bool flag = Operators.CompareString(_like, string.Empty, false) != 0;
			if (flag)
			{
				text += this.AddSqlFilter("mablagh,moshtari.name+' '+moshtari.family,Sh_Check,CheckStatus_Name.Name,Bank.Name,DaryaftPardakht.Check_Shobe,Tarikh_Fa,DaryaftPardakht.Tarikh_Fa,DaryaftPardakht.Check_Sarresid_Fa,DaryaftPardakht.Check_ShomareHesab", _like, false);
			}
			text += " UNION ALL ";
			text += " SELECT     Last.ID AS ID_Last, Last.dpType_ID AS dpType_ID_Last, Last.Tarikh AS Tarikh_Last, Last.Moshtari_ID AS Moshtari_ID_Last,   Last.BankHesab_ID AS BankHesab_ID_Last, Last.Mablagh AS Mablagh_Last, Last.Tozih AS Tozih_Last, Last.Tarikh_Fa AS Tarikh_Fa_Last,   Last.Sh_Check AS Sh_Check_Last, Last.CheckBank_ID AS CheckBank_ID_Last, Last.Check_Shobe AS Check_Shobe_Last,   Last.Check_Sarresid AS Check_Sarresid_Last, Last.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, Last.Check_Status AS Check_Status_Last,   Last.Check_ShomareHesab AS Check_ShomareHesab_Last, Last.CheckBarg_ID AS CheckBarg_ID_Last, Last.PardakhtCheck_ID AS PardakhtCheck_ID_Last,   DaryaftPardakht_2.ID, DaryaftPardakht_2.dpType_ID, DaryaftPardakht_2.Tarikh, DaryaftPardakht_2.Moshtari_ID, DaryaftPardakht_2.Mablagh,   DaryaftPardakht_2.Tozih, DaryaftPardakht_2.Tarikh_Fa, DaryaftPardakht_2.Sh_Check, DaryaftPardakht_2.CheckBank_ID, DaryaftPardakht_2.Check_Shobe,   DaryaftPardakht_2.Check_Sarresid, DaryaftPardakht_2.Check_Sarresid_Fa, DaryaftPardakht_2.Check_Status, DaryaftPardakht_2.Check_ShomareHesab,   DaryaftPardakht_2.CheckBarg_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name,   Moshtari_1.Name + ' ' + Moshtari_1.Family AS Last_Moshtari_Name, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Last_BankHesab,case when last.check_status in(2,4) then Bank_1.Name + '-' + Bank_Hesab.Shobe when last.check_status in(1,5) then Moshtari_1.Name + ' ' + Moshtari_1.Family END AS Last_Name   FROM         Bank_Hesab RIGHT OUTER JOIN   Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID RIGHT OUTER JOIN  (SELECT     DaryaftPardakht_1.ID, DaryaftPardakht_1.dpType_ID, DaryaftPardakht_1.Tarikh, DaryaftPardakht_1.Moshtari_ID, DaryaftPardakht_1.BankHesab_ID,   DaryaftPardakht_1.Mablagh, DaryaftPardakht_1.Tozih, DaryaftPardakht_1.Tarikh_Fa, DaryaftPardakht_1.Sh_Check, DaryaftPardakht_1.CheckBank_ID,  DaryaftPardakht_1.Check_Shobe, DaryaftPardakht_1.Check_Sarresid, DaryaftPardakht_1.Check_Sarresid_Fa, DaryaftPardakht_1.Check_Status,  DaryaftPardakht_1.Check_ShomareHesab, DaryaftPardakht_1.CheckBarg_ID, DaryaftPardakht_1.PardakhtCheck_ID            FROM         (SELECT     MAX(ID) AS ID   FROM DaryaftPardakht   where PardakhtCheck_ID Is Not NULL  GROUP BY PardakhtCheck_ID) AS t INNER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.ID) AS Last INNER JOIN   DaryaftPardakht AS DaryaftPardakht_2 ON Last.PardakhtCheck_ID = DaryaftPardakht_2.ID INNER JOIN   Moshtari ON DaryaftPardakht_2.Moshtari_ID = Moshtari.ID Left Outer JOIN    Bank ON DaryaftPardakht_2.CheckBank_ID = Bank.ID INNER JOIN    CheckStatus_Name ON DaryaftPardakht_2.Check_Status = CheckStatus_Name.ID ON Bank_Hesab.ID = Last.BankHesab_ID LEFT OUTER JOIN    Moshtari AS Moshtari_1 ON Last.Moshtari_ID = Moshtari_1.ID";
			if (haswhere)
			{
				text += "    where last.check_status not in (3,4)";
			}
			flag = (Operators.CompareString(_like, string.Empty, false) != 0);
			if (flag)
			{
				text += this.AddSqlFilter("last.mablagh,moshtari.name+' '+moshtari.family,Last.Sh_Check,CheckStatus_Name.Name,Bank.Name,DaryaftPardakht_2.Check_Shobe,Last.Tarikh_Fa,DaryaftPardakht_2.Tarikh_Fa,DaryaftPardakht_2.Check_Sarresid_Fa,DaryaftPardakht_2.Check_ShomareHesab,Bank_1.Name + '-' + Bank_Hesab.Shobe,Moshtari_1.Name + ' ' + Moshtari_1.Family", _like, true);
			}
			flag = (Operators.CompareString(_like, string.Empty, false) != 0);
			if (flag)
			{
				text += " UNION ALL ";
				text += "SELECT     Last.ID AS ID_Last, Last.dpType_ID AS dpType_ID_Last, Last.Tarikh AS Tarikh_Last, Last.Moshtari_ID AS Moshtari_ID_Last,   Last.BankHesab_ID AS BankHesab_ID_Last, Last.Mablagh AS Mablagh_Last, Last.Tozih AS Tozih_Last, Last.Tarikh_Fa AS Tarikh_Fa_Last,   Last.Sh_Check AS Sh_Check_Last, Last.CheckBank_ID AS CheckBank_ID_Last, Last.Check_Shobe AS Check_Shobe_Last,   Last.Check_Sarresid AS Check_Sarresid_Last, Last.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, Last.Check_Status AS Check_Status_Last,   Last.Check_ShomareHesab AS Check_ShomareHesab_Last, Last.CheckBarg_ID AS CheckBarg_ID_Last, Last.PardakhtCheck_ID AS PardakhtCheck_ID_Last,   DaryaftPardakht_2.ID, DaryaftPardakht_2.dpType_ID, DaryaftPardakht_2.Tarikh, DaryaftPardakht_2.Moshtari_ID, DaryaftPardakht_2.Mablagh,   DaryaftPardakht_2.Tozih, DaryaftPardakht_2.Tarikh_Fa, DaryaftPardakht_2.Sh_Check, DaryaftPardakht_2.CheckBank_ID, DaryaftPardakht_2.Check_Shobe,   DaryaftPardakht_2.Check_Sarresid, DaryaftPardakht_2.Check_Sarresid_Fa, DaryaftPardakht_2.Check_Status, Bank_Hesab.Sh_Hesab AS Check_ShomareHesab,   DaryaftPardakht_2.CheckBarg_ID, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name,  Moshtari_1.Name + ' ' + Moshtari_1.Family AS Last_Moshtari_Name, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Last_BankHesab,   Moshtari.Name + ' ' + Moshtari.Family AS Last_Name   FROM         Bank_Hesab RIGHT OUTER JOIN   Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID RIGHT OUTER JOIN       (SELECT     DaryaftPardakht_1.ID, DaryaftPardakht_1.dpType_ID, DaryaftPardakht_1.Tarikh, DaryaftPardakht_1.Moshtari_ID, DaryaftPardakht_1.BankHesab_ID,        DaryaftPardakht_1.Mablagh, DaryaftPardakht_1.Tozih, DaryaftPardakht_1.Tarikh_Fa, DaryaftPardakht_1.Sh_Check, DaryaftPardakht_1.CheckBank_ID,   DaryaftPardakht_1.Check_Shobe, DaryaftPardakht_1.Check_Sarresid, DaryaftPardakht_1.Check_Sarresid_Fa, DaryaftPardakht_1.Check_Status,   DaryaftPardakht_1.Check_ShomareHesab, DaryaftPardakht_1.CheckBarg_ID, DaryaftPardakht_1.PardakhtCheck_ID   FROM         (SELECT     MAX(ID) AS ID   FROM DaryaftPardakht     where (PardakhtCheck_ID Is Not NULL) And (CheckBarg_ID Is Not NULL)   GROUP BY PardakhtCheck_ID) AS t INNER JOIN   DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.ID) AS Last INNER JOIN   DaryaftPardakht AS DaryaftPardakht_2 ON Last.PardakhtCheck_ID = DaryaftPardakht_2.ID INNER JOIN   Moshtari ON DaryaftPardakht_2.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON DaryaftPardakht_2.CheckBank_ID = Bank.ID LEFT OUTER JOIN   CheckStatus_Name ON DaryaftPardakht_2.Check_Status = CheckStatus_Name.ID ON Bank_Hesab.ID = Last.BankHesab_ID LEFT OUTER JOIN   Moshtari AS Moshtari_1 ON Last.Moshtari_ID = Moshtari_1.ID";
				flag = (Operators.CompareString(_like, string.Empty, false) != 0);
				if (flag)
				{
					text += this.AddSqlFilter("last.mablagh,moshtari.name+' '+moshtari.family,Last.Sh_Check,CheckStatus_Name.Name,Bank.Name,DaryaftPardakht_2.Check_Shobe,Last.Tarikh_Fa,DaryaftPardakht_2.Tarikh_Fa,DaryaftPardakht_2.Check_Sarresid_Fa,DaryaftPardakht_2.Check_ShomareHesab,Bank_1.Name + '-' + Bank_Hesab.Shobe,Moshtari.Name + ' ' + Moshtari.Family", _like, true);
				}
				text += " UNION ALL ";
				text += "SELECT     DaryaftPardakht.ID AS ID_Last, DaryaftPardakht.dpType_ID AS dpType_ID_Last, DaryaftPardakht.Tarikh AS Tarikh_Last, DaryaftPardakht.Moshtari_ID AS Moshtari_ID_Last,      NULL AS BankHesab_ID_Last,DaryaftPardakht.Mablagh AS Mablagh_Last, DaryaftPardakht.Tozih AS Tozih_Last, DaryaftPardakht.Tarikh_Fa as Tarikh_Fa_Last, DaryaftPardakht.Sh_Check AS Sh_Check_Last, DaryaftPardakht.CheckBank_ID AS CheckBank_ID_Last,      Bank_Hesab.Shobe AS Check_Shobe_Last, DaryaftPardakht.Check_Sarresid AS Check_Sarresid_Last, DaryaftPardakht.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, DaryaftPardakht.Check_Status AS Check_Status_Last,      DaryaftPardakht.Check_ShomareHesab AS Check_ShomareHesab_Last, DaryaftPardakht.CheckBarg_ID AS CheckBarg_ID_Last,NULL AS Pardakht_Check_Id_Last,DaryaftPardakht.ID,DaryaftPardakht.dpType_ID,DaryaftPardakht.Tarikh,     DaryaftPardakht.Moshtari_ID,DaryaftPardakht.Mablagh,DaryaftPardakht.Tozih,DaryaftPardakht.Tarikh_Fa,DaryaftPardakht.Sh_Check,DaryaftPardakht.CheckBank_ID,Bank_Hesab.Shobe AS Check_Shobe,DaryaftPardakht.Check_Sarresid,     DaryaftPardakht.Check_Sarresid_Fa,DaryaftPardakht.Check_Status,DaryaftPardakht.Check_ShomareHesab,DaryaftPardakht.CheckBarg_ID,     hazine.name  AS Moshtari_Name, Bank.Name AS Bank_Name,      CheckStatus_Name.Name AS Stat_Name,hazine.name  AS Last_Moshtari_Name,NULL AS Last_BankHesab, Hazine.Name AS Last_Name     FROM         Hazine RIGHT OUTER JOIN    DaryaftPardakht INNER JOIN    CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID ON Hazine.ID = DaryaftPardakht.Hazine_ID LEFT OUTER JOIN    DasteCheck INNER JOIN    DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN    Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN    Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID LEFT OUTER JOIN    Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID    WHERE     (DaryaftPardakht.dpType_ID IN (11,15) AND (DaryaftPardakht.Check_Status IN (3,5))) AND (DaryaftPardakht.Hazine_ID is not null OR DaryaftPardakht.HazineKharid_ID is not null)";
				flag = (Operators.CompareString(_like, string.Empty, false) != 0);
				if (flag)
				{
					text += this.AddSqlFilter("mablagh,moshtari.name+' '+moshtari.family,Sh_Check,Bank.Name,DaryaftPardakht.Check_Shobe,Tarikh_Fa,DaryaftPardakht.Tarikh_Fa,DaryaftPardakht.Check_Sarresid_Fa,DaryaftPardakht.Check_ShomareHesab,Bank_1.Name + '-' + Bank_Hesab.Shobe,hazine.Name", _like, false);
				}
				text += "     UNION ALL ";
				text += "     SELECT     DaryaftPardakht.ID AS ID_Last, DaryaftPardakht.dpType_ID AS dpType_ID_Last, DaryaftPardakht.Tarikh AS Tarikh_Last, DaryaftPardakht.Moshtari_ID AS Moshtari_ID_Last,       NULL AS BankHesab_ID_Last,DaryaftPardakht.Mablagh AS Mablagh_Last, DaryaftPardakht.Tozih AS Tozih_Last, DaryaftPardakht.Tarikh_Fa as Tarikh_Fa_Last, DaryaftPardakht.Sh_Check AS Sh_Check_Last, DaryaftPardakht.CheckBank_ID AS CheckBank_ID_Last,       Bank_Hesab.Shobe AS Check_Shobe_Last, DaryaftPardakht.Check_Sarresid AS Check_Sarresid_Last, DaryaftPardakht.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, DaryaftPardakht.Check_Status AS Check_Status_Last,       DaryaftPardakht.Check_ShomareHesab AS Check_ShomareHesab_Last, DaryaftPardakht.CheckBarg_ID AS CheckBarg_ID_Last,NULL AS Pardakht_Check_Id_Last,DaryaftPardakht.ID,DaryaftPardakht.dpType_ID,DaryaftPardakht.Tarikh,      DaryaftPardakht.Moshtari_ID,DaryaftPardakht.Mablagh,DaryaftPardakht.Tozih,DaryaftPardakht.Tarikh_Fa,DaryaftPardakht.Sh_Check,DaryaftPardakht.CheckBank_ID,Bank_Hesab.Shobe AS Check_Shobe,DaryaftPardakht.Check_Sarresid,      DaryaftPardakht.Check_Sarresid_Fa,DaryaftPardakht.Check_Status,DaryaftPardakht.Check_ShomareHesab,DaryaftPardakht.CheckBarg_ID,      hazine.name  AS Moshtari_Name, Bank.Name AS Bank_Name,       CheckStatus_Name.Name AS Stat_Name,hazine.name  AS Last_Moshtari_Name,NULL AS Last_BankHesab, Hazine.Name AS Last_Name      FROM         Hazine RIGHT OUTER JOIN       DaryaftPardakht INNER JOIN       CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID ON Hazine.ID = DaryaftPardakht.Hazine_ID LEFT OUTER JOIN       DasteCheck INNER JOIN       DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN       Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN       Bank ON Bank_Hesab.Bank_ID = Bank.ID ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID LEFT OUTER JOIN       Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID LEFT OUTER JOIN       Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID       WHERE     (DaryaftPardakht.dpType_ID IN (40) AND (DaryaftPardakht.Check_Status IN (3,5))) ";
				flag = (Operators.CompareString(_like, string.Empty, false) != 0);
				if (flag)
				{
					text += this.AddSqlFilter("mablagh,moshtari.name+' '+moshtari.family,Sh_Check,Bank.Name,DaryaftPardakht.Check_Shobe,Tarikh_Fa,DaryaftPardakht.Tarikh_Fa,DaryaftPardakht.Check_Sarresid_Fa,DaryaftPardakht.Check_ShomareHesab,Bank_1.Name + '-' + Bank_Hesab.Shobe,hazine.Name", _like, false);
				}
			}
			text += "order by DaryaftPardakht.Check_Sarresid";
			DataTable dataTable = Public_Function.FillData(text);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			string text2 = string.Empty;
			bool flag3;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["dptype_id_last"] != DBNull.Value);
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id_last"], 22, false);
						if (flag2)
						{
							flag3 = (dataRow["last_bankhesab"] == DBNull.Value);
							if (flag3)
							{
								dictionary.Add(Conversions.ToInteger(dataRow["pardakhtcheck_id_last"]), dataTable.Rows.IndexOf(dataRow));
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow["pardakhtcheck_id_last"], ",")));
							}
						}
					}
					flag3 = (dataRow["lastname"] == DBNull.Value);
					if (flag3)
					{
						bool flag2 = dataRow["Tozih_last"] != DBNull.Value;
						if (flag2)
						{
							dataRow["lastname"] = RuntimeHelpers.GetObjectValue(dataRow["tozih_last"]);
						}
					}
					flag3 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -99, false);
					if (flag3)
					{
						dataRow["Tarikh_Fa"] = "اول دوره";
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag3 = (enumerator is IDisposable);
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			text2 = Public_Function.RemoveLast(text2);
			flag3 = (text2.Length > 0);
			if (flag3)
			{
				DataTable dataTable2 = Public_Function.FillData("SELECT     DaryaftPardakht.PardakhtCheck_ID, Moshtari.Name+' '+ Moshtari.Family as name  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE     (DaryaftPardakht.PardakhtCheck_ID In (" + text2 + ")) AND (DaryaftPardakht.dpType_ID = 12)");
				try
				{
					IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						dataTable.Rows[dictionary[Conversions.ToInteger(dataRow2["pardakhtcheck_Id"])]]["lastname"] = RuntimeHelpers.GetObjectValue(dataRow2["name"]);
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
			}
			this.GridEX1.DataSource = dataTable;
			this.Add();
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_rpt_checksearch_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x00206FE8 File Offset: 0x002051E8
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			Initdb initdb = new Initdb();
			initdb.Update_checkStatus();
			this.LoadData(true, "");
			this.EditBox1.Focus();
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002B7B RID: 11131 RVA: 0x00207020 File Offset: 0x00205220
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\checkdaryafti.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			this.SetHeader(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x00207090 File Offset: 0x00205290
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				this.LoadData(false, this.EditBox1.Text);
				Public_Function.HighlightCell(this.GridEX1, this.EditBox1.Text);
			}
			else
			{
				this.LoadData(true, "");
			}
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x002070FC File Offset: 0x002052FC
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				this.GridEX1.MoveLast();
			}
			catch (Exception expr_1D)
			{
				ProjectData.SetProjectError(expr_1D);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00207148 File Offset: 0x00205348
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = ((IEnumerable)e.Row.Cells).GetEnumerator();
					while (enumerator.MoveNext())
					{
						GridEXCell gridEXCell = (GridEXCell)enumerator.Current;
						bool flag2 = gridEXCell.Value.ToString().Contains(this.EditBox1.Text);
						if (flag2)
						{
							gridEXCell.FormatStyle = new GridEXFormatStyle();
							gridEXCell.FormatStyle.BackColor = Color.Khaki;
						}
						flag2 = gridEXCell.Text.Contains(this.EditBox1.Text);
						if (flag2)
						{
							gridEXCell.FormatStyle = new GridEXFormatStyle();
							gridEXCell.FormatStyle.BackColor = Color.Khaki;
						}
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
			}
		}

		// Token: 0x040010E2 RID: 4322
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010E4 RID: 4324
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010E5 RID: 4325
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010E6 RID: 4326
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010E7 RID: 4327
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010E8 RID: 4328
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010E9 RID: 4329
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010EA RID: 4330
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040010EB RID: 4331
		[CompilerGenerated]
		private int? _Moshtari_ID;

		// Token: 0x040010EC RID: 4332
		[CompilerGenerated]
		private string _Moshtari_Name;
	}
}
