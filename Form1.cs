using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.CommandBars;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000BD RID: 189
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x06000EEE RID: 3822 RVA: 0x000AA624 File Offset: 0x000A8824
		public Form1()
		{
			base.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
			base.Load += new EventHandler(this.Form1_Load);
			Form1.__ENCAddToList(this);
			Grid_SelectItem selectItem = new Grid_SelectItem();
			this.SelectItem = selectItem;
			this.InitializeComponent();
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x000AA680 File Offset: 0x000A8880
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Form1.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Form1.__ENCList.Count == Form1.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Form1.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Form1.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Form1.__ENCList[num] = Form1.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num);
						Form1.__ENCList.Capacity = Form1.__ENCList.Count;
					}
					Form1.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x000AAB6C File Offset: 0x000A8D6C
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x00005428 File Offset: 0x00003628
		internal virtual MetroTileItem MetroTileItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetroTileItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetroTileItem4 = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x000AAB84 File Offset: 0x000A8D84
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x000AAB9C File Offset: 0x000A8D9C
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyUp);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyUp -= value2;
					this._GridEX1.KeyDown -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyUp += value2;
					this._GridEX1.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x000AAC24 File Offset: 0x000A8E24
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x00005432 File Offset: 0x00003632
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000AAC3C File Offset: 0x000A8E3C
		// (set) Token: 0x06000EF9 RID: 3833 RVA: 0x0000543C File Offset: 0x0000363C
		public Grid_SelectItem SelectItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SelectItem = value;
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x0000205D File Offset: 0x0000025D
		private void UiCommandBar1_CommandClick(object sender, CommandEventArgs e)
		{
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x000AAC54 File Offset: 0x000A8E54
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				bool visible = this.SelectItem.Visible;
				if (visible)
				{
					this.SelectItem.Visible = false;
				}
				else
				{
					this.Close();
				}
			}
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x000AAC9C File Offset: 0x000A8E9C
		private void Form1_Load(object sender, EventArgs e)
		{
			Furush_Hag furush_Hag = new Furush_Hag();
			DataTable detailByID = furush_Hag.GetDetailByID(149L);
			this.GridEX1.DataSource = detailByID;
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Code", "کد", 15));
			itemCollection.Add(new Column("name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.SelectItem.items = itemCollection;
			this.Controls.Add(this.SelectItem);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x000AAD38 File Offset: 0x000A8F38
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Down;
			if (flag)
			{
				bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position;
				if (flag2)
				{
					bool visible = this.SelectItem.Visible;
					if (visible)
					{
						this.SelectItem.GridEx1.Focus();
						e.SuppressKeyPress = true;
					}
				}
			}
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000AADB4 File Offset: 0x000A8FB4
		private void GridEX1_KeyUp(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
					if (flag)
					{
						bool flag2 = this.GridEX1.EditTextBox != null;
						if (flag2)
						{
							bool flag3 = Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) != 0;
							if (flag3)
							{
								bool flag4 = Operators.CompareString(this.GridEX1.CurrentRow.Cells["moshtari_name"].Value.ToString(), this.GridEX1.EditTextBox.Text, false) != 0;
								if (flag4)
								{
									Rectangle cellBounds = this.GridEX1.GetCellBounds(this.GridEX1.Row, this.GridEX1.RootTable.Columns["moshtari_name"].Position);
									Rectangle bounds = this.GridEX1.Bounds;
									bounds.Location = this.GridEX1.Parent.PointToScreen(bounds.Location);
									this.SelectItem.Left = cellBounds.Left - this.SelectItem.Width + cellBounds.Width;
									this.SelectItem.Top = cellBounds.Top + cellBounds.Height;
									this.SelectItem.Show();
									this.SelectItem.BringToFront();
									this.SelectItem.RowFilter(this.GridEX1.EditTextBox.Text);
								}
								else
								{
									this.SelectItem.Hide();
								}
							}
							else
							{
								this.SelectItem.Hide();
							}
						}
					}
				}
			}
		}

		// Token: 0x040005C9 RID: 1481
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005CB RID: 1483
		[AccessedThroughProperty("MetroTileItem4")]
		private MetroTileItem _MetroTileItem4;

		// Token: 0x040005CC RID: 1484
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040005CD RID: 1485
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040005CE RID: 1486
		[CompilerGenerated]
		private Grid_SelectItem _SelectItem;
	}
}
