using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI.Dock;
using Kavenegar.SDK;
using Kavenegar.SDK.Models;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using Stimulsoft.Report.Export;

namespace FruitBox
{
	// Token: 0x0200014C RID: 332
	[DesignerGenerated]
	public partial class Frm_SuratHesab_Moshtari : Form
	{
		// Token: 0x06003152 RID: 12626 RVA: 0x00240288 File Offset: 0x0023E488
		public Frm_SuratHesab_Moshtari()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_SuratHesab_Moshtari_KeyDown);
			base.Load += new EventHandler(this.Frm_SuratHesab_Moshtari_Load);
			Frm_SuratHesab_Moshtari.__ENCAddToList(this);
			this.Moshtari_Info = new Moshtari_Info();
			this.Moshtari_Pic = new Moshtari_Pic();
			this.last_mande = 0L;
			this.last_stat = string.Empty;
			this.mande = string.Empty;
			this.InitializeComponent();
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x00240308 File Offset: 0x0023E508
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_SuratHesab_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_SuratHesab_Moshtari.__ENCList.Count == Frm_SuratHesab_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_SuratHesab_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_SuratHesab_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_SuratHesab_Moshtari.__ENCList[num] = Frm_SuratHesab_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_SuratHesab_Moshtari.__ENCList.RemoveRange(num, Frm_SuratHesab_Moshtari.__ENCList.Count - num);
						Frm_SuratHesab_Moshtari.__ENCList.Capacity = Frm_SuratHesab_Moshtari.__ENCList.Count;
					}
					Frm_SuratHesab_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000F0E RID: 3854
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x00242F10 File Offset: 0x00241110
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x0000C753 File Offset: 0x0000A953
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

		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x00242F28 File Offset: 0x00241128
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x0000C75D File Offset: 0x0000A95D
		internal virtual UIGroupBox UiGroupBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox2 = value;
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x00242F40 File Offset: 0x00241140
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x00242F58 File Offset: 0x00241158
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
				ColumnActionEventHandler value4 = new ColumnActionEventHandler(this.GridEX1_CellEdited);
				RowLoadEventHandler value5 = new RowLoadEventHandler(this.GridEX1_LoadingRow);
				ColumnActionEventHandler value6 = new ColumnActionEventHandler(this.GridEX1_CellValueChanged);
				bool flag = this._GridEX1 != null;
				if (flag)
				{
					this._GridEX1.RowDoubleClick -= value2;
					this._GridEX1.KeyDown -= value3;
					this._GridEX1.CellEdited -= value4;
					this._GridEX1.LoadingRow -= value5;
					this._GridEX1.CellValueChanged -= value6;
				}
				this._GridEX1 = value;
				flag = (this._GridEX1 != null);
				if (flag)
				{
					this._GridEX1.RowDoubleClick += value2;
					this._GridEX1.KeyDown += value3;
					this._GridEX1.CellEdited += value4;
					this._GridEX1.LoadingRow += value5;
					this._GridEX1.CellValueChanged += value6;
				}
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x00243060 File Offset: 0x00241260
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x0000C767 File Offset: 0x0000A967
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

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x00243078 File Offset: 0x00241278
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x00243090 File Offset: 0x00241290
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
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
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

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x002430F0 File Offset: 0x002412F0
		// (set) Token: 0x06003161 RID: 12641 RVA: 0x0000C771 File Offset: 0x0000A971
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

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06003162 RID: 12642 RVA: 0x00243108 File Offset: 0x00241308
		// (set) Token: 0x06003163 RID: 12643 RVA: 0x0000C77B File Offset: 0x0000A97B
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

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06003164 RID: 12644 RVA: 0x00243120 File Offset: 0x00241320
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x0000C785 File Offset: 0x0000A985
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

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x00243138 File Offset: 0x00241338
		// (set) Token: 0x06003167 RID: 12647 RVA: 0x0000C78F File Offset: 0x0000A98F
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

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06003168 RID: 12648 RVA: 0x00243150 File Offset: 0x00241350
		// (set) Token: 0x06003169 RID: 12649 RVA: 0x0000C799 File Offset: 0x0000A999
		internal virtual Label lbl_tel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel3 = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600316A RID: 12650 RVA: 0x00243168 File Offset: 0x00241368
		// (set) Token: 0x0600316B RID: 12651 RVA: 0x0000C7A3 File Offset: 0x0000A9A3
		internal virtual Label lbl_tel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel4 = value;
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600316C RID: 12652 RVA: 0x00243180 File Offset: 0x00241380
		// (set) Token: 0x0600316D RID: 12653 RVA: 0x0000C7AD File Offset: 0x0000A9AD
		internal virtual Label lbl_tel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel2 = value;
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x0600316E RID: 12654 RVA: 0x00243198 File Offset: 0x00241398
		// (set) Token: 0x0600316F RID: 12655 RVA: 0x0000C7B7 File Offset: 0x0000A9B7
		internal virtual Label lbl_tel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_tel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_tel1 = value;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06003170 RID: 12656 RVA: 0x002431B0 File Offset: 0x002413B0
		// (set) Token: 0x06003171 RID: 12657 RVA: 0x0000C7C1 File Offset: 0x0000A9C1
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

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06003172 RID: 12658 RVA: 0x002431C8 File Offset: 0x002413C8
		// (set) Token: 0x06003173 RID: 12659 RVA: 0x0000C7CB File Offset: 0x0000A9CB
		internal virtual Label Label14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label14 = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x002431E0 File Offset: 0x002413E0
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x0000C7D5 File Offset: 0x0000A9D5
		internal virtual Label lbl_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_codemelli = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06003176 RID: 12662 RVA: 0x002431F8 File Offset: 0x002413F8
		// (set) Token: 0x06003177 RID: 12663 RVA: 0x0000C7DF File Offset: 0x0000A9DF
		internal virtual Label Label15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label15 = value;
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06003178 RID: 12664 RVA: 0x00243210 File Offset: 0x00241410
		// (set) Token: 0x06003179 RID: 12665 RVA: 0x0000C7E9 File Offset: 0x0000A9E9
		internal virtual Label lbl_addr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_addr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_addr = value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x0600317A RID: 12666 RVA: 0x00243228 File Offset: 0x00241428
		// (set) Token: 0x0600317B RID: 12667 RVA: 0x0000C7F3 File Offset: 0x0000A9F3
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x0600317C RID: 12668 RVA: 0x00243240 File Offset: 0x00241440
		// (set) Token: 0x0600317D RID: 12669 RVA: 0x0000C7FD File Offset: 0x0000A9FD
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x0600317E RID: 12670 RVA: 0x00243258 File Offset: 0x00241458
		// (set) Token: 0x0600317F RID: 12671 RVA: 0x0000C807 File Offset: 0x0000AA07
		internal virtual PictureBox PictureBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox1 = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06003180 RID: 12672 RVA: 0x00243270 File Offset: 0x00241470
		// (set) Token: 0x06003181 RID: 12673 RVA: 0x00243288 File Offset: 0x00241488
		internal virtual RibbonStatusBar RibbonStatusBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RibbonStatusBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CommandEventHandler value2 = new CommandEventHandler(this.RibbonStatusBar1_CommandClick);
				bool flag = this._RibbonStatusBar1 != null;
				if (flag)
				{
					this._RibbonStatusBar1.CommandClick -= value2;
				}
				this._RibbonStatusBar1 = value;
				flag = (this._RibbonStatusBar1 != null);
				if (flag)
				{
					this._RibbonStatusBar1.CommandClick += value2;
				}
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06003182 RID: 12674 RVA: 0x002432E8 File Offset: 0x002414E8
		// (set) Token: 0x06003183 RID: 12675 RVA: 0x0000C811 File Offset: 0x0000AA11
		internal virtual LabelCommand LabelCommand5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand5 = value;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x00243300 File Offset: 0x00241500
		// (set) Token: 0x06003185 RID: 12677 RVA: 0x0000C81B File Offset: 0x0000AA1B
		internal virtual LabelCommand LabelCommand6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand6 = value;
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06003186 RID: 12678 RVA: 0x00243318 File Offset: 0x00241518
		// (set) Token: 0x06003187 RID: 12679 RVA: 0x0000C825 File Offset: 0x0000AA25
		internal virtual LabelCommand LabelCommand7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand7 = value;
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x00243330 File Offset: 0x00241530
		// (set) Token: 0x06003189 RID: 12681 RVA: 0x0000C82F File Offset: 0x0000AA2F
		internal virtual LabelCommand LabelCommand8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand8 = value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x00243348 File Offset: 0x00241548
		// (set) Token: 0x0600318B RID: 12683 RVA: 0x0000C839 File Offset: 0x0000AA39
		internal virtual LabelCommand LabelCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand1 = value;
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x0600318C RID: 12684 RVA: 0x00243360 File Offset: 0x00241560
		// (set) Token: 0x0600318D RID: 12685 RVA: 0x0000C843 File Offset: 0x0000AA43
		internal virtual LabelCommand LabelCommand2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand2 = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x0600318E RID: 12686 RVA: 0x00243378 File Offset: 0x00241578
		// (set) Token: 0x0600318F RID: 12687 RVA: 0x0000C84D File Offset: 0x0000AA4D
		internal virtual LabelCommand LabelCommand3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand3 = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x00243390 File Offset: 0x00241590
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x0000C857 File Offset: 0x0000AA57
		internal virtual LabelCommand LabelCommand4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand4 = value;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x002433A8 File Offset: 0x002415A8
		// (set) Token: 0x06003193 RID: 12691 RVA: 0x0000C861 File Offset: 0x0000AA61
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

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06003194 RID: 12692 RVA: 0x002433C0 File Offset: 0x002415C0
		// (set) Token: 0x06003195 RID: 12693 RVA: 0x002433D8 File Offset: 0x002415D8
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

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06003196 RID: 12694 RVA: 0x00243438 File Offset: 0x00241638
		// (set) Token: 0x06003197 RID: 12695 RVA: 0x00243450 File Offset: 0x00241650
		internal virtual ButtonItem ButtonItem11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem11_Click);
				bool flag = this._ButtonItem11 != null;
				if (flag)
				{
					this._ButtonItem11.Click -= value2;
				}
				this._ButtonItem11 = value;
				flag = (this._ButtonItem11 != null);
				if (flag)
				{
					this._ButtonItem11.Click += value2;
				}
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06003198 RID: 12696 RVA: 0x002434B0 File Offset: 0x002416B0
		// (set) Token: 0x06003199 RID: 12697 RVA: 0x002434C8 File Offset: 0x002416C8
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

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x0600319A RID: 12698 RVA: 0x00243528 File Offset: 0x00241728
		// (set) Token: 0x0600319B RID: 12699 RVA: 0x00243540 File Offset: 0x00241740
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x0600319C RID: 12700 RVA: 0x002435A0 File Offset: 0x002417A0
		// (set) Token: 0x0600319D RID: 12701 RVA: 0x002435B8 File Offset: 0x002417B8
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
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
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

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x00243618 File Offset: 0x00241818
		// (set) Token: 0x0600319F RID: 12703 RVA: 0x0000C86B File Offset: 0x0000AA6B
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00243630 File Offset: 0x00241830
		// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00243648 File Offset: 0x00241848
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
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

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060031A2 RID: 12706 RVA: 0x002436A8 File Offset: 0x002418A8
		// (set) Token: 0x060031A3 RID: 12707 RVA: 0x002436C0 File Offset: 0x002418C0
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
				KeyEventHandler value2 = new KeyEventHandler(this.txt_az_tarikh_KeyDown_1);
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

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x060031A4 RID: 12708 RVA: 0x00243720 File Offset: 0x00241920
		// (set) Token: 0x060031A5 RID: 12709 RVA: 0x0000C875 File Offset: 0x0000AA75
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x060031A6 RID: 12710 RVA: 0x00243738 File Offset: 0x00241938
		// (set) Token: 0x060031A7 RID: 12711 RVA: 0x0000C87F File Offset: 0x0000AA7F
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x060031A8 RID: 12712 RVA: 0x00243750 File Offset: 0x00241950
		// (set) Token: 0x060031A9 RID: 12713 RVA: 0x0000C889 File Offset: 0x0000AA89
		internal virtual Label lbl_code
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_code;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_code = value;
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x060031AA RID: 12714 RVA: 0x00243768 File Offset: 0x00241968
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x00243780 File Offset: 0x00241980
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

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x002437E0 File Offset: 0x002419E0
		// (set) Token: 0x060031AD RID: 12717 RVA: 0x0000C893 File Offset: 0x0000AA93
		internal virtual LabelCommand LabelCommand10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand10 = value;
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x060031AE RID: 12718 RVA: 0x002437F8 File Offset: 0x002419F8
		// (set) Token: 0x060031AF RID: 12719 RVA: 0x0000C89D File Offset: 0x0000AA9D
		internal virtual LabelCommand LabelCommand9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LabelCommand9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LabelCommand9 = value;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x00243810 File Offset: 0x00241A10
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
		internal virtual Label lbl_shahr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lbl_shahr;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lbl_shahr = value;
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x00243828 File Offset: 0x00241A28
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x00243840 File Offset: 0x00241A40
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

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x002438A0 File Offset: 0x00241AA0
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x002438B8 File Offset: 0x00241AB8
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

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x00243918 File Offset: 0x00241B18
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x0000C8B1 File Offset: 0x0000AAB1
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x00243930 File Offset: 0x00241B30
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x00243948 File Offset: 0x00241B48
		internal virtual UICheckBox txt_jamkharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_jamkharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_jamkharid_CheckedChanged);
				bool flag = this._txt_jamkharid != null;
				if (flag)
				{
					this._txt_jamkharid.CheckedChanged -= value2;
				}
				this._txt_jamkharid = value;
				flag = (this._txt_jamkharid != null);
				if (flag)
				{
					this._txt_jamkharid.CheckedChanged += value2;
				}
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x002439A8 File Offset: 0x00241BA8
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x002439C0 File Offset: 0x00241BC0
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

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x00243A20 File Offset: 0x00241C20
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x0000C8BB File Offset: 0x0000AABB
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

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x00243A38 File Offset: 0x00241C38
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x00243A50 File Offset: 0x00241C50
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

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x00243AB0 File Offset: 0x00241CB0
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x00243AC8 File Offset: 0x00241CC8
		internal virtual ButtonItem ButtonItem9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem9_Click);
				bool flag = this._ButtonItem9 != null;
				if (flag)
				{
					this._ButtonItem9.Click -= value2;
				}
				this._ButtonItem9 = value;
				flag = (this._ButtonItem9 != null);
				if (flag)
				{
					this._ButtonItem9.Click += value2;
				}
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x00243B28 File Offset: 0x00241D28
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x0000C8C5 File Offset: 0x0000AAC5
		internal virtual ButtonCommand ButtonCommand1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonCommand1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ButtonCommand1 = value;
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x00243B40 File Offset: 0x00241D40
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x0000C8CF File Offset: 0x0000AACF
		internal virtual Label Label16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label16 = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x00243B58 File Offset: 0x00241D58
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x0000C8D9 File Offset: 0x0000AAD9
		internal virtual Label Label13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label13 = value;
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x00243B70 File Offset: 0x00241D70
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x0000C8E3 File Offset: 0x0000AAE3
		internal virtual EditBox txt_tedad_safi_mande
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedad_safi_mande;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tedad_safi_mande = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x00243B88 File Offset: 0x00241D88
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x0000C8ED File Offset: 0x0000AAED
		internal virtual Label Label17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label17 = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x00243BA0 File Offset: 0x00241DA0
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x0000C8F7 File Offset: 0x0000AAF7
		internal virtual EditBox txt_tedad_havale
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedad_havale;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tedad_havale = value;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x00243BB8 File Offset: 0x00241DB8
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x0000C901 File Offset: 0x0000AB01
		internal virtual EditBox txt_tedad_safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tedad_safi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tedad_safi = value;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x00243BD0 File Offset: 0x00241DD0
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x0000C90B File Offset: 0x0000AB0B
		public int? Moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_id = value;
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x00243BE8 File Offset: 0x00241DE8
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x0000C915 File Offset: 0x0000AB15
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

		// Token: 0x060031D4 RID: 12756 RVA: 0x00243C00 File Offset: 0x00241E00
		private long Refresh_Status()
		{
			this.LabelCommand2.Text = this.Moshtari_Info.LastTozih.ToString();
			this.LabelCommand1.Text = this.Moshtari_Info.Check_Status;
			this.LabelCommand3.Text = this.Moshtari_Info.Mande_Name;
			bool flag = this.Moshtari_Info.Mande == -1L;
			long result;
			if (flag)
			{
				this.LabelCommand4.Text = "";
				result = 0L;
			}
			else
			{
				flag = (this.Moshtari_Info.Mande != this.last_mande);
				if (flag)
				{
				}
				this.LabelCommand4.Text = Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(this.Moshtari_Info.Mande)));
				result = this.Moshtari_Info.Mande;
			}
			return result;
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00223D44 File Offset: 0x00221F44
		private int GetNextPosBed(int pos, DataTable dt)
		{
			long num = 0L;
			checked
			{
				int arg_16_0 = pos + 1;
				int num2 = dt.Rows.Count - 1;
				int num3 = arg_16_0;
				int num5;
				while (true)
				{
					int arg_1D1_0 = num3;
					int num4 = num2;
					if (arg_1D1_0 > num4)
					{
						goto Block_6;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num3]["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num3]["calc"], 1, false);
					if (flag)
					{
						bool flag2 = num5 + 1 > dt.Rows.Count - 1;
						if (flag2)
						{
							break;
						}
						num5 = num3;
						num = Conversions.ToLong(dt.Rows[num3]["rembed"]);
						DateTime dateTime = Conversions.ToDate(dt.Rows[num3]["tarikh"]);
						int arg_101_0 = num5 + 1;
						int num6 = dt.Rows.Count - 1;
						int num7 = arg_101_0;
						while (true)
						{
							int arg_1BC_0 = num7;
							num4 = num6;
							if (arg_1BC_0 > num4)
							{
								break;
							}
							flag2 = (Operators.ConditionalCompareObjectEqual(dt.Rows[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dt.Rows[num7]["bed"], 0, false));
							if (!flag2)
							{
								goto IL_18A;
							}
							num5 = num7;
							num = Conversions.ToLong(Operators.AddObject(num, dt.Rows[num7]["rembed"]));
							num7++;
						}
					}
					num3++;
				}
				dt.Rows[num5]["rembed"] = num;
				int result = num5;
				return result;
				IL_18A:
				dt.Rows[num5]["rembed"] = num;
				result = num5;
				return result;
				Block_6:
				result = -1;
				return result;
			}
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00043BA4 File Offset: 0x00041DA4
		private int GetNextPosBes(int pos, DataTable dt)
		{
			checked
			{
				int arg_12_0 = pos + 1;
				int num = dt.Rows.Count - 1;
				int num2 = arg_12_0;
				while (true)
				{
					int arg_76_0 = num2;
					int num3 = num;
					if (arg_76_0 > num3)
					{
						goto Block_3;
					}
					bool flag = Operators.ConditionalCompareObjectGreater(dt.Rows[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dt.Rows[num2]["calc"], 1, false);
					if (flag)
					{
						break;
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_3:
				result = -1;
				return result;
			}
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x00243CD4 File Offset: 0x00241ED4
		private void LoadPic(DataRow dr)
		{
			bool flag = dr == null;
			if (flag)
			{
				this.PictureBox1.Image = null;
			}
			else
			{
				flag = (dr["PicData"] != DBNull.Value);
				if (flag)
				{
					MemoryStream memoryStream = new MemoryStream();
					memoryStream.Write((byte[])dr["Picdata"], 0, ((byte[])dr["Picdata"]).Length);
					this.PictureBox1.Image = Image.FromStream(memoryStream);
				}
				else
				{
					this.PictureBox1.Image = null;
				}
			}
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00243D68 File Offset: 0x00241F68
		private void LoadMoshtariData(string id)
		{
			DataRow dataRow = Public_Function.FillDataRow("SELECT     Grouh_Moshtari.Name AS Shahr1, Grouh_Moshtari2.Name AS Shahr2, Moshtari.*  FROM         Moshtari LEFT OUTER JOIN  Grouh_Moshtari2 ON Moshtari.GrouhMoshtari2_ID = Grouh_Moshtari2.ID LEFT OUTER JOIN  Grouh_Moshtari ON Moshtari.GrouhMoshtari_ID = Grouh_Moshtari.ID where Moshtari.id=" + id);
			bool flag = dataRow != null;
			if (flag)
			{
				this.lbl_shahr.Text = string.Empty;
				this.lbl_code.Text = id;
				this.Label7.Text = dataRow["moaref"].ToString();
				this.lbl_tel1.Text = dataRow["tel1"].ToString();
				this.lbl_tel2.Text = dataRow["tel2"].ToString();
				this.lbl_tel3.Text = dataRow["tel3"].ToString();
				this.lbl_tel4.Text = dataRow["tel4"].ToString();
				this.lbl_addr.Text = dataRow["address"].ToString();
				this.lbl_codemelli.Text = dataRow["codemelli"].ToString();
				flag = (dataRow["shahr1"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr1"]);
				}
				flag = (dataRow["shahr2"] != DBNull.Value);
				if (flag)
				{
					this.lbl_shahr.Text = Conversions.ToString(dataRow["shahr2"]);
				}
				DataRow byID = this.Moshtari_Pic.GetByID(id);
				this.LoadPic(byID);
			}
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x00224154 File Offset: 0x00222354
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["tedad"]));
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["vazn_kol"]));
					}
					flag = (dataRow["ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["ba_zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["ba_zarf"]));
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00043C30 File Offset: 0x00041E30
		private void Disablecheckbargasht(DataTable dt)
		{
			DataRow[] array = dt.Select("pardakhtcheck_id is not null");
			bool flag = array.Length > 0;
			checked
			{
				if (flag)
				{
					DataRow[] array2 = array;
					for (int i = 0; i < array2.Length; i++)
					{
						DataRow dataRow = array2[i];
						DataRow[] array3 = dt.Select(Conversions.ToString(Operators.ConcatenateObject("check_id=", dataRow["pardakhtcheck_id"])));
						flag = (array3.Length > 0);
						if (flag)
						{
							dataRow["calc"] = 0;
							array3[0]["calc"] = 0;
						}
					}
				}
			}
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0009DA70 File Offset: 0x0009BC70
		private string getkalaname(DataRow[] r)
		{
			string text = "خرید ";
			checked
			{
				for (int i = 0; i < r.Length; i++)
				{
					DataRow dataRow = r[i];
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dataRow["kala_name"], " , ")));
				}
				return text.Remove(text.Length - 3, 3);
			}
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		private void addtedad(DataRow row, DataRow[] r)
		{
			row["tedad"] = RuntimeHelpers.GetObjectValue(r[0]["tedad"]);
			row["vazn_kol"] = RuntimeHelpers.GetObjectValue(r[0]["vazn_kol"]);
			row["fee"] = RuntimeHelpers.GetObjectValue(r[0]["fee"]);
			row["ba_zarf"] = RuntimeHelpers.GetObjectValue(r[0]["ba_zarf"]);
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00243EFC File Offset: 0x002420FC
		private void loadJamFurushRuzane(DataTable dt, string codehesab_id)
		{
			bool flag = !this.txt_jamkharid.Checked;
			if (!flag)
			{
				string command = string.Concat(new string[]
				{
					"select * from ( SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype is null and Sanad.CodeHesab_ID = ",
					codehesab_id,
					"   UNION all   SELECT     Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE sanad.arztype is null and Sanad.CodeHesab_ID = ",
					codehesab_id,
					")t  order by sanadtype,tarikh"
				});
				DataTable dataTable = Public_Function.FillData(command);
				try
				{
					IEnumerator enumerator = dt.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 2, false) || Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 3, false));
						if (flag)
						{
							DataRow[] array = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("tarikh='", dataRow["tarikh"]), "'")));
							dataRow["Tozih"] = this.getkalaname(array);
							flag = (array.Length == 1);
							if (flag)
							{
								this.addtedad(dataRow, array);
							}
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
			}
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00244060 File Offset: 0x00242260
		private void Delete_Tekrari(DataTable dt)
		{
			long num = -1L;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["id"] == DBNull.Value;
					if (!flag)
					{
						flag = Operators.ConditionalCompareObjectEqual(dataRow["id"], num, false);
						if (flag)
						{
							dataRow.Delete();
							dt.AcceptChanges();
							this.Delete_Tekrari(dt);
							break;
						}
						num = Conversions.ToLong(dataRow["id"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_Ersalbar_duplicate()
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0000205D File Offset: 0x0000025D
		private void Delete_invalid_row(DataTable dt)
		{
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x0024412C File Offset: 0x0024232C
		private void Delete_Sanad_Invalid(DataTable dt, long codehesab_id)
		{
			string iD = Public_Function.GetID(dt, "id", "");
			Public_Function.ExecuteNonQuery(string.Concat(new string[]
			{
				"delete from sanad where codehesab_id=",
				Conversions.ToString(codehesab_id),
				" and id not in(",
				iD,
				")"
			}));
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x0024418C File Offset: 0x0024238C
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				this.LoadMoshtariData(Conversions.ToString(this.txt_moshtari.Value));
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
				string text = string.Empty;
				flag = !this.txt_jamkharid.Checked;
				if (flag)
				{
					text = " SELECT  distinct   Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Kol,Furush_Hag_Detail.fee,vazn_ba_zarf as ba_zarf,2 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked    FROM         Kala INNER JOIN    Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype is null and Sanad.CodeHesab_ID = " + Conversions.ToString(num) + "   UNION all ";
					text = text + "  SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,   Sanad.Bes AS rembes, Kharid_Furush.Tedad, Kharid_Furush.Vazn_Kol,Kharid_Furush.Fee,vazn_ba_zarf as ba_zarf,3 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked   FROM         Kala INNER JOIN   Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN  Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID    WHERE sanad.arztype is null and Sanad.CodeHesab_ID = " + Conversions.ToString(num) + "   union all ";
				}
				else
				{
					text = string.Concat(new string[]
					{
						"select null as ID,max(CodeHesab_ID) as CodeHesab_ID,sum( Bed) AS Bed,sum ( Bes) AS Bes,max(Tarikh) as Tarikh ,max( Tarikh_Fa) AS Tarikh_Fa,null as  Tozih,cast(  null  AS nvarchar(50))  AS Kala_Name, sum( Bed) AS rembed,sum( Bes) AS rembes,null as  Tedad, null as Vazn_Kol, null as Fee, null AS ba_zarf,2 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked from ( SELECT    null as ID, max(Sanad.CodeHesab_ID) as CodeHesab_ID,sum( Sanad.Bed) AS Bed,sum ( Sanad.Bes) AS Bes,Sanad.Tarikh ,max( Sanad.Tarikh_Fa) AS Tarikh_Fa,null as  Tozih,cast(  null  AS nvarchar(50))  AS Kala_Name, sum( Sanad.Bed) AS rembed,sum( Sanad.Bes) AS rembes,null as  Tedad, null as Vazn_Kol, null as Fee, null AS ba_zarf,2 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked  FROM         Kala INNER JOIN Furush_Hag_Detail ON Kala.ID = Furush_Hag_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Hag_Detail.Sanad_ID = Sanad.ID  WHERE sanad.arztype is null and Sanad.CodeHesab_ID = ",
						Conversions.ToString(num),
						" group by Sanad.Tarikh   UNION all   SELECT     null as ID,max ( Sanad.CodeHesab_ID) AS CodeHesab_ID,sum ( Sanad.Bed) AS Bed,sum( Sanad.Bes) AS Bes, Sanad.Tarikh,max( Sanad.Tarikh_Fa) as Tarikh_Fa, null as Tozih, cast(  null  AS nvarchar(50))  AS Kala_Name,sum( Sanad.Bed ) AS rembed,   sum(  Sanad.Bes) AS rembes, null as Tedad, null as Vazn_Kol, null as Fee, null  AS ba_zarf, 3 AS sanadtype,     - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked   FROM         Kala INNER JOIN     Kharid_Furush ON Kala.ID = Kharid_Furush.Kala_ID INNER JOIN     Sanad ON Kharid_Furush.Sanad_ID = Sanad.ID   WHERE sanad.arztype is null and Sanad.CodeHesab_ID =  ",
						Conversions.ToString(num),
						" group by  Sanad.Tarikh  ) as t  group by Tarikh UNION ALL "
					});
				}
				flag = (Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0);
				if (flag)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, Kharid_Detail.Vazn_Ba_Zarf AS ba_zarf, 5 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked  FROM         Sanad INNER JOIN  Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID   where sanad.arztype is null and Kharid.Moshtari_id = ", this.txt_moshtari.Value), " union all ")));
				}
				else
				{
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT distinct    Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Detail.Tedad, Kharid_Detail.Vazn_Kol, Kharid_Detail.Fee, Kharid_Detail.Vazn_Ba_Zarf AS ba_zarf, 5 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked  FROM         Sanad INNER JOIN  Kharid_Detail ON Sanad.ID = Kharid_Detail.sanad_id INNER JOIN  Kala ON Kharid_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid ON Kharid_Detail.Kharid_ID = Kharid.ID   where sanad.arztype is null and Kharid_Detail.Moshtari_id = ", this.txt_moshtari.Value), " union all ")));
				}
				text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" SELECT  distinct   Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, NULL AS Tedad, NULL AS Vazn_Kol, NULL AS Fee, NULL AS ba_zarf, 1 AS sanadtype, - 1 AS printcount, DaryaftPardakht.PardakhtCheck_ID,  DaryaftPardakht_1.ID AS Check_ID, 1 AS calc,0 as checked  FROM         Sanad LEFT OUTER JOIN  DaryaftPardakht ON Sanad.ID = DaryaftPardakht.SanadBed_ID LEFT OUTER JOIN  DaryaftPardakht AS DaryaftPardakht_1 ON Sanad.ID = DaryaftPardakht_1.SanadBes_ID  WHERE     ( sanad.arztype is null and Sanad.CodeHesab_ID = " + Conversions.ToString(num) + ")  AND ((Sanad.sanadtype is null) OR (sanad.sanadtype =1)) " + "  union all" + "  SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, NULL AS kala_name, Sanad.Bed AS rembed, " + " Sanad.Bes AS rembes, t.Tedad, t.vazn_kol, NULL AS Fee,t.ba_zarf as ba_zarf,4 as SanadType,Safi_Furush_1.printcount " + " ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc,sanad.checked as checked  " + " FROM         Safi_Furush AS Safi_Furush_1 INNER JOIN " + " Sanad ON Safi_Furush_1.Sanad_ID = Sanad.ID INNER JOIN " + " (SELECT     Safi_Furush.ID, SUM(Furush_Hag_Detail.Tedad) AS Tedad, SUM(Furush_Hag_Detail.Vazn_Kol) AS vazn_kol,SUM(Furush_Hag_Detail.vazn_ba_zarf) AS ba_zarf " + " FROM         Safi_Furush INNER JOIN " + " Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID INNER JOIN " + " Furush_Hag_Detail ON Furush_Hag.ID = Furush_Hag_Detail.Furush_Hug_ID " + " WHERE Furush_Hag.Moshtari_ID = ", this.txt_moshtari.Value), "  GROUP BY Safi_Furush.ID) AS t ON Safi_Furush_1.ID = t.ID "), "  where sanad.arztype is null "), " union all "), " SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Sardkhane_Detail.Tedad, Kharid_Sardkhane_Detail.Vazn_Kol, Kharid_Sardkhane_Detail.Fee, Kharid_Sardkhane_Detail.Vazn_Ba_Zarf AS ba_zarf, 6 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc , 0 as checked  FROM         Sanad INNER JOIN  Kharid_Sardkhane_Detail ON Sanad.ID = Kharid_Sardkhane_Detail.sanad_id INNER JOIN  Kala ON Kharid_Sardkhane_Detail.Kala_ID = Kala.ID INNER JOIN  Kharid_Sardkhane ON Kharid_Sardkhane_Detail.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where sanad.arztype is null and Moshtari_id = "), this.txt_moshtari.Value.ToString()), " union all "), " SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,  Sanad.Bes AS rembes, Kharid_Sardkhane_Furush.Tedad, Kharid_Sardkhane_Furush.Vazn_Kol, Kharid_Sardkhane_Furush.Fee, Kharid_Sardkhane_Furush.Vazn_Ba_Zarf AS ba_zarf, 6 AS sanadtype,   - 1 AS printcount  ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc , 0 as checked  FROM         Sanad INNER JOIN  Kharid_Sardkhane_Furush ON Sanad.ID = Kharid_Sardkhane_Furush.sanad_id INNER JOIN  Kala ON Kharid_Sardkhane_Furush.Kala_ID = Kala.ID INNER JOIN  Kharid_Sardkhane ON Kharid_Sardkhane_Furush.Kharid_Sardkhane_ID = Kharid_Sardkhane.ID   where sanad.arztype is null and Moshtari_id = "), this.txt_moshtari.Value.ToString()), " union all"), " SELECT  distinct   Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed,     Sanad.Bes AS rembes, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Kol,Furush_Sardkhane_Detail.fee,vazn_ba_zarf as ba_zarf,7 as sanadtype,-1 as printcount ,NULL AS PardakhtCheck_ID, NULL AS Check_ID,1 as calc ,0 as checked    FROM         Kala INNER JOIN    Furush_Sardkhane_Detail ON Kala.ID = Furush_Sardkhane_Detail.Kala_ID INNER JOIN  Sanad ON Furush_Sardkhane_Detail.Sanad_ID = Sanad.ID   WHERE sanad.arztype is null and Sanad.CodeHesab_ID = "), num.ToString()), " union all"), " SELECT  distinct   Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, ErsalBar_Detail.Tedad, ErsalBar_Detail.Vazn_Kol, ErsalBar_Detail.Fee, "), " ErsalBar_Detail.Vazn_Ba_Zarf AS ba_zarf, 8 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked "), " FROM         Kala INNER JOIN "), " ErsalBar_Detail ON Kala.ID = ErsalBar_Detail.Kala_ID INNER JOIN "), " Sanad ON ErsalBar_Detail.Sanad_ID = Sanad.ID "), " WHERE     ( sanad.arztype is null and Sanad.CodeHesab_ID = "), num.ToString()), ") "), " UNION ALL "), " SELECT  distinct   Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, t.Kala_Name,Sanad.Bed AS rembed, Sanad.Bes AS rembes, t.Tedad,  t.Vazn_Kol as vazn_kol "), " ,cast(round( Sanad.Bed / t.Vazn_Kol,0) as bigint) as fee "), " ,t.Vazn_Ba_Zarf as ba_zarf "), " ,9 AS sanadtype,  - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked  "), " FROM         (SELECT     ErsalBar.ID, dbo.getersalbar_kala(ErsalBar.ID) AS Kala_Name, SUM(ErsalBar_Detail.Tedad) AS Tedad, SUM(ErsalBar_Detail.Vazn_Ba_Zarf)   AS Vazn_Ba_Zarf "), " ,sum(ErsalBar_Detail.Vazn_Kol) as Vazn_Kol "), " FROM         ErsalBar_Detail RIGHT OUTER JOIN   ErsalBar ON ErsalBar_Detail.ErsalBar_ID = ErsalBar.ID   WHERE ErsalBar.Moshtari_ID = "), this.txt_moshtari.Value.ToString()), "  GROUP BY ErsalBar.ID) AS t INNER JOIN  ErsalBar AS ErsalBar_1 ON t.ID = ErsalBar_1.ID INNER JOIN  Sanad ON ErsalBar_1.Moshtari_Sanad_ID = Sanad.ID  where sanad.arztype is null "), " union all"), " SELECT   distinct  Sanad.ID, Sanad.CodeHesab_ID, Sanad.Bed, Sanad.Bes, Sanad.Tarikh, Sanad.Tarikh_Fa, Sanad.Tozih, Kala.Name AS Kala_Name, Sanad.Bed AS rembed, "), " Sanad.Bes AS rembes, KhordeFurushi_Detail.Tedad, KhordeFurushi_Detail.Vazn_Kol, KhordeFurushi_Detail.Fee, KhordeFurushi_Detail.Vazn_Ba_Zarf AS ba_zarf,  "), " 10 AS sanadtype, - 1 AS printcount, NULL AS PardakhtCheck_ID, NULL AS Check_ID, 1 AS calc ,0 as checked "), " FROM         KhordeFurushi_Detail INNER JOIN    Kala ON KhordeFurushi_Detail.Kala_ID = Kala.ID INNER JOIN"), " Sanad ON KhordeFurushi_Detail.Moshtari_Sanad_ID = Sanad.ID  where (sanad.arztype is null and Sanad.CodeHesab_ID = "), num.ToString()), ") "), "  ORDER BY Tarikh,sanadtype ")));
				DataTable dataTable = Public_Function.FillData(text);
				this.Delete_Tekrari(dataTable);
				this.Delete_invalid_row(dataTable);
				this.loadJamFurushRuzane(dataTable, Conversions.ToString(num));
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						flag = (dataRow["kala_name"] != DBNull.Value);
						if (flag)
						{
							bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["sanadtype"], 1, false);
							if (flag2)
							{
								string[] array = dataRow["Kala_Name"].ToString().Split(new char[]
								{
									'-'
								});
								flag2 = (array.Length == 3);
								if (flag2)
								{
									DataRow dataRow2 = dataRow;
									DataRow arg_4D3_0 = dataRow2;
									string columnName = "Tozih";
									arg_4D3_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " / " + array[0]);
									flag2 = (Operators.CompareString(array[1], string.Empty, false) != 0);
									if (flag2)
									{
										dataRow["Tedad"] = array[1].ToString();
									}
									flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
									if (flag2)
									{
										dataRow["Vazn_Kol"] = array[2].ToString();
									}
									continue;
								}
							}
							flag2 = Operators.ConditionalCompareObjectNotEqual(dataRow["sanadtype"], 5, false);
							if (flag2)
							{
								DataRow dataRow2 = dataRow;
								DataRow arg_595_0 = dataRow2;
								string columnName = "Tozih";
								arg_595_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(" / ", dataRow["kala_Name"]));
							}
						}
						else
						{
							string[] array = dataRow["Tozih"].ToString().Split(new char[]
							{
								'-'
							});
							bool flag2 = array.Length == 4;
							if (flag2)
							{
								dataRow["Tozih"] = array[0] + " - " + array[1];
								dataRow["Kala_Name"] = array[1].ToString();
								flag2 = (Operators.CompareString(array[2], string.Empty, false) != 0);
								if (flag2)
								{
									flag = Versioned.IsNumeric(array[2].ToString());
									if (flag)
									{
										dataRow["Tedad"] = array[2].ToString();
									}
								}
								flag2 = Versioned.IsNumeric(array[3].ToString());
								if (flag2)
								{
									flag = (Operators.CompareString(array[3], string.Empty, false) != 0);
									if (flag)
									{
										dataRow["Vazn_Kol"] = array[3].ToString();
									}
								}
								flag2 = (dataRow["Vazn_Kol"] != DBNull.Value);
								if (flag2)
								{
									dataRow["fee"] = Operators.DivideObject(dataRow["bed"], dataRow["Vazn_Kol"]);
								}
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
				this.Disablecheckbargasht(dataTable);
				this.RemoveZero(dataTable);
				try
				{
					IEnumerator enumerator2 = dataTable.Rows.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataRow dataRow3 = (DataRow)enumerator2.Current;
						bool flag2 = dataRow3["checked"] == DBNull.Value;
						if (flag2)
						{
							dataRow3["checked"] = 0;
						}
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
				dataTable.Columns.Add("mande", typeof(long));
				dataTable.Columns.Add("stat", typeof(string));
				dataTable.Columns.Add("rad", typeof(long));
				try
				{
					IEnumerator enumerator3 = dataTable.Rows.GetEnumerator();
					while (enumerator3.MoveNext())
					{
						DataRow dataRow4 = (DataRow)enumerator3.Current;
						long num2 = Conversions.ToLong(Operators.AddObject(num2, dataRow4["bed"]));
						num2 = Conversions.ToLong(Operators.SubtractObject(num2, dataRow4["bes"]));
						dataRow4["mande"] = Math.Abs(num2);
						bool flag2 = num2 > 0L;
						if (flag2)
						{
							dataRow4["stat"] = "بد";
						}
						else
						{
							flag2 = (num2 < 0L);
							if (flag2)
							{
								dataRow4["stat"] = "بس";
							}
							else
							{
								dataRow4["stat"] = "ت";
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator3;
					bool flag2 = enumerator3 is IDisposable;
					if (flag2)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				long num3 = 0L;
				bool flag3;
				checked
				{
					bool flag2;
					try
					{
						IEnumerator enumerator4 = dataTable.Rows.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							DataRow dataRow5 = (DataRow)enumerator4.Current;
							dataRow5["rad"] = num3;
							num3 += 1L;
						}
					}
					finally
					{
						IEnumerator enumerator4;
						flag2 = (enumerator4 is IDisposable);
						if (flag2)
						{
							(enumerator4 as IDisposable).Dispose();
						}
					}
					int num4 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select isnull(kind,0) from moshtari where id=", this.txt_moshtari.Value)
					}, null, null, null));
					bool arg_9C6_0;
					if (num4 != 1 && num4 != 3)
					{
						if (num4 != 5)
						{
							arg_9C6_0 = false;
							goto IL_9C5;
						}
					}
					arg_9C6_0 = true;
					IL_9C5:
					flag2 = arg_9C6_0;
					if (flag2)
					{
						int num5 = -1;
						int num6 = -1;
						string text2 = string.Empty;
						num5 = this.GetNextPosBed(num5, dataTable);
						num6 = this.GetNextPosBes(num6, dataTable);
						while (num5 != -1 && num6 != -1)
						{
							flag2 = Operators.ConditionalCompareObjectLess(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"], false);
							if (flag2)
							{
								flag = (Operators.CompareString(text2, string.Empty, false) != 0);
								DataRow dataRow2;
								string columnName;
								if (flag)
								{
									flag3 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
									if (flag3)
									{
										dataRow2 = dataTable.Rows[num6];
										DataRow arg_AA9_0 = dataRow2;
										columnName = "Tozih";
										arg_AA9_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], " ( تسویه تا " + text2 + " ) ");
									}
									text2 = string.Empty;
								}
								dataRow2 = dataTable.Rows[num5];
								DataRow arg_AFA_0 = dataRow2;
								columnName = "rembed";
								arg_AFA_0[columnName] = Operators.SubtractObject(dataRow2[columnName], dataTable.Rows[num6]["rembes"]);
								flag3 = Operators.ConditionalCompareObjectNotEqual(dataTable.Rows[num6]["stat"], "ت", false);
								if (flag3)
								{
									flag2 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
									if (flag2)
									{
										dataRow2 = dataTable.Rows[num6];
										DataRow arg_BCB_0 = dataRow2;
										columnName = "Tozih";
										arg_BCB_0[columnName] = Operators.ConcatenateObject(dataRow2[columnName], Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ( وجه به ", dataTable.Rows[num5]["Tarikh_Fa"]), " - مانده "), Public_Function.FormatPrice(Conversions.ToString(dataTable.Rows[num5]["rembed"]))), " ) "));
									}
								}
								num6 = this.GetNextPosBes(num6, dataTable);
							}
							else
							{
								long num7 = Conversions.ToLong(Operators.SubtractObject(dataTable.Rows[num6]["rembes"], dataTable.Rows[num5]["rembed"]));
								dataTable.Rows[num5]["rembed"] = 0;
								text2 = Conversions.ToString(dataTable.Rows[num5]["Tarikh_Fa"]);
								num5 = this.GetNextPosBed(num5, dataTable);
								dataTable.Rows[num6]["rembes"] = num7;
							}
						}
					}
					int num8 = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num8 > 0);
					if (flag3)
					{
						long value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
						{
							Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
						}, null, null, null));
						this.LabelCommand10.Text = "جمع " + Conversions.ToString(num8) + " فقره چک برگشتی " + Public_Function.FormatPrice(Conversions.ToString(value));
					}
					else
					{
						this.LabelCommand10.Text = string.Empty;
					}
					this.GridEX1.DataSource = dataTable;
					this.GridEX1.Refresh();
					flag3 = (dataTable.Rows.Count > 0);
					if (flag3)
					{
						string text3 = this.get_Tasvie_Tarikh(dataTable);
						flag3 = (Operators.CompareString(text3, string.Empty, false) == 0);
						if (flag3)
						{
							object arg_E17_0 = this.txt_az_tarikh;
							Type arg_E17_1 = null;
							string arg_E17_2 = "SetDate";
							object[] array2 = new object[1];
							object[] arg_DFD_0 = array2;
							int arg_DFD_1 = 0;
							DataRow dataRow2 = dataTable.Rows[0];
							DataRow arg_DF3_0 = dataRow2;
							string columnName = "tarikh_Fa";
							arg_DFD_0[arg_DFD_1] = RuntimeHelpers.GetObjectValue(arg_DF3_0[columnName]);
							object[] array3 = array2;
							object[] arg_E17_3 = array3;
							string[] arg_E17_4 = null;
							Type[] arg_E17_5 = null;
							bool[] array4 = new bool[]
							{
								true
							};
							NewLateBinding.LateCall(arg_E17_0, arg_E17_1, arg_E17_2, arg_E17_3, arg_E17_4, arg_E17_5, array4, true);
							if (array4[0])
							{
								dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array3[0]);
							}
						}
						else
						{
							this.txt_az_tarikh.SetDate(text3);
							flag3 = (Operators.CompareString(this.txt_ta_tarikh.Text, this.txt_az_tarikh.Text, false) < 0);
							if (flag3)
							{
								object arg_ECF_0 = this.txt_ta_tarikh;
								Type arg_ECF_1 = null;
								string arg_ECF_2 = "SetDate";
								object[] array3 = new object[1];
								object[] arg_EB5_0 = array3;
								int arg_EB5_1 = 0;
								DataRow dataRow2 = dataTable.Rows[dataTable.Rows.Count - 1];
								DataRow arg_EAB_0 = dataRow2;
								string columnName = "tarikh_fa";
								arg_EB5_0[arg_EB5_1] = RuntimeHelpers.GetObjectValue(arg_EAB_0[columnName]);
								object[] array2 = array3;
								object[] arg_ECF_3 = array2;
								string[] arg_ECF_4 = null;
								Type[] arg_ECF_5 = null;
								bool[] array4 = new bool[]
								{
									true
								};
								NewLateBinding.LateCall(arg_ECF_0, arg_ECF_1, arg_ECF_2, arg_ECF_3, arg_ECF_4, arg_ECF_5, array4, true);
								if (array4[0])
								{
									dataRow2[columnName] = RuntimeHelpers.GetObjectValue(array2[0]);
								}
							}
						}
						this.last_mande = Conversions.ToLong(dataTable.Rows[dataTable.Rows.Count - 1]["mande"]);
						this.last_stat = Conversions.ToString(dataTable.Rows[dataTable.Rows.Count - 1]["stat"]);
					}
					else
					{
						this.last_mande = 0L;
						this.last_stat = string.Empty;
					}
					this.mande = string.Empty;
					try
					{
						IEnumerator enumerator5 = dataTable.Rows.GetEnumerator();
						while (enumerator5.MoveNext())
						{
							DataRow dataRow6 = (DataRow)enumerator5.Current;
							flag3 = (dataRow6["Kala_Name"] == DBNull.Value);
							if (flag3)
							{
								dataRow6["kala_Name"] = string.Empty;
							}
							flag3 = (Operators.ConditionalCompareObjectEqual(dataRow6["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(dataRow6["bes"], 0, false));
							if (flag3)
							{
								this.mande = "مبلغ تاریخ " + dataRow6["tarikh_fa"].ToString() + " مانده است";
							}
						}
					}
					finally
					{
						IEnumerator enumerator5;
						flag3 = (enumerator5 is IDisposable);
						if (flag3)
						{
							(enumerator5 as IDisposable).Dispose();
						}
					}
					this.Add();
					string rowFilter = string.Empty;
					flag3 = Conversions.ToBoolean(Public_Function.dict["surathesab_tasvie"]);
					if (flag3)
					{
						string text4 = this.get_Tasvie_radif((DataTable)this.GridEX1.DataSource);
						flag3 = (Operators.CompareString(text4, string.Empty, false) != 0);
						if (flag3)
						{
							rowFilter = "rad>" + text4;
							dataTable.DefaultView.RowFilter = rowFilter;
						}
					}
					this.GridEX1.MoveLast();
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.txt_moshtari.Value);
					long num9 = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("SELECT      isnull(count(Safi_Furush.ID),0)   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					flag3 = (num9 == 0L);
					if (flag3)
					{
						this.ButtonCommand1.Visible = false;
					}
					else
					{
						this.ButtonCommand1.Visible = true;
						this.ButtonCommand1.Text = "تعداد " + Conversions.ToString(num9) + " صافی اعلام نشده وجود دارد";
					}
					this.show_tedad_safi(dataTable);
					long num10 = this.Refresh_Status();
					flag3 = (num10 != this.last_mande);
				}
				if (flag3)
				{
					this.Delete_Sanad_Invalid(dataTable, (long)num);
					this.Moshtari_Info.Moshtari_ID = Conversions.ToInteger(this.txt_moshtari.Value);
					this.Refresh_Status();
				}
				this.txt_az_tarikh.Focus();
				this.txt_az_tarikh.SelectionLength = 0;
				this.txt_az_tarikh.SelectionStart = 5;
				this.txt_az_tarikh.SelectionLength = 2;
			}
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x002256E8 File Offset: 0x002238E8
		public string get_Tasvie_Tarikh(DataTable dt)
		{
			string text = string.Empty;
			bool flag;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					flag = Operators.ConditionalCompareObjectEqual(dataRow["stat"], "ت", false);
					if (flag)
					{
						text = Conversions.ToString(dt.Rows.IndexOf(dataRow));
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
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			string result;
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(text) + 1.0 < (double)dt.Rows.Count;
				if (flag2)
				{
					result = Conversions.ToString(dt.Rows[checked((int)Math.Round(unchecked(Conversions.ToDouble(text) + 1.0)))]["tarikh_Fa"]);
				}
				else
				{
					result = Conversions.ToString(dt.Rows[Conversions.ToInteger(text)]["tarikh_fa"]);
				}
			}
			else
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x00225828 File Offset: 0x00223A28
		public string get_Tasvie_radif(DataTable dt)
		{
			string result = string.Empty;
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = Operators.ConditionalCompareObjectEqual(dataRow["stat"], "ت", false);
					if (flag)
					{
						result = Conversions.ToString(dataRow["rad"]);
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x0024541C File Offset: 0x0024361C
		public void Add()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				flag = !dataTable.Columns.Contains("Filter");
				if (flag)
				{
					dataTable.Columns.Add("Filter", typeof(string));
				}
				string text = string.Empty;
				try
				{
					IEnumerator enumerator = dataTable.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRow dataRow = (DataRow)enumerator.Current;
						try
						{
							IEnumerator enumerator2 = this.GridEX1.RootTable.Columns.GetEnumerator();
							while (enumerator2.MoveNext())
							{
								GridEXColumn gridEXColumn = (GridEXColumn)enumerator2.Current;
								text += dataRow[gridEXColumn.DataMember].ToString();
							}
						}
						finally
						{
							IEnumerator enumerator2;
							flag = (enumerator2 is IDisposable);
							if (flag)
							{
								(enumerator2 as IDisposable).Dispose();
							}
						}
						dataRow["filter"] = text;
						text = string.Empty;
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
			}
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x00245588 File Offset: 0x00243788
		private void Frm_SuratHesab_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_moshtari.AddNewForm = MyProject.Forms.Frm_Moshtari;
			this.txt_moshtari.Edit_Frm = MyProject.Forms.Frm_Moshtari;
			this.txt_az_tarikh.SetNew();
			this.txt_ta_tarikh.SetNew();
			bool hasValue = this.Moshtari_id.HasValue;
			if (hasValue)
			{
				string arg_7E_0 = "select count(moshtari_id) from sharik where moshtari_id=";
				int? moshtari_id = this.Moshtari_id;
				bool flag = Operators.ConditionalCompareObjectEqual(Public_Function.ExecuteScalar(arg_7E_0 + (moshtari_id.HasValue ? Conversions.ToString(moshtari_id.GetValueOrDefault()) : null)), 1, false);
				if (flag)
				{
					return;
				}
				this.Moshtari_Info.Moshtari_ID = (T)this.Moshtari_id;
				this.txt_moshtari.SetValue(this.Moshtari_Name, this.Moshtari_id);
				this.SelectItem1_SelectedValueChanged(null, null);
				this.Refresh_Status();
				this.txt_az_tarikh.TabIndex = 0;
				this.txt_ta_tarikh.TabIndex = 1;
				this.txt_moshtari.TabIndex = 4;
			}
			this.txt_az_tarikh.Focus();
			this.txt_az_tarikh.SelectionLength = 0;
			this.txt_az_tarikh.SelectionStart = 5;
			this.txt_az_tarikh.SelectionLength = 2;
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x002456D4 File Offset: 0x002438D4
		private void ExportReport()
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				StiReport stiReport = this.RenderReport(true);
				flag = (stiReport == null);
				if (!flag)
				{
					Public_Function.Sti_replace(stiReport, "Text1,Text48,Text5,Text45,Text36,Text30,Text32,Text46");
					StiText stiText = (StiText)stiReport.GetComponentByName("Text2");
					flag = (stiText != null);
					if (flag)
					{
						stiText.Text = Public_Function.RenderDigitToPdf(stiText.Text);
					}
					StiPdfExportService stiPdfExportService = new StiPdfExportService();
					StiJpegExportSettings stiJpegExportSettings = new StiJpegExportSettings();
					stiPdfExportService.MultipleFiles = true;
					stiReport.Render(true);
					string text = Public_Function.MiladiToShamsi(DateAndTime.Now).Replace("/", "");
					stiPdfExportService.ExportPdf(stiReport, string.Concat(new string[]
					{
						this.FolderBrowserDialog1.SelectedPath,
						"\\",
						this.txt_moshtari.Text,
						"-",
						text,
						".pdf"
					}));
					Public_Function.ShowMessage("گزارش تهیه گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
				}
			}
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00245800 File Offset: 0x00243A00
		private void Frm_SuratHesab_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			else
			{
				flag = (keyCode == Keys.F6);
				if (flag)
				{
					this.ButtonItem4_Click(null, null);
				}
				else
				{
					flag = (keyCode == Keys.F7);
					if (flag)
					{
						this.ButtonItem7_Click(null, null);
					}
				}
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.txt_moshtari.PerformButtonClick();
			}
			flag = (e.Shift && e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ExportReport();
			}
			else
			{
				flag = (e.KeyCode == Keys.F4);
				if (flag)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x002458AC File Offset: 0x00243AAC
		private void showkharid(DataRowView row)
		{
			int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Kharid.Num  FROM         Kharid_Furush INNER JOIN  Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID where sanad_id=", row["id"])
			}, null, null, null));
			Frm_Kharid_Furush frm_Kharid_Furush = new Frm_Kharid_Furush();
			frm_Kharid_Furush.Num = num;
			bool flag = Operators.ConditionalCompareObjectEqual(row["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(row["bes"], 0, false);
			if (flag)
			{
				DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     kharid_furush.ID, Kala.Name FROM kharid_furush INNER JOIN Kala ON kharid_furush.Kala_ID = Kala.ID where moshtari_id=", this.txt_moshtari.Value), " and tarikh_fa= "), Public_Function.GetValue(Conversions.ToString(row["tarikh_fa"])))));
				flag = (dataTable != null);
				if (flag)
				{
					bool flag2 = dataTable.Rows.Count == 1;
					if (flag2)
					{
						frm_Kharid_Furush.GotoLineID = Conversions.ToInteger(dataTable.Rows[0]["id"]);
					}
					else
					{
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag2 = Operators.ConditionalCompareObjectEqual(dataRow["name"], row["kala_name"], false);
								if (flag2)
								{
									frm_Kharid_Furush.GotoLineID = Conversions.ToInteger(dataRow["id"]);
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
					}
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Kharid_Furush);
			this.SelectItem1_SelectedValueChanged(null, null);
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x00245A90 File Offset: 0x00243C90
		private void ShowFurush(DataRowView row)
		{
			bool flag = row["id"] == DBNull.Value;
			if (!flag)
			{
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT     Furush_Hag.Num  FROM         Furush_Hag_Detail INNER JOIN  Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID where sanad_id=", row["id"])
				}, null, null, null));
				frm_Frush_hag frm_Frush_hag = new frm_Frush_hag();
				frm_Frush_hag.Show_Preview = true;
				frm_Frush_hag.Num = num;
				flag = (Operators.ConditionalCompareObjectEqual(row["bed"], 0, false) && Operators.ConditionalCompareObjectEqual(row["bes"], 0, false));
				if (flag)
				{
					DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Furush_Hag_Detail.ID, Kala.Name FROM Furush_Hag_Detail INNER JOIN Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID where moshtari_id=", this.txt_moshtari.Value), " and tarikh_fa= "), Public_Function.GetValue(Conversions.ToString(row["tarikh_fa"])))));
					flag = (dataTable != null);
					if (flag)
					{
						bool flag2 = dataTable.Rows.Count == 1;
						if (flag2)
						{
							frm_Frush_hag.GotoLineID = Conversions.ToInteger(dataTable.Rows[0]["id"]);
						}
						else
						{
							try
							{
								IEnumerator enumerator = dataTable.Rows.GetEnumerator();
								while (enumerator.MoveNext())
								{
									DataRow dataRow = (DataRow)enumerator.Current;
									flag2 = Operators.ConditionalCompareObjectEqual(dataRow["name"], row["kala_name"], false);
									if (flag2)
									{
										frm_Frush_hag.GotoLineID = Conversions.ToInteger(dataRow["id"]);
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
						}
					}
				}
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Frush_hag);
				this.SelectItem1_SelectedValueChanged(null, null);
			}
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x00245C9C File Offset: 0x00243E9C
		private void ShowSafi(DataRowView row)
		{
			DataRow dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			Frm_Safi frm_Safi = new Frm_Safi();
			frm_Safi.Furush_ID = Conversions.ToLong(dataRow["furush_hag_id"]);
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Safi);
			dataRow = Public_Function.FillDataRow(Conversions.ToString(Operators.ConcatenateObject("select * from safi_furush where sanad_id=", row["ID"])));
			bool flag = dataRow["printcount"] != DBNull.Value;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["printcount"].Value = 1;
				this.GridEX1.Refresh();
			}
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x002263B8 File Offset: 0x002245B8
		private void ShowDaryaftPardakht(DataRowView row)
		{
			string text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbed_id=", row["id"])
			}, null, null, null));
			bool flag = Operators.CompareString(text, string.Empty, false) == 0;
			if (flag)
			{
				text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT     Tarikh  FROM DaryaftPardakht  where sanadbes_id=", row["id"])
				}, null, null, null));
			}
			flag = (Operators.CompareString(text, string.Empty, false) != 0);
			if (flag)
			{
				Frm_DaryaftPardakht frm_DaryaftPardakht = new Frm_DaryaftPardakht();
				frm_DaryaftPardakht.PreviewTarikh = Public_Function.MiladiToShamsi(Conversions.ToDate(text));
				frm_DaryaftPardakht.ShowPreview = true;
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_DaryaftPardakht);
			}
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x002264A4 File Offset: 0x002246A4
		private void ShowrizKharid(DataRowView row)
		{
			long num = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
			{
				Operators.ConcatenateObject("select kharid_id from kharid_detail where sanad_id=", row["id"])
			}, null, null, null));
			Frm_RizKharid frm_RizKharid = new Frm_RizKharid
			{
				Kharid_ID = num,
				Preview = true
			};
			Kharid_Detail kharid_Detail = new Kharid_Detail();
			DataTable byID = kharid_Detail.GetByID(checked((int)num));
			frm_RizKharid.dt_Kharid = byID;
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_RizKharid);
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00245D6C File Offset: 0x00243F6C
		private void GridEX1_CellEdited(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "checked", false) == 0;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["sanadtype"].Value, 4, false);
				if (flag2)
				{
					this.GridEX1.CancelCurrentEdit();
				}
			}
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00245DD8 File Offset: 0x00243FD8
		private void GridEX1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.GridEX1_RowDoubleClick(null, null);
			}
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00245E00 File Offset: 0x00244000
		private void GridEX1_RowDoubleClick(object sender, RowActionEventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
				flag = (dataRowView["sanadtype"] == DBNull.Value);
				if (!flag)
				{
					object left = dataRowView["sanadtype"];
					flag = Operators.ConditionalCompareObjectEqual(left, 1, false);
					if (flag)
					{
						this.ShowDaryaftPardakht(dataRowView);
					}
					else
					{
						flag = Operators.ConditionalCompareObjectEqual(left, 3, false);
						if (flag)
						{
							this.showkharid(dataRowView);
						}
						else
						{
							flag = Operators.ConditionalCompareObjectEqual(left, 2, false);
							if (flag)
							{
								this.ShowFurush(dataRowView);
							}
							else
							{
								flag = Operators.ConditionalCompareObjectEqual(left, 4, false);
								if (flag)
								{
									this.ShowSafi(dataRowView);
								}
								else
								{
									flag = Operators.ConditionalCompareObjectEqual(left, 5, false);
									if (flag)
									{
										this.ShowrizKharid(dataRowView);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x00245EF4 File Offset: 0x002440F4
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab showFrm = new Frm_Moshtari_Hesab
			{
				Moshtari_ID = Conversions.ToString(this.txt_moshtari.Value)
			};
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00245F34 File Offset: 0x00244134
		private void ButtonItem11_Click(object sender, EventArgs e)
		{
			Frm_rpt_checkDaryafti frm_rpt_checkDaryafti = new Frm_rpt_checkDaryafti();
			Frm_rpt_checkDaryafti arg_25_0 = frm_rpt_checkDaryafti;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checkDaryafti.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checkDaryafti showFrm = frm_rpt_checkDaryafti;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00245F94 File Offset: 0x00244194
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_rpt_checksearchMoshtari frm_rpt_checksearchMoshtari = new Frm_rpt_checksearchMoshtari();
			Frm_rpt_checksearchMoshtari arg_25_0 = frm_rpt_checksearchMoshtari;
			object expr_13 = this.txt_moshtari.Value;
			int? num;
			arg_25_0.Moshtari_ID = ((expr_13 != null) ? ((int?)expr_13) : num);
			frm_rpt_checksearchMoshtari.Moshtari_Name = this.txt_moshtari.Text;
			Frm_rpt_checksearchMoshtari showFrm = frm_rpt_checksearchMoshtari;
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00245FF4 File Offset: 0x002441F4
		private StiReport RenderReport(bool pdf)
		{
			bool flag = this.GridEX1.DataSource == null;
			StiReport result;
			if (flag)
			{
				result = null;
			}
			else
			{
				StiReport stiReport = new StiReport();
				stiReport.Load(Application.StartupPath + "\\reports\\surathesab.mrt");
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				DataTable dataTable2 = dataTable.Copy();
				DataTable dataTable3 = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("select * from moshtari_pic  where moshtari_id=", this.txt_moshtari.Value)));
				dataTable3.TableName = "pic";
				if (pdf)
				{
					Public_Function.RenderDigitToPdf(dataTable2);
				}
				dataTable2.DefaultView.RowFilter = dataTable.DefaultView.RowFilter;
				stiReport.RegData(dataTable2.DefaultView);
				stiReport.RegData(dataTable3);
				Public_Function.SetHeader(stiReport, pdf);
				StiText stiText = (StiText)stiReport.GetComponentByName("Text13");
				stiText.Text = this.txt_moshtari.Text;
				Public_Function.SetSti_text(stiReport, "Text31", Public_Function.ToFarsi(this.lbl_tel1.Text));
				Public_Function.SetSti_text(stiReport, "Text33", Public_Function.ToFarsi(this.lbl_tel2.Text));
				Public_Function.SetSti_text(stiReport, "Text37", Public_Function.ToFarsi(this.Label7.Text));
				Public_Function.SetSti_text(stiReport, "Text16", Public_Function.ToFarsi(this.lbl_addr.Text));
				Public_Function.SetSti_text(stiReport, "Text49", Public_Function.ToFarsi(this.lbl_code.Text));
				Public_Function.SetSti_text(stiReport, "txt_codemelli", Public_Function.ToFarsi(this.lbl_codemelli.Text));
				Public_Function.SetSti_text(stiReport, "Text47", Public_Function.ToFarsi(this.lbl_shahr.Text));
				Public_Function.SetSti_text(stiReport, "Text35", Public_Function.ToFarsi(Public_Function.MiladiToShamsi(DateAndTime.Now)));
				stiText = (StiText)stiReport.GetComponentByName("Text40");
				if (pdf)
				{
					stiText.Text = Public_Function.RenderDigitToPdf(this.Moshtari_Info.LastTozih);
				}
				else
				{
					stiText.Text = this.Moshtari_Info.LastTozih;
				}
				stiText = (StiText)stiReport.GetComponentByName("Text41");
				if (pdf)
				{
					stiText.Text = Public_Function.RenderDigitToPdf(this.Moshtari_Info.Check_Status);
				}
				else
				{
					stiText.Text = this.Moshtari_Info.Check_Status;
				}
				stiText = (StiText)stiReport.GetComponentByName("Text2");
				flag = (stiText != null);
				if (flag)
				{
					stiText.Text = "از تاریخ " + Public_Function.ToFarsi(this.txt_az_tarikh.Text) + "تا تاریخ " + Public_Function.ToFarsi(this.txt_ta_tarikh.Text);
				}
				else
				{
					stiText = (StiText)stiReport.GetComponentByName("txt_az_tarikh");
					stiText.Text = Public_Function.ToFarsi(this.txt_az_tarikh.Text);
					stiText = (StiText)stiReport.GetComponentByName("txt_ta_tarikh");
					stiText.Text = Public_Function.ToFarsi(this.txt_ta_tarikh.Text);
				}
				stiText = (StiText)stiReport.GetComponentByName("txt_mande");
				flag = (stiText != null);
				if (flag)
				{
					stiText.Text = huruf.ConvertToHuruf(Conversions.ToString(this.Moshtari_Info.Mande), huruf.ConvertType.ریال);
				}
				int num = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select count(id) from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				flag = (num > 0);
				if (flag)
				{
					long value = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject("select sum(mablagh)  from daryaftpardakht where dptype_id=22 and moshtari_id=", this.txt_moshtari.Value)
					}, null, null, null));
					stiText = (StiText)stiReport.GetComponentByName("Text42");
					if (pdf)
					{
						stiText.Text = Public_Function.RenderDigitToPdf("جمع " + Public_Function.ToFarsi(Conversions.ToString(num)) + " فقره چک برگشتی " + Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(value))));
					}
					else
					{
						stiText.Text = "جمع " + Public_Function.ToFarsi(Conversions.ToString(num)) + " فقره چک برگشتی " + Public_Function.ToFarsi(Public_Function.FormatPrice(Conversions.ToString(value)));
					}
				}
				Public_Function.AddTazminText(stiReport, true, pdf);
				Public_Function.SetReport_MarginTop(stiReport);
				Public_Function.setReportFont(stiReport, "Text14,Text17,Text39,Text19,Text18,Text20,Text21,Text22,Text24,Text25,Text28");
				result = stiReport;
			}
			return result;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x002464D4 File Offset: 0x002446D4
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = this.RenderReport(false);
			bool flag = stiReport == null;
			if (!flag)
			{
				stiReport.Print(false);
			}
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0000C91F File Offset: 0x0000AB1F
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.txt_search.Text);
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00246500 File Offset: 0x00244700
		private void FilterDate()
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select codehesab_id from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
				DataRow dataRow = Public_Function.FillDataRow("  SELECT     null as ID, null as CodeHesab_ID,isnull(sum( Sanad.Bed),0) as Bed,isnull(sum( Sanad.Bes),0) as Bes,max(tarikh) as Tarikh, null as Tarikh_Fa, '' as Tozih,null AS Kala_Name,null AS rembed,   null AS rembes, null as Tedad,null as  Vazn_Kol,NULL AS Fee,NULL as ba_zarf,-1 as sanadtype,-1 as printcount    FROM Sanad    WHERE Sanad.CodeHesab_ID = " + Conversions.ToString(value) + " and sanad.tarikh<" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text)));
				dataRow["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text);
				dataRow["Tozih"] = "مانده از قبل";
				DataRow dataRow2 = dataTable.NewRow();
				flag = Operators.ConditionalCompareObjectGreater(dataRow["bed"], dataRow["bes"], false);
				if (flag)
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bed"], dataRow["bes"]);
					dataRow2["stat"] = "بد";
				}
				else
				{
					dataRow2["mande"] = Operators.SubtractObject(dataRow["bes"], dataRow["bed"]);
					dataRow2["stat"] = "بس";
				}
				flag = Operators.ConditionalCompareObjectNotEqual(dataRow2["mande"], 0, false);
				if (flag)
				{
					bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
					if (flag2)
					{
						dataTable.Rows[0].Delete();
					}
					dataRow2["bed"] = RuntimeHelpers.GetObjectValue(dataRow["bed"]);
					dataRow2["bes"] = RuntimeHelpers.GetObjectValue(dataRow["bes"]);
					dataRow2["tozih"] = "مانده از قبل";
					dataRow2["tarikh"] = Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text);
					dataRow2["printcount"] = -1;
					dataTable.Rows.InsertAt(dataRow2, 0);
				}
				else
				{
					bool flag2 = dataTable.Rows[0]["ID"] == DBNull.Value;
					if (flag2)
					{
						dataTable.Rows[0].Delete();
					}
				}
				dataTable.DefaultView.RowFilter = string.Concat(new string[]
				{
					"tarikh >= '",
					Public_Function.ShamsiToMiladi(this.txt_az_tarikh.Text),
					"' AND tarikh<='",
					Public_Function.ShamsiToMiladi(this.txt_ta_tarikh.Text),
					"'"
				});
				this.show_tedad_safi(dataTable);
				this.GridEX1.MoveFirst();
				this.GridEX1.MoveLast();
			}
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00246810 File Offset: 0x00244A10
		private void show_tedad_safi(DataTable dt)
		{
			int num = 0;
			int num2 = 0;
			checked
			{
				bool flag2;
				try
				{
					IEnumerator enumerator = dt.DefaultView.GetEnumerator();
					while (enumerator.MoveNext())
					{
						DataRowView dataRowView = (DataRowView)enumerator.Current;
						bool flag = dataRowView["sanadtype"] == DBNull.Value;
						if (!flag)
						{
							flag = Operators.ConditionalCompareObjectEqual(dataRowView["sanadtype"], 4, false);
							if (flag)
							{
								num++;
							}
							flag = Operators.ConditionalCompareObjectGreater(dataRowView["bed"], 0, false);
							if (flag)
							{
								flag2 = dataRowView["tozih"].ToString().Contains("فروش");
								if (!flag2)
								{
									num2++;
								}
							}
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
				flag2 = (num > 0);
				if (flag2)
				{
					this.txt_tedad_safi.Visible = true;
					this.txt_tedad_havale.Visible = true;
					this.Label13.Visible = true;
					this.Label16.Visible = true;
					this.txt_tedad_safi.Text = Conversions.ToString(num);
					this.txt_tedad_havale.Text = Conversions.ToString(num2);
				}
				else
				{
					this.txt_tedad_safi.Visible = false;
					this.txt_tedad_havale.Visible = false;
					this.Label13.Visible = false;
					this.Label16.Visible = false;
				}
				object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select top 1 id from Furush_Hag where Moshtari_ID=", this.txt_moshtari.Value)
				}, null, null, null));
				flag2 = (objectValue != null);
				if (flag2)
				{
					this.txt_tedad_safi_mande.Visible = true;
					this.Label17.Visible = true;
					int value = Conversions.ToInteger(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject("select count(Furush_Hag.id) from Furush_Hag  left outer join  Safi_Furush  on Furush_Hag.ID=Safi_Furush.Furush_Hag_ID  where Moshtari_id = ", this.txt_moshtari.Value), " and Safi_Furush.ID is null")
					}, null, null, null));
					this.txt_tedad_safi_mande.Text = Conversions.ToString(value);
				}
				else
				{
					this.txt_tedad_safi_mande.Visible = false;
					this.Label17.Visible = false;
				}
			}
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00246A8C File Offset: 0x00244C8C
		private void txt_az_tarikh_KeyDown_1(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.FilterDate();
			}
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0000C93A File Offset: 0x0000AB3A
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_moshtari.PerformButtonClick();
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00246AB4 File Offset: 0x00244CB4
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			if (!flag)
			{
				Frm_Rpt_Furush frm_Rpt_Furush = new Frm_Rpt_Furush();
				frm_Rpt_Furush.txt_moshtari.SetValue(this.txt_moshtari.Text, RuntimeHelpers.GetObjectValue(this.txt_moshtari.Value));
				frm_Rpt_Furush.loaddata();
				frm_Rpt_Furush.ShowDialog();
			}
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00246B14 File Offset: 0x00244D14
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value != null;
			if (flag)
			{
				Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
				Frm_Moshtari arg_3D_0 = frm_Moshtari;
				object expr_2B = this.txt_moshtari.Value;
				int? num;
				arg_3D_0.ID = ((expr_2B != null) ? ((int?)expr_2B) : num);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Moshtari);
				this.txt_moshtari.Text = Conversions.ToString(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("select name+' '+family from moshtari where id=", this.txt_moshtari.Value)
				}, null, null, null));
			}
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00246BC4 File Offset: 0x00244DC4
		private void GridEX1_LoadingRow(object sender, RowLoadEventArgs e)
		{
			bool flag = e.Row.RowType == RowType.TotalRow;
			if (flag)
			{
				e.Row.Cells["mande"].Text = Public_Function.FormatPrice(Conversions.ToString(this.last_mande));
				e.Row.Cells["stat"].Text = this.last_stat;
				e.Row.Cells["Tozih"].Text = this.mande;
				flag = (Operators.CompareString(this.mande, string.Empty, false) != 0);
				if (flag)
				{
					e.Row.Cells["Tozih"].FormatStyle = new GridEXFormatStyle();
					e.Row.Cells["Tozih"].FormatStyle.BackColor = Color.LightCoral;
					e.Row.Cells["Tozih"].FormatStyle.BackgroundGradientMode = BackgroundGradientMode.Solid;
				}
			}
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x0000C94A File Offset: 0x0000AB4A
		private void txt_jamkharid_CheckedChanged(object sender, EventArgs e)
		{
			this.SelectItem1_SelectedValueChanged(null, null);
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00246CD8 File Offset: 0x00244ED8
		private void SendMessage(string msg, string tel)
		{
			KavenegarApi kavenegarApi = new KavenegarApi(Public_Function.dict["sms_apikey"]);
			try
			{
				SendResult sendResult = kavenegarApi.Send(Public_Function.dict["sms_number"], tel, msg);
			}
			catch (Exception expr_31)
			{
				ProjectData.SetProjectError(expr_31);
				Public_Function.ShowMessage("اینترنت وصل نمیباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00246D48 File Offset: 0x00244F48
		private string GetMessage(GridEXRow row)
		{
			string text = string.Empty;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(row.Cells["Tarikh_Fa"].Value, Environment.NewLine)));
			bool flag = Operators.ConditionalCompareObjectEqual(row.Cells["Tozih"].Value, "مانده از قبل", false);
			checked
			{
				string result;
				if (flag)
				{
					text = string.Concat(new string[]
					{
						text,
						"مانده قبل از ",
						this.txt_az_tarikh.Text,
						":",
						Public_Function.FormatPrice(Conversions.ToString(row.Cells["mande"].Value))
					});
					result = text;
				}
				else
				{
					flag = row.Cells["Tozih"].Value.ToString().Contains(")");
					if (flag)
					{
						int num = row.Cells["Tozih"].Value.ToString().IndexOf("(");
						int num2 = row.Cells["Tozih"].Value.ToString().IndexOf(")");
						text = row.Cells["Tozih"].Value.ToString().Remove(num, num2 - num + 2);
						num = text.ToString().IndexOf("(");
						flag = (num > 0);
						if (flag)
						{
							num2 = text.ToString().IndexOf(")");
							text = text.ToString().Remove(num, num2 - num + 2);
						}
						text += Environment.NewLine;
					}
					else
					{
						text = text + row.Cells["Tozih"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["tedad"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "تعداد:" + row.Cells["tedad"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["vazn_kol"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "خالص:" + row.Cells["vazn_kol"].Value.ToString() + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["fee"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "فی:" + row.Cells["fee"].Value.ToString().Replace(".0", "") + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["bed"].Value.ToString(), "0", false) != 0);
					if (flag)
					{
						text = text + "مبلغ:" + Public_Function.FormatPrice(row.Cells["bed"].Value.ToString()) + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["bes"].Value.ToString(), "0", false) != 0);
					if (flag)
					{
						text = text + "مبلغ:" + Public_Function.FormatPrice(row.Cells["bes"].Value.ToString()) + Environment.NewLine;
					}
					flag = (Operators.CompareString(row.Cells["mande"].Value.ToString(), string.Empty, false) != 0);
					if (flag)
					{
						text = text + "مانده:" + Public_Function.FormatPrice(row.Cells["mande"].Value.ToString());
					}
					result = text;
				}
				return result;
			}
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00247174 File Offset: 0x00245374
		private void ButtonItem6_Click(object sender, EventArgs e)
		{
			bool flag = Operators.CompareString(this.lbl_tel2.Text, string.Empty, false) == 0;
			checked
			{
				if (flag)
				{
					Public_Function.ShowMessage("شماره موبایل در مشخصات مشتری ثبت نگردیده است", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
				}
				else
				{
					string msg = string.Empty;
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow row = rows[i];
						msg = this.GetMessage(row);
						this.SendMessage(msg, this.lbl_tel2.Text);
					}
				}
			}
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x0000C957 File Offset: 0x0000AB57
		private void ButtonItem8_Click(object sender, EventArgs e)
		{
			this.ExportReport();
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x002471FC File Offset: 0x002453FC
		private void ButtonItem9_Click(object sender, EventArgs e)
		{
			bool flag = this.txt_moshtari.Value == null;
			checked
			{
				if (!flag)
				{
					DataTable dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject("SELECT      Safi_Furush.ID, Safi_Furush.printcount, Furush_Hag.Num, Furush_Hag.Moshtari_ID,Furush_Hag.ID AS Furush_ID   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)));
					string text = string.Empty;
					flag = (dataTable.Rows.Count > 0);
					if (flag)
					{
						Frm_Safi frm_Safi = new Frm_Safi();
						frm_Safi.WindowState = FormWindowState.Minimized;
						frm_Safi.ShowInTaskbar = false;
						frm_Safi.Show();
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								frm_Safi.Furush_ID = Conversions.ToLong(dataRow["furush_id"]);
								frm_Safi.Frm_Safi_Load(null, null);
								frm_Safi.ButtonItem4_Click(null, null);
								text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(" update safi_furush set printcount=1 where id= ", dataRow["ID"])));
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
						frm_Safi.Close();
					}
					flag = (text.Length > 0);
					if (flag)
					{
						Public_Function.ExecuteNonQuery(text);
					}
					GridEXRow[] rows = this.GridEX1.GetRows();
					for (int i = 0; i < rows.Length; i++)
					{
						GridEXRow gridEXRow = rows[i];
						gridEXRow.BeginEdit();
						gridEXRow.Cells["printcount"].Value = 1;
						gridEXRow.EndEdit();
					}
				}
			}
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00245D6C File Offset: 0x00243F6C
		private void GridEX1_CellValueChanged(object sender, ColumnActionEventArgs e)
		{
			bool flag = Operators.CompareString(e.Column.Key, "checked", false) == 0;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["sanadtype"].Value, 4, false);
				if (flag2)
				{
					this.GridEX1.CancelCurrentEdit();
				}
			}
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x002473AC File Offset: 0x002455AC
		private void RibbonStatusBar1_CommandClick(object sender, CommandEventArgs e)
		{
			bool flag = Operators.CompareString(e.Command.Key.ToLower(), "buttoncommand1", false) == 0;
			if (flag)
			{
				Frm_Rpt_SafiMande frm_Rpt_SafiMande = new Frm_Rpt_SafiMande();
				frm_Rpt_SafiMande.Moshtari_id = Conversions.ToLong(this.txt_moshtari.Value);
				MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Rpt_SafiMande);
				long num = Conversions.ToLong(NewLateBinding.LateGet(null, typeof(Public_Function), "ExecuteScalar", new object[]
				{
					Operators.ConcatenateObject("SELECT      isnull(count(Safi_Furush.ID),0)   FROM         Safi_Furush INNER JOIN   Furush_Hag ON Safi_Furush.Furush_Hag_ID = Furush_Hag.ID   where printcount is null AND Moshtari_id=", this.txt_moshtari.Value)
				}, null, null, null));
				flag = (num == 0L);
				if (flag)
				{
					this.ButtonCommand1.Visible = false;
				}
				else
				{
					this.ButtonCommand1.Visible = true;
					this.ButtonCommand1.Text = "تعداد " + Conversions.ToString(num) + " صافی اعلام نشده وجود دارد";
				}
			}
		}

		// Token: 0x0400131D RID: 4893
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400131F RID: 4895
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001320 RID: 4896
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04001321 RID: 4897
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04001322 RID: 4898
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001323 RID: 4899
		[AccessedThroughProperty("txt_moshtari")]
		private SelectItem _txt_moshtari;

		// Token: 0x04001324 RID: 4900
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04001325 RID: 4901
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04001326 RID: 4902
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04001327 RID: 4903
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04001328 RID: 4904
		[AccessedThroughProperty("lbl_tel3")]
		private Label _lbl_tel3;

		// Token: 0x04001329 RID: 4905
		[AccessedThroughProperty("lbl_tel4")]
		private Label _lbl_tel4;

		// Token: 0x0400132A RID: 4906
		[AccessedThroughProperty("lbl_tel2")]
		private Label _lbl_tel2;

		// Token: 0x0400132B RID: 4907
		[AccessedThroughProperty("lbl_tel1")]
		private Label _lbl_tel1;

		// Token: 0x0400132C RID: 4908
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400132D RID: 4909
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400132E RID: 4910
		[AccessedThroughProperty("lbl_codemelli")]
		private Label _lbl_codemelli;

		// Token: 0x0400132F RID: 4911
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x04001330 RID: 4912
		[AccessedThroughProperty("lbl_addr")]
		private Label _lbl_addr;

		// Token: 0x04001331 RID: 4913
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04001332 RID: 4914
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04001333 RID: 4915
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04001334 RID: 4916
		[AccessedThroughProperty("RibbonStatusBar1")]
		private RibbonStatusBar _RibbonStatusBar1;

		// Token: 0x04001335 RID: 4917
		[AccessedThroughProperty("LabelCommand5")]
		private LabelCommand _LabelCommand5;

		// Token: 0x04001336 RID: 4918
		[AccessedThroughProperty("LabelCommand6")]
		private LabelCommand _LabelCommand6;

		// Token: 0x04001337 RID: 4919
		[AccessedThroughProperty("LabelCommand7")]
		private LabelCommand _LabelCommand7;

		// Token: 0x04001338 RID: 4920
		[AccessedThroughProperty("LabelCommand8")]
		private LabelCommand _LabelCommand8;

		// Token: 0x04001339 RID: 4921
		[AccessedThroughProperty("LabelCommand1")]
		private LabelCommand _LabelCommand1;

		// Token: 0x0400133A RID: 4922
		[AccessedThroughProperty("LabelCommand2")]
		private LabelCommand _LabelCommand2;

		// Token: 0x0400133B RID: 4923
		[AccessedThroughProperty("LabelCommand3")]
		private LabelCommand _LabelCommand3;

		// Token: 0x0400133C RID: 4924
		[AccessedThroughProperty("LabelCommand4")]
		private LabelCommand _LabelCommand4;

		// Token: 0x0400133D RID: 4925
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400133E RID: 4926
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x0400133F RID: 4927
		[AccessedThroughProperty("ButtonItem11")]
		private ButtonItem _ButtonItem11;

		// Token: 0x04001340 RID: 4928
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04001341 RID: 4929
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001342 RID: 4930
		[AccessedThroughProperty("txt_search")]
		private EditBox _txt_search;

		// Token: 0x04001343 RID: 4931
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04001344 RID: 4932
		[AccessedThroughProperty("txt_ta_tarikh")]
		private DateBox2 _txt_ta_tarikh;

		// Token: 0x04001345 RID: 4933
		[AccessedThroughProperty("txt_az_tarikh")]
		private DateBox2 _txt_az_tarikh;

		// Token: 0x04001346 RID: 4934
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04001347 RID: 4935
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04001348 RID: 4936
		[AccessedThroughProperty("lbl_code")]
		private Label _lbl_code;

		// Token: 0x04001349 RID: 4937
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400134A RID: 4938
		[AccessedThroughProperty("LabelCommand10")]
		private LabelCommand _LabelCommand10;

		// Token: 0x0400134B RID: 4939
		[AccessedThroughProperty("LabelCommand9")]
		private LabelCommand _LabelCommand9;

		// Token: 0x0400134C RID: 4940
		[AccessedThroughProperty("lbl_shahr")]
		private Label _lbl_shahr;

		// Token: 0x0400134D RID: 4941
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400134E RID: 4942
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x0400134F RID: 4943
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04001350 RID: 4944
		[AccessedThroughProperty("txt_jamkharid")]
		private UICheckBox _txt_jamkharid;

		// Token: 0x04001351 RID: 4945
		[AccessedThroughProperty("ButtonItem6")]
		private ButtonItem _ButtonItem6;

		// Token: 0x04001352 RID: 4946
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04001353 RID: 4947
		[AccessedThroughProperty("ButtonItem8")]
		private ButtonItem _ButtonItem8;

		// Token: 0x04001354 RID: 4948
		[AccessedThroughProperty("ButtonItem9")]
		private ButtonItem _ButtonItem9;

		// Token: 0x04001355 RID: 4949
		[AccessedThroughProperty("ButtonCommand1")]
		private ButtonCommand _ButtonCommand1;

		// Token: 0x04001356 RID: 4950
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x04001357 RID: 4951
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x04001358 RID: 4952
		[AccessedThroughProperty("txt_tedad_safi_mande")]
		private EditBox _txt_tedad_safi_mande;

		// Token: 0x04001359 RID: 4953
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x0400135A RID: 4954
		[AccessedThroughProperty("txt_tedad_havale")]
		private EditBox _txt_tedad_havale;

		// Token: 0x0400135B RID: 4955
		[AccessedThroughProperty("txt_tedad_safi")]
		private EditBox _txt_tedad_safi;

		// Token: 0x0400135C RID: 4956
		private Moshtari_Info Moshtari_Info;

		// Token: 0x0400135D RID: 4957
		[CompilerGenerated]
		private int? _Moshtari_id;

		// Token: 0x0400135E RID: 4958
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x0400135F RID: 4959
		private Moshtari_Pic Moshtari_Pic;

		// Token: 0x04001360 RID: 4960
		private long last_mande;

		// Token: 0x04001361 RID: 4961
		private string last_stat;

		// Token: 0x04001362 RID: 4962
		private string mande;

		// Token: 0x0200014D RID: 333
		public enum bedbes
		{
			// Token: 0x04001364 RID: 4964
			bed,
			// Token: 0x04001365 RID: 4965
			bes
		}
	}
}
