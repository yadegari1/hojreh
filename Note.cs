using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200001B RID: 27
	public class Note
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Note()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00015048 File Offset: 0x00013248
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Note.ID,dbo.Note.Text From dbo.Note");
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00015064 File Offset: 0x00013264
		public long Insert(string Name)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("Insert Into dbo.Note(Text) VALUES(" + Public_Function.GetValue(Name) + " );Select Scope_Identity();"));
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000022C3 File Offset: 0x000004C3
		public void Update(string Name, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Note SET Text=" + Public_Function.GetValue(Name) + " Where ID=" + ID);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000022E3 File Offset: 0x000004E3
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Note Where Id= " + ID);
		}
	}
}
