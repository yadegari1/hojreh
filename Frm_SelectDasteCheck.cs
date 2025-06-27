using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D9 RID: 217
	[DesignerGenerated]
	public partial class Frm_SelectDasteCheck : Form
	{
		// Token: 0x06001363 RID: 4963 RVA: 0x000CEA1C File Offset: 0x000CCC1C
		[DebuggerNonUserCode]
		public Frm_SelectDasteCheck()
		{
			base.Activated += new EventHandler(this.Frm_SelectDasteCheck_Activated);
			base.Load += new EventHandler(this.Frm_SelectDasteCheck_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_SelectDasteCheck_KeyDown);
			Frm_SelectDasteCheck.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000CEA7C File Offset: 0x000CCC7C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SelectDasteCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SelectDasteCheck.__ENCList.Count == Frm_SelectDasteCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SelectDasteCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SelectDasteCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SelectDasteCheck.__ENCList[num] = Frm_SelectDasteCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SelectDasteCheck.__ENCList.RemoveRange(num, Frm_SelectDasteCheck.__ENCList.Count - num);
						Frm_SelectDasteCheck.__ENCList.Capacity = Frm_SelectDasteCheck.__ENCList.Count;
					}
					Frm_SelectDasteCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000CF578 File Offset: 0x000CD778
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x00006512 File Offset: 0x00004712
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

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000CF590 File Offset: 0x000CD790
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x0000651C File Offset: 0x0000471C
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

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x000CF5A8 File Offset: 0x000CD7A8
		// (set) Token: 0x0600136C RID: 4972 RVA: 0x00006526 File Offset: 0x00004726
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

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000CF5C0 File Offset: 0x000CD7C0
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x000CF5D8 File Offset: 0x000CD7D8
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

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x000CF638 File Offset: 0x000CD838
		// (set) Token: 0x06001370 RID: 4976 RVA: 0x000CF650 File Offset: 0x000CD850
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

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x000CF6B0 File Offset: 0x000CD8B0
		// (set) Token: 0x06001372 RID: 4978 RVA: 0x000CF6C8 File Offset: 0x000CD8C8
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				KeyEventHandler value3 = new KeyEventHandler(this.GridEX1_KeyDown);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
				}
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06001373 RID: 4979 RVA: 0x000CF750 File Offset: 0x000CD950
		// (set) Token: 0x06001374 RID: 4980 RVA: 0x00006530 File Offset: 0x00004730
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

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000CF768 File Offset: 0x000CD968
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x0000653A File Offset: 0x0000473A
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

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x000CF780 File Offset: 0x000CD980
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00006544 File Offset: 0x00004744
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

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x000CF798 File Offset: 0x000CD998
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x0000654E File Offset: 0x0000474E
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

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x000CF7B0 File Offset: 0x000CD9B0
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00006558 File Offset: 0x00004758
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

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x000CF7C8 File Offset: 0x000CD9C8
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00006562 File Offset: 0x00004762
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

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x000CF7E0 File Offset: 0x000CD9E0
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0000656C File Offset: 0x0000476C
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

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x000CF7F8 File Offset: 0x000CD9F8
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x00006576 File Offset: 0x00004776
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

		// Token: 0x06001383 RID: 4995 RVA: 0x000CF810 File Offset: 0x000CDA10
		private void Frm_SelectDasteCheck_Activated(object sender, EventArgs e)
		{
			bool flag = this.BankHesab_ID != 0 && this.BankHesab_Name != null;
			if (flag)
			{
				this.txt_dastecheck.Focus();
			}
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000CF848 File Offset: 0x000CDA48
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

		// Token: 0x06001385 RID: 4997 RVA: 0x000CF96C File Offset: 0x000CDB6C
		private void Frm_SelectDasteCheck_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.txt_hesabbank.SelectCommand = "SELECT    Bank_Hesab.ID, Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab as name FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where visible is null";
			this.txt_hesabbank.AddNewForm = MyProject.Forms.Frm_Bank_Hesab;
			this.txt_dastecheck.AddNewForm = MyProject.Forms.Frm_DasteCheck;
			bool flag = this.ID.HasValue;
			checked
			{
				if (flag)
				{
					string arg_9C_0 = "SELECT     DasteCheckBarg.ID, DasteCheckBarg.ShomareBarg,Bank_Hesab.ID AS BankHesab_ID, Bank.Name+' - '+ Bank_Hesab.Shobe AS BankHesab_Name, DasteCheck.ID AS DasteCheck_ID,cast( DasteCheck.Az_Shomare as nvarchar(50))+' - '+CAST( DasteCheck.Ta_Shomare as nvarchar(50)) AS DasteCheck_Name     FROM         Bank_Hesab INNER JOIN   DasteCheck ON Bank_Hesab.ID = DasteCheck.BankHesab_ID INNER JOIN   DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN   Bank ON Bank_Hesab.Bank_ID = Bank.ID where DasteCheckBarg.ID=";
					int? iD = this.ID;
					DataRow dataRow = Public_Function.FillDataRow(arg_9C_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null));
					flag = (dataRow != null);
					if (flag)
					{
						this.txt_hesabbank.SetValue(Conversions.ToString(dataRow["BankHesab_Name"]), RuntimeHelpers.GetObjectValue(dataRow["BankHesab_ID"]));
						this.txt_dastecheck.SetValue(Conversions.ToString(dataRow["DasteCheck_Name"]), RuntimeHelpers.GetObjectValue(dataRow["DasteCheck_ID"]));
						this.txt_dastecheck_SelectedValueChanged(null, null);
						GridEXRow[] rows = this.GridEX1.GetRows();
						for (int i = 0; i < rows.Length; i++)
						{
							GridEXRow gridEXRow = rows[i];
							flag = Operators.ConditionalCompareObjectEqual(gridEXRow.Cells["shomareBarg"].Value, dataRow["ShomareBarg"], false);
							if (flag)
							{
								this.GridEX1.Row = gridEXRow.Position;
							}
						}
					}
				}
				flag = (Operators.CompareString(this.Notin_Pardakht, string.Empty, false) == 0 && this.Pardakht_Table != null);
				if (flag)
				{
					this._Get_Notin_Pardakht();
				}
				flag = (this.BankHesab_ID != 0 && this.BankHesab_Name != null);
				if (flag)
				{
					this.txt_hesabbank.SetValue(this.BankHesab_Name, this.BankHesab_ID);
					this.txt_hesabbank.SelectCommand = string.Empty;
					this.txt_hesabbank_SelectedValueChanged(null, null);
					this.txt_dastecheck.Focus();
				}
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000CFB8C File Offset: 0x000CDD8C
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
			this.txt_dastecheck.SelectCommand = Conversions.ToString(Operators.ConcatenateObject("SELECT     t.Tedad_Check, t.DasteCheck_ID AS ID,CAST( DasteCheck.Az_Shomare as nvarchar(50)) +' - '+CAST( DasteCheck.Ta_Shomare as nvarchar(50)) AS ShomareBarg FROM         (SELECT     COUNT(ID) AS Tedad_Check, DasteCheck_ID  FROM DasteCheckBarg  WHERE     " + text + " GROUP BY DasteCheck_ID) AS t INNER JOIN " + " DasteCheck ON t.DasteCheck_ID = DasteCheck.ID " + " WHERE     (t.Tedad_Check > 0) AND BankHesab_ID = ", this.txt_hesabbank.Value));
			this.txt_dastecheck.SetNew();
			this.GridEX1.DataSource = null;
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000CFC6C File Offset: 0x000CDE6C
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
			DataTable dataSource = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("select * from DasteCheckBarg where Dastecheck_ID=", this.txt_dastecheck.Value), text)));
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000CFD1C File Offset: 0x000CDF1C
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1_RowDoubleClick(null, null);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000CFD44 File Offset: 0x000CDF44
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				this.ShomareBarg = Conversions.ToString(this.GridEX1.CurrentRow.Cells["shomareBarg"].Value);
				object expr_64 = this.GridEX1.CurrentRow.Cells["ID"].Value;
				int? num;
				this.ID = ((expr_64 != null) ? ((int?)expr_64) : num);
				this.BankHesab_Name = this.txt_hesabbank.Text;
				this.BankHesab_ID = Conversions.ToInteger(this.txt_hesabbank.Value);
				this.Close();
			}
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_SelectDasteCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x04000780 RID: 1920
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000782 RID: 1922
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000783 RID: 1923
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000784 RID: 1924
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000785 RID: 1925
		[AccessedThroughProperty("txt_dastecheck")]
		private SelectItem _txt_dastecheck;

		// Token: 0x04000786 RID: 1926
		[AccessedThroughProperty("txt_hesabbank")]
		private SelectItem _txt_hesabbank;

		// Token: 0x04000787 RID: 1927
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000788 RID: 1928
		[CompilerGenerated]
		private string _Notin_Pardakht;

		// Token: 0x04000789 RID: 1929
		[CompilerGenerated]
		private string _Notin_Me;

		// Token: 0x0400078A RID: 1930
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x0400078B RID: 1931
		[CompilerGenerated]
		private string _Notin_DB;

		// Token: 0x0400078C RID: 1932
		[CompilerGenerated]
		private int _BankHesab_ID;

		// Token: 0x0400078D RID: 1933
		[CompilerGenerated]
		private string _BankHesab_Name;

		// Token: 0x0400078E RID: 1934
		[CompilerGenerated]
		private string _ShomareBarg;

		// Token: 0x0400078F RID: 1935
		[CompilerGenerated]
		private int? _ID;
	}
}
