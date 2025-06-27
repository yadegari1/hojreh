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
	// Token: 0x020000E6 RID: 230
	[DesignerGenerated]
	public partial class Frm_DaryaftCheck_Avaldore : Form
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x000EFC98 File Offset: 0x000EDE98
		public Frm_DaryaftCheck_Avaldore()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			Frm_DaryaftCheck_Avaldore.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.frmsql = new Frm_SelectItemSql();
			DataTable dt = new DataTable();
			this.dt = dt;
			bool delFlag = false;
			this.DelFlag = delFlag;
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.shomarehesab = new ShomareHesab();
			this.InitializeComponent();
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000EFD48 File Offset: 0x000EDF48
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DaryaftCheck_Avaldore.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DaryaftCheck_Avaldore.__ENCList.Count == Frm_DaryaftCheck_Avaldore.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DaryaftCheck_Avaldore.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DaryaftCheck_Avaldore.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DaryaftCheck_Avaldore.__ENCList[num] = Frm_DaryaftCheck_Avaldore.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DaryaftCheck_Avaldore.__ENCList.RemoveRange(num, Frm_DaryaftCheck_Avaldore.__ENCList.Count - num);
						Frm_DaryaftCheck_Avaldore.__ENCList.Capacity = Frm_DaryaftCheck_Avaldore.__ENCList.Count;
					}
					Frm_DaryaftCheck_Avaldore.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x000F0688 File Offset: 0x000EE888
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x000F06A0 File Offset: 0x000EE8A0
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
				KeyEventHandler value2 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				InitCustomEditEventHandler value4 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EndCustomEditEventHandler value5 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				KeyPressEventHandler value6 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.CellEdited -= value3;
					this._GridEX1.InitCustomEdit -= value4;
					this._GridEX1.EndCustomEdit -= value5;
					this._GridEX1.KeyPress -= value6;
					this._GridEX1.ColumnButtonClick -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.CellEdited += value3;
					this._GridEX1.InitCustomEdit += value4;
					this._GridEX1.EndCustomEdit += value5;
					this._GridEX1.KeyPress += value6;
					this._GridEX1.ColumnButtonClick += value7;
				}
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x000F07D4 File Offset: 0x000EE9D4
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x000F07EC File Offset: 0x000EE9EC
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

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x000F084C File Offset: 0x000EEA4C
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x00006DB0 File Offset: 0x00004FB0
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

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x000F0864 File Offset: 0x000EEA64
		// (set) Token: 0x0600162C RID: 5676 RVA: 0x00006DBA File Offset: 0x00004FBA
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

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x000F087C File Offset: 0x000EEA7C
		// (set) Token: 0x0600162E RID: 5678 RVA: 0x00006DC4 File Offset: 0x00004FC4
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

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x000F0894 File Offset: 0x000EEA94
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00006DCE File Offset: 0x00004FCE
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

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x000F08AC File Offset: 0x000EEAAC
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x00006DD8 File Offset: 0x00004FD8
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x000F08C4 File Offset: 0x000EEAC4
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x000F08DC File Offset: 0x000EEADC
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
				DateBox2.OnRightEventHandler obj = new DateBox2.OnRightEventHandler(this.txt_tarikhGrid_OnRight);
				DateBox2.OnLeftEventHandler obj2 = new DateBox2.OnLeftEventHandler(this.txt_tarikhGrid_OnLeft);
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnRight -= obj;
					this._txt_tarikhGrid.OnLeft -= obj2;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnRight += obj;
					this._txt_tarikhGrid.OnLeft += obj2;
				}
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000F0964 File Offset: 0x000EEB64
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x000F097C File Offset: 0x000EEB7C
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
				EventHandler value2 = new EventHandler(this.Bar1_ItemClick);
				bool flag = this._Bar1 != null;
				if (flag)
				{
					this._Bar1.ItemClick -= value2;
				}
				this._Bar1 = value;
				flag = (this._Bar1 != null);
				if (flag)
				{
					this._Bar1.ItemClick += value2;
				}
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x000F09DC File Offset: 0x000EEBDC
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x000F09F4 File Offset: 0x000EEBF4
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

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000F0A54 File Offset: 0x000EEC54
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x000F0A6C File Offset: 0x000EEC6C
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

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000F0ACC File Offset: 0x000EECCC
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x00006DE2 File Offset: 0x00004FE2
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

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x00006DEC File Offset: 0x00004FEC
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

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x000F0AFC File Offset: 0x000EECFC
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x00006DF6 File Offset: 0x00004FF6
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

		// Token: 0x06001641 RID: 5697 RVA: 0x000F0B14 File Offset: 0x000EED14
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

		// Token: 0x06001642 RID: 5698 RVA: 0x000F0B98 File Offset: 0x000EED98
		public void shomarehesab_chenged(DataRow dr)
		{
			string text = string.Empty;
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				bool flag;
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["Check_ShomareHesab"].Value, dr["prevshomarehesab"], false);
					if (flag)
					{
						gridEXRow.BeginEdit();
						gridEXRow.Cells["Check_ShomareHesab"].Value = RuntimeHelpers.GetObjectValue(dr["shomarehesab"]);
						gridEXRow.Cells["checkbank_Name"].Value = RuntimeHelpers.GetObjectValue(dr["bank_name"]);
						gridEXRow.Cells["checkbank_id"].Value = RuntimeHelpers.GetObjectValue(dr["bank_Id"]);
						gridEXRow.Cells["check_shobe"].Value = RuntimeHelpers.GetObjectValue(dr["shobe_Name"]);
						gridEXRow.Cells["shobe_id"].Value = RuntimeHelpers.GetObjectValue(dr["shobe_id"]);
						flag = (Operators.CompareString(text, string.Empty, false) == 0);
						if (flag)
						{
							text = string.Concat(new string[]
							{
								text,
								"update daryaftpardakht set check_shomarehesab=",
								Public_Function.GetValue(Conversions.ToString(dr["shomarehesab"])),
								",checkbank_id=",
								Public_Function.GetValue(Conversions.ToString(dr["bank_id"])),
								",check_shobe=",
								Public_Function.GetValue(Conversions.ToString(dr["shobe_Name"])),
								" where check_shomarehesab=",
								Public_Function.GetValue(Conversions.ToString(dr["prevshomarehesab"])),
								";"
							});
						}
						gridEXRow.EndEdit();
					}
				}
				this.GridEX1.UpdateData();
				flag = (Operators.CompareString(text, string.Empty, false) != 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000F0DD8 File Offset: 0x000EEFD8
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			GridEXRow[] rows = this.GridEX1.GetRows();
			int i = 0;
			checked
			{
				bool flag;
				bool result;
				while (i < rows.Length)
				{
					GridEXRow gridEXRow = rows[i];
					flag = (Operators.CompareString(gridEXRow.Cells["mablagh"].Value.ToString(), string.Empty, false) == 0);
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
							flag = (Operators.CompareString(gridEXRow.Cells["Check_Shobe"].Value.ToString(), string.Empty, false) == 0);
							if (flag)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Shobe", "شعبه صادر کننده چک را وارد کنید");
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
									if (flag)
									{
										Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک معتبر نمیباشد");
										result = false;
									}
									else
									{
										flag = (gridEXRow.Cells["CheckBank_ID"].Value == DBNull.Value);
										if (!flag)
										{
											flag = (gridEXRow.Cells["check_shomarehesab"].Value != DBNull.Value);
											if (flag)
											{
												this.shomarehesab.Update(Conversions.ToString(gridEXRow.Cells["check_shomarehesab"].Value), Conversions.ToString(gridEXRow.Cells["checkbank_id"].Value), Conversions.ToString(gridEXRow.Cells["shobe_id"].Value), Conversions.ToString(gridEXRow.Cells["check_shobe"].Value), "");
											}
											i++;
											continue;
										}
										Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "checkBank_Name", "بانک چک را مشخص فرمائید");
										result = false;
									}
								}
							}
						}
					}
					return result;
				}
				int num = this.is_Tekrari();
				flag = (num > -1);
				if (flag)
				{
					Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Sh_Check", "چک وارد شده تکراری میباشد");
					result = false;
					return result;
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x000F10BC File Offset: 0x000EF2BC
		private DataTable LoadData()
		{
			return this.dt;
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0000205D File Offset: 0x0000025D
		private void UpdateCheck()
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x000F10D4 File Offset: 0x000EF2D4
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGrid();
			if (flag)
			{
				e.Cancel = true;
			}
			this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x000F1130 File Offset: 0x000EF330
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

		// Token: 0x06001648 RID: 5704 RVA: 0x00006E00 File Offset: 0x00005000
		private void GetData()
		{
			this.dt = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,  DaryaftPardakht.Sandug_ID, DaryaftPardakht.BankHesab_ID, DaryaftPardakht.Hazine_ID, DaryaftPardakht.Daramad_ID, DaryaftPardakht.Mablagh,  DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID, DaryaftPardakht.Check_Shobe,  DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status, DaryaftPardakht.Check_ShomareHesab,  DaryaftPardakht.CheckBarg_ID, DaryaftPardakht.Sh_Fish, DaryaftPardakht.FishVariz, DaryaftPardakht.FishVariz_Fa, DaryaftPardakht.PardakhtCheck_ID,  DaryaftPardakht.Parent_ID, Bank.Name AS CheckBank_Name, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name   FROM         DaryaftPardakht INNER JOIN  Bank ON DaryaftPardakht.CheckBank_ID = Bank.ID INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID where dptype_id=-99");
			this.dt.TableName = "data";
			this.GridEX1.DataSource = this.dt;
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000F118C File Offset: 0x000EF38C
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("ID", "کد", 10));
			itemCollection.Add(new Column("Name", "عنوان", 65));
			itemCollection.Add(new Column("shahr", "منطقه", 25));
			this.frm.items = itemCollection;
			this.frm.AllowEnterToClose = true;
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection2.Add(new Column("ShomareHesab", "شماره حساب", 100));
			this.frmsql.items = itemCollection2;
			this.frmsql.Edit_Frm = MyProject.Forms.Frm_ShomareHesab;
			this.frmsql.CanEdit = true;
			this.GetData();
			this.GetSum();
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000F1260 File Offset: 0x000EF460
		private void ShomareHesab_Select()
		{
			this.frmsql.SelectedRow = null;
			bool flag = this.frmsql.ShowDialog("SELECT     ShomareHesab.ID, ShomareHesab.ShomareHesab, Bank.ID as Bank_ID, Bank.Name AS Bank_Name,Shobe.ID as Shobe_ID, Shobe.Name AS Shobe_Name   FROM         Bank INNER JOIN   ShomareHesab ON Bank.ID = ShomareHesab.Bank_ID LEFT OUTER JOIN    Shobe ON ShomareHesab.Shobe_ID = Shobe.ID where shomarehesab like '{0}%'", null, "") == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_ShomareHesab"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						bool flag3 = this.frmsql.SelectedRow != null;
						if (flag3)
						{
							this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frmsql.SelectedRow["shomarehesab"]);
							this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Bank_ID"]);
							this.GridEX1.GetRow().Cells["CheckBank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Bank_Name"]);
							this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Shobe_Name"]);
							this.GridEX1.GetRow().Cells["Shobe_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Shobe_ID"]);
							this.MoveToNewRecord();
							this.GridEX1.Col = 1;
						}
						else
						{
							flag3 = (Operators.CompareString(this.frmsql.EditBox1.Text, string.Empty, false) != 0);
							if (flag3)
							{
								this.GridEX1.EditTextBox.Text = this.frmsql.EditBox1.Text;
								GridEX gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000F1488 File Offset: 0x000EF688
		private void Bank_Select()
		{
			this.frm.AllowEnterToClose = false;
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

		// Token: 0x0600164C RID: 5708 RVA: 0x000F1588 File Offset: 0x000EF788
		private bool Shobe_Select()
		{
			this.frm.AllowEnterToClose = true;
			DataTable dt = Public_Function.FillData("select  name  from shobe ");
			this.frm.SelectedRow = null;
			bool flag = this.frm.ShowDialog(dt, null, "انتخاب شعبه") == DialogResult.OK;
			bool result;
			if (flag)
			{
				bool flag2 = this.frm.SelectedRow != null;
				if (flag2)
				{
					bool flag3 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position && this.GridEX1.EditTextBox != null;
					if (flag3)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						result = true;
						return result;
					}
				}
				else
				{
					bool flag3 = Operators.CompareString(this.frm.EditBox1.Text, string.Empty, false) != 0;
					if (flag3)
					{
						this.GridEX1.EditTextBox.Text = this.frm.EditBox1.Text;
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000F16B8 File Offset: 0x000EF8B8
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
								int arg_EA_0 = num2;
								int num3 = num;
								if (arg_EA_0 > num3)
								{
									goto IL_EC;
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
						IL_EC:;
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
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						string right = string.Empty;
						bool flag2 = dataRow2["ID"] != DBNull.Value;
						if (flag2)
						{
							right = Conversions.ToString(Operators.ConcatenateObject(" and id <>", dataRow2["ID"]));
						}
						DataRow dataRow3 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id in(2,-99) and moshtari_id=", dataRow2["moshtari_id"]), " and sh_check='"), dataRow2["sh_check"]), "' and mablagh="), dataRow2["mablagh"]), " and check_shomareHesab='"), dataRow2["check_shomareHesab"]), "'"), right)));
						flag2 = (dataRow3 != null);
						if (flag2)
						{
							result = dataTable.Rows.IndexOf(dataRow2);
							return result;
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					bool flag2 = enumerator2 is IDisposable;
					if (flag2)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				result = -1;
				return result;
			}
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000F195C File Offset: 0x000EFB5C
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

		// Token: 0x0600164F RID: 5711 RVA: 0x000F1A20 File Offset: 0x000EFC20
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				this.GetSum();
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000EEC3C File Offset: 0x000ECE3C
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

		// Token: 0x06001651 RID: 5713 RVA: 0x000EECB8 File Offset: 0x000ECEB8
		private void Update_MablaghNaghd(GridEXRow row)
		{
			bool flag = ((DataRowView)row.DataRow)["parent_id"] == DBNull.Value;
			if (!flag)
			{
				string text = "declare @id int;declare @sanadbes_id int;declare @mablagh bigint;";
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" select @id=id,@sanadbes_id=sanadbes_id from daryaftpardakht  where parent_id=", ((DataRowView)row.DataRow)["parent_id"]), " and dptype_id=1;")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update daryaftpardakht set mablagh=mablagh+", row.Cells["mablagh"].Value), " where id=@id;")));
				text += "select @mablagh=mablagh from daryaftpardakht where id=@id;";
				text += " update sanad set bes=@mablagh where id=@sanadbes_id;";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000F1A5C File Offset: 0x000EFC5C
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
				flag2 = Operators.ConditionalCompareObjectNotEqual(((DataRowView)row.DataRow)["Check_status"], 1, false);
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
					this.Update_MablaghNaghd(row);
				}
				this.GridEX1.CurrentRow.Delete();
				this.DelFlag = true;
				((DataTable)this.GridEX1.DataSource).AcceptChanges();
				this.GetSum();
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x000F1C00 File Offset: 0x000EFE00
		private void Moshtari_select(GridEX grid)
		{
			this.frm.CanEdit = true;
			this.frm.AllowEnterToClose = false;
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
						flag2 = (grid.GetRow().Cells["check_status"].Value == null || grid.GetRow().Cells["check_status"].Value == DBNull.Value);
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

		// Token: 0x06001654 RID: 5716 RVA: 0x000F1D94 File Offset: 0x000EFF94
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
				flag = (position == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position);
				if (flag)
				{
					this.Bank_Select();
				}
				else
				{
					flag = (position == this.GridEX1.RootTable.Columns["check_shobe"].Position);
					if (flag)
					{
						bool flag2 = this.Shobe_Select();
						if (flag2)
						{
							this.MoveToNewRecord();
						}
					}
					else
					{
						bool flag2 = position == this.GridEX1.RootTable.Columns["check_shomareHesab"].Position;
						if (flag2)
						{
							this.ShomareHesab_Select();
						}
						else
						{
							flag2 = (position == this.GridEX1.RootTable.Columns["del"].Position);
							if (flag2)
							{
								flag = (this.GridEX1.CurrentRow.RowType == RowType.Record);
								if (flag)
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
			}
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000EA1CC File Offset: 0x000E83CC
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

		// Token: 0x06001656 RID: 5718 RVA: 0x000F1F08 File Offset: 0x000F0108
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

		// Token: 0x06001657 RID: 5719 RVA: 0x000F1FF0 File Offset: 0x000F01F0
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
						if (flag2)
						{
							int col = this.GridEX1.Col;
							flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
							if (flag)
							{
								bool flag3 = this.GridEX1.EditTextBox == null;
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
								bool flag3 = col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position;
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
									flag3 = (col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position);
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
											flag2 = this.Shobe_Select();
											if (flag2)
											{
												this.MoveToNewRecord();
												e.SuppressKeyPress = true;
											}
										}
										else
										{
											this.MoveToNewRecord();
											e.SuppressKeyPress = true;
										}
									}
									else
									{
										flag3 = (col == this.GridEX1.RootTable.Columns["Check_ShomareHesab"].Position);
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
												this.ShomareHesab_Select();
											}
											else
											{
												GridEX gridEX = this.GridEX1;
												gridEX.Col++;
											}
										}
										else
										{
											flag3 = this.prevent;
											if (flag3)
											{
												this.prevent = false;
											}
											else
											{
												GridEX gridEX = this.GridEX1;
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
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000F26B8 File Offset: 0x000F08B8
		private void MoveToNewRecord()
		{
			checked
			{
				bool flag = this.GridEX1.Row < this.GridEX1.RowCount - 1;
				if (flag)
				{
					this.GridEX1.Col = 1;
					GridEX gridEX = this.GridEX1;
					gridEX.Row++;
					this.GridEX1.Focus();
				}
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000F2718 File Offset: 0x000F0918
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_ShomareHesab"].Position || this.GridEX1.Col == this.GridEX1.RootTable.Columns["sh_check"].Position;
			bool flag2;
			if (flag)
			{
				flag2 = (Strings.Asc(e.KeyChar) == 8);
				if (flag2)
				{
					return;
				}
			}
			flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_ShomareHesab"].Position);
			if (!flag2)
			{
				flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["CheckBank_Name"].Position);
				if (flag2)
				{
					e.Handled = true;
				}
				flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Check_Shobe"].Position);
				if (!flag2)
				{
					flag2 = (!char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0);
					if (flag2)
					{
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000F2884 File Offset: 0x000F0A84
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

		// Token: 0x0600165B RID: 5723 RVA: 0x000F28C0 File Offset: 0x000F0AC0
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status) VALUES(-99," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(text2)) + ",NULL,NULL ," + Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"])) + ",1,", dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(text2)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), ",1);")));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Check_Status"], 1, false);
							if (!flag)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=-99 ,Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(text2)) + " ,Moshtari_ID=" + Public_Function.GetValueInt(Conversions.ToString(dataRow["Moshtari_ID"])) + " ,Sandug_ID=" + Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"])) + " ,BankHesab_ID=null" + " ,Hazine_ID=Null" + " ,Mablagh=", dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(text2)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), " ,Check_status=1"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
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

		// Token: 0x0600165C RID: 5724 RVA: 0x0000205D File Offset: 0x0000025D
		private void Bar1_ItemClick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x00006E38 File Offset: 0x00005038
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00006E43 File Offset: 0x00005043
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x0400089A RID: 2202
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400089C RID: 2204
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x0400089D RID: 2205
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x0400089E RID: 2206
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x0400089F RID: 2207
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x040008A0 RID: 2208
		[AccessedThroughProperty("lbl_kol")]
		private LabelItem _lbl_kol;

		// Token: 0x040008A1 RID: 2209
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x040008A2 RID: 2210
		[AccessedThroughProperty("lbl_jamCheck")]
		private LabelItem _lbl_jamCheck;

		// Token: 0x040008A3 RID: 2211
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x040008A4 RID: 2212
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040008A5 RID: 2213
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040008A6 RID: 2214
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040008A7 RID: 2215
		private Frm_SelectItem frm;

		// Token: 0x040008A8 RID: 2216
		private Frm_SelectItemSql frmsql;

		// Token: 0x040008A9 RID: 2217
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x040008AA RID: 2218
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x040008AB RID: 2219
		[CompilerGenerated]
		private bool _DelFlag;

		// Token: 0x040008AC RID: 2220
		private List<KeyValuePair<int, int>> check_id;

		// Token: 0x040008AD RID: 2221
		private bool prevent;

		// Token: 0x040008AE RID: 2222
		private bool prevent_right;

		// Token: 0x040008AF RID: 2223
		private bool prevent_left;

		// Token: 0x040008B0 RID: 2224
		private ShomareHesab shomarehesab;
	}
}
