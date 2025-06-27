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
	// Token: 0x020000C4 RID: 196
	[DesignerGenerated]
	public partial class Frm_Change_Kala_To_Kala : Form
	{
		// Token: 0x06001016 RID: 4118 RVA: 0x000B1CC8 File Offset: 0x000AFEC8
		public Frm_Change_Kala_To_Kala()
		{
			base.Load += new EventHandler(this.Frm_Change_Kala_To_Kala_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Change_Kala_To_Kala_KeyDown);
			Frm_Change_Kala_To_Kala.__ENCAddToList(this);
			this.dt_select = new DataTable();
			this.frm = new Frm_SelectItem();
			this.InitializeComponent();
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000B1D2C File Offset: 0x000AFF2C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Change_Kala_To_Kala.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Change_Kala_To_Kala.__ENCList.Count == Frm_Change_Kala_To_Kala.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Change_Kala_To_Kala.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Change_Kala_To_Kala.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Change_Kala_To_Kala.__ENCList[num] = Frm_Change_Kala_To_Kala.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Change_Kala_To_Kala.__ENCList.RemoveRange(num, Frm_Change_Kala_To_Kala.__ENCList.Count - num);
						Frm_Change_Kala_To_Kala.__ENCList.Capacity = Frm_Change_Kala_To_Kala.__ENCList.Count;
					}
					Frm_Change_Kala_To_Kala.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000B219C File Offset: 0x000B039C
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00005768 File Offset: 0x00003968
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

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x000B21B4 File Offset: 0x000B03B4
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x000B21CC File Offset: 0x000B03CC
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

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x000B222C File Offset: 0x000B042C
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00005772 File Offset: 0x00003972
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

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x000B2244 File Offset: 0x000B0444
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x0000577C File Offset: 0x0000397C
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

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001022 RID: 4130 RVA: 0x000B225C File Offset: 0x000B045C
		// (set) Token: 0x06001023 RID: 4131 RVA: 0x00005786 File Offset: 0x00003986
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

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001024 RID: 4132 RVA: 0x000B2274 File Offset: 0x000B0474
		// (set) Token: 0x06001025 RID: 4133 RVA: 0x00005790 File Offset: 0x00003990
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

		// Token: 0x06001026 RID: 4134 RVA: 0x000B228C File Offset: 0x000B048C
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

		// Token: 0x06001027 RID: 4135 RVA: 0x000B240C File Offset: 0x000B060C
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

		// Token: 0x06001028 RID: 4136 RVA: 0x000B24C0 File Offset: 0x000B06C0
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
						flag3 = (array[0]["vazn"] != DBNull.Value);
						if (flag3)
						{
							DataRow[] array2 = array;
							DataRow[] arg_471_0 = array2;
							int num4 = 0;
							DataRow arg_493_0 = arg_471_0[num4];
							string columnName = "vazn";
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
						flag3 = (array[0]["vazn"] != DBNull.Value);
						if (flag3)
						{
							DataRow[] array2 = array;
							DataRow[] arg_550_0 = array2;
							int num4 = 0;
							DataRow arg_572_0 = arg_550_0[num4];
							string columnName = "vazn";
							arg_572_0[columnName] = Operators.SubtractObject(array2[num4][columnName], num3);
						}
					}
					((DataRowView)this.GridEX1.CurrentRow.DataRow)["parent_kala_id"] = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_id"]);
					this.GridEX1.CurrentRow.Cells["parent_kala_Name"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["kala_name"]);
				}
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Change_Kala_To_Kala_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0400061A RID: 1562
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400061C RID: 1564
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400061D RID: 1565
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x0400061E RID: 1566
		[CompilerGenerated]
		private DataTable _dt_kharid;

		// Token: 0x0400061F RID: 1567
		[CompilerGenerated]
		private DataTable _dt_furush;

		// Token: 0x04000620 RID: 1568
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x04000621 RID: 1569
		private DataTable dt_select;

		// Token: 0x04000622 RID: 1570
		private Frm_SelectItem frm;

		// Token: 0x04000623 RID: 1571
		[CompilerGenerated]
		private GridEX _grid;
	}
}
