using System;
using System.Collections;
using System.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200002B RID: 43
	public class Furush_Keraye
	{
		// Token: 0x060002AB RID: 683 RVA: 0x00002593 File Offset: 0x00000793
		public Furush_Keraye()
		{
			this.Isanad = new Sanad();
			this.Daryaft = new DaryaftPardakht();
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00035C98 File Offset: 0x00033E98
		public void DeleteByID(string ID)
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(sanad_id,'') from Furush_Keraye where id=" + ID));
			string text2 = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(keraye_pardakht_id,'') from furush_keraye where id=" + ID));
			bool flag = Operators.CompareString(text, string.Empty, false) != 0;
			if (flag)
			{
				Sanad sanad = new Sanad();
				sanad.Delete(text);
			}
			flag = (Operators.CompareString(text2, string.Empty, false) != 0);
			if (flag)
			{
				DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
				daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(text2, "furush_keraye", "keraye_pardakht_id", ID);
			}
			Public_Function.ExecuteNonQuery("delete from furush_keraye where id=" + ID);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00035D48 File Offset: 0x00033F48
		public DataTable GetByID(int Furush_ID)
		{
			return Public_Function.FillData("SELECT     Furush_Keraye.*, Hazine_Kharid.Name AS Hazine_Kharid_Name,kala.name as Kala_Name  FROM         Furush_Keraye INNER JOIN  Hazine_Kharid ON Furush_Keraye.HazineKharid_ID = Hazine_Kharid.ID LEFT OUTER JOIN  Kala ON Furush_Keraye.Kala_ID = Kala.ID where Furush_ID=" + Conversions.ToString(Furush_ID));
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00035D70 File Offset: 0x00033F70
		public void Insert(int Furush_ID, DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Keraye(Furush_ID,Kala_ID,Tedad,Vazn_Ba_Zarf,Zarf,Vazn_Kol,Fee,Jam_Kol) VALUES(" + Conversions.ToString(Furush_ID) + ",", dataRow["Kala_ID"]), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn_Ba_Zarf"].ToString())), ","), Public_Function.GetValueInt(dataRow["Zarf"].ToString())), ","), dataRow["Vazn_Kol"]), ","), dataRow["Fee"]), ","), dataRow["Jam_Kol"]), ");")));
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

		// Token: 0x060002AF RID: 687 RVA: 0x00035F00 File Offset: 0x00034100
		private void SyncKerayePardakht(string furush_id, DataTable dt)
		{
			DataTable dataTable = Public_Function.FillData("select id,keraye_pardakht_id,keraye_pardakht_id2 from furush_keraye where furush_id=" + furush_id);
			DaryaftPardakht daryaftPardakht = new DaryaftPardakht();
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["ID"] == DBNull.Value;
					if (!flag)
					{
						DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("id=", dataRow["ID"])));
						flag = (array.Length > 0);
						if (flag)
						{
							bool flag2 = dataRow["keraye_pardakht_id2"] != DBNull.Value;
							bool flag3;
							if (flag2)
							{
								flag3 = (array[0]["keraye_pardakht_id2"] == DBNull.Value);
								if (flag3)
								{
									daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(array[0]["keraye_pardakht_id"]), "furush_keraye", "keraye_pardakht_id", Conversions.ToString(array[0]["ID"]));
									dataRow["keraye_pardakht_id"] = DBNull.Value;
									continue;
								}
							}
							flag3 = (dataRow["keraye_pardakht_id"] != DBNull.Value);
							if (flag3)
							{
								flag2 = (array[0]["keraye_pardakht_id"] == DBNull.Value);
								if (flag2)
								{
									daryaftPardakht.DeleteDaryaftPardakhtRadifExtend(Conversions.ToString(array[0]["keraye_pardakht_id2"]), "furush_keraye", "keraye_pardakht_id2", Conversions.ToString(array[0]["ID"]));
									dataRow["keraye_pardakht_id2"] = DBNull.Value;
								}
							}
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag3 = enumerator is IDisposable;
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000360E8 File Offset: 0x000342E8
		public long Sum_Mablagh(DataTable dt)
		{
			long num;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], -4, false);
					if (!flag)
					{
						flag = (dataRow["mablagh"] != DBNull.Value);
						if (flag)
						{
							num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
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
			return num;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		private bool Check_SayerAmaliyat(long id, string Tarikh)
		{
			int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(id) + " and tarikh>" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))));
			bool flag = num == 0;
			return !flag;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000361B0 File Offset: 0x000343B0
		public string UpdatePardakht(string Tarikh, string Pardakht_id, string tozih, string HazineKharid_Name, string Moshtari_ID, string HazineKharid_ID, DataTable dt)
		{
			bool flag = dt.Rows.Count == 0;
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string text = tozih;
				long num = this.Sum_Mablagh(dt);
				Sanad sanad = new Sanad();
				flag = (num > 0L);
				string text2;
				if (flag)
				{
					bool flag2 = Operators.CompareString(Pardakht_id, string.Empty, false) == 0;
					if (flag2)
					{
						text2 = string.Concat(new string[]
						{
							text2,
							"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,moshtarihesab_id) VALUES(-4,",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
							",NULL,NULL,",
							Public_Function.GetValueInt(Moshtari_ID),
							",1,",
							Conversions.ToString(this.Sum_Mablagh(dt)),
							", ",
							Public_Function.GetValue(text),
							",",
							Public_Function.GetValue(Tarikh),
							",NULL);select @keraye_pardakht_id=scope_identity();"
						});
					}
					else
					{
						text2 = string.Concat(new string[]
						{
							text2,
							"Update dbo.DaryaftPardakht SET dpType_ID=-4 ,Tarikh=",
							Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
							" ,Moshtari_ID=",
							Public_Function.GetValueInt(Moshtari_ID),
							" ,Sandug_ID=1 ,BankHesab_ID=null ,Hazine_ID=Null ,Mablagh=",
							Conversions.ToString(this.Sum_Mablagh(dt)),
							" ,Tozih=",
							Public_Function.GetValue(text),
							" ,Tarikh_Fa=",
							Public_Function.GetValue(Tarikh),
							" ,[Sh_Check] = null  ,[CheckBank_ID] = null  ,[Check_Shobe] = null  ,[Check_Sarresid] = null  ,[Check_Sarresid_Fa] = null  ,[Check_Status] =null  ,[Sh_Fish] = null  ,[FishVariz] = null  ,[FishVariz_Fa] = null  ,[PardakhtCheck_ID] = null  ,[sanadbed_id]=null  ,[sanadbes_id]=null  Where ID=",
							Pardakht_id,
							";select @keraye_pardakht_id=",
							Pardakht_id,
							";"
						});
					}
				}
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						object left = dataRow["dpType_ID"];
						bool flag2 = Operators.ConditionalCompareObjectEqual(left, 10, false);
						if (flag2)
						{
							flag = (dataRow["ID"] == DBNull.Value);
							if (flag)
							{
								text2 += sanad.InsertStr("1", "0", dataRow["Mablagh"].ToString(), Tarikh, text, "@sanadbes_id", Sanad.SanadType.@null);
								text2 = string.Concat(new string[]
								{
									text2,
									"Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Parent_ID) VALUES(10,",
									Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)),
									",null,@sanadbes_id,",
									Public_Function.GetValueInt(Moshtari_ID),
									",1,",
									dataRow["Mablagh"].ToString(),
									",NULL ,",
									Public_Function.GetValue(Tarikh),
									",@keraye_pardakht_id);"
								});
							}
							else
							{
								text2 += sanad.UpdateStr("1", Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, text, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=10 ,Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " ,Sandug_ID=1" + " ,BankHesab_ID=null" + " ,Hazine_ID=Null" + " ,Mablagh=" + dataRow["Mablagh"].ToString() + " ,Tozih=" + Public_Function.GetValue(text) + " ,Tarikh_Fa=" + Public_Function.GetValue(Tarikh) + " ,[Sh_Check] = null " + " ,[CheckBank_ID] = null " + " ,[Check_Shobe] = null " + " ,[Check_Sarresid] = null " + " ,[Check_Sarresid_Fa] = null " + " ,[Check_Status] =null " + " ,[Sh_Fish] = null " + " ,[FishVariz] = null " + " ,[FishVariz_Fa] = null " + " ,[PardakhtCheck_ID] = null " + " Where ID=", dataRow["ID"]), ";")));
							}
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(left, 11, false);
							if (flag2)
							{
								flag = (dataRow["ID"] == DBNull.Value);
								if (flag)
								{
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,Check_Sarresid,Check_Sarresid_Fa,CheckBarg_ID,BankHesab_ID,Check_Status,Parent_ID,HazineKharid_ID) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(text)), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValueInt(dataRow["CheckBarg_ID"].ToString())), ","), Public_Function.GetValue(dataRow["BankHesab_ID"].ToString())), ",5,@keraye_pardakht_id,"), HazineKharid_ID), ");")));
								}
								else
								{
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), " ,Sandug_ID="), Public_Function.GetValueInt(dataRow["Sandug_ID"].ToString())), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(text)), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,CheckBarg_ID="), Public_Function.GetValueInt(dataRow["CheckBarg_ID"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,BankHesab_ID= "), Public_Function.GetValueInt(dataRow["BankHesab_ID"].ToString())), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " ,HazineKharid_ID="), HazineKharid_ID), " Where ID="), dataRow["ID"]), ";")));
									flag2 = !this.Check_SayerAmaliyat(Conversions.ToLong(dataRow["ID"]), Tarikh);
									if (flag2)
									{
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dataRow["ID"]), ";")));
									}
								}
							}
							else
							{
								flag2 = Operators.ConditionalCompareObjectEqual(left, 12, false);
								if (flag2)
								{
									flag = (dataRow["ID"] == DBNull.Value);
									if (flag)
									{
										tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("پرداخت چک ", dataRow["checkbank_name"]), " "), dataRow["check_shobe"]), " به شماره "), dataRow["sh_check"]), " به سررسید "), dataRow["check_sarresid_fa"]));
										text2 += sanad.InsertStr(Conversions.ToString(1), Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, tozih, Sanad.SanadType.@null);
										text2 += "select @sanadbes_id=scope_identity();";
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,SanadBed_ID,SanadBes_ID,Moshtari_ID,Sandug_ID,Mablagh,Tozih,Tarikh_Fa,Sh_Check,CheckBank_ID,Check_Shobe,Check_Sarresid,Check_Sarresid_Fa,Check_ShomareHesab,Check_Status,PardakhtCheck_ID,Parent_ID,HazineKharid_ID) VALUES(", dataRow["dptype_id"]), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), ",NULL,NULL,"), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), ",1,"), dataRow["Mablagh"]), ","), Public_Function.GetValue(text)), ","), Public_Function.GetValue(Tarikh)), ","), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), ","), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), ","), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Check_Sarresid_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Check_Sarresid_Fa"]))), ","), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), ",5,"), Public_Function.GetValueInt(dataRow["PardakhtCheck_ID"].ToString())), ",@keraye_pardakht_id,"), Public_Function.GetValueInt(HazineKharid_ID)), ");")));
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dataRow["PardakhtCheck_ID"]), ";")));
									}
									else
									{
										text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=", dataRow["dpType_ID"]), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh))), " ,Moshtari_ID="), Public_Function.GetValueInt(dataRow["Moshtari_ID"].ToString())), " ,Sandug_ID="), Public_Function.GetValueInt(Conversions.ToString(dataRow["Sandug_ID"]))), " ,BankHesab_ID=null"), " ,Hazine_ID=Null"), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(text)), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,Sh_Check="), Public_Function.GetValue(dataRow["Sh_Check"].ToString())), " ,[CheckBank_ID] = "), Public_Function.GetValueInt(dataRow["CheckBank_ID"].ToString())), " ,Check_Shobe="), Public_Function.GetValue(dataRow["Check_Shobe"].ToString())), " ,Check_Sarresid="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Check_Sarresid_Fa"].ToString()))), " ,Check_Sarresid_Fa="), Public_Function.GetValue(dataRow["Check_Sarresid_Fa"].ToString())), " ,Check_ShomareHesab="), Public_Function.GetValue(dataRow["Check_ShomareHesab"].ToString())), " ,Check_status=5"), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = "), dataRow["PardakhtCheck_ID"]), " ,HazineKharid_ID="), HazineKharid_ID), " Where ID="), dataRow["ID"]), ";")));
										flag2 = !this.Check_SayerAmaliyat(Conversions.ToLong(dataRow["PardakhtCheck_ID"]), Tarikh);
										if (flag2)
										{
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(" update dbo.DaryaftPardakht set check_status=5 where id=", dataRow["PardakhtCheck_ID"]), ";")));
										}
									}
								}
								else
								{
									flag2 = Operators.ConditionalCompareObjectEqual(left, 29, false);
									if (flag2)
									{
										flag = (dataRow["ID"] == DBNull.Value);
										if (flag)
										{
											tozih = text + " / کارت به کارت ";
											flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
											if (flag2)
											{
												tozih = Conversions.ToString(Operators.ConcatenateObject(tozih, Operators.ConcatenateObject(" به شماره پیگیری ", dataRow["tozih"])));
											}
											string codeHesab_ID = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
											{
												Operators.ConcatenateObject("select codehesab_mojodi from bank_hesab where id=", dataRow["bankHesab_ID"])
											}, null, null, null));
											text2 += sanad.InsertStr(codeHesab_ID, "0", dataRow["Mablagh"].ToString(), Tarikh, tozih, "@sanadbes_id", Sanad.SanadType.@null);
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.DaryaftPardakht(dpType_ID,Tarikh,sanadbed_id,sanadbes_id,hazineKharid_id,BankHesab_ID,Mablagh,Tozih,Tarikh_Fa,Parent_id) VALUES(29," + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + ",null,@sanadbes_id" + "," + HazineKharid_ID.ToString() + ",", dataRow["bankHesab_ID"]), ","), dataRow["Mablagh"]), ","), Public_Function.GetValue(dataRow["Tozih"].ToString())), ","), Public_Function.GetValue(Tarikh)), ",@keraye_pardakht_id);")));
										}
										else
										{
											tozih = text + " / کارت به کارت ";
											flag2 = (dataRow["tozih"] != DBNull.Value && Operators.ConditionalCompareObjectNotEqual(dataRow["tozih"], string.Empty, false));
											if (flag2)
											{
												tozih = Conversions.ToString(Operators.ConcatenateObject(tozih, Operators.ConcatenateObject(" به شماره پیگیری ", dataRow["tozih"])));
											}
											string codeHesab_ID2 = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
											{
												Operators.ConcatenateObject("select codehesab_mojodi from bank_hesab where id=", dataRow["bankHesab_ID"])
											}, null, null, null));
											text2 += sanad.UpdateStr(codeHesab_ID2, Conversions.ToString(0), Conversions.ToString(dataRow["Mablagh"]), Tarikh, tozih, Conversions.ToString(dataRow["SanadBes_ID"]), Sanad.SanadType.@null);
											text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.DaryaftPardakht SET dpType_ID=29 ,Tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(Tarikh)) + " ,BankHesab_ID=", dataRow["bankhesab_id"]), " ,HazineKharid_ID="), Public_Function.GetValueInt(HazineKharid_ID)), " ,Mablagh="), dataRow["Mablagh"]), " ,Tozih="), Public_Function.GetValue(dataRow["Tozih"].ToString())), " ,Tarikh_Fa="), Public_Function.GetValue(Tarikh)), " ,[Sh_Check] = null "), " ,[CheckBank_ID] = null "), " ,[Check_Shobe] = null "), " ,[Check_Sarresid] = null "), " ,[Check_Sarresid_Fa] = null "), " ,[Check_Status] =null "), " ,[Sh_Fish] = null "), " ,[FishVariz] = null "), " ,[FishVariz_Fa] = null "), " ,[PardakhtCheck_ID] = null "), " Where ID="), dataRow["ID"]), ";")));
										}
									}
								}
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
				result = text2;
			}
			return result;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0003739C File Offset: 0x0003559C
		public void Update(int Furush_ID, DataTable dt)
		{
			bool flag = dt != null;
			if (flag)
			{
				this.SyncKerayePardakht(Conversions.ToString(Furush_ID), dt);
			}
			Sanad sanad = new Sanad();
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select num from Furush_Hag where id=" + Conversions.ToString(Furush_ID)));
			int num = -999;
			string moshtari_ID = Conversions.ToString(Public_Function.ExecuteScalar("select Moshtari_ID from Furush_Hag where id=" + Conversions.ToString(Furush_ID)));
			string iD = Public_Function.GetID(dt, "ID", "");
			string text2 = "declare @keraye_pardakht_id int;declare @sanadbed_id int;declare @sanadbes_id int;declare @sanad_id int;declare @parent_id int;";
			flag = (iD.Length > 0);
			if (flag)
			{
				text2 = string.Concat(new string[]
				{
					text2,
					"Delete From dbo.Furush_Keraye Where Furush_ID=",
					Conversions.ToString(Furush_ID),
					" AND ID NOT IN(",
					iD,
					");"
				});
			}
			else
			{
				text2 = text2 + "Delete From dbo.Furush_Keraye Where Furush_ID=" + Conversions.ToString(Furush_ID) + ";";
			}
			flag = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag)
			{
				num = -5;
			}
			flag = (dt != null);
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						string tozih = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["hazine_kharid_Name"], " "), "سند فروش شماره "), text));
						flag = (dataRow["Tarikh_Fa"] == DBNull.Value);
						if (flag)
						{
							dataRow["Tarikh_Fa"] = Public_Function.MiladiToShamsi(DateAndTime.Now);
						}
						flag = (dataRow["ID"] == DBNull.Value);
						if (flag)
						{
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow["hazinekharid_id"], num, false);
							if (flag2)
							{
								text2 += sanad.InsertStr("18", "0", dataRow["keraye"].ToString(), dataRow["Tarikh_Fa"].ToString(), "تخلیه سند شماره " + text, "@sanad_id", Sanad.SanadType.@null);
							}
							else
							{
								text2 += "select @sanad_id=NULL;";
							}
							flag2 = (dataRow["dt"] != DBNull.Value);
							DataTable dataTable;
							if (flag2)
							{
								dataTable = (DataTable)dataRow["dt"];
							}
							else
							{
								dataTable = null;
							}
							flag2 = (dataTable == null || dataTable.Rows.Count == 0);
							if (flag2)
							{
								flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], -6, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], num, false));
								if (flag)
								{
									text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_حق_العمل, "");
									text2 += "select @keraye_pardakht_id=scope_identity();";
								}
								else
								{
									text2 += "select  @keraye_pardakht_id=NULL;";
								}
							}
							else
							{
								text2 += this.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID2"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), moshtari_ID, Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Insert Into dbo.Furush_Keraye(Furush_ID,HazineKharid_ID,Kala_ID,Tedad,Vazn,Keraye,Tarikh,Tarikh_Fa,Keraye_Pardakht_ID,sanad_id) VALUES(" + Conversions.ToString(Furush_ID) + ",", dataRow["HazineKharid_ID"]), ","), Public_Function.GetValueInt(dataRow["Kala_ID"].ToString())), ","), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), ","), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), ","), Public_Function.GetValueInt(dataRow["keraye"].ToString())), ","), Public_Function.GetValue(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["Tarikh_Fa"])))), ","), Public_Function.GetValue(Conversions.ToString(dataRow["Tarikh_Fa"]))), ",@keraye_pardakht_id,@sanad_id);")));
						}
						else
						{
							flag2 = Operators.ConditionalCompareObjectEqual(dataRow["hazinekharid_id"], num, false);
							if (flag2)
							{
								flag = (dataRow["sanad_id"] != DBNull.Value);
								if (flag)
								{
									text2 += sanad.UpdateStr("18", Conversions.ToString(0), Conversions.ToString(dataRow["keraye"]), Conversions.ToString(dataRow["Tarikh_Fa"]), "تخلیه سند شماره " + text, Conversions.ToString(dataRow["sanad_id"]), Sanad.SanadType.@null);
								}
								else
								{
									text2 += sanad.InsertStr("18", "0", dataRow["keraye"].ToString(), dataRow["Tarikh_Fa"].ToString(), "تخلیه سند شماره " + text, "@sanad_id", Sanad.SanadType.@null);
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_keraye set sanad_id=@sanad_id where id=", dataRow["ID"]), ";")));
								}
							}
							else
							{
								flag2 = (dataRow["sanad_id"] != DBNull.Value);
								if (flag2)
								{
									text2 = text2 + sanad.DeleteStr(Conversions.ToString(dataRow["sanad_id"])) + ";";
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update Furush_Keraye set sanad_id=null where id=", dataRow["ID"]), ";")));
								}
								text2 += "select @sanad_id=NULL;";
							}
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && (Operators.ConditionalCompareObjectEqual(dataRow["HazineKharid_ID"], -6, false) || Operators.ConditionalCompareObjectEqual(dataRow["HazineKharid_ID"], num, false)));
							if (flag2)
							{
								this.Daryaft.DeleteDaryaftPardakhtRadif(dataRow["keraye_pardakht_id"].ToString(), Conversions.ToString(dataRow["ID"]), "");
							}
							flag2 = (dataRow["Keraye_Pardakht_ID"] == DBNull.Value && dataRow["Keraye_Pardakht_ID2"] == DBNull.Value);
							if (flag2)
							{
								flag = (Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], -6, false) && Operators.ConditionalCompareObjectNotEqual(dataRow["hazinekharid_id"], num, false));
								if (flag)
								{
									text2 += this.Daryaft.AddRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, DaryaftPardakht.dptype_ID.پرداخت_کرایه, DaryaftPardakht.CodeHesab.کرایه_حق_العمل, "");
									text2 += "select @keraye_pardakht_id=scope_identity();";
									text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject("update furush_keraye set keraye_pardakht_id=@keraye_pardakht_id where id=", dataRow["ID"]), ";")));
								}
							}
							string text3 = dataRow["Keraye_Pardakht_ID"].ToString();
							flag2 = (dataRow["dt"] != DBNull.Value);
							DataTable dataTable;
							if (flag2)
							{
								dataTable = (DataTable)dataRow["dt"];
							}
							else
							{
								dataTable = null;
							}
							flag2 = (Operators.CompareString(text3, string.Empty, false) != 0 && dataTable != null && dataTable.Rows.Count > 1);
							if (flag2)
							{
								text2 += this.UpdatePardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), dataRow["Keraye_Pardakht_ID"].ToString(), tozih, dataRow["hazine_kharid_name"].ToString(), moshtari_ID, Conversions.ToString(dataRow["HazineKharid_ID"]), dataTable);
							}
							flag2 = (Operators.CompareString(text3, string.Empty, false) != 0 && dataTable == null);
							if (flag2)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update daryaftpardakht set mablagh=", dataRow["keraye"]), " where id="), text3)));
							}
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("Update dbo.Furush_Keraye SET Kala_ID=" + Public_Function.GetValueInt(dataRow["Kala_ID"].ToString()) + " ,hazinekharid_id=", dataRow["HazineKharid_ID"]), " ,Tedad="), Public_Function.GetValueInt(dataRow["Tedad"].ToString())), " ,Vazn="), Public_Function.GetValueInt(dataRow["Vazn"].ToString())), " ,Keraye="), Public_Function.GetValueInt(dataRow["Keraye"].ToString())), " ,Tarikh="), Public_Function.GetValue(Public_Function.ShamsiToMiladi(dataRow["Tarikh_Fa"].ToString()))), " ,Tarikh_Fa="), Public_Function.GetValue(dataRow["Tarikh_Fa"].ToString())), " ,Keraye_Pardakht_Id2="), Public_Function.GetValueInt(dataRow["Keraye_Pardakht_Id2"].ToString())), " Where ID="), dataRow["ID"]), ";")));
							flag2 = (dataRow["Keraye_Pardakht_ID"] != DBNull.Value && dataTable != null && dataTable.Rows.Count > 1);
							if (flag2)
							{
								text2 += this.Daryaft.UpdateRowStrToPardakht(Conversions.ToString(dataRow["Tarikh_Fa"]), Conversions.ToString(dataRow["keraye"]), dataRow["hazine_kharid_name"].ToString() + " سند شماره " + text, moshtari_ID, Conversions.ToString(dataRow["Keraye_Pardakht_ID"]), DaryaftPardakht.dptype_ID.پرداخت_کرایه_کارت, DaryaftPardakht.CodeHesab.کرایه_حق_العمل);
							}
						}
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
			}
			flag2 = (text2.Length > 0);
			if (flag2)
			{
				Public_Function.ExecuteNonQuery(text2);
			}
		}

		// Token: 0x04000111 RID: 273
		private Sanad Isanad;

		// Token: 0x04000112 RID: 274
		private DaryaftPardakht Daryaft;
	}
}
