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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000106 RID: 262
	[DesignerGenerated]
	public partial class Frm_Rizbar_Sardkhane : Form
	{
		// Token: 0x0600239A RID: 9114 RVA: 0x001AA1C8 File Offset: 0x001A83C8
		public Frm_Rizbar_Sardkhane()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Rizbar_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Rizbar_FormClosing);
			base.Load += new EventHandler(this.Frm_Rizbar_Load);
			Frm_Rizbar_Sardkhane.__ENCAddToList(this);
			this.rizbar = new Furush_Hag_RizBar();
			this.frm = new Frm_SelectItem();
			this.tedad_0 = 0m;
			this.vazn_0 = 0m;
			this.InitializeComponent();
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x001AA258 File Offset: 0x001A8458
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rizbar_Sardkhane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rizbar_Sardkhane.__ENCList.Count == Frm_Rizbar_Sardkhane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rizbar_Sardkhane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rizbar_Sardkhane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rizbar_Sardkhane.__ENCList[num] = Frm_Rizbar_Sardkhane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rizbar_Sardkhane.__ENCList.RemoveRange(num, Frm_Rizbar_Sardkhane.__ENCList.Count - num);
						Frm_Rizbar_Sardkhane.__ENCList.Capacity = Frm_Rizbar_Sardkhane.__ENCList.Count;
					}
					Frm_Rizbar_Sardkhane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600239E RID: 9118 RVA: 0x001AA764 File Offset: 0x001A8964
		// (set) Token: 0x0600239F RID: 9119 RVA: 0x0000919C File Offset: 0x0000739C
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

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x001AA77C File Offset: 0x001A897C
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x001AA794 File Offset: 0x001A8994
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.Grid_RizBar_ColumnButtonClick);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.Grid_RizBar_CellEdited);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.Grid_RizBar_KeyPress);
				KeyEventHandler value5 = new KeyEventHandler(this.Grid_RizBar_KeyDown);
				bool flag = this._Grid_RizBar != null;
				if (flag)
				{
					this._Grid_RizBar.ColumnButtonClick -= value2;
					this._Grid_RizBar.CellEdited -= value3;
					this._Grid_RizBar.KeyPress -= value4;
					this._Grid_RizBar.KeyDown -= value5;
				}
				this._Grid_RizBar = value;
				flag = (this._Grid_RizBar != null);
				if (flag)
				{
					this._Grid_RizBar.ColumnButtonClick += value2;
					this._Grid_RizBar.CellEdited += value3;
					this._Grid_RizBar.KeyPress += value4;
					this._Grid_RizBar.KeyDown += value5;
				}
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x001AA870 File Offset: 0x001A8A70
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x000091A6 File Offset: 0x000073A6
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

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x001AA888 File Offset: 0x001A8A88
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x000091B0 File Offset: 0x000073B0
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

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x001AA8A0 File Offset: 0x001A8AA0
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x000091BA File Offset: 0x000073BA
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

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060023A8 RID: 9128 RVA: 0x001AA8B8 File Offset: 0x001A8AB8
		// (set) Token: 0x060023A9 RID: 9129 RVA: 0x000091C4 File Offset: 0x000073C4
		public long Kharid_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kharid_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kharid_ID = value;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060023AA RID: 9130 RVA: 0x001AA8D0 File Offset: 0x001A8AD0
		// (set) Token: 0x060023AB RID: 9131 RVA: 0x000091CE File Offset: 0x000073CE
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

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x001AA8E8 File Offset: 0x001A8AE8
		// (set) Token: 0x060023AD RID: 9133 RVA: 0x000091D8 File Offset: 0x000073D8
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

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x001AA900 File Offset: 0x001A8B00
		// (set) Token: 0x060023AF RID: 9135 RVA: 0x000091E2 File Offset: 0x000073E2
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

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060023B0 RID: 9136 RVA: 0x001AA918 File Offset: 0x001A8B18
		// (set) Token: 0x060023B1 RID: 9137 RVA: 0x000091EC File Offset: 0x000073EC
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

		// Token: 0x060023B2 RID: 9138 RVA: 0x001AA930 File Offset: 0x001A8B30
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
							dataRow["vazn"] = dataRow["vazn"].ToString().Replace(".0", "");
							flag = (dataRow["tedad"] == DBNull.Value);
							if (!flag)
							{
								dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
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

		// Token: 0x060023B3 RID: 9139 RVA: 0x001AAA4C File Offset: 0x001A8C4C
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
				string iD = Public_Function.GetID(dataTable, "kala_id", "");
				flag = (Operators.CompareString(iD, string.Empty, false) != 0);
				bool result;
				if (flag)
				{
					DataRow[] array = this.FurushTable.Select("kala_id not in(" + iD + ")");
					flag = (array.Length > 0);
					if (flag)
					{
						DataRow[] array2 = array;
						for (int j = 0; j < array2.Length; j++)
						{
							DataRow dataRow3 = array2[j];
							bool flag2 = dataRow3["tedad"] != DBNull.Value && dataRow3["vazn_kol"] != DBNull.Value;
							if (!flag2)
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

		// Token: 0x060023B4 RID: 9140 RVA: 0x001AAD90 File Offset: 0x001A8F90
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

		// Token: 0x060023B5 RID: 9141 RVA: 0x001AAEB8 File Offset: 0x001A90B8
		private void Auto_Sub()
		{
			DataTable dataTable = (DataTable)this.Grid_RizBar.DataSource;
			bool flag = dataTable.Rows.Count > 1;
			checked
			{
				if (flag)
				{
					int arg_3B_0 = 1;
					int num = dataTable.Rows.Count - 1;
					int num2 = arg_3B_0;
					bool flag2;
					while (true)
					{
						int arg_A9_0 = num2;
						int num3 = num;
						if (arg_A9_0 > num3)
						{
							goto Block_4;
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
					Block_4:
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
							DataRow arg_259_0 = dataRow2;
							string columnName = "tedad";
							arg_259_0[columnName] = Operators.SubtractObject(dataRow2[columnName], num4);
						}
					}
					flag2 = (dataTable.Rows[0]["vazn"] != DBNull.Value);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[0]["vazn"], this.vazn_0, false);
						if (flag)
						{
							DataRow dataRow2 = dataTable.Rows[0];
							DataRow arg_2E1_0 = dataRow2;
							string columnName = "vazn";
							arg_2E1_0[columnName] = Operators.SubtractObject(dataRow2[columnName], num5);
						}
					}
				}
			}
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x001AB1C0 File Offset: 0x001A93C0
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

		// Token: 0x060023B7 RID: 9143 RVA: 0x001AB1F8 File Offset: 0x001A93F8
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
							Operators.ConcatenateObject("delete from moshtari_kala where moshtari_id=" + Conversions.ToString(this.Kharid_ID) + " and kala_id=", this.frm.GridEX1.CurrentRow.Cells["ID"].Value)
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

		// Token: 0x060023B8 RID: 9144 RVA: 0x001AB2FC File Offset: 0x001A94FC
		private void Frm_Rizbar_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.Grid_RizBar.DataSource = this.dt_rizbar;
			bool flag = this.dt_rizbar.Rows.Count > 0;
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

		// Token: 0x060023B9 RID: 9145 RVA: 0x001AB3F8 File Offset: 0x001A95F8
		private void Grid_RizBar_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "tedad", false) == 0;
			if (flag)
			{
			}
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x001AB42C File Offset: 0x001A962C
		private void DelKala()
		{
			bool flag = this.Grid_RizBar.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.Grid_RizBar.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					long num = Conversions.ToLong(this.Grid_RizBar.CurrentRow.Cells["Kala_ID"].Value);
					bool flag3;
					try
					{
						IEnumerator enumerator = this.FurushTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag2 = (dataRow["kala_id"] != DBNull.Value);
							if (flag2)
							{
								flag = Operators.ConditionalCompareObjectEqual(dataRow["kala_id"], num, false);
								if (flag)
								{
									flag3 = (dataRow["tedad"] != DBNull.Value && dataRow["vazn_kol"] != DBNull.Value);
									if (flag3)
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
							Public_Function.ShowMessage("بدلیل کسر اتوماتیک از این جنس امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
							return;
						}
					}
					this.Grid_RizBar.CurrentRow.Delete();
					((DataTable)this.Grid_RizBar.DataSource).AcceptChanges();
				}
			}
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x001AB610 File Offset: 0x001A9810
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

		// Token: 0x060023BC RID: 9148 RVA: 0x001AB654 File Offset: 0x001A9854
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
								flag3 = (this.Grid_RizBar.CurrentRow.RowType == RowType.NewRecord);
								if (flag3)
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

		// Token: 0x060023BD RID: 9149 RVA: 0x001AB900 File Offset: 0x001A9B00
		private void Kala_select_Riz()
		{
			string text = "SELECT     Kharid_Sardkhane_Detail.Kala_ID AS ID, min(Kala.Name) AS Name  FROM         Kharid_Sardkhane_Detail INNER JOIN   Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID   where kharid_sardkhane_id =  " + Conversions.ToString(this.Kharid_ID);
			string iD = Public_Function.GetID((DataTable)this.Grid_RizBar.DataSource, "Kala_ID", "");
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = text + " AND Kala_ID Not IN (" + iD + ")";
			}
			text += "  group by Kharid_Sardkhane_Detail.Kala_ID";
			this.frm.ExtraData = this.Kharid_ID;
			flag = (this.frm.ShowDialog(text, null, 0) == DialogResult.OK);
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

		// Token: 0x060023BE RID: 9150 RVA: 0x0000917C File Offset: 0x0000737C
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Abort;
			this.Close();
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x001ABA5C File Offset: 0x001A9C5C
		private void Frm_Rizbar_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x001ABA8C File Offset: 0x001A9C8C
		private void Grid_RizBar_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.Grid_RizBar.Col == this.Grid_RizBar.RootTable.Columns["kala_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x04000DDE RID: 3550
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000DE0 RID: 3552
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000DE1 RID: 3553
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000DE2 RID: 3554
		private Furush_Hag_RizBar rizbar;

		// Token: 0x04000DE3 RID: 3555
		[CompilerGenerated]
		private long? _Furush_Hag_ID;

		// Token: 0x04000DE4 RID: 3556
		[CompilerGenerated]
		private DataTable _dt_rizbar;

		// Token: 0x04000DE5 RID: 3557
		[CompilerGenerated]
		private string _Tedad_Kol;

		// Token: 0x04000DE6 RID: 3558
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000DE7 RID: 3559
		[CompilerGenerated]
		private decimal _sum;

		// Token: 0x04000DE8 RID: 3560
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000DE9 RID: 3561
		[CompilerGenerated]
		private DataTable _FurushTable;

		// Token: 0x04000DEA RID: 3562
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x04000DEB RID: 3563
		private Frm_SelectItem frm;

		// Token: 0x04000DEC RID: 3564
		private decimal tedad_0;

		// Token: 0x04000DED RID: 3565
		private decimal vazn_0;
	}
}
