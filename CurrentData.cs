using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200008C RID: 140
	internal class CurrentData
	{
		// Token: 0x06000C76 RID: 3190 RVA: 0x000020C1 File Offset: 0x000002C1
		[DebuggerNonUserCode]
		public CurrentData()
		{
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x0009D878 File Offset: 0x0009BA78
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x0000478E File Offset: 0x0000298E
		public string ComputerName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComputerName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._ComputerName = value;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x0009D890 File Offset: 0x0009BA90
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00004798 File Offset: 0x00002998
		public string Username
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Username;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Username = value;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C7B RID: 3195 RVA: 0x0009D8A8 File Offset: 0x0009BAA8
		// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000047A2 File Offset: 0x000029A2
		public long UserID
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UserID;
			}
			[DebuggerNonUserCode]
			set
			{
				this._UserID = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		// (set) Token: 0x06000C7E RID: 3198 RVA: 0x000047AC File Offset: 0x000029AC
		public int CurrentYear
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CurrentYear;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CurrentYear = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0009D8D8 File Offset: 0x0009BAD8
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x000047B6 File Offset: 0x000029B6
		public string CompanyName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CompanyName;
			}
			[DebuggerNonUserCode]
			set
			{
				this._CompanyName = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0009D8F0 File Offset: 0x0009BAF0
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x000047C0 File Offset: 0x000029C0
		public int Gui
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Gui;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Gui = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0009D908 File Offset: 0x0009BB08
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x000047CA File Offset: 0x000029CA
		public bool Tabbed
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Tabbed;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Tabbed = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0009D920 File Offset: 0x0009BB20
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x000047D4 File Offset: 0x000029D4
		public bool AutoClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AutoClose;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AutoClose = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0009D938 File Offset: 0x0009BB38
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000047DE File Offset: 0x000029DE
		public bool AutoBackup
		{
			[DebuggerNonUserCode]
			get
			{
				return this._AutoBackup;
			}
			[DebuggerNonUserCode]
			set
			{
				this._AutoBackup = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0009D950 File Offset: 0x0009BB50
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x000047E8 File Offset: 0x000029E8
		public string Password
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Password;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Password = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0009D968 File Offset: 0x0009BB68
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x000047F2 File Offset: 0x000029F2
		public int Gruh_Len
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Gruh_Len;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Gruh_Len = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0009D980 File Offset: 0x0009BB80
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x000047FC File Offset: 0x000029FC
		public int Kol_Len
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Kol_Len;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Kol_Len = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0009D998 File Offset: 0x0009BB98
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x00004806 File Offset: 0x00002A06
		public int Moin_Len
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Moin_Len;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Moin_Len = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0009D9B0 File Offset: 0x0009BBB0
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x00004810 File Offset: 0x00002A10
		public int Taf1_Len
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Taf1_Len;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Taf1_Len = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0009D9C8 File Offset: 0x0009BBC8
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x0000481A File Offset: 0x00002A1A
		public int Taf2_Len
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Taf2_Len;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Taf2_Len = value;
			}
		}

		// Token: 0x040004CB RID: 1227
		[CompilerGenerated]
		private string _ComputerName;

		// Token: 0x040004CC RID: 1228
		[CompilerGenerated]
		private string _Username;

		// Token: 0x040004CD RID: 1229
		[CompilerGenerated]
		private long _UserID;

		// Token: 0x040004CE RID: 1230
		[CompilerGenerated]
		private int _CurrentYear;

		// Token: 0x040004CF RID: 1231
		[CompilerGenerated]
		private string _CompanyName;

		// Token: 0x040004D0 RID: 1232
		[CompilerGenerated]
		private int _Gui;

		// Token: 0x040004D1 RID: 1233
		[CompilerGenerated]
		private bool _Tabbed;

		// Token: 0x040004D2 RID: 1234
		[CompilerGenerated]
		private bool _AutoClose;

		// Token: 0x040004D3 RID: 1235
		[CompilerGenerated]
		private bool _AutoBackup;

		// Token: 0x040004D4 RID: 1236
		[CompilerGenerated]
		private string _Password;

		// Token: 0x040004D5 RID: 1237
		[CompilerGenerated]
		private int _Gruh_Len;

		// Token: 0x040004D6 RID: 1238
		[CompilerGenerated]
		private int _Kol_Len;

		// Token: 0x040004D7 RID: 1239
		[CompilerGenerated]
		private int _Moin_Len;

		// Token: 0x040004D8 RID: 1240
		[CompilerGenerated]
		private int _Taf1_Len;

		// Token: 0x040004D9 RID: 1241
		[CompilerGenerated]
		private int _Taf2_Len;
	}
}
