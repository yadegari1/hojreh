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
	// Token: 0x020000F8 RID: 248
	[DesignerGenerated]
	public partial class Frm_Kharid_Sardkhane_Keraye : Form
	{
		// Token: 0x06001D4F RID: 7503 RVA: 0x00159BF4 File Offset: 0x00157DF4
		public Frm_Kharid_Sardkhane_Keraye()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Kharid_Sardkhane_Keraye.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Keraye = new Kharid_Sardkhane_Keraye();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06001D50 RID: 7504 RVA: 0x00159C70 File Offset: 0x00157E70
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Kharid_Sardkhane_Keraye.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Kharid_Sardkhane_Keraye.__ENCList.Count == Frm_Kharid_Sardkhane_Keraye.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Kharid_Sardkhane_Keraye.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Kharid_Sardkhane_Keraye.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Kharid_Sardkhane_Keraye.__ENCList[num] = Frm_Kharid_Sardkhane_Keraye.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Kharid_Sardkhane_Keraye.__ENCList.RemoveRange(num, Frm_Kharid_Sardkhane_Keraye.__ENCList.Count - num);
						Frm_Kharid_Sardkhane_Keraye.__ENCList.Capacity = Frm_Kharid_Sardkhane_Keraye.__ENCList.Count;
					}
					Frm_Kharid_Sardkhane_Keraye.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0015A428 File Offset: 0x00158628
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00008066 File Offset: 0x00006266
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

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0015A440 File Offset: 0x00158640
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0015A458 File Offset: 0x00158658
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
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value5 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value6 = new EventHandler(this.GridEX1_RecordAdded);
				EndCustomEditEventHandler value7 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.ColumnButtonClick -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.InitCustomEdit -= value5;
					this._GridEX1.RecordAdded -= value6;
					this._GridEX1.EndCustomEdit -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.ColumnButtonClick += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.InitCustomEdit += value5;
					this._GridEX1.RecordAdded += value6;
					this._GridEX1.EndCustomEdit += value7;
				}
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0015A58C File Offset: 0x0015878C
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00008070 File Offset: 0x00006270
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

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0015A5A4 File Offset: 0x001587A4
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0000807A File Offset: 0x0000627A
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

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0015A5BC File Offset: 0x001587BC
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x00008084 File Offset: 0x00006284
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

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0015A5D4 File Offset: 0x001587D4
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0000808E File Offset: 0x0000628E
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

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0015A5EC File Offset: 0x001587EC
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x00008098 File Offset: 0x00006298
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

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0015A604 File Offset: 0x00158804
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x000080A2 File Offset: 0x000062A2
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

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0015A61C File Offset: 0x0015881C
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x000080AC File Offset: 0x000062AC
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

		// Token: 0x06001D65 RID: 7525 RVA: 0x00147F90 File Offset: 0x00146190
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

		// Token: 0x06001D66 RID: 7526 RVA: 0x0015A634 File Offset: 0x00158834
		private void LoadData()
		{
			bool flag = this.dt_keraye == null;
			if (flag)
			{
				this.dt_keraye = this.Kharid_Keraye.GetByID(checked((int)this.Kharid_ID));
			}
			this.RemoveZero(this.dt_keraye);
			this.GridEX1.DataSource = this.dt_keraye;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0015A68C File Offset: 0x0015888C
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

		// Token: 0x06001D68 RID: 7528 RVA: 0x0015A720 File Offset: 0x00158920
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

		// Token: 0x06001D69 RID: 7529 RVA: 0x0015A83C File Offset: 0x00158A3C
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
					Kharid_sardkhane kharid_sardkhane = new Kharid_sardkhane();
					int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select num from kharid_sardkhane where id=" + Conversions.ToString(this.Kharid_ID)));
					kharid_sardkhane.UpdateDaramad(Conversions.ToString(value));
				}
				this.GridEX1.CurrentRow.Delete();
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x0015A8E8 File Offset: 0x00158AE8
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

		// Token: 0x06001D6B RID: 7531 RVA: 0x0015A950 File Offset: 0x00158B50
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

		// Token: 0x06001D6C RID: 7532 RVA: 0x0015AA7C File Offset: 0x00158C7C
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
				}
			}
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00148A78 File Offset: 0x00146C78
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

		// Token: 0x06001D6E RID: 7534 RVA: 0x0015AB28 File Offset: 0x00158D28
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

		// Token: 0x06001D6F RID: 7535 RVA: 0x0015ABF0 File Offset: 0x00158DF0
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

		// Token: 0x06001D70 RID: 7536 RVA: 0x0015B1F0 File Offset: 0x001593F0
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

		// Token: 0x06001D71 RID: 7537 RVA: 0x0015B3C0 File Offset: 0x001595C0
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

		// Token: 0x06001D72 RID: 7538 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x0015B3EC File Offset: 0x001595EC
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

		// Token: 0x06001D74 RID: 7540 RVA: 0x0015B454 File Offset: 0x00159654
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

		// Token: 0x06001D75 RID: 7541 RVA: 0x0015B4D8 File Offset: 0x001596D8
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

		// Token: 0x04000B69 RID: 2921
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000B6B RID: 2923
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000B6C RID: 2924
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000B6D RID: 2925
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000B6E RID: 2926
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000B6F RID: 2927
		private Frm_SelectItem frm;

		// Token: 0x04000B70 RID: 2928
		private Kharid_Sardkhane_Keraye Kharid_Keraye;

		// Token: 0x04000B71 RID: 2929
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000B72 RID: 2930
		[CompilerGenerated]
		private long _Moshtari_ID;

		// Token: 0x04000B73 RID: 2931
		[CompilerGenerated]
		private DataTable _dt_keraye;

		// Token: 0x04000B74 RID: 2932
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000B75 RID: 2933
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000B76 RID: 2934
		private bool prevent;
	}
}
