using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Print;

namespace FruitBox
{
	// Token: 0x020000E2 RID: 226
	[DesignerGenerated]
	public partial class Frm_CheckVariz : Form
	{
		// Token: 0x060014AE RID: 5294 RVA: 0x000DCBA0 File Offset: 0x000DADA0
		public Frm_CheckVariz()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_CheckVariz.__ENCAddToList(this);
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

		// Token: 0x060014AF RID: 5295 RVA: 0x000DCC44 File Offset: 0x000DAE44
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_CheckVariz.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_CheckVariz.__ENCList.Count == Frm_CheckVariz.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_CheckVariz.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_CheckVariz.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_CheckVariz.__ENCList[num] = Frm_CheckVariz.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_CheckVariz.__ENCList.RemoveRange(num, Frm_CheckVariz.__ENCList.Count - num);
						Frm_CheckVariz.__ENCList.Capacity = Frm_CheckVariz.__ENCList.Count;
					}
					Frm_CheckVariz.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x000DD498 File Offset: 0x000DB698
		// (set) Token: 0x060014B3 RID: 5299 RVA: 0x000DD4B0 File Offset: 0x000DB6B0
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.KeyPress -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.KeyPress += value5;
				}
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x000DD58C File Offset: 0x000DB78C
		// (set) Token: 0x060014B5 RID: 5301 RVA: 0x0000698E File Offset: 0x00004B8E
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

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060014B6 RID: 5302 RVA: 0x000DD5A4 File Offset: 0x000DB7A4
		// (set) Token: 0x060014B7 RID: 5303 RVA: 0x00006998 File Offset: 0x00004B98
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

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060014B8 RID: 5304 RVA: 0x000DD5BC File Offset: 0x000DB7BC
		// (set) Token: 0x060014B9 RID: 5305 RVA: 0x000069A2 File Offset: 0x00004BA2
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

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060014BA RID: 5306 RVA: 0x000DD5D4 File Offset: 0x000DB7D4
		// (set) Token: 0x060014BB RID: 5307 RVA: 0x000DD5EC File Offset: 0x000DB7EC
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.Click -= value2;
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.Click += value2;
				}
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x000DD64C File Offset: 0x000DB84C
		// (set) Token: 0x060014BD RID: 5309 RVA: 0x000DD664 File Offset: 0x000DB864
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

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060014BE RID: 5310 RVA: 0x000DD6C4 File Offset: 0x000DB8C4
		// (set) Token: 0x060014BF RID: 5311 RVA: 0x000DD6DC File Offset: 0x000DB8DC
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060014C0 RID: 5312 RVA: 0x000DD73C File Offset: 0x000DB93C
		// (set) Token: 0x060014C1 RID: 5313 RVA: 0x000DD754 File Offset: 0x000DB954
		internal virtual ButtonItem ButtonItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem4_Click);
				bool flag = this._ButtonItem4 != null;
				if (flag)
				{
					this._ButtonItem4.Click -= value2;
				}
				this._ButtonItem4 = value;
				flag = (this._ButtonItem4 != null);
				if (flag)
				{
					this._ButtonItem4.Click += value2;
				}
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x000DD7B4 File Offset: 0x000DB9B4
		// (set) Token: 0x060014C3 RID: 5315 RVA: 0x000069AC File Offset: 0x00004BAC
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

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060014C4 RID: 5316 RVA: 0x000DD7CC File Offset: 0x000DB9CC
		// (set) Token: 0x060014C5 RID: 5317 RVA: 0x000069B6 File Offset: 0x00004BB6
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

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x000DD7E4 File Offset: 0x000DB9E4
		// (set) Token: 0x060014C7 RID: 5319 RVA: 0x000069C0 File Offset: 0x00004BC0
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

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x000DD7FC File Offset: 0x000DB9FC
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x000069CA File Offset: 0x00004BCA
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

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x000DD814 File Offset: 0x000DBA14
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x000069D4 File Offset: 0x00004BD4
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

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x000DD82C File Offset: 0x000DBA2C
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x000069DE File Offset: 0x00004BDE
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

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x000DD844 File Offset: 0x000DBA44
		// (set) Token: 0x060014CF RID: 5327 RVA: 0x000069E8 File Offset: 0x00004BE8
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

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060014D0 RID: 5328 RVA: 0x000DD85C File Offset: 0x000DBA5C
		// (set) Token: 0x060014D1 RID: 5329 RVA: 0x000069F2 File Offset: 0x00004BF2
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

		// Token: 0x060014D2 RID: 5330 RVA: 0x000DD874 File Offset: 0x000DBA74
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000DD8A4 File Offset: 0x000DBAA4
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			object expr_11 = this.ParentDatarow["Moshtari_ID"];
			int? num2;
			int? num = (expr_11 != null) ? ((int?)expr_11) : num2;
			string value = Conversions.ToString(this.ParentDatarow["Moshtari_Name"]);
			DataTable table = this.ParentDatarow.Table;
			int num3 = this.ParentDatarow.Table.Rows.IndexOf(this.ParentDatarow);
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_identity=", this.ParentDatarow["Identity"])));
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					int arg_9E_0 = 0;
					int num4 = array.Length - 1;
					int num5 = arg_9E_0;
					while (true)
					{
						int arg_E5_0 = num5;
						int num6 = num4;
						if (arg_E5_0 > num6)
						{
							break;
						}
						bool flag2 = Operators.ConditionalCompareObjectEqual(array[num5]["dptype_id"], 10, false);
						if (flag2)
						{
							num3++;
						}
						else
						{
							array[num5].Delete();
						}
						num5++;
					}
				}
				table.AcceptChanges();
				try
				{
					IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						num3++;
						DataRow dataRow2 = table.NewRow();
						bool flag2 = num.HasValue;
						if (flag2)
						{
							dataRow2["Moshtari_Name"] = value;
							dataRow2["Moshtari_ID"] = num;
						}
						flag2 = (dataRow["ID"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["ID"] = RuntimeHelpers.GetObjectValue(dataRow["ID"]);
						}
						flag2 = (dataRow["Parent_ID"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["Parent_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_ID"]);
						}
						dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
						dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
						dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
						dataRow2["is_child"] = true;
						dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["identity"]);
						flag2 = (dataRow["tarikh"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh"]);
						}
						flag2 = (dataRow["sanadbed_id"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["sanadbed_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbed_id"]);
						}
						flag2 = (dataRow["sanadbes_id"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["sanadbes_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbes_id"]);
						}
						flag2 = (dataRow["daryaft_identity"] != DBNull.Value);
						if (flag2)
						{
							dataRow2["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow["daryaft_identity"]);
						}
						dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
						dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
						dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						dataRow2["dp_Name"] = "واگذاری چک به بانک";
						dataRow2["dptype_id"] = 18;
						dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						table.Rows.InsertAt(dataRow2, num3);
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
				this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
			}
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x000DDD50 File Offset: 0x000DBF50
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
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false))
					{
						goto IL_86;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false))
					{
						goto IL_86;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false))
					{
						goto IL_A5;
					}
					bool arg_A7_0 = false;
					IL_A6:
					bool flag = arg_A7_0;
					if (flag)
					{
						flag2 = (dataRow["PardakhtCheck_ID"] != DBNull.Value);
						if (flag2)
						{
							this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
						}
					}
					continue;
					IL_A5:
					arg_A7_0 = true;
					goto IL_A6;
					IL_86:
					goto IL_A5;
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

		// Token: 0x060014D6 RID: 5334 RVA: 0x000DDEE0 File Offset: 0x000DC0E0
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
			itemCollection2.Add(new Column("Moshtari_Name", "پرداخت کننده", 20));
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
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 18, false);
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

		// Token: 0x060014D7 RID: 5335 RVA: 0x000DE124 File Offset: 0x000DC324
		public void Check_Select_ByNum()
		{
			bool flag = this.prevent;
			if (flag)
			{
				this.prevent = false;
			}
			else
			{
				string text = string.Empty;
				flag = (this.GridEX1.EditTextBox == null);
				bool flag2;
				if (flag)
				{
					flag2 = (this.GridEX1.GetRow().Cells["sh_check"].Value == DBNull.Value);
					if (flag2)
					{
						return;
					}
					text = Conversions.ToString(this.GridEX1.GetRow().Cells["sh_check"].Value);
				}
				else
				{
					text = this.GridEX1.EditTextBox.Text;
				}
				flag2 = (text == null);
				if (!flag2)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					string text2 = string.Empty;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
					try
					{
						IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 26, false);
							if (flag2)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dataRow2["PardakhtCheck_ID"], ",")));
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
					text2 = Public_Function.RemoveLast(text2);
					flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
					if (flag2)
					{
						text2 = " AND DaryaftPardakht.ID NOT IN(" + text2 + ")";
					}
					this.GridEX1.Col = 0;
					this.GridEX1.GetRow().BeginEdit();
					this.GridEX1.EditMode = EditMode.EditOn;
					DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
					{
						"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe,DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht Left Outer JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=",
						Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
						text2,
						this.notin,
						" AND DaryaftPardakht.Sh_Check='",
						text,
						"'"
					}));
					dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
					try
					{
						IEnumerator enumerator3 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataRow dataRow3 = (DataRow)enumerator3.Current;
							flag2 = (dataRow3["id"] != DBNull.Value);
							if (!flag2)
							{
								flag2 = (Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow3["dptype_ID"], 26, false));
								if (flag2)
								{
									flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
									{
										Operation_id = 12,
										Daryaft_Identity = Conversions.ToInteger(dataRow3["identity"])
									});
									if (!flag)
									{
										flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 18,
											Daryaft_Identity = Conversions.ToInteger(dataRow3["identity"])
										});
										if (!flag2)
										{
											flag2 = (dataRow3["PardakhtCheck_ID"] != DBNull.Value);
											if (flag2)
											{
												flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
												{
													Operation_id = 26,
													PardakhtCheck_ID = Conversions.ToInteger(dataRow3["PardakhtCheck_ID"])
												});
												if (flag)
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
											dataRow4["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow3["identity"]);
											dataRow4["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow3["check_shomarehesab"]);
											dataTable2.Rows.Add(dataRow4);
										}
									}
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
					flag2 = (dataTable2.Rows.Count == 0);
					if (flag2)
					{
						this.prevent = true;
						this.GridEX1.CancelCurrentEdit();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
					else
					{
						flag2 = (dataTable2.Rows.Count == 1);
						if (flag2)
						{
							this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Mablagh"]);
							this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CheckBank_ID"]);
							this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Bank_Name"]);
							this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Sarresid_Fa"]);
							this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Shobe"]);
							this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["ID"]);
							this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["daryaft_identity"]);
							this.GridEX1.GetRow().Cells["Check_ShomareHesab"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_ShomareHesab"]);
							flag2 = Operators.ConditionalCompareObjectEqual(dataTable2.Rows[0]["ID"], 0, false);
							if (flag2)
							{
								flag = (dataTable2.Rows[0]["daryaft_identity"] != DBNull.Value);
								if (flag)
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 18,
										Daryaft_Identity = Conversions.ToInteger(dataTable2.Rows[0]["daryaft_identity"])
									});
								}
								else
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 18,
										PardakhtCheck_ID = Conversions.ToInteger(dataTable2.Rows[0]["PardakhtCheck_ID"])
									});
								}
							}
							this.prevent = true;
							this.GridEX1.UpdateData();
							this.GridEX1.MoveToNewRecord();
							this.GridEX1.Col = 0;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
						else
						{
							flag2 = (dataTable2.Rows.Count > 1);
							if (flag2)
							{
								flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "واگذاری چک به بانک - انتخاب چک") == DialogResult.OK);
								if (flag)
								{
									bool flag3 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null;
									if (flag3)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
										this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
										this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
										this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
										this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
										this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
										this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
										this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
										this.GridEX1.GetRow().Cells["Check_ShomareHesab"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_ShomareHesab"]);
										flag3 = Operators.ConditionalCompareObjectEqual(dataTable2.Rows[0]["ID"], 0, false);
										if (flag3)
										{
											flag2 = (dataTable2.Rows[0]["daryaft_identity"] != DBNull.Value);
											if (flag2)
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 18,
													Daryaft_Identity = Conversions.ToInteger(dataTable2.Rows[0]["daryaft_identity"])
												});
											}
											else
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 18,
													PardakhtCheck_ID = Conversions.ToInteger(dataTable2.Rows[0]["PardakhtCheck_ID"])
												});
											}
										}
										this.prevent = true;
										this.GridEX1.UpdateData();
										this.GridEX1.MoveToNewRecord();
										this.GridEX1.Col = 0;
										this.GridEX1.EditMode = EditMode.EditOn;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x000DEE78 File Offset: 0x000DD078
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

		// Token: 0x060014D9 RID: 5337 RVA: 0x000DEEFC File Offset: 0x000DD0FC
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

		// Token: 0x060014DA RID: 5338 RVA: 0x000DF134 File Offset: 0x000DD334
		private string NotinTarikh()
		{
			return " AND DaryaftPardakht.ID  IN( SELECT     dp_asli.ID  FROM         DaryaftPardakht INNER JOIN DaryaftPardakht AS dp_asli ON DaryaftPardakht.PardakhtCheck_ID = dp_asli.ID WHERE     DaryaftPardakht.dpType_ID = 18 and dp_asli.check_status=2 and DaryaftPardakht.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + ")";
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x000DF168 File Offset: 0x000DD368
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
			try
			{
				IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 26, false);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow2["PardakhtCheck_ID"], ",")));
					}
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
			text = Public_Function.RemoveLast(text);
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				text = " AND DaryaftPardakht.ID NOT IN(" + text + ")";
			}
			DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT   DaryaftPardakht.dptype_id,DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe,DaryaftPardakht.Check_ShomareHesab, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_shomareHesab,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht Left Outer JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)),
				text,
				this.notin,
				" order by check_sarresid_Fa"
			}));
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			try
			{
				IEnumerator enumerator3 = dataTable2.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow3["dptype_id"], -99, false);
					if (flag)
					{
						dataRow3["tarikh_fa"] = "اول دوره";
					}
					flag = (dataRow3["Bank_name"] == DBNull.Value);
					if (flag)
					{
						dataRow3["bank_Name"] = string.Empty;
					}
					flag = (dataRow3["Check_Shobe"] == DBNull.Value);
					if (flag)
					{
						dataRow3["Check_Shobe"] = string.Empty;
					}
					flag = (dataRow3["Check_ShomareHesab"] == DBNull.Value);
					if (flag)
					{
						dataRow3["Check_ShomareHesab"] = string.Empty;
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				flag = (enumerator3 is IDisposable);
				if (flag)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			bool flag2;
			try
			{
				IEnumerator enumerator4 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator4.Current;
					flag = (Operators.ConditionalCompareObjectEqual(dataRow4["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow4["dptype_ID"], 26, false));
					if (flag)
					{
						flag2 = (dataRow4["id"] != DBNull.Value);
						if (!flag2)
						{
							flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
							{
								Operation_id = 12,
								Daryaft_Identity = Conversions.ToInteger(dataRow4["identity"])
							});
							if (!flag2)
							{
								flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
								{
									Operation_id = 18,
									Daryaft_Identity = Conversions.ToInteger(dataRow4["identity"])
								});
								if (!flag2)
								{
									flag2 = (dataRow4["PardakhtCheck_ID"] != DBNull.Value);
									if (flag2)
									{
										flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 26,
											PardakhtCheck_ID = Conversions.ToInteger(dataRow4["PardakhtCheck_ID"])
										});
										if (flag)
										{
											continue;
										}
									}
									DataRow dataRow5 = dataTable2.NewRow();
									dataRow5["ID"] = 0;
									dataRow5["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow4["Tarikh"]);
									dataRow5["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow4["Moshtari_ID"]);
									dataRow5["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow4["Mablagh"]);
									dataRow5["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow4["Tozih"]);
									dataRow5["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow4["Tarikh_Fa"]);
									dataRow5["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow4["Sh_Check"]);
									dataRow5["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow4["CheckBank_ID"]);
									dataRow5["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow4["Check_Shobe"]);
									dataRow5["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow4["Check_Sarresid_Fa"]);
									dataRow5["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow4["Moshtari_Name"]);
									dataRow5["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow4["CheckBank_Name"]);
									dataRow5["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow4["identity"]);
									dataRow5["check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow4["Check_ShomareHesab"]);
									dataTable2.Rows.Add(dataRow5);
								}
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator4;
				flag2 = (enumerator4 is IDisposable);
				if (flag2)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			this.Sync_Check_Info(dataTable2);
			flag2 = (this.frmCheck_Select.ShowDialog(dataTable2, null, "واگذاری چک به بانک - انتخاب چک") == DialogResult.OK);
			if (flag2)
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
					this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
					this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
					this.GridEX1.GetRow().Cells["Check_ShomareHesab"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_ShomareHesab"]);
					flag2 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
					if (flag2)
					{
						flag = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
						if (flag)
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 18,
								Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
							});
						}
						else
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 18,
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

		// Token: 0x060014DC RID: 5340 RVA: 0x000DFB78 File Offset: 0x000DDD78
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

		// Token: 0x060014DD RID: 5341 RVA: 0x000DFC34 File Offset: 0x000DDE34
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

		// Token: 0x060014DE RID: 5342 RVA: 0x000DFCC8 File Offset: 0x000DDEC8
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 18,
				Daryaft_Identity = value
			});
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x000DFCFC File Offset: 0x000DDEFC
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
					this.Check_Select_ByNum();
					this.GetSum();
				}
			}
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x000DFD54 File Offset: 0x000DDF54
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			if (flag)
			{
				string str = Conversions.ToString(((DataRowView)row.DataRow)["PardakhtCheck_ID"]);
				string text = string.Empty;
				long value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
				DataRow dataRow = Public_Function.FillDataRow("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + Conversions.ToString(value) + ")");
				text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + Conversions.ToString(value) + ");";
				text = text + "delete from daryaftpardakht where id in(" + Conversions.ToString(value) + ");";
				flag = (dataRow["sanadbed_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbed_id"]), ");")));
				}
				flag = (dataRow["sanadbes_id"] != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id in(", dataRow["sanadbes_id"]), ");")));
				}
				Public_Function.ExecuteNonQuery(text);
				text = "declare @st int;";
				text = text + "select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=" + str + " order by id desc;";
				text += "if @st is null set @st=1;";
				text = text + "update daryaftpardakht set check_status=@st where id=" + str + ";";
				Public_Function.ExecuteNonQuery(text);
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

		// Token: 0x060014E1 RID: 5345 RVA: 0x000E0088 File Offset: 0x000DE288
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
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", row.Cells["pardakhtcheck_id"].Value), " and dptype_id<>18  AND ID IS NULL")));
				}
				else
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", row.Cells["daryaft_identity"].Value), " and dptype_id<>18  AND ID IS NULL")));
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

		// Token: 0x060014E2 RID: 5346 RVA: 0x000E02B0 File Offset: 0x000DE4B0
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
			flag = (dataTable.Rows.Count > 0);
			if (flag)
			{
				Frm_DeleteDaryaftPardakht frm_DeleteDaryaftPardakht = new Frm_DeleteDaryaftPardakht();
				frm_DeleteDaryaftPardakht.ListDaryaft_Identity = this.ListDaryaft_Identity;
				frm_DeleteDaryaftPardakht.dt_opr = dataTable;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DeleteDaryaftPardakht);
			}
			else
			{
				flag = (Public_Function.ShowMessage("آیا مایل به حذف ردیف مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					this.DeletePardakhtRedif(row);
				}
			}
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x000E0448 File Offset: 0x000DE648
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

		// Token: 0x060014E4 RID: 5348 RVA: 0x000D9734 File Offset: 0x000D7934
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

		// Token: 0x060014E5 RID: 5349 RVA: 0x000E0514 File Offset: 0x000DE714
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

		// Token: 0x060014E6 RID: 5350 RVA: 0x000E059C File Offset: 0x000DE79C
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
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["sh_check"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX1.EditTextBox == null;
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
							}
							flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
							if (flag3)
							{
								this.Check_Select();
							}
							else
							{
								this.Check_Select_ByNum();
							}
						}
					}
				}
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x000E07E8 File Offset: 0x000DE9E8
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

		// Token: 0x060014E8 RID: 5352 RVA: 0x000E0848 File Offset: 0x000DEA48
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

		// Token: 0x060014E9 RID: 5353 RVA: 0x000E08C8 File Offset: 0x000DEAC8
		private void design_print()
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(this.ParentDatarow["moshtari_ID"]);
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataTable dataTable2 = dataTable.Copy();
			dataTable2.Columns["sh_check"].ColumnName = "شماره_چک";
			dataTable2.Columns.Remove("ID");
			dataTable2.Columns.Remove("dptype_id");
			dataTable2.Columns.Remove("Tarikh");
			dataTable2.Columns.Remove("sanadbed_id");
			dataTable2.Columns.Remove("sanadbes_id");
			dataTable2.Columns.Remove("moshtari_id");
			dataTable2.Columns.Remove("sandug_id");
			dataTable2.Columns.Remove("bankhesab_id");
			dataTable2.Columns.Remove("tarikh_fa");
			dataTable2.Columns.Remove("checkbank_id");
			dataTable2.Columns.Remove("Parent_ID");
			dataTable2.Columns.Remove("dp_name");
			dataTable2.Columns.Remove("check_status");
			dataTable2.Columns.Remove("sh_fish");
			dataTable2.Columns.Remove("fishvariz");
			dataTable2.Columns.Remove("fishvariz_fa");
			dataTable2.Columns.Remove("hazine_ID");
			dataTable2.Columns.Remove("Hazine_Name");
			dataTable2.Columns.Remove("pardakhtcheck_ID");
			dataTable2.Columns.Remove("Tozih");
			dataTable2.Columns.Remove("check_sarresid");
			dataTable2.Columns.Remove("moshtari_name");
			dataTable2.Columns.Remove("checkbarg_id");
			dataTable2.Columns.Remove("daryaft_identity");
			dataTable2.Columns.Remove("is_child");
			dataTable2.Columns.Remove("identity");
			dataTable2.Columns.Remove("parent_identity");
			dataTable2.Columns.Remove("moshtari_id2");
			dataTable2.Columns.Remove("moshtari_name2");
			dataTable2.Columns["mablagh"].ColumnName = "مبلغ";
			dataTable2.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			dataTable2.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			dataTable2.Columns.Add(new DataColumn("shobe", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("huruf", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("تلفن", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("آدرس", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			dataTable2.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			try
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator.Current;
					dataRow3["shobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["checkbank_name"], "/"), dataRow3["check_shobe"]);
					dataRow3["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow3["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow3["تلفن"] = dataRow["tel"].ToString();
					dataRow3["آدرس"] = dataRow["address"].ToString();
					dataRow3["شماره_حساب"] = dataRow["sh_hesab"].ToString();
					dataRow3["صاحب_حساب"] = dataRow["sahebhesab"].ToString();
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
			dataTable2.Columns["shobe"].ColumnName = "بانک_چک";
			dataTable2.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			dataTable2.Columns.Remove("checkbank_name");
			dataTable2.Columns.Remove("check_shobe");
			dataTable2.Columns.Remove("bankhesab_name");
			dataTable2.TableName = "data";
			stiReport.RegData(dataTable2);
			StiDataBand stiDataBand = new StiDataBand();
			stiDataBand.DataSourceName = "data";
			stiDataBand.Height = stiReport.Pages[0].Height;
			stiReport.Pages[0].Components.Add(stiDataBand);
			StiOptions.Designer.DontAskSaveReport = true;
			StiOptions.Designer.DontSaveDesignerConfig = true;
			StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
			StiOptions.Designer.AllowSaveStandaloneReport = false;
			StiOptions.Designer.CodeTabVisible = false;
			StiOptions.Designer.HtmlPreviewReportVisible = false;
			stiReport.Design();
			NewLateBinding.LateCall(stiReport, null, "Save", new object[]
			{
				Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")
			}, null, null, null, true);
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0004BE70 File Offset: 0x0004A070
		private DataTable Createparentdt(DataTable data, int bank_ID)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(vagozaricount,5) from bank where id=" + Conversions.ToString(bank_ID)));
			data.Columns.Add("Ch", typeof(bool));
			data.Columns.Add("parent_id", typeof(int));
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(int));
			dataTable.Columns.Add("tarikh", typeof(string));
			dataTable.Columns.Add("cnt", typeof(int));
			dataTable.Columns.Add("تعداد_چک", typeof(string));
			dataTable.Columns.Add("مبلغ_به_حروف", typeof(string));
			dataTable.Columns.Add("جمع_مبلغ", typeof(long));
			dataTable.Columns.Add("تاریخ_امروز", typeof(string));
			dataTable.Columns.Add("شماره_صفحه", typeof(string));
			int num2 = 1;
			checked
			{
				try
				{
					IEnumerator enumerator = data.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow["checkbank_id"], bank_ID, false);
						if (flag)
						{
							dataTable.Rows.Add(new object[]
							{
								num2,
								"",
								1
							});
							dataRow["parent_id"] = num2;
							dataRow["ch"] = true;
							num2++;
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
				int num3 = 0;
				try
				{
					IEnumerator enumerator2 = data.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = Operators.ConditionalCompareObjectLess(dataRow2["تاریخ_چک"], Public_Function.dict["today"], false);
						if (flag)
						{
							bool flag2 = dataRow2["ch"] == DBNull.Value;
							if (flag2)
							{
								dataRow2["parent_id"] = num2;
								dataRow2["ch"] = true;
								num3++;
								flag2 = (num3 == 1);
								if (flag2)
								{
									dataTable.Rows.Add(new object[]
									{
										num2,
										"",
										1
									});
								}
								else
								{
									dataTable.Rows[dataTable.Rows.Count - 1]["cnt"] = num3;
								}
								flag2 = (num3 == num);
								if (flag2)
								{
									num2++;
									num3 = 0;
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag2 = enumerator2 is IDisposable;
					if (flag2)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator3 = data.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						bool flag2 = dataRow3["ch"] == DBNull.Value;
						if (flag2)
						{
							DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow3["تاریخ_چک"]), "'")));
							flag2 = (array.Length > 0);
							if (flag2)
							{
								DataRow[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									DataRow dataRow4 = array2[i];
									bool flag = Operators.ConditionalCompareObjectLessEqual(dataRow4["cnt"], num, false);
									if (flag)
									{
										DataRow dataRow5 = dataRow4;
										DataRow arg_430_0 = dataRow5;
										string columnName = "cnt";
										arg_430_0[columnName] = Operators.AddObject(dataRow5[columnName], 1);
										dataRow3["ch"] = true;
										dataRow3["parent_id"] = RuntimeHelpers.GetObjectValue(dataRow4["ID"]);
										flag2 = Operators.ConditionalCompareObjectEqual(dataRow4["cnt"], num + 1, false);
										if (flag2)
										{
											num2++;
											dataTable.Rows.Add(new object[]
											{
												num2,
												RuntimeHelpers.GetObjectValue(dataRow3["تاریخ_چک"]),
												1
											});
											dataRow3["parent_id"] = num2;
											dataRow3["ch"] = true;
										}
									}
								}
							}
							else
							{
								num2++;
								dataTable.Rows.Add(new object[]
								{
									num2,
									RuntimeHelpers.GetObjectValue(dataRow3["تاریخ_چک"]),
									1
								});
								dataRow3["parent_id"] = num2;
								dataRow3["ch"] = true;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag2 = enumerator3 is IDisposable;
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				int num4 = 0;
				try
				{
					IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						DataRow dataRow6 = (DataRow)enumerator4.Current;
						num4++;
						dataRow6["شماره_صفحه"] = num4;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow6["cnt"], num + 1, false);
						if (flag2)
						{
							dataRow6["cnt"] = num;
						}
						dataRow6["تاریخ_امروز"] = Public_Function.dict["today"];
						dataRow6["تعداد_چک"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow6["cnt"]), huruf.ConvertType.هیچکدام);
						DataRow[] array3 = data.Select(Conversions.ToString(Operators.ConcatenateObject("parent_id=", dataRow6["id"])));
						flag2 = (array3.Length > 0);
						if (flag2)
						{
							long num5 = 0L;
							DataRow[] array4 = array3;
							for (int j = 0; j < array4.Length; j++)
							{
								DataRow dataRow7 = array4[j];
								num5 = Conversions.ToLong(Operators.AddObject(num5, dataRow7["مبلغ"]));
							}
							dataRow6["مبلغ_به_حروف"] = huruf.ConvertToHuruf(Conversions.ToString(num5), huruf.ConvertType.هیچکدام);
							dataRow6["جمع_مبلغ"] = num5;
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					bool flag2 = enumerator4 is IDisposable;
					if (flag2)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				return dataTable;
			}
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000E0F0C File Offset: 0x000DF10C
		private void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(this.ParentDatarow["moshtari_ID"]);
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			bool flag = !File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")));
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگ واگذاری به بانک ", dataRow2["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
				if (flag2)
				{
					this.design_print();
				}
			}
			else
			{
				NewLateBinding.LateCall(stiReport, null, "Load", new object[]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")
				}, null, null, null, true);
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				dataTable2.Columns["sh_check"].ColumnName = "شماره_چک";
				dataTable2.Columns.Remove("ID");
				dataTable2.Columns.Remove("dptype_id");
				dataTable2.Columns.Remove("Tarikh");
				dataTable2.Columns.Remove("sanadbed_id");
				dataTable2.Columns.Remove("sanadbes_id");
				dataTable2.Columns.Remove("moshtari_id");
				dataTable2.Columns.Remove("sandug_id");
				dataTable2.Columns.Remove("bankhesab_id");
				dataTable2.Columns.Remove("tarikh_fa");
				dataTable2.Columns.Remove("Parent_ID");
				dataTable2.Columns.Remove("dp_name");
				dataTable2.Columns.Remove("check_status");
				dataTable2.Columns.Remove("sh_fish");
				dataTable2.Columns.Remove("fishvariz");
				dataTable2.Columns.Remove("fishvariz_fa");
				dataTable2.Columns.Remove("hazine_ID");
				dataTable2.Columns.Remove("Hazine_Name");
				dataTable2.Columns.Remove("pardakhtcheck_ID");
				dataTable2.Columns.Remove("Tozih");
				dataTable2.Columns.Remove("check_sarresid");
				dataTable2.Columns.Remove("moshtari_name");
				dataTable2.Columns.Remove("checkbarg_id");
				dataTable2.Columns.Remove("daryaft_identity");
				dataTable2.Columns.Remove("is_child");
				dataTable2.Columns.Remove("identity");
				dataTable2.Columns.Remove("parent_identity");
				dataTable2.Columns.Remove("moshtari_id2");
				dataTable2.Columns.Remove("moshtari_name2");
				dataTable2.Columns["mablagh"].ColumnName = "مبلغ";
				dataTable2.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
				dataTable2.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
				dataTable2.Columns.Add(new DataColumn("bankshobe", typeof(string)));
				dataTable2.Columns.Add(new DataColumn("huruf", typeof(string)));
				dataTable2.Columns.Add(new DataColumn("تلفن", typeof(string)));
				dataTable2.Columns.Add(new DataColumn("آدرس", typeof(string)));
				dataTable2.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
				dataTable2.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
				bool flag2;
				try
				{
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator.Current;
						dataRow3["bankshobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["checkbank_name"], "/"), dataRow3["check_shobe"]);
						dataRow3["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow3["مبلغ"]), huruf.ConvertType.هیچکدام);
						dataRow3["تلفن"] = dataRow["tel"].ToString();
						dataRow3["آدرس"] = dataRow["address"].ToString();
						dataRow3["شماره_حساب"] = dataRow["sh_hesab"].ToString();
						dataRow3["صاحب_حساب"] = dataRow["sahebhesab"].ToString();
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
				dataTable2.Columns["bankshobe"].ColumnName = "بانک_شعبه_چک";
				dataTable2.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
				dataTable2.Columns["checkbank_name"].ColumnName = "بانک_چک";
				dataTable2.Columns["check_shobe"].ColumnName = "شعبه_چک";
				dataTable2.Columns.Remove("bankhesab_name");
				dataTable2.TableName = "data";
				DataTable dataTable3 = this.Createparentdt(dataTable2, Conversions.ToInteger(dataRow["bank_ID"]));
				dataTable3.TableName = "parent";
				stiReport.RegData(dataTable3);
				stiReport.RegData(dataTable2);
				flag2 = !Design;
				if (flag2)
				{
					stiReport.Print(false);
				}
				else
				{
					StiOptions.Designer.DontAskSaveReport = true;
					StiOptions.Designer.DontSaveDesignerConfig = true;
					StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
					StiOptions.Designer.AllowSaveStandaloneReport = false;
					StiOptions.Designer.CodeTabVisible = false;
					StiOptions.Designer.HtmlPreviewReportVisible = false;
					stiReport.Design();
					NewLateBinding.LateCall(stiReport, null, "Save", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")
					}, null, null, null, true);
				}
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x000E1610 File Offset: 0x000DF810
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				flag = (this.GridEX1.GetRows().Length == 0);
				if (!flag)
				{
					new VagozariPrint
					{
						BankHesab_ID = Conversions.ToInteger(this.ParentDatarow["moshtari_ID"]),
						dt = (DataTable)this.GridEX1.DataSource
					}.ShowReport(false);
				}
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x000E1690 File Offset: 0x000DF890
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			new VagozariPrint
			{
				BankHesab_ID = Conversions.ToInteger(this.ParentDatarow["moshtari_ID"]),
				dt = (DataTable)this.GridEX1.DataSource
			}.ShowReport(true);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x000E16E0 File Offset: 0x000DF8E0
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			string str = Conversions.ToString(this.ParentDatarow["moshtari_ID"]);
			DataTable dataTable = Public_Function.FillData("SELECT        Bank_Hesab.ID, Bank_Hesab.Bank_ID, Bank_Hesab.Shobe, Bank_Hesab.Sh_Hesab, Bank_Hesab.Sh_card, Bank_Hesab.Sh_Shaba, Bank_Hesab.AvalDore,  Bank_Hesab.AvalDore_Tarikh, Bank_Hesab.Sanad_ID, Bank_Hesab.CodeHesab_Mojodi, Bank_Hesab.CodeHesab_Vusul, Bank_Hesab.KartKhan,  Bank_Hesab.SahebHesab, Bank_Hesab.Tel, Bank_Hesab.Address, Bank_Hesab.NamePedar, Bank_Hesab.CodeMelli, Bank_Hesab.shsh, Bank_Hesab.sadere,Bank_Hesab.signpic,  Bank_Hesab.codeposti, Bank.Name  FROM            Bank_Hesab INNER JOIN                  Bank ON Bank_Hesab.Bank_ID = Bank.ID where Bank_Hesab.id=" + str);
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\poshtnevisi.mrt");
			dataTable.TableName = "data";
			stiReport.RegData(dataTable);
			stiReport.PrinterSettings = new StiPrinterSettings
			{
				Collate = false,
				Copies = this.GridEX1.GetRows().Length
			};
			stiReport.Print(false);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000E1778 File Offset: 0x000DF978
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			string str = Conversions.ToString(this.ParentDatarow["moshtari_ID"]);
			DataTable dataTable = Public_Function.FillData("SELECT        Bank_Hesab.ID, Bank_Hesab.Bank_ID, Bank_Hesab.Shobe, Bank_Hesab.Sh_Hesab, Bank_Hesab.Sh_card, Bank_Hesab.Sh_Shaba, Bank_Hesab.AvalDore,  Bank_Hesab.AvalDore_Tarikh, Bank_Hesab.Sanad_ID, Bank_Hesab.CodeHesab_Mojodi, Bank_Hesab.CodeHesab_Vusul, Bank_Hesab.KartKhan,  Bank_Hesab.SahebHesab, Bank_Hesab.Tel, Bank_Hesab.Address, Bank_Hesab.NamePedar, Bank_Hesab.CodeMelli, Bank_Hesab.shsh, Bank_Hesab.sadere,Bank_Hesab.signpic,  Bank_Hesab.codeposti, Bank.Name  FROM            Bank_Hesab INNER JOIN                  Bank ON Bank_Hesab.Bank_ID = Bank.ID where Bank_Hesab.id=" + str);
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\poshtnevisi.mrt");
			dataTable.TableName = "data";
			stiReport.RegData(dataTable);
			stiReport.PrinterSettings = new StiPrinterSettings
			{
				Collate = false,
				Copies = this.GridEX1.GetRows().Length
			};
			stiReport.Design();
		}

		// Token: 0x04000809 RID: 2057
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400080B RID: 2059
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x0400080C RID: 2060
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x0400080D RID: 2061
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400080E RID: 2062
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400080F RID: 2063
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000810 RID: 2064
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000811 RID: 2065
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000812 RID: 2066
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000813 RID: 2067
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x04000814 RID: 2068
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x04000815 RID: 2069
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x04000816 RID: 2070
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x04000817 RID: 2071
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000818 RID: 2072
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000819 RID: 2073
		[CompilerGenerated]
		private DataTable _dt_dcheck;

		// Token: 0x0400081A RID: 2074
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x0400081B RID: 2075
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x0400081C RID: 2076
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x0400081D RID: 2077
		private bool prevent;

		// Token: 0x0400081E RID: 2078
		private string notin;
	}
}
