using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using FruitBox.My.Resources;
using Janus.Windows.Common.Layouts;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Kavenegar.SDK;
using Kavenegar.SDK.Models;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000110 RID: 272
	[DesignerGenerated]
	public partial class Frm_sms_ruzane : Form
	{
		// Token: 0x0600271C RID: 10012 RVA: 0x00009B7D File Offset: 0x00007D7D
		[DebuggerNonUserCode]
		public Frm_sms_ruzane()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_sms_ruzane_KeyDown);
			base.Load += new EventHandler(this.Frm_sms_ruzane_Load);
			Frm_sms_ruzane.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x001DA0D8 File Offset: 0x001D82D8
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_sms_ruzane.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_sms_ruzane.__ENCList.Count == Frm_sms_ruzane.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_sms_ruzane.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_sms_ruzane.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_sms_ruzane.__ENCList[num] = Frm_sms_ruzane.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_sms_ruzane.__ENCList.RemoveRange(num, Frm_sms_ruzane.__ENCList.Count - num);
						Frm_sms_ruzane.__ENCList.Capacity = Frm_sms_ruzane.__ENCList.Count;
					}
					Frm_sms_ruzane.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x001DABB8 File Offset: 0x001D8DB8
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x00009BBD File Offset: 0x00007DBD
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x001DABD0 File Offset: 0x001D8DD0
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x00009BC7 File Offset: 0x00007DC7
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x001DABE8 File Offset: 0x001D8DE8
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x001DAC00 File Offset: 0x001D8E00
		internal virtual DateBox2 txt_tarikh_vurud
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_tarikh_vurud;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_tarikh_vurud_Validated);
				bool flag = this._txt_tarikh_vurud != null;
				if (flag)
				{
					this._txt_tarikh_vurud.Validated -= value2;
				}
				this._txt_tarikh_vurud = value;
				flag = (this._txt_tarikh_vurud != null);
				if (flag)
				{
					this._txt_tarikh_vurud.Validated += value2;
				}
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x001DAC60 File Offset: 0x001D8E60
		// (set) Token: 0x06002727 RID: 10023 RVA: 0x00009BD1 File Offset: 0x00007DD1
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

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002728 RID: 10024 RVA: 0x001DAC78 File Offset: 0x001D8E78
		// (set) Token: 0x06002729 RID: 10025 RVA: 0x001DAC90 File Offset: 0x001D8E90
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

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x0600272A RID: 10026 RVA: 0x001DACF0 File Offset: 0x001D8EF0
		// (set) Token: 0x0600272B RID: 10027 RVA: 0x00009BDB File Offset: 0x00007DDB
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
				this._GridEX1 = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x001DAD08 File Offset: 0x001D8F08
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x001DAD20 File Offset: 0x001D8F20
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x001DAD80 File Offset: 0x001D8F80
		// (set) Token: 0x0600272F RID: 10031 RVA: 0x001DAD98 File Offset: 0x001D8F98
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
				EventHandler value2 = new EventHandler(this.EditBox1_TextChanged);
				bool flag = this._EditBox1 != null;
				if (flag)
				{
					this._EditBox1.TextChanged -= value2;
				}
				this._EditBox1 = value;
				flag = (this._EditBox1 != null);
				if (flag)
				{
					this._EditBox1.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002730 RID: 10032 RVA: 0x001DADF8 File Offset: 0x001D8FF8
		// (set) Token: 0x06002731 RID: 10033 RVA: 0x00009BE5 File Offset: 0x00007DE5
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

		// Token: 0x06002732 RID: 10034 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_sms_ruzane_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x001DAE10 File Offset: 0x001D9010
		private void getdata()
		{
			DataTable dataSource = Public_Function.FillData(string.Concat(new string[]
			{
				"SELECT     Furush_Hag_Detail.ID, Furush_Hag_Detail.Furush_Hug_ID, Furush_Hag_Detail.Moshtari_ID, Furush_Hag_Detail.Kala_ID, Furush_Hag_Detail.Tarikh,                         Furush_Hag_Detail.Tarikh_Fa, Furush_Hag_Detail.Tedad, Furush_Hag_Detail.Vazn_Ba_Zarf, Furush_Hag_Detail.Zarf, Furush_Hag_Detail.Vazn_Kol,                         Furush_Hag_Detail.Fee, Furush_Hag_Detail.Jam_Kol, Kala.Name AS kala_name, Moshtari.Name + ' ' + Moshtari.Family AS moshtari_name,cast ( Furush_Hag.Num as nvarchar(10)) +' / فروش' as num , Moshtari.Tel2  FROM         Furush_Hag_Detail INNER JOIN                        Kala ON Furush_Hag_Detail.Kala_ID = Kala.ID INNER JOIN                        Moshtari ON Furush_Hag_Detail.Moshtari_ID = Moshtari.ID INNER JOIN                        Furush_Hag ON Furush_Hag_Detail.Furush_Hug_ID = Furush_Hag.ID  WHERE     (Furush_Hag_Detail.Moshtari_ID <> - 1) AND (Furush_Hag_Detail.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh_vurud.Text)),
				")             union all   SELECT     Kharid_Furush.ID, Kharid_Furush.Kharid_ID, Kharid_Furush.Moshtari_ID, Kharid_Furush.Kala_ID, Kharid_Furush.Tarikh, Kharid_Furush.Tarikh_Fa,                         Kharid_Furush.Tedad, Kharid_Furush.Vazn_Ba_Zarf, Kharid_Furush.Zarf, Kharid_Furush.Vazn_Kol, Kharid_Furush.Fee, Kharid_Furush.Jam_Kol, Kala.Name as kala_name,                         Moshtari.Name +' '+ Moshtari.Family as moshtari_name,cast (Kharid.Num as nvarchar(10)) +' / خرید' as num , Moshtari.Tel2  FROM         Kharid_Furush INNER JOIN                        Kala ON Kharid_Furush.Kala_ID = Kala.ID INNER JOIN                        Kharid ON Kharid_Furush.Kharid_ID = Kharid.ID INNER JOIN                        Moshtari ON Kharid_Furush.Moshtari_ID = Moshtari.ID                          where Kharid_Furush.moshtari_id<>-1   AND (Kharid_Furush.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh_vurud.Text)),
				")                           union all                       SELECT     Furush_Sardkhane_Detail.ID, Furush_Sardkhane_Detail.Furush_Sardkhane_ID, Furush_Sardkhane_Detail.Moshtari_ID, Furush_Sardkhane_Detail.Kala_ID,                         Furush_Sardkhane_Detail.Tarikh, Furush_Sardkhane_Detail.Tarikh_Fa, Furush_Sardkhane_Detail.Tedad, Furush_Sardkhane_Detail.Vazn_Ba_Zarf,                         Furush_Sardkhane_Detail.Zarf, Furush_Sardkhane_Detail.Vazn_Kol, Furush_Sardkhane_Detail.Fee, Furush_Sardkhane_Detail.Jam_Kol, Kala.Name as kala_name,                         Moshtari.Name +' '+ Moshtari.Family as moshtari_name,cast( Furush_Sardkhane.Num as nvarchar(10)) +' / فروش سردخانه' as num , Moshtari.Tel2  FROM         Furush_Sardkhane_Detail INNER JOIN                        Furush_Sardkhane ON Furush_Sardkhane_Detail.Furush_Sardkhane_ID = Furush_Sardkhane.ID INNER JOIN                        Kala ON Furush_Sardkhane_Detail.Kala_ID = Kala.ID INNER JOIN                        Moshtari ON Furush_Sardkhane_Detail.Moshtari_ID = Moshtari.ID                           where moshtari_id<> -1 AND (Furush_Sardkhane_Detail.Tarikh = ",
				Public_Function.GetValue(Public_Function.ShamsiToMiladi(this.txt_tarikh_vurud.Text)),
				")"
			}));
			this.GridEX1.DataSource = dataSource;
			Public_Function.AddFilterColumn(this.GridEX1);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x00009BEF File Offset: 0x00007DEF
		private void EditBox1_TextChanged(object sender, EventArgs e)
		{
			Public_Function.FilterGrid(this.GridEX1, this.EditBox1.Text);
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00009C0A File Offset: 0x00007E0A
		private void Frm_sms_ruzane_Load(object sender, EventArgs e)
		{
			this.txt_tarikh_vurud.SetNew();
			this.getdata();
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x00009C21 File Offset: 0x00007E21
		private void txt_tarikh_vurud_Validated(object sender, EventArgs e)
		{
			this.getdata();
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x001DAEBC File Offset: 0x001D90BC
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			DataRowView dataRowView = (DataRowView)this.GridEX1.CurrentRow.DataRow;
			Frm_Moshtari frm_Moshtari = new Frm_Moshtari();
			Frm_Moshtari arg_3B_0 = frm_Moshtari;
			object expr_29 = dataRowView["moshtari_id"];
			int? num;
			arg_3B_0.ID = ((expr_29 != null) ? ((int?)expr_29) : num);
			bool flag = frm_Moshtari.ShowDialog() == DialogResult.OK;
			if (flag)
			{
				this.GridEX1.CurrentRow.Cells["tel2"].Value = frm_Moshtari.txt_tel2.Text;
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x001DAF44 File Offset: 0x001D9144
		private string GetMessage(GridEXRow row)
		{
			string text = string.Empty;
			text = Public_Function.dict["sms_titr"] + Environment.NewLine;
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(row.Cells["tarikh_fa"].Value, Environment.NewLine)));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("جنس:", row.Cells["kala_name"].Value), Environment.NewLine)));
			text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(Operators.ConcatenateObject("تعداد:", row.Cells["tedad"].Value), Environment.NewLine)));
			text = text + "وزن:" + row.Cells["vazn_kol"].Value.ToString().Replace(".0", "") + Environment.NewLine;
			return text + "قیمت:" + row.Cells["fee"].Value.ToString().Replace(".0", "");
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x001DB07C File Offset: 0x001D927C
		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict["sms_apikey"] == DBNull.Value || Operators.CompareString(Public_Function.dict["sms_apikey"].ToString().Trim(), string.Empty, false) == 0;
			checked
			{
				if (flag)
				{
					bool flag2 = Public_Function.ShowMessage("تنظیمات پیامک ثبت نگردیده است" + Environment.NewLine + "آیا مایل به ثبت تنظیمات پیامک میباشید؟", MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
					if (flag2)
					{
						Frm_Sms_Setting frm_Sms_Setting = new Frm_Sms_Setting();
						frm_Sms_Setting.ShowDialog();
					}
				}
				else
				{
					GridEXRow[] checkedRows = this.GridEX1.GetCheckedRows();
					for (int i = 0; i < checkedRows.Length; i++)
					{
						GridEXRow gridEXRow = checkedRows[i];
						bool flag2 = gridEXRow.Cells["tel2"].Value != DBNull.Value;
						if (flag2)
						{
							KavenegarApi kavenegarApi = new KavenegarApi(Public_Function.dict["sms_apikey"]);
							try
							{
								SendResult sendResult = kavenegarApi.Send(Public_Function.dict["sms_number"], Conversions.ToString(gridEXRow.Cells["tel2"].Value), this.GetMessage(gridEXRow));
							}
							catch (Exception expr_11C)
							{
								ProjectData.SetProjectError(expr_11C);
								Public_Function.ShowMessage("اینترنت وصل نمیباشد", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, null);
								ProjectData.ClearProjectError();
							}
						}
					}
				}
			}
		}

		// Token: 0x04000F45 RID: 3909
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000F47 RID: 3911
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04000F48 RID: 3912
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000F49 RID: 3913
		[AccessedThroughProperty("txt_tarikh_vurud")]
		private DateBox2 _txt_tarikh_vurud;

		// Token: 0x04000F4A RID: 3914
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000F4B RID: 3915
		[AccessedThroughProperty("ButtonItem7")]
		private ButtonItem _ButtonItem7;

		// Token: 0x04000F4C RID: 3916
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x04000F4D RID: 3917
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04000F4E RID: 3918
		[AccessedThroughProperty("EditBox1")]
		private EditBox _EditBox1;

		// Token: 0x04000F4F RID: 3919
		[AccessedThroughProperty("Label2")]
		private Label _Label2;
	}
}
