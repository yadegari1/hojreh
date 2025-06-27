using System;
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
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Janus.Windows.UI.Tab;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000D1 RID: 209
	[DesignerGenerated]
	public partial class Frm_Moshtari : Form
	{
		// Token: 0x060011C9 RID: 4553 RVA: 0x000C06D0 File Offset: 0x000BE8D0
		public Frm_Moshtari()
		{
			base.Activated += new EventHandler(this.Frm_Moshtari_Activated);
			base.Load += new EventHandler(this.Frm_Moshtari_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Moshtari_KeyDown);
			Frm_Moshtari.__ENCAddToList(this);
			this.isnew = true;
			this.CodeHesab = new Code_Hesab();
			this.Moshtari = new Moshtari();
			this.Moshtari_Pic = new Moshtari_Pic();
			this.Sanad = new Sanad();
			this.Hesab = new Moshtari_Hesab();
			bool autoClose = false;
			this.AutoClose = autoClose;
			this.InitializeComponent();
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000C0778 File Offset: 0x000BE978
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Moshtari.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Moshtari.__ENCList.Count == Frm_Moshtari.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Moshtari.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Moshtari.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Moshtari.__ENCList[num] = Frm_Moshtari.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Moshtari.__ENCList.RemoveRange(num, Frm_Moshtari.__ENCList.Count - num);
						Frm_Moshtari.__ENCList.Capacity = Frm_Moshtari.__ENCList.Count;
					}
					Frm_Moshtari.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x000C4E74 File Offset: 0x000C3074
		// (set) Token: 0x060011CE RID: 4558 RVA: 0x00005DF8 File Offset: 0x00003FF8
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x000C4E8C File Offset: 0x000C308C
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x00005E02 File Offset: 0x00004002
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x000C4EA4 File Offset: 0x000C30A4
		// (set) Token: 0x060011D2 RID: 4562 RVA: 0x00005E0C File Offset: 0x0000400C
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x000C4EBC File Offset: 0x000C30BC
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x00005E16 File Offset: 0x00004016
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x000C4ED4 File Offset: 0x000C30D4
		// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00005E20 File Offset: 0x00004020
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x000C4EEC File Offset: 0x000C30EC
		// (set) Token: 0x060011D8 RID: 4568 RVA: 0x00005E2A File Offset: 0x0000402A
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x000C4F04 File Offset: 0x000C3104
		// (set) Token: 0x060011DA RID: 4570 RVA: 0x00005E34 File Offset: 0x00004034
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x000C4F1C File Offset: 0x000C311C
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x00005E3E File Offset: 0x0000403E
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x000C4F34 File Offset: 0x000C3134
		// (set) Token: 0x060011DE RID: 4574 RVA: 0x00005E48 File Offset: 0x00004048
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x000C4F4C File Offset: 0x000C314C
		// (set) Token: 0x060011E0 RID: 4576 RVA: 0x00005E52 File Offset: 0x00004052
		internal virtual EditBox txt_name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_name;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_name = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x000C4F64 File Offset: 0x000C3164
		// (set) Token: 0x060011E2 RID: 4578 RVA: 0x00005E5C File Offset: 0x0000405C
		internal virtual EditBox txt_family
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_family;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_family = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x000C4F7C File Offset: 0x000C317C
		// (set) Token: 0x060011E4 RID: 4580 RVA: 0x00005E66 File Offset: 0x00004066
		internal virtual NumericBox txt_codemelli
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codemelli;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codemelli = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x000C4F94 File Offset: 0x000C3194
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00005E70 File Offset: 0x00004070
		internal virtual NumericBox txt_shsh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_shsh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_shsh = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x000C4FAC File Offset: 0x000C31AC
		// (set) Token: 0x060011E8 RID: 4584 RVA: 0x00005E7A File Offset: 0x0000407A
		internal virtual EditBox txt_tel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel1 = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x000C4FC4 File Offset: 0x000C31C4
		// (set) Token: 0x060011EA RID: 4586 RVA: 0x00005E84 File Offset: 0x00004084
		internal virtual EditBox txt_tel2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel2 = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x000C4FDC File Offset: 0x000C31DC
		// (set) Token: 0x060011EC RID: 4588 RVA: 0x00005E8E File Offset: 0x0000408E
		internal virtual EditBox txt_fax
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_fax;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_fax = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x000C4FF4 File Offset: 0x000C31F4
		// (set) Token: 0x060011EE RID: 4590 RVA: 0x00005E98 File Offset: 0x00004098
		internal virtual EditBox txt_address
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_address;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_address = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x000C500C File Offset: 0x000C320C
		// (set) Token: 0x060011F0 RID: 4592 RVA: 0x00005EA2 File Offset: 0x000040A2
		internal virtual NumericBox txt_codeegtesadi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codeegtesadi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codeegtesadi = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x000C5024 File Offset: 0x000C3224
		// (set) Token: 0x060011F2 RID: 4594 RVA: 0x00005EAC File Offset: 0x000040AC
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x000C503C File Offset: 0x000C323C
		// (set) Token: 0x060011F4 RID: 4596 RVA: 0x00005EB6 File Offset: 0x000040B6
		internal virtual UITab UiTab1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiTab1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiTab1 = value;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x000C5054 File Offset: 0x000C3254
		// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00005EC0 File Offset: 0x000040C0
		internal virtual UITabPage UiTabPage2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiTabPage2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiTabPage2 = value;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x000C506C File Offset: 0x000C326C
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00005ECA File Offset: 0x000040CA
		internal virtual UITabPage UiTabPage1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiTabPage1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiTabPage1 = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x000C5084 File Offset: 0x000C3284
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00005ED4 File Offset: 0x000040D4
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x000C509C File Offset: 0x000C329C
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00005EDE File Offset: 0x000040DE
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x000C50B4 File Offset: 0x000C32B4
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x00005EE8 File Offset: 0x000040E8
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x000C50CC File Offset: 0x000C32CC
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x000C50E4 File Offset: 0x000C32E4
		internal virtual UIButton UiButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton4_Click);
				bool flag = this._UiButton4 != null;
				if (flag)
				{
					this._UiButton4.Click -= value2;
				}
				this._UiButton4 = value;
				flag = (this._UiButton4 != null);
				if (flag)
				{
					this._UiButton4.Click += value2;
				}
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x000C5144 File Offset: 0x000C3344
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x000C515C File Offset: 0x000C335C
		internal virtual UIButton UiButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton3_Click);
				bool flag = this._UiButton3 != null;
				if (flag)
				{
					this._UiButton3.Click -= value2;
				}
				this._UiButton3 = value;
				flag = (this._UiButton3 != null);
				if (flag)
				{
					this._UiButton3.Click += value2;
				}
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x000C51BC File Offset: 0x000C33BC
		// (set) Token: 0x06001204 RID: 4612 RVA: 0x00005EF2 File Offset: 0x000040F2
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001205 RID: 4613 RVA: 0x000C51D4 File Offset: 0x000C33D4
		// (set) Token: 0x06001206 RID: 4614 RVA: 0x00005EFC File Offset: 0x000040FC
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x000C51EC File Offset: 0x000C33EC
		// (set) Token: 0x06001208 RID: 4616 RVA: 0x00005F06 File Offset: 0x00004106
		internal virtual CurrencyBox txt_mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_mablagh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_mablagh = value;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x000C5204 File Offset: 0x000C3404
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00005F10 File Offset: 0x00004110
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x000C521C File Offset: 0x000C341C
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00005F1A File Offset: 0x0000411A
		internal virtual DateBox2 txt_tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tarikh = value;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x000C5234 File Offset: 0x000C3434
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x000C524C File Offset: 0x000C344C
		internal virtual ComboBox cmb_avaldore
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmb_avaldore;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.cmb_avaldore_SelectedValueChanged);
				bool flag = this._cmb_avaldore != null;
				if (flag)
				{
					this._cmb_avaldore.SelectedValueChanged -= value2;
				}
				this._cmb_avaldore = value;
				flag = (this._cmb_avaldore != null);
				if (flag)
				{
					this._cmb_avaldore.SelectedValueChanged += value2;
				}
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x000C52AC File Offset: 0x000C34AC
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x00005F24 File Offset: 0x00004124
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x000C52C4 File Offset: 0x000C34C4
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x00005F2E File Offset: 0x0000412E
		internal virtual EditBox txt_Moaref
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_Moaref;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_Moaref = value;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x000C52DC File Offset: 0x000C34DC
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x000C52F4 File Offset: 0x000C34F4
		internal virtual UIButton UiButton6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton6_Click);
				bool flag = this._UiButton6 != null;
				if (flag)
				{
					this._UiButton6.Click -= value2;
				}
				this._UiButton6 = value;
				flag = (this._UiButton6 != null);
				if (flag)
				{
					this._UiButton6.Click += value2;
				}
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x000C5354 File Offset: 0x000C3554
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x000C536C File Offset: 0x000C356C
		internal virtual UIButton UiButton7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton7_Click);
				bool flag = this._UiButton7 != null;
				if (flag)
				{
					this._UiButton7.Click -= value2;
				}
				this._UiButton7 = value;
				flag = (this._UiButton7 != null);
				if (flag)
				{
					this._UiButton7.Click += value2;
				}
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x000C53CC File Offset: 0x000C35CC
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x00005F38 File Offset: 0x00004138
		internal virtual PictureBox PictureBox2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PictureBox2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PictureBox2 = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x000C53E4 File Offset: 0x000C35E4
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x00005F42 File Offset: 0x00004142
		internal virtual OpenFileDialog OpenFileDialog1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog1 = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x000C53FC File Offset: 0x000C35FC
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x00005F4C File Offset: 0x0000414C
		internal virtual OpenFileDialog OpenFileDialog2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OpenFileDialog2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OpenFileDialog2 = value;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x000C5414 File Offset: 0x000C3614
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x00005F56 File Offset: 0x00004156
		internal virtual EditBox txt_address2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_address2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_address2 = value;
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x000C542C File Offset: 0x000C362C
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x00005F60 File Offset: 0x00004160
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06001221 RID: 4641 RVA: 0x000C5444 File Offset: 0x000C3644
		// (set) Token: 0x06001222 RID: 4642 RVA: 0x00005F6A File Offset: 0x0000416A
		internal virtual EditBox txt_codeposti
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_codeposti;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_codeposti = value;
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x000C545C File Offset: 0x000C365C
		// (set) Token: 0x06001224 RID: 4644 RVA: 0x00005F74 File Offset: 0x00004174
		internal virtual Label Label18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label18 = value;
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000C5474 File Offset: 0x000C3674
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x00005F7E File Offset: 0x0000417E
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06001227 RID: 4647 RVA: 0x000C548C File Offset: 0x000C368C
		// (set) Token: 0x06001228 RID: 4648 RVA: 0x00005F88 File Offset: 0x00004188
		internal virtual EditBox txt_tel4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel4 = value;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x000C54A4 File Offset: 0x000C36A4
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x00005F92 File Offset: 0x00004192
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x000C54BC File Offset: 0x000C36BC
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x00005F9C File Offset: 0x0000419C
		internal virtual EditBox txt_tel3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tel3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_tel3 = value;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x000C54D4 File Offset: 0x000C36D4
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x00005FA6 File Offset: 0x000041A6
		internal virtual SelectItem Txt_Grouh_Moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Txt_Grouh_Moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Txt_Grouh_Moshtari = value;
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x000C54EC File Offset: 0x000C36EC
		// (set) Token: 0x06001230 RID: 4656 RVA: 0x00005FB0 File Offset: 0x000041B0
		internal virtual Label Label19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label19 = value;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x000C5504 File Offset: 0x000C3704
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00005FBA File Offset: 0x000041BA
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x000C551C File Offset: 0x000C371C
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x000C5534 File Offset: 0x000C3734
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x000C5594 File Offset: 0x000C3794
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x000C55AC File Offset: 0x000C37AC
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x000C560C File Offset: 0x000C380C
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x000C5624 File Offset: 0x000C3824
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x000C5684 File Offset: 0x000C3884
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x000C569C File Offset: 0x000C389C
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000C56FC File Offset: 0x000C38FC
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00005FC4 File Offset: 0x000041C4
		internal virtual SelectItem txt_grouhmoshtari2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_grouhmoshtari2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_grouhmoshtari2 = value;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x000C5714 File Offset: 0x000C3914
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x00005FCE File Offset: 0x000041CE
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x000C572C File Offset: 0x000C392C
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00005FD8 File Offset: 0x000041D8
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x000C5744 File Offset: 0x000C3944
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00005FE2 File Offset: 0x000041E2
		internal virtual Label Label20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label20 = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x000C575C File Offset: 0x000C395C
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00005FEC File Offset: 0x000041EC
		internal virtual SelectItem txt_moshtari_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_moshtari_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_moshtari_kind = value;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x000C5774 File Offset: 0x000C3974
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x00005FF6 File Offset: 0x000041F6
		internal virtual Label Label21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label21 = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x000C578C File Offset: 0x000C398C
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x000C57A4 File Offset: 0x000C39A4
		internal virtual SelectItem moaref_kind
		{
			[DebuggerNonUserCode]
			get
			{
				return this._moaref_kind;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.moaref_kind_ButtonClick);
				bool flag = this._moaref_kind != null;
				if (flag)
				{
					this._moaref_kind.ButtonClick -= value2;
				}
				this._moaref_kind = value;
				flag = (this._moaref_kind != null);
				if (flag)
				{
					this._moaref_kind.ButtonClick += value2;
				}
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x000C5804 File Offset: 0x000C3A04
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00006000 File Offset: 0x00004200
		internal virtual Label Label22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label22 = value;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x000C581C File Offset: 0x000C3A1C
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x0000600A File Offset: 0x0000420A
		internal virtual NumericBox txt_karmozd
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_karmozd;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_karmozd = value;
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000C5834 File Offset: 0x000C3A34
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00006014 File Offset: 0x00004214
		internal virtual Label Label23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label23 = value;
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x000C584C File Offset: 0x000C3A4C
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x000C5864 File Offset: 0x000C3A64
		internal virtual NumericBox txt_code_moshtari
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_code_moshtari;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.txt_code_moshtari_Validating);
				KeyEventHandler value3 = new KeyEventHandler(this.txt_code_moshtari_KeyDown);
				bool flag = this._txt_code_moshtari != null;
				if (flag)
				{
					this._txt_code_moshtari.Validating -= value2;
					this._txt_code_moshtari.KeyDown -= value3;
				}
				this._txt_code_moshtari = value;
				flag = (this._txt_code_moshtari != null);
				if (flag)
				{
					this._txt_code_moshtari.Validating += value2;
					this._txt_code_moshtari.KeyDown += value3;
				}
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x000C58EC File Offset: 0x000C3AEC
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x0000601E File Offset: 0x0000421E
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x000C5904 File Offset: 0x000C3B04
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00006028 File Offset: 0x00004228
		internal virtual UIGroupBox group_contact_info
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_contact_info;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_contact_info = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x000C591C File Offset: 0x000C3B1C
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00006032 File Offset: 0x00004232
		internal virtual UIGroupBox group_mahale_faaliyat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group_mahale_faaliyat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group_mahale_faaliyat = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000C5934 File Offset: 0x000C3B34
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x0000603C File Offset: 0x0000423C
		internal virtual UIGroupBox group__albagi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._group__albagi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._group__albagi = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000C594C File Offset: 0x000C3B4C
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00006046 File Offset: 0x00004246
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000C5964 File Offset: 0x000C3B64
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x00006050 File Offset: 0x00004250
		public bool AutoClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AutoClose;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AutoClose = value;
			}
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0000605A File Offset: 0x0000425A
		public void newfrm()
		{
			this.UiButton5_Click(null, null);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x000C597C File Offset: 0x000C3B7C
		private void UiButton5_Click(object sender, EventArgs e)
		{
			Public_Function.SetNew(this.UiGroupBox1);
			this.lbl_code.Text = string.Empty;
			this.txt_code_moshtari.Visible = true;
			this.lbl_code.Visible = false;
			this.cmb_avaldore.SelectedValue = 0;
			this.OpenFileDialog1.FileName = string.Empty;
			this.OpenFileDialog2.FileName = string.Empty;
			this.PictureBox1.Image = null;
			this.PictureBox2.Image = null;
			this.Sanad_ID = null;
			int? iD;
			this.ID = iD;
			this.isnew = true;
			this.GetNewCode();
			bool flag = Public_Function.AppType == 1 | Public_Function.AppType == 3;
			if (flag)
			{
				this.txt_moshtari_kind.SetValue("آقا - خریدار", 1);
			}
			else
			{
				this.txt_moshtari_kind.SetValue("آقا - صاحب بار", 2);
			}
			this.txt_name.Focus();
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000C5A88 File Offset: 0x000C3C88
		private void UiButton1_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.HasNull(this.UiGroupBox1);
			checked
			{
				if (!flag)
				{
					flag = (Operators.CompareString(this.txt_family.Text.Trim(), string.Empty, false) == 0);
					if (flag)
					{
						this.txt_family.RaiseSoftError();
					}
					else
					{
						long value = 0L;
						long value2 = 0L;
						string grouhMoshtari_ID = string.Empty;
						string grouhMoshtari2_ID = string.Empty;
						flag = (this.Txt_Grouh_Moshtari.Value != null);
						if (flag)
						{
							grouhMoshtari_ID = Conversions.ToString(this.Txt_Grouh_Moshtari.Value);
						}
						flag = (this.txt_grouhmoshtari2.Value != null);
						if (flag)
						{
							grouhMoshtari2_ID = Conversions.ToString(this.txt_grouhmoshtari2.Value);
						}
						string tozih = " مانده از تاریخ " + this.txt_tarikh.Text;
						flag = Operators.ConditionalCompareObjectEqual(this.cmb_avaldore.SelectedValue, string.Empty, false);
						if (flag)
						{
							this.cmb_avaldore.SelectedValue = 0;
						}
						flag = Operators.ConditionalCompareObjectNotEqual(this.cmb_avaldore.SelectedValue, 0, false);
						bool flag2;
						if (flag)
						{
							flag2 = (Operators.CompareString(this.txt_mablagh.Text, string.Empty, false) == 0 || Operators.CompareString(this.txt_mablagh.Text, "0", false) == 0);
							if (flag2)
							{
								this.txt_mablagh.ShowTip("مبلغ اول دوره مشتری را وارد نمائید");
								return;
							}
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.cmb_avaldore.SelectedValue, 1, false);
						if (flag2)
						{
							value = (T)this.txt_mablagh.Value;
						}
						flag2 = Operators.ConditionalCompareObjectEqual(this.cmb_avaldore.SelectedValue, 2, false);
						if (flag2)
						{
							value2 = (T)this.txt_mablagh.Value;
						}
						flag2 = this.isnew;
						if (flag2)
						{
							int num = Conversions.ToInteger(Public_Function.ExecuteScalar("select count(id) from moshtari where name=" + Public_Function.GetValue(Strings.Trim(this.txt_name.Text)) + " and family=" + Public_Function.GetValue(Strings.Trim(this.txt_family.Text))));
							flag2 = (num > 0);
							if (flag2)
							{
								Public_Function.ShowMessage("مشتری مورد نظر قبلا ثبت شده است", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
								return;
							}
							this.CodeHesab_Moshtari = (int)this.CodeHesab.Insert(Code_Hesab.GrohHesab.مشتریان, this.txt_name.Text + " " + this.txt_family.Text);
							this.ID = (int)this.Moshtari.Insert(this.cmb_avaldore.SelectedValue.ToString(), this.txt_mablagh.Value.ToString(), "", Conversions.ToString((T)this.CodeHesab_Moshtari), grouhMoshtari_ID, grouhMoshtari2_ID, Strings.Trim(this.txt_name.Text), Strings.Trim(this.txt_family.Text), this.txt_shsh.Text, this.txt_codemelli.Text, this.txt_codeposti.Text, this.txt_tel1.Text, this.txt_tel2.Text, this.txt_tel3.Text, this.txt_tel4.Text, this.txt_address.Text, this.txt_address2.Text, this.txt_fax.Text, this.txt_codeegtesadi.Text, this.txt_Moaref.Text, this.txt_tarikh.Text, Conversions.ToString(this.txt_moshtari_kind.Value), Conversions.ToString(this.moaref_kind.Value), this.txt_karmozd.Text, this.txt_code_moshtari.Text);
							string arg_3DB_0 = "update moshtari set code=id where id=";
							int? iD = this.ID;
							Public_Function.ExecuteNonQuery(arg_3DB_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null));
							flag2 = (this.dt_hesab != null);
							if (flag2)
							{
								this.Hesab.Update(Conversions.ToString((T)this.ID), this.dt_hesab);
							}
							flag2 = Operators.ConditionalCompareObjectNotEqual(this.cmb_avaldore.SelectedValue, 0, false);
							if (flag2)
							{
								this.Sanad_ID = (int)this.Sanad.Insert(Conversions.ToString((T)this.CodeHesab_Moshtari), Conversions.ToString(value), Conversions.ToString(value2), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
								this.Moshtari.UpdateSanad_ID(Conversions.ToString((T)this.Sanad_ID), Conversions.ToString((T)this.ID));
							}
							flag2 = (this.PictureBox1.Image != null && Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0);
							byte[] picdata;
							if (flag2)
							{
								picdata = File.ReadAllBytes(this.OpenFileDialog1.FileName);
							}
							flag2 = (this.PictureBox2.Image != null && Operators.CompareString(this.OpenFileDialog2.FileName, string.Empty, false) != 0);
							byte[] signData;
							if (flag2)
							{
								signData = File.ReadAllBytes(this.OpenFileDialog2.FileName);
							}
							this.Moshtari_Pic.Insert(Conversions.ToString((T)this.ID), picdata, signData);
							Public_Function.ConfirmInsert();
							this.lbl_code.Text = Conversions.ToString((T)this.ID);
							this.isnew = false;
							flag2 = Conversions.ToBoolean(Public_Function.dict["moshtari_exit_on_save"]);
							if (flag2)
							{
								this.Close();
							}
							else
							{
								this.UiButton5_Click(null, null);
							}
						}
						else
						{
							flag2 = (Public_Function.ConfirmUpdate() == DialogResult.Yes);
							if (flag2)
							{
								this.CodeHesab.Update(this.txt_name.Text + " " + this.txt_family.Text, Conversions.ToString((T)this.CodeHesab_Moshtari));
								this.Moshtari.Update(this.cmb_avaldore.SelectedValue.ToString(), this.txt_mablagh.Value.ToString(), "", grouhMoshtari_ID, grouhMoshtari2_ID, Strings.Trim(this.txt_name.Text), Strings.Trim(this.txt_family.Text), this.txt_shsh.Text, this.txt_codemelli.Text, this.txt_codeposti.Text, this.txt_tel1.Text, this.txt_tel2.Text, this.txt_tel3.Text, this.txt_tel4.Text, this.txt_address.Text, this.txt_address2.Text, this.txt_fax.Text, this.txt_codeegtesadi.Text, this.txt_Moaref.Text, this.txt_tarikh.Text, Conversions.ToString(this.txt_moshtari_kind.Value), Conversions.ToString(this.moaref_kind.Value), this.txt_karmozd.Text, Conversions.ToString((T)this.ID));
								flag2 = (this.dt_hesab != null);
								if (flag2)
								{
									this.Hesab.Update(Conversions.ToString((T)this.ID), this.dt_hesab);
								}
								flag2 = Operators.ConditionalCompareObjectEqual(this.cmb_avaldore.SelectedValue, 0, false);
								if (flag2)
								{
									flag = this.Sanad_ID.HasValue;
									if (flag)
									{
										this.Sanad.Delete(Conversions.ToString((T)this.Sanad_ID));
										this.Sanad_ID = null;
									}
								}
								else
								{
									flag2 = this.Sanad_ID.HasValue;
									if (flag2)
									{
										this.Sanad.Update(Conversions.ToString((T)this.CodeHesab_Moshtari), Conversions.ToString(value), Conversions.ToString(value2), this.txt_tarikh.Text, tozih, Conversions.ToString((T)this.Sanad_ID), Sanad.SanadType.@null);
									}
									else
									{
										this.Sanad_ID = (int)this.Sanad.Insert(Conversions.ToString((T)this.CodeHesab_Moshtari), Conversions.ToString(value), Conversions.ToString(value2), this.txt_tarikh.Text, tozih, Sanad.SanadType.@null);
									}
									this.Moshtari.UpdateSanad_ID(Conversions.ToString((T)this.Sanad_ID), Conversions.ToString((T)this.ID));
								}
								flag2 = (this.PictureBox1.Image != null);
								byte[] array;
								if (flag2)
								{
									flag = (Operators.CompareString(this.OpenFileDialog1.FileName, string.Empty, false) != 0);
									if (flag)
									{
										array = File.ReadAllBytes(this.OpenFileDialog1.FileName);
									}
								}
								flag2 = (this.PictureBox2.Image != null && Operators.CompareString(this.OpenFileDialog2.FileName, string.Empty, false) != 0);
								byte[] array2;
								if (flag2)
								{
									array2 = File.ReadAllBytes(this.OpenFileDialog2.FileName);
								}
								string arg_930_0 = "Select Count(Moshtari_ID) from Moshtari_Pic where Moshtari_ID=";
								int? iD = this.ID;
								flag2 = Operators.ConditionalCompareObjectEqual(Public_Function.ExecuteScalar(arg_930_0 + (iD.HasValue ? Conversions.ToString(iD.GetValueOrDefault()) : null)), 0, false);
								if (flag2)
								{
									this.Moshtari_Pic.Insert(Conversions.ToString((T)this.ID), array, array2);
								}
								else
								{
									flag2 = (array != null);
									if (flag2)
									{
										this.Moshtari_Pic.UpdatePicData(array, Conversions.ToString((T)this.ID));
									}
									else
									{
										flag2 = (this.PictureBox1.Image == null);
										if (flag2)
										{
											this.Moshtari_Pic.UpdatePicData(null, Conversions.ToString((T)this.ID));
										}
									}
									flag2 = (array2 != null);
									if (flag2)
									{
										this.Moshtari_Pic.UpdateSignData(array2, Conversions.ToString((T)this.ID));
									}
									else
									{
										flag2 = (this.PictureBox2.Image == null);
										if (flag2)
										{
											this.Moshtari_Pic.UpdateSignData(null, Conversions.ToString((T)this.ID));
										}
									}
								}
								Public_Function.ConfirmInsert();
								this.DialogResult = DialogResult.OK;
								flag2 = Conversions.ToBoolean(Public_Function.dict["txt_moshtari_exit_on_save"]);
								if (flag2)
								{
									this.Close();
								}
								else
								{
									this.UiButton5_Click(null, null);
								}
							}
						}
						Public_Function.InvokeMethod("loadmoshtaridata");
					}
				}
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x000C6514 File Offset: 0x000C4714
		private void LoadDataRow(DataRow dr)
		{
			Public_Function.SetNew(this.UiGroupBox1);
			this.lbl_code.Text = dr["ID"].ToString();
			this.txt_name.Text = dr["Name"].ToString();
			this.txt_family.Text = dr["Family"].ToString();
			this.txt_codemelli.Text = dr["CodeMelli"].ToString();
			this.txt_codeposti.Text = dr["Codeposti"].ToString();
			this.txt_shsh.Text = dr["Shsh"].ToString();
			this.txt_codeegtesadi.Text = dr["CodeEgtesadi"].ToString();
			this.txt_address.Text = dr["Address"].ToString();
			this.txt_address2.Text = dr["Address2"].ToString();
			this.txt_tel1.Text = dr["Tel1"].ToString();
			this.txt_tel2.Text = dr["Tel2"].ToString();
			this.txt_tel3.Text = dr["Tel3"].ToString();
			this.txt_tel4.Text = dr["Tel4"].ToString();
			this.txt_fax.Text = dr["Fax"].ToString();
			bool flag = dr["karmozd"] != DBNull.Value;
			if (flag)
			{
				this.txt_karmozd.Text = Conversions.ToString(Public_Function.GetDecimalValue(Conversions.ToDecimal(dr["karmozd"].ToString())));
			}
			else
			{
				this.txt_karmozd.Text = string.Empty;
			}
			this.txt_Moaref.Text = dr["moaref"].ToString();
			this.cmb_avaldore.SelectedValue = dr["AvalDoreType"].ToString();
			object expr_232 = dr["CodeHesab_ID"];
			int? num;
			this.CodeHesab_Moshtari = ((expr_232 != null) ? ((int?)expr_232) : num);
			flag = (dr["grouhMoshtari_ID"] != DBNull.Value);
			if (flag)
			{
				this.Txt_Grouh_Moshtari.SetValue(Conversions.ToString(dr["GrouhMoshtari_Name"]), RuntimeHelpers.GetObjectValue(dr["grouhMoshtari_ID"]));
			}
			else
			{
				this.Txt_Grouh_Moshtari.SetNew();
			}
			flag = (dr["kind"] != DBNull.Value);
			if (flag)
			{
				this.txt_moshtari_kind.SetValue(Conversions.ToString(dr["moshtari_kind_name"]), RuntimeHelpers.GetObjectValue(dr["kind"]));
			}
			flag = (dr["moaref_kind"] != DBNull.Value);
			bool flag2;
			if (flag)
			{
				flag2 = Operators.ConditionalCompareObjectEqual(dr["moaref_kind"], 1, false);
				if (flag2)
				{
					this.moaref_kind.SetValue("دائم", 1);
				}
				else
				{
					this.moaref_kind.SetValue("موقت", 2);
				}
			}
			flag2 = (dr["grouhMoshtari2_ID"] != DBNull.Value);
			if (flag2)
			{
				this.txt_grouhmoshtari2.SetValue(Conversions.ToString(dr["GrouhMoshtari2_Name"]), RuntimeHelpers.GetObjectValue(dr["grouhMoshtari2_ID"]));
			}
			else
			{
				this.txt_grouhmoshtari2.SetNew();
			}
			flag2 = (dr["Sanad_ID"] != DBNull.Value);
			if (flag2)
			{
				object expr_3C5 = dr["Sanad_ID"];
				this.Sanad_ID = ((expr_3C5 != null) ? ((int?)expr_3C5) : num);
			}
			else
			{
				this.Sanad_ID = null;
			}
			flag2 = (dr["AvalDore"] != DBNull.Value);
			if (flag2)
			{
				this.txt_mablagh.Enabled = true;
				this.txt_mablagh.Text = dr["AvalDore"].ToString();
				this.txt_tarikh.SetDate(dr["AvalDore_Tarikh"].ToString());
			}
			else
			{
				this.txt_mablagh.Enabled = false;
				long? value;
				this.txt_mablagh.Value = value;
				this.txt_tarikh.SetNew();
			}
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000C6998 File Offset: 0x000C4B98
		private void LoadPic(DataRow dr)
		{
			bool flag = dr == null;
			if (flag)
			{
				this.PictureBox1.Image = null;
				this.PictureBox2.Image = null;
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
				flag = (dr["SignData"] != DBNull.Value);
				if (flag)
				{
					MemoryStream memoryStream2 = new MemoryStream();
					memoryStream2.Write((byte[])dr["SignData"], 0, ((byte[])dr["SignData"]).Length);
					this.PictureBox2.Image = Image.FromStream(memoryStream2);
				}
				else
				{
					this.PictureBox2.Image = null;
				}
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00006067 File Offset: 0x00004267
		private void Frm_Moshtari_Activated(object sender, EventArgs e)
		{
			this.txt_name.Focus();
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x000C6AA8 File Offset: 0x000C4CA8
		private void GetNewCode()
		{
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(max(id),99) from moshtari"));
			checked
			{
				num += 1L;
				bool flag = num == 0L;
				if (flag)
				{
					num = 1L;
				}
				this.txt_code_moshtari.Text = Conversions.ToString(num);
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x000C6AEC File Offset: 0x000C4CEC
		private void Frm_Moshtari_Load(object sender, EventArgs e)
		{
			this.txt_code_moshtari.Visible = false;
			this.lbl_code.Visible = true;
			this.Txt_Grouh_Moshtari.AllowEdit = true;
			this.txt_grouhmoshtari2.AllowEdit = true;
			this.Txt_Grouh_Moshtari.CanEdit = true;
			this.txt_grouhmoshtari2.CanEdit = true;
			this.Txt_Grouh_Moshtari.AddNewForm = MyProject.Forms.Frm_Grouh_Moshtari;
			this.txt_grouhmoshtari2.AddNewForm = MyProject.Forms.Frm_Grouh_Moshtari2;
			this.Txt_Grouh_Moshtari.Edit_Frm = MyProject.Forms.Frm_Grouh_Moshtari;
			this.txt_grouhmoshtari2.Edit_Frm = MyProject.Forms.Frm_Grouh_Moshtari2;
			this.txt_tarikh.SetNew();
			this.OpenFileDialog1.FileName = string.Empty;
			this.OpenFileDialog2.FileName = string.Empty;
			this.UiTabPage1.Selected = true;
			bool flag = this.ID.HasValue;
			if (flag)
			{
				DataRow byID = this.Moshtari.GetByID(Conversions.ToString((T)this.ID));
				this.LoadDataRow(byID);
				DataRow byID2 = this.Moshtari_Pic.GetByID(Conversions.ToString((T)this.ID));
				this.LoadPic(byID2);
				this.isnew = false;
				this.AutoClose = true;
			}
			else
			{
				this.UiButton5_Click(null, null);
				this.isnew = true;
				this.GetNewCode();
				this.cmb_avaldore.SelectedValue = 0;
				this.txt_name.Focus();
			}
			flag = !Conversions.ToBoolean(Public_Function.dict["moshtari_show_contact_info"]);
			if (flag)
			{
				this.group_contact_info.Visible = false;
			}
			else
			{
				this.group_contact_info.Visible = true;
			}
			flag = !Conversions.ToBoolean(Public_Function.dict["moshtari_show_pic"]);
			if (flag)
			{
				this.UiTab1.Visible = false;
			}
			else
			{
				this.UiTab1.Visible = true;
			}
			flag = !Conversions.ToBoolean(Public_Function.dict["moshtari_show_mahal"]);
			if (flag)
			{
				this.group_mahale_faaliyat.Visible = false;
			}
			else
			{
				this.group_mahale_faaliyat.Visible = true;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x000C6D2C File Offset: 0x000C4F2C
		private void cmb_avaldore_SelectedValueChanged(object sender, EventArgs e)
		{
			bool flag = this.cmb_avaldore.SelectedItem == null;
			if (!flag)
			{
				flag = Operators.ConditionalCompareObjectEqual(this.cmb_avaldore.SelectedValue, 0, false);
				if (flag)
				{
					this.txt_mablagh.Text = string.Empty;
					this.txt_mablagh.Enabled = false;
				}
				else
				{
					this.txt_mablagh.Enabled = true;
				}
			}
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x000C6D9C File Offset: 0x000C4F9C
		private void Frm_Moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			bool flag = keyCode == Keys.Insert;
			if (flag)
			{
				bool flag2 = this.ButtonItem1.Visible;
				if (flag2)
				{
					this.ButtonItem1_Click(null, null);
				}
			}
			else
			{
				bool flag2 = keyCode == Keys.F2;
				if (flag2)
				{
					flag = this.ButtonItem2.Visible;
					if (flag)
					{
						this.ButtonItem2_Click(null, null);
					}
				}
				else
				{
					flag2 = (keyCode == Keys.F5);
					if (flag2)
					{
						flag = this.ButtonItem3.Visible;
						if (flag)
						{
							this.ButtonItem3_Click(null, null);
						}
					}
					else
					{
						flag2 = (keyCode == Keys.F7);
						if (flag2)
						{
							flag = this.ButtonItem4.Visible;
							if (flag)
							{
								this.ButtonItem4_Click(null, null);
							}
						}
						else
						{
							flag2 = (keyCode == Keys.Escape);
							if (flag2)
							{
								this.Close();
							}
						}
					}
				}
			}
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x000C6E5C File Offset: 0x000C505C
		private void UiButton3_Click(object sender, EventArgs e)
		{
			bool flag = this.OpenFileDialog1.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				byte[] array = File.ReadAllBytes(this.OpenFileDialog1.FileName);
				this.PictureBox1.Image = Image.FromFile(this.OpenFileDialog1.FileName);
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00006077 File Offset: 0x00004277
		private void UiButton6_Click(object sender, EventArgs e)
		{
			this.PictureBox2.Image = null;
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00006088 File Offset: 0x00004288
		private void UiButton4_Click(object sender, EventArgs e)
		{
			this.PictureBox1.Image = null;
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000C6EAC File Offset: 0x000C50AC
		private void UiButton7_Click(object sender, EventArgs e)
		{
			bool flag = this.OpenFileDialog2.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				byte[] array = File.ReadAllBytes(this.OpenFileDialog2.FileName);
				this.PictureBox2.Image = Image.FromFile(this.OpenFileDialog2.FileName);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x000C6EFC File Offset: 0x000C50FC
		private void UiButton8_Click(object sender, EventArgs e)
		{
			Frm_Moshtari_Hesab frm_Moshtari_Hesab = new Frm_Moshtari_Hesab();
			frm_Moshtari_Hesab.Moshtari_ID = this.ID.ToString();
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_Moshtari_Hesab);
			this.dt_hesab = frm_Moshtari_Hesab.dt_Hesab;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000605A File Offset: 0x0000425A
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			this.UiButton5_Click(null, null);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00006099 File Offset: 0x00004299
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.UiButton1_Click(null, null);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000060A6 File Offset: 0x000042A6
		private void ButtonItem4_Click(object sender, EventArgs e)
		{
			this.UiButton8_Click(null, null);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000C6F4C File Offset: 0x000C514C
		private void moaref_kind_ButtonClick(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("name", typeof(string));
			dataTable.Rows.Add(new object[]
			{
				1,
				"دائم"
			});
			dataTable.Rows.Add(new object[]
			{
				2,
				"موقت"
			});
			Frm_SelectItem frm_SelectItem = new Frm_SelectItem();
			frm_SelectItem.items = new ItemCollection
			{
				new Column("Name", "عنوان", 100)
			};
			bool flag = frm_SelectItem.ShowDialog(dataTable, null, "انتخاب نوع معرف") == DialogResult.OK;
			if (flag)
			{
				this.moaref_kind.SetValue(Conversions.ToString(frm_SelectItem.SelectedRow["Name"]), RuntimeHelpers.GetObjectValue(frm_SelectItem.SelectedRow["ID"]));
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x000C7060 File Offset: 0x000C5260
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			bool flag = !this.ID.HasValue;
			if (!flag)
			{
				flag = (Public_Function.ShowMessage("آیا مایل به حذف مشتری میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes);
				if (flag)
				{
					bool flag2 = this.Moshtari.Delete(Conversions.ToString((T)this.ID));
					if (flag2)
					{
						this.newfrm();
					}
				}
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x000C70C8 File Offset: 0x000C52C8
		private void txt_code_moshtari_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Return;
			if (flag)
			{
				this.txt_code_moshtari_Validating(null, null);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x000C70F0 File Offset: 0x000C52F0
		private void txt_code_moshtari_Validating(object sender, CancelEventArgs e)
		{
			bool flag = this.isnew;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txt_code_moshtari.Text, string.Empty, false) != 0;
				if (flag2)
				{
					bool flag3 = Operators.ConditionalCompareObjectGreater(Public_Function.ExecuteScalar("select count(id) from moshtari where id=" + this.txt_code_moshtari.Text), 0, false);
					if (flag3)
					{
						this.GetNewCode();
					}
				}
			}
		}

		// Token: 0x040006CF RID: 1743
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040006D1 RID: 1745
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040006D2 RID: 1746
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040006D3 RID: 1747
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040006D4 RID: 1748
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x040006D5 RID: 1749
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x040006D6 RID: 1750
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x040006D7 RID: 1751
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x040006D8 RID: 1752
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x040006D9 RID: 1753
		[AccessedThroughProperty("Label13")]
		private Label _Label13;

		// Token: 0x040006DA RID: 1754
		[AccessedThroughProperty("txt_name")]
		private EditBox _txt_name;

		// Token: 0x040006DB RID: 1755
		[AccessedThroughProperty("txt_family")]
		private EditBox _txt_family;

		// Token: 0x040006DC RID: 1756
		[AccessedThroughProperty("txt_codemelli")]
		private NumericBox _txt_codemelli;

		// Token: 0x040006DD RID: 1757
		[AccessedThroughProperty("txt_shsh")]
		private NumericBox _txt_shsh;

		// Token: 0x040006DE RID: 1758
		[AccessedThroughProperty("txt_tel1")]
		private EditBox _txt_tel1;

		// Token: 0x040006DF RID: 1759
		[AccessedThroughProperty("txt_tel2")]
		private EditBox _txt_tel2;

		// Token: 0x040006E0 RID: 1760
		[AccessedThroughProperty("txt_fax")]
		private EditBox _txt_fax;

		// Token: 0x040006E1 RID: 1761
		[AccessedThroughProperty("txt_address")]
		private EditBox _txt_address;

		// Token: 0x040006E2 RID: 1762
		[AccessedThroughProperty("txt_codeegtesadi")]
		private NumericBox _txt_codeegtesadi;

		// Token: 0x040006E3 RID: 1763
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040006E4 RID: 1764
		[AccessedThroughProperty("UiTab1")]
		private UITab _UiTab1;

		// Token: 0x040006E5 RID: 1765
		[AccessedThroughProperty("UiTabPage2")]
		private UITabPage _UiTabPage2;

		// Token: 0x040006E6 RID: 1766
		[AccessedThroughProperty("UiTabPage1")]
		private UITabPage _UiTabPage1;

		// Token: 0x040006E7 RID: 1767
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x040006E8 RID: 1768
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040006E9 RID: 1769
		[AccessedThroughProperty("Label15")]
		private Label _Label15;

		// Token: 0x040006EA RID: 1770
		[AccessedThroughProperty("UiButton4")]
		private UIButton _UiButton4;

		// Token: 0x040006EB RID: 1771
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040006EC RID: 1772
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040006ED RID: 1773
		[AccessedThroughProperty("Label14")]
		private Label _Label14;

		// Token: 0x040006EE RID: 1774
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x040006EF RID: 1775
		[AccessedThroughProperty("Label16")]
		private Label _Label16;

		// Token: 0x040006F0 RID: 1776
		[AccessedThroughProperty("txt_tarikh")]
		private DateBox2 _txt_tarikh;

		// Token: 0x040006F1 RID: 1777
		[AccessedThroughProperty("cmb_avaldore")]
		private ComboBox _cmb_avaldore;

		// Token: 0x040006F2 RID: 1778
		[AccessedThroughProperty("Label17")]
		private Label _Label17;

		// Token: 0x040006F3 RID: 1779
		[AccessedThroughProperty("txt_Moaref")]
		private EditBox _txt_Moaref;

		// Token: 0x040006F4 RID: 1780
		[AccessedThroughProperty("UiButton6")]
		private UIButton _UiButton6;

		// Token: 0x040006F5 RID: 1781
		[AccessedThroughProperty("UiButton7")]
		private UIButton _UiButton7;

		// Token: 0x040006F6 RID: 1782
		[AccessedThroughProperty("PictureBox2")]
		private PictureBox _PictureBox2;

		// Token: 0x040006F7 RID: 1783
		[AccessedThroughProperty("OpenFileDialog1")]
		private OpenFileDialog _OpenFileDialog1;

		// Token: 0x040006F8 RID: 1784
		[AccessedThroughProperty("OpenFileDialog2")]
		private OpenFileDialog _OpenFileDialog2;

		// Token: 0x040006F9 RID: 1785
		[AccessedThroughProperty("txt_address2")]
		private EditBox _txt_address2;

		// Token: 0x040006FA RID: 1786
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x040006FB RID: 1787
		[AccessedThroughProperty("txt_codeposti")]
		private EditBox _txt_codeposti;

		// Token: 0x040006FC RID: 1788
		[AccessedThroughProperty("Label18")]
		private Label _Label18;

		// Token: 0x040006FD RID: 1789
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x040006FE RID: 1790
		[AccessedThroughProperty("txt_tel4")]
		private EditBox _txt_tel4;

		// Token: 0x040006FF RID: 1791
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000700 RID: 1792
		[AccessedThroughProperty("txt_tel3")]
		private EditBox _txt_tel3;

		// Token: 0x04000701 RID: 1793
		[AccessedThroughProperty("Txt_Grouh_Moshtari")]
		private SelectItem _Txt_Grouh_Moshtari;

		// Token: 0x04000702 RID: 1794
		[AccessedThroughProperty("Label19")]
		private Label _Label19;

		// Token: 0x04000703 RID: 1795
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000704 RID: 1796
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000705 RID: 1797
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000706 RID: 1798
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x04000707 RID: 1799
		[AccessedThroughProperty("ButtonItem4")]
		private ButtonItem _ButtonItem4;

		// Token: 0x04000708 RID: 1800
		[AccessedThroughProperty("txt_grouhmoshtari2")]
		private SelectItem _txt_grouhmoshtari2;

		// Token: 0x04000709 RID: 1801
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400070A RID: 1802
		[AccessedThroughProperty("lbl_code")]
		private Label _lbl_code;

		// Token: 0x0400070B RID: 1803
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x0400070C RID: 1804
		[AccessedThroughProperty("txt_moshtari_kind")]
		private SelectItem _txt_moshtari_kind;

		// Token: 0x0400070D RID: 1805
		[AccessedThroughProperty("Label21")]
		private Label _Label21;

		// Token: 0x0400070E RID: 1806
		[AccessedThroughProperty("moaref_kind")]
		private SelectItem _moaref_kind;

		// Token: 0x0400070F RID: 1807
		[AccessedThroughProperty("Label22")]
		private Label _Label22;

		// Token: 0x04000710 RID: 1808
		[AccessedThroughProperty("txt_karmozd")]
		private NumericBox _txt_karmozd;

		// Token: 0x04000711 RID: 1809
		[AccessedThroughProperty("Label23")]
		private Label _Label23;

		// Token: 0x04000712 RID: 1810
		[AccessedThroughProperty("txt_code_moshtari")]
		private NumericBox _txt_code_moshtari;

		// Token: 0x04000713 RID: 1811
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x04000714 RID: 1812
		[AccessedThroughProperty("group_contact_info")]
		private UIGroupBox _group_contact_info;

		// Token: 0x04000715 RID: 1813
		[AccessedThroughProperty("group_mahale_faaliyat")]
		private UIGroupBox _group_mahale_faaliyat;

		// Token: 0x04000716 RID: 1814
		[AccessedThroughProperty("group__albagi")]
		private UIGroupBox _group__albagi;

		// Token: 0x04000717 RID: 1815
		private bool isnew;

		// Token: 0x04000718 RID: 1816
		private Code_Hesab CodeHesab;

		// Token: 0x04000719 RID: 1817
		[CompilerGenerated]
		private int? _ID;

		// Token: 0x0400071A RID: 1818
		private int? Sanad_ID;

		// Token: 0x0400071B RID: 1819
		private int? CodeHesab_Moshtari;

		// Token: 0x0400071C RID: 1820
		private Moshtari Moshtari;

		// Token: 0x0400071D RID: 1821
		private Moshtari_Pic Moshtari_Pic;

		// Token: 0x0400071E RID: 1822
		private Sanad Sanad;

		// Token: 0x0400071F RID: 1823
		private Moshtari_Hesab Hesab;

		// Token: 0x04000720 RID: 1824
		private DataTable dt_hesab;

		// Token: 0x04000721 RID: 1825
		[CompilerGenerated]
		private bool _AutoClose;
	}
}
