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
	// Token: 0x020000E7 RID: 231
	[DesignerGenerated]
	public partial class Frm_DaryaftCheck_naghd : Form
	{
		// Token: 0x06001660 RID: 5728 RVA: 0x000F2D94 File Offset: 0x000F0F94
		public Frm_DaryaftCheck_naghd()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_DaryaftCheck_naghd.__ENCAddToList(this);
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

		// Token: 0x06001661 RID: 5729 RVA: 0x000F2E44 File Offset: 0x000F1044
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DaryaftCheck_naghd.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DaryaftCheck_naghd.__ENCList.Count == Frm_DaryaftCheck_naghd.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DaryaftCheck_naghd.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DaryaftCheck_naghd.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DaryaftCheck_naghd.__ENCList[num] = Frm_DaryaftCheck_naghd.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DaryaftCheck_naghd.__ENCList.RemoveRange(num, Frm_DaryaftCheck_naghd.__ENCList.Count - num);
						Frm_DaryaftCheck_naghd.__ENCList.Capacity = Frm_DaryaftCheck_naghd.__ENCList.Count;
					}
					Frm_DaryaftCheck_naghd.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x000F3790 File Offset: 0x000F1990
		// (set) Token: 0x06001665 RID: 5733 RVA: 0x000F37A8 File Offset: 0x000F19A8
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
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value5 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EndCustomEditEventHandler value6 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyPress -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.KeyDown -= value4;
					this._GridEX1.CellEdited -= value5;
					this._GridEX1.EndCustomEdit -= value6;
					this._GridEX1.ColumnButtonClick -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyPress += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.KeyDown += value4;
					this._GridEX1.CellEdited += value5;
					this._GridEX1.EndCustomEdit += value6;
					this._GridEX1.ColumnButtonClick += value7;
				}
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x000F38DC File Offset: 0x000F1ADC
		// (set) Token: 0x06001667 RID: 5735 RVA: 0x000F38F4 File Offset: 0x000F1AF4
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

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x000F3954 File Offset: 0x000F1B54
		// (set) Token: 0x06001669 RID: 5737 RVA: 0x00006E5B File Offset: 0x0000505B
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

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x000F396C File Offset: 0x000F1B6C
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00006E65 File Offset: 0x00005065
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

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x000F3984 File Offset: 0x000F1B84
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00006E6F File Offset: 0x0000506F
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

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x000F399C File Offset: 0x000F1B9C
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00006E79 File Offset: 0x00005079
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

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x000F39B4 File Offset: 0x000F1BB4
		// (set) Token: 0x06001671 RID: 5745 RVA: 0x00006E83 File Offset: 0x00005083
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

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x000F39CC File Offset: 0x000F1BCC
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x000F39E4 File Offset: 0x000F1BE4
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

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x000F3A6C File Offset: 0x000F1C6C
		// (set) Token: 0x06001675 RID: 5749 RVA: 0x000F3A84 File Offset: 0x000F1C84
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

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x000F3AE4 File Offset: 0x000F1CE4
		// (set) Token: 0x06001677 RID: 5751 RVA: 0x00006E8D File Offset: 0x0000508D
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
				this._ButtonItem2 = value;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001678 RID: 5752 RVA: 0x000F3AFC File Offset: 0x000F1CFC
		// (set) Token: 0x06001679 RID: 5753 RVA: 0x000F3B14 File Offset: 0x000F1D14
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

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x000F3B74 File Offset: 0x000F1D74
		// (set) Token: 0x0600167B RID: 5755 RVA: 0x00006E97 File Offset: 0x00005097
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

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000F3B8C File Offset: 0x000F1D8C
		// (set) Token: 0x0600167D RID: 5757 RVA: 0x00006EA1 File Offset: 0x000050A1
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

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600167E RID: 5758 RVA: 0x000F3BA4 File Offset: 0x000F1DA4
		// (set) Token: 0x0600167F RID: 5759 RVA: 0x00006EAB File Offset: 0x000050AB
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

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x000F3BBC File Offset: 0x000F1DBC
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00006EB5 File Offset: 0x000050B5
		public DataTable dt_daryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_daryaft;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_daryaft = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x000F3BD4 File Offset: 0x000F1DD4
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00006EBF File Offset: 0x000050BF
		public List<listCheckDaryaft> ListDaryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListDaryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ListDaryaft_Identity = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000F3BEC File Offset: 0x000F1DEC
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00006EC9 File Offset: 0x000050C9
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000F3C04 File Offset: 0x000F1E04
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x00006ED3 File Offset: 0x000050D3
		public DataRow ParentDatarow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ParentDatarow;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ParentDatarow = value;
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001688 RID: 5768 RVA: 0x000F3C1C File Offset: 0x000F1E1C
		// (set) Token: 0x06001689 RID: 5769 RVA: 0x00006EDD File Offset: 0x000050DD
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x000F3C34 File Offset: 0x000F1E34
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

		// Token: 0x0600168B RID: 5771 RVA: 0x000F3CB8 File Offset: 0x000F1EB8
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

		// Token: 0x0600168C RID: 5772 RVA: 0x000F3EF8 File Offset: 0x000F20F8
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

		// Token: 0x0600168D RID: 5773 RVA: 0x000F41DC File Offset: 0x000F23DC
		private DataTable LoadData()
		{
			return this.dt;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0000205D File Offset: 0x0000025D
		private void UpdateCheck()
		{
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x000F41F4 File Offset: 0x000F23F4
		private void Frm_DaryaftCheck_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = !this.ValidateGrid();
			checked
			{
				if (flag)
				{
					e.Cancel = true;
				}
				else
				{
					DataTable table = this.ParentDatarow.Table;
					int num = this.ParentDatarow.Table.Rows.IndexOf(this.ParentDatarow);
					DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_identity=", this.ParentDatarow["Identity"])));
					flag = (array.Length > 0);
					if (flag)
					{
						int arg_81_0 = 0;
						int num2 = array.Length - 1;
						int num3 = arg_81_0;
						while (true)
						{
							int arg_C0_0 = num3;
							int num4 = num2;
							if (arg_C0_0 > num4)
							{
								break;
							}
							bool flag2 = Operators.ConditionalCompareObjectEqual(array[num3]["dptype_id"], 10, false);
							if (flag2)
							{
								num++;
							}
							else
							{
								array[num3].Delete();
							}
							num3++;
						}
					}
					table.AcceptChanges();
					try
					{
						IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							num++;
							DataRow dataRow2 = table.NewRow();
							bool flag2 = dataRow["ID"] != DBNull.Value;
							if (flag2)
							{
								dataRow2["ID"] = RuntimeHelpers.GetObjectValue(dataRow["ID"]);
							}
							flag2 = (dataRow["Parent_ID"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["Parent_ID"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_ID"]);
							}
							dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
							dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
							dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
							dataRow2["is_child"] = true;
							dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(this.ParentDatarow["identity"]);
							flag2 = (dataRow["tarikh"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh"]);
							}
							flag2 = (dataRow["sanadbed_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["sanadbed_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbed_id"]);
							}
							flag2 = (dataRow["sanadbes_id"] != DBNull.Value);
							if (flag2)
							{
								dataRow2["sanadbes_id"] = RuntimeHelpers.GetObjectValue(dataRow["sanadbes_id"]);
							}
							dataRow2["moshtari_id"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_id"]);
							dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
							dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
							dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
							dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
							dataRow2["PardakhtCheck_ID"] = RuntimeHelpers.GetObjectValue(dataRow["PardakhtCheck_ID"]);
							dataRow2["dp_Name"] = "دریافت چک از مشتری نقدی";
							dataRow2["dptype_id"] = 42;
							dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
							table.Rows.InsertAt(dataRow2, num);
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
					this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
				}
			}
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x000F464C File Offset: 0x000F284C
		private void GetData()
		{
			DataTable table = this.ParentDatarow.Table;
			this.dt = table.Clone();
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_Identity=", this.ParentDatarow["identity"])));
			DataRow[] array2 = array;
			checked
			{
				bool flag;
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 42, false);
					if (flag)
					{
						this.dt.ImportRow(dataRow);
					}
				}
				flag = (this.dt.Rows.Count > 0);
				if (flag)
				{
					this.dt.TableName = "data";
					this.GridEX1.DataSource = this.dt;
				}
				else
				{
					this.GridEX1.DataSource = this.LoadData();
				}
				this.GetSum();
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
				this.dt.TableName = "data";
				this.GridEX1.DataSource = this.dt;
			}
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x000F4794 File Offset: 0x000F2994
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

		// Token: 0x06001693 RID: 5779 RVA: 0x000F4868 File Offset: 0x000F2A68
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

		// Token: 0x06001694 RID: 5780 RVA: 0x000F4A90 File Offset: 0x000F2C90
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

		// Token: 0x06001695 RID: 5781 RVA: 0x000F4B90 File Offset: 0x000F2D90
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

		// Token: 0x06001696 RID: 5782 RVA: 0x000F4CC0 File Offset: 0x000F2EC0
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

		// Token: 0x06001697 RID: 5783 RVA: 0x000F4F64 File Offset: 0x000F3164
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

		// Token: 0x06001698 RID: 5784 RVA: 0x000F5028 File Offset: 0x000F3228
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				this.GetSum();
			}
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x000EEC3C File Offset: 0x000ECE3C
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

		// Token: 0x0600169A RID: 5786 RVA: 0x000EECB8 File Offset: 0x000ECEB8
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

		// Token: 0x0600169B RID: 5787 RVA: 0x000F5064 File Offset: 0x000F3264
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

		// Token: 0x0600169C RID: 5788 RVA: 0x000F5208 File Offset: 0x000F3408
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

		// Token: 0x0600169D RID: 5789 RVA: 0x000F539C File Offset: 0x000F359C
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

		// Token: 0x0600169E RID: 5790 RVA: 0x000EA1CC File Offset: 0x000E83CC
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

		// Token: 0x0600169F RID: 5791 RVA: 0x000F5510 File Offset: 0x000F3710
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

		// Token: 0x060016A0 RID: 5792 RVA: 0x000F55F8 File Offset: 0x000F37F8
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x000F5CC0 File Offset: 0x000F3EC0
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

		// Token: 0x060016A2 RID: 5794 RVA: 0x000F5D20 File Offset: 0x000F3F20
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

		// Token: 0x060016A3 RID: 5795 RVA: 0x000F5E8C File Offset: 0x000F408C
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

		// Token: 0x060016A4 RID: 5796 RVA: 0x0000205D File Offset: 0x0000025D
		private void Bar1_ItemClick(object sender, EventArgs e)
		{
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x00006EE7 File Offset: 0x000050E7
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x00006EF2 File Offset: 0x000050F2
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x040008B1 RID: 2225
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040008B3 RID: 2227
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040008B4 RID: 2228
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040008B5 RID: 2229
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x040008B6 RID: 2230
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x040008B7 RID: 2231
		[AccessedThroughProperty("lbl_kol")]
		private LabelItem _lbl_kol;

		// Token: 0x040008B8 RID: 2232
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x040008B9 RID: 2233
		[AccessedThroughProperty("lbl_jamCheck")]
		private LabelItem _lbl_jamCheck;

		// Token: 0x040008BA RID: 2234
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x040008BB RID: 2235
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040008BC RID: 2236
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040008BD RID: 2237
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040008BE RID: 2238
		private Frm_SelectItem frm;

		// Token: 0x040008BF RID: 2239
		private Frm_SelectItemSql frmsql;

		// Token: 0x040008C0 RID: 2240
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x040008C1 RID: 2241
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x040008C2 RID: 2242
		[CompilerGenerated]
		private bool _DelFlag;

		// Token: 0x040008C3 RID: 2243
		private List<KeyValuePair<int, int>> check_id;

		// Token: 0x040008C4 RID: 2244
		private bool prevent;

		// Token: 0x040008C5 RID: 2245
		private bool prevent_right;

		// Token: 0x040008C6 RID: 2246
		private bool prevent_left;

		// Token: 0x040008C7 RID: 2247
		private ShomareHesab shomarehesab;

		// Token: 0x040008C8 RID: 2248
		[CompilerGenerated]
		private DataTable _dt_daryaft;

		// Token: 0x040008C9 RID: 2249
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x040008CA RID: 2250
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x040008CB RID: 2251
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x040008CC RID: 2252
		[CompilerGenerated]
		private string _Tarikh;
	}
}
