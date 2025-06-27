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
	// Token: 0x020000F3 RID: 243
	[DesignerGenerated]
	public partial class Frm_Furush_Keraye : Form
	{
		// Token: 0x06001C05 RID: 7173 RVA: 0x00147538 File Offset: 0x00145738
		public Frm_Furush_Keraye()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Furush_Keraye.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Furush_Keraye = new Furush_Keraye();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x001475B4 File Offset: 0x001457B4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Furush_Keraye.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Furush_Keraye.__ENCList.Count == Frm_Furush_Keraye.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Furush_Keraye.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Furush_Keraye.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Furush_Keraye.__ENCList[num] = Frm_Furush_Keraye.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Furush_Keraye.__ENCList.RemoveRange(num, Frm_Furush_Keraye.__ENCList.Count - num);
						Frm_Furush_Keraye.__ENCList.Capacity = Frm_Furush_Keraye.__ENCList.Count;
					}
					Frm_Furush_Keraye.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x00147D6C File Offset: 0x00145F6C
		// (set) Token: 0x06001C0A RID: 7178 RVA: 0x00007D72 File Offset: 0x00005F72
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

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001C0B RID: 7179 RVA: 0x00147D84 File Offset: 0x00145F84
		// (set) Token: 0x06001C0C RID: 7180 RVA: 0x00147D9C File Offset: 0x00145F9C
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

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06001C0D RID: 7181 RVA: 0x00147ED0 File Offset: 0x001460D0
		// (set) Token: 0x06001C0E RID: 7182 RVA: 0x00007D7C File Offset: 0x00005F7C
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

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06001C0F RID: 7183 RVA: 0x00147EE8 File Offset: 0x001460E8
		// (set) Token: 0x06001C10 RID: 7184 RVA: 0x00007D86 File Offset: 0x00005F86
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

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06001C11 RID: 7185 RVA: 0x00147F00 File Offset: 0x00146100
		// (set) Token: 0x06001C12 RID: 7186 RVA: 0x00007D90 File Offset: 0x00005F90
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

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06001C13 RID: 7187 RVA: 0x00147F18 File Offset: 0x00146118
		// (set) Token: 0x06001C14 RID: 7188 RVA: 0x00007D9A File Offset: 0x00005F9A
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

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x00147F30 File Offset: 0x00146130
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x00007DA4 File Offset: 0x00005FA4
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

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00147F48 File Offset: 0x00146148
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00007DAE File Offset: 0x00005FAE
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

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x00147F60 File Offset: 0x00146160
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x00007DB8 File Offset: 0x00005FB8
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

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x00147F78 File Offset: 0x00146178
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x00007DC2 File Offset: 0x00005FC2
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

		// Token: 0x06001C1D RID: 7197 RVA: 0x00147F90 File Offset: 0x00146190
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

		// Token: 0x06001C1E RID: 7198 RVA: 0x00126BD8 File Offset: 0x00124DD8
		private void Adddt(DataTable dt)
		{
			bool flag = dt.Columns.Contains("dt");
			if (!flag)
			{
				dt.Columns.Add("dt", typeof(DataTable));
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00148088 File Offset: 0x00146288
		private void LoadData()
		{
			bool flag = this.dt_keraye == null;
			if (flag)
			{
				this.dt_keraye = this.Furush_Keraye.GetByID(checked((int)this.Furush_ID));
			}
			this.RemoveZero(this.dt_keraye);
			this.GridEX1.DataSource = this.dt_keraye;
			this.Adddt(this.dt_keraye);
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x001480EC File Offset: 0x001462EC
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x00148180 File Offset: 0x00146380
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

		// Token: 0x06001C22 RID: 7202 RVA: 0x0014829C File Offset: 0x0014649C
		private void Delete(GridEXRow row)
		{
			bool flag = row.DataRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)row.DataRow;
				flag = (dataRowView["ID"] != DBNull.Value);
				if (flag)
				{
					bool flag2 = dataRowView["keraye_pardakht_id"] == DBNull.Value;
					if (flag2)
					{
						this.Furush_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
						this.GridEX1.CurrentRow.Delete();
						Public_Function.InvokeMethod("Frm_DaryaftPardakht", "Refresh_Keraye", null);
					}
					else
					{
						int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select count(ID)  from daryaftpardakht where id=", dataRowView["Keraye_pardakht_ID"]), " OR parent_id="), dataRowView["Keraye_pardakht_ID"])
						}, null, null, null));
						flag2 = (num == 1);
						if (flag2)
						{
							this.Furush_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
							this.GridEX1.CurrentRow.Delete();
							Public_Function.InvokeMethod("Frm_DaryaftPardakht", "Refresh_Keraye", null);
						}
						else
						{
							DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select *  from daryaftpardakht where id=", dataRowView["Keraye_pardakht_ID"]), " OR parent_id="), dataRowView["Keraye_pardakht_ID"])));
							bool flag3 = true;
							try
							{
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["dptype_id"], -4, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["dptype_id"], 10, false));
									if (flag2)
									{
										flag3 = false;
									}
								}
							}
							finally
							{
								IEnumerator enumerator;
								flag2 = (enumerator is IDisposable);
								if (flag2)
								{
									(enumerator as IDisposable).Dispose();
								}
							}
							flag2 = flag3;
							if (flag2)
							{
								this.Furush_Keraye.DeleteByID(Conversions.ToString(dataRowView["ID"]));
								this.GridEX1.CurrentRow.Delete();
								Public_Function.InvokeMethod("Frm_DaryaftPardakht", "Refresh_Keraye", null);
							}
							else
							{
								Public_Function.ShowMessage("پرداخت مورد نظر دارای پرداخت چک و یا کارت به کارت میباشد" + Environment.NewLine + "لطفا در ابتدا اقدام به حذف موارد ذکر شده نمایید", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
							}
						}
					}
				}
				else
				{
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x00148550 File Offset: 0x00146750
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
					flag2 = (this.GridEX1.GetRows().Length == 0);
					if (flag2)
					{
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = this.GridEX1.RootTable.Columns["Tarikh_Fa"].Position;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
				}
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x00148614 File Offset: 0x00146814
		private void Hazine_Select(char chr = '\0')
		{
			string str = string.Empty;
			str = " where id not in (-6)";
			this.frm.chara = chr;
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

		// Token: 0x06001C25 RID: 7205 RVA: 0x00148730 File Offset: 0x00146930
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["hazine_kharid_Name"].Position;
			if (flag)
			{
				this.Hazine_Select('\0');
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
								frm_PardakhtMoshtari.Tozih = "فروش شماره " + this.Furush_num;
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

		// Token: 0x06001C26 RID: 7206 RVA: 0x00148A78 File Offset: 0x00146C78
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

		// Token: 0x06001C27 RID: 7207 RVA: 0x00148B18 File Offset: 0x00146D18
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

		// Token: 0x06001C28 RID: 7208 RVA: 0x00148BE0 File Offset: 0x00146DE0
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
									this.Hazine_Select('\0');
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

		// Token: 0x06001C29 RID: 7209 RVA: 0x0014914C File Offset: 0x0014734C
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

		// Token: 0x06001C2A RID: 7210 RVA: 0x0014931C File Offset: 0x0014751C
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

		// Token: 0x06001C2B RID: 7211 RVA: 0x00149348 File Offset: 0x00147548
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.F5;
			if (flag)
			{
				this.DelKala();
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00149384 File Offset: 0x00147584
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

		// Token: 0x06001C2D RID: 7213 RVA: 0x001493EC File Offset: 0x001475EC
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["hazine_Kharid_name"].Position;
			bool flag2;
			if (flag)
			{
				flag2 = (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar));
				if (flag2)
				{
					this.Hazine_Select(e.KeyChar);
					e.Handled = true;
					return;
				}
				e.Handled = true;
			}
			flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["hazine_Kharid_name"].Position);
			if (flag2)
			{
				e.Handled = true;
			}
			flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position);
			if (flag2)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x001494E4 File Offset: 0x001476E4
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

		// Token: 0x04000AEB RID: 2795
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000AED RID: 2797
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000AEE RID: 2798
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000AEF RID: 2799
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000AF0 RID: 2800
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000AF1 RID: 2801
		private Frm_SelectItem frm;

		// Token: 0x04000AF2 RID: 2802
		private Furush_Keraye Furush_Keraye;

		// Token: 0x04000AF3 RID: 2803
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000AF4 RID: 2804
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000AF5 RID: 2805
		[CompilerGenerated]
		private DataTable _dt_keraye;

		// Token: 0x04000AF6 RID: 2806
		[CompilerGenerated]
		private long _Furush_ID;

		// Token: 0x04000AF7 RID: 2807
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000AF8 RID: 2808
		[CompilerGenerated]
		private string _Furush_num;

		// Token: 0x04000AF9 RID: 2809
		private bool prevent;
	}
}
