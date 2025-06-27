using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000009 RID: 9
	public class Bank_Hesab
	{
		// Token: 0x0600018E RID: 398 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Bank_Hesab()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00012E84 File Offset: 0x00011084
		public void UpdatePicData(byte[] Picdata, string ID)
		{
			SqlCommand sqlCommand = Public_Function.CreateSqlCommand("Update dbo.bank_hesab SET  signpic = @PicData  Where ID=" + ID);
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.Parameters.Add("@PicData", SqlDbType.Image);
			sqlCommand.Parameters[0].IsNullable = true;
			bool flag = Picdata != null;
			if (flag)
			{
				sqlCommand.Parameters[0].Value = Picdata;
			}
			else
			{
				sqlCommand.Parameters[0].Value = DBNull.Value;
			}
			sqlCommand.ExecuteNonQuery();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00012F14 File Offset: 0x00011114
		public DataRow GetByID(string ID)
		{
			return Public_Function.FillDataRow("SELECT     Bank_Hesab.ID, Bank_Hesab.Bank_ID,Bank_Hesab.Shobe,  Bank_Hesab.Sh_Hesab, Bank_Hesab.Sh_card, Bank_Hesab.Sh_Shaba, Bank_Hesab.AvalDore,Bank_Hesab.tel,Bank_Hesab.address,Bank_Hesab.sahebhesab,   Bank_Hesab.AvalDore_Tarikh, Bank_Hesab.Sanad_ID, Bank.Name AS Bank_Name,CodeHesab_Mojodi,CodeHesab_Vusul,Bank_Hesab.kartkhan,NamePedar,CodeMelli,shsh,sadere,codeposti,signpic,visible     FROM         Bank_Hesab INNER JOIN     Bank ON Bank_Hesab.Bank_ID = Bank.ID  where Bank_Hesab.id=" + ID);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00012F38 File Offset: 0x00011138
		public DataTable GetAll()
		{
			return Public_Function.FillData("SELECT     Bank_Hesab.ID, Bank_Hesab.Bank_ID,Bank_Hesab.Shobe, Bank_Hesab.Sh_Hesab, Bank_Hesab.Sh_card, Bank_Hesab.Sh_Shaba, Bank_Hesab.AvalDore,   Bank_Hesab.AvalDore_Tarikh, Bank_Hesab.Sanad_ID, Bank.Name AS Bank_Name, Bank_Hesab.Shobe      FROM         Bank_Hesab INNER JOIN     Bank ON Bank_Hesab.Bank_ID = Bank.ID");
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00012F54 File Offset: 0x00011154
		public long Insert(string Bank_ID, string Shobe, string Sh_Hesab, string Sh_card, string Sh_Shaba, string AvalDore, string AvalDore_Tarikh, string CodeHesab_Mojodi, string CodeHesab_Vusul, string kartkhan, string SahebHesab, string Address, string Tel, string NamePedar, string CodeMelli, string shsh, string sadere, string codeposti)
		{
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Bank_Hesab(Bank_ID,Shobe,Sh_Hesab,Sh_card,Sh_Shaba,AvalDore,AvalDore_Tarikh,CodeHesab_Mojodi,CodeHesab_Vusul,KartKhan,SahebHesab,Address,Tel,namepedar,codemelli,shsh,sadere,codeposti) VALUES(",
				Bank_ID,
				",",
				Public_Function.GetValue(Shobe),
				",",
				Public_Function.GetValue(Sh_Hesab),
				",",
				Public_Function.GetValue(Sh_card),
				",",
				Public_Function.GetValue(Sh_Shaba),
				",",
				Public_Function.GetValueInt(AvalDore),
				",",
				Public_Function.GetValue(AvalDore_Tarikh),
				",",
				CodeHesab_Mojodi,
				",",
				CodeHesab_Vusul,
				",",
				Public_Function.GetValueInt(kartkhan),
				",",
				Public_Function.GetValue(SahebHesab),
				",",
				Public_Function.GetValue(Address),
				",",
				Public_Function.GetValue(Tel),
				",",
				Public_Function.GetValue(NamePedar),
				",",
				Public_Function.GetValue(CodeMelli),
				",",
				Public_Function.GetValue(shsh),
				",",
				Public_Function.GetValue(sadere),
				",",
				Public_Function.GetValue(codeposti),
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002100 File Offset: 0x00000300
		public void Update_SanadID(string Sanad_ID, string ID)
		{
			Public_Function.ExecuteNonQuery("Update dbo.Bank_Hesab SET Sanad_ID=" + Public_Function.GetValueInt(Sanad_ID) + " Where ID=" + ID);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x000130FC File Offset: 0x000112FC
		public void Update(string Bank_ID, string Shobe, string Sh_Hesab, string Sh_card, string Sh_Shaba, string AvalDore, string AvalDore_Tarikh, string kartkhan, string ID, string SahebHesab, string Address, string Tel, string NamePedar, string CodeMelli, string shsh, string sadere, string codeposti, string visible)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"Update dbo.Bank_Hesab SET Bank_ID=",
				Bank_ID,
				" ,Shobe=",
				Public_Function.GetValue(Shobe),
				" ,Sh_Hesab=",
				Public_Function.GetValue(Sh_Hesab),
				" ,Sh_card=",
				Public_Function.GetValue(Sh_card),
				" ,Sh_Shaba=",
				Public_Function.GetValue(Sh_Shaba),
				" ,AvalDore=",
				Public_Function.GetValueInt(AvalDore),
				" ,AvalDore_Tarikh=",
				Public_Function.GetValue(AvalDore_Tarikh),
				" ,kartkhan=",
				Public_Function.GetValueInt(kartkhan),
				" ,sahebhesab=",
				Public_Function.GetValue(SahebHesab),
				" ,address=",
				Public_Function.GetValue(Address),
				" ,Tel=",
				Public_Function.GetValue(Tel),
				" ,NamePedar=",
				Public_Function.GetValue(NamePedar),
				" ,CodeMelli=",
				Public_Function.GetValue(CodeMelli),
				" ,shsh=",
				Public_Function.GetValue(shsh),
				" ,sadere=",
				Public_Function.GetValue(sadere),
				" ,codeposti=",
				Public_Function.GetValue(codeposti),
				" ,visible=",
				visible,
				" Where ID=",
				ID
			}));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00013290 File Offset: 0x00011490
		public bool Delete(string ID)
		{
			bool flag = Operators.ConditionalCompareObjectGreater(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"SELECT        COUNT(Sanad.ID)   FROM            Code_Hesab INNER JOIN  Sanad ON Code_Hesab.ID = Sanad.CodeHesab_ID INNER JOIN  Bank_Hesab ON Code_Hesab.ID = Bank_Hesab.CodeHesab_Mojodi AND Code_Hesab.ID = Bank_Hesab.CodeHesab_Vusul where Bank_Hesab.ID=",
				ID,
				"AND Sanad.ID not in (select sanad_id from bank_Hesab where id=",
				ID,
				")"
			})), 0, false);
			bool result;
			if (flag)
			{
				Public_Function.ShowMessage("حساب بانکی مورد نظر دارای گردش مالی میباشد  " + Environment.NewLine + "امکان حذف حساب بانکی وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				result = false;
			}
			else
			{
				string text = string.Empty;
				object objectValue = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select sanad_id from bank_hesab where id=" + ID));
				flag = (objectValue != DBNull.Value);
				if (flag)
				{
					text += "update bank_hesab set sanad_id=null;";
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id =", objectValue), ";")));
				}
				object objectValue2 = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select Codehesab_Mojodi from Bank_Hesab where id=" + ID));
				object objectValue3 = RuntimeHelpers.GetObjectValue(Public_Function.ExecuteScalar("select codehesab_vusul from bank_Hesab where id=" + ID));
				text = text + "update Bank_Hesab set Codehesab_Mojodi=null where id=" + ID + ";";
				text = text + "update bank_Hesab set codehesab_vusul=null where id=" + ID + ";";
				flag = (objectValue2 != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from Code_Hesab where id=", objectValue2), ";")));
				}
				flag = (objectValue3 != DBNull.Value);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from code_hesab where id=", objectValue3), ";")));
				}
				text = text + "delete from bank_hesab where id=" + ID;
				flag = !Public_Function.ExecuteNonQuery(text);
				if (flag)
				{
					Public_Function.ShowMessage("حساب بانکی مورد نظر دارای گردش مالی میباشد  " + Environment.NewLine + "امکان حذف حساب بانکی وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}
	}
}
