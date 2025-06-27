using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.Common;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200008A RID: 138
	[StandardModule]
	internal sealed class Public_Function
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x00098D9C File Offset: 0x00096F9C
		static Public_Function()
		{
			CurrentData currentData = new CurrentData();
			Public_Function.CurrentData = currentData;
			Public_Function.dict = new Dictionary<string, string>();
			Public_Function.DayName = new string[]
			{
				"",
				"شنبه",
				"یکشنبه",
				"دوشنبه",
				"سه شنبه",
				"چهار شنبه",
				"پنجشنبه",
				"جمعه"
			};
			Public_Function.MonthName = new string[]
			{
				"",
				"فروردین",
				"اردیبهشت",
				"خرداد",
				"تیر",
				"مرداد",
				"شهریور",
				"مهر",
				"آبان",
				"آذر",
				"دی",
				"بهمن",
				"اسفند"
			};
			int appType = 1;
			Public_Function.AppType = appType;
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00098EA8 File Offset: 0x000970A8
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00004747 File Offset: 0x00002947
		public static SqlConnection Connection
		{
			[DebuggerNonUserCode]
			get
			{
				return Public_Function._Connection;
			}
			[DebuggerNonUserCode]
			set
			{
				Public_Function._Connection = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00098EC0 File Offset: 0x000970C0
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00004750 File Offset: 0x00002950
		public static CurrentData CurrentData
		{
			[DebuggerNonUserCode]
			get
			{
				return Public_Function._CurrentData;
			}
			[DebuggerNonUserCode]
			set
			{
				Public_Function._CurrentData = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00098ED8 File Offset: 0x000970D8
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x00004759 File Offset: 0x00002959
		public static string Server
		{
			[DebuggerNonUserCode]
			get
			{
				return Public_Function._Server;
			}
			[DebuggerNonUserCode]
			set
			{
				Public_Function._Server = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x00098EF0 File Offset: 0x000970F0
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00004762 File Offset: 0x00002962
		public static string SQLInstance
		{
			[DebuggerNonUserCode]
			get
			{
				return Public_Function._SQLInstance;
			}
			[DebuggerNonUserCode]
			set
			{
				Public_Function._SQLInstance = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00098F08 File Offset: 0x00097108
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0000476B File Offset: 0x0000296B
		public static int AppType
		{
			[DebuggerNonUserCode]
			get
			{
				return Public_Function._AppType;
			}
			[DebuggerNonUserCode]
			set
			{
				Public_Function._AppType = value;
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00098F20 File Offset: 0x00097120
		public static string Startup_Path()
		{
			return Application.StartupPath;
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00098F38 File Offset: 0x00097138
		public static decimal GetDecimalValue(decimal d)
		{
			decimal d2 = decimal.Truncate(d);
			bool flag = decimal.Compare(decimal.Subtract(d, d2), decimal.Zero) > 0;
			decimal result;
			if (flag)
			{
				result = Conversions.ToDecimal(decimal.Parse(d.ToString()).ToString("G29"));
			}
			else
			{
				result = decimal.Truncate(d);
			}
			return result;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x00098F94 File Offset: 0x00097194
		public static void SetSti_text(StiReport report, string element, string text)
		{
			StiText stiText = (StiText)report.GetComponentByName(element);
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = text;
			}
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x00098FCC File Offset: 0x000971CC
		public static void Sti_replace(StiReport report, string elements)
		{
			string[] array = elements.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string componentName = array2[i];
					StiText stiText = (StiText)report.GetComponentByName(componentName);
					bool flag = stiText != null;
					if (flag)
					{
						stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					}
				}
			}
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00099054 File Offset: 0x00097254
		public static void setReportFontBold(StiReport report, string elements)
		{
			bool flag = Operators.CompareString(Public_Function.dict["printfont_number"], string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					string[] array = elements.Split(new char[]
					{
						','
					});
					string[] array2 = Public_Function.dict["printfont_number"].ToString().Split(new char[]
					{
						';'
					});
					int style = 1;
					Font font = new Font(array2[0].ToString(), Conversions.ToSingle(array2[1]), (FontStyle)style, GraphicsUnit.Point);
					StiText stiText = new StiText();
					string[] array3 = array;
					for (int i = 0; i < array3.Length; i++)
					{
						string componentName = array3[i];
						stiText = (StiText)report.GetComponentByName(componentName);
						flag = (stiText != null);
						if (flag)
						{
							stiText.Font = font;
							stiText.ShrinkFontToFit = true;
						}
					}
				}
			}
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00099140 File Offset: 0x00097340
		public static void setReportFont(StiReport report, string elements)
		{
			bool flag = Operators.CompareString(Public_Function.dict["printfont_number"], string.Empty, false) == 0;
			checked
			{
				if (!flag)
				{
					try
					{
						string[] array = elements.Split(new char[]
						{
							','
						});
						string[] array2 = Public_Function.dict["printfont_number"].ToString().Split(new char[]
						{
							';'
						});
						string left = Public_Function.dict["gridfont"].ToString().Split(new char[]
						{
							';'
						})[2];
						flag = (Operators.CompareString(left, "regular", false) == 0);
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
						Font font = new Font(array2[0].ToString(), Conversions.ToSingle(array2[1]), (FontStyle)style, GraphicsUnit.Point);
						StiText stiText = new StiText();
						string[] array3 = array;
						for (int i = 0; i < array3.Length; i++)
						{
							string componentName = array3[i];
							stiText = (StiText)report.GetComponentByName(componentName);
							flag = (stiText != null);
							if (flag)
							{
								stiText.Font = font;
								stiText.ShrinkFontToFit = true;
							}
						}
					}
					catch (Exception expr_162)
					{
						ProjectData.SetProjectError(expr_162);
						Public_Function.ShowMessage("فونت انتخاب شده برای چاپ متبر نمی باشد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
						ProjectData.ClearProjectError();
					}
				}
			}
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x000992EC File Offset: 0x000974EC
		public static void SetReport_MarginTop(StiReport report)
		{
			try
			{
				IEnumerator enumerator = report.Pages.GetEnumerator();
				while (enumerator.MoveNext())
				{
					StiPage stiPage = (StiPage)enumerator.Current;
					stiPage.Margins = new StiMargins(stiPage.Margins.Left, stiPage.Margins.Right, Conversions.ToDouble(Public_Function.dict["paper_margin_top"]), stiPage.Margins.Bottom);
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

		// Token: 0x06000C2E RID: 3118 RVA: 0x00099394 File Offset: 0x00097594
		public static string BuildWhere(List<string> lst, Public_Function.OperandType First_op)
		{
			bool flag = lst.Count == 0;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string text = string.Empty;
				switch (First_op)
				{
				case Public_Function.OperandType.where:
					text += " WHERE ";
					break;
				case Public_Function.OperandType.AND_:
					text += " AND ";
					break;
				case Public_Function.OperandType.OR_:
					text += " OR ";
					break;
				}
				try
				{
					List<string>.Enumerator enumerator = lst.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						text = text + current + " AND ";
					}
				}
				finally
				{
					List<string>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				text = Public_Function.RemoveLast(text, 5);
				result = text;
			}
			return result;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00099468 File Offset: 0x00097668
		public static string ReverseString(string s)
		{
			char[] array = s.ToCharArray();
			string text = string.Empty;
			checked
			{
				int num = array.Length - 1;
				while (true)
				{
					int arg_30_0 = num;
					int num2 = 0;
					if (arg_30_0 < num2)
					{
						break;
					}
					text += Conversions.ToString(array[num]);
					num += -1;
				}
				return text;
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000994AC File Offset: 0x000976AC
		public static void RenderDigitToPdf(DataTable dt)
		{
			char[] array = Conversions.ToCharArrayRankOne(string.Empty);
			string text = string.Empty;
			string text2 = string.Empty;
			checked
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						array = dataRow["tozih"].ToString().ToCharArray();
						text2 = dataRow["tozih"].ToString();
						int num = 0;
						bool flag = false;
						int num2 = 0;
						text = string.Empty;
						char[] array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							char c = array2[i];
							bool flag2 = (char.IsNumber(c) | Operators.CompareString(Conversions.ToString(c), "/", false) == 0 | Operators.CompareString(Conversions.ToString(c), ",", false) == 0) & !flag;
							if (flag2)
							{
								num = num2;
								flag = true;
							}
							flag2 = (flag && (!char.IsNumber(c) & Operators.CompareString(Conversions.ToString(c), "/", false) != 0 & Operators.CompareString(Conversions.ToString(c), ",", false) != 0));
							if (flag2)
							{
								text = text2.Substring(num, num2 - num);
								dataRow["tozih"] = dataRow["tozih"].ToString().Replace(text, Public_Function.ReverseString(text));
								flag = false;
							}
							num2++;
							flag2 = (num2 == text2.Length && flag);
							if (flag2)
							{
								text = text2.Substring(num, num2 - num);
								dataRow["tozih"] = dataRow["tozih"].ToString().Replace(text, Public_Function.ReverseString(text));
								flag = false;
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

		// Token: 0x06000C31 RID: 3121 RVA: 0x000996D0 File Offset: 0x000978D0
		public static string RenderDigitToPdf(string str)
		{
			str = Public_Function.ToFarsi(str);
			char[] array = Conversions.ToCharArrayRankOne(string.Empty);
			string text = string.Empty;
			array = str.ToString().ToCharArray();
			int num = 0;
			bool flag = false;
			int num2 = 0;
			text = string.Empty;
			char[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					char c = array2[i];
					bool flag2 = (char.IsNumber(c) | Operators.CompareString(Conversions.ToString(c), "/", false) == 0 | Operators.CompareString(Conversions.ToString(c), ",", false) == 0) & !flag;
					if (flag2)
					{
						num = num2;
						flag = true;
					}
					flag2 = (flag && (!char.IsNumber(c) & Operators.CompareString(Conversions.ToString(c), "/", false) != 0 & Operators.CompareString(Conversions.ToString(c), ",", false) != 0));
					if (flag2)
					{
						text = str.Substring(num, num2 - num);
						str = str.Replace(text, Public_Function.ReverseString(text));
						flag = false;
					}
					num2++;
					flag2 = (num2 == str.Length && flag);
					if (flag2)
					{
						text = str.Substring(num, num2 - num);
						str = str.Replace(text, Public_Function.ReverseString(text));
						flag = false;
					}
				}
				return str;
			}
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00099834 File Offset: 0x00097A34
		public static void SetHeader(StiReport rpt, bool Pdf = false)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			if (stiText != null)
			{
				if (!Pdf)
				{
					stiText.Text = Public_Function.ToFarsi(Public_Function.dict["head1"]);
				}
				else
				{
					stiText.Text = Public_Function.RenderDigitToPdf(Public_Function.dict["head1"]);
				}
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			if (stiText != null)
			{
				if (!Pdf)
				{
					stiText.Text = Public_Function.ToFarsi(Public_Function.dict["head2"]);
				}
				else
				{
					stiText.Text = Public_Function.RenderDigitToPdf(Public_Function.dict["head2"]);
				}
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			if (stiText != null)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			if (Public_Function.dict.ContainsKey("eval"))
			{
				if (Conversions.ToBoolean(Public_Function.dict["eval"]))
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "حجره";
					return;
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x00099998 File Offset: 0x00097B98
		public static void AddTazminText(StiReport rpt, bool left = true, bool Pdf = false)
		{
			StiComponent componentByName = rpt.GetComponentByName("txt_hojreh");
			StiText stiText = new StiText();
			if (!Pdf)
			{
				stiText.Text.Value = Public_Function.ToFarsi("www.hojreh-app.ir - نرم افزارحجره - 09019024221");
			}
			else
			{
				stiText.Text.Value = Public_Function.ToFarsi("www.hojreh-app.ir - 69044209390 - نرم افزار حجره");
			}
			if (componentByName == null)
			{
				StiComponent arg_74_0 = stiText;
				RectangleD clientRectangle = new RectangleD(-0.4, 1.7, 0.4, 9.0);
				arg_74_0.ClientRectangle = clientRectangle;
				if (!left)
				{
					stiText.Left = 19.0;
				}
				stiText.Angle = 90f;
				stiText.HorAlignment = StiTextHorAlignment.Right;
				stiText.VertAlignment = StiVertAlignment.Bottom;
				stiText.Page = rpt.Pages[0];
				stiText.Parent = rpt.Pages[0];
				stiText.Name = "txt_hojreh";
				stiText.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, 178);
				rpt.Pages[0].Components.Add(stiText);
				return;
			}
			stiText = (StiText)componentByName;
			if (!Pdf)
			{
				stiText.Text.Value = Public_Function.ToFarsi("www.hojreh-app.ir - نرم افزارحجره - 09019024221");
				return;
			}
			stiText.Text.Value = Public_Function.ToFarsi("www.hojreh-app.ir - 69044209390 - نرم افزار حجره");
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x00099AE4 File Offset: 0x00097CE4
		public static void RemoveZero(DataTable dt, string Field)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow[Field] != DBNull.Value;
					if (flag)
					{
						dataRow[Field] = dataRow[Field].ToString().Replace(".0", "");
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

		// Token: 0x06000C35 RID: 3125 RVA: 0x00099B84 File Offset: 0x00097D84
		public static bool DBExist()
		{
			SqlConnection sqlConnection = new SqlConnection("Data Source=" + Public_Function.Server + Public_Function.SQLInstance + ";Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=1");
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("select Name from sys.databases where name='fruitbox'", sqlConnection);
			string left = Conversions.ToString(sqlCommand.ExecuteScalar());
			sqlConnection.Close();
			bool flag = Operators.CompareString(left, string.Empty, false) == 0;
			return !flag;
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00099BFC File Offset: 0x00097DFC
		public static void FirstRun()
		{
			CreateDB createDB = new CreateDB();
			createDB.CreateDB();
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00099C18 File Offset: 0x00097E18
		public static void Delete_Row(string table_name, long id)
		{
			DataTable dataTable = Public_Function.FillData("sp_fkeys " + table_name);
			string text = string.Empty;
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from deleted_objects where name=" + Public_Function.GetValue(table_name)));
			DataTable dataTable2 = Public_Function.FillData("select  * from Deleted_Objects_Manual where deleted_object_id=" + Conversions.ToString(value));
			string text2 = string.Empty;
			string right = string.Empty;
			try
			{
				IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("fktable_name='", dataRow["table"]), "'")));
					bool flag = array.Length == 0;
					if (!flag)
					{
						right = Conversions.ToString(array[0]["fkcolumn_name"]);
						object arg_118_0 = null;
						Type arg_118_1 = typeof(Public_Function);
						string arg_118_2 = "SqlServer_Table_Columns_Without_Identity";
						object[] array2 = new object[1];
						object[] arg_FF_0 = array2;
						int arg_FF_1 = 0;
						DataRow dataRow2 = dataRow;
						DataRow arg_F5_0 = dataRow2;
						string columnName = "Referenced_Table";
						arg_FF_0[arg_FF_1] = RuntimeHelpers.GetObjectValue(arg_F5_0[columnName]);
						object[] array3 = array2;
						object[] arg_118_3 = array3;
						string[] arg_118_4 = null;
						Type[] arg_118_5 = null;
						bool[] array4 = new bool[]
						{
							true
						};
						object arg_136_0 = NewLateBinding.LateGet(arg_118_0, arg_118_1, arg_118_2, arg_118_3, arg_118_4, arg_118_5, array4);
						if (array4[0])
						{
							dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
						}
						text2 = Conversions.ToString(arg_136_0);
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into deleted_", dataRow["Referenced_Table"]), " select * from "), dataRow["Referenced_Table"]), " where id in (select "), dataRow["column_name"]), " from "), dataRow["table"]), " where "), right), " ="), id), "   );")));
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
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator2.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into deleted_", dataRow3["fktable_name"]), " select * from "), dataRow3["fktable_name"]), " where "), dataRow3["fkcolumn_name"]), "="), id), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag = enumerator2 is IDisposable;
				if (flag)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			text = string.Concat(new string[]
			{
				text,
				"insert into deleted_",
				table_name,
				" select *,getdate() from ",
				table_name,
				" where id=",
				Conversions.ToString(id),
				";"
			});
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00099FA4 File Offset: 0x000981A4
		private static string SqlServer_Table_Columns_Without_Identity(string table_name, string Replace_column = "", string Replace_Value = "")
		{
			string text = string.Empty;
			DataTable dt = Public_Function.FillData(string.Concat(new string[]
			{
				"select '[' + COLUMN_NAME + ']' as column_name, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH  from INFORMATION_SCHEMA.COLUMNS IC  where TABLE_NAME =  ",
				Public_Function.GetValue(table_name),
				" and COLUMN_NAME not in (  select c.name  from sys.objects o  inner join sys.columns c on o.object_id = c.object_id  where o.type='U'  and o.name=",
				Public_Function.GetValue(table_name),
				" and c.is_identity = 1  )   order by ORDINAL_POSITION"
			}));
			text = Public_Function.GetID(dt, "column_name", "");
			bool flag = Operators.CompareString(Replace_column, "", false) != 0;
			if (flag)
			{
				text = text.Replace("[" + Replace_column + "]", Replace_Value);
			}
			return text;
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0009A044 File Offset: 0x00098244
		private static string SqlServer_Table_Columns_Without_Identity(string table_name, List<KeyValuePair<string, string>> m = null)
		{
			string result = string.Empty;
			DataTable dt = Public_Function.FillData(string.Concat(new string[]
			{
				"select '[' + COLUMN_NAME + ']' as column_name, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH  from INFORMATION_SCHEMA.COLUMNS IC  where TABLE_NAME =  ",
				Public_Function.GetValue(table_name),
				" and COLUMN_NAME not in (  select c.name  from sys.objects o  inner join sys.columns c on o.object_id = c.object_id  where o.type='U'  and o.name=",
				Public_Function.GetValue(table_name),
				" and c.is_identity = 1  )   order by ORDINAL_POSITION"
			}));
			result = Public_Function.GetID(dt, "column_name", "");
			try
			{
				List<KeyValuePair<string, string>>.Enumerator enumerator = m.GetEnumerator();
				while (enumerator.MoveNext())
				{
					KeyValuePair<string, string> current = enumerator.Current;
				}
			}
			finally
			{
				List<KeyValuePair<string, string>>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			return result;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0009A0FC File Offset: 0x000982FC
		public static void Restore_Deleted_Row(string table_name, long id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select id from deleted_objects where name=" + Public_Function.GetValue(table_name)));
			DataTable dataTable = Public_Function.FillData("select  * from Deleted_Objects_Manual where deleted_object_id=" + Conversions.ToString(value));
			DataTable dataTable2 = Public_Function.FillData("sp_fkeys " + table_name);
			string text = "declare @id as bigint; ";
			List<string> list = new List<string>();
			string text2 = string.Empty;
			text2 = Public_Function.SqlServer_Table_Columns_Without_Identity(table_name, "", "");
			List<KeyValuePair<string, string>> list2 = new List<KeyValuePair<string, string>>();
			text = string.Concat(new string[]
			{
				text,
				"insert into ",
				table_name,
				" (",
				text2,
				") select  ",
				text2,
				" from deleted_",
				table_name,
				" where id=",
				Conversions.ToString(id),
				";select @id=scope_identity();"
			});
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("table='", dataRow["fktable_name"]), "'")));
						bool flag = array.Length == 0;
						if (flag)
						{
							text2 = Public_Function.SqlServer_Table_Columns_Without_Identity(Conversions.ToString(dataRow["fktable_name"]), "", "");
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into ", dataRow["fktable_name"]), "("), text2), ")"), " select  "), Public_Function.SqlServer_Table_Columns_Without_Identity(Conversions.ToString(dataRow["fktable_name"]), Conversions.ToString(dataRow["fkcolumn_name"]), "@id")), " from "), "deleted_"), dataRow["fktable_name"]), " where "), dataRow["fkcolumn_name"]), "="), id), ";")));
						}
						else
						{
							DataRow[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								DataRow dataRow2 = array2[i];
								list.Add(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow2["column_name"], "_"), dataRow2["id"])));
								List<KeyValuePair<string, string>> arg_2D6_0 = list2;
								KeyValuePair<string, string> item = new KeyValuePair<string, string>(Conversions.ToString(dataRow2["column_name"]), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow2["column_name"], "_"), dataRow2["id"])));
								arg_2D6_0.Add(item);
							}
							DataTable dataTable3 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from deleted_", array[0]["table"]), " where "), dataRow["fkcolumn_name"]), "="), id)));
							try
							{
								IEnumerator enumerator2 = dataTable3.Rows.GetEnumerator();
								while (enumerator2.MoveNext())
								{
									DataRow instance = (DataRow)enumerator2.Current;
									flag = Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(instance, null, "Item", new object[]
									{
										RuntimeHelpers.GetObjectValue(array[0]["column_name"])
									}, null, null, null), DBNull.Value, false);
									if (flag)
									{
										object arg_4A2_0 = text;
										object arg_447_0 = Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into ", array[0]["Referenced_Table"]), "(");
										object arg_426_0 = null;
										Type arg_426_1 = typeof(Public_Function);
										string arg_426_2 = "SqlServer_Table_Columns_Without_Identity";
										object[] array3 = new object[1];
										object[] arg_40D_0 = array3;
										int arg_40D_1 = 0;
										DataRow[] array4 = array;
										DataRow[] arg_3F9_0 = array4;
										int num = 0;
										DataRow arg_403_0 = arg_3F9_0[num];
										string columnName = "Referenced_Table";
										arg_40D_0[arg_40D_1] = RuntimeHelpers.GetObjectValue(arg_403_0[columnName]);
										object[] array5 = array3;
										object[] arg_426_3 = array5;
										string[] arg_426_4 = null;
										Type[] arg_426_5 = null;
										bool[] array6 = new bool[]
										{
											true
										};
										object arg_447_1 = NewLateBinding.LateGet(arg_426_0, arg_426_1, arg_426_2, arg_426_3, arg_426_4, arg_426_5, array6);
										if (array6[0])
										{
											array4[num][columnName] = RuntimeHelpers.GetObjectValue(array5[0]);
										}
										text = Conversions.ToString(Operators.ConcatenateObject(arg_4A2_0, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(arg_447_0, arg_447_1), ")"), " select * from "), "deleted_"), array[0]["Referenced_Table"]), " where id="), array[0]["column_name"]), ";")));
										text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into ", dataRow["fktable_name"]), "("), Public_Function.SqlServer_Table_Columns_Without_Identity(Conversions.ToString(dataRow["fktable_name"]), Conversions.ToString(array[0]["column_name"]), ""))));
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
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0009A6C4 File Offset: 0x000988C4
		public static void LoadApplicationSetting()
		{
			Public_Function.Dt_FrmSize = Public_Function.FillData("select * from frm_size");
			DataTable dataTable = Public_Function.FillData("Select * from Setting");
			Public_Function.dict.Clear();
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = !Public_Function.dict.ContainsKey(dataRow["key"].ToString());
					if (flag)
					{
						Public_Function.dict.Add(dataRow["Key"].ToString().ToLower(), dataRow["Value"].ToString().ToLower());
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
			flag = !Public_Function.dict.ContainsKey("txt_moshtari_exit_on_save");
			if (flag)
			{
				Public_Function.dict.Add("txt_moshtari_exit_on_save", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("surat_bank_kind");
			if (flag)
			{
				Public_Function.dict.Add("surat_bank_kind", Conversions.ToString(1));
			}
			flag = !Public_Function.dict.ContainsKey("kharid_keraye_moshtari");
			if (flag)
			{
				Public_Function.dict.Add("kharid_keraye_moshtari", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("kharid_keraye_tozih");
			if (flag)
			{
				Public_Function.dict.Add("kharid_keraye_tozih", Conversions.ToString(false));
			}
			Public_Function.dict.Add("today", Public_Function.MiladiToShamsi(DateAndTime.Now));
			flag = !Public_Function.dict.ContainsKey("three_zero");
			if (flag)
			{
				Public_Function.dict.Add("three_zero", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("factor_furush_show_sharik");
			if (flag)
			{
				Public_Function.dict.Add("factor_furush_show_sharik", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("factor_Furush_show_tedad_sefr");
			if (flag)
			{
				Public_Function.dict.Add("factor_Furush_show_tedad_sefr", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("noe_mojodi_anbar");
			if (flag)
			{
				Public_Function.dict.Add("noe_mojodi_anbar", "1");
			}
			flag = !Public_Function.dict.ContainsKey("startup");
			if (flag)
			{
				Public_Function.dict.Add("startup", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("autotakhlie");
			if (flag)
			{
				Public_Function.dict.Add("autotakhlie", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("autosurat");
			if (flag)
			{
				Public_Function.dict.Add("autosurat", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("noesafi");
			if (flag)
			{
				Public_Function.dict.Add("noesafi", "1");
			}
			flag = Public_Function.dict.ContainsKey("owner");
			if (flag)
			{
				MyProject.Forms.Form_Main.txt_CompanyName.Text = Public_Function.dict["owner"];
			}
			else
			{
				Public_Function.dict.Add("owner", "");
			}
			flag = !Public_Function.dict.ContainsKey("head1");
			if (flag)
			{
				Public_Function.dict.Add("head1", "نسخه نمایشی");
			}
			flag = !Public_Function.dict.ContainsKey("showavaldore");
			if (flag)
			{
				Public_Function.dict.Add("showavaldore", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("head2");
			if (flag)
			{
				Public_Function.dict.Add("head2", "نسخه نمایشی");
			}
			flag = !Public_Function.dict.ContainsKey("fullscreen");
			if (flag)
			{
				Public_Function.dict.Add("fullscreen", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("showmemo");
			if (flag)
			{
				Public_Function.dict.Add("showmemo", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("showstatus");
			if (flag)
			{
				Public_Function.dict.Add("showstatus", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("showtoolbar");
			if (flag)
			{
				Public_Function.dict.Add("showtoolbar", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("theme");
			if (flag)
			{
				Public_Function.dict.Add("theme", Conversions.ToString(-1));
			}
			flag = !Public_Function.dict.ContainsKey("showmax");
			if (flag)
			{
				Public_Function.dict.Add("showmax", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("sarresid_d");
			if (flag)
			{
				Public_Function.dict.Add("sarresid_d", Conversions.ToString(0));
			}
			flag = !Public_Function.dict.ContainsKey("sarresid_p");
			if (flag)
			{
				Public_Function.dict.Add("sarresid_p", Conversions.ToString(0));
			}
			flag = !Public_Function.dict.ContainsKey("textfont");
			if (flag)
			{
				Public_Function.dict.Add("textfont", "mitra;14.25;bold");
			}
			flag = !Public_Function.dict.ContainsKey("gridfont");
			if (flag)
			{
				Public_Function.dict.Add("gridfont", "mitra;14.25;bold");
			}
			flag = !Public_Function.dict.ContainsKey("kiosk_auto_kasr");
			if (flag)
			{
				Public_Function.dict.Add("kiosk_auto_kasr", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("newrow_kala");
			if (flag)
			{
				Public_Function.dict.Add("newrow_kala", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("show_newversion");
			if (flag)
			{
				Public_Function.dict.Add("show_newversion", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("autolock");
			if (flag)
			{
				Public_Function.dict.Add("autolock", "4");
			}
			flag = !Public_Function.dict.ContainsKey("sardkhane_vaznkol");
			if (flag)
			{
				Public_Function.dict.Add("sardkhane_vaznkol", Conversions.ToString(false));
			}
			flag = !Public_Function.dict.ContainsKey("sardkhane_keraye_moshtari");
			if (flag)
			{
				Public_Function.dict.Add("sardkhane_keraye_moshtari", Conversions.ToString(true));
			}
			flag = !Public_Function.dict.ContainsKey("sardkhane_keraye_tozih");
			if (flag)
			{
				Public_Function.dict.Add("sardkhane_keraye_tozih", Conversions.ToString(true));
			}
			bool flag2;
			try
			{
				Font font = new Font(Public_Function.dict["gridfont"].ToString().Split(new char[]
				{
					';'
				})[0], 10f);
				flag = (Operators.CompareString(Public_Function.dict["gridfont"].ToString().Split(new char[]
				{
					';'
				})[0].ToLower(), "mitra", false) == 0);
				if (flag)
				{
					flag2 = (Operators.CompareString(font.FontFamily.Name.ToLower(), "mitra", false) != 0);
					if (flag2)
					{
						Public_Function.dict["gridfont"] = "b mitra;14.25;bold";
						Public_Function.dict["textfont"] = "b mitra;14.25;bold";
					}
				}
			}
			catch (Exception expr_7E4)
			{
				ProjectData.SetProjectError(expr_7E4);
				ProjectData.ClearProjectError();
			}
			flag2 = !Public_Function.dict.ContainsKey("printfont_number");
			if (flag2)
			{
				Public_Function.dict.Add("printfont_number", "");
			}
			flag2 = !Public_Function.dict.ContainsKey("dbname");
			if (flag2)
			{
				Public_Function.dict.Add("dbname", "fruitbox");
			}
			flag2 = !Public_Function.dict.ContainsKey("nahve_furush");
			if (flag2)
			{
				Public_Function.dict.Add("nahve_furush", "1");
			}
			flag2 = !Public_Function.dict.ContainsKey("nahve_kharid");
			if (flag2)
			{
				Public_Function.dict.Add("nahve_kharid", "1");
			}
			flag2 = !Public_Function.dict.ContainsKey("sms_number");
			if (flag2)
			{
				Public_Function.dict.Add("sms_number", "10000005550055");
			}
			flag2 = !Public_Function.dict.ContainsKey("show_avg");
			if (flag2)
			{
				Public_Function.dict.Add("show_avg", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("kargari");
			if (flag2)
			{
				Public_Function.dict.Add("kargari", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("bedehkaran_jamkol");
			if (flag2)
			{
				Public_Function.dict.Add("bedehkaran_jamkol", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("bedehkaran_tel");
			if (flag2)
			{
				Public_Function.dict.Add("bedehkaran_tel", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("no_bed_alert");
			if (flag2)
			{
				Public_Function.dict.Add("no_bed_alert", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("no_hazine_agsat");
			if (flag2)
			{
				Public_Function.dict.Add("no_hazine_agsat", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("kharid_baz");
			if (flag2)
			{
				Public_Function.dict.Add("kharid_baz", "1");
			}
			flag2 = !Public_Function.dict.ContainsKey("altbackup");
			if (flag2)
			{
				Public_Function.dict.Add("altbackup", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("elan_check");
			if (flag2)
			{
				Public_Function.dict.Add("elan_check", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("desktop_note");
			if (flag2)
			{
				Public_Function.dict.Add("desktop_note", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("daryaftcheck");
			if (flag2)
			{
				Public_Function.dict.Add("daryaftcheck", "1111");
			}
			flag2 = !Public_Function.dict.ContainsKey("surathesab_tasvie");
			if (flag2)
			{
				Public_Function.dict.Add("surathesab_tasvie", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("auto_vusul");
			if (flag2)
			{
				Public_Function.dict.Add("auto_vusul", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("auto_vusul_d");
			if (flag2)
			{
				Public_Function.dict.Add("auto_vusul_d", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("kharid_sardkhane_factor");
			if (flag2)
			{
				Public_Function.dict.Add("kharid_sardkhane_factor", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("paper_margin_top");
			if (flag2)
			{
				Public_Function.dict.Add("paper_margin_top", "0.4");
			}
			flag2 = !Public_Function.dict.ContainsKey("moshtari_show_contact_info");
			if (flag2)
			{
				Public_Function.dict.Add("moshtari_show_contact_info", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("moshtari_show_pic");
			if (flag2)
			{
				Public_Function.dict.Add("moshtari_show_pic", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("moshtari_show_mahal");
			if (flag2)
			{
				Public_Function.dict.Add("moshtari_show_mahal", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("moshtari_exit_on_save");
			if (flag2)
			{
				Public_Function.dict.Add("moshtari_exit_on_save", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("kharid_kind");
			if (flag2)
			{
				Public_Function.dict.Add("kharid_kind", Conversions.ToString(1));
			}
			flag2 = !Public_Function.dict.ContainsKey("oft");
			if (flag2)
			{
				Public_Function.dict.Add("oft", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("oft_tedad");
			if (flag2)
			{
				Public_Function.dict.Add("oft_tedad", Conversions.ToString(false));
			}
			flag2 = !Public_Function.dict.ContainsKey("oft_kind");
			if (flag2)
			{
				Public_Function.dict.Add("oft_kind", Conversions.ToString(2));
			}
			flag2 = !Public_Function.dict.ContainsKey("kargari_sud");
			if (flag2)
			{
				Public_Function.dict.Add("kargari_sud", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("kargari_kind");
			if (flag2)
			{
				Public_Function.dict.Add("kargari_kind", Conversions.ToString(1));
			}
			flag2 = !Public_Function.dict.ContainsKey("kargari_fee");
			if (flag2)
			{
				Public_Function.dict.Add("kargari_fee", Conversions.ToString(0));
			}
			flag2 = !Public_Function.dict.ContainsKey("arz_kind");
			if (flag2)
			{
				Public_Function.dict.Add("arz_kind", "0");
			}
			flag2 = !Public_Function.dict.ContainsKey("factor_furush_sanad_kind");
			if (flag2)
			{
				Public_Function.dict.Add("factor_furush_sanad_kind", Conversions.ToString(0));
			}
			flag2 = !Public_Function.dict.ContainsKey("factor_furush_control_mojudi");
			if (flag2)
			{
				Public_Function.dict.Add("factor_furush_control_mojudi", Conversions.ToString(true));
			}
			flag2 = !Public_Function.dict.ContainsKey("multiowner");
			if (flag2)
			{
				Public_Function.dict.Add("multiowner", Conversions.ToString(false));
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0009B578 File Offset: 0x00099778
		public static string FormatPrice(string value)
		{
			bool flag = Operators.CompareString(value, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				flag = (Operators.CompareString(value, "0", false) == 0);
				if (flag)
				{
					result = "0";
				}
				else
				{
					result = Strings.FormatNumber(Conversions.ToLong(value), 0, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.False, Microsoft.VisualBasic.TriState.True);
				}
			}
			return result;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0009B5D8 File Offset: 0x000997D8
		public static void AddFilterColumn(GridEX Grid)
		{
			bool flag = Grid.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)Grid.DataSource;
				flag = !dataTable.Columns.Contains("Filter");
				if (flag)
				{
					dataTable.Columns.Add("Filter", typeof(string));
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						try
						{
							IEnumerator enumerator2 = Grid.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								flag = (Operators.CompareString(gridEXColumn.DataMember, string.Empty, false) == 0);
								if (!flag)
								{
									flag = gridEXColumn.Visible;
									if (flag)
									{
										text += dataRow[gridEXColumn.DataMember].ToString();
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
						dataRow["filter"] = text;
						text = string.Empty;
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

		// Token: 0x06000C3E RID: 3134 RVA: 0x0009B760 File Offset: 0x00099960
		public static void FilterGrid(GridEX Grid, string Text)
		{
			DataView defaultView = ((DataTable)Grid.DataSource).DefaultView;
			bool flag = Operators.CompareString(Text, string.Empty, false) == 0;
			if (flag)
			{
				defaultView.RowFilter = "";
			}
			else
			{
				defaultView.RowFilter = "filter LIKE '%" + Text + "%'";
				Grid.Refetch();
				Public_Function.HighlightCell(Grid, Text);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0009B7CC File Offset: 0x000999CC
		public static string GetPathName(DataRow dr, string prefix)
		{
			bool flag = Operators.CompareString(prefix, string.Empty, false) != 0;
			if (flag)
			{
				prefix += "_";
			}
			string text = string.Empty;
			flag = (dr[prefix + "Taf2_Name"] != DBNull.Value);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dr[prefix + "Taf2_Name"], "\\")));
			}
			flag = (dr[prefix + "Taf1_Name"] != DBNull.Value);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dr[prefix + "Taf1_Name"], "\\")));
			}
			flag = (dr[prefix + "Moin_Name"] != DBNull.Value);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dr[prefix + "Moin_Name"], "\\")));
			}
			flag = (dr[prefix + "Kol_Name"] != DBNull.Value);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, dr[prefix + "Kol_Name"]));
			}
			return text;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0009B91C File Offset: 0x00099B1C
		public static string GetLastPathName(DataRow dr, string prefix)
		{
			string empty = string.Empty;
			bool flag = Operators.CompareString(prefix, string.Empty, false) != 0;
			if (flag)
			{
				prefix += "_";
			}
			flag = (dr[prefix + "Taf2_Name"] != DBNull.Value);
			string result;
			if (flag)
			{
				result = Conversions.ToString(dr[prefix + "Taf2_Name"]);
			}
			else
			{
				flag = (dr[prefix + "Taf1_Name"] != DBNull.Value);
				if (flag)
				{
					result = Conversions.ToString(dr[prefix + "Taf1_Name"]);
				}
				else
				{
					flag = (dr[prefix + "Moin_Name"] != DBNull.Value);
					if (flag)
					{
						result = Conversions.ToString(dr[prefix + "Moin_Name"]);
					}
					else
					{
						flag = (dr[prefix + "Kol_Name"] != DBNull.Value);
						if (flag)
						{
							result = Conversions.ToString(dr[prefix + "Kol_Name"]);
						}
						else
						{
							result = empty;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0009BA40 File Offset: 0x00099C40
		public static string GetCodeName(DataRow dr, string prefix)
		{
			bool flag = Operators.CompareString(prefix, string.Empty, false) != 0;
			if (flag)
			{
				prefix += "_";
			}
			return dr[prefix + "Kol_Code"].ToString() + dr[prefix + "Moin_Code"].ToString() + dr[prefix + "Taf1_Code"].ToString() + dr[prefix + "Taf2_Code"].ToString();
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0009BAD4 File Offset: 0x00099CD4
		public static DataTable CopyTableView(DataTable tabla, string Name)
		{
			DataTable dataTable = tabla.Clone();
			bool flag = Operators.CompareString(Name, string.Empty, false) != 0;
			if (flag)
			{
				dataTable.TableName = Name;
			}
			dataTable.DefaultView.RowFilter = tabla.DefaultView.RowFilter;
			try
			{
				IEnumerator enumerator = tabla.DefaultView.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRowView dataRowView = (DataRowView)enumerator.Current;
					dataTable.ImportRow(dataRowView.Row);
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
			return dataTable;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0009BB90 File Offset: 0x00099D90
		public static void ReplaceColumnValue(GridEX grid, string Column, DataTable dt, string IdColumn, string DisplayColumn)
		{
			GridEXDropDown gridEXDropDown = grid.DropDowns.Add();
			gridEXDropDown.RootTable.Columns.Add(IdColumn, ColumnType.Text);
			gridEXDropDown.RootTable.Columns.Add(DisplayColumn, ColumnType.Text);
			gridEXDropDown.ReplaceValues = true;
			grid.RootTable.Columns[Column].HasValueList = true;
			grid.RootTable.Columns[Column].DropDown = gridEXDropDown;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					grid.RootTable.Columns[Column].ValueList.Add(RuntimeHelpers.GetObjectValue(dataRow[IdColumn]), Conversions.ToString(dataRow[DisplayColumn]));
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

		// Token: 0x06000C44 RID: 3140 RVA: 0x0009BC98 File Offset: 0x00099E98
		public static string GetValue(string s)
		{
			bool flag = Operators.CompareString(s, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = "NULL";
			}
			else
			{
				result = "N'" + s + "'";
			}
			return result;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0009BCDC File Offset: 0x00099EDC
		public static string GetValueInt(string s)
		{
			bool flag = Operators.CompareString(s, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = "NULL";
			}
			else
			{
				flag = (Operators.CompareString(s.ToLower(), "true", false) == 0);
				if (flag)
				{
					result = Conversions.ToString(1);
				}
				else
				{
					flag = (Operators.CompareString(s.ToLower(), "false", false) == 0);
					if (flag)
					{
						result = Conversions.ToString(0);
					}
					else
					{
						result = s;
					}
				}
			}
			return result;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0009BD54 File Offset: 0x00099F54
		public static object FillLeft(string s, string value, int length)
		{
			checked
			{
				for (int i = 1; i <= length; i++)
				{
					s = s.Insert(0, value);
				}
				return s;
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0009BD84 File Offset: 0x00099F84
		public static object FillZero(string s, int FixLength)
		{
			int arg_0B_0 = 1;
			checked
			{
				int num = FixLength - s.Length;
				int num2 = arg_0B_0;
				while (true)
				{
					int arg_25_0 = num2;
					int num3 = num;
					if (arg_25_0 > num3)
					{
						break;
					}
					s = s.Insert(0, "0");
					num2++;
				}
				return s;
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0009BDC0 File Offset: 0x00099FC0
		public static bool ExistValue(string TableName, string FieldName, string Value)
		{
			return Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"select top 1  ",
				FieldName,
				" from  ",
				TableName,
				" where ",
				FieldName,
				"=N'",
				Value,
				"'"
			})) != null;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0009BE3C File Offset: 0x0009A03C
		public static bool ExistValue(string TableName, string FieldName, string Value, string FieldID, string Notin)
		{
			return Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"select top 1  ",
				FieldName,
				" from  ",
				TableName,
				" where ",
				FieldName,
				"=N'",
				Value,
				"' AND ",
				FieldID,
				" NOT IN (",
				Notin,
				") "
			})) != null;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0009BED8 File Offset: 0x0009A0D8
		public static SqlCommand CreateSqlCommand(string Command)
		{
			return new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command,
				CommandType = CommandType.StoredProcedure
			};
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0009BF10 File Offset: 0x0009A110
		public static object ExecuteScalar(SqlCommand command)
		{
			return command.ExecuteScalar();
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0009BF28 File Offset: 0x0009A128
		public static object ExecuteScalar(string Command)
		{
			SqlCommand sqlCommand = new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command
			};
			object result;
			try
			{
				result = sqlCommand.ExecuteScalar();
			}
			catch (Exception expr_29)
			{
				ProjectData.SetProjectError(expr_29);
				Exception ex = expr_29;
				bool flag = ex is SqlException;
				if (flag)
				{
					bool flag2 = ((SqlException)ex).Number == 233;
					if (flag2)
					{
						Public_Function.Reconnect();
						result = sqlCommand.ExecuteScalar();
						ProjectData.ClearProjectError();
					}
					else
					{
						result = sqlCommand.ExecuteScalar();
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					result = sqlCommand.ExecuteScalar();
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0009BFE0 File Offset: 0x0009A1E0
		public static void ExecuteNonQuery(SqlCommand command)
		{
			SqlTransaction sqlTransaction = Public_Function.Connection.BeginTransaction();
			try
			{
				command.Transaction = sqlTransaction;
				command.ExecuteNonQuery();
				sqlTransaction.Commit();
			}
			catch (SqlException expr_25)
			{
				ProjectData.SetProjectError(expr_25);
				sqlTransaction.Rollback();
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0009C03C File Offset: 0x0009A23C
		public static bool ExecuteNonQuery(string Command, string mConnection)
		{
			OleDbConnection oleDbConnection = new OleDbConnection(mConnection);
			oleDbConnection.Open();
			bool result;
			try
			{
				OleDbCommand oleDbCommand = new OleDbCommand
				{
					Connection = oleDbConnection,
					CommandText = Command
				};
				oleDbCommand.ExecuteNonQuery();
				oleDbConnection.Close();
				result = true;
			}
			catch (OleDbException expr_40)
			{
				ProjectData.SetProjectError(expr_40);
				oleDbConnection.Close();
				result = false;
				ProjectData.ClearProjectError();
			}
			return result;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0009C0BC File Offset: 0x0009A2BC
		public static bool ExecuteNonQuery(string Command)
		{
			bool flag = Operators.CompareString(Command, string.Empty, false) == 0;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				SqlTransaction sqlTransaction = Public_Function.Connection.BeginTransaction();
				SqlCommand sqlCommand = new SqlCommand
				{
					Connection = Public_Function.Connection,
					CommandText = Command
				};
				sqlCommand.Transaction = sqlTransaction;
				try
				{
					sqlCommand.ExecuteNonQuery();
					sqlTransaction.Commit();
					result = true;
				}
				catch (SqlException expr_6C)
				{
					ProjectData.SetProjectError(expr_6C);
					SqlException ex = expr_6C;
					sqlTransaction.Rollback();
					flag = (ex is SqlException);
					if (flag)
					{
						bool flag2 = ex.Number == 233;
						if (flag2)
						{
							Public_Function.Reconnect();
							SqlTransaction sqlTransaction2 = Public_Function.Connection.BeginTransaction();
							sqlCommand.Transaction = sqlTransaction2;
							try
							{
								sqlCommand.ExecuteNonQuery();
								sqlTransaction2.Commit();
								result = true;
								ProjectData.ClearProjectError();
								return result;
							}
							catch (Exception expr_D9)
							{
								ProjectData.SetProjectError(expr_D9);
								sqlTransaction2.Rollback();
								result = false;
								ProjectData.ClearProjectError();
								return result;
							}
						}
						SqlTransaction sqlTransaction3 = Public_Function.Connection.BeginTransaction();
						sqlCommand.Transaction = sqlTransaction3;
						try
						{
							sqlCommand.ExecuteNonQuery();
							sqlTransaction3.Commit();
							result = true;
							ProjectData.ClearProjectError();
							return result;
						}
						catch (Exception expr_134)
						{
							ProjectData.SetProjectError(expr_134);
							sqlTransaction3.Rollback();
							result = false;
							ProjectData.ClearProjectError();
							return result;
						}
					}
					SqlTransaction sqlTransaction4 = Public_Function.Connection.BeginTransaction();
					sqlCommand.Transaction = sqlTransaction4;
					try
					{
						sqlCommand.ExecuteNonQuery();
						sqlTransaction4.Commit();
						result = true;
						ProjectData.ClearProjectError();
					}
					catch (Exception expr_18A)
					{
						ProjectData.SetProjectError(expr_18A);
						sqlTransaction4.Rollback();
						result = false;
						ProjectData.ClearProjectError();
					}
				}
			}
			return result;
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0009C2EC File Offset: 0x0009A4EC
		public static DataTable FillData_by_sp(string Command, List<SqlParameter> parameters)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command
			};
			try
			{
				try
				{
					List<SqlParameter>.Enumerator enumerator = parameters.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SqlParameter current = enumerator.Current;
						sqlDataAdapter.SelectCommand.Parameters.Add(current);
					}
				}
				finally
				{
					List<SqlParameter>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
				sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				sqlDataAdapter.Fill(dataTable);
			}
			catch (Exception expr_90)
			{
				ProjectData.SetProjectError(expr_90);
				Exception ex = expr_90;
				bool flag = ex is SqlException;
				if (flag)
				{
					bool flag2 = ((SqlException)ex).Number == 233;
					if (flag2)
					{
						Public_Function.Reconnect();
						sqlDataAdapter.Fill(dataTable);
					}
					else
					{
						sqlDataAdapter.Fill(dataTable);
					}
				}
				else
				{
					sqlDataAdapter.Fill(dataTable);
				}
				ProjectData.ClearProjectError();
			}
			return dataTable;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0009C40C File Offset: 0x0009A60C
		public static DataTable FillData(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command
			};
			try
			{
				sqlDataAdapter.Fill(dataTable);
			}
			catch (Exception expr_3E)
			{
				ProjectData.SetProjectError(expr_3E);
				Exception ex = expr_3E;
				bool flag = ex is SqlException;
				if (flag)
				{
					bool flag2 = ((SqlException)ex).Number == 233;
					if (flag2)
					{
						Public_Function.Reconnect();
						sqlDataAdapter.Fill(dataTable);
					}
					else
					{
						sqlDataAdapter.Fill(dataTable);
					}
				}
				else
				{
					sqlDataAdapter.Fill(dataTable);
				}
				ProjectData.ClearProjectError();
			}
			return dataTable;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0009C4CC File Offset: 0x0009A6CC
		public static DataTable FillSchema(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command
			};
			try
			{
				sqlDataAdapter.Fill(dataTable);
			}
			catch (Exception expr_3E)
			{
				ProjectData.SetProjectError(expr_3E);
				Exception ex = expr_3E;
				bool flag = ex is SqlException;
				if (flag)
				{
					bool flag2 = ((SqlException)ex).Number == 233;
					if (flag2)
					{
						Public_Function.Reconnect();
						sqlDataAdapter.FillSchema(dataTable, SchemaType.Mapped);
					}
					else
					{
						sqlDataAdapter.FillSchema(dataTable, SchemaType.Mapped);
					}
				}
				else
				{
					sqlDataAdapter.FillSchema(dataTable, SchemaType.Mapped);
				}
				ProjectData.ClearProjectError();
			}
			return dataTable;
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0009C58C File Offset: 0x0009A78C
		public static DataRow FillDataRow(string Command)
		{
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
			DataTable dataTable = new DataTable();
			sqlDataAdapter.SelectCommand = new SqlCommand
			{
				Connection = Public_Function.Connection,
				CommandText = Command
			};
			bool flag2;
			try
			{
				sqlDataAdapter.Fill(dataTable);
			}
			catch (Exception expr_3E)
			{
				ProjectData.SetProjectError(expr_3E);
				Exception ex = expr_3E;
				bool flag = ex is SqlException;
				if (flag)
				{
					flag2 = (((SqlException)ex).Number == 233);
					if (flag2)
					{
						Public_Function.Reconnect();
						sqlDataAdapter.Fill(dataTable);
					}
					else
					{
						sqlDataAdapter.Fill(dataTable);
					}
				}
				else
				{
					sqlDataAdapter.Fill(dataTable);
				}
				ProjectData.ClearProjectError();
			}
			flag2 = (dataTable.Rows.Count > 0);
			DataRow result;
			if (flag2)
			{
				result = dataTable.Rows[0];
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00004774 File Offset: 0x00002974
		public static void Reconnect()
		{
			Public_Function.Connection.Close();
			Public_Function.Connection.Open();
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0009C670 File Offset: 0x0009A870
		public static string GetID(DataTable Dt, string idcolumn, string defaultvalue = "")
		{
			string text = string.Empty;
			bool flag = Dt == null;
			string result;
			if (flag)
			{
				bool flag2 = Operators.CompareString(defaultvalue, "", false) == 0;
				if (flag2)
				{
					result = text;
				}
				else
				{
					result = defaultvalue;
				}
			}
			else
			{
				bool flag2 = Dt.Rows.Count == 0;
				if (flag2)
				{
					flag = (Operators.CompareString(defaultvalue, "", false) == 0);
					if (flag)
					{
						result = text;
					}
					else
					{
						result = defaultvalue;
					}
				}
				else
				{
					try
					{
						IEnumerator enumerator = Dt.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							flag2 = (dataRow[idcolumn] != DBNull.Value);
							if (flag2)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow[idcolumn], ",")));
							}
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
					text = Public_Function.RemoveLast(text);
					result = text;
				}
			}
			return result;
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0009C790 File Offset: 0x0009A990
		public static string GetID(DataRow[] dr, string IDColumn)
		{
			string text = string.Empty;
			bool flag = dr.Length == 0;
			checked
			{
				string result;
				if (flag)
				{
					result = text;
				}
				else
				{
					for (int i = 0; i < dr.Length; i++)
					{
						DataRow dataRow = dr[i];
						flag = (dataRow[IDColumn] != DBNull.Value);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow[IDColumn], ",")));
						}
					}
					text = Public_Function.RemoveLast(text);
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0009C814 File Offset: 0x0009AA14
		public static string GetUniqueID(DataTable dt, string Column)
		{
			string text = string.Empty;
			List<string> list = new List<string>();
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow[Column] == DBNull.Value;
					if (!flag)
					{
						flag = !list.Contains(Conversions.ToString(dataRow[Column]));
						if (flag)
						{
							list.Add(Conversions.ToString(dataRow[Column]));
						}
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
			try
			{
				List<string>.Enumerator enumerator2 = list.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					string current = enumerator2.Current;
					text = text + current + ",";
				}
			}
			finally
			{
				List<string>.Enumerator enumerator2;
				((IDisposable)enumerator2).Dispose();
			}
			text = Public_Function.RemoveLast(text);
			return text;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0009C930 File Offset: 0x0009AB30
		public static string GetID(List<long> dt)
		{
			string text = string.Empty;
			try
			{
				List<long>.Enumerator enumerator = dt.GetEnumerator();
				while (enumerator.MoveNext())
				{
					long current = enumerator.Current;
					text = text + Conversions.ToString(current) + ",";
				}
			}
			finally
			{
				List<long>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			text = Public_Function.RemoveLast(text);
			return text;
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
		public static string GetID(List<string> dt)
		{
			string text = string.Empty;
			try
			{
				List<string>.Enumerator enumerator = dt.GetEnumerator();
				while (enumerator.MoveNext())
				{
					string current = enumerator.Current;
					text = text + Public_Function.GetValue(current) + ",";
				}
			}
			finally
			{
				List<string>.Enumerator enumerator;
				((IDisposable)enumerator).Dispose();
			}
			text = Public_Function.RemoveLast(text);
			return text;
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0009CA18 File Offset: 0x0009AC18
		public static string RemoveLast(string s)
		{
			bool flag = s == null;
			if (flag)
			{
				s = string.Empty;
			}
			else
			{
				flag = (s.Length > 0);
				if (flag)
				{
					s = s.Remove(checked(s.Length - 1), 1);
				}
			}
			return s;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0009CA60 File Offset: 0x0009AC60
		public static string RemoveLast(string s, int count)
		{
			bool flag = s == null;
			if (flag)
			{
				s = string.Empty;
			}
			else
			{
				flag = (s.Length > 0);
				if (flag)
				{
					s = s.Remove(checked(s.Length - count), count);
				}
			}
			return s;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0009CAA8 File Offset: 0x0009ACA8
		public static DialogResult ShowMessage(string Message, MessageBoxButtons Buttons, MessageBoxIcon icon, ErrorListManager ErrorList = null)
		{
			Frm_MessageBox frm_MessageBox = new Frm_MessageBox
			{
				ErrorList = ErrorList
			};
			frm_MessageBox.Label1.Text = Message;
			switch (Buttons)
			{
			case MessageBoxButtons.OK:
				frm_MessageBox.btn_ok.Visible = true;
				break;
			case MessageBoxButtons.OKCancel:
				frm_MessageBox.btn_ok.Visible = true;
				frm_MessageBox.btn_cancel.Visible = true;
				break;
			case MessageBoxButtons.YesNoCancel:
				frm_MessageBox.btn_yes.Visible = true;
				frm_MessageBox.btn_no.Visible = true;
				frm_MessageBox.UiButton2.Visible = true;
				break;
			case MessageBoxButtons.YesNo:
				frm_MessageBox.btn_yes.Visible = true;
				frm_MessageBox.btn_no.Visible = true;
				break;
			}
			bool flag = icon == MessageBoxIcon.Asterisk;
			if (flag)
			{
				frm_MessageBox.pic_info.Visible = true;
			}
			else
			{
				flag = (icon == MessageBoxIcon.Hand);
				if (flag)
				{
					frm_MessageBox.pic_error.Visible = true;
				}
				else
				{
					flag = (icon == MessageBoxIcon.Question);
					if (flag)
					{
						frm_MessageBox.pic_question.Visible = true;
					}
					else
					{
						flag = (icon == MessageBoxIcon.Exclamation);
						if (flag)
						{
							frm_MessageBox.pic_warning.Visible = true;
						}
					}
				}
			}
			return frm_MessageBox.ShowDialog();
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0009CBE4 File Offset: 0x0009ADE4
		public static DialogResult ConfirmUpdate()
		{
			return Public_Function.ShowMessage("آیا مایل به اصلاح اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null);
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0009CC04 File Offset: 0x0009AE04
		public static DialogResult ConfirmDelete()
		{
			return Public_Function.ShowMessage("آیا مایل به حذف اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0009CC24 File Offset: 0x0009AE24
		public static DialogResult ConfirmDeleteAction()
		{
			return Public_Function.ShowMessage("اطلاعات مورد نظر با موفقیت حذف گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0009CC44 File Offset: 0x0009AE44
		public static DialogResult ConfirmInsert()
		{
			return Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0009CC64 File Offset: 0x0009AE64
		public static void HighlightCell(GridEX grid, string Value)
		{
			GridEXRow[] rows = grid.GetRows();
			checked
			{
				for (int i = 0; i < rows.Length; i++)
				{
					GridEXRow gridEXRow = rows[i];
					try
					{
						IEnumerator enumerator = ((IEnumerable)gridEXRow.Cells).GetEnumerator();
						while (enumerator.MoveNext())
						{
							GridEXCell gridEXCell = (GridEXCell)enumerator.Current;
							bool flag = gridEXCell.Value != null;
							bool flag2;
							if (flag)
							{
								flag2 = gridEXCell.Value.ToString().Contains(Value);
								if (flag2)
								{
									gridEXCell.FormatStyle = new GridEXFormatStyle();
									gridEXCell.FormatStyle.BackColor = Color.Khaki;
								}
							}
							flag2 = gridEXCell.Text.Contains(Value);
							if (flag2)
							{
								gridEXCell.FormatStyle = new GridEXFormatStyle();
								gridEXCell.FormatStyle.BackColor = Color.Khaki;
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

		// Token: 0x06000C62 RID: 3170 RVA: 0x0009CD78 File Offset: 0x0009AF78
		public static string ShamsiToMiladi(string datefa)
		{
			bool flag = Operators.CompareString(datefa, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				PersianCalendar persianCalendar = new PersianCalendar();
				string[] array = datefa.Split(new char[]
				{
					'/'
				});
				result = persianCalendar.ToDateTime(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), 0, 0, 0, 0).ToShortDateString();
			}
			return result;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0009CDF0 File Offset: 0x0009AFF0
		public static string MiladiToShamsi(DateTime datetime)
		{
			PersianCalendar persianCalendar = new PersianCalendar();
			return string.Concat(new string[]
			{
				Conversions.ToString(persianCalendar.GetYear(datetime)),
				"/",
				Strings.Format(persianCalendar.GetMonth(datetime), "00"),
				"/",
				Strings.Format(persianCalendar.GetDayOfMonth(datetime), "00")
			});
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0009CE6C File Offset: 0x0009B06C
		public static bool IsValidShamsiDate(string datefa)
		{
			bool flag = Operators.CompareString(datefa, string.Empty, false) == 0;
			bool result;
			if (flag)
			{
				result = true;
			}
			else
			{
				try
				{
					PersianCalendar persianCalendar = new PersianCalendar();
					string[] array = datefa.Split(new char[]
					{
						'/'
					});
					persianCalendar.ToDateTime(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]), 0, 0, 0, 0);
					result = true;
				}
				catch (Exception expr_62)
				{
					ProjectData.SetProjectError(expr_62);
					result = false;
					ProjectData.ClearProjectError();
				}
			}
			return result;
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0009CF08 File Offset: 0x0009B108
		public static bool HasNull(Control control)
		{
			bool result;
			try
			{
				IEnumerator enumerator = control.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control2 = (Control)enumerator.Current;
					bool flag = control2 is DateBox;
					bool flag2;
					if (flag)
					{
						flag2 = ((DateBox)control2).NullCheck();
						if (flag2)
						{
							result = true;
							return result;
						}
					}
					flag2 = (control2 is EditBox);
					if (flag2)
					{
						flag = ((EditBox)control2).NullCheck();
						if (flag)
						{
							result = true;
							return result;
						}
					}
					flag2 = (control2 is CurrencyBox);
					if (flag2)
					{
						flag = ((CurrencyBox)control2).NullCheck();
						if (flag)
						{
							result = true;
							return result;
						}
					}
					flag2 = (control2 is NumericBox);
					if (flag2)
					{
						flag = ((NumericBox)control2).NullCheck();
						if (flag)
						{
							result = true;
							return result;
						}
					}
					flag2 = (control2 is ComboBox);
					if (flag2)
					{
						flag = ((ComboBox)control2).NullCheck();
						if (flag)
						{
							result = true;
							return result;
						}
					}
					flag2 = (control2 is SelectItem);
					if (flag2)
					{
						flag = ((SelectItem)control2).NullCheck();
						if (flag)
						{
							result = true;
							return result;
						}
					}
					flag2 = Public_Function.HasNull(control2);
					if (flag2)
					{
						result = true;
						return result;
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
			result = false;
			return result;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0009D080 File Offset: 0x0009B280
		public static void SetNew(Control control)
		{
			try
			{
				IEnumerator enumerator = control.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control control2 = (Control)enumerator.Current;
					bool flag = control2 is EditBox;
					if (flag)
					{
						((EditBox)control2).SetNew();
					}
					flag = (control2 is SelectItem);
					if (flag)
					{
						((SelectItem)control2).SetNew();
					}
					flag = (control2 is NumericBox);
					if (flag)
					{
						((NumericBox)control2).SetNew();
					}
					flag = (control2 is CurrencyBox);
					if (flag)
					{
						((CurrencyBox)control2).SetNew();
					}
					flag = (control2 is ComboBox);
					if (flag)
					{
						((ComboBox)control2).SetNew();
					}
					flag = (control2 is DateBox2);
					if (flag)
					{
						((DateBox2)control2).SetNew();
					}
					flag = (control2.Controls.Count > 0);
					if (flag)
					{
						Public_Function.SetNew(control2);
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

		// Token: 0x06000C67 RID: 3175 RVA: 0x0009D1A4 File Offset: 0x0009B3A4
		public static string GetMonthName(int Month_Id)
		{
			return Public_Function.MonthName[Month_Id];
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0009D1C0 File Offset: 0x0009B3C0
		public static string GetDayName(int day)
		{
			return Public_Function.DayName[day];
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0009D1DC File Offset: 0x0009B3DC
		public static void validateTwoControl(Control ctl1, Control ctl2)
		{
			bool flag = Operators.CompareString(ctl1.Text, string.Empty, false) == 0;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(ctl2.Text, string.Empty, false) != 0);
				if (!flag2)
				{
					return;
				}
				ctl1.Text = ctl2.Text;
			}
			flag2 = (Operators.CompareString(ctl2.Text, string.Empty, false) == 0);
			if (flag2)
			{
				flag = (Operators.CompareString(ctl1.Text, string.Empty, false) != 0);
				if (!flag)
				{
					return;
				}
				ctl2.Text = ctl1.Text;
			}
			flag2 = (Conversions.ToLong(ctl1.Text) > Conversions.ToLong(ctl2.Text));
			if (flag2)
			{
				ctl1.Tag = ctl1.Text;
				ctl1.Text = ctl2.Text;
				ctl2.Text = Conversions.ToString(ctl1.Tag);
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0009D2C8 File Offset: 0x0009B4C8
		public static void ShowTip(Control control, string Text)
		{
			control.Focus();
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.RightToLeft = true;
			janusSuperTip.AutoPopDelay = 0;
			janusSuperTip.InitialDelay = 0;
			janusSuperTip.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.HeaderImage = Resources.onebit_36;
			superTipSettings.HeaderText = "خطا";
			superTipSettings.Text = Text;
			Rectangle bounds = control.Bounds;
			bounds.Location = control.Parent.PointToScreen(bounds.Location);
			JanusSuperTip arg_AA_0 = janusSuperTip;
			SuperTipSettings arg_AA_1 = superTipSettings;
			Point position = new Point(bounds.Left, bounds.Bottom);
			arg_AA_0.Show(arg_AA_1, control, position, 2500);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0009D388 File Offset: 0x0009B588
		public static void GridRaiseSoftError(GridEX grid, GridEXRow row, string Column, string NullToolTipText)
		{
			grid.Row = row.Position;
			JanusSuperTip janusSuperTip = new JanusSuperTip();
			janusSuperTip.BodyWidth = 250;
			janusSuperTip.RightToLeft = true;
			janusSuperTip.AutoPopDelay = 0;
			janusSuperTip.InitialDelay = 0;
			janusSuperTip.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			SuperTipSettings superTipSettings = new SuperTipSettings();
			superTipSettings.Text = NullToolTipText;
			Rectangle cellBounds = grid.GetCellBounds(grid.Row, grid.RootTable.Columns[Column].Position);
			Rectangle bounds = grid.Bounds;
			bounds.Location = grid.Parent.PointToScreen(bounds.Location);
			superTipSettings.HeaderImage = Resources.onebit_36;
			superTipSettings.HeaderText = "خطا";
			grid.Focus();
			grid.Col = grid.RootTable.Columns[Column].Position;
			grid.EditMode = EditMode.EditOn;
			JanusSuperTip arg_11B_0 = janusSuperTip;
			SuperTipSettings arg_11B_1 = superTipSettings;
			Point position = checked(new Point(bounds.Left + cellBounds.Left, bounds.Top + cellBounds.Bottom));
			arg_11B_0.Show(arg_11B_1, grid, position, 2500);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0009D4B8 File Offset: 0x0009B6B8
		public static void SetFarsi()
		{
			try
			{
				try
				{
					IEnumerator enumerator = InputLanguage.InstalledInputLanguages.GetEnumerator();
					while (enumerator.MoveNext())
					{
						InputLanguage inputLanguage = (InputLanguage)enumerator.Current;
						bool flag = Operators.CompareString(inputLanguage.Culture.Name.ToLower(), "fa-ir", false) == 0;
						if (flag)
						{
							Application.CurrentInputLanguage = inputLanguage;
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
			catch (Exception expr_74)
			{
				ProjectData.SetProjectError(expr_74);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x0009D568 File Offset: 0x0009B768
		public static void SetEnglish()
		{
			try
			{
				try
				{
					IEnumerator enumerator = InputLanguage.InstalledInputLanguages.GetEnumerator();
					while (enumerator.MoveNext())
					{
						InputLanguage inputLanguage = (InputLanguage)enumerator.Current;
						bool flag = Operators.CompareString(inputLanguage.Culture.Name.ToLower(), "en-us", false) == 0;
						if (flag)
						{
							Application.CurrentInputLanguage = inputLanguage;
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
			catch (Exception expr_74)
			{
				ProjectData.SetProjectError(expr_74);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x0009D618 File Offset: 0x0009B818
		public static string ToFarsis(string s)
		{
			bool flag = Operators.CompareString(s, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = " ";
			}
			else
			{
				result = "{tofarsis(" + s + ")}";
			}
			return result;
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0009D658 File Offset: 0x0009B858
		public static string ToFarsi(string s)
		{
			string text = "1234567890";
			char[] array = s.ToCharArray(0, s.Length);
			string text2 = string.Empty;
			int arg_26_0 = 0;
			checked
			{
				int num = s.Length - 1;
				int num2 = arg_26_0;
				while (true)
				{
					int arg_7B_0 = num2;
					int num3 = num;
					if (arg_7B_0 > num3)
					{
						break;
					}
					bool flag = text.IndexOf(array[num2]) == -1;
					if (flag)
					{
						text2 += Conversions.ToString(array[num2]);
					}
					else
					{
						text2 += Conversions.ToString(Strings.ChrW((int)(array[num2] + 'ۀ')));
					}
					num2++;
				}
				return text2;
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0000205D File Offset: 0x0000025D
		public static void InvokeMethod(string methodName)
		{
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0000205D File Offset: 0x0000025D
		public static void InvokeMethod(string OwnerFrm, string methodName, object[] Parameters)
		{
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0009D6E8 File Offset: 0x0009B8E8
		public static string GetSum(DataTable dt, string field)
		{
			bool flag = dt == null;
			string result;
			if (flag)
			{
				result = Conversions.ToString(0);
			}
			else
			{
				decimal num = 0m;
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow[field] != DBNull.Value);
						if (flag)
						{
							num = Conversions.ToDecimal(Operators.AddObject(num, dataRow[field]));
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
				result = Conversions.ToString(num);
			}
			return result;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x0009D7AC File Offset: 0x0009B9AC
		public static string GetSum(DataRow[] dr, string field)
		{
			bool flag = dr == null;
			checked
			{
				string result;
				if (flag)
				{
					result = Conversions.ToString(0);
				}
				else
				{
					flag = (dr.Length == 0);
					if (flag)
					{
						result = Conversions.ToString(0);
					}
					else
					{
						decimal num = 0m;
						for (int i = 0; i < dr.Length; i++)
						{
							DataRow dataRow = dr[i];
							flag = (dataRow[field] != DBNull.Value);
							if (flag)
							{
								num = Conversions.ToDecimal(Operators.AddObject(num, dataRow[field]));
							}
						}
						result = Conversions.ToString(num);
					}
				}
				return result;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0009D844 File Offset: 0x0009BA44
		public static int GetRandom(int Min, int Max)
		{
			Random random = new Random();
			Random random2 = new Random(random.Next(0, 1000));
			return random2.Next(Min, Max);
		}

		// Token: 0x040004BE RID: 1214
		[CompilerGenerated]
		private static SqlConnection _Connection;

		// Token: 0x040004BF RID: 1215
		[CompilerGenerated]
		private static CurrentData _CurrentData;

		// Token: 0x040004C0 RID: 1216
		[CompilerGenerated]
		private static string _Server;

		// Token: 0x040004C1 RID: 1217
		[CompilerGenerated]
		private static string _SQLInstance;

		// Token: 0x040004C2 RID: 1218
		public static Dictionary<string, string> dict;

		// Token: 0x040004C3 RID: 1219
		public static DataTable Dt_FrmSize;

		// Token: 0x040004C4 RID: 1220
		private static string[] DayName;

		// Token: 0x040004C5 RID: 1221
		private static string[] MonthName;

		// Token: 0x040004C6 RID: 1222
		[CompilerGenerated]
		private static int _AppType;

		// Token: 0x0200008B RID: 139
		public enum OperandType
		{
			// Token: 0x040004C8 RID: 1224
			where = 1,
			// Token: 0x040004C9 RID: 1225
			AND_,
			// Token: 0x040004CA RID: 1226
			OR_
		}
	}
}
