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
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000EA RID: 234
	[DesignerGenerated]
	public partial class Frm_DeleteCheck_Opr : Form
	{
		// Token: 0x0600189E RID: 6302 RVA: 0x00007402 File Offset: 0x00005602
		[DebuggerNonUserCode]
		public Frm_DeleteCheck_Opr()
		{
			base.Load += new EventHandler(this.Frm_DeleteCheck_Opr_Load);
			Frm_DeleteCheck_Opr.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00116F48 File Offset: 0x00115148
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DeleteCheck_Opr.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DeleteCheck_Opr.__ENCList.Count == Frm_DeleteCheck_Opr.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DeleteCheck_Opr.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DeleteCheck_Opr.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DeleteCheck_Opr.__ENCList[num] = Frm_DeleteCheck_Opr.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DeleteCheck_Opr.__ENCList.RemoveRange(num, Frm_DeleteCheck_Opr.__ENCList.Count - num);
						Frm_DeleteCheck_Opr.__ENCList.Capacity = Frm_DeleteCheck_Opr.__ENCList.Count;
					}
					Frm_DeleteCheck_Opr.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060018A2 RID: 6306 RVA: 0x00117794 File Offset: 0x00115994
		// (set) Token: 0x060018A3 RID: 6307 RVA: 0x0000742E File Offset: 0x0000562E
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

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x001177AC File Offset: 0x001159AC
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x00007438 File Offset: 0x00005638
		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x001177C4 File Offset: 0x001159C4
		// (set) Token: 0x060018A7 RID: 6311 RVA: 0x001177DC File Offset: 0x001159DC
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

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x060018A8 RID: 6312 RVA: 0x0011783C File Offset: 0x00115A3C
		// (set) Token: 0x060018A9 RID: 6313 RVA: 0x00007442 File Offset: 0x00005642
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

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x060018AA RID: 6314 RVA: 0x00117854 File Offset: 0x00115A54
		// (set) Token: 0x060018AB RID: 6315 RVA: 0x0000744C File Offset: 0x0000564C
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

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0011786C File Offset: 0x00115A6C
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x00007456 File Offset: 0x00005656
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

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00117884 File Offset: 0x00115A84
		// (set) Token: 0x060018AF RID: 6319 RVA: 0x00007460 File Offset: 0x00005660
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

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x0011789C File Offset: 0x00115A9C
		// (set) Token: 0x060018B1 RID: 6321 RVA: 0x0000746A File Offset: 0x0000566A
		public DataTable dt_opr
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dt_opr;
			}
			[DebuggerNonUserCode]
			set
			{
				this._dt_opr = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x001178B4 File Offset: 0x00115AB4
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00007474 File Offset: 0x00005674
		public DataTable Pardakht_Table
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Table;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Table = value;
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x001178CC File Offset: 0x00115ACC
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x0000747E File Offset: 0x0000567E
		public GridEX Pardakht_Grid
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Pardakht_Grid;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Pardakht_Grid = value;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x001178E4 File Offset: 0x00115AE4
		// (set) Token: 0x060018B7 RID: 6327 RVA: 0x00007488 File Offset: 0x00005688
		public List<listCheckDaryaft> ListDaryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ListDaryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ListDaryaft_Identity = value;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x001178FC File Offset: 0x00115AFC
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x00007492 File Offset: 0x00005692
		public List<int> del_lst
		{
			[DebuggerNonUserCode]
			get
			{
				return this._del_lst;
			}
			[DebuggerNonUserCode]
			set
			{
				this._del_lst = value;
			}
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00117914 File Offset: 0x00115B14
		private void UpdatePardakhtRows(long Parent_identity)
		{
			DataRow[] array = this.Pardakht_Table.Select("parent_identity=" + Conversions.ToString(Parent_identity));
			DataRow[] array2 = array;
			checked
			{
				long num;
				for (int i = 0; i < array2.Length; i++)
				{
					DataRow dataRow = array2[i];
					num = Conversions.ToLong(Operators.AddObject(num, dataRow["mablagh"]));
				}
				DataRow[] array3 = this.Pardakht_Table.Select("identity=" + Conversions.ToString(Parent_identity));
				bool flag = num != 0L;
				if (flag)
				{
					array3[0]["Mablagh"] = num;
				}
				else
				{
					this.Pardakht_Grid.GetRows()[this.Pardakht_Table.Rows.IndexOf(array3[0])].Delete();
					array3[0].Delete();
					this.Pardakht_Table.AcceptChanges();
				}
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0000749C File Offset: 0x0000569C
		private void Frm_DeleteCheck_Opr_Load(object sender, EventArgs e)
		{
			this.GridEX1.DataSource = this.dt_opr;
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x001179FC File Offset: 0x00115BFC
		private DataRow GetLastOpr()
		{
			return this.dt_opr.Rows[checked(this.dt_opr.Rows.Count - 1)];
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00117A30 File Offset: 0x00115C30
		private void DeletefromDb(long id, long parent_id)
		{
			long value = Conversions.ToLong(Public_Function.ExecuteScalar("select pardakhtcheck_id from daryaftpardakht where id=" + Conversions.ToString(id)));
			string text = "declare @bed_id bigint;declare @bes_id bigint;";
			text = text + "select @bed_id=sanadbed_id,@bes_id=sanadbes_id from daryaftpardakht where id=" + Conversions.ToString(id) + ";";
			text = text + "update daryaftpardakht set sanadbes_id=null,sanadbed_id=null where id=" + Conversions.ToString(id) + ";";
			text += "delete from sanad where id =@bed_id;";
			text += "delete from sanad where id =@bes_id;";
			text = text + "delete from daryaftpardakht where id = " + Conversions.ToString(id) + ";";
			Public_Function.ExecuteNonQuery(text);
			text = "declare @st int;";
			text = text + "select top 1  @st=check_status from daryaftpardakht where pardakhtcheck_id=" + Conversions.ToString(value) + " order by id desc;";
			text = text + "update daryaftpardakht set check_status=@st where id=" + Conversions.ToString(value) + ";";
			Public_Function.ExecuteNonQuery(text);
			long num = Conversions.ToLong(Public_Function.ExecuteScalar("select isnull(sum(mablagh),0) from daryaftpardakht where parent_id=" + Conversions.ToString(parent_id)));
			bool flag = num == 0L;
			if (flag)
			{
				Public_Function.ExecuteNonQuery("delete from daryaftpardakht where id=" + Conversions.ToString(parent_id));
			}
			else
			{
				Public_Function.ExecuteNonQuery("update daryaftpardakht set mablagh=" + Conversions.ToString(num) + " where id=" + Conversions.ToString(parent_id));
			}
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x00117B60 File Offset: 0x00115D60
		private void ButtonItem3_Click(object sender, EventArgs e)
		{
			DataRow lastOpr = this.GetLastOpr();
			bool flag = lastOpr["Pardakht_identity"] != DBNull.Value;
			DataRow[] array;
			if (flag)
			{
				array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("identity=", lastOpr["pardakht_identity"])));
			}
			else
			{
				array = this.Pardakht_Table.Select(Conversions.ToString(Operators.ConcatenateObject("id=", lastOpr["pardakht_id"])));
				this.DeletefromDb(Conversions.ToLong(lastOpr["pardakht_id"]), Conversions.ToLong(lastOpr["parent_identity"]));
			}
			flag = (array.Length > 0);
			checked
			{
				if (flag)
				{
					int num = Conversions.ToInteger(array[0]["dptype_id"]);
					int arg_CC_0 = 0;
					int num2 = this.ListDaryaft_Identity.Count - 1;
					int num3 = arg_CC_0;
					while (true)
					{
						int arg_13D_0 = num3;
						int num4 = num2;
						if (arg_13D_0 > num4)
						{
							goto IL_13F;
						}
						flag = (this.ListDaryaft_Identity[num3].Operation_id == num && Operators.ConditionalCompareObjectEqual(this.ListDaryaft_Identity[num3].Daryaft_Identity, array[0]["daryaft_identity"], false));
						if (flag)
						{
							break;
						}
						num3++;
					}
					this.ListDaryaft_Identity.RemoveAt(num3);
					IL_13F:
					int num5 = this.Pardakht_Table.Rows.IndexOf(array[0]);
					array[0].Delete();
					int arg_16C_0 = 0;
					int num6 = this.del_lst.Count - 1;
					int num7 = arg_16C_0;
					while (true)
					{
						int arg_1B3_0 = num7;
						int num4 = num6;
						if (arg_1B3_0 > num4)
						{
							break;
						}
						flag = (this.del_lst[num7] > num5);
						if (flag)
						{
							this.del_lst[num7] = this.del_lst[num7] - 1;
						}
						num7++;
					}
					this.Pardakht_Table.AcceptChanges();
					this.UpdatePardakhtRows(Conversions.ToLong(lastOpr["Parent_identity"]));
				}
				lastOpr.Delete();
				this.dt_opr.AcceptChanges();
			}
		}

		// Token: 0x04000996 RID: 2454
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x04000998 RID: 2456
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x04000999 RID: 2457
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x0400099A RID: 2458
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x0400099B RID: 2459
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x0400099C RID: 2460
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x0400099D RID: 2461
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x0400099E RID: 2462
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x0400099F RID: 2463
		[CompilerGenerated]
		private DataTable _dt_opr;

		// Token: 0x040009A0 RID: 2464
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x040009A1 RID: 2465
		[CompilerGenerated]
		private GridEX _Pardakht_Grid;

		// Token: 0x040009A2 RID: 2466
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x040009A3 RID: 2467
		[CompilerGenerated]
		private List<int> _del_lst;
	}
}
