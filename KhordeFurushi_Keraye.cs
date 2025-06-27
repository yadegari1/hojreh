using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200003D RID: 61
	public class KhordeFurushi_Keraye
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00002712 File Offset: 0x00000912
		public KhordeFurushi_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00042B0C File Offset: 0x00040D0C
		public void DeleteByID(string ID)
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(sanad_id,'') from KhordeFurushi_Keraye where id=" + ID));
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(keraye_pardakht_id,'') from KhordeFurushi_Keraye where id=" + ID));
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(text);
			}
			flag = (Operators.CompareString(text2, string.Empty, false) != 0);
			if (flag)
			{
				DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
				daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(text2, "KhordeFurushi_Keraye", "keraye_pardakht_id", ID);
			}
			Public_Function.ExecuteNonQuery("delete from KhordeFurushi_Keraye where id=" + ID);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00042BBC File Offset: 0x00040DBC
		public DataTable GetByID(int KhordeFurushi_ID)
		{
			return Public_Function.FillData("SELECT     KhordeFurushi_Keraye.*, Hazine_Kharid.Name AS Hazine_Kharid_Name,kala.name as Kala_Name  FROM         KhordeFurushi_Keraye INNER JOIN  Hazine_Kharid ON KhordeFurushi_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Kala ON KhordeFurushi_Keraye.Kala_ID = Kala.ID where KhordeFurushi_ID=" + Conversions.ToString(KhordeFurushi_ID));
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00042BE4 File Offset: 0x00040DE4
		public void Insert(int KhordeFurushi_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.KhordeFurushi_Keraye(KhordeFurushi_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(KhordeFurushi_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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

		// Token: 0x0600031C RID: 796 RVA: 0x00042D74 File Offset: 0x00040F74
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

		// Token: 0x0600031D RID: 797 RVA: 0x000432C8 File Offset: 0x000414C8
		public void Update(string Tarikh_Fa, DataTable dt)
		{
			int value = Conversions.ToInteger(Public_Function.ExecuteScalar("select id from khordefurushi where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa))));
			Sanad sanad = new Sanad();
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;";
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.KhordeFurushi_Keraye Where KhordeFurushi_ID=",
					Conversions.ToString(value),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.KhordeFurushi_Keraye Where KhordeFurushi_ID=" + Conversions.ToString(value) + ";";
			}
			flag = !Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
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
						flag2 = (dataRow["ID"] == DBNull.Value);
						if (flag2)
						{
							text += this.Daryaft.AddRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString(), "", DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.مخارج_خرید, "@keraye_pardakht_id");
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.KhordeFurushi_Keraye(KhordeFurushi_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID,sanad_id) VALUES(" + Conversions.ToString(value) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa))), ","), Public_Function.GetValue(Tarikh_Fa)), ",@keraye_pardakht_id,@sanad_id);")));
						}
						else
						{
							flag2 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value);
							if (flag2)
							{
								text += this.Daryaft.AddRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString(), "", DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.مخارج_خرید, "@keraye_pardakht_id");
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update KhordeFurushi_Keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.KhordeFurushi_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa))), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh_Fa)), " Where ID="), dataRow["ID"]), ";")));
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value);
							if (flag2)
							{
								text += this.Daryaft.UpdateRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString(), "", Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.مخارج_خرید);
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
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0400013B RID: 315
		private Sanad Isanad;

		// Token: 0x0400013C RID: 316
		private DaryaftPardakht Daryaft;
	}
}
