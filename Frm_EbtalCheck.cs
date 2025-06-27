using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000EC RID: 236
	[DesignerGenerated]
	public partial class Frm_EbtalCheck : Form
	{
		// Token: 0x060018E3 RID: 6371 RVA: 0x00118A34 File Offset: 0x00116C34
		[DebuggerNonUserCode]
		public Frm_EbtalCheck()
		{
			base.Activated += new EventHandler(this.Frm_SelectDasteCheck_Activated);
			base.Load += new EventHandler(this.Frm_SelectDasteCheck_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SelectDasteCheck_KeyDown);
			Frm_EbtalCheck.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x00118A94 File Offset: 0x00116C94
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_EbtalCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_EbtalCheck.__ENCList.Count == Frm_EbtalCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_EbtalCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_EbtalCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_EbtalCheck.__ENCList[num] = Frm_EbtalCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_EbtalCheck.__ENCList.RemoveRange(num, Frm_EbtalCheck.__ENCList.Count - num);
						Frm_EbtalCheck.__ENCList.Capacity = Frm_EbtalCheck.__ENCList.Count;
					}
					Frm_EbtalCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00119C64 File Offset: 0x00117E64
		// (set) Token: 0x060018E8 RID: 6376 RVA: 0x00007590 File Offset: 0x00005790
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

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00119C7C File Offset: 0x00117E7C
		// (set) Token: 0x060018EA RID: 6378 RVA: 0x0000759A File Offset: 0x0000579A
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x00119C94 File Offset: 0x00117E94
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x000075A4 File Offset: 0x000057A4
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

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x00119CAC File Offset: 0x00117EAC
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x00119CC4 File Offset: 0x00117EC4
		internal virtual SelectItem txt_dastecheck
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_dastecheck;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_dastecheck_SelectedValueChanged);
				bool flag = this._txt_dastecheck != null;
				if (flag)
				{
					this._txt_dastecheck.SelectedValueChanged -= obj;
				}
				this._txt_dastecheck = value;
				flag = (this._txt_dastecheck != null);
				if (flag)
				{
					this._txt_dastecheck.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00119D24 File Offset: 0x00117F24
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00119D3C File Offset: 0x00117F3C
		internal virtual SelectItem txt_hesabbank
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hesabbank;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_hesabbank_SelectedValueChanged);
				bool flag = this._txt_hesabbank != null;
				if (flag)
				{
					this._txt_hesabbank.SelectedValueChanged -= obj;
				}
				this._txt_hesabbank = value;
				flag = (this._txt_hesabbank != null);
				if (flag)
				{
					this._txt_hesabbank.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00119D9C File Offset: 0x00117F9C
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x000075AE File Offset: 0x000057AE
		internal virtual DataEntryGrid GridEX1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._GridEX1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._GridEX1 = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00119DB4 File Offset: 0x00117FB4
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x000075B8 File Offset: 0x000057B8
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label3 = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00119DCC File Offset: 0x00117FCC
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x000075C2 File Offset: 0x000057C2
		internal virtual SelectItem txt_checkbarg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_checkbarg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_checkbarg = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x00119DE4 File Offset: 0x00117FE4
		// (set) Token: 0x060018F8 RID: 6392 RVA: 0x000075CC File Offset: 0x000057CC
		internal virtual EditBox txt_tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tozih;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tozih = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00119DFC File Offset: 0x00117FFC
		// (set) Token: 0x060018FA RID: 6394 RVA: 0x000075D6 File Offset: 0x000057D6
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00119E14 File Offset: 0x00118014
		// (set) Token: 0x060018FC RID: 6396 RVA: 0x000075E0 File Offset: 0x000057E0
		internal virtual Bar Bar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Bar1 = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00119E2C File Offset: 0x0011802C
		// (set) Token: 0x060018FE RID: 6398 RVA: 0x00119E44 File Offset: 0x00118044
		internal virtual ButtonItem ButtonItem2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem2_Click);
				bool flag = this._ButtonItem2 != null;
				if (flag)
				{
					this._ButtonItem2.Click -= value2;
				}
				this._ButtonItem2 = value;
				flag = (this._ButtonItem2 != null);
				if (flag)
				{
					this._ButtonItem2.Click += value2;
				}
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x00119EA4 File Offset: 0x001180A4
		// (set) Token: 0x06001900 RID: 6400 RVA: 0x00119EBC File Offset: 0x001180BC
		internal virtual ButtonItem ButtonItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem1_Click);
				bool flag = this._ButtonItem1 != null;
				if (flag)
				{
					this._ButtonItem1.Click -= value2;
				}
				this._ButtonItem1 = value;
				flag = (this._ButtonItem1 != null);
				if (flag)
				{
					this._ButtonItem1.Click += value2;
				}
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00119F1C File Offset: 0x0011811C
		// (set) Token: 0x06001902 RID: 6402 RVA: 0x000075EA File Offset: 0x000057EA
		public string Notin_Pardakht
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Notin_Pardakht;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Notin_Pardakht = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00119F34 File Offset: 0x00118134
		// (set) Token: 0x06001904 RID: 6404 RVA: 0x000075F4 File Offset: 0x000057F4
		public string Notin_Me
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Notin_Me;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Notin_Me = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x00119F4C File Offset: 0x0011814C
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x000075FE File Offset: 0x000057FE
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x00119F64 File Offset: 0x00118164
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x00007608 File Offset: 0x00005808
		public string Notin_DB
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Notin_DB;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Notin_DB = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x00119F7C File Offset: 0x0011817C
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x00007612 File Offset: 0x00005812
		public int BankHesab_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_ID = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x00119F94 File Offset: 0x00118194
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x0000761C File Offset: 0x0000581C
		public string BankHesab_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BankHesab_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._BankHesab_Name = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x00119FAC File Offset: 0x001181AC
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x00007626 File Offset: 0x00005826
		public string ShomareBarg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ShomareBarg;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ShomareBarg = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x00119FC4 File Offset: 0x001181C4
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x00007630 File Offset: 0x00005830
		public int? ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00119FDC File Offset: 0x001181DC
		private void Frm_SelectDasteCheck_Activated(object sender, EventArgs e)
		{
			bool flag = this.BankHesab_ID != 0 && this.BankHesab_Name != null;
			if (flag)
			{
				this.txt_dastecheck.Focus();
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x0011A014 File Offset: 0x00118214
		private void _Get_Notin_Pardakht()
		{
			try
			{
				IEnumerator enumerator = this.Pardakht_Table.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false) || Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 15, false))
					{
						goto IL_77;
					}
					if (Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 31, false))
					{
						goto IL_77;
					}
					bool arg_79_0 = false;
					IL_78:
					bool flag = arg_79_0;
					if (flag)
					{
						bool flag2 = dataRow["checkBarg_ID"] != DBNull.Value;
						if (flag2)
						{
							this.Notin_Pardakht = Conversions.ToString(Operators.ConcatenateObject(this.Notin_Pardakht, Operators.ConcatenateObject(dataRow["checkBarg_ID"], ",")));
						}
					}
					continue;
					IL_77:
					arg_79_0 = true;
					goto IL_78;
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
			this.Notin_Pardakht = Public_Function.RemoveLast(this.Notin_Pardakht);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x0011A138 File Offset: 0x00118338
		private void Frm_SelectDasteCheck_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.txt_hesabbank.SelectCommand = "SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID";
			this.txt_hesabbank.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_dastecheck.AddNewForm = MyProject.Forms.Frm_DasteCheck;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x0011A1A8 File Offset: 0x001183A8
		private void txt_hesabbank_SelectedValueChanged(object sender, EventArgs e)
		{
			string text = " DasteCheckBarg.ID not in(select CheckBarg_ID from DaryaftPardakht where checkBarg_ID is not null) ";
			bool flag = Operators.CompareString(this.Notin_Pardakht, string.Empty, false) != 0;
			if (flag)
			{
				text = text + " AND DasteCheckBarg.ID not in(" + this.Notin_Pardakht + ")";
			}
			flag = (Operators.CompareString(this.Notin_Me, string.Empty, false) != 0);
			if (flag)
			{
				text = text + " AND DasteCheckBarg.ID not in(" + this.Notin_Me + ")";
			}
			this.txt_dastecheck.SelectCommand = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     t.Tedad_Check, t.DasteCheck_ID AS ID,CAST( DasteCheck.Az_Shomare as nvarchar(50)) +' - '+CAST( DasteCheck.Ta_Shomare as nvarchar(50)) AS ShomareBarg FROM         (SELECT     COUNT(ID) AS Tedad_Check, DasteCheck_ID  FROM DasteCheckBarg  WHERE     " + text + " GROUP BY DasteCheck_ID) AS t INNER JOIN " + " DasteCheck ON t.DasteCheck_ID = DasteCheck.ID " + " WHERE     (t.Tedad_Check > 0) AND BankHesab_ID = ", this.txt_hesabbank.Value), " order by ShomareBarg ASC"));
			this.txt_dastecheck.SetNew();
			this.GridEX1.DataSource = null;
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x0011A290 File Offset: 0x00118490
		private void txt_dastecheck_SelectedValueChanged(object sender, EventArgs e)
		{
			string text = " AND DasteCheckBarg.ID not in(select CheckBarg_ID from DaryaftPardakht where checkBarg_ID is not null) ";
			bool flag = Operators.CompareString(this.Notin_Pardakht, string.Empty, false) != 0;
			if (flag)
			{
				text = text + " AND DasteCheckBarg.ID not in(" + this.Notin_Pardakht + ")";
			}
			flag = (Operators.CompareString(this.Notin_Me, string.Empty, false) != 0);
			if (flag)
			{
				text = text + " AND DasteCheckBarg.ID not in(" + this.Notin_Me + ")";
			}
			this.txt_checkbarg.SelectCommand = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from DasteCheckBarg where Dastecheck_ID=", this.txt_dastecheck.Value), text), " order by shomareBarg"));
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x0011A344 File Offset: 0x00118544
		private void Frm_SelectDasteCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F2 && this.ButtonItem2.Enabled);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0011A394 File Offset: 0x00118594
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("آیا مایل به حذف برگ میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Sanad sanad = new Sanad();
				string codeHesab_ID = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_mojodi from bank_hesab where id=", this.txt_hesabbank.SelectedRow["ID"])
				}, null, null, null));
				string text = "ابطال برگ شماره " + this.txt_checkbarg.Text;
				flag = (Operators.CompareString(this.txt_tozih.Text, string.Empty, false) != 0);
				if (flag)
				{
					text = text + " - " + this.txt_tozih.Text;
				}
				string text2 = "declare @id bigint;";
				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("delete from dastecheckbarg where dastecheck_id=", this.txt_dastecheck.SelectedRow["ID"]), " and shomarebarg="), this.txt_checkbarg.Text), ";")));
				text2 = text2 + sanad.InsertStr(codeHesab_ID, Conversions.ToString(0), Conversions.ToString(0), Public_Function.MiladiToShamsi(DateAndTime.Now), text, Sanad.SanadType.@null) + ";select @id=Scope_identity();";
				text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" insert into DasteCheck_Ebtal (Dastecheck_id,ShomareBarg,Sanad_ID,Tozih) values(", this.txt_dastecheck.SelectedRow["ID"]), ","), this.txt_checkbarg.Text), ",@id,"), Public_Function.GetValue(this.txt_tozih.Text)), ");")));
				Public_Function.ExecuteNonQuery(text2);
			}
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			Public_Function.SetNew(this.UiGroupBox1);
			this.txt_hesabbank.Focus();
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x0011A57C File Offset: 0x0011877C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			Frm_List_EbtalCheck showFrm = new Frm_List_EbtalCheck();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x040009B2 RID: 2482
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040009B4 RID: 2484
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040009B5 RID: 2485
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040009B6 RID: 2486
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040009B7 RID: 2487
		[AccessedThroughProperty("txt_dastecheck")]
		private SelectItem _txt_dastecheck;

		// Token: 0x040009B8 RID: 2488
		[AccessedThroughProperty("txt_hesabbank")]
		private SelectItem _txt_hesabbank;

		// Token: 0x040009B9 RID: 2489
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040009BA RID: 2490
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040009BB RID: 2491
		[AccessedThroughProperty("txt_checkbarg")]
		private SelectItem _txt_checkbarg;

		// Token: 0x040009BC RID: 2492
		[AccessedThroughProperty("txt_tozih")]
		private EditBox _txt_tozih;

		// Token: 0x040009BD RID: 2493
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040009BE RID: 2494
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040009BF RID: 2495
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040009C0 RID: 2496
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040009C1 RID: 2497
		[CompilerGenerated]
		private string _Notin_Pardakht;

		// Token: 0x040009C2 RID: 2498
		[CompilerGenerated]
		private string _Notin_Me;

		// Token: 0x040009C3 RID: 2499
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x040009C4 RID: 2500
		[CompilerGenerated]
		private string _Notin_DB;

		// Token: 0x040009C5 RID: 2501
		[CompilerGenerated]
		private int _BankHesab_ID;

		// Token: 0x040009C6 RID: 2502
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x040009C7 RID: 2503
		[CompilerGenerated]
		private string _ShomareBarg;

		// Token: 0x040009C8 RID: 2504
		[CompilerGenerated]
		private int? _ID;
	}
}
