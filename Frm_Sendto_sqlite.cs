using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200010F RID: 271
	[DesignerGenerated]
	public partial class Frm_Sendto_sqlite : Form
	{
		// Token: 0x06002705 RID: 9989 RVA: 0x00009B12 File Offset: 0x00007D12
		[DebuggerNonUserCode]
		public Frm_Sendto_sqlite()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Sendto_sqlite_KeyDown);
			Frm_Sendto_sqlite.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002706 RID: 9990 RVA: 0x001D8E64 File Offset: 0x001D7064
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Sendto_sqlite.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Sendto_sqlite.__ENCList.Count == Frm_Sendto_sqlite.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Sendto_sqlite.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Sendto_sqlite.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Sendto_sqlite.__ENCList[num] = Frm_Sendto_sqlite.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Sendto_sqlite.__ENCList.RemoveRange(num, Frm_Sendto_sqlite.__ENCList.Count - num);
						Frm_Sendto_sqlite.__ENCList.Capacity = Frm_Sendto_sqlite.__ENCList.Count;
					}
					Frm_Sendto_sqlite.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x001D9620 File Offset: 0x001D7820
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00009B3E File Offset: 0x00007D3E
		internal virtual UIGroupBox UiGroupBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox1 = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x001D9638 File Offset: 0x001D7838
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x001D9650 File Offset: 0x001D7850
		internal virtual UIButton UiButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton1_Click);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
				}
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x001D96B0 File Offset: 0x001D78B0
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00009B48 File Offset: 0x00007D48
		internal virtual PanelEx PanelEx2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx2 = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x001D96C8 File Offset: 0x001D78C8
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00009B52 File Offset: 0x00007D52
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x001D96E0 File Offset: 0x001D78E0
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00009B5C File Offset: 0x00007D5C
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x001D96F8 File Offset: 0x001D78F8
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x00009B66 File Offset: 0x00007D66
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x001D9710 File Offset: 0x001D7910
		private SQLiteConnection GetSQLiteConnection(string pDataBaseName)
		{
			SQLiteConnection.CreateFile(pDataBaseName);
			return new SQLiteConnection
			{
				ConnectionString = string.Format("Data Source='{0}';Version=3;", pDataBaseName)
			};
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x001D9744 File Offset: 0x001D7944
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Application.DoEvents();
			this.UiButton1.Enabled = false;
			this.PanelEx2.Visible = true;
			this.Refresh();
			SQLiteConnection sQLiteConnection = this.GetSQLiteConnection(string.Concat(new string[]
			{
				"C:\\Users\\Administrator\\Desktop\\tazminandroid-",
				Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", ""),
				"-",
				Conversions.ToString(DateAndTime.Hour(DateAndTime.Now)),
				Conversions.ToString(DateAndTime.Minute(DateAndTime.Now)),
				".db"
			}));
			sQLiteConnection.Open();
			this.CreateTables(sQLiteConnection);
			string text = string.Empty;
			string text2 = " select id from code_hesab where grouh_id=2 ";
			text = " SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE Sanad.CodeHesab_ID in (" + text2 + ")    UNION all ";
			text = text + "  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE Sanad.CodeHesab_ID IN (" + text2 + ")   union all ";
			text = string.Concat(new string[]
			{
				text,
				" SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, NULL AS Tedad, NULL AS Vazn_Kol, NULL AS Fee, NULL AS ba_zarf, 1 AS sanadtype, - 1 AS printcount, DaryaftPardakht.PardakhtCheck_ID,  DaryaftPardakht_1.ID AS Check_ID, 1 AS calc  FROM         Sanad LEFT OUTER JOIN  DaryaftPardakht ON Sanad.ID = DaryaftPardakht.SanadBed_ID LEFT OUTER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON Sanad.ID = DaryaftPardakht_1.SanadBes_ID  WHERE     (Sanad.CodeHesab_ID IN( ",
				text2,
				"))  AND ((Sanad.sanadtype is null) OR (sanad.sanadtype =1))   union all  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS kala_name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, t.Tedad, t.vazn_kol, NULL AS Fee,t.ba_zarf as ba_zarf,4 as SanadType,Safi_Furush_1.printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc  FROM         Safi_Furush AS Safi_Furush_1 INNER JOIN  Sanad ON Safi_Furush_1.Sanad_ID = Sanad.ID INNER JOIN  (SELECT     Safi_Furush.ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Kol) AS vazn_kol,SUM(Furush_Hag_Detail.vazn_ba_zarf) AS ba_zarf  FROM         Safi_Furush INNER JOIN  Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN  Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID   GROUP BY Safi_Furush.ID) AS t ON Safi_Furush_1.ID = t.ID  union all  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, Kharid_Detail.Vazn_Ba_Zarf AS ba_zarf, 5 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc  FROM         Sanad INNER JOIN  Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID  union all  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Sardkhane_Detail.Tedad, Kharid_Sardkhane_Detail.Vazn_Kol, Kharid_Sardkhane_Detail.Fee, Kharid_Sardkhane_Detail.Vazn_Ba_Zarf AS ba_zarf, 6 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc  FROM         Sanad INNER JOIN  Kharid_Sardkhane_Detail ON Sanad.ID = Kharid_Sardkhane_Detail.sanad_id INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid_Sardkhane ON Kharid_Sardkhane_Detail.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID    union all SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Kol,Furush_Sardkhane_Detail.fee,vazn_ba_zarf as ba_zarf,7 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc    FROM         Kala INNER JOIN    Furush_Sardkhane_Detail ON Kala.ID = Furush_Sardkhane_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Sardkhane_Detail.Sanad_ID = Sanad.ID    union all SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, ErsalBar_Detail.Tedad, ErsalBar_Detail.Vazn_Kol, ErsalBar_Detail.Fee,  ErsalBar_Detail.Vazn_Ba_Zarf AS ba_zarf, 8 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc  FROM         Kala INNER JOIN  ErsalBar_Detail ON Kala.ID = ErsalBar_Detail.Kala_ID INNER JOIN  Sanad ON ErsalBar_Detail.Sanad_ID = Sanad.ID  WHERE     (Sanad.CodeHesab_ID IN (",
				text2,
				"))  UNION ALL  SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, t.Kala_Name,Sanad.Bed AS rembed, Sanad.Bes AS rembes, t.Tedad,  null as vazn_kol,null as fee,t.Vazn_Ba_Zarf as ba_zarf,9 AS sanadtype,  - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc  FROM         (SELECT     ErsalBar.ID, dbo.getersalbar_kala(ErsalBar.ID) AS Kala_Name, SUM(ErsalBar_Detail.Tedad) AS Tedad, SUM(ErsalBar_Detail.Vazn_Ba_Zarf)   AS Vazn_Ba_Zarf   FROM         ErsalBar_Detail INNER JOIN   ErsalBar ON ErsalBar_Detail.ErsalBar_ID = ErsalBar.ID   GROUP BY ErsalBar.ID) AS t INNER JOIN  ErsalBar AS ErsalBar_1 ON t.ID = ErsalBar_1.ID INNER JOIN  Sanad ON ErsalBar_1.Moshtari_Sanad_ID = Sanad.ID  union all SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, KhordeFurushi_Detail.Tedad, KhordeFurushi_Detail.Vazn_Kol, KhordeFurushi_Detail.Fee, KhordeFurushi_Detail.Vazn_Ba_Zarf AS ba_zarf,   10 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc  FROM         KhordeFurushi_Detail INNER JOIN    Kala ON KhordeFurushi_Detail.Kala_ID = Kala.ID INNER JOIN Sanad ON KhordeFurushi_Detail.Moshtari_Sanad_ID = Sanad.ID  where (Sanad.CodeHesab_ID IN( ",
				text2,
				"))   ORDER BY CodeHesab_ID,sanad.Tarikh,sanadtype "
			});
			DataTable dataTable = Public_Function.FillData(text);
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["kala_name"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 1, false);
						if (flag2)
						{
							string[] array = dataRow["Kala_Name"].ToString().Split(new char[]
							{
								'-'
							});
							flag2 = (array.Length == 3);
							if (flag2)
							{
								DataRow dataRow2 = dataRow;
								DataRow arg_204_0 = dataRow2;
								string columnName = "Tozih";
								arg_204_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " / " + array[0]);
								flag2 = (Operators.CompareString(array[1], string.Empty, false) != 0);
								if (flag2)
								{
									dataRow["Tedad"] = array[1].ToString();
								}
								flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
								if (flag2)
								{
									dataRow["Vazn_Kol"] = array[2].ToString();
								}
								continue;
							}
						}
						flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["sanadtype"], 5, false);
						if (flag2)
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_2C6_0 = dataRow2;
							string columnName = "Tozih";
							arg_2C6_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" / ", dataRow["kala_Name"]));
						}
					}
					else
					{
						string[] array = dataRow["Tozih"].ToString().Split(new char[]
						{
							'-'
						});
						bool flag2 = array.Length == 4;
						if (flag2)
						{
							dataRow["Tozih"] = array[0] + " - " + array[1];
							dataRow["Kala_Name"] = array[1].ToString();
							flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
							if (flag2)
							{
								flag = Versioned.IsNumeric(array[2].ToString());
								if (flag)
								{
									dataRow["Tedad"] = array[2].ToString();
								}
							}
							flag2 = Versioned.IsNumeric(array[3].ToString());
							if (flag2)
							{
								flag = (Operators.CompareString(array[3], string.Empty, false) != 0);
								if (flag)
								{
									dataRow["Vazn_Kol"] = array[3].ToString();
								}
							}
							flag2 = (dataRow["Vazn_Kol"] != DBNull.Value);
							if (flag2)
							{
								dataRow["fee"] = Operators.DivideObject(dataRow["bed"], dataRow["Vazn_Kol"]);
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
			dataTable.Columns.Add("mande", typeof(long));
			dataTable.Columns.Add("stat", typeof(string));
			long num = 0L;
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow3 = (DataRow)enumerator2.Current;
					bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow3["codehesab_id"], num, false);
					long num2;
					if (flag2)
					{
						num2 = 0L;
						num = Conversions.ToLong(dataRow3["codehesab_id"]);
					}
					num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow3["bed"]));
					num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow3["bes"]));
					dataRow3["mande"] = Math.Abs(num2);
					flag2 = (num2 > 0L);
					if (flag2)
					{
						dataRow3["stat"] = "بد";
					}
					else
					{
						flag2 = (num2 < 0L);
						if (flag2)
						{
							dataRow3["stat"] = "بس";
						}
						else
						{
							dataRow3["stat"] = "ت";
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				bool flag2 = enumerator2 is IDisposable;
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			SQLiteCommand sQLiteCommand = new SQLiteCommand(sQLiteConnection);
			SQLiteTransaction sQLiteTransaction = sQLiteConnection.BeginTransaction();
			string commandText = string.Empty;
			sQLiteCommand.CommandText = commandText;
			sQLiteCommand.ExecuteNonQuery();
			try
			{
				IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					DataRow dataRow4 = (DataRow)enumerator3.Current;
					commandText = string.Concat(new string[]
					{
						" insert into moshtari_hesab (tarikh,tozih,tedad,ba_zarf,vazn_kol,fee,bed,bes,mande,stat) values(",
						this.GetValue(dataRow4["tarikh_fa"].ToString()),
						",",
						this.GetValue(dataRow4["tozih"].ToString()),
						",",
						this.GetValueInt(dataRow4["tedad"].ToString()),
						",",
						this.GetValueInt(dataRow4["ba_zarf"].ToString()),
						",",
						this.GetValueInt(dataRow4["vazn_kol"].ToString()),
						",",
						this.GetValueInt(dataRow4["fee"].ToString()),
						",",
						this.GetValueInt(dataRow4["bed"].ToString()),
						",",
						this.GetValueInt(dataRow4["bes"].ToString()),
						",",
						this.GetValueInt(dataRow4["mande"].ToString()),
						",",
						this.GetValue(Conversions.ToString(dataRow4["stat"])),
						");"
					});
					sQLiteCommand.CommandText = commandText;
					sQLiteCommand.ExecuteNonQuery();
					commandText = string.Empty;
				}
			}
			finally
			{
				IEnumerator enumerator3;
				bool flag2 = enumerator3 is IDisposable;
				if (flag2)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			sQLiteTransaction.Commit();
			this.UiButton1.Enabled = true;
			this.PanelEx2.Visible = false;
			this.Refresh();
			Public_Function.ShowMessage("اطلاعات با موفقیت ذخیره شد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x001D9FDC File Offset: 0x001D81DC
		private void CreateTables(SQLiteConnection cnn)
		{
			string commandText = string.Empty;
			SQLiteCommand sQLiteCommand = new SQLiteCommand(cnn);
			SQLiteTransaction sQLiteTransaction = cnn.BeginTransaction();
			commandText = "CREATE TABLE [moshtari_hesab](  [tarikh] VARCHAR NOT NULL,  [tozih] VARCHAR,  [tedad] INT,  [ba_zarf] DECIMAL,  [vazn_kol] DECIMAL,  [fee] BIGINT,  [bed] BIGINT,  [bes] BIGINT,  [mande] BIGINT,  [stat] VARCHAR);";
			sQLiteCommand.CommandText = commandText;
			sQLiteCommand.ExecuteNonQuery();
			sQLiteTransaction.Commit();
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x001DA01C File Offset: 0x001D821C
		private string GetValue(string s)
		{
			bool flag = Operators.CompareString(s, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = "NULL";
			}
			else
			{
				result = "'" + s + "'";
			}
			return result;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x001DA060 File Offset: 0x001D8260
		private string GetValueInt(string s)
		{
			bool flag = Operators.CompareString(s, string.Empty, false) == 0;
			string result;
			if (flag)
			{
				result = "NULL";
			}
			else
			{
				flag = (Operators.CompareString(s.ToLower(), "true", false) == 0);
				if (flag)
				{
					result = Conversions.ToString(1);
				}
				else
				{
					flag = (Operators.CompareString(s.ToLower(), "false", false) == 0);
					if (flag)
					{
						result = Conversions.ToString(0);
					}
					else
					{
						result = s;
					}
				}
			}
			return result;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Sendto_sqlite_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x04000F3D RID: 3901
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F3F RID: 3903
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F40 RID: 3904
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000F41 RID: 3905
		[AccessedThroughProperty("PanelEx2")]
		private PanelEx _PanelEx2;

		// Token: 0x04000F42 RID: 3906
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x04000F43 RID: 3907
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F44 RID: 3908
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;
	}
}
