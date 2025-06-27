using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200000A RID: 10
	public class Moshtari
	{
		// Token: 0x06000196 RID: 406 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Moshtari()
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00013478 File Offset: 0x00011678
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Moshtari.ID,dbo.Moshtari.AvalDoreType,dbo.Moshtari.AvalDore,dbo.Moshtari.Sanad_ID,dbo.Moshtari.Name+' '+dbo.Moshtari.Family AS Name,dbo.Moshtari.shsh,dbo.Moshtari.CodeMelli,dbo.Moshtari.CodePosti,dbo.Moshtari.Tel1,dbo.Moshtari.Tel2,dbo.Moshtari.Tel3,dbo.Moshtari.Tel4,dbo.Moshtari.Address,dbo.Moshtari.Address2,dbo.Moshtari.Fax,dbo.Moshtari.CodeEgtesadi,dbo.Moshtari.Moaref,dbo.Moshtari.AvalDore_Tarikh  From dbo.Moshtari where id>0");
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00013494 File Offset: 0x00011694
		public long GetNewID()
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(Code),0)+1 from dbo.Moshtari where id<>-1"));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000134B8 File Offset: 0x000116B8
		public DataRow GetByID(string ID)
		{
			return Public_Function.FillDataRow("SELECT     Moshtari.ID, Moshtari.AvalDoreType, Moshtari.AvalDore, Moshtari.Sanad_ID, Moshtari.CodeHesab_ID, Moshtari.GrouhMoshtari_ID, Moshtari.GrouhMoshtari2_ID,   Moshtari.Name, Moshtari.Family, Moshtari.shsh, Moshtari.CodeMelli, Moshtari.CodePosti, Moshtari.Tel1, Moshtari.Tel2, Moshtari.Tel3, Moshtari.Tel4,   Moshtari.Address, Moshtari.Address2, Moshtari.Fax, Moshtari.CodeEgtesadi, Moshtari.Moaref, Moshtari.AvalDore_Tarikh,   Grouh_Moshtari.Name AS GrouhMoshtari_Name, Grouh_Moshtari2.Name AS GrouhMoshtari2_Name, Moshtari.kind,Moshtari.moaref_kind,   Moshtari_Kind.Name AS Moshtari_kind_name,karmozd     FROM         Moshtari INNER JOIN   Moshtari_Kind ON Moshtari.kind = Moshtari_Kind.ID LEFT OUTER JOIN   Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN   Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID  where dbo.Moshtari.ID=" + ID);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000134DC File Offset: 0x000116DC
		public long Insert(string AvalDoreType, string AvalDore, string Sanad_ID, string CodeHesab_ID, string GrouhMoshtari_ID, string GrouhMoshtari2_ID, string Name, string Family, string shsh, string CodeMelli, string CodePosti, string Tel1, string Tel2, string Tel3, string Tel4, string Address, string Address2, string Fax, string CodeEgtesadi, string Moaref, string AvalDore_Tarikh, string kind, string moaref_kind, string karmozd, string Code)
		{
			string text = "set identity_insert Moshtari on;";
			text = string.Concat(new string[]
			{
				text,
				"Insert Into dbo.Moshtari(ID,AvalDoreType,AvalDore,Sanad_ID,CodeHesab_ID,GrouhMoshtari_ID,GrouhMoshtari2_ID,Name,Family,shsh,CodeMelli,CodePosti,Tel1,Tel2,Tel3,Tel4,Address,Address2,Fax,CodeEgtesadi,Moaref,AvalDore_Tarikh,kind,moaref_kind,karmozd) VALUES(",
				Code,
				",",
				Public_Function.GetValueInt(AvalDoreType),
				",",
				Public_Function.GetValueInt(AvalDore),
				",",
				Public_Function.GetValueInt(Sanad_ID),
				",",
				CodeHesab_ID,
				",",
				Public_Function.GetValueInt(GrouhMoshtari_ID),
				",",
				Public_Function.GetValueInt(GrouhMoshtari2_ID),
				",",
				Public_Function.GetValue(Name),
				",",
				Public_Function.GetValue(Family),
				",",
				Public_Function.GetValue(shsh),
				",",
				Public_Function.GetValue(CodeMelli),
				",",
				Public_Function.GetValue(CodePosti),
				",",
				Public_Function.GetValue(Tel1),
				",",
				Public_Function.GetValue(Tel2),
				",",
				Public_Function.GetValue(Tel3),
				",",
				Public_Function.GetValue(Tel4),
				",",
				Public_Function.GetValue(Address),
				",",
				Public_Function.GetValue(Address2),
				",",
				Public_Function.GetValue(Fax),
				",",
				Public_Function.GetValue(CodeEgtesadi),
				",",
				Public_Function.GetValue(Moaref),
				",",
				Public_Function.GetValue(AvalDore_Tarikh),
				",",
				Public_Function.GetValueInt(kind),
				",",
				Public_Function.GetValueInt(moaref_kind),
				",",
				Public_Function.GetValueInt(karmozd),
				" );"
			});
			text += "set identity_insert Moshtari off;";
			text += "Select Scope_Identity();";
			return Conversions.ToLong(Public_Function.ExecuteScalar(text));
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00013748 File Offset: 0x00011948
		public void Update(string AvalDoreType, string AvalDore, string Sanad_ID, string GrouhMoshtari_ID, string GrouhMoshtari2_ID, string Name, string Family, string shsh, string CodeMelli, string CodePosti, string Tel1, string Tel2, string Tel3, string Tel4, string Address, string Address2, string Fax, string CodeEgtesadi, string Moaref, string AvalDore_Tarikh, string kind, string moaref_kind, string karmozd, string ID)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"Update dbo.Moshtari SET  AvalDoreType=",
				Public_Function.GetValueInt(AvalDoreType),
				" ,AvalDore=",
				Public_Function.GetValueInt(AvalDore),
				" ,Sanad_ID=",
				Public_Function.GetValueInt(Sanad_ID),
				" ,GrouhMoshtari_ID=",
				Public_Function.GetValueInt(GrouhMoshtari_ID),
				" ,GrouhMoshtari2_ID=",
				Public_Function.GetValueInt(GrouhMoshtari2_ID),
				" ,Name=",
				Public_Function.GetValue(Name),
				" ,Family=",
				Public_Function.GetValue(Family),
				" ,shsh=",
				Public_Function.GetValue(shsh),
				" ,CodeMelli=",
				Public_Function.GetValue(CodeMelli),
				" ,CodePosti=",
				Public_Function.GetValue(CodePosti),
				" ,Tel1=",
				Public_Function.GetValue(Tel1),
				" ,Tel2=",
				Public_Function.GetValue(Tel2),
				" ,Tel3=",
				Public_Function.GetValue(Tel3),
				" ,Tel4=",
				Public_Function.GetValue(Tel4),
				" ,Address=",
				Public_Function.GetValue(Address),
				" ,Address2=",
				Public_Function.GetValue(Address2),
				" ,Fax=",
				Public_Function.GetValue(Fax),
				" ,CodeEgtesadi=",
				Public_Function.GetValue(CodeEgtesadi),
				" ,Moaref=",
				Public_Function.GetValue(Moaref),
				" ,AvalDore_Tarikh=",
				Public_Function.GetValue(AvalDore_Tarikh),
				" ,kind=",
				Public_Function.GetValueInt(kind),
				" ,moaref_kind=",
				Public_Function.GetValueInt(moaref_kind),
				" ,karmozd=",
				Public_Function.GetValueInt(karmozd),
				" Where ID=",
				ID
			}));
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002120 File Offset: 0x00000320
		public void UpdateSanad_ID(string Sanad_ID, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Moshtari SET Sanad_ID=" + Public_Function.GetValueInt(Sanad_ID) + " Where ID=" + ID);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001396C File Offset: 0x00011B6C
		public bool Delete(string ID)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("SELECT        COUNT(Sanad.ID)  FROM            Moshtari INNER JOIN  Code_Hesab ON Moshtari.CodeHesab_ID = Code_Hesab.ID INNER JOIN  Sanad ON Code_Hesab.ID = Sanad.CodeHesab_ID where Moshtari.ID=" + ID));
			bool flag = num > 0;
			bool result;
			if (flag)
			{
				Public_Function.ShowMessage("مشتری مورد نظر دارای گردش مالی میباشد" + Environment.NewLine + "امکان حذف مشتری وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				result = false;
			}
			else
			{
				flag = Public_Function.ExecuteNonQuery("Delete From dbo.Moshtari Where Id= " + ID);
				if (flag)
				{
					result = true;
				}
				else
				{
					Public_Function.ShowMessage("مشتری مورد نظر دارای گردش مالی میباشد" + Environment.NewLine + "امکان حذف مشتری وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
				}
			}
			return result;
		}
	}
}
