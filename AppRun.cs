using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using FruitBox.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000058 RID: 88
	internal class AppRun
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x0000297C File Offset: 0x00000B7C
		[DebuggerNonUserCode]
		public AppRun()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0004E928 File Offset: 0x0004CB28
		public void mmm()
		{
			if (!File.Exists(Application.StartupPath + "\\fr.snk"))
			{
				this.CheckInstallDate();
				return;
			}
			string text = File.ReadAllText(Application.StartupPath + "\\fr.snk");
			fp expr_3A = new fp();
			string right = expr_3A.Value2(expr_3A.Value());
			if (Operators.CompareString(text, right, false) != 0)
			{
				this.CheckInstallDate();
				return;
			}
			Public_Function.dict.Add("key", text);
			this.mms();
			this.mms2();
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0004E9AC File Offset: 0x0004CBAC
		public void mmm2()
		{
			if (!File.Exists(Application.StartupPath + "\\fr2.snk"))
			{
				this.CheckInstallDate();
				return;
			}
			string arg_47_0 = File.ReadAllText(Application.StartupPath + "\\fr2.snk");
			fp expr_39 = new fp();
			string right = expr_39.Value2(expr_39.Value());
			if (Operators.CompareString(arg_47_0, right, false) != 0)
			{
				this.CheckInstallDate();
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0004EA10 File Offset: 0x0004CC10
		public void CheckInstallDate()
		{
			if (!Public_Function.dict.ContainsKey("eval"))
			{
				Public_Function.dict.Add("eval", Conversions.ToString(true));
				if (Public_Function.dict.ContainsKey("eval"))
				{
					Public_Function.dict["head1"] = "فقط برای آزمایش و تست نرم افزار";
					Public_Function.dict["head2"] = "فقط برای آزمایش و تست نرم افزار";
				}
			}
			setting setting = new setting();
			if (!Public_Function.dict.ContainsKey("installdate"))
			{
				setting.Update("installdate", DateTime.Now.ToShortDateString());
				Public_Function.dict.Add("installdate", DateTime.Now.ToShortDateString());
			}
			if (!Public_Function.dict.ContainsKey("owner"))
			{
				Public_Function.dict.Add("owner", "نسخه نمایشی");
				MyProject.Forms.Form_Main.txt_CompanyName.Text = "نسخه نمایشی";
			}
			else
			{
				Public_Function.dict["owner"] = "نسخه نمایشی";
				MyProject.Forms.Form_Main.txt_CompanyName.Text = "نسخه نمایشی";
			}
			DateTime value = DateTime.Parse(Public_Function.dict["installdate"]);
			if (DateTime.Now.Subtract(value).Days > 30)
			{
				new Frm_Secure().ShowDialog();
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0004EB7C File Offset: 0x0004CD7C
		private bool Check_lic(string tarikh, string[] lic)
		{
			fp fp = new fp();
			for (int i = 0; i < lic.Length; i++)
			{
				string lic2 = lic[i];
				if (fp.Check_lic(tarikh, lic2))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		public void mms()
		{
			new fp().Check_Rd();
			DateTime dateTime = Conversions.ToDate(Public_Function.ShamsiToMiladi(Public_Function.dict["rd"].Split(new char[]
			{
				':'
			})[0])).AddYears(1);
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			bool flag = File.Exists(Application.StartupPath + "\\fr3.snk");
			if (flag)
			{
				File.ReadAllLines(Application.StartupPath + "\\fr3.snk");
			}
			while (DateAndTime.Now.Subtract(dateTime).Days > 0)
			{
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					dateTime = dateTime.AddYears(1);
				}
				else
				{
					if (flag)
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
					}
					dateTime = dateTime.AddYears(1);
				}
			}
			if (dictionary.Count > 0)
			{
				new Frm_Register2
				{
					lic_dict = dictionary
				}.ShowDialog();
				return;
			}
			if (Math.Abs(DateAndTime.Now.Subtract(dateTime).Days) < 30)
			{
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
				}
				else
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime), false);
				}
			}
			if (dictionary.Count > 0)
			{
				new Frm_Register2
				{
					days = Math.Abs(DateAndTime.Now.Subtract(dateTime).Days),
					lic_dict = dictionary
				}.ShowDialog();
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0004ED2C File Offset: 0x0004CF2C
		public void mms2()
		{
			new fp().Check_Rd();
			DateTime dateTime = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from furush_hag_detail order by id desc"));
			DateTime dateTime2 = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from kharid_furush order by id desc"));
			DateTime dateTime3 = Conversions.ToDate(Public_Function.ExecuteScalar("select top 1 tarikh from furush_sardkhane_detail order by id desc"));
			bool flag = DateTime.Compare(dateTime, dateTime2) > 0;
			DateTime t;
			if (flag)
			{
				t = dateTime;
			}
			else
			{
				t = dateTime2;
			}
			flag = (DateTime.Compare(t, dateTime3) < 0);
			if (flag)
			{
				t = dateTime3;
			}
			DateTime dateTime4 = Conversions.ToDate(Public_Function.ShamsiToMiladi(Public_Function.dict["rd"].Split(new char[]
			{
				':'
			})[0])).AddYears(1);
			Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
			flag = File.Exists(Application.StartupPath + "\\fr3.snk");
			if (flag)
			{
				File.ReadAllLines(Application.StartupPath + "\\fr3.snk");
			}
			while (t.Subtract(dateTime4).Days > 0)
			{
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					dateTime4 = dateTime4.AddYears(1);
				}
				else
				{
					if (flag)
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					}
					else
					{
						dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
					}
					dateTime4 = dateTime4.AddYears(1);
				}
			}
			if (dictionary.Count > 0)
			{
				new Frm_Register2
				{
					lic_dict = dictionary
				}.ShowDialog();
				return;
			}
			if (Math.Abs(t.Subtract(dateTime4).Days) < 30)
			{
				if (flag)
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
				}
				else
				{
					dictionary.Add(Public_Function.MiladiToShamsi(dateTime4), false);
				}
			}
			if (dictionary.Count > 0)
			{
				new Frm_Register2
				{
					days = Math.Abs(t.Subtract(dateTime4).Days),
					lic_dict = dictionary
				}.ShowDialog();
			}
		}
	}
}
