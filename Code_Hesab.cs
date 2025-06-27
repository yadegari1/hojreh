using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000B RID: 11
	public class Code_Hesab
	{
		// Token: 0x0600019E RID: 414 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Code_Hesab()
		{
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00013A00 File Offset: 0x00011C00
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Code_Hesab.ID,dbo.Code_Hesab.Grouh_ID,dbo.Code_Hesab.Name From dbo.Code_Hesab");
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00013A1C File Offset: 0x00011C1C
		public long Insert(Code_Hesab.GrohHesab Grouh_ID, string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Code_Hesab(Grouh_ID,Name) VALUES(",
				Conversions.ToString((int)Grouh_ID),
				",",
				Public_Function.GetValue(Name),
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00013A74 File Offset: 0x00011C74
		public string InsertStr(Code_Hesab.GrohHesab Grouh_ID, string Name)
		{
			return string.Concat(new string[]
			{
				"Insert Into dbo.Code_Hesab(Grouh_ID,Name) VALUES(",
				Conversions.ToString((int)Grouh_ID),
				",",
				Public_Function.GetValue(Name),
				" ); "
			});
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public string UpdateStr(string Name, string ID)
		{
			return "Update dbo.Code_Hesab SET  Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002140 File Offset: 0x00000340
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Code_Hesab SET  Name=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002160 File Offset: 0x00000360
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Code_Hesab Where Id= " + ID);
		}

		// Token: 0x0200000C RID: 12
		public enum GrohHesab
		{
			// Token: 0x040000BE RID: 190
			صندوق = 1,
			// Token: 0x040000BF RID: 191
			مشتریان,
			// Token: 0x040000C0 RID: 192
			حساب_بانکی,
			// Token: 0x040000C1 RID: 193
			در_جریان_وصول,
			// Token: 0x040000C2 RID: 194
			هزینه,
			// Token: 0x040000C3 RID: 195
			کرایه,
			// Token: 0x040000C4 RID: 196
			درآمد,
			// Token: 0x040000C5 RID: 197
			ح_دریافتنی,
			// Token: 0x040000C6 RID: 198
			جاری_شرکا
		}
	}
}
