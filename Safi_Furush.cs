using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000044 RID: 68
	public class Safi_Furush
	{
		// Token: 0x0600034C RID: 844 RVA: 0x000027C2 File Offset: 0x000009C2
		public Safi_Furush()
		{
			this.Sanad = new Sanad();
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00046784 File Offset: 0x00044984
		public DataRow GetByID(string Furush_ID)
		{
			return Public_Function.FillDataRow("Select dbo.Safi_Furush.ID,dbo.Safi_Furush.Sanad_ID,dbo.Safi_Furush.Furush_Hag_ID,dbo.Safi_Furush.JamFurush,dbo.Safi_Furush.Darsad,dbo.Safi_Furush.Karmozd,dbo.Safi_Furush.Mande,dbo.Safi_Furush.Tarikh,dbo.Safi_Furush.Tarikh_Fa,Safi_Furush.Tozih From dbo.Safi_Furush where Furush_Hag_ID=" + Furush_ID);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000467A8 File Offset: 0x000449A8
		public long Insert(string sanad_Num, string Furush_Hag_ID, string JamFurush, string Darsad, string Karmozd, string Mande, string Tarikh_Fa, string tarikh_vurud_bar, string Tozih, string kala_name, string sh_mashin, string moshtari_name)
		{
			string text = "declare @karmozd_sanad_id int;declare @sanad_id int;declare @moshtari_id int;declare @moshtarihesab_id int;declare @mablagh_keraye int;declare @mablagh_hazine int;declare @sanad_keraye int;declare @sanad_hazine int;";
			bool flag = Operators.CompareString(sh_mashin, string.Empty, false) != 0;
			if (flag)
			{
				sh_mashin = " به ش م " + sh_mashin;
			}
			text = text + "select @moshtari_id=moshtari_id from furush_hag where id=" + Furush_Hag_ID + ";";
			text += "select @moshtarihesab_id=codehesab_ID from moshtari where id=@moshtari_id;";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype) VALUES(@moshtarihesab_id,0,",
				Mande,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh_vurud_bar)),
				",",
				Public_Function.GetValue(tarikh_vurud_bar),
				",",
				Public_Function.GetValue(string.Concat(new string[]
				{
					"بابت صافی سند شماره ",
					sanad_Num,
					sh_mashin,
					" - ",
					kala_name
				})),
				",",
				Conversions.ToString(4),
				"  );Select @sanad_id=Scope_Identity();"
			});
			flag = (Conversions.ToLong(Karmozd) >= 0L);
			if (flag)
			{
				text += this.Sanad.InsertStr(Conversions.ToString(11), Conversions.ToString(0), Karmozd, Public_Function.dict["today"], "کارمزد فروش سند شماره " + sanad_Num + " - " + moshtari_name, Sanad.SanadType.@null);
			}
			else
			{
				text += this.Sanad.InsertStr(Conversions.ToString(11), Conversions.ToString(Math.Abs(Conversions.ToLong(Karmozd))), Conversions.ToString(0), Public_Function.dict["today"], "زیان فروش سند شماره " + sanad_Num + " - " + moshtari_name, Sanad.SanadType.@null);
			}
			text += "select @karmozd_sanad_id =scope_identity();";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Safi_Furush(Sanad_ID,Furush_Hag_ID,JamFurush,Darsad,Karmozd,Mande,Tarikh,Tarikh_Fa,karmozd_sanad_id,Tozih) VALUES(@sanad_id,",
				Furush_Hag_ID,
				",",
				JamFurush,
				",",
				Darsad,
				",",
				Karmozd,
				",",
				Mande,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",@karmozd_sanad_id,",
				Public_Function.GetValue(Tozih),
				" );Select Scope_Identity();"
			});
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00046A2C File Offset: 0x00044C2C
		public void Update_Sudfurush(long furush_id, long karmozd, string furush_num)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Darsad.ID, Furush_Darsad.Furush_ID, Furush_Darsad.Moshtari_ID, Furush_Darsad.Darsad, Furush_Darsad.Mablagh, Furush_Darsad.SanadBed_ID,  Furush_Darsad.SanadBes_ID, Moshtari.Name+' '+ Moshtari.Family as moshtari_Name,Moshtari.Codehesab_ID   FROM         Furush_Darsad INNER JOIN Moshtari ON Furush_Darsad.Moshtari_ID = Moshtari.ID where furush_id=" + Conversions.ToString(furush_id));
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				long num = 0L;
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dataRow["mablagh"] = Operators.MultiplyObject((double)karmozd / 100.0, dataRow["darsad"]);
						num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
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
				flag = (karmozd > num);
				if (flag)
				{
					DataRow dataRow2 = dataTable.Rows[0];
					DataRow arg_109_0 = dataRow2;
					string columnName = "mablagh";
					arg_109_0[columnName] = Operators.AddObject(dataRow2[columnName], checked(karmozd - num));
				}
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						text = text + this.Sanad.UpdateStr("11", dataRow3["mablagh"].ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["darsad"], "%"), " از فروش شماره"), furush_num), " به "), dataRow3["moshtari_name"])), Conversions.ToString(dataRow3["sanadbed_id"]), Sanad.SanadType.@null) + ";";
						text = text + this.Sanad.UpdateStr(Conversions.ToString(dataRow3["Codehesab_ID"]), "0", dataRow3["mablagh"].ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["darsad"], "%"), " از فروش شماره"), furush_num)), Conversions.ToString(dataRow3["sanadbes_id"]), Sanad.SanadType.@null) + ";";
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update Furush_Darsad set mablagh=", dataRow3["mablagh"]), " where id="), dataRow3["ID"])));
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
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00046D38 File Offset: 0x00044F38
		public void Update(string sanad_num, string JamFurush, string Darsad, string Karmozd, string Mande, string Tarikh_Fa, string tarikh_vurud_bar, string Tozih, string kala_name, string sh_mashin, string moshtari_name, string ID)
		{
			DataTable dataTable = Public_Function.FillData("SELECT     Furush_Darsad.ID, Furush_Darsad.Furush_ID, Furush_Darsad.Moshtari_ID, Furush_Darsad.Darsad, Furush_Darsad.Mablagh, Furush_Darsad.SanadBed_ID,  Furush_Darsad.SanadBes_ID, Moshtari.Name+' '+ Moshtari.Family as moshtari_Name,Moshtari.Codehesab_ID   FROM         Furush_Darsad INNER JOIN Moshtari ON Furush_Darsad.Moshtari_ID = Moshtari.ID where furush_id=" + ID);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				long num = 0L;
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						dataRow["mablagh"] = Operators.MultiplyObject(Conversions.ToDouble(Karmozd) / 100.0, dataRow["darsad"]);
						num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
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
				flag = (Conversions.ToDouble(Karmozd) > (double)num);
				if (flag)
				{
					DataRow dataRow2 = dataTable.Rows[0];
					DataRow arg_118_0 = dataRow2;
					string columnName = "mablagh";
					arg_118_0[columnName] = Operators.AddObject(dataRow2[columnName], Conversions.ToDouble(Karmozd) - (double)num);
				}
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						text = text + this.Sanad.UpdateStr("11", dataRow3["mablagh"].ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["darsad"], "%"), " از فروش شماره"), sanad_num), " به "), dataRow3["moshtari_name"])), Conversions.ToString(dataRow3["sanadbed_id"]), Sanad.SanadType.@null) + ";";
						text = text + this.Sanad.UpdateStr(Conversions.ToString(dataRow3["Codehesab_ID"]), "0", dataRow3["mablagh"].ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow3["darsad"], "%"), " از فروش شماره"), sanad_num)), Conversions.ToString(dataRow3["sanadbes_id"]), Sanad.SanadType.@null) + ";";
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update Furush_Darsad set mablagh=", dataRow3["mablagh"]), " where id="), dataRow3["ID"])));
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
				Public_Function.ExecuteNonQuery(text);
			}
			else
			{
				string text2 = "declare @moshtari_id int;declare @sanad_id int;declare @furush_id int;declare @karmozd_id int;declare @moshtari_hesab_id int;";
				text2 = text2 + "select @furush_id=furush_hag_id,@sanad_id=sanad_id,@karmozd_id =karmozd_sanad_id from safi_furush where id=" + ID + ";";
				text2 += "select @moshtari_id= moshtari_id from furush_hag where id=@furush_id;";
				text2 += "select @moshtari_hesab_id=codehesab_id from moshtari where id=@moshtari_id;";
				flag = (Operators.CompareString(sh_mashin, string.Empty, false) != 0);
				if (flag)
				{
					sh_mashin = " به ش م " + sh_mashin;
				}
				text2 += this.Sanad.UpdateStr("@moshtari_hesab_id", Conversions.ToString(0), Mande, tarikh_vurud_bar, string.Concat(new string[]
				{
					"بابت صافی سند شماره ",
					sanad_num,
					sh_mashin,
					" - ",
					kala_name
				}), "@sanad_id", Sanad.SanadType.صافی_فروش);
				flag = (Conversions.ToLong(Karmozd) >= 0L);
				if (flag)
				{
					text2 += this.Sanad.UpdateStr(Conversions.ToString(11), Conversions.ToString(0), Karmozd, Public_Function.dict["today"], "کارمزد فروش سند شماره " + sanad_num + " - " + moshtari_name, "@karmozd_id", Sanad.SanadType.@null);
				}
				else
				{
					text2 += this.Sanad.UpdateStr(Conversions.ToString(11), Conversions.ToString(Math.Abs(Conversions.ToLong(Karmozd))), Conversions.ToString(0), Public_Function.dict["today"], "زیان فروش سند شماره " + sanad_num + " - " + moshtari_name, "@karmozd_id", Sanad.SanadType.@null);
				}
				text2 = string.Concat(new string[]
				{
					text2,
					"Update dbo.Safi_Furush SET JamFurush=",
					JamFurush,
					" ,Darsad=",
					Darsad,
					" ,Karmozd=",
					Karmozd,
					" ,Mande=",
					Mande,
					" ,Tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
					" ,Tarikh_Fa=",
					Public_Function.GetValue(Tarikh_Fa),
					" ,Tozih=",
					Public_Function.GetValue(Tozih),
					" Where ID=",
					ID
				});
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00047294 File Offset: 0x00045494
		public void Delete(string ID)
		{
			string text = "delete from  sanad where id in(select sanad_id from furush_hag_detail where furush_hag_id=" + ID + ");";
			text = text + "delete from furush_hag where id=" + ID;
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x04000153 RID: 339
		private Sanad Sanad;
	}
}
