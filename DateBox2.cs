using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000092 RID: 146
	public class DateBox2 : MaskedEditBox
	{
		// Token: 0x06000CDE RID: 3294 RVA: 0x0009F91C File Offset: 0x0009DB1C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DateBox2.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DateBox2.__ENCList.Count == DateBox2.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DateBox2.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DateBox2.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DateBox2.__ENCList[num] = DateBox2.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DateBox2.__ENCList.RemoveRange(num, DateBox2.__ENCList.Count - num);
						DateBox2.__ENCList.Capacity = DateBox2.__ENCList.Count;
					}
					DateBox2.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0009FA20 File Offset: 0x0009DC20
		[DebuggerNonUserCode]
		public DateBox2(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0009FA4C File Offset: 0x0009DC4C
		[DebuggerNonUserCode]
		public DateBox2()
		{
			DateBox2.__ENCAddToList(this);
			bool flag = true;
			this.AllowEdit = flag;
			flag = true;
			this.AcceptEnter = flag;
			int focusDatePart = 2;
			this.FocusDatePart = focusDatePart;
			this._btn = true;
			this.daysinmonth = new int[13];
			this.DatePart = 0;
			this.p = new PersianCalendar();
			this.pos = true;
			this.Mask = "0000/00/00";
			this.ButtonStyle = EditButtonStyle.DownArrow;
			this.VisualStyle = VisualStyle.Office2010;
			this.RightToLeft = RightToLeft.No;
			this.GotFocus += new EventHandler(this.Me_GotFocus);
			this.MouseUp += new MouseEventHandler(this.Me_MouseUp);
			this.KeyDown += new KeyEventHandler(this.Me_KeyDown);
			this.ButtonClick += new EventHandler(this.Me_ButtonClick);
			this.InitializeComponent();
			this.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			this.sal = Conversions.ToInteger(this.Text.Substring(0, 4));
			this.mah = Conversions.ToInteger(this.Text.Substring(5, 2));
			this.ruz = Conversions.ToInteger(this.Text.Substring(8, 2));
			this.Text = string.Concat(new string[]
			{
				Conversions.ToString(this.sal),
				"/",
				Strings.Format(this.mah, "00"),
				"/",
				Strings.Format(this.ruz, "00")
			});
			this.GetDays();
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0009FBF8 File Offset: 0x0009DDF8
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

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0000492A File Offset: 0x00002B2A
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0009FC48 File Offset: 0x0009DE48
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x00004939 File Offset: 0x00002B39
		public bool AllowEdit
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AllowEdit;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AllowEdit = value;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0009FC60 File Offset: 0x0009DE60
		// (set) Token: 0x06000CE6 RID: 3302 RVA: 0x00004943 File Offset: 0x00002B43
		[Category("ExtendProperty")]
		public bool AcceptEnter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AcceptEnter;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AcceptEnter = value;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x0009FC78 File Offset: 0x0009DE78
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x0000494D File Offset: 0x00002B4D
		[Category("ExtendProperty")]
		public int FocusDatePart
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FocusDatePart;
			}
			[DebuggerNonUserCode]
			set
			{
				this._FocusDatePart = value;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0009FC90 File Offset: 0x0009DE90
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0009FCA8 File Offset: 0x0009DEA8
		[Category("ExtendProperty")]
		public bool ButtonEnable
		{
			get
			{
				return this._btn;
			}
			set
			{
				this._btn = value;
				if (value)
				{
					this.ButtonStyle = EditButtonStyle.DownArrow;
				}
				else
				{
					this.ButtonStyle = EditButtonStyle.NoButton;
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000CEB RID: 3307 RVA: 0x00004957 File Offset: 0x00002B57
		// (remove) Token: 0x06000CEC RID: 3308 RVA: 0x00004971 File Offset: 0x00002B71
		public event DateBox2.OnRightEventHandler OnRight
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnRightEvent = (DateBox2.OnRightEventHandler)Delegate.Combine(this.OnRightEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnRightEvent = (DateBox2.OnRightEventHandler)Delegate.Remove(this.OnRightEvent, value);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000CED RID: 3309 RVA: 0x0000498B File Offset: 0x00002B8B
		// (remove) Token: 0x06000CEE RID: 3310 RVA: 0x000049A5 File Offset: 0x00002BA5
		public event DateBox2.OnLeftEventHandler OnLeft
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.OnLeftEvent = (DateBox2.OnLeftEventHandler)Delegate.Combine(this.OnLeftEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.OnLeftEvent = (DateBox2.OnLeftEventHandler)Delegate.Remove(this.OnLeftEvent, value);
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x000049BF File Offset: 0x00002BBF
		public void SetNew()
		{
			this.SetDefault();
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x000049CA File Offset: 0x00002BCA
		public void SetDefault()
		{
			this.SetDate(Public_Function.dict["today"]);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0009FCD8 File Offset: 0x0009DED8
		public void SetDate(DateTime _date)
		{
			string date = Public_Function.MiladiToShamsi(_date);
			this.SetDate(date);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x000049E4 File Offset: 0x00002BE4
		public void SetDateToFiscalStart()
		{
			this.SetDate(Public_Function.dict["MaliStartDate"]);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x000049FE File Offset: 0x00002BFE
		public void SetDateToFiscalEnd()
		{
			this.SetDate(Public_Function.dict["MaliEndDate"]);
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x0009FCF8 File Offset: 0x0009DEF8
		public void SetDate(string _date)
		{
			bool flag = Operators.CompareString(_date, string.Empty, false) == 0;
			if (flag)
			{
				this.SetNew();
			}
			else
			{
				string[] array = _date.Split(new char[]
				{
					'/'
				});
				this.Text = _date;
				this.sal = Conversions.ToInteger(array[0]);
				this.mah = Conversions.ToInteger(array[1]);
				this.ruz = Conversions.ToInteger(array[2]);
			}
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x0009FD6C File Offset: 0x0009DF6C
		private void GetDays()
		{
			this.daysinmonth[1] = this.p.GetDaysInMonth(this.sal, 1);
			this.daysinmonth[2] = this.p.GetDaysInMonth(this.sal, 2);
			this.daysinmonth[3] = this.p.GetDaysInMonth(this.sal, 3);
			this.daysinmonth[4] = this.p.GetDaysInMonth(this.sal, 4);
			this.daysinmonth[5] = this.p.GetDaysInMonth(this.sal, 5);
			this.daysinmonth[6] = this.p.GetDaysInMonth(this.sal, 6);
			this.daysinmonth[7] = this.p.GetDaysInMonth(this.sal, 7);
			this.daysinmonth[8] = this.p.GetDaysInMonth(this.sal, 8);
			this.daysinmonth[9] = this.p.GetDaysInMonth(this.sal, 9);
			this.daysinmonth[10] = this.p.GetDaysInMonth(this.sal, 10);
			this.daysinmonth[11] = this.p.GetDaysInMonth(this.sal, 11);
			this.daysinmonth[12] = this.p.GetDaysInMonth(this.sal, 12);
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x0009FEBC File Offset: 0x0009E0BC
		private void Me_ButtonClick(object sender, EventArgs e)
		{
			ToolStripDropDown toolStripDropDown = new ToolStripDropDown();
			DatePanel datePanel = new DatePanel();
			ToolStripControlHost toolStripControlHost = new ToolStripControlHost(datePanel);
			datePanel.Ruz = this.ruz;
			datePanel.Sal = this.sal;
			datePanel.Mah = this.mah;
			datePanel.DateBox = this;
			datePanel.DropDown = toolStripDropDown;
			toolStripDropDown.AutoSize = false;
			Control arg_6A_0 = toolStripDropDown;
			Size size = new Size(datePanel.Width, datePanel.Height);
			arg_6A_0.Size = size;
			toolStripControlHost.Control.Dock = DockStyle.Fill;
			toolStripControlHost.Control.Top = 0;
			toolStripControlHost.Control.Left = 0;
			toolStripDropDown.Items.Add(toolStripControlHost);
			toolStripDropDown.Show(this, 0, checked(this.Height + 1));
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x0009FF80 File Offset: 0x0009E180
		private void Me_GotFocus(object sender, EventArgs e)
		{
			Trace.WriteLine(this.SelectionStart);
			switch (this.FocusDatePart)
			{
			case 0:
				this.SelectionStart = 0;
				this.SelectionLength = 4;
				this.DatePart = 0;
				break;
			case 1:
				this.SelectionStart = 5;
				this.SelectionLength = 2;
				this.DatePart = 1;
				break;
			case 2:
				this.SelectionStart = 8;
				this.SelectionLength = 2;
				this.DatePart = 2;
				break;
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x000A000C File Offset: 0x0009E20C
		private string GetVal(KeyEventArgs e)
		{
			string result;
			switch (e.KeyCode)
			{
			case Keys.D0:
			case Keys.NumPad0:
				result = "0";
				return result;
			case Keys.D1:
			case Keys.NumPad1:
				result = "1";
				return result;
			case Keys.D2:
			case Keys.NumPad2:
				result = "2";
				return result;
			case Keys.D3:
			case Keys.NumPad3:
				result = "3";
				return result;
			case Keys.D4:
			case Keys.NumPad4:
				result = "4";
				return result;
			case Keys.D5:
			case Keys.NumPad5:
				result = "5";
				return result;
			case Keys.D6:
			case Keys.NumPad6:
				result = "6";
				return result;
			case Keys.D7:
			case Keys.NumPad7:
				result = "7";
				return result;
			case Keys.D8:
			case Keys.NumPad8:
				result = "8";
				return result;
			case Keys.D9:
			case Keys.NumPad9:
				result = "9";
				return result;
			}
			result = "0";
			return result;
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x000A018C File Offset: 0x0009E38C
		public void Me_KeyDown(object sender, KeyEventArgs e)
		{
			bool arg_30_0;
			if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
			{
				if (e.KeyData < Keys.NumPad0 || e.KeyData > Keys.NumPad9)
				{
					arg_30_0 = false;
					goto IL_2F;
				}
			}
			arg_30_0 = true;
			IL_2F:
			bool flag = arg_30_0;
			checked
			{
				if (flag)
				{
					switch (this.DatePart)
					{
					case 0:
					{
						bool flag2 = this.pos;
						if (flag2)
						{
							this.sal = Conversions.ToInteger(this.sal.ToString().Remove(2, 1));
							this.sal = Conversions.ToInteger(this.sal.ToString().Insert(2, this.GetVal(e)));
							flag2 = (this.sal >= 1304 && this.sal <= 1309);
							if (flag2)
							{
								this.sal = 1400;
							}
						}
						else
						{
							this.sal = Conversions.ToInteger(this.sal.ToString().Remove(3, 1));
							this.sal = Conversions.ToInteger(this.sal.ToString().Insert(3, this.GetVal(e)));
							flag2 = (this.sal == 1499);
							if (flag2)
							{
								this.sal = 1399;
							}
						}
						this.pos = !this.pos;
						flag2 = this.pos;
						if (flag2)
						{
							this.DatePart = 1;
						}
						break;
					}
					case 1:
					{
						bool flag2 = this.mah >= 2;
						if (flag2)
						{
							this.pos = true;
						}
						flag2 = this.pos;
						if (flag2)
						{
							flag = (Conversions.ToDouble(this.GetVal(e)) >= 2.0);
							if (flag)
							{
								this.mah = Conversions.ToInteger(this.GetVal(e));
								this.DatePart = 2;
							}
							else
							{
								flag2 = (Conversions.ToDouble(this.GetVal(e)) != 0.0);
								if (flag2)
								{
									this.mah = Conversions.ToInteger(this.GetVal(e));
									this.pos = !this.pos;
								}
							}
						}
						else
						{
							flag2 = (Conversions.ToDouble(this.GetVal(e)) <= 2.0);
							if (flag2)
							{
								this.mah = (int)Math.Round(unchecked(Conversions.ToDouble(this.mah.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
							}
							this.pos = true;
							this.DatePart = 2;
						}
						break;
					}
					case 2:
					{
						bool flag2 = this.pos;
						if (flag2)
						{
							flag = (Conversions.ToDouble(this.GetVal(e)) > 3.0);
							if (flag)
							{
								this.ruz = Conversions.ToInteger(this.GetVal(e));
							}
							else
							{
								flag2 = (Conversions.ToDouble(this.GetVal(e)) != 0.0);
								if (flag2)
								{
									this.ruz = Conversions.ToInteger(this.GetVal(e));
									this.pos = false;
								}
							}
						}
						else
						{
							flag2 = (this.ruz < 4);
							if (flag2)
							{
								flag = (this.ruz != 3);
								if (flag)
								{
									this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
									this.pos = true;
								}
								else
								{
									flag2 = (Conversions.ToDouble(this.GetVal(e)) == 0.0 || Conversions.ToDouble(this.GetVal(e)) == 1.0);
									if (flag2)
									{
										this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
										this.pos = true;
									}
									else
									{
										this.ruz = Conversions.ToInteger(this.GetVal(e));
										this.pos = true;
									}
								}
							}
							else
							{
								this.ruz = (int)Math.Round(unchecked(Conversions.ToDouble(this.ruz.ToString("00").Remove(0, 1)) * 10.0 + Conversions.ToDouble(this.GetVal(e))));
								this.pos = true;
							}
						}
						break;
					}
					}
				}
				switch (e.KeyCode)
				{
				case Keys.Return:
				{
					bool flag2 = !this.AcceptEnter;
					if (flag2)
					{
						return;
					}
					this.Parent.SelectNextControl((Control)sender, true, true, true, true);
					break;
				}
				case Keys.Left:
				{
					this.DatePart--;
					bool flag3 = this.DatePart < 0;
					if (flag3)
					{
						this.DatePart = 0;
						flag3 = (this.Parent == null);
						if (flag3)
						{
							return;
						}
						flag3 = (this.Parent.Parent != null);
						if (flag3)
						{
							bool flag2 = this.Parent.Parent is GridEX;
							if (flag2)
							{
								flag = (((GridEX)this.Parent.Parent).Col >= 0);
								if (flag)
								{
									GridEX gridEX = (GridEX)this.Parent.Parent;
									gridEX.Col++;
									DateBox2.OnLeftEventHandler onLeftEvent = this.OnLeftEvent;
									flag3 = (onLeftEvent != null);
									if (flag3)
									{
										onLeftEvent();
									}
								}
							}
						}
						e.SuppressKeyPress = true;
					}
					break;
				}
				case Keys.Up:
				{
					bool flag2 = this.Parent == null;
					if (flag2)
					{
						return;
					}
					flag2 = (this.Parent.Parent != null);
					if (flag2)
					{
						flag = (this.Parent.Parent is GridEX);
						if (flag)
						{
							return;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, false, true, true, true);
					break;
				}
				case Keys.Right:
				{
					this.DatePart++;
					bool flag2 = this.DatePart > 2;
					if (flag2)
					{
						this.DatePart = 2;
						e.SuppressKeyPress = true;
						flag2 = (this.Parent == null);
						if (flag2)
						{
							return;
						}
						flag2 = (this.Parent.Parent != null);
						if (flag2)
						{
							flag = (this.Parent.Parent is GridEX);
							if (flag)
							{
								bool flag3 = ((GridEX)this.Parent.Parent).Col > 0;
								if (flag3)
								{
									GridEX gridEX = (GridEX)this.Parent.Parent;
									gridEX.Col--;
									DateBox2.OnRightEventHandler onRightEvent = this.OnRightEvent;
									flag3 = (onRightEvent != null);
									if (flag3)
									{
										onRightEvent();
									}
								}
							}
						}
					}
					break;
				}
				case Keys.Down:
				{
					bool flag2 = this.Parent == null;
					if (flag2)
					{
						return;
					}
					flag2 = (this.Parent.Parent != null);
					if (flag2)
					{
						flag = (this.Parent.Parent is GridEX);
						if (flag)
						{
							return;
						}
					}
					this.ParentForm.SelectNextControl((Control)sender, true, true, true, true);
					break;
				}
				case Keys.Delete:
					this.SetNew();
					break;
				}
				this.Text = string.Concat(new string[]
				{
					Conversions.ToString(this.sal),
					"/",
					Strings.Format(this.mah, "00"),
					"/",
					Strings.Format(this.ruz, "00")
				});
				switch (this.DatePart)
				{
				case 0:
					this.SelectionStart = 0;
					this.SelectionLength = 4;
					break;
				case 1:
					this.SelectionStart = 5;
					this.SelectionLength = 2;
					break;
				case 2:
					this.SelectionStart = 8;
					this.SelectionLength = 2;
					break;
				}
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x000A0A24 File Offset: 0x0009EC24
		private void Me_MouseUp(object sender, MouseEventArgs e)
		{
			bool flag = this.SelectionStart >= 0 && this.SelectionStart < 4;
			if (flag)
			{
				this.SelectionStart = 0;
				this.SelectionLength = 4;
				this.DatePart = 0;
			}
			flag = (this.SelectionStart >= 4 && this.SelectionStart <= 6);
			if (flag)
			{
				this.SelectionStart = 5;
				this.SelectionLength = 2;
				this.DatePart = 1;
			}
			flag = (this.SelectionStart >= 7);
			if (flag)
			{
				this.SelectionStart = 8;
				this.SelectionLength = 2;
				this.DatePart = 2;
			}
		}

		// Token: 0x040004EB RID: 1259
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004EC RID: 1260
		private IContainer components;

		// Token: 0x040004ED RID: 1261
		[CompilerGenerated]
		private bool _AllowEdit;

		// Token: 0x040004EE RID: 1262
		[CompilerGenerated]
		private bool _AcceptEnter;

		// Token: 0x040004EF RID: 1263
		[CompilerGenerated]
		private int _FocusDatePart;

		// Token: 0x040004F0 RID: 1264
		private bool _btn;

		// Token: 0x040004F1 RID: 1265
		private int[] daysinmonth;

		// Token: 0x040004F2 RID: 1266
		public int DatePart;

		// Token: 0x040004F3 RID: 1267
		private int sal;

		// Token: 0x040004F4 RID: 1268
		private int mah;

		// Token: 0x040004F5 RID: 1269
		private int ruz;

		// Token: 0x040004F6 RID: 1270
		private PersianCalendar p;

		// Token: 0x040004F7 RID: 1271
		private bool pos;

		// Token: 0x040004F8 RID: 1272
		private DateBox2.OnRightEventHandler OnRightEvent;

		// Token: 0x040004F9 RID: 1273
		private DateBox2.OnLeftEventHandler OnLeftEvent;

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000CFE RID: 3326
		public delegate void OnRightEventHandler();

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000D02 RID: 3330
		public delegate void OnLeftEventHandler();
	}
}
