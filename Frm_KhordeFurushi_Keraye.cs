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
	// Token: 0x020000FD RID: 253
	[DesignerGenerated]
	public partial class Frm_KhordeFurushi_Keraye : Form
	{
		// Token: 0x06002046 RID: 8262 RVA: 0x0018094C File Offset: 0x0017EB4C
		public Frm_KhordeFurushi_Keraye()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_KhordeFurushi_Keraye.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.KhordeFurushi_Keraye = new KhordeFurushi_Keraye();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x001809C8 File Offset: 0x0017EBC8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_KhordeFurushi_Keraye.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_KhordeFurushi_Keraye.__ENCList.Count == Frm_KhordeFurushi_Keraye.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_KhordeFurushi_Keraye.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_KhordeFurushi_Keraye.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_KhordeFurushi_Keraye.__ENCList[num] = Frm_KhordeFurushi_Keraye.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_KhordeFurushi_Keraye.__ENCList.RemoveRange(num, Frm_KhordeFurushi_Keraye.__ENCList.Count - num);
						Frm_KhordeFurushi_Keraye.__ENCList.Capacity = Frm_KhordeFurushi_Keraye.__ENCList.Count;
					}
					Frm_KhordeFurushi_Keraye.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x00181180 File Offset: 0x0017F380
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x000087B0 File Offset: 0x000069B0
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

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x00181198 File Offset: 0x0017F398
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x001811B0 File Offset: 0x0017F3B0
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
				EndCustomEditEventHandler value2 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value4 = new EventHandler(this.GridEX1_RecordAdded);
				KeyPressEventHandler value5 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyEventHandler value7 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.EndCustomEdit -= value2;
					this._GridEX1.ColumnButtonClick -= value3;
					this._GridEX1.RecordAdded -= value4;
					this._GridEX1.KeyPress -= value5;
					this._GridEX1.InitCustomEdit -= value6;
					this._GridEX1.KeyDown -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.EndCustomEdit += value2;
					this._GridEX1.ColumnButtonClick += value3;
					this._GridEX1.RecordAdded += value4;
					this._GridEX1.KeyPress += value5;
					this._GridEX1.InitCustomEdit += value6;
					this._GridEX1.KeyDown += value7;
				}
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x001812E4 File Offset: 0x0017F4E4
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x000087BA File Offset: 0x000069BA
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

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x001812FC File Offset: 0x0017F4FC
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x000087C4 File Offset: 0x000069C4
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

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x00181314 File Offset: 0x0017F514
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x000087CE File Offset: 0x000069CE
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

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0018132C File Offset: 0x0017F52C
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x000087D8 File Offset: 0x000069D8
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

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x00181344 File Offset: 0x0017F544
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x000087E2 File Offset: 0x000069E2
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

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0018135C File Offset: 0x0017F55C
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x000087EC File Offset: 0x000069EC
		public long Furush_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_ID = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00181374 File Offset: 0x0017F574
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x000087F6 File Offset: 0x000069F6
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

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0018138C File Offset: 0x0017F58C
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x00008800 File Offset: 0x00006A00
		public string Furush_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Furush_num;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Furush_num = value;
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00147F90 File Offset: 0x00146190
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

		// Token: 0x0600205F RID: 8287 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x001813A4 File Offset: 0x0017F5A4
		private void LoadData()
		{
			bool flag = this.dt_keraye == null;
			if (flag)
			{
				this.dt_keraye = this.KhordeFurushi_Keraye.GetByID(checked((int)this.Furush_ID));
			}
			this.RemoveZero(this.dt_keraye);
			this.GridEX1.DataSource = this.dt_keraye;
			this.Adddt(this.dt_keraye);
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00181408 File Offset: 0x0017F608
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

		// Token: 0x06002062 RID: 8290 RVA: 0x0018149C File Offset: 0x0017F69C
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

		// Token: 0x06002063 RID: 8291 RVA: 0x001815B8 File Offset: 0x0017F7B8
		private void Delete(GridEXRow row)
		{
			bool flag = row.DataRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)row.DataRow;
				flag = (dataRowView["ID"] != DBNull.Value);
				if (flag)
				{
					int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(ID)  from daryaftpardakht where id=", dataRowView["Keraye_pardakht_ID"]), " OR parent_id="), dataRowView["Keraye_pardakht_ID"])
					}, null, null, null));
					flag = (num == 1);
					if (flag)
					{
						this.KhordeFurushi_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
						this.GridEX1.CurrentRow.Delete();
					}
					else
					{
						Public_Function.ShowMessage("پرداخت مورد نظر دارای پرداخت چک و یا کارت به کارت میباشد" + Environment.NewLine + "لطفا در ابتدا اقدام به حذف موارد ذکر شده نمایید", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
					}
				}
				else
				{
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x001816C8 File Offset: 0x0017F8C8
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

		// Token: 0x06002065 RID: 8293 RVA: 0x00181730 File Offset: 0x0017F930
		private void Hazine_Select()
		{
			string str = string.Empty;
			str = " where id not in (-6)";
			string command = "SELECT    ID,Name  From Hazine_Kharid" + str + " order by code";
			bool flag = this.frm.ShowDialog(command, MyProject.Forms.Frm_Hazine_Kharid, 0) == DialogResult.OK;
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

		// Token: 0x06002066 RID: 8294 RVA: 0x00181840 File Offset: 0x0017FA40
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
							Frm_PardakhtMoshtari frm_PardakhtMoshtari = new Frm_PardakhtMoshtari();
							frm_PardakhtMoshtari.Tarikh = this.GridEX1.CurrentRow.Cells["Tarikh_Fa"].Value.ToString();
							frm_PardakhtMoshtari.Tozih = "فروش شماره " + this.Furush_num;
							frm_PardakhtMoshtari.RibbonStatusBar1.Visible = false;
							frm_PardakhtMoshtari.Text = "پرداخت کرایه ";
							frm_PardakhtMoshtari.HazineKharid_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Hazine_Kharid_Name"].Value);
							frm_PardakhtMoshtari.HazineKharid_ID = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["HazineKharid_ID"].Value);
							frm_PardakhtMoshtari.Moshtari_ID = Conversions.ToString(this.Moshtari_ID);
							flag = (this.GridEX1.CurrentRow.Cells["mablagh"].Value != DBNull.Value);
							if (flag)
							{
								frm_PardakhtMoshtari.Mablagh_Kol = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["mablagh"].Value);
							}
							flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"] != DBNull.Value);
							if (flag)
							{
								frm_PardakhtMoshtari.Pardakht_ID = Conversions.ToString(((DataRowView)this.GridEX1.CurrentRow.DataRow)["keraye_pardakht_id"]);
							}
							flag = (((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] != DBNull.Value);
							if (flag)
							{
								frm_PardakhtMoshtari.dt = (DataTable)((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"];
							}
							MyProject.Forms.Form_Main.Dialog_ShowForm(frm_PardakhtMoshtari);
							flag = (frm_PardakhtMoshtari.dt != null && frm_PardakhtMoshtari.dt.Rows.Count > 0);
							if (flag)
							{
								((DataRowView)this.GridEX1.CurrentRow.DataRow)["dt"] = frm_PardakhtMoshtari.dt;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x00148A78 File Offset: 0x00146C78
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
				}
			}
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x00181B54 File Offset: 0x0017FD54
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

		// Token: 0x06002069 RID: 8297 RVA: 0x00181C1C File Offset: 0x0017FE1C
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
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Up));
							e.SuppressKeyPress = true;
							return;
						}
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
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Down));
							e.SuppressKeyPress = true;
							return;
						}
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

		// Token: 0x0600206A RID: 8298 RVA: 0x0018221C File Offset: 0x0018041C
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
						num++;
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
				result = true;
				return result;
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x001823EC File Offset: 0x001805EC
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

		// Token: 0x0600206C RID: 8300 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x00182418 File Offset: 0x00180618
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.LoadData();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x00182480 File Offset: 0x00180680
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

		// Token: 0x0600206F RID: 8303 RVA: 0x00182504 File Offset: 0x00180704
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

		// Token: 0x04000C8B RID: 3211
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000C8D RID: 3213
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000C8E RID: 3214
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000C8F RID: 3215
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000C90 RID: 3216
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000C91 RID: 3217
		private Frm_SelectItem frm;

		// Token: 0x04000C92 RID: 3218
		private KhordeFurushi_Keraye KhordeFurushi_Keraye;

		// Token: 0x04000C93 RID: 3219
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000C94 RID: 3220
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000C95 RID: 3221
		[CompilerGenerated]
		private DataTable _dt_keraye;

		// Token: 0x04000C96 RID: 3222
		[CompilerGenerated]
		private long _Furush_ID;

		// Token: 0x04000C97 RID: 3223
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000C98 RID: 3224
		[CompilerGenerated]
		private string _Furush_num;

		// Token: 0x04000C99 RID: 3225
		private bool prevent;
	}
}
