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
	// Token: 0x02000113 RID: 275
	[DesignerGenerated]
	public partial class Frm_Sud_Kharid_Sardkhane : Form
	{
		// Token: 0x060027B5 RID: 10165 RVA: 0x001E0194 File Offset: 0x001DE394
		public Frm_Sud_Kharid_Sardkhane()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Sud_Kharid_Sardkhane.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Kharid_Darsad = new Kharid_Sardkhane_Darsad();
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x001E0210 File Offset: 0x001DE410
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sud_Kharid_Sardkhane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sud_Kharid_Sardkhane.__ENCList.Count == Frm_Sud_Kharid_Sardkhane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sud_Kharid_Sardkhane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sud_Kharid_Sardkhane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sud_Kharid_Sardkhane.__ENCList[num] = Frm_Sud_Kharid_Sardkhane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sud_Kharid_Sardkhane.__ENCList.RemoveRange(num, Frm_Sud_Kharid_Sardkhane.__ENCList.Count - num);
						Frm_Sud_Kharid_Sardkhane.__ENCList.Capacity = Frm_Sud_Kharid_Sardkhane.__ENCList.Count;
					}
					Frm_Sud_Kharid_Sardkhane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x060027B9 RID: 10169 RVA: 0x001E0AAC File Offset: 0x001DECAC
		// (set) Token: 0x060027BA RID: 10170 RVA: 0x00009DC1 File Offset: 0x00007FC1
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

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x060027BB RID: 10171 RVA: 0x001E0AC4 File Offset: 0x001DECC4
		// (set) Token: 0x060027BC RID: 10172 RVA: 0x00009DCB File Offset: 0x00007FCB
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

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x001E0ADC File Offset: 0x001DECDC
		// (set) Token: 0x060027BE RID: 10174 RVA: 0x00009DD5 File Offset: 0x00007FD5
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
				this._txt_darsad2 = value;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x001E0AF4 File Offset: 0x001DECF4
		// (set) Token: 0x060027C0 RID: 10176 RVA: 0x001E0B0C File Offset: 0x001DED0C
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
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value6 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value7 = new EventHandler(this.GridEX1_RecordAdded);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.EndCustomEdit -= value2;
					this._GridEX1.ColumnButtonClick -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.CellEdited -= value5;
					this._GridEX1.InitCustomEdit -= value6;
					this._GridEX1.RecordAdded -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.EndCustomEdit += value2;
					this._GridEX1.ColumnButtonClick += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.CellEdited += value5;
					this._GridEX1.InitCustomEdit += value6;
					this._GridEX1.RecordAdded += value7;
				}
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060027C1 RID: 10177 RVA: 0x001E0C40 File Offset: 0x001DEE40
		// (set) Token: 0x060027C2 RID: 10178 RVA: 0x00009DDF File Offset: 0x00007FDF
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

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x001E0C58 File Offset: 0x001DEE58
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00009DE9 File Offset: 0x00007FE9
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

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x001E0C70 File Offset: 0x001DEE70
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00009DF3 File Offset: 0x00007FF3
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

		// Token: 0x060027C7 RID: 10183 RVA: 0x001DF348 File Offset: 0x001DD548
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

		// Token: 0x060027C8 RID: 10184 RVA: 0x001E0C88 File Offset: 0x001DEE88
		private void LoadData()
		{
			bool flag = this.dt_Darsad == null;
			if (flag)
			{
				this.dt_Darsad = this.Kharid_Darsad.GetByID(checked((int)this.Kharid_ID));
			}
			this.RemoveZero(this.dt_Darsad);
			this.GridEX1.DataSource = this.dt_Darsad;
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x001E0CE0 File Offset: 0x001DEEE0
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

		// Token: 0x060027CA RID: 10186 RVA: 0x001E0D40 File Offset: 0x001DEF40
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.CanDelete = false;
			string text = Public_Function.GetID(this.dt_Darsad, "Moshtari_ID", "");
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				text += ",-1,-2,-3,-4";
			}
			else
			{
				text = "-1,-2,-3,-4";
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

		// Token: 0x060027CB RID: 10187 RVA: 0x001E0EB0 File Offset: 0x001DF0B0
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
					Kharid_sardkhane kharid_sardkhane = new Kharid_sardkhane();
					int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select num from kharid_Sardkhane where id=" + Conversions.ToString(this.Kharid_ID)));
					kharid_sardkhane.UpdateDaramad(Conversions.ToString(value));
					this.GridEX1.CurrentRow.Delete();
					decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
					this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), d).ToString();
					this.txt_darsad2.Text = this.txt_darsad2.Text.Replace(",0", "");
				}
			}
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x001E100C File Offset: 0x001DF20C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "darsad", false) == 0;
			if (flag)
			{
				decimal d = Conversions.ToDecimal(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["darsad"], AggregateFunction.Sum));
				this.txt_darsad2.Text = decimal.Subtract(new decimal(100L), d).ToString();
				this.txt_darsad2.Text = this.txt_darsad2.Text.Replace(",0", "");
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x001E10B4 File Offset: 0x001DF2B4
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

		// Token: 0x060027CE RID: 10190 RVA: 0x001E1130 File Offset: 0x001DF330
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
								}
								else
								{
									this.GridEX1.MoveToNewRecord();
									this.GridEX1.Col = 0;
									this.GridEX1.EditMode = EditMode.EditOn;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x001E14C4 File Offset: 0x001DF6C4
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

		// Token: 0x060027D0 RID: 10192 RVA: 0x001E174C File Offset: 0x001DF94C
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.ValidateGridData();
			if (!flag)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x001E1774 File Offset: 0x001DF974
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.GridEX1.MoveToNewRecord();
				this.Close();
			}
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x001E17A8 File Offset: 0x001DF9A8
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

		// Token: 0x060027D3 RID: 10195 RVA: 0x001E1884 File Offset: 0x001DFA84
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

		// Token: 0x060027D4 RID: 10196 RVA: 0x001DDA1C File Offset: 0x001DBC1C
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "darsad", false) == 0;
			if (flag)
			{
				e.Value = ((NumericBox)e.EditControl).Text;
			}
		}

		// Token: 0x04000F80 RID: 3968
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F82 RID: 3970
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F83 RID: 3971
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F84 RID: 3972
		[AccessedThroughProperty("txt_darsad2")]
		private NumericBox _txt_darsad2;

		// Token: 0x04000F85 RID: 3973
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F86 RID: 3974
		[AccessedThroughProperty("txt_darsad")]
		private NumericBox _txt_darsad;

		// Token: 0x04000F87 RID: 3975
		private Frm_SelectItem frm;

		// Token: 0x04000F88 RID: 3976
		private Kharid_Sardkhane_Darsad Kharid_Darsad;

		// Token: 0x04000F89 RID: 3977
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000F8A RID: 3978
		[CompilerGenerated]
		private DataTable _dt_Darsad;

		// Token: 0x04000F8B RID: 3979
		private bool prevent;
	}
}
