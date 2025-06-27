using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Components.TextFormats;

namespace FruitBox
{
	// Token: 0x02000086 RID: 134
	public class GridPrint
	{
		// Token: 0x06000BD6 RID: 3030 RVA: 0x0009369C File Offset: 0x0009189C
		public GridPrint()
		{
			double elementheight = 0.2;
			this.elementheight = elementheight;
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x000936C4 File Offset: 0x000918C4
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x000046B5 File Offset: 0x000028B5
		public string ReportTitle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ReportTitle;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ReportTitle = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x000936DC File Offset: 0x000918DC
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x000046BF File Offset: 0x000028BF
		public GridEX Grid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Grid = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x000936F4 File Offset: 0x000918F4
		public int GridWidth
		{
			get
			{
				return this._GridWidth;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x0009370C File Offset: 0x0009190C
		public double PageLeft
		{
			get
			{
				return this.Report.Pages[0].Width;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000BDD RID: 3037 RVA: 0x00093734 File Offset: 0x00091934
		// (set) Token: 0x06000BDE RID: 3038 RVA: 0x000046C9 File Offset: 0x000028C9
		public StiReport Report
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Report;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Report = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0009374C File Offset: 0x0009194C
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x000046D3 File Offset: 0x000028D3
		public StiReportTitleBand TitleBand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TitleBand;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TitleBand = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x00093764 File Offset: 0x00091964
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x000046DD File Offset: 0x000028DD
		public StiHeaderBand HeaderBand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HeaderBand;
			}
			[DebuggerNonUserCode]
			set
			{
				this._HeaderBand = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000BE3 RID: 3043 RVA: 0x0009377C File Offset: 0x0009197C
		// (set) Token: 0x06000BE4 RID: 3044 RVA: 0x000046E7 File Offset: 0x000028E7
		public StiDataBand DataBand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataBand;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DataBand = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000BE5 RID: 3045 RVA: 0x00093794 File Offset: 0x00091994
		// (set) Token: 0x06000BE6 RID: 3046 RVA: 0x000046F1 File Offset: 0x000028F1
		public StiFooterBand FooterBand
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FooterBand;
			}
			[DebuggerNonUserCode]
			set
			{
				this._FooterBand = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000BE7 RID: 3047 RVA: 0x000937AC File Offset: 0x000919AC
		// (set) Token: 0x06000BE8 RID: 3048 RVA: 0x000046FB File Offset: 0x000028FB
		public StiGroupHeaderBand GroupHeader
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupHeader;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GroupHeader = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000BE9 RID: 3049 RVA: 0x000937C4 File Offset: 0x000919C4
		// (set) Token: 0x06000BEA RID: 3050 RVA: 0x00004705 File Offset: 0x00002905
		public StiGroupFooterBand GroupFooter
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GroupFooter;
			}
			[DebuggerNonUserCode]
			set
			{
				this._GroupFooter = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000BEB RID: 3051 RVA: 0x000937DC File Offset: 0x000919DC
		// (set) Token: 0x06000BEC RID: 3052 RVA: 0x0000470F File Offset: 0x0000290F
		public double elementheight
		{
			[DebuggerNonUserCode]
			get
			{
				return this._elementheight;
			}
			[DebuggerNonUserCode]
			set
			{
				this._elementheight = value;
			}
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000937F4 File Offset: 0x000919F4
		private int GetGridWidth()
		{
			bool flag = this.Grid.RootTable.ColumnSets.Count == 0;
			checked
			{
				int num;
				if (flag)
				{
					try
					{
						IEnumerator enumerator = this.Grid.RootTable.Columns.GetEnumerator();
						while (enumerator.MoveNext())
						{
							GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
							bool flag2 = gridEXColumn.Visible;
							if (flag2)
							{
								num += gridEXColumn.Width;
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
				else
				{
					try
					{
						IEnumerator enumerator2 = this.Grid.RootTable.ColumnSets.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							GridEXColumnSet gridEXColumnSet = (GridEXColumnSet)enumerator2.Current;
							bool flag2 = gridEXColumnSet.Visible;
							if (flag2)
							{
								num += gridEXColumnSet.Width;
							}
						}
					}
					finally
					{
						IEnumerator enumerator2;
						bool flag2 = enumerator2 is IDisposable;
						if (flag2)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
				return num;
			}
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x00093928 File Offset: 0x00091B28
		private void SetReportDatasource()
		{
			bool flag = this.Grid.DataSource is DataTable;
			DataTable dataTable;
			if (flag)
			{
				dataTable = (DataTable)this.Grid.DataSource;
			}
			flag = (this.Grid.DataSource is BindingSource);
			if (flag)
			{
				dataTable = (DataTable)((BindingSource)this.Grid.DataSource).DataSource;
			}
			dataTable.TableName = "Data";
			this.Report.RegData(dataTable);
			this.Report.Dictionary.Synchronize();
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000939C0 File Offset: 0x00091BC0
		private void CreateTitleBand()
		{
			RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, 0.6);
			this.TitleBand = new StiReportTitleBand(rect);
			this.TitleBand.Name = "titleband";
			this.TitleBand.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
			this.Report.Pages[0].Components.Add(this.TitleBand);
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00093A6C File Offset: 0x00091C6C
		private void CreateTitleText()
		{
			RectangleD rect = new RectangleD(0.0, 0.0, this.PageLeft, this.elementheight);
			StiText stiText = new StiText(rect, Public_Function.CurrentData.CompanyName);
			stiText.Name = "head1";
			stiText.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText.TextOptions.RightToLeft = true;
			stiText.VertAlignment = StiVertAlignment.Center;
			stiText.HorAlignment = StiTextHorAlignment.Center;
			this.TitleBand.Components.Add(stiText);
			rect = new RectangleD(this.PageLeft - 1.0, 0.4, 1.0, this.elementheight);
			StiText stiText2 = new StiText(rect, "تاریخ تنظیم");
			stiText2.Name = "titletxt1";
			stiText2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText2.TextOptions.RightToLeft = true;
			stiText2.VertAlignment = StiVertAlignment.Center;
			stiText2.HorAlignment = StiTextHorAlignment.Center;
			this.TitleBand.Components.Add(stiText2);
			rect = new RectangleD(this.PageLeft - 1.0 - 1.0, 0.4, 1.0, this.elementheight);
			StiText stiText3 = new StiText(rect, Public_Function.MiladiToShamsi(DateAndTime.Now));
			stiText3.Name = "titletxt4";
			stiText3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText3.TextOptions.RightToLeft = true;
			stiText3.VertAlignment = StiVertAlignment.Center;
			stiText3.HorAlignment = StiTextHorAlignment.Center;
			this.TitleBand.Components.Add(stiText3);
			rect = new RectangleD(0.0, 0.2, this.PageLeft, this.elementheight);
			StiText stiText4 = new StiText(rect, this.ReportTitle);
			stiText4.Name = "head2";
			stiText4.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText4.TextOptions.RightToLeft = true;
			stiText4.VertAlignment = StiVertAlignment.Center;
			stiText4.HorAlignment = StiTextHorAlignment.Center;
			this.TitleBand.Components.Add(stiText4);
			rect = new RectangleD(0.0, 0.4, this.PageLeft, this.elementheight);
			StiText stiText5 = new StiText(rect, this.ReportTitle);
			stiText5.Name = "head3";
			stiText5.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText5.TextOptions.RightToLeft = true;
			stiText5.VertAlignment = StiVertAlignment.Center;
			stiText5.HorAlignment = StiTextHorAlignment.Center;
			this.TitleBand.Components.Add(stiText5);
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00093D50 File Offset: 0x00091F50
		private void CreateColumnHeaders()
		{
			double num = this.PageLeft;
			bool flag = this.Grid.RootTable.ColumnSets.Count > 0;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = this.Grid.RootTable.ColumnSets.GetEnumerator();
					while (enumerator.MoveNext())
					{
						GridEXColumnSet gridEXColumnSet = (GridEXColumnSet)enumerator.Current;
						double num2 = (double)gridEXColumnSet.Width / (double)this.GridWidth * 100.0;
						double num3 = this.Report.Pages[0].Width / 100.0 * num2;
						RectangleD rect = new RectangleD(num - num3, 0.0, num3, 0.6);
						StiText stiText = new StiText(rect, gridEXColumnSet.Caption);
						stiText.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
						stiText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
						stiText.VertAlignment = StiVertAlignment.Center;
						stiText.HorAlignment = StiTextHorAlignment.Center;
						stiText.Brush = new StiSolidBrush(Color.WhiteSmoke);
						stiText.ShrinkFontToFit = true;
						stiText.WordWrap = true;
						stiText.Name = "headercolumnset" + Conversions.ToString(gridEXColumnSet.Position);
						this.HeaderBand.Components.Add(stiText);
						num -= num3;
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

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00093F20 File Offset: 0x00092120
		private void CreateHeaderBand()
		{
			double height = this.elementheight;
			bool flag = this.Grid.RootTable.ColumnSets.Count > 0;
			if (flag)
			{
				height = (double)this.Grid.RootTable.ColumnSetHeaders * 0.6 + (double)this.Grid.RootTable.ColumnSetRowCount * 0.6;
			}
			RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, height);
			this.HeaderBand = new StiHeaderBand(rect);
			this.HeaderBand.Name = "HeaderBand";
			this.Report.Pages[0].Components.Add(this.HeaderBand);
			flag = (this.Grid.RootTable.ColumnSetHeaders == InheritableBoolean.True);
			if (flag)
			{
				this.CreateColumnHeaders();
			}
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0009401C File Offset: 0x0009221C
		private void CreateDataBand()
		{
			RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, this.elementheight);
			this.DataBand = new StiDataBand(rect);
			this.DataBand.Name = "Databand";
			this.DataBand.DataSourceName = "Data";
			this.DataBand.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
			this.Report.Pages[0].Components.Add(this.DataBand);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000940D4 File Offset: 0x000922D4
		private void CreateMainDataText2()
		{
			double num = this.PageLeft;
			double num2 = 0.0;
			bool flag = this.Grid.RootTable.ColumnSetHeaders == InheritableBoolean.True;
			if (flag)
			{
				num2 += 0.6;
			}
			try
			{
				IEnumerator enumerator = this.Grid.RootTable.ColumnSets.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumnSet gridEXColumnSet = (GridEXColumnSet)enumerator.Current;
					int arg_79_0 = 0;
					int num3 = checked(gridEXColumnSet.ColumnCount - 1);
					int num4 = arg_79_0;
					while (true)
					{
						int arg_41B_0 = num4;
						int num5 = num3;
						if (arg_41B_0 > num5)
						{
							break;
						}
						GridEXColumn gridEXColumn = gridEXColumnSet[0, num4];
						flag = !gridEXColumn.Visible;
						if (!flag)
						{
							double num6 = (double)gridEXColumn.Width / (double)this.GridWidth * 100.0;
							double num7 = this.Report.Pages[0].Width / 100.0 * num6;
							flag = (gridEXColumn.ColSpan > 1);
							checked
							{
								if (flag)
								{
									num4 += gridEXColumn.ColSpan - 1;
								}
							}
							RectangleD rect = new RectangleD(num - num7, num2, num7, this.elementheight);
							StiText stiText = new StiText(rect, gridEXColumn.Caption);
							stiText.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
							stiText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
							stiText.VertAlignment = StiVertAlignment.Center;
							stiText.HorAlignment = StiTextHorAlignment.Center;
							stiText.Brush = new StiSolidBrush(Color.WhiteSmoke);
							stiText.ShrinkFontToFit = true;
							stiText.WordWrap = true;
							stiText.Name = "header" + Conversions.ToString(gridEXColumn.Position);
							rect = new RectangleD(num - num7, 0.0, num7, this.elementheight);
							StiText stiText2 = new StiText(rect, "{Data." + gridEXColumn.DataMember + "}");
							stiText2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
							stiText2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
							stiText2.VertAlignment = StiVertAlignment.Center;
							stiText2.HorAlignment = StiTextHorAlignment.Center;
							stiText2.TextOptions.RightToLeft = true;
							stiText2.WordWrap = true;
							stiText2.Name = "data" + Conversions.ToString(gridEXColumn.Position);
							stiText2.ShrinkFontToFit = true;
							flag = (Operators.CompareString(gridEXColumn.FormatString, "N0", false) == 0);
							if (flag)
							{
								stiText2.TextFormat = new StiNumberFormatService(3, ".", 0, ",", 3, true, false, " ");
							}
							flag = (this.Grid.TotalRow == InheritableBoolean.True && Operators.CompareString(gridEXColumn.FormatString, "N0", false) == 0);
							if (flag)
							{
								rect = new RectangleD(num - num7, 0.0, num7, this.elementheight);
								StiText stiText3 = new StiText(rect, "{Sum(Databand,Data." + gridEXColumn.DataMember + ")}");
								stiText3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
								stiText3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
								stiText3.VertAlignment = StiVertAlignment.Center;
								stiText3.HorAlignment = StiTextHorAlignment.Center;
								stiText3.TextFormat = new StiNumberFormatService(3, ".", 0, ",", 3, true, false, " ");
								stiText3.Brush = new StiSolidBrush(Color.WhiteSmoke);
								stiText3.TextOptions.RightToLeft = true;
								stiText3.WordWrap = true;
								stiText3.Name = "footer" + Conversions.ToString(gridEXColumn.Position);
								stiText3.ShrinkFontToFit = true;
								this.FooterBand.Components.Add(stiText3);
							}
							this.DataBand.Components.Add(stiText2);
							this.HeaderBand.Components.Add(stiText);
							num -= num7;
						}
						checked
						{
							num4++;
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
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x00094554 File Offset: 0x00092754
		private void CreateMainDataText()
		{
			double num = this.PageLeft;
			double num2 = 0.0;
			bool flag = this.Grid.RootTable.ColumnHeaders == InheritableBoolean.True;
			if (flag)
			{
				num2 += 0.2;
			}
			try
			{
				IEnumerator enumerator = this.Grid.RootTable.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
					flag = !gridEXColumn.Visible;
					if (!flag)
					{
						double num3 = (double)gridEXColumn.Width / (double)this.GridWidth * 100.0;
						double num4 = this.Report.Pages[0].Width / 100.0 * num3;
						RectangleD rect = new RectangleD(num - num4, num2, num4, this.elementheight);
						StiText stiText = new StiText(rect, gridEXColumn.Caption);
						stiText.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						stiText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
						stiText.VertAlignment = StiVertAlignment.Center;
						stiText.HorAlignment = StiTextHorAlignment.Center;
						stiText.Brush = new StiSolidBrush(Color.WhiteSmoke);
						stiText.ShrinkFontToFit = true;
						stiText.WordWrap = true;
						stiText.Name = "header" + Conversions.ToString(gridEXColumn.Position);
						this.HeaderBand.Components.Add(stiText);
						rect = new RectangleD(num - num4, 0.0, num4, this.elementheight);
						StiText stiText2 = new StiText(rect, "{Data." + gridEXColumn.DataMember + "}");
						stiText2.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
						stiText2.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
						stiText2.VertAlignment = StiVertAlignment.Center;
						stiText2.HorAlignment = StiTextHorAlignment.Left;
						stiText2.TextOptions.RightToLeft = true;
						stiText2.WordWrap = true;
						stiText2.Name = "data" + Conversions.ToString(gridEXColumn.Position);
						stiText2.ShrinkFontToFit = true;
						this.DataBand.Components.Add(stiText2);
						flag = (gridEXColumn.DataTypeCode != TypeCode.String);
						if (flag)
						{
							stiText2.TextFormat = new StiNumberFormatService(3, ".", 0, ",", 3, true, false, " ");
							Public_Function.setReportFont(this.Report, stiText2.Name);
						}
						flag = (this.Grid.TotalRow == InheritableBoolean.True && Operators.CompareString(gridEXColumn.FormatString, "N0", false) == 0);
						if (flag)
						{
							rect = new RectangleD(num - num4, 0.0, num4, this.elementheight);
							StiText stiText3 = new StiText(rect, "{Sum(Databand,Data." + gridEXColumn.DataMember + ")}");
							stiText3.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
							stiText3.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
							stiText3.VertAlignment = StiVertAlignment.Center;
							stiText3.HorAlignment = StiTextHorAlignment.Left;
							stiText3.TextFormat = new StiNumberFormatService(3, ".", 0, ",", 3, true, false, " ");
							stiText3.Brush = new StiSolidBrush(Color.WhiteSmoke);
							stiText3.TextOptions.RightToLeft = true;
							stiText3.WordWrap = true;
							stiText3.Name = "footer" + Conversions.ToString(gridEXColumn.Position);
							stiText3.ShrinkFontToFit = true;
							this.FooterBand.Components.Add(stiText3);
							Public_Function.setReportFont(this.Report, stiText3.Name);
						}
						flag = (gridEXColumn.AggregateFunction == AggregateFunction.Sum && this.Grid.RootTable.Groups.Count > 0);
						if (flag)
						{
							rect = new RectangleD(num - num4, 0.0, num4, this.elementheight);
							StiText stiText4 = new StiText(rect, "{Sum(Databand,Data." + gridEXColumn.DataMember + ")}");
							stiText4.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 0);
							stiText4.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
							stiText4.VertAlignment = StiVertAlignment.Center;
							stiText4.HorAlignment = StiTextHorAlignment.Left;
							stiText4.TextFormat = new StiNumberFormatService(3, ".", 0, ",", 3, true, false, " ");
							stiText4.Brush = new StiSolidBrush(Color.WhiteSmoke);
							stiText4.TextOptions.RightToLeft = true;
							stiText4.WordWrap = true;
							stiText4.Name = "groupfooter" + Conversions.ToString(gridEXColumn.Position);
							stiText4.ShrinkFontToFit = true;
							this.GroupFooter.Components.Add(stiText4);
						}
						num -= num4;
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

		// Token: 0x06000BF6 RID: 3062 RVA: 0x00094AE0 File Offset: 0x00092CE0
		private void CreateFooterBand()
		{
			RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, this.elementheight);
			this.FooterBand = new StiFooterBand(rect);
			this.FooterBand.Name = "footerband";
			this.FooterBand.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
			this.Report.Pages[0].Components.Add(this.FooterBand);
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x00094B88 File Offset: 0x00092D88
		private void CreateGroupHeader()
		{
			RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, 1.0);
			this.GroupHeader = new StiGroupHeaderBand(rect);
			this.GroupHeader.Name = "groupheader";
			this.GroupHeader.Condition = new StiGroupConditionExpression("{data." + this.Grid.RootTable.Groups[0].Column.DataMember + "}");
			rect = new RectangleD(0.0, 0.2, this.Report.Pages[0].Width, 0.6);
			StiText stiText = new StiText(rect, "");
			stiText.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			stiText.Border = new StiBorder(StiBorderSides.All, Color.Black, 1.0, StiPenStyle.Solid);
			stiText.VertAlignment = StiVertAlignment.Center;
			stiText.HorAlignment = StiTextHorAlignment.Right;
			stiText.Brush = new StiSolidBrush(Color.WhiteSmoke);
			stiText.ShrinkFontToFit = true;
			stiText.Text = this.Grid.RootTable.Groups[0].GroupPrefix + "{data." + this.Grid.RootTable.Groups[0].Column.DataMember + "}";
			stiText.WordWrap = true;
			stiText.Name = "grouptext";
			this.GroupHeader.Components.Add(stiText);
			this.Report.Pages[0].Components.Add(this.GroupHeader);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x00094D70 File Offset: 0x00092F70
		private void CreateGroupFooter()
		{
			bool flag = this.Grid.RootTable.Groups.Count > 0;
			if (flag)
			{
				bool flag2 = this.Grid.RootTable.Groups[0].GroupTotalVisibility == GroupTotalVisibility.Default || this.Grid.RootTable.Groups[0].GroupTotalVisibility == GroupTotalVisibility.Visible;
				if (flag2)
				{
					RectangleD rect = new RectangleD(0.0, 0.0, this.Report.Pages[0].Width, 0.6);
					this.GroupFooter = new StiGroupFooterBand(rect);
					this.GroupFooter.Name = "groupfooter";
					this.Report.Pages[0].Components.Add(this.GroupFooter);
				}
			}
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x00094E60 File Offset: 0x00093060
		public void ShowPreview()
		{
			bool flag = this.Report == null;
			if (!flag)
			{
				this.Report.Compile();
				Public_Function.AddTazminText(this.Report, true, false);
				this.Report.Show();
			}
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x00094EA8 File Offset: 0x000930A8
		private void SetHeader()
		{
			StiText stiText = (StiText)this.Report.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)this.Report.GetComponentByName("head2");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)this.Report.GetComponentByName("tarikh");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					this.Report.Pages[0].Watermark.Angle = 45f;
					this.Report.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				this.Report.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x00094FF4 File Offset: 0x000931F4
		public void RenderReport(GridEX grid, string sTitle)
		{
			this.Grid = grid;
			this.ReportTitle = sTitle;
			bool flag = grid.RowCount == 0;
			if (!flag)
			{
				this.Report = new StiReport
				{
					ScriptLanguage = StiReportLanguageType.VB
				};
				this.Report.Pages[0].Margins = new StiMargins(0.2, 0.2, 0.2, 0.2);
				this._GridWidth = this.GetGridWidth();
				this.SetReportDatasource();
				this.CreateTitleBand();
				this.CreateTitleText();
				this.CreateHeaderBand();
				flag = (grid.RootTable.Groups.Count > 0);
				if (flag)
				{
					this.CreateGroupHeader();
				}
				this.CreateDataBand();
				this.CreateGroupFooter();
				flag = (grid.TotalRow == InheritableBoolean.True);
				if (flag)
				{
					this.CreateFooterBand();
				}
				flag = (grid.RootTable.ColumnSets.Count == 0);
				if (flag)
				{
					this.CreateMainDataText();
				}
				else
				{
					this.CreateMainDataText2();
				}
				this.SetHeader();
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x00004719 File Offset: 0x00002919
		public void PrintGrid(GridEX grid, string sTitle)
		{
			this.RenderReport(grid, sTitle);
			this.ShowPreview();
		}

		// Token: 0x040004AF RID: 1199
		[CompilerGenerated]
		private string _ReportTitle;

		// Token: 0x040004B0 RID: 1200
		[CompilerGenerated]
		private GridEX _Grid;

		// Token: 0x040004B1 RID: 1201
		private int _GridWidth;

		// Token: 0x040004B2 RID: 1202
		[CompilerGenerated]
		private StiReport _Report;

		// Token: 0x040004B3 RID: 1203
		[CompilerGenerated]
		private StiReportTitleBand _TitleBand;

		// Token: 0x040004B4 RID: 1204
		[CompilerGenerated]
		private StiHeaderBand _HeaderBand;

		// Token: 0x040004B5 RID: 1205
		[CompilerGenerated]
		private StiDataBand _DataBand;

		// Token: 0x040004B6 RID: 1206
		[CompilerGenerated]
		private StiFooterBand _FooterBand;

		// Token: 0x040004B7 RID: 1207
		[CompilerGenerated]
		private StiGroupHeaderBand _GroupHeader;

		// Token: 0x040004B8 RID: 1208
		[CompilerGenerated]
		private StiGroupFooterBand _GroupFooter;

		// Token: 0x040004B9 RID: 1209
		[CompilerGenerated]
		private double _elementheight;
	}
}
