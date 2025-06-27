using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000F7 RID: 247
	[DesignerGenerated]
	public partial class Frm_Kharid_Keraye : Form
	{
		// Token: 0x06001D23 RID: 7459 RVA: 0x00157C10 File Offset: 0x00155E10
		public Frm_Kharid_Keraye()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Kharid_Keraye.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Keraye = new Kharid_Keraye();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x00157C8C File Offset: 0x00155E8C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kharid_Keraye.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kharid_Keraye.__ENCList.Count == Frm_Kharid_Keraye.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kharid_Keraye.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kharid_Keraye.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kharid_Keraye.__ENCList[num] = Frm_Kharid_Keraye.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kharid_Keraye.__ENCList.RemoveRange(num, Frm_Kharid_Keraye.__ENCList.Count - num);
						Frm_Kharid_Keraye.__ENCList.Capacity = Frm_Kharid_Keraye.__ENCList.Count;
					}
					Frm_Kharid_Keraye.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x00158470 File Offset: 0x00156670
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00007FFF File Offset: 0x000061FF
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

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00158488 File Offset: 0x00156688
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x001584A0 File Offset: 0x001566A0
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value7 = new EventHandler(this.GridEX1_RecordAdded);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
					this._GridEX1.RecordAdded -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.ColumnButtonClick += value6;
					this._GridEX1.RecordAdded += value7;
				}
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x001585D4 File Offset: 0x001567D4
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00008009 File Offset: 0x00006209
		internal virtual CurrencyBox txt_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mablagh = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x001585EC File Offset: 0x001567EC
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00008013 File Offset: 0x00006213
		internal virtual DateBox2 txt_tarikhGrid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikhGrid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikhGrid = value;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00158604 File Offset: 0x00156804
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000801D File Offset: 0x0000621D
		public DataTable Furush_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_Table = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0015861C File Offset: 0x0015681C
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00008027 File Offset: 0x00006227
		public long Moshtari_ID
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

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00158634 File Offset: 0x00156834
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00008031 File Offset: 0x00006231
		public DataTable dt_keraye
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_keraye;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_keraye = value;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0015864C File Offset: 0x0015684C
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0000803B File Offset: 0x0000623B
		public long Kharid_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kharid_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kharid_ID = value;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00158664 File Offset: 0x00156864
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00008045 File Offset: 0x00006245
		public decimal Sum_Vazn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Sum_Vazn;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Sum_Vazn = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0015867C File Offset: 0x0015687C
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0000804F File Offset: 0x0000624F
		public string Kharid_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kharid_num;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kharid_num = value;
			}
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00147F90 File Offset: 0x00146190
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn"] = dataRow["vazn"].ToString().Replace(".0", "");
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x00158694 File Offset: 0x00156894
		private void LoadData()
		{
			bool flag = this.dt_keraye == null;
			if (flag)
			{
				this.dt_keraye = this.Kharid_Keraye.GetByID(checked((int)this.Kharid_ID));
			}
			this.Adddt(this.dt_keraye);
			this.RemoveZero(this.dt_keraye);
			this.GridEX1.DataSource = this.dt_keraye;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x001586F8 File Offset: 0x001568F8
		private void GetSum()
		{
			this.Sum_Vazn = decimal.Zero;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["vazn_ba_zarf"].Value != DBNull.Value;
					if (flag)
					{
						this.Sum_Vazn = Conversions.ToDecimal(Operators.AddObject(this.Sum_Vazn, gridEXRow.Cells["vazn_ba_zarf"].Value));
					}
				}
			}
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x0015878C File Offset: 0x0015698C
		private void Kala_select()
		{
			string command = "SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=" + this.Moshtari_ID.ToString();
			this.frm.ExtraData = this.Moshtari_ID;
			bool flag = this.frm.ShowDialog(command, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x001588A8 File Offset: 0x00156AA8
		private void Delete(GridEXRow row)
		{
			bool flag = row.DataRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)row.DataRow;
				flag = (dataRowView["ID"] != DBNull.Value);
				if (flag)
				{
					this.Kharid_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
				}
				this.GridEX1.CurrentRow.Delete();
			}
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0015891C File Offset: 0x00156B1C
		private void DelKala()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					this.Delete(this.GridEX1.CurrentRow);
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
				}
			}
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x00158984 File Offset: 0x00156B84
		private void Hazine_Select()
		{
			string str = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				str = " where id not in (-6)";
			}
			string command = "SELECT    ID,Name  From Hazine_Kharid" + str + " order by code";
			flag = (this.frm.ShowDialog(command, MyProject.Forms.Frm_Hazine_Kharid, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Hazine_Kharid_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["HazineKharid_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00158AB0 File Offset: 0x00156CB0
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["hazine_kharid_Name"].Position;
			if (flag)
			{
				this.Hazine_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["moshtari_Name"].Position);
				if (flag)
				{
					this.Moshtari_Select('\0');
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["kala_Name"].Position);
					if (flag)
					{
						this.Kala_select();
					}
					else
					{
						flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
						if (flag)
						{
							this.DelKala();
						}
						else
						{
							flag = (position == this.GridEX1.RootTable.Columns["mablagh"].Position);
							if (flag)
							{
								bool flag2 = this.GridEX1.CurrentRow.Cells["Hazine_Kharid_Name"].Value == DBNull.Value;
								if (!flag2)
								{
									Frm_PardakhtMoshtari frm_PardakhtMoshtari = new Frm_PardakhtMoshtari();
									frm_PardakhtMoshtari.Tarikh = this.GridEX1.CurrentRow.Cells["Tarikh_Fa"].Value.ToString();
									frm_PardakhtMoshtari.Tozih = "خرید شماره " + this.Kharid_num;
									frm_PardakhtMoshtari.RibbonStatusBar1.Visible = false;
									frm_PardakhtMoshtari.Text = "پرداخت کرایه ";
									frm_PardakhtMoshtari.HazineKharid_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Hazine_Kharid_Name"].Value);
									frm_PardakhtMoshtari.HazineKharid_ID = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["HazineKharid_ID"].Value);
									frm_PardakhtMoshtari.Moshtari_ID = Conversions.ToString(this.Moshtari_ID);
									flag2 = (this.GridEX1.CurrentRow.Cells["mablagh"].Value != DBNull.Value);
									if (flag2)
									{
										frm_PardakhtMoshtari.Mablagh_Kol = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["mablagh"].Value);
									}
									flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"] != DBNull.Value);
									if (flag2)
									{
										frm_PardakhtMoshtari.Pardakht_ID = Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"]);
									}
									flag2 = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] != DBNull.Value);
									if (flag2)
									{
										frm_PardakhtMoshtari.dt = (DataTable)((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"];
									}
									MyProject.Forms.Form_Main.Dialog_ShowForm(frm_PardakhtMoshtari);
									flag2 = (frm_PardakhtMoshtari.dt != null && frm_PardakhtMoshtari.dt.Rows.Count > 0);
									if (flag2)
									{
										((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] = frm_PardakhtMoshtari.dt;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00158E28 File Offset: 0x00157028
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.Value = ((DateBox2)e.EditControl).Text;
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					bool hasValue = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (hasValue)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
					else
					{
						e.Value = DBNull.Value;
					}
				}
			}
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00158ED8 File Offset: 0x001570D8
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				this.txt_tarikhGrid.SetDate(e.Value.ToString());
			}
			else
			{
				flag = (Operators.CompareString(left, "mablagh", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_mablagh;
					flag = (e.Value != null);
					if (flag)
					{
						this.txt_mablagh.Text = e.Value.ToString();
					}
					else
					{
						this.txt_mablagh.Text = string.Empty;
					}
					this.txt_mablagh.SelectAll();
				}
			}
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00158FA0 File Offset: 0x001571A0
		private void Moshtari_Select(char chr = '\0')
		{
			this.frm.CanEdit = true;
			this.frm.CanDelete = false;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.chara = chr;
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				text = " where moshtari.id not in (-3";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = " where moshtari.id not in (-4,-5)";
			}
			else
			{
				text += " ,-4,-5)";
			}
			flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x0015912C File Offset: 0x0015732C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.EditTextBox == null);
					bool flag2;
					if (flag)
					{
						flag2 = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag2)
						{
							this.GridEX1.GetRow().BeginEdit();
						}
					}
					flag2 = (e.KeyCode == Keys.Delete);
					if (flag2)
					{
						flag = (this.GridEX1.EditTextBox != null);
						if (flag)
						{
							this.GridEX1.EditTextBox.Text = string.Empty;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["Kala_ID"].Value = DBNull.Value;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["moshtari_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
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
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						e.SuppressKeyPress = true;
						break;
					case Keys.Right:
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
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
						flag = (col == this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position);
						if (flag)
						{
							bool flag3 = this.prevent;
							if (flag3)
							{
								e.SuppressKeyPress = true;
								this.prevent = false;
							}
							else
							{
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
						else
						{
							bool flag3 = col == this.GridEX1.RootTable.Columns["hazine_kharid_Name"].Position;
							if (flag3)
							{
								flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag2)
								{
									this.Hazine_Select();
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
							else
							{
								flag3 = (col == this.GridEX1.RootTable.Columns["kala_name"].Position);
								if (flag3)
								{
									flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag2)
									{
										this.Kala_select();
									}
									else
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
								else
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
									if (flag3)
									{
										flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
										if (flag2)
										{
											this.Moshtari_Select('\0');
										}
										else
										{
											DataEntryGrid gridEX = this.GridEX1;
											gridEX.Col++;
										}
									}
									else
									{
										flag3 = (col == this.GridEX1.RootTable.Columns["mablagh"].Position);
										if (flag3)
										{
											flag2 = (this.GridEX1.CurrentRow.RowType == RowType.Record);
											if (flag2)
											{
												flag = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
												if (flag)
												{
													DataEntryGrid gridEX = this.GridEX1;
													gridEX.Row++;
													this.prevent = true;
													this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
												}
												else
												{
													this.GridEX1.MoveToNewRecord();
													this.GridEX1.Col = 0;
												}
											}
											flag3 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
											if (flag3)
											{
												this.GridEX1.UpdateData();
												this.GridEX1.MoveToNewRecord();
												this.GridEX1.Col = 0;
												this.GridEX1.EditMode = EditMode.EditOn;
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
					}
				}
			}
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00159764 File Offset: 0x00157964
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				while (i <= dataTable.Rows.Count - 1)
				{
					bool flag = dataTable.Rows[i].RowState == DataRowState.Deleted;
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["keraye"] == DBNull.Value && dataTable.Rows[i]["hazinekharid_id"] == DBNull.Value);
						if (flag)
						{
							dataTable.Rows[i].Delete();
							i--;
						}
						i++;
					}
				}
				dataTable.AcceptChanges();
				int num = 0;
				bool result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["keraye"] == DBNull.Value;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "mablagh", "کرایه را وارد نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["hazinekharid_id"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "hazine_kharid_name", "نوع هزینه را وارد نمایید");
							result = false;
							return result;
						}
						flag = Conversions.ToBoolean(Public_Function.dict["kharid_keraye_moshtari"]);
						if (flag)
						{
							bool flag2 = dataRow["moshtari_name"] == DBNull.Value;
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "moshtari_name", "مشتری را وارد نمایید");
								result = false;
								return result;
							}
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag2 = enumerator is IDisposable;
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x001599A0 File Offset: 0x00157BA0
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.ValidateGridData();
			if (flag)
			{
				this.GetSum();
			}
			else
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x001599CC File Offset: 0x00157BCC
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.LoadData();
			bool flag = Conversions.ToBoolean(Public_Function.dict["kharid_keraye_moshtari"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["kharid_keraye_tozih"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["tozih"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["tozih"].Visible = false;
			}
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00159AF0 File Offset: 0x00157CF0
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["hazine_Kharid_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x00159B74 File Offset: 0x00157D74
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["Kala_ID"].Value == DBNull.Value && gridEXRow.Cells["hazinekharid_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x04000B5A RID: 2906
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000B5C RID: 2908
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000B5D RID: 2909
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000B5E RID: 2910
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000B5F RID: 2911
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000B60 RID: 2912
		private Frm_SelectItem frm;

		// Token: 0x04000B61 RID: 2913
		private Kharid_Keraye Kharid_Keraye;

		// Token: 0x04000B62 RID: 2914
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000B63 RID: 2915
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000B64 RID: 2916
		[CompilerGenerated]
		private DataTable _dt_keraye;

		// Token: 0x04000B65 RID: 2917
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000B66 RID: 2918
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000B67 RID: 2919
		[CompilerGenerated]
		private string _Kharid_num;

		// Token: 0x04000B68 RID: 2920
		private bool prevent;
	}
}
