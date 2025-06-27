using System;
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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000CF RID: 207
	[DesignerGenerated]
	public partial class Frm_list_Moshtari : Form
	{
		// Token: 0x0600118A RID: 4490 RVA: 0x000BE974 File Offset: 0x000BCB74
		public Frm_list_Moshtari()
		{
			base.Load += new EventHandler(this.Frm_list_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_list_Moshtari_KeyDown);
			Frm_list_Moshtari.__ENCAddToList(this);
			this.moshtari = new Moshtari();
			this.InitializeComponent();
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x000BE9CC File Offset: 0x000BCBCC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_list_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_list_Moshtari.__ENCList.Count == Frm_list_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_list_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_list_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_list_Moshtari.__ENCList[num] = Frm_list_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_list_Moshtari.__ENCList.RemoveRange(num, Frm_list_Moshtari.__ENCList.Count - num);
						Frm_list_Moshtari.__ENCList.Capacity = Frm_list_Moshtari.__ENCList.Count;
					}
					Frm_list_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x000BF2C4 File Offset: 0x000BD4C4
		// (set) Token: 0x0600118F RID: 4495 RVA: 0x00005D66 File Offset: 0x00003F66
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

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x000BF2DC File Offset: 0x000BD4DC
		// (set) Token: 0x06001191 RID: 4497 RVA: 0x000BF2F4 File Offset: 0x000BD4F4
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x000BF354 File Offset: 0x000BD554
		// (set) Token: 0x06001193 RID: 4499 RVA: 0x000BF36C File Offset: 0x000BD56C
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

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000BF3CC File Offset: 0x000BD5CC
		// (set) Token: 0x06001195 RID: 4501 RVA: 0x000BF3E4 File Offset: 0x000BD5E4
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x000BF444 File Offset: 0x000BD644
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x000BF45C File Offset: 0x000BD65C
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
				EventHandler value2 = new EventHandler(this.ButtonItem4_Click);
				bool flag = this._ButtonItem4 != null;
				if (flag)
				{
					this._ButtonItem4.Click -= value2;
				}
				this._ButtonItem4 = value;
				flag = (this._ButtonItem4 != null);
				if (flag)
				{
					this._ButtonItem4.Click += value2;
				}
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x000BF4BC File Offset: 0x000BD6BC
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x000BF4D4 File Offset: 0x000BD6D4
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

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x000BF534 File Offset: 0x000BD734
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x000BF54C File Offset: 0x000BD74C
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

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000BF5AC File Offset: 0x000BD7AC
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x00005D70 File Offset: 0x00003F70
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
				this._EditBox1 = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000BF5C4 File Offset: 0x000BD7C4
		// (set) Token: 0x0600119F RID: 4511 RVA: 0x000BF5DC File Offset: 0x000BD7DC
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
				EventHandler value2 = new EventHandler(this.Label1_Click);
				bool flag = this._Label1 != null;
				if (flag)
				{
					this._Label1.Click -= value2;
				}
				this._Label1 = value;
				flag = (this._Label1 != null);
				if (flag)
				{
					this._Label1.Click += value2;
				}
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x000BF63C File Offset: 0x000BD83C
		// (set) Token: 0x060011A1 RID: 4513 RVA: 0x00005D7A File Offset: 0x00003F7A
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

		// Token: 0x060011A2 RID: 4514 RVA: 0x000BF654 File Offset: 0x000BD854
		public void LoadMoshtariData()
		{
			DataTable all = this.moshtari.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_list_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000BF67C File Offset: 0x000BD87C
		private void Frm_list_Moshtari_Load(object sender, EventArgs e)
		{
			this.GridEX1.FocusCellFormatStyle.BackColor = this.GridEX1.SelectedFormatStyle.BackColor;
			this.LoadMoshtariData();
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x00005D84 File Offset: 0x00003F84
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			this.ButtonItem3_Click(null, null);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x000BF6B4 File Offset: 0x000BD8B4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			Frm_Moshtari showFrm = new Frm_Moshtari();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			DataTable all = this.moshtari.GetAll();
			this.GridEX1.DataSource = all;
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x000BF6F4 File Offset: 0x000BD8F4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
			Frm_Moshtari arg_39_0 = frm_Moshtari;
			object expr_27 = ((DataRowView)this.GridEX1.GetRow().DataRow)["ID"];
			int? num;
			arg_39_0.ID = ((expr_27 != null) ? ((int?)expr_27) : num);
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Moshtari);
			this.LoadMoshtariData();
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x000BF75C File Offset: 0x000BD95C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				flag = (Public_Function.ConfirmDelete() == DialogResult.Yes);
				if (flag)
				{
					bool flag2 = this.moshtari.Delete(Conversions.ToString(((DataRowView)this.GridEX1.GetRow().DataRow)["ID"]));
					if (flag2)
					{
						this.GridEX1.CurrentRow.Delete();
						Public_Function.ConfirmDeleteAction();
					}
				}
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x000BF7D8 File Offset: 0x000BD9D8
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.GetRow() == null;
			if (!flag)
			{
				Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
				Frm_SuratHesab_Moshtari arg_4E_0 = frm_SuratHesab_Moshtari;
				object expr_3C = ((DataRowView)this.GridEX1.GetRow().DataRow)["ID"];
				int? num;
				arg_4E_0.Moshtari_id = ((expr_3C != null) ? ((int?)expr_3C) : num);
				frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.GetRow().Cells["Name"].Value);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
			}
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0000205D File Offset: 0x0000025D
		private void Label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040006B8 RID: 1720
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040006BA RID: 1722
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040006BB RID: 1723
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x040006BC RID: 1724
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040006BD RID: 1725
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x040006BE RID: 1726
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x040006BF RID: 1727
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x040006C0 RID: 1728
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x040006C1 RID: 1729
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x040006C2 RID: 1730
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040006C3 RID: 1731
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040006C4 RID: 1732
		private Moshtari moshtari;
	}
}
