using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using FruitBox.My.Resources;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200011B RID: 283
	[DesignerGenerated]
	public partial class Frm_Check_Print : Form
	{
		// Token: 0x06002996 RID: 10646 RVA: 0x0000A421 File Offset: 0x00008621
		[DebuggerNonUserCode]
		public Frm_Check_Print()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_Check_Print_KeyDown);
			base.Load += new EventHandler(this.Frm_Check_Print_Load);
			Frm_Check_Print.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x001F6BE8 File Offset: 0x001F4DE8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Check_Print.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Check_Print.__ENCList.Count == Frm_Check_Print.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Check_Print.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Check_Print.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Check_Print.__ENCList[num] = Frm_Check_Print.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Check_Print.__ENCList.RemoveRange(num, Frm_Check_Print.__ENCList.Count - num);
						Frm_Check_Print.__ENCList.Capacity = Frm_Check_Print.__ENCList.Count;
					}
					Frm_Check_Print.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x001F73DC File Offset: 0x001F55DC
		// (set) Token: 0x0600299B RID: 10651 RVA: 0x0000A461 File Offset: 0x00008661
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x0600299C RID: 10652 RVA: 0x001F73F4 File Offset: 0x001F55F4
		// (set) Token: 0x0600299D RID: 10653 RVA: 0x001F740C File Offset: 0x001F560C
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

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x001F746C File Offset: 0x001F566C
		// (set) Token: 0x0600299F RID: 10655 RVA: 0x0000A46B File Offset: 0x0000866B
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x001F7484 File Offset: 0x001F5684
		// (set) Token: 0x060029A1 RID: 10657 RVA: 0x0000A475 File Offset: 0x00008675
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
				this._EditBox1 = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060029A2 RID: 10658 RVA: 0x001F749C File Offset: 0x001F569C
		// (set) Token: 0x060029A3 RID: 10659 RVA: 0x0000A47F File Offset: 0x0000867F
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

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x001F74B4 File Offset: 0x001F56B4
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x001F74CC File Offset: 0x001F56CC
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
				bool flag = this._UiButton2 != null;
				if (flag)
				{
					this._UiButton2.Click -= value2;
				}
				this._UiButton2 = value;
				flag = (this._UiButton2 != null);
				if (flag)
				{
					this._UiButton2.Click += value2;
				}
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x001F752C File Offset: 0x001F572C
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x0000A489 File Offset: 0x00008689
		public DataTable dt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x001F7544 File Offset: 0x001F5744
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x0000A493 File Offset: 0x00008693
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

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x001F755C File Offset: 0x001F575C
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0000A49D File Offset: 0x0000869D
		public string Tozih
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tozih;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tozih = value;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x001F7574 File Offset: 0x001F5774
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0000A4A7 File Offset: 0x000086A7
		public string moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._moshtari_id = value;
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x001F758C File Offset: 0x001F578C
		private void UiButton1_Click(object sender, EventArgs e)
		{
			switch (Conversions.ToInteger(Public_Function.ExecuteScalar("select kind from moshtari where id=" + this.moshtari_id)))
			{
			case 1:
			case 2:
				this.Moshtari_Name = " جناب آقای " + this.Moshtari_Name;
				break;
			case 3:
			case 4:
				this.Moshtari_Name = " شرکت " + this.Moshtari_Name;
				break;
			case 5:
			case 6:
				this.Moshtari_Name = " سرکارخانم " + this.Moshtari_Name;
				break;
			}
			checkprint checkprint = new checkprint
			{
				Moshtari_Name = this.Moshtari_Name
			};
			bool flag = !this.UiCheckBox1.Checked;
			if (flag)
			{
				this.dt.Rows[0]["tozih"] = this.EditBox1.Text;
			}
			else
			{
				this.dt.Rows[0]["tozih"] = this.Moshtari_Name + " " + this.EditBox1.Text;
			}
			checkprint.dt = this.dt;
			checkprint.ShowReport(false);
			this.Close();
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x001F76D4 File Offset: 0x001F58D4
		private void UiButton2_Click(object sender, EventArgs e)
		{
			switch (Conversions.ToInteger(Public_Function.ExecuteScalar("select kind from moshtari where id=" + this.moshtari_id)))
			{
			case 1:
			case 2:
				this.Moshtari_Name = " جناب آقای " + this.Moshtari_Name;
				break;
			case 3:
			case 4:
				this.Moshtari_Name = " شرکت " + this.Moshtari_Name;
				break;
			case 5:
			case 6:
				this.Moshtari_Name = " سرکارخانم " + this.Moshtari_Name;
				break;
			}
			checkprint checkprint = new checkprint
			{
				Moshtari_Name = this.Moshtari_Name
			};
			bool flag = !this.UiCheckBox1.Checked;
			if (flag)
			{
				this.dt.Rows[0]["tozih"] = this.EditBox1.Text;
			}
			else
			{
				this.dt.Rows[0]["tozih"] = this.Moshtari_Name + " " + this.EditBox1.Text;
			}
			checkprint.dt = this.dt;
			checkprint.ShowReport(true);
			this.Close();
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_Check_Print_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x0000A4B1 File Offset: 0x000086B1
		private void Frm_Check_Print_Load(object sender, EventArgs e)
		{
			this.EditBox1.Text = this.Tozih;
		}

		// Token: 0x0400103C RID: 4156
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x0400103E RID: 4158
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400103F RID: 4159
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04001040 RID: 4160
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001041 RID: 4161
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04001042 RID: 4162
		[AccessedThroughProperty("UiCheckBox1")]
		private UICheckBox _UiCheckBox1;

		// Token: 0x04001043 RID: 4163
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04001044 RID: 4164
		[CompilerGenerated]
		private DataTable _dt;

		// Token: 0x04001045 RID: 4165
		[CompilerGenerated]
		private string _Moshtari_Name;

		// Token: 0x04001046 RID: 4166
		[CompilerGenerated]
		private string _Tozih;

		// Token: 0x04001047 RID: 4167
		[CompilerGenerated]
		private string _moshtari_id;
	}
}
