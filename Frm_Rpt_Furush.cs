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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000130 RID: 304
	[DesignerGenerated]
	public partial class Frm_Rpt_Furush : Form
	{
		// Token: 0x06002BF5 RID: 11253 RVA: 0x0000B0CF File Offset: 0x000092CF
		[DebuggerNonUserCode]
		public Frm_Rpt_Furush()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Rpt_Furush_KeyDown);
			Frm_Rpt_Furush.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x0020B180 File Offset: 0x00209380
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Rpt_Furush.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Rpt_Furush.__ENCList.Count == Frm_Rpt_Furush.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Rpt_Furush.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Rpt_Furush.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Rpt_Furush.__ENCList[num] = Frm_Rpt_Furush.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Rpt_Furush.__ENCList.RemoveRange(num, Frm_Rpt_Furush.__ENCList.Count - num);
						Frm_Rpt_Furush.__ENCList.Capacity = Frm_Rpt_Furush.__ENCList.Count;
					}
					Frm_Rpt_Furush.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x0020BD28 File Offset: 0x00209F28
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x0000B0FB File Offset: 0x000092FB
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

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x0020BD40 File Offset: 0x00209F40
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x0000B105 File Offset: 0x00009305
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

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x0020BD58 File Offset: 0x00209F58
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x0020BD70 File Offset: 0x00209F70
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

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x0020BDD0 File Offset: 0x00209FD0
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x0000B10F File Offset: 0x0000930F
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x0020BDE8 File Offset: 0x00209FE8
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x0020BE00 File Offset: 0x0020A000
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
				KeyEventHandler value3 = new KeyEventHandler(this.EditBox1_KeyDown);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
					this._EditBox1.KeyDown -= value3;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
					this._EditBox1.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x0020BE88 File Offset: 0x0020A088
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x0000B119 File Offset: 0x00009319
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x0020BEA0 File Offset: 0x0020A0A0
		// (set) Token: 0x06002C06 RID: 11270 RVA: 0x0000B123 File Offset: 0x00009323
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002C07 RID: 11271 RVA: 0x0020BEB8 File Offset: 0x0020A0B8
		// (set) Token: 0x06002C08 RID: 11272 RVA: 0x0020BED0 File Offset: 0x0020A0D0
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

		// Token: 0x06002C09 RID: 11273 RVA: 0x0020BF30 File Offset: 0x0020A130
		public void loaddata()
		{
			DataTable dataSource = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT    Furush_Hag.ID,1 as sanadtype,num as onum, cast(Furush_Hag.Num as nvarchar(5))+'/فروش' as num,  Furush_Hag.Sh_Mashin, Furush_Hag.Sh_Barname, Furush_Hag.Tarikh_Vurud  FROM         Furush_Hag INNER JOIN  Moshtari ON Furush_Hag.Moshtari_ID = Moshtari.ID where moshtari_id=", this.txt_moshtari.Value), " union all "), " SELECT     Kharid.ID,2 as sanadtype,num as onum,cast(Kharid.Num as nvarchar(5))+'/خرید' as num, Kharid.Sh_Mashin, Kharid.Sh_Barname, Kharid.Tarikh_Vurud "), " FROM         Kharid INNER JOIN "), " Moshtari ON Kharid.Moshtari_ID = Moshtari.ID where moshtari_id="), this.txt_moshtari.Value)));
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x0000B12D File Offset: 0x0000932D
		private void txt_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.loaddata();
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x0000B138 File Offset: 0x00009338
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x0020BFB0 File Offset: 0x0020A1B0
		private void EditBox1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1.Focus();
			}
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x0020BFDC File Offset: 0x0020A1DC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow == null;
			if (!flag)
			{
				flag = Operators.ConditionalCompareObjectEqual(this.GridEX1.CurrentRow.Cells["sanadtype"].Value, 1, false);
				if (flag)
				{
					frm_Frush_hag frm_Frush_hag = new frm_Frush_hag();
					frm_Frush_hag.Num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["onum"].Value);
					frm_Frush_hag.Visible = false;
					frm_Frush_hag.WindowState = FormWindowState.Minimized;
					frm_Frush_hag.ShowInTaskbar = false;
					frm_Frush_hag.Show_Preview = true;
					frm_Frush_hag.Show();
					frm_Frush_hag.ButtonItem14_Click(null, null);
					frm_Frush_hag.Close();
				}
				else
				{
					Frm_Kharid_Furush frm_Kharid_Furush = new Frm_Kharid_Furush();
					frm_Kharid_Furush.Num = Conversions.ToInteger(this.GridEX1.CurrentRow.Cells["onum"].Value);
					frm_Kharid_Furush.Visible = false;
					frm_Kharid_Furush.WindowState = FormWindowState.Minimized;
					frm_Kharid_Furush.ShowInTaskbar = false;
					frm_Kharid_Furush.Show_Preview = true;
					frm_Kharid_Furush.Show();
					frm_Kharid_Furush.ButtonItem12_Click(null, null);
					frm_Kharid_Furush.Close();
				}
			}
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x0020C108 File Offset: 0x0020A308
		private void Frm_Rpt_Furush_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.F4;
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			else
			{
				flag = (keyCode == Keys.Escape);
				if (flag)
				{
					this.Close();
				}
			}
		}

		// Token: 0x0400111B RID: 4379
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400111D RID: 4381
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400111E RID: 4382
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400111F RID: 4383
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04001120 RID: 4384
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001121 RID: 4385
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001122 RID: 4386
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04001123 RID: 4387
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001124 RID: 4388
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;
	}
}
