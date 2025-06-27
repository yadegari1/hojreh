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
	// Token: 0x020000C9 RID: 201
	[DesignerGenerated]
	public partial class Frm_Grouh_Moshtari : Form
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x000B8970 File Offset: 0x000B6B70
		public Frm_Grouh_Moshtari()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Anbar_KeyDown);
			base.Load += new EventHandler(this.Frm_Anbar_Load);
			Frm_Grouh_Moshtari.__ENCAddToList(this);
			this.grouhMoshtari = new Grouh_Moshtari();
			this.InitializeComponent();
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000B89C8 File Offset: 0x000B6BC8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Grouh_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Grouh_Moshtari.__ENCList.Count == Frm_Grouh_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Grouh_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Grouh_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Grouh_Moshtari.__ENCList[num] = Frm_Grouh_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Grouh_Moshtari.__ENCList.RemoveRange(num, Frm_Grouh_Moshtari.__ENCList.Count - num);
						Frm_Grouh_Moshtari.__ENCList.Capacity = Frm_Grouh_Moshtari.__ENCList.Count;
					}
					Frm_Grouh_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060010C1 RID: 4289 RVA: 0x000B92BC File Offset: 0x000B74BC
		// (set) Token: 0x060010C2 RID: 4290 RVA: 0x0000599E File Offset: 0x00003B9E
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

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x000B92D4 File Offset: 0x000B74D4
		// (set) Token: 0x060010C4 RID: 4292 RVA: 0x000B92EC File Offset: 0x000B74EC
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

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x000B934C File Offset: 0x000B754C
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x000B9364 File Offset: 0x000B7564
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

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x000B93C4 File Offset: 0x000B75C4
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x000B93DC File Offset: 0x000B75DC
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

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x000B943C File Offset: 0x000B763C
		// (set) Token: 0x060010CA RID: 4298 RVA: 0x000059A8 File Offset: 0x00003BA8
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

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x000B9454 File Offset: 0x000B7654
		// (set) Token: 0x060010CC RID: 4300 RVA: 0x000059B2 File Offset: 0x00003BB2
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x000B946C File Offset: 0x000B766C
		// (set) Token: 0x060010CE RID: 4302 RVA: 0x000059BC File Offset: 0x00003BBC
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

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x000B9484 File Offset: 0x000B7684
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x000B949C File Offset: 0x000B769C
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

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x000B9524 File Offset: 0x000B7724
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x000059C6 File Offset: 0x00003BC6
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

		// Token: 0x060010D3 RID: 4307 RVA: 0x000B953C File Offset: 0x000B773C
		private void GetData()
		{
			DataTable all = this.grouhMoshtari.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x000059D0 File Offset: 0x00003BD0
		private void RefreshDatarow(DataRow dr)
		{
			dr.BeginEdit();
			dr["Name"] = this.txt_name.Text;
			dr.EndEdit();
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000059F9 File Offset: 0x00003BF9
		private void LoadDatarow(DataRow dr)
		{
			this.txt_name.Text = Conversions.ToString(dr["Name"]);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x000B9564 File Offset: 0x000B7764
		private void UpdataDatarow()
		{
			DataRow row = ((DataRowView)this.GridEX1.GetRow().DataRow).Row;
			this.RefreshDatarow(row);
			row.AcceptChanges();
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x000B95A0 File Offset: 0x000B77A0
		private void InsertDatarow(long id)
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			DataRow dataRow = dataTable.NewRow();
			this.RefreshDatarow(dataRow);
			dataRow["ID"] = id;
			dataTable.Rows.Add(dataRow);
			dataRow.AcceptChanges();
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x00005A19 File Offset: 0x00003C19
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.isnew = true;
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_name.Focus();
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x000B95F8 File Offset: 0x000B77F8
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			if (!flag)
			{
				flag = this.isnew;
				if (flag)
				{
					bool flag2 = Public_Function.ExistValue("Grouh_Moshtari", "Name", this.txt_name.Text);
					if (flag2)
					{
						this.txt_name.ShowTip("عنوان وارد شده تکراری میباشد");
					}
					else
					{
						long num = this.grouhMoshtari.Insert(this.txt_name.Text);
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
						flag2 = Public_Function.ExistValue("Grouh_Moshtari", "Name", this.txt_name.Text, "ID", Conversions.ToString(num));
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

		// Token: 0x060010DA RID: 4314 RVA: 0x000B9734 File Offset: 0x000B7934
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

		// Token: 0x060010DB RID: 4315 RVA: 0x000B97C4 File Offset: 0x000B79C4
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

		// Token: 0x060010DC RID: 4316 RVA: 0x000B985C File Offset: 0x000B7A5C
		private void Frm_Anbar_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.GetData();
			this.ButtonItem1_Click(null, null);
			bool flag = this.ID.HasValue;
			if (flag)
			{
				DataRow byID = this.grouhMoshtari.GetByID(Conversions.ToString((T)this.ID));
				flag = (byID != null);
				if (flag)
				{
					this.txt_name.Text = Conversions.ToString(byID["name"]);
					this.isnew = false;
				}
			}
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00005A3C File Offset: 0x00003C3C
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.GridEX1_SelectionChanged(null, null);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x000B98FC File Offset: 0x000B7AFC
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

		// Token: 0x0400066B RID: 1643
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400066D RID: 1645
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400066E RID: 1646
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x0400066F RID: 1647
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000670 RID: 1648
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000671 RID: 1649
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x04000672 RID: 1650
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000673 RID: 1651
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000674 RID: 1652
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000675 RID: 1653
		private Grouh_Moshtari grouhMoshtari;

		// Token: 0x04000676 RID: 1654
		private bool isnew;

		// Token: 0x04000677 RID: 1655
		[CompilerGenerated]
		private int? _ID;
	}
}
