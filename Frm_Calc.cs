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
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000061 RID: 97
	[DesignerGenerated]
	public partial class Frm_Calc : Form
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x00067154 File Offset: 0x00065354
		public Frm_Calc()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Calc_KeyDown);
			base.Load += new EventHandler(this.Frm_Calc_Load);
			Frm_Calc.__ENCAddToList(this);
			this.dt1 = new DataTable();
			this.dt2 = new DataTable();
			this.dt3 = new DataTable();
			this.focusindex = 0;
			this.InitializeComponent();
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000671C8 File Offset: 0x000653C8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Calc.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Calc.__ENCList.Count == Frm_Calc.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Calc.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Calc.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Calc.__ENCList[num] = Frm_Calc.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Calc.__ENCList.RemoveRange(num, Frm_Calc.__ENCList.Count - num);
						Frm_Calc.__ENCList.Capacity = Frm_Calc.__ENCList.Count;
					}
					Frm_Calc.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00068134 File Offset: 0x00066334
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0006814C File Offset: 0x0006634C
		internal virtual CurrencyBox CurrencyBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.CurrencyBox1_KeyDown);
				bool flag = this._CurrencyBox1 != null;
				if (flag)
				{
					this._CurrencyBox1.KeyDown -= value2;
				}
				this._CurrencyBox1 = value;
				flag = (this._CurrencyBox1 != null);
				if (flag)
				{
					this._CurrencyBox1.KeyDown += value2;
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000681AC File Offset: 0x000663AC
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x000681C4 File Offset: 0x000663C4
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
				EventHandler value4 = new EventHandler(this.GridEX1_LostFocus);
				EventHandler value5 = new EventHandler(this.GridEX1_GotFocus);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.KeyDown -= value2;
					this._GridEX1.CellEdited -= value3;
					this._GridEX1.LostFocus -= value4;
					this._GridEX1.GotFocus -= value5;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.KeyDown += value2;
					this._GridEX1.CellEdited += value3;
					this._GridEX1.LostFocus += value4;
					this._GridEX1.GotFocus += value5;
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000682A0 File Offset: 0x000664A0
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00002F8B File Offset: 0x0000118B
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

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000682B8 File Offset: 0x000664B8
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00002F95 File Offset: 0x00001195
		internal virtual CurrencyBox CurrencyBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CurrencyBox4 = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000682D0 File Offset: 0x000664D0
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000682E8 File Offset: 0x000664E8
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00068348 File Offset: 0x00066548
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00068360 File Offset: 0x00066560
		internal virtual GridEX GridEX3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				ColumnActionEventHandler value2 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EventHandler value3 = new EventHandler(this.GridEX3_LostFocus);
				KeyEventHandler value4 = new KeyEventHandler(this.GridEX3_KeyDown);
				EventHandler value5 = new EventHandler(this.GridEX3_GotFocus);
				bool flag = this._GridEX3 != null;
				if (flag)
				{
					this._GridEX3.CellEdited -= value2;
					this._GridEX3.LostFocus -= value3;
					this._GridEX3.KeyDown -= value4;
					this._GridEX3.GotFocus -= value5;
				}
				this._GridEX3 = value;
				flag = (this._GridEX3 != null);
				if (flag)
				{
					this._GridEX3.CellEdited += value2;
					this._GridEX3.LostFocus += value3;
					this._GridEX3.KeyDown += value4;
					this._GridEX3.GotFocus += value5;
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0006843C File Offset: 0x0006663C
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00068454 File Offset: 0x00066654
		internal virtual GridEX GridEX2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.GridEX2_GotFocus);
				ColumnActionEventHandler value3 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				EventHandler value4 = new EventHandler(this.GridEX2_LostFocus);
				KeyEventHandler value5 = new KeyEventHandler(this.GridEX2_KeyDown);
				bool flag = this._GridEX2 != null;
				if (flag)
				{
					this._GridEX2.GotFocus -= value2;
					this._GridEX2.CellEdited -= value3;
					this._GridEX2.LostFocus -= value4;
					this._GridEX2.KeyDown -= value5;
				}
				this._GridEX2 = value;
				flag = (this._GridEX2 != null);
				if (flag)
				{
					this._GridEX2.GotFocus += value2;
					this._GridEX2.CellEdited += value3;
					this._GridEX2.LostFocus += value4;
					this._GridEX2.KeyDown += value5;
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x00068530 File Offset: 0x00066730
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00068548 File Offset: 0x00066748
		internal virtual NumericBox CurrencyBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.CurrencyBox2_KeyDown);
				bool flag = this._CurrencyBox2 != null;
				if (flag)
				{
					this._CurrencyBox2.KeyDown -= value2;
				}
				this._CurrencyBox2 = value;
				flag = (this._CurrencyBox2 != null);
				if (flag)
				{
					this._CurrencyBox2.KeyDown += value2;
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000685A8 File Offset: 0x000667A8
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00002F9F File Offset: 0x0000119F
		internal virtual NumericBox CurrencyBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CurrencyBox5 = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000685C0 File Offset: 0x000667C0
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00002FA9 File Offset: 0x000011A9
		internal virtual NumericBox CurrencyBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CurrencyBox6 = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x000685D8 File Offset: 0x000667D8
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000685F0 File Offset: 0x000667F0
		internal virtual NumericBox CurrencyBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrencyBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.CurrencyBox3_KeyDown);
				bool flag = this._CurrencyBox3 != null;
				if (flag)
				{
					this._CurrencyBox3.KeyDown -= value2;
				}
				this._CurrencyBox3 = value;
				flag = (this._CurrencyBox3 != null);
				if (flag)
				{
					this._CurrencyBox3.KeyDown += value2;
				}
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00068650 File Offset: 0x00066850
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00002FB3 File Offset: 0x000011B3
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

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00068668 File Offset: 0x00066868
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00068680 File Offset: 0x00066880
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.Click -= value2;
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.Click += value2;
				}
			}
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x000686E0 File Offset: 0x000668E0
		private void Calc()
		{
			this.GridEX1.UpdateData();
			this.GridEX2.UpdateData();
			this.GridEX3.UpdateData();
			bool flag = this.dt1.Rows.Count > 0;
			if (flag)
			{
				long num = 0L;
				try
				{
					IEnumerator enumerator = this.dt1.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						object left = dataRow["op"];
						flag = Operators.ConditionalCompareObjectEqual(left, "+", false);
						if (flag)
						{
							num = Conversions.ToLong(Operators.AddObject(num, dataRow["value"]));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, "-", false);
							if (flag)
							{
								num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["value"]));
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, "*", false);
								if (flag)
								{
									num = Conversions.ToLong(Operators.MultiplyObject(num, dataRow["value"]));
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left, "/", false);
									if (flag)
									{
										num = Conversions.ToLong(Operators.DivideObject(num, dataRow["value"]));
									}
								}
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
				this.CurrencyBox4.Text = Conversions.ToString(num);
			}
			else
			{
				this.CurrencyBox4.SetNew();
			}
			flag = (this.dt2.Rows.Count > 0);
			if (flag)
			{
				decimal num2 = 0m;
				try
				{
					IEnumerator enumerator2 = this.dt2.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						object left2 = dataRow2["op"];
						flag = Operators.ConditionalCompareObjectEqual(left2, "+", false);
						if (flag)
						{
							num2 = Conversions.ToDecimal(Operators.AddObject(num2, dataRow2["value"]));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left2, "-", false);
							if (flag)
							{
								num2 = Conversions.ToDecimal(Operators.SubtractObject(num2, dataRow2["value"]));
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left2, "*", false);
								if (flag)
								{
									num2 = Conversions.ToDecimal(Operators.MultiplyObject(num2, dataRow2["value"]));
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left2, "/", false);
									if (flag)
									{
										num2 = Conversions.ToDecimal(Operators.DivideObject(num2, dataRow2["value"]));
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag = (enumerator2 is IDisposable);
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				this.CurrencyBox5.Text = Conversions.ToString(num2);
			}
			else
			{
				this.CurrencyBox5.SetNew();
			}
			flag = (this.dt3.Rows.Count > 0);
			if (flag)
			{
				decimal num3 = 0m;
				try
				{
					IEnumerator enumerator3 = this.dt3.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						object left3 = dataRow3["op"];
						flag = Operators.ConditionalCompareObjectEqual(left3, "+", false);
						if (flag)
						{
							num3 = Conversions.ToDecimal(Operators.AddObject(num3, dataRow3["value"]));
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left3, "-", false);
							if (flag)
							{
								num3 = Conversions.ToDecimal(Operators.SubtractObject(num3, dataRow3["value"]));
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left3, "*", false);
								if (flag)
								{
									num3 = Conversions.ToDecimal(Operators.MultiplyObject(num3, dataRow3["value"]));
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left3, "/", false);
									if (flag)
									{
										num3 = Conversions.ToDecimal(Operators.DivideObject(num3, dataRow3["value"]));
									}
								}
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					flag = (enumerator3 is IDisposable);
					if (flag)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				this.CurrencyBox6.Text = Conversions.ToString(num3);
			}
			else
			{
				this.CurrencyBox6.SetNew();
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00068BD4 File Offset: 0x00066DD4
		private void Frm_Calc_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F5);
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00068C14 File Offset: 0x00066E14
		private void Frm_Calc_Load(object sender, EventArgs e)
		{
			this.dt1.Columns.Add("value", typeof(long));
			this.dt1.Columns.Add("op", typeof(string));
			this.dt2.Columns.Add("value", typeof(decimal));
			this.dt2.Columns.Add("op", typeof(string));
			this.dt3.Columns.Add("value", typeof(decimal));
			this.dt3.Columns.Add("op", typeof(string));
			this.GridEX1.DataSource = this.dt1;
			this.GridEX2.DataSource = this.dt2;
			this.GridEX3.DataSource = this.dt3;
			this.CurrencyBox4.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00068D28 File Offset: 0x00066F28
		private void CurrencyBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Right;
			if (flag)
			{
				this.CurrencyBox2.Focus();
			}
			flag = (e.KeyCode == Keys.Down);
			bool flag2;
			if (flag)
			{
				flag2 = (this.GridEX1.RowCount > 0);
				if (!flag2)
				{
					e.SuppressKeyPress = false;
					return;
				}
				this.GridEX1.Focus();
				this.GridEX1.Row = 0;
				this.GridEX1.Col = 0;
				this.GridEX1.EditMode = EditMode.EditOn;
			}
			flag2 = !this.CurrencyBox1.Value.HasValue;
			if (!flag2)
			{
				Keys keyCode = e.KeyCode;
				flag2 = (keyCode == Keys.Return);
				if (flag2)
				{
					this.dt1.Rows.Add(new object[]
					{
						this.CurrencyBox1.Value,
						"+"
					});
					this.CurrencyBox1.SetNew();
					this.Calc();
				}
				else
				{
					flag2 = (keyCode == Keys.Subtract);
					if (flag2)
					{
						this.dt1.Rows.Add(new object[]
						{
							this.CurrencyBox1.Value,
							"-"
						});
						this.CurrencyBox1.SetNew();
						this.Calc();
					}
					else
					{
						flag2 = (keyCode == Keys.Multiply);
						if (flag2)
						{
							this.dt1.Rows.Add(new object[]
							{
								this.CurrencyBox1.Value,
								"*"
							});
							this.CurrencyBox1.SetNew();
							this.Calc();
						}
						else
						{
							flag2 = (keyCode == Keys.Divide);
							if (flag2)
							{
								this.dt1.Rows.Add(new object[]
								{
									this.CurrencyBox1.Value,
									"/"
								});
								this.CurrencyBox1.SetNew();
								this.Calc();
							}
						}
					}
				}
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00068F48 File Offset: 0x00067148
		private void CurrencyBox2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Left;
			if (flag)
			{
				this.CurrencyBox1.Focus();
			}
			flag = (e.KeyCode == Keys.Right);
			if (flag)
			{
				this.CurrencyBox3.Focus();
			}
			flag = (this.CurrencyBox2.Text == null);
			if (!flag)
			{
				flag = (e.KeyCode == Keys.Down);
				bool flag2;
				if (flag)
				{
					flag2 = (this.GridEX2.RowCount > 0);
					if (!flag2)
					{
						e.SuppressKeyPress = false;
						return;
					}
					this.GridEX2.Focus();
					this.GridEX2.Row = 0;
					this.GridEX2.Col = 0;
					this.GridEX2.EditMode = EditMode.EditOn;
				}
				flag2 = (Operators.CompareString(this.CurrencyBox2.Text, string.Empty, false) == 0);
				if (!flag2)
				{
					Keys keyCode = e.KeyCode;
					flag2 = (keyCode == Keys.Return);
					if (flag2)
					{
						this.dt2.Rows.Add(new object[]
						{
							this.CurrencyBox2.Text,
							"+"
						});
						this.CurrencyBox2.SetNew();
						this.Calc();
					}
					else
					{
						flag2 = (keyCode == Keys.Subtract);
						if (flag2)
						{
							this.dt2.Rows.Add(new object[]
							{
								this.CurrencyBox2.Text,
								"-"
							});
							this.CurrencyBox2.SetNew();
							this.Calc();
						}
						else
						{
							flag2 = (keyCode == Keys.Multiply);
							if (flag2)
							{
								this.dt2.Rows.Add(new object[]
								{
									this.CurrencyBox2.Text,
									"*"
								});
								this.CurrencyBox2.SetNew();
								this.Calc();
							}
							else
							{
								flag2 = (keyCode == Keys.Divide);
								if (flag2)
								{
									this.dt2.Rows.Add(new object[]
									{
										this.CurrencyBox2.Text,
										"/"
									});
									this.CurrencyBox2.SetNew();
									this.Calc();
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00069180 File Offset: 0x00067380
		private void CurrencyBox3_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Left;
			if (flag)
			{
				this.CurrencyBox2.Focus();
			}
			flag = (e.KeyCode == Keys.Down);
			bool flag2;
			if (flag)
			{
				flag2 = (this.GridEX3.RowCount > 0);
				if (!flag2)
				{
					e.SuppressKeyPress = false;
					return;
				}
				this.GridEX3.Focus();
				this.GridEX3.Row = 0;
				this.GridEX3.Col = 0;
				this.GridEX3.EditMode = EditMode.EditOn;
			}
			flag2 = (this.CurrencyBox3.Text == null);
			if (!flag2)
			{
				Keys keyCode = e.KeyCode;
				flag2 = (keyCode == Keys.Return);
				if (flag2)
				{
					this.dt3.Rows.Add(new object[]
					{
						this.CurrencyBox3.Text,
						"+"
					});
					this.CurrencyBox3.SetNew();
					this.Calc();
				}
				else
				{
					flag2 = (keyCode == Keys.Subtract);
					if (flag2)
					{
						this.dt3.Rows.Add(new object[]
						{
							this.CurrencyBox3.Text,
							"-"
						});
						this.CurrencyBox3.SetNew();
						this.Calc();
					}
					else
					{
						flag2 = (keyCode == Keys.Multiply);
						if (flag2)
						{
							this.dt3.Rows.Add(new object[]
							{
								this.CurrencyBox3.Text,
								"*"
							});
							this.CurrencyBox3.SetNew();
							this.Calc();
						}
						else
						{
							flag2 = (keyCode == Keys.Divide);
							if (flag2)
							{
								this.dt3.Rows.Add(new object[]
								{
									this.CurrencyBox3.Text,
									"/"
								});
								this.CurrencyBox3.SetNew();
								this.Calc();
							}
						}
					}
				}
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00069378 File Offset: 0x00067578
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.dt1.Rows.Clear();
			this.dt2.Rows.Clear();
			this.dt3.Rows.Clear();
			this.CurrencyBox4.SetNew();
			this.CurrencyBox1.SetNew();
			this.CurrencyBox2.SetNew();
			this.CurrencyBox3.SetNew();
			this.CurrencyBox5.SetNew();
			this.CurrencyBox6.SetNew();
			this.CurrencyBox1.Focus();
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002FBD File Offset: 0x000011BD
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			this.Calc();
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002FC8 File Offset: 0x000011C8
		private void GridEX1_GotFocus(object sender, EventArgs e)
		{
			this.focusindex = 1;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00069410 File Offset: 0x00067610
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up;
			if (flag)
			{
				bool flag2 = this.GridEX1.Row == 0;
				if (flag2)
				{
					this.CurrencyBox1.Focus();
				}
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002FD3 File Offset: 0x000011D3
		private void GridEX2_GotFocus(object sender, EventArgs e)
		{
			this.focusindex = 2;
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00069450 File Offset: 0x00067650
		private void GridEX2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up;
			if (flag)
			{
				bool flag2 = this.GridEX2.Row == 0;
				if (flag2)
				{
					this.CurrencyBox2.Focus();
				}
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002FDE File Offset: 0x000011DE
		private void GridEX3_GotFocus(object sender, EventArgs e)
		{
			this.focusindex = 3;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00069490 File Offset: 0x00067690
		private void GridEX3_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Up;
			if (flag)
			{
				bool flag2 = this.GridEX3.Row == 0;
				if (flag2)
				{
					this.CurrencyBox3.Focus();
				}
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000694D0 File Offset: 0x000676D0
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			switch (this.focusindex)
			{
			case 1:
			{
				bool flag = this.GridEX1.GetRow() != null;
				if (flag)
				{
					this.GridEX1.GetRow().Delete();
					this.Calc();
					flag = (this.GridEX1.RowCount == 0);
					if (flag)
					{
						this.CurrencyBox1.Focus();
					}
				}
				break;
			}
			case 2:
			{
				bool flag = this.GridEX2.GetRow() != null;
				if (flag)
				{
					this.GridEX2.GetRow().Delete();
					this.Calc();
					flag = (this.GridEX2.RowCount == 0);
					if (flag)
					{
						this.CurrencyBox2.Focus();
					}
				}
				break;
			}
			case 3:
			{
				bool flag = this.GridEX3.GetRow() != null;
				if (flag)
				{
					this.GridEX3.GetRow().Delete();
					this.Calc();
					flag = (this.GridEX3.RowCount == 0);
					if (flag)
					{
						this.CurrencyBox3.Focus();
					}
				}
				break;
			}
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00002FE9 File Offset: 0x000011E9
		private void GridEX3_LostFocus(object sender, EventArgs e)
		{
			this.focusindex = 0;
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00002FE9 File Offset: 0x000011E9
		private void GridEX2_LostFocus(object sender, EventArgs e)
		{
			this.focusindex = 0;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00002FE9 File Offset: 0x000011E9
		private void GridEX1_LostFocus(object sender, EventArgs e)
		{
			this.focusindex = 0;
		}

		// Token: 0x04000284 RID: 644
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000286 RID: 646
		[AccessedThroughProperty("CurrencyBox1")]
		private CurrencyBox _CurrencyBox1;

		// Token: 0x04000287 RID: 647
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04000288 RID: 648
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000289 RID: 649
		[AccessedThroughProperty("CurrencyBox4")]
		private CurrencyBox _CurrencyBox4;

		// Token: 0x0400028A RID: 650
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400028B RID: 651
		[AccessedThroughProperty("GridEX3")]
		private GridEX _GridEX3;

		// Token: 0x0400028C RID: 652
		[AccessedThroughProperty("GridEX2")]
		private GridEX _GridEX2;

		// Token: 0x0400028D RID: 653
		[AccessedThroughProperty("CurrencyBox2")]
		private NumericBox _CurrencyBox2;

		// Token: 0x0400028E RID: 654
		[AccessedThroughProperty("CurrencyBox5")]
		private NumericBox _CurrencyBox5;

		// Token: 0x0400028F RID: 655
		[AccessedThroughProperty("CurrencyBox6")]
		private NumericBox _CurrencyBox6;

		// Token: 0x04000290 RID: 656
		[AccessedThroughProperty("CurrencyBox3")]
		private NumericBox _CurrencyBox3;

		// Token: 0x04000291 RID: 657
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000292 RID: 658
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000293 RID: 659
		private DataTable dt1;

		// Token: 0x04000294 RID: 660
		private DataTable dt2;

		// Token: 0x04000295 RID: 661
		private DataTable dt3;

		// Token: 0x04000296 RID: 662
		private int focusindex;
	}
}
