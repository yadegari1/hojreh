using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x0200004E RID: 78
	public class VagozariPrint
	{
		// Token: 0x06000385 RID: 901 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public VagozariPrint()
		{
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0004B5C0 File Offset: 0x000497C0
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00002855 File Offset: 0x00000A55
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

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0004B5D8 File Offset: 0x000497D8
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000285F File Offset: 0x00000A5F
		public int BankHesab_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_ID = value;
			}
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0004B5F0 File Offset: 0x000497F0
		private void Preparedt(DataRow dr)
		{
			this.dt2 = this.dt.Copy();
			this.dt2.Columns["sh_check"].ColumnName = "شماره_چک";
			this.dt2.Columns.Remove("ID");
			this.dt2.Columns.Remove("dptype_id");
			this.dt2.Columns.Remove("Tarikh");
			this.dt2.Columns.Remove("sanadbed_id");
			this.dt2.Columns.Remove("sanadbes_id");
			this.dt2.Columns.Remove("moshtari_id");
			this.dt2.Columns.Remove("sandug_id");
			this.dt2.Columns.Remove("bankhesab_id");
			this.dt2.Columns.Remove("tarikh_fa");
			this.dt2.Columns.Remove("Parent_ID");
			bool flag = this.dt2.Columns.Contains("dp_name");
			if (flag)
			{
				this.dt2.Columns.Remove("dp_name");
			}
			this.dt2.Columns.Remove("check_status");
			this.dt2.Columns.Remove("sh_fish");
			this.dt2.Columns.Remove("fishvariz");
			this.dt2.Columns.Remove("fishvariz_fa");
			this.dt2.Columns.Remove("hazine_ID");
			flag = this.dt2.Columns.Contains("hazine_name");
			if (flag)
			{
				this.dt2.Columns.Remove("Hazine_Name");
			}
			this.dt2.Columns.Remove("pardakhtcheck_ID");
			this.dt2.Columns.Remove("Tozih");
			this.dt2.Columns.Remove("check_sarresid");
			flag = this.dt2.Columns.Contains("moshtari_name");
			if (flag)
			{
				this.dt2.Columns.Remove("moshtari_name");
			}
			this.dt2.Columns.Remove("checkbarg_id");
			flag = this.dt2.Columns.Contains("daryaft_identity");
			if (flag)
			{
				this.dt2.Columns.Remove("daryaft_identity");
			}
			flag = this.dt2.Columns.Contains("is_child");
			if (flag)
			{
				this.dt2.Columns.Remove("is_child");
			}
			flag = this.dt2.Columns.Contains("identity");
			if (flag)
			{
				this.dt2.Columns.Remove("identity");
			}
			flag = this.dt2.Columns.Contains("parent_identity");
			if (flag)
			{
				this.dt2.Columns.Remove("parent_identity");
			}
			flag = this.dt2.Columns.Contains("moshtari_id2");
			if (flag)
			{
				this.dt2.Columns.Remove("moshtari_id2");
			}
			flag = this.dt2.Columns.Contains("moshtari_name2");
			if (flag)
			{
				this.dt2.Columns.Remove("moshtari_name2");
			}
			this.dt2.Columns["mablagh"].ColumnName = "مبلغ";
			this.dt2.Columns["check_shomarehesab"].ColumnName = "شماره_حساب_چک";
			this.dt2.Columns["check_sarresid_fa"].ColumnName = "تاریخ_چک";
			this.dt2.Columns.Add(new DataColumn("bankshobe", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("huruf", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("تلفن", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("آدرس", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("شعبه_بانک", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("کدملی", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("شماره_شناسنامه", typeof(string)));
			this.dt2.Columns.Add(new DataColumn("کدپستی", typeof(string)));
			try
			{
				IEnumerator enumerator = this.dt2.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["bankshobe"] = Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["checkbank_name"], "/"), dataRow["check_shobe"]);
					dataRow["huruf"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow["مبلغ"]), huruf.ConvertType.هیچکدام);
					dataRow["تلفن"] = dr["tel"].ToString();
					dataRow["آدرس"] = dr["address"].ToString();
					dataRow["شماره_حساب"] = dr["sh_hesab"].ToString();
					dataRow["صاحب_حساب"] = dr["sahebhesab"].ToString();
					dataRow["شعبه_بانک"] = dr["shobe"].ToString();
					dataRow["کدملی"] = dr["codemelli"].ToString();
					dataRow["شماره_شناسنامه"] = dr["shsh"].ToString();
					dataRow["کدپستی"] = dr["codeposti"].ToString();
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
			this.dt2.Columns["bankshobe"].ColumnName = "بانک_شعبه_چک";
			this.dt2.Columns["huruf"].ColumnName = "مبلغ_به_حروف";
			this.dt2.Columns["checkbank_name"].ColumnName = "بانک_چک";
			this.dt2.Columns["check_shobe"].ColumnName = "شعبه_چک";
			this.dt2.Columns.Remove("bankhesab_name");
			this.dt2.TableName = "data";
			this.dtparent = this.Createparentdt(this.dt2, Conversions.ToInteger(dr["bank_ID"]));
			this.dtparent.TableName = "parent";
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0004BDD0 File Offset: 0x00049FD0
		private void design_print(StiReport rpt, int bank_ID)
		{
			StiOptions.Designer.DontAskSaveReport = true;
			StiOptions.Designer.DontSaveDesignerConfig = true;
			StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
			StiOptions.Designer.AllowSaveStandaloneReport = false;
			StiOptions.Designer.CodeTabVisible = false;
			StiOptions.Designer.HtmlPreviewReportVisible = false;
			rpt.Pages[0].Margins = new StiMargins(0.0, 0.0, 0.0, 0.0);
			rpt.Design();
			rpt.Save(Application.StartupPath + "\\reports\\bank\\vagozari\\" + Conversions.ToString(bank_ID) + ".mrt");
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0004BE70 File Offset: 0x0004A070
		private DataTable Createparentdt(DataTable data, int bank_ID)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(vagozaricount,5) from bank where id=" + Conversions.ToString(bank_ID)));
			data.Columns.Add("Ch", typeof(bool));
			data.Columns.Add("parent_id", typeof(int));
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ID", typeof(int));
			dataTable.Columns.Add("tarikh", typeof(string));
			dataTable.Columns.Add("cnt", typeof(int));
			dataTable.Columns.Add("تعداد_چک", typeof(string));
			dataTable.Columns.Add("مبلغ_به_حروف", typeof(string));
			dataTable.Columns.Add("جمع_مبلغ", typeof(long));
			dataTable.Columns.Add("تاریخ_امروز", typeof(string));
			dataTable.Columns.Add("شماره_صفحه", typeof(string));
			int num2 = 1;
			checked
			{
				try
				{
					IEnumerator enumerator = data.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag = Operators.ConditionalCompareObjectEqual(dataRow["checkbank_id"], bank_ID, false);
						if (flag)
						{
							dataTable.Rows.Add(new object[]
							{
								num2,
								"",
								1
							});
							dataRow["parent_id"] = num2;
							dataRow["ch"] = true;
							num2++;
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
				int num3 = 0;
				try
				{
					IEnumerator enumerator2 = data.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = Operators.ConditionalCompareObjectLess(dataRow2["تاریخ_چک"], Public_Function.dict["today"], false);
						if (flag)
						{
							bool flag2 = dataRow2["ch"] == DBNull.Value;
							if (flag2)
							{
								dataRow2["parent_id"] = num2;
								dataRow2["ch"] = true;
								num3++;
								flag2 = (num3 == 1);
								if (flag2)
								{
									dataTable.Rows.Add(new object[]
									{
										num2,
										"",
										1
									});
								}
								else
								{
									dataTable.Rows[dataTable.Rows.Count - 1]["cnt"] = num3;
								}
								flag2 = (num3 == num);
								if (flag2)
								{
									num2++;
									num3 = 0;
								}
							}
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
				try
				{
					IEnumerator enumerator3 = data.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator3.Current;
						bool flag2 = dataRow3["ch"] == DBNull.Value;
						if (flag2)
						{
							DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow3["تاریخ_چک"]), "'")));
							flag2 = (array.Length > 0);
							if (flag2)
							{
								DataRow[] array2 = array;
								for (int i = 0; i < array2.Length; i++)
								{
									DataRow dataRow4 = array2[i];
									bool flag = Operators.ConditionalCompareObjectLessEqual(dataRow4["cnt"], num, false);
									if (flag)
									{
										DataRow dataRow5 = dataRow4;
										DataRow arg_430_0 = dataRow5;
										string columnName = "cnt";
										arg_430_0[columnName] = Operators.AddObject(dataRow5[columnName], 1);
										dataRow3["ch"] = true;
										dataRow3["parent_id"] = RuntimeHelpers.GetObjectValue(dataRow4["ID"]);
										flag2 = Operators.ConditionalCompareObjectEqual(dataRow4["cnt"], num + 1, false);
										if (flag2)
										{
											num2++;
											dataTable.Rows.Add(new object[]
											{
												num2,
												RuntimeHelpers.GetObjectValue(dataRow3["تاریخ_چک"]),
												1
											});
											dataRow3["parent_id"] = num2;
											dataRow3["ch"] = true;
										}
									}
								}
							}
							else
							{
								num2++;
								dataTable.Rows.Add(new object[]
								{
									num2,
									RuntimeHelpers.GetObjectValue(dataRow3["تاریخ_چک"]),
									1
								});
								dataRow3["parent_id"] = num2;
								dataRow3["ch"] = true;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag2 = enumerator3 is IDisposable;
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				int num4 = 0;
				try
				{
					IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						DataRow dataRow6 = (DataRow)enumerator4.Current;
						num4++;
						dataRow6["شماره_صفحه"] = num4;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow6["cnt"], num + 1, false);
						if (flag2)
						{
							dataRow6["cnt"] = num;
						}
						dataRow6["تاریخ_امروز"] = Public_Function.dict["today"];
						dataRow6["تعداد_چک"] = huruf.ConvertToHuruf(Conversions.ToString(dataRow6["cnt"]), huruf.ConvertType.هیچکدام);
						DataRow[] array3 = data.Select(Conversions.ToString(Operators.ConcatenateObject("parent_id=", dataRow6["id"])));
						flag2 = (array3.Length > 0);
						if (flag2)
						{
							long num5 = 0L;
							DataRow[] array4 = array3;
							for (int j = 0; j < array4.Length; j++)
							{
								DataRow dataRow7 = array4[j];
								num5 = Conversions.ToLong(Operators.AddObject(num5, dataRow7["مبلغ"]));
							}
							dataRow6["مبلغ_به_حروف"] = huruf.ConvertToHuruf(Conversions.ToString(num5), huruf.ConvertType.هیچکدام);
							dataRow6["جمع_مبلغ"] = num5;
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					bool flag2 = enumerator4 is IDisposable;
					if (flag2)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				return dataTable;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0004C638 File Offset: 0x0004A838
		public void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + Conversions.ToString(this.BankHesab_ID));
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			this.Preparedt(dataRow);
			bool flag = !File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")));
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگ واگذاری به بانک ", dataRow2["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
				if (flag2)
				{
					stiReport.RegData(this.dtparent);
					stiReport.RegData(this.dt2);
					this.design_print(stiReport, Conversions.ToInteger(dataRow["bank_ID"]));
				}
			}
			else
			{
				NewLateBinding.LateCall(stiReport, null, "Load", new object[]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\vagozari\\", dataRow2["ID"]), ".mrt")
				}, null, null, null, true);
				int num = 3;
				bool flag2 = dataRow2["copies"] != DBNull.Value;
				if (flag2)
				{
					num = Conversions.ToInteger(dataRow2["copies"]);
				}
				stiReport.RegData(this.dtparent);
				stiReport.RegData(this.dt2);
				flag2 = !Design;
				if (flag2)
				{
					Public_Function.AddTazminText(stiReport, true, false);
					stiReport.Print(false, checked((short)num));
				}
				else
				{
					this.design_print(stiReport, Conversions.ToInteger(dataRow["bank_id"]));
				}
			}
		}

		// Token: 0x04000170 RID: 368
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04000171 RID: 369
		[CompilerGenerated]
		private int _BankHesab_ID;

		// Token: 0x04000172 RID: 370
		private DataTable dt2;

		// Token: 0x04000173 RID: 371
		private DataTable dtparent;
	}
}
