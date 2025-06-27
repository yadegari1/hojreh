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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000107 RID: 263
	[DesignerGenerated]
	public partial class Frm_RizKharid : Form
	{
		// Token: 0x060023C2 RID: 9154 RVA: 0x001ABAD8 File Offset: 0x001A9CD8
		public Frm_RizKharid()
		{
			base.Activated += new EventHandler(this.frm_Frush_hag_Activated);
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_RizKharid.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Riz_Kharid = new Kharid_Detail();
			bool flag = false;
			this.Preview = flag;
			flag = false;
			this.EditAndSave = flag;
			long gotoLineID = -1L;
			this.GotoLineID = gotoLineID;
			this.prevent_left = false;
			this.prevent_right = false;
			this.prevent = false;
			this.InitializeComponent();
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x001ABB98 File Offset: 0x001A9D98
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_RizKharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_RizKharid.__ENCList.Count == Frm_RizKharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_RizKharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_RizKharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_RizKharid.__ENCList[num] = Frm_RizKharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_RizKharid.__ENCList.RemoveRange(num, Frm_RizKharid.__ENCList.Count - num);
						Frm_RizKharid.__ENCList.Capacity = Frm_RizKharid.__ENCList.Count;
					}
					Frm_RizKharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060023C6 RID: 9158 RVA: 0x001AC584 File Offset: 0x001AA784
		// (set) Token: 0x060023C7 RID: 9159 RVA: 0x00009203 File Offset: 0x00007403
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

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060023C8 RID: 9160 RVA: 0x001AC59C File Offset: 0x001AA79C
		// (set) Token: 0x060023C9 RID: 9161 RVA: 0x001AC5B4 File Offset: 0x001AA7B4
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
				EventHandler value3 = new EventHandler(this.GridEX1_CurrentCellChanged);
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				RowLoadEventHandler value5 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				CancelEventHandler value6 = new CancelEventHandler(this.GridEX1_AddingRecord);
				EventHandler value7 = new EventHandler(this.GridEX1_RecordAdded);
				KeyPressEventHandler value8 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value9 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				EventHandler value10 = new EventHandler(this.GridEX1_SelectionChanged);
				KeyEventHandler value11 = new KeyEventHandler(this.GridEX1_KeyDown);
				ColumnActionEventHandler value12 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.EndCustomEdit -= value2;
					this._GridEX1.CurrentCellChanged -= value3;
					this._GridEX1.ColumnButtonClick -= value4;
					this._GridEX1.LoadingRow -= value5;
					this._GridEX1.AddingRecord -= value6;
					this._GridEX1.RecordAdded -= value7;
					this._GridEX1.KeyPress -= value8;
					this._GridEX1.InitCustomEdit -= value9;
					this._GridEX1.SelectionChanged -= value10;
					this._GridEX1.KeyDown -= value11;
					this._GridEX1.CellEdited -= value12;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.EndCustomEdit += value2;
					this._GridEX1.CurrentCellChanged += value3;
					this._GridEX1.ColumnButtonClick += value4;
					this._GridEX1.LoadingRow += value5;
					this._GridEX1.AddingRecord += value6;
					this._GridEX1.RecordAdded += value7;
					this._GridEX1.KeyPress += value8;
					this._GridEX1.InitCustomEdit += value9;
					this._GridEX1.SelectionChanged += value10;
					this._GridEX1.KeyDown += value11;
					this._GridEX1.CellEdited += value12;
				}
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060023CA RID: 9162 RVA: 0x001AC7C4 File Offset: 0x001AA9C4
		// (set) Token: 0x060023CB RID: 9163 RVA: 0x001AC7DC File Offset: 0x001AA9DC
		internal virtual CurrencyBox txt_fee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_fee_KeyDown);
				bool flag = this._txt_fee != null;
				if (flag)
				{
					this._txt_fee.KeyDown -= value2;
				}
				this._txt_fee = value;
				flag = (this._txt_fee != null);
				if (flag)
				{
					this._txt_fee.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060023CC RID: 9164 RVA: 0x001AC83C File Offset: 0x001AAA3C
		// (set) Token: 0x060023CD RID: 9165 RVA: 0x001AC854 File Offset: 0x001AAA54
		internal virtual CurrencyBox txt_jam_kol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jam_kol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_jam_kol_KeyDown);
				bool flag = this._txt_jam_kol != null;
				if (flag)
				{
					this._txt_jam_kol.KeyDown -= value2;
				}
				this._txt_jam_kol = value;
				flag = (this._txt_jam_kol != null);
				if (flag)
				{
					this._txt_jam_kol.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060023CE RID: 9166 RVA: 0x001AC8B4 File Offset: 0x001AAAB4
		// (set) Token: 0x060023CF RID: 9167 RVA: 0x0000920D File Offset: 0x0000740D
		internal virtual CurrencyBox txt_kargari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kargari = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x001AC8CC File Offset: 0x001AAACC
		// (set) Token: 0x060023D1 RID: 9169 RVA: 0x001AC8E4 File Offset: 0x001AAAE4
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

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x001AC96C File Offset: 0x001AAB6C
		// (set) Token: 0x060023D3 RID: 9171 RVA: 0x00009217 File Offset: 0x00007417
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

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060023D4 RID: 9172 RVA: 0x001AC984 File Offset: 0x001AAB84
		// (set) Token: 0x060023D5 RID: 9173 RVA: 0x00009221 File Offset: 0x00007421
		public long? Moshtari_ID
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

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x001AC99C File Offset: 0x001AAB9C
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x0000922B File Offset: 0x0000742B
		public DataTable dt_Kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_Kharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_Kharid = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x001AC9B4 File Offset: 0x001AABB4
		// (set) Token: 0x060023D9 RID: 9177 RVA: 0x00009235 File Offset: 0x00007435
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

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x001AC9CC File Offset: 0x001AABCC
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x0000923F File Offset: 0x0000743F
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

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060023DC RID: 9180 RVA: 0x001AC9E4 File Offset: 0x001AABE4
		// (set) Token: 0x060023DD RID: 9181 RVA: 0x00009249 File Offset: 0x00007449
		public bool Preview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Preview;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Preview = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x001AC9FC File Offset: 0x001AABFC
		// (set) Token: 0x060023DF RID: 9183 RVA: 0x00009253 File Offset: 0x00007453
		public DataTable dt_kala_to_kala
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_kala_to_kala;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_kala_to_kala = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x001ACA14 File Offset: 0x001AAC14
		// (set) Token: 0x060023E1 RID: 9185 RVA: 0x0000925D File Offset: 0x0000745D
		public bool EditAndSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditAndSave;
			}
			[DebuggerNonUserCode]
			set
			{
				this._EditAndSave = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x001ACA2C File Offset: 0x001AAC2C
		// (set) Token: 0x060023E3 RID: 9187 RVA: 0x00009267 File Offset: 0x00007467
		public long GotoLineID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GotoLineID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GotoLineID = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x001ACA44 File Offset: 0x001AAC44
		// (set) Token: 0x060023E5 RID: 9189 RVA: 0x00009271 File Offset: 0x00007471
		public int? Nahvefurush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Nahvefurush;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Nahvefurush = value;
			}
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x001ACA5C File Offset: 0x001AAC5C
		private void ButtonItem16_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x001ACAF0 File Offset: 0x001AACF0
		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = false;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x001ACB84 File Offset: 0x001AAD84
		private void ButtonItem18_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x001ACC18 File Offset: 0x001AAE18
		private void ButtonItem19_Click(object sender, EventArgs e)
		{
			this.GridEX1.RootTable.Columns["tedad"].Visible = true;
			this.GridEX1.RootTable.Columns["zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
			this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x001ACCAC File Offset: 0x001AAEAC
		private void LoadNahve_Furush()
		{
			bool flag = !this.Nahvefurush.HasValue;
			if (flag)
			{
				this.ButtonItem19_Click(null, null);
			}
			else
			{
				int? nahvefurush = this.Nahvefurush;
				int num = 1;
				bool? arg_5C_0;
				if (!nahvefurush.HasValue)
				{
					arg_5C_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(nahvefurush.GetValueOrDefault() == num);
					arg_5C_0 = flag2;
				}
				bool? flag3 = arg_5C_0;
				flag = flag3.GetValueOrDefault();
				if (flag)
				{
					this.ButtonItem16_Click(null, null);
				}
				else
				{
					num = 2;
					bool? arg_A3_0;
					if (!nahvefurush.HasValue)
					{
						arg_A3_0 = null;
					}
					else
					{
						flag3 = new bool?(nahvefurush.GetValueOrDefault() == num);
						arg_A3_0 = flag3;
					}
					bool? flag2 = arg_A3_0;
					flag = flag2.GetValueOrDefault();
					if (flag)
					{
						this.ButtonItem17_Click(null, null);
					}
					else
					{
						num = 3;
						bool? arg_EB_0;
						if (!nahvefurush.HasValue)
						{
							arg_EB_0 = null;
						}
						else
						{
							flag3 = new bool?(nahvefurush.GetValueOrDefault() == num);
							arg_EB_0 = flag3;
						}
						flag2 = arg_EB_0;
						flag = flag2.GetValueOrDefault();
						if (flag)
						{
							this.ButtonItem18_Click(null, null);
						}
						else
						{
							num = 4;
							bool? arg_130_0;
							if (!nahvefurush.HasValue)
							{
								arg_130_0 = null;
							}
							else
							{
								flag3 = new bool?(nahvefurush.GetValueOrDefault() == num);
								arg_130_0 = flag3;
							}
							flag2 = arg_130_0;
							flag = flag2.GetValueOrDefault();
							if (flag)
							{
								this.ButtonItem19_Click(null, null);
							}
						}
					}
				}
			}
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x001ACE04 File Offset: 0x001AB004
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
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(",00", "").Replace(".0", "");
					}
					flag = (dataRow["zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["zarf"] = dataRow["zarf"].ToString().Replace(",00", "").Replace(".0", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(",00", "").Replace(".0", "");
					}
					flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = dataRow["vazn_ba_zarf"].ToString().Replace(",00", "").Replace(".0", "");
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

		// Token: 0x060023EC RID: 9196 RVA: 0x001ACFCC File Offset: 0x001AB1CC
		private void Load_Oft()
		{
			bool flag = !Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (!flag)
			{
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["zarf"].Visible = false;
				flag = (Conversions.ToDouble(Public_Function.dict["oft_kind"]) == 1.0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["vazn_ba_oft"].Visible = true;
					this.GridEX1.RootTable.Columns["darsad_oft"].Visible = true;
					this.GridEX1.RootTable.Columns["vazn_oft"].Visible = true;
				}
				flag = (Conversions.ToDouble(Public_Function.dict["oft_kind"]) == 2.0);
				if (flag)
				{
					this.GridEX1.RootTable.Columns["vazn_ba_oft"].Visible = true;
					this.GridEX1.RootTable.Columns["vazn_oft"].Visible = true;
				}
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x001AD12C File Offset: 0x001AB32C
		private void LoadData()
		{
			bool flag = this.dt_Kharid == null;
			if (flag)
			{
				this.dt_Kharid = this.Riz_Kharid.GetByID(checked((int)this.Kharid_ID));
				flag = this.Moshtari_ID.HasValue;
				if (flag)
				{
					string arg_68_0 = "select name +' '+ family from moshtari where id=";
					long? moshtari_ID = this.Moshtari_ID;
					string value = Conversions.ToString(Public_Function.ExecuteScalar(arg_68_0 + (moshtari_ID.HasValue ? Conversions.ToString(moshtari_ID.GetValueOrDefault()) : null)));
					try
					{
						IEnumerator enumerator = this.dt_Kharid.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							dataRow["moshtari_id"] = this.Moshtari_ID;
							dataRow["moshtari_name"] = value;
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
				}
			}
			this.RemoveZero(this.dt_Kharid);
			this.LoadNahve_Furush();
			this.Load_Oft();
			this.GridEX1.DataSource = this.dt_Kharid;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x001AD268 File Offset: 0x001AB468
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

		// Token: 0x060023EF RID: 9199 RVA: 0x001AD2FC File Offset: 0x001AB4FC
		private void GetSum(string key, bool GroupDigit = false)
		{
			decimal num = 0m;
			int arg_18_0 = 0;
			checked
			{
				int num2 = this.GridEX1.RowCount - 1;
				int num3 = arg_18_0;
				bool flag;
				while (true)
				{
					int arg_96_0 = num3;
					int num4 = num2;
					if (arg_96_0 > num4)
					{
						break;
					}
					flag = (this.GridEX1.GetRow(num3).RowType == RowType.TotalRow);
					if (!flag)
					{
						flag = (this.GridEX1.GetRow(num3).Cells[key].Value == DBNull.Value);
						if (!flag)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, this.GridEX1.GetRow(num3).Cells[key].Value));
						}
					}
					num3++;
				}
				flag = !GroupDigit;
				if (flag)
				{
					this.GridEX1.GetTotalRow().Cells[key].Text = num.ToString().Replace(".0", "");
				}
				else
				{
					this.GridEX1.GetTotalRow().Cells[key].Text = Strings.FormatNumber(num, 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				}
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x001AD40C File Offset: 0x001AB60C
		private void Calc()
		{
			bool flag = !this.GridEX1.RootTable.Columns["zarf"].Visible;
			if (!flag)
			{
				flag = (this.GridEX1.GetRow().Cells["Tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Tedad"].Value != null);
				decimal? num2;
				decimal? num;
				if (flag)
				{
					object expr_A1 = this.GridEX1.GetRow().Cells["Tedad"].Value;
					num = ((expr_A1 != null) ? ((decimal?)expr_A1) : num2);
				}
				flag = (this.GridEX1.GetRow().Cells["Zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Zarf"].Value != null);
				decimal? num3;
				if (flag)
				{
					object expr_126 = this.GridEX1.GetRow().Cells["Zarf"].Value;
					num3 = ((expr_126 != null) ? ((decimal?)expr_126) : num2);
				}
				flag = (this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != null);
				decimal? num4;
				if (flag)
				{
					object expr_1AB = this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value;
					num4 = ((expr_1AB != null) ? ((decimal?)expr_1AB) : num2);
				}
				flag = (num.HasValue && num4.HasValue && num3.HasValue);
				bool flag4;
				if (flag)
				{
					decimal? arg_222_0;
					if (!(num3.HasValue & num.HasValue))
					{
						arg_222_0 = null;
					}
					else
					{
						decimal? num5 = new decimal?(decimal.Multiply(num3.GetValueOrDefault(), num.GetValueOrDefault()));
						arg_222_0 = num5;
					}
					decimal? num6 = arg_222_0;
					bool? arg_264_0;
					if (!(num6.HasValue & num4.HasValue))
					{
						arg_264_0 = null;
					}
					else
					{
						bool? flag2 = new bool?(decimal.Compare(num6.GetValueOrDefault(), num4.GetValueOrDefault()) >= 0);
						arg_264_0 = flag2;
					}
					bool? flag3 = arg_264_0;
					flag4 = flag3.GetValueOrDefault();
					if (flag4)
					{
						this.GridEX1.CurrentRow.Cells["Zarf"].Value = DBNull.Value;
						this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4;
						this.GetSum("zarf", false);
					}
					else
					{
						GridEXCell arg_38E_0 = this.GridEX1.CurrentRow.Cells["vazn_kol"];
						bool arg_335_0 = num4.HasValue;
						decimal? arg_32C_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_32C_0 = null;
						}
						else
						{
							decimal? num7 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_32C_0 = num7;
						}
						decimal? num5 = arg_32C_0;
						decimal? arg_361_0;
						if (!(arg_335_0 & num5.HasValue))
						{
							arg_361_0 = null;
						}
						else
						{
							num6 = new decimal?(decimal.Subtract(num4.GetValueOrDefault(), num5.GetValueOrDefault()));
							arg_361_0 = num6;
						}
						decimal? num8 = arg_361_0;
						arg_38E_0.Value = num8.ToString().Replace(",00", "").Replace(".0", "");
					}
				}
				flag4 = (!num.HasValue || !num3.HasValue);
				if (flag4)
				{
					flag = num4.HasValue;
					if (flag)
					{
						this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4.Value;
					}
				}
				this.GetSum("vazn_kol", false);
			}
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x001AD818 File Offset: 0x001ABA18
		private void GetTotalZarf()
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				decimal num;
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["tedad"].Value != DBNull.Value;
					if (flag)
					{
						bool flag2 = gridEXRow.Cells["zarf"].Value != DBNull.Value;
						if (flag2)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, Operators.MultiplyObject(gridEXRow.Cells["tedad"].Value, gridEXRow.Cells["zarf"].Value)));
						}
					}
				}
				this.GridEX1.GetTotalRow().Cells["zarf"].Text = num.ToString().Replace(".00", "").Replace(".0", "");
			}
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x001AD924 File Offset: 0x001ABB24
		private void CalcMablagh(bool calc_jam_kol)
		{
			bool flag = this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				object expr_72 = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
				num = ((expr_72 != null) ? ((decimal?)expr_72) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["fee"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag)
			{
				object expr_F8 = this.GridEX1.GetRow().Cells["fee"].Value;
				num3 = ((expr_F8 != null) ? ((decimal?)expr_F8) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["tedad"].Value != null);
			decimal? num4;
			if (flag)
			{
				object expr_17E = this.GridEX1.GetRow().Cells["tedad"].Value;
				num4 = ((expr_17E != null) ? ((decimal?)expr_17E) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["jam_Kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_Kol"].Value != null);
			decimal? num5;
			if (flag)
			{
				object expr_204 = this.GridEX1.GetRow().Cells["jam_Kol"].Value;
				num5 = ((expr_204 != null) ? ((decimal?)expr_204) : num2);
			}
			bool flag2;
			if (calc_jam_kol)
			{
				flag2 = (num.HasValue && num3.HasValue);
				if (flag2)
				{
					GridEXCell arg_299_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
					decimal? arg_294_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_294_0 = null;
					}
					else
					{
						decimal? num6 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_294_0 = num6;
					}
					arg_299_0.Value = arg_294_0;
				}
				int num7 = 3;
				int? nahvefurush = this.Nahvefurush;
				bool? arg_2D5_0;
				if (!nahvefurush.HasValue)
				{
					arg_2D5_0 = null;
				}
				else
				{
					bool? flag3 = new bool?(nahvefurush.GetValueOrDefault() == num7);
					arg_2D5_0 = flag3;
				}
				bool? flag4 = arg_2D5_0;
				flag2 = flag4.GetValueOrDefault();
				if (flag2)
				{
					flag = (num4.HasValue && num3.HasValue);
					if (flag)
					{
						GridEXCell arg_35A_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
						decimal? arg_355_0;
						if (!(num4.HasValue & num3.HasValue))
						{
							arg_355_0 = null;
						}
						else
						{
							decimal? num6 = new decimal?(decimal.Multiply(num4.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_355_0 = num6;
						}
						arg_35A_0.Value = arg_355_0;
					}
				}
			}
			flag2 = !calc_jam_kol;
			if (flag2)
			{
				flag = (num.HasValue && num5.HasValue);
				bool? flag3;
				bool valueOrDefault;
				if (flag)
				{
					decimal zero = decimal.Zero;
					bool? arg_3CA_0;
					if (!num.HasValue)
					{
						arg_3CA_0 = null;
					}
					else
					{
						bool? flag4 = new bool?(decimal.Compare(num.GetValueOrDefault(), zero) != 0);
						arg_3CA_0 = flag4;
					}
					flag3 = arg_3CA_0;
					valueOrDefault = flag3.GetValueOrDefault();
					if (valueOrDefault)
					{
						GridEXCell arg_432_0 = this.GridEX1.CurrentRow.Cells["fee"];
						decimal? arg_42D_0;
						if (!(num5.HasValue & num.HasValue))
						{
							arg_42D_0 = null;
						}
						else
						{
							decimal? num6 = new decimal?(decimal.Divide(num5.GetValueOrDefault(), num.GetValueOrDefault()));
							arg_42D_0 = num6;
						}
						arg_432_0.Value = arg_42D_0;
					}
				}
				int num7 = 3;
				int? nahvefurush = this.Nahvefurush;
				bool? arg_46F_0;
				if (!nahvefurush.HasValue)
				{
					arg_46F_0 = null;
				}
				else
				{
					bool? flag4 = new bool?(nahvefurush.GetValueOrDefault() == num7);
					arg_46F_0 = flag4;
				}
				flag3 = arg_46F_0;
				valueOrDefault = flag3.GetValueOrDefault();
				if (valueOrDefault)
				{
					flag2 = (num4.HasValue && num3.HasValue);
					if (flag2)
					{
						decimal zero = decimal.Zero;
						bool? arg_4DB_0;
						if (!num4.HasValue)
						{
							arg_4DB_0 = null;
						}
						else
						{
							bool? flag5 = new bool?(decimal.Compare(num4.GetValueOrDefault(), zero) != 0);
							arg_4DB_0 = flag5;
						}
						bool? flag6 = arg_4DB_0;
						flag = flag6.GetValueOrDefault();
						if (flag)
						{
							GridEXCell arg_543_0 = this.GridEX1.CurrentRow.Cells["fee"];
							decimal? arg_53E_0;
							if (!(num5.HasValue & num4.HasValue))
							{
								arg_53E_0 = null;
							}
							else
							{
								decimal? num6 = new decimal?(decimal.Divide(num5.GetValueOrDefault(), num4.GetValueOrDefault()));
								arg_53E_0 = num6;
							}
							arg_543_0.Value = arg_53E_0;
						}
					}
				}
			}
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x001ADE80 File Offset: 0x001AC080
		private void Moshtari_select()
		{
			string command = "  SELECT     Moshtari.ID, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE     (Moshtari.ID > 0)";
			bool flag = this.frm.ShowDialog(command, MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["moshtari_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x001ADF78 File Offset: 0x001AC178
		private string local_GetID(DataTable dt, long moshtari_id)
		{
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["moshtari_id"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], moshtari_id, false);
						if (flag2)
						{
							bool flag3 = dataRow["kala_id"] != DBNull.Value;
							if (flag3)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["kala_id"], ",")));
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag3 = enumerator is IDisposable;
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			text = Public_Function.RemoveLast(text);
			return text;
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x001AE070 File Offset: 0x001AC270
		private void Kala_select()
		{
			string empty = string.Empty;
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0;
			checked
			{
				if (flag)
				{
					string arg_55_0 = "SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=";
					long? moshtari_ID = this.Moshtari_ID;
					string command = arg_55_0 + (moshtari_ID.HasValue ? Conversions.ToString(moshtari_ID.GetValueOrDefault()) : null) + empty;
					this.frm.ExtraData = (T)this.Moshtari_ID;
					flag = (this.frm.ShowDialog(command, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK);
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
				else
				{
					bool flag2 = this.GridEX1.GetRow().Cells["moshtari_id"].Value != DBNull.Value;
					if (flag2)
					{
						string command2 = "SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID where Moshtari_ID=" + this.GridEX1.GetRow().Cells["moshtari_id"].Value.ToString() + empty;
						this.frm.ExtraData = Conversions.ToLong(this.GridEX1.GetRow().Cells["moshtari_id"].Value);
						flag2 = (this.frm.ShowDialog(command2, MyProject.Forms.Frm_Moshtari_kala, 0) == DialogResult.OK);
						if (flag2)
						{
							flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["Kala_Name"].Position && this.GridEX1.EditTextBox != null);
							if (flag)
							{
								this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
								this.GridEX1.GetRow().Cells["Kala_ID"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
								DataEntryGrid gridEX = this.GridEX1;
								gridEX.Col++;
							}
						}
					}
				}
			}
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x001AE358 File Offset: 0x001AC558
		private void GridEX1_AddingRecord(object sender, CancelEventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["moshtari_name"].Value == DBNull.Value && gridEXRow.Cells["kala_name"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x001AE3D8 File Offset: 0x001AC5D8
		private void GridEX1_CurrentCellChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow.Cells["auto"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["auto"].Value, true, false);
				if (flag2)
				{
					this.GridEX1.CurrentRow.Cells["kala_name"].ButtonEnabled = false;
					this.GridEX1.CurrentRow.Cells["kala_name"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["tedad"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["jam_kol"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["vazn_kol"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["fee"].EditType = EditType.NoEdit;
					this.GridEX1.CurrentRow.Cells["zarf"].EditType = EditType.NoEdit;
				}
			}
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x001AE554 File Offset: 0x001AC754
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x001AE580 File Offset: 0x001AC780
		private void Feechanged()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["kala_id"].Value == DBNull.Value;
			checked
			{
				if (!flag)
				{
					long num = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_id"].Value);
					flag = (this.dt_kala_to_kala == null);
					if (!flag)
					{
						try
						{
							IEnumerator enumerator = this.dt_kala_to_kala.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag = Operators.ConditionalCompareObjectEqual(dataRow["parent_kala_id"], num, false);
								if (flag)
								{
									GridEXRow[] rows = this.GridEX1.GetRows();
									for (int i = 0; i < rows.Length; i++)
									{
										GridEXRow gridEXRow = rows[i];
										bool flag2 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["kala_id"].Value, dataRow["child_kala_id"], false);
										if (flag2)
										{
											gridEXRow.BeginEdit();
											gridEXRow.Cells["fee"].Value = RuntimeHelpers.GetObjectValue(this.GridEX1.CurrentRow.Cells["fee"].Value);
											gridEXRow.EndEdit();
											flag2 = (this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null);
											if (flag2)
											{
												object expr_1B7 = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
												decimal? num2;
												decimal? arg_1CA_0 = (expr_1B7 != null) ? ((decimal?)expr_1B7) : num2;
											}
											flag2 = (gridEXRow.Cells["vazn_kol"].Value != DBNull.Value && gridEXRow.Cells["vazn_kol"].Value != null);
											if (flag2)
											{
												gridEXRow.BeginEdit();
												gridEXRow.Cells["jam_kol"].Value = Operators.MultiplyObject(gridEXRow.Cells["vazn_kol"].Value, this.GridEX1.CurrentRow.Cells["fee"].Value);
												gridEXRow.EndEdit();
											}
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
				}
			}
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x001AE864 File Offset: 0x001ACA64
		private void calc_oft()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["vazn_ba_oft"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(Public_Function.dict["oft_kind"]) == 1.0;
				if (flag2)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["darsad_oft"].Value != DBNull.Value;
					if (flag3)
					{
						this.GridEX1.CurrentRow.Cells["vazn_oft"].Value = Operators.DivideObject(Operators.MultiplyObject(this.GridEX1.CurrentRow.Cells["vazn_ba_oft"].Value, this.GridEX1.CurrentRow.Cells["darsad_oft"].Value), 100);
						this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = Operators.SubtractObject(this.GridEX1.CurrentRow.Cells["vazn_ba_oft"].Value, this.GridEX1.CurrentRow.Cells["vazn_oft"].Value);
					}
				}
				else
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["vazn_oft"].Value != DBNull.Value;
					if (flag3)
					{
						this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = Operators.SubtractObject(this.GridEX1.CurrentRow.Cells["vazn_ba_oft"].Value, this.GridEX1.CurrentRow.Cells["vazn_oft"].Value);
					}
				}
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x001AEA68 File Offset: 0x001ACC68
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tedad", false) == 0;
			if (flag)
			{
				this.Calc();
				this.GetSum("tedad", false);
				this.GetTotalZarf();
			}
			else
			{
				flag = (Operators.CompareString(left, "vazn_ba_zarf", false) == 0);
				if (flag)
				{
					this.Calc();
					this.GetSum("vazn_ba_zarf", false);
				}
				else
				{
					flag = (Operators.CompareString(left, "vazn_kol", false) == 0);
					if (flag)
					{
						this.GetSum("Vazn_Kol", false);
						this.CalcMablagh(true);
					}
					else
					{
						flag = (Operators.CompareString(left, "vazn_ba_oft", false) == 0);
						if (flag)
						{
							this.calc_oft();
							this.CalcMablagh(true);
						}
						else
						{
							flag = (Operators.CompareString(left, "darsad_oft", false) == 0);
							if (flag)
							{
								this.calc_oft();
								this.CalcMablagh(true);
							}
							else
							{
								flag = (Operators.CompareString(left, "vazn_oft", false) == 0);
								if (flag)
								{
									this.calc_oft();
									this.CalcMablagh(true);
								}
								else
								{
									flag = (Operators.CompareString(left, "zarf", false) == 0);
									if (flag)
									{
										this.Calc();
										this.GetTotalZarf();
									}
									else
									{
										flag = (Operators.CompareString(left, "fee", false) == 0);
										if (flag)
										{
											this.CalcMablagh(true);
											this.Feechanged();
										}
										else
										{
											flag = (Operators.CompareString(left, "jam_kol", false) == 0);
											if (flag)
											{
												this.GetSum("jam_Kol", true);
												this.CalcMablagh(false);
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

		// Token: 0x060023FC RID: 9212 RVA: 0x001AEC0C File Offset: 0x001ACE0C
		private void DelKala()
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
				if (flag2)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["kala_id"].Value != DBNull.Value;
					if (flag3)
					{
						long num = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["Kala_ID"].Value);
						try
						{
							IEnumerator enumerator = this.Furush_Table.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag3 = (dataRow["kala_id"] != DBNull.Value);
								if (flag3)
								{
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow["kala_id"], num, false);
									if (flag2)
									{
										Public_Function.ShowMessage("جنس مورد نظر در فروش استفاده شده است", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
										return;
									}
								}
							}
						}
						finally
						{
							IEnumerator enumerator;
							flag3 = (enumerator is IDisposable);
							if (flag3)
							{
								(enumerator as IDisposable).Dispose();
							}
						}
						flag3 = (this.dt_kala_to_kala != null);
						if (flag3)
						{
							DataRow[] array = this.dt_kala_to_kala.Select(Conversions.ToString(Operators.ConcatenateObject("parent_kala_id=", this.GridEX1.CurrentRow.Cells["kala_ID"].Value)));
							flag3 = (array.Length > 0);
							if (flag3)
							{
								try
								{
									IEnumerator enumerator2 = this.dt_Kharid.Rows.GetEnumerator();
									while (enumerator2.MoveNext())
									{
										DataRow dataRow2 = (DataRow)enumerator2.Current;
										flag2 = (dataRow2["kala_id"] != DBNull.Value);
										if (flag2)
										{
											flag = Operators.ConditionalCompareObjectEqual(dataRow2["kala_id"], array[0]["child_kala_id"], false);
											if (flag)
											{
												bool flag4 = dataRow2["tedad"] != DBNull.Value && dataRow2["vazn_kol"] != DBNull.Value;
												if (flag4)
												{
													Public_Function.ShowMessage("بدلیل کسر اتوماتیک از این جنس امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
													return;
												}
											}
										}
									}
								}
								finally
								{
									IEnumerator enumerator2;
									bool flag4 = enumerator2 is IDisposable;
									if (flag4)
									{
										(enumerator2 as IDisposable).Dispose();
									}
								}
							}
						}
					}
					this.GridEX1.CurrentRow.Delete();
					((DataTable)this.GridEX1.DataSource).AcceptChanges();
				}
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x001AEED0 File Offset: 0x001AD0D0
		private void GridEX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			int position = e.Column.Position;
			bool flag = position == this.GridEX1.RootTable.Columns["moshtari_Name"].Position;
			if (flag)
			{
				this.Moshtari_select();
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
						flag = (position == this.GridEX1.RootTable.Columns["pardakht"].Position);
						if (flag)
						{
							Frm_Pardakht_BeMoshtari frm_Pardakht_BeMoshtari = new Frm_Pardakht_BeMoshtari();
							frm_Pardakht_BeMoshtari.Moshtari_ID = Conversions.ToString(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value);
							frm_Pardakht_BeMoshtari.Tarikh = Conversions.ToString(this.GridEX1.CurrentRow.Cells["tarikh_fa"].Value);
							frm_Pardakht_BeMoshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["moshtari_name"].Value);
							MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Pardakht_BeMoshtari);
						}
					}
				}
			}
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x001AF048 File Offset: 0x001AD248
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
				flag = (Operators.CompareString(left, "fee", false) == 0);
				if (flag)
				{
					bool flag2 = ((CurrencyBox)e.EditControl).Value.HasValue;
					if (flag2)
					{
						e.Value = ((CurrencyBox)e.EditControl).Value;
					}
				}
				else
				{
					bool flag2 = Operators.CompareString(left, "jam_kol", false) == 0;
					if (flag2)
					{
						flag = ((CurrencyBox)e.EditControl).Value.HasValue;
						if (flag)
						{
							e.Value = ((CurrencyBox)e.EditControl).Value;
						}
					}
					else
					{
						flag2 = (Operators.CompareString(left, "mablagh_kargari", false) == 0);
						if (flag2)
						{
							flag = ((CurrencyBox)e.EditControl).Value.HasValue;
							if (flag)
							{
								e.Value = ((CurrencyBox)e.EditControl).Value;
							}
						}
					}
				}
			}
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x001AF18C File Offset: 0x001AD38C
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
				flag = (Operators.CompareString(left, "fee", false) == 0);
				if (flag)
				{
					e.EditControl = this.txt_fee;
					this.txt_fee.Text = e.Value.ToString();
					this.txt_fee.SelectAll();
				}
				else
				{
					flag = (Operators.CompareString(left, "jam_kol", false) == 0);
					if (flag)
					{
						e.EditControl = this.txt_jam_kol;
						this.txt_jam_kol.Text = e.Value.ToString();
						this.txt_jam_kol.SelectAll();
					}
					else
					{
						flag = (Operators.CompareString(left, "mablagh_kargari", false) == 0);
						if (flag)
						{
							e.EditControl = this.txt_kargari;
							this.txt_kargari.Text = e.Value.ToString();
							this.txt_kargari.SelectAll();
						}
					}
				}
			}
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x001AF2C4 File Offset: 0x001AD4C4
		private void move_right()
		{
			int col = this.GridEX1.Col;
			DataEntryGrid gridEX = this.GridEX1;
			checked
			{
				gridEX.Col--;
				bool flag = col == this.GridEX1.Col;
				if (flag)
				{
					int num = 2;
					while (this.GridEX1.Col >= col)
					{
						gridEX = this.GridEX1;
						gridEX.Col -= num;
						num++;
					}
				}
			}
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x0000927B File Offset: 0x0000747B
		private void txt_tarikhGrid_OnLeft()
		{
			this.prevent_left = true;
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00009286 File Offset: 0x00007486
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_right = true;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x001AF33C File Offset: 0x001AD53C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = this.GridEX1.AllowEdit == InheritableBoolean.False;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.CurrentRow.Cells["auto"].Value != DBNull.Value);
					bool flag2;
					if (flag)
					{
						flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["auto"].Value, true, false);
						if (flag2)
						{
							e.SuppressKeyPress = true;
						}
					}
					flag2 = (this.GridEX1.EditTextBox == null);
					if (flag2)
					{
						flag = (this.GridEX1.GetRow().RowType == RowType.Record);
						if (flag)
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
							this.Kala_select();
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_name"].Position);
						if (flag2)
						{
							this.GridEX1.CurrentRow.Cells["moshtari_id"].Value = DBNull.Value;
							this.Moshtari_select();
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
						flag2 = this.prevent_right;
						if (flag2)
						{
							this.prevent_right = false;
							return;
						}
						flag2 = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["tarikh_fa"].Position);
						if (flag2)
						{
							e.SuppressKeyPress = true;
							return;
						}
						flag2 = (this.GridEX1.Col > 0);
						if (flag2)
						{
							this.move_right();
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
						flag = (col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position);
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
									this.Moshtari_select();
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
							bool flag3 = col == this.GridEX1.RootTable.Columns["Kala_Name"].Position;
							if (flag3)
							{
								flag2 = this.prevent;
								if (flag2)
								{
									e.SuppressKeyPress = true;
									this.prevent = false;
								}
								else
								{
									flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (flag3)
									{
										this.Kala_select();
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
								flag3 = (col == this.GridEX1.RootTable.Columns["fee"].Position);
								if (!flag3)
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["jam_kol"].Position);
									if (flag3)
									{
										e.SuppressKeyPress = true;
									}
									else
									{
										flag3 = (col == this.GridEX1.RootTable.Columns["darsad_oft"].Position);
										if (flag3)
										{
											DataEntryGrid gridEX = this.GridEX1;
											gridEX.Col += 2;
										}
										else
										{
											flag3 = (col == this.GridEX1.RootTable.Columns["mablagh_kargari"].Position);
											if (flag3)
											{
												flag2 = this.prevent;
												if (flag2)
												{
													e.SuppressKeyPress = true;
													this.prevent = false;
												}
												else
												{
													flag3 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
													if (flag3)
													{
														this.GridEX1.UpdateData();
													}
													this.GridEX1.MoveToNewRecord();
													this.GridEX1.Col = 0;
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
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x001AF998 File Offset: 0x001ADB98
		private void txt_fee_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					e.SuppressKeyPress = true;
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x001AF9D4 File Offset: 0x001ADBD4
		private void txt_jam_kol_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.CurrentRow.RowType == RowType.Record;
					bool flag3;
					if (flag2)
					{
						flag3 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
						if (flag3)
						{
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Row++;
							this.prevent = true;
							this.GridEX1.Col = this.GridEX1.RootTable.Columns["Kala_Name"].Position;
						}
					}
					flag3 = !Conversions.ToBoolean(Public_Function.dict["kargari"]);
					if (flag3)
					{
						flag2 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
						if (flag2)
						{
							this.GridEX1.UpdateData();
						}
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
					}
					else
					{
						flag3 = (Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 1.0);
						if (flag3)
						{
							this.prevent = true;
							DataEntryGrid gridEX = this.GridEX1;
							gridEX.Col++;
						}
						else
						{
							flag3 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
							if (flag3)
							{
								this.GridEX1.UpdateData();
							}
							this.GridEX1.MoveToNewRecord();
							this.GridEX1.Col = 0;
							this.GridEX1.EditMode = EditMode.EditOn;
						}
					}
				}
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x001AFB74 File Offset: 0x001ADD74
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int num = 0;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] == DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = 0;
					}
					flag = (dataRow["vazn_ba_zarf"] == DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = 0;
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
			checked
			{
				bool result;
				bool flag2;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = dataRow2["Kala_ID"] == DBNull.Value;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "kala_Name", "جنس را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow2["vazn_kol"] == DBNull.Value);
						if (flag)
						{
							flag2 = (dataRow2["vazn_Ba_Zarf"] == DBNull.Value);
							if (flag2)
							{
								dataRow2["vazn_Kol"] = 0;
							}
						}
						flag2 = (dataRow2["fee"] == DBNull.Value);
						if (flag2)
						{
							dataRow2["fee"] = 0;
						}
						flag2 = (dataRow2["jam_kol"] == DBNull.Value);
						if (flag2)
						{
							dataRow2["jam_Kol"] = 0;
						}
						flag2 = (dataRow2["Tedad"] == DBNull.Value && dataRow2["Vazn_Ba_Zarf"] == DBNull.Value);
						if (flag2)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "Vazn_Ba_Zarf", "تعداد و یا وزن با ظرف را وارد نمایید");
							result = false;
							return result;
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag2 = (enumerator2 is IDisposable);
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
						flag2 = (dataRow3["tedad"] == DBNull.Value);
						if (flag2)
						{
							dataRow3["tedad"] = 0;
						}
						flag2 = (dataRow3["vazn_ba_zarf"] == DBNull.Value);
						if (flag2)
						{
							dataRow3["vazn_ba_zarf"] = 0;
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					flag2 = (enumerator3 is IDisposable);
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				flag2 = this.EditAndSave;
				if (flag2)
				{
					result = true;
				}
				else
				{
					string iD = Public_Function.GetID(dataTable, "kala_id", "");
					flag2 = (Operators.CompareString(iD, string.Empty, false) != 0);
					if (flag2)
					{
						DataRow[] array = this.Furush_Table.Select("kala_id not in(" + iD + ")");
						flag2 = (array.Length > 0);
						if (flag2)
						{
							DataRow[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								DataRow dataRow4 = array2[i];
								bool flag = dataRow4["tedad"] == DBNull.Value && dataRow4["vazn_kol"] == DBNull.Value;
								if (!flag)
								{
									Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("جنس ", array[0]["kala_name"]), " در ریز بار ثبت نگردیده است ")), MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
									result = false;
									return result;
								}
							}
						}
					}
					result = true;
				}
				return result;
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x001AFFF0 File Offset: 0x001AE1F0
		private void SetZero()
		{
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] == DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = 0;
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

		// Token: 0x06002408 RID: 9224 RVA: 0x001B0090 File Offset: 0x001AE290
		private void frm_Frush_hag_Activated(object sender, EventArgs e)
		{
			bool flag = this.GotoLineID != -1L;
			if (flag)
			{
				this.GridEX1.Focus();
				this.GridEX1.EditMode = EditMode.EditOn;
			}
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x001B00CC File Offset: 0x001AE2CC
		private void Frm_RizKharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			bool flag = this.Preview;
			if (!flag)
			{
				flag = this.ValidateGridData();
				if (flag)
				{
					this.SetZero();
					this.GetSum();
					flag = this.EditAndSave;
					if (flag)
					{
						bool flag2 = Public_Function.ShowMessage("آیا مایل به ذخیره اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) > DialogResult.None;
						if (flag2)
						{
							this.Riz_Kharid.Update(checked((int)this.Kharid_ID), this.dt_Kharid, Conversions.ToInteger(Public_Function.dict["kharid_kind"]));
						}
					}
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x001B015C File Offset: 0x001AE35C
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.GridEX1.MoveToNewRecord();
				this.Close();
			}
			flag = (e.KeyCode == Keys.F12);
			if (flag)
			{
				MyProject.Forms.Form_Main.UiButton4_Click(null, null);
			}
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x001B01B0 File Offset: 0x001AE3B0
		private void btn_click(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "del", false) == 0;
			if (flag)
			{
				bool flag2 = this.frm.GridEX1.CurrentRow != null;
				if (flag2)
				{
					try
					{
						bool hasValue = this.Moshtari_ID.HasValue;
						if (hasValue)
						{
							object arg_D6_0 = null;
							Type arg_D6_1 = typeof(Public_Function);
							string arg_D6_2 = "ExecuteNonQuery";
							object[] array = new object[1];
							object[] arg_CF_0 = array;
							int arg_CF_1 = 0;
							string arg_97_0 = "delete from moshtari_kala where moshtari_id=";
							long? moshtari_ID = this.Moshtari_ID;
							arg_CF_0[arg_CF_1] = Operators.ConcatenateObject(arg_97_0 + (moshtari_ID.HasValue ? Conversions.ToString(moshtari_ID.GetValueOrDefault()) : null) + " and kala_id=", this.frm.GridEX1.CurrentRow.Cells["ID"].Value);
							NewLateBinding.LateCall(arg_D6_0, arg_D6_1, arg_D6_2, array, null, null, null, true);
						}
						else
						{
							NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
							{
								Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from moshtari_kala where moshtari_id=", this.GridEX1.CurrentRow.Cells["moshtari_id"].Value), " and kala_id="), this.frm.GridEX1.CurrentRow.Cells["ID"].Value)
							}, null, null, null, true);
						}
						this.frm.GridEX1.CurrentRow.Delete();
					}
					catch (Exception expr_17D)
					{
						ProjectData.SetProjectError(expr_17D);
						Public_Function.ShowMessage("امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x001B0378 File Offset: 0x001AE578
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			bool flag = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["mablagh_kargari"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.Columns["mablagh_kargari"].Visible = false;
			}
			flag = (Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = false;
			}
			else
			{
				this.GridEX1.RootTable.Columns["moshtari_name"].Visible = true;
			}
			flag = (Conversions.ToDouble(Public_Function.dict["kargari_kind"]) == 2.0);
			if (flag)
			{
				this.GridEX1.RootTable.Columns["mablagh_kargari"].Visible = false;
			}
			this.LoadData();
			this.GridEX1.MoveToNewRecord();
			this.GridEX1.Col = 0;
			this.GridEX1.EditMode = EditMode.EditOn;
			this.frm.CanDelete = true;
			this.frm.GridEX1.ColumnButtonClick += new ColumnActionEventHandler(this.btn_click);
			flag = this.Preview;
			if (flag)
			{
				this.GridEX1.AllowAddNew = InheritableBoolean.False;
				this.GridEX1.AllowEdit = InheritableBoolean.False;
				this.GridEX1.RootTable.Columns["del"].Visible = false;
				this.GridEX1.RootTable.Columns["kala_name"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
			}
			flag = this.EditAndSave;
			checked
			{
				if (flag)
				{
					this.GridEX1.AllowAddNew = InheritableBoolean.False;
					flag = (this.GotoLineID != -1L);
					if (flag)
					{
						GridEXRow[] rows = this.GridEX1.GetRows();
						for (int i = 0; i < rows.Length; i++)
						{
							GridEXRow gridEXRow = rows[i];
							bool flag2 = Operators.ConditionalCompareObjectEqual(((DataRowView)gridEXRow.DataRow)["ID"], this.GotoLineID, false);
							if (flag2)
							{
								this.GridEX1.Focus();
								this.GridEX1.MoveTo(gridEXRow);
								this.GridEX1.Col = this.GridEX1.RootTable.Columns["fee"].Position;
								this.GridEX1.EditMode = EditMode.EditOn;
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x001B0668 File Offset: 0x001AE868
		private void GridEX1_SelectionChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (!flag)
			{
				flag = (this.GridEX1.CurrentRow.Cells["auto"].Value != DBNull.Value);
				if (flag)
				{
					bool flag2 = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["auto"].Value, true, false);
					if (flag2)
					{
						this.GridEX1.CurrentRow.Cells["kala_name"].ButtonEnabled = false;
						this.GridEX1.CurrentRow.Cells["kala_name"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["tedad"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["jam_kol"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["vazn_ba_zarf"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["vazn_kol"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["fee"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["zarf"].EditType = EditType.NoEdit;
						this.GridEX1.CurrentRow.Cells["del"].ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton;
					}
				}
			}
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x001B0820 File Offset: 0x001AEA20
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x001AE358 File Offset: 0x001AC558
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["moshtari_name"].Value == DBNull.Value && gridEXRow.Cells["kala_name"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x04000DEE RID: 3566
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000DF0 RID: 3568
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000DF1 RID: 3569
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000DF2 RID: 3570
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000DF3 RID: 3571
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000DF4 RID: 3572
		[AccessedThroughProperty("txt_kargari")]
		private CurrencyBox _txt_kargari;

		// Token: 0x04000DF5 RID: 3573
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000DF6 RID: 3574
		private Frm_SelectItem frm;

		// Token: 0x04000DF7 RID: 3575
		private Kharid_Detail Riz_Kharid;

		// Token: 0x04000DF8 RID: 3576
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000DF9 RID: 3577
		[CompilerGenerated]
		private long? _Moshtari_ID;

		// Token: 0x04000DFA RID: 3578
		[CompilerGenerated]
		private DataTable _dt_Kharid;

		// Token: 0x04000DFB RID: 3579
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000DFC RID: 3580
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000DFD RID: 3581
		[CompilerGenerated]
		private bool _Preview;

		// Token: 0x04000DFE RID: 3582
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x04000DFF RID: 3583
		[CompilerGenerated]
		private bool _EditAndSave;

		// Token: 0x04000E00 RID: 3584
		[CompilerGenerated]
		private long _GotoLineID;

		// Token: 0x04000E01 RID: 3585
		[CompilerGenerated]
		private int? _Nahvefurush;

		// Token: 0x04000E02 RID: 3586
		private bool prevent_left;

		// Token: 0x04000E03 RID: 3587
		private bool prevent_right;

		// Token: 0x04000E04 RID: 3588
		private bool prevent;
	}
}
