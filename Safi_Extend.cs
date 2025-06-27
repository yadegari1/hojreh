using System;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000045 RID: 69
	public class Safi_Extend
	{
		// Token: 0x06000352 RID: 850 RVA: 0x000027D7 File Offset: 0x000009D7
		public Safi_Extend()
		{
			this.sanad = new Sanad();
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000472C8 File Offset: 0x000454C8
		public DataRow GetByID(string Furush_ID)
		{
			return Public_Function.FillDataRow("select * from safi_furush_extend where furush_id=" + Furush_ID);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000472EC File Offset: 0x000454EC
		public void Update(string Furush_ID, string Safi_Type, string Mablagh, string row_Mablagh, string Tozih, string ID)
		{
			string text = "declare @sanad_id bigint;";
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select id from [Safi_Furush_Extend] where furush_id=" + Furush_ID));
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select sum(jam_kol) from furush_hag_detail where furush_hug_id= " + Furush_ID));
			Mablagh = Conversions.ToString(Conversions.ToDouble(Mablagh) - (double)num);
			bool flag = Operators.CompareString(text2, string.Empty, false) == 0;
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(Mablagh) > 0.0;
				if (flag2)
				{
					Tozih = "افزایش صافی - " + Tozih;
					text += this.sanad.InsertStr("34", Mablagh.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), Tozih, "@sanad_id", Sanad.SanadType.@null);
				}
				else
				{
					flag2 = (Conversions.ToDouble(Mablagh) < 0.0);
					if (flag2)
					{
						Tozih = "کاهش صافی - " + Tozih;
						text += this.sanad.InsertStr("35", "0", (Conversions.ToDouble(Mablagh) * -1.0).ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), Tozih, "@sanad_id", Sanad.SanadType.@null);
					}
					else
					{
						flag2 = (Conversions.ToDouble(Mablagh) == 0.0);
						if (flag2)
						{
							text += "set @sanad_id=null;";
						}
					}
				}
				text = string.Concat(new string[]
				{
					text,
					"insert into safi_furush_extend (furush_id,safi_type,mablagh,sanad_id,row_mablagh) values(",
					Furush_ID,
					",",
					Safi_Type,
					",",
					Mablagh,
					",@sanad_id,",
					Public_Function.GetValue(row_Mablagh),
					"); "
				});
			}
			else
			{
				text = text + "select @sanad_id=sanad_id from safi_furush_extend where id=" + text2 + ";";
				bool flag2 = Conversions.ToDouble(Mablagh) > 0.0;
				if (flag2)
				{
					text = text + " if @sanad_id = null BEGIN " + Environment.NewLine;
					text += this.sanad.InsertStr("34", Mablagh.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "افزایش صافی", "@sanad_id", Sanad.SanadType.@null);
					text = text + " END else " + Environment.NewLine;
					text += this.sanad.UpdateStr("34", Mablagh.ToString(), "0", Public_Function.MiladiToShamsi(DateAndTime.Now), "افزایش صافی", "@sanad_id", Sanad.SanadType.@null);
				}
				else
				{
					flag2 = (Conversions.ToDouble(Mablagh) < 0.0);
					if (flag2)
					{
						text = text + " if @sanad_id = null BEGIN " + Environment.NewLine;
						text += this.sanad.InsertStr("35", "0", (Conversions.ToDouble(Mablagh) * -1.0).ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "کاهش صافی", "@sanad_id", Sanad.SanadType.@null);
						text = text + " END else " + Environment.NewLine;
						text += this.sanad.UpdateStr("35", "0", (Conversions.ToDouble(Mablagh) * -1.0).ToString(), Public_Function.MiladiToShamsi(DateAndTime.Now), "کاهش صافی", "@sanad_id", Sanad.SanadType.@null);
					}
				}
				text = string.Concat(new string[]
				{
					text,
					"update safi_furush_extend set  safi_type=",
					Safi_Type,
					" ,mablagh=",
					Mablagh,
					" ,row_mablagh= ",
					Public_Function.GetValue(row_Mablagh),
					" ,sanad_id=@sanad_id where id=",
					text2
				});
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x04000154 RID: 340
		private Sanad sanad;
	}
}
