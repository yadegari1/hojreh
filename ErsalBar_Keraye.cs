using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000026 RID: 38
	public class ErsalBar_Keraye
	{
		// Token: 0x06000235 RID: 565 RVA: 0x000023CB File Offset: 0x000005CB
		public ErsalBar_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0002DCFC File Offset: 0x0002BEFC
		public void DeleteByID(string ID)
		{
			string text = "declare @sanadbed_id int;declare @keraye_pardakht_ID int;declare @sanad_id bigint;";
			text = text + "select @keraye_pardakht_ID=keraye_pardakht_ID,@sanad_id=sanad_id from ErsalBar_Keraye where id=" + ID + ";";
			text += "select @sanadbed_id=sanadbed_id from daryaftpardakht where id=@keraye_pardakht_ID;";
			text += "update daryaftpardakht set sanadbed_id=null where id=@keraye_pardakht_id;";
			text += "delete from sanad where id=@sanadbed_id;";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from ErsalBar_Keraye where id=" + ID + ";";
			text += "delete from daryaftpardakht where id=@keraye_pardakht_ID;";
			bool flag = text.Length > 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0002DD88 File Offset: 0x0002BF88
		public DataTable GetByID(int ErsalBar_ID)
		{
			return Public_Function.FillData("SELECT     ErsalBar_Keraye.*, Hazine_Kharid.Name AS Hazine_Kharid_Name,kala.name as Kala_Name  FROM         ErsalBar_Keraye INNER JOIN  Hazine_Kharid ON ErsalBar_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Kala ON ErsalBar_Keraye.Kala_ID = Kala.ID where ErsalBar_ID=" + Conversions.ToString(ErsalBar_ID));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0002DDB0 File Offset: 0x0002BFB0
		public void Insert(int ErsalBar_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_Keraye(ErsalBar_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(ErsalBar_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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

		// Token: 0x06000239 RID: 569 RVA: 0x0002DF40 File Offset: 0x0002C140
		public void UpdateDetail(int ErsalBar_ID, DataTable dt)
		{
			Sanad sanad = new Sanad();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select num from ErsalBar where id=" + Conversions.ToString(ErsalBar_ID)));
			int num = -999;
			string moshtari_ID = Conversions.ToString(Public_Function.ExecuteScalar("select Moshtari_ID from ErsalBar where id=" + Conversions.ToString(ErsalBar_ID)));
			string text2 = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;";
			bool flag2;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["Keraye_Pardakht_ID"] != DBNull.Value;
					if (flag)
					{
						flag2 = (dataRow["keraye"] != DBNull.Value);
						if (flag2)
						{
							this.Daryaft.DeleteDaryaftPardakhtRadif(Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), "", "");
						}
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
			flag2 = (dt != null);
			bool flag3;
			if (flag2)
			{
				try
				{
					IEnumerator enumerator2 = dt.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						bool flag = dataRow2["ID"] == DBNull.Value;
						if (flag)
						{
							flag3 = (Operators.ConditionalCompareObjectNotEqual(dataRow2["hazinekharid_id"], -6, false) && Operators.ConditionalCompareObjectNotEqual(dataRow2["hazinekharid_id"], num, false));
							if (flag3)
							{
								text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow2["Tarikh_Fa"]), Conversions.ToString(dataRow2["keraye"]), "مخارج ارسال بار  سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_ارسال_بار, "");
								text2 += "select @keraye_pardakht_id=scope_identity();";
							}
							else
							{
								text2 += "select @keraye_pardakht_id=NULL;";
							}
							text2 += "Update ErsalBar_Detail set Keraye_pardakht_ID=@keraye_pardakht_id;";
						}
						else
						{
							flag3 = (dataRow2["Keraye_Pardakht_ID"] == DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], -6, false) && Operators.ConditionalCompareObjectNotEqual(dataRow2["hazinekharid_id"], num, false));
							if (flag3)
							{
								text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow2["Tarikh_Fa"]), Conversions.ToString(dataRow2["keraye"]), "مخارج ارسال بار  سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_ارسال_بار, "");
								text2 += "select @keraye_pardakht_id=scope_identity();";
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update ErsalBar_Detail set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow2["ID"]), ";")));
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.ErsalBar_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow2["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow2["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow2["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow2["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow2["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow2["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow2["Tarikh_Fa"].ToString())), " Where ID="), dataRow2["ID"]), ";")));
							flag3 = ((Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], -6, false) || Operators.ConditionalCompareObjectNotEqual(dataRow2["HazineKharid_ID"], num, false)) && dataRow2["Keraye_Pardakht_ID"] != DBNull.Value);
							if (flag3)
							{
								text2 += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow2["Tarikh_Fa"]), Conversions.ToString(dataRow2["keraye"]), dataRow2["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, Conversions.ToString(dataRow2["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_حق_العمل);
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag3 = (enumerator2 is IDisposable);
					if (flag3)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			flag3 = (text2.Length > 0);
			if (flag3)
			{
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0002E494 File Offset: 0x0002C694
		public void Update(int ErsalBar_ID, DataTable dt)
		{
			Sanad sanad = new Sanad();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select num from ErsalBar where id=" + Conversions.ToString(ErsalBar_ID)));
			int num = -999;
			string moshtari_ID = Conversions.ToString(Public_Function.ExecuteScalar("select Moshtari_ID from ErsalBar where id=" + Conversions.ToString(ErsalBar_ID)));
			string iD = Public_Function.GetID(dt, "ID", "");
			string text2 = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;";
			Furush_Keraye furush_Keraye = new Furush_Keraye();
			string tozih = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text2 = string.Concat(new string[]
				{
					text2,
					"Delete From dbo.ErsalBar_Keraye Where ErsalBar_ID=",
					Conversions.ToString(ErsalBar_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text2 = text2 + "Delete From dbo.ErsalBar_Keraye Where ErsalBar_ID=" + Conversions.ToString(ErsalBar_ID) + ";";
			}
			flag = !Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
				num = -5;
			}
			flag = (dt != null);
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["hazine_kharid_Name"], " "), "سند باربارکنی شماره "), text));
						flag = (dataRow["ID"] == DBNull.Value);
						if (flag)
						{
							flag2 = (dataRow["dt"] != DBNull.Value);
							DataTable dataTable;
							if (flag2)
							{
								dataTable = (DataTable)dataRow["dt"];
							}
							else
							{
								dataTable = null;
							}
							flag2 = (dataTable == null || dataTable.Rows.Count == 0);
							if (flag2)
							{
								text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_ارسال_بار, "");
								text2 += "select @keraye_pardakht_id=scope_identity();";
							}
							else
							{
								text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), moshtari_ID, Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow["hazinekharid_id"], num, false);
							if (flag2)
							{
								text2 += sanad.InsertStr("18", "0", dataRow["keraye"].ToString(), dataRow["Tarikh_Fa"].ToString(), "تخلیه سند شماره " + text, "@sanad_id", Sanad.SanadType.@null);
							}
							else
							{
								text2 += "select @sanad_id=NULL;";
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_Keraye(ErsalBar_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID,sanad_id) VALUES(" + Conversions.ToString(ErsalBar_ID) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ",@keraye_pardakht_id,@sanad_id);")));
						}
						else
						{
							flag2 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["HazineKharid_ID"], -6, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], num, false));
							if (flag2)
							{
								text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_ارسال_بار, "");
								text2 += "select @keraye_pardakht_id=scope_identity();";
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update ErsalBar_Keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
							}
							string text3 = dataRow["Keraye_Pardakht_ID"].ToString();
							flag2 = (dataRow["dt"] != DBNull.Value);
							DataTable dataTable;
							if (flag2)
							{
								dataTable = (DataTable)dataRow["dt"];
							}
							else
							{
								dataTable = null;
							}
							flag2 = (Operators.CompareString(text3, string.Empty, false) != 0 && dataTable != null && dataTable.Rows.Count > 1);
							if (flag2)
							{
								text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), moshtari_ID, Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							flag2 = (Operators.CompareString(text3, string.Empty, false) != 0 && dataTable == null);
							if (flag2)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set mablagh=", dataRow["keraye"]), " where id="), text3)));
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.ErsalBar_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow["Tarikh_Fa"].ToString())), " Where ID="), dataRow["ID"]), ";")));
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && dataTable != null && dataTable.Rows.Count > 1);
							if (flag2)
							{
								text2 += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه_کارت, DaryaftPardakht.CodeHesab.کرایه_ارسال_بار);
							}
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
			}
			flag2 = (text2.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x040000E3 RID: 227
		private Sanad Isanad;

		// Token: 0x040000E4 RID: 228
		private DaryaftPardakht Daryaft;
	}
}
