using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D7 RID: 215
	[DesignerGenerated]
	public partial class Frm_Sarbarg : Form
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x000CD1E8 File Offset: 0x000CB3E8
		public Frm_Sarbarg()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Sarbarg.__ENCAddToList(this);
			this.sarbarg = new Sarbarg();
			this.InitializeComponent();
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000CD240 File Offset: 0x000CB440
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sarbarg.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sarbarg.__ENCList.Count == Frm_Sarbarg.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sarbarg.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sarbarg.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sarbarg.__ENCList[num] = Frm_Sarbarg.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sarbarg.__ENCList.RemoveRange(num, Frm_Sarbarg.__ENCList.Count - num);
						Frm_Sarbarg.__ENCList.Capacity = Frm_Sarbarg.__ENCList.Count;
					}
					Frm_Sarbarg.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000CDB1C File Offset: 0x000CBD1C
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000063B6 File Offset: 0x000045B6
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

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000CDB34 File Offset: 0x000CBD34
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000CDB4C File Offset: 0x000CBD4C
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				EventHandler value3 = new EventHandler(this.GridEX1_SelectionChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.SelectionChanged -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.SelectionChanged += value3;
				}
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000CDBD4 File Offset: 0x000CBDD4
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000063C0 File Offset: 0x000045C0
		internal virtual EditBox txt_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_name = value;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000CDBEC File Offset: 0x000CBDEC
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000063CA File Offset: 0x000045CA
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

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x000CDC04 File Offset: 0x000CBE04
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x000063D4 File Offset: 0x000045D4
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

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x000CDC1C File Offset: 0x000CBE1C
		// (set) Token: 0x0600133A RID: 4922 RVA: 0x000CDC34 File Offset: 0x000CBE34
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
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600133B RID: 4923 RVA: 0x000CDC94 File Offset: 0x000CBE94
		// (set) Token: 0x0600133C RID: 4924 RVA: 0x000CDCAC File Offset: 0x000CBEAC
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

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600133D RID: 4925 RVA: 0x000CDD0C File Offset: 0x000CBF0C
		// (set) Token: 0x0600133E RID: 4926 RVA: 0x000CDD24 File Offset: 0x000CBF24
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

		// Token: 0x0600133F RID: 4927 RVA: 0x000CDD84 File Offset: 0x000CBF84
		private void GetData()
		{
			DataTable all = this.sarbarg.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x000063DE File Offset: 0x000045DE
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00006407 File Offset: 0x00004607
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x000CDDAC File Offset: 0x000CBFAC
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x000CDDE8 File Offset: 0x000CBFE8
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00006427 File Offset: 0x00004627
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000CDE40 File Offset: 0x000CC040
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Bank", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.sarbarg.Insert(this.txt_name.Text);
						this.InsertDatarow(num);
						Public_Function.ConfirmInsert();
						this.ButtonItem1_Click(null, null);
					}
				}
				else
				{
					bool flag2 = Public_Function.ConfirmUpdate() == DialogResult.Yes;
					if (flag2)
					{
						long num = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["id"]);
						flag2 = Public_Function.ExistValue("sarbarg", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.sarbarg.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000CDF78 File Offset: 0x000CC178
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.sarbarg.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x000CE008 File Offset: 0x000CC208
		private void Frm_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Insert;
			if (flag)
			{
				bool flag2 = this.ButtonItem1.Visible;
				if (flag2)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.F2;
				if (flag2)
				{
					flag = this.ButtonItem2.Visible;
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F5);
					if (flag2)
					{
						flag = this.ButtonItem3.Visible;
						if (flag)
						{
							this.ButtonItem3_Click(null, null);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.Escape);
						if (flag2)
						{
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x000CE0A0 File Offset: 0x000CC2A0
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0000644A File Offset: 0x0000464A
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x000CE0E0 File Offset: 0x000CC2E0
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
				this.isnew = false;
				this.LoadDatarow(row);
			}
		}

		// Token: 0x0400076B RID: 1899
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400076D RID: 1901
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400076E RID: 1902
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400076F RID: 1903
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x04000770 RID: 1904
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000771 RID: 1905
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000772 RID: 1906
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000773 RID: 1907
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000774 RID: 1908
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000775 RID: 1909
		private Sarbarg sarbarg;

		// Token: 0x04000776 RID: 1910
		private bool isnew;
	}
}
