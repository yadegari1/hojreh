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
	// Token: 0x020000E1 RID: 225
	[DesignerGenerated]
	public partial class Frm_CheckNaghd : Form
	{
		// Token: 0x0600147D RID: 5245 RVA: 0x000D9BA0 File Offset: 0x000D7DA0
		public Frm_CheckNaghd()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_CheckNaghd.__ENCAddToList(this);
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

		// Token: 0x0600147E RID: 5246 RVA: 0x000D9C44 File Offset: 0x000D7E44
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_CheckNaghd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_CheckNaghd.__ENCList.Count == Frm_CheckNaghd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_CheckNaghd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_CheckNaghd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_CheckNaghd.__ENCList[num] = Frm_CheckNaghd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_CheckNaghd.__ENCList.RemoveRange(num, Frm_CheckNaghd.__ENCList.Count - num);
						Frm_CheckNaghd.__ENCList.Capacity = Frm_CheckNaghd.__ENCList.Count;
					}
					Frm_CheckNaghd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x000DA214 File Offset: 0x000D8414
		// (set) Token: 0x06001482 RID: 5250 RVA: 0x000DA22C File Offset: 0x000D842C
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

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x000DA308 File Offset: 0x000D8508
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x00006911 File Offset: 0x00004B11
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

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x000DA320 File Offset: 0x000D8520
		// (set) Token: 0x06001486 RID: 5254 RVA: 0x0000691B File Offset: 0x00004B1B
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

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x000DA338 File Offset: 0x000D8538
		// (set) Token: 0x06001488 RID: 5256 RVA: 0x00006925 File Offset: 0x00004B25
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

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x000DA350 File Offset: 0x000D8550
		// (set) Token: 0x0600148A RID: 5258 RVA: 0x0000692F File Offset: 0x00004B2F
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

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x000DA368 File Offset: 0x000D8568
		// (set) Token: 0x0600148C RID: 5260 RVA: 0x00006939 File Offset: 0x00004B39
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

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x000DA380 File Offset: 0x000D8580
		// (set) Token: 0x0600148E RID: 5262 RVA: 0x00006943 File Offset: 0x00004B43
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

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x000DA398 File Offset: 0x000D8598
		// (set) Token: 0x06001490 RID: 5264 RVA: 0x0000694D File Offset: 0x00004B4D
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

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x000DA3B0 File Offset: 0x000D85B0
		// (set) Token: 0x06001492 RID: 5266 RVA: 0x00006957 File Offset: 0x00004B57
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

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000DA3C8 File Offset: 0x000D85C8
		// (set) Token: 0x06001494 RID: 5268 RVA: 0x00006961 File Offset: 0x00004B61
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

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x000DA3E0 File Offset: 0x000D85E0
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x0000696B File Offset: 0x00004B6B
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

		// Token: 0x06001497 RID: 5271 RVA: 0x000DA3F8 File Offset: 0x000D85F8
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x000DA428 File Offset: 0x000D8628
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
						int arg_A2_0 = num3;
						int num4 = num2;
						if (arg_A2_0 > num4)
						{
							break;
						}
						bool flag2 = Operators.ConditionalCompareObjectEqual(array[num3]["dptype_id"], 10, false);
						if (flag2)
						{
							num++;
						}
						else
						{
							array[num3].Delete();
						}
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
						bool flag2 = dataRow["ID"] != DBNull.Value;
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
						dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
						dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
						dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
						dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
						dataRow2["dp_Name"] = "نقد کردن چک";
						dataRow2["dptype_id"] = 26;
						dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
						table.Rows.InsertAt(dataRow2, num);
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
				this.sum_mablagh = Conversions.ToInteger(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x000DA824 File Offset: 0x000D8A24
		private void GetNotin()
		{
			this.notin = string.Empty;
			DataTable table = this.ParentDatarow.Table;
			bool flag;
			try
			{
				IEnumerator enumerator = table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false);
					if (flag)
					{
						this.notin = Conversions.ToString(Operators.ConcatenateObject(this.notin, Operators.ConcatenateObject(dataRow["PardakhtCheck_ID"], ",")));
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
			flag = (Operators.CompareString(this.notin, string.Empty, false) != 0);
			if (flag)
			{
				this.notin = Public_Function.RemoveLast(this.notin);
				this.notin = " and DaryaftPardakht.ID not in (" + this.notin + ")";
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x000DA934 File Offset: 0x000D8B34
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm_hesabBanki.items = itemCollection;
			itemCollection2.Add(new Column("Sh_Check", "شماره چک ", 20));
			itemCollection2.Add(new Column("Mablagh", "مبلغ", 20));
			itemCollection2.Add(new Column("Bank_Name", "بانک", 20));
			itemCollection2.Add(new Column("Check_Shobe", "شعبه", 20));
			itemCollection2.Add(new Column("Check_Sarresid_Fa", "سررسید", 20));
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
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 26, false);
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

		// Token: 0x0600149C RID: 5276 RVA: 0x000DAB48 File Offset: 0x000D8D48
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
						"SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99) And check_Status=1 and DaryaftPardakht.Tarikh<=",
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
						IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag2 = (dataRow2["id"] != DBNull.Value);
							if (!flag2)
							{
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 2, false);
								if (flag2)
								{
									flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
									{
										Operation_id = 12,
										Daryaft_Identity = Conversions.ToInteger(dataRow2["identity"])
									});
									if (!flag)
									{
										flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 18,
											Daryaft_Identity = Conversions.ToInteger(dataRow2["identity"])
										});
										if (!flag2)
										{
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
											dataRow3["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow2["identity"]);
											dataTable2.Rows.Add(dataRow3);
										}
									}
								}
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
								flag = (this.frmCheck_Select.ShowDialog(dataTable2, null, "نقد کردن چک - انتخاب چک") == DialogResult.OK);
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

		// Token: 0x0600149D RID: 5277 RVA: 0x000DB6CC File Offset: 0x000D98CC
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

		// Token: 0x0600149E RID: 5278 RVA: 0x000DB750 File Offset: 0x000D9950
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

		// Token: 0x0600149F RID: 5279 RVA: 0x000DB988 File Offset: 0x000D9B88
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
			DataTable dataTable2 = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.Tarikh, DaryaftPardakht.Moshtari_ID, DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa,  DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid_Fa, Moshtari.Name+' ' + Moshtari.Family AS Moshtari_Name,  Bank.Name AS Bank_Name  FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID  where DaryaftPardakht.dptype_ID in(2,-99,42) And check_Status=1 and DaryaftPardakht.Tarikh<=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + text + this.notin);
			dataTable2.Columns.Add(new DataColumn("daryaft_identity", typeof(int)));
			bool flag2;
			try
			{
				IEnumerator enumerator2 = this.dt_daryaft.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag = (Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow2["dptype_id"], 26, false));
					if (flag)
					{
						flag2 = (dataRow2["id"] != DBNull.Value);
						if (!flag2)
						{
							flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
							{
								Operation_id = 12,
								Daryaft_Identity = Conversions.ToInteger(dataRow2["identity"])
							});
							if (!flag2)
							{
								flag2 = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
								{
									Operation_id = 18,
									Daryaft_Identity = Conversions.ToInteger(dataRow2["identity"])
								});
								if (!flag2)
								{
									flag2 = (dataRow2["pardakhtCheck_ID"] != DBNull.Value);
									if (flag2)
									{
										flag = this.ListDaryaft_Identity.Contains(new listCheckDaryaft
										{
											Operation_id = 26,
											PardakhtCheck_ID = Conversions.ToInteger(dataRow2["PardakhtCheck_ID"])
										});
										if (flag)
										{
										}
									}
								}
							}
						}
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
			this.Sync_Check_Info(dataTable2);
			flag2 = (this.frmCheck_Select.ShowDialog(dataTable2, null, "نقد کردن چک - انتخاب چک") == DialogResult.OK);
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
					this.ListDaryaft_Identity.Add(new listCheckDaryaft
					{
						Operation_id = 26,
						PardakhtCheck_ID = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["ID"])
					});
					flag2 = Operators.ConditionalCompareObjectEqual(this.frmCheck_Select.SelectedRow["ID"], 0, false);
					if (flag2)
					{
						flag = (this.frmCheck_Select.SelectedRow["daryaft_identity"] != DBNull.Value);
						if (flag)
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 26,
								Daryaft_Identity = Conversions.ToInteger(this.frmCheck_Select.SelectedRow["daryaft_identity"])
							});
						}
						else
						{
							this.ListDaryaft_Identity.Add(new listCheckDaryaft
							{
								Operation_id = 26,
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

		// Token: 0x060014A0 RID: 5280 RVA: 0x000DBFEC File Offset: 0x000DA1EC
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

		// Token: 0x060014A1 RID: 5281 RVA: 0x000DC0A8 File Offset: 0x000DA2A8
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

		// Token: 0x060014A2 RID: 5282 RVA: 0x000DC138 File Offset: 0x000DA338
		private void Delete_Listdaryaft(int value)
		{
			this.ListDaryaft_Identity.Remove(new listCheckDaryaft
			{
				Operation_id = 26,
				Daryaft_Identity = value
			});
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x000DC16C File Offset: 0x000DA36C
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

		// Token: 0x060014A4 RID: 5284 RVA: 0x000DC1C4 File Offset: 0x000DA3C4
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

		// Token: 0x060014A5 RID: 5285 RVA: 0x000DC4F8 File Offset: 0x000DA6F8
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

		// Token: 0x060014A6 RID: 5286 RVA: 0x00006975 File Offset: 0x00004B75
		private void GetCheckUsagePardakht(GridEXRow row)
		{
			this.DeletePardakhtRedif(row);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x000DC720 File Offset: 0x000DA920
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

		// Token: 0x060014A8 RID: 5288 RVA: 0x000D9734 File Offset: 0x000D7934
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

		// Token: 0x060014A9 RID: 5289 RVA: 0x000DC7EC File Offset: 0x000DA9EC
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

		// Token: 0x060014AA RID: 5290 RVA: 0x000DC874 File Offset: 0x000DAA74
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

		// Token: 0x060014AB RID: 5291 RVA: 0x000DCAC0 File Offset: 0x000DACC0
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

		// Token: 0x060014AC RID: 5292 RVA: 0x000DCB20 File Offset: 0x000DAD20
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

		// Token: 0x040007F8 RID: 2040
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040007FA RID: 2042
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040007FB RID: 2043
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040007FC RID: 2044
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040007FD RID: 2045
		private Frm_SelectItem frm_hesabBanki;

		// Token: 0x040007FE RID: 2046
		private Frm_SelectItem frmCheck_Select;

		// Token: 0x040007FF RID: 2047
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x04000800 RID: 2048
		[CompilerGenerated]
		private int _sum_mablagh;

		// Token: 0x04000801 RID: 2049
		[CompilerGenerated]
		private string _Tarikh;

		// Token: 0x04000802 RID: 2050
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000803 RID: 2051
		[CompilerGenerated]
		private DataTable _dt_dcheck;

		// Token: 0x04000804 RID: 2052
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x04000805 RID: 2053
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000806 RID: 2054
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x04000807 RID: 2055
		private bool prevent;

		// Token: 0x04000808 RID: 2056
		private string notin;
	}
}
