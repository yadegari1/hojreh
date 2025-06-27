using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000115 RID: 277
	[DesignerGenerated]
	public partial class Frm_TedadKala : Form
	{
		// Token: 0x06002827 RID: 10279 RVA: 0x001E553C File Offset: 0x001E373C
		public Frm_TedadKala()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_TedadKala_KeyDown);
			base.Load += new EventHandler(this.Frm_TedadKala_Load);
			Frm_TedadKala.__ENCAddToList(this);
			bool is_Kharid = false;
			this.Is_Kharid = is_Kharid;
			this.InitializeComponent();
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x001E5594 File Offset: 0x001E3794
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_TedadKala.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_TedadKala.__ENCList.Count == Frm_TedadKala.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_TedadKala.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_TedadKala.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_TedadKala.__ENCList[num] = Frm_TedadKala.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_TedadKala.__ENCList.RemoveRange(num, Frm_TedadKala.__ENCList.Count - num);
						Frm_TedadKala.__ENCList.Capacity = Frm_TedadKala.__ENCList.Count;
					}
					Frm_TedadKala.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x001E6080 File Offset: 0x001E4280
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x00009F6F File Offset: 0x0000816F
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x001E6098 File Offset: 0x001E4298
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x00009F79 File Offset: 0x00008179
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x001E60B0 File Offset: 0x001E42B0
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x00009F83 File Offset: 0x00008183
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

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x001E60C8 File Offset: 0x001E42C8
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x00009F8D File Offset: 0x0000818D
		internal virtual DataEntryGrid Grid_RizBar
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Grid_RizBar;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Grid_RizBar = value;
			}
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x001E60E0 File Offset: 0x001E42E0
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00009F97 File Offset: 0x00008197
		internal virtual DataEntryGrid DataEntryGrid1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DataEntryGrid1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._DataEntryGrid1 = value;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x001E60F8 File Offset: 0x001E42F8
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x00009FA1 File Offset: 0x000081A1
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

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x001E6110 File Offset: 0x001E4310
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x001E6128 File Offset: 0x001E4328
		internal virtual UIButton UiButton2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiButton2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiButton2_Click);
				KeyEventHandler value3 = new KeyEventHandler(this.UiButton2_KeyDown);
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
					this._UiButton2.KeyDown -= value3;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
					this._UiButton2.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x001E61B0 File Offset: 0x001E43B0
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x001E61C8 File Offset: 0x001E43C8
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
				KeyEventHandler value3 = new KeyEventHandler(this.UiButton1_KeyDown);
				bool flag = this._UiButton1 != null;
				if (flag)
				{
					this._UiButton1.Click -= value2;
					this._UiButton1.KeyDown -= value3;
				}
				this._UiButton1 = value;
				flag = (this._UiButton1 != null);
				if (flag)
				{
					this._UiButton1.Click += value2;
					this._UiButton1.KeyDown += value3;
				}
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x001E6250 File Offset: 0x001E4450
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x00009FAB File Offset: 0x000081AB
		public DataTable dt_tedad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_tedad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_tedad = value;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x001E6268 File Offset: 0x001E4468
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x00009FB5 File Offset: 0x000081B5
		public DataTable dt_vazn
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_vazn;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_vazn = value;
			}
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x001E6280 File Offset: 0x001E4480
		// (set) Token: 0x06002840 RID: 10304 RVA: 0x00009FBF File Offset: 0x000081BF
		public bool Is_Kharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Is_Kharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Is_Kharid = value;
			}
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x001E6298 File Offset: 0x001E4498
		private void Frm_TedadKala_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.Left);
			if (flag)
			{
				this.UiButton2.Focus();
			}
			flag = (e.KeyCode == Keys.Right);
			if (flag)
			{
				this.UiButton1.Focus();
			}
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x001E62F4 File Offset: 0x001E44F4
		private void Frm_TedadKala_Load(object sender, EventArgs e)
		{
			bool flag = !this.Is_Kharid;
			if (flag)
			{
				this.UiButton2.Visible = false;
			}
			this.Grid_RizBar.DataSource = this.dt_tedad;
			this.DataEntryGrid1.DataSource = this.dt_vazn;
			this.dt_tedad.Columns.Add("ekhtelaf", typeof(decimal));
			try
			{
				IEnumerator enumerator = this.dt_tedad.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					dataRow["ekhtelaf"] = Operators.SubtractObject(dataRow["tedadsabt"], dataRow["tedad"]);
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
			this.dt_vazn.Columns.Add("ekhtelaf", typeof(decimal));
			try
			{
				IEnumerator enumerator2 = this.dt_vazn.Rows.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					DataRow dataRow2 = (DataRow)enumerator2.Current;
					dataRow2["ekhtelaf"] = Operators.SubtractObject(dataRow2["vaznsabt"], dataRow2["vazn"]);
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
			flag = (this.Height < 475);
			if (flag)
			{
				this.Height = 475;
			}
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00009FC9 File Offset: 0x000081C9
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00003A26 File Offset: 0x00001C26
		private void UiButton1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x001E64B0 File Offset: 0x001E46B0
		private void UiButton1_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Left;
			if (flag)
			{
				this.UiButton2.Focus();
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x001E64DC File Offset: 0x001E46DC
		private void UiButton2_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Right;
			if (flag)
			{
				this.UiButton1.Focus();
			}
		}

		// Token: 0x04000FAF RID: 4015
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000FB1 RID: 4017
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000FB2 RID: 4018
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000FB3 RID: 4019
		[AccessedThroughProperty("PictureBox1")]
		private PictureBox _PictureBox1;

		// Token: 0x04000FB4 RID: 4020
		[AccessedThroughProperty("Grid_RizBar")]
		private DataEntryGrid _Grid_RizBar;

		// Token: 0x04000FB5 RID: 4021
		[AccessedThroughProperty("DataEntryGrid1")]
		private DataEntryGrid _DataEntryGrid1;

		// Token: 0x04000FB6 RID: 4022
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000FB7 RID: 4023
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000FB8 RID: 4024
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000FB9 RID: 4025
		[CompilerGenerated]
		private DataTable _dt_tedad;

		// Token: 0x04000FBA RID: 4026
		[CompilerGenerated]
		private DataTable _dt_vazn;

		// Token: 0x04000FBB RID: 4027
		[CompilerGenerated]
		private bool _Is_Kharid;
	}
}
