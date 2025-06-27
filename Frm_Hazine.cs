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
	// Token: 0x020000CB RID: 203
	[DesignerGenerated]
	public partial class Frm_Hazine : Form
	{
		// Token: 0x06001103 RID: 4355 RVA: 0x000BA924 File Offset: 0x000B8B24
		public Frm_Hazine()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Hazine.__ENCAddToList(this);
			this.Hazine = new Hazine();
			this.CodeHesab = new Code_Hesab();
			this.InitializeComponent();
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000BA988 File Offset: 0x000B8B88
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Hazine.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Hazine.__ENCList.Count == Frm_Hazine.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Hazine.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Hazine.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Hazine.__ENCList[num] = Frm_Hazine.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Hazine.__ENCList.RemoveRange(num, Frm_Hazine.__ENCList.Count - num);
						Frm_Hazine.__ENCList.Capacity = Frm_Hazine.__ENCList.Count;
					}
					Frm_Hazine.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x000BB264 File Offset: 0x000B9464
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x00005B0E File Offset: 0x00003D0E
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

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x000BB27C File Offset: 0x000B947C
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x000BB294 File Offset: 0x000B9494
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

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000BB31C File Offset: 0x000B951C
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00005B18 File Offset: 0x00003D18
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x000BB334 File Offset: 0x000B9534
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00005B22 File Offset: 0x00003D22
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x000BB34C File Offset: 0x000B954C
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00005B2C File Offset: 0x00003D2C
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x000BB364 File Offset: 0x000B9564
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x000BB37C File Offset: 0x000B957C
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

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x000BB3DC File Offset: 0x000B95DC
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x000BB3F4 File Offset: 0x000B95F4
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

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x000BB454 File Offset: 0x000B9654
		// (set) Token: 0x06001116 RID: 4374 RVA: 0x000BB46C File Offset: 0x000B966C
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x000BB4CC File Offset: 0x000B96CC
		// (set) Token: 0x06001118 RID: 4376 RVA: 0x00005B36 File Offset: 0x00003D36
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

		// Token: 0x06001119 RID: 4377 RVA: 0x000BB4E4 File Offset: 0x000B96E4
		private void GetData()
		{
			DataTable all = this.Hazine.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00005B40 File Offset: 0x00003D40
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00005B69 File Offset: 0x00003D69
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
			this.hesab_id = Conversions.ToInteger(dr["CodeHesab_ID"]);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x000BB50C File Offset: 0x000B970C
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x000BB548 File Offset: 0x000B9748
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataRow["CodeHesab_ID"] = this.hesab_id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00005B9F File Offset: 0x00003D9F
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x000BB5B4 File Offset: 0x000B97B4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				string empty = string.Empty;
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Hazine", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						this.hesab_id = checked((int)this.CodeHesab.Insert(Code_Hesab.GrohHesab.هزینه, this.txt_name.Text));
						long num = this.Hazine.Insert(this.txt_name.Text, Conversions.ToString(this.hesab_id));
						this.InsertDatarow(num);
						Public_Function.ConfirmInsert();
						this.Close();
					}
				}
				else
				{
					bool flag2 = Public_Function.ConfirmUpdate() == DialogResult.Yes;
					if (flag2)
					{
						long num = Conversions.ToLong(((DataRowView)this.GridEX1.GetRow().DataRow)["id"]);
						flag2 = Public_Function.ExistValue("Hazine", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.CodeHesab.Update(this.txt_name.Text, Conversions.ToString(this.hesab_id));
							this.Hazine.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x000BB740 File Offset: 0x000B9940
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

		// Token: 0x06001121 RID: 4385 RVA: 0x000BB7D0 File Offset: 0x000B99D0
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

		// Token: 0x06001122 RID: 4386 RVA: 0x000BB868 File Offset: 0x000B9A68
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
			bool hasValue = this.ID.HasValue;
			if (hasValue)
			{
				string arg_6A_0 = "select * from hazine where id=";
				int? iD = this.ID;
				DataRow dr = Public_Function.FillDataRow(arg_6A_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null));
				this.isnew = false;
				this.LoadDatarow(dr);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00005BC2 File Offset: 0x00003DC2
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000BB8FC File Offset: 0x000B9AFC
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

		// Token: 0x04000685 RID: 1669
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000687 RID: 1671
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000688 RID: 1672
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000689 RID: 1673
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x0400068A RID: 1674
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400068B RID: 1675
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400068C RID: 1676
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400068D RID: 1677
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400068E RID: 1678
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400068F RID: 1679
		private Hazine Hazine;

		// Token: 0x04000690 RID: 1680
		private Code_Hesab CodeHesab;

		// Token: 0x04000691 RID: 1681
		private int hesab_id;

		// Token: 0x04000692 RID: 1682
		private bool isnew;

		// Token: 0x04000693 RID: 1683
		[CompilerGenerated]
		private int? _ID;
	}
}
