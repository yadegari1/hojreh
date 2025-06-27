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
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200007C RID: 124
	[DesignerGenerated]
	public partial class Frm_Setting : Form
	{
		// Token: 0x06000A6F RID: 2671 RVA: 0x0000405F File Offset: 0x0000225F
		[DebuggerNonUserCode]
		public Frm_Setting()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Setting_KeyDown);
			base.Load += new EventHandler(this.Frm_Setting_Load);
			Frm_Setting.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00086958 File Offset: 0x00084B58
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Setting.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Setting.__ENCList.Count == Frm_Setting.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Setting.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Setting.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Setting.__ENCList[num] = Frm_Setting.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Setting.__ENCList.RemoveRange(num, Frm_Setting.__ENCList.Count - num);
						Frm_Setting.__ENCList.Capacity = Frm_Setting.__ENCList.Count;
					}
					Frm_Setting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x00089C74 File Offset: 0x00087E74
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0000409F File Offset: 0x0000229F
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

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x00089C8C File Offset: 0x00087E8C
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x000040A9 File Offset: 0x000022A9
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

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00089CA4 File Offset: 0x00087EA4
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x000040B3 File Offset: 0x000022B3
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

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x00089CBC File Offset: 0x00087EBC
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x00089CD4 File Offset: 0x00087ED4
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
				EventHandler value2 = new EventHandler(this.EditBox1_ButtonClick);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.ButtonClick -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00089D34 File Offset: 0x00087F34
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000040BD File Offset: 0x000022BD
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

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x00089D4C File Offset: 0x00087F4C
		// (set) Token: 0x06000A7E RID: 2686 RVA: 0x000040C7 File Offset: 0x000022C7
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

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A7F RID: 2687 RVA: 0x00089D64 File Offset: 0x00087F64
		// (set) Token: 0x06000A80 RID: 2688 RVA: 0x000040D1 File Offset: 0x000022D1
		internal virtual UIGroupBox UiGroupBox3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox3 = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A81 RID: 2689 RVA: 0x00089D7C File Offset: 0x00087F7C
		// (set) Token: 0x06000A82 RID: 2690 RVA: 0x000040DB File Offset: 0x000022DB
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

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x00089D94 File Offset: 0x00087F94
		// (set) Token: 0x06000A84 RID: 2692 RVA: 0x00089DAC File Offset: 0x00087FAC
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

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x00089E0C File Offset: 0x0008800C
		// (set) Token: 0x06000A86 RID: 2694 RVA: 0x000040E5 File Offset: 0x000022E5
		internal virtual NumericBox txt_sarresid_pardakht
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sarresid_pardakht;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sarresid_pardakht = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x00089E24 File Offset: 0x00088024
		// (set) Token: 0x06000A88 RID: 2696 RVA: 0x000040EF File Offset: 0x000022EF
		internal virtual NumericBox txt_sarresid_daryaft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sarresid_daryaft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sarresid_daryaft = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x00089E3C File Offset: 0x0008803C
		// (set) Token: 0x06000A8A RID: 2698 RVA: 0x000040F9 File Offset: 0x000022F9
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

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000A8B RID: 2699 RVA: 0x00089E54 File Offset: 0x00088054
		// (set) Token: 0x06000A8C RID: 2700 RVA: 0x00004103 File Offset: 0x00002303
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

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x00089E6C File Offset: 0x0008806C
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0000410D File Offset: 0x0000230D
		internal virtual DateBox2 DateBox21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateBox21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DateBox21 = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x00089E84 File Offset: 0x00088084
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x00004117 File Offset: 0x00002317
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

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x00089E9C File Offset: 0x0008809C
		// (set) Token: 0x06000A92 RID: 2706 RVA: 0x00004121 File Offset: 0x00002321
		internal virtual UIGroupBox UiGroupBox5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox5 = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000A93 RID: 2707 RVA: 0x00089EB4 File Offset: 0x000880B4
		// (set) Token: 0x06000A94 RID: 2708 RVA: 0x00089ECC File Offset: 0x000880CC
		internal virtual EditBox txt_font
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_font;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_ButtonClick);
				bool flag = this._txt_font != null;
				if (flag)
				{
					this._txt_font.ButtonClick -= value2;
				}
				this._txt_font = value;
				flag = (this._txt_font != null);
				if (flag)
				{
					this._txt_font.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00089F2C File Offset: 0x0008812C
		// (set) Token: 0x06000A96 RID: 2710 RVA: 0x0000412B File Offset: 0x0000232B
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

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00089F44 File Offset: 0x00088144
		// (set) Token: 0x06000A98 RID: 2712 RVA: 0x00004135 File Offset: 0x00002335
		internal virtual FontDialog FontDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._FontDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._FontDialog1 = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00089F5C File Offset: 0x0008815C
		// (set) Token: 0x06000A9A RID: 2714 RVA: 0x00089F74 File Offset: 0x00088174
		internal virtual EditBox txt_gridfont
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_gridfont;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_ButtonClick);
				bool flag = this._txt_gridfont != null;
				if (flag)
				{
					this._txt_gridfont.ButtonClick -= value2;
				}
				this._txt_gridfont = value;
				flag = (this._txt_gridfont != null);
				if (flag)
				{
					this._txt_gridfont.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00089FD4 File Offset: 0x000881D4
		// (set) Token: 0x06000A9C RID: 2716 RVA: 0x0000413F File Offset: 0x0000233F
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

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x00089FEC File Offset: 0x000881EC
		// (set) Token: 0x06000A9E RID: 2718 RVA: 0x00004149 File Offset: 0x00002349
		internal virtual UICheckBox UiCheckBox7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox7 = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0008A004 File Offset: 0x00088204
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00004153 File Offset: 0x00002353
		internal virtual UICheckBox UiCheckBox8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox8 = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0008A01C File Offset: 0x0008821C
		// (set) Token: 0x06000AA2 RID: 2722 RVA: 0x0000415D File Offset: 0x0000235D
		internal virtual UICheckBox UiCheckBox9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiCheckBox9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiCheckBox9 = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0008A034 File Offset: 0x00088234
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00004167 File Offset: 0x00002367
		internal virtual EditBox txt_salmali
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_salmali;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_salmali = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0008A04C File Offset: 0x0008824C
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00004171 File Offset: 0x00002371
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

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0008A064 File Offset: 0x00088264
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0000417B File Offset: 0x0000237B
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

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0008A07C File Offset: 0x0008827C
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00004185 File Offset: 0x00002385
		internal virtual UIComboBox txt_nahve_furush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_nahve_furush;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_nahve_furush = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0008A094 File Offset: 0x00088294
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0008A0AC File Offset: 0x000882AC
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

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0008A10C File Offset: 0x0008830C
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000418F File Offset: 0x0000238F
		internal virtual UICheckBox txt_show_avg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_show_avg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_show_avg = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0008A124 File Offset: 0x00088324
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x00004199 File Offset: 0x00002399
		internal virtual UICheckBox txt_kargari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kargari = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0008A13C File Offset: 0x0008833C
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0008A154 File Offset: 0x00088354
		internal virtual EditBox txt_print_font_number
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_print_font_number;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.EditBox2_ButtonClick);
				bool flag = this._txt_print_font_number != null;
				if (flag)
				{
					this._txt_print_font_number.ButtonClick -= value2;
				}
				this._txt_print_font_number = value;
				flag = (this._txt_print_font_number != null);
				if (flag)
				{
					this._txt_print_font_number.ButtonClick += value2;
				}
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0008A1B4 File Offset: 0x000883B4
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x000041A3 File Offset: 0x000023A3
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

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0008A1CC File Offset: 0x000883CC
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x000041AD File Offset: 0x000023AD
		internal virtual UICheckBox txt_no_bed_alert
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_no_bed_alert;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_no_bed_alert = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0008A1E4 File Offset: 0x000883E4
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0008A1FC File Offset: 0x000883FC
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

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0008A25C File Offset: 0x0008845C
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x0008A274 File Offset: 0x00088474
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

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0008A2D4 File Offset: 0x000884D4
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x000041B7 File Offset: 0x000023B7
		internal virtual UICheckBox txt_tasvie
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tasvie;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tasvie = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0008A2EC File Offset: 0x000884EC
		// (set) Token: 0x06000ABE RID: 2750 RVA: 0x000041C1 File Offset: 0x000023C1
		internal virtual Label Label30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label30 = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x0008A304 File Offset: 0x00088504
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x000041CB File Offset: 0x000023CB
		internal virtual SelectItem txt_bank_hesab
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_bank_hesab;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_bank_hesab = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x0008A31C File Offset: 0x0008851C
		// (set) Token: 0x06000AC2 RID: 2754 RVA: 0x000041D5 File Offset: 0x000023D5
		internal virtual UIComboBox txt_kharid_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kharid_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kharid_kind = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0008A334 File Offset: 0x00088534
		// (set) Token: 0x06000AC4 RID: 2756 RVA: 0x000041DF File Offset: 0x000023DF
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

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0008A34C File Offset: 0x0008854C
		// (set) Token: 0x06000AC6 RID: 2758 RVA: 0x000041E9 File Offset: 0x000023E9
		internal virtual UIGroupBox UiGroupBox4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox4 = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0008A364 File Offset: 0x00088564
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x000041F3 File Offset: 0x000023F3
		internal virtual UIComboBox txt_kargari_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kargari_kind = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0008A37C File Offset: 0x0008857C
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x000041FD File Offset: 0x000023FD
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

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0008A394 File Offset: 0x00088594
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x00004207 File Offset: 0x00002407
		internal virtual CurrencyBox txt_kargari_fee
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kargari_fee;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kargari_fee = value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0008A3AC File Offset: 0x000885AC
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x00004211 File Offset: 0x00002411
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0008A3C4 File Offset: 0x000885C4
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0000421B File Offset: 0x0000241B
		internal virtual UIComboBox txt_arz_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_arz_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_arz_kind = value;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0008A3DC File Offset: 0x000885DC
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x00004225 File Offset: 0x00002425
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

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0008A3F4 File Offset: 0x000885F4
		// (set) Token: 0x06000AD4 RID: 2772 RVA: 0x0000422F File Offset: 0x0000242F
		internal virtual UICheckBox txt_oft
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_oft;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_oft = value;
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0008A40C File Offset: 0x0008860C
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00004239 File Offset: 0x00002439
		internal virtual UIComboBox txt_sarbarg
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sarbarg;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sarbarg = value;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0008A424 File Offset: 0x00088624
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00004243 File Offset: 0x00002443
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0008A43C File Offset: 0x0008863C
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0008A454 File Offset: 0x00088654
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

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0008A4B4 File Offset: 0x000886B4
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x0000424D File Offset: 0x0000244D
		internal virtual UIGroupBox UiGroupBox6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiGroupBox6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiGroupBox6 = value;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x0008A4CC File Offset: 0x000886CC
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00004257 File Offset: 0x00002457
		internal virtual UIComboBox txt_oft_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_oft_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_oft_kind = value;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0008A4E4 File Offset: 0x000886E4
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x00004261 File Offset: 0x00002461
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

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0008A4FC File Offset: 0x000886FC
		private void LoadData()
		{
			bool flag = Public_Function.dict.ContainsKey("vagozari_bankhesab");
			if (flag)
			{
				string name = Conversions.ToString(Public_Function.ExecuteScalar("SELECT     Bank.Name+' '+ Bank_Hesab.Shobe +' - '+ Bank_Hesab.SahebHesab  FROM Bank_Hesab INNER JOIN Bank ON Bank_Hesab.Bank_ID = Bank.ID where bank_hesab.id=" + Public_Function.dict["vagozari_bankhesab"]));
				this.txt_bank_hesab.SetValue(name, Public_Function.dict["vagozari_bankhesab"]);
			}
			flag = Public_Function.dict.ContainsKey("backuponexit");
			bool flag2;
			if (flag)
			{
				flag2 = Conversions.ToBoolean(Public_Function.dict["backuponexit"]);
				if (flag2)
				{
					this.UiCheckBox1.Checked = true;
				}
				else
				{
					this.UiCheckBox1.Checked = false;
				}
			}
			else
			{
				this.UiCheckBox1.Checked = false;
			}
			flag2 = Public_Function.dict.ContainsKey("today");
			if (flag2)
			{
				this.DateBox21.Text = Public_Function.dict["today"];
			}
			flag2 = Public_Function.dict.ContainsKey("kargari");
			if (flag2)
			{
				this.txt_kargari.Checked = Conversions.ToBoolean(Public_Function.dict["kargari"]);
			}
			flag2 = Public_Function.dict.ContainsKey("kargari_kind");
			if (flag2)
			{
				this.txt_kargari_kind.SelectedValue = Public_Function.dict["kargari_kind"];
			}
			flag2 = Public_Function.dict.ContainsKey("kargari_fee");
			if (flag2)
			{
				this.txt_kargari_fee.Text = Public_Function.dict["kargari_fee"];
			}
			flag2 = Public_Function.dict.ContainsKey("show_avg");
			if (flag2)
			{
				this.txt_show_avg.Checked = Conversions.ToBoolean(Public_Function.dict["show_avg"]);
			}
			flag2 = Public_Function.dict.ContainsKey("no_bed_alert");
			if (flag2)
			{
				this.txt_no_bed_alert.Checked = Conversions.ToBoolean(Public_Function.dict["no_bed_alert"]);
			}
			flag2 = Public_Function.dict.ContainsKey("salmali");
			if (flag2)
			{
				this.txt_salmali.Text = Public_Function.dict["salmali"];
			}
			flag2 = Public_Function.dict.ContainsKey("arz_kind");
			if (flag2)
			{
				this.txt_arz_kind.SelectedValue = Public_Function.dict["arz_kind"];
			}
			flag2 = Public_Function.dict.ContainsKey("backuppath");
			if (flag2)
			{
				this.EditBox1.Text = Public_Function.dict["backuppath"].ToString();
			}
			else
			{
				this.EditBox1.Text = string.Empty;
			}
			flag2 = Public_Function.dict.ContainsKey("nahve_furush");
			if (flag2)
			{
				this.txt_nahve_furush.SelectedValue = Public_Function.dict["nahve_furush"];
			}
			flag2 = Conversions.ToBoolean(Public_Function.dict["surathesab_tasvie"]);
			if (flag2)
			{
				this.txt_tasvie.Checked = true;
			}
			else
			{
				this.txt_tasvie.Checked = false;
			}
			flag2 = Conversions.ToBoolean(Public_Function.dict["autotakhlie"]);
			if (flag2)
			{
				this.UiCheckBox8.Checked = true;
			}
			else
			{
				this.UiCheckBox8.Checked = false;
			}
			flag2 = Conversions.ToBoolean(Public_Function.dict["autosurat"]);
			if (flag2)
			{
				this.UiCheckBox9.Checked = true;
			}
			else
			{
				this.UiCheckBox9.Checked = false;
			}
			flag2 = Conversions.ToBoolean(Public_Function.dict["showavaldore"]);
			if (flag2)
			{
				this.UiCheckBox7.Checked = true;
			}
			else
			{
				this.UiCheckBox7.Checked = false;
			}
			flag2 = (Conversions.ToDouble(Public_Function.dict["kharid_kind"]) == 1.0);
			if (flag2)
			{
				this.txt_kharid_kind.SelectedIndex = 0;
			}
			else
			{
				this.txt_kharid_kind.SelectedIndex = 1;
			}
			flag2 = Conversions.ToBoolean(Public_Function.dict["oft"]);
			if (flag2)
			{
				this.txt_oft.Checked = true;
			}
			else
			{
				this.txt_oft.Checked = false;
			}
			flag2 = Public_Function.dict.ContainsKey("oft_kind");
			if (flag2)
			{
				this.txt_oft_kind.SelectedValue = Public_Function.dict["oft_kind"];
			}
			this.txt_font.Text = Public_Function.dict["textfont"];
			this.txt_print_font_number.Text = Public_Function.dict["printfont_number"];
			this.txt_gridfont.Text = Public_Function.dict["gridfont"];
			this.txt_sarresid_daryaft.Text = Public_Function.dict["sarresid_d"];
			this.txt_sarresid_pardakht.Text = Public_Function.dict["sarresid_p"];
			flag2 = Public_Function.dict.ContainsKey("eval");
			if (flag2)
			{
				flag = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag)
				{
					this.DateBox21.Visible = false;
					this.Label1.Visible = false;
				}
			}
			DataTable dataSource = Public_Function.FillData("select -1 as id,value as name from setting where [key]='owner' union all select id,name from sarbarg");
			this.txt_sarbarg.DataSource = dataSource;
			this.txt_sarbarg.DisplayMember = "name";
			this.txt_sarbarg.ValueMember = "id";
			this.txt_sarbarg.SelectedIndex = 0;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0008AA4C File Offset: 0x00088C4C
		private void Save()
		{
			setting setting = new setting();
			Public_Function.dict["today"] = this.DateBox21.Text;
			Public_Function.dict["backuppath"] = this.EditBox1.Text;
			Public_Function.dict["backuponexit"] = Conversions.ToString(this.UiCheckBox1.Checked);
			setting.Update("backuponexit", Conversions.ToString(this.UiCheckBox1.Checked));
			setting.Update("sarresid_d", this.txt_sarresid_daryaft.Text);
			setting.Update("sarresid_p", this.txt_sarresid_pardakht.Text);
			setting.Update("showavaldore", Conversions.ToString(this.UiCheckBox7.Checked));
			setting.Update("autotakhlie", Conversions.ToString(this.UiCheckBox8.Checked));
			setting.Update("autosurat", Conversions.ToString(this.UiCheckBox9.Checked));
			setting.Update("show_avg", Conversions.ToString(this.txt_show_avg.Checked));
			setting.Update("kargari", Conversions.ToString(this.txt_kargari.Checked));
			setting.Update("surathesab_tasvie", Conversions.ToString(this.txt_tasvie.Checked));
			setting.Update("arz_kind", Conversions.ToString(this.txt_arz_kind.SelectedValue));
			setting.Update("no_bed_alert", Conversions.ToString(this.txt_no_bed_alert.Checked));
			Public_Function.dict["show_avg"] = Conversions.ToString(this.txt_show_avg.Checked);
			Public_Function.dict["arz_kind"] = Conversions.ToString(this.txt_arz_kind.SelectedValue);
			Public_Function.dict["sarresid_d"] = this.txt_sarresid_daryaft.Text;
			Public_Function.dict["sarresid_p"] = this.txt_sarresid_pardakht.Text;
			Public_Function.dict["textfont"] = this.txt_font.Text;
			Public_Function.dict["printfont_number"] = this.txt_print_font_number.Text;
			Public_Function.dict["gridfont"] = this.txt_gridfont.Text;
			Public_Function.dict["showavaldore"] = Conversions.ToString(this.UiCheckBox7.Checked);
			Public_Function.dict["autotakhlie"] = Conversions.ToString(this.UiCheckBox8.Checked);
			Public_Function.dict["autosurat"] = Conversions.ToString(this.UiCheckBox9.Checked);
			Public_Function.dict["kargari"] = Conversions.ToString(this.txt_kargari.Checked);
			Public_Function.dict["no_bed_alert"] = Conversions.ToString(this.txt_no_bed_alert.Checked);
			Public_Function.dict["salmali"] = this.txt_salmali.Text;
			Public_Function.dict["surathesab_tasvie"] = Conversions.ToString(this.txt_tasvie.Checked);
			Public_Function.dict["kharid_kind"] = Conversions.ToString(this.txt_kharid_kind.SelectedValue);
			Public_Function.dict["oft"] = Conversions.ToString(this.txt_oft.Checked);
			Public_Function.dict["oft_kind"] = Conversions.ToString(this.txt_oft_kind.SelectedValue);
			Public_Function.dict["kargari_kind"] = Conversions.ToString(this.txt_kargari_kind.SelectedValue);
			Public_Function.dict["kargari_fee"] = Conversions.ToString((T)this.txt_kargari_fee.Value);
			bool flag = Conversions.ToBoolean(Public_Function.dict["multiowner"]);
			if (flag)
			{
				Public_Function.dict["head1"] = this.txt_sarbarg.SelectedItem.Text;
			}
			setting.Update("kargari_fee", Conversions.ToString((T)this.txt_kargari_fee.Value));
			setting.Update("kargari_kind", Conversions.ToString(this.txt_kargari_kind.SelectedValue));
			setting.Update("kharid_kind", Conversions.ToString(this.txt_kharid_kind.SelectedValue));
			setting.Update("oft", Conversions.ToString(this.txt_oft.Checked));
			setting.Update("oft_kind", Conversions.ToString(this.txt_oft_kind.SelectedValue));
			setting.Update("textfont", this.txt_font.Text);
			setting.Update("gridfont", this.txt_gridfont.Text);
			setting.Update("nahve_furush", Conversions.ToString(this.txt_nahve_furush.SelectedValue));
			flag = (Operators.CompareString(this.txt_print_font_number.Text, string.Empty, false) != 0);
			if (flag)
			{
				setting.Update("printfont_number", this.txt_print_font_number.Text);
			}
			else
			{
				setting.Delete("printfont_number");
			}
			Public_Function.dict["nahve_furush"] = Conversions.ToString(this.txt_nahve_furush.SelectedValue);
			flag = (Operators.CompareString(this.EditBox1.Text, string.Empty, false) == 0);
			if (flag)
			{
				setting.Update("backuppath", " ");
			}
			else
			{
				setting.Update("backuppath", this.EditBox1.Text);
			}
			flag = (this.txt_bank_hesab.Value != null);
			if (flag)
			{
				Public_Function.dict["vagozari_bankhesab"] = Conversions.ToString(this.txt_bank_hesab.Value);
				setting.Update("vagozari_bankhesab", Conversions.ToString(this.txt_bank_hesab.Value));
			}
			else
			{
				Public_Function.dict.Remove("vagozari_bankhesab");
				setting.Delete("vagozari_bankhesab");
			}
			setting.Update("salmali", this.txt_salmali.Text);
			Public_Function.ConfirmInsert();
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0008B07C File Offset: 0x0008927C
		private void Frm_Setting_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.Control && e.Shift && e.KeyCode == Keys.X;
			if (flag)
			{
				Frm_Extra_Setting frm_Extra_Setting = new Frm_Extra_Setting();
				frm_Extra_Setting.ShowDialog();
			}
			flag = (e.KeyCode == Keys.Escape);
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F2);
			if (flag)
			{
				this.Save();
			}
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0008B0E8 File Offset: 0x000892E8
		private void Frm_Setting_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
			}
			this.LoadData();
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0008B114 File Offset: 0x00089314
		private void EditBox1_ButtonClick(object sender, EventArgs e)
		{
			bool flag = this.FolderBrowserDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.EditBox1.Text = this.FolderBrowserDialog1.SelectedPath;
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000426B File Offset: 0x0000246B
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.Save();
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0008B150 File Offset: 0x00089350
		private void EditBox2_ButtonClick(object sender, EventArgs e)
		{
			bool flag = this.FontDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				((EditBox)sender).Text = string.Concat(new string[]
				{
					this.FontDialog1.Font.Name,
					";",
					Conversions.ToString(this.FontDialog1.Font.Size),
					";",
					this.FontDialog1.Font.Style.ToString()
				});
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0008B1E8 File Offset: 0x000893E8
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			Frm_Sms_Setting frm_Sms_Setting = new Frm_Sms_Setting();
			frm_Sms_Setting.ShowDialog();
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0008B204 File Offset: 0x00089404
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_Amniat_Setting frm_Amniat_Setting = new Frm_Amniat_Setting();
			frm_Amniat_Setting.ShowDialog();
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0008B220 File Offset: 0x00089420
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			Frm_Extra_Setting showFrm = new Frm_Extra_Setting();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0008B248 File Offset: 0x00089448
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			Frm_Factor_Setting showFrm = new Frm_Factor_Setting();
			MyProject.Forms.Form_Main.Dialog_ShowForm(showFrm);
		}

		// Token: 0x04000419 RID: 1049
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400041B RID: 1051
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400041C RID: 1052
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x0400041D RID: 1053
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400041E RID: 1054
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x0400041F RID: 1055
		[AccessedThroughProperty("FolderBrowserDialog1")]
		private FolderBrowserDialog _FolderBrowserDialog1;

		// Token: 0x04000420 RID: 1056
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000421 RID: 1057
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x04000422 RID: 1058
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000423 RID: 1059
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000424 RID: 1060
		[AccessedThroughProperty("txt_sarresid_pardakht")]
		private NumericBox _txt_sarresid_pardakht;

		// Token: 0x04000425 RID: 1061
		[AccessedThroughProperty("txt_sarresid_daryaft")]
		private NumericBox _txt_sarresid_daryaft;

		// Token: 0x04000426 RID: 1062
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000427 RID: 1063
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000428 RID: 1064
		[AccessedThroughProperty("DateBox21")]
		private DateBox2 _DateBox21;

		// Token: 0x04000429 RID: 1065
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x0400042A RID: 1066
		[AccessedThroughProperty("UiGroupBox5")]
		private UIGroupBox _UiGroupBox5;

		// Token: 0x0400042B RID: 1067
		[AccessedThroughProperty("txt_font")]
		private EditBox _txt_font;

		// Token: 0x0400042C RID: 1068
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x0400042D RID: 1069
		[AccessedThroughProperty("FontDialog1")]
		private FontDialog _FontDialog1;

		// Token: 0x0400042E RID: 1070
		[AccessedThroughProperty("txt_gridfont")]
		private EditBox _txt_gridfont;

		// Token: 0x0400042F RID: 1071
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000430 RID: 1072
		[AccessedThroughProperty("UiCheckBox7")]
		private UICheckBox _UiCheckBox7;

		// Token: 0x04000431 RID: 1073
		[AccessedThroughProperty("UiCheckBox8")]
		private UICheckBox _UiCheckBox8;

		// Token: 0x04000432 RID: 1074
		[AccessedThroughProperty("UiCheckBox9")]
		private UICheckBox _UiCheckBox9;

		// Token: 0x04000433 RID: 1075
		[AccessedThroughProperty("txt_salmali")]
		private EditBox _txt_salmali;

		// Token: 0x04000434 RID: 1076
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000435 RID: 1077
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000436 RID: 1078
		[AccessedThroughProperty("txt_nahve_furush")]
		private UIComboBox _txt_nahve_furush;

		// Token: 0x04000437 RID: 1079
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000438 RID: 1080
		[AccessedThroughProperty("txt_show_avg")]
		private UICheckBox _txt_show_avg;

		// Token: 0x04000439 RID: 1081
		[AccessedThroughProperty("txt_kargari")]
		private UICheckBox _txt_kargari;

		// Token: 0x0400043A RID: 1082
		[AccessedThroughProperty("txt_print_font_number")]
		private EditBox _txt_print_font_number;

		// Token: 0x0400043B RID: 1083
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400043C RID: 1084
		[AccessedThroughProperty("txt_no_bed_alert")]
		private UICheckBox _txt_no_bed_alert;

		// Token: 0x0400043D RID: 1085
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400043E RID: 1086
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x0400043F RID: 1087
		[AccessedThroughProperty("txt_tasvie")]
		private UICheckBox _txt_tasvie;

		// Token: 0x04000440 RID: 1088
		[AccessedThroughProperty("Label30")]
		private Label _Label30;

		// Token: 0x04000441 RID: 1089
		[AccessedThroughProperty("txt_bank_hesab")]
		private SelectItem _txt_bank_hesab;

		// Token: 0x04000442 RID: 1090
		[AccessedThroughProperty("txt_kharid_kind")]
		private UIComboBox _txt_kharid_kind;

		// Token: 0x04000443 RID: 1091
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000444 RID: 1092
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x04000445 RID: 1093
		[AccessedThroughProperty("txt_kargari_kind")]
		private UIComboBox _txt_kargari_kind;

		// Token: 0x04000446 RID: 1094
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000447 RID: 1095
		[AccessedThroughProperty("txt_kargari_fee")]
		private CurrencyBox _txt_kargari_fee;

		// Token: 0x04000448 RID: 1096
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000449 RID: 1097
		[AccessedThroughProperty("txt_arz_kind")]
		private UIComboBox _txt_arz_kind;

		// Token: 0x0400044A RID: 1098
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x0400044B RID: 1099
		[AccessedThroughProperty("txt_oft")]
		private UICheckBox _txt_oft;

		// Token: 0x0400044C RID: 1100
		[AccessedThroughProperty("txt_sarbarg")]
		private UIComboBox _txt_sarbarg;

		// Token: 0x0400044D RID: 1101
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x0400044E RID: 1102
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x0400044F RID: 1103
		[AccessedThroughProperty("UiGroupBox6")]
		private UIGroupBox _UiGroupBox6;

		// Token: 0x04000450 RID: 1104
		[AccessedThroughProperty("txt_oft_kind")]
		private UIComboBox _txt_oft_kind;

		// Token: 0x04000451 RID: 1105
		[AccessedThroughProperty("Label15")]
		private Label _Label15;
	}
}
