using System;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000020 RID: 32
	public class Check_Status
	{
		// Token: 0x060001FD RID: 509 RVA: 0x00002357 File Offset: 0x00000557
		public Check_Status()
		{
			this.sanad = new Sanad();
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000155A8 File Offset: 0x000137A8
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Check_Status.ID,dbo.Check_Status.dp_id,dbo.Check_Status.Status_id,dbo.Check_Status.Tarikh,dbo.Check_Status.Tarikh_Fa,dbo.Check_Status.Sanadbed_ID,dbo.Check_Status.Sanadbes_ID From dbo.Check_Status");
		}

		// Token: 0x060001FF RID: 511 RVA: 0x000155C4 File Offset: 0x000137C4
		public long InsertJaryanVusul(string Bank_ID, string Mablagh, string dp_id, string Tarikh_Fa, string Tozih)
		{
			string text = "declare @sanadbed_id int,@sanadbes_id int;";
			text += this.sanad.InsertStr(Bank_ID, Mablagh, "0", Tarikh_Fa, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += this.sanad.InsertStr(Conversions.ToString(1), "0", Mablagh, Tarikh_Fa, Tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Check_Status(dp_id,Status_id,Tarikh,Tarikh_Fa,Sanadbed_ID,Sanadbes_ID) VALUES(",
				dp_id,
				",2,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",@sanadbed_id,@sanadbes_id );Select Scope_Identity();"
			});
			text = text + "Update DaryaftPardakht Set Check_Status=2 where id=" + dp_id;
			Public_Function.ExecuteNonQuery(text);
			long result;
			return result;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000156A0 File Offset: 0x000138A0
		public long InsertVusul(string Bank_ID, string Mablagh, string dp_id, string Tarikh_Fa, string tozih)
		{
			string text = "declare @sanadbed_id int,@sanadbes_id int;";
			text += this.sanad.InsertStr(Bank_ID, Mablagh, "0", Tarikh_Fa, tozih, Sanad.SanadType.@null);
			text += "select @sanadbed_id=scope_identity();";
			text += this.sanad.InsertStr(Bank_ID, "0", Mablagh, Tarikh_Fa, tozih, Sanad.SanadType.@null);
			text += "select @sanadbes_id=scope_identity();";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Check_Status(dp_id,Status_id,Tarikh,Tarikh_Fa,Sanadbed_ID,Sanadbes_ID) VALUES(",
				dp_id,
				",3,",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",@sanadbed_id,@sanadbes_id );Select Scope_Identity();"
			});
			text = text + "Update DaryaftPardakht Set Check_Status=3 where id=" + dp_id;
			Public_Function.ExecuteNonQuery(text);
			long result;
			return result;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00015774 File Offset: 0x00013974
		public void Update(string dp_id, string Status_id, string Tarikh_Fa, string Sanadbed_ID, string Sanadbes_ID, string ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"Update dbo.Check_Status SET dp_id=",
				dp_id,
				" ,Status_id=",
				Status_id,
				" ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh_Fa),
				" ,Sanadbed_ID=",
				Sanadbed_ID,
				" ,Sanadbes_ID=",
				Sanadbes_ID,
				" Where ID=",
				ID
			}));
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000236C File Offset: 0x0000056C
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Check_Status Where Id= " + ID);
		}

		// Token: 0x040000C8 RID: 200
		private Sanad sanad;
	}
}
