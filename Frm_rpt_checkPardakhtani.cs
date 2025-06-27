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
	// Token: 0x0200012A RID: 298
	[DesignerGenerated]
	public partial class Frm_rpt_checkPardakhtani : Form
	{
		// Token: 0x06002B42 RID: 11074 RVA: 0x0000ACF9 File Offset: 0x00008EF9
		[DebuggerNonUserCode]
		public Frm_rpt_checkPardakhtani()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_checkPardakhtani_KeyDown);
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			Frm_rpt_checkPardakhtani.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x002051C4 File Offset: 0x002033C4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_checkPardakhtani.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_checkPardakhtani.__ENCList.Count == Frm_rpt_checkPardakhtani.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_checkPardakhtani.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_checkPardakhtani.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_checkPardakhtani.__ENCList[num] = Frm_rpt_checkPardakhtani.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_checkPardakhtani.__ENCList.RemoveRange(num, Frm_rpt_checkPardakhtani.__ENCList.Count - num);
						Frm_rpt_checkPardakhtani.__ENCList.Capacity = Frm_rpt_checkPardakhtani.__ENCList.Count;
					}
					Frm_rpt_checkPardakhtani.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x00205B74 File Offset: 0x00203D74
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x0000AD39 File Offset: 0x00008F39
		internal virtual GridEX GridEX1
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

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x00205B8C File Offset: 0x00203D8C
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x0000AD43 File Offset: 0x00008F43
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

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x00205BA4 File Offset: 0x00203DA4
		// (set) Token: 0x06002B4B RID: 11083 RVA: 0x0000AD4D File Offset: 0x00008F4D
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

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x00205BBC File Offset: 0x00203DBC
		// (set) Token: 0x06002B4D RID: 11085 RVA: 0x00205BD4 File Offset: 0x00203DD4
		internal virtual SelectItem txt_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_moshtari_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged -= obj;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.SelectedValueChanged += obj;
				}
			}
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x00205C34 File Offset: 0x00203E34
		// (set) Token: 0x06002B4F RID: 11087 RVA: 0x00205C4C File Offset: 0x00203E4C
		internal virtual EditBox EditBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._EditBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x00205CAC File Offset: 0x00203EAC
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x0000AD57 File Offset: 0x00008F57
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

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x00205CC4 File Offset: 0x00203EC4
		// (set) Token: 0x06002B53 RID: 11091 RVA: 0x00205CDC File Offset: 0x00203EDC
		internal virtual Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				bool flag = this._Timer1 != null;
				if (flag)
				{
					this._Timer1.Tick -= value2;
				}
				this._Timer1 = value;
				flag = (this._Timer1 != null);
				if (flag)
				{
					this._Timer1.Tick += value2;
				}
			}
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x00205D3C File Offset: 0x00203F3C
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x0000AD61 File Offset: 0x00008F61
		public int? Moshtari_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_ID = value;
			}
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x00205D54 File Offset: 0x00203F54
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x0000AD6B File Offset: 0x00008F6B
		public string Moshtari_Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_Name = value;
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x00205D6C File Offset: 0x00203F6C
		private void LoadData()
		{
			string str = string.Empty;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				str = Conversions.ToString(Operators.ConcatenateObject(" AND Moshtari.ID=", this.txt_moshtari.Value));
			}
			DataTable dataTable = Public_Function.FillData("SELECT     DaryaftPardakht.ID, DaryaftPardakht.dpType_ID, DaryaftPardakht.Tarikh, DaryaftPardakht.SanadBed_ID, DaryaftPardakht.SanadBes_ID, DaryaftPardakht.Moshtari_ID,   DaryaftPardakht.Mablagh, DaryaftPardakht.Tozih, DaryaftPardakht.Tarikh_Fa, DaryaftPardakht.Sh_Check, DaryaftPardakht.CheckBank_ID,  DaryaftPardakht.Check_Shobe, DaryaftPardakht.Check_Sarresid, DaryaftPardakht.Check_Sarresid_Fa, DaryaftPardakht.Check_Status,  DaryaftPardakht.Check_ShomareHesab, Moshtari.Name + ' ' + Moshtari.Family AS Moshtari_Name, Bank_1.Name AS Bank_Name, Bank_Hesab.Shobe,   DaryaftPardakht.CheckBarg_ID, Bank.Name  FROM         DasteCheck INNER JOIN  DasteCheckBarg ON DasteCheck.ID = DasteCheckBarg.DasteCheck_ID INNER JOIN  Bank_Hesab ON DasteCheck.BankHesab_ID = Bank_Hesab.ID INNER JOIN  Bank ON Bank_Hesab.Bank_ID = Bank.ID RIGHT OUTER JOIN  DaryaftPardakht INNER JOIN  Moshtari ON DaryaftPardakht.Moshtari_ID = Moshtari.ID ON DasteCheckBarg.ID = DaryaftPardakht.CheckBarg_ID LEFT OUTER JOIN  Bank AS Bank_1 ON DaryaftPardakht.CheckBank_ID = Bank_1.ID  WHERE     (DaryaftPardakht.dpType_ID IN (11, 12)) " + str + " order by DaryaftPardakht.Check_Sarresid");
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["dptype_id"], 11, false);
					if (flag)
					{
						dataRow["bank_Name"] = RuntimeHelpers.GetObjectValue(dataRow["Name"]);
						dataRow["Check_Shobe"] = RuntimeHelpers.GetObjectValue(dataRow["shobe"]);
					}
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
			this.GridEX1.DataSource = dataTable;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x00205E98 File Offset: 0x00204098
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			bool hasValue = this.Moshtari_ID.HasValue;
			if (hasValue)
			{
				this.txt_moshtari.SetValue(this.Moshtari_Name, this.Moshtari_ID);
			}
			this.LoadData();
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x0000AD75 File Offset: 0x00008F75
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_rpt_checkPardakhtani_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x0000AD80 File Offset: 0x00008F80
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.GridEX1.MoveLast();
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0000AD9D File Offset: 0x00008F9D
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x040010D7 RID: 4311
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040010D9 RID: 4313
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040010DA RID: 4314
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040010DB RID: 4315
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040010DC RID: 4316
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x040010DD RID: 4317
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040010DE RID: 4318
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040010DF RID: 4319
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040010E0 RID: 4320
		[CompilerGenerated]
		private int? _Moshtari_ID;

		// Token: 0x040010E1 RID: 4321
		[CompilerGenerated]
		private string _Moshtari_Name;
	}
}
