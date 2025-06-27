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
using Janus.Windows.ButtonBar;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200006E RID: 110
	[DesignerGenerated]
	public partial class Frm_MainSortMenu : Form
	{
		// Token: 0x0600087E RID: 2174 RVA: 0x000773A0 File Offset: 0x000755A0
		[DebuggerNonUserCode]
		public Frm_MainSortMenu()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_MainSortMenu_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_MainSortMenu_KeyDown);
			base.Load += new EventHandler(this.Frm_SortMenu_Load);
			Frm_MainSortMenu.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00077400 File Offset: 0x00075600
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_MainSortMenu.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_MainSortMenu.__ENCList.Count == Frm_MainSortMenu.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_MainSortMenu.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_MainSortMenu.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_MainSortMenu.__ENCList[num] = Frm_MainSortMenu.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_MainSortMenu.__ENCList.RemoveRange(num, Frm_MainSortMenu.__ENCList.Count - num);
						Frm_MainSortMenu.__ENCList.Capacity = Frm_MainSortMenu.__ENCList.Count;
					}
					Frm_MainSortMenu.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00077A98 File Offset: 0x00075C98
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0000386D File Offset: 0x00001A6D
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

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00077AB0 File Offset: 0x00075CB0
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00077AC8 File Offset: 0x00075CC8
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

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00077B28 File Offset: 0x00075D28
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00077B40 File Offset: 0x00075D40
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

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00077BA0 File Offset: 0x00075DA0
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00003877 File Offset: 0x00001A77
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00077BB8 File Offset: 0x00075DB8
		private void Frm_MainSortMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			string text = string.Empty;
			int num = 0;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update menu_sort set [order] =" + Conversions.ToString(num) + " where id=", gridEXRow.Cells["ID"].Value), ";")));
					num++;
				}
				Public_Function.ExecuteNonQuery(text);
				MyProject.Forms.Form_Main.Load_Root_Menu();
			}
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_MainSortMenu_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00077C5C File Offset: 0x00075E5C
		private void Frm_SortMenu_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			string empty = string.Empty;
			DataTable dataTable = Public_Function.FillData("select * from Menu_Sort where Parent_ID is NULL order by [order]");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = false;
					bool flag3;
					try
					{
						IEnumerator enumerator2 = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							BaseItem baseItem = (BaseItem)enumerator2.Current;
							bool flag2 = baseItem is ButtonItem;
							if (flag2)
							{
								flag3 = Operators.ConditionalCompareObjectEqual(baseItem.Text, dataRow["name"], false);
								if (flag3)
								{
									flag = true;
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
					flag3 = !flag;
					if (flag3)
					{
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject("delete from menu_sort where parent_id=", dataRow["ID"])
						}, null, null, null, true);
						NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
						{
							Operators.ConcatenateObject("delete from menu_sort where id=", dataRow["ID"])
						}, null, null, null, true);
						dataTable = Public_Function.FillData("select * from Menu_Sort where Parent_ID is NULL order by [order]");
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
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00077E64 File Offset: 0x00076064
		private void GetItems(string Menu)
		{
			try
			{
				IEnumerator enumerator = MyProject.Forms.Form_Main.Bar1.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ButtonItem buttonItem = (ButtonItem)enumerator.Current;
					bool flag = Operators.CompareString(buttonItem.Text, Menu, false) == 0;
					if (flag)
					{
						try
						{
							IEnumerator enumerator2 = buttonItem.SubItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								BaseItem baseItem = (BaseItem)enumerator2.Current;
								bool flag2 = baseItem is ButtonItem;
								if (flag2)
								{
									bool flag3 = !baseItem.Visible;
									if (!flag3)
									{
										ButtonBarItem buttonBarItem = new ButtonBarItem();
										buttonBarItem.TextAlignment = Alignment.Far;
										buttonBarItem.Text = baseItem.Text;
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator2;
							bool flag3 = enumerator2 is IDisposable;
							if (flag3)
							{
								(enumerator2 as IDisposable).Dispose();
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

		// Token: 0x0600088E RID: 2190 RVA: 0x0000205D File Offset: 0x0000025D
		private void UiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00077F98 File Offset: 0x00076198
		private void UiButton2_Click(object sender, EventArgs e)
		{
			int position = this.GridEX1.CurrentRow.Position;
			string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
			int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
			checked
			{
				bool flag = position < this.GridEX1.RowCount - 1;
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

		// Token: 0x06000890 RID: 2192 RVA: 0x000780A8 File Offset: 0x000762A8
		private void UiButton1_Click(object sender, EventArgs e)
		{
			int position = this.GridEX1.CurrentRow.Position;
			string value = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Name"].Value);
			int num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["ID"].Value);
			bool flag = position > 0;
			checked
			{
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

		// Token: 0x04000351 RID: 849
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000353 RID: 851
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000354 RID: 852
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000355 RID: 853
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000356 RID: 854
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;
	}
}
