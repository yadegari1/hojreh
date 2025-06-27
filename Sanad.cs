using System;
using System.Data;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000047 RID: 71
	public class Sanad
	{
		// Token: 0x0600035A RID: 858 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Sanad()
		{
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00047C8C File Offset: 0x00045E8C
		public DataTable GetAll()
		{
			return Public_Function.FillData("Select dbo.Sanad.ID,dbo.Sanad.Moshtari_ID,dbo.Sanad.Bed,dbo.Sanad.Bes,dbo.Sanad.Tarikh,dbo.Sanad.Tarikh_Fa From dbo.Sanad");
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00047CA8 File Offset: 0x00045EA8
		public long Insert(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			return Conversions.ToLong(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"Insert Into dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype) VALUES(",
				CodeHesab_ID,
				",",
				Bed,
				",",
				Bes,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValueInt(s),
				" );Select Scope_Identity();"
			})));
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00047D80 File Offset: 0x00045F80
		public string InsertStr(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			return string.Concat(new string[]
			{
				"Insert Into dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype) VALUES(",
				CodeHesab_ID,
				",",
				Bed,
				",",
				Bes,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValueInt(s),
				" );"
			});
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00047E50 File Offset: 0x00046050
		public string InsertStrArzi(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			return string.Concat(new string[]
			{
				"Insert Into dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype,arztype) VALUES(",
				CodeHesab_ID,
				",",
				Bed,
				",",
				Bes,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValueInt(s),
				",1 );"
			});
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00047F20 File Offset: 0x00046120
		public string InsertStr(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, string ReturnID, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			string empty = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			string text = string.Concat(new string[]
			{
				"Insert Into dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype) VALUES(",
				CodeHesab_ID,
				",",
				Bed,
				",",
				Bes,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValueInt(s),
				" );"
			});
			flag = (Operators.CompareString(ReturnID, string.Empty, false) != 0);
			if (flag)
			{
				text = text + "select " + ReturnID + "=Scope_Identity();";
			}
			return text;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00048038 File Offset: 0x00046238
		public string InsertStr(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, string ReturnID, string dbname, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			string text = string.Concat(new string[]
			{
				"Insert Into ",
				dbname,
				".dbo.Sanad(CodeHesab_ID,Bed,Bes,Tarikh,Tarikh_Fa,Tozih,sanadtype) VALUES(",
				CodeHesab_ID,
				",",
				Bed,
				",",
				Bes,
				",",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				",",
				Public_Function.GetValue(Tarikh_Fa),
				",",
				Public_Function.GetValue(Tozih),
				",",
				Public_Function.GetValueInt(s),
				" );"
			});
			flag = (Operators.CompareString(ReturnID, string.Empty, false) != 0);
			if (flag)
			{
				text = text + "select " + ReturnID + "=Scope_Identity();";
			}
			return text;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00048148 File Offset: 0x00046348
		public void Update(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, string ID, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"Update dbo.Sanad SET Bed=",
				Bed,
				" ,Bes=",
				Bes,
				" ,CodeHesab_ID=",
				Public_Function.GetValueInt(CodeHesab_ID),
				" ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh_Fa),
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,sanadtype=",
				Public_Function.GetValueInt(s),
				" Where ID=",
				ID
			}));
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00048228 File Offset: 0x00046428
		public string UpdateStr(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, string ID, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			string empty = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			return string.Concat(new string[]
			{
				"Update dbo.Sanad SET Bed=",
				Bed,
				" ,Bes=",
				Bes,
				" ,CodeHesab_ID=",
				Public_Function.GetValueInt(CodeHesab_ID),
				" ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh_Fa),
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,sanadtype=",
				Public_Function.GetValueInt(s),
				" Where ID=",
				ID,
				";"
			});
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00048314 File Offset: 0x00046514
		public string UpdateStrArzi(string CodeHesab_ID, string Bed, string Bes, string Tarikh_Fa, string Tozih, string ID, Sanad.SanadType Sanadtype = Sanad.SanadType.@null)
		{
			string s = string.Empty;
			string empty = string.Empty;
			bool flag = Sanadtype == Sanad.SanadType.@null;
			if (flag)
			{
				s = "NULL";
			}
			else
			{
				s = Conversions.ToString((int)Sanadtype);
			}
			return string.Concat(new string[]
			{
				"Update dbo.Sanad SET Bed=",
				Bed,
				" ,Bes=",
				Bes,
				" ,CodeHesab_ID=",
				Public_Function.GetValueInt(CodeHesab_ID),
				" ,Tarikh=",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh_Fa)),
				" ,Tarikh_Fa=",
				Public_Function.GetValue(Tarikh_Fa),
				" ,Tozih=",
				Public_Function.GetValue(Tozih),
				" ,sanadtype=",
				Public_Function.GetValueInt(s),
				" ,arztype=1 Where ID=",
				ID,
				";"
			});
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002801 File Offset: 0x00000A01
		public void Delete(string ID)
		{
			Public_Function.ExecuteNonQuery("Delete From dbo.Sanad Where Id= " + ID);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00048400 File Offset: 0x00046600
		public string DeleteStr(string ID)
		{
			return "Delete From dbo.Sanad Where Id= " + ID;
		}

		// Token: 0x02000048 RID: 72
		public enum SanadType
		{
			// Token: 0x04000157 RID: 343
			@null = -1,
			// Token: 0x04000158 RID: 344
			دریافت_و_پرداخت = 1,
			// Token: 0x04000159 RID: 345
			فروش_حق_العمل,
			// Token: 0x0400015A RID: 346
			فروش_خرید,
			// Token: 0x0400015B RID: 347
			صافی_فروش,
			// Token: 0x0400015C RID: 348
			خرید_ریزبار_به_صاحب_بار,
			// Token: 0x0400015D RID: 349
			خرید_به_سردخانه_ریزبار_صاحب_بار,
			// Token: 0x0400015E RID: 350
			فروش_از_سردخانه_به_مشتری,
			// Token: 0x0400015F RID: 351
			خرید_ارسال_بار_از_مشتری_,
			// Token: 0x04000160 RID: 352
			ارسال_بار_گیرنده_بار,
			// Token: 0x04000161 RID: 353
			خرید_مغازه_خرده_فروشی,
			// Token: 0x04000162 RID: 354
			صادرات_گیرنده_بار,
			// Token: 0x04000163 RID: 355
			صادرات_خرید_از_مشتری,
			// Token: 0x04000164 RID: 356
			کسر_صندوق = 98,
			// Token: 0x04000165 RID: 357
			اضافی_صندوق
		}
	}
}
