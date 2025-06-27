using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.ServiceProcess;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000066 RID: 102
	[DesignerGenerated]
	public partial class Frm_Connect : Form
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x000031D3 File Offset: 0x000013D3
		[DebuggerNonUserCode]
		public Frm_Connect()
		{
			base.Load += new EventHandler(this.Frm_Connect_Load);
			base.Activated += new EventHandler(this.Frm_Connect_Activated);
			Frm_Connect.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0006E0D8 File Offset: 0x0006C2D8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Connect.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Connect.__ENCList.Count == Frm_Connect.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Connect.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Connect.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Connect.__ENCList[num] = Frm_Connect.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Connect.__ENCList.RemoveRange(num, Frm_Connect.__ENCList.Count - num);
						Frm_Connect.__ENCList.Capacity = Frm_Connect.__ENCList.Count;
					}
					Frm_Connect.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0006E970 File Offset: 0x0006CB70
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00003213 File Offset: 0x00001413
		internal virtual PanelEx PanelEx1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PanelEx1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PanelEx1 = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0006E988 File Offset: 0x0006CB88
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x0000321D File Offset: 0x0000141D
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

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0006E9A0 File Offset: 0x0006CBA0
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00003227 File Offset: 0x00001427
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

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0006E9B8 File Offset: 0x0006CBB8
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x0006E9D0 File Offset: 0x0006CBD0
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

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0006EA30 File Offset: 0x0006CC30
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x0006EA48 File Offset: 0x0006CC48
		internal virtual UIButton btn_ViewError
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_ViewError;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_ViewError_Click);
				bool flag = this._btn_ViewError != null;
				if (flag)
				{
					this._btn_ViewError.Click -= value2;
				}
				this._btn_ViewError = value;
				flag = (this._btn_ViewError != null);
				if (flag)
				{
					this._btn_ViewError.Click += value2;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0006EAA8 File Offset: 0x0006CCA8
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0006EAC0 File Offset: 0x0006CCC0
		internal virtual UIButton btn_try
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn_try;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.btn_try_Click);
				bool flag = this._btn_try != null;
				if (flag)
				{
					this._btn_try.Click -= value2;
				}
				this._btn_try = value;
				flag = (this._btn_try != null);
				if (flag)
				{
					this._btn_try.Click += value2;
				}
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0006EB20 File Offset: 0x0006CD20
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0006EB38 File Offset: 0x0006CD38
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

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000763 RID: 1891 RVA: 0x0006EB98 File Offset: 0x0006CD98
		// (set) Token: 0x06000764 RID: 1892 RVA: 0x00003231 File Offset: 0x00001431
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

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x0006EBB0 File Offset: 0x0006CDB0
		// (set) Token: 0x06000766 RID: 1894 RVA: 0x0000323B File Offset: 0x0000143B
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

		// Token: 0x06000767 RID: 1895 RVA: 0x0000205D File Offset: 0x0000025D
		private void Frm_Connect_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0006EBC8 File Offset: 0x0006CDC8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			try
			{
				ServiceController serviceController = new ServiceController("MSSQL$FRUITBOX");
				Public_Function.ShowMessage("starting service...", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk, null);
				serviceController.Start();
				Application.Restart();
			}
			catch (Exception expr_38)
			{
				ProjectData.SetProjectError(expr_38);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00003245 File Offset: 0x00001445
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void UiButton3_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			ProjectData.EndApp();
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0006EC30 File Offset: 0x0006CE30
		private void btn_try_Click(object sender, EventArgs e)
		{
			try
			{
				Public_Function.Connection.Open();
				this.Close();
			}
			catch (Exception expr_16)
			{
				ProjectData.SetProjectError(expr_16);
				Public_Function.ShowMessage("امکان ارتباط با بانک اطلاعاتی وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Hand, null);
				ProjectData.ClearProjectError();
			}
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00003257 File Offset: 0x00001457
		private void btn_ViewError_Click(object sender, EventArgs e)
		{
			Public_Function.ShowMessage(this.err, MessageBoxButtons.OK, MessageBoxIcon.Asterisk, null);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000326B File Offset: 0x0000146B
		private void Frm_Connect_Load(object sender, EventArgs e)
		{
			this.PictureBox1.Image = Resources.Data_Connect;
		}

		// Token: 0x040002CA RID: 714
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040002CC RID: 716
		[AccessedThroughProperty("PanelEx1")]
		private PanelEx _PanelEx1;

		// Token: 0x040002CD RID: 717
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040002CE RID: 718
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x040002CF RID: 719
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x040002D0 RID: 720
		[AccessedThroughProperty("btn_ViewError")]
		private UIButton _btn_ViewError;

		// Token: 0x040002D1 RID: 721
		[AccessedThroughProperty("btn_try")]
		private UIButton _btn_try;

		// Token: 0x040002D2 RID: 722
		[AccessedThroughProperty("UiButton3")]
		private UIButton _UiButton3;

		// Token: 0x040002D3 RID: 723
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040002D4 RID: 724
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x040002D5 RID: 725
		private string err;
	}
}
