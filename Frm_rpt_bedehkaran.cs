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
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x02000124 RID: 292
	[DesignerGenerated]
	public partial class Frm_rpt_bedehkaran : Form
	{
		// Token: 0x06002A4D RID: 10829 RVA: 0x001FCB78 File Offset: 0x001FAD78
		public Frm_rpt_bedehkaran()
		{
			base.FormClosing += new FormClosingEventHandler(this.Frm_rpt_bedehkaran_FormClosing);
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_bedehkaran_KeyDown);
			Frm_rpt_bedehkaran.__ENCAddToList(this);
			this.moshtari = new Moshtari_Info();
			bool is_Listdirkard = false;
			this.Is_Listdirkard = is_Listdirkard;
			this.InitializeComponent();
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x001FCBEC File Offset: 0x001FADEC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_bedehkaran.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_bedehkaran.__ENCList.Count == Frm_rpt_bedehkaran.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_bedehkaran.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_bedehkaran.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_bedehkaran.__ENCList[num] = Frm_rpt_bedehkaran.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_bedehkaran.__ENCList.RemoveRange(num, Frm_rpt_bedehkaran.__ENCList.Count - num);
						Frm_rpt_bedehkaran.__ENCList.Capacity = Frm_rpt_bedehkaran.__ENCList.Count;
					}
					Frm_rpt_bedehkaran.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x001FE6BC File Offset: 0x001FC8BC
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0000A8B3 File Offset: 0x00008AB3
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

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x001FE6D4 File Offset: 0x001FC8D4
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x0000A8BD File Offset: 0x00008ABD
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

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x001FE6EC File Offset: 0x001FC8EC
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0000A8C7 File Offset: 0x00008AC7
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

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x001FE704 File Offset: 0x001FC904
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x001FE71C File Offset: 0x001FC91C
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

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x001FE77C File Offset: 0x001FC97C
		// (set) Token: 0x06002A5A RID: 10842 RVA: 0x001FE794 File Offset: 0x001FC994
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

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x001FE7F4 File Offset: 0x001FC9F4
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x0000A8D1 File Offset: 0x00008AD1
		internal virtual UIProgressBar UiProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiProgressBar1 = value;
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x001FE80C File Offset: 0x001FCA0C
		// (set) Token: 0x06002A5E RID: 10846 RVA: 0x0000A8DB File Offset: 0x00008ADB
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x001FE824 File Offset: 0x001FCA24
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x001FE83C File Offset: 0x001FCA3C
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiComboBox1_SelectedIndexChanged);
				bool flag = this._UiComboBox1 != null;
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged -= value2;
				}
				this._UiComboBox1 = value;
				flag = (this._UiComboBox1 != null);
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x001FE89C File Offset: 0x001FCA9C
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x001FE8B4 File Offset: 0x001FCAB4
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
				SelectItem.ValueDeletedEventHandler obj = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				SelectItem.SelectedValueChangedEventHandler obj2 = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				bool flag = this._txt_moshtari != null;
				if (flag)
				{
					this._txt_moshtari.ValueDeleted -= obj;
					this._txt_moshtari.SelectedValueChanged -= obj2;
				}
				this._txt_moshtari = value;
				flag = (this._txt_moshtari != null);
				if (flag)
				{
					this._txt_moshtari.ValueDeleted += obj;
					this._txt_moshtari.SelectedValueChanged += obj2;
				}
			}
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x001FE93C File Offset: 0x001FCB3C
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x0000A8E5 File Offset: 0x00008AE5
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

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x001FE954 File Offset: 0x001FCB54
		// (set) Token: 0x06002A66 RID: 10854 RVA: 0x001FE96C File Offset: 0x001FCB6C
		internal virtual EditBox txt_search
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_search_TextChanged);
				bool flag = this._txt_search != null;
				if (flag)
				{
					this._txt_search.TextChanged -= value2;
				}
				this._txt_search = value;
				flag = (this._txt_search != null);
				if (flag)
				{
					this._txt_search.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x001FE9CC File Offset: 0x001FCBCC
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0000A8EF File Offset: 0x00008AEF
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06002A69 RID: 10857 RVA: 0x001FE9E4 File Offset: 0x001FCBE4
		// (set) Token: 0x06002A6A RID: 10858 RVA: 0x001FE9FC File Offset: 0x001FCBFC
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

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x001FEA5C File Offset: 0x001FCC5C
		// (set) Token: 0x06002A6C RID: 10860 RVA: 0x001FEA74 File Offset: 0x001FCC74
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

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002A6D RID: 10861 RVA: 0x001FEAD4 File Offset: 0x001FCCD4
		// (set) Token: 0x06002A6E RID: 10862 RVA: 0x001FEAEC File Offset: 0x001FCCEC
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

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002A6F RID: 10863 RVA: 0x001FEB4C File Offset: 0x001FCD4C
		// (set) Token: 0x06002A70 RID: 10864 RVA: 0x001FEB64 File Offset: 0x001FCD64
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

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002A71 RID: 10865 RVA: 0x001FEBC4 File Offset: 0x001FCDC4
		// (set) Token: 0x06002A72 RID: 10866 RVA: 0x001FEBDC File Offset: 0x001FCDDC
		internal virtual ButtonItem ButtonItem6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem6_Click);
				bool flag = this._ButtonItem6 != null;
				if (flag)
				{
					this._ButtonItem6.Click -= value2;
				}
				this._ButtonItem6 = value;
				flag = (this._ButtonItem6 != null);
				if (flag)
				{
					this._ButtonItem6.Click += value2;
				}
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002A73 RID: 10867 RVA: 0x001FEC3C File Offset: 0x001FCE3C
		// (set) Token: 0x06002A74 RID: 10868 RVA: 0x001FEC54 File Offset: 0x001FCE54
		internal virtual EditBox txt_tedadruz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedadruz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_search_TextChanged);
				EventHandler value3 = new EventHandler(this.EditBox1_Validated);
				bool flag = this._txt_tedadruz != null;
				if (flag)
				{
					this._txt_tedadruz.TextChanged -= value2;
					this._txt_tedadruz.Validated -= value3;
				}
				this._txt_tedadruz = value;
				flag = (this._txt_tedadruz != null);
				if (flag)
				{
					this._txt_tedadruz.TextChanged += value2;
					this._txt_tedadruz.Validated += value3;
				}
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x001FECDC File Offset: 0x001FCEDC
		// (set) Token: 0x06002A76 RID: 10870 RVA: 0x0000A8F9 File Offset: 0x00008AF9
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002A77 RID: 10871 RVA: 0x001FECF4 File Offset: 0x001FCEF4
		// (set) Token: 0x06002A78 RID: 10872 RVA: 0x0000A903 File Offset: 0x00008B03
		internal virtual UICheckBox UiCheckBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox1 = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002A79 RID: 10873 RVA: 0x001FED0C File Offset: 0x001FCF0C
		// (set) Token: 0x06002A7A RID: 10874 RVA: 0x0000A90D File Offset: 0x00008B0D
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002A7B RID: 10875 RVA: 0x001FED24 File Offset: 0x001FCF24
		// (set) Token: 0x06002A7C RID: 10876 RVA: 0x001FED3C File Offset: 0x001FCF3C
		internal virtual SelectItem txt_noe_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_noe_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.txt_noe_moshtari_SelectedValueChanged);
				EventHandler value2 = new EventHandler(this.txt_noe_moshtari_TextChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.txt_noe_moshtari_ValueDeleted);
				EventHandler value3 = new EventHandler(this.moaref_kind_ButtonClick);
				KeyEventHandler value4 = new KeyEventHandler(this.txt_noe_moshtari_KeyDown);
				bool flag = this._txt_noe_moshtari != null;
				if (flag)
				{
					this._txt_noe_moshtari.SelectedValueChanged -= obj;
					this._txt_noe_moshtari.TextChanged -= value2;
					this._txt_noe_moshtari.ValueDeleted -= obj2;
					this._txt_noe_moshtari.ButtonClick -= value3;
					this._txt_noe_moshtari.KeyDown -= value4;
				}
				this._txt_noe_moshtari = value;
				flag = (this._txt_noe_moshtari != null);
				if (flag)
				{
					this._txt_noe_moshtari.SelectedValueChanged += obj;
					this._txt_noe_moshtari.TextChanged += value2;
					this._txt_noe_moshtari.ValueDeleted += obj2;
					this._txt_noe_moshtari.ButtonClick += value3;
					this._txt_noe_moshtari.KeyDown += value4;
				}
			}
		}

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002A7D RID: 10877 RVA: 0x001FEE44 File Offset: 0x001FD044
		// (set) Token: 0x06002A7E RID: 10878 RVA: 0x0000A917 File Offset: 0x00008B17
		internal virtual UICheckBox UiCheckBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox2 = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002A7F RID: 10879 RVA: 0x001FEE5C File Offset: 0x001FD05C
		// (set) Token: 0x06002A80 RID: 10880 RVA: 0x001FEE74 File Offset: 0x001FD074
		internal virtual UICheckBox UiCheckBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiCheckBox2_CheckedChanged);
				bool flag = this._UiCheckBox3 != null;
				if (flag)
				{
					this._UiCheckBox3.CheckedChanged -= value2;
				}
				this._UiCheckBox3 = value;
				flag = (this._UiCheckBox3 != null);
				if (flag)
				{
					this._UiCheckBox3.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002A81 RID: 10881 RVA: 0x001FEED4 File Offset: 0x001FD0D4
		// (set) Token: 0x06002A82 RID: 10882 RVA: 0x001FEEEC File Offset: 0x001FD0EC
		internal virtual DateBox2 txt_ta_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ta_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown);
				bool flag = this._txt_ta_tarikh != null;
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown -= value2;
				}
				this._txt_ta_tarikh = value;
				flag = (this._txt_ta_tarikh != null);
				if (flag)
				{
					this._txt_ta_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x001FEF4C File Offset: 0x001FD14C
		// (set) Token: 0x06002A84 RID: 10884 RVA: 0x001FEF64 File Offset: 0x001FD164
		internal virtual DateBox2 txt_az_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_az_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown);
				bool flag = this._txt_az_tarikh != null;
				if (flag)
				{
					this._txt_az_tarikh.KeyDown -= value2;
				}
				this._txt_az_tarikh = value;
				flag = (this._txt_az_tarikh != null);
				if (flag)
				{
					this._txt_az_tarikh.KeyDown += value2;
				}
			}
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002A85 RID: 10885 RVA: 0x001FEFC4 File Offset: 0x001FD1C4
		// (set) Token: 0x06002A86 RID: 10886 RVA: 0x0000A921 File Offset: 0x00008B21
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002A87 RID: 10887 RVA: 0x001FEFDC File Offset: 0x001FD1DC
		// (set) Token: 0x06002A88 RID: 10888 RVA: 0x001FEFF4 File Offset: 0x001FD1F4
		internal virtual ButtonItem ButtonItem8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem8_Click);
				bool flag = this._ButtonItem8 != null;
				if (flag)
				{
					this._ButtonItem8.Click -= value2;
				}
				this._ButtonItem8 = value;
				flag = (this._ButtonItem8 != null);
				if (flag)
				{
					this._ButtonItem8.Click += value2;
				}
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06002A89 RID: 10889 RVA: 0x001FF054 File Offset: 0x001FD254
		// (set) Token: 0x06002A8A RID: 10890 RVA: 0x0000A92B File Offset: 0x00008B2B
		internal virtual FolderBrowserDialog FolderBrowserDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FolderBrowserDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FolderBrowserDialog1 = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x001FF06C File Offset: 0x001FD26C
		// (set) Token: 0x06002A8C RID: 10892 RVA: 0x001FF084 File Offset: 0x001FD284
		internal virtual ButtonItem ButtonItem7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem7_Click);
				bool flag = this._ButtonItem7 != null;
				if (flag)
				{
					this._ButtonItem7.Click -= value2;
				}
				this._ButtonItem7 = value;
				flag = (this._ButtonItem7 != null);
				if (flag)
				{
					this._ButtonItem7.Click += value2;
				}
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x001FF0E4 File Offset: 0x001FD2E4
		// (set) Token: 0x06002A8E RID: 10894 RVA: 0x0000A935 File Offset: 0x00008B35
		public bool Is_Listdirkard
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Is_Listdirkard;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Is_Listdirkard = value;
			}
		}

		// Token: 0x06002A8F RID: 10895 RVA: 0x001FF0FC File Offset: 0x001FD2FC
		private int GetNextPosBed(int pos, DataRow[] dr)
		{
			long num = 0L;
			checked
			{
				int arg_0E_0 = pos + 1;
				int num2 = dr.Length - 1;
				int num3 = arg_0E_0;
				while (true)
				{
					int arg_15D_0 = num3;
					int num4 = num2;
					if (arg_15D_0 > num4)
					{
						goto Block_6;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dr[num3]["bed"], 0, false);
					if (flag)
					{
						break;
					}
					num3++;
				}
				int num5;
				bool flag2 = num5 + 1 > dr.Length - 1;
				int result;
				if (flag2)
				{
					dr[num5]["rembed"] = num;
					result = num5;
					return result;
				}
				num5 = num3;
				num = Conversions.ToLong(dr[num3]["rembed"]);
				DateTime dateTime = Conversions.ToDate(dr[num3]["tarikh"]);
				int arg_99_0 = num5 + 1;
				int num6 = dr.Length - 1;
				int num7 = arg_99_0;
				while (true)
				{
					int arg_130_0 = num7;
					int num4 = num6;
					if (arg_130_0 > num4)
					{
						goto Block_5;
					}
					flag2 = (Operators.ConditionalCompareObjectEqual(dr[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dr[num7]["bed"], 0, false));
					if (!flag2)
					{
						break;
					}
					num5 = num7;
					num = Conversions.ToLong(Operators.AddObject(num, dr[num7]["rembed"]));
					num7++;
				}
				dr[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_5:
				dr[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_6:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002A90 RID: 10896 RVA: 0x001FF270 File Offset: 0x001FD470
		private int GetNextPosBes(int pos, DataRow[] dr)
		{
			checked
			{
				int arg_0A_0 = pos + 1;
				int num = dr.Length - 1;
				int num2 = arg_0A_0;
				while (true)
				{
					int arg_3A_0 = num2;
					int num3 = num;
					if (arg_3A_0 > num3)
					{
						goto Block_2;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dr[num2]["bes"], 0, false);
					if (flag)
					{
						break;
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_2:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002A91 RID: 10897 RVA: 0x001FF2C0 File Offset: 0x001FD4C0
		public string GetLastTarikh(long Codehesab_ID, DataRow[] dr)
		{
			Codehesab_ID = Codehesab_ID;
			string result = string.Empty;
			int num = 0;
			checked
			{
				for (int i = 0; i < dr.Length; i++)
				{
					DataRow dataRow = dr[i];
					long num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow["bed"]));
					num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow["bes"]));
					bool flag = num2 > 0L;
					if (flag)
					{
						dataRow["stat"] = "بد";
					}
					else
					{
						flag = (num2 < 0L);
						if (flag)
						{
							dataRow["stat"] = "بس";
						}
						else
						{
							dataRow["stat"] = "ت";
						}
					}
					num++;
				}
				int num3 = -1;
				int num4 = -1;
				string left = string.Empty;
				num3 = this.GetNextPosBed(num3, dr);
				num4 = this.GetNextPosBes(num4, dr);
				bool flag2;
				while (num3 != -1 && num4 != -1)
				{
					bool flag = Operators.ConditionalCompareObjectLess(dr[num4]["rembes"], dr[num3]["rembed"], false);
					if (flag)
					{
						flag2 = (Operators.CompareString(left, string.Empty, false) != 0);
						if (flag2)
						{
							left = string.Empty;
						}
						int num5 = num3;
						DataRow arg_17A_0 = dr[num5];
						string columnName = "rembed";
						arg_17A_0[columnName] = Operators.SubtractObject(dr[num5][columnName], dr[num4]["rembes"]);
						flag2 = Operators.ConditionalCompareObjectNotEqual(dr[num4]["stat"], "ت", false);
						if (flag2)
						{
							result = Conversions.ToString(dr[num3]["Tarikh_Fa"]);
						}
						num4 = this.GetNextPosBes(num4, dr);
					}
					else
					{
						long num6 = Conversions.ToLong(Operators.SubtractObject(dr[num4]["rembes"], dr[num3]["rembed"]));
						dr[num3]["rembed"] = 0;
						left = Conversions.ToString(dr[num3]["Tarikh_Fa"]);
						num3 = this.GetNextPosBed(num3, dr);
						dr[num4]["rembes"] = num6;
					}
				}
				flag2 = (num3 != -1 && num4 == -1);
				if (flag2)
				{
					result = Conversions.ToString(dr[num3]["Tarikh_Fa"]);
				}
				return result;
			}
		}

		// Token: 0x06002A92 RID: 10898 RVA: 0x001FF550 File Offset: 0x001FD750
		private void Preparedt(DataTable dt)
		{
			bool flag = dt.Rows.Count == 0;
			checked
			{
				if (!flag)
				{
					this.txt_moshtari.Enabled = false;
					dt.Columns.Add("tarikh", typeof(string));
					this.UiProgressBar1.Visible = true;
					this.UiProgressBar1.Maximum = dt.Rows.Count;
					this.UiProgressBar1.Value = 0;
					GridEX gridEX = this.GridEX1;
					gridEX.Height -= this.UiProgressBar1.Height;
					int count = dt.Rows.Count;
					int num = count / 50;
					string text = string.Empty;
					string text2 = string.Empty;
					int arg_BA_0 = 0;
					int num2 = num;
					int num3 = arg_BA_0;
					while (true)
					{
						int arg_32A_0 = num3;
						int num4 = num2;
						if (arg_32A_0 > num4)
						{
							break;
						}
						int arg_D1_0 = num3 * 50;
						int num5 = (num3 + 1) * 50 - 1;
						int num6 = arg_D1_0;
						while (true)
						{
							int arg_1A9_0 = num6;
							num4 = num5;
							if (arg_1A9_0 > num4)
							{
								break;
							}
							this.UiProgressBar1.Value = num6;
							flag = (num6 > dt.Rows.Count - 1);
							if (flag)
							{
								goto Block_2;
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dt.Rows[num6]["codehesab_id"], ",")));
							text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(dt.Rows[num6]["id"], ",")));
							num6++;
						}
						IL_1AE:
						text = Public_Function.RemoveLast(text);
						flag = (Operators.CompareString(text, string.Empty, false) == 0);
						if (!flag)
						{
							text2 = Public_Function.RemoveLast(text2);
							Application.DoEvents();
							string empty = string.Empty;
							DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
							{
								"SELECT     ID, Bed, Bes,Bed as rembed,Bes as rembes,codehesab_id,tarikh, Tarikh_Fa  FROM Sanad where CodeHesab_ID in(",
								text,
								") and ID not in (select sanadbed_id from  daryaftpardakht where  moshtari_id IN(",
								text2,
								") and dptype_id=22 and pardakhtcheck_id not in (select id from daryaftpardakht where dptype_id=-99 and moshtari_id IN(",
								text2,
								" )))  AND ID NOT IN (select sanadbes_id from daryaftpardakht where sanadbes_id is not null and moshtari_id IN(",
								text2,
								") and id in (select pardakhtcheck_id from daryaftpardakht where dptype_id=22) and dptype_id<> -99) order by CodeHesab_ID,Tarikh,bed,bes"
							}));
							dataTable.Columns.Add("stat", typeof(string));
							int arg_276_0 = num3 * 50;
							int num7 = (num3 + 1) * 50 - 1;
							int num8 = arg_276_0;
							while (true)
							{
								int arg_310_0 = num8;
								num4 = num7;
								if (arg_310_0 > num4)
								{
									break;
								}
								flag = (num8 > dt.Rows.Count - 1);
								if (flag)
								{
									break;
								}
								DataRow[] dr = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("codehesab_id=", dt.Rows[num8]["codehesab_id"])));
								dt.Rows[num8]["tarikh"] = this.GetLastTarikh(Conversions.ToLong(dt.Rows[num8]["codehesab_id"]), dr);
								num8++;
							}
							IL_315:
							text = string.Empty;
							goto IL_31B;
							goto IL_315;
						}
						IL_31B:
						num3++;
						continue;
						Block_2:
						this.UiProgressBar1.Visible = false;
						gridEX = this.GridEX1;
						gridEX.Height += this.UiProgressBar1.Height;
						this.UiComboBox1.SelectedIndex = 2;
						goto IL_1AE;
					}
					this.txt_moshtari.Enabled = true;
					this.txt_search.Focus();
				}
			}
		}

		// Token: 0x06002A93 RID: 10899 RVA: 0x001FF8A8 File Offset: 0x001FDAA8
		private void LoadData()
		{
			string text = string.Empty;
			bool flag = this.txt_moshtari.Value != null && Operators.CompareString(this.txt_moshtari.Value.ToString(), string.Empty, false) != 0;
			bool flag3;
			if (flag)
			{
				object left = this.txt_moshtari.SelectedRow["kind"];
				bool flag2 = Operators.ConditionalCompareObjectEqual(left, 0, false);
				if (flag2)
				{
					flag3 = Operators.ConditionalCompareObjectEqual(this.txt_moshtari.Value, -1, false);
					if (flag3)
					{
						text = " AND (Moshtari.GrouhMoshtari_ID is not null) ";
					}
					else
					{
						text = " AND (Moshtari.GrouhMoshtari2_ID is not null) ";
					}
				}
				else
				{
					flag3 = Operators.ConditionalCompareObjectEqual(left, 1, false);
					if (flag3)
					{
						text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (Moshtari.GrouhMoshtari_ID=", this.txt_moshtari.Value), ") "));
					}
					else
					{
						flag3 = Operators.ConditionalCompareObjectEqual(left, 2, false);
						if (flag3)
						{
							text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(" AND (Moshtari.GrouhMoshtari2_ID=", this.txt_moshtari.Value), ") "));
						}
					}
				}
			}
			flag3 = (this.txt_noe_moshtari.Value != null && Operators.CompareString(this.txt_noe_moshtari.Value.ToString(), string.Empty, false) != 0);
			if (flag3)
			{
				bool flag2 = Operators.ConditionalCompareObjectEqual(this.txt_noe_moshtari.Value, "1", false);
				if (flag2)
				{
					text += " AND (Moshtari.kind in (1,3,5))";
				}
				else
				{
					text += " AND (Moshtari.kind in (2,4,6))";
				}
			}
			flag3 = this.UiCheckBox3.Checked;
			if (flag3)
			{
				text = string.Concat(new string[]
				{
					text,
					" AND Sanad.Tarikh between ",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)),
					" AND ",
					Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text))
				});
			}
			DataTable dataTable = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     t.bes, t.bed, t.jam_bed, t.CodeHesab_ID, t.Moshtari_Name, Moshtari_1.ID, Moshtari_1.Name, Moshtari_1.Family, Moshtari_1.AvalDore_Tarikh,Moshtari_1.tel2 as tel,Moshtari_1.tel1,Moshtari_1.tel2,Moshtari_1.tel3,Moshtari_1.tel4,1 as visible,  m.count AS Check_Count, m.mablagh AS Check_Mablagh FROM         (SELECT     SUM(Sanad.Bes) AS bes, SUM(Sanad.Bed) AS bed, SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID, MIN(Code_Hesab.Name)  AS Moshtari_Name FROM         Sanad INNER JOIN Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN  Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN  (SELECT     Moshtari_ID  FROM         Sharik)) AND (Moshtari.ID NOT IN  (SELECT     Moshtari_ID  FROM         Moshtari_ListSiah)) ",
				text,
				" GROUP BY Sanad.CodeHesab_ID  HAVING      (SUM(Sanad.Bed - Sanad.Bes) > 0)) AS t INNER JOIN  Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID LEFT OUTER JOIN  (SELECT     Moshtari_ID, COUNT(ID) AS count, SUM(Mablagh) AS mablagh  FROM DaryaftPardakht  WHERE     (dpType_ID = 2) AND (Check_Status IN (1, 2)) AND (PardakhtCheck_ID IS NULL)  GROUP BY Moshtari_ID) AS m ON Moshtari_1.ID = m.Moshtari_ID union all                                        SELECT     t.bes, t.bed, t.jam_bed, t.CodeHesab_ID, t.Moshtari_Name, Moshtari_1.ID, Moshtari_1.Name, Moshtari_1.Family, Moshtari_1.AvalDore_Tarikh,Moshtari_1.tel2 as tel,Moshtari_1.tel1,Moshtari_1.tel2,Moshtari_1.tel3,Moshtari_1.tel4,1 as visible,                       m.count AS Check_Count, m.mablagh AS Check_Mablagh  FROM         (SELECT     SUM(Sanad.Bes) AS bes, SUM(Sanad.Bed) AS bed, SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID, MIN(Code_Hesab.Name)                                                AS Moshtari_Name                          FROM         Sanad INNER JOIN                                                Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN                                                Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID                          WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN                                                    (SELECT     Moshtari_ID                                                       FROM         Sharik)) AND (Moshtari.ID NOT IN                                                    (SELECT     Moshtari_ID                                                       FROM         Moshtari_ListSiah)) ",
				text,
				"                         GROUP BY Sanad.CodeHesab_ID                          HAVING      (SUM(Sanad.Bed - Sanad.Bes) = 0)) AS t INNER JOIN                        Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID INNER JOIN                            (SELECT     Moshtari_ID, COUNT(ID) AS count, SUM(Mablagh) AS mablagh                               FROM         DaryaftPardakht                               WHERE     (dpType_ID = 2) AND (Check_Status IN (1, 2)) AND (PardakhtCheck_ID IS NULL)                               GROUP BY Moshtari_ID                               HAVING      (COUNT(ID) > 0)) AS m ON Moshtari_1.ID = m.Moshtari_ID "
			}));
			dataTable.Columns.Add("jam_kol", typeof(long));
			try
			{
				IEnumerator enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag3 = (dataRow["check_mablagh"] != DBNull.Value);
					if (flag3)
					{
						dataRow["jam_kol"] = Operators.AddObject(dataRow["jam_bed"], dataRow["check_mablagh"]);
					}
					else
					{
						dataRow["jam_kol"] = RuntimeHelpers.GetObjectValue(dataRow["jam_bed"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				flag3 = (enumerator is IDisposable);
				if (flag3)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			try
			{
				IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					flag3 = (dataRow2["tel2"] != DBNull.Value);
					if (flag3)
					{
						dataRow2["tel"] = RuntimeHelpers.GetObjectValue(dataRow2["tel2"]);
					}
					flag3 = (dataRow2["tel1"] != DBNull.Value);
					if (flag3)
					{
						dataRow2["tel"] = RuntimeHelpers.GetObjectValue(dataRow2["tel1"]);
					}
					flag3 = (dataRow2["tel3"] != DBNull.Value);
					if (flag3)
					{
						dataRow2["tel"] = RuntimeHelpers.GetObjectValue(dataRow2["tel3"]);
					}
					flag3 = (dataRow2["tel4"] != DBNull.Value);
					if (flag3)
					{
						dataRow2["tel"] = RuntimeHelpers.GetObjectValue(dataRow2["tel4"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag3 = (enumerator2 is IDisposable);
				if (flag3)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			this.GridEX1.DataSource = dataTable;
		}

		// Token: 0x06002A94 RID: 10900 RVA: 0x001FFD2C File Offset: 0x001FDF2C
		private void Frm_rpt_bedehkaran_FormClosing(object sender, FormClosingEventArgs e)
		{
			setting setting = new setting();
			bool @checked = this.UiCheckBox1.Checked;
			if (@checked)
			{
				setting.Update("bedehkaran_jamkol", Conversions.ToString(true));
				Public_Function.dict["bedehkaran_jamkol"] = Conversions.ToString(true);
			}
			else
			{
				setting.Update("bedehkaran_jamkol", Conversions.ToString(false));
				Public_Function.dict["bedehkaran_jamkol"] = Conversions.ToString(false);
			}
			@checked = this.UiCheckBox2.Checked;
			if (@checked)
			{
				setting.Update("bedehkaran_tel", Conversions.ToString(true));
				Public_Function.dict["bedehkaran_tel"] = Conversions.ToString(true);
			}
			else
			{
				setting.Update("bedehkaran_tel", Conversions.ToString(false));
				Public_Function.dict["bedehkaran_tel"] = Conversions.ToString(false);
			}
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x001FFE08 File Offset: 0x001FE008
		private void Frm_rpt_bedehkaran_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F5);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x001FFE78 File Offset: 0x001FE078
		private void UiCheckBox2_CheckedChanged(object sender, EventArgs e)
		{
			this.txt_az_tarikh.Enabled = this.UiCheckBox3.Checked;
			this.txt_ta_tarikh.Enabled = this.UiCheckBox3.Checked;
			bool @checked = this.UiCheckBox3.Checked;
			if (@checked)
			{
				this.txt_az_tarikh.FocusDatePart = 1;
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.Focus();
			}
			else
			{
				this.LoadData();
				this.Preparedt((DataTable)this.GridEX1.DataSource);
			}
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x001FFF0C File Offset: 0x001FE10C
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			bool flag = this.Is_Listdirkard;
			if (flag)
			{
				this.Label4.Visible = true;
				this.txt_tedadruz.Visible = true;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["bedehkaran_tel"]);
			if (flag)
			{
				this.UiCheckBox2.Checked = true;
			}
			else
			{
				this.UiCheckBox2.Checked = false;
			}
			flag = Conversions.ToBoolean(Public_Function.dict["bedehkaran_jamkol"]);
			if (flag)
			{
				this.UiCheckBox1.Checked = true;
			}
			else
			{
				this.UiCheckBox1.Checked = false;
			}
			this.LoadData();
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x001FFFCC File Offset: 0x001FE1CC
		private void SetHeader(StiReport rpt, bool Pdf = false)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			bool flag2;
			if (flag)
			{
				flag2 = !Pdf;
				if (flag2)
				{
					stiText.Text = Public_Function.ToFarsi(Public_Function.dict["head1"]);
				}
				else
				{
					stiText.Text = Public_Function.RenderDigitToPdf(Public_Function.dict["head1"]);
				}
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			flag2 = (stiText != null);
			if (flag2)
			{
				flag = !Pdf;
				if (flag)
				{
					stiText.Text = Public_Function.ToFarsi(Public_Function.dict["head2"]);
				}
				else
				{
					stiText.Text = Public_Function.RenderDigitToPdf(Public_Function.dict["head2"]);
				}
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			flag2 = (stiText != null);
			if (flag2)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			flag2 = Public_Function.dict.ContainsKey("eval");
			if (flag2)
			{
				flag = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag)
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x0020015C File Offset: 0x001FE35C
		private StiReport RenderReport(bool pdf)
		{
			StiReport stiReport = new StiReport();
			bool flag = !this.ButtonItem6.Checked;
			if (flag)
			{
				stiReport.Load(Application.StartupPath + "\\reports\\bedehkaran.mrt");
				Public_Function.setReportFont(stiReport, "Text10,Text13,Text7,Text5,Text2");
			}
			else
			{
				stiReport.Load(Application.StartupPath + "\\reports\\ebedehkaran.mrt");
				Public_Function.setReportFont(stiReport, "Text10,Text14,Text7,Text5,Text15,Text16");
			}
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			dataTable.DefaultView.RowFilter = "visible=1";
			stiReport.RegData(dataTable.DefaultView);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("txt_tarikh");
			stiText.Text.Value = Public_Function.MiladiToShamsi(DateAndTime.Now);
			flag = (this.UiComboBox1.SelectedIndex == 4);
			if (flag)
			{
				stiText = (StiText)stiReport.GetComponentByName("Text7");
				stiText.Text.Value = "{viewdata.avaldore_tarikh}";
			}
			StiFooterBand stiFooterBand = new StiFooterBand();
			stiFooterBand = (StiFooterBand)stiReport.GetComponentByName("FooterBand1");
			flag = this.UiCheckBox1.Checked;
			if (flag)
			{
				stiFooterBand.Enabled = true;
			}
			else
			{
				stiFooterBand.Enabled = false;
			}
			flag = (Operators.CompareString(this.txt_moshtari.Text, string.Empty, false) != 0);
			if (flag)
			{
				stiText = (StiText)stiReport.GetComponentByName("Text11");
				stiText.Text.Value = stiText.Text.Value + " - " + this.txt_moshtari.Text;
			}
			flag = !this.UiCheckBox2.Checked;
			if (flag)
			{
				stiText = (StiText)stiReport.GetComponentByName("Text13");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text1");
				stiText.Height = 0.8;
			}
			this.SetHeader(stiReport, pdf);
			Public_Function.AddTazminText(stiReport, true, pdf);
			Public_Function.SetReport_MarginTop(stiReport);
			return stiReport;
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00200380 File Offset: 0x001FE580
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport != null;
			if (flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0000A93F File Offset: 0x00008B3F
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x002003AC File Offset: 0x001FE5AC
		private void UiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				this.GridEX1.RootTable.Columns["tarikh"].Visible = true;
				this.GridEX1.RootTable.Columns["avaldore_tarikh"].Visible = false;
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				object selectedValue = this.UiComboBox1.SelectedValue;
				flag = Operators.ConditionalCompareObjectEqual(selectedValue, 0, false);
				if (flag)
				{
					dataTable.DefaultView.Sort = "tarikh";
				}
				else
				{
					flag = Operators.ConditionalCompareObjectEqual(selectedValue, 1, false);
					if (flag)
					{
						dataTable.DefaultView.Sort = "jam_bed desc";
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(selectedValue, 3, false);
						if (flag)
						{
							dataTable.DefaultView.Sort = "name asc,family asc";
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(selectedValue, 2, false);
							if (flag)
							{
								dataTable.DefaultView.Sort = "family";
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(selectedValue, 4, false);
								if (flag)
								{
									dataTable.DefaultView.Sort = "avaldore_tarikh";
									this.GridEX1.RootTable.Columns["tarikh"].Visible = false;
									this.GridEX1.RootTable.Columns["avaldore_tarikh"].Visible = true;
								}
							}
						}
					}
				}
				this.GridEX1.Row = 0;
				this.GridEX1.Focus();
			}
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x0000A967 File Offset: 0x00008B67
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.Preparedt((DataTable)this.GridEX1.DataSource);
			this.UiComboBox1_SelectedIndexChanged(null, null);
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x0000A992 File Offset: 0x00008B92
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00200550 File Offset: 0x001FE750
		private void FilterGrid(GridEX Grid, string Text)
		{
			DataView defaultView = ((DataTable)Grid.DataSource).DefaultView;
			bool flag = Operators.CompareString(Text, string.Empty, false) == 0;
			if (flag)
			{
				defaultView.RowFilter = "";
			}
			else
			{
				defaultView.RowFilter = "moshtari_name LIKE '%" + Text + "%'";
				Public_Function.HighlightCell(Grid, Text);
			}
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			this.FilterGrid(this.GridEX1, this.txt_search.Text);
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x002005B4 File Offset: 0x001FE7B4
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_search.Text = string.Empty;
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				this.LoadData();
				this.Preparedt((DataTable)this.GridEX1.DataSource);
				this.txt_moshtari.SetNew();
			}
			this.txt_search.Focus();
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00200620 File Offset: 0x001FE820
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow.Cells["id"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["id"].Value, -1, false);
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_98_0 = frm_SuratHesab_Moshtari;
					object expr_86 = this.GridEX1.CurrentRow.Cells["id"].Value;
					int? num;
					arg_98_0.Moshtari_id = ((expr_86 != null) ? ((int?)expr_86) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0020070C File Offset: 0x001FE90C
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("آیا مایل به افزودن ", this.GridEX1.CurrentRow.Cells["moshtari_name"].Value), " به لیست سیاه میباشید؟ ")), MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
				if (flag2)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject("insert into moshtari_listSiah (moshtari_id) values(", this.GridEX1.CurrentRow.Cells["ID"].Value), ")")
					}, null, null, null, true);
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x002007E8 File Offset: 0x001FE9E8
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_rpt_listsiah_bedehkaran showFrm = new Frm_rpt_listsiah_bedehkaran();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
			this.LoadData();
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0020082C File Offset: 0x001FEA2C
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			bool @checked = this.ButtonItem6.Checked;
			if (@checked)
			{
				this.GridEX1.RootTable.FilterCondition = null;
				this.GridEX1.RootTable.Columns["check_count"].Visible = true;
				this.GridEX1.RootTable.Columns["check_mablagh"].Visible = true;
				this.GridEX1.RootTable.Columns["jam_kol"].Visible = true;
			}
			else
			{
				this.GridEX1.RootTable.FilterCondition = this.GridEX1.RootTable.StoredFilters[0];
				this.GridEX1.RootTable.Columns["check_count"].Visible = false;
				this.GridEX1.RootTable.Columns["check_mablagh"].Visible = false;
				this.GridEX1.RootTable.Columns["jam_kol"].Visible = false;
			}
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00200950 File Offset: 0x001FEB50
		private void moaref_kind_ButtonClick(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Rows.Add(new object[]
			{
				1,
				"خریدار"
			});
			dataTable.Rows.Add(new object[]
			{
				2,
				"صاحب بار"
			});
			Frm_SelectItem frm_SelectItem = new Frm_SelectItem();
			frm_SelectItem.items = new ItemCollection
			{
				new Column("Name", "عنوان", 100)
			};
			bool flag = frm_SelectItem.ShowDialog(dataTable, null, "انتخاب نوع مشتری") == DialogResult.OK;
			if (flag)
			{
				this.txt_noe_moshtari.SetValue(Conversions.ToString(frm_SelectItem.SelectedRow["Name"]), RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow["ID"]));
				this.txt_noe_moshtari_SelectedValueChanged(null, null);
			}
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00200A6C File Offset: 0x001FEC6C
		private void EditBox1_Validated(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_tedadruz.Text, string.Empty, false) != 0;
			if (flag)
			{
				bool flag2 = this.GridEX1.DataSource == null;
				if (!flag2)
				{
					DataTable dataTable = (DataTable)this.GridEX1.DataSource;
					DateTime t = DateAndTime.Now.AddDays(-1.0 * Conversions.ToDouble(this.txt_tedadruz.Text));
					try
					{
						IEnumerator enumerator = dataTable.Rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							DataRow dataRow = (DataRow)enumerator.Current;
							DateTime t2 = Conversions.ToDate(Public_Function.ShamsiToMiladi(Conversions.ToString(dataRow["tarikh"])));
							flag2 = (DateTime.Compare(t2, t) > 0);
							if (flag2)
							{
								dataRow["visible"] = 0;
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						flag2 = (enumerator is IDisposable);
						if (flag2)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					this.GridEX1.Refetch();
					this.GridEX1.UpdateData();
				}
			}
			else
			{
				DataTable dataTable2 = (DataTable)this.GridEX1.DataSource;
				try
				{
					IEnumerator enumerator2 = dataTable2.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow2 = (DataRow)enumerator2.Current;
						dataRow2["visible"] = 1;
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
				this.GridEX1.Refetch();
			}
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0000A992 File Offset: 0x00008B92
		private void txt_noe_moshtari_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData();
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0000A992 File Offset: 0x00008B92
		private void txt_noe_moshtari_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData();
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00200C44 File Offset: 0x001FEE44
		private void txt_noe_moshtari_TextChanged(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.txt_noe_moshtari.Text, string.Empty, false) == 0;
			if (flag)
			{
				this.txt_noe_moshtari_ValueDeleted(null, null);
			}
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00200C7C File Offset: 0x001FEE7C
		private void txt_noe_moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.moaref_kind_ButtonClick(null, null);
			}
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00200CA4 File Offset: 0x001FEEA4
		private void txt_az_tarikh_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.LoadData();
				this.Preparedt((DataTable)this.GridEX1.DataSource);
			}
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x001C94E4 File Offset: 0x001C76E4
		private void Remove_(StiReport report, string stitext)
		{
			string[] array = stitext.Split(new char[]
			{
				','
			});
			string[] array2 = array;
			checked
			{
				for (int i = 0; i < array2.Length; i++)
				{
					string componentName = array2[i];
					StiText stiText = (StiText)report.GetComponentByName(componentName);
					bool flag = stiText == null;
					if (!flag)
					{
						stiText.Text = stiText.Text.ToString().Replace("ـ", "");
					}
				}
			}
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00200CE0 File Offset: 0x001FEEE0
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(true);
			bool flag = stiReport == null;
			if (!flag)
			{
				flag = (this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK);
				if (flag)
				{
					StiPdfExportService stiPdfExportService = new StiPdfExportService();
					StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
					stiPdfExportService.MultipleFiles = true;
					this.Remove_(stiReport, "txt_tarikh,Text10,Text1,Text13,Text7,Text5,Text2");
					stiReport.Render(true);
					string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "-");
					stiPdfExportService.ExportPdf(stiReport, this.FolderBrowserDialog1.SelectedPath + "بدهکاران.pdf");
					Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x00200D8C File Offset: 0x001FEF8C
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\excel\\bedehkaran.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			dataTable.DefaultView.RowFilter = "visible=1";
			stiReport.RegData(dataTable.DefaultView);
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				stiReport.Render(true);
				stiReport.ExportDocument(StiExportFormat.Excel, "c:\\1.xls");
				Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			}
		}

		// Token: 0x04001080 RID: 4224
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001082 RID: 4226
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001083 RID: 4227
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001084 RID: 4228
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001085 RID: 4229
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001086 RID: 4230
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001087 RID: 4231
		[AccessedThroughProperty("UiProgressBar1")]
		private UIProgressBar _UiProgressBar1;

		// Token: 0x04001088 RID: 4232
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001089 RID: 4233
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x0400108A RID: 4234
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x0400108B RID: 4235
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400108C RID: 4236
		[AccessedThroughProperty("txt_search")]
		private EditBox _txt_search;

		// Token: 0x0400108D RID: 4237
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400108E RID: 4238
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400108F RID: 4239
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04001090 RID: 4240
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04001091 RID: 4241
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04001092 RID: 4242
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04001093 RID: 4243
		[AccessedThroughProperty("txt_tedadruz")]
		private EditBox _txt_tedadruz;

		// Token: 0x04001094 RID: 4244
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001095 RID: 4245
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x04001096 RID: 4246
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04001097 RID: 4247
		[AccessedThroughProperty("txt_noe_moshtari")]
		private SelectItem _txt_noe_moshtari;

		// Token: 0x04001098 RID: 4248
		[AccessedThroughProperty("UiCheckBox2")]
		private UICheckBox _UiCheckBox2;

		// Token: 0x04001099 RID: 4249
		[AccessedThroughProperty("UiCheckBox3")]
		private UICheckBox _UiCheckBox3;

		// Token: 0x0400109A RID: 4250
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x0400109B RID: 4251
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x0400109C RID: 4252
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400109D RID: 4253
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x0400109E RID: 4254
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x0400109F RID: 4255
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x040010A0 RID: 4256
		private Moshtari_Info moshtari;

		// Token: 0x040010A1 RID: 4257
		[CompilerGenerated]
		private bool _Is_Listdirkard;

		// Token: 0x02000125 RID: 293
		private enum bedbes
		{
			// Token: 0x040010A3 RID: 4259
			bed,
			// Token: 0x040010A4 RID: 4260
			bes
		}
	}
}
