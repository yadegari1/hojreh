using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;

namespace FruitBox
{
	// Token: 0x02000132 RID: 306
	[DesignerGenerated]
	public partial class Frm_rpt_listsiah_bedehkaran : Form
	{
		// Token: 0x06002C2B RID: 11307 RVA: 0x0020CEF0 File Offset: 0x0020B0F0
		public Frm_rpt_listsiah_bedehkaran()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_rpt_bedehkaran_KeyDown);
			base.Load += new EventHandler(this.Frm_rpt_checkDaryafti_Load);
			Frm_rpt_listsiah_bedehkaran.__ENCAddToList(this);
			this.moshtari = new Moshtari_Info();
			this.InitializeComponent();
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x0020CF48 File Offset: 0x0020B148
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_rpt_listsiah_bedehkaran.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_rpt_listsiah_bedehkaran.__ENCList.Count == Frm_rpt_listsiah_bedehkaran.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_rpt_listsiah_bedehkaran.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_rpt_listsiah_bedehkaran.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_rpt_listsiah_bedehkaran.__ENCList[num] = Frm_rpt_listsiah_bedehkaran.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_rpt_listsiah_bedehkaran.__ENCList.RemoveRange(num, Frm_rpt_listsiah_bedehkaran.__ENCList.Count - num);
						Frm_rpt_listsiah_bedehkaran.__ENCList.Capacity = Frm_rpt_listsiah_bedehkaran.__ENCList.Count;
					}
					Frm_rpt_listsiah_bedehkaran.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002C2F RID: 11311 RVA: 0x0020DF14 File Offset: 0x0020C114
		// (set) Token: 0x06002C30 RID: 11312 RVA: 0x0000B20F File Offset: 0x0000940F
		internal virtual GridEX GridEX1
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

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002C31 RID: 11313 RVA: 0x0020DF2C File Offset: 0x0020C12C
		// (set) Token: 0x06002C32 RID: 11314 RVA: 0x0000B219 File Offset: 0x00009419
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

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x0020DF44 File Offset: 0x0020C144
		// (set) Token: 0x06002C34 RID: 11316 RVA: 0x0000B223 File Offset: 0x00009423
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

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x0020DF5C File Offset: 0x0020C15C
		// (set) Token: 0x06002C36 RID: 11318 RVA: 0x0020DF74 File Offset: 0x0020C174
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

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x0020DFD4 File Offset: 0x0020C1D4
		// (set) Token: 0x06002C38 RID: 11320 RVA: 0x0020DFEC File Offset: 0x0020C1EC
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

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x0020E04C File Offset: 0x0020C24C
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x0000B22D File Offset: 0x0000942D
		internal virtual UIProgressBar UiProgressBar1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiProgressBar1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UiProgressBar1 = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x0020E064 File Offset: 0x0020C264
		// (set) Token: 0x06002C3C RID: 11324 RVA: 0x0000B237 File Offset: 0x00009437
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

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x0020E07C File Offset: 0x0020C27C
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x0020E094 File Offset: 0x0020C294
		internal virtual UIComboBox UiComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UiComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.UiComboBox1_SelectedIndexChanged);
				bool flag = this._UiComboBox1 != null;
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged -= value2;
				}
				this._UiComboBox1 = value;
				flag = (this._UiComboBox1 != null);
				if (flag)
				{
					this._UiComboBox1.SelectedIndexChanged += value2;
				}
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x0020E0F4 File Offset: 0x0020C2F4
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x0020E10C File Offset: 0x0020C30C
		internal virtual SelectItem SelectItem1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._SelectItem1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				SelectItem.SelectedValueChangedEventHandler obj = new SelectItem.SelectedValueChangedEventHandler(this.SelectItem1_SelectedValueChanged);
				SelectItem.ValueDeletedEventHandler obj2 = new SelectItem.ValueDeletedEventHandler(this.SelectItem1_ValueDeleted);
				bool flag = this._SelectItem1 != null;
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged -= obj;
					this._SelectItem1.ValueDeleted -= obj2;
				}
				this._SelectItem1 = value;
				flag = (this._SelectItem1 != null);
				if (flag)
				{
					this._SelectItem1.SelectedValueChanged += obj;
					this._SelectItem1.ValueDeleted += obj2;
				}
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x0020E194 File Offset: 0x0020C394
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x0000B241 File Offset: 0x00009441
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

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06002C43 RID: 11331 RVA: 0x0020E1AC File Offset: 0x0020C3AC
		// (set) Token: 0x06002C44 RID: 11332 RVA: 0x0020E1C4 File Offset: 0x0020C3C4
		internal virtual EditBox txt_search
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txt_search;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.txt_search_TextChanged);
				bool flag = this._txt_search != null;
				if (flag)
				{
					this._txt_search.TextChanged -= value2;
				}
				this._txt_search = value;
				flag = (this._txt_search != null);
				if (flag)
				{
					this._txt_search.TextChanged += value2;
				}
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0020E224 File Offset: 0x0020C424
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x0000B24B File Offset: 0x0000944B
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

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x0020E23C File Offset: 0x0020C43C
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x0020E254 File Offset: 0x0020C454
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

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x0020E2B4 File Offset: 0x0020C4B4
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x0020E2CC File Offset: 0x0020C4CC
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

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0020E32C File Offset: 0x0020C52C
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x0020E344 File Offset: 0x0020C544
		internal virtual ButtonItem ButtonItem5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ButtonItem5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.ButtonItem5_Click);
				bool flag = this._ButtonItem5 != null;
				if (flag)
				{
					this._ButtonItem5.Click -= value2;
				}
				this._ButtonItem5 = value;
				flag = (this._ButtonItem5 != null);
				if (flag)
				{
					this._ButtonItem5.Click += value2;
				}
			}
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0020E3A4 File Offset: 0x0020C5A4
		private int GetNextPosx(Frm_rpt_listsiah_bedehkaran.bedbes bedbes, int pos, DataRow[] dr)
		{
			checked
			{
				int arg_0E_0 = pos + 1;
				int num = dr.Length - 1;
				int num2 = arg_0E_0;
				int num4;
				long num5;
				while (true)
				{
					int arg_172_0 = num2;
					int num3 = num;
					if (arg_172_0 > num3)
					{
						goto Block_7;
					}
					bool flag = bedbes == Frm_rpt_listsiah_bedehkaran.bedbes.bed;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dr[num2]["bed"], 0, false);
						if (flag2)
						{
							num4 = num2;
							num5 = Conversions.ToLong(dr[num2]["rembed"]);
							DateTime dateTime = Conversions.ToDate(dr[num2]["tarikh"]);
							int arg_7A_0 = num4 + 1;
							int num6 = dr.Length - 1;
							int num7 = arg_7A_0;
							while (true)
							{
								int arg_111_0 = num7;
								num3 = num6;
								if (arg_111_0 > num3)
								{
									break;
								}
								flag2 = (Operators.ConditionalCompareObjectEqual(dr[num7]["tarikh"], dateTime, false) && Operators.ConditionalCompareObjectGreater(dr[num7]["bed"], 0, false));
								if (!flag2)
								{
									goto IL_E8;
								}
								num4 = num7;
								num5 = Conversions.ToLong(Operators.AddObject(num5, dr[num7]["rembed"]));
								num7++;
							}
						}
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dr[num2]["bes"], 0, false) && Operators.ConditionalCompareObjectEqual(dr[num2]["stat"], "بد", false);
						if (flag2)
						{
							goto Block_6;
						}
					}
					num2++;
				}
				IL_E8:
				dr[num4]["rembed"] = num5;
				int result = num4;
				return result;
				Block_6:
				result = num2;
				return result;
				Block_7:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0020E530 File Offset: 0x0020C730
		private int GetNextPos(Frm_rpt_listsiah_bedehkaran.bedbes bedbes, int pos, DataRow[] dr)
		{
			checked
			{
				int arg_0A_0 = pos + 1;
				int num = dr.Length - 1;
				int num2 = arg_0A_0;
				while (true)
				{
					int arg_AA_0 = num2;
					int num3 = num;
					if (arg_AA_0 > num3)
					{
						goto Block_6;
					}
					bool flag = bedbes == Frm_rpt_listsiah_bedehkaran.bedbes.bed;
					if (flag)
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dr[num2]["bed"], 0, false);
						if (flag2)
						{
							break;
						}
					}
					else
					{
						bool flag2 = Operators.ConditionalCompareObjectGreater(dr[num2]["bes"], 0, false) && (Operators.ConditionalCompareObjectEqual(dr[num2]["stat"], "بد", false) || Operators.ConditionalCompareObjectEqual(dr[num2]["stat"], "ت", false));
						if (flag2)
						{
							goto Block_5;
						}
					}
					num2++;
				}
				int result = num2;
				return result;
				Block_5:
				result = num2;
				return result;
				Block_6:
				result = -1;
				return result;
			}
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0020E5F4 File Offset: 0x0020C7F4
		public string GetLastTarikh(long Codehesab_ID, DataRow[] dr)
		{
			Codehesab_ID = Codehesab_ID;
			string result = string.Empty;
			checked
			{
				for (int i = 0; i < dr.Length; i++)
				{
					DataRow dataRow = dr[i];
					long num = Conversions.ToLong(Operators.AddObject(num, dataRow["bed"]));
					num = Conversions.ToLong(Operators.SubtractObject(num, dataRow["bes"]));
					bool flag = num > 0L;
					if (flag)
					{
						dataRow["stat"] = "بد";
					}
					else
					{
						flag = (num < 0L);
						if (flag)
						{
							dataRow["stat"] = "بس";
						}
						else
						{
							dataRow["stat"] = "ت";
						}
					}
				}
				int num2 = -1;
				int num3 = -1;
				string left = string.Empty;
				num2 = this.GetNextPosx(Frm_rpt_listsiah_bedehkaran.bedbes.bed, num2, dr);
				num3 = this.GetNextPos(Frm_rpt_listsiah_bedehkaran.bedbes.bes, num3, dr);
				while (num2 != -1 && num3 != -1)
				{
					bool flag = Operators.ConditionalCompareObjectLess(dr[num3]["rembes"], dr[num2]["rembed"], false);
					if (flag)
					{
						bool flag2 = Operators.CompareString(left, string.Empty, false) != 0;
						if (flag2)
						{
							left = string.Empty;
						}
						int num4 = num2;
						DataRow arg_16A_0 = dr[num4];
						string columnName = "rembed";
						arg_16A_0[columnName] = Operators.SubtractObject(dr[num4][columnName], dr[num3]["rembes"]);
						flag2 = Operators.ConditionalCompareObjectNotEqual(dr[num3]["stat"], "ت", false);
						if (flag2)
						{
							result = Conversions.ToString(dr[num2]["Tarikh_Fa"]);
						}
						num3 = this.GetNextPos(Frm_rpt_listsiah_bedehkaran.bedbes.bes, num3, dr);
					}
					else
					{
						long num5 = Conversions.ToLong(Operators.SubtractObject(dr[num3]["rembes"], dr[num2]["rembed"]));
						dr[num2]["rembed"] = 0;
						left = Conversions.ToString(dr[num2]["Tarikh_Fa"]);
						num2 = this.GetNextPosx(Frm_rpt_listsiah_bedehkaran.bedbes.bed, num2, dr);
						dr[num3]["rembes"] = num5;
					}
				}
				return result;
			}
		}

		// Token: 0x06002C50 RID: 11344 RVA: 0x0020E840 File Offset: 0x0020CA40
		private void Preparedt(DataTable dt)
		{
			bool flag = dt.Rows.Count == 0;
			checked
			{
				if (!flag)
				{
					dt.Columns.Add("tarikh", typeof(string));
					this.UiProgressBar1.Visible = true;
					this.UiProgressBar1.Maximum = dt.Rows.Count;
					this.UiProgressBar1.Value = 0;
					int count = dt.Rows.Count;
					int num = count / 50;
					string text = string.Empty;
					int arg_85_0 = 0;
					int num2 = num;
					int num3 = arg_85_0;
					while (true)
					{
						int arg_256_0 = num3;
						int num4 = num2;
						if (arg_256_0 > num4)
						{
							break;
						}
						int arg_9C_0 = num3 * 50;
						int num5 = (num3 + 1) * 50 - 1;
						int num6 = arg_9C_0;
						while (true)
						{
							int arg_137_0 = num6;
							num4 = num5;
							if (arg_137_0 > num4)
							{
								break;
							}
							flag = (num6 > dt.Rows.Count - 1);
							if (flag)
							{
								goto Block_2;
							}
							text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(dt.Rows[num6]["codehesab_id"], ",")));
							num6++;
						}
						IL_13C:
						text = Public_Function.RemoveLast(text);
						Application.DoEvents();
						DataTable dataTable = Public_Function.FillData("SELECT     ID, Bed, Bes,Bed as rembed,Bes as rembes,codehesab_id,tarikh, Tarikh_Fa  FROM Sanad where CodeHesab_ID in(" + text + ") order by CodeHesab_ID,Tarikh");
						dataTable.Columns.Add("stat", typeof(string));
						int arg_18A_0 = num3 * 50;
						int num7 = (num3 + 1) * 50 - 1;
						int num8 = arg_18A_0;
						while (true)
						{
							int arg_223_0 = num8;
							num4 = num7;
							if (arg_223_0 > num4)
							{
								break;
							}
							flag = (num8 > dt.Rows.Count - 1);
							if (flag)
							{
								break;
							}
							DataRow[] dr = dataTable.Select(Conversions.ToString(Operators.ConcatenateObject("codehesab_id=", dt.Rows[num8]["codehesab_id"])));
							dt.Rows[num8]["tarikh"] = this.GetLastTarikh(Conversions.ToLong(dt.Rows[num8]["codehesab_id"]), dr);
							num8++;
						}
						IL_228:
						text = string.Empty;
						UIProgressBar uiProgressBar = this.UiProgressBar1;
						uiProgressBar.Value++;
						num3++;
						continue;
						goto IL_228;
						Block_2:
						this.UiProgressBar1.Visible = false;
						GridEX gridEX = this.GridEX1;
						gridEX.Height += this.UiProgressBar1.Height;
						this.UiComboBox1.SelectedIndex = 0;
						goto IL_13C;
					}
				}
			}
		}

		// Token: 0x06002C51 RID: 11345 RVA: 0x0020EAAC File Offset: 0x0020CCAC
		private void LoadData(string inm, int gm)
		{
			string str = string.Empty;
			bool flag = Operators.CompareString(inm, string.Empty, false) != 0;
			if (flag)
			{
				bool flag2 = gm == 1;
				if (flag2)
				{
					str = " AND (Moshtari.GrouhMoshtari_ID=" + inm + ") ";
				}
				else
				{
					str = " AND (Moshtari.GrouhMoshtari2_ID=" + inm + ") ";
				}
			}
			DataTable dataSource = Public_Function.FillData("SELECT     t.bes, t.bed, t.jam_bed, t.CodeHesab_ID, t.Moshtari_Name,Moshtari_1.ID, Moshtari_1.Name, Moshtari_1.Family,Moshtari_1.avaldore_tarikh  FROM         (SELECT     SUM(Sanad.Bes) AS bes, SUM(Sanad.Bed) AS bed, SUM(Sanad.Bed - Sanad.Bes) AS jam_bed, Sanad.CodeHesab_ID, MIN(Code_Hesab.Name)  AS Moshtari_Name  FROM         Sanad INNER JOIN  Code_Hesab ON Sanad.CodeHesab_ID = Code_Hesab.ID INNER JOIN   Moshtari ON Code_Hesab.ID = Moshtari.CodeHesab_ID  WHERE     (Code_Hesab.Grouh_ID = 2) AND (Moshtari.ID NOT IN  (SELECT     Moshtari_ID  FROM         Sharik)) AND (Moshtari.ID IN(select moshtari_id from moshtari_listSiah)) " + str + " GROUP BY Sanad.CodeHesab_ID  HAVING      (SUM(Sanad.Bed - Sanad.Bes) > 0)) AS t INNER JOIN  Moshtari AS Moshtari_1 ON t.CodeHesab_ID = Moshtari_1.CodeHesab_ID ");
			this.GridEX1.DataSource = dataSource;
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x0020EB2C File Offset: 0x0020CD2C
		private void Frm_rpt_bedehkaran_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
			flag = (e.KeyCode == Keys.F3);
			if (flag)
			{
				this.ButtonItem3_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F4);
			if (flag)
			{
				this.ButtonItem1_Click(null, null);
			}
			flag = (e.KeyCode == Keys.F5);
			if (flag)
			{
				this.ButtonItem2_Click(null, null);
			}
		}

		// Token: 0x06002C53 RID: 11347 RVA: 0x0000B255 File Offset: 0x00009455
		private void Frm_rpt_checkDaryafti_Load(object sender, EventArgs e)
		{
			this.LoadData(string.Empty, 0);
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00128E48 File Offset: 0x00127048
		private void SetHeader(StiReport rpt)
		{
			StiText stiText = (StiText)rpt.GetComponentByName("head1");
			bool flag = stiText != null;
			if (flag)
			{
				stiText.Text = Public_Function.dict["head1"];
			}
			stiText = (StiText)rpt.GetComponentByName("head2");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.dict["head2"];
			}
			stiText = (StiText)rpt.GetComponentByName("tarikh");
			flag = (stiText != null);
			if (flag)
			{
				stiText.Text = Public_Function.MiladiToShamsi(DateAndTime.Now);
			}
			flag = Public_Function.dict.ContainsKey("eval");
			if (flag)
			{
				bool flag2 = Conversions.ToBoolean(Public_Function.dict["eval"]);
				if (flag2)
				{
					rpt.Pages[0].Watermark.Angle = 45f;
					rpt.Pages[0].Watermark.Text = "آزمایشی";
				}
			}
			else
			{
				rpt.Pages[0].Watermark = null;
			}
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x0020EB9C File Offset: 0x0020CD9C
		private void ButtonItem1_Click(object sender, EventArgs e)
		{
			StiReport stiReport = new StiReport();
			stiReport.Load(Application.StartupPath + "\\reports\\bedehkaran.mrt");
			DataTable dataTable = (DataTable)this.GridEX1.DataSource;
			dataTable.TableName = "data";
			stiReport.RegData(dataTable.DefaultView);
			StiText stiText = new StiText();
			stiText = (StiText)stiReport.GetComponentByName("txt_tarikh");
			stiText.Text.Value = Public_Function.MiladiToShamsi(DateAndTime.Now);
			bool flag = this.UiComboBox1.SelectedIndex == 4;
			if (flag)
			{
				stiText = (StiText)stiReport.GetComponentByName("Text7");
				stiText.Text.Value = "{viewdata.avaldore_tarikh}";
			}
			this.SetHeader(stiReport);
			Public_Function.SetReport_MarginTop(stiReport);
			Public_Function.AddTazminText(stiReport, true, false);
			stiReport.Print(false);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x0000B266 File Offset: 0x00009466
		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.Timer1.Enabled = false;
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0020EC74 File Offset: 0x0020CE74
		private void UiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.DataSource == null;
			if (!flag)
			{
				this.GridEX1.RootTable.Columns["tarikh"].Visible = true;
				this.GridEX1.RootTable.Columns["avaldore_tarikh"].Visible = false;
				DataTable dataTable = (DataTable)this.GridEX1.DataSource;
				switch (this.UiComboBox1.SelectedIndex)
				{
				case 0:
					dataTable.DefaultView.Sort = "tarikh";
					break;
				case 1:
					dataTable.DefaultView.Sort = "bed desc";
					break;
				case 2:
					dataTable.DefaultView.Sort = "family";
					break;
				case 3:
					dataTable.DefaultView.Sort = "name";
					break;
				case 4:
					dataTable.DefaultView.Sort = "avaldore_tarikh";
					this.GridEX1.RootTable.Columns["tarikh"].Visible = false;
					this.GridEX1.RootTable.Columns["avaldore_tarikh"].Visible = true;
					break;
				}
				this.GridEX1.Row = 0;
				this.GridEX1.Focus();
			}
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0020EDDC File Offset: 0x0020CFDC
		private void SelectItem1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.LoadData(Conversions.ToString(this.SelectItem1.Value), Conversions.ToInteger(this.SelectItem1.SelectedRow["kind"]));
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002C59 RID: 11353 RVA: 0x0000B28E File Offset: 0x0000948E
		private void SelectItem1_ValueDeleted(object sender, EventArgs e)
		{
			this.LoadData(string.Empty, 0);
			this.Preparedt((DataTable)this.GridEX1.DataSource);
		}

		// Token: 0x06002C5A RID: 11354 RVA: 0x00200550 File Offset: 0x001FE750
		private void FilterGrid(GridEX Grid, string Text)
		{
			DataView defaultView = ((DataTable)Grid.DataSource).DefaultView;
			bool flag = Operators.CompareString(Text, string.Empty, false) == 0;
			if (flag)
			{
				defaultView.RowFilter = "";
			}
			else
			{
				defaultView.RowFilter = "moshtari_name LIKE '%" + Text + "%'";
				Public_Function.HighlightCell(Grid, Text);
			}
		}

		// Token: 0x06002C5B RID: 11355 RVA: 0x0000B2B6 File Offset: 0x000094B6
		private void txt_search_TextChanged(object sender, EventArgs e)
		{
			this.FilterGrid(this.GridEX1, this.txt_search.Text);
		}

		// Token: 0x06002C5C RID: 11356 RVA: 0x0020EE34 File Offset: 0x0020D034
		private void ButtonItem2_Click(object sender, EventArgs e)
		{
			this.txt_search.Text = string.Empty;
			bool flag = this.SelectItem1.Value != null;
			if (flag)
			{
				this.LoadData(string.Empty, 0);
				this.Preparedt((DataTable)this.GridEX1.DataSource);
				this.SelectItem1.SetNew();
			}
			this.txt_search.Focus();
		}

		// Token: 0x06002C5D RID: 11357 RVA: 0x0020EEA8 File Offset: 0x0020D0A8
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			Frm_SuratHesab_Moshtari frm_SuratHesab_Moshtari = new Frm_SuratHesab_Moshtari();
			bool flag = this.GridEX1.CurrentRow.Cells["id"].Value != DBNull.Value;
			if (flag)
			{
				bool flag2 = Operators.ConditionalCompareObjectNotEqual(this.GridEX1.CurrentRow.Cells["id"].Value, -1, false);
				if (flag2)
				{
					Frm_SuratHesab_Moshtari arg_98_0 = frm_SuratHesab_Moshtari;
					object expr_86 = this.GridEX1.CurrentRow.Cells["id"].Value;
					int? num;
					arg_98_0.Moshtari_id = ((expr_86 != null) ? ((int?)expr_86) : num);
					frm_SuratHesab_Moshtari.Moshtari_Name = Conversions.ToString(this.GridEX1.CurrentRow.Cells["Moshtari_Name"].Value);
				}
			}
			MyProject.Forms.Form_Main.Dialog_ShowForm(frm_SuratHesab_Moshtari);
		}

		// Token: 0x06002C5E RID: 11358 RVA: 0x0020EF94 File Offset: 0x0020D194
		private void ButtonItem5_Click(object sender, EventArgs e)
		{
			bool flag = this.GridEX1.CurrentRow != null;
			if (flag)
			{
				bool flag2 = Public_Function.ShowMessage(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("آیا مایل به حذف ", this.GridEX1.CurrentRow.Cells["moshtari_name"].Value), " از لیست سیاه میباشید؟ ")), MessageBoxButtons.YesNo, MessageBoxIcon.Question, null) == DialogResult.Yes;
				if (flag2)
				{
					NewLateBinding.LateCall(null, typeof(Public_Function), "ExecuteNonQuery", new object[]
					{
						Operators.ConcatenateObject("delete from moshtari_listSiah where moshtari_id=", this.GridEX1.CurrentRow.Cells["ID"].Value)
					}, null, null, null, true);
					this.GridEX1.CurrentRow.Delete();
				}
			}
		}

		// Token: 0x0400112F RID: 4399
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04001131 RID: 4401
		[AccessedThroughProperty("GridEX1")]
		private GridEX _GridEX1;

		// Token: 0x04001132 RID: 4402
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x04001133 RID: 4403
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04001134 RID: 4404
		[AccessedThroughProperty("ButtonItem1")]
		private ButtonItem _ButtonItem1;

		// Token: 0x04001135 RID: 4405
		[AccessedThroughProperty("Timer1")]
		private Timer _Timer1;

		// Token: 0x04001136 RID: 4406
		[AccessedThroughProperty("UiProgressBar1")]
		private UIProgressBar _UiProgressBar1;

		// Token: 0x04001137 RID: 4407
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04001138 RID: 4408
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x04001139 RID: 4409
		[AccessedThroughProperty("SelectItem1")]
		private SelectItem _SelectItem1;

		// Token: 0x0400113A RID: 4410
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400113B RID: 4411
		[AccessedThroughProperty("txt_search")]
		private EditBox _txt_search;

		// Token: 0x0400113C RID: 4412
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x0400113D RID: 4413
		[AccessedThroughProperty("ButtonItem2")]
		private ButtonItem _ButtonItem2;

		// Token: 0x0400113E RID: 4414
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400113F RID: 4415
		[AccessedThroughProperty("ButtonItem5")]
		private ButtonItem _ButtonItem5;

		// Token: 0x04001140 RID: 4416
		private Moshtari_Info moshtari;

		// Token: 0x02000133 RID: 307
		private enum bedbes
		{
			// Token: 0x04001142 RID: 4418
			bed,
			// Token: 0x04001143 RID: 4419
			bes
		}
	}
}
