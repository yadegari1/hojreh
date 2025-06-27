using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FruitBox
{
	// Token: 0x020000A8 RID: 168
	public class Column
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x000020B6 File Offset: 0x000002B6
		public Column()
		{
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0000510D File Offset: 0x0000330D
		public Column(string Name, string Caption, int Size)
		{
			this.Name = Name;
			this.Caption = Caption;
			this.Size = Size;
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000A72EC File Offset: 0x000A54EC
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00005130 File Offset: 0x00003330
		public string Caption
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Caption;
			}
			[DebuggerNonUserCode]
			set
			{
				this._Caption = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x000A7304 File Offset: 0x000A5504
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x0000513A File Offset: 0x0000333A
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x000A731C File Offset: 0x000A551C
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00005144 File Offset: 0x00003344
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

		// Token: 0x0400056C RID: 1388
		[CompilerGenerated]
		private string _Caption;

		// Token: 0x0400056D RID: 1389
		[CompilerGenerated]
		private string _Name;

		// Token: 0x0400056E RID: 1390
		[CompilerGenerated]
		private int _Size;
	}
}
