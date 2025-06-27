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
	// Token: 0x020000C2 RID: 194
	[DesignerGenerated]
	public partial class Frm_Bank : Form
	{
		// Token: 0x06000F89 RID: 3977 RVA: 0x000ACD68 File Offset: 0x000AAF68
		public Frm_Bank()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Bank.__ENCAddToList(this);
			this.Bank = new Bank();
			this.InitializeComponent();
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000ACDC0 File Offset: 0x000AAFC0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Bank.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Bank.__ENCList.Count == Frm_Bank.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Bank.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Bank.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Bank.__ENCList[num] = Frm_Bank.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Bank.__ENCList.RemoveRange(num, Frm_Bank.__ENCList.Count - num);
						Frm_Bank.__ENCList.Capacity = Frm_Bank.__ENCList.Count;
					}
					Frm_Bank.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x000AD69C File Offset: 0x000AB89C
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x000054D0 File Offset: 0x000036D0
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

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x000AD6B4 File Offset: 0x000AB8B4
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x000AD6CC File Offset: 0x000AB8CC
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

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x000AD754 File Offset: 0x000AB954
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x000054DA File Offset: 0x000036DA
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

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x000AD76C File Offset: 0x000AB96C
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x000054E4 File Offset: 0x000036E4
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x000AD784 File Offset: 0x000AB984
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x000054EE File Offset: 0x000036EE
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x000AD79C File Offset: 0x000AB99C
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x000AD7B4 File Offset: 0x000AB9B4
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x000AD814 File Offset: 0x000ABA14
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x000AD82C File Offset: 0x000ABA2C
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

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x000AD88C File Offset: 0x000ABA8C
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
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

		// Token: 0x06000F9D RID: 3997 RVA: 0x000AD904 File Offset: 0x000ABB04
		private void GetData()
		{
			DataTable all = this.Bank.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000054F8 File Offset: 0x000036F8
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00005521 File Offset: 0x00003721
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x000AD92C File Offset: 0x000ABB2C
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x000AD968 File Offset: 0x000ABB68
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00005541 File Offset: 0x00003741
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000AD9C0 File Offset: 0x000ABBC0
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
						long num = this.Bank.Insert(this.txt_name.Text);
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
						flag2 = Public_Function.ExistValue("Bank", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.Bank.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000ADAF8 File Offset: 0x000ABCF8
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.Bank.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000ADB88 File Offset: 0x000ABD88
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

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000ADC20 File Offset: 0x000ABE20
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00005564 File Offset: 0x00003764
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000ADC60 File Offset: 0x000ABE60
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

		// Token: 0x040005D8 RID: 1496
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005DA RID: 1498
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040005DB RID: 1499
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040005DC RID: 1500
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x040005DD RID: 1501
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040005DE RID: 1502
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040005DF RID: 1503
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040005E0 RID: 1504
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040005E1 RID: 1505
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040005E2 RID: 1506
		private Bank Bank;

		// Token: 0x040005E3 RID: 1507
		private bool isnew;
	}
}
