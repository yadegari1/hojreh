using System;
using Microsoft.VisualBasic.CompilerServices;

namespace FruitBox
{
	// Token: 0x02000087 RID: 135
	[StandardModule]
	public sealed class huruf
	{
		// Token: 0x06000BFD RID: 3069 RVA: 0x00095118 File Offset: 0x00093318
		private static string yekan(string value)
		{
			bool flag = Operators.CompareString(value, Conversions.ToString(1), false) == 0;
			string result;
			if (flag)
			{
				result = "یک";
			}
			else
			{
				flag = (Operators.CompareString(value, Conversions.ToString(2), false) == 0);
				if (flag)
				{
					result = "دو";
				}
				else
				{
					flag = (Operators.CompareString(value, Conversions.ToString(3), false) == 0);
					if (flag)
					{
						result = "سه";
					}
					else
					{
						flag = (Operators.CompareString(value, Conversions.ToString(4), false) == 0);
						if (flag)
						{
							result = "چهار";
						}
						else
						{
							flag = (Operators.CompareString(value, Conversions.ToString(5), false) == 0);
							if (flag)
							{
								result = "پنج";
							}
							else
							{
								flag = (Operators.CompareString(value, Conversions.ToString(6), false) == 0);
								if (flag)
								{
									result = "شش";
								}
								else
								{
									flag = (Operators.CompareString(value, Conversions.ToString(7), false) == 0);
									if (flag)
									{
										result = "هفت";
									}
									else
									{
										flag = (Operators.CompareString(value, Conversions.ToString(8), false) == 0);
										if (flag)
										{
											result = "هشت";
										}
										else
										{
											flag = (Operators.CompareString(value, Conversions.ToString(9), false) == 0);
											if (flag)
											{
												result = "نه";
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0009525C File Offset: 0x0009345C
		private static string Dahgan(string value)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = value.Length == 2;
			bool flag3;
			if (flag)
			{
				bool flag2 = Conversions.ToDouble(value) >= 10.0 && Conversions.ToDouble(value) < 20.0;
				if (flag2)
				{
					flag3 = (Operators.CompareString(value, Conversions.ToString(10), false) == 0);
					if (flag3)
					{
						text = "ده";
					}
					else
					{
						flag3 = (Operators.CompareString(value, Conversions.ToString(11), false) == 0);
						if (flag3)
						{
							text = "یازده";
						}
						else
						{
							flag3 = (Operators.CompareString(value, Conversions.ToString(12), false) == 0);
							if (flag3)
							{
								text = "دوازده";
							}
							else
							{
								flag3 = (Operators.CompareString(value, Conversions.ToString(13), false) == 0);
								if (flag3)
								{
									text = "سیزده";
								}
								else
								{
									flag3 = (Operators.CompareString(value, Conversions.ToString(14), false) == 0);
									if (flag3)
									{
										text = "چهارده";
									}
									else
									{
										flag3 = (Operators.CompareString(value, Conversions.ToString(15), false) == 0);
										if (flag3)
										{
											text = "پانزده";
										}
										else
										{
											flag3 = (Operators.CompareString(value, Conversions.ToString(16), false) == 0);
											if (flag3)
											{
												text = "شانزده";
											}
											else
											{
												flag3 = (Operators.CompareString(value, Conversions.ToString(17), false) == 0);
												if (flag3)
												{
													text = "هفده";
												}
												else
												{
													flag3 = (Operators.CompareString(value, Conversions.ToString(18), false) == 0);
													if (flag3)
													{
														text = "هجده";
													}
													else
													{
														flag3 = (Operators.CompareString(value, Conversions.ToString(19), false) == 0);
														if (flag3)
														{
															text = "نوزده";
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				flag3 = (Conversions.ToDouble(value) >= 20.0);
				if (flag3)
				{
					string left = value.Substring(0, 1);
					flag2 = (Operators.CompareString(left, Conversions.ToString(2), false) == 0);
					if (flag2)
					{
						text = "بیست";
					}
					else
					{
						flag3 = (Operators.CompareString(left, Conversions.ToString(3), false) == 0);
						if (flag3)
						{
							text = "سی";
						}
						else
						{
							flag3 = (Operators.CompareString(left, Conversions.ToString(4), false) == 0);
							if (flag3)
							{
								text = "چهل";
							}
							else
							{
								flag3 = (Operators.CompareString(left, Conversions.ToString(5), false) == 0);
								if (flag3)
								{
									text = "پنجاه";
								}
								else
								{
									flag3 = (Operators.CompareString(left, Conversions.ToString(6), false) == 0);
									if (flag3)
									{
										text = "شصت";
									}
									else
									{
										flag3 = (Operators.CompareString(left, Conversions.ToString(7), false) == 0);
										if (flag3)
										{
											text = "هفتاد";
										}
										else
										{
											flag3 = (Operators.CompareString(left, Conversions.ToString(8), false) == 0);
											if (flag3)
											{
												text = "هشتاد";
											}
											else
											{
												flag3 = (Operators.CompareString(left, Conversions.ToString(9), false) == 0);
												if (flag3)
												{
													text = "نود";
												}
											}
										}
									}
								}
							}
						}
					}
					text2 = huruf.yekan(value.Substring(1, 1));
				}
				flag3 = (Conversions.ToDouble(value) < 10.0);
				if (flag3)
				{
					text2 = huruf.yekan(value.Substring(1, 1));
				}
			}
			else
			{
				text2 = huruf.yekan(value);
			}
			flag3 = (Operators.CompareString(text2, string.Empty, false) != 0);
			if (flag3)
			{
				bool flag2 = text.Length > 0;
				if (flag2)
				{
					text = text + " و " + text2;
				}
				else
				{
					text = text2;
				}
			}
			return text;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000955BC File Offset: 0x000937BC
		private static string Sadgan(int value)
		{
			string text = string.Empty;
			string text2 = string.Empty;
			bool flag = value.ToString().Length == 3;
			bool flag2;
			if (flag)
			{
				string left = value.ToString().Substring(0, 1);
				flag2 = (Operators.CompareString(left, Conversions.ToString(1), false) == 0);
				if (flag2)
				{
					text = "یکصد";
				}
				else
				{
					flag2 = (Operators.CompareString(left, Conversions.ToString(2), false) == 0);
					if (flag2)
					{
						text = "دویست";
					}
					else
					{
						flag2 = (Operators.CompareString(left, Conversions.ToString(3), false) == 0);
						if (flag2)
						{
							text = "سیصد";
						}
						else
						{
							flag2 = (Operators.CompareString(left, Conversions.ToString(4), false) == 0);
							if (flag2)
							{
								text = "چهارصد";
							}
							else
							{
								flag2 = (Operators.CompareString(left, Conversions.ToString(5), false) == 0);
								if (flag2)
								{
									text = "پانصد";
								}
								else
								{
									flag2 = (Operators.CompareString(left, Conversions.ToString(6), false) == 0);
									if (flag2)
									{
										text = "ششصد";
									}
									else
									{
										flag2 = (Operators.CompareString(left, Conversions.ToString(7), false) == 0);
										if (flag2)
										{
											text = "هفتصد";
										}
										else
										{
											flag2 = (Operators.CompareString(left, Conversions.ToString(8), false) == 0);
											if (flag2)
											{
												text = "هشتصد";
											}
											else
											{
												flag2 = (Operators.CompareString(left, Conversions.ToString(9), false) == 0);
												if (flag2)
												{
													text = "نهصد";
												}
											}
										}
									}
								}
							}
						}
					}
				}
				text2 = huruf.Dahgan(value.ToString().Substring(1, 2));
			}
			else
			{
				text2 = huruf.Dahgan(Conversions.ToString(value));
			}
			flag2 = (text2.Length > 0);
			if (flag2)
			{
				flag = (text.Length > 0);
				if (flag)
				{
					text = text + " و " + text2;
				}
				else
				{
					text = text2;
				}
			}
			return text;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0009577C File Offset: 0x0009397C
		private static string Addext(int pos)
		{
			string result;
			switch (pos)
			{
			case 1:
				result = "";
				break;
			case 2:
				result = " هزار";
				break;
			case 3:
				result = " میلیون";
				break;
			case 4:
				result = " میلیارد";
				break;
			default:
				result = "";
				break;
			}
			return result;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000957E0 File Offset: 0x000939E0
		public static string ConvertToHuruf(string value, huruf.ConvertType convert)
		{
			bool flag = Operators.CompareString(value, "0", false) == 0;
			checked
			{
				string result;
				if (flag)
				{
					result = "";
				}
				else
				{
					string text = string.Empty;
					string text2 = string.Empty;
					flag = (Operators.CompareString(value.ToString(), string.Empty, false) == 0);
					if (flag)
					{
						result = string.Empty;
					}
					else
					{
						long value2 = Conversions.ToLong(value);
						value = Conversions.ToString(Math.Abs(value2));
						flag = (convert == huruf.ConvertType.تومان);
						if (flag)
						{
							value = Public_Function.RemoveLast(value);
						}
						int num = value.ToString().Length / 3;
						flag = (value.Length > 3 && value.ToString().Length % 3 > 0);
						if (flag)
						{
							num++;
						}
						flag = (num == 0);
						if (flag)
						{
							num++;
						}
						int num2 = 3;
						int num3 = 0;
						flag = (value.ToString().Length % 3 > 0);
						if (flag)
						{
							num2 = value.ToString().Length % 3;
						}
						flag = (num2 > value.Length);
						if (flag)
						{
							num2 = value.Length;
						}
						int arg_111_0 = 1;
						int num4 = num;
						int num5 = arg_111_0;
						while (true)
						{
							int arg_1A4_0 = num5;
							int num6 = num4;
							if (arg_1A4_0 > num6)
							{
								break;
							}
							text2 = huruf.Sadgan(Conversions.ToInteger(value.ToString().Substring(num3, num2)));
							flag = (Operators.CompareString(text2, string.Empty, false) != 0);
							if (flag)
							{
								bool flag2 = Operators.CompareString(text, string.Empty, false) != 0;
								if (flag2)
								{
									text += " و ";
								}
								text += text2;
								text += huruf.Addext(num - num5 + 1);
							}
							num3 += num2;
							num2 = 3;
							num5++;
						}
						switch (convert)
						{
						case huruf.ConvertType.ریال:
							text += " ریال ";
							break;
						case huruf.ConvertType.تومان:
							text += " تومان ";
							break;
						case huruf.ConvertType.هیچکدام:
							result = text;
							return result;
						}
						result = text;
					}
				}
				return result;
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000959DC File Offset: 0x00093BDC
		public static object ConvertTarikhTohuruf(string tarikh)
		{
			string[] array = new string[]
			{
				"",
				"یکم",
				"دوم",
				"سوم",
				"چهارم",
				"پنجم",
				"ششم",
				"هفتم",
				"هشتم",
				"نهم",
				"دهم",
				"یازدهم",
				"دوازدهم",
				"سیزدهم",
				"چهاردهم",
				"پانزدهم",
				"شانزدهم",
				"هفدهم",
				"هجدهم",
				"نوزدهم",
				"بیستم",
				"بیست یکم",
				"بیست دوم",
				"بیست سوم",
				"بیست چهارم",
				"بیست پنجم",
				"بیست ششم",
				"بیست هفتم",
				"بیست هشتم",
				"بیست نهم",
				"سی ام",
				"سی یکم"
			};
			string[] array2 = new string[]
			{
				"",
				"فروردین",
				"اردیبهشت",
				"خرداد",
				"تیر",
				"مرداد",
				"شهریور",
				"مهر",
				"آبان",
				"آذر",
				"دی",
				"بهمن",
				"اسفند"
			};
			string[] array3 = tarikh.Split(new char[]
			{
				'/'
			});
			return string.Concat(new string[]
			{
				array[Conversions.ToInteger(array3[2])],
				" ",
				array2[Conversions.ToInteger(array3[1])],
				" ",
				huruf.ConvertToHuruf(array3[0], huruf.ConvertType.هیچکدام)
			});
		}

		// Token: 0x02000088 RID: 136
		public enum ConvertType
		{
			// Token: 0x040004BB RID: 1211
			ریال = 1,
			// Token: 0x040004BC RID: 1212
			تومان,
			// Token: 0x040004BD RID: 1213
			هیچکدام
		}
	}
}
