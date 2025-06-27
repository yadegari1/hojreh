using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000120 RID: 288
	[DesignerGenerated]
	public partial class Frm_List_EbtalCheck : Form
	{
		// Token: 0x06002A0F RID: 10767 RVA: 0x0000A723 File Offset: 0x00008923
		[DebuggerNonUserCode]
		public Frm_List_EbtalCheck()
		{
			base.Load += new EventHandler(this.Frm_List_EbtalCheck_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_List_EbtalCheck_KeyDown);
			Frm_List_EbtalCheck.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x001FA9F8 File Offset: 0x001F8BF8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_List_EbtalCheck.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_List_EbtalCheck.__ENCList.Count == Frm_List_EbtalCheck.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_List_EbtalCheck.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_List_EbtalCheck.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_List_EbtalCheck.__ENCList[num] = Frm_List_EbtalCheck.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_List_EbtalCheck.__ENCList.RemoveRange(num, Frm_List_EbtalCheck.__ENCList.Count - num);
						Frm_List_EbtalCheck.__ENCList.Capacity = Frm_List_EbtalCheck.__ENCList.Count;
					}
					Frm_List_EbtalCheck.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x001FB05C File Offset: 0x001F925C
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x0000A763 File Offset: 0x00008963
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

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x001FB074 File Offset: 0x001F9274
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0000A76D File Offset: 0x0000896D
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

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x001FB08C File Offset: 0x001F928C
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x0000A777 File Offset: 0x00008977
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

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002A19 RID: 10777 RVA: 0x001FB0A4 File Offset: 0x001F92A4
		// (set) Token: 0x06002A1A RID: 10778 RVA: 0x001FB0BC File Offset: 0x001F92BC
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

		// Token: 0x06002A1B RID: 10779 RVA: 0x001FB11C File Offset: 0x001F931C
		private void LoadData()
		{
			DataTable dataSource = Public_Function.FillData("SELECT     DasteCheck_Ebtal.ID,DasteCheck_Ebtal.Sanad_ID,ShomareBarg,DasteCheck.ID as DasteCheck_ID,cast( DasteCheck.Az_Shomare as nvarchar(10))+' - '+cast( DasteCheck.Ta_Shomare AS nvarchar(10)) as DasteCheck, Bank.Name+' '+ Bank_Hesab.Shobe+' - '+ Bank_Hesab.SahebHesab AS BankHesab_Name,  DasteCheck_Ebtal.Tozih  FROM         Bank_Hesab INNER JOIN    DasteCheck ON Bank_Hesab.ID = DasteCheck.BankHesab_ID INNER JOIN    DasteCheck_Ebtal ON DasteCheck.ID = DasteCheck_Ebtal.DasteCheck_ID INNER JOIN    Bank ON Bank_Hesab.Bank_ID = Bank.ID");
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x0000A781 File Offset: 0x00008981
		private void Frm_List_EbtalCheck_Load(object sender, EventArgs e)
		{
			this.LoadData();
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x001FB144 File Offset: 0x001F9344
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				string text = string.Empty;
				DataRow row = ((DataRowView)this.GridEX1.CurrentRow.DataRow).Row;
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from DasteCheck_Ebtal where id=", row["ID"]), ";")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" delete from sanad where id=", row["sanad_id"]), ";")));
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("insert into DasteCheckBarg (DasteCheck_ID,ShomareBarg) Values(", row["DasteCheck_ID"]), ","), row["ShomareBarg"]), ")")));
				Public_Function.ExecuteNonQuery(text);
				Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_List_EbtalCheck_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x0400106A RID: 4202
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400106C RID: 4204
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400106D RID: 4205
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400106E RID: 4206
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400106F RID: 4207
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;
	}
}
