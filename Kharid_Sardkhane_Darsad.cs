using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200003A RID: 58
	public class Kharid_Sardkhane_Darsad
	{
		// Token: 0x06000306 RID: 774 RVA: 0x000026D2 File Offset: 0x000008D2
		public Kharid_Sardkhane_Darsad()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000414C8 File Offset: 0x0003F6C8
		public void DeleteByID(string ID)
		{
			string text = "declare @sanad_id int;select @sanad_id=sanad_id from kharid_Sardkhane_darsad where id=" + ID + ";";
			text = text + "update kharid_Sardkhane_darsad set sanad_id=null where id=" + ID + ";";
			text += "delete from sanad where id=@sanad_id;";
			text = text + "delete from kharid_Sardkhane_darsad where id=" + ID + ";";
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00041520 File Offset: 0x0003F720
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT     Kharid_Sardkhane_Darsad.ID, Kharid_Sardkhane_Darsad.Moshtari_ID, Kharid_Sardkhane_Darsad.darsad, Kharid_Sardkhane_Darsad.Mablagh, Kharid_Sardkhane_Darsad.Sanad_ID,  Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name   FROM         Kharid_Sardkhane_Darsad INNER JOIN    Moshtari ON Kharid_Sardkhane_Darsad.Moshtari_ID = Moshtari.ID where Kharid_Sardkhane_ID=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00041548 File Offset: 0x0003F748
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
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Darsad(Kharid_ID,Moshtari_ID,Darsad) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Moshtari_ID"]), ","), Public_Function.GetValueInt(dataRow["Darsad"].ToString())), ");")));
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

		// Token: 0x0600030A RID: 778 RVA: 0x00041630 File Offset: 0x0003F830
		public void Update(int Kharid_Sardkhane_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;";
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Kharid_Sardkhane_Darsad Where Kharid_Sardkhane_ID=",
					Conversions.ToString(Kharid_Sardkhane_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Kharid_Sardkhane_Darsad Where Kharid_Sardkhane_ID=" + Conversions.ToString(Kharid_Sardkhane_ID) + ";";
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Kharid_Sardkhane_Darsad(Kharid_Sardkhane_ID,Moshtari_ID,Darsad) VALUES(" + Conversions.ToString(Kharid_Sardkhane_ID) + ",", dataRow["Moshtari_ID"]), ","), Public_Function.GetValueInt(dataRow["Darsad"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Kharid_Sardkhane_Darsad SET Darsad=" + Public_Function.GetValueInt(dataRow["Darsad"].ToString()) + " ,Moshtari_ID=", dataRow["Moshtari_ID"]), " Where ID="), dataRow["ID"]), ";")));
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

		// Token: 0x04000132 RID: 306
		private Sanad Isanad;

		// Token: 0x04000133 RID: 307
		private DaryaftPardakht Daryaft;
	}
}
