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
	// Token: 0x020000D4 RID: 212
	[DesignerGenerated]
	public partial class Frm_Note : Form
	{
		// Token: 0x060012AC RID: 4780 RVA: 0x000C8EF8 File Offset: 0x000C70F8
		public Frm_Note()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Note.__ENCAddToList(this);
			this.note = new Note();
			this.InitializeComponent();
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000C8F50 File Offset: 0x000C7150
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Note.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Note.__ENCList.Count == Frm_Note.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Note.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Note.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Note.__ENCList[num] = Frm_Note.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Note.__ENCList.RemoveRange(num, Frm_Note.__ENCList.Count - num);
						Frm_Note.__ENCList.Capacity = Frm_Note.__ENCList.Count;
					}
					Frm_Note.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000C982C File Offset: 0x000C7A2C
		// (set) Token: 0x060012B1 RID: 4785 RVA: 0x00006192 File Offset: 0x00004392
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

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x060012B2 RID: 4786 RVA: 0x000C9844 File Offset: 0x000C7A44
		// (set) Token: 0x060012B3 RID: 4787 RVA: 0x000C985C File Offset: 0x000C7A5C
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

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000C98E4 File Offset: 0x000C7AE4
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x0000619C File Offset: 0x0000439C
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

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000C98FC File Offset: 0x000C7AFC
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x000061A6 File Offset: 0x000043A6
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

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000C9914 File Offset: 0x000C7B14
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000061B0 File Offset: 0x000043B0
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

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000C992C File Offset: 0x000C7B2C
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x000C9944 File Offset: 0x000C7B44
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

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000C99A4 File Offset: 0x000C7BA4
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x000C99BC File Offset: 0x000C7BBC
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

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000C9A1C File Offset: 0x000C7C1C
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x000C9A34 File Offset: 0x000C7C34
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

		// Token: 0x060012C0 RID: 4800 RVA: 0x000C9A94 File Offset: 0x000C7C94
		private void GetData()
		{
			DataTable all = this.note.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000061BA File Offset: 0x000043BA
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Text"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000061E3 File Offset: 0x000043E3
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Text"]);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000C9ABC File Offset: 0x000C7CBC
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x000C9AF8 File Offset: 0x000C7CF8
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00006203 File Offset: 0x00004403
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x000C9B50 File Offset: 0x000C7D50
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Note", "Text", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.note.Insert(this.txt_name.Text);
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
						flag2 = Public_Function.ExistValue("Note", "Text", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.note.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x000C9C88 File Offset: 0x000C7E88
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.note.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x000C9D18 File Offset: 0x000C7F18
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

		// Token: 0x060012C9 RID: 4809 RVA: 0x000C9DB0 File Offset: 0x000C7FB0
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00006226 File Offset: 0x00004426
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x000C9DF0 File Offset: 0x000C7FF0
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

		// Token: 0x04000735 RID: 1845
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000737 RID: 1847
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000738 RID: 1848
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000739 RID: 1849
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x0400073A RID: 1850
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400073B RID: 1851
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400073C RID: 1852
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400073D RID: 1853
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400073E RID: 1854
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400073F RID: 1855
		private Note note;

		// Token: 0x04000740 RID: 1856
		private bool isnew;
	}
}
