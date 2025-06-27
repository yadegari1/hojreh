using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000A2 RID: 162
	public class NumericBox : EditBox
	{
		// Token: 0x06000DF2 RID: 3570 RVA: 0x000A6080 File Offset: 0x000A4280
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = NumericBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = NumericBox.__ENCList.Count == NumericBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = NumericBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = NumericBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									NumericBox.__ENCList[num] = NumericBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						NumericBox.__ENCList.RemoveRange(num, NumericBox.__ENCList.Count - num);
						NumericBox.__ENCList.Capacity = NumericBox.__ENCList.Count;
					}
					NumericBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x000A6184 File Offset: 0x000A4384
		[DebuggerNonUserCode]
		public NumericBox(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x000A61B0 File Offset: 0x000A43B0
		public NumericBox()
		{
			base.HandleCreated += new EventHandler(this.NumericBox_HandleCreated);
			NumericBox.__ENCAddToList(this);
			base.KeyPress += new KeyPressEventHandler(this.Me_Keypress);
			base.LostFocus += new EventHandler(this.me_lostFocus);
			this.TextAlignment = TextAlignment.Far;
			this.InitializeComponent();
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000A6218 File Offset: 0x000A4418
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x00004F41 File Offset: 0x00003141
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00004F50 File Offset: 0x00003150
		protected override void Finalize()
		{
			base.Finalize();
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x000A6268 File Offset: 0x000A4468
		// (set) Token: 0x06000DF9 RID: 3577 RVA: 0x00004F5B File Offset: 0x0000315B
		[Category("ExtendProperty"), DefaultValue(0)]
		public int DecimalDigits
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DecimalDigits;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DecimalDigits = value;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06000DFA RID: 3578 RVA: 0x000A6280 File Offset: 0x000A4480
		// (set) Token: 0x06000DFB RID: 3579 RVA: 0x00004F65 File Offset: 0x00003165
		[Category("ExtendProperty"), DefaultValue(false)]
		public bool AllowZero
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowZero;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowZero = value;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x000A6298 File Offset: 0x000A4498
		// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00004F6F File Offset: 0x0000316F
		[DefaultValue(false), Category("ExtendProperty")]
		public bool AllowNegative
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowNegative;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowNegative = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000DFE RID: 3582 RVA: 0x000A62B0 File Offset: 0x000A44B0
		// (set) Token: 0x06000DFF RID: 3583 RVA: 0x00004F79 File Offset: 0x00003179
		[DefaultValue(false), Category("ExtendProperty")]
		public bool ThreeZero
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ThreeZero;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ThreeZero = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000E00 RID: 3584 RVA: 0x000A62C8 File Offset: 0x000A44C8
		// (set) Token: 0x06000E01 RID: 3585 RVA: 0x00004F83 File Offset: 0x00003183
		[Category("ExtendProperty"), DefaultValue(0)]
		public int FixLength
		{
			get
			{
				return this._FixLength;
			}
			set
			{
				this._FixLength = value;
				this.MaxLength = this._FixLength;
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x000A62E0 File Offset: 0x000A44E0
		public override void me_keydown(object sender, KeyEventArgs e)
		{
			base.me_keydown(RuntimeHelpers.GetObjectValue(sender), e);
			bool flag = e.KeyCode == Keys.Left;
			checked
			{
				bool flag2;
				if (flag)
				{
					flag2 = (this.SelectionStart > 0);
					if (flag2)
					{
						this.SelectionStart--;
						e.SuppressKeyPress = true;
					}
				}
				flag2 = (e.KeyCode == Keys.Right);
				if (flag2)
				{
					flag = (this.SelectionStart < this.Text.Length);
					if (flag)
					{
						this.SelectionStart++;
						e.SuppressKeyPress = true;
					}
				}
				flag2 = !this.AllowEdit;
				if (!flag2)
				{
					flag2 = (e.KeyCode == Keys.Delete && this.SelectionStart != this.TextLength);
					if (flag2)
					{
						int selectionStart = this.SelectionStart;
						this.Text = this.Text.Remove(this.SelectionStart, 1);
						this.SelectionStart = selectionStart;
						flag2 = (Operators.CompareString(this.Text, string.Empty, false) != 0 && this.Text.StartsWith("0"));
						if (flag2)
						{
							this.Text = this.Text.Remove(0, 1);
						}
						flag2 = (Operators.CompareString(this.Text, string.Empty, false) != 0 && this.Text.StartsWith(","));
						if (flag2)
						{
							this.Text = this.Text.Remove(0, 1);
						}
						e.SuppressKeyPress = true;
					}
					flag2 = (e.KeyCode == Keys.Back);
					if (flag2)
					{
						int selectionStart2 = this.SelectionStart;
						flag2 = (selectionStart2 != 0);
						if (flag2)
						{
							this.Text = this.Text.Remove(this.SelectionStart - 1, 1);
							this.SelectionStart = selectionStart2 - 1;
						}
						else
						{
							flag2 = (Operators.CompareString(this.Text, "-", false) == 0);
							if (flag2)
							{
								this.Text = "";
							}
						}
						e.SuppressKeyPress = true;
					}
				}
			}
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000A64D8 File Offset: 0x000A46D8
		private void Me_Keypress(object sender, KeyPressEventArgs e)
		{
			bool flag = !char.IsDigit(e.KeyChar) && Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) != 0 && Operators.CompareString(Conversions.ToString(e.KeyChar), "+", false) != 0 && Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) != 0;
			checked
			{
				if (flag)
				{
					e.Handled = true;
				}
				else
				{
					flag = (Operators.CompareString(Conversions.ToString(e.KeyChar), "0", false) == 0);
					bool flag3;
					if (flag)
					{
						bool flag2 = Operators.CompareString(this.Text, string.Empty, false) == 0 || Operators.CompareString(this.Text, "-", false) == 0;
						if (flag2)
						{
							flag3 = !this.AllowZero;
							if (flag3)
							{
								e.Handled = true;
							}
						}
					}
					flag3 = (Operators.CompareString(Conversions.ToString(e.KeyChar), "+", false) == 0);
					if (flag3)
					{
						bool flag2 = Operators.CompareString(this.Text, string.Empty, false) != 0 && Operators.CompareString(this.Text, "-", false) != 0;
						if (flag2)
						{
							flag = (this.Text.IndexOf("-") > 0);
							if (flag)
							{
								string str = this.Text.Replace("-", "");
								flag3 = this.ThreeZero;
								if (flag3)
								{
									this.Text = str + "000-";
								}
								else
								{
									this.Text = str + "00-";
								}
								this.SelectionStart = this.TextLength - 1;
							}
							else
							{
								flag3 = this.ThreeZero;
								if (flag3)
								{
									this.Text += "000";
								}
								else
								{
									this.Text += "00";
								}
								this.SelectionStart = this.TextLength;
							}
						}
						e.Handled = true;
					}
					flag3 = (Operators.CompareString(Conversions.ToString(e.KeyChar), "-", false) == 0);
					if (flag3)
					{
						bool flag2 = Operators.CompareString(this.Text, string.Empty, false) == 0 || Operators.CompareString(this.Text, "0", false) == 0;
						if (flag2)
						{
							flag = this.AllowNegative;
							if (flag)
							{
								this.Text = "-";
							}
						}
						else
						{
							flag3 = this.AllowNegative;
							if (flag3)
							{
								int selectionStart = this.SelectionStart;
								flag3 = (this.Text.IndexOf("-") > -1);
								if (flag3)
								{
									this.Text = this.Text.Replace("-", "");
								}
								else
								{
									this.Text += "-";
								}
								this.SelectionStart = selectionStart;
							}
						}
						e.Handled = true;
					}
					flag3 = char.IsDigit(e.KeyChar);
					if (flag3)
					{
						bool flag2 = this.Text.StartsWith(".");
						if (flag2)
						{
							this.Text = this.Text.Remove(0, 1) + ".";
							this.SelectionStart = this.Text.Length;
						}
					}
					flag3 = (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0 && this.DecimalDigits == 0);
					if (flag3)
					{
						e.Handled = true;
					}
					else
					{
						flag3 = (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0);
						if (flag3)
						{
							bool flag2 = !this.Text.Contains(".");
							if (flag2)
							{
								flag = (Operators.CompareString(this.Text, string.Empty, false) == 0);
								if (flag)
								{
									this.Text = ".0";
								}
								else
								{
									this.Text = this.Text.Insert(0, ".");
								}
							}
							e.Handled = true;
						}
						flag3 = (this.DecimalDigits != 0);
						if (flag3)
						{
							bool flag2 = this.Text.Contains(".");
							if (flag2)
							{
								flag = (this.Text.Substring(this.Text.IndexOf("."), this.Text.Length - this.Text.IndexOf(".")).Length - 1 == this.DecimalDigits);
								if (flag)
								{
									e.Handled = true;
								}
							}
						}
						flag3 = (this.FixLength != 0);
						if (flag3)
						{
							bool flag2 = this.Text.Contains(".");
							if (flag2)
							{
								flag = (this.Text.Substring(this.Text.IndexOf("."), this.Text.Length - this.Text.IndexOf(".")).Length - 1 == this.FixLength);
								if (flag)
								{
									e.Handled = true;
								}
							}
							else
							{
								flag3 = (this.Text.Length == this.FixLength);
								if (flag3)
								{
									e.Handled = true;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000A69F4 File Offset: 0x000A4BF4
		public override void me_lostFocus(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
			bool flag = this.Text.EndsWith(".");
			if (flag)
			{
				this.Text = this.Text.Remove(checked(this.Text.Length - 1), 1);
			}
			flag = (this.DecimalDigits == 0 && this.FixLength > 0);
			if (flag)
			{
				this.Text = Conversions.ToString(Public_Function.FillZero(this.Text, this.FixLength));
			}
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000A6A80 File Offset: 0x000A4C80
		private void NumericBox_HandleCreated(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict != null;
			if (flag)
			{
				bool flag2 = Public_Function.dict.ContainsKey("three_zero");
				if (flag2)
				{
					this.ThreeZero = Conversions.ToBoolean(Public_Function.dict["three_zero"]);
				}
			}
		}

		// Token: 0x04000556 RID: 1366
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000557 RID: 1367
		private IContainer components;

		// Token: 0x04000558 RID: 1368
		private int _FixLength;

		// Token: 0x04000559 RID: 1369
		[CompilerGenerated]
		private int _DecimalDigits;

		// Token: 0x0400055A RID: 1370
		[CompilerGenerated]
		private bool _AllowZero;

		// Token: 0x0400055B RID: 1371
		[CompilerGenerated]
		private bool _AllowNegative;

		// Token: 0x0400055C RID: 1372
		[CompilerGenerated]
		private bool _ThreeZero;
	}
}
