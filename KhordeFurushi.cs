using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200003B RID: 59
	public class KhordeFurushi
	{
		// Token: 0x0600030B RID: 779 RVA: 0x000026F2 File Offset: 0x000008F2
		public KhordeFurushi()
		{
			this.Sanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0004184C File Offset: 0x0003FA4C
		public DataRow GetByID(string Num)
		{
			return Public_Function.FillDataRow("SELECT     * from khordefurushi  where tarikh =" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Num)));
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00041878 File Offset: 0x0003FA78
		public DataTable GetDetailByID(long ID)
		{
			return Public_Function.FillData("SELECT     KhordeFurushi_Detail.ID, KhordeFurushi_Detail.KhordeFurushi_ID, KhordeFurushi_Detail.Moshtari_ID, KhordeFurushi_Detail.Kala_ID,    KhordeFurushi_Detail.Tedad, KhordeFurushi_Detail.Vazn_Ba_Zarf, KhordeFurushi_Detail.Zarf, KhordeFurushi_Detail.Vazn_Kol,  KhordeFurushi_Detail.Fee, KhordeFurushi_Detail.Jam_Kol,KhordeFurushi_Detail.Keraye,KhordeFurushi_Detail.Keraye_Pardakht_ID, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Kala.Name AS Kala_Name,   KhordeFurushi_Detail.Moshtari_Sanad_ID,KhordeFurushi_Detail.Tedad as tafazol_tedad,KhordeFurushi_Detail.Vazn_Ba_Zarf as tafazol_vazn, NULL AS Row_Index   FROM         KhordeFurushi_Detail INNER JOIN   Moshtari ON KhordeFurushi_Detail.Moshtari_ID = Moshtari.ID INNER JOIN   Kala ON KhordeFurushi_Detail.Kala_ID = Kala.ID INNER JOIN   KhordeFurushi ON KhordeFurushi_Detail.KhordeFurushi_ID = KhordeFurushi.ID   where KhordeFurushi.ID=" + Conversions.ToString(ID));
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000418A0 File Offset: 0x0003FAA0
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Num),0)+1 from dbo.ErsalBar"));
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000418C4 File Offset: 0x0003FAC4
		public long GetNavigateID(KhordeFurushi.NavTo nav, long num)
		{
			string empty = string.Empty;
			long result;
			switch (nav)
			{
			case KhordeFurushi.NavTo.forward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.KhordeFurushi   WHERE Num > " + Conversions.ToString(num) + " ORDER BY Num ASC"));
				break;
			case KhordeFurushi.NavTo.backward:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT TOP 1 Num FROM dbo.KhordeFurushi   WHERE Num < " + Conversions.ToString(num) + " ORDER BY Num DESC"));
				break;
			case KhordeFurushi.NavTo.first:
				result = Conversions.ToLong(Public_Function.ExecuteScalar(" SELECT isnull(MIN(Num),1) FROM dbo.KhordeFurushi"));
				break;
			case KhordeFurushi.NavTo.last:
				result = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(MAX(Num),1) FROM dbo.KhordeFurushi"));
				break;
			}
			return result;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0002C4F0 File Offset: 0x0002A6F0
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.ErsalBar.ID,dbo.ErsalBar.Num,dbo.ErsalBar.Moshtari_ID,dbo.ErsalBar.Sh_Mashin,dbo.ErsalBar.Sh_Barname,dbo.ErsalBar.Tarikh_Vurud,dbo.ErsalBar.[Desc],dbo.ErsalBar.Baskul,Baskul_Mabda,dbo.ErsalBar.Tedad_Kol,dbo.ErsalBar.Keraye,dbo.ErsalBar.Hazine,dbo.ErsalBar.Tarikh_Keraye,dbo.ErsalBar.Tarikh_Hazine,dbo.ErsalBar.Tarikh_Keraye_Fa,dbo.ErsalBar.Tarikh_Hazine_Fa From dbo.ErsalBar");
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00041968 File Offset: 0x0003FB68
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
				text += this.Sanad.InsertStr("@codehesab_id", Mablagh_Safi, "0", Tarikh_Vurud, tozih, "@moshtari_sanad_id", Sanad.SanadType.@null);
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
						text += this.Sanad.InsertStr("@codehesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Jam_Kol"]), Conversions.ToString(dataRow["Tarikh_Fa"]), tozih, Sanad.SanadType.@null);
						text += "Select @Sanad_id=Scope_Identity();";
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
					{
						goto IL_319;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["Moshtari_ID"], -3, false))
					{
						goto IL_319;
					}
					if (Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false))
					{
						goto IL_339;
					}
					bool arg_33B_0 = false;
					IL_33A:
					flag = arg_33B_0;
					if (flag)
					{
						right = "NULL";
					}
					else
					{
						right = "@sanad_id";
					}
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_Detail(ErsalBar_ID,Moshtari_ID,Kala_ID,Tarikh,Tarikh_Fa,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Sanad_ID) VALUES(@id,", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), Public_Function.GetValueInt(dataRow["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), ","), right), ");")));
					continue;
					IL_339:
					arg_33B_0 = true;
					goto IL_33A;
					IL_319:
					goto IL_339;
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

		// Token: 0x06000312 RID: 786 RVA: 0x0002C50C File Offset: 0x0002A70C
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

		// Token: 0x06000313 RID: 787 RVA: 0x00041EB0 File Offset: 0x000400B0
		private void UpdateSanadFurushNaghdByID(string id)
		{
			string tarikh_Fa = Conversions.ToString(Public_Function.ExecuteScalar("select tarikh_fa from khordefurushi where id=" + id));
			this.UpdateSanadFurushNaghd(tarikh_Fa, id);
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00041EE0 File Offset: 0x000400E0
		public void UpdateSanadFurushNaghd(string Tarikh_Fa, string ID)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(jam_kol),0) from khordefurushi_detail where khordefurushi_id= " + ID + " AND Moshtari_id=-1"));
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(pardakht_naghd_id,'') from khordefurushi where id=" + ID));
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			string text2 = "declare @sanadbed_id int,@sanadbes_id int;";
			bool flag = num > 0L;
			bool flag2;
			if (flag)
			{
				flag2 = (Operators.CompareString(text, string.Empty, false) == 0 || Operators.CompareString(text, "0", false) == 0);
				if (flag2)
				{
					daryaftPardakht.AddRowPardakhtExtend(Tarikh_Fa, Conversions.ToString(num), "", "", DaryaftPardakht.dptype_ID.خرید_نقدی, DaryaftPardakht.CodeHesab.NULL, "khordefurushi", "pardakht_naghd_ID", ID);
				}
				else
				{
					text2 += daryaftPardakht.UpdateRowStrToPardakht(Tarikh_Fa, Conversions.ToString(num), "", "", text, DaryaftPardakht.dptype_ID.خرید_نقدی, DaryaftPardakht.CodeHesab.NULL);
				}
			}
			else
			{
				flag2 = (num == 0L);
				if (flag2)
				{
					flag = (Operators.CompareString(text, string.Empty, false) != 0);
					if (flag)
					{
						daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(text, "Khordefurushi", "pardakht_naghd_id", ID);
					}
				}
			}
			flag2 = (Operators.CompareString(text2, string.Empty, false) != 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00042008 File Offset: 0x00040208
		public void Update(string Tarikh_Fa, string nahve_furush, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string tozih = string.Empty;
			string text = "declare @sanad_id int;declare @codehesab_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @daryaft_id int;declare @keraye_id bigint;declare @hazine_pardakht_id int;declare @moshtari_sanad_id bigint;";
			string right = string.Empty;
			string right2 = string.Empty;
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select id from khordefurushi where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa))));
			bool flag = Operators.CompareString(text2, string.Empty, false) == 0;
			if (flag)
			{
				text2 = Conversions.ToString(Public_Function.ExecuteScalar(string.Concat(new string[]
				{
					"insert into khordeFurushi (Tarikh,tarikh_fa,nahve_furush) values(",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
					",",
					Public_Function.GetValue(Tarikh_Fa),
					",",
					nahve_furush,
					");select scope_identity();"
				})));
			}
			flag = (iD.Length > 0);
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.KhordeFurushi_Detail Where Khordefurushi_ID=",
					text2,
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.KhordeFurushi_Detail Where Khordefurushi_ID=" + text2 + ";";
			}
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = (dataRow["ID"] == DBNull.Value);
					bool flag2;
					if (!flag)
					{
						flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false);
						if (!flag2)
						{
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -2, false))
							{
								goto IL_5EA;
							}
							if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_id"], -3, false))
							{
								goto IL_5EA;
							}
							bool arg_5EC_0 = false;
							IL_5EB:
							flag2 = arg_5EC_0;
							if (flag2)
							{
								flag = (dataRow["moshtari_sanad_id"] != DBNull.Value);
								if (flag)
								{
									string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("update KhordeFurushi_Detail set moshtari_sanad_id=null where id=", dataRow["ID"]), ";"));
									text3 = Conversions.ToString(Operators.ConcatenateObject(text3, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", dataRow["Moshtari_sanad_id"]), ";")));
									Public_Function.ExecuteNonQuery(text3);
								}
								goto IL_66C;
							}
							goto IL_66C;
							IL_5EA:
							arg_5EC_0 = true;
							goto IL_5EB;
						}
						tozih = " خرید ";
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						flag2 = (dataRow["Moshtari_Sanad_ID"] != DBNull.Value);
						if (flag2)
						{
							text += this.Sanad.UpdateStr("@codehesab_id", Conversions.ToString(0), Conversions.ToString(dataRow["Jam_Kol"]), Tarikh_Fa, tozih, Conversions.ToString(dataRow["Moshtari_Sanad_ID"]), Sanad.SanadType.خرید_مغازه_خرده_فروشی);
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject("select @sanad_id=", dataRow["Moshtari_Sanad_ID"])));
						}
						else
						{
							text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), Tarikh_Fa, tozih, Sanad.SanadType.خرید_مغازه_خرده_فروشی);
							text += "Select @Sanad_id=Scope_Identity();";
						}
						IL_66C:
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -1, false) || Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -2, false))
						{
							goto IL_6BF;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -3, false))
						{
							goto IL_6BF;
						}
						if (Operators.ConditionalCompareObjectEqual(dataRow["moshtari_ID"], -5, false))
						{
							goto IL_6DF;
						}
						bool arg_6E1_0 = false;
						IL_6E0:
						flag2 = arg_6E1_0;
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
								text += this.Daryaft.AddRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_خرید, "@keraye_id");
								right2 = "@keraye_id";
							}
							else
							{
								text += this.Daryaft.UpdateRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_خرید);
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
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.KhordeFurushi_Detail SET Moshtari_ID=", dataRow["Moshtari_ID"]), " ,Kala_ID="), dataRow["Kala_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn_Ba_Zarf="), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), " ,Zarf="), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), " ,Vazn_Kol="), dataRow["Vazn_Kol"]), " ,Fee="), Public_Function.GetValueInt(dataRow["Fee"].ToString())), " ,Jam_Kol="), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), " , Moshtari_Sanad_ID="), right), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Keraye_Pardakht_ID= "), right2), " Where ID="), dataRow["ID"]), ";")));
						continue;
						IL_6DF:
						arg_6E1_0 = true;
						goto IL_6E0;
						IL_6BF:
						goto IL_6DF;
					}
					flag2 = (Operators.ConditionalCompareObjectNotEqual(dataRow["Moshtari_ID"], -1, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_id"], -2, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -3, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["moshtari_ID"], -5, false));
					if (flag2)
					{
						tozih = " خرید ";
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("select @codehesab_id=Codehesab_id from Moshtari where id=", dataRow["Moshtari_ID"]), ";")));
						text += this.Sanad.InsertStr("@codehesab_id", "0", dataRow["Jam_Kol"].ToString(), Tarikh_Fa, tozih, Sanad.SanadType.خرید_مغازه_خرده_فروشی);
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
							text += this.Daryaft.AddRowStrToPardakht(Tarikh_Fa, Conversions.ToString(dataRow["Keraye"]), "", Conversions.ToString(dataRow["Moshtari_ID"]), DaryaftPardakht.dptype_ID.پرداخت_مخارج, DaryaftPardakht.CodeHesab.مخارج_خرید, "@keraye_id");
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
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.KhordeFurushi_Detail(KhordeFurushi_ID,Moshtari_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol,Moshtari_Sanad_ID,Keraye,Keraye_Pardakht_ID) VALUES(" + text2 + ",", dataRow["Moshtari_ID"]), ","), dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), Public_Function.GetValueInt(Conversions.ToString(dataRow["Vazn_Kol"]))), ","), Public_Function.GetValueInt(dataRow["Fee"].ToString())), ","), Public_Function.GetValueInt(dataRow["Jam_Kol"].ToString())), ","), right), ","), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), ","), right2), ");")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag2 = enumerator is IDisposable;
				if (flag2)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
			this.UpdateSanadFurushNaghd(Tarikh_Fa, text2);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
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

		// Token: 0x06000317 RID: 791 RVA: 0x00042A4C File Offset: 0x00040C4C
		public void DeleteDetailByID(string id)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(Keraye_pardakht_id,0) from KhordeFurushi_Detail where id=" + id));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(Moshtari_sanad_id,0) from KhordeFurushi_Detail where id=" + id));
			string id2 = Conversions.ToString(Public_Function.ExecuteScalar("select khordefurushi_id from KhordeFurushi_Detail where id=" + id));
			bool flag = num != 0L;
			if (flag)
			{
				DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
				daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(num), "khordefurushi_detail", "keraye_pardakht_id", id);
			}
			flag = (num2 != 0L);
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(Conversions.ToString(num2));
			}
			string command = "delete from khordefurushi_detail where id=" + id;
			Public_Function.ExecuteNonQuery(command);
			this.UpdateSanadFurushNaghdByID(id2);
		}

		// Token: 0x04000134 RID: 308
		private Sanad Sanad;

		// Token: 0x04000135 RID: 309
		private DaryaftPardakht Daryaft;

		// Token: 0x0200003C RID: 60
		public enum NavTo
		{
			// Token: 0x04000137 RID: 311
			forward = 1,
			// Token: 0x04000138 RID: 312
			backward,
			// Token: 0x04000139 RID: 313
			first,
			// Token: 0x0400013A RID: 314
			last
		}
	}
}
