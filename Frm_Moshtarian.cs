using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000FF RID: 255
	[DesignerGenerated]
	public partial class Frm_Moshtarian : Form
	{
		// Token: 0x06002103 RID: 8451 RVA: 0x0018A194 File Offset: 0x00188394
		public Frm_Moshtarian()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_DaryaftCheck_KeyDown);
			base.Load += new EventHandler(this.Frm_DaryaftCheck_Load);
			Frm_Moshtarian.__ENCAddToList(this);
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

		// Token: 0x06002104 RID: 8452 RVA: 0x0018A230 File Offset: 0x00188430
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Moshtarian.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Moshtarian.__ENCList.Count == Frm_Moshtarian.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Moshtarian.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Moshtarian.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Moshtarian.__ENCList[num] = Frm_Moshtarian.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Moshtarian.__ENCList.RemoveRange(num, Frm_Moshtarian.__ENCList.Count - num);
						Frm_Moshtarian.__ENCList.Capacity = Frm_Moshtarian.__ENCList.Count;
					}
					Frm_Moshtarian.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002107 RID: 8455 RVA: 0x0018AB70 File Offset: 0x00188D70
		// (set) Token: 0x06002108 RID: 8456 RVA: 0x0018AB88 File Offset: 0x00188D88
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
				KeyPressEventHandler value3 = new KeyPressEventHandler(this.GridEX1_KeyPress);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.KeyPress -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.KeyPress += value3;
				}
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002109 RID: 8457 RVA: 0x0018AC10 File Offset: 0x00188E10
		// (set) Token: 0x0600210A RID: 8458 RVA: 0x0018AC28 File Offset: 0x00188E28
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

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x0600210B RID: 8459 RVA: 0x0018AC88 File Offset: 0x00188E88
		// (set) Token: 0x0600210C RID: 8460 RVA: 0x00008966 File Offset: 0x00006B66
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

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x0600210D RID: 8461 RVA: 0x0018ACA0 File Offset: 0x00188EA0
		// (set) Token: 0x0600210E RID: 8462 RVA: 0x00008970 File Offset: 0x00006B70
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x0600210F RID: 8463 RVA: 0x0018ACB8 File Offset: 0x00188EB8
		// (set) Token: 0x06002110 RID: 8464 RVA: 0x0000897A File Offset: 0x00006B7A
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

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002111 RID: 8465 RVA: 0x0018ACD0 File Offset: 0x00188ED0
		// (set) Token: 0x06002112 RID: 8466 RVA: 0x00008984 File Offset: 0x00006B84
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

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002113 RID: 8467 RVA: 0x0018ACE8 File Offset: 0x00188EE8
		// (set) Token: 0x06002114 RID: 8468 RVA: 0x0000898E File Offset: 0x00006B8E
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

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002115 RID: 8469 RVA: 0x0018AD00 File Offset: 0x00188F00
		// (set) Token: 0x06002116 RID: 8470 RVA: 0x00008998 File Offset: 0x00006B98
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

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002117 RID: 8471 RVA: 0x0018AD18 File Offset: 0x00188F18
		// (set) Token: 0x06002118 RID: 8472 RVA: 0x000089A2 File Offset: 0x00006BA2
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

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002119 RID: 8473 RVA: 0x0018AD30 File Offset: 0x00188F30
		// (set) Token: 0x0600211A RID: 8474 RVA: 0x0018AD48 File Offset: 0x00188F48
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

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600211B RID: 8475 RVA: 0x0018ADA8 File Offset: 0x00188FA8
		// (set) Token: 0x0600211C RID: 8476 RVA: 0x000089AC File Offset: 0x00006BAC
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
				this._Timer1 = value;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x0018ADC0 File Offset: 0x00188FC0
		// (set) Token: 0x0600211E RID: 8478 RVA: 0x000089B6 File Offset: 0x00006BB6
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

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x0018ADD8 File Offset: 0x00188FD8
		// (set) Token: 0x06002120 RID: 8480 RVA: 0x000089C0 File Offset: 0x00006BC0
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

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002121 RID: 8481 RVA: 0x0018ADF0 File Offset: 0x00188FF0
		// (set) Token: 0x06002122 RID: 8482 RVA: 0x000089CA File Offset: 0x00006BCA
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

		// Token: 0x06002123 RID: 8483 RVA: 0x0018AE08 File Offset: 0x00189008
		private bool ValidateGrid()
		{
			bool result;
			return result;
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x0018AE18 File Offset: 0x00189018
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

		// Token: 0x06002125 RID: 8485 RVA: 0x000089D4 File Offset: 0x00006BD4
		private void GetData()
		{
			this.dt = Public_Function.FillData("SELECT     ID, Name, Family, AvalDoreType, AvalDore, Sanad_ID, AvalDore_Tarikh   FROM         Moshtari where id>0");
			this.GridEX1.DataSource = this.dt;
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000089FB File Offset: 0x00006BFB
		private void Frm_DaryaftCheck_Load(object sender, EventArgs e)
		{
			this.GetData();
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0018AE74 File Offset: 0x00189074
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
							flag = (col == this.GridEX1.RootTable.Columns["Name"].Position);
							if (flag)
							{
								bool flag3 = this.GridEX1.EditTextBox == null;
								if (flag3)
								{
									this.GridEX1.GetRow().BeginEdit();
								}
								flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
								if (!flag3)
								{
									GridEX gridEX = this.GridEX1;
									gridEX.Col++;
								}
							}
							else
							{
								bool flag3 = col == this.GridEX1.RootTable.Columns["family"].Position;
								if (flag3)
								{
									flag2 = (this.GridEX1.EditTextBox == null);
									if (flag2)
									{
										this.GridEX1.GetRow().BeginEdit();
									}
									flag3 = (Operators.CompareString(this.GridEX1.EditTextBox.Text, string.Empty, false) == 0);
									if (!flag3)
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

		// Token: 0x06002128 RID: 8488 RVA: 0x0018B3E0 File Offset: 0x001895E0
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

		// Token: 0x06002129 RID: 8489 RVA: 0x0018B440 File Offset: 0x00189640
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

		// Token: 0x0600212A RID: 8490 RVA: 0x0018B5AC File Offset: 0x001897AC
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

		// Token: 0x0600212B RID: 8491 RVA: 0x0018B5E8 File Offset: 0x001897E8
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = !this.ValidateGrid();
			if (flag)
			{
			}
		}

		// Token: 0x04000CCF RID: 3279
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000CD1 RID: 3281
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000CD2 RID: 3282
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000CD3 RID: 3283
		[AccessedThroughProperty("MetroStatusBar1")]
		private MetroStatusBar _MetroStatusBar1;

		// Token: 0x04000CD4 RID: 3284
		[AccessedThroughProperty("LabelItem1")]
		private LabelItem _LabelItem1;

		// Token: 0x04000CD5 RID: 3285
		[AccessedThroughProperty("lbl_kol")]
		private LabelItem _lbl_kol;

		// Token: 0x04000CD6 RID: 3286
		[AccessedThroughProperty("LabelItem2")]
		private LabelItem _LabelItem2;

		// Token: 0x04000CD7 RID: 3287
		[AccessedThroughProperty("lbl_jamCheck")]
		private LabelItem _lbl_jamCheck;

		// Token: 0x04000CD8 RID: 3288
		[AccessedThroughProperty("txt_tarikhGrid")]
		private DateBox2 _txt_tarikhGrid;

		// Token: 0x04000CD9 RID: 3289
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000CDA RID: 3290
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000CDB RID: 3291
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04000CDC RID: 3292
		private Frm_SelectItem frm;

		// Token: 0x04000CDD RID: 3293
		private Frm_SelectItemSql frmsql;

		// Token: 0x04000CDE RID: 3294
		[CompilerGenerated]
		private long _sum_mablagh;

		// Token: 0x04000CDF RID: 3295
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000CE0 RID: 3296
		[CompilerGenerated]
		private bool _DelFlag;

		// Token: 0x04000CE1 RID: 3297
		private List<KeyValuePair<int, int>> check_id;

		// Token: 0x04000CE2 RID: 3298
		private bool prevent;

		// Token: 0x04000CE3 RID: 3299
		private bool prevent_right;

		// Token: 0x04000CE4 RID: 3300
		private bool prevent_left;

		// Token: 0x04000CE5 RID: 3301
		private ShomareHesab shomarehesab;
	}
}
