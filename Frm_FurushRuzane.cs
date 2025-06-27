using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	// Token: 0x020000F6 RID: 246
	[DesignerGenerated]
	public partial class Frm_FurushRuzane : Form
	{
		// Token: 0x06001D09 RID: 7433 RVA: 0x00156F54 File Offset: 0x00155154
		public Frm_FurushRuzane()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_BastanSandug_KeyDown);
			base.Load += new EventHandler(this.Frm_BastanSandug_Load);
			Frm_FurushRuzane.__ENCAddToList(this);
			this.sum_daryaft = 0L;
			this.sum_pardakht = 0L;
			this.sum_kart = 0L;
			this.avaldore = false;
			this.sandug = new Sandugh();
			this.InitializeComponent();
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00156FCC File Offset: 0x001551CC
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_FurushRuzane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_FurushRuzane.__ENCList.Count == Frm_FurushRuzane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_FurushRuzane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_FurushRuzane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_FurushRuzane.__ENCList[num] = Frm_FurushRuzane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_FurushRuzane.__ENCList.RemoveRange(num, Frm_FurushRuzane.__ENCList.Count - num);
						Frm_FurushRuzane.__ENCList.Capacity = Frm_FurushRuzane.__ENCList.Count;
					}
					Frm_FurushRuzane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x001577F8 File Offset: 0x001559F8
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x00007FC0 File Offset: 0x000061C0
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

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00157810 File Offset: 0x00155A10
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x00157828 File Offset: 0x00155A28
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
				EventHandler value2 = new EventHandler(this.CurrencyBox1_TextChanged);
				bool flag = this._txt_mablagh != null;
				if (flag)
				{
					this._txt_mablagh.TextChanged -= value2;
				}
				this._txt_mablagh = value;
				flag = (this._txt_mablagh != null);
				if (flag)
				{
					this._txt_mablagh.TextChanged += value2;
				}
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00157888 File Offset: 0x00155A88
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x00007FCA File Offset: 0x000061CA
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

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x001578A0 File Offset: 0x00155AA0
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x001578B8 File Offset: 0x00155AB8
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

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00157918 File Offset: 0x00155B18
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x00157930 File Offset: 0x00155B30
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

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00157990 File Offset: 0x00155B90
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x00007FD4 File Offset: 0x000061D4
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

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x001579A8 File Offset: 0x00155BA8
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x00007FDE File Offset: 0x000061DE
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

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x001579C0 File Offset: 0x00155BC0
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x00007FE8 File Offset: 0x000061E8
		public string Tarikh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tarikh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tarikh = value;
			}
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_BastanSandug_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x001579D8 File Offset: 0x00155BD8
		private void Frm_BastanSandug_Load(object sender, EventArgs e)
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select isnull(mablagh,0) from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + " and dptype_id=35"));
			this.txt_mablagh.Text = text;
			string right = Conversions.ToString(Public_Function.ExecuteScalar("select top 1 tarikh_fa from sud order by tarikh_fa desc"));
			bool flag = Operators.CompareString(this.Tarikh, right, false) <= 0;
			if (flag)
			{
				this.txt_mablagh.Enabled = false;
			}
			else
			{
				this.txt_mablagh.Enabled = true;
			}
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00003A26 File Offset: 0x00001C26
		private void UiButton2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00157A64 File Offset: 0x00155C64
		private void UiButton1_Click(object sender, EventArgs e)
		{
			string text = Conversions.ToString(Public_Function.ExecuteScalar("select id from daryaftpardakht where tarikh=" + Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh)) + " and dptype_id=35"));
			bool flag = Operators.CompareString(this.txt_mablagh.Text, string.Empty, false) == 0;
			if (flag)
			{
				bool flag2 = text != null;
				if (flag2)
				{
					Public_Function.ExecuteNonQuery("delete from daryaftpardakht where id=" + text);
				}
				this.Close();
			}
			else
			{
				bool flag2 = text != null;
				if (flag2)
				{
					string arg_B1_0 = "update daryaftpardakht set mablagh=";
					long? value = this.txt_mablagh.Value;
					Public_Function.ExecuteNonQuery(arg_B1_0 + (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null) + " where id=" + text);
				}
				else
				{
					string[] array = new string[7];
					array[0] = "insert into daryaftpardakht (dptype_id,mablagh,tarikh,tarikh_fa) values(35,";
					string[] arg_F8_0 = array;
					int arg_F8_1 = 1;
					long? value = this.txt_mablagh.Value;
					arg_F8_0[arg_F8_1] = (value.HasValue ? Conversions.ToString(value.GetValueOrDefault()) : null);
					array[2] = ",";
					array[3] = Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.Tarikh));
					array[4] = ",";
					array[5] = Public_Function.GetValue(this.Tarikh);
					array[6] = ")";
					Public_Function.ExecuteNonQuery(string.Concat(array));
				}
				this.Close();
			}
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x00157BC0 File Offset: 0x00155DC0
		private void CurrencyBox1_TextChanged(object sender, EventArgs e)
		{
			bool hasValue = this.txt_mablagh.Value.HasValue;
			if (hasValue)
			{
				this.Label6.Text = huruf.ConvertToHuruf(Conversions.ToString((T)this.txt_mablagh.Value), huruf.ConvertType.ریال);
			}
		}

		// Token: 0x04000B49 RID: 2889
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000B4B RID: 2891
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000B4C RID: 2892
		[AccessedThroughProperty("txt_mablagh")]
		private CurrencyBox _txt_mablagh;

		// Token: 0x04000B4D RID: 2893
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000B4E RID: 2894
		[AccessedThroughProperty("UiButton2")]
		private UIButton _UiButton2;

		// Token: 0x04000B4F RID: 2895
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x04000B50 RID: 2896
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000B51 RID: 2897
		[AccessedThroughProperty("UiGroupBox2")]
		private UIGroupBox _UiGroupBox2;

		// Token: 0x04000B52 RID: 2898
		private long sum_daryaft;

		// Token: 0x04000B53 RID: 2899
		private long sum_pardakht;

		// Token: 0x04000B54 RID: 2900
		private long sum_kart;

		// Token: 0x04000B55 RID: 2901
		private long ruzegabl;

		// Token: 0x04000B56 RID: 2902
		private long mande;

		// Token: 0x04000B57 RID: 2903
		private bool avaldore;

		// Token: 0x04000B58 RID: 2904
		private Sandugh sandug;

		// Token: 0x04000B59 RID: 2905
		[CompilerGenerated]
		private string _Tarikh;
	}
}
