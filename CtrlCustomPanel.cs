using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace FruitBox
{
	// Token: 0x020000B1 RID: 177
	public class CtrlCustomPanel : Panel, IStickyControl
	{
		// Token: 0x06000E73 RID: 3699 RVA: 0x000A76D0 File Offset: 0x000A58D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = CtrlCustomPanel.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = CtrlCustomPanel.__ENCList.Count == CtrlCustomPanel.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = CtrlCustomPanel.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = CtrlCustomPanel.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									CtrlCustomPanel.__ENCList[num] = CtrlCustomPanel.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						CtrlCustomPanel.__ENCList.RemoveRange(num, CtrlCustomPanel.__ENCList.Count - num);
						CtrlCustomPanel.__ENCList.Capacity = CtrlCustomPanel.__ENCList.Count;
					}
					CtrlCustomPanel.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x000A77D4 File Offset: 0x000A59D4
		[DebuggerNonUserCode]
		public CtrlCustomPanel(IContainer container) : this()
		{
			bool flag = container != null;
			if (flag)
			{
				container.Add(this);
			}
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000A7800 File Offset: 0x000A5A00
		[DebuggerNonUserCode]
		public CtrlCustomPanel()
		{
			CtrlCustomPanel.__ENCAddToList(this);
			this._BackColour2 = Color.White;
			this._BorderColour = SystemColors.WindowFrame;
			this._BorderWidth = 1;
			this._CurveMode = CtrlCustomPanel_CornerCurveMode.All;
			this._GradientMode = CtrlCustomPanel_LinearGradientMode.None;
			this.InitializeComponent();
			this.SetDefaultControlStyles();
			this.BorderStyle = BorderStyle.None;
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x000A7860 File Offset: 0x000A5A60
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

		// Token: 0x06000E77 RID: 3703 RVA: 0x00005251 File Offset: 0x00003451
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000A78B0 File Offset: 0x000A5AB0
		private LinearGradientBrush CreateGlassGradientBrush(Rectangle Rectangle, Color Color1, Color Color2)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None;
			LinearGradientBrush linearGradientBrush;
			if (flag)
			{
				linearGradientBrush = new LinearGradientBrush(Rectangle, Color1, Color2, (LinearGradientMode)this._GradientMode);
			}
			else
			{
				linearGradientBrush = new LinearGradientBrush(Rectangle, Color1, Color2, (LinearGradientMode)this._GradientMode);
			}
			Bitmap bitmap = new Bitmap(1, Rectangle.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			Graphics arg_61_0 = graphics;
			Brush arg_61_1 = linearGradientBrush;
			Rectangle rect = new Rectangle(0, 0, 1, Rectangle.Height);
			arg_61_0.FillRectangle(arg_61_1, rect);
			ColorBlend colorBlend = new ColorBlend(4);
			colorBlend.Colors[0] = bitmap.GetPixel(0, 0);
			checked
			{
				colorBlend.Colors[1] = bitmap.GetPixel(0, (int)Math.Round((double)bitmap.Height / 3.0));
				colorBlend.Colors[2] = bitmap.GetPixel(0, bitmap.Height - 1);
				colorBlend.Colors[3] = bitmap.GetPixel(0, (int)Math.Round((double)bitmap.Height / 3.0));
				colorBlend.Positions[0] = 0f;
				colorBlend.Positions[1] = 0.335f;
				colorBlend.Positions[2] = 0.335f;
				colorBlend.Positions[3] = 1f;
				linearGradientBrush.InterpolationColors = colorBlend;
				graphics.Dispose();
				bitmap.Dispose();
				return linearGradientBrush;
			}
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00005260 File Offset: 0x00003460
		public void DeleteSticky(CtrlStickyNote toDelete)
		{
			this.StickyManager.DeleteSticky(toDelete, this);
			this.StickyParent.RefreshStickyDisplay();
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x000A7A1C File Offset: 0x000A5C1C
		public static int DoubleToInt(double value)
		{
			return decimal.ToInt32(decimal.Floor(decimal.Parse(value.ToString())));
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x000A7A44 File Offset: 0x000A5C44
		private void DrawCurvedPanel(PaintEventArgs pevent)
		{
			pevent.Graphics.Clear(this.GetColorBehindCurve());
			pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			pevent.Graphics.InterpolationMode = InterpolationMode.High;
			pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			GraphicsPath curvedPath = this.GetCurvedPath();
			Brush backgroundBrush = this.GetBackgroundBrush(pevent);
			pevent.Graphics.FillPath(backgroundBrush, curvedPath);
			backgroundBrush.Dispose();
			bool flag = this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0;
			if (flag)
			{
				Pen borderPen = this.GetBorderPen(this._BorderColour, this._BorderWidth);
				pevent.Graphics.DrawPath(borderPen, curvedPath);
				borderPen.Dispose();
			}
			curvedPath.Dispose();
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x000A7B08 File Offset: 0x000A5D08
		private void DrawRectPanel(PaintEventArgs pevent)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None || this.BackColor == this._BackColour2;
			if (flag)
			{
				pevent.Graphics.CompositingQuality = CompositingQuality.Invalid;
				pevent.Graphics.InterpolationMode = InterpolationMode.Low;
				pevent.Graphics.PixelOffsetMode = PixelOffsetMode.None;
				pevent.Graphics.SmoothingMode = SmoothingMode.None;
			}
			else
			{
				pevent.Graphics.CompositingQuality = CompositingQuality.HighQuality;
				pevent.Graphics.InterpolationMode = InterpolationMode.High;
				pevent.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				pevent.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			}
			Brush backgroundBrush = this.GetBackgroundBrush(pevent);
			pevent.Graphics.FillRectangle(backgroundBrush, base.ClientRectangle);
			backgroundBrush.Dispose();
			flag = (this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0);
			checked
			{
				if (flag)
				{
					Pen borderPen = this.GetBorderPen(this._BorderColour, this._BorderWidth);
					Point location = base.ClientRectangle.Location;
					location.X = (int)Math.Round(unchecked((double)location.X + (double)this._BorderWidth / 2.0));
					location.Y = (int)Math.Round(unchecked((double)location.Y + (double)this._BorderWidth / 2.0));
					Size size = base.ClientRectangle.Size;
					size.Width -= this._BorderWidth;
					size.Height -= this._BorderWidth;
					Rectangle rect = new Rectangle(location, size);
					pevent.Graphics.DrawRectangle(borderPen, rect);
					borderPen.Dispose();
				}
			}
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x000A7CC0 File Offset: 0x000A5EC0
		private int GetAdjustedCurve()
		{
			bool flag = this._CurveMode == CtrlCustomPanel_CornerCurveMode.None || this._Curvature == 0;
			int result;
			if (flag)
			{
				result = 0;
			}
			else
			{
				int num = 0;
				flag = ((double)this._Curvature > (double)base.ClientRectangle.Width / 2.0);
				if (flag)
				{
					result = CtrlCustomPanel.DoubleToInt((double)base.ClientRectangle.Width / 2.0);
				}
				else
				{
					flag = ((double)num > (double)base.ClientRectangle.Height / 2.0);
					if (flag)
					{
						result = CtrlCustomPanel.DoubleToInt((double)base.ClientRectangle.Height / 2.0);
					}
					else
					{
						result = this._Curvature;
					}
				}
			}
			return result;
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x000A7D90 File Offset: 0x000A5F90
		private Brush GetBackgroundBrush(PaintEventArgs pevent)
		{
			bool flag = this._GradientMode == CtrlCustomPanel_LinearGradientMode.None || this.BackColor == this._BackColour2;
			Brush result;
			if (flag)
			{
				result = new SolidBrush(this.BackColor);
			}
			else
			{
				flag = !this._useGlassGradient;
				if (flag)
				{
					result = new LinearGradientBrush(base.ClientRectangle, this.BackColor, this._BackColour2, (LinearGradientMode)this._GradientMode);
				}
				else
				{
					result = this.CreateGlassGradientBrush(base.ClientRectangle, this.BackColor, this._BackColour2);
				}
			}
			return result;
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x000A7E1C File Offset: 0x000A601C
		private Pen GetBorderPen(Color borderColor, int borderWidth)
		{
			return new Pen(borderColor, (float)borderWidth);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x000A7E38 File Offset: 0x000A6038
		private Color GetColorBehindCurve()
		{
			Control parent = base.Parent;
			while (parent != null && parent.BackColor == Color.Transparent)
			{
				parent = parent.Parent;
			}
			bool flag = parent == null;
			Color result;
			if (flag)
			{
				result = Color.Transparent;
			}
			else
			{
				result = parent.BackColor;
			}
			return result;
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x000A7E90 File Offset: 0x000A6090
		protected GraphicsPath GetCurvedPath()
		{
			Rectangle clientRectangle = base.ClientRectangle;
			int adjustedCurve = this.GetAdjustedCurve();
			int num = 0;
			bool flag = this._BorderStyle == BorderStyle.FixedSingle;
			if (flag)
			{
				bool flag2 = this._BorderWidth > 1;
				if (flag2)
				{
					num = CtrlCustomPanel.DoubleToInt((double)this.BorderWidth / 2.0);
				}
				else
				{
					flag2 = (this._BorderWidth == 1);
					if (flag2)
					{
						num = 1;
					}
				}
			}
			checked
			{
				int num2 = clientRectangle.Width - 1 - num;
				int num3 = clientRectangle.Height - 1 - num;
				GraphicsPath graphicsPath = new GraphicsPath();
				bool flag2 = (this._CurveMode & CtrlCustomPanel_CornerCurveMode.TopRight) != CtrlCustomPanel_CornerCurveMode.None;
				int num4;
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num2 - num4, num, num4, num4, 270f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.BottomRight) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num2 - num4, num3 - num4, num4, num4, 0f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.BottomLeft) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num, num3 - num4, num4, num4, 90f, 90f);
				flag2 = ((this._CurveMode & CtrlCustomPanel_CornerCurveMode.TopLeft) != CtrlCustomPanel_CornerCurveMode.None);
				if (flag2)
				{
					num4 = adjustedCurve * 2;
				}
				else
				{
					num4 = 1;
				}
				graphicsPath.AddArc(num, num, num4, num4, 180f, 90f);
				graphicsPath.CloseFigure();
				return graphicsPath;
			}
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x000A8024 File Offset: 0x000A6224
		public Point GetParentFormLocation()
		{
			return this.GetParentFormLocation(this);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x000A8040 File Offset: 0x000A6240
		private Point GetParentFormLocation(Control c)
		{
			bool flag = c is Form;
			checked
			{
				Point result;
				if (flag)
				{
					result = c.Location;
				}
				else
				{
					flag = (c is SplitterPanel);
					if (flag)
					{
						result = this.GetParentFormLocation(c.Parent);
					}
					else
					{
						flag = (c is SplitContainer);
						if (flag)
						{
							Point parentFormLocation = this.GetParentFormLocation(c.Parent);
							parentFormLocation.X += c.Location.X;
							parentFormLocation.Y += c.Location.Y;
							SplitContainer splitContainer = (SplitContainer)c;
							flag = (splitContainer.Orientation == Orientation.Horizontal);
							if (flag)
							{
								bool flag2 = splitContainer.Panel2 == c;
								if (flag2)
								{
									parentFormLocation.Y += splitContainer.SplitterDistance;
									parentFormLocation.Y += splitContainer.SplitterWidth;
								}
								result = parentFormLocation;
							}
							else
							{
								bool flag2 = splitContainer.Panel2 == c;
								if (flag2)
								{
									parentFormLocation.X += splitContainer.SplitterDistance;
									parentFormLocation.X += splitContainer.SplitterWidth;
								}
								result = parentFormLocation;
							}
						}
						else
						{
							Point parentFormLocation2 = this.GetParentFormLocation(c.Parent);
							parentFormLocation2.X += c.Location.X;
							parentFormLocation2.Y += c.Location.Y;
							result = parentFormLocation2;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x000A81D4 File Offset: 0x000A63D4
		public Point GetScreenLocation()
		{
			Point screenLocation = this.GetScreenLocation(this);
			checked
			{
				screenLocation.X += base.Padding.Left;
				screenLocation.Y += base.Padding.Top;
				bool flag = this.BorderStyle == BorderStyle.FixedSingle;
				if (flag)
				{
					screenLocation.X += this.BorderWidth;
					screenLocation.Y += this.BorderWidth;
				}
				return screenLocation;
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x000A8268 File Offset: 0x000A6468
		private Point GetScreenLocation(Control c)
		{
			bool flag = c is Form;
			checked
			{
				Point result;
				if (flag)
				{
					Point location = c.Location;
					location.Y += 25;
					result = location;
				}
				else
				{
					flag = (c is SplitterPanel);
					if (flag)
					{
						Point screenLocation = this.GetScreenLocation(c.Parent);
						SplitContainer splitContainer = (SplitContainer)c.Parent;
						flag = (splitContainer.Orientation == Orientation.Vertical);
						if (flag)
						{
							bool flag2 = splitContainer.Panel2 == c && !splitContainer.Panel1Collapsed;
							if (flag2)
							{
								screenLocation.X += splitContainer.SplitterDistance;
								screenLocation.X += splitContainer.SplitterWidth;
								screenLocation.X += ((SplitterPanel)c).Padding.Left;
							}
							result = screenLocation;
						}
						else
						{
							bool flag2 = splitContainer.Panel2 == c && !splitContainer.Panel1Collapsed;
							if (flag2)
							{
								screenLocation.Y += splitContainer.SplitterDistance;
								screenLocation.Y += splitContainer.SplitterWidth;
								screenLocation.Y += ((SplitterPanel)c).Padding.Top;
							}
							result = screenLocation;
						}
					}
					else
					{
						bool flag2 = c is CtrlCustomPanel;
						if (flag2)
						{
							Point screenLocation2 = this.GetScreenLocation(c.Parent);
							screenLocation2.X += c.Location.X;
							screenLocation2.Y += c.Location.Y;
							flag2 = (((CtrlCustomPanel)c).BorderStyle == BorderStyle.FixedSingle);
							if (flag2)
							{
								screenLocation2.X += ((CtrlCustomPanel)c).BorderWidth;
								screenLocation2.Y += ((CtrlCustomPanel)c).BorderWidth;
							}
							result = screenLocation2;
						}
						else
						{
							Point screenLocation3 = this.GetScreenLocation(c.Parent);
							screenLocation3.X += c.Location.X;
							screenLocation3.Y += c.Location.Y;
							result = screenLocation3;
						}
					}
				}
				return result;
			}
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0000527E File Offset: 0x0000347E
		public void HideAllStickies()
		{
			this.StickyManager.IsShowingStickies = false;
			this.RefreshStickyDisplay();
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000A84CC File Offset: 0x000A66CC
		private bool IsNormalPanel()
		{
			bool flag = this._CurveMode != CtrlCustomPanel_CornerCurveMode.None && this._Curvature > 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (this._BorderStyle == BorderStyle.FixedSingle && this._BorderWidth > 0);
				if (flag)
				{
					result = false;
				}
				else
				{
					flag = (this.BackColor != this._BackColour2 && this._GradientMode != CtrlCustomPanel_LinearGradientMode.None);
					result = !flag;
				}
			}
			return result;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000A854C File Offset: 0x000A674C
		public void MoveTop(int targetTop)
		{
			checked
			{
				int num = targetTop - base.Top;
				base.Top = targetTop;
				base.Height -= num;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000A857C File Offset: 0x000A677C
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			bool flag = this.IsNormalPanel();
			if (flag)
			{
				base.OnPaintBackground(pevent);
			}
			else
			{
				flag = (this._CurveMode == CtrlCustomPanel_CornerCurveMode.None || this._Curvature == 0);
				if (flag)
				{
					this.DrawRectPanel(pevent);
				}
				else
				{
					this.DrawCurvedPanel(pevent);
				}
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00005296 File Offset: 0x00003496
		public void RefreshStickyDisplay()
		{
			this.StickyParent.RefreshStickyDisplay();
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x000052A6 File Offset: 0x000034A6
		public void ScrollPanel(MouseEventArgs e)
		{
			this.OnMouseWheel(e);
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x000A85D0 File Offset: 0x000A67D0
		private void SetDefaultControlStyles()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.SetStyle(ControlStyles.UserMouse, true);
			base.SetStyle(ControlStyles.DoubleBuffer, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			base.SetStyle(ControlStyles.ContainerControl, true);
			base.UpdateStyles();
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x000A862C File Offset: 0x000A682C
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x000A8644 File Offset: 0x000A6844
		[Category("Appearance"), Description("The secondary background color used to paint the control."), DefaultValue(typeof(Color), "Window")]
		public Color BackColor2
		{
			get
			{
				return this._BackColour2;
			}
			set
			{
				this._BackColour2 = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000A866C File Offset: 0x000A686C
		// (set) Token: 0x06000E90 RID: 3728 RVA: 0x000A8684 File Offset: 0x000A6884
		[Category("Appearance"), Description("The border color used to paint the control."), DefaultValue(typeof(Color), "WindowFrame")]
		public Color BorderColor
		{
			get
			{
				return this._BorderColour;
			}
			set
			{
				this._BorderColour = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x000A86AC File Offset: 0x000A68AC
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000A86C4 File Offset: 0x000A68C4
		[Description("The border style used to paint the control."), DefaultValue(typeof(BorderStyle), "None"), Category("Appearance")]
		public new BorderStyle BorderStyle
		{
			get
			{
				return this._BorderStyle;
			}
			set
			{
				this._BorderStyle = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x000A86EC File Offset: 0x000A68EC
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x000A8704 File Offset: 0x000A6904
		[Description("The width of the border used to paint the control."), DefaultValue(typeof(int), "1"), Category("Appearance")]
		public int BorderWidth
		{
			get
			{
				return this._BorderWidth;
			}
			set
			{
				this._BorderWidth = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x000A872C File Offset: 0x000A692C
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x000A8744 File Offset: 0x000A6944
		[Description("The radius of the curve used to paint the corners of the control."), Category("Appearance"), DefaultValue(typeof(int), "0")]
		public int Curvature
		{
			get
			{
				return this._Curvature;
			}
			set
			{
				this._Curvature = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x000A876C File Offset: 0x000A696C
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x000A8784 File Offset: 0x000A6984
		[DefaultValue(typeof(CtrlCustomPanel_CornerCurveMode), "All"), Category("Appearance"), Description("The style of the curves to be drawn on the control.")]
		public CtrlCustomPanel_CornerCurveMode CurveMode
		{
			get
			{
				return this._CurveMode;
			}
			set
			{
				this._CurveMode = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x000A87AC File Offset: 0x000A69AC
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x000A87C4 File Offset: 0x000A69C4
		[DefaultValue(typeof(CtrlCustomPanel_LinearGradientMode), "None"), Description("The gradient direction used to paint the control."), Category("Appearance")]
		public CtrlCustomPanel_LinearGradientMode GradientMode
		{
			get
			{
				return this._GradientMode;
			}
			set
			{
				this._GradientMode = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x000A87EC File Offset: 0x000A69EC
		public StickyManager StickyManager
		{
			get
			{
				bool flag = this._stickyManager == null;
				if (flag)
				{
					this._stickyManager = new StickyManager();
				}
				return this._stickyManager;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x000A8820 File Offset: 0x000A6A20
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x000052B2 File Offset: 0x000034B2
		public IStickyControl StickyParent
		{
			get
			{
				return this._stickyParent;
			}
			set
			{
				this._stickyParent = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x000A8838 File Offset: 0x000A6A38
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x000A8850 File Offset: 0x000A6A50
		[DefaultValue(typeof(bool), "false"), Category("Appearance"), Description("To call base.PaintBackround or not.")]
		public bool UseBasePaintFirst
		{
			get
			{
				return this._useBasePaintFirst;
			}
			set
			{
				this._useBasePaintFirst = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x000A8878 File Offset: 0x000A6A78
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x000A8890 File Offset: 0x000A6A90
		[DefaultValue(typeof(bool), "false"), Description("To use glass effect gradient or not."), Category("Appearance")]
		public bool UseGlassGradient
		{
			get
			{
				return this._useGlassGradient;
			}
			set
			{
				this._useGlassGradient = value;
				bool designMode = base.DesignMode;
				if (designMode)
				{
					base.Invalidate();
				}
			}
		}

		// Token: 0x04000585 RID: 1413
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000586 RID: 1414
		private IContainer components;

		// Token: 0x04000587 RID: 1415
		private Color _BackColour2;

		// Token: 0x04000588 RID: 1416
		private Color _BorderColour;

		// Token: 0x04000589 RID: 1417
		private BorderStyle _BorderStyle;

		// Token: 0x0400058A RID: 1418
		private int _BorderWidth;

		// Token: 0x0400058B RID: 1419
		private int _Curvature;

		// Token: 0x0400058C RID: 1420
		private CtrlCustomPanel_CornerCurveMode _CurveMode;

		// Token: 0x0400058D RID: 1421
		private CtrlCustomPanel_LinearGradientMode _GradientMode;

		// Token: 0x0400058E RID: 1422
		private bool _useBasePaintFirst;

		// Token: 0x0400058F RID: 1423
		private bool _useGlassGradient;

		// Token: 0x04000590 RID: 1424
		private StickyManager _stickyManager;

		// Token: 0x04000591 RID: 1425
		private IStickyControl _stickyParent;
	}
}
