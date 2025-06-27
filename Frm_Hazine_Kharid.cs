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
	// Token: 0x020000CC RID: 204
	[DesignerGenerated]
	public partial class Frm_Hazine_Kharid : Form
	{
		// Token: 0x06001126 RID: 4390 RVA: 0x000BB94C File Offset: 0x000B9B4C
		public Frm_Hazine_Kharid()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Hazine_Kharid_FormClosing);
			Frm_Hazine_Kharid.__ENCAddToList(this);
			this.Hazine = new Hazine_Kharid();
			this.InitializeComponent();
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000BB9B8 File Offset: 0x000B9BB8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Hazine_Kharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Hazine_Kharid.__ENCList.Count == Frm_Hazine_Kharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Hazine_Kharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Hazine_Kharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Hazine_Kharid.__ENCList[num] = Frm_Hazine_Kharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Hazine_Kharid.__ENCList.RemoveRange(num, Frm_Hazine_Kharid.__ENCList.Count - num);
						Frm_Hazine_Kharid.__ENCList.Capacity = Frm_Hazine_Kharid.__ENCList.Count;
					}
					Frm_Hazine_Kharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x000BC460 File Offset: 0x000BA660
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00005BDC File Offset: 0x00003DDC
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x000BC478 File Offset: 0x000BA678
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x000BC490 File Offset: 0x000BA690
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
				RowActionEventHandler value3 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.SelectionChanged -= value2;
					this._GridEX1.RowDoubleClick -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.SelectionChanged += value2;
					this._GridEX1.RowDoubleClick += value3;
				}
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x000BC518 File Offset: 0x000BA718
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x00005BE6 File Offset: 0x00003DE6
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

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x000BC530 File Offset: 0x000BA730
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00005BF0 File Offset: 0x00003DF0
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

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x000BC548 File Offset: 0x000BA748
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00005BFA File Offset: 0x00003DFA
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

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x000BC560 File Offset: 0x000BA760
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x000BC578 File Offset: 0x000BA778
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x000BC5F0 File Offset: 0x000BA7F0
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

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x000BC650 File Offset: 0x000BA850
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x000BC668 File Offset: 0x000BA868
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x000BC6C8 File Offset: 0x000BA8C8
		// (set) Token: 0x0600113B RID: 4411 RVA: 0x000BC6E0 File Offset: 0x000BA8E0
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

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x000BC740 File Offset: 0x000BA940
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x000BC758 File Offset: 0x000BA958
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

		// Token: 0x0600113E RID: 4414 RVA: 0x000BC7B8 File Offset: 0x000BA9B8
		private void GetData()
		{
			DataTable all = this.Hazine.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00005C04 File Offset: 0x00003E04
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00005C2D File Offset: 0x00003E2D
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000BC7E0 File Offset: 0x000BA9E0
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x000BC81C File Offset: 0x000BAA1C
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00005C4D File Offset: 0x00003E4D
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x000BC874 File Offset: 0x000BAA74
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				string empty = string.Empty;
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Hazine_Kharid", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.Hazine.Insert(this.txt_name.Text);
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
						flag2 = Public_Function.ExistValue("Hazine_kharid", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.Hazine.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000BC9B4 File Offset: 0x000BABB4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.Hazine.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000BCA44 File Offset: 0x000BAC44
		private void Frm_Hazine_Kharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			string text = string.Empty;
			int num = 1;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update hazine_kharid set code=" + Conversions.ToString(num) + " where id=", gridEXRow.Cells["ID"].Value), ";")));
					num++;
				}
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x000BCAD8 File Offset: 0x000BACD8
		private void Frm_Anbar_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Insert;
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			else
			{
				flag = (keyCode == Keys.F2);
				if (flag)
				{
					this.ButtonItem2_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F5);
					if (flag)
					{
						this.ButtonItem3_Click(null, null);
					}
					else
					{
						flag = (keyCode == Keys.Escape);
						if (flag)
						{
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x000BCB40 File Offset: 0x000BAD40
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00005C70 File Offset: 0x00003E70
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x000BCB80 File Offset: 0x000BAD80
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

		// Token: 0x0600114B RID: 4427 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		private void UiButton3_Click(object sender, EventArgs e)
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

		// Token: 0x0600114C RID: 4428 RVA: 0x000BCCEC File Offset: 0x000BAEEC
		private void UiButton4_Click(object sender, EventArgs e)
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

		// Token: 0x04000694 RID: 1684
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000696 RID: 1686
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000697 RID: 1687
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000698 RID: 1688
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x04000699 RID: 1689
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400069A RID: 1690
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400069B RID: 1691
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400069C RID: 1692
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400069D RID: 1693
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400069E RID: 1694
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x0400069F RID: 1695
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040006A0 RID: 1696
		private Hazine_Kharid Hazine;

		// Token: 0x040006A1 RID: 1697
		private bool isnew;
	}
}
