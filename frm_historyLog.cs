using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006D RID: 109
	[DesignerGenerated]
	public partial class frm_historyLog : Form
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x000037C6 File Offset: 0x000019C6
		[DebuggerNonUserCode]
		public frm_historyLog()
		{
			base.Load += new EventHandler(this.frm_historyLog_Load);
			frm_historyLog.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00076268 File Offset: 0x00074468
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = frm_historyLog.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = frm_historyLog.__ENCList.Count == frm_historyLog.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = frm_historyLog.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = frm_historyLog.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									frm_historyLog.__ENCList[num] = frm_historyLog.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						frm_historyLog.__ENCList.RemoveRange(num, frm_historyLog.__ENCList.Count - num);
						frm_historyLog.__ENCList.Capacity = frm_historyLog.__ENCList.Count;
					}
					frm_historyLog.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00076D18 File Offset: 0x00074F18
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00076D30 File Offset: 0x00074F30
		internal virtual GridEX GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridEX2_SelectionChanged);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.SelectionChanged -= value2;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00076D90 File Offset: 0x00074F90
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000037F2 File Offset: 0x000019F2
		internal virtual GridEX GridDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridDelete = value;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00076DA8 File Offset: 0x00074FA8
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000037FC File Offset: 0x000019FC
		internal virtual GridEX GridEX4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX4 = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00076DC0 File Offset: 0x00074FC0
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00003806 File Offset: 0x00001A06
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

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00076DD8 File Offset: 0x00074FD8
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00076DF0 File Offset: 0x00074FF0
		internal virtual SuperTabStrip SuperTabStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler<SuperTabStripSelectedTabChangedEventArgs> value2 = new EventHandler<SuperTabStripSelectedTabChangedEventArgs>(this.SuperTabStrip1_SelectedTabChanged);
				bool flag = this._SuperTabStrip1 != null;
				if (flag)
				{
					this._SuperTabStrip1.SelectedTabChanged -= value2;
				}
				this._SuperTabStrip1 = value;
				flag = (this._SuperTabStrip1 != null);
				if (flag)
				{
					this._SuperTabStrip1.SelectedTabChanged += value2;
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00076E50 File Offset: 0x00075050
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00003810 File Offset: 0x00001A10
		internal virtual SuperTabItem SuperTabItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabItem1 = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00076E68 File Offset: 0x00075068
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x0000381A File Offset: 0x00001A1A
		internal virtual SuperTabItem SuperTabItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabItem2 = value;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00076E80 File Offset: 0x00075080
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00003824 File Offset: 0x00001A24
		internal virtual SuperTabItem SuperTabItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SuperTabItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SuperTabItem3 = value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x00076E98 File Offset: 0x00075098
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x0000382E File Offset: 0x00001A2E
		internal virtual GridEX GridEslah
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEslah;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEslah = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00076EB0 File Offset: 0x000750B0
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00003838 File Offset: 0x00001A38
		public List<TableItemChange> TableItems
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableItems;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TableItems = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00076EC8 File Offset: 0x000750C8
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00003842 File Offset: 0x00001A42
		public List<string> ExtColumnNames
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExtColumnNames;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ExtColumnNames = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x00076EE0 File Offset: 0x000750E0
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x0000384C File Offset: 0x00001A4C
		public string TableName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TableName = value;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x00076EF8 File Offset: 0x000750F8
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00003856 File Offset: 0x00001A56
		public string Pkey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pkey;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pkey = value;
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00076F10 File Offset: 0x00075110
		private void frm_historyLog_Load(object sender, EventArgs e)
		{
			DataTable dataSource = Public_Function.FillData("SELECT   ID,  HistoryLog.TableName, HistoryLog.UserName, HistoryLog.Tarikh, HistoryLog.Saat  FROM         HistoryLog  where TableName=" + Public_Function.GetValue(this.TableName) + " and pkey=" + Public_Function.GetValue(this.Pkey));
			this.GridEX2.DataSource = dataSource;
			int arg_49_0 = 0;
			checked
			{
				int num = this.ExtColumnNames.Count - 1;
				int num2 = arg_49_0;
				while (true)
				{
					int arg_BF_0 = num2;
					int num3 = num;
					if (arg_BF_0 > num3)
					{
						break;
					}
					this.GridDelete.RootTable.Columns["Ext" + Conversions.ToString(num2 + 1)].Visible = true;
					this.GridDelete.RootTable.Columns["Ext" + Conversions.ToString(num2 + 1)].Caption = this.ExtColumnNames[num2];
					num2++;
				}
				try
				{
					List<TableItemChange>.Enumerator enumerator = this.TableItems.GetEnumerator();
					while (enumerator.MoveNext())
					{
						TableItemChange current = enumerator.Current;
						GridEXColumn gridEXColumn = new GridEXColumn();
						gridEXColumn.BoundMode = ColumnBoundMode.Unbound;
						gridEXColumn.DataMember = current.column;
						gridEXColumn.Key = current.column;
						gridEXColumn.Caption = current.caption;
						this.GridDelete.RootTable.Columns.Add(gridEXColumn);
					}
				}
				finally
				{
					List<TableItemChange>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00077074 File Offset: 0x00075274
		private void GridEX2_SelectionChanged(object sender, EventArgs e)
		{
			long value = Conversions.ToLong(this.GridEX2.CurrentRow.Cells["ID"].Value);
			DataTable dataTable = Public_Function.FillData("select * from HistoryLog_Detail where HistoryLog_ID=" + Conversions.ToString(value) + " and opr_id=1");
			this.GridEslah.DataSource = dataTable;
			this.SuperTabStrip1.Tabs[0].Text = "اصلاح  - " + Conversions.ToString(dataTable.Rows.Count);
			int arg_8F_0 = 0;
			checked
			{
				int num = this.ExtColumnNames.Count - 1;
				int num2 = arg_8F_0;
				while (true)
				{
					int arg_10C_0 = num2;
					int num3 = num;
					if (arg_10C_0 > num3)
					{
						break;
					}
					this.GridEslah.RootTable.Columns["Ext" + Conversions.ToString(num2 + 1)].Visible = true;
					this.GridEslah.RootTable.Columns["Ext" + Conversions.ToString(num2 + 1)].Caption = this.ExtColumnNames[num2];
					num2++;
				}
				DataTable dataTable2 = Public_Function.FillData("select * from HistoryLog_Detail where HistoryLog_ID=" + Conversions.ToString(value) + " and opr_id=3");
				this.GridDelete.DataSource = dataTable2;
				this.SuperTabStrip1.Tabs[2].Text = "حذف  - " + Conversions.ToString(dataTable2.Rows.Count);
				int arg_179_0 = 0;
				int num4 = dataTable2.Rows.Count - 1;
				int num5 = arg_179_0;
				while (true)
				{
					int arg_273_0 = num5;
					int num3 = num4;
					if (arg_273_0 > num3)
					{
						break;
					}
					string[] array = dataTable2.Rows[num5]["FromValue"].ToString().Split(new char[]
					{
						';'
					});
					int num6 = 0;
					this.GridDelete.GetRow(num5).BeginEdit();
					try
					{
						List<TableItemChange>.Enumerator enumerator = this.TableItems.GetEnumerator();
						while (enumerator.MoveNext())
						{
							TableItemChange current = enumerator.Current;
							this.GridDelete.GetRow(num5).Cells["Ext1"].Text = array[num6];
							this.GridDelete.GetRow(num5).Cells["Ext2"].Value = array[num6];
							num6++;
						}
					}
					finally
					{
						List<TableItemChange>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					this.GridDelete.GetRow(num5).EndEdit();
					num5++;
				}
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0007730C File Offset: 0x0007550C
		private void SuperTabStrip1_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
		{
			switch (this.SuperTabStrip1.SelectedTabIndex)
			{
			case 0:
				this.GridDelete.Visible = false;
				this.GridEslah.Visible = true;
				break;
			case 1:
				this.GridEslah.Visible = false;
				this.GridDelete.Visible = false;
				break;
			case 2:
				this.GridEslah.Visible = false;
				this.GridDelete.Visible = true;
				this.GridDelete.BringToFront();
				break;
			}
		}

		// Token: 0x04000342 RID: 834
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000344 RID: 836
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x04000345 RID: 837
		[AccessedThroughProperty("GridDelete")]
		private GridEX _GridDelete;

		// Token: 0x04000346 RID: 838
		[AccessedThroughProperty("GridEX4")]
		private GridEX _GridEX4;

		// Token: 0x04000347 RID: 839
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000348 RID: 840
		[AccessedThroughProperty("SuperTabStrip1")]
		private SuperTabStrip _SuperTabStrip1;

		// Token: 0x04000349 RID: 841
		[AccessedThroughProperty("SuperTabItem1")]
		private SuperTabItem _SuperTabItem1;

		// Token: 0x0400034A RID: 842
		[AccessedThroughProperty("SuperTabItem2")]
		private SuperTabItem _SuperTabItem2;

		// Token: 0x0400034B RID: 843
		[AccessedThroughProperty("SuperTabItem3")]
		private SuperTabItem _SuperTabItem3;

		// Token: 0x0400034C RID: 844
		[AccessedThroughProperty("GridEslah")]
		private GridEX _GridEslah;

		// Token: 0x0400034D RID: 845
		[CompilerGenerated]
		private List<TableItemChange> _TableItems;

		// Token: 0x0400034E RID: 846
		[CompilerGenerated]
		private List<string> _ExtColumnNames;

		// Token: 0x0400034F RID: 847
		[CompilerGenerated]
		private string _TableName;

		// Token: 0x04000350 RID: 848
		[CompilerGenerated]
		private string _Pkey;
	}
}
