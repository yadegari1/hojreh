using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000046 RID: 70
	public class Safi_Furush_Sardkhane
	{
		// Token: 0x06000355 RID: 853 RVA: 0x000027EC File Offset: 0x000009EC
		public Safi_Furush_Sardkhane()
		{
			this.Sanad = new Sanad();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000476AC File Offset: 0x000458AC
		public DataRow GetByID(string Furush_ID)
		{
			return Public_Function.FillDataRow("Select dbo.Furush_Sardkhane_Safi.ID,dbo.Furush_Sardkhane_Safi.Sanad_ID,dbo.Furush_Sardkhane_Safi.Furush_Sardkhane_ID,dbo.Furush_Sardkhane_Safi.JamFurush,dbo.Furush_Sardkhane_Safi.Darsad,dbo.Furush_Sardkhane_Safi.Karmozd,dbo.Furush_Sardkhane_Safi.Mande,dbo.Furush_Sardkhane_Safi.Tarikh,dbo.Furush_Sardkhane_Safi.Tarikh_Fa,Furush_Sardkhane_Safi.Tozih From dbo.Furush_Sardkhane_Safi where Furush_Sardkhane_ID=" + Furush_ID);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000476D0 File Offset: 0x000458D0
		public long Insert(string sanad_Num, string Furush_Sardkhane_ID, string JamFurush, string Darsad, string Karmozd, string Mande, string Tarikh_Fa, string tarikh_vurud_bar, string Tozih, string kala_name, string sh_mashin)
		{
			string text = "declare @karmozd_sanad_id int;declare @sanad_id int;declare @moshtari_id int;declare @moshtarihesab_id int;declare @mablagh_keraye int;declare @mablagh_hazine int;declare @sanad_keraye int;declare @sanad_hazine int;";
			bool flag = Operators.CompareString(sh_mashin, string.Empty, false) != 0;
			if (flag)
			{
				sh_mashin = " به ش م " + sh_mashin;
			}
			flag = (Operators.CompareString(Karmozd, string.Empty, false) != 0 && Conversions.ToDouble(Karmozd) != 0.0);
			if (flag)
			{
				bool flag2 = Conversions.ToLong(Karmozd) > 0L;
				if (flag2)
				{
					text += this.Sanad.InsertStr(Conversions.ToString(11), Conversions.ToString(0), Karmozd, Public_Function.dict["today"], "کارمزد فروش از سردخانه شماره " + sanad_Num, Sanad.SanadType.@null);
				}
				else
				{
					text += this.Sanad.InsertStr(Conversions.ToString(11), Conversions.ToString(Math.Abs(Conversions.ToLong(Karmozd))), Conversions.ToString(0), Public_Function.dict["today"], "زیان فروش از سردخانه شماره " + sanad_Num, Sanad.SanadType.@null);
				}
				text += "select @karmozd_sanad_id =scope_identity();";
			}
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Furush_Sardkhane_Safi(Sanad_ID,Furush_Sardkhane_ID,JamFurush,Darsad,Karmozd,Mande,Tarikh,Tarikh_Fa,karmozd_sanad_id,Tozih) VALUES(NULL,",
				Furush_Sardkhane_ID,
				",",
				JamFurush,
				",",
				Public_Function.GetValueInt(Darsad),
				",",
				Public_Function.GetValueInt(Karmozd),
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

		// Token: 0x06000358 RID: 856 RVA: 0x000478AC File Offset: 0x00045AAC
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

		// Token: 0x06000359 RID: 857 RVA: 0x00047BB4 File Offset: 0x00045DB4
		public void Update(string sanad_num, string JamFurush, string Darsad, string Karmozd, string Mande, string Tarikh_Fa, string tarikh_vurud_bar, string Tozih, string kala_name, string sh_mashin, string ID)
		{
			string text = string.Empty;
			text = text + "select @furush_id=furush_hag_id,@sanad_id=sanad_id,@karmozd_id =karmozd_sanad_id from safi_furush where id=" + ID + ";";
			text = string.Concat(new string[]
			{
				text,
				"Update dbo.Furush_Sardkhane_Safi SET JamFurush=",
				JamFurush,
				" ,Darsad=",
				Public_Function.GetValueInt(Darsad),
				" ,Karmozd=",
				Public_Function.GetValueInt(Karmozd),
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
		}

		// Token: 0x04000155 RID: 341
		private Sanad Sanad;
	}
}
