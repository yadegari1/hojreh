using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000122 RID: 290
	[DesignerGenerated]
	public partial class Frm_Rotbe : Form
	{
		// Token: 0x06002A36 RID: 10806 RVA: 0x0000A81F File Offset: 0x00008A1F
		[DebuggerNonUserCode]
		public Frm_Rotbe()
		{
			Frm_Rotbe.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002A37 RID: 10807 RVA: 0x001FBE0C File Offset: 0x001FA00C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rotbe.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rotbe.__ENCList.Count == Frm_Rotbe.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rotbe.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rotbe.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rotbe.__ENCList[num] = Frm_Rotbe.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rotbe.__ENCList.RemoveRange(num, Frm_Rotbe.__ENCList.Count - num);
						Frm_Rotbe.__ENCList.Capacity = Frm_Rotbe.__ENCList.Count;
					}
					Frm_Rotbe.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x001FC2A4 File Offset: 0x001FA4A4
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x001FC2BC File Offset: 0x001FA4BC
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				bool flag = this._Button1 != null;
				if (flag)
				{
					this._Button1.Click -= value2;
				}
				this._Button1 = value;
				flag = (this._Button1 != null);
				if (flag)
				{
					this._Button1.Click += value2;
				}
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x001FC31C File Offset: 0x001FA51C
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x001FC334 File Offset: 0x001FA534
		internal virtual DataEntryGrid GridEX1
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

		// Token: 0x06002A3E RID: 10814 RVA: 0x001FC394 File Offset: 0x001FA594
		private void getRotbe(DataTable dt)
		{
			dt.Columns.Add("diff", typeof(int));
			dt.Columns.Add("sud", typeof(int));
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DateTime dateTime;
					bool flag = DateTime.Compare(dateTime, DateTime.MinValue) == 0;
					if (flag)
					{
						dateTime = Conversions.ToDate(dataRow["tarikh"]);
						long num = Conversions.ToLong(dataRow["bed"]);
					}
					else
					{
						DateTime dateTime2 = Conversions.ToDate(dataRow["tarikh"]);
						dataRow["diff"] = DateAndTime.DateDiff(DateInterval.Day, dateTime, dateTime2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1);
						long num;
						dataRow["sud"] = Operators.MultiplyObject(Operators.MultiplyObject(dataRow["diff"], 0.01), num);
						dateTime = dateTime2;
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

		// Token: 0x06002A3F RID: 10815 RVA: 0x001FC4E4 File Offset: 0x001FA6E4
		private void prepare(DataTable dt)
		{
			dt.Columns.Add("mande", typeof(long));
			dt.Columns.Add("stat", typeof(string));
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["bes"]));
					dataRow["mande"] = Math.Abs(num);
					bool flag = num > 0L;
					if (flag)
					{
						dataRow["stat"] = "بد";
					}
					else
					{
						dataRow["stat"] = "بس";
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
			this.getRotbe(dt);
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x001FC60C File Offset: 0x001FA80C
		private void Button1_Click(object sender, EventArgs e)
		{
			DataTable dataTable = Public_Function.FillData("select * from moshtari where id>0 ");
			dataTable.Columns.Add("days", typeof(long));
			dataTable.Columns.Add("sud", typeof(long));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataTable dataTable2 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from sanad where codehesab_ID=", dataRow["codehesab_id"]), "order by tarikh")));
					this.prepare(dataTable2);
					dataRow["days"] = RuntimeHelpers.GetObjectValue(dataTable2.Compute("sum(diff)", ""));
					dataRow["sud"] = RuntimeHelpers.GetObjectValue(dataTable2.Compute("sum(sud)", ""));
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
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x001FC740 File Offset: 0x001FA940
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			DataTable dt = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from sanad where codehesab_ID=", this.GridEX1.CurrentRow.Cells["codehesab_id"].Value), "order by tarikh")));
			this.prepare(dt);
			Frm_Rotbe_Detailvb frm_Rotbe_Detailvb = new Frm_Rotbe_Detailvb
			{
				dt = dt
			};
			frm_Rotbe_Detailvb.ShowDialog();
		}

		// Token: 0x04001078 RID: 4216
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400107A RID: 4218
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400107B RID: 4219
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;
	}
}
