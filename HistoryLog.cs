using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000054 RID: 84
	public class HistoryLog
	{
		// Token: 0x060003A9 RID: 937 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public HistoryLog()
		{
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0004D9F4 File Offset: 0x0004BBF4
		// (set) Token: 0x060003AB RID: 939 RVA: 0x000028BD File Offset: 0x00000ABD
		public List<TableItemChange> TableItems
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableItems;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TableItems = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0004DA0C File Offset: 0x0004BC0C
		// (set) Token: 0x060003AD RID: 941 RVA: 0x000028C7 File Offset: 0x00000AC7
		public string TableName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TableName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._TableName = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0004DA24 File Offset: 0x0004BC24
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000028D1 File Offset: 0x00000AD1
		public string Pkey
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pkey;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pkey = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0004DA3C File Offset: 0x0004BC3C
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x000028DB File Offset: 0x00000ADB
		public string Ext1ColumnName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Ext1ColumnName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Ext1ColumnName = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0004DA54 File Offset: 0x0004BC54
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x000028E5 File Offset: 0x00000AE5
		public string Ext2ColumnName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Ext2ColumnName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Ext2ColumnName = value;
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0004DA6C File Offset: 0x0004BC6C
		public void GetChenges(DataTable OriginTabl, DataTable ChangedTable)
		{
			Public_Function.CurrentData.Username = "admin";
			HistoryLog historyLog = new HistoryLog();
			OriginTabl.TableName = "orig";
			ChangedTable.TableName = "changed";
			DataSet dataSet = new DataSet();
			dataSet.Tables.Add(OriginTabl);
			dataSet.Tables.Add(ChangedTable);
			dataSet.Relations.Add(new DataRelation("s", dataSet.Tables["orig"].Columns["id"], dataSet.Tables["changed"].Columns["id"]));
			string text = this.InsertHeader_String();
			string text2 = string.Empty;
			string text3 = string.Empty;
			bool flag = OriginTabl.Columns.Contains("Parent_ID");
			if (flag)
			{
			}
			try
			{
				IEnumerator enumerator = dataSet.Tables["orig"].Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					DataRow[] childRows = dataRow.GetChildRows("s");
					flag = (childRows.Length == 0);
					if (flag)
					{
						try
						{
							List<TableItemChange>.Enumerator enumerator2 = this.TableItems.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								TableItemChange current = enumerator2.Current;
								text3 = text3 + dataRow[current.column].ToString() + ";";
							}
						}
						finally
						{
							List<TableItemChange>.Enumerator enumerator2;
							((IDisposable)enumerator2).Dispose();
						}
						text2 += historyLog.Insert(Operation_Log.حذف, "D", text3, "D", dataRow[this.Ext1ColumnName].ToString(), dataRow[this.Ext2ColumnName].ToString());
					}
					else
					{
						try
						{
							List<TableItemChange>.Enumerator enumerator3 = this.TableItems.GetEnumerator();
							while (enumerator3.MoveNext())
							{
								TableItemChange current2 = enumerator3.Current;
								flag = (Operators.CompareString(dataRow[current2.column].ToString(), childRows[0][current2.column].ToString(), false) != 0);
								if (flag)
								{
									text2 += historyLog.Insert(Operation_Log.اصلاح, current2.caption, dataRow[current2.column].ToString(), childRows[0][current2.column].ToString(), dataRow[this.Ext1ColumnName].ToString(), dataRow[this.Ext2ColumnName].ToString());
								}
							}
						}
						finally
						{
							List<TableItemChange>.Enumerator enumerator3;
							((IDisposable)enumerator3).Dispose();
						}
					}
					text3 = string.Empty;
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
			flag = (Operators.CompareString(text2, string.Empty, false) != 0);
			if (flag)
			{
				text += text2;
				Public_Function.ExecuteNonQuery(text);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0004DDCC File Offset: 0x0004BFCC
		public string InsertHeader_String()
		{
			return string.Concat(new string[]
			{
				"declare @id bigint;insert into historylog(TableName,pkey,username,tarikh,saat) values(",
				Public_Function.GetValue(this.TableName),
				",",
				Public_Function.GetValue(this.Pkey),
				",",
				Public_Function.GetValue(Public_Function.CurrentData.Username),
				",",
				Public_Function.GetValue(Public_Function.MiladiToShamsi(DateAndTime.Now)),
				",",
				Public_Function.GetValue(DateAndTime.Now.ToShortTimeString()),
				");set @id=scope_identity();"
			});
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0004DE80 File Offset: 0x0004C080
		public string Insert(Operation_Log operation, string ColumnName, string FromValue, string ToValue, string Ext1, string Ext2)
		{
			return string.Concat(new string[]
			{
				"INSERT INTO [Fruitbox].[dbo].[HistoryLog_Detail]  (HistoryLog_ID,Opr_ID,[ColumnName],[FromValue],[ToValue]  ,ext1,ext2)   VALUES (@id,",
				Conversions.ToString((int)operation),
				",",
				Public_Function.GetValue(ColumnName),
				",",
				Public_Function.GetValue(FromValue),
				",",
				Public_Function.GetValue(ToValue),
				",",
				Public_Function.GetValue(Ext1),
				",",
				Public_Function.GetValue(Ext2),
				");"
			});
		}

		// Token: 0x04000179 RID: 377
		[CompilerGenerated]
		private List<TableItemChange> _TableItems;

		// Token: 0x0400017A RID: 378
		[CompilerGenerated]
		private string _TableName;

		// Token: 0x0400017B RID: 379
		[CompilerGenerated]
		private string _Pkey;

		// Token: 0x0400017C RID: 380
		[CompilerGenerated]
		private string _Ext1ColumnName;

		// Token: 0x0400017D RID: 381
		[CompilerGenerated]
		private string _Ext2ColumnName;
	}
}
