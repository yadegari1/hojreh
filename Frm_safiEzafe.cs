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
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200010C RID: 268
	[DesignerGenerated]
	public partial class Frm_safiEzafe : Form
	{
		// Token: 0x06002677 RID: 9847 RVA: 0x00009959 File Offset: 0x00007B59
		[DebuggerNonUserCode]
		public Frm_safiEzafe()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_safiEzafe_KeyDown);
			base.Load += new EventHandler(this.Frm_safiEzafe_Load);
			Frm_safiEzafe.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x001D1C10 File Offset: 0x001CFE10
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_safiEzafe.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_safiEzafe.__ENCList.Count == Frm_safiEzafe.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_safiEzafe.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_safiEzafe.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_safiEzafe.__ENCList[num] = Frm_safiEzafe.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_safiEzafe.__ENCList.RemoveRange(num, Frm_safiEzafe.__ENCList.Count - num);
						Frm_safiEzafe.__ENCList.Capacity = Frm_safiEzafe.__ENCList.Count;
					}
					Frm_safiEzafe.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x001D2668 File Offset: 0x001D0868
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x00009999 File Offset: 0x00007B99
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

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x001D2680 File Offset: 0x001D0880
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x000099A3 File Offset: 0x00007BA3
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

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x001D2698 File Offset: 0x001D0898
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x000099AD File Offset: 0x00007BAD
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

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002681 RID: 9857 RVA: 0x001D26B0 File Offset: 0x001D08B0
		// (set) Token: 0x06002682 RID: 9858 RVA: 0x001D26C8 File Offset: 0x001D08C8
		internal virtual CurrencyBox txt_ezafe
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_ezafe;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_ezafe_TextChanged);
				bool flag = this._txt_ezafe != null;
				if (flag)
				{
					this._txt_ezafe.TextChanged -= value2;
				}
				this._txt_ezafe = value;
				flag = (this._txt_ezafe != null);
				if (flag)
				{
					this._txt_ezafe.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002683 RID: 9859 RVA: 0x001D2728 File Offset: 0x001D0928
		// (set) Token: 0x06002684 RID: 9860 RVA: 0x000099B7 File Offset: 0x00007BB7
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

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x001D2740 File Offset: 0x001D0940
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x000099C1 File Offset: 0x00007BC1
		internal virtual CurrencyBox txt_safikol
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_safikol;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_safikol = value;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x001D2758 File Offset: 0x001D0958
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x000099CB File Offset: 0x00007BCB
		internal virtual CurrencyBox txt_safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_safi;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_safi = value;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x001D2770 File Offset: 0x001D0970
		// (set) Token: 0x0600268A RID: 9866 RVA: 0x000099D5 File Offset: 0x00007BD5
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

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600268B RID: 9867 RVA: 0x001D2788 File Offset: 0x001D0988
		// (set) Token: 0x0600268C RID: 9868 RVA: 0x001D27A0 File Offset: 0x001D09A0
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

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600268D RID: 9869 RVA: 0x001D2800 File Offset: 0x001D0A00
		// (set) Token: 0x0600268E RID: 9870 RVA: 0x000099DF File Offset: 0x00007BDF
		public long Safi
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Safi;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Safi = value;
			}
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_safiEzafe_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000099E9 File Offset: 0x00007BE9
		private void Frm_safiEzafe_Load(object sender, EventArgs e)
		{
			this.txt_safi.Text = Conversions.ToString(this.Safi);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x001D2818 File Offset: 0x001D0A18
		private void txt_ezafe_TextChanged(object sender, EventArgs e)
		{
			Control arg_5D_0 = this.txt_safikol;
			long? value = this.txt_safi.Value;
			bool arg_2D_0 = value.HasValue;
			long? value2 = this.txt_ezafe.Value;
			long? arg_53_0;
			if (!(arg_2D_0 & value2.HasValue))
			{
				arg_53_0 = null;
			}
			else
			{
				long? num = new long?(checked(value.GetValueOrDefault() + value2.GetValueOrDefault()));
				arg_53_0 = num;
			}
			arg_5D_0.Text = Conversions.ToString((T)arg_53_0);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0000205D File Offset: 0x0000025D
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x04000F0B RID: 3851
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F0D RID: 3853
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F0E RID: 3854
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000F0F RID: 3855
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000F10 RID: 3856
		[AccessedThroughProperty("txt_ezafe")]
		private CurrencyBox _txt_ezafe;

		// Token: 0x04000F11 RID: 3857
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F12 RID: 3858
		[AccessedThroughProperty("txt_safikol")]
		private CurrencyBox _txt_safikol;

		// Token: 0x04000F13 RID: 3859
		[AccessedThroughProperty("txt_safi")]
		private CurrencyBox _txt_safi;

		// Token: 0x04000F14 RID: 3860
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000F15 RID: 3861
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x04000F16 RID: 3862
		[CompilerGenerated]
		private long _Safi;
	}
}
