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
	// Token: 0x0200004D RID: 77
	public class checkprint
	{
		// Token: 0x0600037D RID: 893 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public checkprint()
		{
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0004AE2C File Offset: 0x0004902C
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002841 File Offset: 0x00000A41
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

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0004AE44 File Offset: 0x00049044
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000284B File Offset: 0x00000A4B
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0004AE5C File Offset: 0x0004905C
		private void PrepareDt(DataRow bank, DataRow bankhesab, bool fl)
		{
			this.dt.Rows[0]["tarikh_fa"] = RuntimeHelpers.GetObjectValue(this.dt.Rows[0]["check_sarresid_fa"]);
			this.dt.Columns.Remove("ID");
			this.dt.Columns.Remove("dptype_id");
			this.dt.Columns.Remove("Tarikh");
			this.dt.Columns.Remove("sanadbed_id");
			this.dt.Columns.Remove("sanadbes_id");
			this.dt.Columns.Remove("sandug_id");
			this.dt.Columns.Remove("bankhesab_id");
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
			this.dt.Columns.Remove("moshtarihesab_id");
			this.dt.Columns.Remove("moshtarihesab_name");
			this.dt.Columns.Remove("moshtari_id");
			this.dt.Columns.Remove("bankhesab_id2");
			this.dt.Columns.Remove("bankhesab_name2");
			this.dt.Columns["mablagh"].ColumnName = "مبلغ";
			this.dt.Columns.Add(new DataColumn("مبلغ_به_حروف", typeof(string)));
			this.dt.Columns.Add(new DataColumn("تاریخ_به_حروف", typeof(string)));
			this.dt.Columns.Add(new DataColumn("در_وجه", typeof(string)));
			this.dt.Rows[0]["در_وجه"] = RuntimeHelpers.GetObjectValue(this.dt.Rows[0]["Tozih"]);
			this.dt.Columns["Tozih"].ColumnName = "بابت";
			this.dt.Columns["tarikh_fa"].ColumnName = "تاریخ";
			this.dt.Rows[0]["moshtari_name"] = this.Moshtari_Name;
			this.dt.Columns["moshtari_name"].ColumnName = "مشتری";
			this.dt.Rows[0]["تاریخ_به_حروف"] = RuntimeHelpers.GetObjectValue(huruf.ConvertTarikhTohuruf(Conversions.ToString(this.dt.Rows[0]["تاریخ"])));
			this.dt.Rows[0]["مبلغ_به_حروف"] = huruf.ConvertToHuruf(Conversions.ToString(this.dt.Rows[0]["مبلغ"]), huruf.ConvertType.ریال) + " تمام ";
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0004B3A0 File Offset: 0x000495A0
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
			rpt.Save(Application.StartupPath + "\\reports\\bank\\checkprint\\bank.mrt");
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0004B438 File Offset: 0x00049638
		public void ShowReport(bool Design)
		{
			StiReport stiReport = new StiReport();
			string str = Conversions.ToString(this.dt.Rows[0]["bankhesab_id"]);
			DataRow dataRow = Public_Function.FillDataRow("select * from bank_hesab where id=" + str);
			DataRow dataRow2 = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from bank where id=", dataRow["bank_ID"])));
			bool fl;
			this.PrepareDt(dataRow2, dataRow, fl);
			bool flag = !File.Exists(Application.StartupPath + "\\reports\\bank\\checkprint\\bank.mrt");
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("چک پرینت بانک ", dataRow2["Name"]), "  طراحی نگردیده است"), Environment.NewLine), "آیا مایل به طراحی برگ میباشید؟")), MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, null) == DialogResult.Yes;
				if (flag2)
				{
					this.dt.TableName = "data";
					stiReport.RegData(this.dt);
					this.design_print(stiReport, Conversions.ToInteger(dataRow2["ID"]));
				}
			}
			else
			{
				stiReport.Load(Application.StartupPath + "\\reports\\bank\\checkprint\\bank.mrt");
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

		// Token: 0x0400016E RID: 366
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x0400016F RID: 367
		[CompilerGenerated]
		private string _Moshtari_Name;
	}
}
