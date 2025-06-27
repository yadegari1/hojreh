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
	// Token: 0x0200010E RID: 270
	[DesignerGenerated]
	public partial class Frm_Sardkhane_RizKharid : Form
	{
		// Token: 0x060026C6 RID: 9926 RVA: 0x001D504C File Offset: 0x001D324C
		public Frm_Sardkhane_RizKharid()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_RizKharid_FormClosing);
			base.KeyDown += new KeyEventHandler(this.Frm_RizKharid_KeyDown);
			base.Load += new EventHandler(this.Frm_RizKharid_Load);
			Frm_Sardkhane_RizKharid.__ENCAddToList(this);
			this.frm = new Frm_SelectItem();
			this.Riz_Kharid = new Kharid_Sardkhane_detail();
			bool flag = false;
			this.Preview = flag;
			int nahve_kharid = 4;
			this.nahve_kharid = nahve_kharid;
			flag = false;
			this.is_Varedat = flag;
			this.prevent = false;
			this.prevent_left = false;
			this.InitializeComponent();
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x001D50F0 File Offset: 0x001D32F0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sardkhane_RizKharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sardkhane_RizKharid.__ENCList.Count == Frm_Sardkhane_RizKharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sardkhane_RizKharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sardkhane_RizKharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sardkhane_RizKharid.__ENCList[num] = Frm_Sardkhane_RizKharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sardkhane_RizKharid.__ENCList.RemoveRange(num, Frm_Sardkhane_RizKharid.__ENCList.Count - num);
						Frm_Sardkhane_RizKharid.__ENCList.Capacity = Frm_Sardkhane_RizKharid.__ENCList.Count;
					}
					Frm_Sardkhane_RizKharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x001D59D4 File Offset: 0x001D3BD4
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x00009AA0 File Offset: 0x00007CA0
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

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x001D59EC File Offset: 0x001D3BEC
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x001D5A04 File Offset: 0x001D3C04
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
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				InitCustomEditEventHandler value3 = new InitCustomEditEventHandler(this.GridEX1_InitCustomEdit);
				RowLoadEventHandler value4 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX1_KeyDown);
				EventHandler value6 = new EventHandler(this.GridEX1_SelectionChanged);
				ColumnActionEventHandler value7 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EventHandler value8 = new EventHandler(this.GridEX1_CurrentCellChanged);
				CancelEventHandler value9 = new CancelEventHandler(this.GridEX1_AddingRecord);
				EndCustomEditEventHandler value10 = new EndCustomEditEventHandler(this.GridEX1_EndCustomEdit);
				ColumnActionEventHandler value11 = new ColumnActionEventHandler(this.GridEX1_ColumnButtonClick);
				EventHandler value12 = new EventHandler(this.GridEX1_RecordAdded);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyPress -= value2;
					this._GridEX1.InitCustomEdit -= value3;
					this._GridEX1.LoadingRow -= value4;
					this._GridEX1.KeyDown -= value5;
					this._GridEX1.SelectionChanged -= value6;
					this._GridEX1.CellEdited -= value7;
					this._GridEX1.CurrentCellChanged -= value8;
					this._GridEX1.AddingRecord -= value9;
					this._GridEX1.EndCustomEdit -= value10;
					this._GridEX1.ColumnButtonClick -= value11;
					this._GridEX1.RecordAdded -= value12;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyPress += value2;
					this._GridEX1.InitCustomEdit += value3;
					this._GridEX1.LoadingRow += value4;
					this._GridEX1.KeyDown += value5;
					this._GridEX1.SelectionChanged += value6;
					this._GridEX1.CellEdited += value7;
					this._GridEX1.CurrentCellChanged += value8;
					this._GridEX1.AddingRecord += value9;
					this._GridEX1.EndCustomEdit += value10;
					this._GridEX1.ColumnButtonClick += value11;
					this._GridEX1.RecordAdded += value12;
				}
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x001D5C14 File Offset: 0x001D3E14
		// (set) Token: 0x060026CF RID: 9935 RVA: 0x001D5C2C File Offset: 0x001D3E2C
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x001D5C8C File Offset: 0x001D3E8C
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x001D5CA4 File Offset: 0x001D3EA4
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x001D5D04 File Offset: 0x001D3F04
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x001D5D1C File Offset: 0x001D3F1C
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
				DateBox2.OnLeftEventHandler obj = new DateBox2.OnLeftEventHandler(this.txt_tarikhGrid_OnRight);
				bool flag = this._txt_tarikhGrid != null;
				if (flag)
				{
					this._txt_tarikhGrid.OnLeft -= obj;
				}
				this._txt_tarikhGrid = value;
				flag = (this._txt_tarikhGrid != null);
				if (flag)
				{
					this._txt_tarikhGrid.OnLeft += obj;
				}
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x001D5D7C File Offset: 0x001D3F7C
		// (set) Token: 0x060026D5 RID: 9941 RVA: 0x00009AAA File Offset: 0x00007CAA
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x001D5D94 File Offset: 0x001D3F94
		// (set) Token: 0x060026D7 RID: 9943 RVA: 0x00009AB4 File Offset: 0x00007CB4
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

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x001D5DAC File Offset: 0x001D3FAC
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00009ABE File Offset: 0x00007CBE
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x001D5DC4 File Offset: 0x001D3FC4
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x00009AC8 File Offset: 0x00007CC8
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x001D5DDC File Offset: 0x001D3FDC
		// (set) Token: 0x060026DD RID: 9949 RVA: 0x00009AD2 File Offset: 0x00007CD2
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

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060026DE RID: 9950 RVA: 0x001D5DF4 File Offset: 0x001D3FF4
		// (set) Token: 0x060026DF RID: 9951 RVA: 0x00009ADC File Offset: 0x00007CDC
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

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x060026E0 RID: 9952 RVA: 0x001D5E0C File Offset: 0x001D400C
		// (set) Token: 0x060026E1 RID: 9953 RVA: 0x00009AE6 File Offset: 0x00007CE6
		public int nahve_kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._nahve_kharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._nahve_kharid = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060026E2 RID: 9954 RVA: 0x001D5E24 File Offset: 0x001D4024
		// (set) Token: 0x060026E3 RID: 9955 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public bool is_Varedat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._is_Varedat;
			}
			[DebuggerNonUserCode]
			set
			{
				this._is_Varedat = value;
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x001D5E3C File Offset: 0x001D403C
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
					flag = (dataRow["fee"] != DBNull.Value);
					if (flag)
					{
						dataRow["fee"] = dataRow["fee"].ToString().Replace(",00", "").Replace(".0", "");
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

		// Token: 0x060026E5 RID: 9957 RVA: 0x001D6058 File Offset: 0x001D4258
		private void LoadData()
		{
			bool flag = this.dt_Kharid == null;
			if (flag)
			{
				this.dt_Kharid = this.Riz_Kharid.GetByID(checked((int)this.Kharid_ID));
			}
			this.RemoveZero(this.dt_Kharid);
			this.GridEX1.DataSource = this.dt_Kharid;
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x001D60B0 File Offset: 0x001D42B0
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

		// Token: 0x060026E7 RID: 9959 RVA: 0x001D6144 File Offset: 0x001D4344
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

		// Token: 0x060026E8 RID: 9960 RVA: 0x001D6254 File Offset: 0x001D4454
		private void Calc()
		{
			bool flag = this.GridEX1.GetRow().Cells["Tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Tedad"].Value != null;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				object expr_72 = this.GridEX1.GetRow().Cells["Tedad"].Value;
				num = ((expr_72 != null) ? ((decimal?)expr_72) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["Zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["Zarf"].Value != null);
			decimal? num3;
			if (flag)
			{
				object expr_F7 = this.GridEX1.GetRow().Cells["Zarf"].Value;
				num3 = ((expr_F7 != null) ? ((decimal?)expr_F7) : num2);
			}
			flag = (this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value != null);
			decimal? num4;
			if (flag)
			{
				object expr_17C = this.GridEX1.GetRow().Cells["vazn_ba_zarf"].Value;
				num4 = ((expr_17C != null) ? ((decimal?)expr_17C) : num2);
			}
			flag = (num.HasValue && num4.HasValue && num3.HasValue);
			bool flag4;
			if (flag)
			{
				decimal? arg_1F3_0;
				if (!(num3.HasValue & num.HasValue))
				{
					arg_1F3_0 = null;
				}
				else
				{
					decimal? num5 = new decimal?(decimal.Multiply(num3.GetValueOrDefault(), num.GetValueOrDefault()));
					arg_1F3_0 = num5;
				}
				decimal? num6 = arg_1F3_0;
				bool? arg_235_0;
				if (!(num6.HasValue & num4.HasValue))
				{
					arg_235_0 = null;
				}
				else
				{
					bool? flag2 = new bool?(decimal.Compare(num6.GetValueOrDefault(), num4.GetValueOrDefault()) >= 0);
					arg_235_0 = flag2;
				}
				bool? flag3 = arg_235_0;
				flag4 = flag3.GetValueOrDefault();
				if (flag4)
				{
					this.GridEX1.CurrentRow.Cells["Zarf"].Value = DBNull.Value;
					this.GridEX1.CurrentRow.Cells["vazn_kol"].Value = num4;
					this.GetSum("zarf", false);
				}
				else
				{
					GridEXCell arg_35F_0 = this.GridEX1.CurrentRow.Cells["vazn_kol"];
					bool arg_306_0 = num4.HasValue;
					decimal? arg_2FD_0;
					if (!(num.HasValue & num3.HasValue))
					{
						arg_2FD_0 = null;
					}
					else
					{
						decimal? num7 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
						arg_2FD_0 = num7;
					}
					decimal? num5 = arg_2FD_0;
					decimal? arg_332_0;
					if (!(arg_306_0 & num5.HasValue))
					{
						arg_332_0 = null;
					}
					else
					{
						num6 = new decimal?(decimal.Subtract(num4.GetValueOrDefault(), num5.GetValueOrDefault()));
						arg_332_0 = num6;
					}
					decimal? num8 = arg_332_0;
					arg_35F_0.Value = num8.ToString().Replace(",00", "").Replace(".0", "");
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

		// Token: 0x060026E9 RID: 9961 RVA: 0x001D6630 File Offset: 0x001D4830
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

		// Token: 0x060026EA RID: 9962 RVA: 0x001D673C File Offset: 0x001D493C
		private void CalcMablagh(bool calc_jam_kol)
		{
			bool flag = this.GridEX1.RootTable.Columns["vazn_kol"].Visible;
			bool flag2;
			decimal? num2;
			decimal? num;
			if (flag)
			{
				flag2 = (this.GridEX1.GetRow().Cells["vazn_kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["vazn_kol"].Value != null);
				if (flag2)
				{
					object expr_9A = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
					num = ((expr_9A != null) ? ((decimal?)expr_9A) : num2);
				}
			}
			else
			{
				flag2 = (this.GridEX1.GetRow().Cells["tedad"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["tedad"].Value != null);
				if (flag2)
				{
					object expr_126 = this.GridEX1.GetRow().Cells["tedad"].Value;
					num = ((expr_126 != null) ? ((decimal?)expr_126) : num2);
				}
			}
			flag2 = (this.GridEX1.GetRow().Cells["fee"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["fee"].Value != null);
			decimal? num3;
			if (flag2)
			{
				object expr_1AD = this.GridEX1.GetRow().Cells["fee"].Value;
				num3 = ((expr_1AD != null) ? ((decimal?)expr_1AD) : num2);
			}
			flag2 = (this.GridEX1.GetRow().Cells["jam_Kol"].Value != DBNull.Value && this.GridEX1.GetRow().Cells["jam_Kol"].Value != null);
			if (flag2)
			{
				object expr_233 = this.GridEX1.GetRow().Cells["jam_Kol"].Value;
				decimal? arg_246_0 = (expr_233 != null) ? ((decimal?)expr_233) : num2;
			}
			if (calc_jam_kol)
			{
				flag = (num.HasValue && num3.HasValue);
				if (flag)
				{
					bool flag3 = this.GridEX1.CurrentRow.Cells["jam_kol"].Value == DBNull.Value;
					if (flag3)
					{
						GridEXCell arg_2F7_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
						decimal? arg_2F2_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_2F2_0 = null;
						}
						else
						{
							decimal? num4 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_2F2_0 = num4;
						}
						arg_2F7_0.Value = arg_2F2_0;
					}
					else
					{
						decimal? arg_33D_0;
						if (!(num.HasValue & num3.HasValue))
						{
							arg_33D_0 = null;
						}
						else
						{
							decimal? num4 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
							arg_33D_0 = num4;
						}
						decimal value = Conversions.ToDecimal(Operators.SubtractObject(arg_33D_0, this.GridEX1.CurrentRow.Cells["jam_kol"].Value));
						flag3 = (decimal.Compare(Math.Abs(value), new decimal(1000L)) > 0);
						if (flag3)
						{
							GridEXCell arg_3E5_0 = this.GridEX1.CurrentRow.Cells["jam_kol"];
							decimal? arg_3E0_0;
							if (!(num.HasValue & num3.HasValue))
							{
								arg_3E0_0 = null;
							}
							else
							{
								decimal? num4 = new decimal?(decimal.Multiply(num.GetValueOrDefault(), num3.GetValueOrDefault()));
								arg_3E0_0 = num4;
							}
							arg_3E5_0.Value = arg_3E0_0;
						}
					}
				}
			}
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x001D6B3C File Offset: 0x001D4D3C
		private void Kala_select()
		{
			string empty = string.Empty;
			bool flag = this.GridEX1.CurrentRow.Cells["moshtari_id"].Value == DBNull.Value;
			checked
			{
				if (!flag)
				{
					flag = (this.GridEX1.CurrentRow.Cells["moshtari_id"].Value == null);
					if (!flag)
					{
						string command = Conversions.ToString(Operators.ConcatenateObject("SELECT     Kala.ID, Kala.Name  FROM         Moshtari_Kala INNER JOIN  Kala ON Moshtari_Kala.Kala_ID = Kala.ID  where Moshtari_ID = ", this.GridEX1.CurrentRow.Cells["moshtari_id"].Value));
						this.frm.ExtraData = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["moshtari_id"].Value);
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
				}
			}
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x001D6CF0 File Offset: 0x001D4EF0
		private void GridEX1_AddingRecord(object sender, CancelEventArgs e)
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["kharid_sardkhane_factor"]);
			checked
			{
				if (flag)
				{
					GridEXRow row = this.GridEX1.GetRow(-1);
					flag = (row.Cells["sh_factor"].Value != DBNull.Value);
					if (flag)
					{
						bool flag2 = row.Cells["moshtari_id"].Value != DBNull.Value;
						if (flag2)
						{
							bool flag3 = row.Cells["kala_id"].Value != DBNull.Value;
							if (flag3)
							{
								bool flag4 = row.Cells["vazn_kol"].Value != DBNull.Value;
								if (flag4)
								{
									GridEXRow[] rows = this.GridEX1.GetRows();
									for (int i = 0; i < rows.Length; i++)
									{
										GridEXRow gridEXRow = rows[i];
										bool flag5 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["tarikh_fa"].Value, row.Cells["tarikh_fa"].Value, false);
										if (flag5)
										{
											bool flag6 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["sh_factor"].Value, row.Cells["sh_factor"].Value, false);
											if (flag6)
											{
												bool flag7 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["moshtari_id"].Value, row.Cells["moshtari_id"].Value, false);
												if (flag7)
												{
													bool flag8 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["kala_id"].Value, row.Cells["kala_id"].Value, false);
													if (flag8)
													{
														bool flag9 = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["vazn_kol"].Value, row.Cells["vazn_kol"].Value, false);
														if (flag9)
														{
															Public_Function.ShowMessage("شماره فاکتور تکراری میباشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
															row.CancelEdit();
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
				}
			}
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x001D6F2C File Offset: 0x001D512C
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

		// Token: 0x060026EE RID: 9966 RVA: 0x001D70A8 File Offset: 0x001D52A8
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				this.GetTotalZarf();
			}
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x001D70D4 File Offset: 0x001D52D4
		private void Feechanged()
		{
			bool flag = this.GridEX1.CurrentRow.Cells["kala_id"].Value == DBNull.Value;
			checked
			{
				if (!flag)
				{
					long num = Conversions.ToLong(this.GridEX1.CurrentRow.Cells["kala_id"].Value);
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
											object expr_1A1 = this.GridEX1.GetRow().Cells["vazn_kol"].Value;
											decimal? num2;
											decimal? arg_1B4_0 = (expr_1A1 != null) ? ((decimal?)expr_1A1) : num2;
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

		// Token: 0x060026F0 RID: 9968 RVA: 0x001D73A0 File Offset: 0x001D55A0
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

		// Token: 0x060026F1 RID: 9969 RVA: 0x001D74C8 File Offset: 0x001D56C8
		private void GridEX1_RecordAdded(object sender, EventArgs e)
		{
			GridEXRow[] rows = this.GridEX1.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					bool flag = gridEXRow.Cells["Kala_ID"].Value == DBNull.Value && gridEXRow.Cells["moshtari_id"].Value == DBNull.Value;
					if (flag)
					{
						gridEXRow.Delete();
						break;
					}
				}
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x001D7548 File Offset: 0x001D5748
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

		// Token: 0x060026F3 RID: 9971 RVA: 0x001D780C File Offset: 0x001D5A0C
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

		// Token: 0x060026F4 RID: 9972 RVA: 0x00142128 File Offset: 0x00140328
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
				}
			}
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x001D78B8 File Offset: 0x001D5AB8
		private void GridEX1_InitCustomEdit(object sender, InitCustomEditEventArgs e)
		{
			string left = e.Column.Key.ToLower();
			bool flag = Operators.CompareString(left, "tarikh_fa", false) == 0;
			if (flag)
			{
				e.EditControl = this.txt_tarikhGrid;
				flag = (e.Value != null);
				if (flag)
				{
					this.txt_tarikhGrid.SetDate(e.Value.ToString());
				}
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
				}
			}
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x001D79B8 File Offset: 0x001D5BB8
		private void Moshtari_Select()
		{
			this.frm.CanEdit = true;
			this.frm.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.frm.CanDelete = false;
			string str = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				str = ",-3";
			}
			flag = (this.frm.ShowDialog("SELECT     Moshtari.ID,Moshtari.Code,Moshtari.CodeHesab_id, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID WHERE moshtari.id not in(-1,-2,-4,-5,-6" + str + ") order by moshtari.code", MyProject.Forms.Frm_Moshtari, 0) == DialogResult.OK);
			checked
			{
				if (flag)
				{
					bool flag2 = this.GridEX1.Col == this.GridEX1.RootTable.Columns["moshtari_Name"].Position && this.GridEX1.EditTextBox != null;
					if (flag2)
					{
						this.GridEX1.EditTextBox.Text = Conversions.ToString(this.frm.SelectedRow["Name"]);
						this.GridEX1.GetRow().Cells["Moshtari_Id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["ID"]);
						this.GridEX1.GetRow().Cells["CodeHesab_id"].Value = RuntimeHelpers.GetObjectValue(this.frm.SelectedRow["CodeHesab_id"]);
						DataEntryGrid gridEX = this.GridEX1;
						gridEX.Col++;
					}
				}
			}
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x001D7B4C File Offset: 0x001D5D4C
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
						flag = (col == this.GridEX1.RootTable.Columns["Moshtari_Name"].Position);
						if (flag)
						{
							bool flag3 = this.GridEX1.EditTextBox == null;
							if (flag3)
							{
								this.GridEX1.GetRow().BeginEdit();
								this.GridEX1.EditMode = EditMode.EditOn;
							}
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
								if (flag3)
								{
									flag2 = this.is_Varedat;
									if (flag2)
									{
										DataEntryGrid gridEX = this.GridEX1;
										gridEX.Col++;
									}
								}
								else
								{
									flag3 = (col == this.GridEX1.RootTable.Columns["jam_kol"].Position);
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
											flag3 = (this.GridEX1.CurrentRow.RowType == RowType.Record);
											if (flag3)
											{
												flag2 = (this.GridEX1.Row + 1 <= this.GridEX1.RowCount - 1);
												if (flag2)
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
											e.SuppressKeyPress = true;
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

		// Token: 0x060026F8 RID: 9976 RVA: 0x001D81A4 File Offset: 0x001D63A4
		private void txt_fee_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			checked
			{
				if (flag)
				{
					this.prevent = true;
					e.SuppressKeyPress = true;
					DataEntryGrid gridEX = this.GridEX1;
					gridEX.Col++;
				}
			}
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x001D81E8 File Offset: 0x001D63E8
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
					flag3 = (this.GridEX1.CurrentRow.RowType == RowType.NewRecord);
					if (flag3)
					{
						this.GridEX1.UpdateData();
						this.GridEX1.MoveToNewRecord();
						this.GridEX1.Col = 0;
						this.GridEX1.EditMode = EditMode.EditOn;
						this.prevent = true;
					}
				}
			}
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x001D82E0 File Offset: 0x001D64E0
		private bool ValidateGridData()
		{
			this.GridEX1.UpdateData();
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			int num = 0;
			checked
			{
				bool result;
				bool flag2;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = dataRow["Kala_ID"] == DBNull.Value;
						if (flag)
						{
							Public_Function.GridRaiseSoftError(this.GridEX1, this.GridEX1.GetRows()[num], "kala_Name", "جنس را انتخاب نمایید");
							result = false;
							return result;
						}
						flag = (dataRow["vazn_kol"] == DBNull.Value);
						if (flag)
						{
							flag2 = (dataRow["vazn_Ba_Zarf"] == DBNull.Value);
							if (flag2)
							{
								dataRow["vazn_Kol"] = 0;
							}
						}
						flag2 = (dataRow["fee"] == DBNull.Value);
						if (flag2)
						{
							dataRow["fee"] = 0;
						}
						flag2 = (dataRow["jam_kol"] == DBNull.Value);
						if (flag2)
						{
							dataRow["jam_Kol"] = 0;
						}
						flag2 = (dataRow["Tedad"] == DBNull.Value && dataRow["Vazn_Ba_Zarf"] == DBNull.Value);
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
					IEnumerator enumerator;
					flag2 = (enumerator is IDisposable);
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
						flag2 = (dataRow2["tedad"] == DBNull.Value);
						if (flag2)
						{
							dataRow2["tedad"] = 0;
						}
						flag2 = (dataRow2["vazn_ba_zarf"] == DBNull.Value);
						if (flag2)
						{
							dataRow2["vazn_ba_zarf"] = 0;
						}
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
							DataRow dataRow3 = array2[i];
							bool flag = dataRow3["tedad"] == DBNull.Value && dataRow3["vazn_kol"] == DBNull.Value;
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
				return result;
			}
		}

		// Token: 0x060026FB RID: 9979 RVA: 0x001D8684 File Offset: 0x001D6884
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

		// Token: 0x060026FC RID: 9980 RVA: 0x001D8724 File Offset: 0x001D6924
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
				}
				else
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x060026FD RID: 9981 RVA: 0x001D8768 File Offset: 0x001D6968
		private void Frm_RizKharid_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.GridEX1.MoveToNewRecord();
				this.Close();
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x001D879C File Offset: 0x001D699C
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
						this.frm.GridEX1.CurrentRow.Delete();
					}
					catch (Exception expr_51)
					{
						ProjectData.SetProjectError(expr_51);
						Public_Function.ShowMessage("امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00009AFA File Offset: 0x00007CFA
		private void txt_tarikhGrid_OnRight()
		{
			this.prevent_left = true;
		}

		// Token: 0x06002700 RID: 9984 RVA: 0x001D882C File Offset: 0x001D6A2C
		private void Load_nahve_Kharid()
		{
			switch (this.nahve_kharid)
			{
			case 1:
				this.GridEX1.RootTable.Columns["zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["tedad"].Visible = true;
				this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
				break;
			case 2:
				this.GridEX1.RootTable.Columns["tedad"].Visible = false;
				this.GridEX1.RootTable.Columns["zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
				break;
			case 3:
				this.GridEX1.RootTable.Columns["tedad"].Visible = true;
				this.GridEX1.RootTable.Columns["zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = false;
				this.GridEX1.RootTable.Columns["vazn_kol"].Visible = false;
				break;
			case 4:
				this.GridEX1.RootTable.Columns["tedad"].Visible = true;
				this.GridEX1.RootTable.Columns["zarf"].Visible = true;
				this.GridEX1.RootTable.Columns["vazn_ba_zarf"].Visible = true;
				this.GridEX1.RootTable.Columns["vazn_kol"].Visible = true;
				break;
			}
		}

		// Token: 0x06002701 RID: 9985 RVA: 0x001D8A84 File Offset: 0x001D6C84
		private void Frm_RizKharid_Load(object sender, EventArgs e)
		{
			bool flag = this.is_Varedat;
			if (flag)
			{
				this.GridEX1.RootTable.Columns["fee"].EditType = EditType.TextBox;
				this.GridEX1.RootTable.Columns["fee"].FormatString = "";
			}
			this.txt_tarikhGrid.SetNew();
			ItemCollection itemCollection = new ItemCollection();
			itemCollection.Add(new Column("Name", "عنوان", 100));
			this.frm.items = itemCollection;
			this.Load_nahve_Kharid();
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
		}

		// Token: 0x06002702 RID: 9986 RVA: 0x001D8BE4 File Offset: 0x001D6DE4
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

		// Token: 0x06002703 RID: 9987 RVA: 0x001D8D9C File Offset: 0x001D6F9C
		private void GridEX1_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool flag = this.GridEX1.Col == this.GridEX1.RootTable.Columns["kala_name"].Position;
			if (flag)
			{
				e.Handled = true;
			}
			else
			{
				flag = (this.GridEX1.Col == this.GridEX1.RootTable.Columns["fee"].Position);
				if (flag)
				{
					bool flag2 = !char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0 && Strings.Asc(e.KeyChar) != 8;
					if (flag2)
					{
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x04000F2A RID: 3882
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F2C RID: 3884
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F2D RID: 3885
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F2E RID: 3886
		[AccessedThroughProperty("txt_fee")]
		private CurrencyBox _txt_fee;

		// Token: 0x04000F2F RID: 3887
		[AccessedThroughProperty("txt_jam_kol")]
		private CurrencyBox _txt_jam_kol;

		// Token: 0x04000F30 RID: 3888
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000F31 RID: 3889
		private Frm_SelectItem frm;

		// Token: 0x04000F32 RID: 3890
		private Kharid_Sardkhane_detail Riz_Kharid;

		// Token: 0x04000F33 RID: 3891
		[CompilerGenerated]
		private DataTable _Furush_Table;

		// Token: 0x04000F34 RID: 3892
		[CompilerGenerated]
		private DataTable _dt_Kharid;

		// Token: 0x04000F35 RID: 3893
		[CompilerGenerated]
		private long _Kharid_ID;

		// Token: 0x04000F36 RID: 3894
		[CompilerGenerated]
		private decimal _Sum_Vazn;

		// Token: 0x04000F37 RID: 3895
		[CompilerGenerated]
		private bool _Preview;

		// Token: 0x04000F38 RID: 3896
		[CompilerGenerated]
		private DataTable _dt_kala_to_kala;

		// Token: 0x04000F39 RID: 3897
		[CompilerGenerated]
		private int _nahve_kharid;

		// Token: 0x04000F3A RID: 3898
		[CompilerGenerated]
		private bool _is_Varedat;

		// Token: 0x04000F3B RID: 3899
		private bool prevent;

		// Token: 0x04000F3C RID: 3900
		private bool prevent_left;
	}
}
