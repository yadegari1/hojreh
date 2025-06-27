using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000030 RID: 48
	public class Furush_Sardkhane_RizBar
	{
		// Token: 0x060002CA RID: 714 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Furush_Sardkhane_RizBar()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0003A3F4 File Offset: 0x000385F4
		public DataTable GetByID(int Kharid_ID)
		{
			return Public_Function.FillData("SELECT     Furush_Sardkhane_RizBar.*, Kala.Name AS Kala_Name   FROM         Furush_Sardkhane_RizBar INNER JOIN   Kala ON Furush_Sardkhane_RizBar.Kala_ID = Kala.ID   where furush_Sardkhane_id=" + Conversions.ToString(Kharid_ID));
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0003A41C File Offset: 0x0003861C
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
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [Furush_Sardkhane_RizBar] ([Furush_Sardkhane_ID],[Kala_ID],[Tedad]) VALUES(" + Kharid_ID.ToString() + ",", dataRow["Kala_ID"]), ","), dataRow["Tedad"]), ")")));
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

		// Token: 0x060002CD RID: 717 RVA: 0x0003A4F8 File Offset: 0x000386F8
		public void Update(int Kharid_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Sardkhane_RizBar Where Furush_Sardkhane_ID=",
					Conversions.ToString(Kharid_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Sardkhane_RizBar Where Furush_Sardkhane_ID=" + Conversions.ToString(Kharid_ID) + ";";
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Sardkhane_RizBar(Furush_Sardkhane_ID,Kala_ID,Tedad,Vazn,auto) VALUES(" + Conversions.ToString(Kharid_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["auto"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Sardkhane_RizBar SET Kala_ID=", dataRow["Kala_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,auto="), Public_Function.GetValueInt(dataRow["auto"].ToString())), " Where ID="), dataRow["ID"]), ";")));
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
	}
}
