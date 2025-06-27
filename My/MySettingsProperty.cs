using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox.My
{
	// Token: 0x020000C1 RID: 193
	[StandardModule, CompilerGenerated, HideModuleName, DebuggerNonUserCode]
	internal sealed class MySettingsProperty
	{
		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x000ACD50 File Offset: 0x000AAF50
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings
		{
			get
			{
				return MySettings.Default;
			}
		}
	}
}
