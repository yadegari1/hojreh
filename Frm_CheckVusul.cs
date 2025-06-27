using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000E3 RID: 227
	[DesignerGenerated]
	public partial class Frm_CheckVusul : Form
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x000E1810 File Offset: 0x000DFA10
		public Frm_CheckVusul()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_CheckVusul.__ENCAddToList(this);
			this.frm_hesabBanki = new Frm_SelectItem();
			this.frmCheck_Select = new Frm_SelectItem();
			DataTable dataTable = new DataTable();
			this.dt = dataTable;
			dataTable = new DataTable();
			this.dt_dcheck = dataTable;
			this.prevent = false;
			this.notin = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000E18B4 File Offset: 0x000DFAB4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_CheckVusul.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_CheckVusul.__ENCList.Count == Frm_CheckVusul.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_CheckVusul.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_CheckVusul.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_CheckVusul.__ENCList[num] = Frm_CheckVusul.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_CheckVusul.__ENCList.RemoveRange(num, Frm_CheckVusul.__ENCList.Count - num);
						Frm_CheckVusul.__ENCList.Capacity = Frm_CheckVusul.__ENCList.Count;
					}
					Frm_CheckVusul.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x000E1E84 File Offset: 0x000E0084
		// (set) Token: 0x060014F6 RID: 5366 RVA: 0x000E1E9C File Offset: 0x000E009C
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
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyPress -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.ColumnButtonClick -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyPress += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.ColumnButtonClick += value5;
				}
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x000E1F78 File Offset: 0x000E0178
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x00006A09 File Offset: 0x00004C09
		internal virtual CurrencyBox txt_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mablagh = value;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000E1F90 File Offset: 0x000E0190
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x00006A13 File Offset: 0x00004C13
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

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000E1FA8 File Offset: 0x000E01A8
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x00006A1D File Offset: 0x00004C1D
		public DataRow ParentDatarow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParentDatarow;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ParentDatarow = value;
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000E1FC0 File Offset: 0x000E01C0
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x00006A27 File Offset: 0x00004C27
		public long sum_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sum_mablagh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sum_mablagh = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000E1FD8 File Offset: 0x000E01D8
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x00006A31 File Offset: 0x00004C31
		public DataTable dt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt = value;
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000E1FF0 File Offset: 0x000E01F0
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x00006A3B File Offset: 0x00004C3B
		public DataTable dt_dcheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_dcheck;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_dcheck = value;
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000E2008 File Offset: 0x000E0208
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x00006A45 File Offset: 0x00004C45
		public DataTable dt_daryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_daryaft;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_daryaft = value;
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x000E2020 File Offset: 0x000E0220
		// (set) Token: 0x06001506 RID: 5382 RVA: 0x00006A4F File Offset: 0x00004C4F
		public List<listCheckDaryaft> ListDaryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListDaryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ListDaryaft_Identity = value;
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x000E2038 File Offset: 0x000E0238
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x00006A59 File Offset: 0x00004C59
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x000E2050 File Offset: 0x000E0250
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x00006A63 File Offset: 0x00004C63
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x000E2068 File Offset: 0x000E0268
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000E2098 File Offset: 0x000E0298
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			DataTable table = this.ParentDatarow.Table;
			int num = this.ParentDatarow.Table.Rows.IndexOf(this.ParentDatarow);
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_identity=", this.ParentDatarow["Identity"])));
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					int arg_63_0 = 0;
					int num2 = array.Length - 1;
					int num3 = arg_63_0;
					while (true)
					{
						int arg_7B_0 = num3;
						int num4 = num2;
						if (arg_7B_0 > num4)
						{
							break;
						}
						array[num3].Delete();
						num3++;
					}
				}
				table.AcceptChanges();
				try
				{
					IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						num++;
						DataRow dataRow2 = table.NewRow();
						flag = (dataRow["ID"] != DBNull.Value);
						if (flag)
						{
							dataRow2["ID"] = RuntimeHelpers.GetObjectValue(dataRow["ID"]);
						}
						flag = (dataRow["Parent_ID"] != DBNull.Value);
						if (flag)
						{
							dataRow2["Parent_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_ID"]);
						}
						dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
						dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
						dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
						dataRow2["is_child"] = true;
						dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["identity"]);
						flag = (dataRow["tarikh"] != DBNull.Value);
						if (flag)
						{
							dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh"]);
						}
						flag = (dataRow["sanadbed_id"] != DBNull.Value);
						if (flag)
						{
							dataRow2["sanadbed_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbed_id"]);
						}
						flag = (dataRow["sanadbes_id"] != DBNull.Value);
						if (flag)
						{
							dataRow2["sanadbes_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbes_id"]);
						}
						flag = (dataRow["daryaft_identity"] != DBNull.Value);
						if (flag)
						{
							dataRow2["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow["daryaft_identity"]);
						}
						flag = (dataRow["checkbarg_ID"] != DBNull.Value);
						if (flag)
						{
							dataRow2["checkbarg_ID"] = RuntimeHelpers.GetObjectValue(dataRow["checkbarg_ID"]);
						}
						flag = (dataRow["moshtari_id"] != DBNull.Value);
						if (flag)
						{
							dataRow2["moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]);
						}
						flag = (dataRow["bankhesab_id"] != DBNull.Value);
						if (flag)
						{
							dataRow2["bankhesab_id"] = RuntimeHelpers.GetObjectValue(dataRow["bankhesab_id"]);
						}
						dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
						dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
						dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						dataRow2["dp_Name"] = "اعلام وصول چک";
						dataRow2["dptype_id"] = 20;
						dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						table.Rows.InsertAt(dataRow2, num);
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
				this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x000E2578 File Offset: 0x000E0778
		private void GetNotin()
		{
			this.notin = string.Empty;
			DataTable table = this.ParentDatarow.Table;
			bool flag2;
			try
			{
				IEnumerator enumerator = table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
					if (flag)
					{
						flag2 = (dataRow["pardakhtcheck_id"] != DBNull.Value);
						if (flag2)
						{
							this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
						}
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
			flag2 = (Operators.CompareString(this.notin, string.Empty, false) != 0);
			if (flag2)
			{
				this.notin = Public_Function.RemoveLast(this.notin);
				this.notin = " and DaryaftPardakht.ID not in (" + this.notin + ")";
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000E26D0 File Offset: 0x000E08D0
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm_hesabBanki.items = itemCollection;
			itemCollection2.Add(new Column("Sh_Check", "شماره چک ", 15));
			itemCollection2.Add(new Column("Mablagh", "مبلغ", 15));
			itemCollection2.Add(new Column("Bank_Name", "بانک", 10));
			itemCollection2.Add(new Column("Check_Shobe", "شعبه", 15));
			itemCollection2.Add(new Column("Check_ShomareHesab", "شماره حساب", 15));
			itemCollection2.Add(new Column("Moshtari_Name", "دریافت کننده", 20));
			itemCollection2.Add(new Column("Check_Sarresid_Fa", "سررسید", 10));
			this.frmCheck_Select.items = itemCollection2;
			this.GetNotin();
			DataTable table = this.ParentDatarow.Table;
			this.dt = table.Clone();
			this.dt_dcheck = table.Clone();
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_Identity=", this.ParentDatarow["identity"])));
			DataRow[] array2 = array;
			checked
			{
				bool flag;
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false);
					if (flag)
					{
						this.dt.ImportRow(dataRow);
					}
				}
				flag = (this.dt.Rows.Count > 0);
				if (flag)
				{
					this.dt.TableName = "data";
					this.GridEX1.DataSource = this.dt;
				}
				else
				{
					this.GridEX1.DataSource = this.LoadData();
				}
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
				flag = (this.GridEX1.RowCount == 0);
				if (flag)
				{
					this.Check_Select();
				}
				this.GetSum();
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x000E2914 File Offset: 0x000E0B14
		private object Contains_In_List(int Operation_ID, int PardakhtCheck_ID)
		{
			object result;
			try
			{
				List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
				while (enumerator.MoveNext())
				{
					listCheckDaryaft current = enumerator.Current;
					bool flag = current.Operation_id == Operation_ID && current.PardakhtCheck_ID == PardakhtCheck_ID;
					if (flag)
					{
						result = true;
						return result;
					}
				}
			}
			finally
			{
				List<listCheckDaryaft>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			result = false;
			return result;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x000E2998 File Offset: 0x000E0B98
		private void Sync_Check_Info(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false) && dataRow["id"] != DBNull.Value && dataRow.RowState == DataRowState.Added;
					if (flag)
					{
						DataRow[] array = dt.Select(Conversions.ToString(Operators.ConcatenateObject("ID=", dataRow["ID"])));
						flag = (array.Length > 0);
						if (flag)
						{
							array[0]["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh"]);
							array[0]["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_ID"]);
							array[0]["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
							array[0]["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
							array[0]["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Tarikh_Fa"]);
							array[0]["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
							array[0]["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
							array[0]["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
							array[0]["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
							array[0]["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_Name"]);
							array[0]["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						}
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

		// Token: 0x06001512 RID: 5394 RVA: 0x000E2BD0 File Offset: 0x000E0DD0
		private string NotinTarikh()
		{
			return " AND DaryaftPardakht.ID  IN( SELECT     dp_asli.ID  FROM         DaryaftPardakht INNER JOIN DaryaftPardakht AS dp_asli ON DaryaftPardakht.PardakhtCheck_ID = dp_asli.ID WHERE     DaryaftPardakht.dpType_ID = 18 and dp_asli.check_status=2 and DaryaftPardakht.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + ")";
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000E2C04 File Offset: 0x000E0E04
		public void Check_Select()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			string text2 = string.Concat(new string[]
			{
				"select * from (SELECT     DaryaftPardakht.ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS Bank_Name, DaryaftPardakht.CheckBarg_ID   FROM         DaryaftPardakht Left Outer JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status in(2) ",
				text,
				this.notin,
				this.NotinTarikh(),
				Environment.NewLine
			});
			text2 = string.Concat(new string[]
			{
				text2,
				"union all SELECT     DaryaftPardakht.ID, DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, CAST(DasteCheckBarg.ShomareBarg AS nvarchar(50)) AS Sh_Check, DasteCheck.BankHesab_ID AS CheckBank_ID,  Bank_Hesab.Shobe AS Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa,case dptype_id when 11 then Moshtari.Name + ' ' + Moshtari.Family when -98 then Moshtari.Name + ' ' + Moshtari.Family when 15 then hazine.name end AS Moshtari_Name,isnull(DaryaftPardakht.Check_ShomareHesab,' ') as Check_ShomareHesab , Bank.Name AS Bank_Name,  DaryaftPardakht.CheckBarg_ID FROM         DaryaftPardakht INNER JOIN  DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN  Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID LEFT OUTER JOIN  Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID   WHERE     (DaryaftPardakht.dpType_ID IN (15,11,-98)) AND (DaryaftPardakht.Check_Status IN (5))",
				text,
				this.notin,
				")t order by check_sarresid_fa"
			});
			DataTable dataTable2 = Public_Function.FillData(text2);
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			bool flag2;
			try
			{
				IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = (dataRow2["moshtari_name"] == DBNull.Value);
					if (flag)
					{
						flag2 = (dataRow2["Tozih"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow2["tozih"]);
						}
					}
					flag2 = (dataRow2["bank_Name"] == DBNull.Value);
					if (flag2)
					{
						dataRow2["bank_Name"] = string.Empty;
					}
					flag2 = (dataRow2["check_shobe"] == DBNull.Value);
					if (flag2)
					{
						dataRow2["check_shobe"] = string.Empty;
					}
					flag2 = (dataRow2["Check_ShomareHesab"] == DBNull.Value);
					if (flag2)
					{
						dataRow2["Check_ShomareHesab"] = string.Empty;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag2 = (enumerator2 is IDisposable);
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			try
			{
				IEnumerator enumerator3 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					flag2 = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 18, false);
					if (flag2)
					{
						flag = (dataRow3["id"] != DBNull.Value);
						if (!flag)
						{
							flag2 = (dataRow3["daryaft_identity"] != DBNull.Value);
							if (flag2)
							{
								flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
								{
									Operation_id = 20,
									Daryaft_Identity = Conversions.ToInteger(dataRow3["daryaft_identity"])
								});
								if (flag)
								{
									continue;
								}
								flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
								{
									Operation_id = 22,
									Daryaft_Identity = Conversions.ToInteger(dataRow3["daryaft_identity"])
								});
								if (flag2)
								{
									continue;
								}
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(this.Contains_In_List(20, Conversions.ToInteger(dataRow3["PardakhtCheck_ID"])), true, false);
								if (flag2)
								{
									continue;
								}
								flag2 = Operators.ConditionalCompareObjectEqual(this.Contains_In_List(22, Conversions.ToInteger(dataRow3["PardakhtCheck_ID"])), true, false);
								if (flag2)
								{
									continue;
								}
							}
							DataRow dataRow4 = dataTable2.NewRow();
							dataRow4["ID"] = 0;
							dataRow4["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow3["Tarikh"]);
							dataRow4["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["Moshtari_ID"]);
							dataRow4["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow3["Mablagh"]);
							dataRow4["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow3["Tozih"]);
							dataRow4["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow3["Tarikh_Fa"]);
							dataRow4["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow3["Sh_Check"]);
							dataRow4["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBank_ID"]);
							dataRow4["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow3["Check_Shobe"]);
							dataRow4["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow3["Check_Sarresid_Fa"]);
							dataRow4["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["Moshtari_Name"]);
							dataRow4["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow3["CheckBank_Name"]);
							dataRow4["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow3["daryaft_identity"]);
							dataRow4["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["PardakhtCheck_ID"]);
							dataRow4["checkbarg_ID"] = RuntimeHelpers.GetObjectValue(dataRow3["checkbarg_ID"]);
							dataTable2.Rows.Add(dataRow4);
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				flag2 = (enumerator3 is IDisposable);
				if (flag2)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			this.Sync_Check_Info(dataTable2);
			flag2 = (this.frmCheck_Select.ShowDialog(dataTable2, null, "اعلام وصول چک - انتخاب چک") == DialogResult.OK);
			if (flag2)
			{
				flag = Operators.ConditionalCompareObjectGreater(this.frmCheck_Select.SelectedRow["check_Sarresid_Fa"], Public_Function.MiladiToShamsi(DateAndTime.Now), false);
				if (flag)
				{
					Public_Function.ShowMessage("امکان وصول قبل از سررسید چک وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				}
				else
				{
					this.prevent = true;
					flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null);
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
						this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
						this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
						this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
						this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
						this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
						this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["PardakhtCheck_ID"]);
						this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
						this.GridEX1.GetRow().Cells["checkbarg_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["checkbarg_ID"]);
						flag2 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
						if (flag2)
						{
							flag = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
							if (flag)
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 20,
									Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
								});
							}
							else
							{
								this.ListDaryaft_Identity.Add(new listCheckDaryaft
								{
									Operation_id = 20,
									PardakhtCheck_ID = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["PardakhtCheck_ID"])
								});
							}
						}
						this.GridEX1.UpdateData();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000E3620 File Offset: 0x000E1820
		private void Shobe_Select()
		{
			DataTable dt = Public_Function.FillData("select distinct Check_shobe as name  from daryaftpardakht where Check_Shobe is not null");
			bool flag = this.frm_hesabBanki.ShowDialog(dt, null, "انتخاب شعبه") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm_hesabBanki.SelectedRow["Name"]);
						GridEX gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x000E36DC File Offset: 0x000E18DC
		private void GetSum()
		{
			long num = 0L;
			int arg_13_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_13_0;
				while (true)
				{
					int arg_81_0 = num3;
					int num4 = num2;
					if (arg_81_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX1.GetRow(num3).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells["Mablagh"].Value));
					}
					num3++;
				}
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000E3770 File Offset: 0x000E1970
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 20,
				Daryaft_Identity = value
			});
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x000E37A4 File Offset: 0x000E19A4
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = this.prevent;
			if (flag)
			{
				this.prevent = false;
			}
			else
			{
				flag = (Operators.CompareString(e.Column.Key.ToLower(), "sh_check", false) == 0);
				if (flag)
				{
					this.GetSum();
				}
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x000E37F4 File Offset: 0x000E19F4
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			if (flag)
			{
				string text = Conversions.ToString(((DataRowView)row.DataRow)["PardakhtCheck_ID"]);
				string text2 = string.Empty;
				long value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
				DataRow dataRow = Public_Function.FillDataRow("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + Conversions.ToString(value) + ")");
				text2 = text2 + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + Conversions.ToString(value) + ");";
				text2 = text2 + "delete from daryaftpardakht where id in(" + Conversions.ToString(value) + ");";
				flag = (dataRow["sanadbed_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbed_id"]), ");")));
				}
				flag = (dataRow["sanadbes_id"] != DBNull.Value);
				if (flag)
				{
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbes_id"]), ");")));
				}
				Public_Function.ExecuteNonQuery(text2);
				text2 = string.Concat(new string[]
				{
					"   declare @st int;    declare @barg_id int;    select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=",
					text,
					" order by id desc;  if @st is null begin   select top 1  @barg_id=checkbarg_id from daryaftpardakht where id=",
					text,
					" ;   if @barg_id is null  set @st=1;    else  set @st=5;   End  update daryaftpardakht set check_status=@st where id=",
					text,
					";"
				});
				Public_Function.ExecuteNonQuery(text2);
			}
			flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
			if (flag)
			{
				bool flag2 = this.GridEX1.GetRow().Cells["daryaft_identity"].Value != DBNull.Value;
				if (flag2)
				{
					this.Delete_Listdaryaft(Conversions.ToInteger(this.GridEX1.GetRow().Cells["daryaft_identity"].Value));
				}
				this.GridEX1.CurrentRow.Delete();
				((DataTable)this.GridEX1.DataSource).AcceptChanges();
				this.GetSum();
				this.GetNotin();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
				this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
				flag2 = (this.ParentDatarow["ID"] != DBNull.Value);
				if (flag2)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("update daryaftpardakht set mablagh=" + Conversions.ToString(this.sum_mablagh) + " where id=", this.ParentDatarow["ID"])
					}, null, null, null, true);
				}
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x000E3B38 File Offset: 0x000E1D38
		private void GetChackeUsageInPardakhtForPardakht(GridEXRow row, DataTable dt2)
		{
			long num = Conversions.ToLong(((DataRowView)row.DataRow)["Identity"]);
			int num2 = this.Pardakht_Table.Rows.IndexOf(this.ParentDatarow);
			bool flag = row.Cells["pardakhtcheck_id"].Value != DBNull.Value;
			bool flag2;
			DataRow[] array;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectNotEqual(row.Cells["pardakhtcheck_id"].Value, 0, false);
				if (flag2)
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", row.Cells["pardakhtcheck_id"].Value), " and dptype_id<>20  AND ID IS NULL")));
				}
				else
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", row.Cells["daryaft_identity"].Value), " and dptype_id<>20  AND ID IS NULL")));
				}
			}
			flag2 = (array != null);
			checked
			{
				if (flag2)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						flag = (this.Pardakht_Table.Rows.IndexOf(dataRow) > num2);
						if (flag)
						{
							DataRow dataRow2 = dt2.NewRow();
							dataRow2["sh_check"] = RuntimeHelpers.GetObjectValue(dataRow["sh_Check"]);
							dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
							dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh_Fa"]);
							dataRow2["opr_name"] = RuntimeHelpers.GetObjectValue(dataRow["dp_name"]);
							dataRow2["Pardakht_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
							dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_identity"]);
							dt2.Rows.Add(dataRow2);
						}
					}
				}
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000E3D60 File Offset: 0x000E1F60
		private void GetCheckUsagePardakht(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = ((DataRowView)row.DataRow)["pardakhtcheck_id"] != DBNull.Value;
			if (flag)
			{
				text = Conversions.ToString(((DataRowView)row.DataRow)["pardakhtcheck_id"]);
			}
			else
			{
				text = "-1";
			}
			string text3 = string.Empty;
			flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
			if (flag)
			{
				text3 = Conversions.ToString(Operators.ConcatenateObject(" AND DaryaftPardakht.ID>", ((DataRowView)row.DataRow)["ID"]));
				text2 = Conversions.ToString(((DataRowView)row.DataRow)["ID"]);
			}
			else
			{
				text2 = "-1";
			}
			dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Sh_Check, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.pardakhtcheck_id in(",
				text,
				") AND DaryaftPardakht.ID Not IN(",
				text2,
				")",
				text3
			}));
			this.GetChackeUsageInPardakhtForPardakht(row, dataTable);
			flag = (Operators.CompareString(text2, "-1", false) != 0);
			if (flag)
			{
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					new Frm_DeleteDaryaftPardakht
					{
						ListDaryaft_Identity = this.ListDaryaft_Identity,
						dt_opr = dataTable
					}.ShowDialog();
				}
			}
			else
			{
				bool flag2 = Public_Function.ShowMessage("آیا مایل به حذف ردیف مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
				if (flag2)
				{
					this.DeletePardakhtRedif(row);
				}
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x000E3F08 File Offset: 0x000E2108
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				this.Check_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
				if (flag)
				{
					bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
					if (flag2)
					{
						this.GetCheckUsagePardakht(this.GridEX1.CurrentRow);
					}
					flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
					if (flag2)
					{
						this.GridEX1.CancelCurrentEdit();
						this.GetSum();
					}
				}
			}
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x000D9734 File Offset: 0x000D7934
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (hasValue)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x000E3FD4 File Offset: 0x000E21D4
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_mablagh;
				flag = (e.Value != null);
				if (flag)
				{
					this.txt_mablagh.Text = e.Value.ToString();
				}
				else
				{
					this.txt_mablagh.Text = string.Empty;
				}
				this.txt_mablagh.SelectAll();
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x000E405C File Offset: 0x000E225C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["CheckBank_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Up:
						flag2 = (this.GridEX1.Row > 0);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row--;
							e.SuppressKeyPress = true;
							return;
						}
						this.GridEX1.MoveToNewRecord();
						break;
					case Keys.Down:
						flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
						if (flag2)
						{
							GridEX gridEX = this.GridEX1;
							gridEX.Row++;
							e.SuppressKeyPress = true;
							return;
						}
						break;
					}
					flag2 = (e.KeyCode == Keys.Return);
					bool flag3;
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["sh_check"].Position);
						if (flag)
						{
							flag3 = (this.GridEX1.EditTextBox == null);
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Check_Select();
							}
						}
					}
					flag3 = (this.GridEX1.Col == 0);
					if (flag3)
					{
						e.SuppressKeyPress = true;
					}
				}
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000E42C8 File Offset: 0x000E24C8
		private void MoveToNewRecord()
		{
			checked
			{
				bool flag = this.GridEX1.Row < this.GridEX1.RowCount - 1;
				if (flag)
				{
					this.GridEX1.Col = 0;
					GridEX gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.Focus();
				}
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000E4328 File Offset: 0x000E2528
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position;
			if (!flag)
			{
				flag = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
				if (flag)
				{
					e.Handled = true;
				}
			}
		}

		// Token: 0x0400081F RID: 2079
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000821 RID: 2081
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000822 RID: 2082
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000823 RID: 2083
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000824 RID: 2084
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x04000825 RID: 2085
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x04000826 RID: 2086
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x04000827 RID: 2087
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x04000828 RID: 2088
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000829 RID: 2089
		[CompilerGenerated]
		private DataTable _dt_dcheck;

		// Token: 0x0400082A RID: 2090
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x0400082B RID: 2091
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x0400082C RID: 2092
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x0400082D RID: 2093
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x0400082E RID: 2094
		private bool prevent;

		// Token: 0x0400082F RID: 2095
		private string notin;
	}
}
