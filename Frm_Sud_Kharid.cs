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
	// Token: 0x02000112 RID: 274
	[DesignerGenerated]
	public partial class Frm_Sud_Kharid : Form
	{
		// Token: 0x06002783 RID: 10115 RVA: 0x001DE10C File Offset: 0x001DC30C
		public Frm_Sud_Kharid()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Sud_Kharid.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Darsad = new Kharid_Darsad();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x001DE188 File Offset: 0x001DC388
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sud_Kharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sud_Kharid.__ENCList.Count == Frm_Sud_Kharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sud_Kharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sud_Kharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sud_Kharid.__ENCList[num] = Frm_Sud_Kharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sud_Kharid.__ENCList.RemoveRange(num, Frm_Sud_Kharid.__ENCList.Count - num);
						Frm_Sud_Kharid.__ENCList.Capacity = Frm_Sud_Kharid.__ENCList.Count;
					}
					Frm_Sud_Kharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x001DF04C File Offset: 0x001DD24C
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x00009CFB File Offset: 0x00007EFB
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

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x001DF064 File Offset: 0x001DD264
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x00009D05 File Offset: 0x00007F05
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x001DF07C File Offset: 0x001DD27C
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x001DF094 File Offset: 0x001DD294
		internal virtual NumericBox txt_darsad2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_darsad2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_darsad2_TextChanged);
				bool flag = this._txt_darsad2 != null;
				if (flag)
				{
					this._txt_darsad2.TextChanged -= value2;
				}
				this._txt_darsad2 = value;
				flag = (this._txt_darsad2 != null);
				if (flag)
				{
					this._txt_darsad2.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x001DF0F4 File Offset: 0x001DD2F4
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x001DF10C File Offset: 0x001DD30C
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
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EventHandler value5 = new EventHandler(this.GridEX1_RecordAdded);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value7 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.ColumnButtonClick -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.RecordAdded -= value5;
					this._GridEX1.InitCustomEdit -= value6;
					this._GridEX1.EndCustomEdit -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.ColumnButtonClick += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.RecordAdded += value5;
					this._GridEX1.InitCustomEdit += value6;
					this._GridEX1.EndCustomEdit += value7;
				}
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x001DF240 File Offset: 0x001DD440
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00009D0F File Offset: 0x00007F0F
		internal virtual NumericBox txt_darsad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_darsad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_darsad = value;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x001DF258 File Offset: 0x001DD458
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x00009D19 File Offset: 0x00007F19
		internal virtual NumericBox txt_sanad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sanad;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sanad = value;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x001DF270 File Offset: 0x001DD470
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x00009D23 File Offset: 0x00007F23
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

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x001DF288 File Offset: 0x001DD488
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x00009D2D File Offset: 0x00007F2D
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06002797 RID: 10135 RVA: 0x001DF2A0 File Offset: 0x001DD4A0
		// (set) Token: 0x06002798 RID: 10136 RVA: 0x00009D37 File Offset: 0x00007F37
		internal virtual NumericBox txt_jam
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_jam = value;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x001DF2B8 File Offset: 0x001DD4B8
		// (set) Token: 0x0600279A RID: 10138 RVA: 0x00009D41 File Offset: 0x00007F41
		internal virtual CurrencyBox txt_mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mande;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mande = value;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x001DF2D0 File Offset: 0x001DD4D0
		// (set) Token: 0x0600279C RID: 10140 RVA: 0x00009D4B File Offset: 0x00007F4B
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600279D RID: 10141 RVA: 0x001DF2E8 File Offset: 0x001DD4E8
		// (set) Token: 0x0600279E RID: 10142 RVA: 0x00009D55 File Offset: 0x00007F55
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

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x001DF300 File Offset: 0x001DD500
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x00009D5F File Offset: 0x00007F5F
		public long Sh_Sanad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Sh_Sanad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Sh_Sanad = value;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x060027A1 RID: 10145 RVA: 0x001DF318 File Offset: 0x001DD518
		// (set) Token: 0x060027A2 RID: 10146 RVA: 0x00009D69 File Offset: 0x00007F69
		public long Jam
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Jam;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Jam = value;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x001DF330 File Offset: 0x001DD530
		// (set) Token: 0x060027A4 RID: 10148 RVA: 0x00009D73 File Offset: 0x00007F73
		public DataTable dt_Darsad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_Darsad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_Darsad = value;
			}
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x001DF348 File Offset: 0x001DD548
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["darsad"] != DBNull.Value;
					if (flag)
					{
						dataRow["darsad"] = dataRow["darsad"].ToString().Replace(",00", "").Replace(".0", "");
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

		// Token: 0x060027A6 RID: 10150 RVA: 0x00009D7D File Offset: 0x00007F7D
		private void txt_darsad2_TextChanged(object sender, EventArgs e)
		{
			this.txt_mande.Text = Conversions.ToString((double)this.Jam / 100.0 * Conversions.ToDouble(this.txt_darsad2.Text));
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x001DF404 File Offset: 0x001DD604
		private void LoadData()
		{
			this.txt_sanad.Text = Conversions.ToString(this.Sh_Sanad);
			this.txt_jam.Text = Conversions.ToString(this.Jam);
			bool flag = this.dt_Darsad == null;
			if (flag)
			{
				this.dt_Darsad = this.Kharid_Darsad.GetByID(checked((int)this.Kharid_ID));
			}
			this.RemoveZero(this.dt_Darsad);
			this.GridEX1.DataSource = this.dt_Darsad;
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x001DF488 File Offset: 0x001DD688
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["moshtari_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x001DF4E8 File Offset: 0x001DD6E8
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.CanDelete = false;
			string text = Public_Function.GetID(this.dt_Darsad, "Moshtari_ID", "");
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				text += ",-1,-2,-3,-4,-5,-6";
			}
			else
			{
				text = "-1,-2,-3,-4,-5,-6";
			}
			flag = (this.frm.ShowDialog("select Id,name + ' ' + Family as Name From Moshtari where id not in(" + text + ")", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
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

		// Token: 0x060027AA RID: 10154 RVA: 0x001DF658 File Offset: 0x001DD858
		private void Del()
		{
			bool flag = this.GridEX1.CurrentRow.RowType == RowType.Record;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.Cells["ID"].Value == DBNull.Value;
				if (flag2)
				{
					this.GridEX1.CurrentRow.Delete();
				}
				else
				{
					this.Kharid_Darsad.DeleteByID(Conversions.ToString(this.GridEX1.CurrentRow.Cells["ID"].Value));
					Kharid kharid = new Kharid();
					int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select num from kharid where id=" + Conversions.ToString(this.Kharid_ID)));
					kharid.UpdateDaramad(Conversions.ToString(value));
					this.GridEX1.CurrentRow.Delete();
					decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
					this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), d).ToString();
					this.txt_darsad2.Text = this.txt_darsad2.Text.Replace(",0", "");
				}
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x001DF7B4 File Offset: 0x001DD9B4
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "darsad", false) == 0;
			if (flag)
			{
				this.GridEX1.UpdateData();
				this.GridEX1.Focus();
				decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
				this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), d).ToString();
				this.txt_darsad2.Text = this.txt_darsad2.Text.Replace(",0", "");
				flag = (this.GridEX1.CurrentRow.Cells["darsad"].Value != DBNull.Value);
				if (flag)
				{
					this.GridEX1.CurrentRow.BeginEdit();
					this.GridEX1.CurrentRow.Cells["mablagh"].Value = Operators.MultiplyObject((double)this.Jam / 100.0, this.GridEX1.CurrentRow.Cells["darsad"].Value);
					this.GridEX1.CurrentRow.EndEdit();
				}
			}
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x001DF920 File Offset: 0x001DDB20
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_Select();
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
				if (flag)
				{
					this.Del();
				}
			}
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x001DF99C File Offset: 0x001DDB9C
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
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["Moshtari_ID"].Value = DBNull.Value;
						}
					}
					switch (e.KeyData)
					{
					case Keys.Left:
					{
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
						flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
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
								flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag3)
								{
									this.Moshtari_Select();
								}
								else
								{
									DataEntryGrid gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
						}
						else
						{
							bool flag3 = col == this.GridEX1.RootTable.Columns["Darsad"].Position;
							if (flag3)
							{
								flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
								if (flag2)
								{
									this.GridEX1.UpdateData();
									this.GridEX1.MoveToNewRecord();
									this.GridEX1.Col = 0;
									this.GridEX1.EditMode = EditMode.EditOn;
									this.GridEX1.MoveToNewRecord();
									this.GridEX1.Col = 0;
									this.GridEX1.EditMode = EditMode.EditOn;
								}
								else
								{
									this.GridEX1.MoveToNewRecord();
									this.GridEX1.CurrentRow.BeginEdit();
									this.GridEX1.Col = 0;
									this.GridEX1.EditMode = EditMode.EditOn;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x001DFD6C File Offset: 0x001DDF6C
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int i = 0;
			checked
			{
				bool flag;
				while (i <= dataTable.Rows.Count - 1)
				{
					flag = (dataTable.Rows[i].RowState == DataRowState.Deleted);
					if (flag)
					{
						i++;
					}
					else
					{
						flag = (dataTable.Rows[i]["Moshtari_ID"] == DBNull.Value && dataTable.Rows[i]["Darsad"] == DBNull.Value);
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
						flag = (dataRow["Moshtari_ID"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Moshtari_Name", "مشتری را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["Darsad"] == DBNull.Value);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Darsad", "درصد را وارد نمایید");
							result = false;
							return result;
						}
						flag = Operators.ConditionalCompareObjectEqual(dataRow["darsad"], 0, false);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Darsad", "درصد را وارد نمایید");
							result = false;
							return result;
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
				flag = (decimal.Compare(d, new decimal(100L)) > 0);
				if (flag)
				{
					Public_Function.ShowMessage("جمع درصدها بیشتر از 100 میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
				}
				else
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x001DFFF4 File Offset: 0x001DE1F4
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.ValidateGridData();
			if (!flag)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x001E001C File Offset: 0x001DE21C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.GridEX1.MoveToNewRecord();
				this.Close();
			}
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x001E0050 File Offset: 0x001DE250
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.LoadData();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
			decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
			this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), d).ToString();
			this.txt_darsad2.Text = this.txt_darsad2.Text.Replace(",0", "");
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x001E012C File Offset: 0x001DE32C
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "darsad", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_darsad;
				this.txt_darsad.Text = e.Value.ToString();
				this.txt_darsad.SelectAll();
			}
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x001DDA1C File Offset: 0x001DBC1C
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "darsad", false) == 0;
			if (flag)
			{
				e.Value = ((NumericBox)e.EditControl).Text;
			}
		}

		// Token: 0x04000F6C RID: 3948
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F6E RID: 3950
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F6F RID: 3951
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F70 RID: 3952
		[AccessedThroughProperty("txt_darsad2")]
		private NumericBox _txt_darsad2;

		// Token: 0x04000F71 RID: 3953
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F72 RID: 3954
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000F73 RID: 3955
		[AccessedThroughProperty("txt_sanad")]
		private NumericBox _txt_sanad;

		// Token: 0x04000F74 RID: 3956
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F75 RID: 3957
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000F76 RID: 3958
		[AccessedThroughProperty("txt_jam")]
		private NumericBox _txt_jam;

		// Token: 0x04000F77 RID: 3959
		[AccessedThroughProperty("txt_mande")]
		private CurrencyBox _txt_mande;

		// Token: 0x04000F78 RID: 3960
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000F79 RID: 3961
		private Frm_SelectItem frm;

		// Token: 0x04000F7A RID: 3962
		private Kharid_Darsad Kharid_Darsad;

		// Token: 0x04000F7B RID: 3963
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000F7C RID: 3964
		[CompilerGenerated]
		private long _Sh_Sanad;

		// Token: 0x04000F7D RID: 3965
		[CompilerGenerated]
		private long _Jam;

		// Token: 0x04000F7E RID: 3966
		[CompilerGenerated]
		private DataTable _dt_Darsad;

		// Token: 0x04000F7F RID: 3967
		private bool prevent;
	}
}
