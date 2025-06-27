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
using Janus.Windows.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000062 RID: 98
	[DesignerGenerated]
	public partial class Frm_Chap_Kharid : Form
	{
		// Token: 0x060006D2 RID: 1746 RVA: 0x000695F4 File Offset: 0x000677F4
		[DebuggerNonUserCode]
		public Frm_Chap_Kharid()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_ClearData_KeyDown);
			base.FormClosing += new FormClosingEventHandler(this.Frm_Chap_Kharid_FormClosing);
			base.Load += new EventHandler(this.Frm_Chap_Kharid_Load);
			Frm_Chap_Kharid.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00069654 File Offset: 0x00067854
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_Chap_Kharid.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_Chap_Kharid.__ENCList.Count == Frm_Chap_Kharid.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_Chap_Kharid.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_Chap_Kharid.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_Chap_Kharid.__ENCList[num] = Frm_Chap_Kharid.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_Chap_Kharid.__ENCList.RemoveRange(num, Frm_Chap_Kharid.__ENCList.Count - num);
						Frm_Chap_Kharid.__ENCList.Capacity = Frm_Chap_Kharid.__ENCList.Count;
					}
					Frm_Chap_Kharid.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00069ED8 File Offset: 0x000680D8
		// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00003001 File Offset: 0x00001201
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

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00069EF0 File Offset: 0x000680F0
		// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00069F08 File Offset: 0x00068108
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

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x00069F68 File Offset: 0x00068168
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0000300B File Offset: 0x0000120B
		internal virtual UICheckBox txt_rizkharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_rizkharid;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_rizkharid = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00069F80 File Offset: 0x00068180
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x00003015 File Offset: 0x00001215
		internal virtual UICheckBox txt_sherakat
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_sherakat;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txt_sherakat = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x00069F98 File Offset: 0x00068198
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0000301F File Offset: 0x0000121F
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

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x00069FB0 File Offset: 0x000681B0
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00003029 File Offset: 0x00001229
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

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00069FC8 File Offset: 0x000681C8
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00003033 File Offset: 0x00001233
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

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00069FE0 File Offset: 0x000681E0
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0000303D File Offset: 0x0000123D
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

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00069FF8 File Offset: 0x000681F8
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00003047 File Offset: 0x00001247
		public long Kharid_num
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kharid_num;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kharid_num = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x0006A010 File Offset: 0x00068210
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00003051 File Offset: 0x00001251
		public int NahveKharid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NahveKharid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._NahveKharid = value;
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0006A028 File Offset: 0x00068228
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x0000305B File Offset: 0x0000125B
		public string Jam_Furush
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Jam_Furush;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Jam_Furush = value;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x0006A040 File Offset: 0x00068240
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00003065 File Offset: 0x00001265
		public string Jam_Daramad
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Jam_Daramad;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Jam_Daramad = value;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x0006A058 File Offset: 0x00068258
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0000306F File Offset: 0x0000126F
		public string Makharej
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Makharej;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Makharej = value;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0006A070 File Offset: 0x00068270
		private void RemoveZero(DataTable dt)
		{
			try
			{
				IEnumerator enumerator = dt.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					bool flag = dataRow["tedad"] != DBNull.Value;
					if (flag)
					{
						dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
					}
					flag = (dataRow["zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["zarf"] = dataRow["zarf"].ToString().Replace(".00", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".00", "");
					}
					flag = (dataRow["vazn_kol"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_kol"] = dataRow["vazn_kol"].ToString().Replace(".0", "");
					}
					flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
					if (flag)
					{
						dataRow["vazn_ba_zarf"] = dataRow["vazn_ba_zarf"].ToString().Replace(".0", "");
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				bool flag = enumerator is IDisposable;
				if (flag)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0006A244 File Offset: 0x00068444
		private string GetMoshtari_Name()
		{
			DataTable dt = Public_Function.FillData("SELECT distinct Kharid_Detail.moshtari_id,Moshtari.name +' '+ Moshtari.Family as moshtari_name  FROM [Kharid]  inner join Kharid_Detail  on Kharid.ID=Kharid_Detail.Kharid_ID  inner join Moshtari  on Kharid_Detail.moshtari_id=Moshtari.ID  where num=" + Conversions.ToString(this.Kharid_num));
			return Public_Function.GetID(dt, "moshtari_name", "");
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0006A284 File Offset: 0x00068484
		private void Render(StiReport rpt, StiHeaderBand stiheader, StiDataBand stidata_band, StiFooterBand sti_footer)
		{
			Dictionary<string, double> dictionary = new Dictionary<string, double>();
			double width = stiheader.Width;
			double num = (width - 7.47) * 100.0 / 7.47;
			double num2 = 0.0;
			bool flag;
			try
			{
				IEnumerator enumerator = stiheader.Components.GetEnumerator();
				while (enumerator.MoveNext())
				{
					StiComponent stiComponent = (StiComponent)enumerator.Current;
					dictionary.Add(stiComponent.Name, (stiComponent.Width + stiComponent.Width * num / 100.0) * 100.0 / width);
					StiComponent stiComponent2 = stiComponent;
					stiComponent2.Width += stiComponent.Width * num / 100.0;
					flag = !stiComponent.Enabled;
					if (flag)
					{
						double num3 = stiComponent.Width * 100.0 / width;
						num2 += stiComponent.Width + stiComponent.Width * num3 / 100.0;
					}
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
			try
			{
				IEnumerator enumerator2 = stiheader.Components.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					StiComponent stiComponent3 = (StiComponent)enumerator2.Current;
					flag = stiComponent3.Enabled;
					if (flag)
					{
						StiComponent stiComponent2 = stiComponent3;
						stiComponent2.Width += num2 * dictionary[stiComponent3.Name] / 100.0;
					}
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
			double num4 = 0.0;
			try
			{
				IEnumerator enumerator3 = stiheader.Components.GetEnumerator();
				while (enumerator3.MoveNext())
				{
					StiComponent stiComponent4 = (StiComponent)enumerator3.Current;
					flag = stiComponent4.Enabled;
					if (flag)
					{
						num4 += stiComponent4.Width;
					}
				}
			}
			finally
			{
				IEnumerator enumerator3;
				flag = (enumerator3 is IDisposable);
				if (flag)
				{
					(enumerator3 as IDisposable).Dispose();
				}
			}
			flag = (num4 < width);
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator4 = stiheader.Components.GetEnumerator();
					while (enumerator4.MoveNext())
					{
						StiComponent stiComponent5 = (StiComponent)enumerator4.Current;
						flag2 = stiComponent5.Enabled;
						if (flag2)
						{
							StiComponent stiComponent2 = stiComponent5;
							stiComponent2.Width += width - num4;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					flag2 = (enumerator4 is IDisposable);
					if (flag2)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
			}
			dictionary.Clear();
			width = stidata_band.Width;
			num2 = 0.0;
			num4 = 0.0;
			try
			{
				IEnumerator enumerator5 = stidata_band.Components.GetEnumerator();
				while (enumerator5.MoveNext())
				{
					StiComponent stiComponent6 = (StiComponent)enumerator5.Current;
					dictionary.Add(stiComponent6.Name, (stiComponent6.Width + stiComponent6.Width * num / 100.0) * 100.0 / width);
					StiComponent stiComponent2 = stiComponent6;
					stiComponent2.Width += stiComponent6.Width * num / 100.0;
					flag2 = !stiComponent6.Enabled;
					if (flag2)
					{
						double num3 = stiComponent6.Width * 100.0 / width;
						num2 += stiComponent6.Width + stiComponent6.Width * num3 / 100.0;
					}
				}
			}
			finally
			{
				IEnumerator enumerator5;
				flag2 = (enumerator5 is IDisposable);
				if (flag2)
				{
					(enumerator5 as IDisposable).Dispose();
				}
			}
			try
			{
				IEnumerator enumerator6 = stidata_band.Components.GetEnumerator();
				while (enumerator6.MoveNext())
				{
					StiComponent stiComponent7 = (StiComponent)enumerator6.Current;
					flag2 = stiComponent7.Enabled;
					if (flag2)
					{
						StiComponent stiComponent2 = stiComponent7;
						stiComponent2.Width += num2 * dictionary[stiComponent7.Name] / 100.0;
					}
				}
			}
			finally
			{
				IEnumerator enumerator6;
				flag2 = (enumerator6 is IDisposable);
				if (flag2)
				{
					(enumerator6 as IDisposable).Dispose();
				}
			}
			try
			{
				IEnumerator enumerator7 = stidata_band.Components.GetEnumerator();
				while (enumerator7.MoveNext())
				{
					StiComponent stiComponent8 = (StiComponent)enumerator7.Current;
					flag2 = stiComponent8.Enabled;
					if (flag2)
					{
						num4 += stiComponent8.Width;
					}
				}
			}
			finally
			{
				IEnumerator enumerator7;
				flag2 = (enumerator7 is IDisposable);
				if (flag2)
				{
					(enumerator7 as IDisposable).Dispose();
				}
			}
			flag2 = (num4 < width);
			if (flag2)
			{
				try
				{
					IEnumerator enumerator8 = stidata_band.Components.GetEnumerator();
					while (enumerator8.MoveNext())
					{
						StiComponent stiComponent9 = (StiComponent)enumerator8.Current;
						flag = stiComponent9.Enabled;
						if (flag)
						{
							StiComponent stiComponent2 = stiComponent9;
							stiComponent2.Width += width - num4;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator8;
					flag2 = (enumerator8 is IDisposable);
					if (flag2)
					{
						(enumerator8 as IDisposable).Dispose();
					}
				}
			}
			flag2 = (sti_footer != null);
			if (flag2)
			{
				dictionary.Clear();
				width = sti_footer.Width;
				num2 = 0.0;
				num4 = 0.0;
				try
				{
					IEnumerator enumerator9 = sti_footer.Components.GetEnumerator();
					while (enumerator9.MoveNext())
					{
						StiComponent stiComponent10 = (StiComponent)enumerator9.Current;
						dictionary.Add(stiComponent10.Name, (stiComponent10.Width + stiComponent10.Width * num / 100.0) * 100.0 / width);
						StiComponent stiComponent2 = stiComponent10;
						stiComponent2.Width += stiComponent10.Width * num / 100.0;
						flag2 = !stiComponent10.Enabled;
						if (flag2)
						{
							double num3 = stiComponent10.Width * 100.0 / width;
							num2 += stiComponent10.Width + stiComponent10.Width * num3 / 100.0;
						}
					}
				}
				finally
				{
					IEnumerator enumerator9;
					flag2 = (enumerator9 is IDisposable);
					if (flag2)
					{
						(enumerator9 as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator10 = sti_footer.Components.GetEnumerator();
					while (enumerator10.MoveNext())
					{
						StiComponent stiComponent11 = (StiComponent)enumerator10.Current;
						flag2 = stiComponent11.Enabled;
						if (flag2)
						{
							StiComponent stiComponent2 = stiComponent11;
							stiComponent2.Width += num2 * dictionary[stiComponent11.Name] / 100.0;
						}
					}
				}
				finally
				{
					IEnumerator enumerator10;
					flag2 = (enumerator10 is IDisposable);
					if (flag2)
					{
						(enumerator10 as IDisposable).Dispose();
					}
				}
				try
				{
					IEnumerator enumerator11 = sti_footer.Components.GetEnumerator();
					while (enumerator11.MoveNext())
					{
						StiComponent stiComponent12 = (StiComponent)enumerator11.Current;
						flag2 = stiComponent12.Enabled;
						if (flag2)
						{
							num4 += stiComponent12.Width;
						}
					}
				}
				finally
				{
					IEnumerator enumerator11;
					flag2 = (enumerator11 is IDisposable);
					if (flag2)
					{
						(enumerator11 as IDisposable).Dispose();
					}
				}
				flag2 = (num4 < width);
				if (flag2)
				{
					try
					{
						IEnumerator enumerator12 = sti_footer.Components.GetEnumerator();
						while (enumerator12.MoveNext())
						{
							StiComponent stiComponent13 = (StiComponent)enumerator12.Current;
							flag = stiComponent13.Enabled;
							if (flag)
							{
								StiComponent stiComponent2 = stiComponent13;
								stiComponent2.Width += width - num4;
								break;
							}
						}
					}
					finally
					{
						IEnumerator enumerator12;
						flag2 = (enumerator12 is IDisposable);
						if (flag2)
						{
							(enumerator12 as IDisposable).Dispose();
						}
					}
				}
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0006AB50 File Offset: 0x00068D50
		private void UiButton1_Click(object sender, EventArgs e)
		{
			Kharid kharid = new Kharid();
			Kharid_Detail kharid_Detail = new Kharid_Detail();
			Kharid_Darsad kharid_Darsad = new Kharid_Darsad();
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\kharid.mrt");
			DataRow byID = kharid.GetByID(this.Kharid_num);
			bool flag = this.UiRadioButton3.Checked;
			DataTable dataTable;
			StiText stiText;
			if (flag)
			{
				dataTable = kharid.GetDetailByID(Conversions.ToLong(byID["ID"]));
			}
			else
			{
				flag = this.UiRadioButton1.Checked;
				if (flag)
				{
					dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT        Kharid_Furush.Kala_ID, SUM(Kharid_Furush.Tedad) AS Tedad, SUM(Kharid_Furush.Vazn_Ba_Zarf) AS Vazn_Ba_Zarf,  SUM(Kharid_Furush.Vazn_Kol) AS Vazn_Kol, SUM(Kharid_Furush.Jam_Kol) AS Jam_Kol    , case when SUM(Kharid_Furush.Vazn_Kol) <>0 then  cast ( SUM(Kharid_Furush.Jam_Kol)   / isnull( SUM(Kharid_Furush.Vazn_Kol),1) as bigint )  else cast( SUM(Kharid_Furush.Jam_Kol)   / isnull( SUM(Kharid_Furush.Tedad),1)as bigint)  end  AS Fee,0 as Zarf , MIN(Kala.Name) AS Kala_Name   FROM            Kharid_Furush INNER JOIN   Kala ON Kharid_Furush.Kala_ID = Kala.ID   WHERE Kharid_Furush.Kharid_ID = ", byID["ID"]), " GROUP BY Kharid_Furush.Kala_ID ")));
					stiText = (StiText)stiReport.GetComponentByName("Text5");
					stiText.Enabled = false;
					stiText = (StiText)stiReport.GetComponentByName("Text14");
					stiText.Enabled = false;
					stiText = (StiText)stiReport.GetComponentByName("Text6");
					stiText.Enabled = false;
					stiText = (StiText)stiReport.GetComponentByName("Text15");
					stiText.Enabled = false;
					stiText = (StiText)stiReport.GetComponentByName("Text47");
					stiText.Enabled = false;
					stiText = (StiText)stiReport.GetComponentByName("Text63");
					stiText.Enabled = false;
				}
				else
				{
					flag = this.UiRadioButton4.Checked;
					if (flag)
					{
						dataTable = Public_Function.FillData(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("SELECT     Kharid_Furush.Kala_ID,sum( Kharid_Furush.Tedad) AS Tedad,isnull(sum( Kharid_Furush.Vazn_Ba_Zarf) ,NULL) as  Vazn_Ba_Zarf,isnull(sum( Kharid_Furush.Zarf),NULL) AS Zarf,   isnull(sum(Kharid_Furush.Vazn_Kol),null) AS Vazn_Kol, Kharid_Furush.Fee,sum( Kharid_Furush.Jam_Kol) AS Jam_Kol,max( Kala.Name )AS Kala_Name   FROM         Kharid_Furush INNER JOIN   Kala ON Kharid_Furush.Kala_ID = Kala.ID    WHERE Kharid_Furush.kharid_id =", byID["ID"]), " group by Kala_ID,Fee order by kala_id asc,fee desc")));
						dataTable.TableName = "data";
						try
						{
							IEnumerator enumerator = dataTable.Rows.GetEnumerator();
							while (enumerator.MoveNext())
							{
								DataRow dataRow = (DataRow)enumerator.Current;
								flag = (dataRow["tedad"] != DBNull.Value);
								if (flag)
								{
									dataRow["tedad"] = dataRow["tedad"].ToString().Replace(".0", "");
								}
								flag = (dataRow["vazn_ba_zarf"] != DBNull.Value);
								if (flag)
								{
									dataRow["Vazn_ba_Zarf"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_ba_Zarf"]));
								}
								flag = (dataRow["vazn_kol"] != DBNull.Value);
								if (flag)
								{
									dataRow["Vazn_Kol"] = Public_Function.GetDecimalValue(Conversions.ToDecimal(dataRow["Vazn_Kol"]));
								}
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
						stiText = (StiText)stiReport.GetComponentByName("Text5");
						stiText.Enabled = false;
						stiText = (StiText)stiReport.GetComponentByName("Text14");
						stiText.Enabled = false;
						stiText = (StiText)stiReport.GetComponentByName("Text6");
						stiText.Enabled = false;
						stiText = (StiText)stiReport.GetComponentByName("Text15");
						stiText.Enabled = false;
						stiText = (StiText)stiReport.GetComponentByName("Text47");
						stiText.Enabled = false;
						stiText = (StiText)stiReport.GetComponentByName("Text63");
						stiText.Enabled = false;
					}
				}
			}
			DataTable byID2 = kharid_Detail.GetByID(Conversions.ToInteger(byID["ID"]));
			DataTable byID3 = kharid_Darsad.GetByID(Conversions.ToInteger(byID["ID"]));
			this.RemoveZero(dataTable);
			dataTable.AcceptChanges();
			dataTable.AcceptChanges();
			dataTable.TableName = "data";
			byID2.TableName = "rizbar";
			byID3.TableName = "sherakat";
			this.RemoveZero(byID2);
			stiReport.RegData(dataTable);
			stiReport.RegData(byID2);
			stiReport.RegData(byID3);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.SetHeader(stiReport, false);
			stiText = (StiText)stiReport.GetComponentByName("Text2");
			stiText.Text = byID["num"].ToString();
			stiText = (StiText)stiReport.GetComponentByName("Text4");
			stiText.Text = this.GetMoshtari_Name();
			stiText = (StiText)stiReport.GetComponentByName("Text26");
			stiText.Text = byID["Sh_Mashin"].ToString();
			stiText = (StiText)stiReport.GetComponentByName("Text27");
			stiText.Text = byID["Sh_Barname"].ToString();
			stiText = (StiText)stiReport.GetComponentByName("Text28");
			stiText.Text = byID["Tarikh_Vurud"].ToString();
			stiText = (StiText)stiReport.GetComponentByName("txt_jamfurush");
			stiText.Text = this.Jam_Furush;
			stiText = (StiText)stiReport.GetComponentByName("txt_daramad");
			stiText.Text = this.Jam_Daramad;
			stiText = (StiText)stiReport.GetComponentByName("txt_hazine");
			stiText.Text = this.Makharej;
			Public_Function.AddTazminText(stiReport, true, false);
			flag = !this.txt_rizkharid.Checked;
			if (flag)
			{
				StiHeaderBand stiHeaderBand = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand4");
				stiHeaderBand.Enabled = false;
				stiHeaderBand = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand2");
				stiHeaderBand.Enabled = false;
				StiDataBand stiDataBand = (StiDataBand)stiReport.GetComponentByName("DataBand2");
				stiDataBand.Enabled = false;
			}
			flag = !this.txt_sherakat.Checked;
			if (flag)
			{
				StiHeaderBand stiHeaderBand2 = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand5");
				stiHeaderBand2.Enabled = false;
				stiHeaderBand2 = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand6");
				stiHeaderBand2.Enabled = false;
				StiDataBand stiDataBand2 = (StiDataBand)stiReport.GetComponentByName("DataBand3");
				stiDataBand2.Enabled = false;
			}
			int nahveKharid = this.NahveKharid;
			flag = (nahveKharid == 1);
			if (flag)
			{
				stiText = (StiText)stiReport.GetComponentByName("Text31");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text42");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text39");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text51");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text9");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text10");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text18");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text19");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text45");
				stiText.Enabled = false;
				stiText = (StiText)stiReport.GetComponentByName("Text32");
				stiText.Enabled = false;
			}
			StiHeaderBand stiheader = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand2");
			StiFooterBand sti_footer = new StiFooterBand();
			StiDataBand stidata_band = (StiDataBand)stiReport.GetComponentByName("DataBand2");
			this.Render(stiReport, stiheader, stidata_band, null);
			stiheader = (StiHeaderBand)stiReport.GetComponentByName("HeaderBand1");
			stidata_band = (StiDataBand)stiReport.GetComponentByName("DataBand1");
			sti_footer = (StiFooterBand)stiReport.GetComponentByName("FooterBand1");
			this.Render(stiReport, stiheader, stidata_band, sti_footer);
			stiReport.Print(false);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_ClearData_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0006B380 File Offset: 0x00069580
		private void Frm_Chap_Kharid_FormClosing(object sender, FormClosingEventArgs e)
		{
			string text = string.Empty;
			bool @checked = this.txt_rizkharid.Checked;
			if (@checked)
			{
				text = "1;";
			}
			else
			{
				text = "0;";
			}
			@checked = this.txt_sherakat.Checked;
			if (@checked)
			{
				text += "1;";
			}
			else
			{
				text += "0;";
			}
			@checked = this.UiRadioButton1.Checked;
			if (@checked)
			{
				text += "1;";
			}
			@checked = this.UiRadioButton3.Checked;
			if (@checked)
			{
				text += "2;";
			}
			@checked = this.UiRadioButton4.Checked;
			if (@checked)
			{
				text += "3;";
			}
			setting setting = new setting();
			setting.Update("chap_kharid", text);
			Public_Function.dict["chap_kharid"] = text;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0006B458 File Offset: 0x00069658
		private void Frm_Chap_Kharid_Load(object sender, EventArgs e)
		{
			bool flag = Public_Function.dict.ContainsKey("chap_kharid");
			if (flag)
			{
				string[] array = Public_Function.dict["chap_kharid"].Split(new char[]
				{
					';'
				});
				flag = (Operators.CompareString(array[0], "1", false) == 0);
				if (flag)
				{
					this.txt_rizkharid.Checked = true;
				}
				else
				{
					this.txt_rizkharid.Checked = false;
				}
				flag = (Operators.CompareString(array[1], "1", false) == 0);
				if (flag)
				{
					this.txt_sherakat.Checked = true;
				}
				else
				{
					this.txt_sherakat.Checked = false;
				}
				flag = (Operators.CompareString(array[2], "1", false) == 0);
				if (flag)
				{
					this.UiRadioButton1.Checked = true;
				}
				else
				{
					flag = (Operators.CompareString(array[2], "2", false) == 0);
					if (flag)
					{
						this.UiRadioButton3.Checked = true;
					}
					else
					{
						flag = (Operators.CompareString(array[2], "3", false) == 0);
						if (flag)
						{
							this.UiRadioButton4.Checked = true;
						}
					}
				}
			}
		}

		// Token: 0x04000297 RID: 663
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000299 RID: 665
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400029A RID: 666
		[AccessedThroughProperty("UiButton1")]
		private UIButton _UiButton1;

		// Token: 0x0400029B RID: 667
		[AccessedThroughProperty("txt_rizkharid")]
		private UICheckBox _txt_rizkharid;

		// Token: 0x0400029C RID: 668
		[AccessedThroughProperty("txt_sherakat")]
		private UICheckBox _txt_sherakat;

		// Token: 0x0400029D RID: 669
		[AccessedThroughProperty("UiRadioButton4")]
		private UIRadioButton _UiRadioButton4;

		// Token: 0x0400029E RID: 670
		[AccessedThroughProperty("UiRadioButton3")]
		private UIRadioButton _UiRadioButton3;

		// Token: 0x0400029F RID: 671
		[AccessedThroughProperty("UiRadioButton1")]
		private UIRadioButton _UiRadioButton1;

		// Token: 0x040002A0 RID: 672
		[AccessedThroughProperty("Label20")]
		private Label _Label20;

		// Token: 0x040002A1 RID: 673
		[CompilerGenerated]
		private long _Kharid_num;

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private int _NahveKharid;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private string _Jam_Furush;

		// Token: 0x040002A4 RID: 676
		[CompilerGenerated]
		private string _Jam_Daramad;

		// Token: 0x040002A5 RID: 677
		[CompilerGenerated]
		private string _Makharej;
	}
}
