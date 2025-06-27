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
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000E0 RID: 224
	[DesignerGenerated]
	public partial class Frm_CheckBargasht : Form
	{
		// Token: 0x06001447 RID: 5191 RVA: 0x000D612C File Offset: 0x000D432C
		public Frm_CheckBargasht()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			Frm_CheckBargasht.__ENCAddToList(this);
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

		// Token: 0x06001448 RID: 5192 RVA: 0x000D61D0 File Offset: 0x000D43D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_CheckBargasht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_CheckBargasht.__ENCList.Count == Frm_CheckBargasht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_CheckBargasht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_CheckBargasht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_CheckBargasht.__ENCList[num] = Frm_CheckBargasht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_CheckBargasht.__ENCList.RemoveRange(num, Frm_CheckBargasht.__ENCList.Count - num);
						Frm_CheckBargasht.__ENCList.Capacity = Frm_CheckBargasht.__ENCList.Count;
					}
					Frm_CheckBargasht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000D67A0 File Offset: 0x000D49A0
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x000D67B8 File Offset: 0x000D49B8
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EventHandler value4 = new EventHandler(this.GridEX1_SelectionChanged);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.KeyPress -= value3;
					this._GridEX1.SelectionChanged -= value4;
					this._GridEX1.CellEdited -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.KeyPress += value3;
					this._GridEX1.SelectionChanged += value4;
					this._GridEX1.CellEdited += value5;
					this._GridEX1.ColumnButtonClick += value6;
				}
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x000D68C0 File Offset: 0x000D4AC0
		// (set) Token: 0x0600144E RID: 5198 RVA: 0x000068A0 File Offset: 0x00004AA0
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

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x000D68D8 File Offset: 0x000D4AD8
		// (set) Token: 0x06001450 RID: 5200 RVA: 0x000068AA File Offset: 0x00004AAA
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

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x000D68F0 File Offset: 0x000D4AF0
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x000068B4 File Offset: 0x00004AB4
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

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x000D6908 File Offset: 0x000D4B08
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x000068BE File Offset: 0x00004ABE
		public int sum_mablagh
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x000D6920 File Offset: 0x000D4B20
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x000068C8 File Offset: 0x00004AC8
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x000D6938 File Offset: 0x000D4B38
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x000068D2 File Offset: 0x00004AD2
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

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x000D6950 File Offset: 0x000D4B50
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x000068DC File Offset: 0x00004ADC
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

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x000D6968 File Offset: 0x000D4B68
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x000068E6 File Offset: 0x00004AE6
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

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x000D6980 File Offset: 0x000D4B80
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x000068F0 File Offset: 0x00004AF0
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

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x000D6998 File Offset: 0x000D4B98
		// (set) Token: 0x06001460 RID: 5216 RVA: 0x000068FA File Offset: 0x00004AFA
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

		// Token: 0x06001461 RID: 5217 RVA: 0x000D69B0 File Offset: 0x000D4BB0
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000D69E0 File Offset: 0x000D4BE0
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
						dataRow2["BankHesab_Name"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
						dataRow2["BankHesab_ID"] = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
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
							dataRow2["checkbarg_id"] = RuntimeHelpers.GetObjectValue(dataRow["checkbarg_ID"]);
						}
						dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
						dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
						dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						dataRow2["dp_Name"] = "برگشت چک";
						dataRow2["dptype_id"] = 22;
						dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						dataRow2["Moshtari_ID2"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_ID2"]);
						dataRow2["Moshtari_Name2"] = RuntimeHelpers.GetObjectValue(dataRow["Moshtari_Name2"]);
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
				this.sum_mablagh = Conversions.ToInteger(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
			}
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000D6EC0 File Offset: 0x000D50C0
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
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 20, false);
					if (flag)
					{
						this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
					if (flag)
					{
						this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 12, false);
					if (flag)
					{
						this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
					}
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false);
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

		// Token: 0x06001465 RID: 5221 RVA: 0x000D70DC File Offset: 0x000D52DC
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
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 22, false);
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

		// Token: 0x06001466 RID: 5222 RVA: 0x000D7320 File Offset: 0x000D5520
		private void GetMoshtari_ID(DataRow row)
		{
			bool flag = row["daryaft_identity"] != DBNull.Value;
			DataRow[] array;
			if (flag)
			{
				array = this.dt_daryaft.Select(Conversions.ToString(Operators.ConcatenateObject("dptype_id=18 and daryaft_identity=", row["daryaft_identity"])));
			}
			else
			{
				array = this.dt_daryaft.Select(Conversions.ToString(Operators.ConcatenateObject("dptype_id=18 and PardakhtCheck_ID=", row["PardakhtCheck_ID"])));
			}
			flag = (array.Length > 0);
			if (flag)
			{
				this.GridEX1.GetRow().Cells["BankHesab_ID"].Value = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_ID"]);
				this.GridEX1.GetRow().Cells["BankHesab_Name"].Value = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_Name"]);
			}
			else
			{
				flag = (row["daryaft_identity"] != DBNull.Value);
				if (flag)
				{
					array = this.dt_daryaft.Select(Conversions.ToString(Operators.ConcatenateObject("dptype_id=12 and daryaft_identity=", row["daryaft_identity"])));
				}
				else
				{
					array = this.dt_daryaft.Select(Conversions.ToString(Operators.ConcatenateObject("dptype_id=12 and PardakhtCheck_ID=", row["PardakhtCheck_ID"])));
				}
				flag = (array.Length > 0);
				if (flag)
				{
					this.GridEX1.GetRow().Cells["Moshtari_ID2"].Value = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_ID"]);
					this.GridEX1.GetRow().Cells["Moshtari_Name2"].Value = RuntimeHelpers.GetObjectValue(array[0]["Moshtari_Name"]);
				}
				else
				{
					DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     TOP (1) DaryaftPardakht.BankHesab_ID, Bank.Name + ' ' + Bank_Hesab.Shobe AS BankHesab_Name  FROM   DaryaftPardakht INNER JOIN   Bank_Hesab ON DaryaftPardakht.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID where dptype_id=18 AND PardakhtCheck_ID=", row["PardakhtCheck_ID"]), " order by DaryaftPardakht.id desc")));
					flag = (dataRow != null);
					if (flag)
					{
						this.GridEX1.GetRow().Cells["BankHesab_ID"].Value = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]);
						this.GridEX1.GetRow().Cells["BankHesab_Name"].Value = RuntimeHelpers.GetObjectValue(dataRow["BankHesab_Name"]);
					}
				}
			}
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x000D7584 File Offset: 0x000D5784
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
						"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status in(2,5)",
						text2,
						this.notin,
						this.NotinTarikh(),
						" AND DaryaftPardakht.Sh_Check='",
						text,
						"'"
					}));
					dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
					bool flag3;
					try
					{
						IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag2 = (dataRow2["id"] != DBNull.Value);
							if (!flag2)
							{
								flag2 = (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 18, false) || Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 12, false));
								if (flag2)
								{
									flag = (dataRow2["daryaft_identity"] != DBNull.Value);
									if (flag)
									{
										flag3 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 20,
											Daryaft_Identity = Conversions.ToInteger(dataRow2["daryaft_identity"])
										});
										if (flag3)
										{
											continue;
										}
										flag3 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 22,
											Daryaft_Identity = Conversions.ToInteger(dataRow2["daryaft_identity"])
										});
										if (flag3)
										{
											continue;
										}
									}
									else
									{
										flag3 = Operators.ConditionalCompareObjectEqual(this.Contains_In_List(20, Conversions.ToInteger(dataRow2["PardakhtCheck_ID"])), true, false);
										if (flag3)
										{
											continue;
										}
										flag3 = Operators.ConditionalCompareObjectEqual(this.Contains_In_List(22, Conversions.ToInteger(dataRow2["PardakhtCheck_ID"])), true, false);
										if (flag3)
										{
											continue;
										}
									}
									DataRow dataRow3 = dataTable2.NewRow();
									dataRow3["ID"] = 0;
									dataRow3["Tarikh"] = RuntimeHelpers.GetObjectValue(dataRow2["Tarikh"]);
									dataRow3["Moshtari_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["Moshtari_ID"]);
									dataRow3["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow2["Mablagh"]);
									dataRow3["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow2["Tozih"]);
									dataRow3["Tarikh_Fa"] = RuntimeHelpers.GetObjectValue(dataRow2["Tarikh_Fa"]);
									dataRow3["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow2["Sh_Check"]);
									dataRow3["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["CheckBank_ID"]);
									dataRow3["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow2["Check_Shobe"]);
									dataRow3["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow2["Check_Sarresid_Fa"]);
									dataRow3["Moshtari_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["Moshtari_Name"]);
									dataRow3["Bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow2["CheckBank_Name"]);
									dataRow3["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow2["daryaft_identity"]);
									dataRow3["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow2["PardakhtCheck_ID"]);
									dataTable2.Rows.Add(dataRow3);
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
					flag3 = (dataTable2.Rows.Count == 0);
					if (flag3)
					{
						this.prevent = true;
						this.GridEX1.CancelCurrentEdit();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
					else
					{
						flag3 = (dataTable2.Rows.Count == 1);
						if (flag3)
						{
							this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Mablagh"]);
							this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["CheckBank_ID"]);
							this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Bank_Name"]);
							this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Sarresid_Fa"]);
							this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["Check_Shobe"]);
							this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["PardakhtCheck_ID"]);
							this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(dataTable2.Rows[0]["daryaft_identity"]);
							this.GetMoshtari_ID(dataTable2.Rows[0]);
							flag3 = Operators.ConditionalCompareObjectEqual(dataTable2.Rows[0]["ID"], 0, false);
							if (flag3)
							{
								flag2 = (dataTable2.Rows[0]["daryaft_identity"] != DBNull.Value);
								if (flag2)
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 22,
										Daryaft_Identity = Conversions.ToInteger(dataTable2.Rows[0]["daryaft_identity"])
									});
								}
								else
								{
									this.ListDaryaft_Identity.Add(new listCheckDaryaft
									{
										Operation_id = 22,
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
							flag3 = (dataTable2.Rows.Count > 1);
							if (flag3)
							{
								flag2 = (this.frmCheck_Select.ShowDialog(dataTable2, null, "برگشت چک - انتخاب چک") == DialogResult.OK);
								if (flag2)
								{
									flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null);
									if (flag)
									{
										this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
										this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
										this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
										this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
										this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
										this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
										this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["ID"]);
										this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
										this.GetMoshtari_ID(this.frmCheck_Select.SelectedRow.Row);
										flag3 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
										if (flag3)
										{
											flag2 = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
											if (flag2)
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 22,
													Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
												});
											}
											else
											{
												this.ListDaryaft_Identity.Add(new listCheckDaryaft
												{
													Operation_id = 22,
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
					}
				}
			}
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x000D81E4 File Offset: 0x000D63E4
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

		// Token: 0x06001469 RID: 5225 RVA: 0x000D8268 File Offset: 0x000D6468
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

		// Token: 0x0600146A RID: 5226 RVA: 0x000D84A0 File Offset: 0x000D66A0
		private string NotinTarikh()
		{
			return " AND DaryaftPardakht.ID  IN( SELECT     dp_asli.ID  FROM         DaryaftPardakht INNER JOIN DaryaftPardakht AS dp_asli ON DaryaftPardakht.PardakhtCheck_ID = dp_asli.ID WHERE     DaryaftPardakht.dpType_ID in(18,12) and dp_asli.check_status in(2,5) and DaryaftPardakht.tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + ")";
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000D84D4 File Offset: 0x000D66D4
		private string UnionNazdSandugh()
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
			return " UNION ALL SELECT  DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Check_Shobe,DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_shomareHesab,  Bank.Name AS Bank_Name,DaryaftPardakht.dptype_ID,check_Status,NULL AS CheckBarg_ID   FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + text + this.notin;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000D8678 File Offset: 0x000D6878
		private string UnionDasteCheck()
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
			return " UNION ALL SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih,  DaryaftPardakht.Tarikh_Fa, CAST(DasteCheckBarg.ShomareBarg AS nvarchar(50)) AS Sh_Check, DasteCheck.BankHesab_ID AS CheckBank_ID, DaryaftPardakht.ID AS PardakhtCheck_ID, Bank_Hesab.Shobe AS Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa,  CASE dptype_id WHEN 11 THEN Moshtari.Name + ' ' + Moshtari.Family WHEN - 98 THEN Moshtari.Name + ' ' + Moshtari.Family WHEN 15 THEN hazine.name END AS  Moshtari_Name, ISNULL(DaryaftPardakht.Check_ShomareHesab, ' ') AS Check_ShomareHesab, Bank.Name AS Bank_Name,DaryaftPardakht.dptype_ID,check_Status,DaryaftPardakht.CheckBarg_ID   FROM         DaryaftPardakht INNER JOIN  DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN  DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN  Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID LEFT OUTER JOIN  Hazine ON DaryaftPardakht.Hazine_ID = Hazine.ID LEFT OUTER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  WHERE     (DaryaftPardakht.dpType_ID IN (15, 11, - 98)) AND (DaryaftPardakht.Check_Status IN (5)) " + text + this.notin;
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000D880C File Offset: 0x000D6A0C
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
			DataTable dataTable2 = Public_Function.FillData(string.Concat(new string[]
			{
				"select * from ( SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,DaryaftPardakht.ID AS PardakhtCheck_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,DaryaftPardakht.Check_ShomareHesab,  Bank.Name AS Bank_Name,DaryaftPardakht.dptype_ID,check_Status,NULL AS CheckBarg_ID   FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status in (2,5)",
				text,
				this.notin,
				this.NotinTarikh(),
				this.UnionNazdSandugh(),
				this.UnionDasteCheck(),
				")t order by Check_Sarresid_Fa"
			}));
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			this.Sync_Check_Info(dataTable2);
			flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "برگشت چک - انتخاب چک") == DialogResult.OK);
			if (flag)
			{
				this.prevent = true;
				flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position && this.GridEX1.EditTextBox != null);
				if (flag)
				{
					this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmCheck_Select.SelectedRow["sh_check"]);
					this.GridEX1.GetRow().Cells["Mablagh"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Mablagh"]);
					this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBank_ID"]);
					this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Bank_Name"]);
					this.GridEX1.GetRow().Cells["Check_Sarresid_Fa"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Sarresid_Fa"]);
					this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["Check_Shobe"]);
					this.GridEX1.GetRow().Cells["PardakhtCheck_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["PardakhtCheck_ID"]);
					this.GridEX1.GetRow().Cells["daryaft_identity"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["daryaft_identity"]);
					this.GridEX1.GetRow().Cells["CheckBarg_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmCheck_Select.SelectedRow["CheckBarg_ID"]);
					flag = (this.frmCheck_Select.SelectedRow["pardakhtcheck_id"] != DBNull.Value);
					if (flag)
					{
						this.GetMoshtari_ID(this.frmCheck_Select.SelectedRow.Row);
					}
					flag = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
					if (flag)
					{
						bool flag2 = this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value;
						if (flag2)
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 22,
								Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
							});
						}
						else
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 22,
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

		// Token: 0x0600146E RID: 5230 RVA: 0x000D8D18 File Offset: 0x000D6F18
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

		// Token: 0x0600146F RID: 5231 RVA: 0x000D8DD4 File Offset: 0x000D6FD4
		private void GetSum()
		{
			int num = 0;
			int arg_12_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_12_0;
				while (true)
				{
					int arg_80_0 = num3;
					int num4 = num2;
					if (arg_80_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX1.GetRow(num3).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToInteger(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells["Mablagh"].Value));
					}
					num3++;
				}
			}
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x000D8E64 File Offset: 0x000D7064
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 20,
				Daryaft_Identity = value
			});
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000D8E98 File Offset: 0x000D7098
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

		// Token: 0x06001472 RID: 5234 RVA: 0x000D8EF0 File Offset: 0x000D70F0
		private void DeletePardakhtRedif(GridEXRow row)
		{
			DataRowView dataRowView = (DataRowView)row.DataRow;
			bool flag = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
			bool flag2;
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
				flag = (dataRowView["BankHesab_ID"] == DBNull.Value);
				int value2;
				if (flag)
				{
					flag2 = (dataRowView["Moshtari_id2"] != DBNull.Value);
					if (flag2)
					{
						value2 = 5;
					}
					else
					{
						flag2 = (dataRowView["CheckBarg_ID"] != DBNull.Value);
						if (flag2)
						{
							value2 = 5;
						}
						else
						{
							value2 = 1;
						}
					}
				}
				else
				{
					value2 = 2;
				}
				text2 = string.Concat(new string[]
				{
					text2,
					"update daryaftpardakht set check_status=",
					Conversions.ToString(value2),
					" where id=",
					text,
					";"
				});
				Public_Function.ExecuteNonQuery(text2);
			}
			flag2 = (this.GridEX1.CurrentRow.RowType == RowType.Record);
			if (flag2)
			{
				flag = (this.GridEX1.GetRow().Cells["daryaft_identity"].Value != DBNull.Value);
				if (flag)
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
				this.sum_mablagh = Conversions.ToInteger(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
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

		// Token: 0x06001473 RID: 5235 RVA: 0x000D9298 File Offset: 0x000D7498
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
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("pardakhtcheck_id=", row.Cells["pardakhtcheck_id"].Value), " and dptype_id<>22  AND ID IS NULL")));
				}
				else
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("daryaft_identity=", row.Cells["daryaft_identity"].Value), " and dptype_id<>22  AND ID IS NULL")));
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

		// Token: 0x06001474 RID: 5236 RVA: 0x000D94C0 File Offset: 0x000D76C0
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
				new Frm_DeleteDaryaftPardakht
				{
					ListDaryaft_Identity = this.ListDaryaft_Identity,
					dt_opr = dataTable
				}.ShowDialog();
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

		// Token: 0x06001475 RID: 5237 RVA: 0x000D964C File Offset: 0x000D784C
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["sh_check"].Position;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (!flag2)
				{
					this.Check_Select();
				}
			}
			else
			{
				bool flag2 = position == this.GridEX1.RootTable.Columns["del"].Position;
				if (flag2)
				{
					flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
					if (flag)
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

		// Token: 0x06001476 RID: 5238 RVA: 0x000D9734 File Offset: 0x000D7934
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

		// Token: 0x06001477 RID: 5239 RVA: 0x000D97A0 File Offset: 0x000D79A0
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

		// Token: 0x06001478 RID: 5240 RVA: 0x000D9828 File Offset: 0x000D7A28
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == Janus.Windows.GridEX.InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (e.KeyCode == Keys.Delete);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.EditTextBox != null);
						if (flag2)
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
							bool flag3 = this.GridEX1.CurrentRow.RowType == RowType.Record;
							if (!flag3)
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
								else
								{
									this.Check_Select_ByNum();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x000D9A54 File Offset: 0x000D7C54
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

		// Token: 0x0600147A RID: 5242 RVA: 0x000D9AB4 File Offset: 0x000D7CB4
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

		// Token: 0x0600147B RID: 5243 RVA: 0x000D9B34 File Offset: 0x000D7D34
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.RowType == RowType.Record;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["sh_check"].EditType = EditType.NoEdit;
				this.GridEX1.CurrentRow.Cells["sh_check"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
			}
		}

		// Token: 0x040007E7 RID: 2023
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007E9 RID: 2025
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040007EA RID: 2026
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040007EB RID: 2027
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040007EC RID: 2028
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x040007ED RID: 2029
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x040007EE RID: 2030
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x040007EF RID: 2031
		[CompilerGenerated]
		private int _sum_mablagh;

		// Token: 0x040007F0 RID: 2032
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x040007F1 RID: 2033
		[CompilerGenerated]
		private DataTable _dt_dcheck;

		// Token: 0x040007F2 RID: 2034
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x040007F3 RID: 2035
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x040007F4 RID: 2036
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x040007F5 RID: 2037
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x040007F6 RID: 2038
		private bool prevent;

		// Token: 0x040007F7 RID: 2039
		private string notin;
	}
}
