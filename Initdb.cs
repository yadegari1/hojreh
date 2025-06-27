using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000089 RID: 137
	public class Initdb
	{
		// Token: 0x06000C03 RID: 3075 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public Initdb()
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00095C4C File Offset: 0x00093E4C
		private void AlterColumn(string TableName, string FieldName, string DataType)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"Alter Table ",
				TableName,
				" Alter Column ",
				FieldName,
				" ",
				DataType
			}));
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00095C98 File Offset: 0x00093E98
		private void AddColumn(string TableName, string FieldName, string DataType)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
				Public_Function.GetValue(TableName),
				" AND column_name= ",
				Public_Function.GetValue(FieldName),
				") ALTER TABLE ",
				TableName,
				" ADD ",
				FieldName,
				" ",
				DataType
			}));
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00095D0C File Offset: 0x00093F0C
		private void DeleteColumn(string TableName, string FieldName)
		{
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"IF EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
				Public_Function.GetValue(TableName),
				" AND column_name= ",
				Public_Function.GetValue(FieldName),
				") ALTER TABLE ",
				TableName,
				" DROP COLUMN ",
				FieldName
			}));
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00095D70 File Offset: 0x00093F70
		private void InsertKharid_Sanad()
		{
			try
			{
				Public_Function.ExecuteNonQuery(string.Concat(new string[]
				{
					"IF EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
					Public_Function.GetValue("kharid"),
					" AND column_name= ",
					Public_Function.GetValue("moshtari_sanad_id"),
					") delete from sanad where id in(select moshtari_sanad_id from kharid where moshtari_sanad_id is not null)"
				}));
			}
			catch (Exception expr_55)
			{
				ProjectData.SetProjectError(expr_55);
				ProjectData.ClearProjectError();
			}
			this.DeleteColumn("kharid", "moshtari_sanad_id");
			DataTable dataTable = Public_Function.FillData("SELECT     Kharid_Detail.ID, Kharid_Detail.Jam_Kol, Moshtari.CodeHesab_ID, Kala.Name AS Kala_Name, Kharid.Num,Kharid.Tarikh_Vurud  FROM         Kharid_Detail INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID INNER JOIN  Moshtari ON Kharid.Moshtari_ID = Moshtari.ID INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID  where kharid_detail.sanad_id is null");
			string text = "declare @id bigint;";
			Sanad sanad = new Sanad();
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text += sanad.InsertStr(Conversions.ToString(dataRow["codehesab_id"]), Conversions.ToString(0), Conversions.ToString(dataRow["jam_kol"]), Conversions.ToString(dataRow["Tarikh_vurud"]), Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("خرید شماره ", dataRow["num"]), " - "), dataRow["kala_name"])), Sanad.SanadType.@null);
					text += "select @id=scope_identity();";
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update kharid_detail set sanad_id=@id where id=", dataRow["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00095F3C File Offset: 0x0009413C
		private void UpdateCheckSanadCode()
		{
			string command = string.Empty;
			command = "update sanad set codehesab_id=33 where id in (select sanadbed_id from daryaftpardakht where dptype_id=2)";
			Public_Function.ExecuteNonQuery(command);
			command = "update sanad set codehesab_id=33 where id in (select sanadbes_id from daryaftpardakht where dptype_id in (12,18,26))";
			Public_Function.ExecuteNonQuery(command);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x00095F6C File Offset: 0x0009416C
		private void InsertSandugh_Sanad()
		{
			string text = "declare @sanad_id int;";
			Sanad sanad = new Sanad();
			string text2 = string.Empty;
			DataTable dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh,sh_check from daryaftpardakht where dptype_id=26 and sanadbed_id is null");
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text2 = Conversions.ToString(Operators.ConcatenateObject("نقد کردن چک به شماره ", dataRow["sh_check"]));
					text += sanad.InsertStr("1", dataRow["mablagh"].ToString(), "0", dataRow["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbed_id=@sanad_id where id= ", dataRow["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			flag = (text.Length > 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh,sh_check from daryaftpardakht where dptype_id=26 and sanadbes_id is null");
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					text2 = Conversions.ToString(Operators.ConcatenateObject("نقد کردن چک به شماره ", dataRow2["sh_check"]));
					text += sanad.InsertStr("33", "0", dataRow2["mablagh"].ToString(), dataRow2["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=@sanad_id where id= ", dataRow2["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag = (enumerator2 is IDisposable);
				if (flag)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			flag = (text.Length > 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			text = "declare @sanad_id int;";
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh,tozih from daryaftpardakht where dptype_id=28 and moshtari_id=-1 and sanadbed_id is null");
			bool flag2;
			try
			{
				IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					text2 = "فروش بار روی زمین ";
					flag = (dataRow3["tozih"] != DBNull.Value);
					if (flag)
					{
						string[] array = dataRow3["tozih"].ToString().Split(new char[]
						{
							'-'
						});
						flag = (Operators.CompareString(array[0], string.Empty, false) != 0);
						if (flag)
						{
							text2 = text2 + "/" + array[0];
						}
						flag = (array.Length == 2);
						if (flag)
						{
							flag2 = (Operators.CompareString(array[1], string.Empty, false) != 0);
							if (flag2)
							{
								text2 = text2 + " / تعداد " + array[1];
							}
							flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
							if (flag2)
							{
								text2 = text2 + " / خالص " + array[2];
							}
						}
					}
					text += sanad.InsertStr("1", dataRow3["mablagh"].ToString(), "0", dataRow3["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbed_id=@sanad_id where id= ", dataRow3["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator3;
				flag2 = (enumerator3 is IDisposable);
				if (flag2)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			text = "declare @sanad_id int;";
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh,Tozih from daryaftpardakht where dptype_id=27 and sanadbes_id is null");
			try
			{
				IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
				while (enumerator4.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator4.Current;
					text2 = "دریافت از کارتخوان ";
					flag2 = (dataRow4["tozih"] != DBNull.Value);
					if (flag2)
					{
						text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(" - ", dataRow4["tozih"])));
					}
					text += sanad.InsertStr("1", "0", dataRow4["mablagh"].ToString(), dataRow4["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=@sanad_id where id= ", dataRow4["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator4;
				flag2 = (enumerator4 is IDisposable);
				if (flag2)
				{
					(enumerator4 as IDisposable).Dispose();
				}
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			text = "declare @sanad_id int;";
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh from daryaftpardakht where dptype_id=5 and sanadbed_id is null");
			try
			{
				IEnumerator enumerator5 = dataTable.Rows.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					DataRow dataRow5 = (DataRow)enumerator5.Current;
					text2 = "افزایش صندوق ";
					text += sanad.InsertStr("1", dataRow5["mablagh"].ToString(), "0", dataRow5["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbed_id=@sanad_id where id= ", dataRow5["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator5;
				flag2 = (enumerator5 is IDisposable);
				if (flag2)
				{
					(enumerator5 as IDisposable).Dispose();
				}
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			text = "declare @sanad_id int;";
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh from daryaftpardakht where dptype_id=16 and sanadbes_id is null");
			try
			{
				IEnumerator enumerator6 = dataTable.Rows.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					DataRow dataRow6 = (DataRow)enumerator6.Current;
					text2 = "کاهش صندوق ";
					text += sanad.InsertStr("1", "0", dataRow6["mablagh"].ToString(), dataRow6["tarikh_fa"].ToString(), text2, "@sanad_id", Sanad.SanadType.@null);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=@sanad_id where id= ", dataRow6["id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator6;
				flag2 = (enumerator6 is IDisposable);
				if (flag2)
				{
					(enumerator6 as IDisposable).Dispose();
				}
			}
			flag2 = (text.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text);
			}
			int num = 0;
			text = "declare @sanad_id int;";
			dataTable = Public_Function.FillData("select id,tarikh,tarikh_fa,mablagh,tozih from daryaftpardakht where dptype_id in (-2,10) and sanadbes_id is null");
			checked
			{
				try
				{
					IEnumerator enumerator7 = dataTable.Rows.GetEnumerator();
					while (enumerator7.MoveNext())
					{
						DataRow dataRow7 = (DataRow)enumerator7.Current;
						num++;
						text += sanad.InsertStr("1", "0", dataRow7["mablagh"].ToString(), dataRow7["tarikh_fa"].ToString(), dataRow7["tozih"].ToString(), "@sanad_id", Sanad.SanadType.@null);
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set sanadbes_id=@sanad_id where id= ", dataRow7["id"]), ";")));
						flag2 = (num == 100);
						if (flag2)
						{
							flag = (text.Length > 0);
							if (flag)
							{
								Public_Function.ExecuteNonQuery(text);
								text = "declare @sanad_id int;";
							}
							num = 0;
						}
					}
				}
				finally
				{
					IEnumerator enumerator7;
					flag2 = (enumerator7 is IDisposable);
					if (flag2)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
				flag2 = (num < 100 && num > 0);
				if (flag2)
				{
					flag = (text.Length > 0);
					if (flag)
					{
						Public_Function.ExecuteNonQuery(text);
						text = "declare @sanad_id int;";
					}
				}
			}
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0009687C File Offset: 0x00094A7C
		private void DeleteNaghdTakrari()
		{
			try
			{
				Public_Function.ExecuteNonQuery("delete from daryaftpardakht where id in (select id from daryaftpardakht  where dptype_id=-1 and id not in(  select distinct(daryaft_id) from [Furush_Hag_Detail]   where moshtari_id=-1 and daryaft_id is not null)  and id not in (  select distinct(daryaft_id) from [Kharid_Furush]   where moshtari_id=-1 and daryaft_id is not null)   and id not in (  select distinct(daryaft_id) from [Kharid_Sardkhane_Furush]   where moshtari_id=-1 and daryaft_id is not null)   and id not in (  select distinct(daryaft_id) from [Furush_Sardkhane_Detail]   where moshtari_id=-1 and daryaft_id is not null))");
			}
			catch (Exception expr_0F)
			{
				ProjectData.SetProjectError(expr_0F);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0000472D File Offset: 0x0000292D
		private void DeleteSanad_hazfeShode()
		{
			Public_Function.ExecuteNonQuery("delete from sanad where id in ( select id from sanad where sanadtype=2  and id not in (SELECT     Sanad.ID FROM         Furush_Hag_Detail INNER JOIN Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID))");
			Public_Function.ExecuteNonQuery("delete from sanad where id in ( select id from sanad where sanadtype=3  and id not in (SELECT     Sanad.ID FROM         Kharid_Furush INNER JOIN Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID))");
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000968BC File Offset: 0x00094ABC
		public void InitDb1()
		{
			Public_Function.ExecuteNonQuery("update dptype set visible=0 where id in(5,16)");
			Public_Function.ExecuteNonQuery("update daryaftpardakht set check_status=5 where checkbarg_id is not null and check_status=1");
			this.AddColumn("dptype", "Code", "int null");
			Public_Function.ExecuteNonQuery("update dptype set visible=1 where id=3");
			Public_Function.ExecuteNonQuery("update dptype set name=" + Public_Function.GetValue("پرداخت هزینه از صندوق") + " where id=15");
			Public_Function.ExecuteNonQuery("update dptype set name=" + Public_Function.GetValue("پرداخت هزینه از بانک") + " where id=30");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("درآمد خریدو فروش") + " where id=12");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("درآمد ارسال بار") + " where id=13");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("فروش نقد خرید") + " where id=3");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("فروش نقد سردخانه") + " where id=4");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("کرایه حق العمل") + " where id=5");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("کرایه خرید") + " where id=6");
			Public_Function.ExecuteNonQuery("update code_hesab set name=" + Public_Function.GetValue("کرایه فروش سردخانه") + " where id=7");
			this.AlterColumn("Kharid_Detail", "Vazn_Kol", "decimal(18,1) NULL");
			this.AlterColumn("Kharid_Detail", "Fee", "decimal(18,1) NULL");
			this.AlterColumn("Kharid_Detail", "Jam_Kol", "decimal(18,1) NULL");
			this.AlterColumn("Furush_hag_rizbar", "Tedad", "decimal(18,1) NULL");
			this.AlterColumn("sanad", "bed", "bigint not null");
			this.AlterColumn("sanad", "bes", "bigint not null");
			this.AlterColumn("moshtari", "avaldore", "bigint null");
			this.AlterColumn("daryaftpardakht", "mablagh", "bigint not null");
			this.AlterColumn("bank_Hesab", "AvalDore", "bigint null");
			this.AlterColumn("Furush_Keraye", "Keraye_Pardakht_ID", "int Null");
			this.AlterColumn("Kharid_Keraye", "Keraye_Pardakht_ID", "int Null");
			this.AddColumn("Furush_Keraye", "Keraye_Pardakht_ID2", "int Null");
			this.AlterColumn("historylog_detail", "fromvalue", "nvarchar(1000) null");
			this.AlterColumn("historylog_detail", "tovalue", "nvarchar(1000) null");
			this.AlterColumn("furush_hag", "sh_barname", "nvarchar(50)");
			this.AlterColumn("kharid", "sh_barname", "nvarchar(50)");
			this.AlterColumn("furush_hag_detail", "zarf", "decimal(18,2)");
			this.AlterColumn("furush_hag_detail", "vazn_kol", "decimal(18,2)");
			this.AlterColumn("kharid_furush", "zarf", "decimal(18,2)");
			this.AlterColumn("kharid_furush", "vazn_kol", "decimal(18,2)");
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
				Public_Function.GetValue("moshtari"),
				" AND column_name= ",
				Public_Function.GetValue("kind"),
				")BEGIN ALTER TABLE moshtari  ADD [kind] int null; END"
			}));
			Public_Function.ExecuteNonQuery("update moshtari set [kind]=1 where [kind] is null");
			Public_Function.ExecuteNonQuery("IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[routines] where [ROUTINE_NAME]=" + Public_Function.GetValue("daryaftnaghd") + ")      exec('Create FUNCTION daryaftnaghd  ( @tarikh datetime ) RETURNS bigint   AS  BEGIN  declare @sum bigint,@sumbar bigint,@sumkart bigint;  select @sum=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(-1,1,26,6);  select @sumbar=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(28) and moshtari_id=-1  select @sumkart=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(27,32)  RETURN @sum+@sumbar-@sumkart   End');  ELSE  exec('ALTER FUNCTION [dbo].[daryaftnaghd]  ( @tarikh datetime ) RETURNS bigint   AS  BEGIN  declare @sum bigint,@sumbar bigint,@sumkart bigint;    select @sum=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(-1,1,26,6);   select @sumbar=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(28) and moshtari_id=-1;  select @sumkart=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(27,32)  RETURN @sum+@sumbar-@sumkart   End ')  ");
			Public_Function.ExecuteNonQuery("IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[routines] where [ROUTINE_NAME]=" + Public_Function.GetValue("pardakhtnaghd") + ") exec('Create Function pardakhtnaghd  (@tarikh datetime  )  returns BIGINT  AS  BEGIN  DECLARE @sum bigint; select @sum=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(10,14,-2,-3,-5);  select @sum=@sum+ isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(15) and sh_check is null and bankhesab_id is null ;  RETURN @sum;  END'); ELSE  exec('ALTER Function [dbo].[pardakhtnaghd]  (@tarikh datetime  )  returns bigint  AS  BEGIN   declare @sum bigint;  select @sum=isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(10,14,-2,-3,-5);  select @sum=@sum+ isnull(sum(mablagh),0) from daryaftpardakht where tarikh=@tarikh and dptype_id in(15) and sh_check is null and bankhesab_id is null ;  RETURN @sum;  End ');");
			Public_Function.ExecuteNonQuery("IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[routines] where [ROUTINE_NAME]=" + Public_Function.GetValue("getersalbar_kala") + ") exec('CREATE FUNCTION getersalbar_kala (@ersalbar_id bigint) returns nvarchar(100) AS  BEGIN declare @kala_name nvarchar(100),@kala nvarchar(50);  set @kala_name='''';  declare cur1 cursor for  select DISTINCT Kala.Name  FROM         ErsalBar INNER JOIN   ErsalBar_Detail ON ErsalBar.ID = ErsalBar_Detail.ErsalBar_ID INNER JOIN  Kala ON ErsalBar_Detail.Kala_ID = Kala.ID  where ErsalBar.id=@ersalbar_id;   open cur1;  fetch next from cur1 into @kala;  while @@fetch_status=0  begin  set @kala_name += @kala +'' - '';  fetch next from cur1 into @kala;  End  close cur1;  deallocate cur1;   return @kala_name;  End  ');");
			this.AddColumn("daryaftpardakht", "MoshtariHesab_ID", " Int NULL");
			this.AddColumn("daryaftpardakht", "BankHesab_ID2", " Int NULL");
			this.AddColumn("bank_hesab", "SahebHesab", "nvarchar(100) NULL");
			this.AddColumn("bank_hesab", "Tel", "nvarchar(100) NULL");
			this.AddColumn("bank_hesab", "Address", "nvarchar(200) NULL");
			this.AddColumn("bank_hesab", "NamePedar", "nvarchar(20) NULL");
			this.AddColumn("bank_hesab", "CodeMelli", "nvarchar(10) NULL");
			this.AddColumn("bank_hesab", "shsh", "nvarchar(10) NULL");
			this.AddColumn("bank_hesab", "sadere", "nvarchar(15) NULL");
			this.AddColumn("bank_hesab", "codeposti", "nvarchar(10) NULL");
			this.AddColumn("bank_hesab", "signpic", "image");
			this.AddColumn("bank", "vagozaricount", "Int null");
			this.AddColumn("bank", "copies", "Int null");
			this.AddColumn("moshtari", "moaref_kind", "int null");
			this.AddColumn("moshtari", "karmozd", "int null");
			this.AddColumn("safi_furush", "printcount", "Decimal(10,2) null");
			this.AddColumn("pardakhtkonande", "address", "nvarchar(100) null");
			this.AddColumn("sanad", "checked", "bit null");
			this.AddColumn("hazine_kharid", "code", "int null");
			this.AddColumn("moshtari", "code", "int null");
			this.AddColumn("kharid_Detail", "sanad_id", "bigint null");
			this.AddColumn("Furush_Keraye", "Sanad_ID", "bigint null");
			Public_Function.ExecuteNonQuery("update moshtari set code=0 where id=-1");
			Public_Function.ExecuteNonQuery("update moshtari set code=1 where id=-2");
			Public_Function.ExecuteNonQuery("update moshtari set code=id where code is null");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[NahvePardakht_Hazine]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[NahvePardakht_Hazine](  [ID] [int] NOT NULL,  [Name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_NahvePardakht_Hazine] PRIMARY KEY CLUSTERED   ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY];  insert into NahvePardakht_Hazine (ID,name) values(1,N'نقد'); insert into NahvePardakht_Hazine (ID,name) values(2,N'دسته چک'); insert into NahvePardakht_Hazine (ID,name) values(3,N'چک مشتری'); END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[NahvePardakht_Agsat]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[NahvePardakht_Agsat](  [ID] [int] NOT NULL,  [Name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_NahvePardakht_Agsat] PRIMARY KEY CLUSTERED   ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY];  insert into NahvePardakht_Agsat (ID,name) values(1,N'صندوق'); insert into NahvePardakht_Agsat (ID,name) values(2,N'حساب بانکی'); END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FactorFurush]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[FactorFurush](  [ID] [int] NOT NULL  IDENTITY (1, 1),  [NUM] [int] NOT NULL, [Moshtari_ID] [int] NOT NULL,  [Moshtari_Name] [nvarchar](100)  NULL,  CONSTRAINT [PK_FactorFurush] PRIMARY KEY CLUSTERED ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Darsad]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Furush_Darsad](  ID bigint NOT NULL IDENTITY (1, 1),  [Furush_ID] [int] NOT NULL,  [Moshtari_ID] [int] NOT NULL,  [Darsad] [decimal](10, 2) NOT NULL, [Mablagh] [bigint] NOT NULL, [SanadBed_ID] [bigint] NOT NULL, [SanadBes_ID] [bigint] NOT NULL, CONSTRAINT [PK_Furush_Darsad] PRIMARY KEY CLUSTERED  (  [ID] Asc  ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Furush_Darsad]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Darsad_Furush_Hag] FOREIGN KEY([Furush_ID])  REFERENCES [dbo].[Furush_Hag]([ID])  ALTER TABLE [dbo].[Furush_Darsad] CHECK CONSTRAINT [FK_Furush_Darsad_Furush_Hag]  ALTER TABLE [dbo].[Furush_Darsad]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Darsad_Moshtari] FOREIGN KEY([Moshtari_ID])  REFERENCES [dbo].[Moshtari]([ID])  ALTER TABLE [dbo].[Furush_Darsad] CHECK CONSTRAINT [FK_Furush_Darsad_Moshtari]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Moshtari_Kind]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN CREATE TABLE [dbo].[Moshtari_Kind]( [ID] [int] NOT NULL,  [Name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_Moshtari_Kind] PRIMARY KEY CLUSTERED  ( [ID] Asc   )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY]; END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Moshtari_ListSiah]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Moshtari_ListSiah](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Moshtari_ID] [int] NOT NULL,  CONSTRAINT [PK_Moshtari_ListSiah] PRIMARY KEY CLUSTERED   (\t[ID] ASC  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=1) insert into moshtari_kind(id,name) values(1,'آقا - خریدار') else update moshtari_kind set name='آقا - خریدار' where id=1;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=2) insert into moshtari_kind(id,name) values(2,'آقا - صاحب بار') else update moshtari_kind set name='آقا - صاحب بار' where id=2;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=3) insert into moshtari_kind(id,name) values(3,'شرکت - خریدار') else update moshtari_kind set name='شرکت - خریدار' where id=3;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=4) insert into moshtari_kind(id,name) values(4,'شرکت - صاحب بار') else update moshtari_kind set name='شرکت - صاحب بار' where id=4;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=5) insert into moshtari_kind(id,name) values(5,'خانم - خریدار') else update moshtari_kind set name='خانم - خریدار' where id=5;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from moshtari_kind where id=6) insert into moshtari_kind(id,name) values(6,'خانم - صاحب بار') else update moshtari_kind set name='خانم - صاحب بار' where id=6;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from NahvePardakht_Hazine where id=4) insert into NahvePardakht_Hazine(id,name) values(4,'کارت به کارت') ;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from NahvePardakht_Hazine where id=5) insert into NahvePardakht_Hazine(id,name) values(5,'پرداخت از تنخواه') ;");
			Public_Function.ExecuteNonQuery(" if not exists(select id from Grouh_Hesab where id=12) insert into Grouh_Hesab(id,name) values(12,N'چک های نزد صندوق') ;");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Note]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Note](  [ID] [int] IDENTITY(1,1) NOT NULL,  [text] [nvarchar](500) NULL,  CONSTRAINT [PK_Note] PRIMARY KEY CLUSTERED  ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sharik]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE dbo.Sharik  (\tMoshtari_ID int NOT NULL,  Darsad int NOT NULL  )  ON [PRIMARY]  ALTER TABLE dbo.Sharik ADD CONSTRAINT  FK_Sharik_Moshtari FOREIGN KEY   ( Moshtari_ID  ) REFERENCES dbo.Moshtari  (  ID  ) ON UPDATE  NO ACTION   ON DELETE  CASCADE  END");
			Public_Function.ExecuteNonQuery(" IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Saheb_Saham]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  DROP TABLE [dbo].[Saheb_Saham]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Theme]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Theme](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Name] [nvarchar](50) NOT NULL,  [GridColor] [nvarchar](50)  NULL, [ToolbarBackground] [nvarchar](50) NULL, [Background] [nvarchar](50) NULL, [ButtonBackground] [nvarchar](50) NULL, CONSTRAINT [PK_Theme] PRIMARY KEY CLUSTERED  ( [ID] Asc  ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END ");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sud]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Sud](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Num] [int] NOT NULL,  [Tarikh] [datetime] NOT NULL,  [Tarikh_Fa] [nvarchar](10) NOT NULL,  [DaramadSanad_ID] [bigint]  NULL,  [HazineSanad_ID] [bigint] NULL,  CONSTRAINT [PK_Sud] PRIMARY KEY CLUSTERED   (   [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sud_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Sud_Detail](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Sud_ID] [int] NOT NULL,  [Moshtari_ID] [int] NOT NULL,  [Darsad] [decimal](10, 2) NOT NULL, [Mablagh] [bigint] NOT NULL,  [Sanad_ID] [bigint] NOT NULL,  CONSTRAINT [PK_Sud_Detail] PRIMARY KEY CLUSTERED  (  [ID] Asc  ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Sud_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Sud_Detail_Sud] FOREIGN KEY([Sud_ID])  REFERENCES [dbo].[Sud]([ID])  ALTER TABLE [dbo].[Sud_Detail] CHECK CONSTRAINT [FK_Sud_Detail_Sud] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[shobe]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN CREATE TABLE [dbo].[Shobe](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_Shobe] PRIMARY KEY CLUSTERED  ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Sardkhane]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Kharid_Sardkhane](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Num] [bigint] NOT NULL,  [Tarikh_Vurud] [nvarchar](10) NULL,  [Desc] [nvarchar](200) NULL,  [Daramad_Sanad_ID] [bigint] NULL,  [Closed] [bit] NULL CONSTRAINT [PK_Kharid_Sardkhane] PRIMARY KEY CLUSTERED  (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Sardkhane_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Kharid_Sardkhane_Detail](  [ID] [int] IDENTITY(1,1) NOT NULL, [Kharid_Sardkhane_ID] [int] NOT NULL, Moshtari_id [int] NOT NULL, Tarikh [datetime] NOT NULL, Tarikh_Fa [nvarchar] (10) NOT NULL, sh_mashin [nvarchar] (9) NULL, sh_barname [nvarchar] (50) NULL, [Kala_ID] [int] NOT NULL, [Tedad] [decimal](18, 1) NULL, [Vazn_Ba_Zarf] [decimal](18, 1) NULL, [Zarf] [decimal](18, 1) NULL, [Vazn_Kol] [decimal](18, 1) NULL, [Fee] [decimal](18, 1) NULL, [Jam_Kol] [decimal](18, 1) NULL, [auto] [bit] NULL, [sanad_id] [bigint] NULL,  CONSTRAINT [PK_Kharid_Sardkhane_Detail] PRIMARY KEY CLUSTERED  (         [ID] Asc )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY] ALTER TABLE [dbo].[Kharid_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Detail_Kala] FOREIGN KEY([Kala_ID])         REFERENCES [dbo].[Kala]([ID]) ALTER TABLE [dbo].[Kharid_Sardkhane_Detail] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Detail_Kala] ALTER TABLE [dbo].[Kharid_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Detail_Kharid] FOREIGN KEY([Kharid_Sardkhane_ID])         REFERENCES [dbo].[Kharid_Sardkhane]([ID]) ALTER TABLE [dbo].[Kharid_Sardkhane_Detail] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Detail_Kharid] ALTER TABLE [dbo].[Kharid_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Detail_moshtari] FOREIGN KEY([moshtari_ID])         REFERENCES [dbo].[moshtari]([ID]) ALTER TABLE [dbo].[Kharid_Sardkhane_Detail] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Detail_moshtari]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Sardkhane_Keraye]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Kharid_Sardkhane_Keraye](    [ID] [int] IDENTITY(1,1) NOT NULL,    [Kharid_Sardkhane_ID] [int] NOT NULL,    [HazineKharid_ID] [int] NOT NULL,    [Kala_ID] [int] NULL,    [Tedad] [decimal](18, 1) NULL,    [Vazn] [decimal](18, 1) NULL,    [Keraye] [bigint] NOT NULL,    [Keraye_Pardakht_ID] [int] NULL,    [Tarikh] [datetime] NOT NULL,    [Tarikh_Fa] [nvarchar](10) NOT NULL,     CONSTRAINT [PK_Kharid_Sardkhane_Keraye] PRIMARY KEY CLUSTERED    (            [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]    ) ON [PRIMARY]    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Keraye_DaryaftPardakht] FOREIGN KEY([Keraye_Pardakht_ID])            REFERENCES [dbo].[DaryaftPardakht]([ID])    ON DELETE CASCADE    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Keraye_DaryaftPardakht]    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Hazine_Kharid] FOREIGN KEY([HazineKharid_ID])            REFERENCES [dbo].[Hazine_Kharid]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Hazine_Kharid]    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Kala] FOREIGN KEY([Kala_ID])            REFERENCES [dbo].[Kala]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Kala]    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Kharid] FOREIGN KEY([Kharid_Sardkhane_ID])            REFERENCES [dbo].[Kharid_Sardkhane]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Keraye_Kharid]   END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Furush_Sardkhane](    [ID] [int] IDENTITY(1,1) NOT NULL,   [Num] [bigint] NOT NULL,   [Kharid_Sardkhane_ID] [int] NOT NULL,    [Sh_Mashin] [nvarchar](9) NULL,    [Sh_Barname] [nvarchar](50) NULL,   [Tarikh_Vurud] [nvarchar](10) NULL,   [Desc] [nvarchar](200) NULL,   [Baskul] [decimal](18, 1) NULL,   [Baskul_Mabda] [bigint] NULL,   [Tedad_Kol] [decimal](18, 1) NULL, CONSTRAINT [PK_Furush_Sardkhane] PRIMARY KEY CLUSTERED  (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Furush_Sardkhane]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Kharid] FOREIGN KEY([Kharid_Sardkhane_ID])  REFERENCES [dbo].[Kharid_Sardkhane]([ID])  ALTER TABLE [dbo].[Furush_Sardkhane] CHECK CONSTRAINT [FK_Furush_Sardkhane_Kharid]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Furush_Sardkhane_Detail]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Furush_Sardkhane_ID] [int] NOT NULL, \t[Moshtari_ID] [int] NOT NULL, \t[Kala_ID] [int] NOT NULL, \t[Tarikh] [date] NOT NULL, \t[Tarikh_Fa] [nvarchar](10) NOT NULL, \t[Tedad] [decimal](18, 1) NULL, \t[Vazn_Ba_Zarf] [decimal](18, 1) NULL, \t[Zarf] [decimal](18, 1) NULL, \t[Vazn_Kol] [decimal](18, 1) NOT NULL, \t[Fee] [decimal](18, 1) NOT NULL, \t[Jam_Kol] [decimal](18, 1) NOT NULL, \t[Sanad_ID] [int] NULL, \t[Daryaft_ID] [int] NULL,     CONSTRAINT [PK_Furush_Sardkhane_Detail] PRIMARY KEY CLUSTERED    (            [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]    ) ON [PRIMARY]    ALTER TABLE [dbo].[Furush_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Detail_DaryaftPardakht] FOREIGN KEY([Daryaft_ID])            REFERENCES [dbo].[DaryaftPardakht]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Detail] CHECK CONSTRAINT [FK_Furush_Sardkhane_Detail_DaryaftPardakht]    ALTER TABLE [dbo].[Furush_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Detail_Sanad] FOREIGN KEY([Sanad_ID])            REFERENCES [dbo].[Sanad]([ID])    ON UPDATE CASCADE    ON DELETE CASCADE    ALTER TABLE [dbo].[Furush_Sardkhane_Detail] CHECK CONSTRAINT [FK_Furush_Sardkhane_Detail_Sanad]    ALTER TABLE [dbo].[Furush_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Detail_Furush_Sardkhane] FOREIGN KEY([Furush_Sardkhane_ID])            REFERENCES [dbo].[Furush_Sardkhane]([ID])    ON UPDATE CASCADE    ON DELETE CASCADE    ALTER TABLE [dbo].[Furush_Sardkhane_Detail] CHECK CONSTRAINT [FK_Furush_Sardkhane_Detail_Furush_Sardkhane]    ALTER TABLE [dbo].[Furush_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Detail_Kala] FOREIGN KEY([Kala_ID])            REFERENCES [dbo].[Kala]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Detail] CHECK CONSTRAINT [FK_Furush_Sardkhane_Detail_Kala]    ALTER TABLE [dbo].[Furush_Sardkhane_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Detail_Moshtari] FOREIGN KEY([Moshtari_ID])            REFERENCES [dbo].[Moshtari]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Detail] CHECK CONSTRAINT [FK_Furush_Sardkhane_Detail_Moshtari]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane_RizBar]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN     CREATE TABLE [dbo].[Furush_Sardkhane_RizBar]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Furush_Sardkhane_ID] [int] NOT NULL, \t[Kala_ID] [int] NOT NULL, \t[Tedad] [decimal](18, 1) NULL,\t[Vazn] [decimal](18, 1) NULL, \t[auto] [bit] NULL,     CONSTRAINT [PK_Furush_Sardkhane_RizBar] PRIMARY KEY CLUSTERED    (            [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]    ) ON [PRIMARY]    ALTER TABLE [dbo].[Furush_Sardkhane_RizBar]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_RizBar_Furush_Sardkhane] FOREIGN KEY([Furush_Sardkhane_ID])            REFERENCES [dbo].[Furush_Sardkhane]([ID])    ON UPDATE CASCADE    ON DELETE CASCADE    ALTER TABLE [dbo].[Furush_Sardkhane_RizBar] CHECK CONSTRAINT [FK_Furush_Sardkhane_RizBar_Furush_Sardkhane]    ALTER TABLE [dbo].[Furush_Sardkhane_RizBar]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_RizBar_Kala] FOREIGN KEY([Kala_ID])            REFERENCES [dbo].[Kala]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_RizBar] CHECK CONSTRAINT [FK_Furush_Sardkhane_RizBar_Kala]     END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane_Keraye]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Furush_Sardkhane_Keraye]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Furush_Sardkhane_ID] [int] NOT NULL, \t[HazineKharid_ID] [int] NOT NULL, \t[Kala_ID] [int] NULL, \t[Tedad] [decimal](18, 1) NULL, \t[Vazn] [decimal](18, 1) NULL, \t[Keraye] [bigint] NOT NULL, \t[Keraye_Pardakht_ID] [int] NULL, \t[Tarikh] [datetime] NOT NULL, \t[Tarikh_Fa] [nvarchar](10) NOT NULL,     CONSTRAINT [PK_Furush_Sardkhane_Keraye] PRIMARY KEY CLUSTERED     (            [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]    ) ON [PRIMARY]    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Keraye_DaryaftPardakht] FOREIGN KEY([Keraye_Pardakht_ID])            REFERENCES [dbo].[DaryaftPardakht]([ID])    ON DELETE CASCADE    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Furush_Sardkhane_Keraye_DaryaftPardakht]    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Keraye_Furush_Sardkhane] FOREIGN KEY([Furush_Sardkhane_ID])            REFERENCES [dbo].[Furush_Sardkhane]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Furush_Sardkhane_Keraye_Furush_Sardkhane]    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Keraye_Hazine_Kharid] FOREIGN KEY([HazineKharid_ID])            REFERENCES [dbo].[Hazine_Kharid]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Furush_Sardkhane_Keraye_Hazine_Kharid]    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Keraye_Kala] FOREIGN KEY([Kala_ID])            REFERENCES [dbo].[Kala]([ID])    ALTER TABLE [dbo].[Furush_Sardkhane_Keraye] CHECK CONSTRAINT [FK_Furush_Sardkhane_Keraye_Kala]     END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane_Safi]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Furush_Sardkhane_Safi]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Sanad_ID] [int] NULL, \t[Furush_Sardkhane_ID] [int] NOT NULL, \t[JamFurush] [int] NOT NULL, \t[Darsad] [decimal](18, 1)  NULL, \t[Karmozd] [int]  NULL, \t[Mande] [int] NOT NULL, \t[Tarikh] [datetime] NULL, \t[Tarikh_Fa] [nvarchar](10) NULL, \t[Karmozd_Sanad_ID] [int] NULL, \t[Tozih] [nvarchar](150) NULL, \t[printcount] [int] NULL,  CONSTRAINT [PK_Furush_Sardkhane_Safi] PRIMARY KEY CLUSTERED  (  [ID] Asc  ) WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Furush_Sardkhane_Safi]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Safi_Furush_Sardkhane] FOREIGN KEY([Furush_Sardkhane_ID])  REFERENCES [dbo].[Furush_Sardkhane]([ID])  ALTER TABLE [dbo].[Furush_Sardkhane_Safi] CHECK CONSTRAINT [FK_Furush_Sardkhane_Safi_Furush_Sardkhane]  ALTER TABLE [dbo].[Furush_Sardkhane_Safi]  WITH CHECK ADD  CONSTRAINT [FK_Furush_Sardkhane_Safi_Sanad] FOREIGN KEY([Sanad_ID])  REFERENCES [dbo].[Sanad]([ID])  ON UPDATE CASCADE  ON DELETE CASCADE  ALTER TABLE [dbo].[Furush_Sardkhane_Safi] CHECK CONSTRAINT [FK_Furush_Sardkhane_Safi_Sanad]     END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Sardkhane_Darsad]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN     CREATE TABLE [dbo].[Kharid_Sardkhane_Darsad](\t[ID] [int] IDENTITY(1,1) NOT NULL,\t[Kharid_Sardkhane_ID] [int] NOT NULL,\t[Moshtari_ID] [int] NOT NULL,\t[darsad] [decimal](18, 1) NOT NULL,\t[Mablagh] [bigint] NULL,\t[Sanad_ID] [int] NULL, CONSTRAINT [PK_Kharid_Sardkhane_Darsad] PRIMARY KEY CLUSTERED  (         [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Kharid] FOREIGN KEY([Kharid_Sardkhane_ID])        REFERENCES [dbo].[Kharid_Sardkhane]([ID]) ON UPDATE CASCADE ON DELETE CASCADE ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Kharid] ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Moshtari] FOREIGN KEY([Moshtari_ID])        REFERENCES [dbo].[Moshtari]([ID]) ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Moshtari] ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Sanad] FOREIGN KEY([Sanad_ID])        REFERENCES [dbo].[Sanad]([ID]) ALTER TABLE [dbo].[Kharid_Sardkhane_Darsad] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Darsad_Sanad]    END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[PardakhtKonande]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[PardakhtKonande](  [Name] [nvarchar](50) NOT NULL,  [namePedar] [nvarchar](50) NULL,  [CodeMelli] [nvarchar](50) NULL,  [Shsh] [nvarchar](50) NULL,  [CodePosti] [nvarchar](50) NULL,  [Tel] [nvarchar](50) NULL,  [TarikhTavalod] [nvarchar](50) NULL  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ShomareHesab]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN CREATE TABLE [dbo].[ShomareHesab](  [ID] [int] IDENTITY(1,1) NOT NULL,  [ShomareHesab] [nvarchar](50) NOT NULL, [Bank_ID] [int] NOT NULL,  [Shobe_ID] [int] NOT NULL, CONSTRAINT [PK_ShomareHesab_1] PRIMARY KEY CLUSTERED   ( [ID] Asc   )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]   ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KhordeFurushi]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[KhordeFurushi](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Pardakht_Naghd_ID] [int] null,  [Tarikh] [datetime] NOT NULL,  [Tarikh_Fa] [nvarchar](10) NOT NULL,  CONSTRAINT [PK_KhordeFurushi] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KhordeFurushi_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN            CREATE TABLE [dbo].[KhordeFurushi_Detail](    \t[ID] [bigint] IDENTITY(1,1) NOT NULL,        [Khordefurushi_id] [int] NOT NULL,    \t[Moshtari_ID] [int] NOT NULL,    \t[Kala_ID] [int] NOT NULL,    \t[Tedad] [decimal](18, 1) NULL,    \t[Vazn_Ba_Zarf] [decimal](18, 1) NULL,    \t[Zarf] [decimal](18, 1) NULL,    \t[Vazn_Kol] [decimal](18, 1) NOT NULL,    \t[Fee] [decimal](18, 1) NOT NULL,    \t[Jam_Kol] [decimal](18, 1) NOT NULL,    \t[Moshtari_Sanad_ID] [int] NULL,    \t[Keraye] [bigint] NULL,    \t[Keraye_Pardakht_ID] [bigint] NULL,     CONSTRAINT [PK_KhordeFurushi_Detail] PRIMARY KEY CLUSTERED     (    [ID] Asc     )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]     ) ON [PRIMARY]     ALTER TABLE [dbo].[KhordeFurushi_Detail]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Detail_Kala] FOREIGN KEY([Kala_ID])    REFERENCES [dbo].[Kala]([ID])     ALTER TABLE [dbo].[KhordeFurushi_Detail] CHECK CONSTRAINT [FK_KhordeFurushi_Detail_Kala]     ALTER TABLE [dbo].[KhordeFurushi_Detail]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Detail_Khordefurushi] FOREIGN KEY([khordefurushi_ID])    REFERENCES [dbo].[KhordeFurushi]([ID])     ALTER TABLE [dbo].[KhordeFurushi_Detail] CHECK CONSTRAINT [FK_KhordeFurushi_Detail_Khordefurushi]     ALTER TABLE [dbo].[KhordeFurushi_Detail]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Detail_Moshtari] FOREIGN KEY([Moshtari_ID])    REFERENCES [dbo].[Moshtari]([ID])     ALTER TABLE [dbo].[KhordeFurushi_Detail] CHECK CONSTRAINT [FK_KhordeFurushi_Detail_Moshtari]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KhordeFurushi_Keraye]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN                                          CREATE TABLE [dbo].[KhordeFurushi_Keraye](  \t[ID] [int] IDENTITY(1,1) NOT NULL,  \t[Khordefurushi_ID] [int] NOT NULL,  \t[HazineKharid_ID] [int] NOT NULL,  \t[Kala_ID] [int] NULL,  \t[Tedad] [decimal](18, 1) NULL,  \t[Vazn] [decimal](18, 1) NULL,  \t[Keraye] [bigint] NOT NULL,  \t[Keraye_Pardakht_ID] [int] NULL,  \t[Tarikh] [datetime] NOT NULL,  \t[Tarikh_Fa] [nvarchar](10) NOT NULL,  \t[Sanad_ID] [bigint] NULL,   CONSTRAINT [PK_KhordeFurushi_Keraye] PRIMARY KEY CLUSTERED   (          [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[KhordeFurushi_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Keraye_DaryaftPardakht] FOREIGN KEY([Keraye_Pardakht_ID])          REFERENCES [dbo].[DaryaftPardakht]([ID])  ON DELETE CASCADE  ALTER TABLE [dbo].[KhordeFurushi_Keraye] CHECK CONSTRAINT [FK_KhordeFurushi_Keraye_DaryaftPardakht]  ALTER TABLE [dbo].[KhordeFurushi_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Keraye_KhordeFurushi] FOREIGN KEY([Khordefurushi_ID])          REFERENCES [dbo].Khordefurushi([ID])  ALTER TABLE [dbo].[KhordeFurushi_Keraye] CHECK CONSTRAINT [FK_KhordeFurushi_Keraye_KhordeFurushi]  ALTER TABLE [dbo].[KhordeFurushi_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Keraye_Hazine_Kharid] FOREIGN KEY([HazineKharid_ID])          REFERENCES [dbo].[Hazine_Kharid]([ID])  ALTER TABLE [dbo].[KhordeFurushi_Keraye] CHECK CONSTRAINT [FK_KhordeFurushi_Keraye_Hazine_Kharid]  ALTER TABLE [dbo].[KhordeFurushi_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_KhordeFurushi_Keraye_Kala] FOREIGN KEY([Kala_ID])          REFERENCES [dbo].[Kala]([ID])  ALTER TABLE [dbo].[KhordeFurushi_Keraye] CHECK CONSTRAINT [FK_KhordeFurushi_Keraye_Kala]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ErsalBar_Keraye]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[ErsalBar_Keraye]( [ID] [int] IDENTITY(1,1) NOT NULL, [ErsalBar_ID] [int] NOT NULL, [HazineKharid_ID] [int] NOT NULL, [Kala_ID] [int] NULL, [Tedad] [decimal](18, 1) NULL, [Vazn] [decimal](18, 1) NULL, [Keraye] [bigint] NOT NULL, [Keraye_Pardakht_ID] [int] NULL, [Tarikh] [datetime] NOT NULL, [Tarikh_Fa] [nvarchar](10) NOT NULL, [Sanad_ID] [bigint] NULL, CONSTRAINT [PK_ErsalBar_Keraye] PRIMARY KEY CLUSTERED  (    [ID] Asc )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY] ) ON [PRIMARY] ALTER TABLE [dbo].[ErsalBar_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_ErsalBar_Keraye_DaryaftPardakht] FOREIGN KEY([Keraye_Pardakht_ID]) REFERENCES [dbo].[DaryaftPardakht]([ID]) ON DELETE CASCADE ALTER TABLE [dbo].[ErsalBar_Keraye] CHECK CONSTRAINT [FK_ErsalBar_Keraye_DaryaftPardakht] ALTER TABLE [dbo].[ErsalBar_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_ErsalBar_Keraye_ErsalBar] FOREIGN KEY([ErsalBar_ID]) REFERENCES [dbo].[ErsalBar]([ID]) ALTER TABLE [dbo].[ErsalBar_Keraye] CHECK CONSTRAINT [FK_ErsalBar_Keraye_ErsalBar] ALTER TABLE [dbo].[ErsalBar_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_ErsalBar_Keraye_Hazine_Kharid] FOREIGN KEY([HazineKharid_ID]) REFERENCES [dbo].[Hazine_Kharid]([ID]) ALTER TABLE [dbo].[ErsalBar_Keraye] CHECK CONSTRAINT [FK_ErsalBar_Keraye_Hazine_Kharid] ALTER TABLE [dbo].[ErsalBar_Keraye]  WITH CHECK ADD  CONSTRAINT [FK_ErsalBar_Keraye_Kala] FOREIGN KEY([Kala_ID]) REFERENCES [dbo].[Kala]([ID]) ALTER TABLE [dbo].[ErsalBar_Keraye] CHECK CONSTRAINT [FK_ErsalBar_Keraye_Kala] END");
			Public_Function.ExecuteNonQuery("if not exists (select * from users) insert into users(username,password,gui) values('Admin','1',0)");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-4) insert into dptype(id,type,name,visible) values(-4,2,N'پرداخت کرایه و مخارج',0);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=28) insert into dptype(id,type,name,visible) values(28,1,N'فروش بارروی زمین',1);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-99) insert into dptype(id,type,name,visible) values(-99,1,N'اول دوره دریافتنی',0);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-98) insert into dptype(id,type,name,visible) values(-98,2,N'اول دوره پرداختنی',0);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=29) insert into dptype(id,type,name,visible,Code) values(29,2,N'کارت به کارت',1,7);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=30) insert into dptype(id,type,name,visible,Code) values(30,2,N'پرداخت هزینه از بانک',1,8);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=31) insert into dptype(id,type,name,visible,Code) values(31,2,N'بانک به بانک',1,8);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=32) insert into dptype(id,type,name,visible,Code) values(32,2,N'الباقی فاکتور مشتری',1,9);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=33) insert into dptype(id,type,name,visible,Code) values(33,1,'دریافت تسهیلات',1,8);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=35) insert into dptype(id,type,name,visible,Code) values(35,1,'فروش روزانه',0,10);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=36) insert into dptype(id,type,name,visible,Code) values(36,1,'دریافت سود بانکی',1,11);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=37) insert into dptype(id,type,name,visible,Code) values(37,2,'پرداخت اقساط',1,9);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=38) insert into dptype(id,type,name,visible,Code) values(38,2,'پرداخت به تنخواه گردان',1,10);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=39) insert into dptype(id,type,name,visible,Code) values(39,2,'مشتری به مشتری',1,11);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=40) insert into dptype(id,type,name,visible,Code) values(40,1,'بانک به صندوق',1,10);");
			Public_Function.ExecuteNonQuery("update dptype set name=N'پرداخت به تنخواه گردان' where id=38");
			Public_Function.ExecuteNonQuery("update dptype set name=N'پرداخت هزینه' where id=15");
			Public_Function.ExecuteNonQuery("update dptype set visible=0 where id=30");
			Public_Function.ExecuteNonQuery("update dptype set visible=0 where id=32");
			Public_Function.ExecuteNonQuery("update dptype set visible=0 where id=35");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-1) insert into moshtari(id,name,family) values(-1,N'نقدی',' '); set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-2) insert into moshtari(id,name,family) values(-2,N'بارروی زمین',' '); set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-3) insert into moshtari(id,name,family) values(-3,N'اول دوره سندهای ناتمام',' '); set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-5) insert into moshtari(id,name,family) values(-5,N'تولید',' '); set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("set identity_insert Hazine_Kharid on; if not exists(select id from Hazine_Kharid where id=-6) insert into Hazine_Kharid(id,name) values(-6,N'کرایه و مخارج اول دوره'); set identity_insert Hazine_Kharid off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=15) insert into Code_Hesab(id,Grouh_ID,name) values(15,7,N'محاسبه سود و زیان - درآمد'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=16) insert into Code_Hesab(id,Grouh_ID,name) values(16,5,N'محاسبه سود و زیان - هزینه'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=17) insert into Code_Hesab(id,Grouh_ID,name) values(17,7,N'درآمد فروش سردخانه'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=18) insert into Code_Hesab(id,Grouh_ID,name) values(18,11,N'تخلیه فروش'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-4) insert into moshtari(id,name,family,code,codehesab_ID) values(-4,N'تخلیه','',-4,18) set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=25) insert into Code_Hesab(id,Grouh_ID,name) values(25,6,N'کرایه ارسال بار'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=26) insert into Code_Hesab(id,Grouh_ID,name) values(26,11,N'مخارج ارسال بار'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=27) insert into Code_Hesab(id,Grouh_ID,name) values(27,5,N'هزینه تفاوت'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=28) insert into Code_Hesab(id,Grouh_ID,name) values(28,5,N'هزینه اول دوره'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=29) insert into Code_Hesab(id,Grouh_ID,name) values(29,7,N'درآمد اول دوره'); set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=30) insert into Code_Hesab(id,Grouh_ID,name) values(30,5,N'هزینه');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=31) insert into Code_Hesab(id,Grouh_ID,name) values(31,7,N'درآمد سود بانکی');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=32) insert into Code_Hesab(id,Grouh_ID,name) values(32,5,N'پرداخت اقساط');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=33) insert into Code_Hesab(id,Grouh_ID,name) values(33,12,N'چک های نزد صندوق');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=34) insert into Code_Hesab(id,Grouh_ID,name) values(34,5,N'هزینه افزایش صافی');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=35) insert into Code_Hesab(id,Grouh_ID,name) values(35,7,N'درآمد کاهش صافی');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert moshtari on; if not exists(select id from moshtari where id=-6) insert into moshtari(id,codehesab_ID,name,family,code) values(-6,30,N'هزینه',' ',2); set identity_insert moshtari off;");
			Public_Function.ExecuteNonQuery("update bank set vagozaricount=1");
			Public_Function.ExecuteNonQuery("update bank set copies=2 where id=6");
			Public_Function.ExecuteNonQuery("update dptype set name=N'فروش نقدی' where id=-1");
			Public_Function.ExecuteNonQuery("update dptype set name=N'کارت به کارت - ساتنا - پایا' where id=29");
			this.AddColumn("kharid_Sardkhane", "Darsad", "Decimal (18,1) NULL");
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0009723C File Offset: 0x0009543C
		private void Delete_SanadType()
		{
			bool flag = false;
			while (!flag)
			{
				DataTable dataTable = Public_Function.FillData("SELECT  top 5000   Sanad.ID, Code_Hesab.Name  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID WHERE     (Code_Hesab.Grouh_ID = 2) and sanadtype is not null");
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
				{
					Public_Function.ExecuteNonQuery("update sanad set sanadtype=null where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
				}
				else
				{
					flag = true;
				}
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000972A0 File Offset: 0x000954A0
		private bool UpdateSanadType()
		{
			bool flag = false;
			DataTable dataTable = Public_Function.FillData("SELECT  top 1000    Sanad.ID FROM Furush_Hag_Detail INNER JOIN Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype IS NULL)");
			bool flag2 = dataTable.Rows.Count > 0;
			bool result;
			if (flag2)
			{
				Public_Function.ExecuteNonQuery("update sanad set sanadtype=2 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
				result = true;
			}
			else
			{
				dataTable = Public_Function.FillData("SELECT top 1000    Sanad.ID FROM         Kharid_Furush INNER JOIN Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype is null)");
				flag2 = (dataTable.Rows.Count > 0);
				if (flag2)
				{
					Public_Function.ExecuteNonQuery("update sanad set sanadtype=3 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
					result = true;
				}
				else
				{
					dataTable = Public_Function.FillData("SELECT   top 1000  Sanad.ID FROM Safi_Furush  INNER JOIN Sanad ON Safi_Furush.Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype is null)");
					flag2 = (dataTable.Rows.Count > 0);
					if (flag2)
					{
						Public_Function.ExecuteNonQuery("update sanad set sanadtype=4 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
						result = true;
					}
					else
					{
						dataTable = Public_Function.FillData("SELECT   top 1000  Sanad.ID FROM         Sanad INNER JOIN Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id WHERE     (Sanad.sanadtype is null)");
						flag2 = (dataTable.Rows.Count > 0);
						if (flag2)
						{
							Public_Function.ExecuteNonQuery("update sanad set sanadtype=5 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
							result = true;
						}
						else
						{
							dataTable = Public_Function.FillData("SELECT  top 1000   Sanad.ID FROM         Sanad INNER JOIN Kharid_Sardkhane_Detail ON Sanad.ID = Kharid_Sardkhane_Detail.sanad_id where (Sanad.sanadtype is null)");
							flag2 = (dataTable.Rows.Count > 0);
							if (flag2)
							{
								Public_Function.ExecuteNonQuery("update sanad set sanadtype=6 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
								result = true;
							}
							else
							{
								dataTable = Public_Function.FillData("SELECT  top 1000   Sanad.ID FROM         Furush_Sardkhane_Detail INNER JOIN Sanad ON Furush_Sardkhane_Detail.Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype is null)");
								flag2 = (dataTable.Rows.Count > 0);
								if (flag2)
								{
									Public_Function.ExecuteNonQuery("update sanad set sanadtype=7 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
									result = true;
								}
								else
								{
									dataTable = Public_Function.FillData("SELECT  top 1000   Sanad.ID, 8 AS sanadtype FROM         ErsalBar_Detail INNER JOIN Sanad ON ErsalBar_Detail.Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype is null)");
									flag2 = (dataTable.Rows.Count > 0);
									if (flag2)
									{
										Public_Function.ExecuteNonQuery("update sanad set sanadtype=8 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
										result = true;
									}
									else
									{
										dataTable = Public_Function.FillData("SELECT  top 1000   Sanad.ID FROM         ErsalBar AS ErsalBar_1 INNER JOIN Sanad ON ErsalBar_1.Moshtari_Sanad_ID = Sanad.ID WHERE     (Sanad.sanadtype is null)");
										flag2 = (dataTable.Rows.Count > 0);
										if (flag2)
										{
											Public_Function.ExecuteNonQuery("update sanad set sanadtype=9 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
											result = true;
										}
										else
										{
											dataTable = Public_Function.FillData("SELECT   top 1000  Sanad.ID FROM         Sanad INNER JOIN  KhordeFurushi_Detail ON Sanad.ID = KhordeFurushi_Detail.Moshtari_Sanad_ID  WHERE     (Sanad.sanadtype is null)");
											flag2 = (dataTable.Rows.Count > 0);
											if (flag2)
											{
												Public_Function.ExecuteNonQuery("update sanad set sanadtype=10 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
												result = true;
											}
											else
											{
												dataTable = Public_Function.FillData("SELECT  top 1000   Sanad.ID FROM         Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID where grouh_id=2 and sanadtype is null");
												flag2 = (dataTable.Rows.Count > 0);
												if (flag2)
												{
													Public_Function.ExecuteNonQuery("update sanad set sanadtype=1 where id in (" + Public_Function.GetID(dataTable, "ID", "") + ")");
													result = true;
												}
												else
												{
													result = flag;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000975A8 File Offset: 0x000957A8
		private void Updatedp_code()
		{
			string text = string.Empty;
			DataTable dataTable = Public_Function.FillData("select id,code from dptype where [type]=1 and visible=1 order by code");
			int num = 1;
			checked
			{
				bool flag;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectNotEqual(dataRow["code"], num, false);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update dptype set code=" + Conversions.ToString(num) + " where id=", dataRow["ID"]), ";")));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				dataTable = Public_Function.FillData("select id,code from dptype where [type]=2 and visible=1 order by code");
				num = 1;
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["code"], num, false);
						if (flag)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update dptype set code=" + Conversions.ToString(num) + " where id=", dataRow2["ID"]), ";")));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					flag = (enumerator2 is IDisposable);
					if (flag)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00097774 File Offset: 0x00095974
		private void InsertTakhlieSanad()
		{
			bool flag = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
				Sanad sanad = new Sanad();
				string text = "declare @sanad_id int;";
				DataTable dataTable = Public_Function.FillData("select * from furush_keraye where keraye_pardakht_id is null and sanad_id is null and hazinekharid_id=-5");
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						text += sanad.InsertStr("18", "0", dataRow["keraye"].ToString(), dataRow["tarikh_fa"].ToString(), "بابت تخلیه", "@sanad_id", Sanad.SanadType.@null);
						text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_keraye set sanad_id=@sanad_id where id=", dataRow["id"]), ";")));
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				flag = (text.Length > 0);
				if (flag)
				{
					Public_Function.ExecuteNonQuery(text);
				}
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000978A0 File Offset: 0x00095AA0
		public void initdb2()
		{
			this.DeleteNaghdTakrari();
			this.AlterColumn("furush_darsad", "sanadbed_id", "bigint null");
			this.AddColumn("Moshtari_Hesab", "Saheb_Hesab", "nvarchar(50) NULL");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=34) insert into dptype(id,type,name,visible,Code) values(34,1,N'حقوق ماهیانه',1,11);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-5) insert into dptype(id,type,name,visible,Code) values(-5,2,N'خرید نقدی',0,NULL);");
			this.AddColumn("ErsalBar_Detail", "Keraye", "bigint null");
			this.AddColumn("ErsalBar_Detail", "Keraye_Pardakht_ID", "bigint null");
			this.AddColumn("Ersalbar", "Moshtari_Sanad_ID", "bigint null");
			this.AddColumn("ErsalBar", "Keraye_Mabda", "bigint null");
			Public_Function.ExecuteNonQuery("update dptype set visible=1 where id=34");
			this.AlterColumn("sharik", "darsad", "decimal(18,2) ");
			this.AddColumn("daryaftPardakht", "HazineKharid_ID", "int null");
			this.AddColumn("shomarehesab", "sahebcheck", "nvarchar(100)");
			this.AddColumn("furush_hag", "nahve_furush", "Int");
			this.AddColumn("kharid", "nahve_furush", "Int");
			this.AddColumn("ersalbar", "nahve_furush", "Int");
			this.AddColumn("furush_sardkhane", "nahve_furush", "Int");
			this.AddColumn("khordefurushi", "nahve_furush", "Int");
			this.AlterColumn("sanad", "tozih", "nvarchar(500) null");
			this.AddColumn("sanad", "sanadtype", "int");
			this.AlterColumn("sud", "daramadsanad_id", "int null");
			this.AlterColumn("sud", "hazinesanad_id", "int null");
			this.AddColumn("sud", "mablagh_kharid", "bigint null");
			this.AddColumn("moshtari_listsiah", "checked", "bit null");
			this.AddColumn("sud", "mablagh_sukhte", "bigint null");
			this.AddColumn("sud", "Tarikh_Kasrezafe", "datetime null");
			this.AddColumn("sud", "Mablagh_Kasrezafe", "bigint null");
			this.AddColumn("furush_hag", "noe_darsad", "smallint null");
			this.AlterColumn("Safi_Furush", "jamfurush", "bigint not null");
			this.AlterColumn("Safi_Furush", "karmozd", "bigint not null");
			this.AlterColumn("Safi_Furush", "mande", "bigint not null");
			this.AlterColumn("shomarehesab", "bank_id", "int null");
			this.AlterColumn("shomarehesab", "shobe_id", "int null");
			this.AlterColumn("Setting", "Value", "nvarchar(500) NULL");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Sardkhane_kala_to_kala]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [Furush_Sardkhane_kala_to_kala]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Furush_Sardkhane_ID] [int] NOT NULL, \t[Parent_Kala_ID] [int] NOT NULL, \t[Child_Kala_ID] [int] NOT NULL,    CONSTRAINT [PK_Furush_sardkhane_kala_to_kala] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [Furush_Sardkhane_kala_to_kala]  WITH CHECK ADD  CONSTRAINT [FK_Kala_To_Kala_Furush_Sardkhane] FOREIGN KEY([Furush_Sardkhane_ID])  REFERENCES [Furush_Sardkhane]([ID])  ON UPDATE CASCADE  ON DELETE CASCADE  ALTER TABLE [dbo].[Furush_Sardkhane_kala_to_kala] CHECK CONSTRAINT [FK_Kala_To_Kala_Furush_Sardkhane]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[sud_sukhte]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Sud_Sukhte](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Sud_ID] [int] NOT NULL,  [Moshtari_ID] [int] NOT NULL,  CONSTRAINT [PK_Sud_Sukhte] PRIMARY KEY CLUSTERED  (   [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Safi_Furush_Extend]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Safi_Furush_Extend]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Furush_ID] [int] NOT NULL, \t[safi_Type] [int] NOT NULL, \t[Mablagh] [bigint] NOT NULL, \t[Sanad_ID] [bigint] NOT NULL, \t[row_Mablagh] [nvarchar](500) NULL, CONSTRAINT [PK_Safi_Furush_Extend] PRIMARY KEY CLUSTERED   (   [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			while (this.UpdateSanadType())
			{
			}
			this.Updatedp_code();
			bool flag = Public_Function.AppType == 1 | Public_Function.AppType == 3;
			if (flag)
			{
				Public_Function.ExecuteNonQuery("update dptype set name=" + Public_Function.GetValue("فروش بار روی زمین") + " where id=28");
			}
			else
			{
				Public_Function.ExecuteNonQuery("update dptype set name=" + Public_Function.GetValue("فروش نسیه") + " where id=28");
			}
			this.AlterColumn("moshtari", "karmozd", "decimal(18,1)");
			this.AddColumn("furush_hag_detail", "kargari", "decimal(18,1)");
			this.AddColumn("furush_hag_detail", "jamkol_ba_kargari", "decimal(18,1)");
			this.AddColumn("Furush_Hag_RizBar", "mablagh_kargari", "bigint");
			this.AddColumn("kharid_detail", "mablagh_kargari", "bigint");
			this.AddColumn("kharid_furush", "kargari", "decimal(18,1)");
			this.AddColumn("kharid_furush", "jamkol_ba_kargari", "decimal(18,1)");
			this.AddColumn("daryaftpardakht", "beMoshtari_ID", "int null");
			this.InsertSandugh_Sanad();
			this.UpdateCheckSanadCode();
			this.InsertTakhlieSanad();
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Kiosk]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Furush_Kiosk](  [ID] [bigint] IDENTITY(1,1) NOT NULL,  [Furush_ID] [bigint] NULL,  [Kharid_ID] [bigint] NULL,  [furush_sardkhane_ID] [bigint] NULL,  CONSTRAINT [PK_Furush_Kiosk] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END ");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_kiosk_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN           CREATE TABLE [dbo].[Furush_kiosk_Detail](    \t[ID] [bigint] IDENTITY(1,1) NOT NULL,    \t[Furush_kiosk_ID] [bigint] NOT NULL,    \t[Tarikh] [datetime] NOT NULL,    \t[Moshtari_ID] [bigint] NOT NULL,    \t[Kala_ID] [bigint] NOT NULL,    \t[Insert_Detail_ID] [bigint] NULL,    \t[Tedad] [decimal](18, 2) NULL,    \t[Vazn_Ba_Zarf] [decimal](18, 2) NULL,    \t[Zarf] [decimal](18, 2) NULL,    \t[Vazn_Kol] [decimal](18, 2) NULL,    \t[Fee] [decimal](18,1) NULL,    \t[Jam_Kol] [decimal](18,1) NULL,    CONSTRAINT [PK_Furush_kiosk_Detail] PRIMARY KEY CLUSTERED    (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Furush_kiosk_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Furush_kiosk_Detail_Furush_Kiosk] FOREIGN KEY([Furush_kiosk_ID])  REFERENCES [dbo].[Furush_Kiosk]([ID])  ALTER TABLE [dbo].[Furush_kiosk_Detail] CHECK CONSTRAINT [FK_Furush_kiosk_Detail_Furush_Kiosk]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DasteCheck_Ebtal]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN CREATE TABLE [dbo].[DasteCheck_Ebtal](  \t[ID] [int] IDENTITY(1,1) NOT NULL,  \t[DasteCheck_ID] [int] NOT NULL,  \t[ShomareBarg] [int] NOT NULL,    [Sanad_ID] [bigint] NOT NULL, \t[Tozih] [nvarchar](200) NULL,   CONSTRAINT [PK_DasteCheck_Ebtal] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			this.AddColumn("furush_kiosk", "nahve_furush", "Int");
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x00097CF8 File Offset: 0x00095EF8
		public void Delete_checkBargashti_tekrari()
		{
			DataTable dataTable = Public_Function.FillData("select moshtari_id,count(mablagh),check_sarresid,mablagh,sh_check from daryaftpardakht  where Check_Status = 4 And parent_id Is Not null And dptype_id = 22  group by moshtari_id,check_sarresid,mablagh,sh_check  having count(mablagh)=2");
			bool flag = dataTable != null && dataTable.Rows.Count > 0;
			if (flag)
			{
				DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
				string iD = Public_Function.GetID(dataTable, "sh_check", "");
				string right = string.Empty;
				DataTable dataTable2 = Public_Function.FillData(" select * from daryaftpardakht where sh_check in (898708,919584,601131) and check_status=4 and dptype_id=22 and parent_id is not null order by sh_check ");
				try
				{
					IEnumerator enumerator = dataTable2.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = Operators.ConditionalCompareObjectEqual(dataRow["sh_check"], right, false);
						if (flag)
						{
							daryaftPardakht.DeleteDaryaftPardakhtRadif(Conversions.ToString(dataRow["id"]), "", "");
						}
						right = Conversions.ToString(dataRow["sh_check"]);
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag = (enumerator is IDisposable);
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00097E0C File Offset: 0x0009600C
		public void Update_checkStatus()
		{
			DataTable dataTable = Public_Function.FillData("select id,check_status,PardakhtCheck_ID from daryaftpardakht where pardakhtcheck_id in (select id from daryaftpardakht where check_status=1)");
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set check_status=", dataRow["check_status"]), " where id="), dataRow["pardakhtcheck_id"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag = (enumerator is IDisposable);
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x00097EEC File Offset: 0x000960EC
		private void Delete_keraye_sanad()
		{
			DataTable dataTable = Public_Function.FillData("SELECT ID,Sanad_ID  FROM Furush_Keraye  where HazineKharid_ID<>-5 and Sanad_ID is not null");
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("delete from sanad where id=", dataRow["sanad_id"]), ";")));
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_keraye set sanad_id=null where id=", dataRow["ID"]), ";")));
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x00097FC4 File Offset: 0x000961C4
		public void InitDB3()
		{
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=41) insert into dptype(id,type,name,visible,Code) values(41,1,N'دریافت چک از مشتری نقدی',1,12);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=42) insert into dptype(id,type,name,visible,Code) values(42,1,N'دریافت چک از مشتری نقدی',0,NULL);");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Hesab_Type]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Hesab_Type](  [ID] [int] NOT NULL,  [Name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_Hesab_Type] PRIMARY KEY CLUSTERED   ( [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY];  insert into Hesab_Type (ID,name) values(1,N'صندوق'); insert into Hesab_Type (ID,name) values(2,N'مشتری'); insert into Hesab_Type (ID,name) values(3,N'بانک'); insert into Hesab_Type (ID,name) values(4,N'هزینه'); insert into Hesab_Type (ID,name) values(5,N'درآمد'); END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sanad_Dasti]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Sanad_Dasti](   [ID] [bigint] IDENTITY(1,1) NOT NULL,   [dp_id] [bigint] NOT NULL,   [dorp] [int] NOT NULL,   [Tarikh] [datetime] NOT NULL,   [Tarikh_Fa] [nvarchar](10) NOT NULL,   [desc] [nvarchar](500) NULL,   CONSTRAINT [PK_Sanad_Dasti] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sanad_Dasti_Detail]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Sanad_Dasti_Detail](   [ID] [bigint] IDENTITY(1,1) NOT NULL,   [Sanad_Dasti_id] [bigint] NOT NULL,  [Hesab_Type] [int] NOT NULL,   [Sandugh_id] [bigint]  NULL,   [Moshtari_id] [bigint] NULL,   [BankHesab_ID] [bigint] NULL,   [Hazine_ID] [bigint]  NULL,   [Daramad_ID] [bigint] NULL,   [bed] [bigint] NOT NULL,   [bes] [bigint] NOT NULL,   [Sanad_ID] [bigint] NOT NULL,   [Desc] [nvarchar](500)  NULL,   CONSTRAINT [PK_Sanad_Dasti_Detail] PRIMARY KEY CLUSTERED  (  [ID] Asc  )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  ALTER TABLE [dbo].[Sanad_Dasti_Detail]  WITH CHECK ADD  CONSTRAINT [FK_Sanad_Detail_Sanad_dasti] FOREIGN KEY([Sanad_Dasti_id])  REFERENCES [dbo].[sanad_dasti]([ID])  END");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-6) insert into dptype(id,type,name,visible,Code) values(-6,1,N'سند دستی',0,NULL);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=-7) insert into dptype(id,type,name,visible,Code) values(-7,2,N'سند دستی',0,NULL);");
			this.DeleteSanad_hazfeShode();
			this.AddColumn("Kharid_Sardkhane_Keraye", "Sanad_ID", "bigint Null");
			this.AddColumn("Kharid_Sardkhane_Keraye", "Keraye_Pardakht_ID2", "int Null");
			this.AddColumn("Kharid_Keraye", "Keraye_Pardakht_ID2", "int Null");
			this.AlterColumn("Furush_Sardkhane_Safi", "jamfurush", "bigint");
			this.AlterColumn("Furush_Sardkhane_Safi", "karmozd", "bigint");
			this.AlterColumn("Furush_Sardkhane_Safi", "mande", "bigint");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=36) insert into Code_Hesab(id,Grouh_ID,name) values(36,7,N'درآمد تخلیه');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=37) insert into Code_Hesab(id,Grouh_ID,name) values(37,7,N'درآمد کارگری');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=38) insert into Code_Hesab(id,Grouh_ID,name) values(38,11,N'کارگری');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=39) insert into Code_Hesab(id,Grouh_ID,name) values(39,5,N'هزینه حقوق');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=40) insert into Code_Hesab(id,Grouh_ID,name) values(40,7,N'درآمد بار روی زمین');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=41) insert into Code_Hesab(id,Grouh_ID,name) values(41,5,N'زیان بار روی زمین');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=42) insert into Code_Hesab(id,Grouh_ID,name) values(42,5,N'اول دوره بارروی زمین');set identity_insert Code_Hesab off;");
			Public_Function.ExecuteNonQuery("update daryaftpardakht set sanadbed_id=null , sanadbes_id=null where dptype_id in(-98,-99);");
			this.AddColumn("sud", "barzamin_sanad_id", "bigint null");
			this.Update_checkStatus();
			this.Delete_keraye_sanad();
			Public_Function.ExecuteNonQuery("update dptype set name=N'دریافت نقد و چک از مشتری' where id=4");
			Public_Function.ExecuteNonQuery("update dptype set name=N'پرداخت نقد و چک به مشتری' where id=13");
			Public_Function.ExecuteNonQuery("update dptype set name=N'انتقال وجه به بانک - واریز به حساب' where id=14");
			Public_Function.ExecuteNonQuery("update dptype set name=N'بانک به صندوق - برداشت از حساب' where id=40");
			Public_Function.ExecuteNonQuery("update dptype set name=N'واگذاری چک به بانک - خواباندن چک به حساب' where id=17");
			this.Delete_checkBargashti_tekrari();
			this.AddColumn("Ersalbar", "type", "int null");
			this.AddColumn("Ersalbar", "safi_dolar", "bigint null");
			this.AddColumn("Ersalbar", "safi_dolar_sanad_id", "bigint null");
			this.AddColumn("sanad", "arztype", "int null");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=43) insert into dptype(id,type,name,visible,Code) values(43,1,N'دریافت حواله ارزی',1,13);");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=44) insert into dptype(id,type,name,visible,Code) values(44,2,N'پرداخت حواله ارزی',1,12);");
			this.AddColumn("Kharid_Sardkhane_Keraye", "moshtari_id", "int null");
			this.AddColumn("Kharid_Sardkhane_Keraye", "tozih", "nvarchar(200) null");
			this.AddColumn("sud", "mablagh_barzamin", "bigint null");
			this.AddColumn("sud", "mablagh_sud", "bigint null");
			this.AddColumn("sud", "mablagh_hazine", "bigint null");
			this.AddColumn("Kharid_Sardkhane_Detail", "sh_factor", "nvarchar(10) null");
			this.AddColumn("Kharid_Sardkhane", "type", "int null");
			this.AddColumn("Kharid_Sardkhane", "nahve_kharid", "int null");
			this.AddColumn("Kharid_Sardkhane", "nahve_furush", "int null");
			this.AddColumn("sud", "calc_sukhte", "int null");
			this.AddColumn("bank_hesab", "visible", "bit null");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Sardkhane_Furush]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Kharid_Sardkhane_Furush]( \t[ID] [int] IDENTITY(1,1) NOT NULL, \t[Kharid_Sardkhane_ID] [int] NOT NULL, \t[Moshtari_ID] [int] NOT NULL, \t[Kala_ID] [int] NOT NULL, \t[Tarikh] [date] NOT NULL, \t[Tarikh_Fa] [nvarchar](10) NOT NULL, \t[Tedad] [decimal](18, 1) NULL, \t[Vazn_Ba_Zarf] [decimal](18, 1) NULL, \t[Zarf] [decimal](18, 1) NULL, \t[Vazn_Kol] [decimal](18, 1) NOT NULL, \t[Fee] [decimal](18, 1) NOT NULL, \t[Jam_Kol] [decimal](18, 1) NOT NULL, \t[Sanad_ID] [int] NULL, \t[Daryaft_ID] [int] NULL,     CONSTRAINT [PK_Kharid_Sardkhane_Furush] PRIMARY KEY CLUSTERED    (            [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]    ) ON [PRIMARY]    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Furush_DaryaftPardakht] FOREIGN KEY([Daryaft_ID])            REFERENCES [dbo].[DaryaftPardakht]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Furush_DaryaftPardakht]    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Furush_Sanad] FOREIGN KEY([Sanad_ID])            REFERENCES [dbo].[Sanad]([ID])    ON UPDATE CASCADE    ON DELETE CASCADE    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Furush_Sanad]    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Furush_Kala] FOREIGN KEY([Kala_ID])            REFERENCES [dbo].[Kala]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Furush_Kala]    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush]  WITH CHECK ADD  CONSTRAINT [FK_Kharid_Sardkhane_Furush_Moshtari] FOREIGN KEY([Moshtari_ID])            REFERENCES [dbo].[Moshtari]([ID])    ALTER TABLE [dbo].[Kharid_Sardkhane_Furush] CHECK CONSTRAINT [FK_Kharid_Sardkhane_Furush_Moshtari]  END");
			this.DeleteColumn("Furush_Kiosk", "furush_id");
			this.DeleteColumn("Furush_Kiosk", "kharid_id");
			this.DeleteColumn("furush_kiosk", "furush_sardkhane_id");
			this.AddColumn("furush_kiosk", "tarikh", "datetime null");
			this.AddColumn("Furush_kiosk_Detail", "furush_id", "bigint null");
			this.AddColumn("Furush_kiosk_Detail", "kharid_id", "bigint null");
			this.AddColumn("Furush_kiosk_Detail", "furush_sardkhane_id", "bigint null");
			this.AddColumn("sud", "ta_tarikh", "nvarchar(10) null");
			this.AddColumn("Kharid_Detail", "moshtari_id", "bigint null");
			this.AlterColumn("kharid", "moshtari_id", "int null");
			Public_Function.ExecuteNonQuery(" if not exists(select id from dptype where id=45) insert into dptype(id,type,name,visible,Code) values(45,2,N'تخفیف',1,13);");
			Public_Function.ExecuteNonQuery("set identity_insert Code_Hesab on; if not exists(select id from Code_Hesab where id=43) insert into Code_Hesab(id,Grouh_ID,name) values(43,5,N'تخفیف به مشتری'); set identity_insert Code_Hesab off;");
			this.Add_Tarikh_Kharid();
			this.AddColumn("kharid_detail", "vazn_ba_oft", "decimal(18,1) null");
			this.AddColumn("kharid_detail", "darsad_oft", "int null");
			this.AddColumn("kharid_detail", "vazn_oft", "decimal(18,1) null");
			Public_Function.ExecuteNonQuery("IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[routines] where [ROUTINE_NAME]=" + Public_Function.GetValue("Get_Mande") + ")      exec('create  FUNCTION Get_Mande  (  @kind int  ,@id bigint  ,@kala_id bigint  )  RETURNS Int  AS  BEGIN  declare @mande as int=0  if @kind=1 begin  SELECT @mande= (select isnull(sum( Furush_Hag_RizBar.Vazn),0 ) from Furush_Hag_RizBar where Furush_Hag_RizBar.Furush_Hag_ID=Furush_Hag.ID and Furush_Hag_RizBar.Kala_ID=kala.id)  - (SELECT isnull(sum(Vazn_Kol),0)   FROM    Furush_Hag_Detail  where Furush_Hag_Detail.furush_hug_id=Furush_Hag.ID  and Furush_Hag_Detail.kala_id=Furush_Hag_RizBar.Kala_ID  )  FROM    Furush_Hag INNER JOIN   Furush_Hag_RizBar ON Furush_Hag.ID = Furush_Hag_RizBar.Furush_Hag_ID inner join kala on Furush_Hag_RizBar.kala_id=kala.id  where Furush_Hag.ID=@id and Furush_Hag_RizBar.kala_id=@kala_id   End  if @kind=2 begin  SELECT @mande= ( select isnull(sum(Kharid_Detail.Vazn_Kol),0) from Kharid_Detail where Kharid_Detail.Kharid_ID=Kharid.ID and Kharid_Detail.kala_id=Kala.ID ) -  (SELECT isnull(sum(Vazn_Kol),0)  FROM    Kharid_Furush   where Kharid_Furush.kharid_id=Kharid.id  and Kharid_Furush.kala_id=Kharid_Detail.Kala_ID)  FROM    Kharid INNER JOIN  Kharid_Detail ON Kharid.ID = Kharid_Detail.Kharid_ID INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID  where Kharid.id=@id and kala_id=@kala_id    End  return @mande  End ')  ");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sabt_Factor_Furush]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Sabt_Factor_Furush](  [ID] [bigint] IDENTITY(1,1) NOT NULL,  [Moshtari_id] [bigint] NOT NULL,  [Tarikh] [datetime] NOT NULL,  [Tarikh_Fa] [nvarchar](10) NOT NULL,  [Naghd_Daryaft_ID] [bigint]  NULL,  [Kart_Daryaft_ID] [bigint]  NULL,  CONSTRAINT [PK_Sabt_Factor_Furush] PRIMARY KEY CLUSTERED   (  [ID] Asc    )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			this.AddColumn("Kharid_Furush", "Naghd_Daryaft_ID", "int null");
			this.AddColumn("Kharid_Furush", "Be_Moshtari_DaryaftID", "int null");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Not_In_Bestankaran]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Not_In_Bestankaran](  [ID] [int] IDENTITY(1,1) NOT NULL,  [Moshtari_ID] [int] NOT NULL,  CONSTRAINT [PK_Not_In_Bestankaran] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			this.AddColumn("Furush_hag_detail", "Factor_Num", "int null");
			this.AddColumn("Kharid_Furush", "Factor_Num", "int null");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Sarbarg]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Sarbarg](  [ID] [int] IDENTITY(1,1) NOT NULL,   [name] [nvarchar](150) NOT NULL,  CONSTRAINT [PK_Sarbarg] PRIMARY KEY CLUSTERED   (  [ID] Asc  )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  ) ON [PRIMARY] END");
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
				Public_Function.GetValue("NahvePardakht_Hazine"),
				" AND column_name= ",
				Public_Function.GetValue("order"),
				")   ALTER TABLE  NahvePardakht_Hazine ADD [order] int"
			}));
			Public_Function.ExecuteNonQuery(" update NahvePardakht_Hazine set [order]=1 where id=1; update NahvePardakht_Hazine set [order]=3 where id=2; update NahvePardakht_Hazine set [order]=4 where id=3; update NahvePardakht_Hazine set [order]=2 where id=4; update NahvePardakht_Hazine set [order]=5 where id=5;");
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar(string.Concat(new string[]
			{
				"declare @a as int=0; IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name=",
				Public_Function.GetValue("Kharid_Keraye"),
				" AND column_name= ",
				Public_Function.GetValue("moshtari_id"),
				") BEGIN ALTER TABLE Kharid_Keraye ADD moshtari_id  int null  set @a=1; select @a; END"
			})));
			bool flag = num == 1;
			if (flag)
			{
				Public_Function.ExecuteNonQuery("update kharid_keraye set moshtari_id=-1 where moshtari_id is null");
			}
			this.AddColumn("Kharid_Keraye", "tozih", "nvarchar(200) null");
			Public_Function.ExecuteNonQuery("if not exists (SELECT * FROM dbo.sysobjects WHERE name ='Get_Moshtari_Mande_Info')  begin  declare @var as nvarchar(max)set @var=' create procedure Get_Moshtari_Mande_Info                                              @Moshtari_ID as bigint                                                                as begin                                                                              declare @codeHesab_id as bigint                                                                                                                                             select @codeHesab_id=CodeHesab_ID from Moshtari                                       where id=  @Moshtari_ID                                                                                                                                                     declare @bes as bigint                                                                select @bes=sum(bes) from Sanad                                                       where CodeHesab_ID=@codeHesab_id                                                                                                                                            DECLARE                                                                                  @id as bigint                                                                         ,@bed as bigint                                                                       ,@tarikh_Fa as nvarchar(10)                                                                                                                                              DECLARE cur CURSOR for                                                                select id,bed,Tarikh_Fa from Sanad                                                    where CodeHesab_ID=@codeHesab_id                                                      and bed >0                                                                                                                                                                  OPEN cur;                                                                                                                                                                   FETCH NEXT FROM cur INTO                                                               @id,@bed,@tarikh_Fa                                                                                                                                                        WHILE @@FETCH_STATUS = 0                                                                  BEGIN                                                                             \t if @bes  < @bed begin                                                                                                                                                    \t select @id as id,@tarikh_Fa as tarikh_fa ,@bed -@bes as mande,@bes as bes                                                                                                \t CLOSE cur;                                                                                                                                                               DEALLOCATE cur;                                                                       return                                                                                \t end                                                                                     set @bes = @bes - @bed                                                                   FETCH NEXT FROM cur INTO                                                                @id,@bed,@tarikh_Fa                                                             END;                                                                              CLOSE cur;                                                                            DEALLOCATE cur;                                                                        select @id as id,@tarikh_Fa as tarikh_fa ,@bed -@bes as mande,@bes as bes            end '       execute sp_executesql  @var  end");
			Public_Function.ExecuteNonQuery("if not exists  (SELECT  TC.CONSTRAINT_NAME, CC.COLUMN_NAME, CC.TABLE_NAME  FROM    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS CC ON TC.CONSTRAINT_NAME = CC.CONSTRAINT_NAME  WHERE  (TC.CONSTRAINT_TYPE = 'Unique')  and CC.TABLE_NAME='Furush_Hag'  and TC.CONSTRAINT_NAME='IX_Furush_Hag')  ALTER TABLE dbo.Furush_Hag ADD CONSTRAINT  IX_Furush_Hag UNIQUE NONCLUSTERED  (Num  ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
			Public_Function.ExecuteNonQuery("if not exists  (SELECT  TC.CONSTRAINT_NAME, CC.COLUMN_NAME, CC.TABLE_NAME  FROM    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS CC ON TC.CONSTRAINT_NAME = CC.CONSTRAINT_NAME  WHERE  (TC.CONSTRAINT_TYPE = 'Unique')  and CC.TABLE_NAME='kharid'  and TC.CONSTRAINT_NAME='IX_kharid')  ALTER TABLE dbo.kharid ADD CONSTRAINT  IX_kharid UNIQUE NONCLUSTERED  (Num  ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
			Public_Function.ExecuteNonQuery("if not exists  (SELECT  TC.CONSTRAINT_NAME, CC.COLUMN_NAME, CC.TABLE_NAME  FROM    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS CC ON TC.CONSTRAINT_NAME = CC.CONSTRAINT_NAME  WHERE  (TC.CONSTRAINT_TYPE = 'Unique')  and CC.TABLE_NAME='ErsalBar'  and TC.CONSTRAINT_NAME='IX_ErsalBar')  ALTER TABLE dbo.ErsalBar ADD CONSTRAINT  IX_ErsalBar UNIQUE NONCLUSTERED  (Num  ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
			Public_Function.ExecuteNonQuery("if not exists  (SELECT  TC.CONSTRAINT_NAME, CC.COLUMN_NAME, CC.TABLE_NAME  FROM    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS CC ON TC.CONSTRAINT_NAME = CC.CONSTRAINT_NAME  WHERE  (TC.CONSTRAINT_TYPE = 'Unique')  and CC.TABLE_NAME='Kharid_Sardkhane'  and TC.CONSTRAINT_NAME='IX_Kharid_Sardkhane')  ALTER TABLE dbo.Kharid_Sardkhane ADD CONSTRAINT  IX_Kharid_Sardkhane UNIQUE NONCLUSTERED  (Num  ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
			Public_Function.ExecuteNonQuery("if not exists  (SELECT  TC.CONSTRAINT_NAME, CC.COLUMN_NAME, CC.TABLE_NAME  FROM    INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS TC INNER JOIN  INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE AS CC ON TC.CONSTRAINT_NAME = CC.CONSTRAINT_NAME  WHERE  (TC.CONSTRAINT_TYPE = 'Unique')  and CC.TABLE_NAME='Furush_Sardkhane'  and TC.CONSTRAINT_NAME='IX_Furush_Sardkhane')  ALTER TABLE dbo.Furush_Sardkhane ADD CONSTRAINT  IX_Furush_Sardkhane UNIQUE NONCLUSTERED  (Num  ) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Kharid_Furush_DP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE dbo.Kharid_Furush_DP  \t(  \tID int NOT NULL IDENTITY (1, 1),  \tKharid_Furush_ID int NOT NULL,  \tdp_ID int NOT NULL  \t)  ON [PRIMARY]  ALTER TABLE dbo.Kharid_Furush_DP ADD CONSTRAINT  \tPK_Kharid_Furush_DP PRIMARY KEY CLUSTERED  \t(           ID  \t) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  ALTER TABLE dbo.Kharid_Furush_DP ADD CONSTRAINT  \tFK_Kharid_Furush_DP_Kharid_Furush FOREIGN KEY  \t(          Kharid_Furush_ID  \t) REFERENCES dbo.Kharid_Furush  \t(          ID  \t) ON UPDATE  NO ACTION   \t ON DELETE  CASCADE  ALTER TABLE dbo.Kharid_Furush_DP ADD CONSTRAINT  \tFK_Kharid_Furush_DP_DaryaftPardakht FOREIGN KEY  \t(          dp_ID  \t) REFERENCES dbo.DaryaftPardakht  \t(          ID  \t) ON UPDATE  NO ACTION   \t ON DELETE  CASCADE   END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Furush_Hag_Detail_DP]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE dbo.Furush_Hag_Detail_DP  \t(  \tID int NOT NULL IDENTITY (1, 1),  \tFurush_Hag_Detail_ID int NOT NULL,  \tdp_ID int NOT NULL  \t)  ON [PRIMARY]  ALTER TABLE dbo.Furush_Hag_Detail_DP ADD CONSTRAINT  \tPK_Furush_Hag_Detail_DP PRIMARY KEY CLUSTERED  \t(           ID  \t) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  ALTER TABLE dbo.Furush_Hag_Detail_DP ADD CONSTRAINT  \tFK_Furush_Hag_Detail_DP_Furush_Hag_Detail FOREIGN KEY  \t(          Furush_Hag_Detail_ID  \t) REFERENCES dbo.Furush_Hag_Detail  \t(          ID  \t) ON UPDATE  NO ACTION   \t ON DELETE  CASCADE  ALTER TABLE dbo.Furush_Hag_Detail_DP ADD CONSTRAINT  \tFK_Furush_Hag_Detail_DP_DaryaftPardakht FOREIGN KEY  \t(          dp_ID  \t) REFERENCES dbo.DaryaftPardakht  \t(          ID  \t) ON UPDATE  NO ACTION   \t ON DELETE  CASCADE   END");
			Public_Function.ExecuteNonQuery("update kharid_detail  set Kharid_Detail.moshtari_id = Kharid.moshtari_id  from Kharid_Detail  inner join kharid  on kharid_detail.kharid_id=kharid.id  where kharid_detail.moshtari_id  is null");
			Public_Function.ExecuteNonQuery("delete from sanad  where codehesab_id = 11  and id not in  (  Select karmozd_sanad_id  FROM [Safi_Furush]  inner join furush_hag  on [Safi_Furush].furush_hag_id=furush_hag.id  union all  select karmozd_sanad_id from Furush_Sardkhane_Safi where karmozd_sanad_id is not null)");
			Public_Function.ExecuteNonQuery("if exists (  SELECT id FROM dbo.sysobjects  where name='FK_Safi_Furush_Sanad')  ALTER TABLE dbo.Safi_Furush  DROP CONSTRAINT FK_Safi_Furush_Sanad");
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000985DC File Offset: 0x000967DC
		private string Create_Deleted_columns(DataRow row, bool comma)
		{
			string text = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("[", row["column_name"]), "] ["), row["data_type"]), "]"));
			bool flag = Operators.ConditionalCompareObjectEqual(row["data_type"], "nvarchar", false);
			if (flag)
			{
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("(", row["CHARACTER_MAXIMUM_LENGTH"]), ") ")));
			}
			text += " NULL";
			if (comma)
			{
				text += ", ";
			}
			return text + Environment.NewLine;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000986A4 File Offset: 0x000968A4
		private string Create_Deleted_Objects_Script(string object_name)
		{
			string text = string.Empty;
			DataTable dataTable = Public_Function.FillData("select COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH  from INFORMATION_SCHEMA.COLUMNS IC  where TABLE_NAME = " + Public_Function.GetValue(object_name) + " order by ORDINAL_POSITION");
			text = string.Concat(new string[]
			{
				" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Deleted_",
				object_name,
				"]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN   CREATE TABLE [dbo].[Deleted_",
				object_name,
				"]( "
			});
			int num = 0;
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow row = (DataRow)enumerator.Current;
						num++;
						bool flag = dataTable.Rows.Count > num;
						if (flag)
						{
							text += this.Create_Deleted_columns(row, true);
						}
						else
						{
							text += this.Create_Deleted_columns(row, false);
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag = enumerator is IDisposable;
					if (flag)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				text += " ) END";
				return text;
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000987C0 File Offset: 0x000969C0
		public void Create_Deleted_Objects()
		{
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Deleted_Objects]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Deleted_Objects](   [ID] [bigint] IDENTITY(1,1) NOT NULL, [Name] [nvarchar](100) NOT NULL,   CONSTRAINT [PK_Deleted_Objects] PRIMARY KEY CLUSTERED    (  [ID] Asc  )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]   ) ON [PRIMARY]  INSERT INTO [dbo].[Deleted_Objects]  ([Name])  VALUES('Furush_Hag') END");
			Public_Function.ExecuteNonQuery(" IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Deleted_Objects_Manual]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)  BEGIN  CREATE TABLE [dbo].[Deleted_Objects_Manual](  [ID] [bigint] IDENTITY(1,1) NOT NULL,  [deleted_object_id] [bigint] NOT NULL,  [Referenced_Table] [nvarchar](50) NOT NULL,  [Table] [nvarchar](50) NOT NULL,  [column_name] [nvarchar](50) NOT NULL,  CONSTRAINT [PK_Deleted_Objects_Manual] PRIMARY KEY CLUSTERED  (  [ID] Asc  )WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  ) ON [PRIMARY]  END");
			DataTable dataTable = Public_Function.FillData("select * from Deleted_Objects");
			string text = string.Empty;
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text += this.Create_Deleted_Objects_Script(Conversions.ToString(dataRow["name"]));
					DataTable dataTable2 = Public_Function.FillData("sp_fkeys " + Public_Function.GetValue(Conversions.ToString(dataRow["name"])));
					try
					{
						IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataRow dataRow2 = (DataRow)enumerator2.Current;
							text += this.Create_Deleted_Objects_Script(Conversions.ToString(dataRow2["fktable_name"]));
						}
					}
					finally
					{
						IEnumerator enumerator2;
						bool flag = enumerator2 is IDisposable;
						if (flag)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			DataTable dataTable3 = Public_Function.FillData("select * from Deleted_Objects_Manual");
			try
			{
				IEnumerator enumerator3 = dataTable3.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator3.Current;
					text += this.Create_Deleted_Objects_Script(Conversions.ToString(dataRow3["Referenced_Table"]));
				}
			}
			finally
			{
				IEnumerator enumerator3;
				bool flag = enumerator3 is IDisposable;
				if (flag)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			Public_Function.ExecuteNonQuery(text);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000989AC File Offset: 0x00096BAC
		private void Add_Tarikh_Kharid()
		{
			bool flag = Conversions.ToBoolean(Public_Function.ExecuteScalar("declare @a as int=0;  IF NOT EXISTS (select * from [INFORMATION_SCHEMA].[COLUMNS] where table_name='Kharid_Detail' AND column_name='tarikh' )  begin  alter table Kharid_Detail  add tarikh date null;  alter table Kharid_Detail add tarikh_fa nvarchar(10) null;  select 1 end else begin select 0 end "));
			bool flag2 = flag;
			if (flag2)
			{
				Public_Function.ExecuteNonQuery("   update Kharid_Detail set tarikh_fa=  (select tarikh_vurud from kharid  where kharid.id=kharid_detail.Kharid_ID)");
				string text = string.Empty;
				int i = 1;
				while (i > 0)
				{
					DataTable dataTable = Public_Function.FillData("select top 100 id,tarikh_fa from kharid_detail where tarikh is null");
					i = dataTable.Rows.Count;
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" update kharid_detail set tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["tarikh_fa"]))) + " where id=", dataRow["id"]), ";")));
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag2 = (enumerator is IDisposable);
						if (flag2)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					Public_Function.ExecuteNonQuery(text);
					text = string.Empty;
				}
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00098AD8 File Offset: 0x00096CD8
		private void SyncSandugh()
		{
			Public_Function.ExecuteNonQuery("update sanad set sanadtype=99 where id in (select sanadbed_id from daryaftpardakht where dptype_id=5)");
			Public_Function.ExecuteNonQuery("update sanad set sanadtype=98 where id in (select sanadbes_id from daryaftpardakht where dptype_id=16)");
			Sandugh sandugh = new Sandugh();
			DataTable dataTable = Public_Function.FillData("select * from mande_sandugh order by tarikh");
			DataTable dataTable2 = Public_Function.FillData("SELECT sum([Bed]) as bed ,sum([Bes]) as bes ,[Tarikh] ,max([Tarikh_Fa]) as Tarikh_Fa  FROM [fruitbox].[dbo].[Sanad]  where codehesab_id=1 and  sanadtype is null  group by tarikh");
			DataTable dataTable3 = Public_Function.FillData("select * from daryaftpardakht where dptype_id in (5,16)");
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			checked
			{
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						long num = Conversions.ToLong(dataRow["mande"]);
						DataRow[] array = dataTable2.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow["tarikh"]), "'")));
						bool flag = array.Length > 0;
						long num2;
						if (flag)
						{
							num2 = Conversions.ToLong(Operators.SubtractObject(array[0]["bed"], array[0]["bes"]));
						}
						else
						{
							num2 = 0L;
						}
						num -= num2;
						DataRow[] array2 = dataTable3.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow["tarikh"]), "'")));
						flag = (array2.Length > 0);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectNotEqual(array2[0]["mablagh"], num, false);
							if (flag2)
							{
								sandugh.SynckasrEzafe(Conversions.ToString(dataRow["Tarikh_fa"]));
							}
						}
						else
						{
							bool flag2 = num != 0L;
							if (flag2)
							{
								sandugh.SynckasrEzafe(Conversions.ToString(dataRow["Tarikh_fa"]));
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					bool flag2 = enumerator is IDisposable;
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00098CC8 File Offset: 0x00096EC8
		public void Initdir()
		{
			bool flag = !Directory.Exists(Application.StartupPath + "\\reports\\bank");
			if (flag)
			{
				Directory.CreateDirectory(Application.StartupPath + "\\reports\\bank");
			}
			flag = !Directory.Exists(Application.StartupPath + "\\reports\\bank\\vagozari");
			if (flag)
			{
				Directory.CreateDirectory(Application.StartupPath + "\\reports\\bank\\vagozari");
			}
			flag = !Directory.Exists(Application.StartupPath + "\\reports\\bank\\checkprint");
			if (flag)
			{
				Directory.CreateDirectory(Application.StartupPath + "\\reports\\bank\\checkprint");
			}
			flag = !Directory.Exists(Application.StartupPath + "\\reports\\bank\\variz");
			if (flag)
			{
				Directory.CreateDirectory(Application.StartupPath + "\\reports\\bank\\variz");
			}
		}
	}
}
