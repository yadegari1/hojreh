using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000027 RID: 39
	public class ErsalBar_RizBar
	{
		// Token: 0x0600023B RID: 571 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public ErsalBar_RizBar()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0002ED2C File Offset: 0x0002CF2C
		public DataTable GetByID(int ErsalBar_ID)
		{
			return Public_Function.FillData("SELECT     ErsalBar_RizBar.*, Kala.Name AS Kala_Name   FROM         ErsalBar_RizBar INNER JOIN   Kala ON ErsalBar_RizBar.Kala_ID = Kala.ID   where ErsalBar_id=" + Conversions.ToString(ErsalBar_ID));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0002ED54 File Offset: 0x0002CF54
		public void Insert(int ErsalBar_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [ErsalBar_RizBar] ([ErsalBar_ID],[Kala_ID],[Tedad]) VALUES(" + ErsalBar_ID.ToString() + ",", dataRow["Kala_ID"]), ","), dataRow["Tedad"]), ")")));
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

		// Token: 0x0600023E RID: 574 RVA: 0x0002EE30 File Offset: 0x0002D030
		public void Update(int ErsalBar_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.ErsalBar_RizBar Where ErsalBar_ID=",
					Conversions.ToString(ErsalBar_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.ErsalBar_RizBar Where ErsalBar_ID=" + Conversions.ToString(ErsalBar_ID) + ";";
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
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.ErsalBar_RizBar(ErsalBar_ID,Kala_ID,Tedad,Vazn,auto) VALUES(" + Conversions.ToString(ErsalBar_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["auto"].ToString())), ");")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.ErsalBar_RizBar SET Kala_ID=", dataRow["Kala_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,auto="), Public_Function.GetValueInt(dataRow["auto"].ToString())), " Where ID="), dataRow["ID"]), ";")));
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
