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
using Janus.Windows.GridEX;
using Janus.Windows.Ribbon;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000E5 RID: 229
	[DesignerGenerated]
	public partial class Frm_DaryaftCheck : Form
	{
		// Token: 0x060015C4 RID: 5572 RVA: 0x000EBBE8 File Offset: 0x000E9DE8
		public Frm_DaryaftCheck()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_DaryaftCheck_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_DaryaftCheck.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.frmsql = new Frm_SelectItemSql();
			DataTable dt = new DataTable();
			this.dt = dt;
			bool flag = false;
			this.DelFlag = flag;
			flag = true;
			this.ShomeHesab_visible = flag;
			flag = true;
			this.Bank_visible = flag;
			flag = true;
			this.Shobe_visible = flag;
			flag = true;
			this.SahebHesa_visible = flag;
			this.prevent = false;
			this.prevent_right = false;
			this.prevent_left = false;
			this.shomarehesab = new ShomareHesab();
			this.InitializeComponent();
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x000EBCC0 File Offset: 0x000E9EC0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DaryaftCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DaryaftCheck.__ENCList.Count == Frm_DaryaftCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DaryaftCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DaryaftCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DaryaftCheck.__ENCList[num] = Frm_DaryaftCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DaryaftCheck.__ENCList.RemoveRange(num, Frm_DaryaftCheck.__ENCList.Count - num);
						Frm_DaryaftCheck.__ENCList.Capacity = Frm_DaryaftCheck.__ENCList.Count;
					}
					Frm_DaryaftCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000EC67C File Offset: 0x000EA87C
		// (set) Token: 0x060015C9 RID: 5577 RVA: 0x000EC694 File Offset: 0x000EA894
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
				EndCustomEditEventHandler value2 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				KeyPressEventHandler value4 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value5 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				KeyEventHandler value6 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.EndCustomEdit -= value2;
					this._GridEX1.ColumnButtonClick -= value3;
					this._GridEX1.KeyPress -= value4;
					this._GridEX1.InitCustomEdit -= value5;
					this._GridEX1.KeyDown -= value6;
					this._GridEX1.CellEdited -= value7;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.EndCustomEdit += value2;
					this._GridEX1.ColumnButtonClick += value3;
					this._GridEX1.KeyPress += value4;
					this._GridEX1.InitCustomEdit += value5;
					this._GridEX1.KeyDown += value6;
					this._GridEX1.CellEdited += value7;
				}
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000EC7C8 File Offset: 0x000EA9C8
		// (set) Token: 0x060015CB RID: 5579 RVA: 0x000EC7E0 File Offset: 0x000EA9E0
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

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000EC840 File Offset: 0x000EAA40
		// (set) Token: 0x060015CD RID: 5581 RVA: 0x000EC858 File Offset: 0x000EAA58
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

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x000EC8E0 File Offset: 0x000EAAE0
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x00006C93 File Offset: 0x00004E93
		internal virtual RibbonStatusBar RibbonStatusBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonStatusBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._RibbonStatusBar1 = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x000EC8F8 File Offset: 0x000EAAF8
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x00006C9D File Offset: 0x00004E9D
		internal virtual LabelCommand lbl_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_code = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x000EC910 File Offset: 0x000EAB10
		// (set) Token: 0x060015D3 RID: 5587 RVA: 0x00006CA7 File Offset: 0x00004EA7
		internal virtual LabelCommand lbl_codem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codem = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000EC928 File Offset: 0x000EAB28
		// (set) Token: 0x060015D5 RID: 5589 RVA: 0x00006CB1 File Offset: 0x00004EB1
		internal virtual LabelCommand LabelCommand2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand2 = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x000EC940 File Offset: 0x000EAB40
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x00006CBB File Offset: 0x00004EBB
		internal virtual LabelCommand lbl_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_name = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x000EC958 File Offset: 0x000EAB58
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x00006CC5 File Offset: 0x00004EC5
		internal virtual LabelCommand LabelCommand3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand3 = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x000EC970 File Offset: 0x000EAB70
		// (set) Token: 0x060015DB RID: 5595 RVA: 0x00006CCF File Offset: 0x00004ECF
		internal virtual LabelCommand lbl_check
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_check;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_check = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000EC988 File Offset: 0x000EAB88
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x00006CD9 File Offset: 0x00004ED9
		internal virtual LabelCommand LabelCommand4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand4 = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x000EC9A0 File Offset: 0x000EABA0
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x00006CE3 File Offset: 0x00004EE3
		internal virtual LabelCommand lbl_jam
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_jam;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_jam = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x000EC9B8 File Offset: 0x000EABB8
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00006CED File Offset: 0x00004EED
		internal virtual LabelCommand LabelCommand6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand6 = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x000EC9D0 File Offset: 0x000EABD0
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00006CF7 File Offset: 0x00004EF7
		internal virtual LabelCommand LabelCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand1 = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x000EC9E8 File Offset: 0x000EABE8
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x00006D01 File Offset: 0x00004F01
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

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x000ECA00 File Offset: 0x000EAC00
		// (set) Token: 0x060015E7 RID: 5607 RVA: 0x00006D0B File Offset: 0x00004F0B
		public DataTable Daryaft_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Daryaft_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Daryaft_Table = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060015E8 RID: 5608 RVA: 0x000ECA18 File Offset: 0x000EAC18
		// (set) Token: 0x060015E9 RID: 5609 RVA: 0x00006D15 File Offset: 0x00004F15
		public GridEX Pardakht_Grid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Grid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Grid = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x000ECA30 File Offset: 0x000EAC30
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x00006D1F File Offset: 0x00004F1F
		public List<int> del_lst
		{
			[DebuggerNonUserCode]
			get
			{
				return this._del_lst;
			}
			[DebuggerNonUserCode]
			set
			{
				this._del_lst = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x000ECA48 File Offset: 0x000EAC48
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00006D29 File Offset: 0x00004F29
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

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x000ECA60 File Offset: 0x000EAC60
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x00006D33 File Offset: 0x00004F33
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

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x000ECA78 File Offset: 0x000EAC78
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x00006D3D File Offset: 0x00004F3D
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

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x000ECA90 File Offset: 0x000EAC90
		// (set) Token: 0x060015F3 RID: 5619 RVA: 0x00006D47 File Offset: 0x00004F47
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

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x000ECAA8 File Offset: 0x000EACA8
		// (set) Token: 0x060015F5 RID: 5621 RVA: 0x00006D51 File Offset: 0x00004F51
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

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000ECAC0 File Offset: 0x000EACC0
		// (set) Token: 0x060015F7 RID: 5623 RVA: 0x00006D5B File Offset: 0x00004F5B
		public long Mablagh_Kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mablagh_Kol;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mablagh_Kol = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000ECAD8 File Offset: 0x000EACD8
		// (set) Token: 0x060015F9 RID: 5625 RVA: 0x00006D65 File Offset: 0x00004F65
		private bool ShomeHesab_visible
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShomeHesab_visible;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ShomeHesab_visible = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000ECAF0 File Offset: 0x000EACF0
		// (set) Token: 0x060015FB RID: 5627 RVA: 0x00006D6F File Offset: 0x00004F6F
		private bool Bank_visible
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bank_visible;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Bank_visible = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x000ECB08 File Offset: 0x000EAD08
		// (set) Token: 0x060015FD RID: 5629 RVA: 0x00006D79 File Offset: 0x00004F79
		private bool Shobe_visible
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Shobe_visible;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Shobe_visible = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000ECB20 File Offset: 0x000EAD20
		// (set) Token: 0x060015FF RID: 5631 RVA: 0x00006D83 File Offset: 0x00004F83
		private bool SahebHesa_visible
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SahebHesa_visible;
			}
			[DebuggerNonUserCode]
			set
			{
				this._SahebHesa_visible = value;
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000ECB38 File Offset: 0x000EAD38
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
						gridEXRow.Cells["bank_Name"].Value = RuntimeHelpers.GetObjectValue(dr["bank_name"]);
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

		// Token: 0x06001601 RID: 5633 RVA: 0x000ECD78 File Offset: 0x000EAF78
		private bool ValidateGrid()
		{
			this.GridEX1.UpdateData();
			GridEXRow[] rows = this.GridEX1.GetRows();
			int i = 0;
			checked
			{
				bool result;
				bool flag2;
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
							flag = this.Shobe_visible;
							if (flag)
							{
								flag2 = (Operators.CompareString(gridEXRow.Cells["Check_Shobe"].Value.ToString(), string.Empty, false) == 0);
								if (flag2)
								{
									Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Shobe", "شعبه صادر کننده چک را وارد کنید");
									result = false;
									return result;
								}
							}
							flag2 = (Operators.CompareString(gridEXRow.Cells["Check_Sarresid_Fa"].Value.ToString(), string.Empty, false) == 0);
							if (flag2)
							{
								Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Check_Sarresid_Fa", "تاریخ چک را وارد کنید");
								result = false;
							}
							else
							{
								flag2 = !Public_Function.IsValidShamsiDate(Conversions.ToString(gridEXRow.Cells["Check_Sarresid_Fa"].Value));
								if (!flag2)
								{
									flag2 = this.Bank_visible;
									if (flag2)
									{
										flag = (gridEXRow.Cells["CheckBank_ID"].Value == DBNull.Value);
										if (flag)
										{
											Public_Function.GridRaiseSoftError(this.GridEX1, gridEXRow, "Bank_Name", "بانک چک را مشخص فرمائید");
											result = false;
											return result;
										}
									}
									flag2 = this.ShomeHesab_visible;
									if (flag2)
									{
										string shobeID = string.Empty;
										flag2 = (gridEXRow.Cells["shobe_id"].Value != null);
										if (flag2)
										{
											shobeID = Conversions.ToString(gridEXRow.Cells["shobe_id"].Value);
										}
										this.shomarehesab.Update(Conversions.ToString(gridEXRow.Cells["check_shomarehesab"].Value), gridEXRow.Cells["checkbank_id"].Value.ToString(), shobeID, gridEXRow.Cells["check_shobe"].Value.ToString(), gridEXRow.Cells["tozih"].Value.ToString());
									}
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
				flag2 = Operators.ConditionalCompareObjectGreater(Operators.SubtractObject(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum), this.Mablagh_Kol), 0, false);
				if (flag2)
				{
					Public_Function.ShowMessage("مبلغ چک ها بیشتر از مبلغ کل میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
					return result;
				}
				int num = this.is_Tekrari();
				flag2 = (num > -1);
				if (flag2)
				{
					Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Sh_Check", "چک وارد شده تکراری میباشد");
					result = false;
					return result;
				}
				result = true;
				return result;
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000ED100 File Offset: 0x000EB300
		private DataTable LoadData()
		{
			this.dt = this.ParentDatarow.Table.Clone();
			return this.dt;
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x000ED130 File Offset: 0x000EB330
		private void Update_Daryaft_Check(DataRow row)
		{
			bool flag = row["id"] == DBNull.Value;
			checked
			{
				if (!flag)
				{
					DataRow[] array = this.Daryaft_Table.Select(Conversions.ToString(Operators.ConcatenateObject("Pardakhtcheck_ID=", row["ID"])));
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						dataRow["Mablagh"] = RuntimeHelpers.GetObjectValue(row["Mablagh"]);
						dataRow["Sh_Check"] = RuntimeHelpers.GetObjectValue(row["Sh_Check"]);
						dataRow["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(row["CheckBank_ID"]);
						dataRow["Check_Shobe"] = RuntimeHelpers.GetObjectValue(row["Check_Shobe"]);
						dataRow["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(row["Check_Sarresid_Fa"]);
						dataRow["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(row["Check_ShomareHesab"]);
						dataRow["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(row["CheckBank_Name"]);
						dataRow["Tozih"] = RuntimeHelpers.GetObjectValue(row["Tozih"]);
					}
				}
			}
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x000ED284 File Offset: 0x000EB484
		private void Update_Pardakht_Check(DataRow row)
		{
			DataRow[] array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("Daryaft_identity=", row["identity"])));
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					dataRow["Mablagh"] = RuntimeHelpers.GetObjectValue(row["Mablagh"]);
					dataRow["Sh_Check"] = RuntimeHelpers.GetObjectValue(row["Sh_Check"]);
					dataRow["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(row["CheckBank_ID"]);
					dataRow["Check_Shobe"] = RuntimeHelpers.GetObjectValue(row["Check_Shobe"]);
					dataRow["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(row["Check_Sarresid_Fa"]);
					dataRow["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(row["Check_ShomareHesab"]);
					dataRow["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(row["CheckBank_Name"]);
				}
				bool flag = row["id"] != DBNull.Value;
				if (flag)
				{
					array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("Pardakhtcheck_ID=", row["id"])));
					DataRow[] array3 = array;
					for (int j = 0; j < array3.Length; j++)
					{
						DataRow dataRow2 = array3[j];
						dataRow2["Mablagh"] = RuntimeHelpers.GetObjectValue(row["Mablagh"]);
						dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(row["Sh_Check"]);
						dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(row["CheckBank_ID"]);
						dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(row["Check_Shobe"]);
						dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(row["Check_Sarresid_Fa"]);
						dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(row["Check_ShomareHesab"]);
						dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(row["CheckBank_Name"]);
					}
				}
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x000ED4D4 File Offset: 0x000EB6D4
		private void Update_Check(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow.RowState == DataRowState.Modified;
					if (flag)
					{
						this.Update_Pardakht_Check(dataRow);
						this.Update_Daryaft_Check(dataRow);
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

		// Token: 0x06001606 RID: 5638 RVA: 0x000ED55C File Offset: 0x000EB75C
		private void UpdateDaryaftRows(DataRow i)
		{
			DataRow[] array = this.Daryaft_Table.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", i["parent_identity"])));
			DataRow[] array2 = array;
			checked
			{
				long num;
				for (int j = 0; j < array2.Length; j++)
				{
					DataRow dataRow = array2[j];
					num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
				}
				DataRow[] array3 = this.Daryaft_Table.Select(Conversions.ToString(Operators.ConcatenateObject("identity=", i["parent_identity"])));
				array3[0]["Mablagh"] = num;
			}
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x000ED60C File Offset: 0x000EB80C
		private void UpdatePardakhtRows(DataRow i)
		{
			DataRow[] array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("parent_identity=", i["parent_identity"])));
			DataRow[] array2 = array;
			checked
			{
				long num;
				for (int j = 0; j < array2.Length; j++)
				{
					DataRow dataRow = array2[j];
					num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
				}
				DataRow[] array3 = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("identity=", i["parent_identity"])));
				array3[0]["Mablagh"] = num;
			}
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x000ED6BC File Offset: 0x000EB8BC
		private void ChangeIdentity(int before, int After)
		{
			bool flag = this.ListDaryaft_Identity == null;
			if (!flag)
			{
				try
				{
					List<listCheckDaryaft>.Enumerator enumerator = this.ListDaryaft_Identity.GetEnumerator();
					while (enumerator.MoveNext())
					{
						listCheckDaryaft current = enumerator.Current;
						flag = (current.Daryaft_Identity == before);
						if (flag)
						{
							current.Daryaft_Identity = After;
						}
					}
				}
				finally
				{
					List<listCheckDaryaft>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x000ED738 File Offset: 0x000EB938
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
					object expr_2E = this.ParentDatarow["Moshtari_ID"];
					int? num2;
					int? num = (expr_2E != null) ? ((int?)expr_2E) : num2;
					string value = Conversions.ToString(this.ParentDatarow["Moshtari_Name"]);
					DataTable table = this.ParentDatarow.Table;
					int num3 = this.ParentDatarow.Table.Rows.IndexOf(this.ParentDatarow);
					DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("Parent_identity=", this.ParentDatarow["Identity"]), " and dptype_id=2")));
					flag = (array.Length > 0);
					if (flag)
					{
						int arg_C7_0 = 0;
						int num4 = array.Length - 1;
						int num5 = arg_C7_0;
						while (true)
						{
							int arg_10D_0 = num5;
							int num6 = num4;
							if (arg_10D_0 > num6)
							{
								break;
							}
							bool flag2 = Operators.ConditionalCompareObjectEqual(array[num5]["dptype_id"], 1, false);
							if (flag2)
							{
								num3++;
							}
							else
							{
								array[num5].Delete();
							}
							num5++;
						}
					}
					table.AcceptChanges();
					this.Update_Check((DataTable)this.GridEX1.DataSource);
					try
					{
						IEnumerator enumerator = ((DataTable)this.GridEX1.DataSource).Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							num3++;
							DataRow dataRow2 = table.NewRow();
							bool flag2 = num.HasValue;
							if (flag2)
							{
								dataRow2["Moshtari_Name"] = value;
								dataRow2["Moshtari_ID"] = num;
							}
							flag2 = (dataRow["ID"] != DBNull.Value);
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
							flag2 = (dataRow["Mablagh2"] == DBNull.Value);
							if (flag2)
							{
								dataRow["Mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh"]);
								dataRow2["mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow["mablagh"]);
							}
							else
							{
								dataRow2["Mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow["Mablagh2"]);
							}
							dataRow2["Sh_Check"] = RuntimeHelpers.GetObjectValue(dataRow["Sh_Check"]);
							dataRow2["CheckBank_ID"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_ID"]);
							dataRow2["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Shobe"]);
							dataRow2["Check_Sarresid_Fa"] = RuntimeHelpers.GetObjectValue(dataRow["Check_Sarresid_Fa"]);
							dataRow2["Check_ShomareHesab"] = RuntimeHelpers.GetObjectValue(dataRow["Check_ShomareHesab"]);
							dataRow2["dp_Name"] = "دریافت چک";
							dataRow2["dptype_id"] = 2;
							dataRow2["CheckBank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["CheckBank_Name"]);
							dataRow2["Tozih"] = RuntimeHelpers.GetObjectValue(dataRow["Tozih"]);
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
							this.ChangeIdentity(Conversions.ToInteger(dataRow["identity"]), Conversions.ToInteger(dataRow2["identity"]));
							table.Rows.InsertAt(dataRow2, num3);
							flag2 = (this.Daryaft_Table != null);
							if (flag2)
							{
								flag = (dataRow["ID"] == DBNull.Value);
								DataRow[] array2;
								if (flag)
								{
									array2 = this.Daryaft_Table.Select(Conversions.ToString(Operators.ConcatenateObject("identity =", dataRow["identity"])));
								}
								else
								{
									array2 = this.Daryaft_Table.Select(Conversions.ToString(Operators.ConcatenateObject("pardakhtcheck_id =", dataRow["id"])));
								}
								DataRow[] array3 = array2;
								for (int i = 0; i < array3.Length; i++)
								{
									DataRow i2 = array3[i];
									flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["mablagh"], dataRow["mablagh2"], false);
									if (flag2)
									{
										this.UpdateDaryaftRows(i2);
									}
								}
							}
							flag2 = (this.Pardakht_Table != null);
							if (flag2)
							{
								flag = (dataRow["ID"] == DBNull.Value);
								DataRow[] array2;
								if (flag)
								{
									array2 = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("daryaft_identity =", dataRow["identity"])));
								}
								else
								{
									array2 = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("pardakhtcheck_id =", dataRow["id"])));
								}
								DataRow[] array4 = array2;
								for (int j = 0; j < array4.Length; j++)
								{
									DataRow dataRow3 = array4[j];
									dataRow3["daryaft_identity"] = RuntimeHelpers.GetObjectValue(dataRow2["identity"]);
									flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["mablagh"], dataRow["mablagh2"], false);
									if (flag2)
									{
										this.UpdatePardakhtRows(dataRow3);
									}
								}
							}
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
				}
				this.sum_mablagh = Conversions.ToLong(this.GridEX1.GetTotal(this.GridEX1.RootTable.Columns["Mablagh"], AggregateFunction.Sum));
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x000EDE50 File Offset: 0x000EC050
		private void Frm_DaryaftCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F5);
			if (flag)
			{
				this.Delete_Check(this.GridEX1.CurrentRow);
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x000EDE98 File Offset: 0x000EC098
		private void SetColumns()
		{
			bool flag = !Public_Function.dict.ContainsKey("daryaftcheck");
			if (!flag)
			{
				string text = string.Empty;
				text = Public_Function.dict["daryaftcheck"];
				flag = (Operators.CompareString(text.Substring(0, 1), "0", false) == 0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["check_shomarehesab"].Visible = false;
					this.ShomeHesab_visible = false;
				}
				flag = (Operators.CompareString(text.Substring(1, 1), "0", false) == 0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["Bank_Name"].Visible = false;
					this.Bank_visible = false;
				}
				flag = (Operators.CompareString(text.Substring(2, 1), "0", false) == 0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["check_shobe"].Visible = false;
					this.Shobe_visible = false;
				}
				flag = (Operators.CompareString(text.Substring(3, 1), "0", false) == 0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["Tozih"].Visible = false;
					this.SahebHesa_visible = false;
				}
			}
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x000EDFEC File Offset: 0x000EC1EC
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			this.lbl_jam.Text = Public_Function.ToFarsi(Strings.FormatNumber(this.Mablagh_Kol, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True));
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.SetColumns();
			ItemCollection itemCollection2 = new ItemCollection();
			itemCollection2.Add(new Column("ShomareHesab", "شماره حساب", 100));
			this.frmsql.items = itemCollection2;
			this.frmsql.Edit_Frm = MyProject.Forms.Frm_ShomareHesab;
			this.frmsql.CanEdit = true;
			DataTable table = this.ParentDatarow.Table;
			this.dt = table.Clone();
			DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject("Parent_Identity=", this.ParentDatarow["identity"])));
			DataRow[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 2, false);
					if (flag)
					{
						this.dt.ImportRow(dataRow);
					}
				}
				try
				{
					IEnumerator enumerator = this.dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator.Current;
						dataRow2["mablagh2"] = RuntimeHelpers.GetObjectValue(dataRow2["mablagh"]);
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
				this.dt.AcceptChanges();
				this.dt.TableName = "data";
				this.GridEX1.DataSource = this.dt;
				this.GetSum();
				this.GridEX1.Focus();
				this.GridEX1.MoveToNewRecord();
				this.GridEX1.Col = 0;
				this.GridEX1.CurrentRow.BeginEdit();
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x000EE220 File Offset: 0x000EC420
		private void ShomareHesab_Select()
		{
			this.frmsql.SelectedRow = null;
			bool flag = this.frmsql.ShowDialog("SELECT     ShomareHesab.ID, ShomareHesab.ShomareHesab,Bank.ID as Bank_ID,ShomareHesab.sahebcheck, Bank.Name AS Bank_Name,Shobe.ID as Shobe_ID, Shobe.Name AS Shobe_Name   FROM         Bank INNER JOIN   ShomareHesab ON Bank.ID = ShomareHesab.Bank_ID LEFT OUTER JOIN    Shobe ON ShomareHesab.Shobe_ID = Shobe.ID where shomarehesab like '{0}%'", null, "انتخاب شماره حساب - ویرایش اطلاعات=F6") == DialogResult.OK;
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
							this.GridEX1.GetRow().Cells["Bank_Name"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Bank_Name"]);
							this.GridEX1.GetRow().Cells["Check_Shobe"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Shobe_Name"]);
							this.GridEX1.GetRow().Cells["Shobe_ID"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["Shobe_ID"]);
							flag3 = (this.frmsql.SelectedRow["sahebcheck"] != DBNull.Value);
							if (flag3)
							{
								this.GridEX1.GetRow().Cells["tozih"].Value = RuntimeHelpers.GetObjectValue(this.frmsql.SelectedRow["sahebcheck"]);
							}
							this.MoveToNewRecord();
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

		// Token: 0x0600160E RID: 5646 RVA: 0x000EE498 File Offset: 0x000EC698
		private void Bank_Select()
		{
			this.frm.AllowEnterToClose = false;
			this.frm.Text = "انتخاب بانک";
			bool flag = this.frm.ShowDialog("select id,Name  from Bank", MyProject.Forms.Frm_Bank, 0) == DialogResult.OK;
			if (flag)
			{
				bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position && this.GridEX1.EditTextBox != null;
				if (flag2)
				{
					this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
					this.GridEX1.GetRow().Cells["CheckBank_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
					flag2 = this.MoveNext();
					if (flag2)
					{
						this.Shobe_Select();
					}
				}
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x000EE5A8 File Offset: 0x000EC7A8
		private bool Shobe_Select()
		{
			this.frm.AllowEnterToClose = true;
			DataTable dt = Public_Function.FillData("select  name  from shobe");
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
						this.MoveNext();
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
						this.MoveNext();
						result = true;
						return result;
					}
				}
			}
			result = false;
			return result;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x000EE6E8 File Offset: 0x000EC8E8
		private int is_Tekrari()
		{
			string right = string.Empty;
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
						bool flag = this.Bank_visible;
						if (flag)
						{
							right = Conversions.ToString(Operators.ConcatenateObject("and checkbank_id= ", dataRow["checkbank_id"]));
						}
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("sh_check='", dataRow["sh_check"]), "'"), right), " and mablagh="), dataRow["mablagh"])));
						flag = (array.Length > 0);
						if (flag)
						{
							int arg_C6_0 = 0;
							int num = array.Length - 1;
							int num2 = arg_C6_0;
							while (true)
							{
								int arg_116_0 = num2;
								int num3 = num;
								if (arg_116_0 > num3)
								{
									goto IL_118;
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
						IL_118:;
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
				DataTable table = this.ParentDatarow.Table;
				int num4 = Conversions.ToInteger(this.ParentDatarow["Moshtari_id"]);
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag2 = this.Bank_visible;
						if (flag2)
						{
							right = Conversions.ToString(Operators.ConcatenateObject(" and checkbank_id= ", dataRow2["checkbank_id"]));
						}
						DataRow[] array = table.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("parent_identity <>", this.ParentDatarow["Identity"]), "  and sh_check='"), dataRow2["sh_check"]), "'"), right), "  and moshtari_id="), num4), " and mablagh="), dataRow2["mablagh"])));
						flag2 = (array.Length > 0);
						if (flag2)
						{
							int arg_254_0 = 0;
							int num5 = array.Length - 1;
							int num6 = arg_254_0;
							int arg_27A_0 = num6;
							int num3 = num5;
							if (arg_27A_0 <= num3)
							{
								result = dataTable.Rows.IndexOf(dataRow2);
								return result;
							}
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
				try
				{
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						string right2 = string.Empty;
						bool flag2 = dataRow3["ID"] != DBNull.Value;
						if (flag2)
						{
							right2 = Conversions.ToString(Operators.ConcatenateObject(" and id <>", dataRow3["ID"]));
						}
						flag2 = this.ShomeHesab_visible;
						if (flag2)
						{
							right = " and check_shomareHesab=" + Public_Function.GetValue(Conversions.ToString(dataRow3["check_shomareHesab"]));
						}
						DataRow dataRow4 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from daryaftpardakht where dptype_id in(2,-99) and moshtari_id=" + Conversions.ToString(num4) + " and sh_check=" + Public_Function.GetValue(Conversions.ToString(dataRow3["sh_check"])) + " and mablagh=", dataRow3["mablagh"]), right), right2)));
						flag2 = (dataRow4 != null);
						if (flag2)
						{
							result = dataTable.Rows.IndexOf(dataRow3);
							return result;
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag2 = enumerator3 is IDisposable;
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				result = -1;
				return result;
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x000EEB4C File Offset: 0x000ECD4C
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
				this.lbl_check.Text = Public_Function.ToFarsi(Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True));
			}
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000EEC00 File Offset: 0x000ECE00
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key.ToLower(), "mablagh", false) == 0;
			if (flag)
			{
				this.GetSum();
			}
		}

		// Token: 0x06001613 RID: 5651 RVA: 0x000EEC3C File Offset: 0x000ECE3C
		private void DeletefromDb(long id, long parent_id)
		{
			string text = "declare @bed_id bigint;declare @bes_id bigint;";
			text = text + "select @bed_id=sanadbed_id,@bes_id=sanadbes_id from daryaftpardakht where id=" + Conversions.ToString(id) + ";";
			text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(id) + ";";
			text += "delete from sanad where id =@bed_id;";
			text += "delete from sanad where id =@bes_id;";
			text = text + "delete from daryaftpardakht where id = " + Conversions.ToString(id) + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000EECB8 File Offset: 0x000ECEB8
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

		// Token: 0x06001615 RID: 5653 RVA: 0x000EED7C File Offset: 0x000ECF7C
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
			dataTable = Public_Function.FillData("SELECT     Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, DaryaftPardakht.Tarikh_Fa AS tarikh, dpType.Name AS opr_name, NULL AS pardakht_identity,   DaryaftPardakht.ID AS 'pardakht_id', Bank.Name + ' ' + Bank_Hesab.Shobe AS bankhesab,  NULL AS daryaft_identity,  NULL AS daryaft_id ,DaryaftPardakht.Parent_id AS  Parent_identity  FROM         Bank_Hesab RIGHT OUTER JOIN   DaryaftPardakht INNER JOIN   dpType ON DaryaftPardakht.dpType_ID = dpType.ID ON Bank_Hesab.ID = DaryaftPardakht.BankHesab_ID LEFT OUTER JOIN   Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID LEFT OUTER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID   where dpType.type in(2,-99) and DaryaftPardakht.pardakhtcheck_id=" + Conversions.ToString(value));
			flag = (((DataRowView)row.DataRow)["ID"] == DBNull.Value);
			checked
			{
				if (flag)
				{
					DataRow[] array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("daryaft_identity=", ((DataRowView)row.DataRow)["identity"])));
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						DataRow dataRow2 = dataTable.NewRow();
						dataRow2["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow["moshtari_name"]);
						dataRow2["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow["tarikh_Fa"]);
						dataRow2["opr_name"] = RuntimeHelpers.GetObjectValue(dataRow["dp_name"]);
						dataRow2["Pardakht_identity"] = RuntimeHelpers.GetObjectValue(dataRow["identity"]);
						dataRow2["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow["Parent_identity"]);
						dataTable.Rows.Add(dataRow2);
					}
				}
				else
				{
					DataRow[] array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("Pardakhtcheck_id=", ((DataRowView)row.DataRow)["id"])));
					DataRow[] array3 = array;
					for (int j = 0; j < array3.Length; j++)
					{
						DataRow dataRow3 = array3[j];
						flag = (dataRow3["ID"] == DBNull.Value);
						if (flag)
						{
							DataRow dataRow4 = dataTable.NewRow();
							dataRow4["moshtari_name"] = RuntimeHelpers.GetObjectValue(dataRow3["moshtari_name"]);
							dataRow4["tarikh"] = RuntimeHelpers.GetObjectValue(dataRow3["tarikh_Fa"]);
							dataRow4["opr_name"] = RuntimeHelpers.GetObjectValue(dataRow3["dp_name"]);
							dataRow4["Pardakht_identity"] = RuntimeHelpers.GetObjectValue(dataRow3["identity"]);
							dataRow4["parent_identity"] = RuntimeHelpers.GetObjectValue(dataRow3["Parent_identity"]);
							dataTable.Rows.Add(dataRow4);
						}
					}
				}
				flag = (dataTable.Rows.Count > 0);
				if (flag)
				{
					new Frm_DeleteCheck_Opr
					{
						ListDaryaft_Identity = this.ListDaryaft_Identity,
						dt_opr = dataTable,
						Pardakht_Table = this.Pardakht_Table,
						Pardakht_Grid = this.Pardakht_Grid,
						del_lst = this.del_lst
					}.ShowDialog();
				}
				else
				{
					flag = (Public_Function.ShowMessage("آیا مایل به حذف چک مورد نظر میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
					if (flag)
					{
						bool flag2 = ((DataRowView)row.DataRow)["ID"] != DBNull.Value;
						if (flag2)
						{
							this.DeletefromDb(Conversions.ToLong(((DataRowView)row.DataRow)["ID"]), Conversions.ToLong(((DataRowView)row.DataRow)["parent_id"]));
							this.Update_MablaghNaghd(row);
						}
						this.GridEX1.CurrentRow.Delete();
						this.DelFlag = true;
						((DataTable)this.GridEX1.DataSource).AcceptChanges();
						this.GetSum();
					}
				}
			}
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000EF160 File Offset: 0x000ED360
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["Bank_Name"].Position;
			checked
			{
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
							GridEX gridEX = this.GridEX1;
							gridEX.Col++;
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

		// Token: 0x06001617 RID: 5655 RVA: 0x000EA1CC File Offset: 0x000E83CC
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

		// Token: 0x06001618 RID: 5656 RVA: 0x000EF2AC File Offset: 0x000ED4AC
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

		// Token: 0x06001619 RID: 5657 RVA: 0x000EF394 File Offset: 0x000ED594
		private bool MoveNext()
		{
			GridEX gridEX = this.GridEX1;
			checked
			{
				gridEX.Col++;
				bool flag = this.GridEX1.Col == 8;
				bool result;
				if (flag)
				{
					this.MoveToNewRecord();
					result = false;
				}
				else
				{
					result = true;
				}
				return result;
			}
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x000EF3DC File Offset: 0x000ED5DC
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
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
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
					if (flag2)
					{
						int col = this.GridEX1.Col;
						flag = (col == this.GridEX1.RootTable.Columns["Check_Sarresid_Fa"].Position);
						if (flag)
						{
							bool flag3 = !this.MoveNext();
							if (!flag3)
							{
								flag3 = (this.GridEX1.EditTextBox == null);
								if (flag3)
								{
									this.GridEX1.GetRow().BeginEdit();
								}
								flag3 = this.ShomeHesab_visible;
								if (flag3)
								{
									this.ShomareHesab_Select();
								}
							}
						}
						else
						{
							bool flag3 = col == this.GridEX1.RootTable.Columns["Bank_Name"].Position;
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
									this.Shobe_Select();
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
											e.SuppressKeyPress = true;
										}
									}
									else
									{
										GridEX gridEX = this.GridEX1;
										gridEX.Col++;
										e.SuppressKeyPress = true;
									}
								}
								else
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["Tozih"].Position);
									if (flag3)
									{
										this.MoveToNewRecord();
										e.SuppressKeyPress = true;
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
												flag3 = this.MoveNext();
												if (flag3)
												{
													this.Bank_Select();
												}
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

		// Token: 0x0600161B RID: 5659 RVA: 0x000EFA5C File Offset: 0x000EDC5C
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

		// Token: 0x0600161C RID: 5660 RVA: 0x000EFABC File Offset: 0x000EDCBC
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
				flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Tozih"].Position);
				if (!flag2)
				{
					flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Bank_Name"].Position);
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
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000EFC5C File Offset: 0x000EDE5C
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

		// Token: 0x0600161E RID: 5662 RVA: 0x00006D8D File Offset: 0x00004F8D
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x00006D98 File Offset: 0x00004F98
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x04000875 RID: 2165
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000877 RID: 2167
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000878 RID: 2168
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000879 RID: 2169
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x0400087A RID: 2170
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x0400087B RID: 2171
		[AccessedThroughProperty("lbl_code")]
		private LabelCommand _lbl_code;

		// Token: 0x0400087C RID: 2172
		[AccessedThroughProperty("lbl_codem")]
		private LabelCommand _lbl_codem;

		// Token: 0x0400087D RID: 2173
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x0400087E RID: 2174
		[AccessedThroughProperty("lbl_name")]
		private LabelCommand _lbl_name;

		// Token: 0x0400087F RID: 2175
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x04000880 RID: 2176
		[AccessedThroughProperty("lbl_check")]
		private LabelCommand _lbl_check;

		// Token: 0x04000881 RID: 2177
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x04000882 RID: 2178
		[AccessedThroughProperty("lbl_jam")]
		private LabelCommand _lbl_jam;

		// Token: 0x04000883 RID: 2179
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04000884 RID: 2180
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x04000885 RID: 2181
		private Frm_SelectItem frm;

		// Token: 0x04000886 RID: 2182
		private Frm_SelectItemSql frmsql;

		// Token: 0x04000887 RID: 2183
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x04000888 RID: 2184
		[CompilerGenerated]
		private DataTable _Daryaft_Table;

		// Token: 0x04000889 RID: 2185
		[CompilerGenerated]
		private GridEX _Pardakht_Grid;

		// Token: 0x0400088A RID: 2186
		[CompilerGenerated]
		private List<int> _del_lst;

		// Token: 0x0400088B RID: 2187
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x0400088C RID: 2188
		[CompilerGenerated]
		private DataRow _ParentDatarow;

		// Token: 0x0400088D RID: 2189
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x0400088E RID: 2190
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x0400088F RID: 2191
		[CompilerGenerated]
		private bool _DelFlag;

		// Token: 0x04000890 RID: 2192
		[CompilerGenerated]
		private long _Mablagh_Kol;

		// Token: 0x04000891 RID: 2193
		[CompilerGenerated]
		private bool _ShomeHesab_visible;

		// Token: 0x04000892 RID: 2194
		[CompilerGenerated]
		private bool _Bank_visible;

		// Token: 0x04000893 RID: 2195
		[CompilerGenerated]
		private bool _Shobe_visible;

		// Token: 0x04000894 RID: 2196
		[CompilerGenerated]
		private bool _SahebHesa_visible;

		// Token: 0x04000895 RID: 2197
		private List<KeyValuePair<int, int>> check_id;

		// Token: 0x04000896 RID: 2198
		private bool prevent;

		// Token: 0x04000897 RID: 2199
		private bool prevent_right;

		// Token: 0x04000898 RID: 2200
		private bool prevent_left;

		// Token: 0x04000899 RID: 2201
		private ShomareHesab shomarehesab;
	}
}
