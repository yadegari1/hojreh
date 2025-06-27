using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000040 RID: 64
	public class Saderat
	{
		// Token: 0x06000337 RID: 823 RVA: 0x00002782 File Offset: 0x00000982
		public Saderat()
		{
			this.Sanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00044444 File Offset: 0x00042644
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     ErsalBar.*, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name  FROM         ErsalBar INNER JOIN   Moshtari ON ErsalBar.Moshtari_ID = Moshtari.ID  where type=1 and num =" + Conversions.ToString(Num));
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0002C400 File Offset: 0x0002A600
		public DataTable GetDetailByID(long ID)
		{
			return Public_Function.FillData("SELECT     ErsalBar_Detail.ID, ErsalBar_Detail.ErsalBar_ID, ErsalBar_Detail.Moshtari_ID, ErsalBar_Detail.Kala_ID, ErsalBar_Detail.Tarikh,   ErsalBar_Detail.Tarikh_Fa, ErsalBar_Detail.Tedad, ErsalBar_Detail.Vazn_Ba_Zarf, ErsalBar_Detail.Zarf, ErsalBar_Detail.Vazn_Kol,  ErsalBar_Detail.Fee, ErsalBar_Detail.Jam_Kol,ErsalBar_Detail.Sanad_ID,ErsalBar_Detail.Mablagh_Safi,ErsalBar_Detail.Keraye,ErsalBar_Detail.Keraye_Pardakht_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   ErsalBar_Detail.Sanad_ID,ErsalBar_Detail.Tedad as tafazol_tedad,ErsalBar_Detail.Vazn_Ba_Zarf as tafazol_vazn, ErsalBar_Detail.Kala_ID AS prekala_id,NULL AS Row_Index   FROM         ErsalBar_Detail INNER JOIN   Moshtari ON ErsalBar_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON ErsalBar_Detail.Kala_ID = Kala.ID INNER JOIN   ErsalBar ON ErsalBar_Detail.ErsalBar_ID = ErsalBar.ID   where ErsalBar.ID=" + Conversions.ToString(ID));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0004446C File Offset: 0x0004266C
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.ErsalBar where type=1"));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00044490 File Offset: 0x00042690
		public long GetNavigateID(Saderat.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Saderat.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.ErsalBar   WHERE type =1 and Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Saderat.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.ErsalBar   WHERE type=1 and Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Saderat.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT isnull(MIN(Num),1) FROM dbo.ErsalBar where type=1"));
				break;
			case Saderat.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(MAX(Num),1) FROM dbo.ErsalBar where type=1"));
				break;
			}
			return result;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.ErsalBar.ID,dbo.ErsalBar.Num,dbo.ErsalBar.Moshtari_ID,dbo.ErsalBar.Sh_Mashin,dbo.ErsalBar.Sh_Barname,dbo.ErsalBar.Tarikh_Vurud,dbo.ErsalBar.[Desc],dbo.ErsalBar.Baskul,Baskul_Mabda,dbo.ErsalBar.Tedad_Kol,dbo.ErsalBar.Keraye,dbo.ErsalBar.Hazine,dbo.ErsalBar.Tarikh_Keraye,dbo.ErsalBar.Tarikh_Hazine,dbo.ErsalBar.Tarikh_Keraye_Fa,dbo.ErsalBar.Tarikh_Hazine_Fa From dbo.ErsalBar");
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0002C50C File Offset: 0x0002A70C
		private object IsTekrari(DataTable dt, int pos, long Daryaft_id)
		{
			checked
			{
				object result;
				for (int i = 0; i <= pos; i++)
				{
					bool flag = dt.Rows[i]["daryaft_id"] == DBNull.Value;
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dt.Rows[i]["daryaft_id"], Daryaft_id, false);
						if (flag)
						{
							result = true;
							return result;
						}
					}
				}
				result = false;
				return result;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00044534 File Offset: 0x00042734
		public long Insert(string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string Mablagh_Safi, string keraye_mabda, string nahve_furush, string safi_dolar, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @moshtari_sanad_id bigint;declare @safi_dolar_sanad_id bigint;";
			string right = string.Empty;
			tozih = " صادرات سند " + Num;
			bool flag = Operators.CompareString(Mablagh_Safi, string.Empty, false) != 0 && Operators.CompareString(Mablagh_Safi, "0", false) != 0;
			if (flag)
			{
				text = text + "select @codehesab_id=Codehesab_id from Moshtari where id=" + Moshtari_ID + ";";
				text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.صادرات_گیرنده_بار);
			}
			flag = (Operators.CompareString(safi_dolar, string.Empty, false) != 0 && Operators.CompareString(safi_dolar, "0", false) != 0);
			if (flag)
			{
				text = text + "select @codehesab_id=Codehesab_id from Moshtari where id=" + Moshtari_ID + ";";
				text += this.Sanad.InsertStrArzi("@codehesab_id", safi_dolar, Conversions.ToString(0), Tarikh_Vurud, tozih, Sanad.SanadType.صادرات_گیرنده_بار);
				text += "select @safi_dolar_sanad_id = scope_identity();";
			}
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.ErsalBar(Num,Moshtari_ID,Sh_Mashin,Sh_Barname,Tarikh_Vurud,[Desc],Baskul,Baskul_Mabda,Tedad_Kol,MablaghSafi,Moshtari_Sanad_ID,Keraye_Mabda,nahve_furush,type,safi_dolar,safi_dolar_sanad_id) VALUES(",
				Num,
				",",
				Moshtari_ID,
				",",
				Public_Function.GetValue(Sh_Mashin),
				",",
				Public_Function.GetValue(Sh_Barname),
				",",
				Public_Function.GetValue(Tarikh_Vurud),
				",",
				Public_Function.GetValue(Desc),
				",",
				Public_Function.GetValueInt(Baskul),
				",",
				Public_Function.GetValueInt(Baskul_Mabda),
				",",
				Public_Function.GetValueInt(Tedad_Kol),
				",",
				Public_Function.GetValueInt(Mablagh_Safi),
				",@moshtari_sanad_id,",
				Public_Function.GetValueInt(keraye_mabda),
				",",
				Public_Function.GetValueInt(nahve_furush),
				",1,",
				Public_Function.GetValueInt(safi_dolar),
				",@safi_dolar_sanad_id);Select @id=Scope_Identity();"
			});
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false));
					if (flag)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.صادرات_خرید_از_مشتری);
						text += "Select @Sanad_id=Scope_Identity();";
					}
					flag = (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) && Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -5, false));
					if (flag)
					{
						right = "NULL";
					}
					else
					{
						right = "@sanad_id";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_Detail(ErsalBar_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), Public_Function.GetValueInt(dataRow["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), ","), right), ");")));
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
			text += "select @id;";
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00044B00 File Offset: 0x00042D00
		public void Update(string ID, string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string Mablagh_Safi, string Keraye_Mabda, string nahve_furush, string safi_dolar, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_id bigint;declare @hazine_pardakht_id int;declare @moshtari_sanad_id bigint;declare @safi_dolar_sanad_id bigint;";
			string right = string.Empty;
			string right2 = string.Empty;
			string text2 = Public_Function.ExecuteScalar("select moshtari_sanad_id from ersalbar where id=" + ID).ToString();
			string text3 = Public_Function.ExecuteScalar("select safi_dolar_sanad_id from ersalbar where id=" + ID).ToString();
			tozih = " صادرات سند " + Num;
			text = text + "select @codehesab_id=Codehesab_id from Moshtari where id=" + Moshtari_ID + ";";
			bool flag = Operators.CompareString(Mablagh_Safi, string.Empty, false) != 0;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(text2, string.Empty, false) == 0);
				if (flag2)
				{
					text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.صادرات_گیرنده_بار);
				}
				else
				{
					text += this.Sanad.UpdateStr("@codehesab_id", Mablagh_Safi, Conversions.ToString(0), Tarikh_Vurud, tozih, text2, Sanad.SanadType.صادرات_گیرنده_بار);
					text = text + "select @moshtari_sanad_id=" + text2 + ";";
				}
			}
			else
			{
				flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
				if (flag2)
				{
					this.Sanad.Delete(text2);
					text2 = string.Empty;
					text += "select @moshtari_sanad_id=NULL;";
				}
			}
			flag2 = (Operators.CompareString(safi_dolar, string.Empty, false) != 0);
			if (flag2)
			{
				flag = (Operators.CompareString(text3, string.Empty, false) == 0);
				if (flag)
				{
					text += this.Sanad.InsertStrArzi("@codehesab_id", safi_dolar, "0", Tarikh_Vurud, tozih, Sanad.SanadType.صادرات_گیرنده_بار);
					text += "select @safi_dolar_sanad_id=scope_identity();";
				}
				else
				{
					text += this.Sanad.UpdateStrArzi("@codehesab_id", safi_dolar, Conversions.ToString(0), Tarikh_Vurud, tozih, text3, Sanad.SanadType.صادرات_گیرنده_بار);
					text = text + "select @safi_dolar_sanad_id=" + text3 + ";";
				}
			}
			else
			{
				flag2 = (Operators.CompareString(text3, string.Empty, false) != 0);
				if (flag2)
				{
					this.Sanad.Delete(text3);
					text3 = string.Empty;
					text += "select @safi_dolar_sanad_id=NULL;";
				}
			}
			text = string.Concat(new string[]
			{
				text,
				" Update dbo.ErsalBar SET Num=",
				Num,
				" ,Moshtari_ID=",
				Moshtari_ID,
				" ,Sh_Mashin=",
				Public_Function.GetValue(Sh_Mashin),
				" ,Sh_Barname=",
				Public_Function.GetValue(Sh_Barname),
				" ,Tarikh_Vurud=",
				Public_Function.GetValue(Tarikh_Vurud),
				" ,[Desc]=",
				Public_Function.GetValue(Desc),
				" ,Baskul=",
				Public_Function.GetValueInt(Baskul),
				" ,Baskul_Mabda=",
				Public_Function.GetValueInt(Baskul_Mabda),
				" ,Tedad_Kol=",
				Public_Function.GetValueInt(Tedad_Kol),
				" ,MablaghSafi=",
				Public_Function.GetValueInt(Mablagh_Safi),
				" ,Moshtari_sanad_id=@moshtari_sanad_id ,Keraye_Mabda=",
				Public_Function.GetValueInt(Keraye_Mabda),
				" ,nahve_furush=",
				Public_Function.GetValueInt(nahve_furush),
				" ,type=1 ,safi_dolar=",
				Public_Function.GetValueInt(safi_dolar),
				" ,safi_dolar_sanad_id=@safi_dolar_sanad_id Where ID=",
				ID,
				";"
			});
			flag2 = (iD.Length > 0);
			if (flag2)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.ErsalBar_Detail Where ErsalBar_ID=",
					ID,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.ErsalBar_Detail Where ErsalBar_ID=" + ID + ";";
			}
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag2 = (dataRow["ID"] == DBNull.Value);
					if (!flag2)
					{
						flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false));
						if (!flag2)
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
							{
								goto IL_9C3;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_9C3;
							}
							bool arg_9C5_0 = false;
							IL_9C4:
							flag2 = arg_9C5_0;
							if (flag2)
							{
								flag = (dataRow["sanad_id"] != DBNull.Value);
								if (flag)
								{
									string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update ErsalBar_Detail set sanad_id=null where id=", dataRow["ID"]), ";"));
									text4 = Conversions.ToString(Operators.ConcatenateObject(text4, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text4);
								}
								goto IL_A45;
							}
							goto IL_A45;
							IL_9C3:
							arg_9C5_0 = true;
							goto IL_9C4;
						}
						tozih = " صادرات سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.صادرات_خرید_از_مشتری);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.صادرات_خرید_از_مشتری);
							text += "Select @Sanad_id=Scope_Identity();";
						}
						IL_A45:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_A98;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_A98;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -5, false))
						{
							goto IL_AB8;
						}
						bool arg_ABA_0 = false;
						IL_AB9:
						flag2 = arg_ABA_0;
						if (flag2)
						{
							right = "NULL";
						}
						else
						{
							right = "@sanad_ID";
						}
						flag2 = (dataRow["keraye"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["Keraye"], 0, false));
						if (flag2)
						{
							flag = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value);
							if (flag)
							{
								text += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_ارسال_بار, "@keraye_id");
								right2 = "@keraye_id";
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_ارسال_بار);
								right2 = Public_Function.GetValueInt(dataRow["Keraye_Pardakht_ID"].ToString());
							}
						}
						else
						{
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value);
							if (flag2)
							{
								this.Daryaft.DeleteDaryaftPardakhtRadif(Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), "", "");
								right2 = "NULL";
							}
							else
							{
								right2 = "NULL";
							}
						}
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.ErsalBar_Detail SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), " ,Tarikh_Fa="), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), Public_Function.GetValueInt(dataRow["Fee"].ToString())), " ,Jam_Kol="), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), " , Sanad_ID="), right), " ,Mablagh_Safi="), Public_Function.GetValueInt(dataRow["Mablagh_Safi"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Keraye_Pardakht_ID= "), right2), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_AB8:
						arg_ABA_0 = true;
						goto IL_AB9;
						IL_A98:
						goto IL_AB8;
					}
					flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false));
					if (flag)
					{
						tozih = " صادرات سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.صادرات_خرید_از_مشتری);
						text += "Select @Sanad_id=Scope_Identity();";
						right = "@sanad_id";
					}
					else
					{
						right = "NULL";
					}
					flag2 = (dataRow["Keraye"] != DBNull.Value);
					if (flag2)
					{
						flag = Operators.ConditionalCompareObjectNotEqual(dataRow["Keraye"], 0, false);
						if (flag)
						{
							text += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_ارسال_بار, "@keraye_id");
							right2 = "@keraye_id";
						}
						else
						{
							right2 = "NULL";
						}
					}
					else
					{
						right2 = "NULL";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_Detail(ErsalBar_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID,Mablagh_Safi,Keraye,Keraye_Pardakht_ID) VALUES(" + ID + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), Public_Function.GetValueInt(dataRow["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), ","), right), ","), Public_Function.GetValueInt(dataRow["Mablagh_Safi"].ToString())), ","), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), ","), right2), ");")));
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
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		public void Delete(string ID)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			string text3 = string.Empty;
			DataTable dataTable = Public_Function.FillData("select * from ErsalBar_Keraye where ErsalBar_ID=" + ID);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				text3 = Public_Function.GetID(dataTable, "keraye_pardakht_id", "");
				DataTable dt = Public_Function.FillData("select sanadbed_id,sanadbes_id from daryaftpardakht where id in(" + text3 + ");");
				text2 = Public_Function.GetID(dt, "sanadbed_id", "");
				flag = (text2.Length > 0);
				if (flag)
				{
					text = text + "delete from sanad where id in (" + text2 + ");";
				}
				text2 = Public_Function.GetID(dt, "sanadbes_id", "");
				flag = (text2.Length > 0);
				if (flag)
				{
					text = text + "delete from sanad where id in(" + text2 + ");";
				}
				text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
				Public_Function.ExecuteNonQuery(text);
				text = string.Empty;
			}
			DataTable dataTable2 = Public_Function.FillData("select * from ErsalBar_detail where ErsalBar_ID=" + ID);
			flag = (dataTable2.Rows.Count > 0);
			bool flag2;
			if (flag)
			{
				text2 = Public_Function.GetID(dataTable2, "sanad_id", "");
				text = text + " update ErsalBar_detail set sanad_id=null where ErsalBar_ID= " + ID + ";";
				flag = (text2.Length > 0);
				if (flag)
				{
					text = text + "delete from sanad where id in(" + text2 + ");";
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
				text = string.Empty;
				string iD = Public_Function.GetID(dataTable2, "ID", "");
				text3 = Public_Function.GetID(dataTable2, "keraye_pardakht_id", "");
				flag = (Operators.CompareString(text3, string.Empty, false) != 0);
				if (flag)
				{
					DataTable dt = Public_Function.FillData("select * from daryaftPardakht where id in(" + text3 + ");");
					text2 = Public_Function.GetID(dt, "sanadbed_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						text2 += ",";
					}
					text2 += Public_Function.GetID(dt, "sanadbes_id", "");
					flag = (text2.Length > 0);
					if (flag)
					{
						flag2 = (Operators.CompareString(text2.Substring(checked(text2.Length - 1), 1), ",", false) == 0);
						if (flag2)
						{
							text2 = Public_Function.RemoveLast(text2);
						}
					}
					flag2 = (text2.Length > 0);
					if (flag2)
					{
						text = text + "update daryaftpardakht set sanadbed_id=null,sanadbes_id=null where id in(" + text3 + ");";
					}
					flag2 = (text2.Length > 0);
					if (flag2)
					{
						text = text + "delete from sanad where id in(" + text2 + ");";
					}
					text = text + "delete from daryaftpardakht where id in(" + text3 + ");";
				}
				text = text + "delete ErsalBar_detail where id in(" + iD + ");";
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			text = "Delete From dbo.ErsalBar Where Id= " + ID + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
		public void DeleteDetailByID(string id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(Keraye_pardakht_id,0) from ErsalBar_Detail where id=" + id));
			long value2 = Conversions.ToLong(Public_Function.ExecuteScalar("select ErsalBar_ID from ErsalBar_detail where id=" + id));
			string text = "declare @sanad_id int;declare @Keraye_pardakht_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
			text = text + "select @sanad_id=sanad_id , @Keraye_pardakht_id=Keraye_pardakht_id from ErsalBar_detail where id=" + id + ";";
			text = text + "update ErsalBar_detail set sanad_id=null,Keraye_pardakht_id=null where id=" + id + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from ErsalBar_detail where id=" + id + ";";
			Public_Function.ExecuteNonQuery(text);
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select isnull(count(id),0) from ErsalBar_detail where ErsalBar_ID=" + Conversions.ToString(value2) + " and Keraye_pardakht_id=" + Conversions.ToString(value)));
			bool flag = num == 0;
			if (flag)
			{
				text = "declare @sanad_id int;declare @Keraye_pardakht_id int;declare @sanadbes_id int;declare @sanadbed_id int;";
				text = text + "select @sanadbed_id=sanadbed_id,@sanadbes_id=sanadbes_id from daryaftpardakht where id= " + Conversions.ToString(value) + ";";
				text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(value) + ";";
				text += "delete from sanad where id =@sanadbed_id;";
				text += "delete from sanad where id=@sanadbes_id;";
				text = text + "delete from daryaftpardakht where id=" + Conversions.ToString(value) + ";";
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x0400014A RID: 330
		private Sanad Sanad;

		// Token: 0x0400014B RID: 331
		private DaryaftPardakht Daryaft;

		// Token: 0x02000041 RID: 65
		public enum NavTo
		{
			// Token: 0x0400014D RID: 333
			forward = 1,
			// Token: 0x0400014E RID: 334
			backward,
			// Token: 0x0400014F RID: 335
			first,
			// Token: 0x04000150 RID: 336
			last
		}
	}
}
