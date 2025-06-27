using System;
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
	// Token: 0x0200004F RID: 79
	public class varizprint
	{
		// Token: 0x0600038E RID: 910 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public varizprint()
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0004C82C File Offset: 0x0004AA2C
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00002869 File Offset: 0x00000A69
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

		// Token: 0x06000391 RID: 913 RVA: 0x0004C844 File Offset: 0x0004AA44
		private void PrepareDt(DataRow bank, DataRow bankhesab, bool fl)
		{
			this.dt.Columns.Remove("ID");
			this.dt.Columns.Remove("dptype_id");
			this.dt.Columns.Remove("Tarikh");
			this.dt.Columns.Remove("sanadbed_id");
			this.dt.Columns.Remove("sanadbes_id");
			this.dt.Columns.Remove("sandug_id");
			this.dt.Columns.Remove("bankhesab_id");
			this.dt.Columns.Remove("tarikh_fa");
			this.dt.Columns.Remove("checkbank_id");
			this.dt.Columns.Remove("Parent_ID");
			this.dt.Columns.Remove("dp_name");
			this.dt.Columns.Remove("check_status");
			this.dt.Columns.Remove("sh_fish");
			this.dt.Columns.Remove("fishvariz");
			this.dt.Columns.Remove("fishvariz_fa");
			this.dt.Columns.Remove("hazine_ID");
			this.dt.Columns.Remove("Hazine_Name");
			this.dt.Columns.Remove("pardakhtcheck_ID");
			this.dt.Columns.Remove("check_sarresid");
			this.dt.Columns.Remove("checkbarg_id");
			this.dt.Columns.Remove("daryaft_identity");
			this.dt.Columns.Remove("is_child");
			this.dt.Columns.Remove("identity");
			this.dt.Columns.Remove("parent_identity");
			this.dt.Columns.Remove("Sh_check");
			this.dt.Columns.Remove("check_shobe");
			this.dt.Columns.Remove("check_shomarehesab");
			this.dt.Columns.Remove("check_sarresid_fa");
			this.dt.Columns.Remove("checkbank_name");
			this.dt.Columns.Remove("bankhesab_name");
			this.dt.Columns.Remove("moshtari_id2");
			this.dt.Columns.Remove("moshtari_name2");
			this.dt.Columns["mablagh"].ColumnName = "مبلغ";
			this.dt.Columns.Add(new DataColumn("شعبه", typeof(string)));
			this.dt.Columns.Add(new DataColumn("مبلغ_به_حروف", typeof(string)));
			this.dt.Columns.Add(new DataColumn("شماره_حساب", typeof(string)));
			this.dt.Columns.Add(new DataColumn("صاحب_حساب", typeof(string)));
			this.dt.Columns.Add(new DataColumn("تاریخ", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_نام", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_کدملی", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_تلفن", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_شناسنامه", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_پدر", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_تاریخ_تولد", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_کدپستی", typeof(string)));
			this.dt.Columns.Add(new DataColumn("پرداخت_کننده_آدرس", typeof(string)));
			DataRow dataRow = Public_Function.FillDataRow("select top 1 * from pardakhtkonande");
			bool flag = dataRow != null;
			if (flag)
			{
				this.dt.Rows[0]["پرداخت_کننده_نام"] = dataRow["name"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_کدملی"] = dataRow["codemelli"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_تلفن"] = dataRow["tel"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_شناسنامه"] = dataRow["shsh"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_پدر"] = dataRow["namepedar"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_تاریخ_تولد"] = dataRow["tarikhtavalod"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_کدپستی"] = dataRow["codeposti"].ToString();
				this.dt.Rows[0]["پرداخت_کننده_آدرس"] = dataRow["address"].ToString();
			}
			this.dt.Columns["Tozih"].ColumnName = "بابت";
			if (fl)
			{
				this.dt.Rows[0]["صاحب_حساب"] = bankhesab["sahebhesab"].ToString();
				this.dt.Rows[0]["شعبه"] = bankhesab["shobe"].ToString();
				this.dt.Rows[0]["شماره_حساب"] = bankhesab["sh_hesab"].ToString();
			}
			else
			{
				this.dt.Rows[0]["صاحب_حساب"] = RuntimeHelpers.GetObjectValue(this.dt.Rows[0]["moshtari_name"]);
				this.dt.Rows[0]["شعبه"] = "";
				this.dt.Rows[0]["شماره_حساب"] = RuntimeHelpers.GetObjectValue(bankhesab["Bank_Hesab"]);
			}
			this.dt.Columns.Remove("moshtari_name");
			this.dt.Rows[0]["تاریخ"] = Public_Function.dict["today"];
			this.dt.Rows[0]["مبلغ_به_حروف"] = huruf.ConvertToHuruf(Conversions.ToString(this.dt.Rows[0]["مبلغ"]), huruf.ConvertType.هیچکدام);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0004D050 File Offset: 0x0004B250
		public void design_print(StiReport rpt, int bank_ID)
		{
			StiOptions.Designer.DontAskSaveReport = true;
			StiOptions.Designer.DontSaveDesignerConfig = true;
			StiOptions.Designer.DesignerTitleText = "نرم افزار میادین میوه و تره بار";
			StiOptions.Designer.AllowSaveStandaloneReport = false;
			StiOptions.Designer.CodeTabVisible = false;
			StiOptions.Designer.HtmlPreviewReportVisible = false;
			rpt.Pages[0].Margins = new StiMargins(0.0, 0.0, 0.0, 0.0);
			rpt.Design();
			rpt.Save(Application.StartupPath + "\\reports\\bank\\variz\\" + Conversions.ToString(bank_ID) + ".mrt");
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0004D0F0 File Offset: 0x0004B2F0
		public void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			bool flag = this.dt.Rows[0]["moshtarihesab_id"] == DBNull.Value;
			DataRow dataRow;
			bool fl;
			if (flag)
			{
				string str = Conversions.ToString(this.dt.Rows[0]["moshtari_ID"]);
				dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
				fl = true;
			}
			else
			{
				string str = Conversions.ToString(this.dt.Rows[0]["moshtarihesab_id"]);
				dataRow = Public_Function.FillDataRow("select * from moshtari_hesab where id=" + str);
				fl = false;
			}
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			this.PrepareDt(dataRow2, dataRow, fl);
			flag = !File.Exists(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\variz\\", dataRow2["ID"]), ".mrt")));
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("برگ واریز به بانک ", dataRow2["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
				if (flag2)
				{
					this.dt.TableName = "data";
					stiReport.RegData(this.dt);
					this.design_print(stiReport, Conversions.ToInteger(dataRow2["ID"]));
				}
			}
			else
			{
				NewLateBinding.LateCall(stiReport, null, "Load", new object[]
				{
					Operators.ConcatenateObject(Operators.ConcatenateObject(Application.StartupPath + "\\reports\\bank\\variz\\", dataRow2["ID"]), ".mrt")
				}, null, null, null, true);
				this.dt.TableName = "data";
				stiReport.RegData(this.dt);
				bool flag2 = !Design;
				if (flag2)
				{
					stiReport.Print(false);
				}
				else
				{
					this.design_print(stiReport, Conversions.ToInteger(dataRow2["ID"]));
				}
			}
		}

		// Token: 0x04000174 RID: 372
		[CompilerGenerated]
		private DataTable _dt;
	}
}
