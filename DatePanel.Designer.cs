using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using Janus.Windows.GridEX;
using Janus.Windows.GridEX.EditControls;
using Janus.Windows.UI;
using Janus.Windows.UI.Dock;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000095 RID: 149
	[DesignerGenerated]
	public class DatePanel : UserControl
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x000A0AC4 File Offset: 0x0009ECC4
		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			List<WeakReference> _ENCList = DatePanel.__ENCList;
			checked
			{
				lock (_ENCList)
				{
					bool flag = DatePanel.__ENCList.Count == DatePanel.__ENCList.Capacity;
					if (flag)
					{
						int num = 0;
						int arg_3F_0 = 0;
						int num2 = DatePanel.__ENCList.Count - 1;
						int num3 = arg_3F_0;
						while (true)
						{
							int arg_90_0 = num3;
							int num4 = num2;
							if (arg_90_0 > num4)
							{
								break;
							}
							WeakReference weakReference = DatePanel.__ENCList[num3];
							flag = weakReference.IsAlive;
							if (flag)
							{
								bool flag2 = num3 != num;
								if (flag2)
								{
									DatePanel.__ENCList[num] = DatePanel.__ENCList[num3];
								}
								num++;
							}
							num3++;
						}
						DatePanel.__ENCList.RemoveRange(num, DatePanel.__ENCList.Count - num);
						DatePanel.__ENCList.Capacity = DatePanel.__ENCList.Count;
					}
					DatePanel.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000A0BC8 File Offset: 0x0009EDC8
		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000A0C18 File Offset: 0x0009EE18
		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			UIComboBoxItem uIComboBoxItem = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem2 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem3 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem4 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem5 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem6 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem7 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem8 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem9 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem10 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem11 = new UIComboBoxItem();
			UIComboBoxItem uIComboBoxItem12 = new UIComboBoxItem();
			this.UiGroupBox1 = new UIGroupBox();
			this.LinkLabel1 = new LinkLabel();
			this.btn35 = new UIButton();
			this.btn34 = new UIButton();
			this.btn33 = new UIButton();
			this.btn28 = new UIButton();
			this.btn27 = new UIButton();
			this.btn26 = new UIButton();
			this.btn21 = new UIButton();
			this.btn20 = new UIButton();
			this.btn19 = new UIButton();
			this.btn32 = new UIButton();
			this.btn14 = new UIButton();
			this.btn13 = new UIButton();
			this.btn25 = new UIButton();
			this.btn12 = new UIButton();
			this.btn18 = new UIButton();
			this.btn31 = new UIButton();
			this.btn7 = new UIButton();
			this.btn6 = new UIButton();
			this.btn24 = new UIButton();
			this.btn11 = new UIButton();
			this.btn17 = new UIButton();
			this.btn30 = new UIButton();
			this.btn5 = new UIButton();
			this.btn23 = new UIButton();
			this.btn10 = new UIButton();
			this.btn16 = new UIButton();
			this.btn29 = new UIButton();
			this.btn4 = new UIButton();
			this.btn22 = new UIButton();
			this.btn9 = new UIButton();
			this.btn15 = new UIButton();
			this.btn3 = new UIButton();
			this.btn8 = new UIButton();
			this.btn2 = new UIButton();
			this.btn1 = new UIButton();
			this.Label7 = new Label();
			this.Label6 = new Label();
			this.Label5 = new Label();
			this.Label4 = new Label();
			this.Label3 = new Label();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.UiComboBox1 = new UIComboBox();
			this.IntegerUpDown1 = new IntegerUpDown();
			this.Panel1 = new Panel();
			((ISupportInitialize)this.UiGroupBox1).BeginInit();
			this.UiGroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			this.UiGroupBox1.BackgroundStyle = BackgroundStyle.TabPage;
			this.UiGroupBox1.Controls.Add(this.LinkLabel1);
			this.UiGroupBox1.Controls.Add(this.btn35);
			this.UiGroupBox1.Controls.Add(this.btn34);
			this.UiGroupBox1.Controls.Add(this.btn33);
			this.UiGroupBox1.Controls.Add(this.btn28);
			this.UiGroupBox1.Controls.Add(this.btn27);
			this.UiGroupBox1.Controls.Add(this.btn26);
			this.UiGroupBox1.Controls.Add(this.btn21);
			this.UiGroupBox1.Controls.Add(this.btn20);
			this.UiGroupBox1.Controls.Add(this.btn19);
			this.UiGroupBox1.Controls.Add(this.btn32);
			this.UiGroupBox1.Controls.Add(this.btn14);
			this.UiGroupBox1.Controls.Add(this.btn13);
			this.UiGroupBox1.Controls.Add(this.btn25);
			this.UiGroupBox1.Controls.Add(this.btn12);
			this.UiGroupBox1.Controls.Add(this.btn18);
			this.UiGroupBox1.Controls.Add(this.btn31);
			this.UiGroupBox1.Controls.Add(this.btn7);
			this.UiGroupBox1.Controls.Add(this.btn6);
			this.UiGroupBox1.Controls.Add(this.btn24);
			this.UiGroupBox1.Controls.Add(this.btn11);
			this.UiGroupBox1.Controls.Add(this.btn17);
			this.UiGroupBox1.Controls.Add(this.btn30);
			this.UiGroupBox1.Controls.Add(this.btn5);
			this.UiGroupBox1.Controls.Add(this.btn23);
			this.UiGroupBox1.Controls.Add(this.btn10);
			this.UiGroupBox1.Controls.Add(this.btn16);
			this.UiGroupBox1.Controls.Add(this.btn29);
			this.UiGroupBox1.Controls.Add(this.btn4);
			this.UiGroupBox1.Controls.Add(this.btn22);
			this.UiGroupBox1.Controls.Add(this.btn9);
			this.UiGroupBox1.Controls.Add(this.btn15);
			this.UiGroupBox1.Controls.Add(this.btn3);
			this.UiGroupBox1.Controls.Add(this.btn8);
			this.UiGroupBox1.Controls.Add(this.btn2);
			this.UiGroupBox1.Controls.Add(this.btn1);
			this.UiGroupBox1.Controls.Add(this.Label7);
			this.UiGroupBox1.Controls.Add(this.Label6);
			this.UiGroupBox1.Controls.Add(this.Label5);
			this.UiGroupBox1.Controls.Add(this.Label4);
			this.UiGroupBox1.Controls.Add(this.Label3);
			this.UiGroupBox1.Controls.Add(this.Label2);
			this.UiGroupBox1.Controls.Add(this.Label1);
			this.UiGroupBox1.Controls.Add(this.UiComboBox1);
			this.UiGroupBox1.Controls.Add(this.IntegerUpDown1);
			this.UiGroupBox1.Dock = DockStyle.Fill;
			this.UiGroupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
			this.UiGroupBox1.FrameStyle = Janus.Windows.EditControls.FrameStyle.None;
			Control arg_716_0 = this.UiGroupBox1;
			Point location = new Point(0, 0);
			arg_716_0.Location = location;
			this.UiGroupBox1.Name = "UiGroupBox1";
			Control arg_747_0 = this.UiGroupBox1;
			Size size = new Size(263, 275);
			arg_747_0.Size = size;
			this.UiGroupBox1.TabIndex = 0;
			this.UiGroupBox1.VisualStyle = PanelVisualStyle.Office2010;
			this.LinkLabel1.AutoSize = true;
			this.LinkLabel1.BackColor = Color.Transparent;
			this.LinkLabel1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_7BE_0 = this.LinkLabel1;
			location = new Point(12, 242);
			arg_7BE_0.Location = location;
			this.LinkLabel1.Name = "LinkLabel1";
			Control arg_7E8_0 = this.LinkLabel1;
			size = new Size(0, 28);
			arg_7E8_0.Size = size;
			this.LinkLabel1.TabIndex = 4;
			this.btn35.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_833_0 = this.btn35;
			location = new Point(7, 203);
			arg_833_0.Location = location;
			this.btn35.Name = "btn35";
			this.btn35.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
			this.btn35.RightToLeft = RightToLeft.Yes;
			Control arg_878_0 = this.btn35;
			size = new Size(33, 33);
			arg_878_0.Size = size;
			this.btn35.TabIndex = 3;
			this.btn35.Text = "35";
			this.btn35.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn34.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_8E2_0 = this.btn34;
			location = new Point(39, 203);
			arg_8E2_0.Location = location;
			this.btn34.Name = "btn34";
			this.btn34.RightToLeft = RightToLeft.Yes;
			Control arg_91A_0 = this.btn34;
			size = new Size(33, 33);
			arg_91A_0.Size = size;
			this.btn34.TabIndex = 3;
			this.btn34.Text = "34";
			this.btn34.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn33.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_984_0 = this.btn33;
			location = new Point(71, 203);
			arg_984_0.Location = location;
			this.btn33.Name = "btn33";
			this.btn33.RightToLeft = RightToLeft.Yes;
			Control arg_9BC_0 = this.btn33;
			size = new Size(33, 33);
			arg_9BC_0.Size = size;
			this.btn33.TabIndex = 3;
			this.btn33.Text = "33";
			this.btn33.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn28.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_A25_0 = this.btn28;
			location = new Point(7, 175);
			arg_A25_0.Location = location;
			this.btn28.Name = "btn28";
			this.btn28.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
			this.btn28.RightToLeft = RightToLeft.Yes;
			Control arg_A6A_0 = this.btn28;
			size = new Size(33, 33);
			arg_A6A_0.Size = size;
			this.btn28.TabIndex = 3;
			this.btn28.Text = "28";
			this.btn28.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn27.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_AD4_0 = this.btn27;
			location = new Point(39, 175);
			arg_AD4_0.Location = location;
			this.btn27.Name = "btn27";
			this.btn27.RightToLeft = RightToLeft.Yes;
			Control arg_B0C_0 = this.btn27;
			size = new Size(33, 33);
			arg_B0C_0.Size = size;
			this.btn27.TabIndex = 3;
			this.btn27.Text = "1";
			this.btn27.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn26.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_B76_0 = this.btn26;
			location = new Point(71, 175);
			arg_B76_0.Location = location;
			this.btn26.Name = "btn26";
			this.btn26.RightToLeft = RightToLeft.Yes;
			Control arg_BAE_0 = this.btn26;
			size = new Size(33, 33);
			arg_BAE_0.Size = size;
			this.btn26.TabIndex = 3;
			this.btn26.Text = "1";
			this.btn26.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn21.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_C17_0 = this.btn21;
			location = new Point(7, 146);
			arg_C17_0.Location = location;
			this.btn21.Name = "btn21";
			this.btn21.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
			this.btn21.RightToLeft = RightToLeft.Yes;
			Control arg_C5C_0 = this.btn21;
			size = new Size(33, 33);
			arg_C5C_0.Size = size;
			this.btn21.TabIndex = 3;
			this.btn21.Text = "21";
			this.btn21.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn20.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_CC6_0 = this.btn20;
			location = new Point(39, 145);
			arg_CC6_0.Location = location;
			this.btn20.Name = "btn20";
			this.btn20.RightToLeft = RightToLeft.Yes;
			Control arg_CFE_0 = this.btn20;
			size = new Size(33, 33);
			arg_CFE_0.Size = size;
			this.btn20.TabIndex = 3;
			this.btn20.Text = "1";
			this.btn20.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn19.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_D68_0 = this.btn19;
			location = new Point(71, 146);
			arg_D68_0.Location = location;
			this.btn19.Name = "btn19";
			this.btn19.RightToLeft = RightToLeft.Yes;
			Control arg_DA0_0 = this.btn19;
			size = new Size(33, 33);
			arg_DA0_0.Size = size;
			this.btn19.TabIndex = 3;
			this.btn19.Text = "1";
			this.btn19.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn32.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_E0A_0 = this.btn32;
			location = new Point(103, 203);
			arg_E0A_0.Location = location;
			this.btn32.Name = "btn32";
			this.btn32.RightToLeft = RightToLeft.Yes;
			Control arg_E42_0 = this.btn32;
			size = new Size(33, 33);
			arg_E42_0.Size = size;
			this.btn32.TabIndex = 3;
			this.btn32.Text = "32";
			this.btn32.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn14.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_EA8_0 = this.btn14;
			location = new Point(7, 117);
			arg_EA8_0.Location = location;
			this.btn14.Name = "btn14";
			this.btn14.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
			this.btn14.RightToLeft = RightToLeft.Yes;
			Control arg_EED_0 = this.btn14;
			size = new Size(33, 33);
			arg_EED_0.Size = size;
			this.btn14.TabIndex = 3;
			this.btn14.Text = "14";
			this.btn14.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn13.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_F54_0 = this.btn13;
			location = new Point(39, 117);
			arg_F54_0.Location = location;
			this.btn13.Name = "btn13";
			this.btn13.RightToLeft = RightToLeft.Yes;
			Control arg_F8C_0 = this.btn13;
			size = new Size(33, 33);
			arg_F8C_0.Size = size;
			this.btn13.TabIndex = 3;
			this.btn13.Text = "13";
			this.btn13.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn25.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_FF6_0 = this.btn25;
			location = new Point(103, 175);
			arg_FF6_0.Location = location;
			this.btn25.Name = "btn25";
			this.btn25.RightToLeft = RightToLeft.Yes;
			Control arg_102E_0 = this.btn25;
			size = new Size(33, 33);
			arg_102E_0.Size = size;
			this.btn25.TabIndex = 3;
			this.btn25.Text = "1";
			this.btn25.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn12.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1095_0 = this.btn12;
			location = new Point(71, 117);
			arg_1095_0.Location = location;
			this.btn12.Name = "btn12";
			this.btn12.RightToLeft = RightToLeft.Yes;
			Control arg_10CD_0 = this.btn12;
			size = new Size(33, 33);
			arg_10CD_0.Size = size;
			this.btn12.TabIndex = 3;
			this.btn12.Text = "12";
			this.btn12.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn18.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1137_0 = this.btn18;
			location = new Point(103, 146);
			arg_1137_0.Location = location;
			this.btn18.Name = "btn18";
			this.btn18.RightToLeft = RightToLeft.Yes;
			Control arg_116F_0 = this.btn18;
			size = new Size(33, 33);
			arg_116F_0.Size = size;
			this.btn18.TabIndex = 3;
			this.btn18.Text = "1";
			this.btn18.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn31.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_11DC_0 = this.btn31;
			location = new Point(135, 203);
			arg_11DC_0.Location = location;
			this.btn31.Name = "btn31";
			this.btn31.RightToLeft = RightToLeft.Yes;
			Control arg_1214_0 = this.btn31;
			size = new Size(33, 33);
			arg_1214_0.Size = size;
			this.btn31.TabIndex = 3;
			this.btn31.Text = "31";
			this.btn31.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn7.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_127A_0 = this.btn7;
			location = new Point(7, 88);
			arg_127A_0.Location = location;
			this.btn7.Name = "btn7";
			this.btn7.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
			this.btn7.RightToLeft = RightToLeft.Yes;
			Control arg_12BF_0 = this.btn7;
			size = new Size(33, 33);
			arg_12BF_0.Size = size;
			this.btn7.TabIndex = 3;
			this.btn7.Text = "7";
			this.btn7.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn6.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1326_0 = this.btn6;
			location = new Point(39, 88);
			arg_1326_0.Location = location;
			this.btn6.Name = "btn6";
			this.btn6.RightToLeft = RightToLeft.Yes;
			Control arg_135E_0 = this.btn6;
			size = new Size(33, 33);
			arg_135E_0.Size = size;
			this.btn6.TabIndex = 3;
			this.btn6.Text = "6";
			this.btn6.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn24.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_13CB_0 = this.btn24;
			location = new Point(135, 175);
			arg_13CB_0.Location = location;
			this.btn24.Name = "btn24";
			this.btn24.RightToLeft = RightToLeft.Yes;
			Control arg_1403_0 = this.btn24;
			size = new Size(33, 33);
			arg_1403_0.Size = size;
			this.btn24.TabIndex = 3;
			this.btn24.Text = "1";
			this.btn24.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn11.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_146A_0 = this.btn11;
			location = new Point(103, 117);
			arg_146A_0.Location = location;
			this.btn11.Name = "btn11";
			this.btn11.RightToLeft = RightToLeft.Yes;
			Control arg_14A2_0 = this.btn11;
			size = new Size(33, 33);
			arg_14A2_0.Size = size;
			this.btn11.TabIndex = 3;
			this.btn11.Text = "11";
			this.btn11.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn17.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_150F_0 = this.btn17;
			location = new Point(135, 146);
			arg_150F_0.Location = location;
			this.btn17.Name = "btn17";
			this.btn17.RightToLeft = RightToLeft.Yes;
			Control arg_1547_0 = this.btn17;
			size = new Size(33, 33);
			arg_1547_0.Size = size;
			this.btn17.TabIndex = 3;
			this.btn17.Text = "1";
			this.btn17.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn30.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_15B4_0 = this.btn30;
			location = new Point(167, 203);
			arg_15B4_0.Location = location;
			this.btn30.Name = "btn30";
			this.btn30.RightToLeft = RightToLeft.Yes;
			Control arg_15EC_0 = this.btn30;
			size = new Size(33, 33);
			arg_15EC_0.Size = size;
			this.btn30.TabIndex = 3;
			this.btn30.Text = "30";
			this.btn30.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn5.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1653_0 = this.btn5;
			location = new Point(71, 88);
			arg_1653_0.Location = location;
			this.btn5.Name = "btn5";
			this.btn5.RightToLeft = RightToLeft.Yes;
			Control arg_168B_0 = this.btn5;
			size = new Size(33, 33);
			arg_168B_0.Size = size;
			this.btn5.TabIndex = 3;
			this.btn5.Text = "5";
			this.btn5.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn23.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_16F8_0 = this.btn23;
			location = new Point(167, 175);
			arg_16F8_0.Location = location;
			this.btn23.Name = "btn23";
			this.btn23.RightToLeft = RightToLeft.Yes;
			Control arg_1730_0 = this.btn23;
			size = new Size(33, 33);
			arg_1730_0.Size = size;
			this.btn23.TabIndex = 3;
			this.btn23.Text = "1";
			this.btn23.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn10.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_179A_0 = this.btn10;
			location = new Point(135, 117);
			arg_179A_0.Location = location;
			this.btn10.Name = "btn10";
			this.btn10.RightToLeft = RightToLeft.Yes;
			Control arg_17D2_0 = this.btn10;
			size = new Size(33, 33);
			arg_17D2_0.Size = size;
			this.btn10.TabIndex = 3;
			this.btn10.Text = "10";
			this.btn10.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn16.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_183F_0 = this.btn16;
			location = new Point(167, 145);
			arg_183F_0.Location = location;
			this.btn16.Name = "btn16";
			this.btn16.RightToLeft = RightToLeft.Yes;
			Control arg_1877_0 = this.btn16;
			size = new Size(33, 33);
			arg_1877_0.Size = size;
			this.btn16.TabIndex = 3;
			this.btn16.Text = "1";
			this.btn16.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn29.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_18E4_0 = this.btn29;
			location = new Point(199, 203);
			arg_18E4_0.Location = location;
			this.btn29.Name = "btn29";
			this.btn29.RightToLeft = RightToLeft.Yes;
			Control arg_191C_0 = this.btn29;
			size = new Size(33, 33);
			arg_191C_0.Size = size;
			this.btn29.TabIndex = 3;
			this.btn29.Text = "29";
			this.btn29.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn4.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1983_0 = this.btn4;
			location = new Point(103, 88);
			arg_1983_0.Location = location;
			this.btn4.Name = "btn4";
			this.btn4.RightToLeft = RightToLeft.Yes;
			Control arg_19BB_0 = this.btn4;
			size = new Size(33, 33);
			arg_19BB_0.Size = size;
			this.btn4.TabIndex = 3;
			this.btn4.Text = "4";
			this.btn4.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn22.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1A28_0 = this.btn22;
			location = new Point(199, 175);
			arg_1A28_0.Location = location;
			this.btn22.Name = "btn22";
			this.btn22.RightToLeft = RightToLeft.Yes;
			Control arg_1A60_0 = this.btn22;
			size = new Size(33, 33);
			arg_1A60_0.Size = size;
			this.btn22.TabIndex = 3;
			this.btn22.Text = "24";
			this.btn22.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn9.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1ACA_0 = this.btn9;
			location = new Point(167, 117);
			arg_1ACA_0.Location = location;
			this.btn9.Name = "btn9";
			this.btn9.RightToLeft = RightToLeft.Yes;
			Control arg_1B02_0 = this.btn9;
			size = new Size(33, 33);
			arg_1B02_0.Size = size;
			this.btn9.TabIndex = 3;
			this.btn9.Text = "9";
			this.btn9.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn15.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1B6F_0 = this.btn15;
			location = new Point(199, 146);
			arg_1B6F_0.Location = location;
			this.btn15.Name = "btn15";
			this.btn15.RightToLeft = RightToLeft.Yes;
			Control arg_1BA7_0 = this.btn15;
			size = new Size(33, 33);
			arg_1BA7_0.Size = size;
			this.btn15.TabIndex = 3;
			this.btn15.Text = "15";
			this.btn15.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn3.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1C11_0 = this.btn3;
			location = new Point(135, 88);
			arg_1C11_0.Location = location;
			this.btn3.Name = "btn3";
			this.btn3.RightToLeft = RightToLeft.Yes;
			Control arg_1C49_0 = this.btn3;
			size = new Size(33, 33);
			arg_1C49_0.Size = size;
			this.btn3.TabIndex = 3;
			this.btn3.Text = "3";
			this.btn3.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn8.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1CB3_0 = this.btn8;
			location = new Point(199, 117);
			arg_1CB3_0.Location = location;
			this.btn8.Name = "btn8";
			this.btn8.RightToLeft = RightToLeft.Yes;
			Control arg_1CEB_0 = this.btn8;
			size = new Size(33, 33);
			arg_1CEB_0.Size = size;
			this.btn8.TabIndex = 3;
			this.btn8.Text = "8";
			this.btn8.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn2.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1D55_0 = this.btn2;
			location = new Point(167, 88);
			arg_1D55_0.Location = location;
			this.btn2.Name = "btn2";
			this.btn2.RightToLeft = RightToLeft.Yes;
			Control arg_1D8D_0 = this.btn2;
			size = new Size(33, 33);
			arg_1D8D_0.Size = size;
			this.btn2.TabIndex = 3;
			this.btn2.Text = "2";
			this.btn2.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.btn1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1DF7_0 = this.btn1;
			location = new Point(199, 88);
			arg_1DF7_0.Location = location;
			this.btn1.Name = "btn1";
			this.btn1.RightToLeft = RightToLeft.Yes;
			Control arg_1E2F_0 = this.btn1;
			size = new Size(33, 33);
			arg_1E2F_0.Size = size;
			this.btn1.TabIndex = 3;
			this.btn1.Text = "1";
			this.btn1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.Label7.AutoSize = true;
			this.Label7.BackColor = Color.Transparent;
			this.Label7.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1EB4_0 = this.Label7;
			location = new Point(13, 56);
			arg_1EB4_0.Location = location;
			this.Label7.Name = "Label7";
			Control arg_1EDF_0 = this.Label7;
			size = new Size(24, 28);
			arg_1EDF_0.Size = size;
			this.Label7.TabIndex = 2;
			this.Label7.Text = "ج";
			this.Label6.AutoSize = true;
			this.Label6.BackColor = Color.Transparent;
			this.Label6.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1F57_0 = this.Label6;
			location = new Point(41, 56);
			arg_1F57_0.Location = location;
			this.Label6.Name = "Label6";
			Control arg_1F82_0 = this.Label6;
			size = new Size(27, 28);
			arg_1F82_0.Size = size;
			this.Label6.TabIndex = 2;
			this.Label6.Text = "پ";
			this.Label5.AutoSize = true;
			this.Label5.BackColor = Color.Transparent;
			this.Label5.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_1FFA_0 = this.Label5;
			location = new Point(75, 56);
			arg_1FFA_0.Location = location;
			this.Label5.Name = "Label5";
			Control arg_2025_0 = this.Label5;
			size = new Size(24, 28);
			arg_2025_0.Size = size;
			this.Label5.TabIndex = 2;
			this.Label5.Text = "چ";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = Color.Transparent;
			this.Label4.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_209D_0 = this.Label4;
			location = new Point(102, 56);
			arg_209D_0.Location = location;
			this.Label4.Name = "Label4";
			Control arg_20C8_0 = this.Label4;
			size = new Size(32, 28);
			arg_20C8_0.Size = size;
			this.Label4.TabIndex = 2;
			this.Label4.Text = "س";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = Color.Transparent;
			this.Label3.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_2143_0 = this.Label3;
			location = new Point(140, 56);
			arg_2143_0.Location = location;
			this.Label3.Name = "Label3";
			Control arg_216E_0 = this.Label3;
			size = new Size(19, 28);
			arg_216E_0.Size = size;
			this.Label3.TabIndex = 2;
			this.Label3.Text = "د";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = Color.Transparent;
			this.Label2.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_21E9_0 = this.Label2;
			location = new Point(169, 56);
			arg_21E9_0.Location = location;
			this.Label2.Name = "Label2";
			Control arg_2214_0 = this.Label2;
			size = new Size(26, 28);
			arg_2214_0.Size = size;
			this.Label2.TabIndex = 2;
			this.Label2.Text = "ی";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = Color.Transparent;
			this.Label1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_228F_0 = this.Label1;
			location = new Point(200, 56);
			arg_228F_0.Location = location;
			this.Label1.Name = "Label1";
			Control arg_22BA_0 = this.Label1;
			size = new Size(32, 28);
			arg_22BA_0.Size = size;
			this.Label1.TabIndex = 2;
			this.Label1.Text = "ش";
			this.UiComboBox1.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.UiComboBox1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			uIComboBoxItem.FormatStyle.Alpha = 0;
			uIComboBoxItem.IsSeparator = false;
			uIComboBoxItem.Text = "فروردین";
			uIComboBoxItem.Value = "1";
			uIComboBoxItem2.FormatStyle.Alpha = 0;
			uIComboBoxItem2.IsSeparator = false;
			uIComboBoxItem2.Text = "اردیبهشت";
			uIComboBoxItem2.Value = "2";
			uIComboBoxItem3.FormatStyle.Alpha = 0;
			uIComboBoxItem3.IsSeparator = false;
			uIComboBoxItem3.Text = "خرداد";
			uIComboBoxItem3.Value = "3";
			uIComboBoxItem4.FormatStyle.Alpha = 0;
			uIComboBoxItem4.IsSeparator = false;
			uIComboBoxItem4.Text = "تیر";
			uIComboBoxItem4.Value = "4";
			uIComboBoxItem5.FormatStyle.Alpha = 0;
			uIComboBoxItem5.IsSeparator = false;
			uIComboBoxItem5.Text = "مرداد";
			uIComboBoxItem5.Value = "5";
			uIComboBoxItem6.FormatStyle.Alpha = 0;
			uIComboBoxItem6.IsSeparator = false;
			uIComboBoxItem6.Text = "شهریور";
			uIComboBoxItem6.Value = "6";
			uIComboBoxItem7.FormatStyle.Alpha = 0;
			uIComboBoxItem7.IsSeparator = false;
			uIComboBoxItem7.Text = "مهر";
			uIComboBoxItem7.Value = "7";
			uIComboBoxItem8.FormatStyle.Alpha = 0;
			uIComboBoxItem8.IsSeparator = false;
			uIComboBoxItem8.Text = "آبان";
			uIComboBoxItem8.Value = "8";
			uIComboBoxItem9.FormatStyle.Alpha = 0;
			uIComboBoxItem9.IsSeparator = false;
			uIComboBoxItem9.Text = "آذر";
			uIComboBoxItem9.Value = "9";
			uIComboBoxItem10.FormatStyle.Alpha = 0;
			uIComboBoxItem10.IsSeparator = false;
			uIComboBoxItem10.Text = "دی";
			uIComboBoxItem10.Value = "10";
			uIComboBoxItem11.FormatStyle.Alpha = 0;
			uIComboBoxItem11.IsSeparator = false;
			uIComboBoxItem11.Text = "بهمن";
			uIComboBoxItem11.Value = "11";
			uIComboBoxItem12.FormatStyle.Alpha = 0;
			uIComboBoxItem12.IsSeparator = false;
			uIComboBoxItem12.Text = "اسفند";
			uIComboBoxItem12.Value = "12";
			this.UiComboBox1.Items.AddRange(new UIComboBoxItem[]
			{
				uIComboBoxItem,
				uIComboBoxItem2,
				uIComboBoxItem3,
				uIComboBoxItem4,
				uIComboBoxItem5,
				uIComboBoxItem6,
				uIComboBoxItem7,
				uIComboBoxItem8,
				uIComboBoxItem9,
				uIComboBoxItem10,
				uIComboBoxItem11,
				uIComboBoxItem12
			});
			Control arg_25CC_0 = this.UiComboBox1;
			location = new Point(88, 13);
			arg_25CC_0.Location = location;
			this.UiComboBox1.Name = "UiComboBox1";
			Control arg_25FA_0 = this.UiComboBox1;
			size = new Size(144, 36);
			arg_25FA_0.Size = size;
			this.UiComboBox1.TabIndex = 1;
			this.UiComboBox1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010;
			this.IntegerUpDown1.Font = new Font("Mitra", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 178);
			Control arg_2650_0 = this.IntegerUpDown1;
			location = new Point(14, 13);
			arg_2650_0.Location = location;
			this.IntegerUpDown1.Maximum = 1450;
			this.IntegerUpDown1.Minimum = 1300;
			this.IntegerUpDown1.Name = "IntegerUpDown1";
			this.IntegerUpDown1.RightToLeft = RightToLeft.Yes;
			Control arg_26AA_0 = this.IntegerUpDown1;
			size = new Size(68, 36);
			arg_26AA_0.Size = size;
			this.IntegerUpDown1.TabIndex = 0;
			this.IntegerUpDown1.Value = 1391;
			this.IntegerUpDown1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010;
			this.Panel1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.Panel1.BackColor = Color.Transparent;
			this.Panel1.Controls.Add(this.UiGroupBox1);
			Control arg_2723_0 = this.Panel1;
			location = new Point(0, 0);
			arg_2723_0.Location = location;
			this.Panel1.Name = "Panel1";
			Control arg_2754_0 = this.Panel1;
			size = new Size(263, 275);
			arg_2754_0.Size = size;
			this.Panel1.TabIndex = 5;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleDimensions = autoScaleDimensions;
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.Panel1);
			this.Name = "DatePanel";
			size = new Size(263, 275);
			this.Size = size;
			((ISupportInitialize)this.UiGroupBox1).EndInit();
			this.UiGroupBox1.ResumeLayout(false);
			this.UiGroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x000A3424 File Offset: 0x000A1624
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00004A25 File Offset: 0x00002C25
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

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x000A343C File Offset: 0x000A163C
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x000A3454 File Offset: 0x000A1654
		internal virtual IntegerUpDown IntegerUpDown1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._IntegerUpDown1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.IntegerUpDown1_ValueChanged);
				bool flag = this._IntegerUpDown1 != null;
				if (flag)
				{
					this._IntegerUpDown1.ValueChanged -= value2;
				}
				this._IntegerUpDown1 = value;
				flag = (this._IntegerUpDown1 != null);
				if (flag)
				{
					this._IntegerUpDown1.ValueChanged += value2;
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x000A34B4 File Offset: 0x000A16B4
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x000A34CC File Offset: 0x000A16CC
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
				EventHandler value2 = new EventHandler(this.UiComboBox1_SelectedValueChanged);
				bool flag = this._UiComboBox1 != null;
				if (flag)
				{
					this._UiComboBox1.SelectedValueChanged -= value2;
				}
				this._UiComboBox1 = value;
				flag = (this._UiComboBox1 != null);
				if (flag)
				{
					this._UiComboBox1.SelectedValueChanged += value2;
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x000A352C File Offset: 0x000A172C
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00004A2F File Offset: 0x00002C2F
		internal virtual UIButton btn35
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn35;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn35 = value;
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000A3544 File Offset: 0x000A1744
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00004A39 File Offset: 0x00002C39
		internal virtual UIButton btn34
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn34;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn34 = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x000A355C File Offset: 0x000A175C
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00004A43 File Offset: 0x00002C43
		internal virtual UIButton btn33
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn33;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn33 = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x000A3574 File Offset: 0x000A1774
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00004A4D File Offset: 0x00002C4D
		internal virtual UIButton btn28
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn28;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn28 = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x000A358C File Offset: 0x000A178C
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00004A57 File Offset: 0x00002C57
		internal virtual UIButton btn27
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn27;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn27 = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x000A35A4 File Offset: 0x000A17A4
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00004A61 File Offset: 0x00002C61
		internal virtual UIButton btn26
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn26;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn26 = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x000A35BC File Offset: 0x000A17BC
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00004A6B File Offset: 0x00002C6B
		internal virtual UIButton btn21
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn21;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn21 = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x000A35D4 File Offset: 0x000A17D4
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00004A75 File Offset: 0x00002C75
		internal virtual UIButton btn20
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn20;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn20 = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x000A35EC File Offset: 0x000A17EC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00004A7F File Offset: 0x00002C7F
		internal virtual UIButton btn19
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn19;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn19 = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x000A3604 File Offset: 0x000A1804
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00004A89 File Offset: 0x00002C89
		internal virtual UIButton btn32
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn32;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn32 = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x000A361C File Offset: 0x000A181C
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00004A93 File Offset: 0x00002C93
		internal virtual UIButton btn14
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn14;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn14 = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x000A3634 File Offset: 0x000A1834
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00004A9D File Offset: 0x00002C9D
		internal virtual UIButton btn13
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn13;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn13 = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x000A364C File Offset: 0x000A184C
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00004AA7 File Offset: 0x00002CA7
		internal virtual UIButton btn25
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn25;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn25 = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x000A3664 File Offset: 0x000A1864
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00004AB1 File Offset: 0x00002CB1
		internal virtual UIButton btn12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn12 = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x000A367C File Offset: 0x000A187C
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x00004ABB File Offset: 0x00002CBB
		internal virtual UIButton btn18
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn18;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn18 = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x000A3694 File Offset: 0x000A1894
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x00004AC5 File Offset: 0x00002CC5
		internal virtual UIButton btn31
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn31;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn31 = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x000A36AC File Offset: 0x000A18AC
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x00004ACF File Offset: 0x00002CCF
		internal virtual UIButton btn7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn7 = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x000A36C4 File Offset: 0x000A18C4
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x00004AD9 File Offset: 0x00002CD9
		internal virtual UIButton btn6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn6 = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x000A36DC File Offset: 0x000A18DC
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x00004AE3 File Offset: 0x00002CE3
		internal virtual UIButton btn24
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn24;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn24 = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000A36F4 File Offset: 0x000A18F4
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x00004AED File Offset: 0x00002CED
		internal virtual UIButton btn11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn11 = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000A370C File Offset: 0x000A190C
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x00004AF7 File Offset: 0x00002CF7
		internal virtual UIButton btn17
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn17;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn17 = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000A3724 File Offset: 0x000A1924
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x00004B01 File Offset: 0x00002D01
		internal virtual UIButton btn30
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn30;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn30 = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000A373C File Offset: 0x000A193C
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x00004B0B File Offset: 0x00002D0B
		internal virtual UIButton btn5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn5 = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000A3754 File Offset: 0x000A1954
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00004B15 File Offset: 0x00002D15
		internal virtual UIButton btn23
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn23;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn23 = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000A376C File Offset: 0x000A196C
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00004B1F File Offset: 0x00002D1F
		internal virtual UIButton btn10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn10 = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000A3784 File Offset: 0x000A1984
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00004B29 File Offset: 0x00002D29
		internal virtual UIButton btn16
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn16;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn16 = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000D41 RID: 3393 RVA: 0x000A379C File Offset: 0x000A199C
		// (set) Token: 0x06000D42 RID: 3394 RVA: 0x00004B33 File Offset: 0x00002D33
		internal virtual UIButton btn29
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn29;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn29 = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000D43 RID: 3395 RVA: 0x000A37B4 File Offset: 0x000A19B4
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00004B3D File Offset: 0x00002D3D
		internal virtual UIButton btn4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn4 = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000A37CC File Offset: 0x000A19CC
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00004B47 File Offset: 0x00002D47
		internal virtual UIButton btn22
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn22;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn22 = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x000A37E4 File Offset: 0x000A19E4
		// (set) Token: 0x06000D48 RID: 3400 RVA: 0x00004B51 File Offset: 0x00002D51
		internal virtual UIButton btn9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn9 = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000A37FC File Offset: 0x000A19FC
		// (set) Token: 0x06000D4A RID: 3402 RVA: 0x00004B5B File Offset: 0x00002D5B
		internal virtual UIButton btn15
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn15;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn15 = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D4B RID: 3403 RVA: 0x000A3814 File Offset: 0x000A1A14
		// (set) Token: 0x06000D4C RID: 3404 RVA: 0x00004B65 File Offset: 0x00002D65
		internal virtual UIButton btn3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn3 = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x000A382C File Offset: 0x000A1A2C
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x00004B6F File Offset: 0x00002D6F
		internal virtual UIButton btn8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn8 = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D4F RID: 3407 RVA: 0x000A3844 File Offset: 0x000A1A44
		// (set) Token: 0x06000D50 RID: 3408 RVA: 0x00004B79 File Offset: 0x00002D79
		internal virtual UIButton btn2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn2 = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D51 RID: 3409 RVA: 0x000A385C File Offset: 0x000A1A5C
		// (set) Token: 0x06000D52 RID: 3410 RVA: 0x00004B83 File Offset: 0x00002D83
		internal virtual UIButton btn1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btn1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btn1 = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D53 RID: 3411 RVA: 0x000A3874 File Offset: 0x000A1A74
		// (set) Token: 0x06000D54 RID: 3412 RVA: 0x00004B8D File Offset: 0x00002D8D
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D55 RID: 3413 RVA: 0x000A388C File Offset: 0x000A1A8C
		// (set) Token: 0x06000D56 RID: 3414 RVA: 0x00004B97 File Offset: 0x00002D97
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000A38A4 File Offset: 0x000A1AA4
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00004BA1 File Offset: 0x00002DA1
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D59 RID: 3417 RVA: 0x000A38BC File Offset: 0x000A1ABC
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00004BAB File Offset: 0x00002DAB
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x000A38D4 File Offset: 0x000A1AD4
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00004BB5 File Offset: 0x00002DB5
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

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x000A38EC File Offset: 0x000A1AEC
		// (set) Token: 0x06000D5E RID: 3422 RVA: 0x00004BBF File Offset: 0x00002DBF
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

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x000A3904 File Offset: 0x000A1B04
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x00004BC9 File Offset: 0x00002DC9
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

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x000A391C File Offset: 0x000A1B1C
		// (set) Token: 0x06000D62 RID: 3426 RVA: 0x000A3934 File Offset: 0x000A1B34
		internal virtual LinkLabel LinkLabel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LinkLabel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				LinkLabelLinkClickedEventHandler value2 = new LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
				bool flag = this._LinkLabel1 != null;
				if (flag)
				{
					this._LinkLabel1.LinkClicked -= value2;
				}
				this._LinkLabel1 = value;
				flag = (this._LinkLabel1 != null);
				if (flag)
				{
					this._LinkLabel1.LinkClicked += value2;
				}
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x000A3994 File Offset: 0x000A1B94
		// (set) Token: 0x06000D64 RID: 3428 RVA: 0x00004BD3 File Offset: 0x00002DD3
		internal virtual Panel Panel1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Panel1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Panel1 = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000A39AC File Offset: 0x000A1BAC
		// (set) Token: 0x06000D66 RID: 3430 RVA: 0x00004BDD File Offset: 0x00002DDD
		public DateBox2 DateBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DateBox;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DateBox = value;
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000A39C4 File Offset: 0x000A1BC4
		public DatePanel()
		{
			DatePanel.__ENCAddToList(this);
			this.btn = new UIButton[36];
			this.p = new PersianCalendar();
			this.InitializeComponent();
			this.btn[1] = this.btn1;
			this.btn[2] = this.btn2;
			this.btn[3] = this.btn3;
			this.btn[4] = this.btn4;
			this.btn[5] = this.btn5;
			this.btn[6] = this.btn6;
			this.btn[7] = this.btn7;
			this.btn[8] = this.btn8;
			this.btn[9] = this.btn9;
			this.btn[10] = this.btn10;
			this.btn[11] = this.btn11;
			this.btn[12] = this.btn12;
			this.btn[13] = this.btn13;
			this.btn[14] = this.btn14;
			this.btn[15] = this.btn15;
			this.btn[16] = this.btn16;
			this.btn[17] = this.btn17;
			this.btn[18] = this.btn18;
			this.btn[19] = this.btn19;
			this.btn[20] = this.btn20;
			this.btn[21] = this.btn21;
			this.btn[22] = this.btn22;
			this.btn[23] = this.btn23;
			this.btn[24] = this.btn24;
			this.btn[25] = this.btn25;
			this.btn[26] = this.btn26;
			this.btn[27] = this.btn27;
			this.btn[28] = this.btn28;
			this.btn[29] = this.btn29;
			this.btn[30] = this.btn30;
			this.btn[31] = this.btn31;
			this.btn[32] = this.btn32;
			this.btn[33] = this.btn33;
			this.btn[34] = this.btn34;
			this.btn[35] = this.btn35;
			int num = 1;
			checked
			{
				int arg_27F_0;
				int num2;
				do
				{
					this.btn[num].Click += new EventHandler(this.btn1_Click);
					num++;
					arg_27F_0 = num;
					num2 = 35;
				}
				while (arg_27F_0 <= num2);
				string[] array = Public_Function.MiladiToShamsi(DateAndTime.Now).Split(new char[]
				{
					'/'
				});
				this.curday = Conversions.ToInteger(array[2]);
				this.curmonth = Conversions.ToInteger(array[1]);
				this.curyear = Conversions.ToInteger(array[0]);
				int num3 = (int)(this.p.GetDayOfWeek(DateAndTime.Now) + 2);
				bool flag = num3 == 8;
				if (flag)
				{
					num3 = 1;
				}
				this.LinkLabel1.Text = string.Concat(new string[]
				{
					"امروز ",
					Public_Function.GetDayName(num3),
					" ",
					array[2],
					" ",
					Public_Function.GetMonthName(Conversions.ToInteger(array[1])),
					" ",
					array[0]
				});
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x000A3D2C File Offset: 0x000A1F2C
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00004BE7 File Offset: 0x00002DE7
		public int Sal
		{
			get
			{
				return this._Sal;
			}
			set
			{
				this._Sal = value;
				this.IntegerUpDown1.Value = this._Sal;
				this.SetDate();
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x000A3D44 File Offset: 0x000A1F44
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00004C0B File Offset: 0x00002E0B
		public int Mah
		{
			get
			{
				return this._Mah;
			}
			set
			{
				this._Mah = value;
				this.UiComboBox1.SelectedValue = value.ToString();
				this.SetDate();
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000A3D5C File Offset: 0x000A1F5C
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00004C30 File Offset: 0x00002E30
		public int Ruz
		{
			get
			{
				return this._Ruz;
			}
			set
			{
				this._Ruz = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x000A3D74 File Offset: 0x000A1F74
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00004C3B File Offset: 0x00002E3B
		public ToolStripDropDown DropDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DropDown;
			}
			[DebuggerNonUserCode]
			set
			{
				this._DropDown = value;
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000A3D8C File Offset: 0x000A1F8C
		public void SetDate()
		{
			bool flag = this.Sal == 0;
			checked
			{
				if (!flag)
				{
					flag = (this.Mah == 0);
					if (!flag)
					{
						this._day = (int)this.p.GetDayOfWeek(Conversions.ToDate(Public_Function.ShamsiToMiladi(Conversions.ToString(this.Sal) + "/" + Conversions.ToString(this.Mah) + "/1")));
						int daysInMonth = this.p.GetDaysInMonth(this.Sal, this.Mah);
						this._day += 2;
						flag = (this._day == 8);
						if (flag)
						{
							this._day = 1;
						}
						int num = 1;
						int num2 = 1;
						int arg_1AD_0;
						int num3;
						do
						{
							flag = (num2 >= this._day && num <= daysInMonth);
							if (flag)
							{
								this.btn[num2].Visible = true;
								this.btn[num2].Text = Conversions.ToString(num);
								num++;
								flag = (this.btn[num2].OfficeCustomColor == Color.LawnGreen);
								if (flag)
								{
									this.btn[num2].OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Default;
								}
							}
							else
							{
								this.btn[num2].Visible = false;
							}
							flag = (this.Sal == this.curyear && this.Mah == this.curmonth && num - 1 == this.curday);
							if (flag)
							{
								this.btn[num2].OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Custom;
								this.btn[num2].OfficeCustomColor = Color.LawnGreen;
							}
							else
							{
								flag = (num2 % 7 == 0);
								if (flag)
								{
									this.btn[num2].OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Silver;
								}
							}
							num2++;
							arg_1AD_0 = num2;
							num3 = 35;
						}
						while (arg_1AD_0 <= num3);
					}
				}
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x000A3F4C File Offset: 0x000A214C
		private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			bool flag = this.DateBox != null;
			if (flag)
			{
				this.DateBox.SetDate(Public_Function.MiladiToShamsi(DateAndTime.Now));
			}
			this.DropDown.Hide();
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x000A3F90 File Offset: 0x000A2190
		private void btn1_Click(object sender, EventArgs e)
		{
			this.Ruz = Conversions.ToInteger(((UIButton)sender).Text);
			bool flag = this.DateBox != null;
			if (flag)
			{
				this.DateBox.SetDate(string.Concat(new string[]
				{
					Conversions.ToString(this.Sal),
					"/",
					Strings.Format(this.Mah, "00"),
					"/",
					Strings.Format(this.Ruz, "00")
				}));
			}
			this.DropDown.Hide();
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00004C45 File Offset: 0x00002E45
		private void IntegerUpDown1_ValueChanged(object sender, EventArgs e)
		{
			this.Sal = this.IntegerUpDown1.Value;
			this.SetDate();
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00004C62 File Offset: 0x00002E62
		private void UiComboBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			this.Mah = Conversions.ToInteger(this.UiComboBox1.SelectedValue);
			this.SetDate();
		}

		// Token: 0x040004FA RID: 1274
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		// Token: 0x040004FB RID: 1275
		private IContainer components;

		// Token: 0x040004FC RID: 1276
		[AccessedThroughProperty("UiGroupBox1")]
		private UIGroupBox _UiGroupBox1;

		// Token: 0x040004FD RID: 1277
		[AccessedThroughProperty("IntegerUpDown1")]
		private IntegerUpDown _IntegerUpDown1;

		// Token: 0x040004FE RID: 1278
		[AccessedThroughProperty("UiComboBox1")]
		private UIComboBox _UiComboBox1;

		// Token: 0x040004FF RID: 1279
		[AccessedThroughProperty("btn35")]
		private UIButton _btn35;

		// Token: 0x04000500 RID: 1280
		[AccessedThroughProperty("btn34")]
		private UIButton _btn34;

		// Token: 0x04000501 RID: 1281
		[AccessedThroughProperty("btn33")]
		private UIButton _btn33;

		// Token: 0x04000502 RID: 1282
		[AccessedThroughProperty("btn28")]
		private UIButton _btn28;

		// Token: 0x04000503 RID: 1283
		[AccessedThroughProperty("btn27")]
		private UIButton _btn27;

		// Token: 0x04000504 RID: 1284
		[AccessedThroughProperty("btn26")]
		private UIButton _btn26;

		// Token: 0x04000505 RID: 1285
		[AccessedThroughProperty("btn21")]
		private UIButton _btn21;

		// Token: 0x04000506 RID: 1286
		[AccessedThroughProperty("btn20")]
		private UIButton _btn20;

		// Token: 0x04000507 RID: 1287
		[AccessedThroughProperty("btn19")]
		private UIButton _btn19;

		// Token: 0x04000508 RID: 1288
		[AccessedThroughProperty("btn32")]
		private UIButton _btn32;

		// Token: 0x04000509 RID: 1289
		[AccessedThroughProperty("btn14")]
		private UIButton _btn14;

		// Token: 0x0400050A RID: 1290
		[AccessedThroughProperty("btn13")]
		private UIButton _btn13;

		// Token: 0x0400050B RID: 1291
		[AccessedThroughProperty("btn25")]
		private UIButton _btn25;

		// Token: 0x0400050C RID: 1292
		[AccessedThroughProperty("btn12")]
		private UIButton _btn12;

		// Token: 0x0400050D RID: 1293
		[AccessedThroughProperty("btn18")]
		private UIButton _btn18;

		// Token: 0x0400050E RID: 1294
		[AccessedThroughProperty("btn31")]
		private UIButton _btn31;

		// Token: 0x0400050F RID: 1295
		[AccessedThroughProperty("btn7")]
		private UIButton _btn7;

		// Token: 0x04000510 RID: 1296
		[AccessedThroughProperty("btn6")]
		private UIButton _btn6;

		// Token: 0x04000511 RID: 1297
		[AccessedThroughProperty("btn24")]
		private UIButton _btn24;

		// Token: 0x04000512 RID: 1298
		[AccessedThroughProperty("btn11")]
		private UIButton _btn11;

		// Token: 0x04000513 RID: 1299
		[AccessedThroughProperty("btn17")]
		private UIButton _btn17;

		// Token: 0x04000514 RID: 1300
		[AccessedThroughProperty("btn30")]
		private UIButton _btn30;

		// Token: 0x04000515 RID: 1301
		[AccessedThroughProperty("btn5")]
		private UIButton _btn5;

		// Token: 0x04000516 RID: 1302
		[AccessedThroughProperty("btn23")]
		private UIButton _btn23;

		// Token: 0x04000517 RID: 1303
		[AccessedThroughProperty("btn10")]
		private UIButton _btn10;

		// Token: 0x04000518 RID: 1304
		[AccessedThroughProperty("btn16")]
		private UIButton _btn16;

		// Token: 0x04000519 RID: 1305
		[AccessedThroughProperty("btn29")]
		private UIButton _btn29;

		// Token: 0x0400051A RID: 1306
		[AccessedThroughProperty("btn4")]
		private UIButton _btn4;

		// Token: 0x0400051B RID: 1307
		[AccessedThroughProperty("btn22")]
		private UIButton _btn22;

		// Token: 0x0400051C RID: 1308
		[AccessedThroughProperty("btn9")]
		private UIButton _btn9;

		// Token: 0x0400051D RID: 1309
		[AccessedThroughProperty("btn15")]
		private UIButton _btn15;

		// Token: 0x0400051E RID: 1310
		[AccessedThroughProperty("btn3")]
		private UIButton _btn3;

		// Token: 0x0400051F RID: 1311
		[AccessedThroughProperty("btn8")]
		private UIButton _btn8;

		// Token: 0x04000520 RID: 1312
		[AccessedThroughProperty("btn2")]
		private UIButton _btn2;

		// Token: 0x04000521 RID: 1313
		[AccessedThroughProperty("btn1")]
		private UIButton _btn1;

		// Token: 0x04000522 RID: 1314
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000523 RID: 1315
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000524 RID: 1316
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000525 RID: 1317
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000526 RID: 1318
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000527 RID: 1319
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000528 RID: 1320
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000529 RID: 1321
		[AccessedThroughProperty("LinkLabel1")]
		private LinkLabel _LinkLabel1;

		// Token: 0x0400052A RID: 1322
		[AccessedThroughProperty("Panel1")]
		private Panel _Panel1;

		// Token: 0x0400052B RID: 1323
		[CompilerGenerated]
		private DateBox2 _DateBox;

		// Token: 0x0400052C RID: 1324
		private int _day;

		// Token: 0x0400052D RID: 1325
		private int _Sal;

		// Token: 0x0400052E RID: 1326
		private int _Mah;

		// Token: 0x0400052F RID: 1327
		private int _Ruz;

		// Token: 0x04000530 RID: 1328
		private UIButton[] btn;

		// Token: 0x04000531 RID: 1329
		private PersianCalendar p;

		// Token: 0x04000532 RID: 1330
		private int curday;

		// Token: 0x04000533 RID: 1331
		private int curmonth;

		// Token: 0x04000534 RID: 1332
		private int curyear;

		// Token: 0x04000535 RID: 1333
		[CompilerGenerated]
		private ToolStripDropDown _DropDown;
	}
}
