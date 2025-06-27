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
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000105 RID: 261
	[DesignerGenerated]
	public partial class Frm_Rizbar : Form
	{
		// Token: 0x0600236B RID: 9067 RVA: 0x001A7F48 File Offset: 0x001A6148
		public Frm_Rizbar()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Rizbar_FormClosing);
			base.Load += new EventHandler(this.Frm_Rizbar_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Rizbar_KeyDown);
			Frm_Rizbar.__ENCAddToList(this);
			this.rizbar = new Furush_Hag_RizBar();
			this.frm = new Frm_SelectItem();
			this.tedad_0 = 0m;
			this.vazn_0 = 0m;
			bool can_Sub = true;
			this.Can_Sub = can_Sub;
			this.InitializeComponent();
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x001A7FE0 File Offset: 0x001A61E0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rizbar.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rizbar.__ENCList.Count == Frm_Rizbar.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rizbar.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rizbar.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rizbar.__ENCList[num] = Frm_Rizbar.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rizbar.__ENCList.RemoveRange(num, Frm_Rizbar.__ENCList.Count - num);
						Frm_Rizbar.__ENCList.Capacity = Frm_Rizbar.__ENCList.Count;
					}
					Frm_Rizbar.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x0600236F RID: 9071 RVA: 0x001A860C File Offset: 0x001A680C
		// (set) Token: 0x06002370 RID: 9072 RVA: 0x0000910E File Offset: 0x0000730E
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

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002371 RID: 9073 RVA: 0x001A8624 File Offset: 0x001A6824
		// (set) Token: 0x06002372 RID: 9074 RVA: 0x001A863C File Offset: 0x001A683C
		internal virtual DataEntryGrid Grid_RizBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid_RizBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.Grid_RizBar_KeyPress);
				KeyEventHandler value3 = new KeyEventHandler(this.Grid_RizBar_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.Grid_RizBar_ColumnButtonClick);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.Grid_RizBar_CellEdited);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value7 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._Grid_RizBar != null;
				if (flag)
				{
					this._Grid_RizBar.KeyPress -= value2;
					this._Grid_RizBar.KeyDown -= value3;
					this._Grid_RizBar.ColumnButtonClick -= value4;
					this._Grid_RizBar.CellEdited -= value5;
					this._Grid_RizBar.InitCustomEdit -= value6;
					this._Grid_RizBar.EndCustomEdit -= value7;
				}
				this._Grid_RizBar = value;
				flag = (this._Grid_RizBar != null);
				if (flag)
				{
					this._Grid_RizBar.KeyPress += value2;
					this._Grid_RizBar.KeyDown += value3;
					this._Grid_RizBar.ColumnButtonClick += value4;
					this._Grid_RizBar.CellEdited += value5;
					this._Grid_RizBar.InitCustomEdit += value6;
					this._Grid_RizBar.EndCustomEdit += value7;
				}
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002373 RID: 9075 RVA: 0x001A8770 File Offset: 0x001A6970
		// (set) Token: 0x06002374 RID: 9076 RVA: 0x00009118 File Offset: 0x00007318
		internal virtual CurrencyBox txt_kargari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kargari = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002375 RID: 9077 RVA: 0x001A8788 File Offset: 0x001A6988
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00009122 File Offset: 0x00007322
		public long? Furush_Hag_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_Hag_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_Hag_ID = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06002377 RID: 9079 RVA: 0x001A87A0 File Offset: 0x001A69A0
		// (set) Token: 0x06002378 RID: 9080 RVA: 0x0000912C File Offset: 0x0000732C
		public DataTable dt_rizbar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_rizbar;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_rizbar = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002379 RID: 9081 RVA: 0x001A87B8 File Offset: 0x001A69B8
		// (set) Token: 0x0600237A RID: 9082 RVA: 0x00009136 File Offset: 0x00007336
		public string Tedad_Kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tedad_Kol;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tedad_Kol = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x0600237B RID: 9083 RVA: 0x001A87D0 File Offset: 0x001A69D0
		// (set) Token: 0x0600237C RID: 9084 RVA: 0x00009140 File Offset: 0x00007340
		public long Moshtari_ID
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

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600237D RID: 9085 RVA: 0x001A87E8 File Offset: 0x001A69E8
		// (set) Token: 0x0600237E RID: 9086 RVA: 0x0000914A File Offset: 0x0000734A
		public decimal sum
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sum;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sum = value;
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x0600237F RID: 9087 RVA: 0x001A8800 File Offset: 0x001A6A00
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x00009154 File Offset: 0x00007354
		public decimal Sum_Vazn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Sum_Vazn;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Sum_Vazn = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x001A8818 File Offset: 0x001A6A18
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x0000915E File Offset: 0x0000735E
		public DataTable FurushTable
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FurushTable;
			}
			[DebuggerNonUserCode]
			set
			{
				this._FurushTable = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x001A8830 File Offset: 0x001A6A30
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00009168 File Offset: 0x00007368
		public DataTable dt_kala_to_kala
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_kala_to_kala;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_kala_to_kala = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06002385 RID: 9093 RVA: 0x001A8848 File Offset: 0x001A6A48
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00009172 File Offset: 0x00007372
		private bool Can_Sub
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Can_Sub;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Can_Sub = value;
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x001A8860 File Offset: 0x001A6A60
		private void RemoveZeroVazn()
		{
			bool flag = this.Grid_RizBar.DataSource == null;
			if (!flag)
			{
				try
				{
					IEnumerator enumerator = ((DataTable)this.Grid_RizBar.DataSource).Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["vazn"] == DBNull.Value);
						if (!flag)
						{
							dataRow["vazn"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn"]));
							flag = (dataRow["tedad"] == DBNull.Value);
							if (!flag)
							{
								dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
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
			}
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x001A8970 File Offset: 0x001A6B70
		private bool ValidateGridData()
		{
			this.Grid_RizBar.UpdateData();
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] == DBNull.Value && dataRow["vazn"] == DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = 0;
						dataRow["vazn"] = 0;
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
			int i = 0;
			checked
			{
				bool flag;
				while (i <= dataTable.Rows.Count - 1)
				{
					flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["tedad"] == DBNull.Value && dataTable.Rows[i]["vazn"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[i].Delete();
							i--;
						}
						i++;
					}
				}
				dataTable.AcceptChanges();
				int num = 0;
				bool result;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = (dataRow2["tedad"] == DBNull.Value);
						if (flag)
						{
							dataRow2["tedad"] = 0;
						}
						flag = (dataRow2["vazn"] == DBNull.Value);
						if (flag)
						{
							dataRow2["vazn"] = 0;
						}
						flag = (dataRow2["kala_id"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.Grid_RizBar, this.Grid_RizBar.GetRows()[num], "kala_name", "جنس مورد نظر را انتخاب نمایید");
							result = false;
							return result;
						}
						num++;
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
				string text = Public_Function.GetID(dataTable, "kala_id", "");
				string iD = Public_Function.GetID(this.dt_kala_to_kala, "child_kala_id", "");
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				bool flag2;
				if (flag)
				{
					flag2 = (Operators.CompareString(iD, string.Empty, false) != 0);
					if (flag2)
					{
						text = text + "," + iD;
					}
				}
				else
				{
					text = iD;
				}
				flag2 = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag2)
				{
					DataRow[] array = this.FurushTable.Select("kala_id not in(" + text + ")");
					flag2 = (array.Length > 0);
					if (flag2)
					{
						DataRow[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							DataRow dataRow3 = array2[j];
							flag = (dataRow3["tedad"] != DBNull.Value && dataRow3["vazn_kol"] != DBNull.Value);
							if (!flag)
							{
								Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("جنس ", array[0]["kala_name"]), " در ریز بار ثبت نگردیده است ")), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
								result = false;
								return result;
							}
						}
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x001A8D5C File Offset: 0x001A6F5C
		private void GetSum()
		{
			this.sum = decimal.Zero;
			this.Sum_Vazn = decimal.Zero;
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			dataTable.AcceptChanges();
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						this.sum = Conversions.ToDecimal(Operators.AddObject(this.sum, dataRow["Tedad"]));
					}
					flag = (dataRow["vazn"] != DBNull.Value);
					if (flag)
					{
						this.Sum_Vazn = Conversions.ToDecimal(Operators.AddObject(this.Sum_Vazn, dataRow["vazn"]));
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
			this.dt_rizbar = dataTable;
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x001A8E84 File Offset: 0x001A7084
		private void Auto_Sub()
		{
			bool flag = !this.Can_Sub;
			checked
			{
				if (!flag)
				{
					DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
					flag = (dataTable.Rows.Count > 1);
					if (flag)
					{
						int arg_4F_0 = 1;
						int num = dataTable.Rows.Count - 1;
						int num2 = arg_4F_0;
						bool flag2;
						while (true)
						{
							int arg_B7_0 = num2;
							int num3 = num;
							if (arg_B7_0 > num3)
							{
								goto Block_5;
							}
							flag2 = (dataTable.Rows[num2]["auto"] == DBNull.Value);
							if (flag2)
							{
								break;
							}
							flag2 = Operators.ConditionalCompareObjectEqual(dataTable.Rows[num2]["auto"], false, false);
							if (flag2)
							{
								break;
							}
							num2++;
						}
						return;
						Block_5:
						decimal num4 = 0m;
						decimal num5 = 0m;
						try
						{
							IEnumerator enumerator = this.FurushTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag2 = (dataRow["kala_id"] == DBNull.Value);
								if (!flag2)
								{
									flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["kala_id"], dataTable.Rows[0]["kala_id"], false);
									if (flag2)
									{
										flag = (dataRow["tedad"] != DBNull.Value);
										if (flag)
										{
											num4 = Conversions.ToDecimal(Operators.AddObject(num4, dataRow["tedad"]));
										}
										flag2 = (dataRow["vazn_ba_zarf"] != DBNull.Value);
										if (flag2)
										{
											num5 = Conversions.ToDecimal(Operators.AddObject(num5, dataRow["vazn_ba_zarf"]));
										}
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
						flag2 = (dataTable.Rows[0]["tedad"] != DBNull.Value);
						if (flag2)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[0]["tedad"], this.tedad_0, false);
							if (flag)
							{
								DataRow dataRow2 = dataTable.Rows[0];
								DataRow arg_267_0 = dataRow2;
								string columnName = "tedad";
								arg_267_0[columnName] = Operators.SubtractObject(dataRow2[columnName], num4);
							}
						}
						flag2 = (dataTable.Rows[0]["vazn"] != DBNull.Value);
						if (flag2)
						{
							flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[0]["vazn"], this.vazn_0, false);
							if (flag)
							{
								DataRow dataRow2 = dataTable.Rows[0];
								DataRow arg_2EF_0 = dataRow2;
								string columnName = "vazn";
								arg_2EF_0[columnName] = Operators.SubtractObject(dataRow2[columnName], num5);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x001A919C File Offset: 0x001A739C
		private void Frm_Rizbar_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGridData();
			if (flag)
			{
				e.Cancel = true;
			}
			else
			{
				this.Auto_Sub();
				this.GetSum();
			}
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x001A91D4 File Offset: 0x001A73D4
		private void btn_click(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "del", false) == 0;
			if (flag)
			{
				bool flag2 = this.frm.GridEX1.CurrentRow != null;
				if (flag2)
				{
					try
					{
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject("delete from moshtari_kala where moshtari_id=" + Conversions.ToString(this.Moshtari_ID) + " and kala_id=", this.frm.GridEX1.CurrentRow.Cells["ID"].Value)
						}, null, null, null, true);
						this.frm.GridEX1.CurrentRow.Delete();
					}
					catch (Exception expr_C5)
					{
						ProjectData.SetProjectError(expr_C5);
						Public_Function.ShowMessage("امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x001A92D8 File Offset: 0x001A74D8
		private void Frm_Rizbar_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				this.Grid_RizBar.RootTable.Columns["mablagh_kargari"].Visible = true;
			}
			flag = (Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 2.0);
			if (flag)
			{
				this.Grid_RizBar.RootTable.Columns["mablagh_kargari"].Visible = false;
			}
			this.Grid_RizBar.DataSource = this.dt_rizbar;
			flag = (this.dt_rizbar.Rows.Count > 0);
			if (flag)
			{
				this.tedad_0 = Conversions.ToDecimal(this.dt_rizbar.Rows[0]["tedad"]);
				this.vazn_0 = Conversions.ToDecimal(this.dt_rizbar.Rows[0]["vazn"]);
			}
			this.RemoveZeroVazn();
			this.Grid_RizBar.Focus();
			this.Grid_RizBar.MoveToNewRecord();
			this.Grid_RizBar.Col = 0;
			this.frm.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.btn_click);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0000205D File Offset: 0x0000025D
		private void Grid_RizBar_CellEdited(object sender, ColumnActionEventArgs e)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x001A9454 File Offset: 0x001A7654
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "mablagh_kargari", false) == 0;
			if (flag)
			{
				bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
				if (hasValue)
				{
					e.Value = ((CurrencyBox)e.EditControl).Value;
				}
			}
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x001A94C4 File Offset: 0x001A76C4
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "mablagh_kargari", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_kargari;
				this.txt_kargari.Text = e.Value.ToString();
				this.txt_kargari.SelectAll();
			}
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x001A952C File Offset: 0x001A772C
		private void DelKala()
		{
			bool flag = this.Grid_RizBar.CurrentRow != null;
			checked
			{
				if (flag)
				{
					bool flag2 = this.Grid_RizBar.CurrentRow.RowType == RowType.Record;
					if (flag2)
					{
						bool flag3 = this.Grid_RizBar.CurrentRow.Cells["Kala_ID"].Value != DBNull.Value;
						if (flag3)
						{
							long num = Conversions.ToLong(this.Grid_RizBar.CurrentRow.Cells["Kala_ID"].Value);
							try
							{
								IEnumerator enumerator = this.FurushTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									flag3 = (dataRow["kala_id"] != DBNull.Value);
									if (flag3)
									{
										flag2 = Operators.ConditionalCompareObjectEqual(dataRow["kala_id"], num, false);
										if (flag2)
										{
											flag = (dataRow["tedad"] != DBNull.Value && dataRow["vazn_kol"] != DBNull.Value);
											if (flag)
											{
												Public_Function.ShowMessage("جنس مورد نظر در فروش استفاده شده است", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
												return;
											}
										}
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
							flag3 = (this.dt_kala_to_kala != null);
							if (flag3)
							{
								DataRow[] array = this.dt_kala_to_kala.Select(Conversions.ToString(Operators.ConcatenateObject("parent_kala_id=", this.Grid_RizBar.CurrentRow.Cells["kala_ID"].Value)));
								flag3 = (array.Length > 0);
								if (flag3)
								{
									DataRow[] array2 = array;
									for (int i = 0; i < array2.Length; i++)
									{
										DataRow dataRow2 = array2[i];
										DataRow[] array3 = this.dt_rizbar.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow2["child_kala_id"])));
										flag3 = (array3.Length > 0);
										if (flag3)
										{
											Public_Function.ShowMessage("بدلیل کسر اتوماتیک از این جنس امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
											return;
										}
									}
								}
							}
						}
						this.Grid_RizBar.CurrentRow.Delete();
						((DataTable)this.Grid_RizBar.DataSource).AcceptChanges();
						flag3 = (this.Grid_RizBar.GetRows().Length == 0);
						if (flag3)
						{
							this.Grid_RizBar.MoveToNewRecord();
							this.Grid_RizBar.Col = this.Grid_RizBar.RootTable.Columns["kala_name"].Position;
							this.Grid_RizBar.EditMode = EditMode.EditOn;
						}
					}
				}
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x001A9804 File Offset: 0x001A7A04
		private void Grid_RizBar_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "kala_name", false) == 0;
			if (flag)
			{
				this.Kala_select_Riz();
			}
			else
			{
				this.DelKala();
			}
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x001A9848 File Offset: 0x001A7A48
		private void Sync_kala()
		{
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			try
			{
				IEnumerator enumerator = this.dt_kala_to_kala.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["child_kala_id"])));
					bool flag = array.Length == 0;
					if (flag)
					{
						DataRow dataRow2 = dataTable.NewRow();
						dataRow2["kala_id"] = RuntimeHelpers.GetObjectValue(dataRow["child_kala_id"]);
						DataRow[] array2 = this.FurushTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow2["kala_id"])));
						flag = (array2.Length > 0);
						if (flag)
						{
							dataRow2["tedad"] = Public_Function.GetSum(array2, "tedad");
							dataRow2["vazn"] = Public_Function.GetSum(array2, "vazn_kol");
							dataRow2["auto"] = 1;
							dataRow2["kala_name"] = RuntimeHelpers.GetObjectValue(array2[0]["kala_name"]);
							array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", dataRow["parent_kala_id"])));
							flag = (array.Length > 0);
							if (flag)
							{
								bool flag2 = dataRow2["tedad"] != DBNull.Value;
								bool flag3;
								if (flag2)
								{
									flag3 = (array[0]["tedad"] != DBNull.Value);
									if (flag3)
									{
										DataRow[] array3 = array;
										DataRow[] arg_19B_0 = array3;
										int num = 0;
										DataRow arg_1C2_0 = arg_19B_0[num];
										string columnName = "tedad";
										arg_1C2_0[columnName] = Operators.SubtractObject(array3[num][columnName], dataRow2["tedad"]);
									}
								}
								flag3 = (dataRow2["vazn"] != DBNull.Value);
								if (flag3)
								{
									flag2 = (array[0]["vazn"] != DBNull.Value);
									if (flag2)
									{
										DataRow[] array3 = array;
										DataRow[] arg_20D_0 = array3;
										int num = 0;
										DataRow arg_234_0 = arg_20D_0[num];
										string columnName = "vazn";
										arg_234_0[columnName] = Operators.SubtractObject(array3[num][columnName], dataRow2["vazn"]);
									}
								}
							}
							dataTable.Rows.Add(dataRow2);
							this.Can_Sub = false;
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

		// Token: 0x06002394 RID: 9108 RVA: 0x001A9B00 File Offset: 0x001A7D00
		private void Grid_RizBar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			if (flag)
			{
				bool flag2 = this.Grid_RizBar.EditTextBox != null;
				if (flag2)
				{
					this.Grid_RizBar.EditTextBox.Text = string.Empty;
				}
			}
			checked
			{
				bool flag2;
				switch (e.KeyData)
				{
				case Keys.Left:
				{
					DataEntryGrid grid_RizBar = this.Grid_RizBar;
					grid_RizBar.Col++;
					e.SuppressKeyPress = true;
					return;
				}
				case Keys.Up:
					flag2 = (this.Grid_RizBar.Row > 0);
					if (flag2)
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Row--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Right:
					flag2 = (this.Grid_RizBar.Col > 0);
					if (flag2)
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Col--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Down:
					flag2 = (this.Grid_RizBar.Row < this.Grid_RizBar.RowCount - 1);
					if (flag2)
					{
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Row++;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				}
				flag2 = (e.KeyCode == Keys.Return);
				if (flag2)
				{
					int col = this.Grid_RizBar.Col;
					flag = (col == this.Grid_RizBar.RootTable.Columns["kala_Name"].Position);
					if (flag)
					{
						bool flag3 = Operators.CompareString(this.Grid_RizBar.EditTextBox.Text, string.Empty, false) == 0;
						if (flag3)
						{
							this.Kala_select_Riz();
						}
						else
						{
							DataEntryGrid grid_RizBar = this.Grid_RizBar;
							grid_RizBar.Col++;
						}
					}
					else
					{
						bool flag3 = col == this.Grid_RizBar.RootTable.Columns["Tedad"].Position;
						if (flag3)
						{
							e.SuppressKeyPress = true;
							DataEntryGrid grid_RizBar = this.Grid_RizBar;
							grid_RizBar.Col++;
						}
						else
						{
							flag3 = (col == this.Grid_RizBar.RootTable.Columns["Vazn"].Position);
							if (flag3)
							{
								e.SuppressKeyPress = true;
								flag3 = (!Conversions.ToBoolean(Public_Function.dict["kargari"]) || Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 2.0);
								if (flag3)
								{
									flag2 = (this.Grid_RizBar.CurrentRow.RowType == RowType.NewRecord);
									if (flag2)
									{
										this.Grid_RizBar.UpdateData();
									}
									this.Sync_kala();
									this.Grid_RizBar.MoveToNewRecord();
									this.Grid_RizBar.Col = 0;
								}
								else
								{
									DataEntryGrid grid_RizBar = this.Grid_RizBar;
									grid_RizBar.Col++;
								}
							}
							else
							{
								flag3 = (col == this.Grid_RizBar.RootTable.Columns["mablagh_kargari"].Position);
								if (flag3)
								{
									flag2 = (this.Grid_RizBar.CurrentRow.RowType == RowType.NewRecord);
									if (flag2)
									{
										this.Grid_RizBar.UpdateData();
									}
									this.Grid_RizBar.MoveToNewRecord();
									this.Grid_RizBar.Col = 0;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x001A9E7C File Offset: 0x001A807C
		private void Kala_select_Riz()
		{
			string uniqueID = Public_Function.GetUniqueID(this.FurushTable, "kala_id");
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = Operators.CompareString(uniqueID, string.Empty, false) != 0;
			if (flag)
			{
				text3 = string.Concat(new string[]
				{
					"SELECT     Kala.ID,  Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=",
					Conversions.ToString(this.Moshtari_ID),
					" and kala_id in (",
					uniqueID,
					") "
				});
				text2 = Public_Function.GetID(this.dt_kala_to_kala, "child_kala_id", "");
				flag = (text2.Length > 0);
				if (flag)
				{
					text3 = text3 + " AND Kala_ID Not IN (" + text2 + ")";
				}
				text = Public_Function.GetID((DataTable)this.Grid_RizBar.DataSource, "Kala_ID", "");
				flag = (text.Length > 0);
				if (flag)
				{
				}
				text3 += " union all";
			}
			text3 = text3 + " SELECT     Kala.ID,  Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=" + Conversions.ToString(this.Moshtari_ID);
			text = Public_Function.GetID((DataTable)this.Grid_RizBar.DataSource, "Kala_ID", "");
			flag = (text.Length > 0);
			if (flag)
			{
			}
			text2 = Public_Function.GetID(this.dt_kala_to_kala, "child_kala_id", "");
			flag = (text2.Length > 0);
			if (flag)
			{
			}
			flag = (uniqueID.Length > 0);
			if (flag)
			{
				text3 = text3 + " AND Kala_ID Not IN (" + uniqueID + ")";
			}
			this.frm.CanDelete = true;
			this.frm.ExtraData = this.Moshtari_ID;
			flag = (this.frm.ShowDialog(text3, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["Kala_Name"].Position && this.Grid_RizBar.EditTextBox != null;
					if (flag2)
					{
						this.Grid_RizBar.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.Grid_RizBar.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid grid_RizBar = this.Grid_RizBar;
						grid_RizBar.Col++;
					}
				}
			}
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x0000917C File Offset: 0x0000737C
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Abort;
			this.Close();
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x001AA118 File Offset: 0x001A8318
		private void Frm_Rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F5;
			if (flag)
			{
				this.DelKala();
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			flag = (e.KeyCode == Keys.F12);
			if (flag)
			{
				MyProject.Forms.Form_Main.UiButton4_Click(null, null);
			}
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x001AA17C File Offset: 0x001A837C
		private void Grid_RizBar_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["kala_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000DCC RID: 3532
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000DCE RID: 3534
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000DCF RID: 3535
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000DD0 RID: 3536
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000DD1 RID: 3537
		private Furush_Hag_RizBar rizbar;

		// Token: 0x04000DD2 RID: 3538
		[CompilerGenerated]
		private long? _Furush_Hag_ID;

		// Token: 0x04000DD3 RID: 3539
		[CompilerGenerated]
		private DataTable _dt_rizbar;

		// Token: 0x04000DD4 RID: 3540
		[CompilerGenerated]
		private string _Tedad_Kol;

		// Token: 0x04000DD5 RID: 3541
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000DD6 RID: 3542
		[CompilerGenerated]
		private decimal _sum;

		// Token: 0x04000DD7 RID: 3543
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000DD8 RID: 3544
		[CompilerGenerated]
		private DataTable _FurushTable;

		// Token: 0x04000DD9 RID: 3545
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x04000DDA RID: 3546
		private Frm_SelectItem frm;

		// Token: 0x04000DDB RID: 3547
		private decimal tedad_0;

		// Token: 0x04000DDC RID: 3548
		private decimal vazn_0;

		// Token: 0x04000DDD RID: 3549
		[CompilerGenerated]
		private bool _Can_Sub;
	}
}
