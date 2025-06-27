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
	// Token: 0x020000C6 RID: 198
	[DesignerGenerated]
	public partial class Frm_Daramad : Form
	{
		// Token: 0x06001040 RID: 4160 RVA: 0x000B3920 File Offset: 0x000B1B20
		public Frm_Daramad()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Daramad.__ENCAddToList(this);
			this.Daramad = new Daramad();
			this.CodeHesab = new Code_Hesab();
			this.InitializeComponent();
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000B3984 File Offset: 0x000B1B84
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Daramad.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Daramad.__ENCList.Count == Frm_Daramad.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Daramad.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Daramad.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Daramad.__ENCList[num] = Frm_Daramad.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Daramad.__ENCList.RemoveRange(num, Frm_Daramad.__ENCList.Count - num);
						Frm_Daramad.__ENCList.Capacity = Frm_Daramad.__ENCList.Count;
					}
					Frm_Daramad.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x000B425C File Offset: 0x000B245C
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x000057E6 File Offset: 0x000039E6
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

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001046 RID: 4166 RVA: 0x000B4274 File Offset: 0x000B2474
		// (set) Token: 0x06001047 RID: 4167 RVA: 0x000B428C File Offset: 0x000B248C
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

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001048 RID: 4168 RVA: 0x000B4314 File Offset: 0x000B2514
		// (set) Token: 0x06001049 RID: 4169 RVA: 0x000057F0 File Offset: 0x000039F0
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

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x000B432C File Offset: 0x000B252C
		// (set) Token: 0x0600104B RID: 4171 RVA: 0x000057FA File Offset: 0x000039FA
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600104C RID: 4172 RVA: 0x000B4344 File Offset: 0x000B2544
		// (set) Token: 0x0600104D RID: 4173 RVA: 0x00005804 File Offset: 0x00003A04
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600104E RID: 4174 RVA: 0x000B435C File Offset: 0x000B255C
		// (set) Token: 0x0600104F RID: 4175 RVA: 0x000B4374 File Offset: 0x000B2574
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

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x000B43D4 File Offset: 0x000B25D4
		// (set) Token: 0x06001051 RID: 4177 RVA: 0x000B43EC File Offset: 0x000B25EC
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

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x000B444C File Offset: 0x000B264C
		// (set) Token: 0x06001053 RID: 4179 RVA: 0x000B4464 File Offset: 0x000B2664
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

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x000B44C4 File Offset: 0x000B26C4
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x0000580E File Offset: 0x00003A0E
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

		// Token: 0x06001056 RID: 4182 RVA: 0x000B44DC File Offset: 0x000B26DC
		private void GetData()
		{
			DataTable all = this.Daramad.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00005818 File Offset: 0x00003A18
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00005841 File Offset: 0x00003A41
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
			this.hesab_id = Conversions.ToInteger(dr["CodeHesab_ID"]);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x000B4504 File Offset: 0x000B2704
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x000B4540 File Offset: 0x000B2740
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

		// Token: 0x0600105B RID: 4187 RVA: 0x00005877 File Offset: 0x00003A77
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x000B45AC File Offset: 0x000B27AC
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				string empty = string.Empty;
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Daramad", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						this.hesab_id = checked((int)this.CodeHesab.Insert(Code_Hesab.GrohHesab.درآمد, this.txt_name.Text));
						long num = this.Daramad.Insert(this.txt_name.Text, Conversions.ToString(this.hesab_id));
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
						flag2 = Public_Function.ExistValue("Daramad", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
						if (flag2)
						{
							this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
						}
						else
						{
							this.CodeHesab.Update(this.txt_name.Text, Conversions.ToString(this.hesab_id));
							this.Daramad.Update(this.txt_name.Text, Conversions.ToString(num));
							this.UpdataDatarow();
							Public_Function.ConfirmInsert();
						}
					}
				}
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x000B4740 File Offset: 0x000B2940
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					this.Daramad.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					this.GridEX1.GetRow().Delete();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.ButtonItem1_Click(null, null);
					}
				}
			}
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x000B47D0 File Offset: 0x000B29D0
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

		// Token: 0x0600105F RID: 4191 RVA: 0x000B4868 File Offset: 0x000B2A68
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
			bool hasValue = this.ID.HasValue;
			if (hasValue)
			{
				string arg_6A_0 = "select * from daramad where id=";
				int? iD = this.ID;
				DataRow dr = Public_Function.FillDataRow(arg_6A_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null));
				this.isnew = false;
				this.LoadDatarow(dr);
			}
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0000589A File Offset: 0x00003A9A
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000B48FC File Offset: 0x000B2AFC
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

		// Token: 0x0400062E RID: 1582
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000630 RID: 1584
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000631 RID: 1585
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000632 RID: 1586
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x04000633 RID: 1587
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000634 RID: 1588
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000635 RID: 1589
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000636 RID: 1590
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000637 RID: 1591
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000638 RID: 1592
		private Daramad Daramad;

		// Token: 0x04000639 RID: 1593
		private Code_Hesab CodeHesab;

		// Token: 0x0400063A RID: 1594
		private int hesab_id;

		// Token: 0x0400063B RID: 1595
		private bool isnew;

		// Token: 0x0400063C RID: 1596
		[CompilerGenerated]
		private int? _ID;
	}
}
