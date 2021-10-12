using System;

namespace TechX_Script
{
	// Token: 0x0200000D RID: 13
	internal class Variables
	{
		// Token: 0x0200000E RID: 14
		public class Menu
		{
			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002B55 File Offset: 0x00000D55
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002B5C File Offset: 0x00000D5C
			private static bool Enabled { get; set; }

			// Token: 0x0600002A RID: 42 RVA: 0x00003590 File Offset: 0x00001790
			public static bool isEnabled()
			{
				return Variables.Menu.Enabled;
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00002B64 File Offset: 0x00000D64
			public static void setEnabled(bool boolean)
			{
				Variables.Menu.Enabled = boolean;
			}
		}

		// Token: 0x0200000F RID: 15
		public class Weapon
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x0600002D RID: 45 RVA: 0x00002B6E File Offset: 0x00000D6E
			// (set) Token: 0x0600002E RID: 46 RVA: 0x00002B75 File Offset: 0x00000D75
			private static string Name { get; set; } = string.Empty;

			// Token: 0x0600002F RID: 47 RVA: 0x000035A8 File Offset: 0x000017A8
			public static string getName()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Name);
				string result;
				if (flag)
				{
					result = Variables.Weapon.Name;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000030 RID: 48 RVA: 0x00002B7D File Offset: 0x00000D7D
			public static void setName(string newName)
			{
				Variables.Weapon.Name = newName;
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000031 RID: 49 RVA: 0x00002B87 File Offset: 0x00000D87
			// (set) Token: 0x06000032 RID: 50 RVA: 0x00002B8E File Offset: 0x00000D8E
			private static int Ammo { get; set; } = 0;

			// Token: 0x06000033 RID: 51 RVA: 0x000035D8 File Offset: 0x000017D8
			public static int getAmmo()
			{
				return Variables.Weapon.Ammo;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00002B96 File Offset: 0x00000D96
			public static void setAmmo(int AmmoSize)
			{
				Variables.Weapon.Ammo = AmmoSize;
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002BA0 File Offset: 0x00000DA0
			// (set) Token: 0x06000036 RID: 54 RVA: 0x00002BA7 File Offset: 0x00000DA7
			private static int[,] ActiveRecoil { get; set; } = new int[1, 2];

			// Token: 0x06000037 RID: 55 RVA: 0x000035F0 File Offset: 0x000017F0
			public static int getRecoilX(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 0];
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00003610 File Offset: 0x00001810
			public static int getRecoilY(int Bullet)
			{
				return Variables.Weapon.ActiveRecoil[Bullet, 1];
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00002BAF File Offset: 0x00000DAF
			public static void setRecoilPattern(int[,] Pattern)
			{
				Variables.Weapon.ActiveRecoil = Pattern;
			}

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002BB9 File Offset: 0x00000DB9
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00002BC0 File Offset: 0x00000DC0
			private static double[] Delay { get; set; } = new double[1];

			// Token: 0x0600003C RID: 60 RVA: 0x00003630 File Offset: 0x00001830
			public static double getShotDelay(int Bullet)
			{
				return Variables.Weapon.Delay[Bullet];
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002BC8 File Offset: 0x00000DC8
			public static void setShotDelay(double[] Delays)
			{
				Variables.Weapon.Delay = Delays;
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00002BD2 File Offset: 0x00000DD2
			// (set) Token: 0x0600003F RID: 63 RVA: 0x00002BD9 File Offset: 0x00000DD9
			private static int ShootingMilliSec { get; set; } = 0;

			// Token: 0x06000040 RID: 64 RVA: 0x0000364C File Offset: 0x0000184C
			public static int getShootingMilliSec()
			{
				return Variables.Weapon.ShootingMilliSec;
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00002BE1 File Offset: 0x00000DE1
			public static void setShootingMilliSec(int MilliSec)
			{
				Variables.Weapon.ShootingMilliSec = MilliSec;
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00002BEB File Offset: 0x00000DEB
			// (set) Token: 0x06000043 RID: 67 RVA: 0x00002BF2 File Offset: 0x00000DF2
			public static int scopeIndex { get; set; } = 0;

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00002BFA File Offset: 0x00000DFA
			// (set) Token: 0x06000045 RID: 69 RVA: 0x00002C01 File Offset: 0x00000E01
			private static string Scope { get; set; } = "None";

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00002C09 File Offset: 0x00000E09
			// (set) Token: 0x06000047 RID: 71 RVA: 0x00002C10 File Offset: 0x00000E10
			private static double ScopeMulitplier { get; set; } = 1.0;

			// Token: 0x06000048 RID: 72 RVA: 0x00003664 File Offset: 0x00001864
			public static string getActiveScope()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Scope) && Variables.Weapon.Scope != "None";
				string result;
				if (flag)
				{
					result = Variables.Weapon.Scope;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000049 RID: 73 RVA: 0x000036A8 File Offset: 0x000018A8
			public static void changeScope()
			{
				switch (Variables.Weapon.scopeIndex)
				{
				case 0:
					Variables.Weapon.Scope = "None";
					Variables.Weapon.ScopeMulitplier = 1.0;
					break;
				case 1:
					Variables.Weapon.Scope = "Simple scope";
					Variables.Weapon.ScopeMulitplier = 0.8;
					break;
				case 2:
					Variables.Weapon.Scope = "Holo scope";
					Variables.Weapon.ScopeMulitplier = 1.2;
					break;
				case 3:
					Variables.Weapon.Scope = "8x scope";
					Variables.Weapon.ScopeMulitplier = 3.83721;
					break;
				case 4:
					Variables.Weapon.Scope = "16x scope";
					Variables.Weapon.ScopeMulitplier = 7.65116;
					Variables.Weapon.scopeIndex = -1;
					break;
				}
			}

			// Token: 0x0600004A RID: 74 RVA: 0x00003770 File Offset: 0x00001970
			public static double getScopeMulitplier()
			{
				return Variables.Weapon.ScopeMulitplier;
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00002C18 File Offset: 0x00000E18
			// (set) Token: 0x0600004C RID: 76 RVA: 0x00002C1F File Offset: 0x00000E1F
			public static int barrelIndex { get; set; } = 0;

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00002C27 File Offset: 0x00000E27
			// (set) Token: 0x0600004E RID: 78 RVA: 0x00002C2E File Offset: 0x00000E2E
			private static string Barrel { get; set; } = "None";

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00002C36 File Offset: 0x00000E36
			// (set) Token: 0x06000050 RID: 80 RVA: 0x00002C3D File Offset: 0x00000E3D
			private static double BarrelMultiplier { get; set; } = 1.0;

			// Token: 0x06000051 RID: 81 RVA: 0x00003788 File Offset: 0x00001988
			public static string getActiveBarrel()
			{
				bool flag = !string.IsNullOrEmpty(Variables.Weapon.Barrel) && Variables.Weapon.Barrel != "None";
				string result;
				if (flag)
				{
					result = Variables.Weapon.Barrel;
				}
				else
				{
					result = "None";
				}
				return result;
			}

			// Token: 0x06000052 RID: 82 RVA: 0x000037CC File Offset: 0x000019CC
			public static void changeBarrel()
			{
				switch (Variables.Weapon.barrelIndex)
				{
				case 0:
					Variables.Weapon.Barrel = "None";
					Variables.Weapon.BarrelMultiplier = 1.0;
					break;
				case 1:
					Variables.Weapon.Barrel = "Suppressor";
					Variables.Weapon.BarrelMultiplier = 0.8;
					break;
				case 2:
					Variables.Weapon.Barrel = "Muzzle boost";
					Variables.Weapon.BarrelMultiplier = 1.0;
					Variables.Weapon.MuzzleBoost = true;
					break;
				case 3:
					Variables.Weapon.Barrel = "Muzzle break";
					Variables.Weapon.BarrelMultiplier = 0.5;
					Variables.Weapon.barrelIndex = -1;
					Variables.Weapon.MuzzleBoost = false;
					break;
				}
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00003884 File Offset: 0x00001A84
			public static double getBarrelMultiplier()
			{
				return Variables.Weapon.BarrelMultiplier;
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000054 RID: 84 RVA: 0x00002C45 File Offset: 0x00000E45
			// (set) Token: 0x06000055 RID: 85 RVA: 0x00002C4C File Offset: 0x00000E4C
			private static bool MuzzleBoost { get; set; } = false;

			// Token: 0x06000056 RID: 86 RVA: 0x0000389C File Offset: 0x00001A9C
			public static double isMuzzleBoost(double MilliSec)
			{
				bool muzzleBoost = Variables.Weapon.MuzzleBoost;
				double result;
				if (muzzleBoost)
				{
					result = MilliSec - MilliSec * 0.10000000149011612;
				}
				else
				{
					result = MilliSec;
				}
				return result;
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000057 RID: 87 RVA: 0x00002C54 File Offset: 0x00000E54
			// (set) Token: 0x06000058 RID: 88 RVA: 0x00002C5B File Offset: 0x00000E5B
			private static double Randomness { get; set; } = 0.0;

			// Token: 0x06000059 RID: 89 RVA: 0x000038C8 File Offset: 0x00001AC8
			public static void setRandomness(int RandomnessIndex)
			{
			}

			// Token: 0x0600005A RID: 90 RVA: 0x000038DC File Offset: 0x00001ADC
			public static double getRandomness()
			{
				return Variables.Weapon.Randomness;
			}
		}

		// Token: 0x02000010 RID: 16
		public class Settings
		{
			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00002C63 File Offset: 0x00000E63
			// (set) Token: 0x0600005E RID: 94 RVA: 0x00002C6A File Offset: 0x00000E6A
			private static double Sensitivity { get; set; } = 1.0;

			// Token: 0x0600005F RID: 95 RVA: 0x00003980 File Offset: 0x00001B80
			public static void setSensitivity(int SensitivityIndex)
			{
				if (SensitivityIndex != -1)
				{
					if (SensitivityIndex == 1)
					{
						bool flag = Variables.Settings.Sensitivity < 2.0;
						if (flag)
						{
							Variables.Settings.Sensitivity += 0.1;
						}
					}
				}
				else
				{
					bool flag2 = 0.2 < Variables.Settings.Sensitivity;
					if (flag2)
					{
						Variables.Settings.Sensitivity -= 0.1;
					}
				}
			}

			// Token: 0x06000060 RID: 96 RVA: 0x000039F4 File Offset: 0x00001BF4
			public static double getSensitivity()
			{
				return Variables.Settings.Sensitivity;
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00002C72 File Offset: 0x00000E72
			// (set) Token: 0x06000062 RID: 98 RVA: 0x00002C79 File Offset: 0x00000E79
			private static int FOV { get; set; } = 90;

			// Token: 0x06000063 RID: 99 RVA: 0x00003A0C File Offset: 0x00001C0C
			public static void setFOV(int FOVIndex)
			{
				if (FOVIndex != -1)
				{
					if (FOVIndex == 1)
					{
						bool flag = Variables.Settings.FOV < 90;
						if (flag)
						{
							Variables.Settings.FOV++;
						}
					}
				}
				else
				{
					bool flag2 = 71 < Variables.Settings.FOV;
					if (flag2)
					{
						Variables.Settings.FOV--;
					}
				}
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00003A64 File Offset: 0x00001C64
			public static int getFOV()
			{
				return Variables.Settings.FOV;
			}
		}
	}
}
