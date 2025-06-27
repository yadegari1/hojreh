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
	// Token: 0x020000CD RID: 205
	[DesignerGenerated]
	public partial class Frm_Kala : Form
	{
		// Token: 0x0600114E RID: 4430 RVA: 0x000BCE14 File Offset: 0x000BB014
		public Frm_Kala()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Kala.__ENCAddToList(this);
			this.Kala = new Kala();
			this.InitializeComponent();
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x000BCE6C File Offset: 0x000BB06C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kala.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kala.__ENCList.Count == Frm_Kala.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kala.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kala.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kala.__ENCList[num] = Frm_Kala.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kala.__ENCList.RemoveRange(num, Frm_Kala.__ENCList.Count - num);
						Frm_Kala.__ENCList.Capacity = Frm_Kala.__ENCList.Count;
					}
					Frm_Kala.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x000BD768 File Offset: 0x000BB968
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x00005C8A File Offset: 0x00003E8A
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x000BD780 File Offset: 0x000BB980
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x000BD798 File Offset: 0x000BB998
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

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x000BD7F8 File Offset: 0x000BB9F8
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x000BD810 File Offset: 0x000BBA10
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

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x000BD870 File Offset: 0x000BBA70
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x000BD888 File Offset: 0x000BBA88
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x000BD8E8 File Offset: 0x000BBAE8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x00005C94 File Offset: 0x00003E94
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

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x000BD900 File Offset: 0x000BBB00
		// (set) Token: 0x0600115D RID: 4445 RVA: 0x00005C9E File Offset: 0x00003E9E
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

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x000BD918 File Offset: 0x000BBB18
		// (set) Token: 0x0600115F RID: 4447 RVA: 0x00005CA8 File Offset: 0x00003EA8
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x000BD930 File Offset: 0x000BBB30
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x000BD948 File Offset: 0x000BBB48
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

		// Token: 0x06001162 RID: 4450 RVA: 0x000BD9D0 File Offset: 0x000BBBD0
		private void GetData()
		{
			DataTable all = this.Kala.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00005CB2 File Offset: 0x00003EB2
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00005CDB File Offset: 0x00003EDB
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x000BD9F8 File Offset: 0x000BBBF8
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000BDA34 File Offset: 0x000BBC34
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00005CFB File Offset: 0x00003EFB
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000BDA8C File Offset: 0x000BBC8C
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Kala", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.Kala.Insert(this.txt_name.Text);
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
						flag2 = Public_Function.ExistValue("Kala", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.Kala.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000BDBC4 File Offset: 0x000BBDC4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.Kala.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000BDC54 File Offset: 0x000BBE54
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

		// Token: 0x0600116B RID: 4459 RVA: 0x000BDCEC File Offset: 0x000BBEEC
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00005D1E File Offset: 0x00003F1E
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x000BDD2C File Offset: 0x000BBF2C
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

		// Token: 0x040006A2 RID: 1698
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040006A4 RID: 1700
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040006A5 RID: 1701
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040006A6 RID: 1702
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040006A7 RID: 1703
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040006A8 RID: 1704
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x040006A9 RID: 1705
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040006AA RID: 1706
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040006AB RID: 1707
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040006AC RID: 1708
		private Kala Kala;

		// Token: 0x040006AD RID: 1709
		private bool isnew;
	}
}
