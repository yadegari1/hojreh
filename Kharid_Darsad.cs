using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000035 RID: 53
	public class Kharid_Darsad
	{
		// Token: 0x060002E8 RID: 744 RVA: 0x0000265D File Offset: 0x0000085D
		public Kharid_Darsad()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0003ED50 File Offset: 0x0003CF50
		public void DeleteByID(string ID)
		{
			string text = "declare @sanad_id int;select @sanad_id=sanad_id from kharid_darsad where id=" + ID + ";";
			text = text + "update kharid_darsad set sanad_id=null where id=" + ID + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from kharid_darsad where id=" + ID + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0003EDA8 File Offset: 0x0003CFA8
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT     Kharid_Darsad.ID, Kharid_Darsad.Moshtari_ID, Kharid_Darsad.darsad, Kharid_Darsad.Mablagh, Kharid_Darsad.Sanad_ID,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name   FROM         Kharid_Darsad INNER JOIN    Moshtari ON Kharid_Darsad.Moshtari_ID = Moshtari.ID where Kharid_ID=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0003EDD0 File Offset: 0x0003CFD0
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
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Darsad(Kharid_ID,Moshtari_ID,Darsad,mablagh) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Moshtari_ID"]), ","), Public_Function.GetValueInt(dataRow["Darsad"].ToString())), ","), Public_Function.GetValueInt(dataRow["mablagh"].ToString())), ");")));
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

		// Token: 0x060002EC RID: 748 RVA: 0x0003EEE0 File Offset: 0x0003D0E0
		public void Update(int Kharid_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;";
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Kharid_Darsad Where Kharid_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Kharid_Darsad Where Kharid_ID=" + Conversions.ToString(Kharid_ID) + ";";
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Darsad(Kharid_ID,Moshtari_ID,Darsad,mablagh) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Moshtari_ID"]), ","), Public_Function.GetValueInt(dataRow["Darsad"].ToString())), ","), Public_Function.GetValueInt(dataRow["mablagh"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Darsad SET Darsad=" + Public_Function.GetValueInt(dataRow["Darsad"].ToString()) + " ,Moshtari_ID=", dataRow["Moshtari_ID"]), " ,mablagh="), dataRow["mablagh"]), " Where ID="), dataRow["ID"]), ";")));
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

		// Token: 0x04000126 RID: 294
		private Sanad Isanad;

		// Token: 0x04000127 RID: 295
		private DaryaftPardakht Daryaft;
	}
}
