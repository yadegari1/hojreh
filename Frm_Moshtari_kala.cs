using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D3 RID: 211
	[DesignerGenerated]
	public partial class Frm_Moshtari_kala : Form
	{
		// Token: 0x0600128B RID: 4747 RVA: 0x000C7F44 File Offset: 0x000C6144
		public Frm_Moshtari_kala()
		{
			base.Activated += new EventHandler(this.Frm_Moshtari_kala_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Moshtari_kala_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_Moshtari_kala_KeyDown);
			base.Load += new EventHandler(this.Frm_Moshtari_kala_Load);
			Frm_Moshtari_kala.__ENCAddToList(this);
			this.frm_closing = false;
			this.InitializeComponent();
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000C7FC0 File Offset: 0x000C61C0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Moshtari_kala.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Moshtari_kala.__ENCList.Count == Frm_Moshtari_kala.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Moshtari_kala.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Moshtari_kala.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Moshtari_kala.__ENCList[num] = Frm_Moshtari_kala.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Moshtari_kala.__ENCList.RemoveRange(num, Frm_Moshtari_kala.__ENCList.Count - num);
						Frm_Moshtari_kala.__ENCList.Capacity = Frm_Moshtari_kala.__ENCList.Count;
					}
					Frm_Moshtari_kala.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x000C88A8 File Offset: 0x000C6AA8
		// (set) Token: 0x06001290 RID: 4752 RVA: 0x000C88C0 File Offset: 0x000C6AC0
		internal virtual DataEntryGrid DataEntryGrid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataEntryGrid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.DataEntryGrid1_KeyDown);
				bool flag = this._DataEntryGrid1 != null;
				if (flag)
				{
					this._DataEntryGrid1.KeyDown -= value2;
				}
				this._DataEntryGrid1 = value;
				flag = (this._DataEntryGrid1 != null);
				if (flag)
				{
					this._DataEntryGrid1.KeyDown += value2;
				}
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x000C8920 File Offset: 0x000C6B20
		// (set) Token: 0x06001292 RID: 4754 RVA: 0x000C8938 File Offset: 0x000C6B38
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x000C8998 File Offset: 0x000C6B98
		// (set) Token: 0x06001294 RID: 4756 RVA: 0x000060EB File Offset: 0x000042EB
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

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001295 RID: 4757 RVA: 0x000C89B0 File Offset: 0x000C6BB0
		// (set) Token: 0x06001296 RID: 4758 RVA: 0x000C89C8 File Offset: 0x000C6BC8
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

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x000C8A28 File Offset: 0x000C6C28
		// (set) Token: 0x06001298 RID: 4760 RVA: 0x000C8A40 File Offset: 0x000C6C40
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

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x000C8AA0 File Offset: 0x000C6CA0
		// (set) Token: 0x0600129A RID: 4762 RVA: 0x000C8AB8 File Offset: 0x000C6CB8
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

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x000C8B18 File Offset: 0x000C6D18
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x000060F5 File Offset: 0x000042F5
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

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000C8B30 File Offset: 0x000C6D30
		// (set) Token: 0x0600129E RID: 4766 RVA: 0x000060FF File Offset: 0x000042FF
		public long ExtraData
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ExtraData;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ExtraData = value;
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00006109 File Offset: 0x00004309
		private void Frm_Moshtari_kala_Activated(object sender, EventArgs e)
		{
			this.EditBox1.Focus();
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00006119 File Offset: 0x00004319
		private void Frm_Moshtari_kala_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.frm_closing = true;
			this.UiButton1_Click(null, null);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000C8B48 File Offset: 0x000C6D48
		private void Frm_Moshtari_kala_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.UiButton1_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F2);
			if (flag)
			{
				this.UiButton3_Click(null, null);
			}
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x000C8B88 File Offset: 0x000C6D88
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.EditBox1.Text, string.Empty, false) != 0;
			if (flag)
			{
				this.DataEntryGrid1.RootTable.FilterCondition = new GridEXFilterCondition(this.DataEntryGrid1.RootTable.Columns["Name"], ConditionOperator.Contains, this.EditBox1.Text);
			}
			else
			{
				this.DataEntryGrid1.RootTable.FilterCondition = null;
			}
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000C8C0C File Offset: 0x000C6E0C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			GridEXRow currentRow = this.DataEntryGrid1.CurrentRow;
			bool flag = currentRow != null;
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("if not exists(select id from moshtari_kala where moshtari_id=" + Conversions.ToString(this.ExtraData) + " and kala_id=", currentRow.Cells["ID"].Value), ") insert into Moshtari_kala (Moshtari_ID,Kala_ID) Values("), this.ExtraData), ","), currentRow.Cells["ID"].Value), ");")));
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
			flag = !this.frm_closing;
			if (flag)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000C8CFC File Offset: 0x000C6EFC
		private void Loaddata()
		{
			DataTable dataSource = Public_Function.FillData("select Id,name from Kala where id not in(select kala_id from Moshtari_kala where moshtari_id =" + Conversions.ToString(this.ExtraData) + ")");
			this.DataEntryGrid1.DataSource = dataSource;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0000612D File Offset: 0x0000432D
		private void Frm_Moshtari_kala_Load(object sender, EventArgs e)
		{
			this.frm_closing = false;
			this.EditBox1.Text = string.Empty;
			this.EditBox1.Focus();
			this.Loaddata();
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0000615C File Offset: 0x0000435C
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.EditBox1.Text;
			dr.EndEdit();
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x000C8D38 File Offset: 0x000C6F38
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.DataEntryGrid1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000C8D90 File Offset: 0x000C6F90
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ExistValue("Kala", "Name", this.EditBox1.Text);
			if (flag)
			{
				this.EditBox1.ShowTip("عنوان وارد شده تکراری میباشد");
			}
			else
			{
				flag = (Operators.CompareString(this.EditBox1.Text, string.Empty, false) == 0);
				if (flag)
				{
					this.EditBox1.ShowTip("عنوان جنس را وارد نمایید");
				}
				else
				{
					Kala kala = new Kala();
					long id = kala.Insert(this.EditBox1.Text);
					this.InsertDatarow(id);
					Public_Function.ConfirmInsert();
					this.DataEntryGrid1.Focus();
					flag = (this.DataEntryGrid1.RowCount > 0);
					if (flag)
					{
						this.DataEntryGrid1.Row = checked(this.DataEntryGrid1.RowCount - 1);
						this.Close();
					}
				}
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00003A26 File Offset: 0x00001C26
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x000C8E6C File Offset: 0x000C706C
		private void DataEntryGrid1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up;
			bool flag2;
			if (flag)
			{
				flag2 = (this.DataEntryGrid1.Row == 0);
				if (flag2)
				{
					this.EditBox1.Focus();
				}
			}
			flag2 = (e.KeyCode == Keys.Escape);
			if (flag2)
			{
				this.frm_closing = false;
				this.UiButton1_Click(null, null);
			}
			flag2 = (e.KeyCode == Keys.Return);
			if (flag2)
			{
				flag = (this.DataEntryGrid1.CurrentRow != null);
				if (flag)
				{
					this.UiButton1_Click(null, null);
				}
			}
		}

		// Token: 0x0400072A RID: 1834
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400072C RID: 1836
		[AccessedThroughProperty("DataEntryGrid1")]
		private DataEntryGrid _DataEntryGrid1;

		// Token: 0x0400072D RID: 1837
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400072E RID: 1838
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400072F RID: 1839
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000730 RID: 1840
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000731 RID: 1841
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x04000732 RID: 1842
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000733 RID: 1843
		[CompilerGenerated]
		private long _ExtraData;

		// Token: 0x04000734 RID: 1844
		private bool frm_closing;
	}
}
