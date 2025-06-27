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
	// Token: 0x020000EB RID: 235
	[DesignerGenerated]
	public partial class Frm_DeleteDaryaftPardakht : Form
	{
		// Token: 0x060018C0 RID: 6336 RVA: 0x000074BF File Offset: 0x000056BF
		[DebuggerNonUserCode]
		public Frm_DeleteDaryaftPardakht()
		{
			base.KeyDown += new KeyEventHandler(this.Frm_DeleteDaryaftPardakht_KeyDown);
			base.Load += new EventHandler(this.Frm_DeleteCheck_Opr_Load);
			Frm_DeleteDaryaftPardakht.__ENCAddToList(this);
			this.InitializeComponent();
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x00117D5C File Offset: 0x00115F5C
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = Frm_DeleteDaryaftPardakht.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = Frm_DeleteDaryaftPardakht.__ENCList.Count == Frm_DeleteDaryaftPardakht.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = Frm_DeleteDaryaftPardakht.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = Frm_DeleteDaryaftPardakht.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									Frm_DeleteDaryaftPardakht.__ENCList[num] = Frm_DeleteDaryaftPardakht.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						Frm_DeleteDaryaftPardakht.__ENCList.RemoveRange(num, Frm_DeleteDaryaftPardakht.__ENCList.Count - num);
						Frm_DeleteDaryaftPardakht.__ENCList.Capacity = Frm_DeleteDaryaftPardakht.__ENCList.Count;
					}
					Frm_DeleteDaryaftPardakht.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x0011859C File Offset: 0x0011679C
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x000074FF File Offset: 0x000056FF
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

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x001185B4 File Offset: 0x001167B4
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x00007509 File Offset: 0x00005709
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

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x001185CC File Offset: 0x001167CC
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x001185E4 File Offset: 0x001167E4
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

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00118644 File Offset: 0x00116844
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x00007513 File Offset: 0x00005713
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

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x0011865C File Offset: 0x0011685C
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000751D File Offset: 0x0000571D
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

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x00118674 File Offset: 0x00116874
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x00007527 File Offset: 0x00005727
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

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0011868C File Offset: 0x0011688C
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00007531 File Offset: 0x00005731
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

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x001186A4 File Offset: 0x001168A4
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000753B File Offset: 0x0000573B
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

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x001186BC File Offset: 0x001168BC
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00007545 File Offset: 0x00005745
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

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x001186D4 File Offset: 0x001168D4
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x0000754F File Offset: 0x0000574F
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

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x001186EC File Offset: 0x001168EC
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00007559 File Offset: 0x00005759
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

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x00118704 File Offset: 0x00116904
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00007563 File Offset: 0x00005763
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

		// Token: 0x060018DC RID: 6364 RVA: 0x0011871C File Offset: 0x0011691C
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

		// Token: 0x060018DD RID: 6365 RVA: 0x0006620C File Offset: 0x0006440C
		private void Frm_DeleteDaryaftPardakht_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyCode == Keys.Escape;
			if (flag)
			{
				this.Close();
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0000756D File Offset: 0x0000576D
		private void Frm_DeleteCheck_Opr_Load(object sender, EventArgs e)
		{
			this.GridEX1.DataSource = this.dt_opr;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x00118804 File Offset: 0x00116A04
		private DataRow GetLastOpr()
		{
			return this.dt_opr.Rows[checked(this.dt_opr.Rows.Count - 1)];
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00117A30 File Offset: 0x00115C30
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

		// Token: 0x060018E1 RID: 6369 RVA: 0x00118838 File Offset: 0x00116A38
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

		// Token: 0x040009A4 RID: 2468
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040009A6 RID: 2470
		[AccessedThroughProperty("Bar1")]
		private Bar _Bar1;

		// Token: 0x040009A7 RID: 2471
		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		// Token: 0x040009A8 RID: 2472
		[AccessedThroughProperty("ButtonItem3")]
		private ButtonItem _ButtonItem3;

		// Token: 0x040009A9 RID: 2473
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040009AA RID: 2474
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x040009AB RID: 2475
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x040009AC RID: 2476
		[AccessedThroughProperty("GridEX1")]
		private DataEntryGrid _GridEX1;

		// Token: 0x040009AD RID: 2477
		[CompilerGenerated]
		private DataTable _dt_opr;

		// Token: 0x040009AE RID: 2478
		[CompilerGenerated]
		private DataTable _Pardakht_Table;

		// Token: 0x040009AF RID: 2479
		[CompilerGenerated]
		private GridEX _Pardakht_Grid;

		// Token: 0x040009B0 RID: 2480
		[CompilerGenerated]
		private List<listCheckDaryaft> _ListDaryaft_Identity;

		// Token: 0x040009B1 RID: 2481
		[CompilerGenerated]
		private List<int> _del_lst;
	}
}
