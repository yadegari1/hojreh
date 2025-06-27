using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000063 RID: 99
	[DesignerGenerated]
	public partial class Frm_ClearData : Form
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x00003086 File Offset: 0x00001286
		[DebuggerNonUserCode]
		public Frm_ClearData()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_ClearData_KeyDown);
			Frm_ClearData.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0006B574 File Offset: 0x00069774
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_ClearData.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_ClearData.__ENCList.Count == Frm_ClearData.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_ClearData.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_ClearData.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_ClearData.__ENCList[num] = Frm_ClearData.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_ClearData.__ENCList.RemoveRange(num, Frm_ClearData.__ENCList.Count - num);
						Frm_ClearData.__ENCList.Capacity = Frm_ClearData.__ENCList.Count;
					}
					Frm_ClearData.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x0006BB04 File Offset: 0x00069D04
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x000030B2 File Offset: 0x000012B2
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

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0006BB1C File Offset: 0x00069D1C
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0006BB34 File Offset: 0x00069D34
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

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0006BB94 File Offset: 0x00069D94
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x000030BC File Offset: 0x000012BC
		internal virtual UICheckBox txt_moshtari
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
				this._txt_moshtari = value;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x0006BBAC File Offset: 0x00069DAC
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x000030C6 File Offset: 0x000012C6
		internal virtual UICheckBox txt_hesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_hesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_hesab = value;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0006BBC4 File Offset: 0x00069DC4
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x000030D0 File Offset: 0x000012D0
		internal virtual UICheckBox txt_mande_avalie
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mande_avalie;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mande_avalie = value;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0006BBDC File Offset: 0x00069DDC
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.ShowMessage("ایا مایل به حذف تمامی اطلاعات میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
			if (flag)
			{
				Frm_Password frm_Password = new Frm_Password();
				flag = (frm_Password.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					string text = "delete from safi_furush delete from kala_to_kala_furush  delete from kala_to_kala_kharid    delete from furush_darsad    delete from Furush_Keraye                  delete from furush_hag_detail              delete from furush_hag                     delete from furush_sardkhane_keraye    delete from furush_Sardkhane_Safi   delete from furush_Sardkhane_Detail   delete from furush_Sardkhane    delete from kharid_sardkhane_keraye    delete from kharid_Sardkhane_Darsad    delete from kharid_Sardkhane_Detail    delete from kharid_Sardkhane    delete from ersalbar_keraye    delete from ersalbar_detail    delete from ersalbar    delete from khordefurushi_keraye   delete from khordefurushi_detail   delete from khordefurushi    delete from check_status                   delete from kharid_keraye                  delete from kharid_darsad                  delete from kharid_detail                  delete from kharid_furush                  delete from kharid                         delete from daryaftpardakht                delete from mande_sandugh                  update moshtari set sanad_id=null          update bank_hesab set sanad_id=null        delete from dastecheckbarg                delete from dastecheck                     delete from sanad                          delete from hazine    delete from daramad   delete from Sharik    delete from historylog   delete from historylog_detail   delete from sud_sukhte    delete from sud_detail   delete from sud   delete from moshtari_listsiah";
					Public_Function.ExecuteNonQuery(text);
					text = "DBCC CHECKIDENT('daramad',reseed,0);DBCC CHECKIDENT('hazine',reseed,0);";
					Public_Function.ExecuteNonQuery(text);
					text = string.Empty;
					flag = this.txt_moshtari.Checked;
					if (flag)
					{
						text = "   delete from moshtari_kala    delete from moshtari_hesab   delete from moshtari_pic   delete from moshtari where id>0   DBCC CHECKIDENT('moshtari',reseed,100)";
					}
					flag = this.txt_hesab.Checked;
					if (flag)
					{
						text += " delete from bank_hesab;  DBCC CHECKIDENT('Bank_Hesab',reseed,0);";
					}
					text += " delete from code_hesab where grouh_id not in (2,3,4) and id>80;";
					flag = (text.Length > 0);
					if (flag)
					{
						Public_Function.ExecuteNonQuery(text);
					}
					text = string.Empty;
					flag = this.txt_moshtari.Checked;
					if (flag)
					{
						text += "delete from code_hesab where grouh_id in (2) and id>80;";
					}
					flag = this.txt_hesab.Checked;
					if (flag)
					{
						text += "delete from code_hesab where grouh_id in (3,4) and id>80;";
					}
					flag = (text.Length > 0);
					if (flag)
					{
						Public_Function.ExecuteNonQuery(text);
					}
					flag = this.txt_mande_avalie.Checked;
					if (flag)
					{
						DataTable dt = Public_Function.FillData("select sanad_id from moshtari where id>0");
						string iD = Public_Function.GetID(dt, "sanad_id", "");
						text += " update moshtari set avaldoretype= null,avaldore = null,Sanad_id=null where id>0;";
						flag = (iD.Length > 0);
						if (flag)
						{
							text = text + " delete from sanad where id in (" + iD + ");";
						}
						flag = (text.Length > 0);
						if (flag)
						{
							Public_Function.ExecuteNonQuery(text);
						}
					}
					Public_Function.ConfirmInsert();
					this.Close();
				}
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_ClearData_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x040002A6 RID: 678
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002A8 RID: 680
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002A9 RID: 681
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040002AA RID: 682
		[AccessedThroughProperty("txt_moshtari")]
		private UICheckBox _txt_moshtari;

		// Token: 0x040002AB RID: 683
		[AccessedThroughProperty("txt_hesab")]
		private UICheckBox _txt_hesab;

		// Token: 0x040002AC RID: 684
		[AccessedThroughProperty("txt_mande_avalie")]
		private UICheckBox _txt_mande_avalie;
	}
}
