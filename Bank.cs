using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000008 RID: 8
	public class Bank
	{
		// Token: 0x06000189 RID: 393 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Bank()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00012E34 File Offset: 0x00011034
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Bank.ID,dbo.Bank.Name From dbo.Bank");
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00012E50 File Offset: 0x00011050
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Bank(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000020CB File Offset: 0x000002CB
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Bank SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000020EB File Offset: 0x000002EB
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Bank Where Id= " + ID);
		}
	}
}
