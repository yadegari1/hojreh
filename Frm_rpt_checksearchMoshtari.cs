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
	// Token: 0x0200012C RID: 300
	[DesignerGenerated]
	public partial class Frm_rpt_checksearchMoshtari : Form
	{
		// Token: 0x06002B80 RID: 11136 RVA: 0x0000AE44 File Offset: 0x00009044
		[DebuggerNonUserCode]
		public Frm_rpt_checksearchMoshtari()
		{
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checksearch_KeyDown);
			Frm_rpt_checksearchMoshtari.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x0020725C File Offset: 0x0020545C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checksearchMoshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checksearchMoshtari.__ENCList.Count == Frm_rpt_checksearchMoshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checksearchMoshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checksearchMoshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checksearchMoshtari.__ENCList[num] = Frm_rpt_checksearchMoshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checksearchMoshtari.__ENCList.RemoveRange(num, Frm_rpt_checksearchMoshtari.__ENCList.Count - num);
						Frm_rpt_checksearchMoshtari.__ENCList.Capacity = Frm_rpt_checksearchMoshtari.__ENCList.Count;
					}
					Frm_rpt_checksearchMoshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x00207A70 File Offset: 0x00205C70
		// (set) Token: 0x06002B85 RID: 11141 RVA: 0x00207A88 File Offset: 0x00205C88
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

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x00207AE8 File Offset: 0x00205CE8
		// (set) Token: 0x06002B87 RID: 11143 RVA: 0x0000AE84 File Offset: 0x00009084
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

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002B88 RID: 11144 RVA: 0x00207B00 File Offset: 0x00205D00
		// (set) Token: 0x06002B89 RID: 11145 RVA: 0x0000AE8E File Offset: 0x0000908E
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x00207B18 File Offset: 0x00205D18
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00207B30 File Offset: 0x00205D30
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

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002B8C RID: 11148 RVA: 0x00207B90 File Offset: 0x00205D90
		// (set) Token: 0x06002B8D RID: 11149 RVA: 0x00207BA8 File Offset: 0x00205DA8
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

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x00207C08 File Offset: 0x00205E08
		// (set) Token: 0x06002B8F RID: 11151 RVA: 0x0000AE98 File Offset: 0x00009098
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

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002B90 RID: 11152 RVA: 0x00207C20 File Offset: 0x00205E20
		// (set) Token: 0x06002B91 RID: 11153 RVA: 0x00207C38 File Offset: 0x00205E38
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

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x00207C98 File Offset: 0x00205E98
		// (set) Token: 0x06002B93 RID: 11155 RVA: 0x0000AEA2 File Offset: 0x000090A2
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

		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06002B94 RID: 11156 RVA: 0x00207CB0 File Offset: 0x00205EB0
		// (set) Token: 0x06002B95 RID: 11157 RVA: 0x0000AEAC File Offset: 0x000090AC
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

		// Token: 0x06002B96 RID: 11158 RVA: 0x00207CC8 File Offset: 0x00205EC8
		private void LoadData2(bool haswhere)
		{
			string empty = string.Empty;
			string arg_32_0 = " SELECT     NULL AS ID_Last, NULL AS dpType_ID_Last, NULL AS Tarikh_Last, NULL AS Moshtari_ID_Last, NULL AS BankHesab_ID_Last, NULL AS Mablagh_Last, NULL  AS Tozih_Last, NULL AS Tarikh_Fa_Last, NULL AS Sh_Check_Last, NULL AS CheckBank_ID_Last, NULL AS Check_Shobe_Last, NULL AS Check_Sarresid_Last, NULL  AS Check_Sarresid_Fa_Last, NULL AS Check_Status_Last, NULL AS Check_ShomareHesab_Last, NULL AS CheckBarg_ID_Last, NULL AS PardakhtCheck_ID_Last,  DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid,  DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.CheckBarg_ID,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name, NULL AS Last_Moshtari_Name, NULL  AS Last_BankHesab,NULL AS LastName FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE     (DaryaftPardakht.dpType_ID IN (2, - 99)) AND (DaryaftPardakht.Check_Status = 1) AND (DaryaftPardakht.Moshtari_id = ";
			int? moshtari_ID = this.Moshtari_ID;
			string text = arg_32_0 + (moshtari_ID.HasValue ? Conversions.ToString(moshtari_ID.GetValueOrDefault()) : null) + ") ";
			text += " UNION ALL ";
			text += " SELECT     Last.ID AS ID_Last, Last.dpType_ID AS dpType_ID_Last, Last.Tarikh AS Tarikh_Last, Last.Moshtari_ID AS Moshtari_ID_Last,   Last.BankHesab_ID AS BankHesab_ID_Last, Last.Mablagh AS Mablagh_Last, Last.Tozih AS Tozih_Last, Last.Tarikh_Fa AS Tarikh_Fa_Last,   Last.Sh_Check AS Sh_Check_Last, Last.CheckBank_ID AS CheckBank_ID_Last, Last.Check_Shobe AS Check_Shobe_Last,   Last.Check_Sarresid AS Check_Sarresid_Last, Last.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, Last.Check_Status AS Check_Status_Last,   Last.Check_ShomareHesab AS Check_ShomareHesab_Last, Last.CheckBarg_ID AS CheckBarg_ID_Last, Last.PardakhtCheck_ID AS PardakhtCheck_ID_Last,   DaryaftPardakht_2.ID, DaryaftPardakht_2.dpType_ID, DaryaftPardakht_2.Tarikh, DaryaftPardakht_2.Moshtari_ID, DaryaftPardakht_2.Mablagh,   DaryaftPardakht_2.Tozih, DaryaftPardakht_2.Tarikh_Fa, DaryaftPardakht_2.Sh_Check, DaryaftPardakht_2.CheckBank_ID, DaryaftPardakht_2.Check_Shobe,   DaryaftPardakht_2.Check_Sarresid, DaryaftPardakht_2.Check_Sarresid_Fa, DaryaftPardakht_2.Check_Status, DaryaftPardakht_2.Check_ShomareHesab,   DaryaftPardakht_2.CheckBarg_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name,   Moshtari_1.Name + ' ' + Moshtari_1.Family AS Last_Moshtari_Name, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Last_BankHesab,case when last.check_status in(2,4) then Bank_1.Name + '-' + Bank_Hesab.Shobe when last.check_status in(1,5) then Moshtari_1.Name + ' ' + Moshtari_1.Family END AS Last_Name   FROM         Bank_Hesab RIGHT OUTER JOIN   Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID RIGHT OUTER JOIN  (SELECT     DaryaftPardakht_1.ID, DaryaftPardakht_1.dpType_ID, DaryaftPardakht_1.Tarikh, DaryaftPardakht_1.Moshtari_ID, DaryaftPardakht_1.BankHesab_ID,   DaryaftPardakht_1.Mablagh, DaryaftPardakht_1.Tozih, DaryaftPardakht_1.Tarikh_Fa, DaryaftPardakht_1.Sh_Check, DaryaftPardakht_1.CheckBank_ID,  DaryaftPardakht_1.Check_Shobe, DaryaftPardakht_1.Check_Sarresid, DaryaftPardakht_1.Check_Sarresid_Fa, DaryaftPardakht_1.Check_Status,  DaryaftPardakht_1.Check_ShomareHesab, DaryaftPardakht_1.CheckBarg_ID, DaryaftPardakht_1.PardakhtCheck_ID            FROM         (SELECT     MAX(ID) AS ID   FROM DaryaftPardakht   where PardakhtCheck_ID Is Not NULL  GROUP BY PardakhtCheck_ID) AS t INNER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.ID) AS Last INNER JOIN   DaryaftPardakht AS DaryaftPardakht_2 ON Last.PardakhtCheck_ID = DaryaftPardakht_2.ID INNER JOIN   Moshtari ON DaryaftPardakht_2.Moshtari_ID = Moshtari.ID INNER JOIN    Bank ON DaryaftPardakht_2.CheckBank_ID = Bank.ID INNER JOIN    CheckStatus_Name ON DaryaftPardakht_2.Check_Status = CheckStatus_Name.ID ON Bank_Hesab.ID = Last.BankHesab_ID LEFT OUTER JOIN    Moshtari AS Moshtari_1 ON Last.Moshtari_ID = Moshtari_1.ID";
			if (haswhere)
			{
				text += "    where last.check_status not in (3,4)";
			}
			text += " UNION ALL ";
			text += "SELECT     Last.ID AS ID_Last, Last.dpType_ID AS dpType_ID_Last, Last.Tarikh AS Tarikh_Last, Last.Moshtari_ID AS Moshtari_ID_Last,   Last.BankHesab_ID AS BankHesab_ID_Last, Last.Mablagh AS Mablagh_Last, Last.Tozih AS Tozih_Last, Last.Tarikh_Fa AS Tarikh_Fa_Last,   Last.Sh_Check AS Sh_Check_Last, Last.CheckBank_ID AS CheckBank_ID_Last, Last.Check_Shobe AS Check_Shobe_Last,   Last.Check_Sarresid AS Check_Sarresid_Last, Last.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, Last.Check_Status AS Check_Status_Last,   Last.Check_ShomareHesab AS Check_ShomareHesab_Last, Last.CheckBarg_ID AS CheckBarg_ID_Last, Last.PardakhtCheck_ID AS PardakhtCheck_ID_Last,   DaryaftPardakht_2.ID, DaryaftPardakht_2.dpType_ID, DaryaftPardakht_2.Tarikh, DaryaftPardakht_2.Moshtari_ID, DaryaftPardakht_2.Mablagh,   DaryaftPardakht_2.Tozih, DaryaftPardakht_2.Tarikh_Fa, DaryaftPardakht_2.Sh_Check, DaryaftPardakht_2.CheckBank_ID, DaryaftPardakht_2.Check_Shobe,   DaryaftPardakht_2.Check_Sarresid, DaryaftPardakht_2.Check_Sarresid_Fa, DaryaftPardakht_2.Check_Status, Bank_Hesab.Sh_Hesab AS Check_ShomareHesab,   DaryaftPardakht_2.CheckBarg_ID, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name,  Moshtari_1.Name + ' ' + Moshtari_1.Family AS Last_Moshtari_Name, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Last_BankHesab,   Moshtari.Name + ' ' + Moshtari.Family AS Last_Name   FROM         Bank_Hesab RIGHT OUTER JOIN   Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID RIGHT OUTER JOIN       (SELECT     DaryaftPardakht_1.ID, DaryaftPardakht_1.dpType_ID, DaryaftPardakht_1.Tarikh, DaryaftPardakht_1.Moshtari_ID, DaryaftPardakht_1.BankHesab_ID,        DaryaftPardakht_1.Mablagh, DaryaftPardakht_1.Tozih, DaryaftPardakht_1.Tarikh_Fa, DaryaftPardakht_1.Sh_Check, DaryaftPardakht_1.CheckBank_ID,   DaryaftPardakht_1.Check_Shobe, DaryaftPardakht_1.Check_Sarresid, DaryaftPardakht_1.Check_Sarresid_Fa, DaryaftPardakht_1.Check_Status,   DaryaftPardakht_1.Check_ShomareHesab, DaryaftPardakht_1.CheckBarg_ID, DaryaftPardakht_1.PardakhtCheck_ID   FROM         (SELECT     MAX(ID) AS ID   FROM DaryaftPardakht     where (PardakhtCheck_ID Is Not NULL) And (CheckBarg_ID Is Not NULL)   GROUP BY PardakhtCheck_ID) AS t INNER JOIN   DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.ID) AS Last INNER JOIN   DaryaftPardakht AS DaryaftPardakht_2 ON Last.PardakhtCheck_ID = DaryaftPardakht_2.ID INNER JOIN   Moshtari ON DaryaftPardakht_2.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON DaryaftPardakht_2.CheckBank_ID = Bank.ID LEFT OUTER JOIN   CheckStatus_Name ON DaryaftPardakht_2.Check_Status = CheckStatus_Name.ID ON Bank_Hesab.ID = Last.BankHesab_ID LEFT OUTER JOIN   Moshtari AS Moshtari_1 ON Last.Moshtari_ID = Moshtari_1.ID";
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
					bool flag = dataRow["dptype_id_last"] != DBNull.Value;
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
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00207FF8 File Offset: 0x002061F8
		private void LoadData(bool haswhere, string _like)
		{
			string empty = string.Empty;
			string[] array = new string[11];
			array[0] = " SELECT     NULL AS ID_Last, NULL AS dpType_ID_Last, NULL AS Tarikh_Last, NULL AS Moshtari_ID_Last, NULL AS BankHesab_ID_Last, NULL AS Mablagh_Last, NULL  AS Tozih_Last, NULL AS Tarikh_Fa_Last, NULL AS Sh_Check_Last, NULL AS CheckBank_ID_Last, NULL AS Check_Shobe_Last, NULL AS Check_Sarresid_Last, NULL  AS Check_Sarresid_Fa_Last, NULL AS Check_Status_Last, NULL AS Check_ShomareHesab_Last, NULL AS CheckBarg_ID_Last, NULL AS PardakhtCheck_ID_Last,  DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid,  DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.CheckBarg_ID,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name, NULL AS Last_Moshtari_Name, NULL  AS Last_BankHesab,NULL AS LastName FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN  CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID   WHERE  (DaryaftPardakht.Moshtari_ID=";
			string[] arg_3E_0 = array;
			int arg_3E_1 = 1;
			int? moshtari_ID = this.Moshtari_ID;
			arg_3E_0[arg_3E_1] = (moshtari_ID.HasValue ? Conversions.ToString(moshtari_ID.GetValueOrDefault()) : null);
			array[2] = ") AND (DaryaftPardakht.dpType_ID IN (2, - 99)) AND (DaryaftPardakht.Check_Status = 1)   UNION ALL  SELECT     Last.ID AS ID_Last, Last.dpType_ID AS dpType_ID_Last, Last.Tarikh AS Tarikh_Last, Last.Moshtari_ID AS Moshtari_ID_Last,   Last.BankHesab_ID AS BankHesab_ID_Last, Last.Mablagh AS Mablagh_Last, Last.Tozih AS Tozih_Last, Last.Tarikh_Fa AS Tarikh_Fa_Last,   Last.Sh_Check AS Sh_Check_Last, Last.CheckBank_ID AS CheckBank_ID_Last, Last.Check_Shobe AS Check_Shobe_Last,   Last.Check_Sarresid AS Check_Sarresid_Last, Last.Check_Sarresid_Fa AS Check_Sarresid_Fa_Last, Last.Check_Status AS Check_Status_Last,   Last.Check_ShomareHesab AS Check_ShomareHesab_Last, Last.CheckBarg_ID AS CheckBarg_ID_Last, Last.PardakhtCheck_ID AS PardakhtCheck_ID_Last,   DaryaftPardakht_2.ID, DaryaftPardakht_2.dpType_ID, DaryaftPardakht_2.Tarikh, DaryaftPardakht_2.Moshtari_ID, DaryaftPardakht_2.Mablagh,   DaryaftPardakht_2.Tozih, DaryaftPardakht_2.Tarikh_Fa, DaryaftPardakht_2.Sh_Check, DaryaftPardakht_2.CheckBank_ID, DaryaftPardakht_2.Check_Shobe,   DaryaftPardakht_2.Check_Sarresid, DaryaftPardakht_2.Check_Sarresid_Fa, DaryaftPardakht_2.Check_Status, DaryaftPardakht_2.Check_ShomareHesab,   DaryaftPardakht_2.CheckBarg_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name AS Bank_Name, CheckStatus_Name.Name AS Stat_Name,   Moshtari_1.Name + ' ' + Moshtari_1.Family AS Last_Moshtari_Name, Bank_1.Name + '-' + Bank_Hesab.Shobe AS Last_BankHesab,case when last.check_status in(2,4) then Bank_1.Name + '-' + Bank_Hesab.Shobe when last.check_status in(1,5) then Moshtari_1.Name + ' ' + Moshtari_1.Family END AS Last_Name   FROM         Bank_Hesab RIGHT OUTER JOIN   Bank AS Bank_1 ON Bank_Hesab.Bank_ID = Bank_1.ID RIGHT OUTER JOIN  (SELECT     DaryaftPardakht_1.ID, DaryaftPardakht_1.dpType_ID, DaryaftPardakht_1.Tarikh, DaryaftPardakht_1.Moshtari_ID, DaryaftPardakht_1.BankHesab_ID,   DaryaftPardakht_1.Mablagh, DaryaftPardakht_1.Tozih, DaryaftPardakht_1.Tarikh_Fa, DaryaftPardakht_1.Sh_Check, DaryaftPardakht_1.CheckBank_ID,  DaryaftPardakht_1.Check_Shobe, DaryaftPardakht_1.Check_Sarresid, DaryaftPardakht_1.Check_Sarresid_Fa, DaryaftPardakht_1.Check_Status,  DaryaftPardakht_1.Check_ShomareHesab, DaryaftPardakht_1.CheckBarg_ID, DaryaftPardakht_1.PardakhtCheck_ID            FROM         (SELECT     MAX(ID) AS ID   FROM DaryaftPardakht   where PardakhtCheck_ID Is Not NULL  GROUP BY PardakhtCheck_ID) AS t INNER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON t.ID = DaryaftPardakht_1.ID) AS Last INNER JOIN   DaryaftPardakht AS DaryaftPardakht_2 ON Last.PardakhtCheck_ID = DaryaftPardakht_2.ID INNER JOIN   Moshtari ON DaryaftPardakht_2.Moshtari_ID = Moshtari.ID INNER JOIN    Bank ON DaryaftPardakht_2.CheckBank_ID = Bank.ID INNER JOIN    CheckStatus_Name ON DaryaftPardakht_2.Check_Status = CheckStatus_Name.ID ON Bank_Hesab.ID = Last.BankHesab_ID LEFT OUTER JOIN    Moshtari AS Moshtari_1 ON Last.Moshtari_ID = Moshtari_1.ID    where last.moshtari_id = ";
			string[] arg_6D_0 = array;
			int arg_6D_1 = 3;
			int? moshtari_ID2 = this.Moshtari_ID;
			arg_6D_0[arg_6D_1] = (moshtari_ID2.HasValue ? Conversions.ToString(moshtari_ID2.GetValueOrDefault()) : null);
			array[4] = " Or DaryaftPardakht_2.Moshtari_ID = ";
			string[] arg_9C_0 = array;
			int arg_9C_1 = 5;
			int? moshtari_ID3 = this.Moshtari_ID;
			arg_9C_0[arg_9C_1] = (moshtari_ID3.HasValue ? Conversions.ToString(moshtari_ID3.GetValueOrDefault()) : null);
			array[6] = "union all   SELECT     NULL AS ID_Last, NULL AS dpType_ID_Last, NULL AS Tarikh_Last, NULL AS Moshtari_ID_Last, NULL AS BankHesab_ID_Last, NULL AS Mablagh_Last, NULL    AS Tozih_Last, DaryaftPardakht.Tarikh_Fa AS Tarikh_Fa_Last, NULL AS Sh_Check_Last, NULL AS CheckBank_ID_Last, NULL AS Check_Shobe_Last, NULL AS Check_Sarresid_Last, NULL    AS Check_Sarresid_Fa_Last, NULL AS Check_Status_Last, NULL AS Check_ShomareHesab_Last, NULL AS CheckBarg_ID_Last, NULL AS PardakhtCheck_ID_Last,   DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,   DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, Bank_Hesab.Shobe AS Check_Shobe, DaryaftPardakht.Check_Sarresid,   DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, Bank_Hesab.Sh_Hesab as Check_ShomareHesab, DaryaftPardakht.CheckBarg_ID,   'دسته چک' AS Moshtari_Name, Bank.Name + ' ' + Bank_Hesab.Shobe AS Bank_Name, CheckStatus_Name.Name AS Stat_Name, NULL   AS Last_Moshtari_Name, NULL AS Last_BankHesab, CheckStatus_Name.Name AS LastName   FROM         DaryaftPardakht INNER JOIN                         Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN                          CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID INNER JOIN                         DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN                         DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN                          Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN                         Bank ON Bank_Hesab.Bank_ID = Bank.ID    WHERE     (DaryaftPardakht.dpType_ID = 11) AND (DaryaftPardakht.Check_Status = 5) AND (DaryaftPardakht.Moshtari_ID = ";
			string[] arg_CB_0 = array;
			int arg_CB_1 = 7;
			int? moshtari_ID4 = this.Moshtari_ID;
			arg_CB_0[arg_CB_1] = (moshtari_ID4.HasValue ? Conversions.ToString(moshtari_ID4.GetValueOrDefault()) : null);
			array[8] = ")           union all   SELECT     NULL AS ID_Last, NULL AS dpType_ID_Last, NULL AS Tarikh_Last, NULL AS Moshtari_ID_Last, NULL AS BankHesab_ID_Last, NULL AS Mablagh_Last, NULL                          AS Tozih_Last, DaryaftPardakht.Tarikh_Fa AS Tarikh_Fa_Last, NULL AS Sh_Check_Last, NULL AS CheckBank_ID_Last, NULL AS Check_Shobe_Last, NULL                          AS Check_Sarresid_Last, NULL AS Check_Sarresid_Fa_Last, NULL AS Check_Status_Last, NULL AS Check_ShomareHesab_Last, NULL AS CheckBarg_ID_Last, NULL                          AS PardakhtCheck_ID_Last, DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh,                          DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, Bank_Hesab.Shobe AS Check_Shobe,                          DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, Bank_Hesab.Sh_Hesab AS Check_ShomareHesab,                          DaryaftPardakht.CheckBarg_ID, 'دسته چک' AS Moshtari_Name, Bank.Name + ' ' + Bank_Hesab.Shobe AS Bank_Name,                          CheckStatus_Name.Name AS Stat_Name, NULL AS Last_Moshtari_Name, NULL AS Last_BankHesab, CheckStatus_Name.Name AS LastName    FROM         Moshtari RIGHT OUTER JOIN                          DaryaftPardakht INNER JOIN                          CheckStatus_Name ON DaryaftPardakht.Check_Status = CheckStatus_Name.ID ON Moshtari.ID = DaryaftPardakht.Moshtari_ID LEFT OUTER JOIN                         DasteCheck INNER JOIN                         Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN                         Bank ON Bank_Hesab.Bank_ID = Bank.ID RIGHT OUTER JOIN                          DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID   WHERE     (DaryaftPardakht.dpType_ID = 20) AND (DaryaftPardakht.PardakhtCheck_ID IN                              (SELECT     ID                                 FROM         DaryaftPardakht AS DaryaftPardakht_1                                WHERE     (Moshtari_ID = ";
			string[] arg_FB_0 = array;
			int arg_FB_1 = 9;
			int? moshtari_ID5 = this.Moshtari_ID;
			arg_FB_0[arg_FB_1] = (moshtari_ID5.HasValue ? Conversions.ToString(moshtari_ID5.GetValueOrDefault()) : null);
			array[10] = " AND CheckBarg_ID is not null )))    ORDER BY DaryaftPardakht.Check_Sarresid";
			string command = string.Concat(array);
			DataTable dataTable = Public_Function.FillData(command);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			string text = string.Empty;
			bool flag3;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["dptype_id_last"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id_last"], 22, false);
						if (flag2)
						{
							flag3 = (dataRow["last_bankhesab"] == DBNull.Value);
							if (flag3)
							{
								dictionary.Add(Conversions.ToInteger(dataRow["pardakhtcheck_id_last"]), dataTable.Rows.IndexOf(dataRow));
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["pardakhtcheck_id_last"], ",")));
							}
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
			text = Public_Function.RemoveLast(text);
			flag3 = (text.Length > 0);
			if (flag3)
			{
				DataTable dataTable2 = Public_Function.FillData("SELECT     DaryaftPardakht.PardakhtCheck_ID, Moshtari.Name+' '+ Moshtari.Family as name  FROM         DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE     (DaryaftPardakht.PardakhtCheck_ID In (" + text + ")) AND (DaryaftPardakht.dpType_ID = 12)");
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
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_rpt_checksearch_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0000AEB6 File Offset: 0x000090B6
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData(true, "");
			this.EditBox1.Focus();
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x00128E48 File Offset: 0x00127048
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

		// Token: 0x06002B9B RID: 11163 RVA: 0x00208364 File Offset: 0x00206564
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

		// Token: 0x06002B9C RID: 11164 RVA: 0x0000AED3 File Offset: 0x000090D3
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x002083D4 File Offset: 0x002065D4
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

		// Token: 0x06002B9E RID: 11166 RVA: 0x00208420 File Offset: 0x00206620
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

		// Token: 0x040010ED RID: 4333
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010EF RID: 4335
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010F0 RID: 4336
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010F1 RID: 4337
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040010F2 RID: 4338
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040010F3 RID: 4339
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010F4 RID: 4340
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010F5 RID: 4341
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040010F6 RID: 4342
		[CompilerGenerated]
		private int? _Moshtari_ID;

		// Token: 0x040010F7 RID: 4343
		[CompilerGenerated]
		private string _Moshtari_Name;
	}
}
