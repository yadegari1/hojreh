using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000F RID: 15
	public class Frm_Size
	{
		// Token: 0x060001AF RID: 431 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Frm_Size()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00013D14 File Offset: 0x00011F14
		public DataTable GetAll()
		{
			return Public_Function.FillData("select * from Frm_Size");
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00013D30 File Offset: 0x00011F30
		public void Update(string Name, Point loc, Size Size)
		{
			bool flag = Operators.CompareString(Name, string.Empty, false) == 0;
			if (!flag)
			{
				string command = string.Concat(new string[]
				{
					"declare @id int;select @id=id from frm_size where name=",
					Public_Function.GetValue(Name),
					";if @id is null insert into frm_size(name,[top],[left],width,height) values(",
					Public_Function.GetValue(Name),
					",",
					Conversions.ToString(loc.Y),
					",",
					Conversions.ToString(loc.X),
					",",
					Conversions.ToString(Size.Width),
					" ,",
					Conversions.ToString(Size.Height),
					") update frm_size set [top]=",
					Conversions.ToString(loc.Y),
					",[left]=",
					Conversions.ToString(loc.X),
					",width=",
					Conversions.ToString(Size.Width),
					",height=",
					Conversions.ToString(Size.Height),
					" where name=",
					Public_Function.GetValue(Name)
				});
				Public_Function.ExecuteNonQuery(command);
			}
		}
	}
}
