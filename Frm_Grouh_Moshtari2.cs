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
	// Token: 0x020000CA RID: 202
	[DesignerGenerated]
	public partial class Frm_Grouh_Moshtari2 : Form
	{
		// Token: 0x060010E0 RID: 4320 RVA: 0x000B994C File Offset: 0x000B7B4C
		public Frm_Grouh_Moshtari2()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Grouh_Moshtari2.__ENCAddToList(this);
			this.grouhMoshtari = new Grouh_Moshtari2();
			this.InitializeComponent();
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000B99A4 File Offset: 0x000B7BA4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Grouh_Moshtari2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Grouh_Moshtari2.__ENCList.Count == Frm_Grouh_Moshtari2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Grouh_Moshtari2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Grouh_Moshtari2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Grouh_Moshtari2.__ENCList[num] = Frm_Grouh_Moshtari2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Grouh_Moshtari2.__ENCList.RemoveRange(num, Frm_Grouh_Moshtari2.__ENCList.Count - num);
						Frm_Grouh_Moshtari2.__ENCList.Capacity = Frm_Grouh_Moshtari2.__ENCList.Count;
					}
					Frm_Grouh_Moshtari2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x000BA298 File Offset: 0x000B8498
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x00005A56 File Offset: 0x00003C56
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

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x000BA2B0 File Offset: 0x000B84B0
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x000BA2C8 File Offset: 0x000B84C8
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x000BA328 File Offset: 0x000B8528
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x000BA340 File Offset: 0x000B8540
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

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x000BA3A0 File Offset: 0x000B85A0
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x000BA3B8 File Offset: 0x000B85B8
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x000BA418 File Offset: 0x000B8618
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x00005A60 File Offset: 0x00003C60
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x000BA430 File Offset: 0x000B8630
		// (set) Token: 0x060010EF RID: 4335 RVA: 0x00005A6A File Offset: 0x00003C6A
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

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x000BA448 File Offset: 0x000B8648
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00005A74 File Offset: 0x00003C74
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x000BA460 File Offset: 0x000B8660
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x000BA478 File Offset: 0x000B8678
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

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x000BA500 File Offset: 0x000B8700
		// (set) Token: 0x060010F5 RID: 4341 RVA: 0x00005A7E File Offset: 0x00003C7E
		public int? ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x000BA518 File Offset: 0x000B8718
		private void GetData()
		{
			DataTable all = this.grouhMoshtari.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x00005A88 File Offset: 0x00003C88
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00005AB1 File Offset: 0x00003CB1
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x000BA540 File Offset: 0x000B8740
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x000BA57C File Offset: 0x000B877C
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00005AD1 File Offset: 0x00003CD1
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x000BA5D4 File Offset: 0x000B87D4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Grouh_Moshtari2", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.grouhMoshtari.Insert(this.txt_name.Text);
						this.InsertDatarow(num);
						Public_Function.ConfirmInsert();
						this.ButtonItem1_Click(null, null);
						this.Close();
					}
				}
				else
				{
					bool flag2 = Public_Function.ConfirmUpdate() == DialogResult.Yes;
					if (flag2)
					{
						long num = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["id"]);
						flag2 = Public_Function.ExistValue("Grouh_Moshtari2", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.grouhMoshtari.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
							this.Close();
						}
					}
				}
			}
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x000BA71C File Offset: 0x000B891C
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.grouhMoshtari.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x000BA7AC File Offset: 0x000B89AC
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

		// Token: 0x060010FF RID: 4351 RVA: 0x000BA844 File Offset: 0x000B8A44
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
			bool flag = this.ID.HasValue;
			if (flag)
			{
				DataRow dataRow = Public_Function.FillDataRow("select * from grouh_moshtari2");
				flag = (dataRow != null);
				if (flag)
				{
					this.txt_name.Text = Conversions.ToString(dataRow["name"]);
					this.isnew = false;
				}
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00005AF4 File Offset: 0x00003CF4
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000BA8D4 File Offset: 0x000B8AD4
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

		// Token: 0x04000678 RID: 1656
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400067A RID: 1658
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400067B RID: 1659
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400067C RID: 1660
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400067D RID: 1661
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400067E RID: 1662
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x0400067F RID: 1663
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000680 RID: 1664
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000681 RID: 1665
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000682 RID: 1666
		private Grouh_Moshtari2 grouhMoshtari;

		// Token: 0x04000683 RID: 1667
		private bool isnew;

		// Token: 0x04000684 RID: 1668
		[CompilerGenerated]
		private int? _ID;
	}
}
