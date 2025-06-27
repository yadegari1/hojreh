using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000E9 RID: 233
	public class listCheckDaryaft : IEquatable<listCheckDaryaft>
	{
		// Token: 0x0600188D RID: 6285 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public listCheckDaryaft()
		{
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x00116E50 File Offset: 0x00115050
		// (set) Token: 0x0600188F RID: 6287 RVA: 0x000073AF File Offset: 0x000055AF
		public int Operation_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Operation_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Operation_id = value;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001890 RID: 6288 RVA: 0x00116E68 File Offset: 0x00115068
		// (set) Token: 0x06001891 RID: 6289 RVA: 0x000073B9 File Offset: 0x000055B9
		public int Daryaft_Identity
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Daryaft_Identity;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Daryaft_Identity = value;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x00116E80 File Offset: 0x00115080
		// (set) Token: 0x06001893 RID: 6291 RVA: 0x000073C3 File Offset: 0x000055C3
		public int PardakhtCheck_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PardakhtCheck_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._PardakhtCheck_ID = value;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x00116E98 File Offset: 0x00115098
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x000073CD File Offset: 0x000055CD
		public int Moshtari_id
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moshtari_id;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moshtari_id = value;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x00116EB0 File Offset: 0x001150B0
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x000073D7 File Offset: 0x000055D7
		public int Bank_ID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Bank_ID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Bank_ID = value;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x00116EC8 File Offset: 0x001150C8
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x000073E1 File Offset: 0x000055E1
		public string sh_check
		{
			[DebuggerNonUserCode]
			get
			{
				return this._sh_check;
			}
			[DebuggerNonUserCode]
			set
			{
				this._sh_check = value;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x00116EE0 File Offset: 0x001150E0
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x000073EB File Offset: 0x000055EB
		public long Mablagh
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Mablagh;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Mablagh = value;
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00116EF8 File Offset: 0x001150F8
		public bool Equals(listCheckDaryaft other)
		{
			bool flag = other == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				flag = (this.Operation_id == other.Operation_id && this.Daryaft_Identity == other.Daryaft_Identity);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400098F RID: 2447
		[CompilerGenerated]
		private int _Operation_id;

		// Token: 0x04000990 RID: 2448
		[CompilerGenerated]
		private int _Daryaft_Identity;

		// Token: 0x04000991 RID: 2449
		[CompilerGenerated]
		private int _PardakhtCheck_ID;

		// Token: 0x04000992 RID: 2450
		[CompilerGenerated]
		private int _Moshtari_id;

		// Token: 0x04000993 RID: 2451
		[CompilerGenerated]
		private int _Bank_ID;

		// Token: 0x04000994 RID: 2452
		[CompilerGenerated]
		private string _sh_check;

		// Token: 0x04000995 RID: 2453
		[CompilerGenerated]
		private long _Mablagh;
	}
}
