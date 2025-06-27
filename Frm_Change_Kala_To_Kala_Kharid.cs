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
	// Token: 0x020000C5 RID: 197
	[DesignerGenerated]
	public partial class Frm_Change_Kala_To_Kala_Kharid : Form
	{
		// Token: 0x0600102B RID: 4139 RVA: 0x000B2AF4 File Offset: 0x000B0CF4
		public Frm_Change_Kala_To_Kala_Kharid()
		{
			base.Load += new EventHandler(this.Frm_Change_Kala_To_Kala_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Change_Kala_To_Kala_KeyDown);
			Frm_Change_Kala_To_Kala_Kharid.__ENCAddToList(this);
			this.dt_select = new DataTable();
			this.frm = new Frm_SelectItem();
			this.InitializeComponent();
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x000B2B58 File Offset: 0x000B0D58
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Change_Kala_To_Kala_Kharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Change_Kala_To_Kala_Kharid.__ENCList.Count == Frm_Change_Kala_To_Kala_Kharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Change_Kala_To_Kala_Kharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Change_Kala_To_Kala_Kharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Change_Kala_To_Kala_Kharid.__ENCList[num] = Frm_Change_Kala_To_Kala_Kharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Change_Kala_To_Kala_Kharid.__ENCList.RemoveRange(num, Frm_Change_Kala_To_Kala_Kharid.__ENCList.Count - num);
						Frm_Change_Kala_To_Kala_Kharid.__ENCList.Capacity = Frm_Change_Kala_To_Kala_Kharid.__ENCList.Count;
					}
					Frm_Change_Kala_To_Kala_Kharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600102F RID: 4143 RVA: 0x000B2FC8 File Offset: 0x000B11C8
		// (set) Token: 0x06001030 RID: 4144 RVA: 0x000057A7 File Offset: 0x000039A7
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

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001031 RID: 4145 RVA: 0x000B2FE0 File Offset: 0x000B11E0
		// (set) Token: 0x06001032 RID: 4146 RVA: 0x000B2FF8 File Offset: 0x000B11F8
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
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
				}
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001033 RID: 4147 RVA: 0x000B3058 File Offset: 0x000B1258
		// (set) Token: 0x06001034 RID: 4148 RVA: 0x000057B1 File Offset: 0x000039B1
		public DataTable dt_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_kharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_kharid = value;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001035 RID: 4149 RVA: 0x000B3070 File Offset: 0x000B1270
		// (set) Token: 0x06001036 RID: 4150 RVA: 0x000057BB File Offset: 0x000039BB
		public DataTable dt_furush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_furush;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_furush = value;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001037 RID: 4151 RVA: 0x000B3088 File Offset: 0x000B1288
		// (set) Token: 0x06001038 RID: 4152 RVA: 0x000057C5 File Offset: 0x000039C5
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

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x000B30A0 File Offset: 0x000B12A0
		// (set) Token: 0x0600103A RID: 4154 RVA: 0x000057CF File Offset: 0x000039CF
		public GridEX grid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._grid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._grid = value;
			}
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000B30B8 File Offset: 0x000B12B8
		private void Preparedt()
		{
			bool flag = !this.dt_kala_to_kala.Columns.Contains("parent_kala_name");
			if (flag)
			{
				this.dt_kala_to_kala.Columns.Add("parent_kala_name", typeof(string));
			}
			flag = !this.dt_kala_to_kala.Columns.Contains("Child_kala_name");
			if (flag)
			{
				this.dt_kala_to_kala.Columns.Add("Child_kala_name", typeof(string));
			}
			try
			{
				IEnumerator enumerator = this.dt_kala_to_kala.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["parent_kala_name"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select name from kala where id=", dataRow["parent_kala_id"])
					}, null, null, null));
					dataRow["child_kala_name"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select name from kala where id=", dataRow["Child_kala_id"])
					}, null, null, null));
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

		// Token: 0x0600103C RID: 4156 RVA: 0x000B3238 File Offset: 0x000B1438
		private void Frm_Change_Kala_To_Kala_Load(object sender, EventArgs e)
		{
			this.Preparedt();
			this.GridEX1.DataSource = this.dt_kala_to_kala;
			this.dt_select.Columns.Add("kala_name", typeof(string));
			this.dt_select.Columns.Add("kala_id", typeof(long));
			this.dt_select.Columns.Add("row_index", typeof(int));
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("kala_Name", "عنوان", 100));
			this.frm.items = itemCollection;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x000B32EC File Offset: 0x000B14EC
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = this.dt_select != null;
			if (flag)
			{
				this.dt_select.Clear();
			}
			int num = -1;
			checked
			{
				bool flag2;
				try
				{
					IEnumerator enumerator = this.dt_kharid.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						num++;
						flag = (dataRow["auto"] == DBNull.Value);
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["kala_id"], this.GridEX1.CurrentRow.Cells["parent_kala_id"].Value, false);
							if (flag2)
							{
								this.dt_select.Rows.Add(new object[]
								{
									RuntimeHelpers.GetObjectValue(dataRow["kala_name"]),
									RuntimeHelpers.GetObjectValue(dataRow["kala_id"]),
									num
								});
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
				flag2 = (this.frm.ShowDialog(this.dt_select, null, "کسر اتوماتیک - انتخاب جنس") == DialogResult.OK);
				if (flag2)
				{
					int num2;
					decimal num3;
					try
					{
						IEnumerator enumerator2 = this.dt_furush.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							flag = (dataRow2["kala_id"] == DBNull.Value);
							if (!flag)
							{
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow2["kala_id"], this.GridEX1.CurrentRow.Cells["child_kala_id"].Value, false);
								if (flag2)
								{
									flag = (dataRow2["tedad"] != DBNull.Value);
									if (flag)
									{
										num2 = Conversions.ToInteger(Operators.AddObject(num2, dataRow2["tedad"]));
									}
									flag2 = (dataRow2["vazn_ba_zarf"] != DBNull.Value);
									if (flag2)
									{
										num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataRow2["vazn_ba_zarf"]));
									}
									dataRow2["row_index"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["row_index"]);
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
					flag2 = (this.grid.CurrentRow.RowType == RowType.NewRecord);
					bool flag3;
					if (flag2)
					{
						flag = (this.grid.CurrentRow.Cells["kala_id"].Value != DBNull.Value);
						if (flag)
						{
							flag3 = Operators.ConditionalCompareObjectEqual(this.grid.CurrentRow.Cells["kala_id"].Value, this.GridEX1.CurrentRow.Cells["child_kala_id"].Value, false);
							if (flag3)
							{
								this.grid.CurrentRow.Cells["row_index"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["row_index"]);
								this.grid.CurrentRow.Cells["kala_id"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["child_kala_id"].Value);
							}
						}
					}
					DataRow[] array = this.dt_kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.GridEX1.CurrentRow.Cells["Parent_kala_ID"].Value)));
					flag3 = (array.Length > 0);
					if (flag3)
					{
						flag2 = (array[0]["tedad"] != DBNull.Value);
						if (flag2)
						{
							DataRow[] array2 = array;
							DataRow[] arg_422_0 = array2;
							int num4 = 0;
							DataRow arg_443_0 = arg_422_0[num4];
							string columnName = "tedad";
							arg_443_0[columnName] = Operators.AddObject(array2[num4][columnName], num2);
						}
						flag3 = (array[0]["vazn_ba_zarf"] != DBNull.Value);
						if (flag3)
						{
							DataRow[] array2 = array;
							DataRow[] arg_471_0 = array2;
							int num4 = 0;
							DataRow arg_493_0 = arg_471_0[num4];
							string columnName = "vazn_ba_zarf";
							arg_493_0[columnName] = Operators.AddObject(array2[num4][columnName], num3);
						}
					}
					array = this.dt_kharid.Select(Conversions.ToString(Operators.ConcatenateObject("kala_id=", this.frm.SelectedRow["Kala_id"])));
					flag3 = (array.Length > 0);
					if (flag3)
					{
						flag2 = (array[0]["tedad"] != DBNull.Value);
						if (flag2)
						{
							DataRow[] array2 = array;
							DataRow[] arg_501_0 = array2;
							int num4 = 0;
							DataRow arg_522_0 = arg_501_0[num4];
							string columnName = "tedad";
							arg_522_0[columnName] = Operators.SubtractObject(array2[num4][columnName], num2);
						}
						flag3 = (array[0]["vazn_ba_zarf"] != DBNull.Value);
						if (flag3)
						{
							DataRow[] array2 = array;
							DataRow[] arg_550_0 = array2;
							int num4 = 0;
							DataRow arg_572_0 = arg_550_0[num4];
							string columnName = "vazn_ba_zarf";
							arg_572_0[columnName] = Operators.SubtractObject(array2[num4][columnName], num3);
						}
					}
					((DataRowView)this.GridEX1.CurrentRow.DataRow)["parent_kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_id"]);
					this.GridEX1.CurrentRow.Cells["parent_kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_name"]);
				}
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Change_Kala_To_Kala_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x04000624 RID: 1572
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000626 RID: 1574
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000627 RID: 1575
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000628 RID: 1576
		[CompilerGenerated]
		private DataTable _dt_kharid;

		// Token: 0x04000629 RID: 1577
		[CompilerGenerated]
		private DataTable _dt_furush;

		// Token: 0x0400062A RID: 1578
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x0400062B RID: 1579
		private DataTable dt_select;

		// Token: 0x0400062C RID: 1580
		private Frm_SelectItem frm;

		// Token: 0x0400062D RID: 1581
		[CompilerGenerated]
		private GridEX _grid;
	}
}
