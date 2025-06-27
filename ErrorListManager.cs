using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000059 RID: 89
	public class ErrorListManager
	{
		// Token: 0x060003CA RID: 970 RVA: 0x0004EF04 File Offset: 0x0004D104
		public ErrorListManager()
		{
			List<string> list = new List<string>();
			this.List = list;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003CB RID: 971 RVA: 0x0004EF28 File Offset: 0x0004D128
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00002984 File Offset: 0x00000B84
		public List<string> List
		{
			[DebuggerNonUserCode]
			get
			{
				return this._List;
			}
			[DebuggerNonUserCode]
			set
			{
				this._List = value;
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000298E File Offset: 0x00000B8E
		public void AddToList(string Desc)
		{
			this.List.Add(Desc);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000299F File Offset: 0x00000B9F
		public void ClearList()
		{
			this.List.Clear();
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0004EF40 File Offset: 0x0004D140
		public void Hide(Frm_Base frm)
		{
			Cursor.Current = Cursors.WaitCursor;
			UIPanelManager uIPanelManager = null;
			bool flag = frm.components != null;
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = frm.components.Components.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IComponent component = (IComponent)enumerator.Current;
						flag2 = (component is UIPanelManager);
						if (flag2)
						{
							uIPanelManager = (UIPanelManager)component;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag2 = (enumerator is IDisposable);
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			else
			{
				frm.components = new Container();
			}
			flag2 = (uIPanelManager == null);
			if (flag2)
			{
				uIPanelManager = new UIPanelManager(frm.components);
			}
			UIPanel uIPanel = null;
			try
			{
				IEnumerator enumerator2 = ((IEnumerable)uIPanelManager.Panels).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					UIPanel uIPanel2 = (UIPanel)enumerator2.Current;
					flag2 = (Operators.CompareString(uIPanel2.Name, "ErrorInfo", false) == 0);
					if (flag2)
					{
						uIPanel = uIPanel2;
						UIPanelInnerContainer innerContainer = uIPanel.InnerContainer;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag2 = (enumerator2 is IDisposable);
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			flag2 = (uIPanel != null);
			if (flag2)
			{
				uIPanel.Closed = true;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0004F0B0 File Offset: 0x0004D2B0
		public void Show(Frm_Base frm)
		{
			Cursor.Current = Cursors.WaitCursor;
			UIPanelManager uIPanelManager = null;
			bool flag = frm.components != null;
			bool flag2;
			if (flag)
			{
				try
				{
					IEnumerator enumerator = frm.components.Components.GetEnumerator();
					while (enumerator.MoveNext())
					{
						IComponent component = (IComponent)enumerator.Current;
						flag2 = (component is UIPanelManager);
						if (flag2)
						{
							uIPanelManager = (UIPanelManager)component;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					flag2 = (enumerator is IDisposable);
					if (flag2)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			else
			{
				frm.components = new Container();
			}
			flag2 = (uIPanelManager == null);
			if (flag2)
			{
				uIPanelManager = new UIPanelManager(frm.components);
			}
			UIPanel uIPanel = null;
			UIPanelInnerContainer uIPanelInnerContainer = null;
			try
			{
				IEnumerator enumerator2 = ((IEnumerable)uIPanelManager.Panels).GetEnumerator();
				while (enumerator2.MoveNext())
				{
					UIPanel uIPanel2 = (UIPanel)enumerator2.Current;
					flag2 = (Operators.CompareString(uIPanel2.Name, "ErrorInfo", false) == 0);
					if (flag2)
					{
						uIPanel = uIPanel2;
						uIPanelInnerContainer = uIPanel.InnerContainer;
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				flag2 = (enumerator2 is IDisposable);
				if (flag2)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			flag2 = (uIPanel == null);
			checked
			{
				if (flag2)
				{
					uIPanel = new UIPanel();
					uIPanelInnerContainer = new UIPanelInnerContainer();
					uIPanel.Name = "ErrorInfo";
					uIPanel.Text = "خطاها";
					uIPanel.Id = Guid.NewGuid();
					uIPanel.InnerContainer = uIPanelInnerContainer;
					uIPanel.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.False;
					uIPanel.AutoHide = true;
					uIPanel.AutoHideActive = true;
					GridEX gridEX = new GridEX();
					gridEX.BoundMode = BoundMode.Unbound;
					gridEX.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
					gridEX.Dock = DockStyle.Fill;
					gridEX.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
					gridEX.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
					gridEX.RootTable = new GridEXTable();
					gridEX.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
					gridEX.RightToLeft = RightToLeft.Yes;
					gridEX.GroupByBoxVisible = false;
					gridEX.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
					gridEX.RootTable.Columns.Add("Name");
					try
					{
						List<string>.Enumerator enumerator3 = this.List.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							string current = enumerator3.Current;
							gridEX.AddItem(new object[]
							{
								current
							});
						}
					}
					finally
					{
						List<string>.Enumerator enumerator3;
						((IDisposable)enumerator3).Dispose();
					}
					uIPanelInnerContainer.Controls.Add(gridEX);
					uIPanel.ActiveCaptionMode = ActiveCaptionMode.Never;
					uIPanelManager.VisualStyle = PanelVisualStyle.Office2010;
					uIPanelManager.ContainerControl = frm;
					uIPanelManager.Panels.Add(uIPanel);
					uIPanelManager.BeginPanelInfo();
					UIPanelManager arg_2B0_0 = uIPanelManager;
					Guid arg_2B0_1 = uIPanel.Id;
					PanelDockStyle arg_2B0_2 = PanelDockStyle.Bottom;
					Size size = new Size(frm.Width, 200);
					arg_2B0_0.AddDockPanelInfo(arg_2B0_1, arg_2B0_2, size, true);
					uIPanelManager.EndPanelInfo();
					gridEX.RootTable.Columns["Name"].Width = gridEX.Width - gridEX.RootTable.RowHeaderWidth - gridEX.ScrollBarWidth;
				}
				else
				{
					uIPanel.Closed = false;
					GridEX gridEX2 = (GridEX)uIPanelInnerContainer.Controls[0];
					gridEX2.ClearItems();
					try
					{
						List<string>.Enumerator enumerator4 = this.List.GetEnumerator();
						while (enumerator4.MoveNext())
						{
							string current2 = enumerator4.Current;
							gridEX2.AddItem(new object[]
							{
								current2
							});
						}
					}
					finally
					{
						List<string>.Enumerator enumerator4;
						((IDisposable)enumerator4).Dispose();
					}
					gridEX2.RootTable.Columns["Name"].Width = gridEX2.Width - gridEX2.RootTable.RowHeaderWidth - gridEX2.ScrollBarWidth;
				}
				uIPanel.Activate();
				Cursor.Current = Cursors.Default;
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000205D File Offset: 0x0000025D
		public void Show()
		{
		}

		// Token: 0x04000181 RID: 385
		[CompilerGenerated]
		private List<string> _List;
	}
}
