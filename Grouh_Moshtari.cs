using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000011 RID: 17
	public class Grouh_Moshtari
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Grouh_Moshtari()
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00014038 File Offset: 0x00012238
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Grouh_Moshtari.ID,dbo.Grouh_Moshtari.Name From dbo.Grouh_Moshtari");
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00014054 File Offset: 0x00012254
		public DataRow GetByID(string id)
		{
			return Public_Function.FillDataRow("select * from grouh_moshtari where id=" + id);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00014078 File Offset: 0x00012278
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Grouh_Moshtari(Name) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000021C5 File Offset: 0x000003C5
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Grouh_Moshtari SET Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000021E5 File Offset: 0x000003E5
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Grouh_Moshtari Where Id= " + ID);
		}
	}
}
