using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000034 RID: 52
	public class Kharid_Keraye
	{
		// Token: 0x060002E3 RID: 739 RVA: 0x0000263D File Offset: 0x0000083D
		public Kharid_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0003E028 File Offset: 0x0003C228
		public void DeleteByID(string ID)
		{
			string text = "declare @sanadbes_id int;declare @sanadbed_id int;declare @keraye_pardakht_ID int;";
			text = text + "select @keraye_pardakht_ID=keraye_pardakht_ID from Kharid_Keraye where id=" + ID + ";";
			text += "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=@keraye_pardakht_ID;";
			text += "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null  where id=@keraye_pardakht_id;";
			text += "delete from sanad where id in(@sanadbed_id,@sanadbes_id);";
			text = text + "delete from Kharid_Keraye where id=" + ID + ";";
			text += "delete from daryaftpardakht where id=@keraye_pardakht_ID;";
			bool flag = text.Length > 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0003E0A8 File Offset: 0x0003C2A8
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT     Kharid_Keraye.*,moshtari.name +' '+ moshtari.family as moshtari_name, Hazine_Kharid.Name AS Hazine_Kharid_Name,kala.name as Kala_Name  FROM         Kharid_Keraye INNER JOIN  Hazine_Kharid ON Kharid_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  moshtari on Kharid_Keraye.moshtari_id=moshtari.id left outer join Kala ON Kharid_Keraye.Kala_ID = Kala.ID where Kharid_ID=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0003E0D0 File Offset: 0x0003C2D0
		public void Insert(int Kharid_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Keraye(Kharid_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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

		// Token: 0x060002E7 RID: 743 RVA: 0x0003E260 File Offset: 0x0003C460
		public void Update(int Kharid_ID, DataTable dt)
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select num from kharid where id=" + Conversions.ToString(Kharid_ID)));
			string moshtari_ID = string.Empty;
			bool flag = Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0;
			if (flag)
			{
				moshtari_ID = Conversions.ToString(Public_Function.ExecuteScalar("select Moshtari_ID from kharid where id=" + Conversions.ToString(Kharid_ID)));
			}
			string iD = Public_Function.GetID(dt, "ID", "");
			string text2 = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @moshtari_hesab_id int;";
			string tozih = string.Empty;
			Furush_Keraye furush_Keraye = new Furush_Keraye();
			flag = (iD.Length > 0);
			if (flag)
			{
				text2 = string.Concat(new string[]
				{
					text2,
					"Delete From dbo.Kharid_Keraye Where Kharid_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text2 = text2 + "Delete From dbo.Kharid_Keraye Where Kharid_ID=" + Conversions.ToString(Kharid_ID) + ";";
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
						tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["hazine_kharid_Name"], " "), "سند فروش شماره "), text));
						flag = (dataRow["Tarikh_Fa"] == DBNull.Value);
						if (flag)
						{
							dataRow["Tarikh_Fa"] = Public_Function.MiladiToShamsi(DateAndTime.Now);
						}
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
								flag = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -1, false));
								if (flag)
								{
									text2 += this.Daryaft.AddKerayeNesie(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), tozih, Conversions.ToString(dataRow["moshtari_id"]), DaryaftPardakht.CodeHesab.کرایه_خرید, "@keraye_pardakht_id");
								}
								else
								{
									text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_خرید, "");
								}
								text2 += "select @keraye_pardakht_id=scope_identity();";
							}
							else
							{
								text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID2"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), moshtari_ID, Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Keraye(Kharid_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID,moshtari_id,tozih) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ",@keraye_pardakht_id, "), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), ","), Public_Function.GetValue(dataRow["tozih"].ToString())), " );")));
						}
						else
						{
							flag2 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value && dataRow["Keraye_Pardakht_ID2"] == DBNull.Value);
							if (flag2)
							{
								flag = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -1, false));
								if (flag)
								{
									text2 += this.Daryaft.AddKerayeNesie(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), tozih, Conversions.ToString(dataRow["moshtari_id"]), DaryaftPardakht.CodeHesab.کرایه_خرید, "@keraye_pardakht_id");
								}
								else
								{
									text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_خرید, "");
									text2 += "select @keraye_pardakht_id=scope_identity();";
								}
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
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
								text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), dataRow["Moshtari_ID"].ToString(), Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							flag2 = (Operators.CompareString(text3, string.Empty, false) != 0 && dataTable == null);
							if (flag2)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set mablagh=", dataRow["keraye"]), " where id="), text3)));
								flag2 = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -1, false));
								if (flag2)
								{
									text2 += this.Daryaft.UpdateKerayeNesie(Conversions.ToString(dataRow["tarikh_fa"]), Conversions.ToString(dataRow["Keraye"]), tozih, Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.CodeHesab.کرایه_خرید, text3);
								}
								else
								{
									flag2 = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false));
									if (flag2)
									{
										text2 = text2 + "select @sanadbes_id=isnull(sanadbes_id,0) from daryaftpardakht where id=" + text3 + ";";
										text2 = text2 + "if @sanadbes_id <> 0 begin  delete from sanad where id=@sanadbes_id; update daryaftpardakht set moshtari_id=-1, sanadbes_id=null where id=" + text3 + "; END; ";
									}
								}
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow["Tarikh_Fa"].ToString())), " ,Keraye_Pardakht_Id2="), Public_Function.GetValueInt(dataRow["Keraye_Pardakht_Id2"].ToString())), " ,moshtari_id="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,tozih="), Public_Function.GetValue(dataRow["tozih"].ToString())), " Where ID="), dataRow["ID"]), ";")));
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && dataTable != null && dataTable.Rows.Count > 1);
							if (flag2)
							{
								text2 += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه_کارت, DaryaftPardakht.CodeHesab.کرایه_خرید);
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

		// Token: 0x04000124 RID: 292
		private Sanad Isanad;

		// Token: 0x04000125 RID: 293
		private DaryaftPardakht Daryaft;
	}
}
