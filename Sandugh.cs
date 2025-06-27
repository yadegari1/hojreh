using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200004A RID: 74
	public class Sandugh
	{
		// Token: 0x06000369 RID: 873 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Sandugh()
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00048DF8 File Offset: 0x00046FF8
		public bool IsSandughBaste(string tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(tarikh) from mande_sandugh where tarikh= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))));
			return num > 0;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00048E3C File Offset: 0x0004703C
		public long DaryaftNaghd(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(-1,1,6,40)"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(26) and bankhesab_id is null"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(28) and moshtari_id=-1"));
			long num4 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(27,32,42)"));
			long num5 = Conversions.ToLong(Public_Function.ExecuteScalar("SELECT isnull(sum(Sanad_Dasti_Detail.bed),0) FROM Sanad_Dasti INNER JOIN Sanad_Dasti_Detail ON Sanad_Dasti.ID = Sanad_Dasti_Detail.Sanad_Dasti_id where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and hesab_type=1"));
			checked
			{
				num += num3 + num5 + num2;
				return num - num4;
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00048F18 File Offset: 0x00047118
		public long PardakhtNaghd(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(10,14,-2,-3,-5) and sh_fish is null"));
			num = Conversions.ToLong(Operators.AddObject(num, Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(15) and sh_check is null and bankhesab_id is null ")));
			num = Conversions.ToLong(Operators.AddObject(num, Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(37,38) and sandug_id is not null ")));
			return Conversions.ToLong(Operators.AddObject(num, Public_Function.ExecuteScalar("SELECT isnull(sum(Sanad_Dasti_Detail.bes),0) FROM Sanad_Dasti INNER JOIN Sanad_Dasti_Detail ON Sanad_Dasti.ID = Sanad_Dasti_Detail.Sanad_Dasti_id where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and hesab_type=1")));
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00048FE4 File Offset: 0x000471E4
		public long DaryaftNaghdAfter(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(-1,1,26,6,40)"));
			long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(28) and moshtari_id=-1"));
			long num3 = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(27,32)"));
			checked
			{
				num += num2;
				return num - num3;
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00049070 File Offset: 0x00047270
		public long PardakhtNaghdAfter(string tarikh)
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(10,14,-2,-3,-5)"));
			num = Conversions.ToLong(Operators.AddObject(num, Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(15) and sh_check is null and bankhesab_id is null ")));
			return Conversions.ToLong(Operators.AddObject(num, Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " and dptype_id in(37,38) and sandug_id is not null ")));
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0004910C File Offset: 0x0004730C
		public long SynckasrEzafe(string tarikh)
		{
			bool flag = Operators.ConditionalCompareObjectGreater(Public_Function.ExecuteScalar("select count(mande) from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))), 0, false);
			long result;
			if (flag)
			{
				long num = 0L;
				long num2 = Conversions.ToLong(Public_Function.ExecuteScalar("select mande from mande_sandugh where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh))));
				long num3 = this.DaryaftNaghd(tarikh);
				long num4 = this.PardakhtNaghd(tarikh);
				DataRow dataRow = Public_Function.FillDataRow("select top 1 mande from mande_sandugh where tarikh< " + Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)) + " order by tarikh desc ");
				flag = (dataRow != null);
				if (flag)
				{
					num = Conversions.ToLong(dataRow["mande"]);
				}
				else
				{
					dataRow = Public_Function.FillDataRow("select bed from sanad where codehesab_id=1 and tarikh= " + Public_Function.GetValue(Public_Function.ShamsiToMiladi("1392/01/01")) + " order by tarikh desc ");
					flag = (dataRow != null);
					if (flag)
					{
						num = Conversions.ToLong(dataRow["bed"]);
					}
				}
				long num5 = checked(num2 - (num + num3 - num4));
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"delete from sanad where id in (select sanadbed_id from dbo.DaryaftPardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
					" and dptype_id in (5,16));delete from sanad where id in (select sanadbes_id from dbo.DaryaftPardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
					" and dptype_id in (5,16)); delete from dbo.DaryaftPardakht where tarikh=",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
					" and dptype_id in (5,16);"
				}));
				flag = (num5 == 0L);
				if (flag)
				{
					result = 0L;
				}
				else
				{
					string text = string.Empty;
					flag = (num5 > 0L);
					if (flag)
					{
						text = string.Concat(new string[]
						{
							text,
							"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(5,",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
							",Null,Null,-1,1,",
							Conversions.ToString(num5),
							",'',",
							Public_Function.GetValue(tarikh),
							");"
						});
					}
					flag = (num5 < 0L);
					if (flag)
					{
						text = string.Concat(new string[]
						{
							text,
							"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa) VALUES(16,",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(tarikh)),
							",Null,Null,-1,1,",
							Conversions.ToString(Math.Abs(num5)),
							",'',",
							Public_Function.GetValue(tarikh),
							");"
						});
					}
					Public_Function.ExecuteNonQuery(text);
					result = num5;
				}
			}
			return result;
		}
	}
}
