using System;
using System.Threading;
using System.Windows.Forms;

namespace TechX_Script
{
	// Token: 0x0200000C RID: 12
	internal class Recoil
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003358 File Offset: 0x00001558
		private static bool IsKeyDown(Keys key)
		{
			return ((int)DLLImports.GetAsyncKeyState((int)key) & 32768) != 0;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000337C File Offset: 0x0000157C
		public static void RecoilLoop()
		{
			for (;;)
			{
				bool flag = Variables.Menu.isEnabled() && !string.IsNullOrEmpty(Variables.Weapon.getName());
				if (flag)
				{
					while (Recoil.IsKeyDown(Keys.LButton) && Recoil.IsKeyDown(Keys.RButton))
					{
						for (int i = 0; i <= Variables.Weapon.getAmmo() - 1; i++)
						{
							bool flag2 = !Recoil.IsKeyDown(Keys.LButton);
							if (flag2)
							{
								break;
							}
							Recoil.Smoothing(Variables.Weapon.isMuzzleBoost((double)Variables.Weapon.getShootingMilliSec()), Variables.Weapon.isMuzzleBoost(Variables.Weapon.getShotDelay(i)), (int)(((double)Variables.Weapon.getRecoilX(i) + Recoil.GetRandomNumber(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()), (int)(((double)Variables.Weapon.getRecoilY(i) + Recoil.GetRandomNumber(0.0, Variables.Weapon.getRandomness())) / 4.0 / Variables.Settings.getSensitivity() * Variables.Weapon.getScopeMulitplier() * Variables.Weapon.getBarrelMultiplier()));
							DLLImports.mouse_event(1, 0, 0, 0, 0);
						}
					}
				}
				Thread.Sleep(1);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000034AC File Offset: 0x000016AC
		private static double GetRandomNumber(double minimum, double maximum)
		{
			Random random = new Random();
			return random.NextDouble() * (maximum - minimum) + minimum;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000034D0 File Offset: 0x000016D0
		private static void Smoothing(double MS, double ControlledTime, int X, int Y)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int i = 1; i <= (int)ControlledTime; i++)
			{
				int num4 = i * X / (int)ControlledTime;
				int num5 = i * Y / (int)ControlledTime;
				int num6 = i * (int)ControlledTime / (int)ControlledTime;
				DLLImports.mouse_event(1, num4 - num, num5 - num2, 0, 0);
				Recoil.PerciseSleep(num6 - num3);
				num = num4;
				num2 = num5;
				num3 = num6;
			}
			Recoil.PerciseSleep((int)MS - (int)ControlledTime);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003544 File Offset: 0x00001744
		private static void PerciseSleep(int ms)
		{
			long num;
			DLLImports.QueryPerformanceFrequency(out num);
			num /= 1000L;
			long num2;
			DLLImports.QueryPerformanceCounter(out num2);
			long num3 = num2 / num + (long)ms;
			for (num2 = 0L; num2 < num3; num2 /= num)
			{
				DLLImports.QueryPerformanceCounter(out num2);
			}
		}
	}
}
