using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000010 RID: 16
	public class Grid_Size
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Grid_Size()
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00013E7C File Offset: 0x0001207C
		public DataTable GetByName(string frm_Name, string Grid)
		{
			return Public_Function.FillData("SELECT        Frm_Size.Name, Grid_Size.Grid, Grid_Size.[Key], Grid_Size.Width  FROM            Frm_Size INNER JOIN  Grid_Size ON Frm_Size.ID = Grid_Size.Frm_ID where Name=" + Public_Function.GetValue(frm_Name) + " AND Grid=" + Public_Function.GetValue(Grid));
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00013EB0 File Offset: 0x000120B0
		public void Update(string Frm_Name, string Grid, GridEXColumnCollection Columns)
		{
			bool flag = Operators.CompareString(Frm_Name, string.Empty, false) == 0;
			if (!flag)
			{
				string text = "declare @cnt int;declare @id int;select @id=id from frm_size where name=" + Public_Function.GetValue(Frm_Name) + ";";
				text = text + "if @id is null begin insert into frm_size(name,[top],[left],width,height) values(" + Public_Function.GetValue(Frm_Name) + ",20,20,150,150);select @id=scope_identity(); END ;";
				try
				{
					IEnumerator enumerator = Columns.GetEnumerator();
					while (enumerator.MoveNext())
					{
						GridEXColumn gridEXColumn = (GridEXColumn)enumerator.Current;
						text = string.Concat(new string[]
						{
							text,
							"select @cnt=id from Grid_Size where Frm_ID=@id AND Grid=",
							Public_Function.GetValue(Grid),
							" AND [key]=",
							Public_Function.GetValue(gridEXColumn.Key),
							";"
						});
						text = string.Concat(new string[]
						{
							text,
							"if @cnt is null  insert into grid_size (Frm_ID,Grid,[key],width) Values(@id,",
							Public_Function.GetValue(Grid),
							",",
							Public_Function.GetValue(gridEXColumn.Key),
							",",
							Conversions.ToString(gridEXColumn.Width),
							") else "
						});
						text = text + " update grid_size set width=" + Conversions.ToString(gridEXColumn.Width) + " where id=@cnt;";
						text += " set @cnt=null;";
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
				Public_Function.ExecuteNonQuery(text);
			}
		}
	}
}
