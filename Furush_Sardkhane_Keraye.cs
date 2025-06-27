using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200002F RID: 47
	public class Furush_Sardkhane_Keraye
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x000025D3 File Offset: 0x000007D3
		public Furush_Sardkhane_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00039D18 File Offset: 0x00037F18
		public void DeleteByID(string ID)
		{
			string text = "declare @sanadbed_id int;declare @keraye_pardakht_ID int;";
			text = text + "select @keraye_pardakht_ID=keraye_pardakht_ID from Furush_Sardkhane_Keraye where id=" + ID + ";";
			text += "select @sanadbed_id=sanadbed_id from daryaftpardakht where id=@keraye_pardakht_ID;";
			text += "update daryaftpardakht set sanadbed_id=null where id=@keraye_pardakht_id;";
			text += "delete from sanad where id=@sanadbed_id;";
			text = text + "delete from Furush_Sardkhane_Keraye where id=" + ID + ";";
			text += "delete from daryaftpardakht where id=@keraye_pardakht_ID;";
			bool flag = text.Length > 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00039D98 File Offset: 0x00037F98
		public DataTable GetByID(int Furush_ID)
		{
			return Public_Function.FillData("SELECT     Furush_Sardkhane_Keraye.*, Hazine_Kharid.Name AS Hazine_Kharid_Name,kala.name as Kala_Name  FROM         Furush_Sardkhane_Keraye INNER JOIN  Hazine_Kharid ON Furush_Sardkhane_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Kala ON Furush_Sardkhane_Keraye.Kala_ID = Kala.ID where Furush_Sardkhane_ID=" + Conversions.ToString(Furush_ID));
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00035D70 File Offset: 0x00033F70
		public void Insert(int Furush_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Keraye(Furush_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(Furush_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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
			flag = (text.Length > 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00039DC0 File Offset: 0x00037FC0
		public void Update(int Furush_ID, DataTable dt)
		{
			string str = Conversions.ToString(Public_Function.ExecuteScalar("select num from Furush_Sardkhane where id=" + Conversions.ToString(Furush_ID)));
			string empty = string.Empty;
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;";
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Sardkhane_Keraye Where Furush_Sardkhane_ID=",
					Conversions.ToString(Furush_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Sardkhane_Keraye Where Furush_Sardkhane_ID=" + Conversions.ToString(Furush_ID) + ";";
			}
			flag = (dt != null);
			bool flag3;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag2 = dataRow["ID"] == DBNull.Value;
						if (flag2)
						{
							flag3 = Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], -6, false);
							if (flag3)
							{
								text += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + str, empty, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_فروش_سردخانه, "");
								text += "select @keraye_pardakht_id=scope_identity();";
							}
							else
							{
								text += "select @keraye_pardakht_id=NULL;";
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Sardkhane_Keraye(Furush_Sardkhane_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID) VALUES(" + Conversions.ToString(Furush_ID) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ",@keraye_pardakht_id );")));
						}
						else
						{
							flag3 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -6, false));
							if (flag3)
							{
								text += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + str, empty, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_فروش_سردخانه, "");
								text += "select @keraye_pardakht_id=scope_identity();";
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
							}
							flag3 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && Operators.ConditionalCompareObjectEqual(dataRow["HazineKharid_ID"], -6, false));
							if (flag3)
							{
								this.Daryaft.DeleteDaryaftPardakhtRadif(dataRow["keraye_pardakht_id"].ToString(), Conversions.ToString(dataRow["ID"]), "");
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Sardkhane_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow["Tarikh_Fa"].ToString())), " Where ID="), dataRow["ID"]), ";")));
							flag3 = (Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -6, false) && dataRow["Keraye_Pardakht_ID"] != DBNull.Value);
							if (flag3)
							{
								text += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + str, empty, Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_فروش_سردخانه);
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag3 = (enumerator is IDisposable);
					if (flag3)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			flag3 = (text.Length > 0);
			if (flag3)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0400011A RID: 282
		private Sanad Isanad;

		// Token: 0x0400011B RID: 283
		private DaryaftPardakht Daryaft;
	}
}
