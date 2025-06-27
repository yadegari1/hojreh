using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000018 RID: 24
	public class Kala_To_Kala_Furush_Sardkhane
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Kala_To_Kala_Furush_Sardkhane()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001475C File Offset: 0x0001295C
		public void Insert(long Furush_ID, long Parent_Kala_ID, long Child_Kala_ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"insert into Furush_Sardkhane_kala_to_kala (Furush_Sardkhane_ID,Parent_kala_ID,Child_Kala_ID) values(",
				Conversions.ToString(Furush_ID),
				",",
				Conversions.ToString(Parent_Kala_ID),
				",",
				Conversions.ToString(Child_Kala_ID),
				")"
			}));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000147C0 File Offset: 0x000129C0
		public void Update(long Furush_ID, DataTable dt)
		{
			string iD = Public_Function.GetID(dt, "ID", "");
			string text = string.Empty;
			bool flag = iD.Length > 0;
			if (flag)
			{
				text = string.Concat(new string[]
				{
					text,
					"Delete From dbo.Furush_Sardkhane_kala_to_kala Where Furush_Sardkhane_ID=",
					Conversions.ToString(Furush_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text = text + "Delete From dbo.Furush_Sardkhane_kala_to_kala Where Furush_Sardkhane_ID=" + Conversions.ToString(Furush_ID) + ";";
			}
			flag = (dt != null);
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						bool flag2 = dataRow["ID"] == DBNull.Value;
						if (flag2)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into Furush_Sardkhane_kala_to_kala (Furush_Sardkhane_ID,Parent_kala_ID,Child_Kala_ID) values(" + Conversions.ToString(Furush_ID) + ",", dataRow["Parent_Kala_ID"]), ","), dataRow["Child_Kala_ID"]), ")")));
						}
						else
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Sardkhane_kala_to_kala SET Parent_kala_ID=", dataRow["Parent_Kala_ID"]), " ,Child_Kala_ID="), dataRow["Child_Kala_ID"].ToString()), " Where ID="), dataRow["ID"]), ";")));
						}
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
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000149B4 File Offset: 0x00012BB4
		public DataTable GetByFurush_ID(long ID)
		{
			return Public_Function.FillData("select * from Furush_Sardkhane_kala_to_kala where Furush_Sardkhane_ID=" + Conversions.ToString(ID));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000149DC File Offset: 0x00012BDC
		public DataTable GetParent_Kala_ID(long Child_Kala_ID)
		{
			return Public_Function.FillData("select Parent_Kala_ID from Furush_Sardkhane_kala_to_kala where child_kala_id=" + Conversions.ToString(Child_Kala_ID));
		}
	}
}
