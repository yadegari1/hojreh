using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200009B RID: 155
	[DesignerGenerated]
	public class NavBox : UserControl
	{
		// Token: 0x06000DB7 RID: 3511 RVA: 0x00004DD3 File Offset: 0x00002FD3
		[DebuggerNonUserCode]
		public NavBox()
		{
			NavBox.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x000A5710 File Offset: 0x000A3910
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = NavBox.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = NavBox.__ENCList.Count == NavBox.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = NavBox.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = NavBox.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									NavBox.__ENCList[num] = NavBox.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						NavBox.__ENCList.RemoveRange(num, NavBox.__ENCList.Count - num);
						NavBox.__ENCList.Capacity = NavBox.__ENCList.Count;
					}
					NavBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x000A5814 File Offset: 0x000A3A14
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

		// Token: 0x06000DBA RID: 3514 RVA: 0x000A5864 File Offset: 0x000A3A64
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			this.UiButton4 = new UIButton();
			this.UiButton3 = new UIButton();
			this.UiButton2 = new UIButton();
			this.UiButton1 = new UIButton();
			this.NumericBox1 = new NumericBox(this.components);
			this.SuspendLayout();
			this.UiButton4.Dock = DockStyle.Left;
			this.UiButton4.Image = Resources.resultset_last;
			Control arg_88_0 = this.UiButton4;
			Point location = new Point(144, 0);
			arg_88_0.Location = location;
			this.UiButton4.Name = "UiButton4";
			this.UiButton4.ShowFocusRectangle = false;
			Control arg_BF_0 = this.UiButton4;
			Size size = new Size(25, 28);
			arg_BF_0.Size = size;
			this.UiButton4.TabIndex = 1;
			this.UiButton4.TabStop = false;
			this.UiButton4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton3.Dock = DockStyle.Left;
			this.UiButton3.Image = Resources.resultset_next;
			Control arg_11C_0 = this.UiButton3;
			location = new Point(120, 0);
			arg_11C_0.Location = location;
			this.UiButton3.Name = "UiButton3";
			this.UiButton3.ShowFocusRectangle = false;
			Control arg_153_0 = this.UiButton3;
			size = new Size(24, 28);
			arg_153_0.Size = size;
			this.UiButton3.TabIndex = 1;
			this.UiButton3.TabStop = false;
			this.UiButton3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton2.Dock = DockStyle.Left;
			this.UiButton2.Image = Resources.resultset_first;
			Control arg_1AF_0 = this.UiButton2;
			location = new Point(0, 0);
			arg_1AF_0.Location = location;
			this.UiButton2.Name = "UiButton2";
			this.UiButton2.ShowFocusRectangle = false;
			Control arg_1E6_0 = this.UiButton2;
			size = new Size(24, 28);
			arg_1E6_0.Size = size;
			this.UiButton2.TabIndex = 1;
			this.UiButton2.TabStop = false;
			this.UiButton2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.UiButton1.Dock = DockStyle.Left;
			this.UiButton1.Image = Resources.resultset_previous;
			Control arg_243_0 = this.UiButton1;
			location = new Point(24, 0);
			arg_243_0.Location = location;
			this.UiButton1.Name = "UiButton1";
			this.UiButton1.ShowFocusRectangle = false;
			Control arg_27A_0 = this.UiButton1;
			size = new Size(24, 28);
			arg_27A_0.Size = size;
			this.UiButton1.TabIndex = 1;
			this.UiButton1.TabStop = false;
			this.UiButton1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.NumericBox1.AcceptEnter = true;
			this.NumericBox1.AllowEdit = true;
			this.NumericBox1.AllowNew = true;
			this.NumericBox1.Dock = DockStyle.Left;
			this.NumericBox1.FocusColor = true;
			this.NumericBox1.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
			Control arg_31C_0 = this.NumericBox1;
			location = new Point(48, 0);
			arg_31C_0.Location = location;
			this.NumericBox1.Name = "NumericBox1";
			this.NumericBox1.Nullable = true;
			this.NumericBox1.NullToolTipText = "این قسمت نمیتواند خالی باشد";
			this.NumericBox1.ShortcutsEnabled = false;
			Control arg_371_0 = this.NumericBox1;
			size = new Size(72, 27);
			arg_371_0.Size = size;
			this.NumericBox1.TabIndex = 0;
			this.NumericBox1.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NumericBox1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			this.Controls.Add(this.UiButton4);
			this.Controls.Add(this.UiButton3);
			this.Controls.Add(this.NumericBox1);
			this.Controls.Add(this.UiButton1);
			this.Controls.Add(this.UiButton2);
			this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			this.Name = "NavBox";
			size = new Size(169, 28);
			this.Size = size;
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x000A5CE8 File Offset: 0x000A3EE8
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x000A5D00 File Offset: 0x000A3F00
		public virtual UIButton UiButton1
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

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000A5D60 File Offset: 0x000A3F60
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000A5D78 File Offset: 0x000A3F78
		public virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000DBF RID: 3519 RVA: 0x000A5DD8 File Offset: 0x000A3FD8
		// (set) Token: 0x06000DC0 RID: 3520 RVA: 0x000A5DF0 File Offset: 0x000A3FF0
		public virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x000A5E50 File Offset: 0x000A4050
		// (set) Token: 0x06000DC2 RID: 3522 RVA: 0x000A5E68 File Offset: 0x000A4068
		public virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x000A5EC8 File Offset: 0x000A40C8
		// (set) Token: 0x06000DC4 RID: 3524 RVA: 0x000A5EE0 File Offset: 0x000A40E0
		public virtual NumericBox NumericBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NumericBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NumericBox1_LostFocus);
				KeyEventHandler value3 = new KeyEventHandler(this.NumericBox1_KeyDown);
				bool flag = this._NumericBox1 != null;
				if (flag)
				{
					this._NumericBox1.LostFocus -= value2;
					this._NumericBox1.KeyDown -= value3;
				}
				this._NumericBox1 = value;
				flag = (this._NumericBox1 != null);
				if (flag)
				{
					this._NumericBox1.LostFocus += value2;
					this._NumericBox1.KeyDown += value3;
				}
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000DC5 RID: 3525 RVA: 0x00004DEB File Offset: 0x00002FEB
		// (remove) Token: 0x06000DC6 RID: 3526 RVA: 0x00004E05 File Offset: 0x00003005
		public event NavBox.Next_ClickEventHandler Next_Click
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Next_ClickEvent = (NavBox.Next_ClickEventHandler)Delegate.Combine(this.Next_ClickEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Next_ClickEvent = (NavBox.Next_ClickEventHandler)Delegate.Remove(this.Next_ClickEvent, value);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000DC7 RID: 3527 RVA: 0x00004E1F File Offset: 0x0000301F
		// (remove) Token: 0x06000DC8 RID: 3528 RVA: 0x00004E39 File Offset: 0x00003039
		public event NavBox.Previous_ClickEventHandler Previous_Click
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Previous_ClickEvent = (NavBox.Previous_ClickEventHandler)Delegate.Combine(this.Previous_ClickEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Previous_ClickEvent = (NavBox.Previous_ClickEventHandler)Delegate.Remove(this.Previous_ClickEvent, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000DC9 RID: 3529 RVA: 0x00004E53 File Offset: 0x00003053
		// (remove) Token: 0x06000DCA RID: 3530 RVA: 0x00004E6D File Offset: 0x0000306D
		public event NavBox.Last_ClickEventHandler Last_Click
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.Last_ClickEvent = (NavBox.Last_ClickEventHandler)Delegate.Combine(this.Last_ClickEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.Last_ClickEvent = (NavBox.Last_ClickEventHandler)Delegate.Remove(this.Last_ClickEvent, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000DCB RID: 3531 RVA: 0x00004E87 File Offset: 0x00003087
		// (remove) Token: 0x06000DCC RID: 3532 RVA: 0x00004EA1 File Offset: 0x000030A1
		public event NavBox.First_ClickEventHandler First_Click
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.First_ClickEvent = (NavBox.First_ClickEventHandler)Delegate.Combine(this.First_ClickEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.First_ClickEvent = (NavBox.First_ClickEventHandler)Delegate.Remove(this.First_ClickEvent, value);
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000DCD RID: 3533 RVA: 0x00004EBB File Offset: 0x000030BB
		// (remove) Token: 0x06000DCE RID: 3534 RVA: 0x00004ED5 File Offset: 0x000030D5
		public event NavBox.txt_LostFocusEventHandler txt_LostFocus
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.txt_LostFocusEvent = (NavBox.txt_LostFocusEventHandler)Delegate.Combine(this.txt_LostFocusEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.txt_LostFocusEvent = (NavBox.txt_LostFocusEventHandler)Delegate.Remove(this.txt_LostFocusEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000DCF RID: 3535 RVA: 0x00004EEF File Offset: 0x000030EF
		// (remove) Token: 0x06000DD0 RID: 3536 RVA: 0x00004F09 File Offset: 0x00003109
		public event NavBox.NumberBox_KeydownEventHandler NumberBox_Keydown
		{
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				this.NumberBox_KeydownEvent = (NavBox.NumberBox_KeydownEventHandler)Delegate.Combine(this.NumberBox_KeydownEvent, value);
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				this.NumberBox_KeydownEvent = (NavBox.NumberBox_KeydownEventHandler)Delegate.Remove(this.NumberBox_KeydownEvent, value);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x000A5F68 File Offset: 0x000A4168
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x00004F23 File Offset: 0x00003123
		public string Value
		{
			get
			{
				return this.NumericBox1.Text;
			}
			set
			{
				this.NumericBox1.Text = value;
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000A5F88 File Offset: 0x000A4188
		private void UiButton3_Click(object sender, EventArgs e)
		{
			NavBox.Next_ClickEventHandler next_ClickEvent = this.Next_ClickEvent;
			bool flag = next_ClickEvent != null;
			if (flag)
			{
				next_ClickEvent();
			}
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000A5FB0 File Offset: 0x000A41B0
		private void UiButton4_Click(object sender, EventArgs e)
		{
			NavBox.Last_ClickEventHandler last_ClickEvent = this.Last_ClickEvent;
			bool flag = last_ClickEvent != null;
			if (flag)
			{
				last_ClickEvent();
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000A5FD8 File Offset: 0x000A41D8
		private void UiButton1_Click(object sender, EventArgs e)
		{
			NavBox.Previous_ClickEventHandler previous_ClickEvent = this.Previous_ClickEvent;
			bool flag = previous_ClickEvent != null;
			if (flag)
			{
				previous_ClickEvent();
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000A6000 File Offset: 0x000A4200
		private void UiButton2_Click(object sender, EventArgs e)
		{
			NavBox.First_ClickEventHandler first_ClickEvent = this.First_ClickEvent;
			bool flag = first_ClickEvent != null;
			if (flag)
			{
				first_ClickEvent();
			}
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000A6028 File Offset: 0x000A4228
		private void NumericBox1_KeyDown(object sender, KeyEventArgs e)
		{
			NavBox.NumberBox_KeydownEventHandler numberBox_KeydownEvent = this.NumberBox_KeydownEvent;
			bool flag = numberBox_KeydownEvent != null;
			if (flag)
			{
				numberBox_KeydownEvent(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000A6058 File Offset: 0x000A4258
		private void NumericBox1_LostFocus(object sender, EventArgs e)
		{
			NavBox.txt_LostFocusEventHandler txt_LostFocusEventHandler = this.txt_LostFocusEvent;
			bool flag = txt_LostFocusEventHandler != null;
			if (flag)
			{
				txt_LostFocusEventHandler();
			}
		}

		// Token: 0x04000549 RID: 1353
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400054A RID: 1354
		private IContainer components;

		// Token: 0x0400054B RID: 1355
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400054C RID: 1356
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x0400054D RID: 1357
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x0400054E RID: 1358
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x0400054F RID: 1359
		[AccessedThroughProperty("NumericBox1")]
		private NumericBox _NumericBox1;

		// Token: 0x04000550 RID: 1360
		private NavBox.Next_ClickEventHandler Next_ClickEvent;

		// Token: 0x04000551 RID: 1361
		private NavBox.Previous_ClickEventHandler Previous_ClickEvent;

		// Token: 0x04000552 RID: 1362
		private NavBox.Last_ClickEventHandler Last_ClickEvent;

		// Token: 0x04000553 RID: 1363
		private NavBox.First_ClickEventHandler First_ClickEvent;

		// Token: 0x04000554 RID: 1364
		private NavBox.txt_LostFocusEventHandler txt_LostFocusEvent;

		// Token: 0x04000555 RID: 1365
		private NavBox.NumberBox_KeydownEventHandler NumberBox_KeydownEvent;

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000DDC RID: 3548
		public delegate void Next_ClickEventHandler();

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000DE0 RID: 3552
		public delegate void Previous_ClickEventHandler();

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000DE4 RID: 3556
		public delegate void Last_ClickEventHandler();

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000DE8 RID: 3560
		public delegate void First_ClickEventHandler();

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000DEC RID: 3564
		public delegate void txt_LostFocusEventHandler();

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x06000DF0 RID: 3568
		public delegate void NumberBox_KeydownEventHandler(object sender, KeyEventArgs e);
	}
}
