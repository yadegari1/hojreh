using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000039 RID: 57
	public class Kharid_Sardkhane_Keraye
	{
		// Token: 0x06000300 RID: 768 RVA: 0x000026B2 File Offset: 0x000008B2
		public Kharid_Sardkhane_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00040714 File Offset: 0x0003E914
		public void DeleteByID(string ID)
		{
			string text = "declare @sanadbes_id int;declare @sanadbed_id int;declare @keraye_pardakht_ID int;";
			text = text + "select @keraye_pardakht_ID=keraye_pardakht_ID from Kharid_sardkhane_Keraye where id=" + ID + ";";
			text += "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id=@keraye_pardakht_ID;";
			text += "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id=@keraye_pardakht_id;";
			text += "delete from sanad where id in(@sanadbed_id,@sanadbes_id);";
			text = text + "delete from Kharid_sardkhane_Keraye where id=" + ID + ";";
			text += "delete from daryaftpardakht where id=@keraye_pardakht_ID;";
			bool flag = text.Length > 0;
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00040794 File Offset: 0x0003E994
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT     Kharid_Sardkhane_Keraye.ID, Kharid_Sardkhane_Keraye.Kharid_Sardkhane_ID, Kharid_Sardkhane_Keraye.HazineKharid_ID, Kharid_Sardkhane_Keraye.Kala_ID,   Kharid_Sardkhane_Keraye.Tedad, Kharid_Sardkhane_Keraye.Vazn, Kharid_Sardkhane_Keraye.Keraye, Kharid_Sardkhane_Keraye.Keraye_Pardakht_ID,  Kharid_Sardkhane_Keraye.Tarikh, Kharid_Sardkhane_Keraye.Tarikh_Fa, Kharid_Sardkhane_Keraye.Sanad_ID, Kharid_Sardkhane_Keraye.Keraye_Pardakht_ID2,  Kharid_Sardkhane_Keraye.moshtari_id, Kharid_Sardkhane_Keraye.tozih, Hazine_Kharid.Name AS Hazine_Kharid_Name, Kala.Name AS Kala_Name,  Moshtari.ID AS moshtari_id, Moshtari.Name+' '+ Moshtari.Family as moshtari_name  FROM         Kharid_Sardkhane_Keraye INNER JOIN  Hazine_Kharid ON Kharid_Sardkhane_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Moshtari ON Kharid_Sardkhane_Keraye.moshtari_id = Moshtari.ID LEFT OUTER JOIN  Kala ON Kharid_Sardkhane_Keraye.Kala_ID = Kala.ID  where Kharid_Sardkhane_ID=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0003E0D0 File Offset: 0x0003C2D0
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

		// Token: 0x06000304 RID: 772 RVA: 0x000407BC File Offset: 0x0003E9BC
		private void SyncKerayePardakht(string Kharid_ID, DataTable dt)
		{
			DataTable dataTable = Public_Function.FillData("select id,keraye_pardakht_id,keraye_pardakht_id2 from kharid_sardkhane_keraye where kharid_sardkhane_id=" + Kharid_ID);
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["ID"] == DBNull.Value;
					if (!flag)
					{
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
						flag = (array.Length > 0);
						if (flag)
						{
							bool flag2 = dataRow["keraye_pardakht_id2"] != DBNull.Value;
							bool flag3;
							if (flag2)
							{
								flag3 = (array[0]["keraye_pardakht_id2"] == DBNull.Value);
								if (flag3)
								{
									daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(array[0]["keraye_pardakht_id"]), "kharid_sardkhane_keraye", "keraye_pardakht_id", Conversions.ToString(array[0]["ID"]));
									dataRow["keraye_pardakht_id"] = DBNull.Value;
									continue;
								}
							}
							flag3 = (dataRow["keraye_pardakht_id"] != DBNull.Value);
							if (flag3)
							{
								flag2 = (array[0]["keraye_pardakht_id"] == DBNull.Value);
								if (flag2)
								{
									daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(array[0]["keraye_pardakht_id2"]), "kharid_sardkhane_keraye", "keraye_pardakht_id2", Conversions.ToString(array[0]["ID"]));
									dataRow["keraye_pardakht_id2"] = DBNull.Value;
								}
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag3 = enumerator is IDisposable;
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000409A4 File Offset: 0x0003EBA4
		public void Update(int Kharid_ID, DataTable dt)
		{
			Furush_Keraye furush_Keraye = new Furush_Keraye();
			bool flag = dt != null;
			if (flag)
			{
				this.SyncKerayePardakht(Conversions.ToString(Kharid_ID), dt);
			}
			Sanad sanad = new Sanad();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select num from Kharid_Sardkhane where id=" + Conversions.ToString(Kharid_ID)));
			int num = -999;
			string iD = Public_Function.GetID(dt, "ID", "");
			string text2 = "declare @keraye_pardakht_id int;declare @moshtari_hesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;declare @parent_id int;";
			flag = !Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
				num = -5;
			}
			flag = (dt != null);
			checked
			{
				bool flag2;
				if (flag)
				{
					int num2 = 0;
					try
					{
						IEnumerator enumerator = dt.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["hazine_kharid_Name"], " "), "خرید به سردخانه شماره "), text));
							flag = (dataRow["tozih"] != DBNull.Value);
							if (flag)
							{
								text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject("-", dataRow["tozih"])));
							}
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
										text2 += this.Daryaft.AddKerayeNesie(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), text3, Conversions.ToString(dataRow["moshtari_id"]), DaryaftPardakht.CodeHesab.کرایه_خرید, "@keraye_pardakht_id");
									}
									else
									{
										text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), text3, Conversions.ToString(-1), DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_خرید, "");
									}
									text2 += "select @keraye_pardakht_id=scope_identity();";
								}
								else
								{
									text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID2"].ToString(), text3, dataRow["hazine_kharid_name"].ToString(), "", Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
								}
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Keraye(Kharid_Sardkhane_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID,sanad_id,moshtari_id,tozih) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ",@keraye_pardakht_id,@sanad_id,"), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), ","), Public_Function.GetValue(dataRow["tozih"].ToString())), ");")));
							}
							else
							{
								flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && (Operators.ConditionalCompareObjectEqual(dataRow["HazineKharid_ID"], -6, false) || Operators.ConditionalCompareObjectEqual(dataRow["HazineKharid_ID"], num, false)));
								if (flag2)
								{
									this.Daryaft.DeleteDaryaftPardakhtRadif(dataRow["keraye_pardakht_id"].ToString(), Conversions.ToString(dataRow["ID"]), "");
								}
								flag2 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value && dataRow["Keraye_Pardakht_ID2"] == DBNull.Value);
								if (flag2)
								{
									flag = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -1, false));
									if (flag)
									{
										text2 += this.Daryaft.AddKerayeNesie(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), text3, Conversions.ToString(dataRow["moshtari_id"]), DaryaftPardakht.CodeHesab.کرایه_خرید, "@keraye_pardakht_id");
									}
									else
									{
										text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), text3, Conversions.ToString(-1), DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_خرید, "@keraye_pardakht_id");
									}
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update Kharid_Sardkhane_Keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
								}
								string text4 = dataRow["Keraye_Pardakht_ID"].ToString();
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
								flag2 = (Operators.CompareString(text4, string.Empty, false) != 0 && dataTable != null && dataTable.Rows.Count > 1);
								if (flag2)
								{
									text2 += furush_Keraye.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID"].ToString(), text3, dataRow["hazine_kharid_name"].ToString(), dataRow["moshtari_id"].ToString(), Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
								}
								flag2 = (Operators.CompareString(text4, string.Empty, false) != 0 && dataTable == null);
								if (flag2)
								{
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set mablagh=", dataRow["keraye"]), " where id="), text4), ";")));
									flag2 = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -1, false));
									if (flag2)
									{
										text2 += this.Daryaft.UpdateKerayeNesie(Conversions.ToString(dataRow["tarikh_fa"]), Conversions.ToString(dataRow["Keraye"]), text3, Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.CodeHesab.کرایه_خرید, text4);
									}
									else
									{
										flag2 = (dataRow["moshtari_id"] != DBNull.Value && Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false));
										if (flag2)
										{
											text2 = text2 + "select @sanadbes_id=isnull(sanadbes_id,0) from daryaftpardakht where id=" + text4 + ";";
											text2 = text2 + "if @sanadbes_id <> 0 begin  delete from sanad where id=@sanadbes_id; update daryaftpardakht set moshtari_id=-1, sanadbes_id=null where id=" + text4 + "; END; ";
										}
									}
								}
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Update dbo.Kharid_Sardkhane_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow["Tarikh_Fa"].ToString())), " ,moshtari_id="), Public_Function.GetValueInt(dataRow["moshtari_id"].ToString())), " ,tozih="), Public_Function.GetValue(dataRow["tozih"].ToString())), " Where ID="), dataRow["ID"]), ";")));
								flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && dataTable != null && dataTable.Rows.Count > 1);
								if (flag2)
								{
									text2 += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, Conversions.ToString(dataRow["moshtari_id"]), Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه_کارت, DaryaftPardakht.CodeHesab.کرایه_ارسال_بار);
								}
							}
							num2++;
							flag2 = (num2 == 200);
							if (flag2)
							{
								flag = (text2.Length > 0);
								if (flag)
								{
									Public_Function.ExecuteNonQuery(text2);
								}
								num2 = 0;
								text2 = "declare @keraye_pardakht_id int;declare @moshtari_hesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;declare @parent_id int;";
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
		}

		// Token: 0x04000130 RID: 304
		private Sanad Isanad;

		// Token: 0x04000131 RID: 305
		private DaryaftPardakht Daryaft;
	}
}
