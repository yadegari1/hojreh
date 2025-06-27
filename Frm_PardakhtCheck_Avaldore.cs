using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000103 RID: 259
	[DesignerGenerated]
	public partial class Frm_PardakhtCheck_Avaldore : Form
	{
		// Token: 0x060022AD RID: 8877 RVA: 0x0019E610 File Offset: 0x0019C810
		public Frm_PardakhtCheck_Avaldore()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_PardakhtCheck_Avaldore.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			DataTable dt = new DataTable();
			this.dt = dt;
			bool delFlag = false;
			this.DelFlag = delFlag;
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.InitializeComponent();
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0019E6A8 File Offset: 0x0019C8A8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_PardakhtCheck_Avaldore.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_PardakhtCheck_Avaldore.__ENCList.Count == Frm_PardakhtCheck_Avaldore.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_PardakhtCheck_Avaldore.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_PardakhtCheck_Avaldore.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_PardakhtCheck_Avaldore.__ENCList[num] = Frm_PardakhtCheck_Avaldore.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_PardakhtCheck_Avaldore.__ENCList.RemoveRange(num, Frm_PardakhtCheck_Avaldore.__ENCList.Count - num);
						Frm_PardakhtCheck_Avaldore.__ENCList.Capacity = Frm_PardakhtCheck_Avaldore.__ENCList.Count;
					}
					Frm_PardakhtCheck_Avaldore.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0019EFDC File Offset: 0x0019D1DC
		// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0019EFF4 File Offset: 0x0019D1F4
		internal virtual GridEX GridEX1
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
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				EndCustomEditEventHandler value4 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				InitCustomEditEventHandler value7 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyPress -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.EndCustomEdit -= value4;
					this._GridEX1.CellEdited -= value5;
					this._GridEX1.ColumnButtonClick -= value6;
					this._GridEX1.InitCustomEdit -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyPress += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.EndCustomEdit += value4;
					this._GridEX1.CellEdited += value5;
					this._GridEX1.ColumnButtonClick += value6;
					this._GridEX1.InitCustomEdit += value7;
				}
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0019F128 File Offset: 0x0019D328
		// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0019F140 File Offset: 0x0019D340
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_mablagh_KeyDown);
				bool flag = this._txt_mablagh != null;
				if (flag)
				{
					this._txt_mablagh.KeyDown -= value2;
				}
				this._txt_mablagh = value;
				flag = (this._txt_mablagh != null);
				if (flag)
				{
					this._txt_mablagh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0019F1A0 File Offset: 0x0019D3A0
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x00008ED6 File Offset: 0x000070D6
		internal virtual MetroStatusBar MetroStatusBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._MetroStatusBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._MetroStatusBar1 = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0019F1B8 File Offset: 0x0019D3B8
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x00008EE0 File Offset: 0x000070E0
		internal virtual LabelItem LabelItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem1 = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0019F1D0 File Offset: 0x0019D3D0
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x00008EEA File Offset: 0x000070EA
		internal virtual LabelItem lbl_kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_kol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_kol = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x0019F1E8 File Offset: 0x0019D3E8
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x00008EF4 File Offset: 0x000070F4
		internal virtual LabelItem LabelItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelItem2 = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0019F200 File Offset: 0x0019D400
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x00008EFE File Offset: 0x000070FE
		internal virtual LabelItem lbl_jamCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jamCheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jamCheck = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0019F218 File Offset: 0x0019D418
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x0019F230 File Offset: 0x0019D430
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
				DateBox2.OnLeftEventHandler obj = new DateBox2.OnLeftEventHandler(this.txt_tarikhGrid_OnLeft);
				DateBox2.OnRightEventHandler obj2 = new DateBox2.OnRightEventHandler(this.txt_tarikhGrid_OnRight);
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnLeft -= obj;
					this._txt_tarikhGrid.OnRight -= obj2;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnLeft += obj;
					this._txt_tarikhGrid.OnRight += obj2;
				}
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0019F2B8 File Offset: 0x0019D4B8
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00008F08 File Offset: 0x00007108
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

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x0019F2D0 File Offset: 0x0019D4D0
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0019F2E8 File Offset: 0x0019D4E8
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

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0019F348 File Offset: 0x0019D548
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0019F360 File Offset: 0x0019D560
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0019F3C0 File Offset: 0x0019D5C0
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00008F12 File Offset: 0x00007112
		public long sum_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sum_mablagh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sum_mablagh = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0019F3D8 File Offset: 0x0019D5D8
		// (set) Token: 0x060022CA RID: 8906 RVA: 0x00008F1C File Offset: 0x0000711C
		public DataTable dt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0019F3F0 File Offset: 0x0019D5F0
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x00008F26 File Offset: 0x00007126
		public bool DelFlag
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DelFlag;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DelFlag = value;
			}
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x0019F408 File Offset: 0x0019D608
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				this.GridEX1.MoveLast();
				this.GridEX1.Focus();
				this.GridEX1.Col = 1;
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.CurrentRow.BeginEdit();
			}
			catch (Exception expr_53)
			{
				ProjectData.SetProjectError(expr_53);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0019F48C File Offset: 0x0019D68C
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			GridEXRow[] rows = this.GridEX1.GetRows();
			int i = 0;
			checked
			{
				bool result;
				while (i < rows.Length)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = Operators.CompareString(gridEXRow.Cells["mablagh"].Value.ToString(), string.Empty, false) == 0;
					if (flag)
					{
						Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Mablagh", "مبلغ چک را وارد کنید");
						result = false;
					}
					else
					{
						flag = (Operators.CompareString(gridEXRow.Cells["Sh_Check"].Value.ToString(), string.Empty, false) == 0);
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Sh_Check", "شماره چک را وارد کنید");
							result = false;
						}
						else
						{
							flag = (Operators.CompareString(gridEXRow.Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
								result = false;
							}
							else
							{
								flag = !Public_Function.IsValidShamsiDate(Conversions.ToString(gridEXRow.Cells["Check_Sarresid_Fa"].Value));
								if (!flag)
								{
									i++;
									continue;
								}
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
								result = false;
							}
						}
					}
					return result;
				}
				result = true;
				return result;
			}
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0019F600 File Offset: 0x0019D800
		private DataTable LoadData()
		{
			return this.dt;
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0000205D File Offset: 0x0000025D
		private void UpdateCheck()
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0019F618 File Offset: 0x0019D818
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGrid();
			if (flag)
			{
				e.Cancel = true;
			}
			this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0019F674 File Offset: 0x0019D874
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			bool flag2;
			if (flag)
			{
				flag2 = (Public_Function.ShowMessage("آیا مایل به ثبت اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag2)
				{
					this.ButtonItem2_Click(null, null);
				}
				this.Close();
			}
			flag2 = (e.KeyCode == Keys.F2);
			if (flag2)
			{
				this.ButtonItem2_Click(null, null);
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00008F30 File Offset: 0x00007130
		private void GetData()
		{
			this.dt = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,  DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Hazine_ID, DaryaftPardakht.Daramad_ID, DaryaftPardakht.Mablagh,                                   DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe,                                     DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab,                                       DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.PardakhtCheck_ID,                          DaryaftPardakht.Parent_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank.Name + N' ' + Bank_Hesab.Shobe AS CheckBank_Name                                   FROM         DaryaftPardakht INNER JOIN                                                                                                                                    Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID INNER JOIN                                                                                                           DasteCheckBarg ON DaryaftPardakht.CheckBarg_ID = DasteCheckBarg.ID INNER JOIN                                                                                              DasteCheck ON DasteCheckBarg.DasteCheck_ID = DasteCheck.ID INNER JOIN                                                                                                      Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN                                                                                                           Bank ON Bank_Hesab.Bank_ID = Bank.ID                                                                                                                                        WHERE     (DaryaftPardakht.dpType_ID = - 98)");
			this.dt.TableName = "data";
			this.GridEX1.DataSource = this.dt;
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0019F6D0 File Offset: 0x0019D8D0
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("ID", "کد", 10));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection;
			this.GetData();
			this.GetSum();
			this.GridEX1.Focus();
			this.GridEX1.Col = 0;
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.CurrentRow.BeginEdit();
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0019F780 File Offset: 0x0019D980
		private void Bank_Select()
		{
			bool flag = this.frm.ShowDialog("select id,Name  from Bank", MyProject.Forms.Frm_Bank, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						GridEX gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0019F874 File Offset: 0x0019DA74
		private void Shobe_Select()
		{
			DataTable dt = Public_Function.FillData("select distinct Check_shobe as name  from daryaftpardakht where Check_Shobe is not null");
			bool flag = this.frm.ShowDialog(dt, null, "انتخاب شعبه") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						GridEX gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x0019F930 File Offset: 0x0019DB30
		private int is_Tekrari()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			checked
			{
				int result;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("id is null and checkbank_id= ", dataRow["checkbank_id"]), " and sh_check='"), dataRow["sh_check"]), "' and mablagh="), dataRow["mablagh"])));
						bool flag = array.Length > 0;
						if (flag)
						{
							int arg_9B_0 = 0;
							int num = array.Length - 1;
							int num2 = arg_9B_0;
							while (true)
							{
								int arg_E7_0 = num2;
								int num3 = num;
								if (arg_E7_0 > num3)
								{
									goto IL_E9;
								}
								bool flag2 = dataTable.Rows.IndexOf(array[num2]) != dataTable.Rows.IndexOf(dataRow);
								if (flag2)
								{
									break;
								}
								num2++;
							}
							result = dataTable.Rows.IndexOf(array[num2]);
							return result;
						}
						IL_E9:;
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
				result = -1;
				return result;
			}
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0019FA74 File Offset: 0x0019DC74
		private void GetSum()
		{
			long num = 0L;
			int arg_13_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_13_0;
				while (true)
				{
					int arg_81_0 = num3;
					int num4 = num2;
					if (arg_81_0 > num4)
					{
						break;
					}
					bool flag = this.GridEX1.GetRow(num3).Cells["Mablagh"].Value != DBNull.Value;
					if (flag)
					{
						num = Conversions.ToLong(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells["Mablagh"].Value));
					}
					num3++;
				}
				this.lbl_jamCheck.Text = Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				this.MetroStatusBar1.Refresh();
				this.lbl_jamCheck.Refresh();
			}
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x0019FB38 File Offset: 0x0019DD38
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				this.GetSum();
			}
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x000EEC3C File Offset: 0x000ECE3C
		private void DeletefromDb(long id)
		{
			string text = "declare @bed_id bigint;declare @bes_id bigint;";
			text = text + "select @bed_id=sanadbed_id,@bes_id=sanadbes_id from daryaftpardakht where id=" + Conversions.ToString(id) + ";";
			text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(id) + ";";
			text += "delete from sanad where id =@bed_id;";
			text += "delete from sanad where id =@bes_id;";
			text = text + "delete from daryaftpardakht where id = " + Conversions.ToString(id) + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0019FB74 File Offset: 0x0019DD74
		private void Delete_Check(GridEXRow row)
		{
			DataTable dataTable = new DataTable();
			bool flag = ((DataRowView)row.DataRow)["ID"] == DBNull.Value;
			long value;
			if (flag)
			{
				value = 0L;
			}
			else
			{
				value = Conversions.ToLong(((DataRowView)row.DataRow)["ID"]);
			}
			flag = (((DataRowView)row.DataRow)["Check_status"] != DBNull.Value);
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectNotEqual(((DataRowView)row.DataRow)["Check_status"], 5, false);
				if (flag2)
				{
					Public_Function.ShowMessage("چک مورد نظر دارای عملیات دریافت / پرداخت میباشد" + Environment.NewLine + "امکان حذف چک وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					return;
				}
			}
			dataTable = Public_Function.FillData("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type=2 and DaryaftPardakht.pardakhtcheck_id=" + Conversions.ToString(value));
			flag2 = (((DataRowView)row.DataRow)["ID"] == DBNull.Value);
			if (flag2)
			{
			}
			flag2 = (Public_Function.ShowMessage("آیا مایل به حذف چک مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
			if (flag2)
			{
				flag = (((DataRowView)row.DataRow)["ID"] != DBNull.Value);
				if (flag)
				{
					this.DeletefromDb(Conversions.ToLong(((DataRowView)row.DataRow)["ID"]));
				}
				this.GridEX1.CurrentRow.Delete();
				this.DelFlag = true;
				((DataTable)this.GridEX1.DataSource).AcceptChanges();
				this.GetSum();
			}
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0019FD0C File Offset: 0x0019DF0C
		private void Moshtari_select(GridEX grid)
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			bool flag = this.frm.ShowDialog("SELECT     Moshtari.ID, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0)", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = grid.Col == grid.RootTable.Columns["moshtari_Name"].Position && grid.EditTextBox != null;
					if (flag2)
					{
						grid.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						flag2 = (grid.GetRow().Cells["check_status"].Value == null);
						if (flag2)
						{
							grid.GetRow().Cells["Check_status"].Value = 1;
						}
						grid.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						grid.Col++;
						grid.EditMode = EditMode.EditOn;
					}
				}
				this.frm.CanEdit = false;
				this.frm.Edit_Frm = null;
			}
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0019FE6C File Offset: 0x0019E06C
		private void Daste_Check_Select()
		{
			Frm_SelectDasteCheck frm_SelectDasteCheck = new Frm_SelectDasteCheck();
			bool flag = this.GridEX1.CurrentRow.Cells["CheckBarg_ID"].Value != DBNull.Value;
			if (flag)
			{
				Frm_SelectDasteCheck arg_68_0 = frm_SelectDasteCheck;
				object expr_56 = this.GridEX1.CurrentRow.Cells["CheckBarg_ID"].Value;
				int? num;
				arg_68_0.ID = ((expr_56 != null) ? ((int?)expr_56) : num);
			}
			string text = string.Empty;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (gridEXRow.Cells["Checkbarg_id"].Value != DBNull.Value);
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(gridEXRow.Cells["Checkbarg_id"].Value, ",")));
					}
				}
				text = Public_Function.RemoveLast(text);
				frm_SelectDasteCheck.Notin_Me = text;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SelectDasteCheck);
				flag = (frm_SelectDasteCheck.ShomareBarg != null);
				if (flag)
				{
					this.GridEX1.CurrentRow.Cells["Sh_Check"].Value = frm_SelectDasteCheck.ShomareBarg;
					this.GridEX1.CurrentRow.Cells["CheckBarg_ID"].Value = frm_SelectDasteCheck.ID;
					this.GridEX1.CurrentRow.Cells["CheckBank_Name"].Value = frm_SelectDasteCheck.BankHesab_Name;
					GridEX gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x001A0034 File Offset: 0x0019E234
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_select(this.GridEX1);
			}
			else
			{
				flag = (position == this.GridEX1.RootTable.Columns["Sh_Check"].Position);
				if (flag)
				{
					this.Daste_Check_Select();
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["del"].Position);
					if (flag)
					{
						bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
						if (flag2)
						{
							this.Delete_Check(this.GridEX1.CurrentRow);
						}
						flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
						if (flag2)
						{
							this.GridEX1.CancelCurrentEdit();
							this.GetSum();
						}
					}
				}
			}
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x000EA1CC File Offset: 0x000E83CC
		private void GridEX1_EndCustomEdit(object sender, EndCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
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

		// Token: 0x060022E0 RID: 8928 RVA: 0x001A0138 File Offset: 0x0019E338
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "check_sarresid_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				flag = (e.Value != null);
				if (flag)
				{
					this.txt_tarikhGrid.SetDate(e.Value.ToString());
				}
				else
				{
					this.txt_tarikhGrid.SetDefault();
				}
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

		// Token: 0x060022E1 RID: 8929 RVA: 0x001A0220 File Offset: 0x0019E420
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.GetRow() == null);
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
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position);
							if (flag2)
							{
								this.GridEX1.CurrentRow.Cells["CheckBank_ID"].Value = DBNull.Value;
							}
						}
						switch (e.KeyData)
						{
						case Keys.Left:
						{
							flag2 = this.prevent_left;
							if (flag2)
							{
								this.prevent_left = false;
								this.GridEX1.EditMode = EditMode.EditOn;
								return;
							}
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["check_sarresid_fa"].Position);
							if (flag2)
							{
								e.SuppressKeyPress = true;
								return;
							}
							GridEX gridEX = this.GridEX1;
							gridEX.Col++;
							e.SuppressKeyPress = true;
							return;
						}
						case Keys.Up:
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["check_sarresid_fa"].Position);
							if (flag2)
							{
								this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Up));
								e.SuppressKeyPress = true;
								return;
							}
							flag2 = (this.GridEX1.Row > 0);
							if (flag2)
							{
								GridEX gridEX = this.GridEX1;
								gridEX.Row--;
								e.SuppressKeyPress = true;
								return;
							}
							break;
						case Keys.Right:
							flag2 = this.prevent_right;
							if (flag2)
							{
								this.prevent_right = false;
								return;
							}
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["check_sarresid_fa"].Position);
							if (flag2)
							{
								e.SuppressKeyPress = true;
								return;
							}
							flag2 = (this.GridEX1.Col > 0);
							if (flag2)
							{
								GridEX gridEX = this.GridEX1;
								gridEX.Col--;
								e.SuppressKeyPress = true;
								return;
							}
							break;
						case Keys.Down:
							flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["check_sarresid_fa"].Position);
							if (flag2)
							{
								this.txt_tarikhGrid.Me_KeyDown(this.txt_tarikhGrid, new KeyEventArgs(Keys.Down));
								e.SuppressKeyPress = true;
								return;
							}
							flag2 = (this.GridEX1.Row < this.GridEX1.RowCount - 1);
							if (flag2)
							{
								GridEX gridEX = this.GridEX1;
								gridEX.Row++;
								e.SuppressKeyPress = true;
								return;
							}
							break;
						}
						flag2 = (e.KeyCode == Keys.Return);
						bool flag3;
						if (flag2)
						{
							int col = this.GridEX1.Col;
							flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
							if (flag)
							{
								flag3 = (this.GridEX1.EditTextBox == null);
								if (flag3)
								{
									this.GridEX1.GetRow().BeginEdit();
								}
								flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (flag3)
								{
									this.Moshtari_select(this.GridEX1);
								}
								else
								{
									GridEX gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
							else
							{
								flag3 = (col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position);
								if (flag3)
								{
									flag2 = (this.GridEX1.EditTextBox == null);
									if (flag2)
									{
										this.GridEX1.GetRow().BeginEdit();
									}
									flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag3)
									{
										this.Bank_Select();
									}
									else
									{
										GridEX gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
								else
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["sh_Check"].Position);
									if (flag3)
									{
										flag2 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
										if (flag2)
										{
											this.Daste_Check_Select();
										}
										else
										{
											GridEX gridEX = this.GridEX1;
											gridEX.Col++;
										}
									}
									else
									{
										flag3 = (col == this.GridEX1.RootTable.Columns["Check_sarresid_Fa"].Position);
										if (flag3)
										{
											flag2 = this.prevent;
											if (flag2)
											{
												this.prevent = false;
												return;
											}
											this.MoveToNewRecord();
											e.SuppressKeyPress = true;
										}
										else
										{
											flag3 = this.prevent;
											if (flag3)
											{
												this.prevent = false;
												return;
											}
											GridEX gridEX = this.GridEX1;
											gridEX.Col++;
										}
									}
								}
							}
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
						if (flag3)
						{
							e.SuppressKeyPress = true;
						}
						flag3 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position);
						if (flag3)
						{
							e.SuppressKeyPress = true;
						}
					}
				}
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x001A088C File Offset: 0x0019EA8C
		private void MoveToNewRecord()
		{
			checked
			{
				bool flag = this.GridEX1.Row < this.GridEX1.RowCount - 1;
				if (flag)
				{
					this.GridEX1.Col = 0;
					GridEX gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.Focus();
				}
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x001A08EC File Offset: 0x0019EAEC
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position;
			bool flag2;
			if (flag)
			{
				flag2 = (Strings.Asc(e.KeyChar) == 8);
				if (flag2)
				{
					return;
				}
			}
			flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position);
			if (flag2)
			{
				e.Handled = true;
			}
			flag2 = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
			if (flag2)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x001A09B8 File Offset: 0x0019EBB8
		private void txt_mablagh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					GridEX gridEX = this.GridEX1;
					gridEX.Col++;
					this.prevent = true;
				}
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x001A09F4 File Offset: 0x0019EBF4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = !this.ValidateGrid();
			if (!flag)
			{
				string text = string.Empty;
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				string text2 = "1392/01/01";
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["id"] == DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,CheckBarg_ID,Check_Status) VALUES(-98," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(text2)) + ",NULL,NULL ," + Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"])) + ",NULL,", dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(text2)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ",NULL,NULL,"), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ",NULL,"), Public_Function.GetValueInt(Conversions.ToString(dataRow["checkbarg_ID"]))), ",5);")));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Check_Status"], 5, false);
							if (!flag)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=-98 ,Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(text2)) + " ,Moshtari_ID=" + Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"])) + " ,BankHesab_ID=null" + " ,Hazine_ID=Null" + " ,Mablagh=", dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(text2)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,[CheckBank_ID] = NULL"), " ,Check_Shobe=NULL"), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab=NULL"), " ,Check_status=5"), " ,CheckBarg_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["checkbarg_ID"]))), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
							}
						}
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
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
				Public_Function.ConfirmInsert();
				this.GetData();
				this.GridEX1.Col = 1;
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.CurrentRow.BeginEdit();
			}
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00008F68 File Offset: 0x00007168
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00008F73 File Offset: 0x00007173
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x04000D84 RID: 3460
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000D86 RID: 3462
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000D87 RID: 3463
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000D88 RID: 3464
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x04000D89 RID: 3465
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000D8A RID: 3466
		[AccessedThroughProperty("lbl_kol")]
		private LabelItem _lbl_kol;

		// Token: 0x04000D8B RID: 3467
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000D8C RID: 3468
		[AccessedThroughProperty("lbl_jamCheck")]
		private LabelItem _lbl_jamCheck;

		// Token: 0x04000D8D RID: 3469
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000D8E RID: 3470
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000D8F RID: 3471
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000D90 RID: 3472
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000D91 RID: 3473
		private Frm_SelectItem frm;

		// Token: 0x04000D92 RID: 3474
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x04000D93 RID: 3475
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000D94 RID: 3476
		[CompilerGenerated]
		private bool _DelFlag;

		// Token: 0x04000D95 RID: 3477
		private List<KeyValuePair<int, int>> check_id;

		// Token: 0x04000D96 RID: 3478
		private bool prevent;

		// Token: 0x04000D97 RID: 3479
		private bool prevent_right;

		// Token: 0x04000D98 RID: 3480
		private bool prevent_left;
	}
}
