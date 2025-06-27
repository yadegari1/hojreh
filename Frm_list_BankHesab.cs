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
using Janus.Windows.GridEX;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000CE RID: 206
	[DesignerGenerated]
	public partial class Frm_list_BankHesab : Form
	{
		// Token: 0x0600116F RID: 4463 RVA: 0x000BDD7C File Offset: 0x000BBF7C
		public Frm_list_BankHesab()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_list_BankHesab_KeyDown);
			base.Load += new EventHandler(this.Frm_list_Moshtari_Load);
			Frm_list_BankHesab.__ENCAddToList(this);
			this.Bank_Hesab = new Bank_Hesab();
			this.InitializeComponent();
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000BDDD4 File Offset: 0x000BBFD4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_list_BankHesab.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_list_BankHesab.__ENCList.Count == Frm_list_BankHesab.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_list_BankHesab.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_list_BankHesab.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_list_BankHesab.__ENCList[num] = Frm_list_BankHesab.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_list_BankHesab.__ENCList.RemoveRange(num, Frm_list_BankHesab.__ENCList.Count - num);
						Frm_list_BankHesab.__ENCList.Capacity = Frm_list_BankHesab.__ENCList.Count;
					}
					Frm_list_BankHesab.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000BE3F4 File Offset: 0x000BC5F4
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x00005D38 File Offset: 0x00003F38
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

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x000BE40C File Offset: 0x000BC60C
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x000BE424 File Offset: 0x000BC624
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000BE484 File Offset: 0x000BC684
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x000BE49C File Offset: 0x000BC69C
		internal virtual ButtonItem ButtonItem3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem3_Click);
				bool flag = this._ButtonItem3 != null;
				if (flag)
				{
					this._ButtonItem3.Click -= value2;
				}
				this._ButtonItem3 = value;
				flag = (this._ButtonItem3 != null);
				if (flag)
				{
					this._ButtonItem3.Click += value2;
				}
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000BE4FC File Offset: 0x000BC6FC
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x000BE514 File Offset: 0x000BC714
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

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x000BE574 File Offset: 0x000BC774
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x00005D42 File Offset: 0x00003F42
		internal virtual ButtonItem ButtonItem4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonItem4 = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000BE58C File Offset: 0x000BC78C
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x000BE5A4 File Offset: 0x000BC7A4
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
				RowActionEventHandler value2 = new RowActionEventHandler(this.GridEX1_RowDoubleClick);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
				}
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000BE604 File Offset: 0x000BC804
		// (set) Token: 0x06001180 RID: 4480 RVA: 0x000BE61C File Offset: 0x000BC81C
		internal virtual ButtonItem ButtonItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem5_Click);
				bool flag = this._ButtonItem5 != null;
				if (flag)
				{
					this._ButtonItem5.Click -= value2;
				}
				this._ButtonItem5 = value;
				flag = (this._ButtonItem5 != null);
				if (flag)
				{
					this._ButtonItem5.Click += value2;
				}
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x000BE67C File Offset: 0x000BC87C
		public void LoadBankHesabData()
		{
			DataTable all = this.Bank_Hesab.GetAll();
			try
			{
				IEnumerator enumerator = all.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["shobe"] != DBNull.Value;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["shobe"], string.Empty, false);
						if (flag2)
						{
							DataRow dataRow2 = dataRow;
							DataRow arg_8D_0 = dataRow2;
							string columnName = "bank_name";
							arg_8D_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" - ", dataRow["shobe"]));
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
			this.GridEX1.DataSource = all;
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_list_BankHesab_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x000BE770 File Offset: 0x000BC970
		private void Frm_list_Moshtari_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.LoadBankHesabData();
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00005D4C File Offset: 0x00003F4C
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.ButtonItem3_Click(null, null);
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x000BE7A8 File Offset: 0x000BC9A8
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			Frm_Bank_Hesab showFrm = new Frm_Bank_Hesab();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			this.LoadBankHesabData();
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000BE7D8 File Offset: 0x000BC9D8
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_Bank_Hesab frm_Bank_Hesab = new Frm_Bank_Hesab();
			Frm_Bank_Hesab arg_39_0 = frm_Bank_Hesab;
			object expr_27 = ((DataRowView)this.GridEX1.GetRow().DataRow)["ID"];
			int? num;
			arg_39_0.ID = ((expr_27 != null) ? ((int?)expr_27) : num);
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Bank_Hesab);
			this.LoadBankHesabData();
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000BE840 File Offset: 0x000BCA40
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					bool flag2 = this.Bank_Hesab.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					if (flag2)
					{
						this.GridEX1.GetRow().Delete();
						Public_Function.ConfirmDeleteAction();
					}
				}
			}
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000BE8BC File Offset: 0x000BCABC
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Bank frm_SuratHesab_Bank = new Frm_SuratHesab_Bank();
			Frm_SuratHesab_Bank arg_39_0 = frm_SuratHesab_Bank;
			object expr_27 = ((DataRowView)this.GridEX1.GetRow().DataRow)["ID"];
			int? num;
			arg_39_0.BankHesab_ID = ((expr_27 != null) ? ((int?)expr_27) : num);
			frm_SuratHesab_Bank.BankHesab_Name = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(((DataRowView)this.GridEX1.GetRow().DataRow)["Bank_Name"], " "), ((DataRowView)this.GridEX1.GetRow().DataRow)["Shobe"]));
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Bank);
		}

		// Token: 0x040006AE RID: 1710
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040006B0 RID: 1712
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040006B1 RID: 1713
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040006B2 RID: 1714
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040006B3 RID: 1715
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040006B4 RID: 1716
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040006B5 RID: 1717
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040006B6 RID: 1718
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040006B7 RID: 1719
		private Bank_Hesab Bank_Hesab;
	}
}
