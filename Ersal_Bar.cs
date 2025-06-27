using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000024 RID: 36
	public class Ersal_Bar
	{
		// Token: 0x0600022A RID: 554 RVA: 0x000023AB File Offset: 0x000005AB
		public Ersal_Bar()
		{
			this.Sanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0002C3D8 File Offset: 0x0002A5D8
		public DataRow GetByID(long Num)
		{
			return Public_Function.FillDataRow("SELECT     ErsalBar.*, Moshtari.Name+' '+ Moshtari.Family AS Moshtari_Name  FROM         ErsalBar INNER JOIN   Moshtari ON ErsalBar.Moshtari_ID = Moshtari.ID  where type is null and num =" + Conversions.ToString(Num));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0002C400 File Offset: 0x0002A600
		public DataTable GetDetailByID(long ID)
		{
			return Public_Function.FillData("SELECT     ErsalBar_Detail.ID, ErsalBar_Detail.ErsalBar_ID, ErsalBar_Detail.Moshtari_ID, ErsalBar_Detail.Kala_ID, ErsalBar_Detail.Tarikh,   ErsalBar_Detail.Tarikh_Fa, ErsalBar_Detail.Tedad, ErsalBar_Detail.Vazn_Ba_Zarf, ErsalBar_Detail.Zarf, ErsalBar_Detail.Vazn_Kol,  ErsalBar_Detail.Fee, ErsalBar_Detail.Jam_Kol,ErsalBar_Detail.Sanad_ID,ErsalBar_Detail.Mablagh_Safi,ErsalBar_Detail.Keraye,ErsalBar_Detail.Keraye_Pardakht_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   ErsalBar_Detail.Sanad_ID,ErsalBar_Detail.Tedad as tafazol_tedad,ErsalBar_Detail.Vazn_Ba_Zarf as tafazol_vazn, ErsalBar_Detail.Kala_ID AS prekala_id,NULL AS Row_Index   FROM         ErsalBar_Detail INNER JOIN   Moshtari ON ErsalBar_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON ErsalBar_Detail.Kala_ID = Kala.ID INNER JOIN   ErsalBar ON ErsalBar_Detail.ErsalBar_ID = ErsalBar.ID   where ErsalBar.ID=" + Conversions.ToString(ID));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0002C428 File Offset: 0x0002A628
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.ErsalBar where type is null"));
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0002C44C File Offset: 0x0002A64C
		public long GetNavigateID(Ersal_Bar.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case Ersal_Bar.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.ErsalBar   WHERE type is null and Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case Ersal_Bar.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.ErsalBar   WHERE type is null and Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case Ersal_Bar.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT isnull(MIN(Num),1) FROM dbo.ErsalBar where type is null"));
				break;
			case Ersal_Bar.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(MAX(Num),1) FROM dbo.ErsalBar where type is null"));
				break;
			}
			return result;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.ErsalBar.ID,dbo.ErsalBar.Num,dbo.ErsalBar.Moshtari_ID,dbo.ErsalBar.Sh_Mashin,dbo.ErsalBar.Sh_Barname,dbo.ErsalBar.Tarikh_Vurud,dbo.ErsalBar.[Desc],dbo.ErsalBar.Baskul,Baskul_Mabda,dbo.ErsalBar.Tedad_Kol,dbo.ErsalBar.Keraye,dbo.ErsalBar.Hazine,dbo.ErsalBar.Tarikh_Keraye,dbo.ErsalBar.Tarikh_Hazine,dbo.ErsalBar.Tarikh_Keraye_Fa,dbo.ErsalBar.Tarikh_Hazine_Fa From dbo.ErsalBar");
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x06000231 RID: 561 RVA: 0x0002C58C File Offset: 0x0002A78C
		public long Insert(string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string Mablagh_Safi, string keraye_mabda, string nahve_furush, DataTable dt)
		{
			string tozih = string.Empty;
			string text = "declare @id bigint;declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_pardakht_id int;declare @hazine_pardakht_id int;declare @moshtari_sanad_id bigint;";
			string right = string.Empty;
			tozih = " ارسال بار سند " + Num;
			bool flag = Operators.CompareString(Mablagh_Safi, string.Empty, false) != 0 && Operators.CompareString(Mablagh_Safi, "0", false) != 0;
			if (flag)
			{
				text = text + "select @codehesab_id=Codehesab_id from Moshtari where id=" + Moshtari_ID + ";";
				text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.ارسال_بار_گیرنده_بار);
			}
			text = string.Concat(new string[]
			{
				text,
				" Insert Into dbo.ErsalBar(Num,Moshtari_ID,Sh_Mashin,Sh_Barname,Tarikh_Vurud,[Desc],Baskul,Baskul_Mabda,Tedad_Kol,MablaghSafi,Moshtari_Sanad_ID,Keraye_Mabda,nahve_furush) VALUES(",
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
				" );Select @id=Scope_Identity();"
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
						text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.خرید_ارسال_بار_از_مشتری_);
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

		// Token: 0x06000232 RID: 562 RVA: 0x0002CAD0 File Offset: 0x0002ACD0
		public void Update(string ID, string Num, string Moshtari_ID, string Sh_Mashin, string Sh_Barname, string Tarikh_Vurud, string Desc, string Baskul, string Baskul_Mabda, string Tedad_Kol, string Mablagh_Safi, string Keraye_Mabda, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_id bigint;declare @hazine_pardakht_id int;declare @moshtari_sanad_id bigint;";
			string right = string.Empty;
			string right2 = string.Empty;
			string text2 = Public_Function.ExecuteScalar("select moshtari_sanad_id from ersalbar where id=" + ID).ToString();
			tozih = " ارسال بار سند " + Num;
			text = text + "select @codehesab_id=Codehesab_id from Moshtari where id=" + Moshtari_ID + ";";
			bool flag = Operators.CompareString(Mablagh_Safi, string.Empty, false) != 0;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(text2, string.Empty, false) == 0);
				if (flag2)
				{
					text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.ارسال_بار_گیرنده_بار);
				}
				else
				{
					object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select top 1 id from sanad where id=" + text2));
					flag2 = (objectValue == null);
					if (flag2)
					{
						text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.ارسال_بار_گیرنده_بار);
					}
					else
					{
						text += this.Sanad.UpdateStr("@codehesab_id", Mablagh_Safi, Conversions.ToString(0), Tarikh_Vurud, tozih, text2, Sanad.SanadType.ارسال_بار_گیرنده_بار);
						text = text + "select @moshtari_sanad_id=" + text2 + ";";
					}
				}
			}
			else
			{
				flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
				if (flag2)
				{
					this.Sanad.Delete(text2);
					text2 = string.Empty;
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
				" Where ID=",
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
								goto IL_8FB;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_8FB;
							}
							bool arg_8FD_0 = false;
							IL_8FC:
							flag2 = arg_8FD_0;
							if (flag2)
							{
								flag = (dataRow["sanad_id"] != DBNull.Value);
								if (flag)
								{
									string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update ErsalBar_Detail set sanad_id=null where id=", dataRow["ID"]), ";"));
									text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text3);
								}
								goto IL_97D;
							}
							goto IL_97D;
							IL_8FB:
							arg_8FD_0 = true;
							goto IL_8FC;
						}
						tozih = " ارسال بار سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Conversions.ToString(dataRow["Sanad_ID"]), Sanad.SanadType.خرید_ارسال_بار_از_مشتری_);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Sanad_ID"])));
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.خرید_ارسال_بار_از_مشتری_);
							text += "Select @Sanad_id=Scope_Identity();";
						}
						IL_97D:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_9D0;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_9D0;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -5, false))
						{
							goto IL_9F0;
						}
						bool arg_9F2_0 = false;
						IL_9F1:
						flag2 = arg_9F2_0;
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
						IL_9F0:
						arg_9F2_0 = true;
						goto IL_9F1;
						IL_9D0:
						goto IL_9F0;
					}
					flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false));
					if (flag)
					{
						tozih = " ارسال بار سند " + Num;
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), dataRow["Tarikh_Fa"].ToString(), tozih, Sanad.SanadType.خرید_ارسال_بار_از_مشتری_);
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

		// Token: 0x06000233 RID: 563 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
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

		// Token: 0x06000234 RID: 564 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
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

		// Token: 0x040000DC RID: 220
		private Sanad Sanad;

		// Token: 0x040000DD RID: 221
		private DaryaftPardakht Daryaft;

		// Token: 0x02000025 RID: 37
		public enum NavTo
		{
			// Token: 0x040000DF RID: 223
			forward = 1,
			// Token: 0x040000E0 RID: 224
			backward,
			// Token: 0x040000E1 RID: 225
			first,
			// Token: 0x040000E2 RID: 226
			last
		}
	}
}
