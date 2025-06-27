using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000097 RID: 151
	[DesignerGenerated]
	public class Grid_SelectItem : UserControl
	{
		// Token: 0x06000D91 RID: 3473 RVA: 0x000A45D0 File Offset: 0x000A27D0
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Grid_SelectItem.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Grid_SelectItem.__ENCList.Count == Grid_SelectItem.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Grid_SelectItem.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Grid_SelectItem.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Grid_SelectItem.__ENCList[num] = Grid_SelectItem.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Grid_SelectItem.__ENCList.RemoveRange(num, Grid_SelectItem.__ENCList.Count - num);
						Grid_SelectItem.__ENCList.Capacity = Grid_SelectItem.__ENCList.Count;
					}
					Grid_SelectItem.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x000A46D4 File Offset: 0x000A28D4
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

		// Token: 0x06000D93 RID: 3475 RVA: 0x000A4724 File Offset: 0x000A2924
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			GridEXLayout gridEXLayout = new GridEXLayout();
			this.GridEx1 = new DataEntryGrid(this.components);
			((ISupportInitialize)this.GridEx1).BeginInit();
			this.SuspendLayout();
			this.GridEx1.AcceptsEscape = false;
			this.GridEx1.AlternatingColors = true;
			this.GridEx1.AutoEdit = true;
			gridEXLayout.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><GroupCondition /><RowHeight>23</RowHeight><TotalRow>False</TotalRow></RootTable></GridEXLayoutData>";
			this.GridEx1.DesignTimeLayout = gridEXLayout;
			this.GridEx1.Dock = DockStyle.Fill;
			this.GridEx1.EnterKeyBehavior = EnterKeyBehavior.None;
			this.GridEx1.FocusStyle = FocusStyle.Solid;
			this.GridEx1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			this.GridEx1.GridLineStyle = GridLineStyle.Solid;
			this.GridEx1.GroupByBoxVisible = false;
			Control arg_EB_0 = this.GridEx1;
			Point location = new Point(0, 0);
			arg_EB_0.Location = location;
			this.GridEx1.Name = "GridEx1";
			this.GridEx1.NewRowPosition = NewRowPosition.BottomRow;
			this.GridEx1.OfficeColorScheme = OfficeColorScheme.Blue;
			this.GridEx1.RowHeaders = InheritableBoolean.True;
			Control arg_143_0 = this.GridEx1;
			Size size = new Size(740, 249);
			arg_143_0.Size = size;
			this.GridEx1.TabIndex = 16;
			this.GridEx1.TotalRow = InheritableBoolean.True;
			this.GridEx1.TotalRowFormatStyle.BackColor = Color.AliceBlue;
			this.GridEx1.TotalRowFormatStyle.BackColorGradient = Color.DarkTurquoise;
			this.GridEx1.TotalRowFormatStyle.BackgroundGradientMode = BackgroundGradientMode.Vertical;
			this.GridEx1.TotalRowPosition = TotalRowPosition.BottomFixed;
			this.GridEx1.UpdateMode = UpdateMode.CellUpdate;
			this.GridEx1.VisualStyle = VisualStyle.Office2010;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.GridEx1);
			this.Name = "Grid_SelectItem";
			this.RightToLeft = RightToLeft.Yes;
			size = new Size(740, 249);
			this.Size = size;
			((ISupportInitialize)this.GridEx1).EndInit();
			this.ResumeLayout(false);
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x000A4974 File Offset: 0x000A2B74
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x00004CF9 File Offset: 0x00002EF9
		internal virtual DataEntryGrid GridEx1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEx1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEx1 = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000A498C File Offset: 0x000A2B8C
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00004D03 File Offset: 0x00002F03
		public ToolStripDropDown DropDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DropDown;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DropDown = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000A49A4 File Offset: 0x000A2BA4
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00004D0D File Offset: 0x00002F0D
		public CollectionBase items
		{
			[DebuggerNonUserCode]
			get
			{
				return this._items;
			}
			[DebuggerNonUserCode]
			set
			{
				this._items = value;
			}
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000A49BC File Offset: 0x000A2BBC
		private void InitGrid(DataTable dt)
		{
			string text = string.Empty;
			DataColumn dataColumn = new DataColumn("filter", typeof(string));
			bool flag = !dt.Columns.Contains("filter");
			if (flag)
			{
				dt.Columns.Add(dataColumn);
			}
			this.GridEx1.DataSource = dt.DefaultView;
			this.GridEx1.RetrieveStructure();
			try
			{
				IEnumerator enumerator = this.GridEx1.RootTable.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
					gridEXColumn.Visible = false;
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
			int num = 0;
			checked
			{
				int num2 = this.GridEx1.Width - this.GridEx1.ScrollBarWidth - this.GridEx1.RootTable.RowHeaderWidth - 2;
				try
				{
					IEnumerator enumerator2 = this.items.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						Column column = (Column)enumerator2.Current;
						flag = !this.GridEx1.RootTable.Columns.Contains(column.Name);
						if (!flag)
						{
							this.GridEx1.RootTable.Columns[column.Name].Visible = true;
							this.GridEx1.RootTable.Columns[column.Name].Caption = column.Caption;
							this.GridEx1.RootTable.Columns[column.Name].Width = (int)Math.Round(unchecked((double)num2 / 100.0 * (double)column.Size));
							this.GridEx1.RootTable.Columns[column.Name].Position = num;
							this.GridEx1.RootTable.Columns[column.Name].FormatString = "N0";
							num++;
							text = text + column.Name + "+";
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
				text = Public_Function.RemoveLast(text);
				dataColumn.Expression = text;
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000A4C6C File Offset: 0x000A2E6C
		private void ApplyFont(Control frm)
		{
			string left = Public_Function.dict["textfont"].ToString().Split(new char[]
			{
				';'
			})[2];
			bool flag = Operators.CompareString(left, "regular", false) == 0;
			int style;
			if (flag)
			{
				style = 0;
			}
			else
			{
				flag = (Operators.CompareString(left, "bold", false) == 0);
				if (flag)
				{
					style = 1;
				}
				else
				{
					flag = (Operators.CompareString(left, "italic", false) == 0);
					if (flag)
					{
						style = 2;
					}
				}
			}
			try
			{
				IEnumerator enumerator = frm.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control = (Control)enumerator.Current;
					flag = (control is NavBox);
					if (flag)
					{
						((NavBox)control).NumericBox1.Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is SelectItem);
					if (flag)
					{
						((SelectItem)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is EditBox);
					if (flag)
					{
						((EditBox)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is DateBox2);
					if (flag)
					{
						((DateBox2)control).Font = new Font(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["textfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
					}
					flag = (control is GridEX);
					if (flag)
					{
						((GridEX)control).Font = new Font(Public_Function.dict["gridfont"].ToString().Split(new char[]
						{
							';'
						})[0], Conversions.ToSingle(Public_Function.dict["gridfont"].ToString().Split(new char[]
						{
							';'
						})[1]), (FontStyle)style, GraphicsUnit.Point);
						int cellAscent = ((GridEX)control).Font.FontFamily.GetCellAscent(FontStyle.Regular);
						decimal d = new decimal(this.Font.Size * (float)cellAscent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						int cellDescent = ((GridEX)control).Font.FontFamily.GetCellDescent(FontStyle.Regular);
						decimal d2 = new decimal(this.Font.Size * (float)cellDescent / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						int lineSpacing = ((GridEX)control).Font.FontFamily.GetLineSpacing(FontStyle.Regular);
						decimal d3 = new decimal(this.Font.Size * (float)lineSpacing / (float)((GridEX)control).Font.FontFamily.GetEmHeight(FontStyle.Regular));
						flag = (decimal.Compare(new decimal(((GridEX)control).RootTable.RowHeight), decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L))) < 0);
						if (flag)
						{
							((GridEX)control).RootTable.RowHeight = Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(d, d2), d2), d2), d3), new decimal(2L)));
						}
					}
					flag = (frm.Controls.Count > 0);
					if (flag)
					{
						this.ApplyFont(control);
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
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x000A516C File Offset: 0x000A336C
		public void RowFilter(string filter)
		{
			DataView dataView = (DataView)this.GridEx1.DataSource;
			bool flag = Operators.CompareString(filter, string.Empty, false) == 0;
			if (flag)
			{
				dataView.RowFilter = "";
			}
			else
			{
				dataView.RowFilter = "filter LIKE '%" + filter + "%'";
				this.GridEx1.Refetch();
				Public_Function.HighlightCell(this.GridEx1, filter);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00004D17 File Offset: 0x00002F17
		public Grid_SelectItem()
		{
			base.Load += new EventHandler(this.Grid_SelectItem_Load);
			Grid_SelectItem.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000A51E0 File Offset: 0x000A33E0
		private void Grid_SelectItem_Load(object sender, EventArgs e)
		{
			string text = string.Empty;
			bool flag = !Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag)
			{
				text = " where moshtari.id not in (-3";
			}
			flag = (Operators.CompareString(text, string.Empty, false) == 0);
			if (flag)
			{
				text = " where moshtari.id not in (-4,-5)";
			}
			else
			{
				text += " ,-4,-5)";
			}
			DataTable dataTable = Public_Function.FillData("SELECT     Moshtari.ID,Moshtari.Code, Moshtari.Name + ' ' + Moshtari.Family AS name, case when GrouhMoshtari_ID is null then isnull(Grouh_Moshtari2.Name,'') else isnull(Grouh_Moshtari.Name,'') end AS Shahr FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID " + text + " order by moshtari.code ");
			this.GridEx1.DataSource = dataTable;
			this.ApplyFont(this);
			this.InitGrid(dataTable);
		}

		// Token: 0x0400053E RID: 1342
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400053F RID: 1343
		private IContainer components;

		// Token: 0x04000540 RID: 1344
		[AccessedThroughProperty("GridEx1")]
		private DataEntryGrid _GridEx1;

		// Token: 0x04000541 RID: 1345
		[CompilerGenerated]
		private ToolStripDropDown _DropDown;

		// Token: 0x04000542 RID: 1346
		[CompilerGenerated]
		private CollectionBase _items;
	}
}
