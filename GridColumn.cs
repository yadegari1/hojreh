using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FruitBox
{
	// Token: 0x0200009A RID: 154
	public class GridColumn
	{
		// Token: 0x06000DB0 RID: 3504 RVA: 0x000020B6 File Offset: 0x000002B6
		public GridColumn()
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00004D97 File Offset: 0x00002F97
		public GridColumn(string Name, int Size)
		{
			this.Name = Name;
			this.Size = Size;
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x000A56E0 File Offset: 0x000A38E0
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00004DB2 File Offset: 0x00002FB2
		public string Name
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Name;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x000A56F8 File Offset: 0x000A38F8
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x00004DBC File Offset: 0x00002FBC
		public int Size
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Size;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Size = value;
			}
		}

		// Token: 0x04000547 RID: 1351
		[CompilerGenerated]
		private string _Name;

		// Token: 0x04000548 RID: 1352
		[CompilerGenerated]
		private int _Size;
	}
}
