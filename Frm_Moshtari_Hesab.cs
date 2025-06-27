using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D2 RID: 210
	[DesignerGenerated]
	public partial class Frm_Moshtari_Hesab : Form
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x000C7160 File Offset: 0x000C5360
		public Frm_Moshtari_Hesab()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_Moshtari_Hesab_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Moshtari_Hesab_KeyDown);
			base.Load += new EventHandler(this.Frm_Moshtari_Hesab_Load);
			Frm_Moshtari_Hesab.__ENCAddToList(this);
			this.Hesab = new Moshtari_Hesab();
			this.frm = new Frm_SelectItem();
			this.InitializeComponent();
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x000C71D8 File Offset: 0x000C53D8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Moshtari_Hesab.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Moshtari_Hesab.__ENCList.Count == Frm_Moshtari_Hesab.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Moshtari_Hesab.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Moshtari_Hesab.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Moshtari_Hesab.__ENCList[num] = Frm_Moshtari_Hesab.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Moshtari_Hesab.__ENCList.RemoveRange(num, Frm_Moshtari_Hesab.__ENCList.Count - num);
						Frm_Moshtari_Hesab.__ENCList.Capacity = Frm_Moshtari_Hesab.__ENCList.Count;
					}
					Frm_Moshtari_Hesab.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x000C76BC File Offset: 0x000C58BC
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000C76D4 File Offset: 0x000C58D4
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
				EventHandler value3 = new EventHandler(this.GridEX1_RecordAdded);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.RecordAdded -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.KeyPress -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.RecordAdded += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.KeyPress += value5;
				}
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x000C77B0 File Offset: 0x000C59B0
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000060C0 File Offset: 0x000042C0
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
				this._UiButton1 = value;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x000C77C8 File Offset: 0x000C59C8
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x000060CA File Offset: 0x000042CA
		public string Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x000C77E0 File Offset: 0x000C59E0
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x000060D4 File Offset: 0x000042D4
		public DataTable dt_Hesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_Hesab;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_Hesab = value;
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000C77F8 File Offset: 0x000C59F8
		private void Bank_Select()
		{
			DataTable dt = Public_Function.FillData("select id,Name from Bank");
			bool flag = this.frm.ShowDialog(dt, null, "انتخاب بانک") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Bank_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000C78F0 File Offset: 0x000C5AF0
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Delete;
			if (flag)
			{
				bool flag2 = this.GridEX1.EditTextBox != null;
				if (flag2)
				{
					this.GridEX1.EditTextBox.Text = string.Empty;
				}
			}
			checked
			{
				bool flag2;
				switch (e.KeyData)
				{
				case Keys.Left:
				{
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
					e.SuppressKeyPress = true;
					return;
				}
				case Keys.Up:
					flag2 = (this.GridEX1.Row > 0);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Right:
					flag2 = (this.GridEX1.Col > 0);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col--;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				case Keys.Down:
					flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
					if (flag2)
					{
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Row++;
						e.SuppressKeyPress = true;
						return;
					}
					break;
				}
				flag2 = (e.KeyCode == Keys.Return);
				if (flag2)
				{
					int col = this.GridEX1.Col;
					flag = (col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
					if (flag)
					{
						bool flag3 = Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0;
						if (flag3)
						{
							this.Bank_Select();
						}
						else
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
						}
					}
					else
					{
						bool flag3 = col == this.GridEX1.RootTable.Columns["Saheb_Hesab"].Position;
						if (flag3)
						{
							flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1 && this.GridEX1.Row != -1);
							if (flag2)
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Row++;
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["Bank_Name"].Position;
							}
							else
							{
								this.GridEX1.UpdateData();
								this.GridEX1.MoveToNewRecord();
								this.GridEX1.Col = 0;
							}
						}
						else
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
						}
					}
				}
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x000C7BC4 File Offset: 0x000C5DC4
		private void Frm_Moshtari_Hesab_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.Save();
			if (flag)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Moshtari_Hesab_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000C7BEC File Offset: 0x000C5DEC
		private void Frm_Moshtari_Hesab_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			bool flag = Operators.CompareString(this.Moshtari_ID, string.Empty, false) == 0;
			if (flag)
			{
				this.Moshtari_ID = Conversions.ToString(0);
			}
			DataTable byID = this.Hesab.GetByID(this.Moshtari_ID);
			this.GridEX1.DataSource = byID;
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000C7C90 File Offset: 0x000C5E90
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "bank_name", false) == 0;
			if (flag)
			{
				this.Bank_Select();
			}
			else
			{
				flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
				if (flag)
				{
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x000C7CF8 File Offset: 0x000C5EF8
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				bool result;
				while (i <= dataTable.Rows.Count - 1)
				{
					bool flag = dataTable.Rows[i].RowState == DataRowState.Deleted;
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["Bank_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[i], "Bank_Name", "بانک را انتخاب فرمائید");
							result = false;
							return result;
						}
						i++;
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000C7DBC File Offset: 0x000C5FBC
		private bool Save()
		{
			bool flag = !this.ValidateGridData();
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				this.GridEX1.UpdateData();
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				dataTable.AcceptChanges();
				flag = (Operators.CompareString(this.Moshtari_ID, "0", false) != 0);
				if (flag)
				{
					this.Hesab.Update(this.Moshtari_ID, dataTable);
				}
				else
				{
					this.dt_Hesab = dataTable;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x000C7E40 File Offset: 0x000C6040
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["bank_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x000C7E88 File Offset: 0x000C6088
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["Bank_Name"].Value == DBNull.Value && gridEXRow.Cells["Bank_Hesab"].Value == DBNull.Value && gridEXRow.Cells["Card_Hesab"].Value == DBNull.Value && gridEXRow.Cells["Shaba_Hesab"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x04000722 RID: 1826
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000724 RID: 1828
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000725 RID: 1829
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000726 RID: 1830
		[CompilerGenerated]
		private string _Moshtari_ID;

		// Token: 0x04000727 RID: 1831
		[CompilerGenerated]
		private DataTable _dt_Hesab;

		// Token: 0x04000728 RID: 1832
		private Moshtari_Hesab Hesab;

		// Token: 0x04000729 RID: 1833
		private Frm_SelectItem frm;
	}
}
