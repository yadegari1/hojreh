using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000080 RID: 128
	[DesignerGenerated]
	public partial class Frm_Sortdp : Form
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x000043FA File Offset: 0x000025FA
		[DebuggerNonUserCode]
		public Frm_Sortdp()
		{
			base.Load += new EventHandler(this.Frm_SortMenu_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SortMenu_KeyDown);
			Frm_Sortdp.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x0008CB10 File Offset: 0x0008AD10
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sortdp.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sortdp.__ENCList.Count == Frm_Sortdp.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sortdp.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sortdp.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sortdp.__ENCList[num] = Frm_Sortdp.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sortdp.__ENCList.RemoveRange(num, Frm_Sortdp.__ENCList.Count - num);
						Frm_Sortdp.__ENCList.Capacity = Frm_Sortdp.__ENCList.Count;
					}
					Frm_Sortdp.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0008D940 File Offset: 0x0008BB40
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0000443A File Offset: 0x0000263A
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiComboBox1 = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0008D958 File Offset: 0x0008BB58
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00004444 File Offset: 0x00002644
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

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0008D970 File Offset: 0x0008BB70
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0008D988 File Offset: 0x0008BB88
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0008D9E8 File Offset: 0x0008BBE8
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0008DA00 File Offset: 0x0008BC00
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0008DA60 File Offset: 0x0008BC60
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x0000444E File Offset: 0x0000264E
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

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x0008DA78 File Offset: 0x0008BC78
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x00004458 File Offset: 0x00002658
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
				this._ButtonItem1 = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x0008DA90 File Offset: 0x0008BC90
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x0008DAA8 File Offset: 0x0008BCA8
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

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0008DB08 File Offset: 0x0008BD08
		// (set) Token: 0x06000B3A RID: 2874 RVA: 0x0008DB20 File Offset: 0x0008BD20
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

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0008DB80 File Offset: 0x0008BD80
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x0008DB98 File Offset: 0x0008BD98
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
				EventHandler value2 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.SelectionChanged -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.SelectionChanged += value2;
				}
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0008DBF8 File Offset: 0x0008BDF8
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00004462 File Offset: 0x00002662
		internal virtual DataEntryGrid GridEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx2 = value;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0008DC10 File Offset: 0x0008BE10
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0008DC28 File Offset: 0x0008BE28
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0008DC88 File Offset: 0x0008BE88
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0008DCA0 File Offset: 0x0008BEA0
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0008DD00 File Offset: 0x0008BF00
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0000446C File Offset: 0x0000266C
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SortMenu_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x0008DD18 File Offset: 0x0008BF18
		private void Frm_SortMenu_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			DataTable dataSource = Public_Function.FillData("select id,name,code,visible from dptype where type=1 and id in (4,27,3,25,8,6,28,40,33,34,36,41) order by code");
			this.GridEX1.DataSource = dataSource;
			DataTable dataSource2 = Public_Function.FillData("select id,name,code,visible from dptype where type=2 and id in (13,15,29,14,17,19,21,31,37,38,39) order by code");
			this.GridEx2.DataSource = dataSource2;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["visible"], 0, false);
					if (flag)
					{
						gridEXRow.IsChecked = false;
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["visible"], 1, false);
						if (flag)
						{
							gridEXRow.IsChecked = true;
						}
					}
				}
				GridEXRow[] rows2 = this.GridEx2.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					bool flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow2.DataRow)["visible"], 0, false);
					if (flag)
					{
						gridEXRow2.IsChecked = false;
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow2.DataRow)["visible"], 1, false);
						if (flag)
						{
							gridEXRow2.IsChecked = true;
						}
					}
				}
			}
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0008DE98 File Offset: 0x0008C098
		private void Delmenus(string menu, DataTable dt)
		{
			bool flag = false;
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag2 = baseItem is ButtonItem;
					if (flag2)
					{
						bool flag3 = Operators.CompareString(baseItem.Text, menu, false) == 0;
						if (flag3)
						{
							try
							{
								IEnumerator enumerator2 = dt.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator2.Current;
									flag = false;
									try
									{
										IEnumerator enumerator3 = baseItem.SubItems.GetEnumerator();
										while (enumerator3.MoveNext())
										{
											BaseItem baseItem2 = (BaseItem)enumerator3.Current;
											flag3 = Operators.ConditionalCompareObjectEqual(baseItem2.Text, dataRow["name"], false);
											if (flag3)
											{
												flag = true;
											}
										}
									}
									finally
									{
										IEnumerator enumerator3;
										flag3 = (enumerator3 is IDisposable);
										if (flag3)
										{
											(enumerator3 as IDisposable).Dispose();
										}
									}
									flag3 = !flag;
									if (flag3)
									{
										NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
										{
											Operators.ConcatenateObject("delete from menu_sort where id=", dataRow["ID"])
										}, null, null, null, true);
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

		// Token: 0x06000B48 RID: 2888 RVA: 0x0008E098 File Offset: 0x0008C298
		private void UiButton2_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEX1.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
					flag = (position < this.GridEX1.RowCount - 1);
					if (flag)
					{
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEX1.DataSource).Rows.InsertAt(dataRow, position + 1);
						this.GridEX1.Row = position + 1;
					}
				}
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x0008E1C0 File Offset: 0x0008C3C0
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEX1.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
					flag = (position > 0);
					if (flag)
					{
						this.GridEX1.CurrentRow.Delete();
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEX1.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEX1.DataSource).Rows.InsertAt(dataRow, position - 1);
						this.GridEX1.Row = position - 1;
					}
				}
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0008E2DC File Offset: 0x0008C4DC
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_MainSortMenu frm_MainSortMenu = new Frm_MainSortMenu();
			frm_MainSortMenu.ShowDialog();
			this.UiComboBox1.Items.Clear();
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					BaseItem baseItem = (BaseItem)enumerator.Current;
					bool flag = baseItem is ButtonItem;
					if (flag)
					{
						this.UiComboBox1.Items.Add(baseItem.Text);
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

		// Token: 0x06000B4B RID: 2891 RVA: 0x0008E394 File Offset: 0x0008C594
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			int num = 1;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update dptype set [code] =" + Conversions.ToString(num) + ",visible=" + Public_Function.GetValueInt(Conversions.ToString(gridEXRow.IsChecked)) + " where id=", gridEXRow.Cells["ID"].Value), ";")));
					num++;
				}
				num = 1;
				GridEXRow[] rows2 = this.GridEx2.GetRows();
				for (int j = 0; j < rows2.Length; j++)
				{
					GridEXRow gridEXRow2 = rows2[j];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update dptype set [code] =" + Conversions.ToString(num) + ",visible=" + Public_Function.GetValueInt(Conversions.ToString(gridEXRow2.IsChecked)) + " where id=", gridEXRow2.Cells["ID"].Value), ";")));
					num++;
				}
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ShowMessage("اطلاعات با موفقیت ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0008E500 File Offset: 0x0008C700
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (flag)
			{
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0008E528 File Offset: 0x0008C728
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEx2.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEx2.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEx2.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEx2.CurrentRow.Cells["ID"].Value);
					flag = (position > 0);
					if (flag)
					{
						this.GridEx2.CurrentRow.Delete();
						((DataTable)this.GridEx2.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEx2.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEx2.DataSource).Rows.InsertAt(dataRow, position - 1);
						this.GridEx2.Row = position - 1;
					}
				}
			}
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x0008E644 File Offset: 0x0008C844
		private void UiButton4_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEx2.CurrentRow == null;
			checked
			{
				if (!flag)
				{
					int position = this.GridEx2.CurrentRow.Position;
					string value = Conversions.ToString(this.GridEx2.CurrentRow.Cells["Name"].Value);
					int num = Conversions.ToInteger(this.GridEx2.CurrentRow.Cells["ID"].Value);
					flag = (position < this.GridEx2.RowCount - 1);
					if (flag)
					{
						this.GridEx2.CurrentRow.Delete();
						((DataTable)this.GridEx2.DataSource).AcceptChanges();
						DataRow dataRow = ((DataTable)this.GridEx2.DataSource).NewRow();
						dataRow["Name"] = value;
						dataRow["ID"] = num;
						((DataTable)this.GridEx2.DataSource).Rows.InsertAt(dataRow, position + 1);
						this.GridEx2.Row = position + 1;
					}
				}
			}
		}

		// Token: 0x04000469 RID: 1129
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400046B RID: 1131
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x0400046C RID: 1132
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400046D RID: 1133
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400046E RID: 1134
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400046F RID: 1135
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000470 RID: 1136
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000471 RID: 1137
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000472 RID: 1138
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000473 RID: 1139
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000474 RID: 1140
		[AccessedThroughProperty("GridEx2")]
		private DataEntryGrid _GridEx2;

		// Token: 0x04000475 RID: 1141
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x04000476 RID: 1142
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000477 RID: 1143
		[AccessedThroughProperty("Label1")]
		private Label _Label1;
	}
}
