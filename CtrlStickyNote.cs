using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;

namespace FruitBox
{
	// Token: 0x020000B4 RID: 180
	public class CtrlStickyNote : BaseUserControl
	{
		// Token: 0x06000EA3 RID: 3747 RVA: 0x000A88B8 File Offset: 0x000A6AB8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlStickyNote.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlStickyNote.__ENCList.Count == CtrlStickyNote.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlStickyNote.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlStickyNote.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlStickyNote.__ENCList[num] = CtrlStickyNote.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlStickyNote.__ENCList.RemoveRange(num, CtrlStickyNote.__ENCList.Count - num);
						CtrlStickyNote.__ENCList.Capacity = CtrlStickyNote.__ENCList.Count;
					}
					CtrlStickyNote.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x000052CA File Offset: 0x000034CA
		public CtrlStickyNote()
		{
			CtrlStickyNote.__ENCAddToList(this);
			this._Enabled = true;
			this.InitializeComponent();
			this.SetDefaultControlStyles();
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000A89BC File Offset: 0x000A6BBC
		private void ChangeToColour(CtrlStickyNote.Colour c)
		{
			switch (c)
			{
			case CtrlStickyNote.Colour.Yellow:
				this.BackColor = Color.Gold;
				this.ctrlCustomPanel1.BackColor = Color.Gold;
				this.splitContainer1.BackColor = Color.Gold;
				this.splitContainer1.Panel2.BackColor = Color.Gold;
				this.richTextBox1.BackColor = Color.Gold;
				break;
			case CtrlStickyNote.Colour.Blue:
				this.BackColor = Color.LightSteelBlue;
				this.ctrlCustomPanel1.BackColor = Color.LightSteelBlue;
				this.splitContainer1.BackColor = Color.LightSteelBlue;
				this.splitContainer1.Panel2.BackColor = Color.LightSteelBlue;
				this.richTextBox1.BackColor = Color.LightSteelBlue;
				break;
			case CtrlStickyNote.Colour.Red:
				this.BackColor = Color.LightCoral;
				this.ctrlCustomPanel1.BackColor = Color.LightCoral;
				this.splitContainer1.BackColor = Color.LightCoral;
				this.splitContainer1.Panel2.BackColor = Color.LightCoral;
				this.richTextBox1.BackColor = Color.LightCoral;
				break;
			}
			this._CurrentColour = c;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x000052F1 File Offset: 0x000034F1
		private void ctrlBlue_Click(object sender, EventArgs e)
		{
			this.ChangeToColour(CtrlStickyNote.Colour.Blue);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000052FD File Offset: 0x000034FD
		private void ctrlRed_Click(object sender, EventArgs e)
		{
			this.ChangeToColour(CtrlStickyNote.Colour.Red);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00005309 File Offset: 0x00003509
		private void ctrlYellow_Click(object sender, EventArgs e)
		{
			this.ChangeToColour(CtrlStickyNote.Colour.Yellow);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000A8B04 File Offset: 0x000A6D04
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x000A8B3C File Offset: 0x000A6D3C
		private void Drag_MouseDown(object sender, MouseEventArgs e)
		{
			bool flag = this._Enabled && e.Button == MouseButtons.Left;
			checked
			{
				if (flag)
				{
					this.dragging = true;
					this.mousex = e.X;
					this.mousey = e.Y;
					base.Invalidate();
					Point point = base.Parent.PointToClient(Control.MousePosition);
					int x = point.X - base.Location.X;
					int y = point.Y - base.Location.Y;
					int width = base.Parent.ClientSize.Width - base.Width;
					int height = base.Parent.ClientSize.Height - base.Height;
					Control arg_D9_0 = base.Parent;
					Rectangle r = new Rectangle(x, y, width, height);
					Cursor.Clip = arg_D9_0.RectangleToScreen(r);
				}
			}
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000A8C30 File Offset: 0x000A6E30
		private void Drag_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this._Enabled && this.dragging;
			if (flag)
			{
				base.Location = checked(new Point
				{
					X = e.X - this.mousex + base.Location.X,
					Y = e.Y - this.mousey + base.Location.Y
				});
				base.Invalidate();
			}
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x000A8CBC File Offset: 0x000A6EBC
		private void Drag_MouseUp(object sender, MouseEventArgs e)
		{
			bool enabled = this._Enabled;
			if (enabled)
			{
				this.dragging = false;
				Cursor.Clip = Rectangle.Empty;
				base.Invalidate();
			}
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x000A8CF0 File Offset: 0x000A6EF0
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CtrlStickyNote));
			this.ctrlCustomPanel1 = new CtrlCustomPanel();
			this.splitContainer1 = new CtrlStyledSplitContainer();
			this.splitContainer3 = new CtrlStyledSplitContainer();
			this.ctrlStyledPictureBox1 = new CtrlStyledPictureBox();
			this.richTextBox1 = new CtrlStyledTextBox();
			this.splitContainer2 = new CtrlStyledSplitContainer();
			this.ctrlRed = new CtrlStyledPictureBox();
			this.ctrlYellow = new CtrlStyledPictureBox();
			this.ctrlBlue = new CtrlStyledPictureBox();
			this.ctrlCustomPanel1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((ISupportInitialize)this.ctrlStyledPictureBox1).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((ISupportInitialize)this.ctrlRed).BeginInit();
			((ISupportInitialize)this.ctrlYellow).BeginInit();
			((ISupportInitialize)this.ctrlBlue).BeginInit();
			base.SuspendLayout();
			this.ctrlCustomPanel1.BackColor = Color.Gold;
			this.ctrlCustomPanel1.BackColor2 = Color.White;
			this.ctrlCustomPanel1.BorderColor = Color.Silver;
			this.ctrlCustomPanel1.BorderStyle = BorderStyle.FixedSingle;
			this.ctrlCustomPanel1.Controls.Add(this.splitContainer1);
			this.ctrlCustomPanel1.Dock = DockStyle.Fill;
			Control arg_1A5_0 = this.ctrlCustomPanel1;
			Point location = new Point(0, 0);
			arg_1A5_0.Location = location;
			this.ctrlCustomPanel1.Name = "ctrlCustomPanel1";
			Control arg_1CD_0 = this.ctrlCustomPanel1;
			Padding padding = new Padding(2);
			arg_1CD_0.Padding = padding;
			Control arg_1ED_0 = this.ctrlCustomPanel1;
			Size size = new Size(153, 142);
			arg_1ED_0.Size = size;
			this.ctrlCustomPanel1.StickyParent = null;
			this.ctrlCustomPanel1.TabIndex = 0;
			this.ctrlCustomPanel1.MouseMove += new MouseEventHandler(this.Drag_MouseMove);
			this.ctrlCustomPanel1.MouseDown += new MouseEventHandler(this.Drag_MouseDown);
			this.ctrlCustomPanel1.MouseUp += new MouseEventHandler(this.Drag_MouseUp);
			this.splitContainer1.BackColor = Color.Gold;
			this.splitContainer1.Dock = DockStyle.Fill;
			this.splitContainer1.FixedPanel = FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			Control arg_2A1_0 = this.splitContainer1;
			location = new Point(2, 2);
			arg_2A1_0.Location = location;
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = Orientation.Horizontal;
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
			this.splitContainer1.Panel2.BackColor = Color.Gold;
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Panel2.MouseMove += new MouseEventHandler(this.Drag_MouseMove);
			this.splitContainer1.Panel2.MouseDown += new MouseEventHandler(this.Drag_MouseDown);
			this.splitContainer1.Panel2.MouseUp += new MouseEventHandler(this.Drag_MouseUp);
			this.splitContainer1.Panel2MinSize = 19;
			Control arg_395_0 = this.splitContainer1;
			size = new Size(149, 138);
			arg_395_0.Size = size;
			this.splitContainer1.SplitterDistance = 115;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer3.Dock = DockStyle.Fill;
			this.splitContainer3.FixedPanel = FixedPanel.Panel1;
			this.splitContainer3.IsSplitterFixed = true;
			Control arg_3EE_0 = this.splitContainer3;
			location = new Point(0, 0);
			arg_3EE_0.Location = location;
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = Orientation.Horizontal;
			this.splitContainer3.Panel1.Controls.Add(this.ctrlStyledPictureBox1);
			Control arg_447_0 = this.splitContainer3.Panel1;
			padding = new Padding(0, 2, 2, 0);
			arg_447_0.Padding = padding;
			this.splitContainer3.Panel1.MouseMove += new MouseEventHandler(this.Drag_MouseMove);
			this.splitContainer3.Panel1.MouseDown += new MouseEventHandler(this.Drag_MouseDown);
			this.splitContainer3.Panel1.MouseUp += new MouseEventHandler(this.Drag_MouseUp);
			this.splitContainer3.Panel1MinSize = 14;
			this.splitContainer3.Panel2.Controls.Add(this.richTextBox1);
			Control arg_4E8_0 = this.splitContainer3;
			size = new Size(149, 115);
			arg_4E8_0.Size = size;
			this.splitContainer3.SplitterDistance = 14;
			this.splitContainer3.SplitterWidth = 1;
			this.splitContainer3.TabIndex = 0;
			this.ctrlStyledPictureBox1.BorderColor = Color.LightGray;
			this.ctrlStyledPictureBox1.Cursor = Cursors.Hand;
			this.ctrlStyledPictureBox1.Dock = DockStyle.Right;
			this.ctrlStyledPictureBox1.Image = Resources.delete;
			Control arg_56B_0 = this.ctrlStyledPictureBox1;
			location = new Point(135, 2);
			arg_56B_0.Location = location;
			this.ctrlStyledPictureBox1.Name = "ctrlStyledPictureBox1";
			Control arg_596_0 = this.ctrlStyledPictureBox1;
			size = new Size(12, 12);
			arg_596_0.Size = size;
			this.ctrlStyledPictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ctrlStyledPictureBox1.TabIndex = 0;
			this.ctrlStyledPictureBox1.TabStop = false;
			this.ctrlStyledPictureBox1.Click += new EventHandler(this.toolStripStatusLabel1_Click);
			this.richTextBox1.AcceptsReturn = true;
			this.richTextBox1.BackColor = Color.Gold;
			this.richTextBox1.BorderColor = Color.LightGray;
			this.richTextBox1.BorderStyle = BorderStyle.None;
			this.richTextBox1.ConvertEnterToTab = true;
			this.richTextBox1.ConvertEnterToTabForDialogs = false;
			this.richTextBox1.Dock = DockStyle.Fill;
			Control arg_650_0 = this.richTextBox1;
			location = new Point(0, 0);
			arg_650_0.Location = location;
			this.richTextBox1.Multiline = true;
			this.richTextBox1.Name = "richTextBox1";
			Control arg_68B_0 = this.richTextBox1;
			size = new Size(149, 100);
			arg_68B_0.Size = size;
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.RightToLeft = RightToLeft.Yes;
			this.richTextBox1.MouseMove += new MouseEventHandler(this.Drag_MouseMove);
			this.richTextBox1.MouseDown += new MouseEventHandler(this.Drag_MouseDown);
			this.richTextBox1.MouseUp += new MouseEventHandler(this.Drag_MouseUp);
			this.splitContainer2.BackColor = Color.Transparent;
			this.splitContainer2.Dock = DockStyle.Fill;
			this.splitContainer2.FixedPanel = FixedPanel.Panel2;
			this.splitContainer2.IsSplitterFixed = true;
			Control arg_73F_0 = this.splitContainer2;
			location = new Point(0, 0);
			arg_73F_0.Location = location;
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Panel1.Controls.Add(this.ctrlRed);
			this.splitContainer2.Panel1.Controls.Add(this.ctrlYellow);
			this.splitContainer2.Panel1.Controls.Add(this.ctrlBlue);
			this.splitContainer2.Panel1.MouseMove += new MouseEventHandler(this.Drag_MouseMove);
			this.splitContainer2.Panel1.MouseDown += new MouseEventHandler(this.Drag_MouseDown);
			this.splitContainer2.Panel1.MouseUp += new MouseEventHandler(this.Drag_MouseUp);
			this.splitContainer2.Panel1MinSize = 19;
			this.splitContainer2.Panel2.BackgroundImageLayout = ImageLayout.Center;
			this.splitContainer2.Panel2.Cursor = Cursors.SizeNWSE;
			this.splitContainer2.Panel2.MouseMove += new MouseEventHandler(this.splitContainer2_Panel2_MouseMove);
			this.splitContainer2.Panel2.MouseDown += new MouseEventHandler(this.splitContainer2_Panel2_MouseDown);
			this.splitContainer2.Panel2.MouseUp += new MouseEventHandler(this.splitContainer2_Panel2_MouseUp);
			this.splitContainer2.Panel2MinSize = 19;
			Control arg_8B9_0 = this.splitContainer2;
			size = new Size(149, 19);
			arg_8B9_0.Size = size;
			this.splitContainer2.SplitterDistance = 129;
			this.splitContainer2.SplitterWidth = 1;
			this.splitContainer2.TabIndex = 0;
			this.ctrlRed.BackColor = Color.LightCoral;
			this.ctrlRed.BorderColor = Color.Gray;
			this.ctrlRed.BorderStyle = BorderStyle.FixedSingle;
			this.ctrlRed.Cursor = Cursors.Hand;
			Control arg_93C_0 = this.ctrlRed;
			location = new Point(35, 6);
			arg_93C_0.Location = location;
			this.ctrlRed.Name = "ctrlRed";
			Control arg_967_0 = this.ctrlRed;
			size = new Size(10, 10);
			arg_967_0.Size = size;
			this.ctrlRed.TabIndex = 5;
			this.ctrlRed.TabStop = false;
			this.ctrlRed.Click += new EventHandler(this.ctrlRed_Click);
			this.ctrlYellow.BackColor = Color.Gold;
			this.ctrlYellow.BorderColor = Color.Gray;
			this.ctrlYellow.BorderStyle = BorderStyle.FixedSingle;
			this.ctrlYellow.Cursor = Cursors.Hand;
			Control arg_9F1_0 = this.ctrlYellow;
			location = new Point(3, 6);
			arg_9F1_0.Location = location;
			this.ctrlYellow.Name = "ctrlYellow";
			Control arg_A1C_0 = this.ctrlYellow;
			size = new Size(10, 10);
			arg_A1C_0.Size = size;
			this.ctrlYellow.TabIndex = 3;
			this.ctrlYellow.TabStop = false;
			this.ctrlYellow.Click += new EventHandler(this.ctrlYellow_Click);
			this.ctrlBlue.BackColor = Color.LightSteelBlue;
			this.ctrlBlue.BorderColor = Color.Gray;
			this.ctrlBlue.BorderStyle = BorderStyle.FixedSingle;
			this.ctrlBlue.Cursor = Cursors.Hand;
			Control arg_AA7_0 = this.ctrlBlue;
			location = new Point(19, 6);
			arg_AA7_0.Location = location;
			this.ctrlBlue.Name = "ctrlBlue";
			Control arg_AD2_0 = this.ctrlBlue;
			size = new Size(10, 10);
			arg_AD2_0.Size = size;
			this.ctrlBlue.TabIndex = 4;
			this.ctrlBlue.TabStop = false;
			this.ctrlBlue.Click += new EventHandler(this.ctrlBlue_Click);
			base.AutoScaleMode = AutoScaleMode.None;
			this.BackColor = Color.Gold;
			base.Controls.Add(this.ctrlCustomPanel1);
			this.DoubleBuffered = false;
			size = new Size(80, 80);
			this.MinimumSize = size;
			base.Name = "CtrlStickyNote";
			size = new Size(153, 142);
			base.Size = size;
			this.ctrlCustomPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.Panel2.PerformLayout();
			this.splitContainer3.ResumeLayout(false);
			((ISupportInitialize)this.ctrlStyledPictureBox1).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			((ISupportInitialize)this.ctrlRed).EndInit();
			((ISupportInitialize)this.ctrlYellow).EndInit();
			((ISupportInitialize)this.ctrlBlue).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x0000205D File Offset: 0x0000025D
		private void lblHideNotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000A994C File Offset: 0x000A7B4C
		private void SetDefaultControlStyles()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.UserMouse, true);
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.ContainerControl, true);
			base.UpdateStyles();
			this._CurrentColour = CtrlStickyNote.Colour.Yellow;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000A99BC File Offset: 0x000A7BBC
		private void splitContainer2_Panel2_MouseDown(object sender, MouseEventArgs e)
		{
			bool enabled = this._Enabled;
			if (enabled)
			{
				this.resizeMouseDown = true;
				this.resizemousex = e.X;
				this.resizemousey = e.Y;
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x000A99F8 File Offset: 0x000A7BF8
		private void splitContainer2_Panel2_MouseMove(object sender, MouseEventArgs e)
		{
			bool flag = this._Enabled && this.resizeMouseDown;
			checked
			{
				if (flag)
				{
					int num = e.X - this.resizemousex + base.Width;
					int num2 = e.Y - this.resizemousey + base.Height;
					flag = (num < this.MinimumSize.Width);
					if (flag)
					{
						num = this.MinimumSize.Width;
					}
					int arg_7F_0 = num2;
					Size minimumSize = this.MinimumSize;
					flag = (arg_7F_0 < minimumSize.Height);
					if (flag)
					{
						num2 = this.MinimumSize.Height;
					}
					minimumSize = new Size(num, num2);
					base.Size = minimumSize;
				}
			}
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x000A9AB0 File Offset: 0x000A7CB0
		private void splitContainer2_Panel2_MouseUp(object sender, MouseEventArgs e)
		{
			bool enabled = this._Enabled;
			if (enabled)
			{
				this.resizeMouseDown = false;
			}
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x0000205D File Offset: 0x0000025D
		private void toolStripStatusLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000EB4 RID: 3764 RVA: 0x000A9AD4 File Offset: 0x000A7CD4
		// (set) Token: 0x06000EB5 RID: 3765 RVA: 0x00005315 File Offset: 0x00003515
		public CtrlStickyNote.Colour CurrentColour
		{
			get
			{
				return this._CurrentColour;
			}
			set
			{
				this._CurrentColour = value;
				this.ChangeToColour(value);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000EB6 RID: 3766 RVA: 0x000A9AEC File Offset: 0x000A7CEC
		// (set) Token: 0x06000EB7 RID: 3767 RVA: 0x000A9B04 File Offset: 0x000A7D04
		public new bool Enabled
		{
			get
			{
				return this._Enabled;
			}
			set
			{
				this._Enabled = value;
				this.richTextBox1.Enabled = this._Enabled;
				this.splitContainer1.Panel2.Enabled = this._Enabled;
				this.ctrlBlue.Enabled = this._Enabled;
				this.ctrlRed.Enabled = this._Enabled;
				this.ctrlYellow.Enabled = this._Enabled;
				this.ctrlStyledPictureBox1.Enabled = this._Enabled;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000A9B8C File Offset: 0x000A7D8C
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00005328 File Offset: 0x00003528
		public int StickyNoteId
		{
			get
			{
				return this._StickyNoteId;
			}
			set
			{
				this._StickyNoteId = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000A9BA4 File Offset: 0x000A7DA4
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x00005333 File Offset: 0x00003533
		public override string Text
		{
			get
			{
				return this.richTextBox1.Text;
			}
			set
			{
				this.richTextBox1.Text = value;
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040005AA RID: 1450
		private CtrlStickyNote.Colour _CurrentColour;

		// Token: 0x040005AB RID: 1451
		private bool _Enabled;

		// Token: 0x040005AC RID: 1452
		private int _StickyNoteId;

		// Token: 0x040005AD RID: 1453
		private IContainer components;

		// Token: 0x040005AE RID: 1454
		private CtrlStyledPictureBox ctrlBlue;

		// Token: 0x040005AF RID: 1455
		private CtrlCustomPanel ctrlCustomPanel1;

		// Token: 0x040005B0 RID: 1456
		private CtrlStyledPictureBox ctrlRed;

		// Token: 0x040005B1 RID: 1457
		private CtrlStyledPictureBox ctrlStyledPictureBox1;

		// Token: 0x040005B2 RID: 1458
		private CtrlStyledPictureBox ctrlYellow;

		// Token: 0x040005B3 RID: 1459
		private bool dragging;

		// Token: 0x040005B4 RID: 1460
		private int mousex;

		// Token: 0x040005B5 RID: 1461
		private int mousey;

		// Token: 0x040005B6 RID: 1462
		private bool resizeMouseDown;

		// Token: 0x040005B7 RID: 1463
		private int resizemousex;

		// Token: 0x040005B8 RID: 1464
		private int resizemousey;

		// Token: 0x040005B9 RID: 1465
		private CtrlStyledTextBox richTextBox1;

		// Token: 0x040005BA RID: 1466
		private CtrlStyledSplitContainer splitContainer1;

		// Token: 0x040005BB RID: 1467
		private CtrlStyledSplitContainer splitContainer2;

		// Token: 0x040005BC RID: 1468
		private CtrlStyledSplitContainer splitContainer3;

		// Token: 0x020000B5 RID: 181
		public enum Colour
		{
			// Token: 0x040005BE RID: 1470
			Blue = 2,
			// Token: 0x040005BF RID: 1471
			Red,
			// Token: 0x040005C0 RID: 1472
			Yellow = 1
		}
	}
}
