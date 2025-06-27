using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200005E RID: 94
	[DesignerGenerated]
	public partial class Frm_Amniat_Setting : Form
	{
		// Token: 0x0600065B RID: 1627 RVA: 0x00002E0E File Offset: 0x0000100E
		[DebuggerNonUserCode]
		public Frm_Amniat_Setting()
		{
			base.Load += new EventHandler(this.Frm_Amniat_Setting_Load);
			base.KeyDown += new KeyEventHandler(this.Frm_Amniat_Setting_KeyDown);
			Frm_Amniat_Setting.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00064E4C File Offset: 0x0006304C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Amniat_Setting.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Amniat_Setting.__ENCList.Count == Frm_Amniat_Setting.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Amniat_Setting.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Amniat_Setting.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Amniat_Setting.__ENCList[num] = Frm_Amniat_Setting.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Amniat_Setting.__ENCList.RemoveRange(num, Frm_Amniat_Setting.__ENCList.Count - num);
						Frm_Amniat_Setting.__ENCList.Capacity = Frm_Amniat_Setting.__ENCList.Count;
					}
					Frm_Amniat_Setting.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0006602C File Offset: 0x0006422C
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x00002E4E File Offset: 0x0000104E
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

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00066044 File Offset: 0x00064244
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00002E58 File Offset: 0x00001058
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

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0006605C File Offset: 0x0006425C
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00066074 File Offset: 0x00064274
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

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000660D4 File Offset: 0x000642D4
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00002E62 File Offset: 0x00001062
		internal virtual BackgroundWorker BackgroundWorker1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._BackgroundWorker1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._BackgroundWorker1 = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000660EC File Offset: 0x000642EC
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00002E6C File Offset: 0x0000106C
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

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00066104 File Offset: 0x00064304
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00002E76 File Offset: 0x00001076
		internal virtual UIComboBox txt_eslah_safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_eslah_safi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_eslah_safi = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0006611C File Offset: 0x0006431C
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00002E80 File Offset: 0x00001080
		internal virtual UIComboBox txt_sandugh_baz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sandugh_baz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sandugh_baz = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00066134 File Offset: 0x00064334
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00002E8A File Offset: 0x0000108A
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0006614C File Offset: 0x0006434C
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00002E94 File Offset: 0x00001094
		internal virtual UIComboBox txt_sandugh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sandugh;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sandugh = value;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00066164 File Offset: 0x00064364
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00002E9E File Offset: 0x0000109E
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0006617C File Offset: 0x0006437C
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x00002EA8 File Offset: 0x000010A8
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

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00066194 File Offset: 0x00064394
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x00002EB2 File Offset: 0x000010B2
		internal virtual EditBox txt_password
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_password;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_password = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000661AC File Offset: 0x000643AC
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x00002EBC File Offset: 0x000010BC
		internal virtual UIComboBox txt_kharid_baz
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_kharid_baz;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_kharid_baz = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x000661C4 File Offset: 0x000643C4
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00002EC6 File Offset: 0x000010C6
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

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000661DC File Offset: 0x000643DC
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002ED0 File Offset: 0x000010D0
		internal virtual UIComboBox txt_autolock
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_autolock;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_autolock = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x000661F4 File Offset: 0x000643F4
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00002EDA File Offset: 0x000010DA
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

		// Token: 0x0600067F RID: 1663 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Amniat_Setting_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00066234 File Offset: 0x00064434
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			bool arg_53_0;
			if (!Operators.ConditionalCompareObjectEqual(this.txt_eslah_safi.SelectedValue, 3, false) && !Operators.ConditionalCompareObjectEqual(this.txt_sandugh.SelectedValue, 3, false))
			{
				if (!Operators.ConditionalCompareObjectEqual(this.txt_sandugh_baz.SelectedValue, 3, false))
				{
					arg_53_0 = false;
					goto IL_52;
				}
			}
			arg_53_0 = true;
			IL_52:
			bool flag = arg_53_0;
			if (flag)
			{
				bool flag2 = Operators.CompareString(this.txt_password.Text, string.Empty, false) == 0;
				if (flag2)
				{
					Public_Function.ShowTip(this.txt_password, "گذرواژه عملیات را وارد نمایید");
					return;
				}
			}
			setting setting = new setting();
			setting.Update("pidkey", this.txt_password.Text);
			setting.Update("eslah_safi", Conversions.ToString(this.txt_eslah_safi.SelectedValue));
			setting.Update("sandugh_baste", Conversions.ToString(this.txt_sandugh.SelectedValue));
			setting.Update("sandugh_baz", Conversions.ToString(this.txt_sandugh_baz.SelectedValue));
			setting.Update("kharid_baz", Conversions.ToString(this.txt_kharid_baz.SelectedValue));
			setting.Update("autolock", Conversions.ToString(this.txt_autolock.SelectedValue));
			Public_Function.dict["pidkey"] = this.txt_password.Text;
			Public_Function.dict["eslah_safi"] = Conversions.ToString(this.txt_eslah_safi.SelectedValue);
			Public_Function.dict["sandugh_baste"] = Conversions.ToString(this.txt_sandugh.SelectedValue);
			Public_Function.dict["sandugh_baz"] = Conversions.ToString(this.txt_sandugh_baz.SelectedValue);
			Public_Function.dict["kharid_baz"] = Conversions.ToString(this.txt_kharid_baz.SelectedValue);
			Public_Function.dict["autolock"] = Conversions.ToString(this.txt_autolock.SelectedValue);
			Public_Function.ShowMessage("اطلاعات مورد نظر ثبت گردید", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
			this.Close();
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0006644C File Offset: 0x0006464C
		private void Frm_Amniat_Setting_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict.ContainsKey("pidkey");
			if (flag)
			{
				this.txt_password.Text = Public_Function.dict["pidkey"];
			}
			flag = Public_Function.dict.ContainsKey("eslah_safi");
			if (flag)
			{
				this.txt_eslah_safi.SelectedValue = Public_Function.dict["eslah_safi"];
			}
			else
			{
				this.txt_eslah_safi.SelectedValue = 1;
			}
			flag = Public_Function.dict.ContainsKey("sandugh_baste");
			if (flag)
			{
				this.txt_sandugh.SelectedValue = Public_Function.dict["sandugh_baste"];
			}
			else
			{
				this.txt_sandugh.SelectedValue = 1;
			}
			flag = Public_Function.dict.ContainsKey("sandugh_baz");
			if (flag)
			{
				this.txt_sandugh_baz.SelectedValue = Public_Function.dict["sandugh_baz"];
			}
			else
			{
				this.txt_sandugh_baz.SelectedValue = 1;
			}
			this.txt_kharid_baz.SelectedValue = Public_Function.dict["kharid_baz"];
			this.txt_autolock.SelectedValue = Public_Function.dict["autolock"];
			flag = (Operators.CompareString(this.txt_password.Text, string.Empty, false) != 0);
			if (flag)
			{
				flag = (new Frm_Password
				{
					Auth_type = 2
				}.ShowDialog() == DialogResult.Cancel);
				if (flag)
				{
					this.Close();
				}
			}
		}

		// Token: 0x04000266 RID: 614
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000268 RID: 616
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000269 RID: 617
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x0400026A RID: 618
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400026B RID: 619
		[AccessedThroughProperty("BackgroundWorker1")]
		private BackgroundWorker _BackgroundWorker1;

		// Token: 0x0400026C RID: 620
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x0400026D RID: 621
		[AccessedThroughProperty("txt_eslah_safi")]
		private UIComboBox _txt_eslah_safi;

		// Token: 0x0400026E RID: 622
		[AccessedThroughProperty("txt_sandugh_baz")]
		private UIComboBox _txt_sandugh_baz;

		// Token: 0x0400026F RID: 623
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000270 RID: 624
		[AccessedThroughProperty("txt_sandugh")]
		private UIComboBox _txt_sandugh;

		// Token: 0x04000271 RID: 625
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000272 RID: 626
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000273 RID: 627
		[AccessedThroughProperty("txt_password")]
		private EditBox _txt_password;

		// Token: 0x04000274 RID: 628
		[AccessedThroughProperty("txt_kharid_baz")]
		private UIComboBox _txt_kharid_baz;

		// Token: 0x04000275 RID: 629
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000276 RID: 630
		[AccessedThroughProperty("txt_autolock")]
		private UIComboBox _txt_autolock;

		// Token: 0x04000277 RID: 631
		[AccessedThroughProperty("Label4")]
		private Label _Label4;
	}
}
