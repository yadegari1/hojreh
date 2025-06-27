using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Janus.Windows.EditControls;
using Janus.Windows.Ribbon;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000068 RID: 104
	public partial class Frm_EditUser : Form
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x0000332A File Offset: 0x0000152A
		public Frm_EditUser()
		{
			base.Load += new EventHandler(this.Frm_EditUser_Load);
			Frm_EditUser.__ENCAddToList(this);
			this.user = new base_user();
			this.InitializeComponent();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0006F8F8 File Offset: 0x0006DAF8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_EditUser.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_EditUser.__ENCList.Count == Frm_EditUser.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_EditUser.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_EditUser.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_EditUser.__ENCList[num] = Frm_EditUser.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_EditUser.__ENCList.RemoveRange(num, Frm_EditUser.__ENCList.Count - num);
						Frm_EditUser.__ENCList.Capacity = Frm_EditUser.__ENCList.Count;
					}
					Frm_EditUser.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00070638 File Offset: 0x0006E838
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x00003361 File Offset: 0x00001561
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

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00070650 File Offset: 0x0006E850
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0000336B File Offset: 0x0000156B
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

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00070668 File Offset: 0x0006E868
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x00003375 File Offset: 0x00001575
		internal virtual OfficeFormAdorner OfficeFormAdorner1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OfficeFormAdorner1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._OfficeFormAdorner1 = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00070680 File Offset: 0x0006E880
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x00070698 File Offset: 0x0006E898
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

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x000706F8 File Offset: 0x0006E8F8
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0000337F File Offset: 0x0000157F
		internal virtual UIRadioButton UiRadioButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton2 = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00070710 File Offset: 0x0006E910
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00003389 File Offset: 0x00001589
		internal virtual UIRadioButton UiRadioButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton1 = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00070728 File Offset: 0x0006E928
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00003393 File Offset: 0x00001593
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

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00070740 File Offset: 0x0006E940
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0000339D File Offset: 0x0000159D
		internal virtual SwitchButton SwitchButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SwitchButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SwitchButton2 = value;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00070758 File Offset: 0x0006E958
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x000033A7 File Offset: 0x000015A7
		internal virtual SwitchButton SwitchButton1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SwitchButton1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._SwitchButton1 = value;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00070770 File Offset: 0x0006E970
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x000033B1 File Offset: 0x000015B1
		internal virtual UIRadioButton UiRadioButton4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton4 = value;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00070788 File Offset: 0x0006E988
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x000033BB File Offset: 0x000015BB
		internal virtual UIRadioButton UiRadioButton3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiRadioButton3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiRadioButton3 = value;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x000707A0 File Offset: 0x0006E9A0
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x000033C5 File Offset: 0x000015C5
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

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x000707B8 File Offset: 0x0006E9B8
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x000033CF File Offset: 0x000015CF
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

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000707D0 File Offset: 0x0006E9D0
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x000033D9 File Offset: 0x000015D9
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

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000707E8 File Offset: 0x0006E9E8
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x000033E3 File Offset: 0x000015E3
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

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x00070800 File Offset: 0x0006EA00
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x000033ED File Offset: 0x000015ED
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

		// Token: 0x060007AC RID: 1964 RVA: 0x00070818 File Offset: 0x0006EA18
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string gui = string.Empty;
			string tabbed = string.Empty;
			string autoclose = string.Empty;
			string autobackup = string.Empty;
			bool flag = this.UiRadioButton1.Checked;
			if (flag)
			{
				gui = "1";
			}
			else
			{
				gui = "0";
			}
			flag = this.UiRadioButton3.Checked;
			if (flag)
			{
				tabbed = "0";
			}
			else
			{
				tabbed = "1";
			}
			flag = this.SwitchButton1.Value;
			if (flag)
			{
				autoclose = "0";
			}
			else
			{
				autoclose = "1";
			}
			flag = this.SwitchButton2.Value;
			if (flag)
			{
				autobackup = "1";
			}
			else
			{
				autobackup = "0";
			}
			this.user.Update(gui, tabbed, autoclose, autobackup);
			this.Close();
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x000708DC File Offset: 0x0006EADC
		private void Frm_EditUser_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.CurrentData.Gui == 1;
			if (flag)
			{
				this.UiRadioButton1.Checked = true;
			}
			else
			{
				this.UiRadioButton2.Checked = true;
			}
			flag = Public_Function.CurrentData.Tabbed;
			if (flag)
			{
				this.UiRadioButton4.Checked = true;
			}
			else
			{
				this.UiRadioButton3.Checked = true;
			}
			flag = Public_Function.CurrentData.AutoClose;
			if (flag)
			{
				this.SwitchButton1.Value = false;
			}
			else
			{
				this.SwitchButton1.Value = true;
			}
			flag = Public_Function.CurrentData.AutoBackup;
			if (flag)
			{
				this.SwitchButton2.Value = true;
			}
			else
			{
				this.SwitchButton2.Value = false;
			}
		}

		// Token: 0x040002E1 RID: 737
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002E3 RID: 739
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040002E4 RID: 740
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x040002E5 RID: 741
		[AccessedThroughProperty("OfficeFormAdorner1")]
		private OfficeFormAdorner _OfficeFormAdorner1;

		// Token: 0x040002E6 RID: 742
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x040002E7 RID: 743
		[AccessedThroughProperty("UiRadioButton2")]
		private UIRadioButton _UiRadioButton2;

		// Token: 0x040002E8 RID: 744
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x040002E9 RID: 745
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002EA RID: 746
		[AccessedThroughProperty("SwitchButton2")]
		private SwitchButton _SwitchButton2;

		// Token: 0x040002EB RID: 747
		[AccessedThroughProperty("SwitchButton1")]
		private SwitchButton _SwitchButton1;

		// Token: 0x040002EC RID: 748
		[AccessedThroughProperty("UiRadioButton4")]
		private UIRadioButton _UiRadioButton4;

		// Token: 0x040002ED RID: 749
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x040002EE RID: 750
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x040002EF RID: 751
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002F0 RID: 752
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002F1 RID: 753
		[AccessedThroughProperty("UiGroupBox4")]
		private UIGroupBox _UiGroupBox4;

		// Token: 0x040002F2 RID: 754
		[AccessedThroughProperty("UiGroupBox3")]
		private UIGroupBox _UiGroupBox3;

		// Token: 0x040002F3 RID: 755
		private base_user user;

        private void Frm_EditUser_Load_1(object sender, EventArgs e)
        {

        }
    }
}
