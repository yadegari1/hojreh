using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200001E RID: 30
	public class Sarbarg
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Sarbarg()
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00015300 File Offset: 0x00013500
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select * From dbo.sarbarg");
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001531C File Offset: 0x0001351C
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.sarbarg(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002322 File Offset: 0x00000522
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.sarbarg SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002342 File Offset: 0x00000542
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.sarbarg Where Id= " + ID);
		}
	}
}
