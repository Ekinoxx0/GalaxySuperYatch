using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GTA;
using GTA.Math;
using GTA.Native;
using Microsoft.CSharp.RuntimeBinder;
using NativeUI;

namespace GalaxyClassSuperYacht
{
	// Token: 0x02000003 RID: 3
	public class Yacht : Script
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002FBC File Offset: 0x000011BC
		public Model RequestModel(int Name)
		{
			Model model;
			model..ctor(Name);
			model.Request(10000);
			bool flag = model.IsInCdImage && model.IsValid;
			Model result;
			if (flag)
			{
				while (!model.IsLoaded)
				{
					Script.Wait(100);
				}
				result = model;
			}
			else
			{
				model.MarkAsNoLongerNeeded();
				result = model;
			}
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003020 File Offset: 0x00001220
		public Model RequestModel(string Name)
		{
			Model model;
			model..ctor(Name);
			model.Request(10000);
			bool flag = model.IsInCdImage && model.IsValid;
			Model result;
			if (flag)
			{
				while (!model.IsLoaded)
				{
					Script.Wait(100);
				}
				result = model;
			}
			else
			{
				model.MarkAsNoLongerNeeded();
				result = model;
			}
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003084 File Offset: 0x00001284
		public Model RequestModel(VehicleHash Name)
		{
			Model model;
			model..ctor(Name);
			model.Request(10000);
			bool flag = model.IsInCdImage && model.IsValid;
			Model result;
			if (flag)
			{
				while (!model.IsLoaded)
				{
					Script.Wait(50);
				}
				result = model;
			}
			else
			{
				model.MarkAsNoLongerNeeded();
				result = model;
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000030E8 File Offset: 0x000012E8
		public Model RequestModel(PedHash Name)
		{
			Model model;
			model..ctor(Name);
			model.Request(10000);
			bool flag = model.IsInCdImage && model.IsValid;
			Model result;
			if (flag)
			{
				while (!model.IsLoaded)
				{
					Script.Wait(50);
				}
				result = model;
			}
			else
			{
				model.MarkAsNoLongerNeeded();
				result = model;
			}
			return result;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000314C File Offset: 0x0000134C
		public void Drinks()
		{
			UIMenu uimenu = this.DrinksPool.AddSubMenu(this.DrinksMenu, "Drinks");
			UIMenuItem DrinkA = new UIMenuItem("Pisswasser                                               $25");
			uimenu.AddItem(DrinkA);
			UIMenuItem DrinkB = new UIMenuItem("Vodka Shot                                              $75");
			uimenu.AddItem(DrinkB);
			UIMenuItem DrinkC = new UIMenuItem("The Mount Whiskey Shot                       $250");
			uimenu.AddItem(DrinkC);
			UIMenuItem DrinkD = new UIMenuItem("Richard's Whiskey Shot                       $1,000");
			uimenu.AddItem(DrinkD);
			UIMenuItem DrinkE = new UIMenuItem("Macbeth Whiskey Shot                       $5,000");
			uimenu.AddItem(DrinkE);
			UIMenuItem DrinkF = new UIMenuItem("Bleuter'd Champaine Slver                $30,000");
			uimenu.AddItem(DrinkF);
			UIMenuItem DrinkG = new UIMenuItem("Bleuter'd Champaine Gold                $50,000");
			uimenu.AddItem(DrinkG);
			UIMenuItem DrinkH = new UIMenuItem("Bleuter'd Champaine Diamond        $150,000");
			uimenu.AddItem(DrinkH);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == DrinkH;
				if (flag)
				{
					bool flag2 = Game.Player.Money >= 150000;
					if (flag2)
					{
						Game.Player.Money -= 150000;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop = World.CreateProp(this.RequestModel("ba_prop_battle_champ_closed_03"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop.FreezePosition = true;
						prop.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop;
						this.Champ.Add(prop);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 6;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.Weapons.Select(-1600701090);
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag3 = item == DrinkG;
				if (flag3)
				{
					bool flag4 = Game.Player.Money >= 50000;
					if (flag4)
					{
						Game.Player.Money -= 50000;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop2 = World.CreateProp(this.RequestModel("ba_prop_battle_champ_closed_02"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop2.FreezePosition = true;
						prop2.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop2;
						this.Champ.Add(prop2);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 6;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.Weapons.Select(-1600701090);
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord2 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag5 = item == DrinkF;
				if (flag5)
				{
					bool flag6 = Game.Player.Money >= 30000;
					if (flag6)
					{
						Game.Player.Money -= 30000;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop3 = World.CreateProp(this.RequestModel("ba_prop_battle_champ_closed"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop3.FreezePosition = true;
						prop3.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop3;
						this.Champ.Add(prop3);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 6;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.Weapons.Select(-1600701090);
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord3 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag7 = item == DrinkE;
				if (flag7)
				{
					bool flag8 = Game.Player.Money >= 5000;
					if (flag8)
					{
						Game.Player.Money -= 5000;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop4 = World.CreateProp(this.RequestModel("prop_cs_whiskey_bottle"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop4.FreezePosition = true;
						prop4.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop4;
						this.Champ.Add(prop4);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 3;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord4 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify(" You do not have enough money for this Drink!");
					}
				}
				bool flag9 = item == DrinkD;
				if (flag9)
				{
					bool flag10 = Game.Player.Money >= 1000;
					if (flag10)
					{
						Game.Player.Money -= 1000;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop5 = World.CreateProp(this.RequestModel("prop_cs_whiskey_bottle"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop5.FreezePosition = true;
						prop5.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop5;
						this.Champ.Add(prop5);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 2;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord5 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag11 = item == DrinkC;
				if (flag11)
				{
					bool flag12 = Game.Player.Money >= 250;
					if (flag12)
					{
						Game.Player.Money -= 250;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop6 = World.CreateProp(this.RequestModel("prop_cs_whiskey_bottle"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop6.FreezePosition = true;
						prop6.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop6;
						this.Champ.Add(prop6);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 1;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord6 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag13 = item == DrinkB;
				if (flag13)
				{
					bool flag14 = Game.Player.Money >= 75;
					if (flag14)
					{
						Game.Player.Money -= 75;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop7 = World.CreateProp(this.RequestModel("prop_sh_beer_pissh_01"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop7.FreezePosition = true;
						prop7.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop7;
						this.Champ.Add(prop7);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = 0;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord7 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
				bool flag15 = item == DrinkA;
				if (flag15)
				{
					bool flag16 = Game.Player.Money >= 25;
					if (flag16)
					{
						Game.Player.Money -= 25;
						Game.Player.Character.Weapons.Select(-1569615261);
						Prop prop8 = World.CreateProp(this.RequestModel("prop_sh_beer_pissh_01"), Game.Player.Character.GetOffsetInWorldCoords(new Vector3(5f, 0f, -1f)), false, false);
						prop8.FreezePosition = true;
						prop8.Position = Game.Player.Character.GetBoneCoord(6286, new Vector3(0f, 0f, 0f));
						this.Champaine = prop8;
						this.Champ.Add(prop8);
						this.IsDrinking = true;
						Game.Player.Character.Task.PlayAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one", 5f, 4500, false, 0f);
						this.Effect = -1;
						Function.Call(7753999234533660383L, new InputArgument[]
						{
							this.Champaine,
							Game.Player.Character,
							Game.Player.Character.GetBoneIndex(28422),
							0f,
							0f,
							0f,
							0f,
							0f,
							0f,
							0,
							0,
							0,
							0,
							2,
							1
						});
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.FreezePosition = true;
						Vector3 boneCoord8 = Game.Player.Character.GetBoneCoord(28422, new Vector3(-0.05f, 0f, -0.05f));
						Script.Wait(5000);
						Game.Player.Character.HasGravity = true;
						Game.Player.Character.FreezePosition = false;
						this.Champaine.FreezePosition = false;
						this.IsDrinking = false;
						this.Champaine.HasCollision = true;
						this.DrinkTimer = 0;
						Game.Player.Character.Task.ClearAnimation("anim@heists@heist_safehouse_intro@wine@window", "wine_window_part_one");
						Game.Player.Character.Task.ClearAll();
						Game.Player.Character.Task.ClearAllImmediately();
						this.Champaine.Detach();
					}
					else
					{
						UI.Notify("You do not have enough money for this Drink!");
					}
				}
			};
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000327C File Offset: 0x0000147C
		public int CheckClothes(int T, int RComp, int RDraw)
		{
			int result = 0;
			bool flag = T == 1;
			if (flag)
			{
				bool flag2 = Function.Call<bool>(-1718696417760418019L, new InputArgument[]
				{
					Game.Player.Character,
					RComp,
					RDraw
				});
				if (flag2)
				{
					result = Function.Call<int>(2834476523764480066L, new InputArgument[]
					{
						Game.Player.Character,
						RComp
					});
				}
			}
			bool flag3 = T == 2;
			if (flag3)
			{
				bool flag4 = Function.Call<bool>(-1718696417760418019L, new InputArgument[]
				{
					Game.Player.Character,
					RComp,
					RDraw
				});
				if (flag4)
				{
					result = Function.Call<int>(-8110606195499570259L, new InputArgument[]
					{
						Game.Player.Character,
						RComp,
						RDraw
					});
				}
			}
			return result;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000338C File Offset: 0x0000158C
		public void Setoutfit(int i)
		{
			Function.Call(-7838678542154536097L, new InputArgument[]
			{
				Game.Player.Character,
				0,
				0,
				0,
				0
			});
			bool flag = Game.Player.Character.Model != 1885233650;
			if (flag)
			{
				this.OldCharacter = Game.Player.Character.Model;
			}
			Function.Call(-6164042450715612628L, new InputArgument[]
			{
				Game.Player.Character,
				1.0
			});
			Function.Call(2328651364711703671L, new InputArgument[]
			{
				Game.Player.Character
			});
			Model model;
			model..ctor(1885233650);
			model.Request(500);
			bool flag2 = model.IsInCdImage && model.IsValid;
			if (flag2)
			{
				while (!model.IsLoaded)
				{
					Script.Wait(100);
				}
				Function.Call(45540521788082230L, new InputArgument[]
				{
					Game.Player,
					model.Hash
				});
			}
			model.MarkAsNoLongerNeeded();
			Ped character = Game.Player.Character;
			Function.Call(-7838678542154536097L, new InputArgument[]
			{
				character,
				-1,
				0,
				0,
				17
			});
			bool flag3 = false;
			string id_C = this.ID_C;
			bool flag4 = i == 0;
			if (flag4)
			{
				bool flag5 = id_C.Equals("Outfit Default");
				if (flag5)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag6 = id_C.Equals("Green");
				if (flag6)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag7 = id_C.Equals("Purple");
				if (flag7)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag8 = id_C.Equals("Pink");
				if (flag8)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag9 = id_C.Equals("Orange");
				if (flag9)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag10 = !flag3;
				if (flag10)
				{
					bool flag11 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag11)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						125,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag12 = i == 1;
			if (flag12)
			{
				bool flag13 = id_C.Equals("Outfit Default");
				if (flag13)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						89,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						55,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						54,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag14 = id_C.Equals("Black");
				if (flag14)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						89,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						55,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						54,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag15 = i == 2;
			if (flag15)
			{
				bool flag16 = id_C.Equals("Outfit Default");
				if (flag16)
				{
					bool flag17 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag17)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Random random = new Random();
					int num = random.Next(1, 100);
					bool flag18 = num <= 25;
					if (flag18)
					{
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character,
							1,
							38,
							0,
							1
						});
					}
					bool flag19 = num > 25 && num <= 50;
					if (flag19)
					{
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character,
							1,
							112,
							0,
							1
						});
					}
					bool flag20 = num > 50 && num <= 75;
					if (flag20)
					{
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character,
							1,
							46,
							0,
							1
						});
					}
					bool flag21 = num > 75;
					if (flag21)
					{
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character,
							1,
							104,
							25,
							1
						});
					}
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						125,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						68,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag22 = i == 3;
			if (flag22)
			{
				bool flag23 = id_C.Equals("Blue");
				if (flag23)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag24 = id_C.Equals("Green");
				if (flag24)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag25 = id_C.Equals("Red");
				if (flag25)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag26 = id_C.Equals("Orange");
				if (flag26)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag27 = id_C.Equals("Purple");
				if (flag27)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag28 = id_C.Equals("Pink");
				if (flag28)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag29 = id_C.Equals("White");
				if (flag29)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
				bool flag30 = id_C.Equals("Black") || id_C.Equals("Outfit Default");
				if (flag30)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						1,
						91,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						3,
						46,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						4,
						84,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						6,
						10,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						8,
						97,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						11,
						186,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						Game.Player.Character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag31 = i == 4;
			if (flag31)
			{
				bool flag32 = id_C.Equals("Black");
				if (flag32)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag33 = id_C.Equals("White");
				if (flag33)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag34 = id_C.Equals("Green");
				if (flag34)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						12,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						8,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag35 = id_C.Equals("Orange");
				if (flag35)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						13,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag36 = id_C.Equals("Purple");
				if (flag36)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						14,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag37 = id_C.Equals("Pink");
				if (flag37)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						15,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag38 = id_C.Equals("Red");
				if (flag38)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						14,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag39 = id_C.Equals("Outfit Default") || !flag3;
				if (flag39)
				{
					bool flag40 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag40)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						275,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag41 = i == 5;
			if (flag41)
			{
				bool flag42 = id_C.Equals("Black");
				if (flag42)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						5,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag43 = id_C.Equals("White");
				if (flag43)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag44 = id_C.Equals("Green");
				if (flag44)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						12,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag45 = id_C.Equals("Orange");
				if (flag45)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						13,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag46 = id_C.Equals("Purple");
				if (flag46)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						14,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag47 = id_C.Equals("Pink");
				if (flag47)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						15,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag48 = id_C.Equals("Red");
				if (flag48)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						6,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag49 = id_C.Equals("Outfit Default") || !flag3;
				if (flag49)
				{
					bool flag50 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag50)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						142,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						19,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						107,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						84,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						3,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						276,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag51 = i == 6;
			if (flag51)
			{
				bool flag52 = id_C.Equals("Green");
				if (flag52)
				{
					flag3 = true;
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						134,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						147,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						167,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						113,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						90,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						286,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						1,
						0,
						135,
						0
					});
				}
				bool flag53 = id_C.Equals("Outfit Default") || !flag3;
				if (flag53)
				{
					bool flag54 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag54)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						134,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						147,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						167,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						113,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						90,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						286,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						1,
						0,
						135,
						0
					});
				}
			}
			bool flag55 = i == 7;
			if (flag55)
			{
				bool flag56 = id_C.Equals("Outfit Default");
				if (flag56)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag57 = id_C.Equals("Green");
				if (flag57)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						4,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag58 = id_C.Equals("Purple");
				if (flag58)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						6,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag59 = id_C.Equals("Pink");
				if (flag59)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						7,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						4,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag60 = id_C.Equals("Orange");
				if (flag60)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						5,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						2,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag61 = !flag3;
				if (flag61)
				{
					bool flag62 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag62)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						115,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						17,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						34,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						69,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						128,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag63 = i == 8;
			if (flag63)
			{
				bool flag64 = id_C.Equals("Green");
				if (flag64)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						8,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						8,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						8,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						8,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag65 = id_C.Equals("Purple");
				if (flag65)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						10,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag66 = id_C.Equals("Pink");
				if (flag66)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						11,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						11,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag67 = id_C.Equals("Orange");
				if (flag67)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						9,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						9,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag68 = !flag3;
				if (flag68)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag69 = id_C.Equals("Outfit Default") || !flag3;
				if (flag69)
				{
					bool flag70 = !flag3 && !id_C.Equals("Outfit Default");
					if (flag70)
					{
						UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + id_C);
					}
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						133,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						108,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						166,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						110,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						88,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						2,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						283,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
			bool flag71 = i == 9;
			if (flag71)
			{
				bool flag72 = id_C.Equals("Outfit Default");
				if (flag72)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag73 = id_C.Equals("Green");
				if (flag73)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						1,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						1,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						1,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag74 = id_C.Equals("White");
				if (flag74)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						9,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						7,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						7,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag75 = id_C.Equals("Blue");
				if (flag75)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						3,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						3,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						3,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag76 = id_C.Equals("Black");
				if (flag76)
				{
					flag3 = true;
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						10,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						10,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						10,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
				bool flag77 = !flag3;
				if (flag77)
				{
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						0,
						0,
						0,
						1
					});
					Function.Call(-7838678542154536097L, new InputArgument[]
					{
						character,
						0,
						91,
						0,
						17
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						1,
						0,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						2,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						3,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						4,
						77,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						5,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						6,
						55,
						0,
						0
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						7,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						8,
						130,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						9,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						10,
						0,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						11,
						178,
						0,
						1
					});
					Function.Call(2750315038012726912L, new InputArgument[]
					{
						character,
						12,
						0,
						0,
						1
					});
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public void WareDrobe()
		{
			List<object> list = new List<object>();
			list.Add("Save");
			list.Add("Load");
			List<dynamic> Slots = new List<object>();
			Slots.Add("Slot1.ini");
			Slots.Add("Slot2.ini");
			Slots.Add("Slot3.ini");
			Slots.Add("Slot4.ini");
			Slots.Add("Slot5.ini");
			Slots.Add("Slot6.ini");
			Slots.Add("Slot7.ini");
			Slots.Add("Slot8.ini");
			Slots.Add("Slot9.ini");
			Slots.Add("Slot10.ini");
			List<object> list2 = new List<object>();
			list2.Add(-1569615261);
			list2.Add(-1716189206);
			list2.Add(1737195953);
			list2.Add(1317494643);
			list2.Add(-102973651);
			list2.Add(-656458692);
			list2.Add(-581044007);
			list2.Add(-1810795771);
			list2.Add(419712736);
			list2.Add(-538741184);
			list2.Add(1141786504);
			list2.Add(-1951375401);
			List<dynamic> Colours = new List<object>();
			Colours.Add("Outfit Default");
			Colours.Add("Blue");
			Colours.Add("Green");
			Colours.Add("Red");
			Colours.Add("Orange");
			Colours.Add("Pink");
			Colours.Add("Purple");
			Colours.Add("White");
			Colours.Add("Black");
			List<dynamic> Outfits = new List<object>();
			Outfits.Add("Soldier");
			Outfits.Add("Cloaker");
			Outfits.Add("Hacker");
			Outfits.Add("Juggernaut");
			Outfits.Add("Arena War A");
			Outfits.Add("Arena War B");
			Outfits.Add("Space Marine");
			Outfits.Add("Commando");
			Outfits.Add("Space Suit");
			Outfits.Add("Tron");
			List<object> list3 = new List<object>();
			List<dynamic> Draw = new List<object>();
			List<object> list4 = new List<object>();
			List<dynamic> Tex = new List<object>();
			for (int i = 0; i < 999; i++)
			{
				Tex.Add(i);
				Draw.Add(i);
				list4.Add(i);
				list3.Add(i);
			}
			List<object> list5 = new List<object>();
			list5.Add(" 0 FACE");
			list5.Add("1 BEARD");
			list5.Add("2 HAIRCUT");
			list5.Add("3 SHIRT");
			list5.Add("4 PANTS");
			list5.Add("5 Hands / Gloves");
			list5.Add("6 SHOES");
			list5.Add("7 Eyes");
			list5.Add("8 Accessories");
			list5.Add("9 Mission Items/ Tasks");
			list5.Add("10 Decals");
			list5.Add("11 Collars and Inner Shirts");
			UIMenu uimenu = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Change Outfit");
			UIMenuListItem O = new UIMenuListItem("", Outfits, 0);
			uimenu.AddItem(O);
			O.Description = "While Using this outfit you will not be able to purchase anything due to being the MP male";
			UIMenuListItem C = new UIMenuListItem("Color : ", Colours, 0);
			uimenu.AddItem(C);
			C.Description = "Use this Colour Whenever possible or use Default";
			UIMenuItem Set = new UIMenuItem("Wear Outfit ");
			uimenu.AddItem(Set);
			Set.Description = "~y~ Warning ~w~ Lag is normal while applying outfits, simple alt tab out to avoid crash";
			UIMenuItem Remove = new UIMenuItem("Remove Outift ");
			uimenu.AddItem(Remove);
			UIMenu uimenu2 = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Change Clothes");
			UIMenu uimenu3 = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Save/Load Outfit");
			UIMenuListItem SVL = new UIMenuListItem("Function ", list, 0);
			uimenu3.AddItem(SVL);
			UIMenuListItem Sl = new UIMenuListItem("Slot ", Slots, 0);
			uimenu3.AddItem(Sl);
			UIMenuItem Get = new UIMenuItem("Save");
			uimenu3.AddItem(Get);
			uimenu3.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Get;
				if (flag)
				{
					string arg = "";
					bool flag2 = Game.Player.Character.Model == -1692214353;
					if (flag2)
					{
						arg = "scripts//GalaxyClassSuperYacht//YachtWaredrobe//Waredrobe//Franklin//";
					}
					bool flag3 = Game.Player.Character.Model == 225514697;
					if (flag3)
					{
						arg = "scripts//GalaxyClassSuperYacht//YachtWaredrobe//Waredrobe//Michael//";
					}
					bool flag4 = Game.Player.Character.Model == -1686040670;
					if (flag4)
					{
						arg = "scripts//GalaxyClassSuperYacht//YachtWaredrobe//Waredrobe//Trevor//";
					}
					bool flag5 = Game.Player.Character.Model == -1667301416 || Game.Player.Character.Model == 1885233650;
					if (flag5)
					{
						arg = "scripts//GalaxyClassSuperYacht//YachtWaredrobe//Waredrobe//Mp//";
					}
					bool flag6 = SVL.Index == 0;
					if (flag6)
					{
						Ped character = Game.Player.Character;
						Get.Text = "Save";
						if (Yacht.<>o__176.<>p__1 == null)
						{
							Yacht.<>o__176.<>p__1 = CallSite<Action<CallSite, Yacht, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "LoadIniFile", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Yacht, object> target = Yacht.<>o__176.<>p__1.Target;
						CallSite <>p__ = Yacht.<>o__176.<>p__1;
						Yacht <>4__this = this;
						if (Yacht.<>o__176.<>p__0 == null)
						{
							Yacht.<>o__176.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(<>p__, <>4__this, Yacht.<>o__176.<>p__0.Target(Yacht.<>o__176.<>p__0, arg, Slots[Sl.Index]));
						int num = Function.Call<int>(-8535233825580798760L, new InputArgument[]
						{
							character,
							0
						});
						int num2 = Function.Call<int>(-2219814444253832526L, new InputArgument[]
						{
							character,
							0
						});
						int num3 = Function.Call<int>(-2027359621027192191L, new InputArgument[]
						{
							character,
							0
						});
						this.Config.SetValue<int>("-1 HAT", "Hat_Drawable", num);
						this.Config.SetValue<int>("-1 Hat", "Hat_Tex", num2);
						this.Config.SetValue<int>("-1 Hat", "Hat_Palette", num3);
						int num4 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							0
						});
						int num5 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							0
						});
						this.Config.SetValue<int>("0 FACE", "Head_Drawable", num4);
						this.Config.SetValue<int>("0 FACE", "Head_Palette", num5);
						int num6 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							1
						});
						int num7 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							1
						});
						this.Config.SetValue<int>("1 BEARD", "BEARD_Drawable", num6);
						this.Config.SetValue<int>("1 BEARD", "BEARD_Palette", num7);
						int num8 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							2
						});
						int num9 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							2
						});
						this.Config.SetValue<int>("2 HAIRCUT", "HAIRCUT_Drawable", num8);
						this.Config.SetValue<int>("2 HAIRCUT", "HAIRCUT_Palette", num9);
						int num10 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							3
						});
						int num11 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							3
						});
						this.Config.SetValue<int>("3 SHIRT", "SHIRT_Drawable", num10);
						this.Config.SetValue<int>("3 SHIRT", "SHIRT_Palette", num11);
						int num12 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							4
						});
						int num13 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							4
						});
						this.Config.SetValue<int>("4 PANTS", "PANTS_Drawable", num12);
						this.Config.SetValue<int>("4 PANTS", "PANTS_Palette", num13);
						int num14 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							5
						});
						int num15 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							5
						});
						this.Config.SetValue<int>("5 Hands / Gloves", "Gloves_Drawable", num14);
						this.Config.SetValue<int>("5 Hands / Gloves", "Gloves_Palette", num15);
						int num16 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							6
						});
						int num17 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							6
						});
						this.Config.SetValue<int>("6 SHOES", "SHOES_Drawable", num16);
						this.Config.SetValue<int>("6 SHOES", "SHOES_Palette", num17);
						int num18 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							7
						});
						int num19 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							7
						});
						this.Config.SetValue<int>("7 Eyes", "Eyes_Drawable", num18);
						this.Config.SetValue<int>("7 Eyes", "Eyes_Palette", num19);
						int num20 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							8
						});
						int num21 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							8
						});
						this.Config.SetValue<int>("8 Accessories", "Accessories_Drawable", num20);
						this.Config.SetValue<int>("8 Accessories", "Accessories_Palette", num21);
						int num22 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							9
						});
						int num23 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							9
						});
						this.Config.SetValue<int>("9 Mission Items/ Tasks", "Mission_Drawable", num22);
						this.Config.SetValue<int>("9 Mission Items/ Tasks", "Mission_Palette", num23);
						int num24 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							10
						});
						int num25 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							10
						});
						this.Config.SetValue<int>("10 Decals", "Decals_Drawable", num24);
						this.Config.SetValue<int>("10 Decals", "Decals_Palette", num25);
						int num26 = Function.Call<int>(7490462606036423932L, new InputArgument[]
						{
							character,
							11
						});
						int num27 = Function.Call<int>(334205219021784294L, new InputArgument[]
						{
							character,
							11
						});
						this.Config.SetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Drawable", num26);
						this.Config.SetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Palette", num27);
						this.Config.Save();
						UI.Notify("Outfit saved!");
					}
					bool flag7 = SVL.Index == 1;
					if (flag7)
					{
						Get.Text = "Load";
						Ped character2 = Game.Player.Character;
						if (Yacht.<>o__176.<>p__3 == null)
						{
							Yacht.<>o__176.<>p__3 = CallSite<Action<CallSite, Yacht, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.InvokeSimpleName | CSharpBinderFlags.ResultDiscarded, "LoadIniFile", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Yacht, object> target2 = Yacht.<>o__176.<>p__3.Target;
						CallSite <>p__2 = Yacht.<>o__176.<>p__3;
						Yacht <>4__this2 = this;
						if (Yacht.<>o__176.<>p__2 == null)
						{
							Yacht.<>o__176.<>p__2 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target2(<>p__2, <>4__this2, Yacht.<>o__176.<>p__2.Target(Yacht.<>o__176.<>p__2, arg, Slots[Sl.Index]));
						int num28 = 0;
						num28 = this.Config.GetValue<int>("0 FACE", "Head_Drawable", num28);
						int num29 = 0;
						num29 = this.Config.GetValue<int>("0 FACE", "Head_Palette", num29);
						int num30 = 0;
						num30 = this.Config.GetValue<int>("1 BEARD", "BEARD_Drawable", num30);
						int num31 = 0;
						num31 = this.Config.GetValue<int>("1 BEARD", "BEARD_Palette", num31);
						int num32 = 0;
						num32 = this.Config.GetValue<int>("2 HAIRCUT", "HAIRCUT_Drawable", num32);
						int num33 = 0;
						num33 = this.Config.GetValue<int>("2 HAIRCUT", "HAIRCUT_Palette", num33);
						int num34 = 0;
						num34 = this.Config.GetValue<int>("3 SHIRT", "SHIRT_Drawable", num34);
						int num35 = 0;
						num35 = this.Config.GetValue<int>("3 SHIRT", "SHIRT_Palette", num35);
						int num36 = 0;
						num36 = this.Config.GetValue<int>("4 PANTS", "PANTS_Drawable", num36);
						int num37 = 0;
						num37 = this.Config.GetValue<int>("4 PANTS", "PANTS_Palette", num37);
						int num38 = 0;
						num38 = this.Config.GetValue<int>("5 Hands / Gloves", "Gloves_Drawable", num38);
						int num39 = 0;
						num39 = this.Config.GetValue<int>("5 Hands / Gloves", "Gloves_Palette", num39);
						int num40 = 0;
						num40 = this.Config.GetValue<int>("6 SHOES", "SHOES_Drawable", num40);
						int num41 = 0;
						num41 = this.Config.GetValue<int>("6 SHOES", "SHOES_Palette", num41);
						int num42 = 0;
						num42 = this.Config.GetValue<int>("7 Eyes", "Eyes_Drawable", num42);
						int num43 = 0;
						num43 = this.Config.GetValue<int>("7 Eyes", "Eyes_Palette", num43);
						int num44 = 0;
						num44 = this.Config.GetValue<int>("8 Accessories", "Accessories_Drawable", num44);
						int num45 = 0;
						num45 = this.Config.GetValue<int>("8 Accessories", "Accessories_Palette", num45);
						int num46 = 0;
						num46 = this.Config.GetValue<int>("9 Mission Items/ Tasks", "Mission_Drawable", num46);
						int num47 = 0;
						num47 = this.Config.GetValue<int>("9 Mission Items/ Tasks", "Mission_Palette", num47);
						int num48 = 0;
						num48 = this.Config.GetValue<int>("10 Decals", "Decals_Drawable", num48);
						int num49 = 0;
						num49 = this.Config.GetValue<int>("10 Decals", "Decals_Palette", num49);
						int num50 = 0;
						num50 = this.Config.GetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Drawable", num50);
						int num51 = 0;
						num51 = this.Config.GetValue<int>("11 Collars and Inner Shirts", "InnerShirts_Palette", num51);
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							0,
							num28,
							num29,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							1,
							num30,
							num31,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							2,
							num32,
							num33,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							3,
							num34,
							num35,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							4,
							num36,
							num37,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							5,
							num38,
							num39,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							6,
							num40,
							num41,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							7,
							num42,
							num43,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							8,
							num44,
							num45,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							9,
							num46,
							num47,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							10,
							num48,
							num49,
							1
						});
						Function.Call(2750315038012726912L, new InputArgument[]
						{
							character2,
							11,
							num50,
							num51,
							1
						});
						int num52 = 0;
						num52 = this.Config.GetValue<int>("-1 HAT", "Hat_Drawable", num52);
						int num53 = 0;
						num53 = this.Config.GetValue<int>("-1 Hat", "Hat_Tex", num53);
						int num54 = 0;
						num54 = this.Config.GetValue<int>("-1 Hat", "Hat_Palette", num54);
						bool flag8 = num52 >= 1;
						if (flag8)
						{
							Function.Call(-7838678542154536097L, new InputArgument[]
							{
								character2,
								0,
								num52,
								num53,
								num54
							});
						}
						else
						{
							bool flag9 = num52 < 1;
							if (flag9)
							{
								Function.Call(-3635964867217379578L, new InputArgument[]
								{
									Game.Player.Character
								});
							}
						}
					}
				}
			};
			uimenu3.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = SVL.Index == 0;
				if (flag)
				{
					Get.Text = "Save";
				}
				bool flag2 = SVL.Index == 1;
				if (flag2)
				{
					Get.Text = "Load";
				}
			};
			UIMenuListItem Comp1 = new UIMenuListItem("", list5, 0);
			uimenu2.AddItem(Comp1);
			UIMenuListItem Drawable = new UIMenuListItem("Item : ", list3, 0);
			uimenu2.AddItem(Drawable);
			UIMenuListItem Texture = new UIMenuListItem("Texture : ", list4, 0);
			uimenu2.AddItem(Texture);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Set;
				if (flag)
				{
					this.LoadIniFile("scripts//YachtWaredrobe//Wardrobe//Weapons.ini");
					foreach (WeaponHash weaponHash in (WeaponHash[])Enum.GetValues(typeof(WeaponHash)))
					{
						bool flag2 = Game.Player.Character.Weapons.HasWeapon(weaponHash);
						if (flag2)
						{
							Game.Player.Character.Weapons.Select(weaponHash, false);
							this.Config.SetValue<WeaponHash>(weaponHash.ToString(), "WeaponName", weaponHash);
							WeaponHash hash = Game.Player.Character.Weapons.Current.Hash;
							this.Liv = Game.Player.Character.Weapons.Current.Tint;
							int num = 0;
							foreach (WeaponComponent weaponComponent in (WeaponComponent[])Enum.GetValues(typeof(WeaponComponent)))
							{
								try
								{
									bool flag3 = Function.Call<bool>(6696357820197948080L, new InputArgument[]
									{
										weaponHash.GetHashCode(),
										weaponComponent.GetHashCode()
									});
									if (flag3)
									{
										bool flag4 = Game.Player.Character.Weapons.Current.IsComponentActive(weaponComponent);
										if (flag4)
										{
											this.Config.SetValue<bool>(weaponHash.ToString(), "HasComponent" + num.ToString(), true);
											this.Config.SetValue<WeaponComponent>(weaponHash.ToString(), "Component" + num.ToString(), weaponComponent);
											num++;
											this.Config.Save();
										}
										bool flag5 = !Game.Player.Character.Weapons.Current.IsComponentActive(weaponComponent);
										if (flag5)
										{
											this.Config.SetValue<bool>(weaponHash.ToString(), "HasComponent" + num.ToString(), false);
											this.Config.SetValue<WeaponComponent>(weaponHash.ToString(), "Component" + num.ToString(), weaponComponent);
											num++;
											this.Config.Save();
										}
									}
								}
								catch
								{
									num++;
									UI.Notify("~y~ Warning ~w~: Weapon : " + weaponHash.ToString() + " Failed to save");
								}
							}
							this.Config.SetValue<WeaponTint>(weaponHash.ToString(), "Tint", this.Liv);
							this.Config.Save();
						}
					}
					this.ID_O = O.Index;
					Yacht <>4__this = this;
					if (Yacht.<>o__176.<>p__4 == null)
					{
						Yacht.<>o__176.<>p__4 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
					}
					<>4__this.ID_C = Yacht.<>o__176.<>p__4.Target(Yacht.<>o__176.<>p__4, Colours[C.Index]);
					this.Setoutfit(O.Index);
					UI.Notify("~y~ Warning ~w~ Lag is normal while applying outfits");
					Script.Wait(2000);
					if (Yacht.<>o__176.<>p__9 == null)
					{
						Yacht.<>o__176.<>p__9 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Notify", null, typeof(Yacht), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Action<CallSite, Type, object> target = Yacht.<>o__176.<>p__9.Target;
					CallSite <>p__ = Yacht.<>o__176.<>p__9;
					Type typeFromHandle = typeof(UI);
					if (Yacht.<>o__176.<>p__8 == null)
					{
						Yacht.<>o__176.<>p__8 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target2 = Yacht.<>o__176.<>p__8.Target;
					CallSite <>p__2 = Yacht.<>o__176.<>p__8;
					if (Yacht.<>o__176.<>p__7 == null)
					{
						Yacht.<>o__176.<>p__7 = CallSite<Func<CallSite, object, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					Func<CallSite, object, object, object> target3 = Yacht.<>o__176.<>p__7.Target;
					CallSite <>p__3 = Yacht.<>o__176.<>p__7;
					if (Yacht.<>o__176.<>p__6 == null)
					{
						Yacht.<>o__176.<>p__6 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
						}));
					}
					Func<CallSite, object, string, object> target4 = Yacht.<>o__176.<>p__6.Target;
					CallSite <>p__4 = Yacht.<>o__176.<>p__6;
					if (Yacht.<>o__176.<>p__5 == null)
					{
						Yacht.<>o__176.<>p__5 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
						{
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
							CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
						}));
					}
					target(<>p__, typeFromHandle, target2(<>p__2, target3(<>p__3, target4(<>p__4, Yacht.<>o__176.<>p__5.Target(Yacht.<>o__176.<>p__5, "Player is wearing outfit : ~y~", Outfits[O.Index]), "~w~ with colour : ~y~"), Colours[C.Index]), "~y~"));
					this.LoadIniFile("scripts//YachtWaredrobe//Wardrobe//Weapons.ini");
					foreach (WeaponHash weaponHash2 in (WeaponHash[])Enum.GetValues(typeof(WeaponHash)))
					{
						WeaponHash value = this.Config.GetValue<WeaponHash>(weaponHash2.ToString(), "WeaponName", weaponHash2);
						bool flag6 = weaponHash2 == value;
						if (flag6)
						{
							Game.Player.Character.Weapons.Give(weaponHash2, 9999, true, true);
							Game.Player.Character.Weapons.Select(weaponHash2, true);
							this.Liv = this.Config.GetValue<WeaponTint>(weaponHash2.ToString(), "Tint", this.Liv);
							WeaponHash hash2 = Game.Player.Character.Weapons.Current.Hash;
							Game.Player.Character.Weapons.Current.Tint = this.Liv;
							this.Comp = 0;
							foreach (WeaponComponent weaponComponent2 in (WeaponComponent[])Enum.GetValues(typeof(WeaponComponent)))
							{
								try
								{
									bool flag7 = Function.Call<bool>(6696357820197948080L, new InputArgument[]
									{
										weaponHash2.GetHashCode(),
										weaponComponent2.GetHashCode()
									});
									if (flag7)
									{
										bool value2 = this.Config.GetValue<bool>(weaponHash2.ToString(), "HasComponent" + this.Comp.ToString(), true);
										if (value2)
										{
											Game.Player.Character.Weapons.Current.SetComponent(weaponComponent2, true);
											this.Comp++;
										}
										else
										{
											bool flag8 = !this.Config.GetValue<bool>(weaponHash2.ToString(), "HasComponent" + this.Comp.ToString(), true);
											if (flag8)
											{
												this.Comp++;
											}
										}
									}
								}
								catch
								{
									this.Comp++;
								}
							}
						}
					}
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						177293209,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						3686625920U,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						4208062921U,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						2024373456,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						961495388,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						3219281620U,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						1432025498,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						-2009644972,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						-879347409,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						-1768145561,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						-2066285827,
						9999
					});
					Function.Call(8714538174022443552L, new InputArgument[]
					{
						Game.Player.Character,
						1785463520,
						9999
					});
					Game.Player.Character.Weapons.Give(-1569615261, 9999, true, true);
				}
				bool flag9 = item == Remove;
				if (flag9)
				{
					bool flag10 = Game.Player.Character.Model == 1885233650;
					if (flag10)
					{
						UI.Notify("taking off Outfit, this may take some time, lag spikes are normal");
						Model model;
						model..ctor(this.OldCharacter.Hash);
						model.Request(500);
						bool flag11 = model.IsInCdImage && model.IsValid;
						if (flag11)
						{
							while (!model.IsLoaded)
							{
								Script.Wait(100);
							}
							Function.Call(45540521788082230L, new InputArgument[]
							{
								Game.Player,
								model.Hash
							});
						}
						model.MarkAsNoLongerNeeded();
						this.LoadIniFile("scripts//YachtWaredrobe//Waredrobe//Weapons.ini");
						foreach (WeaponHash weaponHash3 in (WeaponHash[])Enum.GetValues(typeof(WeaponHash)))
						{
							WeaponHash value3 = this.Config.GetValue<WeaponHash>(weaponHash3.ToString(), "WeaponName", weaponHash3);
							bool flag12 = weaponHash3 == value3;
							if (flag12)
							{
								Game.Player.Character.Weapons.Give(weaponHash3, 9999, true, true);
								Game.Player.Character.Weapons.Select(weaponHash3, true);
								this.Liv = this.Config.GetValue<WeaponTint>(weaponHash3.ToString(), "Tint", this.Liv);
								WeaponHash hash3 = Game.Player.Character.Weapons.Current.Hash;
								Game.Player.Character.Weapons.Current.Tint = this.Liv;
								this.Comp = 0;
								foreach (WeaponComponent weaponComponent3 in (WeaponComponent[])Enum.GetValues(typeof(WeaponComponent)))
								{
									try
									{
										bool flag13 = Function.Call<bool>(6696357820197948080L, new InputArgument[]
										{
											weaponHash3.GetHashCode(),
											weaponComponent3.GetHashCode()
										});
										if (flag13)
										{
											bool value4 = this.Config.GetValue<bool>(weaponHash3.ToString(), "HasComponent" + this.Comp.ToString(), true);
											if (value4)
											{
												Game.Player.Character.Weapons.Current.SetComponent(weaponComponent3, true);
												this.Comp++;
											}
											else
											{
												bool flag14 = !this.Config.GetValue<bool>(weaponHash3.ToString(), "HasComponent" + this.Comp.ToString(), true);
												if (flag14)
												{
													this.Comp++;
												}
											}
										}
									}
									catch
									{
										this.Comp++;
									}
								}
							}
						}
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							177293209,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							3686625920U,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							4208062921U,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							2024373456,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							961495388,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							3219281620U,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							1432025498,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							-2009644972,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							-879347409,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							-1768145561,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							-2066285827,
							9999
						});
						Function.Call(8714538174022443552L, new InputArgument[]
						{
							Game.Player.Character,
							1785463520,
							9999
						});
						Game.Player.Character.Weapons.Give(-1569615261, 9999, true, true);
						UI.Notify("Removed Outfit!");
					}
				}
			};
			uimenu.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == O;
				if (flag)
				{
					this.ID_O = O.Index;
				}
				bool flag2 = item == C;
				if (flag2)
				{
					bool flag3 = C == O;
					if (flag3)
					{
						Yacht <>4__this = this;
						if (Yacht.<>o__176.<>p__10 == null)
						{
							Yacht.<>o__176.<>p__10 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
						}
						<>4__this.ID_C = Yacht.<>o__176.<>p__10.Target(Yacht.<>o__176.<>p__10, Colours[C.Index]);
					}
				}
			};
			uimenu2.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				try
				{
					bool flag = item == Comp1;
					if (flag)
					{
						bool flag2 = Game.Player.Character != null;
						if (flag2)
						{
							bool flag3 = Function.Call<int>(2834476523764480066L, new InputArgument[]
							{
								Game.Player.Character,
								Comp1.Index
							}) > Drawable.Index;
							if (flag3)
							{
								if (Yacht.<>o__176.<>p__11 == null)
								{
									Yacht.<>o__176.<>p__11 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__11.Target(Yacht.<>o__176.<>p__11, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
							else
							{
								Drawable.Index = 0;
								if (Yacht.<>o__176.<>p__12 == null)
								{
									Yacht.<>o__176.<>p__12 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__12.Target(Yacht.<>o__176.<>p__12, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
							bool flag4 = Function.Call<int>(-8110606195499570259L, new InputArgument[]
							{
								Game.Player.Character,
								Comp1.Index,
								Drawable.Index
							}) > Texture.Index;
							if (flag4)
							{
								if (Yacht.<>o__176.<>p__13 == null)
								{
									Yacht.<>o__176.<>p__13 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__13.Target(Yacht.<>o__176.<>p__13, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
							else
							{
								Texture.Index = 0;
								if (Yacht.<>o__176.<>p__14 == null)
								{
									Yacht.<>o__176.<>p__14 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__14.Target(Yacht.<>o__176.<>p__14, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
						}
					}
					bool flag5 = item == Drawable;
					if (flag5)
					{
						bool flag6 = Game.Player.Character != null;
						if (flag6)
						{
							bool flag7 = Function.Call<int>(2834476523764480066L, new InputArgument[]
							{
								Game.Player.Character,
								Comp1.Index
							}) > Drawable.Index;
							if (flag7)
							{
								if (Yacht.<>o__176.<>p__15 == null)
								{
									Yacht.<>o__176.<>p__15 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__15.Target(Yacht.<>o__176.<>p__15, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
							else
							{
								Drawable.Index = 0;
								if (Yacht.<>o__176.<>p__16 == null)
								{
									Yacht.<>o__176.<>p__16 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__16.Target(Yacht.<>o__176.<>p__16, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
						}
					}
					bool flag8 = item == Texture;
					if (flag8)
					{
						bool flag9 = Game.Player.Character != null;
						if (flag9)
						{
							bool flag10 = Function.Call<int>(-8110606195499570259L, new InputArgument[]
							{
								Game.Player.Character,
								Comp1.Index,
								Drawable.Index
							}) > Texture.Index;
							if (flag10)
							{
								if (Yacht.<>o__176.<>p__17 == null)
								{
									Yacht.<>o__176.<>p__17 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__17.Target(Yacht.<>o__176.<>p__17, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
							else
							{
								Texture.Index = 0;
								if (Yacht.<>o__176.<>p__18 == null)
								{
									Yacht.<>o__176.<>p__18 = CallSite<Action<CallSite, Type, Hash, Ped, int, object, object, int>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Call", null, typeof(Yacht), new CSharpArgumentInfo[]
									{
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
										CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
									}));
								}
								Yacht.<>o__176.<>p__18.Target(Yacht.<>o__176.<>p__18, typeof(Function), 2750315038012726912L, Game.Player.Character, Comp1.Index, Draw[Drawable.Index], Tex[Texture.Index], 1);
							}
						}
					}
				}
				catch
				{
				}
			};
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00010288 File Offset: 0x0000E488
		private void LoadIniFile(string iniName)
		{
			try
			{
				this.Config = ScriptSettings.Load(iniName);
				this.LoadTime = this.Config.GetValue<int>("SPAWN - SETNOLOWERTHAN_ONE", "TIME", this.LoadTime);
				this.Key1 = this.Config.GetValue<Keys>("Configurations", "Key1", this.Key1);
				this.purchaselvl = this.Config.GetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
				this.stockscount = this.Config.GetValue<int>("Setup", "stockslevel", this.stockscount);
				this.stocksvalue = this.Config.GetValue<float>("Setup", "StocksValue", this.stocksvalue);
				this.BuzzardBought = this.Config.GetValue<int>("Setup", "BuzzardBought", this.BuzzardBought);
				this.FMJBought = this.Config.GetValue<int>("Setup", "FMJBought", this.FMJBought);
				this.A911Bought = this.Config.GetValue<int>("Setup", "911Bought", this.A911Bought);
				this.X80Bought = this.Config.GetValue<int>("Setup", "X80Bought", this.X80Bought);
				this.SEVEN70Bought = this.Config.GetValue<int>("Setup", "SEVEN70Bought", this.SEVEN70Bought);
				this.GunLockerBought = this.Config.GetValue<int>("Setup", "GunLockerBought", this.GunLockerBought);
				this.MoneyVaultBought = this.Config.GetValue<int>("Setup", " MoneyVaultBought", this.MoneyVaultBought);
				this.AATrailerABought = this.Config.GetValue<int>("Setup", "AATrailerABought", this.AATrailerABought);
				this.AATrailerBBought = this.Config.GetValue<int>("Setup", "AATrailerBBought", this.AATrailerBBought);
				this.AATrailerCBought = this.Config.GetValue<int>("Setup", " AATrailerCBought", this.AATrailerCBought);
				this.ValkyrieBought = this.Config.GetValue<int>("Setup", "ValkyrieBought", this.ValkyrieBought);
				this.SavageBought = this.Config.GetValue<int>("Setup", "SavageBought", this.SavageBought);
				this.HunterBought = this.Config.GetValue<int>("Setup", "HunterBought", this.HunterBought);
				this.AkulaBought = this.Config.GetValue<int>("Setup", "AkulaBought", this.AkulaBought);
				this.AnnihilatorBought = this.Config.GetValue<int>("Setup", "AnnihilatorBought", this.AnnihilatorBought);
				this.UseCustomWaitTime = this.Config.GetValue<int>("Setup", "UseCustomWaitTime", this.UseCustomWaitTime);
				this.turretedlimo = this.Config.GetValue<int>("Setup", "turretedlimo", this.turretedlimo);
				this.Design = this.Config.GetValue<string>("Design", "InteriorDesign", this.Design);
				this.maxstocks = 10 * this.purchaselvl;
				float num = (float)(125000 * this.purchaselvl) / 0.75f;
				this.profitMargin = (float)(0.85 * (double)this.purchaselvl + 0.0);
				this.increaseGain = num;
			}
			catch (Exception ex)
			{
				UI.Notify("~r~Error~w~: ArcadiusTower.ini Failed To Load.");
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00010618 File Offset: 0x0000E818
		private void LoadIniFile2(string iniName)
		{
			try
			{
				this.Config = ScriptSettings.Load(iniName);
				this.Purchased = this.Config.GetValue<int>("Yacht", "Purchased", this.Purchased);
				this.GoldRails = this.Config.GetValue<bool>("Yacht", "GoldRails", this.GoldRails);
				this.ShipColor = this.Config.GetValue<int>("Yacht", "ShipColor", this.ShipColor);
				this.RailsColor = this.Config.GetValue<int>("Yacht", "RailsColor", this.RailsColor);
				this.YachtType = this.Config.GetValue<int>("Yacht", "YachtType", this.YachtType);
				this.Location = this.Config.GetValue<int>("Yacht", "Location", this.Location);
				this.Lighting = this.Config.GetValue<int>("Yacht", "Lighting", this.Lighting);
				this.LightingColor = this.Config.GetValue<int>("Yacht", "LightingColor", this.LightingColor);
				this.H1 = this.Config.GetValue<int>("Yacht", "HeliA", this.H1);
				this.H2 = this.Config.GetValue<int>("Yacht", "HeliB", this.H2);
				this.PedType = this.Config.GetValue<int>("Yacht", "PedType", this.PedType);
				this.CurrentFlag = this.Config.GetValue<int>("Yacht", "CurrentFlag", this.CurrentFlag);
				this.ShowTestBlips = this.Config.GetValue<bool>("Yacht", "ShowTestBlips", this.ShowTestBlips);
				this.AmountOfSeaSharks = this.Config.GetValue<int>("Yacht", "AmountOfSeaSharks", this.AmountOfSeaSharks);
				this.BoatAType = this.Config.GetValue<int>("Yacht", "BoatAType", this.BoatAType);
				this.BoatBType = this.Config.GetValue<int>("Yacht", "BoatBType", this.BoatBType);
				this.SpawnDist = this.Config.GetValue<int>("Yacht", "SpawnDist", this.SpawnDist);
				this.ShowDistWhenClose = this.Config.GetValue<bool>("Yacht", "ShowDistWhenClose", this.ShowDistWhenClose);
			}
			catch (Exception ex)
			{
				UI.Notify("~r~Error~w~: ArcadiusTower.ini Failed To Load.");
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000108B4 File Offset: 0x0000EAB4
		public void Reset()
		{
			this.Delete();
			this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
			this.Created = false;
			Blip blip = World.CreateBlip(new Vector3(this.YachtPos[this.Location].X, this.YachtPos[this.Location].Y, this.YachtPos[this.Location].Z));
			blip.Sprite = 455;
			blip.Name = "Yacht : " + this.Location.ToString() + ", " + this.YachtLocSring[this.Location];
			blip.Color = 2;
			this.Blips.Add(blip);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0001097C File Offset: 0x0000EB7C
		public void SpawnProp(string Prop, Vector3 Pos, Vector3 Rot, int i)
		{
			try
			{
				Model model;
				model..ctor(Prop);
				model.Request(250);
				bool flag = model.IsInCdImage && model.IsValid;
				if (flag)
				{
					while (!model.IsLoaded)
					{
						Script.Wait(50);
					}
					Prop[] nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					World.CreateProp(model, Pos, true, false);
					bool flag2 = i != 4 && i != 5 && i != 6;
					if (flag2)
					{
						nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					}
					else
					{
						nearbyProps = World.GetNearbyProps(Pos, 2f, model);
					}
					bool flag3 = i != 4 && i != 5;
					if (flag3)
					{
						foreach (Prop prop in nearbyProps)
						{
							bool flag4 = this.Base != null;
							if (flag4)
							{
								bool flag5 = i == 1;
								if (flag5)
								{
									prop.AttachTo(this.Base, 0, new Vector3(0f, 0f, 14.5f), new Vector3(0f, 0f, this.GetRoationalAxis()));
									prop.HasCollision = true;
									this.Props.Add(prop);
									Function.Call(-7557708654927622093L, new InputArgument[]
									{
										prop,
										this.ShipColor
									});
								}
								bool flag6 = i == 2;
								if (flag6)
								{
									prop.AttachTo(this.Base, 0, new Vector3(0f, 0f, 14.5f), new Vector3(0f, 0f, this.GetRoationalAxis()));
									prop.HasCollision = true;
									this.Props.Add(prop);
									bool flag7 = !this.GoldRails;
									if (flag7)
									{
										Function.Call(-7557708654927622093L, new InputArgument[]
										{
											prop,
											this.RailsColor
										});
									}
									else
									{
										bool goldRails = this.GoldRails;
										if (goldRails)
										{
											Function.Call(-7557708654927622093L, new InputArgument[]
											{
												prop,
												0
											});
										}
									}
								}
								bool flag8 = i == 3;
								if (flag8)
								{
									prop.AttachTo(this.Base, 0, new Vector3(0f, 0f, 14.5f), new Vector3(0f, 0f, this.GetRoationalAxis()));
									prop.HasCollision = true;
									this.Props.Add(prop);
								}
								bool flag9 = i == 6;
								if (flag9)
								{
									prop.AttachTo(this.Base, 0, new Vector3(-36.8f, -2.7f, 0.6f), new Vector3(0f, 0f, 90f));
									prop.HasCollision = true;
									bool flag10 = this.DoorA == null;
									if (flag10)
									{
										this.DoorA = prop;
									}
									this.Props.Add(prop);
									Function.Call(-7557708654927622093L, new InputArgument[]
									{
										prop,
										this.ShipColor
									});
								}
								bool flag11 = i == 7;
								if (flag11)
								{
									prop.AttachTo(this.Base, 0, new Vector3(-51f, -2f, 0.3f), new Vector3(0f, 0f, this.GetRoationalAxis()));
									prop.HasCollision = true;
									this.Props.Add(prop);
								}
							}
						}
					}
					else
					{
						bool flag12 = i == 4 || i == 5;
						if (flag12)
						{
							foreach (Prop prop2 in nearbyProps)
							{
								bool flag13 = this.Base != null;
								if (flag13)
								{
									bool flag14 = i == 4;
									if (flag14)
									{
										bool flag15 = this.DoorB == null;
										if (flag15)
										{
											this.DoorB = prop2;
										}
										break;
									}
									bool flag16 = i == 5;
									if (flag16)
									{
										bool flag17 = this.DoorC == null;
										if (flag17)
										{
											this.DoorC = prop2;
										}
										break;
									}
								}
							}
						}
					}
				}
				model.MarkAsNoLongerNeeded();
			}
			catch (Exception ex)
			{
				UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00010E24 File Offset: 0x0000F024
		public void SpawnDoor(string Prop, Vector3 Pos, Vector3 Rot, int i)
		{
			try
			{
				Model model;
				model..ctor(Prop);
				model.Request(250);
				bool flag = model.IsInCdImage && model.IsValid;
				if (flag)
				{
					while (!model.IsLoaded)
					{
						Script.Wait(50);
					}
					Prop[] nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					bool flag2 = this.DoorB == null;
					if (flag2)
					{
						this.DoorB = World.CreateProp(model, Pos, false, false);
					}
					bool flag3 = this.DoorC == null;
					if (flag3)
					{
						this.DoorC = World.CreateProp(model, Pos, false, false);
					}
				}
				model.MarkAsNoLongerNeeded();
			}
			catch (Exception ex)
			{
				UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00010F00 File Offset: 0x0000F100
		public void SpawnFlagA(string Prop, Vector3 Pos, Vector3 Rot, int i)
		{
			try
			{
				Model model;
				model..ctor(Prop);
				model.Request(250);
				bool flag = model.IsInCdImage && model.IsValid;
				if (flag)
				{
					while (!model.IsLoaded)
					{
						Script.Wait(50);
					}
					Prop[] nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					bool flag2 = this.FlagA == null;
					if (flag2)
					{
						this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
					}
					else
					{
						this.FlagA.Delete();
						this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
					}
				}
				model.MarkAsNoLongerNeeded();
			}
			catch (Exception ex)
			{
				UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00010FE0 File Offset: 0x0000F1E0
		public void SpawnFlagB(string Prop, Vector3 Pos, Vector3 Rot, int i)
		{
			try
			{
				Model model;
				model..ctor(Prop);
				model.Request(250);
				bool flag = model.IsInCdImage && model.IsValid;
				if (flag)
				{
					while (!model.IsLoaded)
					{
						Script.Wait(50);
					}
					Prop[] nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					bool flag2 = this.FlagB == null;
					if (flag2)
					{
						this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
					}
					else
					{
						this.FlagB.Delete();
						this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
					}
				}
				model.MarkAsNoLongerNeeded();
			}
			catch (Exception ex)
			{
				UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000110C0 File Offset: 0x0000F2C0
		public void SpawnFlagC(string Prop, Vector3 Pos, Vector3 Rot, int i)
		{
			try
			{
				Model model;
				model..ctor(Prop);
				model.Request(250);
				bool flag = model.IsInCdImage && model.IsValid;
				if (flag)
				{
					while (!model.IsLoaded)
					{
						Script.Wait(50);
					}
					Prop[] nearbyProps = World.GetNearbyProps(Pos, 100f, model);
					bool flag2 = this.FlagC == null;
					if (flag2)
					{
						this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
					}
					else
					{
						this.FlagC.Delete();
						this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
					}
				}
				model.MarkAsNoLongerNeeded();
			}
			catch (Exception ex)
			{
				UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000111A0 File Offset: 0x0000F3A0
		public Yacht()
		{
			base.Tick += this.OnTick;
			base.Aborted += this.OnShutdown;
			base.Interval = 1;
			this.Setup();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00011818 File Offset: 0x0000FA18
		public void AddPeds()
		{
			this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
			foreach (Ped ped in this.Peds)
			{
				bool flag = ped != null;
				if (flag)
				{
					ped.Delete();
				}
			}
			bool flag2 = this.Bargirl != null;
			if (flag2)
			{
				this.Bargirl.Delete();
			}
			bool flag3 = this.PedType == 0;
			if (flag3)
			{
			}
			bool flag4 = this.PedType == 1;
			if (flag4)
			{
				Random random = new Random();
				int num = random.Next(1, 100);
				bool flag5 = num < 50;
				if (flag5)
				{
					Ped p = World.CreatePed(1077785853, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
					this.PlayAnim(p, 2);
				}
				else
				{
					bool flag6 = num > 50;
					if (flag6)
					{
						Ped p = World.CreatePed(-945854168, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
						this.PlayAnim(p, 1);
					}
				}
				Script.Wait(1);
				this.IsinHottub = false;
				num = random.Next(1, 100);
				bool flag7 = num < 50;
				if (flag7)
				{
					Ped p = World.CreatePed(1077785853, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
					this.PlayAnim(p, 2);
				}
				else
				{
					bool flag8 = num > 50;
					if (flag8)
					{
						Ped p = World.CreatePed(-945854168, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
						this.PlayAnim(p, 1);
					}
				}
				Script.Wait(1);
				num = random.Next(1, 100);
				bool flag9 = num < 50;
				if (flag9)
				{
					Ped p = World.CreatePed(1077785853, this.jacuzziSeat4, this.Base.Rotation.Z + 220f);
					this.PlayAnim(p, 2);
				}
				else
				{
					bool flag10 = num > 50;
					if (flag10)
					{
						Ped p = World.CreatePed(-945854168, this.jacuzziSeat4, this.Base.Rotation.Z + 200f);
						this.PlayAnim(p, 1);
					}
				}
				Script.Wait(1);
				num = random.Next(1, 100);
				bool flag11 = num < 50;
				if (flag11)
				{
					Ped p = World.CreatePed(1077785853, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
					this.PlayAnim(p, 2);
				}
				else
				{
					bool flag12 = num > 50;
					if (flag12)
					{
						Ped p = World.CreatePed(-945854168, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
						this.PlayAnim(p, 1);
					}
				}
				Script.Wait(1);
				num = random.Next(1, 100);
				bool flag13 = num < 50;
				if (flag13)
				{
					Ped p = World.CreatePed(1077785853, this.jacuzziSeat5, this.Base.Rotation.Z + 280f);
					this.PlayAnim(p, 2);
				}
				else
				{
					bool flag14 = num > 50;
					if (flag14)
					{
						Ped p = World.CreatePed(-945854168, this.jacuzziSeat5, this.Base.Rotation.Z + 280f);
						this.PlayAnim(p, 1);
					}
				}
				Script.Wait(1);
			}
			bool flag15 = this.PedType == 2;
			if (flag15)
			{
				Ped p2 = World.CreatePed(1077785853, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
				this.PlayAnim(p2, 1);
				Script.Wait(1);
				this.IsinHottub = false;
				p2 = World.CreatePed(1077785853, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
				this.PlayAnim(p2, 1);
				Script.Wait(1);
				p2 = World.CreatePed(1077785853, this.jacuzziSeat4, this.Base.Rotation.Z + 220f);
				this.PlayAnim(p2, 1);
				Script.Wait(1);
				p2 = World.CreatePed(1077785853, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
				this.PlayAnim(p2, 1);
				Script.Wait(1);
				p2 = World.CreatePed(1077785853, this.jacuzziSeat6, this.Base.Rotation.Z + 280f);
				this.PlayAnim(p2, 1);
				Script.Wait(1);
			}
			bool flag16 = this.PedType == 3;
			if (flag16)
			{
				Ped p3 = World.CreatePed(-945854168, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
				this.PlayAnim(p3, 1);
				Script.Wait(1);
				this.IsinHottub = false;
				p3 = World.CreatePed(-945854168, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
				this.PlayAnim(p3, 1);
				Script.Wait(1);
				p3 = World.CreatePed(-945854168, this.jacuzziSeat4, this.Base.Rotation.Z + 220f);
				this.PlayAnim(p3, 1);
				Script.Wait(1);
				p3 = World.CreatePed(-945854168, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
				this.PlayAnim(p3, 1);
				Script.Wait(1);
				p3 = World.CreatePed(-945854168, this.jacuzziSeat6, this.Base.Rotation.Z + 280f);
				this.PlayAnim(p3, 1);
				Script.Wait(1);
			}
			bool flag17 = this.PedType == 4;
			if (flag17)
			{
				Ped p4 = World.CreatePed(-1661836925, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
				this.PlayAnim(p4, 1);
				Script.Wait(1);
				this.IsinHottub = false;
				p4 = World.CreatePed(-1661836925, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
				this.PlayAnim(p4, 1);
				Script.Wait(1);
				p4 = World.CreatePed(-1661836925, this.jacuzziSeat4, this.Base.Rotation.Z + 220f);
				this.PlayAnim(p4, 1);
				Script.Wait(1);
				p4 = World.CreatePed(-1661836925, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
				this.PlayAnim(p4, 1);
				Script.Wait(1);
				p4 = World.CreatePed(-1661836925, this.jacuzziSeat6, this.Base.Rotation.Z + 280f);
				this.PlayAnim(p4, 1);
				Script.Wait(1);
			}
			bool flag18 = this.PedType == 5;
			if (flag18)
			{
				Random random2 = new Random();
				int num2 = random2.Next(1, 100);
				bool flag19 = num2 < 50;
				if (flag19)
				{
					Ped p5 = World.CreatePed(1077785853, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
					this.PlayAnim(p5, 2);
				}
				else
				{
					bool flag20 = num2 > 50;
					if (flag20)
					{
						Ped p5 = World.CreatePed(-1661836925, this.jacuzziSeat2, this.Base.Rotation.Z - 5f);
						this.PlayAnim(p5, 1);
					}
				}
				Script.Wait(1);
				this.IsinHottub = false;
				num2 = random2.Next(1, 100);
				bool flag21 = num2 < 50;
				if (flag21)
				{
					Ped p5 = World.CreatePed(1077785853, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
					this.PlayAnim(p5, 2);
				}
				else
				{
					bool flag22 = num2 > 50;
					if (flag22)
					{
						Ped p5 = World.CreatePed(-1661836925, this.jacuzziSeat3, this.Base.Rotation.Z + 150f);
						this.PlayAnim(p5, 1);
					}
				}
				Script.Wait(1);
				num2 = random2.Next(1, 100);
				bool flag23 = num2 < 50;
				if (flag23)
				{
					Ped p5 = World.CreatePed(1077785853, this.jacuzziSeat4, this.Base.Rotation.Z + 220f);
					this.PlayAnim(p5, 2);
				}
				else
				{
					bool flag24 = num2 > 50;
					if (flag24)
					{
						Ped p5 = World.CreatePed(-1661836925, this.jacuzziSeat4, this.Base.Rotation.Z + 200f);
						this.PlayAnim(p5, 1);
					}
				}
				Script.Wait(1);
				num2 = random2.Next(1, 100);
				bool flag25 = num2 < 50;
				if (flag25)
				{
					Ped p5 = World.CreatePed(1077785853, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
					this.PlayAnim(p5, 2);
				}
				else
				{
					bool flag26 = num2 > 50;
					if (flag26)
					{
						Ped p5 = World.CreatePed(-1661836925, this.jacuzziSeat5, this.Base.Rotation.Z - 30f);
						this.PlayAnim(p5, 1);
					}
				}
				Script.Wait(1);
				num2 = random2.Next(1, 100);
				bool flag27 = num2 < 50;
				if (flag27)
				{
					Ped p5 = World.CreatePed(1077785853, this.jacuzziSeat6, this.Base.Rotation.Z + 280f);
					this.PlayAnim(p5, 2);
				}
				else
				{
					bool flag28 = num2 > 50;
					if (flag28)
					{
						Ped p5 = World.CreatePed(-1661836925, this.jacuzziSeat6, this.Base.Rotation.Z + 280f);
						this.PlayAnim(p5, 1);
					}
				}
				Script.Wait(1);
			}
			this.Bargirl = World.CreatePed(848542158, this.BarPos);
			this.Bargirl.Rotation = new Vector3(0f, 0f, this.Base.Rotation.Z + 90f);
			this.Bargirl.Task.PlayAnimation("anim@amb@yacht@bow@female@variation_01@", "base", 8f, -1, true, -1f);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00012398 File Offset: 0x00010598
		public void YachtMenu()
		{
			List<dynamic> Dist = new List<object>();
			Dist.Add(200);
			Dist.Add(250);
			Dist.Add(300);
			Dist.Add(350);
			Dist.Add(400);
			Dist.Add(450);
			Dist.Add(500);
			Dist.Add(550);
			Dist.Add(600);
			Dist.Add(650);
			Dist.Add(700);
			Dist.Add(750);
			Dist.Add(800);
			Dist.Add(900);
			Dist.Add(1000);
			Dist.Add(1100);
			Dist.Add(1200);
			Dist.Add(1300);
			Dist.Add(1400);
			Dist.Add(1500);
			Dist.Add(1600);
			Dist.Add(1700);
			Dist.Add(1800);
			Dist.Add(1900);
			Dist.Add(2000);
			Dist.Add(2100);
			Dist.Add(2200);
			Dist.Add(2300);
			Dist.Add(2400);
			Dist.Add(2500);
			Dist.Add("Spawn on game Load");
			List<object> list = new List<object>();
			list.Add("None");
			list.Add("Male & Female");
			list.Add("Male");
			list.Add("Female");
			list.Add("Female - Topless");
			list.Add("Male & Female - Topless");
			List<dynamic> TF = new List<object>();
			TF.Add(false);
			TF.Add(true);
			List<object> list2 = new List<object>();
			foreach (string item2 in this.YachtLocSring)
			{
				list2.Add(item2);
			}
			UIMenu uimenu = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Change Position");
			UIMenuListItem Yloc = new UIMenuListItem("Location : ", list2, 0);
			uimenu.AddItem(Yloc);
			UIMenuItem ChangeLoc = new UIMenuItem("Change Location  -$25000");
			uimenu.AddItem(ChangeLoc);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == ChangeLoc;
				if (flag)
				{
					bool flag2 = Game.Player.Money >= 25000;
					if (flag2)
					{
						this.Delete();
						this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
						Game.Player.Money -= 25000;
						bool flag3 = Yloc.Index == 0;
						if (flag3)
						{
							this.Location = Yloc.Index + 1;
						}
						else
						{
							bool flag4 = Yloc.Index > 0;
							if (flag4)
							{
								this.Location = Yloc.Index;
							}
						}
						this.Config.SetValue<int>("Yacht", "Location", this.Location);
						this.Config.Save();
						foreach (Blip blip in this.Blips)
						{
							bool flag5 = blip != null;
							if (flag5)
							{
								blip.Remove();
							}
						}
						bool flag6 = this.FlagA != null;
						if (flag6)
						{
							this.FlagA.Delete();
						}
						bool flag7 = this.FlagB != null;
						if (flag7)
						{
							this.FlagB.Delete();
						}
						bool flag8 = this.FlagC != null;
						if (flag8)
						{
							this.FlagC.Delete();
						}
						bool flag9 = this.DoorC != null;
						if (flag9)
						{
							this.DoorC.Delete();
						}
						bool flag10 = this.DoorB != null;
						if (flag10)
						{
							this.DoorB.Delete();
						}
						bool flag11 = this.Bargirl != null;
						if (flag11)
						{
							this.Bargirl.Delete();
						}
						this.Created = false;
						Game.Player.Character.Position = this.YachtPos[this.Location];
						Blip blip2 = World.CreateBlip(new Vector3(this.YachtPos[this.Location].X, this.YachtPos[this.Location].Y, this.YachtPos[this.Location].Z));
						blip2.Sprite = 455;
						blip2.Name = "Yacht : " + this.Location.ToString() + ", " + this.YachtLocSring[this.Location];
						blip2.Color = 2;
						this.Blips.Add(blip2);
						this.WaitForCreated = true;
					}
				}
			};
			UIMenu uimenu2 = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Jacuzzi Options");
			UIMenuListItem PedO = new UIMenuListItem("Ped  : ", list, 0);
			uimenu2.AddItem(PedO);
			UIMenuItem ChangePeds = new UIMenuItem("Change peds in Jacuzzi");
			uimenu2.AddItem(ChangePeds);
			uimenu2.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == ChangePeds;
				if (flag)
				{
					this.PedType = PedO.Index;
					this.Config.SetValue<int>("Yacht", "PedType", this.PedType);
					this.Config.Save();
					this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
					this.AddPeds();
				}
			};
			UIMenu uimenu3 = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Misc");
			UIMenuListItem TM = new UIMenuListItem("Show Test Markers  : ", TF, 0);
			uimenu3.AddItem(TM);
			UIMenuListItem Int = new UIMenuListItem("Spawn Dist : ", Dist, 0);
			uimenu3.AddItem(Int);
			UIMenuListItem Sd = new UIMenuListItem("Show Dist When Close : ", TF, 0);
			uimenu3.AddItem(Sd);
			uimenu3.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == Sd;
				if (flag)
				{
					Yacht <>4__this = this;
					if (Yacht.<>o__348.<>p__0 == null)
					{
						Yacht.<>o__348.<>p__0 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Yacht)));
					}
					<>4__this.ShowDistWhenClose = Yacht.<>o__348.<>p__0.Target(Yacht.<>o__348.<>p__0, TF[Sd.Index]);
					this.Config.SetValue<bool>("Yacht", "ShowDistWhenClose", this.ShowDistWhenClose);
					this.Config.Save();
					string str = "Show Dist When close set to : ";
					object obj = Sd.IndexToItem(Sd.Index);
					UI.Notify(str + ((obj != null) ? obj.ToString() : null));
				}
				bool flag2 = item == TM;
				if (flag2)
				{
					Yacht <>4__this2 = this;
					if (Yacht.<>o__348.<>p__1 == null)
					{
						Yacht.<>o__348.<>p__1 = CallSite<Func<CallSite, object, bool>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(bool), typeof(Yacht)));
					}
					<>4__this2.ShowTestBlips = Yacht.<>o__348.<>p__1.Target(Yacht.<>o__348.<>p__1, TF[TM.Index]);
					this.Config.SetValue<bool>("Yacht", "ShowTestBlips", this.ShowTestBlips);
					this.Config.Save();
					string str2 = "Test Markers : ";
					object obj2 = TM.IndexToItem(TM.Index);
					UI.Notify(str2 + ((obj2 != null) ? obj2.ToString() : null));
				}
				bool flag3 = item == Int;
				if (flag3)
				{
					try
					{
						Yacht <>4__this3 = this;
						if (Yacht.<>o__348.<>p__2 == null)
						{
							Yacht.<>o__348.<>p__2 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(int), typeof(Yacht)));
						}
						<>4__this3.SpawnDist = Yacht.<>o__348.<>p__2.Target(Yacht.<>o__348.<>p__2, Dist[Int.Index]);
						this.Config.SetValue<int>("Yacht", "SpawnDist", this.SpawnDist);
						this.Config.Save();
						if (Yacht.<>o__348.<>p__5 == null)
						{
							Yacht.<>o__348.<>p__5 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Notify", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Type, object> target = Yacht.<>o__348.<>p__5.Target;
						CallSite <>p__ = Yacht.<>o__348.<>p__5;
						Type typeFromHandle = typeof(UI);
						if (Yacht.<>o__348.<>p__4 == null)
						{
							Yacht.<>o__348.<>p__4 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, object, string, object> target2 = Yacht.<>o__348.<>p__4.Target;
						CallSite <>p__2 = Yacht.<>o__348.<>p__4;
						if (Yacht.<>o__348.<>p__3 == null)
						{
							Yacht.<>o__348.<>p__3 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(<>p__, typeFromHandle, target2(<>p__2, Yacht.<>o__348.<>p__3.Target(Yacht.<>o__348.<>p__3, "The Yacht will now load when the player is : ~b~", Dist[Int.Index]), "m~w~ away"));
					}
					catch (Exception ex)
					{
						this.SpawnDist = 100000;
						this.Config.SetValue<int>("Yacht", "SpawnDist", this.SpawnDist);
						this.Config.Save();
						UI.Notify("The Yacht will now load when on game load/mods reload");
					}
				}
			};
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000128A0 File Offset: 0x00010AA0
		public void Setup()
		{
			this.FlagList.Add("apa_prop_flag_wales");
			this.FlagList.Add("apa_prop_flag_us_yt");
			this.FlagList.Add("apa_prop_flag_uk_yt");
			this.FlagList.Add("apa_prop_flag_turkey");
			this.FlagList.Add("apa_prop_flag_switzerland");
			this.FlagList.Add("apa_prop_flag_sweden");
			this.FlagList.Add("apa_prop_flag_spain");
			this.FlagList.Add("apa_prop_flag_southkorea");
			this.FlagList.Add("apa_prop_flag_southafrica");
			this.FlagList.Add("apa_prop_flag_slovenia");
			this.FlagList.Add("apa_prop_flag_slovakia");
			this.FlagList.Add("apa_prop_flag_script");
			this.FlagList.Add("apa_prop_flag_scotland_yt");
			this.FlagList.Add("apa_prop_flag_russia_yt");
			this.FlagList.Add("apa_prop_flag_puertorico");
			this.FlagList.Add("apa_prop_flag_portugal");
			this.FlagList.Add("apa_prop_flag_poland");
			this.FlagList.Add("apa_prop_flag_palestine");
			this.FlagList.Add("apa_prop_flag_norway");
			this.FlagList.Add("apa_prop_flag_nigeria");
			this.FlagList.Add("apa_prop_flag_newzealand");
			this.FlagList.Add("apa_prop_flag_netherlands");
			this.FlagList.Add("apa_prop_flag_mexico_yt");
			this.FlagList.Add("apa_prop_flag_malta");
			this.FlagList.Add("apa_prop_flag_lstein");
			this.FlagList.Add("apa_prop_flag_japan_yt");
			this.FlagList.Add("apa_prop_flag_jamaica");
			this.FlagList.Add("apa_prop_flag_italy");
			this.FlagList.Add("apa_prop_flag_israel");
			this.FlagList.Add("apa_prop_flag_ireland");
			this.FlagList.Add("apa_prop_flag_hungary");
			this.FlagList.Add("apa_prop_flag_german_yt");
			this.FlagList.Add("apa_prop_flag_france");
			this.FlagList.Add("apa_prop_flag_finland");
			this.FlagList.Add("apa_prop_flag_eu_yt");
			this.FlagList.Add("apa_prop_flag_england");
			this.FlagList.Add("apa_prop_flag_denmark");
			this.FlagList.Add("apa_prop_flag_czechrep");
			this.FlagList.Add("apa_prop_flag_croatia");
			this.FlagList.Add("apa_prop_flag_colombia");
			this.FlagList.Add("apa_prop_flag_china");
			this.FlagList.Add("apa_prop_flag_canada_yt");
			this.FlagList.Add("apa_prop_flag_brazil");
			this.FlagList.Add("apa_prop_flag_belgium");
			this.FlagList.Add("apa_prop_flag_austria");
			this.FlagList.Add("apa_prop_flag_australia");
			this.FlagList.Add("apa_prop_flag_argentina");
			this.YachtLocSring.Add("");
			this.YachtLocSring.Add(" Zancudo River 1 ");
			this.YachtLocSring.Add("Zancudo River 2 ");
			this.YachtLocSring.Add("Zancudo River 3 ");
			this.YachtLocSring.Add("Zancudo Base 1 ");
			this.YachtLocSring.Add("Zancudo Base 2 ");
			this.YachtLocSring.Add("Zancudo Base 3 ");
			this.YachtLocSring.Add("North Chumash 1 ");
			this.YachtLocSring.Add("North Chumash 2 ");
			this.YachtLocSring.Add("North Chumash 3 ");
			this.YachtLocSring.Add("Vespucci Beach 1 ");
			this.YachtLocSring.Add("Vespucci Beach 2 ");
			this.YachtLocSring.Add("Vespucci Beach 3 ");
			this.YachtLocSring.Add("LSIA 1 ");
			this.YachtLocSring.Add("LSIA 2 ");
			this.YachtLocSring.Add("LSIA 3 ");
			this.YachtLocSring.Add("Docks 1 ");
			this.YachtLocSring.Add("Docks 2 ");
			this.YachtLocSring.Add("Docks 3 ");
			this.YachtLocSring.Add("Palomino Highlands 1 ");
			this.YachtLocSring.Add("Palomino Highlands 2 ");
			this.YachtLocSring.Add("Palomino Highlands 3 ");
			this.YachtLocSring.Add("Tavarium Mountains 1 ");
			this.YachtLocSring.Add("Tavarium Mountains 2 ");
			this.YachtLocSring.Add("Tavarium Mountains 3 ");
			this.YachtLocSring.Add("San Chianski Mountain Range 1 ");
			this.YachtLocSring.Add("San Chianski Mountain Range 2 ");
			this.YachtLocSring.Add("San Chianski Mountain Range 3 ");
			this.YachtLocSring.Add("Mount Gordo 1 ");
			this.YachtLocSring.Add("Mount Gordo 2 ");
			this.YachtLocSring.Add("Mount Gordo 3 ");
			this.YachtLocSring.Add("Propocio Beach 1 ");
			this.YachtLocSring.Add("Propocio Beach 2 ");
			this.YachtLocSring.Add("Propocio Beach 3 ");
			this.YachtLocSring.Add("Paleto Bay 1 ");
			this.YachtLocSring.Add("Paleto Bay 2 ");
			this.YachtLocSring.Add("Paleto Bay 3 ");
			this.YachtLocSring.Add("Summer Update Yacht");
			this.YachtPos.Add(new Vector3(0f, 0f, 0f));
			this.YachtPos.Add(this.PlayerYachtPos1);
			this.YachtPos.Add(this.PlayerYachtPos2);
			this.YachtPos.Add(this.PlayerYachtPos3);
			this.YachtPos.Add(this.PlayerYachtPos4);
			this.YachtPos.Add(this.PlayerYachtPos5);
			this.YachtPos.Add(this.PlayerYachtPos6);
			this.YachtPos.Add(this.PlayerYachtPos7);
			this.YachtPos.Add(this.PlayerYachtPos8);
			this.YachtPos.Add(this.PlayerYachtPos9);
			this.YachtPos.Add(this.PlayerYachtPos10);
			this.YachtPos.Add(this.PlayerYachtPos11);
			this.YachtPos.Add(this.PlayerYachtPos12);
			this.YachtPos.Add(this.PlayerYachtPos13);
			this.YachtPos.Add(this.PlayerYachtPos14);
			this.YachtPos.Add(this.PlayerYachtPos15);
			this.YachtPos.Add(this.PlayerYachtPos16);
			this.YachtPos.Add(this.PlayerYachtPos17);
			this.YachtPos.Add(this.PlayerYachtPos18);
			this.YachtPos.Add(this.PlayerYachtPos19);
			this.YachtPos.Add(this.PlayerYachtPos20);
			this.YachtPos.Add(this.PlayerYachtPos21);
			this.YachtPos.Add(this.PlayerYachtPos22);
			this.YachtPos.Add(this.PlayerYachtPos23);
			this.YachtPos.Add(this.PlayerYachtPos24);
			this.YachtPos.Add(this.PlayerYachtPos25);
			this.YachtPos.Add(this.PlayerYachtPos26);
			this.YachtPos.Add(this.PlayerYachtPos27);
			this.YachtPos.Add(this.PlayerYachtPos28);
			this.YachtPos.Add(this.PlayerYachtPos29);
			this.YachtPos.Add(this.PlayerYachtPos30);
			this.YachtPos.Add(this.PlayerYachtPos31);
			this.YachtPos.Add(this.PlayerYachtPos32);
			this.YachtPos.Add(this.PlayerYachtPos33);
			this.YachtPos.Add(this.PlayerYachtPos34);
			this.YachtPos.Add(this.PlayerYachtPos35);
			this.YachtPos.Add(this.PlayerYachtPos36);
			this.YachtPos.Add(new Vector3(3615.523f, -4779.021f, 5.433739f));
			this.YachtHashs.Add("");
			this.YachtHashs2.Add("");
			this.YachtHashs.Add("apa_yacht_grp01_1");
			this.YachtHashs2.Add("apa_yacht_grp01_1_int");
			this.YachtHashs.Add("apa_yacht_grp01_2");
			this.YachtHashs2.Add("apa_yacht_grp01_2_int");
			this.YachtHashs.Add("apa_yacht_grp01_3");
			this.YachtHashs2.Add("apa_yacht_grp01_3_int");
			this.YachtHashs.Add("apa_yacht_grp02_1");
			this.YachtHashs2.Add("apa_yacht_grp02_1_int");
			this.YachtHashs.Add("apa_yacht_grp02_2");
			this.YachtHashs2.Add("apa_yacht_grp02_2_int");
			this.YachtHashs.Add("apa_yacht_grp02_3");
			this.YachtHashs2.Add("apa_yacht_grp02_3_int");
			this.YachtHashs.Add("apa_yacht_grp03_1");
			this.YachtHashs2.Add("apa_yacht_grp03_1_int");
			this.YachtHashs.Add("apa_yacht_grp03_2");
			this.YachtHashs2.Add("apa_yacht_grp03_2_int");
			this.YachtHashs.Add("apa_yacht_grp03_3");
			this.YachtHashs2.Add("apa_yacht_grp03_3_int");
			this.YachtHashs.Add("apa_yacht_grp04_1");
			this.YachtHashs2.Add("apa_yacht_grp04_1_int");
			this.YachtHashs.Add("apa_yacht_grp04_2");
			this.YachtHashs2.Add("apa_yacht_grp04_2_int");
			this.YachtHashs.Add("apa_yacht_grp04_3");
			this.YachtHashs2.Add("apa_yacht_grp04_3_int");
			this.YachtHashs.Add("apa_yacht_grp05_1");
			this.YachtHashs2.Add("apa_yacht_grp05_1_int");
			this.YachtHashs.Add("apa_yacht_grp05_2");
			this.YachtHashs2.Add("apa_yacht_grp05_2_int");
			this.YachtHashs.Add("apa_yacht_grp05_3");
			this.YachtHashs2.Add("apa_yacht_grp05_3_int");
			this.YachtHashs.Add("apa_yacht_grp06_1");
			this.YachtHashs2.Add("apa_yacht_grp06_1_int");
			this.YachtHashs.Add("apa_yacht_grp06_2");
			this.YachtHashs2.Add("apa_yacht_grp06_2_int");
			this.YachtHashs.Add("apa_yacht_grp06_3");
			this.YachtHashs2.Add("apa_yacht_grp06_3_int");
			this.YachtHashs.Add("apa_yacht_grp07_1");
			this.YachtHashs2.Add("apa_yacht_grp07_1_int");
			this.YachtHashs.Add("apa_yacht_grp07_2");
			this.YachtHashs2.Add("apa_yacht_grp07_2_int");
			this.YachtHashs.Add("apa_yacht_grp07_3");
			this.YachtHashs2.Add("apa_yacht_grp07_3_int");
			this.YachtHashs.Add("apa_yacht_grp08_1");
			this.YachtHashs2.Add("apa_yacht_grp08_1_int");
			this.YachtHashs.Add("apa_yacht_grp08_2");
			this.YachtHashs2.Add("apa_yacht_grp08_2_int");
			this.YachtHashs.Add("apa_yacht_grp08_3");
			this.YachtHashs2.Add("apa_yacht_grp08_3_int");
			this.YachtHashs.Add("apa_yacht_grp09_1");
			this.YachtHashs2.Add("apa_yacht_grp09_1_int");
			this.YachtHashs.Add("apa_yacht_grp09_2");
			this.YachtHashs2.Add("apa_yacht_grp09_2_int");
			this.YachtHashs.Add("apa_yacht_grp09_3");
			this.YachtHashs2.Add("apa_yacht_grp09_3_int");
			this.YachtHashs.Add("apa_yacht_grp10_1");
			this.YachtHashs2.Add("apa_yacht_grp10_1_int");
			this.YachtHashs.Add("apa_yacht_grp10_2");
			this.YachtHashs2.Add("apa_yacht_grp10_2_int");
			this.YachtHashs.Add("apa_yacht_grp10_3");
			this.YachtHashs2.Add("apa_yacht_grp10_3_int");
			this.YachtHashs.Add("apa_yacht_grp11_1");
			this.YachtHashs2.Add("apa_yacht_grp11_1_int");
			this.YachtHashs.Add("apa_yacht_grp11_2");
			this.YachtHashs2.Add("apa_yacht_grp11_2_int");
			this.YachtHashs.Add("apa_yacht_grp11_3");
			this.YachtHashs2.Add("apa_yacht_grp11_3_int");
			this.YachtHashs.Add("apa_yacht_grp12_1");
			this.YachtHashs2.Add("apa_yacht_grp12_1_int");
			this.YachtHashs.Add("apa_yacht_grp12_2");
			this.YachtHashs2.Add("apa_yacht_grp12_2_int");
			this.YachtHashs.Add("apa_yacht_grp12_3");
			this.YachtHashs2.Add("apa_yacht_grp12_3_int");
			this.YachtHashs.Add("sum_lost_yacht");
			this.YachtHashs2.Add("sum_lost_yacht_int");
			this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
			this.Created = false;
			bool flag = this.Purchased == 1;
			if (flag)
			{
				Blip blip = World.CreateBlip(new Vector3(this.YachtPos[this.Location].X, this.YachtPos[this.Location].Y, this.YachtPos[this.Location].Z));
				blip.Sprite = 455;
				blip.Name = "Yacht : " + this.Location.ToString() + ", " + this.YachtLocSring[this.Location];
				blip.Color = 2;
				this.Blips.Add(blip);
			}
			this.ChangePosPool = new MenuPool();
			this.ChangePosMainMenu = new UIMenu("Yacht", "Select an Option");
			this.ChangePosPool.Add(this.ChangePosMainMenu);
			this.ChangePosMenu = this.ChangePosPool.AddSubMenu(this.ChangePosMainMenu, "Yacht Options");
			this.Woredrobepool = new MenuPool();
			this.WoredrobeMainMenu = new UIMenu("Wardrobe", "Select an Option");
			this.Woredrobepool.Add(this.WoredrobeMainMenu);
			this.WoredrobeMenu = this.Woredrobepool.AddSubMenu(this.WoredrobeMainMenu, "Change Clothes");
			this.WareDrobe();
			this.IsSittinginCeoSeat = false;
			this.MarkerEnter = new Vector3(-1539.5f, -610.789f, 30f);
			this.MarkerExit = new Vector3(-1573.788f, -571.0647f, 107.5f);
			this.MenuMarker = new Vector3(-1574.97f, -584.364f, 107f);
			this.RoofEnterMarker = new Vector3(-1565f, -575f, 107f);
			this.RoofExitMarker = new Vector3(-1563.06f, -569f, 114f);
			this.HeliSpawn = new Vector3(-1581.08f, -570.092f, 116f);
			this.CarSpawn = new Vector3(-1541.52f, -570.96f, 25f);
			this.GarageMarker = new Vector3(-1541.52f, -570.96f, 25f);
			this.VehicleSpawn = new Vector3(-36f, -939.158f, 29.5f);
			this.WherehouseMarker = new Vector3(254.6f, -3057f, 5.7f);
			this.AircraftStorageLoc = new Vector3(1679f, 3238f, 40f);
			this.Dockloc = new Vector3(3865f, 4463.66f, 2f);
			this.LotLoc = new Vector3(863f, 2173f, 51f);
			this.Radiopos = new Vector3(-79.33f, -804.844f, 243f);
			this.SleepPos = new Vector3(-1560f, -568f, 108f);
			this.MBTOfficeSitRespawnPos = new Vector3(-1564.72f, -583.497f, 107f);
			this.MBTOfficeSitPos = new Vector3(-1564.72f, -583.497f, 107f);
			this.modMenuPool = new MenuPool();
			this.mainMenu = new UIMenu("GSY", "Select an Option");
			this.modMenuPool.Add(this.mainMenu);
			this.methgarage = this.modMenuPool.AddSubMenu(this.mainMenu, "Purchase Options");
			this.ProductStock = this.modMenuPool.AddSubMenu(this.mainMenu, "Product Options");
			this.SpecialMissions = this.modMenuPool.AddSubMenu(this.mainMenu, "Special Missions (Missions)");
			this.YachtMenu();
			this.Setupbuisness();
			this.SetupProduct();
			this.SetupSpecialMissions();
			this.DrinksPool = new MenuPool();
			this.DrinksMainMenu = new UIMenu("Galaxy Super Yacht", "Select an Option");
			this.DrinksPool.Add(this.DrinksMainMenu);
			this.DrinksMenu = this.DrinksPool.AddSubMenu(this.mainMenu, "Purchase Options");
			this.Drinks();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00013A48 File Offset: 0x00011C48
		public void ShowIncrease()
		{
			UI.Notify("Level: " + this.purchaselvl.ToString());
			UI.Notify("Max Stocks: " + this.maxstocks.ToString());
			UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
			UI.Notify("Mission Gain: " + this.profitMargin.ToString() + "%");
			UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00013AEC File Offset: 0x00011CEC
		public VehicleHash RandomVehicleFun()
		{
			Random random = new Random();
			int num = random.Next(1, 13);
			bool flag = num == 1;
			if (flag)
			{
				this.RandomVehicle = -808831384;
			}
			bool flag2 = num == 2;
			if (flag2)
			{
				this.RandomVehicle = 80636076;
			}
			bool flag3 = num == 3;
			if (flag3)
			{
				this.RandomVehicle = 723973206;
			}
			bool flag4 = num == 4;
			if (flag4)
			{
				this.RandomVehicle = -1045541610;
			}
			bool flag5 = num == 5;
			if (flag5)
			{
				this.RandomVehicle = -1685021548;
			}
			bool flag6 = num == 6;
			if (flag6)
			{
				this.RandomVehicle = -1255452397;
			}
			bool flag7 = num == 7;
			if (flag7)
			{
				this.RandomVehicle = 1923400478;
			}
			bool flag8 = num == 8;
			if (flag8)
			{
				this.RandomVehicle = 1951180813;
			}
			bool flag9 = num == 9;
			if (flag9)
			{
				this.RandomVehicle = -1622444098;
			}
			bool flag10 = num == 10;
			if (flag10)
			{
				this.RandomVehicle = 1203490606;
			}
			bool flag11 = num == 11;
			if (flag11)
			{
				this.RandomVehicle = -140902153;
			}
			bool flag12 = num == 12;
			if (flag12)
			{
				this.RandomVehicle = 970598228;
			}
			bool flag13 = num == 13;
			if (flag13)
			{
				this.RandomVehicle = 788045382;
			}
			bool flag14 = num > 13;
			if (flag14)
			{
				this.RandomVehicle = 349605904;
			}
			return this.RandomVehicle;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00013C5C File Offset: 0x00011E5C
		public Vector3 Randomlocation()
		{
			Random random = new Random();
			int num = random.Next(1, 13);
			bool flag = num == 1;
			if (flag)
			{
				this.VehicleSpawn = new Vector3(-1069.32f, -72.28f, 19f);
			}
			bool flag2 = num == 2;
			if (flag2)
			{
				this.VehicleSpawn = new Vector3(-1579.93f, -155.28f, 55f);
			}
			bool flag3 = num == 3;
			if (flag3)
			{
				this.VehicleSpawn = new Vector3(-711.74f, -28.28f, 37f);
			}
			bool flag4 = num == 4;
			if (flag4)
			{
				this.VehicleSpawn = new Vector3(6f, 253.58f, 109f);
			}
			bool flag5 = num == 5;
			if (flag5)
			{
				this.VehicleSpawn = new Vector3(703f, 32f, 84f);
			}
			bool flag6 = num == 6;
			if (flag6)
			{
				this.VehicleSpawn = new Vector3(1197f, -421.5f, 68f);
			}
			bool flag7 = num == 7;
			if (flag7)
			{
				this.VehicleSpawn = new Vector3(1257f, -1428f, 35f);
			}
			bool flag8 = num == 8;
			if (flag8)
			{
				this.VehicleSpawn = new Vector3(1264f, -2039f, 45f);
			}
			bool flag9 = num == 9;
			if (flag9)
			{
				this.VehicleSpawn = new Vector3(527f, -2052f, 28f);
			}
			bool flag10 = num == 10;
			if (flag10)
			{
				this.VehicleSpawn = new Vector3(-161f, -2087.8f, 26f);
			}
			bool flag11 = random.Next(1, 13) == 11;
			if (flag11)
			{
				this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
			}
			bool flag12 = num == 12;
			if (flag12)
			{
				this.VehicleSpawn = new Vector3(-816f, -2300f, 11f);
			}
			bool flag13 = num == 13;
			if (flag13)
			{
				this.VehicleSpawn = new Vector3(-1839f, 136f, 78f);
			}
			bool flag14 = num > 13;
			if (flag14)
			{
				this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
			}
			return this.VehicleSpawn;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00013EA4 File Offset: 0x000120A4
		public VehicleColor GetColor()
		{
			List<object> list = new List<object>();
			VehicleColor[] array = (VehicleColor[])Enum.GetValues(typeof(VehicleColor));
			for (int i = 0; i < array.Length; i++)
			{
				list.Add(array[i]);
			}
			Random random = new Random();
			int index = random.Next(1, array.Length);
			if (Yacht.<>o__353.<>p__0 == null)
			{
				Yacht.<>o__353.<>p__0 = CallSite<Func<CallSite, object, VehicleColor>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(VehicleColor), typeof(Yacht)));
			}
			return Yacht.<>o__353.<>p__0.Target(Yacht.<>o__353.<>p__0, list[index]);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00013F58 File Offset: 0x00012158
		public void SetupSpecialMissions()
		{
			UIMenu uimenu = this.modMenuPool.AddSubMenu(this.SpecialMissions, "Special Missions");
			UIMenuItem Race1 = new UIMenuItem("ExPatriot");
			uimenu.AddItem(Race1);
			UIMenuItem Race2 = new UIMenuItem("Electrical Discharge");
			uimenu.AddItem(Race2);
			UIMenuItem Race3 = new UIMenuItem("Piracy Scam ");
			uimenu.AddItem(Race3);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Race3;
				if (flag)
				{
					bool flag2 = this.VtoGet != null;
					if (flag2)
					{
						this.VtoGet.Delete();
					}
					bool flag3 = this.VtoGetBlip != null;
					if (flag3)
					{
						this.VtoGetBlip.Remove();
					}
					Vector3 vector = this.Randomlocation();
					VehicleHash vehicleHash = this.RandomVehicleFun();
					this.VtoGet = World.CreateVehicle(vehicleHash, vector, 45f);
					UI.Notify("Office Assistant : Boss weve got some Joker trying to hack into out server to steal stock, find them! and destroy there vehicle");
					UI.Notify("test1");
					this.VtoGetBlip = World.CreateBlip(vector);
					UI.Notify("test2");
					this.VtoGetBlip.Name = "Find Vehicle";
					this.VtoGetBlip.Sprite = 459;
					this.VtoGetBlip.Color = 3;
					this.VtoGetBlip.Name = "Find Vehicle";
					UI.Notify("test3");
					this.stocktoloose = 0f;
					this.ISinPiracyScamMission = true;
					this.Piracymission = 1;
					this.HackhasStarted = false;
					this.GoPoint = this.VtoGet.Position;
					this.TimerLeft = 4000;
					this.VehicleSetup = true;
				}
				bool flag4 = item == Race1;
				if (flag4)
				{
					UI.Notify("Office Assistant : Retrieve the Patriot Stretch and bring it to the Combined Vehicle Storage");
					bool flag5 = this.VtoGet != null;
					if (flag5)
					{
						this.VtoGet.Delete();
					}
					bool flag6 = this.VtoGetBlip != null;
					if (flag6)
					{
						this.VtoGetBlip.Remove();
					}
					foreach (Ped ped in this.Guards)
					{
						bool flag7 = ped != null;
						if (flag7)
						{
							ped.Delete();
						}
					}
					foreach (Ped ped2 in this.Driver)
					{
						bool flag8 = this.Driver != null;
						if (flag8)
						{
							ped2.Delete();
						}
					}
					this.VtoGet = World.CreateVehicle("PATRIOT2", new Vector3(-1490f, 147f, 54f), 45f);
					this.VtoGetBlip = World.CreateBlip(this.VtoGet.Position);
					this.VtoGet.IsPersistent = true;
					this.VtoGetBlip.Name = "Retrieve Patriot Stretch";
					this.VtoGetBlip.Sprite = 523;
					this.VtoGetBlip.Color = 0;
					this.VtoGetBlip.Name = "Retrieve Patriot Stretch";
					this.VehicleSetup = true;
					this.Missionnum = 12;
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1467f, 157f, 54f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1491f, 165f, 54f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1483f, 158f, 54f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1467f, 145f, 45f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1500f, 144f, 55f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1480f, 138f, 55f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1477f, 165f, 55f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(-1466f, 164f, 55f)));
					foreach (Ped ped3 in this.Guards)
					{
						ped3.Weapons.Give(-1768145561, 9999, true, true);
						ped3.RelationshipGroup = 4;
						ped3.IsEnemy = true;
					}
					this.Driver.Add(World.CreatePed("CSB_TonyPrince", new Vector3(-1186.21f, 282f, 69f)));
					this.GotCar = false;
					Function.Call(2245783831530643834L, new InputArgument[]
					{
						this.VtoGet.Handle,
						0
					});
					this.VtoGet.PrimaryColor = 131;
					this.VtoGet.SecondaryColor = 111;
					this.VtoGet.SetMod(48, 17, true);
					this.VtoGet.SetMod(41, 8, true);
					this.VtoGet.SetMod(7, 2, true);
					this.VtoGet.NumberPlate = "PR2NCE";
					this.VtoGet.SetMod(42, 4, true);
					this.VtoGet.WindowTint = 1;
				}
				bool flag9 = item == Race2;
				if (flag9)
				{
					UI.Notify("Office Assistant : Retrieve Each Electric Car from the 10 car garage, and bring it back to Combined Vehicle Storage");
					bool flag10 = this.VtoGet != null;
					if (flag10)
					{
						this.VtoGet.Delete();
					}
					bool flag11 = this.VtoGetBlip != null;
					if (flag11)
					{
						this.VtoGetBlip.Remove();
					}
					foreach (Ped ped4 in this.Guards)
					{
						bool flag12 = ped4 != null;
						if (flag12)
						{
							ped4.Delete();
						}
					}
					foreach (Ped ped5 in this.Driver)
					{
						bool flag13 = this.Driver != null;
						if (flag13)
						{
							ped5.Delete();
						}
					}
					this.VtoGet = World.CreateVehicle(1031562256, new Vector3(222f, -999f, -99f), -50f);
					this.VtoGet1 = World.CreateVehicle(-1848994066, new Vector3(223f, -993f, -99f), -50f);
					this.VtoGet2 = World.CreateVehicle(-1529242755, new Vector3(223f, -986f, -99f), -50f);
					this.VtoGet3 = World.CreateVehicle(1392481335, new Vector3(223f, -981f, -99f), -50f);
					this.VtoGetBlip = World.CreateBlip(new Vector3(213f, -936f, 24f));
					this.VtoGet.IsPersistent = true;
					this.VtoGetBlip.Name = "Retrieve Eletric cars from Impound";
					this.VtoGetBlip.Sprite = 523;
					this.VtoGetBlip.Color = 0;
					this.VtoGetBlip.Name = "Retrieve Eletric cars from Impound";
					this.VehicleSetup = true;
					this.Missionnum = 13;
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(233f, -942f, 29f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(255f, -886f, 29f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(214f, -1003f, 29f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(212f, -946f, 24f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(210f, -944f, 24f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(218f, -939f, 24f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(224f, -930f, 24f)));
					this.Guards.Add(World.CreatePed(-1613485779, new Vector3(221f, -927f, 24f)));
					foreach (Ped ped6 in this.Guards)
					{
						ped6.Weapons.Give(-86904375, 9999, true, true);
						ped6.RelationshipGroup = 4;
						ped6.IsEnemy = true;
					}
					this.GotCar = false;
					this.VtoGet.PrimaryColor = 0;
					this.VtoGet.SecondaryColor = 38;
					this.VtoGet1.PrimaryColor = 89;
					this.VtoGet1.SecondaryColor = 89;
					this.VtoGet2.PrimaryColor = 64;
					this.VtoGet2.SecondaryColor = 64;
					this.VtoGet3.PrimaryColor = 34;
					this.VtoGet3.SecondaryColor = 1;
					this.Vehiclesleft = 4;
				}
			};
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00013FF4 File Offset: 0x000121F4
		public void OpenMenu()
		{
			Script.Wait(25);
			UI.Notify("Menu");
			this.MenuOn = true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00014014 File Offset: 0x00012214
		public void ChooseVehicle(int i)
		{
			bool flag = i == 1;
			if (flag)
			{
				this.carid = "Mogul";
				this.VehicleMissioncar = World.CreateVehicle(new Model(-749299473), this.VehicleLocation);
				this.VehicleMissioncar.PlaceOnGround();
			}
			bool flag2 = i == 2;
			if (flag2)
			{
				this.carid = "Cuban 800";
				this.VehicleMissioncar = World.CreateVehicle(-644710429, this.VehicleLocation);
				this.VehicleMissioncar.PlaceOnGround();
			}
			bool flag3 = i == 3;
			if (flag3)
			{
				this.carid = "Duster";
				this.VehicleMissioncar = World.CreateVehicle(970356638, this.VehicleLocation);
				this.VehicleMissioncar.PlaceOnGround();
			}
			bool flag4 = i == 4;
			if (flag4)
			{
				this.carid = "Mammatus";
				this.VehicleMissioncar = World.CreateVehicle(-1746576111, this.VehicleLocation);
				this.VehicleMissioncar.PlaceOnGround();
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00014114 File Offset: 0x00012314
		public void SetupProduct()
		{
			List<object> list = new List<object>();
			list.Add("Maze Bank");
			list.Add("Arcadius");
			list.Add("Maze Bank West");
			list.Add("Lombok");
			UIMenu uimenu = this.modMenuPool.AddSubMenu(this.ProductStock, "Buy/Sell Product");
			UIMenuListItem B = new UIMenuListItem("Business : ", list, 0);
			uimenu.AddItem(B);
			UIMenuItem Buy2 = new UIMenuItem("Buy X10: -$" + 500000.ToString());
			uimenu.AddItem(Buy2);
			UIMenuItem Buy = new UIMenuItem("Buy X1: -$" + 100000.ToString());
			uimenu.AddItem(Buy);
			UIMenuItem Sell = new UIMenuItem("Sell - All Stocks (Low)");
			uimenu.AddItem(Sell);
			UIMenuItem Sell2 = new UIMenuItem("Sell - All Stocks (High)");
			uimenu.AddItem(Sell2);
			UIMenuItem Show = new UIMenuItem("Show Product Value/Count");
			uimenu.AddItem(Show);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Show;
				if (flag)
				{
					this.LoadIniFile("scripts//ExecutiveBusiness//LombokTower.ini");
					UI.Notify("Office Assistant: Here is where we are at");
					UI.Notify("Level: " + this.purchaselvl.ToString() + "/20");
					this.ShowIncrease();
				}
				bool flag2 = item == Buy2;
				if (flag2)
				{
					bool flag3 = this.stockscount + 10 <= this.maxstocks;
					if (flag3)
					{
						bool flag4 = Game.Player.Money > 500000;
						if (flag4)
						{
							Game.Player.Money = Game.Player.Money - 500000;
							this.stocksvalue += 250000f;
							this.stockscount += 10;
							this.Config.SetValue<int>("Setup", "stockslevel", this.stockscount);
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
							UI.Notify("Office Assistant: ok i can deal with that, one new container of product");
							UI.Notify("Stocks Avalable: " + this.stockscount.ToString());
						}
					}
					else
					{
						UI.Notify("Office Assistant: Sorry Boss, were full, we canot store any more stocks, please sell stocks or upgrade ");
					}
				}
				bool flag5 = item == Buy;
				if (flag5)
				{
					bool flag6 = this.stockscount != this.maxstocks;
					if (flag6)
					{
						bool flag7 = Game.Player.Money > 100000;
						if (flag7)
						{
							Game.Player.Money = Game.Player.Money - 100000;
							this.stocksvalue += 25000f;
							this.stockscount++;
							this.Config.SetValue<int>("Setup", "stockslevel", this.stockscount);
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
							UI.Notify("Office Assistant: ok i can deal with that, one new container of product");
							UI.Notify("Stocks Avalable: " + this.stockscount.ToString());
						}
					}
					else
					{
						UI.Notify("Office Assistant: Sorry Boss, were full, we canot store any more stocks, please sell stocks or upgrade ");
					}
				}
				bool flag8 = item == Sell;
				if (flag8)
				{
					UI.Notify("Office Assistant: ok i can deal with that, selling all product avalable");
					Game.Player.Money = Game.Player.Money + (int)this.stocksvalue;
					this.stocksvalue = 0f;
					this.stockscount = 0;
					this.Config.SetValue<int>("Setup", "stockslevel", this.stockscount);
					this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
					this.Config.Save();
				}
				bool flag9 = item == Sell2;
				if (flag9)
				{
					bool flag10 = this.VtoGet != null;
					if (flag10)
					{
						this.VtoGet.Delete();
					}
					bool flag11 = this.VtoGetBlip != null;
					if (flag11)
					{
						this.VtoGetBlip.Remove();
					}
					UI.Notify("Office Assistant: ok get the mule from the Combined Vehicle Storage and deliver it to the drop zone");
					this.Missionnum = 14;
					this.VtoGet = World.CreateVehicle(904750859, this.LotLoc);
					this.VtoGet.Rotation = new Vector3(0f, 0f, 44f);
					this.VtoGetBlip = World.CreateBlip(this.VtoGet.Position);
					this.VtoGetBlip.Name = "Take Mule to drop point";
					this.VtoGetBlip.Sprite = 479;
					this.VtoGetBlip.Color = 0;
					this.VtoGetBlip.Name = "Take Mule to drop point";
					this.VehicleisDamaged = false;
					this.Vehiclehealth = this.VtoGet.Health;
					this.VehicleSetup = true;
					this.GotCar = false;
				}
			};
			uimenu.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == B;
				if (flag)
				{
					bool flag2 = B.Index == 0;
					if (flag2)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//MazeBank.ini");
						UI.Notify("~w~Selected ~b~ Maze Bank~w~");
					}
					bool flag3 = B.Index == 1;
					if (flag3)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//ArcadiusTower.ini");
						UI.Notify("~w~Selected ~y~ Arcadius ~w~");
					}
					bool flag4 = B.Index == 2;
					if (flag4)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//DelPerroMazeBank.ini");
						UI.Notify("~w~Selected ~r~ Maze Bank West ~w~");
					}
					bool flag5 = B.Index == 3;
					if (flag5)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//LombokTower.ini");
						UI.Notify("~w~Selected ~g~ Lombok ~w~");
					}
				}
			};
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00014278 File Offset: 0x00012478
		public void Setupbuisness()
		{
			List<object> list = new List<object>();
			list.Add("Maze Bank");
			list.Add("Arcadius");
			list.Add("Maze Bank West");
			list.Add("Lombok");
			List<dynamic> CamP = new List<object>();
			List<dynamic> CamR = new List<object>();
			List<dynamic> Options = new List<object>();
			List<dynamic> Price = new List<object>();
			List<dynamic> Location = new List<object>();
			Options.Add("Option1");
			Price.Add(1580000);
			Location.Add("Elysian Island");
			CamP.Add(new Vector3(296f, -3092f, 8f));
			CamR.Add(43);
			Options.Add("Option2");
			Price.Add(2380000);
			Location.Add("La Mesa");
			CamP.Add(new Vector3(946f, -1506f, 32f));
			CamR.Add(11);
			Options.Add("Option3");
			Price.Add(2675000);
			Location.Add("Cypress Flats");
			CamP.Add(new Vector3(795f, -2243f, 33f));
			CamR.Add(-15);
			Options.Add("Option4");
			Price.Add(1635000);
			Location.Add("El Burro Heights");
			CamP.Add(new Vector3(1778f, -1665f, 116f));
			CamR.Add(39);
			Options.Add("Option5");
			Price.Add(1950000);
			Location.Add("Elysian Island");
			CamP.Add(new Vector3(158f, -2962f, 14f));
			CamR.Add(160);
			Options.Add("Option6");
			Price.Add(1500000);
			Location.Add("La Mesa");
			CamP.Add(new Vector3(999f, -1875f, 37f));
			CamR.Add(-8);
			Options.Add("Option7");
			Price.Add(2730000);
			Location.Add("La Puerta");
			CamP.Add(new Vector3(-648f, -1793f, 27f));
			CamR.Add(-61);
			Options.Add("Option8");
			Price.Add(2170000);
			Location.Add("LSIA");
			CamP.Add(new Vector3(-1171f, -2195f, 20f));
			CamR.Add(-42);
			Options.Add("Option9");
			Price.Add(2300000);
			Location.Add("LSIA");
			CamP.Add(new Vector3(-489f, -2178f, 10f));
			CamR.Add(128);
			Options.Add("Option10");
			Price.Add(2850000);
			Location.Add("Murrieta Heights");
			CamP.Add(new Vector3(1200f, -1273f, 37f));
			CamR.Add(-43);
			Options.Add("Option11");
			Price.Add(4550000);
			Location.Add("Pacific Bluffs");
			CamP.Add(new Vector3(-2059f, -257f, 26.5f));
			CamR.Add(-113);
			Options.Add("Option12");
			Price.Add(4850000);
			Location.Add("Hawick");
			CamP.Add(new Vector3(541.3f, -229f, 56f));
			CamR.Add(-22);
			Options.Add("Option13");
			Price.Add(2350000);
			Location.Add("Strawberry");
			CamP.Add(new Vector3(62f, -1283f, 32f));
			CamR.Add(85);
			Options.Add("Option14");
			Price.Add(1150000);
			Location.Add("La Mesa");
			CamP.Add(new Vector3(511f, -624f, 28f));
			CamR.Add(129);
			UIMenu uimenu = this.modMenuPool.AddSubMenu(this.methgarage, "Change Warehouse Position");
			UIMenuListItem Positions = new UIMenuListItem("Option : ", Options, 0);
			uimenu.AddItem(Positions);
			UIMenuItem Loc = new UIMenuItem("Location : ");
			uimenu.AddItem(Loc);
			UIMenuItem pr1 = new UIMenuItem("Price : $0");
			uimenu.AddItem(pr1);
			UIMenuItem uimenuItem = new UIMenuItem("Current");
			uimenu.AddItem(uimenuItem);
			UIMenuItem Set = new UIMenuItem("Set");
			uimenu.AddItem(Set);
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Set;
				if (flag)
				{
					bool flag2 = this.WarehouseCam != null;
					if (flag2)
					{
						object arg = Price[Positions.Index];
						if (Yacht.<>o__358.<>p__1 == null)
						{
							Yacht.<>o__358.<>p__1 = CallSite<Action<CallSite, Type, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Notify", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Action<CallSite, Type, object> target = Yacht.<>o__358.<>p__1.Target;
						CallSite <>p__ = Yacht.<>o__358.<>p__1;
						Type typeFromHandle = typeof(UI);
						if (Yacht.<>o__358.<>p__0 == null)
						{
							Yacht.<>o__358.<>p__0 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						target(<>p__, typeFromHandle, Yacht.<>o__358.<>p__0.Target(Yacht.<>o__358.<>p__0, "Cash ", arg));
						if (Yacht.<>o__358.<>p__3 == null)
						{
							Yacht.<>o__358.<>p__3 = CallSite<Func<CallSite, object, bool>>.Create(Binder.UnaryOperation(CSharpBinderFlags.None, ExpressionType.IsTrue, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, object, bool> target2 = Yacht.<>o__358.<>p__3.Target;
						CallSite <>p__2 = Yacht.<>o__358.<>p__3;
						if (Yacht.<>o__358.<>p__2 == null)
						{
							Yacht.<>o__358.<>p__2 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.GreaterThanOrEqual, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						bool flag3 = target2(<>p__2, Yacht.<>o__358.<>p__2.Target(Yacht.<>o__358.<>p__2, Game.Player.Money, arg));
						if (flag3)
						{
							this.WCamOn = false;
							Player player = Game.Player;
							Player player2 = player;
							if (Yacht.<>o__358.<>p__5 == null)
							{
								Yacht.<>o__358.<>p__5 = CallSite<Func<CallSite, object, int>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(int), typeof(Yacht)));
							}
							Func<CallSite, object, int> target3 = Yacht.<>o__358.<>p__5.Target;
							CallSite <>p__3 = Yacht.<>o__358.<>p__5;
							if (Yacht.<>o__358.<>p__4 == null)
							{
								Yacht.<>o__358.<>p__4 = CallSite<Func<CallSite, int, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.SubtractAssign, typeof(Yacht), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							player2.Money = target3(<>p__3, Yacht.<>o__358.<>p__4.Target(Yacht.<>o__358.<>p__4, player.Money, arg));
							Game.Player.Character.IsVisible = true;
							Camera warehouseCam = this.WarehouseCam;
							if (Yacht.<>o__358.<>p__6 == null)
							{
								Yacht.<>o__358.<>p__6 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Vector3), typeof(Yacht)));
							}
							warehouseCam.Position = Yacht.<>o__358.<>p__6.Target(Yacht.<>o__358.<>p__6, CamP[Positions.Index]);
							Camera warehouseCam2 = this.WarehouseCam;
							if (Yacht.<>o__358.<>p__7 == null)
							{
								Yacht.<>o__358.<>p__7 = CallSite<Func<CallSite, Type, int, int, object, Vector3>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Yacht), new CSharpArgumentInfo[]
								{
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
									CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
								}));
							}
							warehouseCam2.Rotation = Yacht.<>o__358.<>p__7.Target(Yacht.<>o__358.<>p__7, typeof(Vector3), 0, 0, CamR[Positions.Index]);
							this.WarehouseCam.FarClip = 2000f;
							this.WarehouseCam.IsActive = false;
							this.WarehouseCam.Destroy();
							Function.Call(569060033405794044L, new InputArgument[]
							{
								0,
								0,
								3000,
								1,
								0
							});
							this.modMenuPool.CloseAllMenus();
							Game.Player.Character.FreezePosition = false;
							Game.Player.Character.Position = this.MenuMarker;
							this.modMenuPool.CloseAllMenus();
							this.WarehouseCam.Destroy();
							this.LoadIniFile("scripts//ExecutiveBusiness//Warehouse.ini");
							Yacht <>4__this = this;
							if (Yacht.<>o__358.<>p__8 == null)
							{
								Yacht.<>o__358.<>p__8 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
							}
							<>4__this.WarehousePos = Yacht.<>o__358.<>p__8.Target(Yacht.<>o__358.<>p__8, Options[Positions.Index]);
							this.Config.SetValue<string>("Position", "WarehousePos", this.WarehousePos);
							this.Config.Save();
							UI.Notify("~g~HKH191~w~ : Please reload the mod for the changes to take effect, thank you");
						}
					}
				}
			};
			uimenu.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == Positions;
				if (flag)
				{
					bool flag2 = this.WarehouseCam != null;
					if (flag2)
					{
						this.WCamOn = true;
						Camera warehouseCam = this.WarehouseCam;
						if (Yacht.<>o__358.<>p__9 == null)
						{
							Yacht.<>o__358.<>p__9 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Vector3), typeof(Yacht)));
						}
						warehouseCam.Position = Yacht.<>o__358.<>p__9.Target(Yacht.<>o__358.<>p__9, CamP[Positions.Index]);
						Camera warehouseCam2 = this.WarehouseCam;
						if (Yacht.<>o__358.<>p__10 == null)
						{
							Yacht.<>o__358.<>p__10 = CallSite<Func<CallSite, Type, int, int, object, Vector3>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						warehouseCam2.Rotation = Yacht.<>o__358.<>p__10.Target(Yacht.<>o__358.<>p__10, typeof(Vector3), 0, 0, CamR[Positions.Index]);
						Entity character = Game.Player.Character;
						if (Yacht.<>o__358.<>p__11 == null)
						{
							Yacht.<>o__358.<>p__11 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Vector3), typeof(Yacht)));
						}
						character.Position = Yacht.<>o__358.<>p__11.Target(Yacht.<>o__358.<>p__11, CamP[Positions.Index]);
						Game.Player.Character.FreezePosition = true;
						Game.Player.Character.IsVisible = false;
						this.WarehouseCam.IsActive = true;
						this.WarehouseCam.FarClip = 2000f;
						Function.Call(569060033405794044L, new InputArgument[]
						{
							1,
							0,
							3000,
							1,
							0
						});
						World.RenderingCamera = this.WarehouseCam;
						UIMenuItem pr = pr1;
						if (Yacht.<>o__358.<>p__14 == null)
						{
							Yacht.<>o__358.<>p__14 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
						}
						Func<CallSite, object, string> target = Yacht.<>o__358.<>p__14.Target;
						CallSite <>p__ = Yacht.<>o__358.<>p__14;
						if (Yacht.<>o__358.<>p__13 == null)
						{
							Yacht.<>o__358.<>p__13 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target2 = Yacht.<>o__358.<>p__13.Target;
						CallSite <>p__2 = Yacht.<>o__358.<>p__13;
						string arg = "Price : $";
						if (Yacht.<>o__358.<>p__12 == null)
						{
							Yacht.<>o__358.<>p__12 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						pr.Text = target(<>p__, target2(<>p__2, arg, Yacht.<>o__358.<>p__12.Target(Yacht.<>o__358.<>p__12, Price[Positions.Index], "N")));
						UIMenuItem loc = Loc;
						if (Yacht.<>o__358.<>p__16 == null)
						{
							Yacht.<>o__358.<>p__16 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
						}
						Func<CallSite, object, string> target3 = Yacht.<>o__358.<>p__16.Target;
						CallSite <>p__3 = Yacht.<>o__358.<>p__16;
						if (Yacht.<>o__358.<>p__15 == null)
						{
							Yacht.<>o__358.<>p__15 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						loc.Text = target3(<>p__3, Yacht.<>o__358.<>p__15.Target(Yacht.<>o__358.<>p__15, "Location : ", Location[Positions.Index]));
					}
					bool flag3 = this.WarehouseCam == null;
					if (flag3)
					{
						this.WCamOn = true;
						Yacht <>4__this = this;
						if (Yacht.<>o__358.<>p__19 == null)
						{
							Yacht.<>o__358.<>p__19 = CallSite<Func<CallSite, object, Camera>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Camera), typeof(Yacht)));
						}
						Func<CallSite, object, Camera> target4 = Yacht.<>o__358.<>p__19.Target;
						CallSite <>p__4 = Yacht.<>o__358.<>p__19;
						if (Yacht.<>o__358.<>p__18 == null)
						{
							Yacht.<>o__358.<>p__18 = CallSite<Func<CallSite, Type, object, Vector3, int, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "CreateCamera", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						Func<CallSite, Type, object, Vector3, int, object> target5 = Yacht.<>o__358.<>p__18.Target;
						CallSite <>p__5 = Yacht.<>o__358.<>p__18;
						Type typeFromHandle = typeof(World);
						object arg2 = CamP[Positions.Index];
						if (Yacht.<>o__358.<>p__17 == null)
						{
							Yacht.<>o__358.<>p__17 = CallSite<Func<CallSite, Type, int, int, object, Vector3>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						<>4__this.WarehouseCam = target4(<>p__4, target5(<>p__5, typeFromHandle, arg2, Yacht.<>o__358.<>p__17.Target(Yacht.<>o__358.<>p__17, typeof(Vector3), 0, 0, CamR[Positions.Index]), 100));
						Camera warehouseCam3 = this.WarehouseCam;
						if (Yacht.<>o__358.<>p__20 == null)
						{
							Yacht.<>o__358.<>p__20 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Vector3), typeof(Yacht)));
						}
						warehouseCam3.Position = Yacht.<>o__358.<>p__20.Target(Yacht.<>o__358.<>p__20, CamP[Positions.Index]);
						Camera warehouseCam4 = this.WarehouseCam;
						if (Yacht.<>o__358.<>p__21 == null)
						{
							Yacht.<>o__358.<>p__21 = CallSite<Func<CallSite, Type, int, int, object, Vector3>>.Create(Binder.InvokeConstructor(CSharpBinderFlags.None, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.IsStaticType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						warehouseCam4.Rotation = Yacht.<>o__358.<>p__21.Target(Yacht.<>o__358.<>p__21, typeof(Vector3), 0, 0, CamR[Positions.Index]);
						Game.Player.Character.IsVisible = false;
						this.WarehouseCam.IsActive = true;
						this.WarehouseCam.FarClip = 2000f;
						Function.Call(569060033405794044L, new InputArgument[]
						{
							1,
							0,
							3000,
							1,
							0
						});
						World.RenderingCamera = this.WarehouseCam;
						Entity character2 = Game.Player.Character;
						if (Yacht.<>o__358.<>p__22 == null)
						{
							Yacht.<>o__358.<>p__22 = CallSite<Func<CallSite, object, Vector3>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(Vector3), typeof(Yacht)));
						}
						character2.Position = Yacht.<>o__358.<>p__22.Target(Yacht.<>o__358.<>p__22, CamP[Positions.Index]);
						Game.Player.Character.FreezePosition = true;
						UIMenuItem pr2 = pr1;
						if (Yacht.<>o__358.<>p__25 == null)
						{
							Yacht.<>o__358.<>p__25 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
						}
						Func<CallSite, object, string> target6 = Yacht.<>o__358.<>p__25.Target;
						CallSite <>p__6 = Yacht.<>o__358.<>p__25;
						if (Yacht.<>o__358.<>p__24 == null)
						{
							Yacht.<>o__358.<>p__24 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						Func<CallSite, string, object, object> target7 = Yacht.<>o__358.<>p__24.Target;
						CallSite <>p__7 = Yacht.<>o__358.<>p__24;
						string arg3 = "Price : $";
						if (Yacht.<>o__358.<>p__23 == null)
						{
							Yacht.<>o__358.<>p__23 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "ToString", null, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						pr2.Text = target6(<>p__6, target7(<>p__7, arg3, Yacht.<>o__358.<>p__23.Target(Yacht.<>o__358.<>p__23, Price[Positions.Index], "N")));
						UIMenuItem loc2 = Loc;
						if (Yacht.<>o__358.<>p__27 == null)
						{
							Yacht.<>o__358.<>p__27 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof(string), typeof(Yacht)));
						}
						Func<CallSite, object, string> target8 = Yacht.<>o__358.<>p__27.Target;
						CallSite <>p__8 = Yacht.<>o__358.<>p__27;
						if (Yacht.<>o__358.<>p__26 == null)
						{
							Yacht.<>o__358.<>p__26 = CallSite<Func<CallSite, string, object, object>>.Create(Binder.BinaryOperation(CSharpBinderFlags.None, ExpressionType.Add, typeof(Yacht), new CSharpArgumentInfo[]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null)
							}));
						}
						loc2.Text = target8(<>p__8, Yacht.<>o__358.<>p__26.Target(Yacht.<>o__358.<>p__26, "Location : ", Location[Positions.Index]));
					}
				}
			};
			List<object> list3 = new List<object>();
			int num = 1;
			for (int i = 1; i < 100; i++)
			{
				list3.Add(num + i);
			}
			UIMenu uimenu2 = this.modMenuPool.AddSubMenu(this.methgarage, "Expand Business ");
			UIMenuListItem B = new UIMenuListItem("Business : ", list, 0);
			uimenu2.AddItem(B);
			UIMenuItem Update = new UIMenuItem("Update Stats");
			uimenu2.AddItem(Update);
			UIMenuItem BuyNewLevel = new UIMenuItem(" Buy Level ");
			uimenu2.AddItem(BuyNewLevel);
			UIMenuListItem list2 = new UIMenuListItem("Select Level: ", list3, 1);
			uimenu2.AddItem(list2);
			UIMenuItem Jump = new UIMenuItem("Jump Straight to Level");
			uimenu2.AddItem(Jump);
			UIMenuItem Show = new UIMenuItem("Show Level");
			uimenu2.AddItem(Show);
			uimenu2.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == B;
				if (flag)
				{
					bool flag2 = B.Index == 0;
					if (flag2)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//MazeBank.ini");
						UI.Notify("~w~Selected ~b~ Maze Bank~w~");
					}
					bool flag3 = B.Index == 1;
					if (flag3)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//ArcadiusTower.ini");
						UI.Notify("~w~Selected ~y~ Arcadius ~w~");
					}
					bool flag4 = B.Index == 2;
					if (flag4)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//DelPerroMazeBank.ini");
						UI.Notify("~w~Selected ~r~ Maze Bank West ~w~");
					}
					bool flag5 = B.Index == 3;
					if (flag5)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//LombokTower.ini");
						UI.Notify("~w~Selected ~g~ Lombok ~w~");
					}
				}
			};
			UIMenu uimenu3 = this.modMenuPool.AddSubMenu(this.methgarage, "Sell  Business");
			UIMenuListItem B1 = new UIMenuListItem("Business : ", list, 0);
			uimenu3.AddItem(B1);
			UIMenuItem Sell = new UIMenuItem("Sell");
			uimenu3.AddItem(Sell);
			uimenu3.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Sell;
				if (flag)
				{
					bool flag2 = !this.bought;
					if (flag2)
					{
						UI.Notify("Office Assistant: Get out of here!, you dont own any of these buisnesses ");
					}
					else
					{
						this.bought = false;
						this.purchaselvl = 0;
						this.stocksvalue = 0f;
						this.stockscount = 0;
						this.Config.SetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
						this.Config.Save();
						UI.Notify("Office Assistant: I just heard, you wanted to sell the buisness, i'm verry sorry, if i have upset you in any way");
					}
				}
			};
			uimenu3.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = item == B1;
				if (flag)
				{
					bool flag2 = B1.Index == 0;
					if (flag2)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//MazeBank.ini");
						UI.Notify("~w~Selected ~b~ Maze Bank~w~");
					}
					bool flag3 = B1.Index == 1;
					if (flag3)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//ArcadiusTower.ini");
						UI.Notify("~w~Selected ~y~ Arcadius ~w~");
					}
					bool flag4 = B1.Index == 2;
					if (flag4)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//DelPerroMazeBank.ini");
						UI.Notify("~w~Selected ~r~ Maze Bank West ~w~");
					}
					bool flag5 = B1.Index == 3;
					if (flag5)
					{
						this.LoadIniFile("scripts//ExecutiveBusiness//LombokTower.ini");
						UI.Notify("~w~Selected ~g~ Lombok ~w~");
					}
				}
			};
			uimenu2.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == Jump;
				if (flag)
				{
					int num2 = list2.Index + 1;
					bool flag2 = num2 > this.purchaselvl;
					if (flag2)
					{
						int num3 = 0;
						int num4 = 0;
						this.purchaselvl = this.Config.GetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
						for (int j = this.purchaselvl; j < num2; j++)
						{
							double num5 = 1.75;
							bool flag3 = this.purchaselvl < 25;
							if (flag3)
							{
								num5 = 1.75;
							}
							bool flag4 = this.purchaselvl > 25 && index < 50;
							if (flag4)
							{
								num5 = 2.25;
							}
							bool flag5 = this.purchaselvl > 50 && this.purchaselvl < 70;
							if (flag5)
							{
								num5 = 3.5;
							}
							bool flag6 = this.purchaselvl > 75 && this.purchaselvl < 100;
							if (flag6)
							{
								num5 = 4.75;
							}
							num3 += (int)(200000.0 * num5 * (double)num2);
							num4++;
						}
						string[] array = new string[5];
						array[0] = "Office Assistant : OK your new level will be ";
						int num6 = 1;
						int num7 = this.purchaselvl += num4 + 1;
						array[num6] = num7.ToString();
						array[2] = ", at a price of $";
						array[3] = num3.ToString("N");
						array[4] = ", Do u want to continue Enter Y or N";
						UI.Notify(string.Concat(array));
						Script.Wait(1000);
						try
						{
							string userInput = Game.GetUserInput(0, 1);
							bool flag7 = userInput.Equals("Y");
							if (flag7)
							{
								bool flag8 = Game.Player.Money >= num3;
								if (flag8)
								{
									Game.Player.Money -= num3;
									this.purchaselvl = num2;
									float num8 = (float)(125000 * this.purchaselvl) / 0.75f;
									this.maxstocks = 10 * this.purchaselvl;
									this.maxstocks = 10 * this.purchaselvl;
									this.profitMargin = (float)(0.85 * (double)this.purchaselvl + 0.0);
									this.increaseGain = num8;
									this.Config.SetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
									this.Config.Save();
								}
								else
								{
									UI.Notify("You dont have enough money to purchase this upgrade");
								}
							}
							else
							{
								this.purchaselvl = this.Config.GetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
								UI.Notify("Office Assistant : You Entered the Wrong key or N");
							}
						}
						catch (NullReferenceException ex)
						{
							this.purchaselvl = this.Config.GetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
							UI.Notify("You did not enter a key!");
						}
					}
				}
				bool flag9 = item == Update;
				if (flag9)
				{
					int num9 = list2.Index + 1;
					double num10 = 1.75;
					bool flag10 = this.purchaselvl < 25;
					if (flag10)
					{
						num10 = 1.75;
					}
					bool flag11 = this.purchaselvl > 25 && index < 50;
					if (flag11)
					{
						num10 = 2.25;
					}
					bool flag12 = this.purchaselvl > 50 && this.purchaselvl < 70;
					if (flag12)
					{
						num10 = 3.5;
					}
					bool flag13 = this.purchaselvl > 75 && this.purchaselvl < 100;
					if (flag13)
					{
						num10 = 4.75;
					}
					UI.Notify("Price " + (200000.0 * num10 * (double)num9).ToString("N"));
					UI.Notify("Level to Buy " + (num9 + 1).ToString());
					UI.Notify("increaseGain : $" + ((float)(125000 * num9) / 0.75f).ToString());
					UI.Notify("Profit Margin :" + (0.85 * (double)num9 + 0.0).ToString() + "%");
					UI.Notify("Max Stocks : " + (10 * num9).ToString());
				}
				bool flag14 = item == BuyNewLevel;
				if (flag14)
				{
					int num11 = list2.Index + 1;
					this.purchaselvl = this.Config.GetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
					bool flag15 = this.purchaselvl + 1 == num11;
					if (flag15)
					{
						double num12 = 1.75;
						bool flag16 = this.purchaselvl < 25;
						if (flag16)
						{
							num12 = 1.75;
						}
						bool flag17 = this.purchaselvl > 25 && index < 50;
						if (flag17)
						{
							num12 = 2.25;
						}
						bool flag18 = this.purchaselvl > 50 && this.purchaselvl < 70;
						if (flag18)
						{
							num12 = 3.5;
						}
						bool flag19 = this.purchaselvl > 75 && this.purchaselvl < 100;
						if (flag19)
						{
							num12 = 4.75;
						}
						bool flag20 = (double)Game.Player.Money >= 200000.0 * num12 * (double)num11;
						if (flag20)
						{
							Game.Player.Money -= (int)(200000.0 * num12 * (double)num11);
							this.purchaselvl++;
							this.maxstocks = 10 * this.purchaselvl;
							float num13 = (float)(125000 * this.purchaselvl) / 0.75f;
							this.profitMargin = (float)(0.85 * (double)this.purchaselvl + 0.0);
							this.increaseGain = num13;
							this.Config.SetValue<int>("Setup", "BuisnessLevel", this.purchaselvl);
							this.Config.Save();
						}
						else
						{
							UI.Notify("You dont have enough money to purchase this upgrade");
						}
					}
					else
					{
						UI.Notify("The level you are trying to purchase is either to high or to low!, please purchase the level before, to purchase this level");
					}
				}
				bool flag21 = item == Show;
				if (flag21)
				{
					double num14 = 1.75;
					bool flag22 = this.purchaselvl < 25;
					if (flag22)
					{
						num14 = 1.75;
					}
					bool flag23 = this.purchaselvl > 25 && index < 50;
					if (flag23)
					{
						num14 = 2.25;
					}
					bool flag24 = this.purchaselvl > 50 && this.purchaselvl < 70;
					if (flag24)
					{
						num14 = 3.5;
					}
					bool flag25 = this.purchaselvl > 75 && this.purchaselvl < 100;
					if (flag25)
					{
						num14 = 4.75;
					}
					UI.Notify("Price for Next Level $" + (200000.0 * num14 * (double)this.purchaselvl).ToString("N"));
					UI.Notify("Next Level " + (this.purchaselvl + 1).ToString());
					UI.Notify("increaseGain : $" + ((float)(125000 * this.purchaselvl) / 0.75f).ToString());
					UI.Notify("Profit Margin :" + (0.85 * (double)this.purchaselvl + 0.0).ToString() + "%");
					UI.Notify("Max Stocks : " + (10 * this.purchaselvl).ToString());
				}
			};
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00014BA0 File Offset: 0x00012DA0
		private void DisplayHelpTextThisFrame(string text)
		{
			InputArgument[] array = new InputArgument[]
			{
				"STRING"
			};
			Function.Call(-8860350453193909743L, array);
			InputArgument[] array2 = new InputArgument[]
			{
				text
			};
			Function.Call(7789129354908300458L, array2);
			InputArgument[] array3 = new InputArgument[]
			{
				0,
				0,
				1,
				-1
			};
			Function.Call(2562546386151446694L, array3);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00014C30 File Offset: 0x00012E30
		private void DisplayHelpTextThisFrameNoSound(string text)
		{
			InputArgument[] array = new InputArgument[]
			{
				"STRING"
			};
			Function.Call(-8860350453193909743L, array);
			InputArgument[] array2 = new InputArgument[]
			{
				text
			};
			Function.Call(7789129354908300458L, array2);
			InputArgument[] array3 = new InputArgument[]
			{
				0,
				0,
				0,
				-1
			};
			Function.Call(2562546386151446694L, array3);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00014CC0 File Offset: 0x00012EC0
		public void Delete()
		{
			Function.Call(-1266537528939206611L, new InputArgument[]
			{
				this.YachtHashs[this.Location]
			});
			Function.Call(-1266537528939206611L, new InputArgument[]
			{
				this.YachtHashs2[this.Location]
			});
			bool flag = this.Base != null;
			if (flag)
			{
				this.Base.Delete();
			}
			this.Created = false;
			this.DeletedYacht = false;
			this.Foundyacht = false;
			bool flag2 = this.Base2 != null;
			if (flag2)
			{
				this.Base2.Delete();
			}
			bool flag3 = this.BoatA != null;
			if (flag3)
			{
				this.BoatA.Delete();
			}
			bool flag4 = this.BoatB != null;
			if (flag4)
			{
				this.BoatB.Delete();
			}
			bool flag5 = this.SeaSharkA != null;
			if (flag5)
			{
				this.SeaSharkA.Delete();
			}
			bool flag6 = this.SeaSharkB != null;
			if (flag6)
			{
				this.SeaSharkB.Delete();
			}
			bool flag7 = this.SeaSharkC != null;
			if (flag7)
			{
				this.SeaSharkC.Delete();
			}
			bool flag8 = this.SeaSharkD != null;
			if (flag8)
			{
				this.SeaSharkD.Delete();
			}
			bool flag9 = this.FlagA != null;
			if (flag9)
			{
				this.FlagA.Delete();
			}
			bool flag10 = this.FlagB != null;
			if (flag10)
			{
				this.FlagB.Delete();
			}
			bool flag11 = this.FlagC != null;
			if (flag11)
			{
				this.FlagC.Delete();
			}
			bool flag12 = this.DoorC != null;
			if (flag12)
			{
				this.DoorC.Delete();
			}
			bool flag13 = this.DoorB != null;
			if (flag13)
			{
				this.DoorB.Delete();
			}
			bool flag14 = this.Bargirl != null;
			if (flag14)
			{
				this.Bargirl.Delete();
			}
			foreach (Ped ped in this.Peds)
			{
				bool flag15 = ped != null;
				if (flag15)
				{
					ped.Delete();
				}
			}
			bool flag16 = this.HeliA != null;
			if (flag16)
			{
				this.HeliA.Delete();
			}
			bool flag17 = this.HeliB != null;
			if (flag17)
			{
				this.HeliB.Delete();
			}
			bool flag18 = this.Base != null;
			if (flag18)
			{
				this.Base.Delete();
			}
			Prop[] nearbyProps = World.GetNearbyProps(this.YachtPos[this.Location], 500f);
			foreach (Prop prop in nearbyProps)
			{
				bool flag19 = prop != null;
				if (flag19)
				{
					prop.Delete();
				}
			}
			foreach (Prop prop2 in this.Props)
			{
				bool flag20 = prop2 != null;
				if (flag20)
				{
					prop2.Delete();
				}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00015064 File Offset: 0x00013264
		private void OnShutdown(object sender, EventArgs e)
		{
			bool flag = true;
			bool flag2 = flag;
			if (flag2)
			{
				foreach (Prop prop in this.Champ)
				{
					bool flag3 = prop != null;
					if (flag3)
					{
						prop.Delete();
					}
				}
				bool flag4 = this.WarehouseCam != null;
				if (flag4)
				{
					World.RenderingCamera = this.WarehouseCam;
					Function.Call(569060033405794044L, new InputArgument[]
					{
						0,
						0,
						3000,
						1,
						0
					});
					this.WarehouseCam.IsActive = false;
					this.WarehouseCam.Destroy();
					Game.Player.Character.FreezePosition = false;
				}
				bool flag5 = this.DestoryVehicle != null;
				if (flag5)
				{
					this.DestoryVehicle.Remove();
				}
				bool flag6 = this.VehicleMissioncar != null;
				if (flag6)
				{
					this.VehicleMissioncar.Delete();
				}
				bool flag7 = this.VehicleId != null;
				if (flag7)
				{
					this.VehicleId.Delete();
				}
				bool flag8 = this.VtoGet != null;
				if (flag8)
				{
					this.VtoGet.Delete();
				}
				bool flag9 = this.VtoGet1 != null;
				if (flag9)
				{
					this.VtoGet1.Delete();
				}
				bool flag10 = this.VtoGet2 != null;
				if (flag10)
				{
					this.VtoGet2.Delete();
				}
				bool flag11 = this.VtoGet3 != null;
				if (flag11)
				{
					this.VtoGet3.Delete();
				}
				bool flag12 = this.VtoGetBlip != null;
				if (flag12)
				{
					this.VtoGetBlip.Remove();
				}
				bool flag13 = this.DropzoneBlip != null;
				if (flag13)
				{
					this.DropzoneBlip.Remove();
				}
				bool flag14 = this.RentedVehicle != null;
				if (flag14)
				{
					this.RentedVehicle.Delete();
				}
				bool flag15 = this.BoatA != null;
				if (flag15)
				{
					this.BoatA.Delete();
				}
				bool flag16 = this.BoatB != null;
				if (flag16)
				{
					this.BoatB.Delete();
				}
				bool flag17 = this.SeaSharkA != null;
				if (flag17)
				{
					this.SeaSharkA.Delete();
				}
				bool flag18 = this.SeaSharkB != null;
				if (flag18)
				{
					this.SeaSharkB.Delete();
				}
				bool flag19 = this.SeaSharkC != null;
				if (flag19)
				{
					this.SeaSharkC.Delete();
				}
				bool flag20 = this.SeaSharkD != null;
				if (flag20)
				{
					this.SeaSharkD.Delete();
				}
				bool flag21 = this.FlagA != null;
				if (flag21)
				{
					this.FlagA.Delete();
				}
				bool flag22 = this.FlagB != null;
				if (flag22)
				{
					this.FlagB.Delete();
				}
				bool flag23 = this.FlagC != null;
				if (flag23)
				{
					this.FlagC.Delete();
				}
				bool flag24 = this.DoorC != null;
				if (flag24)
				{
					this.DoorC.Delete();
				}
				bool flag25 = this.DoorB != null;
				if (flag25)
				{
					this.DoorB.Delete();
				}
				bool flag26 = this.Bargirl != null;
				if (flag26)
				{
					this.Bargirl.Delete();
				}
				foreach (Ped ped in this.Peds)
				{
					bool flag27 = ped != null;
					if (flag27)
					{
						ped.Delete();
					}
				}
				bool flag28 = this.HeliA != null;
				if (flag28)
				{
					this.HeliA.Delete();
				}
				bool flag29 = this.HeliB != null;
				if (flag29)
				{
					this.HeliB.Delete();
				}
				foreach (Prop prop2 in this.Props)
				{
					bool flag30 = prop2 != null;
					if (flag30)
					{
						prop2.Delete();
					}
				}
				foreach (Blip blip in this.Blips)
				{
					bool flag31 = blip != null;
					if (flag31)
					{
						blip.Remove();
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00015574 File Offset: 0x00013774
		public void PlayAnim(Ped p, int Gender)
		{
			Random random = new Random();
			int num = random.Next(1, 5);
			p.FreezePosition = true;
			p.AlwaysKeepTask = true;
			bool flag = Gender == 1;
			if (flag)
			{
				bool flag2 = num == 1;
				if (flag2)
				{
					int num2 = random.Next(1, 4);
					bool flag3 = num2 == 1;
					if (flag3)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base", 8f, -1, true, -1f);
					}
					bool flag4 = num2 == 2;
					if (flag4)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_a", 8f, -1, true, -1f);
					}
					bool flag5 = num2 == 3;
					if (flag5)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_b", 8f, -1, true, -1f);
					}
					bool flag6 = num2 == 4;
					if (flag6)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag7 = num == 2;
				if (flag7)
				{
					int num3 = random.Next(1, 4);
					bool flag8 = num3 == 1;
					if (flag8)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base", 8f, -1, true, -1f);
					}
					bool flag9 = num3 == 2;
					if (flag9)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_a", 8f, -1, true, -1f);
					}
					bool flag10 = num3 == 3;
					if (flag10)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_b", 8f, -1, true, -1f);
					}
					bool flag11 = num3 == 4;
					if (flag11)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag12 = num == 3;
				if (flag12)
				{
					int num4 = random.Next(1, 4);
					bool flag13 = num4 == 1;
					if (flag13)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base", 8f, -1, true, -1f);
					}
					bool flag14 = num4 == 2;
					if (flag14)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_a", 8f, -1, true, -1f);
					}
					bool flag15 = num4 == 3;
					if (flag15)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_b", 8f, -1, true, -1f);
					}
					bool flag16 = num4 == 4;
					if (flag16)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag17 = num == 4;
				if (flag17)
				{
					p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_04@", "base", 8f, -1, true, -1f);
				}
				bool flag18 = num == 5;
				if (flag18)
				{
					p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_05@", "base", 8f, -1, true, -1f);
				}
			}
			bool flag19 = Gender == 2;
			if (flag19)
			{
				bool flag20 = num == 1;
				if (flag20)
				{
					int num5 = random.Next(1, 4);
					bool flag21 = num5 == 1;
					if (flag21)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base", 8f, -1, true, -1f);
					}
					bool flag22 = num5 == 2;
					if (flag22)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_a", 8f, -1, true, -1f);
					}
					bool flag23 = num5 == 3;
					if (flag23)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_b", 8f, -1, true, -1f);
					}
					bool flag24 = num5 == 4;
					if (flag24)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag25 = num == 2;
				if (flag25)
				{
					int num6 = random.Next(1, 4);
					bool flag26 = num6 == 1;
					if (flag26)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base", 8f, -1, true, -1f);
					}
					bool flag27 = num6 == 2;
					if (flag27)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_a", 8f, -1, true, -1f);
					}
					bool flag28 = num6 == 3;
					if (flag28)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_b", 8f, -1, true, -1f);
					}
					bool flag29 = num6 == 4;
					if (flag29)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag30 = num == 3;
				if (flag30)
				{
					int num7 = random.Next(1, 4);
					bool flag31 = num7 == 1;
					if (flag31)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base", 8f, -1, true, -1f);
					}
					bool flag32 = num7 == 2;
					if (flag32)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_a", 8f, -1, true, -1f);
					}
					bool flag33 = num7 == 3;
					if (flag33)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_b", 8f, -1, true, -1f);
					}
					bool flag34 = num7 == 4;
					if (flag34)
					{
						p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_c", 8f, -1, true, -1f);
					}
				}
				bool flag35 = num == 4;
				if (flag35)
				{
					p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
				}
				bool flag36 = num == 5;
				if (flag36)
				{
					p.Task.PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
				}
			}
			this.Peds.Add(p);
			p = null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00015B54 File Offset: 0x00013D54
		public float GetRoationalAxis()
		{
			float z = this.Base.Rotation.Z;
			return 0f;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00015B80 File Offset: 0x00013D80
		public void OnTick(object sender, EventArgs e)
		{
			bool flag = this.ChangePosPool != null && this.ChangePosPool.IsAnyMenuOpen();
			if (flag)
			{
				this.ChangePosPool.ProcessMenus();
			}
			bool flag2 = this.Woredrobepool != null && this.Woredrobepool.IsAnyMenuOpen();
			if (flag2)
			{
				this.Woredrobepool.ProcessMenus();
			}
			this.OnKeyDown();
			bool flag3 = this.DrinksPool != null && this.DrinksPool.IsAnyMenuOpen();
			if (flag3)
			{
				this.DrinksPool.ProcessMenus();
			}
			foreach (Vector3 vector in this.RadioPos)
			{
				bool flag4 = World.GetDistance(Game.Player.Character.Position, vector) < 80f;
				if (flag4)
				{
					World.DrawMarker(1, vector, Vector3.Zero, Vector3.Zero, new Vector3(0.4f, 0.4f, 0.3f), Color.Yellow);
				}
				bool flag5 = World.GetDistance(Game.Player.Character.Position, vector) < 2f;
				if (flag5)
				{
					this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to turn Radio On/Off, ~INPUT_COVER~ to change station");
				}
				bool flag6 = World.GetDistance(Game.Player.Character.Position, vector) < 2f;
				if (flag6)
				{
					bool flag7 = Game.IsControlJustPressed(2, 51);
					if (flag7)
					{
						bool radioOn = this.RadioOn;
						if (radioOn)
						{
							this.RadioOn = false;
							Function.Call(-4672365499868974113L, new InputArgument[]
							{
								false
							});
							Function.Call(1195764362099706803L, new InputArgument[]
							{
								false
							});
						}
						else
						{
							bool flag8 = !this.RadioOn;
							if (flag8)
							{
								this.CurrentRadio = Game.Player.Character.Position;
								Vector3 position = Game.Player.Character.Position;
								this.CurrentInt = Function.Call<int>(-5694810085874607677L, new InputArgument[]
								{
									position.X,
									position.Y,
									position.Z
								});
								this.Z_min = Game.Player.Character.Position.Z - 7f;
								this.Z_max = Game.Player.Character.Position.Z + 7f;
								this.RadioOn = true;
								Function.Call(-6477951525662992625L, new InputArgument[]
								{
									1
								});
								Function.Call(1195764362099706803L, new InputArgument[]
								{
									true
								});
							}
						}
					}
				}
			}
			bool radioOn2 = this.RadioOn;
			if (radioOn2)
			{
				bool flag9 = World.GetDistance(Game.Player.Character.Position, this.CurrentRadio) > 150f;
				if (flag9)
				{
					UI.Notify("Radio Off, due to Player being to far away from Radio");
					this.RadioOn = false;
					Function.Call(-4672365499868974113L, new InputArgument[]
					{
						false
					});
					Function.Call(1195764362099706803L, new InputArgument[]
					{
						false
					});
					Function.Call(1869590208789261902L, new InputArgument[]
					{
						true
					});
				}
				Vector3 position2 = Game.Player.Character.Position;
				bool flag10 = position2.Z > this.Z_max || position2.Z < this.Z_min;
				if (flag10)
				{
					UI.Notify("Radio Off, due to Player Height, being too low or too High");
					this.RadioOn = false;
					Function.Call(-4672365499868974113L, new InputArgument[]
					{
						false
					});
					Function.Call(1195764362099706803L, new InputArgument[]
					{
						false
					});
					Function.Call(1869590208789261902L, new InputArgument[]
					{
						true
					});
				}
				bool flag11 = Function.Call<int>(-5694810085874607677L, new InputArgument[]
				{
					position2.X,
					position2.Y,
					position2.Z
				}) != Function.Call<int>(-5694810085874607677L, new InputArgument[]
				{
					this.CurrentRadio.X,
					this.CurrentRadio.Y,
					this.CurrentRadio.Z
				});
				if (flag11)
				{
					UI.Notify("Radio Off, due to exiting Interior");
					this.RadioOn = false;
					Function.Call(-4672365499868974113L, new InputArgument[]
					{
						false
					});
					Function.Call(1195764362099706803L, new InputArgument[]
					{
						false
					});
					Function.Call(1869590208789261902L, new InputArgument[]
					{
						true
					});
				}
				bool flag12 = Game.Player.Character.CurrentVehicle != null;
				if (flag12)
				{
					UI.Notify("Radio Off, due to being in Vehicle");
					this.RadioOn = false;
					Function.Call(-4672365499868974113L, new InputArgument[]
					{
						false
					});
					Function.Call(1195764362099706803L, new InputArgument[]
					{
						false
					});
					Function.Call(1869590208789261902L, new InputArgument[]
					{
						true
					});
				}
				bool flag13 = Game.Player.Character.CurrentVehicle == null;
				if (flag13)
				{
					Function.Call(-4672365499868974113L, new InputArgument[]
					{
						true
					});
				}
			}
			bool flag14 = this.Base != null;
			if (flag14)
			{
				bool flag15 = Game.IsControlJustPressed(2, 51);
				if (flag15)
				{
				}
				bool flag16 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) < 200f;
				if (flag16)
				{
					Game.Player.Character.Weapons.Select(-1569615261);
				}
			}
			bool showDistWhenClose = this.ShowDistWhenClose;
			if (showDistWhenClose)
			{
				bool flag17 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) < (float)(this.SpawnDist + 200);
				if (flag17)
				{
					bool flag18 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) > (float)this.SpawnDist;
					if (flag18)
					{
						this.DisplayHelpTextThisFrameNoSound(string.Concat(new string[]
						{
							"Distance to Yacht ~b~",
							World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]).ToString(),
							"m ~w~, Dist to spawn :~b~",
							this.SpawnDist.ToString(),
							"m~w~"
						}));
					}
				}
			}
			bool flag19 = this.Purchased == 1;
			if (flag19)
			{
				bool flag20 = World.GetDistance(Game.Player.Character.Position, new Vector3(2000f, 2000f, 1000f)) < 2f;
				if (flag20)
				{
					this.Reset();
				}
				bool flag21 = this.Base != null;
				if (flag21)
				{
					bool showTestBlips = this.ShowTestBlips;
					if (showTestBlips)
					{
						bool flag22 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeBPos) < 80f;
						if (flag22)
						{
							World.DrawMarker(1, this.WoredrobeBPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Pink);
						}
						bool flag23 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeCPos) < 80f;
						if (flag23)
						{
							World.DrawMarker(1, this.WoredrobeCPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Purple);
						}
						bool flag24 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeAPos) < 80f;
						if (flag24)
						{
							World.DrawMarker(1, this.WoredrobeAPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Lime);
						}
						bool flag25 = World.GetDistance(Game.Player.Character.Position, this.SeaSharkPosA) < 80f;
						if (flag25)
						{
							World.DrawMarker(1, this.SeaSharkPosA, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag26 = World.GetDistance(Game.Player.Character.Position, this.SeaSharkPosB) < 80f;
						if (flag26)
						{
							World.DrawMarker(1, this.SeaSharkPosB, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag27 = World.GetDistance(Game.Player.Character.Position, this.SeaSharkPosC) < 80f;
						if (flag27)
						{
							World.DrawMarker(1, this.SeaSharkPosC, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag28 = World.GetDistance(Game.Player.Character.Position, this.SeaSharkPosD) < 80f;
						if (flag28)
						{
							World.DrawMarker(1, this.SeaSharkPosD, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag29 = World.GetDistance(Game.Player.Character.Position, this.BoatAPos) < 80f;
						if (flag29)
						{
							World.DrawMarker(1, this.BoatAPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag30 = World.GetDistance(Game.Player.Character.Position, this.BoatBPos) < 80f;
						if (flag30)
						{
							World.DrawMarker(1, this.BoatBPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag31 = World.GetDistance(Game.Player.Character.Position, this.ShowerAPos) < 80f;
						if (flag31)
						{
							World.DrawMarker(1, this.ShowerAPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
							World.DrawMarker(1, this.ShowerAPosEnter, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
						}
						bool flag32 = World.GetDistance(Game.Player.Character.Position, this.ShowerBPos) < 80f;
						if (flag32)
						{
							World.DrawMarker(1, this.ShowerBPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
							World.DrawMarker(1, this.ShowerBPosEnter, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
						}
						bool flag33 = World.GetDistance(Game.Player.Character.Position, this.ShowerCPos) < 80f;
						if (flag33)
						{
							World.DrawMarker(1, this.ShowerCPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
							World.DrawMarker(1, this.ShowerCPosEnter, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
						}
						bool flag34 = World.GetDistance(Game.Player.Character.Position, this.BarPos) < 80f;
						if (flag34)
						{
							World.DrawMarker(1, this.BarPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
						}
						bool flag35 = World.GetDistance(Game.Player.Character.Position, this.BarPos) < 80f;
						if (flag35)
						{
							World.DrawMarker(1, this.BarPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
						}
						bool flag36 = World.GetDistance(Game.Player.Character.Position, this.BarDrinkPos) < 80f;
						if (flag36)
						{
							World.DrawMarker(1, this.BarDrinkPos, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag37 = World.GetDistance(Game.Player.Character.Position, this.Bed1) < 80f;
						if (flag37)
						{
							World.DrawMarker(1, this.Bed1, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Green);
						}
						bool flag38 = World.GetDistance(Game.Player.Character.Position, this.Bed2) < 80f;
						if (flag38)
						{
							World.DrawMarker(1, this.Bed2, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag39 = World.GetDistance(Game.Player.Character.Position, this.Bed3) < 80f;
						if (flag39)
						{
							World.DrawMarker(1, this.Bed3, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
						}
						bool flag40 = this.HeliB != null;
						if (flag40)
						{
							bool flag41 = World.GetDistance(Game.Player.Character.Position, this.HeliB.Position) < 80f;
							if (flag41)
							{
								World.DrawMarker(1, this.HeliB.Position, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 10f), Color.Red);
							}
						}
						bool flag42 = this.HeliA != null;
						if (flag42)
						{
							bool flag43 = World.GetDistance(Game.Player.Character.Position, this.HeliA.Position) < 80f;
							if (flag43)
							{
								World.DrawMarker(1, this.HeliA.Position, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 10f), Color.Red);
							}
						}
						bool flag44 = World.GetDistance(Game.Player.Character.Position, this.HeliPosA) < 80f;
						if (flag44)
						{
							World.DrawMarker(1, this.HeliPosA, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
						}
						bool flag45 = World.GetDistance(Game.Player.Character.Position, this.HeliPosB) < 80f;
						if (flag45)
						{
							bool flag46 = this.MaxHelis != 1;
							if (flag46)
							{
								World.DrawMarker(1, this.HeliPosB, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
							}
						}
						bool flag47 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat1) < 80f;
						if (flag47)
						{
							World.DrawMarker(1, this.jacuzziSeat1, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
						}
						bool flag48 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat2) < 80f;
						if (flag48)
						{
							World.DrawMarker(1, this.jacuzziSeat2, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
						}
						bool flag49 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat3) < 80f;
						if (flag49)
						{
							World.DrawMarker(1, this.jacuzziSeat3, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
						}
						bool flag50 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat4) < 80f;
						if (flag50)
						{
							World.DrawMarker(1, this.jacuzziSeat4, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Green);
						}
						bool flag51 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat5) < 80f;
						if (flag51)
						{
							World.DrawMarker(1, this.jacuzziSeat5, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Purple);
						}
						bool flag52 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat6) < 80f;
						if (flag52)
						{
							World.DrawMarker(1, this.jacuzziSeat6, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.YellowGreen);
						}
						bool flag53 = this.DoorC != null;
						if (flag53)
						{
							bool flag54 = World.GetDistance(Game.Player.Character.Position, this.DoorC.Position) < 80f;
							if (flag54)
							{
								World.DrawMarker(1, this.DoorC.Position, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Blue);
							}
						}
						bool flag55 = this.DoorB != null;
						if (flag55)
						{
							bool flag56 = World.GetDistance(Game.Player.Character.Position, this.DoorB.Position) < 80f;
							if (flag56)
							{
								World.DrawMarker(1, this.DoorB.Position, Vector3.Zero, Vector3.Zero, new Vector3(0.7f, 0.7f, 1f), Color.Red);
							}
						}
					}
					bool flag57 = World.GetDistance(Game.Player.Character.Position, this.ChangeLocMarker) < 80f;
					if (flag57)
					{
						World.DrawMarker(1, this.ChangeLocMarker, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag58 = World.GetDistance(Game.Player.Character.Position, this.BarEnter) < 80f;
					if (flag58)
					{
						World.DrawMarker(1, this.BarEnter, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag59 = World.GetDistance(Game.Player.Character.Position, this.BarExit) < 80f;
					if (flag59)
					{
						World.DrawMarker(1, this.BarExit, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag60 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersEnter) < 80f;
					if (flag60)
					{
						World.DrawMarker(1, this.CaptinsQuartersEnter, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag61 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersExit) < 80f;
					if (flag61)
					{
						World.DrawMarker(1, this.CaptinsQuartersExit, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag62 = World.GetDistance(Game.Player.Character.Position, this.MenuMarker) < 80f;
					if (flag62)
					{
						World.DrawMarker(1, this.MenuMarker, Vector3.Zero, Vector3.Zero, new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, 255));
					}
					bool flag63 = World.GetDistance(Game.Player.Character.Position, this.BarDrinkPos) < 2f;
					if (flag63)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to buy a drink");
					}
					bool flag64 = World.GetDistance(Game.Player.Character.Position, this.ShowerAPos) < 3f || World.GetDistance(Game.Player.Character.Position, this.ShowerBPos) < 3f || World.GetDistance(Game.Player.Character.Position, this.ShowerCPos) < 3f;
					if (flag64)
					{
						bool inShower = this.InShower;
						if (inShower)
						{
							this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to get out of shower");
						}
						bool flag65 = !this.InShower;
						if (flag65)
						{
							this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to take a shower");
						}
					}
					bool flag66 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat1) < 4f;
					if (flag66)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
					}
					bool flag67 = World.GetDistance(Game.Player.Character.Position, this.ChangeLocMarker) < 2f;
					if (flag67)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Open Menu to Change Location of Yacht ");
					}
					bool flag68 = World.GetDistance(Game.Player.Character.Position, this.BarEnter) < 2f;
					if (flag68)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Enter Bar and Lounge Area ");
					}
					bool flag69 = World.GetDistance(Game.Player.Character.Position, this.BarExit) < 2f;
					if (flag69)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Exit Bar and Lounge Area ");
					}
					bool flag70 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersEnter) < 2f;
					if (flag70)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Enter Captain's Quarters ");
					}
					bool flag71 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersExit) < 2f;
					if (flag71)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Exit Captain's Quarters ");
					}
					bool flag72 = World.GetDistance(Game.Player.Character.Position, this.MenuMarker) < 2f;
					if (flag72)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Open the Business Menu ");
					}
					bool flag73 = World.GetDistance(Game.Player.Character.Position, this.Bed1) < 2f;
					if (flag73)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Sleep");
					}
					bool flag74 = World.GetDistance(Game.Player.Character.Position, this.Bed2) < 2f;
					if (flag74)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Sleep");
					}
					bool flag75 = World.GetDistance(Game.Player.Character.Position, this.Bed3) < 2f;
					if (flag75)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sleep");
					}
					bool flag76 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeAPos) < 2f;
					if (flag76)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to access Wardrobe");
					}
					bool flag77 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeBPos) < 2f;
					if (flag77)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to access Wardrobe");
					}
					bool flag78 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeCPos) < 2f;
					if (flag78)
					{
						this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to access Wardrobe");
					}
				}
				bool flag79 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) < 750f;
				if (flag79)
				{
					bool flag80 = this.BoatA != null;
					if (flag80)
					{
						bool flag81 = this.BoatA.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag81)
						{
							this.BoatA.FreezePosition = false;
						}
					}
					bool flag82 = this.BoatB != null;
					if (flag82)
					{
						bool flag83 = this.BoatB.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag83)
						{
							this.BoatB.FreezePosition = false;
						}
					}
					bool flag84 = this.SeaSharkA != null;
					if (flag84)
					{
						bool flag85 = this.SeaSharkA.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag85)
						{
							this.SeaSharkA.FreezePosition = false;
						}
					}
					bool flag86 = this.SeaSharkB != null;
					if (flag86)
					{
						bool flag87 = this.SeaSharkB.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag87)
						{
							this.SeaSharkB.FreezePosition = false;
						}
					}
					bool flag88 = this.SeaSharkC != null;
					if (flag88)
					{
						bool flag89 = this.SeaSharkC.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag89)
						{
							this.SeaSharkC.FreezePosition = false;
						}
					}
					bool flag90 = this.SeaSharkD != null;
					if (flag90)
					{
						bool flag91 = this.HeliA.GetPedOnSeat(-1) != Game.Player.Character;
						if (!flag91)
						{
							this.SeaSharkD.FreezePosition = false;
						}
					}
				}
				bool flag92 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) > (float)this.SpawnDist;
				if (flag92)
				{
					bool created = this.Created;
					if (created)
					{
						this.Delete();
					}
				}
				bool flag93 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) < (float)this.SpawnDist;
				if (flag93)
				{
					bool flag94 = !this.Created;
					if (flag94)
					{
						bool flag95 = !this.DeletedYacht;
						if (flag95)
						{
							bool flag96 = this.HeliA != null;
							if (flag96)
							{
								this.HeliA.Delete();
							}
							bool flag97 = this.HeliB != null;
							if (flag97)
							{
								this.HeliB.Delete();
							}
							this.DoorA = null;
							this.DoorB = null;
							this.DoorC = null;
							this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
							string text = this.YachtHashs[this.Location];
							string text2 = this.YachtHashs2[this.Location];
							Function.Call(4734559983020792692L, new InputArgument[]
							{
								text
							});
							Function.Call(4734559983020792692L, new InputArgument[]
							{
								text2
							});
							bool flag98 = Function.Call<bool>(-8599832514687978347L, new InputArgument[]
							{
								text
							}) && Function.Call<bool>(-8599832514687978347L, new InputArgument[]
							{
								text2
							});
							if (flag98)
							{
								this.DeletedYacht = true;
							}
						}
						bool deletedYacht = this.DeletedYacht;
						if (deletedYacht)
						{
							string text3 = this.YachtHashs[this.Location];
							string text4 = this.YachtHashs2[this.Location];
							Function.Call(4734559983020792692L, new InputArgument[]
							{
								text3
							});
							Function.Call(4734559983020792692L, new InputArgument[]
							{
								text4
							});
							Script.Wait(500);
							int num = Function.Call<int>(-3292914402564945716L, new InputArgument[]
							{
								"apa_mp_apa_yacht"
							});
							this.Base = Function.Call<Prop>(-2214651566572027031L, new InputArgument[]
							{
								this.YachtPos[this.Location].X,
								this.YachtPos[this.Location].Y,
								this.YachtPos[this.Location].Z,
								25f,
								num,
								0,
								0,
								0
							});
							bool flag99 = this.Base != null;
							if (flag99)
							{
								this.Foundyacht = false;
								this.Created = true;
								Function.Call(-7557708654927622093L, new InputArgument[]
								{
									this.Base,
									this.ShipColor
								});
							}
						}
					}
					bool created2 = this.Created;
					if (created2)
					{
						bool flag100 = !this.Foundyacht;
						if (flag100)
						{
							try
							{
								bool flag101 = this.Location != 37;
								if (flag101)
								{
									string text5 = this.YachtHashs[this.Location];
									string text6 = this.YachtHashs2[this.Location];
									Function.Call(4734559983020792692L, new InputArgument[]
									{
										text5
									});
									Function.Call(4734559983020792692L, new InputArgument[]
									{
										text6
									});
									Script.Wait(500);
									int num2 = Function.Call<int>(-3292914402564945716L, new InputArgument[]
									{
										"apa_mp_apa_yacht"
									});
									this.Base = Function.Call<Prop>(-2214651566572027031L, new InputArgument[]
									{
										this.YachtPos[this.Location].X,
										this.YachtPos[this.Location].Y,
										this.YachtPos[this.Location].Z,
										25f,
										num2,
										0,
										0,
										0
									});
									bool flag102 = this.Base != null;
									if (flag102)
									{
										this.Foundyacht = false;
										this.Created = true;
										Function.Call(-7557708654927622093L, new InputArgument[]
										{
											this.Base,
											this.ShipColor
										});
									}
									bool flag103 = this.Base == null;
									if (flag103)
									{
										UI.Notify("Test Case Scenario Failed, Trying Again");
										Prop[] nearbyProps = World.GetNearbyProps(this.YachtPos[this.Location], 50f, this.RequestModel(1338692320));
										bool flag104 = nearbyProps.Length != 0;
										if (flag104)
										{
											foreach (Prop prop in nearbyProps)
											{
												bool flag105 = prop != null;
												if (flag105)
												{
													this.Foundyacht = true;
													this.Created = true;
													this.Base = prop;
													bool flag106 = this.Base != null;
													if (flag106)
													{
														Function.Call(-7557708654927622093L, new InputArgument[]
														{
															this.Base,
															this.ShipColor
														});
													}
												}
											}
										}
										bool flag107 = this.Base == null;
										if (flag107)
										{
											UI.Notify("Test Case Scenario Failed, Trying Again (2)");
											Prop[] nearbyProps2 = World.GetNearbyProps(this.YachtPos[this.Location], 100f);
											bool flag108 = nearbyProps2.Length != 0;
											if (flag108)
											{
												foreach (Prop prop2 in nearbyProps)
												{
													bool flag109 = prop2 != null;
													if (flag109)
													{
														bool flag110 = prop2.Model == this.RequestModel(1338692320);
														if (flag110)
														{
															this.Foundyacht = true;
															this.Created = true;
															this.Base = prop2;
															bool flag111 = this.Base != null;
															if (flag111)
															{
																Function.Call(-7557708654927622093L, new InputArgument[]
																{
																	this.Base,
																	this.ShipColor
																});
															}
														}
													}
												}
											}
										}
									}
									bool flag112 = this.Base == null;
									if (flag112)
									{
										UI.Notify("Test Case Scenario Failed, Yacht Base Could not be found!");
									}
									bool flag113 = this.Base != null;
									if (flag113)
									{
										bool flag114 = this.Base != null;
										if (flag114)
										{
											this.PropYachtBase = this.Base;
											UI.Notify("Test Case Scenario Succeeded");
											this.SpawnYacht();
										}
										this.Foundyacht = true;
										bool flag115 = this.Base != null;
										if (flag115)
										{
											this.ChangeYachtPositions();
											Script.Wait(500);
											bool flag116 = this.MaxHelis != 1;
											if (flag116)
											{
												bool flag117 = this.H1 == 1;
												if (flag117)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosA);
												}
												bool flag118 = this.H1 == 2;
												if (flag118)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosA);
												}
												bool flag119 = this.H1 == 3;
												if (flag119)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosA);
												}
												bool flag120 = this.H1 == 4;
												if (flag120)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosA);
												}
												bool flag121 = this.H1 == 5;
												if (flag121)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosA);
												}
												bool flag122 = this.H1 == 6;
												if (flag122)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosA);
												}
												bool flag123 = this.H2 == 1;
												if (flag123)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosB);
												}
												bool flag124 = this.H2 == 2;
												if (flag124)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosB);
												}
												bool flag125 = this.H2 == 3;
												if (flag125)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosB);
												}
												bool flag126 = this.H2 == 4;
												if (flag126)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosB);
												}
												bool flag127 = this.H2 == 5;
												if (flag127)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosB);
												}
												bool flag128 = this.H2 == 6;
												if (flag128)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosB);
												}
												bool flag129 = this.HeliA != null;
												if (flag129)
												{
													this.HeliA.IsInvincible = true;
													this.HeliA.Position = this.HeliPosA;
													this.HeliA.Rotation = this.Base.Rotation;
													this.HeliA.IsPersistent = true;
													Vector3 rotation = this.HeliA.Rotation;
													this.HeliA.Rotation = new Vector3(rotation.X, rotation.Y, rotation.Z - 90f);
													Script.Wait(25);
													this.HeliA.IsInvincible = false;
												}
												bool flag130 = this.HeliB != null;
												if (flag130)
												{
													this.HeliB.Position = this.HeliPosB;
													this.HeliB.IsInvincible = true;
													this.HeliB.Rotation = this.Base.Rotation;
													Vector3 rotation2 = this.HeliB.Rotation;
													this.HeliB.IsPersistent = true;
													this.HeliB.Rotation = new Vector3(rotation2.X, rotation2.Y, rotation2.Z + 150f);
													Script.Wait(25);
													this.HeliB.IsInvincible = false;
												}
											}
											else
											{
												bool flag131 = this.MaxHelis == 1;
												if (flag131)
												{
													bool flag132 = this.H1 == 1;
													if (flag132)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosA);
													}
													bool flag133 = this.H1 == 2;
													if (flag133)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosA);
													}
													bool flag134 = this.H1 == 3;
													if (flag134)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosA);
													}
													bool flag135 = this.H1 == 4;
													if (flag135)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosA);
													}
													bool flag136 = this.H1 == 5;
													if (flag136)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosA);
													}
													bool flag137 = this.H1 == 6;
													if (flag137)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosA);
													}
													bool flag138 = this.HeliA != null;
													if (flag138)
													{
														this.HeliA.Position = this.HeliPosA;
														this.HeliA.IsInvincible = true;
														this.HeliA.Rotation = this.Base.Rotation;
														this.HeliA.IsPersistent = true;
														Vector3 rotation3 = this.HeliA.Rotation;
														this.HeliA.Rotation = new Vector3(rotation3.X, rotation3.Y, rotation3.Z - 90f);
														Script.Wait(25);
														this.HeliA.IsInvincible = false;
													}
												}
											}
											bool flag139 = this.BoatA != null;
											if (flag139)
											{
												this.BoatA.Delete();
											}
											bool flag140 = this.BoatB != null;
											if (flag140)
											{
												this.BoatB.Delete();
											}
											bool flag141 = this.SeaSharkA != null;
											if (flag141)
											{
												this.SeaSharkA.Delete();
											}
											bool flag142 = this.SeaSharkB != null;
											if (flag142)
											{
												this.SeaSharkB.Delete();
											}
											bool flag143 = this.SeaSharkC != null;
											if (flag143)
											{
												this.SeaSharkC.Delete();
											}
											bool flag144 = this.SeaSharkD != null;
											if (flag144)
											{
												this.SeaSharkD.Delete();
											}
											bool flag145 = this.BoatAType != 0;
											if (flag145)
											{
												bool flag146 = this.BoatAType == 1;
												if (flag146)
												{
													this.BoatA = World.CreateVehicle(231083307, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag147 = this.BoatAType == 2;
												if (flag147)
												{
													this.BoatA = World.CreateVehicle(861409633, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag148 = this.BoatAType == 3;
												if (flag148)
												{
													this.BoatA = World.CreateVehicle(1033245328, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag149 = this.BoatAType == 4;
												if (flag149)
												{
													this.BoatA = World.CreateVehicle(509498602, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag150 = this.BoatAType == 5;
												if (flag150)
												{
													this.BoatA = World.CreateVehicle(1070967343, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag151 = this.BoatAType == 6;
												if (flag151)
												{
													this.BoatA = World.CreateVehicle(908897389, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag152 = this.BoatAType == 7;
												if (flag152)
												{
													this.BoatA = World.CreateVehicle(-1043459709, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
											}
											bool flag153 = this.BoatBType != 0;
											if (flag153)
											{
												bool flag154 = this.BoatBType == 1;
												if (flag154)
												{
													this.BoatB = World.CreateVehicle(231083307, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag155 = this.BoatBType == 2;
												if (flag155)
												{
													this.BoatB = World.CreateVehicle(861409633, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag156 = this.BoatBType == 3;
												if (flag156)
												{
													this.BoatB = World.CreateVehicle(1033245328, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag157 = this.BoatBType == 4;
												if (flag157)
												{
													this.BoatB = World.CreateVehicle(861409633, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag158 = this.BoatBType == 5;
												if (flag158)
												{
													this.BoatB = World.CreateVehicle(1070967343, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag159 = this.BoatBType == 6;
												if (flag159)
												{
													this.BoatB = World.CreateVehicle(908897389, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag160 = this.BoatBType == 7;
												if (flag160)
												{
													this.BoatB = World.CreateVehicle(-1043459709, this.BoatBPos, this.Base.Rotation.Z - 90f);
												}
											}
											bool flag161 = this.AmountOfSeaSharks != 0;
											if (flag161)
											{
												bool flag162 = this.AmountOfSeaSharks >= 1;
												if (flag162)
												{
													this.SeaSharkA = World.CreateVehicle(-1030275036, this.SeaSharkPosA, this.Base.Rotation.Z + 90f);
												}
												bool flag163 = this.AmountOfSeaSharks >= 2;
												if (flag163)
												{
													this.SeaSharkB = World.CreateVehicle(-1030275036, this.SeaSharkPosB, this.Base.Rotation.Z + 90f);
												}
												bool flag164 = this.AmountOfSeaSharks >= 3;
												if (flag164)
												{
													this.SeaSharkC = World.CreateVehicle(-1030275036, this.SeaSharkPosC, this.Base.Rotation.Z + 90f);
												}
												bool flag165 = this.AmountOfSeaSharks >= 4;
												if (flag165)
												{
													this.SeaSharkD = World.CreateVehicle(-1030275036, this.SeaSharkPosD, this.Base.Rotation.Z + 90f);
												}
											}
											bool flag166 = this.BoatA != null;
											if (flag166)
											{
												this.BoatA.FreezePosition = true;
											}
											bool flag167 = this.BoatB != null;
											if (flag167)
											{
												this.BoatB.FreezePosition = true;
											}
											bool flag168 = this.SeaSharkA != null;
											if (flag168)
											{
												this.SeaSharkA.FreezePosition = true;
											}
											bool flag169 = this.SeaSharkB != null;
											if (flag169)
											{
												this.SeaSharkB.FreezePosition = true;
											}
											bool flag170 = this.SeaSharkC != null;
											if (flag170)
											{
												this.SeaSharkC.FreezePosition = true;
											}
											bool flag171 = this.SeaSharkD != null;
											if (flag171)
											{
												this.SeaSharkD.FreezePosition = true;
											}
											this.AddPeds();
											UI.Notify("~b~ Finished Spawning In Yacht~w~");
											bool waitForCreated = this.WaitForCreated;
											if (waitForCreated)
											{
												this.WaitForCreated = false;
												Game.Player.Character.Position = this.YachtPos[this.Location];
												Game.Player.Character.Position = this.ChangeLocMarker;
											}
										}
										bool flag172 = this.Base == null;
										if (flag172)
										{
											UI.Notify("Test Case Scenario Failed");
										}
									}
								}
								bool flag173 = this.Location == 37;
								if (flag173)
								{
									string text7 = this.YachtHashs[this.Location];
									string text8 = this.YachtHashs2[this.Location];
									Function.Call(4734559983020792692L, new InputArgument[]
									{
										text7
									});
									Function.Call(4734559983020792692L, new InputArgument[]
									{
										text8
									});
									Script.Wait(500);
									int num3 = Function.Call<int>(-3292914402564945716L, new InputArgument[]
									{
										"sum_mp_apa_yacht"
									});
									this.Base = Function.Call<Prop>(-2214651566572027031L, new InputArgument[]
									{
										this.YachtPos[this.Location].X,
										this.YachtPos[this.Location].Y,
										this.YachtPos[this.Location].Z,
										25f,
										num3,
										0,
										0,
										0
									});
									bool flag174 = this.Base != null;
									if (flag174)
									{
										this.Foundyacht = false;
										this.Created = true;
										Function.Call(-7557708654927622093L, new InputArgument[]
										{
											this.Base,
											this.ShipColor
										});
									}
									bool flag175 = this.Base == null;
									if (flag175)
									{
										UI.Notify("Test Case Scenario Failed, Trying Again");
										Prop[] nearbyProps3 = World.GetNearbyProps(this.YachtPos[this.Location], 50f, this.RequestModel(1338692320));
										bool flag176 = nearbyProps3.Length != 0;
										if (flag176)
										{
											foreach (Prop prop3 in nearbyProps3)
											{
												bool flag177 = prop3 != null;
												if (flag177)
												{
													this.Foundyacht = true;
													this.Created = true;
													this.Base = prop3;
													bool flag178 = this.Base != null;
													if (flag178)
													{
														Function.Call(-7557708654927622093L, new InputArgument[]
														{
															this.Base,
															this.ShipColor
														});
													}
												}
											}
										}
										bool flag179 = this.Base == null;
										if (flag179)
										{
											UI.Notify("Test Case Scenario Failed, Trying Again (2)");
											Prop[] nearbyProps4 = World.GetNearbyProps(this.YachtPos[this.Location], 100f);
											bool flag180 = nearbyProps4.Length != 0;
											if (flag180)
											{
												foreach (Prop prop4 in nearbyProps3)
												{
													bool flag181 = prop4 != null;
													if (flag181)
													{
														bool flag182 = prop4.Model == this.RequestModel(1338692320);
														if (flag182)
														{
															this.Foundyacht = true;
															this.Created = true;
															this.Base = prop4;
															bool flag183 = this.Base != null;
															if (flag183)
															{
																Function.Call(-7557708654927622093L, new InputArgument[]
																{
																	this.Base,
																	this.ShipColor
																});
															}
														}
													}
												}
											}
										}
									}
									bool flag184 = this.Base == null;
									if (flag184)
									{
										UI.Notify("Test Case Scenario Failed, Yacht Base Could not be found!");
									}
									bool flag185 = this.Base != null;
									if (flag185)
									{
										bool flag186 = this.Base != null;
										if (flag186)
										{
											this.PropYachtBase = this.Base;
											UI.Notify("Test Case Scenario Succeeded");
											this.SpawnYacht();
										}
										this.Foundyacht = true;
										bool flag187 = this.Base != null;
										if (flag187)
										{
											this.ChangeYachtPositions();
											Script.Wait(500);
											bool flag188 = this.MaxHelis != 1;
											if (flag188)
											{
												bool flag189 = this.H1 == 1;
												if (flag189)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosA);
												}
												bool flag190 = this.H1 == 2;
												if (flag190)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosA);
												}
												bool flag191 = this.H1 == 3;
												if (flag191)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosA);
												}
												bool flag192 = this.H1 == 4;
												if (flag192)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosA);
												}
												bool flag193 = this.H1 == 5;
												if (flag193)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosA);
												}
												bool flag194 = this.H1 == 6;
												if (flag194)
												{
													this.HeliA = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosA);
												}
												bool flag195 = this.H2 == 1;
												if (flag195)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosB);
												}
												bool flag196 = this.H2 == 2;
												if (flag196)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosB);
												}
												bool flag197 = this.H2 == 3;
												if (flag197)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosB);
												}
												bool flag198 = this.H2 == 4;
												if (flag198)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosB);
												}
												bool flag199 = this.H2 == 5;
												if (flag199)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosB);
												}
												bool flag200 = this.H2 == 6;
												if (flag200)
												{
													this.HeliB = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosB);
												}
												bool flag201 = this.HeliA != null;
												if (flag201)
												{
													this.HeliA.IsInvincible = true;
													this.HeliA.Position = this.HeliPosA;
													this.HeliA.Rotation = this.Base.Rotation;
													this.HeliA.IsPersistent = true;
													Vector3 rotation4 = this.HeliA.Rotation;
													this.HeliA.Rotation = new Vector3(rotation4.X, rotation4.Y, rotation4.Z - 90f);
													Script.Wait(25);
													this.HeliA.IsInvincible = false;
												}
												bool flag202 = this.HeliB != null;
												if (flag202)
												{
													this.HeliB.Position = this.HeliPosB;
													this.HeliB.IsInvincible = true;
													this.HeliB.Rotation = this.Base.Rotation;
													Vector3 rotation5 = this.HeliB.Rotation;
													this.HeliB.IsPersistent = true;
													this.HeliB.Rotation = new Vector3(rotation5.X, rotation5.Y, rotation5.Z + 150f);
													Script.Wait(25);
													this.HeliB.IsInvincible = false;
												}
											}
											else
											{
												bool flag203 = this.MaxHelis == 1;
												if (flag203)
												{
													bool flag204 = this.H1 == 1;
													if (flag204)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-339587598), this.HeliPosA);
													}
													bool flag205 = this.H1 == 2;
													if (flag205)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1660661558), this.HeliPosA);
													}
													bool flag206 = this.H1 == 3;
													if (flag206)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(710198397), this.HeliPosA);
													}
													bool flag207 = this.H1 == 4;
													if (flag207)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1845487887), this.HeliPosA);
													}
													bool flag208 = this.H1 == 5;
													if (flag208)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(-1671539132), this.HeliPosA);
													}
													bool flag209 = this.H1 == 6;
													if (flag209)
													{
														this.HeliA = World.CreateVehicle(this.RequestModel(1075432268), this.HeliPosA);
													}
													bool flag210 = this.HeliA != null;
													if (flag210)
													{
														this.HeliA.Position = this.HeliPosA;
														this.HeliA.IsInvincible = true;
														this.HeliA.Rotation = this.Base.Rotation;
														this.HeliA.IsPersistent = true;
														Vector3 rotation6 = this.HeliA.Rotation;
														this.HeliA.Rotation = new Vector3(rotation6.X, rotation6.Y, rotation6.Z - 90f);
														Script.Wait(25);
														this.HeliA.IsInvincible = false;
													}
												}
											}
											bool flag211 = this.BoatA != null;
											if (flag211)
											{
												this.BoatA.Delete();
											}
											bool flag212 = this.BoatB != null;
											if (flag212)
											{
												this.BoatB.Delete();
											}
											bool flag213 = this.SeaSharkA != null;
											if (flag213)
											{
												this.SeaSharkA.Delete();
											}
											bool flag214 = this.SeaSharkB != null;
											if (flag214)
											{
												this.SeaSharkB.Delete();
											}
											bool flag215 = this.SeaSharkC != null;
											if (flag215)
											{
												this.SeaSharkC.Delete();
											}
											bool flag216 = this.SeaSharkD != null;
											if (flag216)
											{
												this.SeaSharkD.Delete();
											}
											bool flag217 = this.BoatAType != 0;
											if (flag217)
											{
												bool flag218 = this.BoatAType == 1;
												if (flag218)
												{
													this.BoatA = World.CreateVehicle(231083307, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag219 = this.BoatAType == 2;
												if (flag219)
												{
													this.BoatA = World.CreateVehicle(861409633, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag220 = this.BoatAType == 3;
												if (flag220)
												{
													this.BoatA = World.CreateVehicle(1033245328, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag221 = this.BoatAType == 4;
												if (flag221)
												{
													this.BoatA = World.CreateVehicle(509498602, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag222 = this.BoatAType == 5;
												if (flag222)
												{
													this.BoatA = World.CreateVehicle(1070967343, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag223 = this.BoatAType == 6;
												if (flag223)
												{
													this.BoatA = World.CreateVehicle(908897389, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
												bool flag224 = this.BoatAType == 7;
												if (flag224)
												{
													this.BoatA = World.CreateVehicle(-1043459709, this.BoatAPos, this.Base.Rotation.Z + 90f);
												}
											}
											bool flag225 = this.BoatBType != 0;
											if (flag225)
											{
												bool flag226 = this.BoatBType == 1;
												if (flag226)
												{
													this.BoatB = World.CreateVehicle(231083307, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag227 = this.BoatBType == 2;
												if (flag227)
												{
													this.BoatB = World.CreateVehicle(861409633, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag228 = this.BoatBType == 3;
												if (flag228)
												{
													this.BoatB = World.CreateVehicle(1033245328, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag229 = this.BoatBType == 4;
												if (flag229)
												{
													this.BoatB = World.CreateVehicle(861409633, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag230 = this.BoatBType == 5;
												if (flag230)
												{
													this.BoatB = World.CreateVehicle(1070967343, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag231 = this.BoatBType == 6;
												if (flag231)
												{
													this.BoatB = World.CreateVehicle(908897389, this.BoatBPos, this.Base.Rotation.Z + 90f);
												}
												bool flag232 = this.BoatBType == 7;
												if (flag232)
												{
													this.BoatB = World.CreateVehicle(-1043459709, this.BoatBPos, this.Base.Rotation.Z - 90f);
												}
											}
											bool flag233 = this.AmountOfSeaSharks != 0;
											if (flag233)
											{
												bool flag234 = this.AmountOfSeaSharks >= 1;
												if (flag234)
												{
													this.SeaSharkA = World.CreateVehicle(-1030275036, this.SeaSharkPosA, this.Base.Rotation.Z + 90f);
												}
												bool flag235 = this.AmountOfSeaSharks >= 2;
												if (flag235)
												{
													this.SeaSharkB = World.CreateVehicle(-1030275036, this.SeaSharkPosB, this.Base.Rotation.Z + 90f);
												}
												bool flag236 = this.AmountOfSeaSharks >= 3;
												if (flag236)
												{
													this.SeaSharkC = World.CreateVehicle(-1030275036, this.SeaSharkPosC, this.Base.Rotation.Z + 90f);
												}
												bool flag237 = this.AmountOfSeaSharks >= 4;
												if (flag237)
												{
													this.SeaSharkD = World.CreateVehicle(-1030275036, this.SeaSharkPosD, this.Base.Rotation.Z + 90f);
												}
											}
											bool flag238 = this.BoatA != null;
											if (flag238)
											{
												this.BoatA.FreezePosition = true;
											}
											bool flag239 = this.BoatB != null;
											if (flag239)
											{
												this.BoatB.FreezePosition = true;
											}
											bool flag240 = this.SeaSharkA != null;
											if (flag240)
											{
												this.SeaSharkA.FreezePosition = true;
											}
											bool flag241 = this.SeaSharkB != null;
											if (flag241)
											{
												this.SeaSharkB.FreezePosition = true;
											}
											bool flag242 = this.SeaSharkC != null;
											if (flag242)
											{
												this.SeaSharkC.FreezePosition = true;
											}
											bool flag243 = this.SeaSharkD != null;
											if (flag243)
											{
												this.SeaSharkD.FreezePosition = true;
											}
											this.AddPeds();
											UI.Notify("~b~ Finished Spawning In Yacht~w~");
											bool waitForCreated2 = this.WaitForCreated;
											if (waitForCreated2)
											{
												this.WaitForCreated = false;
												Game.Player.Character.Position = this.YachtPos[this.Location];
												Game.Player.Character.Position = this.ChangeLocMarker;
											}
										}
										bool flag244 = this.Base == null;
										if (flag244)
										{
											UI.Notify("Test Case Scenario Failed");
										}
									}
								}
							}
							catch
							{
								UI.Notify("~r~ Error ~w~ Yacht Failed to Spawn!");
								this.Delete();
								this.Created = false;
							}
						}
					}
				}
				bool flag245 = World.GetDistance(Game.Player.Character.Position, this.YachtPos[this.Location]) >= (float)this.SpawnDist;
				if (flag245)
				{
					bool created3 = this.Created;
					if (created3)
					{
						this.Created = false;
						bool flag246 = this.BoatA != null;
						if (flag246)
						{
							bool flag247 = this.BoatA.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag247)
							{
								this.BoatA.Delete();
							}
							else
							{
								this.BoatA.FreezePosition = false;
								this.BoatA.IsPersistent = false;
								this.BoatA = null;
							}
						}
						bool flag248 = this.BoatB != null;
						if (flag248)
						{
							bool flag249 = this.BoatB.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag249)
							{
								this.BoatB.Delete();
							}
							else
							{
								this.BoatB.FreezePosition = false;
								this.BoatB.IsPersistent = false;
								this.BoatB = null;
							}
						}
						bool flag250 = this.SeaSharkA != null;
						if (flag250)
						{
							bool flag251 = this.SeaSharkA.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag251)
							{
								this.SeaSharkA.Delete();
							}
							else
							{
								this.SeaSharkA.FreezePosition = false;
								this.SeaSharkA.IsPersistent = false;
								this.SeaSharkA = null;
							}
						}
						bool flag252 = this.SeaSharkB != null;
						if (flag252)
						{
							bool flag253 = this.SeaSharkB.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag253)
							{
								this.SeaSharkB.Delete();
							}
							else
							{
								this.SeaSharkB.FreezePosition = false;
								this.SeaSharkB.IsPersistent = false;
								this.SeaSharkB = null;
							}
						}
						bool flag254 = this.SeaSharkC != null;
						if (flag254)
						{
							bool flag255 = this.SeaSharkC.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag255)
							{
								this.SeaSharkC.Delete();
							}
							else
							{
								this.SeaSharkC.FreezePosition = false;
								this.SeaSharkC.IsPersistent = false;
								this.SeaSharkC = null;
							}
						}
						bool flag256 = this.SeaSharkD != null;
						if (flag256)
						{
							bool flag257 = this.HeliA.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag257)
							{
								this.SeaSharkD.Delete();
							}
							else
							{
								this.SeaSharkD.FreezePosition = false;
								this.SeaSharkD.IsPersistent = false;
								this.SeaSharkD = null;
							}
						}
						bool flag258 = this.HeliA != null;
						if (flag258)
						{
							bool flag259 = this.HeliA.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag259)
							{
								this.HeliA.Delete();
							}
							else
							{
								this.HeliA.IsPersistent = false;
								this.HeliA = null;
							}
						}
						bool flag260 = this.HeliB != null;
						if (flag260)
						{
							bool flag261 = this.HeliB.GetPedOnSeat(-1) != Game.Player.Character;
							if (flag261)
							{
								this.HeliB.Delete();
							}
							else
							{
								this.HeliB.IsPersistent = false;
								this.HeliB = null;
							}
						}
						this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
						int location = this.Location;
						int num4;
						for (int m = 1; m < 37; m = num4 + 1)
						{
							foreach (Prop prop5 in this.Props)
							{
								bool flag262 = prop5 != null;
								if (flag262)
								{
									prop5.Delete();
								}
							}
							num4 = m;
						}
					}
				}
			}
			bool flag263 = this.modMenuPool != null;
			if (flag263)
			{
				this.modMenuPool.ProcessMenus();
			}
			bool flag264 = this.WarehouseCam != null;
			if (flag264)
			{
				bool flag265 = this.WCamOn && !this.modMenuPool.IsAnyMenuOpen();
				if (flag265)
				{
					this.WCamOn = false;
					this.modMenuPool.CloseAllMenus();
					this.WarehouseCam.IsActive = false;
					this.WarehouseCam.Destroy();
					Function.Call(569060033405794044L, new InputArgument[]
					{
						0,
						0,
						3000,
						1,
						0
					});
					Game.Player.Character.FreezePosition = false;
					Game.Player.Character.IsVisible = true;
					Game.Player.Character.Position = this.MenuMarker;
				}
			}
			bool flag266 = this.VehicleMissioncar != null;
			if (flag266)
			{
				bool flag267 = World.GetDistance(Game.Player.Character.Position, this.VehicleMissioncar.Position) < 100f;
				if (flag267)
				{
					this.VehicleMissioncar.IsInvincible = false;
				}
			}
			bool flag268 = this.RentedVehicle != null;
			if (flag268)
			{
				bool flag269 = this.startedRent;
				if (flag269)
				{
					bool flag270 = this.RentalvehicleHealth != this.RentedVehicle.Health;
					if (flag270)
					{
						this.RentalvehicleHealth = this.RentedVehicle.Health;
						UI.Notify("Office Assistant : That is a rental!, be more carefull, we get billed each time you damage it! ");
						bool flag271 = Game.Player.Money >= 300;
						if (flag271)
						{
							Player player = Game.Player;
							player.Money -= 300;
						}
					}
					bool flag272 = this.RentTimer != 0;
					if (flag272)
					{
						int num4 = this.RentTimer;
						this.RentTimer = num4 - 1;
					}
					else
					{
						this.startedRent = false;
						UI.Notify("Office Assistant : ok Boss, the Rent for that vehicle has expired");
						this.RentedVehicle.GetPedOnSeat(-1).Task.LeaveVehicle(4096);
						this.RentedVehicle.LockStatus = 2;
					}
				}
			}
			bool flag273 = this.checkforconvoy;
			if (flag273)
			{
				bool flag274 = this.convoysetup == 1 || this.convoysetup == 2 || this.convoysetup == 3;
				if (flag274)
				{
					this.ConvoyBlip1.Position = this.Vehicle1.Position;
					this.ConvoyBlip2.Position = this.Vehicle2.Position;
					this.ConvoyBlip3.Position = this.Vehicle3.Position;
				}
				bool flag275 = this.convoysetup == 1 || this.convoysetup == 2;
				if (flag275)
				{
					bool flag276 = !this.Vehicle1.IsAlive && !this.Vehicle2.IsAlive && !this.Vehicle3.IsAlive;
					if (flag276)
					{
						Game.FadeScreenOut(500);
						Script.Wait(500);
						bool flag277 = this.ConvoyBlip1 != null;
						if (flag277)
						{
							this.ConvoyBlip1.Remove();
						}
						bool flag278 = this.ConvoyBlip2 != null;
						if (flag278)
						{
							this.ConvoyBlip2.Remove();
						}
						bool flag279 = this.ConvoyBlip3 != null;
						if (flag279)
						{
							this.ConvoyBlip3.Remove();
						}
						bool flag280 = this.Vehicle1 != null;
						if (flag280)
						{
							this.Vehicle1.Delete();
						}
						bool flag281 = this.Vehicle2 != null;
						if (flag281)
						{
							this.Vehicle2.Delete();
						}
						bool flag282 = this.Vehicle3 != null;
						if (flag282)
						{
							this.Vehicle3.Delete();
						}
						Script.Wait(500);
						Game.FadeScreenIn(500);
						this.stocksvalue = this.stocksvalue + 750000f + 750000f * this.profitMargin / 100f;
						UI.Notify("Office Assistant: Great convoy Destoryed");
						UI.Notify("Office Assistant: Stocks just Increased");
						this.ShowIncrease();
						this.checkforconvoy = false;
						this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
						this.Config.Save();
					}
				}
				bool flag283 = this.convoysetup == 3;
				if (flag283)
				{
					bool flag284 = !this.Vehicle1.IsAlive && !this.Vehicle2.IsAlive && !this.Vehicle3.IsAlive;
					if (flag284)
					{
						Game.FadeScreenOut(500);
						Script.Wait(500);
						bool flag285 = this.ConvoyBlip1 != null;
						if (flag285)
						{
							this.ConvoyBlip1.Remove();
						}
						bool flag286 = this.ConvoyBlip2 != null;
						if (flag286)
						{
							this.ConvoyBlip2.Remove();
						}
						bool flag287 = this.ConvoyBlip3 != null;
						if (flag287)
						{
							this.ConvoyBlip3.Remove();
						}
						bool flag288 = this.Vehicle1 != null;
						if (flag288)
						{
							this.Vehicle1.Delete();
						}
						bool flag289 = this.Vehicle2 != null;
						if (flag289)
						{
							this.Vehicle2.Delete();
						}
						bool flag290 = this.Vehicle3 != null;
						if (flag290)
						{
							this.Vehicle3.Delete();
						}
						Script.Wait(500);
						Game.FadeScreenIn(500);
						this.stocksvalue = this.stocksvalue + 500000f + 500000f * this.profitMargin / 100f;
						UI.Notify("Office Assistant: Great convoy Destoryed");
						UI.Notify("Office Assistant: Stocks just Increased");
						this.ShowIncrease();
						this.checkforconvoy = false;
						this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
						this.Config.Save();
					}
				}
			}
			bool vehicleSetup = this.VehicleSetup;
			if (vehicleSetup)
			{
				bool flag291 = this.Missionnum == 14;
				if (flag291)
				{
					bool flag292 = !this.GotCar;
					if (flag292)
					{
						bool isAlive = this.VtoGet.IsAlive;
						if (isAlive)
						{
							bool isPlayer = this.VtoGet.GetPedOnSeat(-1).IsPlayer;
							if (isPlayer)
							{
								this.GotCar = true;
								Random random = new Random();
								bool flag293 = random.Next(1, 100) < 20;
								if (flag293)
								{
									this.Dropzone = new Vector3(1737f, 3291f, 41f);
									this.DropzoneBlip = World.CreateBlip(this.Dropzone);
									this.DropzoneBlip.Name = "Drop Zone";
									this.DropzoneBlip.Sprite = 478;
									this.DropzoneBlip.Color = 0;
									this.DropzoneBlip.Name = "Drop Zone";
								}
								bool flag294 = random.Next(1, 100) > 20 && random.Next(1, 100) < 40;
								if (flag294)
								{
									this.Dropzone = new Vector3(141f, 6619f, 31f);
									this.DropzoneBlip = World.CreateBlip(this.Dropzone);
									this.DropzoneBlip.Name = "Drop Zone";
									this.DropzoneBlip.Sprite = 478;
									this.DropzoneBlip.Color = 0;
									this.DropzoneBlip.Name = "Drop Zone";
								}
								bool flag295 = random.Next(1, 100) > 40 && random.Next(1, 100) < 60;
								if (flag295)
								{
									this.Dropzone = new Vector3(2143f, 4801f, 41f);
									this.DropzoneBlip = World.CreateBlip(this.Dropzone);
									this.DropzoneBlip.Name = "Drop Zone";
									this.DropzoneBlip.Sprite = 478;
									this.DropzoneBlip.Color = 0;
									this.DropzoneBlip.Name = "Drop Zone";
								}
								bool flag296 = random.Next(1, 100) > 60 && random.Next(1, 100) < 80;
								if (flag296)
								{
									this.Dropzone = new Vector3(2817f, 1695f, 24f);
									this.DropzoneBlip = World.CreateBlip(this.Dropzone);
									this.DropzoneBlip.Name = "Drop Zone";
									this.DropzoneBlip.Sprite = 478;
									this.DropzoneBlip.Color = 0;
									this.DropzoneBlip.Name = "Drop Zone";
								}
								bool flag297 = random.Next(1, 100) > 80 && random.Next(1, 100) < 100;
								if (flag297)
								{
									this.Dropzone = new Vector3(-1154f, 2674f, 18f);
									this.DropzoneBlip = World.CreateBlip(this.Dropzone);
									this.DropzoneBlip.Name = "Drop Zone";
									this.DropzoneBlip.Sprite = 478;
									this.DropzoneBlip.Color = 0;
									this.DropzoneBlip.Name = "Drop Zone";
								}
								bool flag298 = this.DropzoneBlip != null;
								if (flag298)
								{
									this.DropzoneBlip.ShowRoute = true;
								}
							}
						}
					}
					bool isAlive2 = this.VtoGet.IsAlive;
					if (isAlive2)
					{
						bool isPlayer2 = this.VtoGet.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer2)
						{
							bool flag299 = this.VtoGetBlip != null;
							if (flag299)
							{
								this.VtoGetBlip.Position = this.VtoGet.Position;
							}
							bool isDamaged = this.VtoGet.IsDamaged;
							if (isDamaged)
							{
								this.VehicleisDamaged = true;
							}
							bool flag300 = this.Vehiclehealth != this.VtoGet.Health;
							if (flag300)
							{
								this.Vehiclehealth = this.VtoGet.Health;
								this.stocksvalue = (float)((int)this.stocksvalue - (int)this.stocksvalue / 100);
								UI.Notify("Office Assistant : damaging the Mule, will decrease stock value, value : " + this.stocksvalue.ToString());
							}
							bool flag301 = World.GetDistance(Game.Player.Character.Position, this.Dropzone) < 5f;
							if (flag301)
							{
								bool flag302 = this.VtoGet != null;
								if (flag302)
								{
									this.VtoGet.Delete();
								}
								bool flag303 = this.VtoGetBlip != null;
								if (flag303)
								{
									this.VtoGetBlip.Remove();
								}
								bool flag304 = this.DropzoneBlip != null;
								if (flag304)
								{
									this.DropzoneBlip.Remove();
								}
								this.VehicleSetup = false;
								this.Missionnum = 0;
								Random random2 = new Random();
								this.stocksvalue = (float)((int)this.stocksvalue + (int)this.stocksvalue / random2.Next(5, 10));
								Script.Wait(200);
								Game.Player.Money = Game.Player.Money + (int)this.stocksvalue;
								this.stocksvalue = 0f;
								this.stockscount = 0;
								this.Config.SetValue<int>("Setup", "stockslevel", this.stockscount);
								this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
								this.Config.Save();
								UI.Notify("Office Assistant : ok we got the delivery to the location, there is a little boost in there");
							}
							bool flag305 = World.GetDistance(Game.Player.Character.Position, this.Dropzone) < 5f;
							if (flag305)
							{
								World.DrawMarker(1, this.Dropzone, Vector3.Zero, Vector3.Zero, new Vector3(3f, 3f, 2f), Color.White);
							}
						}
					}
					else
					{
						bool flag306 = this.VtoGet != null;
						if (flag306)
						{
							this.VtoGet.Delete();
						}
						bool flag307 = this.VtoGetBlip != null;
						if (flag307)
						{
							this.VtoGetBlip.Remove();
						}
						bool flag308 = this.DropzoneBlip != null;
						if (flag308)
						{
							this.DropzoneBlip.Remove();
						}
						this.VehicleSetup = false;
						this.Missionnum = 0;
						this.stocksvalue = (float)((int)this.stocksvalue - (int)this.stocksvalue / 2);
						Script.Wait(200);
						UI.Notify("Office Assistant : What were you doing out there we just lost 50% of out stock!");
					}
				}
				bool flag309 = this.Missionnum == 11;
				if (flag309)
				{
					bool isAlive3 = this.VehicleMissioncar.IsAlive;
					if (isAlive3)
					{
						bool isPlayer3 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer3)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
							bool flag310 = !this.TriggeredWanted;
							if (flag310)
							{
								Game.Player.WantedLevel = 4;
								this.TriggeredWanted = true;
							}
						}
						bool flag311 = this.VehicleMissioncar != null;
						if (flag311)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
						}
						bool flag312 = this.warnedplayer;
						if (flag312)
						{
							UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
							this.warnedplayer = false;
						}
						bool isPlayer4 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer4)
						{
							bool flag313 = World.GetDistance(Game.Player.Character.Position, this.Dockloc) < 60f;
							if (flag313)
							{
								bool flag314 = this.DestoryVehicle != null;
								if (flag314)
								{
									this.DestoryVehicle.Remove();
								}
								bool flag315 = this.VehicleMissioncar != null;
								if (flag315)
								{
									this.VehicleMissioncar.IsDriveable = false;
									this.Missionnum = 0;
									Game.FadeScreenOut(300);
									Script.Wait(300);
									this.DestoryVehicle.Remove();
									this.VehicleSetup = false;
									Script.Wait(400);
									this.VehicleMissioncar.Delete();
									Game.Player.Character.Position = this.Dockloc;
									Script.Wait(300);
									Game.FadeScreenIn(300);
								}
								this.stocksvalue = this.stocksvalue + 325000f + 325000f * this.profitMargin / 100f;
								UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
								UI.Notify("Office Assistant: Stocks just Increased");
								this.ShowIncrease();
								this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
								this.Config.Save();
							}
						}
					}
				}
				bool flag316 = this.Missionnum == 10;
				if (flag316)
				{
					bool isAlive4 = this.VehicleMissioncar.IsAlive;
					if (isAlive4)
					{
						bool isPlayer5 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer5)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
							bool flag317 = !this.TriggeredWanted;
							if (flag317)
							{
								Game.Player.WantedLevel = 4;
								this.TriggeredWanted = true;
							}
						}
						bool flag318 = this.VehicleMissioncar != null;
						if (flag318)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
						}
						bool flag319 = this.warnedplayer;
						if (flag319)
						{
							UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
							this.warnedplayer = false;
						}
						bool isPlayer6 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer6)
						{
							bool flag320 = this.DestoryVehicle != null;
							if (flag320)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag321 = this.VehicleMissioncar != null;
							if (flag321)
							{
								this.VehicleMissioncar.IsDriveable = false;
								this.Missionnum = 0;
								Game.FadeScreenOut(300);
								Script.Wait(300);
								this.DestoryVehicle.Remove();
								this.VehicleSetup = false;
								Script.Wait(400);
								this.VehicleMissioncar.Delete();
								Game.Player.Character.Position = this.AircraftStorageLoc;
								Script.Wait(300);
								Game.FadeScreenIn(300);
							}
							this.stocksvalue = this.stocksvalue + 425000f + 425000f * this.profitMargin / 100f;
							UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
					}
				}
				bool flag322 = this.Missionnum == 9;
				if (flag322)
				{
					bool isAlive5 = this.VehicleMissioncar.IsAlive;
					if (isAlive5)
					{
						bool isPlayer7 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer7)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
							bool flag323 = !this.TriggeredWanted;
							if (flag323)
							{
								Game.Player.WantedLevel = 4;
								this.TriggeredWanted = true;
							}
						}
						bool flag324 = this.VehicleMissioncar != null;
						if (flag324)
						{
							this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
						}
						bool flag325 = this.warnedplayer;
						if (flag325)
						{
							UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
							this.warnedplayer = false;
						}
						bool isPlayer8 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
						if (isPlayer8)
						{
							bool flag326 = World.GetDistance(Game.Player.Character.Position, this.LotLoc) < 60f;
							if (flag326)
							{
								bool flag327 = this.DestoryVehicle != null;
								if (flag327)
								{
									this.DestoryVehicle.Remove();
								}
								bool flag328 = this.VehicleMissioncar != null;
								if (flag328)
								{
									this.VehicleMissioncar.IsDriveable = false;
									this.Missionnum = 0;
									Game.FadeScreenOut(300);
									Script.Wait(300);
									this.DestoryVehicle.Remove();
									this.VehicleSetup = false;
									this.VehicleMissioncar.Delete();
									Game.Player.Character.Position = this.LotLoc;
									Script.Wait(300);
									Game.FadeScreenIn(300);
								}
								this.stocksvalue = this.stocksvalue + 225000f + 225000f * this.profitMargin / 100f;
								UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
								UI.Notify("Office Assistant: Stocks just Increased");
								this.ShowIncrease();
								this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
								this.Config.Save();
							}
						}
					}
				}
				bool flag329 = this.Missionnum == 7 || this.Missionnum == 6 || this.Missionnum == 8;
				if (flag329)
				{
					bool flag330 = this.VehicleMissioncar != null;
					if (flag330)
					{
						bool flag331 = World.GetDistance(Game.Player.Character.Position, this.VehicleMissioncar.Position) < 500f;
						if (flag331)
						{
							this.VehicleMissioncar.IsInvincible = false;
							this.VehicleMissioncar.IsVisible = true;
						}
						bool flag332 = World.GetDistance(Game.Player.Character.Position, this.VehicleMissioncar.Position) > 500f;
						if (flag332)
						{
							this.VehicleMissioncar.IsInvincible = true;
							this.VehicleMissioncar.IsVisible = true;
						}
						bool isAlive6 = this.VehicleMissioncar.IsAlive;
						if (isAlive6)
						{
							bool flag333 = this.DestoryVehicle != null && this.VehicleMissioncar != null;
							if (flag333)
							{
								this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
							}
							bool flag334 = this.warnedplayer;
							if (flag334)
							{
								UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
								this.warnedplayer = false;
							}
							bool isPlayer9 = this.VehicleMissioncar.GetPedOnSeat(-1).IsPlayer;
							if (isPlayer9)
							{
								Vector3 vector2 = this.LotLoc;
								bool flag335 = this.Missionnum == 7;
								if (flag335)
								{
									vector2 = this.LotLoc;
								}
								bool flag336 = this.Missionnum == 6;
								if (flag336)
								{
									vector2 = this.AircraftStorageLoc;
								}
								bool flag337 = this.Missionnum == 8;
								if (flag337)
								{
									vector2 = this.Dockloc;
								}
								bool flag338 = World.GetDistance(Game.Player.Character.Position, vector2) < 60f;
								if (flag338)
								{
									bool flag339 = this.DestoryVehicle != null;
									if (flag339)
									{
										this.DestoryVehicle.Remove();
									}
									bool flag340 = this.VehicleMissioncar != null;
									if (flag340)
									{
										this.VehicleMissioncar.IsDriveable = false;
										Game.FadeScreenOut(300);
										Script.Wait(300);
										this.VehicleSetup = false;
										this.VehicleMissioncar.Delete();
										Game.Player.Character.Position = vector2;
										Script.Wait(300);
										Game.FadeScreenIn(300);
									}
									this.stocksvalue = this.stocksvalue + 25000f + 25000f * this.profitMargin / 100f;
									UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
									UI.Notify("Office Assistant: Stocks just Increased");
									this.ShowIncrease();
									this.VehicleSetup = false;
									this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
									this.Config.Save();
								}
							}
						}
						else
						{
							bool flag341 = this.DestoryVehicle != null;
							if (flag341)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag342 = this.VehicleMissioncar != null;
							if (flag342)
							{
								this.VehicleMissioncar.IsDriveable = false;
								Game.FadeScreenOut(300);
								Script.Wait(300);
								this.VehicleSetup = false;
								this.VehicleMissioncar.Delete();
								Script.Wait(300);
								Game.FadeScreenIn(300);
							}
							UI.Notify("Office Assistant: We lost the vehicle!, we will have to find another one! ");
							this.ShowIncrease();
							this.VehicleSetup = false;
						}
					}
				}
				bool flag343 = this.Missionnum == 5;
				if (flag343)
				{
					bool flag344 = this.VehicleMissioncar != null;
					if (flag344)
					{
						this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
					}
				}
				bool flag345 = this.Missionnum == 5;
				if (flag345)
				{
					bool flag346 = this.VehicleMissioncar != null;
					if (flag346)
					{
						bool flag347 = World.GetDistance(Game.Player.Character.Position, this.VehicleMissioncar.Position) < 500f;
						if (flag347)
						{
							this.VehicleMissioncar.IsInvincible = false;
							this.VehicleMissioncar.IsVisible = true;
						}
					}
				}
				bool flag348 = this.Missionnum == 2 || this.Missionnum == 3;
				if (flag348)
				{
					this.DestoryVehicle.Position = this.VehicleMissioncar.Position;
				}
				bool flag349 = this.VehicleMissioncar != null;
				if (flag349)
				{
					bool flag350 = !this.VehicleMissioncar.IsAlive;
					if (flag350)
					{
						bool flag351 = this.Missionnum == 11;
						if (flag351)
						{
							bool flag352 = this.DestoryVehicle != null;
							if (flag352)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag353 = this.VehicleMissioncar != null;
							if (flag353)
							{
								this.VehicleMissioncar.Delete();
							}
							Game.FadeScreenOut(500);
							Script.Wait(500);
							Script.Wait(500);
							Game.FadeScreenIn(500);
							UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag354 = this.Missionnum == 10;
						if (flag354)
						{
							bool flag355 = this.DestoryVehicle != null;
							if (flag355)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag356 = this.VehicleMissioncar != null;
							if (flag356)
							{
								this.VehicleMissioncar.Delete();
							}
							Game.FadeScreenOut(500);
							Script.Wait(500);
							Script.Wait(500);
							Game.FadeScreenIn(500);
							UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag357 = this.Missionnum == 9;
						if (flag357)
						{
							bool flag358 = this.DestoryVehicle != null;
							if (flag358)
							{
								this.DestoryVehicle.Remove();
							}
							Game.FadeScreenOut(500);
							Script.Wait(500);
							this.VehicleMissioncar.Delete();
							Script.Wait(500);
							Game.FadeScreenIn(500);
							UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag359 = this.Missionnum == 5;
						if (flag359)
						{
							bool flag360 = this.DestoryVehicle != null;
							if (flag360)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag361 = this.VehicleMissioncar != null;
							if (flag361)
							{
								this.VehicleMissioncar.Delete();
							}
							this.stocksvalue = this.stocksvalue + 125000f + 125000f * this.profitMargin / 100f;
							UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag362 = this.Missionnum == 4;
						if (flag362)
						{
							bool flag363 = this.DestoryVehicle != null;
							if (flag363)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag364 = this.VehicleMissioncar != null;
							if (flag364)
							{
								this.VehicleMissioncar.Delete();
							}
							this.stocksvalue = this.stocksvalue + 75000f + 75000f * this.profitMargin / 100f;
							UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag365 = this.Missionnum == 3;
						if (flag365)
						{
							bool flag366 = this.DestoryVehicle != null;
							if (flag366)
							{
								this.DestoryVehicle.Remove();
							}
							this.stocksvalue = this.stocksvalue + 50000f + 50000f * this.profitMargin / 100f;
							bool flag367 = this.VehicleMissioncar != null;
							if (flag367)
							{
								this.VehicleMissioncar.Delete();
							}
							UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag368 = this.Missionnum == 1;
						if (flag368)
						{
							bool flag369 = this.DestoryVehicle != null;
							if (flag369)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag370 = this.VehicleMissioncar != null;
							if (flag370)
							{
								this.VehicleMissioncar.Delete();
							}
							this.stocksvalue = this.stocksvalue + 25000f + 25000f * this.profitMargin / 100f;
							UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
						bool flag371 = this.Missionnum == 2;
						if (flag371)
						{
							bool flag372 = this.DestoryVehicle != null;
							if (flag372)
							{
								this.DestoryVehicle.Remove();
							}
							bool flag373 = this.VehicleMissioncar != null;
							if (flag373)
							{
								this.VehicleMissioncar.Delete();
							}
							this.stocksvalue = this.stocksvalue + 25000f + 25000f * this.profitMargin / 100f;
							UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
							UI.Notify("Office Assistant: Stocks just Increased");
							this.ShowIncrease();
							this.VehicleSetup = false;
							this.Config.SetValue<float>("Setup", "StocksValue", this.stocksvalue);
							this.Config.Save();
						}
					}
				}
			}
			bool sourcingCheckingforDamage = this.SourcingCheckingforDamage;
			if (sourcingCheckingforDamage)
			{
				bool newVehicleSourcing = this.NewVehicleSourcing;
				if (newVehicleSourcing)
				{
					bool flag374 = Game.Player.Character.CurrentVehicle != null;
					if (flag374)
					{
						bool flag375 = Game.Player.Character.CurrentVehicle.DisplayName == this.SourcedVehicle;
						if (flag375)
						{
							this.Vehicletoget = Game.Player.Character.CurrentVehicle;
						}
					}
				}
				bool flag376 = this.Vehicletoget != null;
				if (flag376)
				{
					bool isDamaged2 = this.Vehicletoget.IsDamaged;
					if (isDamaged2)
					{
						this.SourcingCheckingforDamage = false;
						UI.Notify("Office Assistant: Be Carefull the Vehice is already damaged ");
					}
				}
			}
			bool flag377 = this.foundvehicleyet && !this.NewVehicleSourcing;
			if (flag377)
			{
				this.Vehicleloc = this.Vehicletoget.Position;
				bool flag378 = this.VehicleMarker != null;
				if (flag378)
				{
					this.VehicleMarker.Position = this.Vehicletoget.Position;
				}
				bool flag379 = this.Vehicletoget.GetPedOnSeat(-1).IsPlayer && this.foundvehicleyet;
				if (flag379)
				{
					this.foundvehicleyet = true;
					this.Vehicletoget.IsDriveable = true;
					UI.Notify("Office Assistant: Boss that is the car we need, bring it back to the vehicle warehouse to sell it");
					this.foundvehicleyet = false;
					this.hasgotvehicle = true;
				}
			}
			bool flag380 = this.foundvehicleyet && this.NewVehicleSourcing;
			if (flag380)
			{
				bool flag381 = Game.Player.Character.CurrentVehicle != null;
				if (flag381)
				{
					bool flag382 = Game.Player.Character.CurrentVehicle.DisplayName == this.SourcedVehicle;
					if (flag382)
					{
						this.Vehicletoget = Game.Player.Character.CurrentVehicle;
						bool flag383 = this.Vehicletoget.GetPedOnSeat(-1).IsPlayer && this.foundvehicleyet;
						if (flag383)
						{
							this.foundvehicleyet = true;
							this.Vehicletoget.IsDriveable = true;
							UI.Notify("Office Assistant: Boss that is the car we need, bring it back to the vehicle warehouse to sell it");
							this.foundvehicleyet = false;
							this.hasgotvehicle = true;
						}
					}
				}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0001C604 File Offset: 0x0001A804
		public void ChangeYachtPositions()
		{
			this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
			bool flag = this.Base != null;
			if (flag)
			{
				this.MenuMarker = this.Base.GetOffsetInWorldCoords(this.MenuOffset);
				this.ChangeLocMarker = this.Base.GetOffsetInWorldCoords(this.CaptComputerOffset);
				this.SleepPos1 = new Vector3(0f, 0f, 0f);
				this.SleepPos2 = new Vector3(0f, 0f, 0f);
				bool flag2 = this.YachtType == 0;
				if (flag2)
				{
					this.HeliPadAOffset = new Vector3(-51.5f, -1.999345f, 3f);
					this.HeliPadBOffset = new Vector3(-37.78258f, -1.999345f, -0.5f);
					this.MaxHelis = 1;
					this.HeliPosA = this.Base.GetOffsetInWorldCoords(this.HeliPadAOffset);
					this.HeliPosB = new Vector3(0f, 0f, 0f);
				}
				bool flag3 = this.YachtType == 1;
				if (flag3)
				{
					this.HeliPadAOffset = new Vector3(-29.5f, -1.999345f, 6f);
					this.HeliPadBOffset = new Vector3(36f, -1.999345f, 4.5f);
					this.MaxHelis = 2;
					this.HeliPosA = this.Base.GetOffsetInWorldCoords(this.HeliPadAOffset);
					this.HeliPosB = this.Base.GetOffsetInWorldCoords(this.HeliPadBOffset);
				}
				bool flag4 = this.YachtType == 2;
				if (flag4)
				{
					this.HeliPadAOffset = new Vector3(-29.5f, -1.999345f, 6f);
					this.HeliPadBOffset = new Vector3(36f, -1.999345f, 4.5f);
					this.MaxHelis = 2;
					this.HeliPosA = this.Base.GetOffsetInWorldCoords(this.HeliPadAOffset);
					this.HeliPosB = this.Base.GetOffsetInWorldCoords(this.HeliPadBOffset);
				}
				Vector3 vector;
				vector..ctor(-49f, -1.999345f, -1.1f);
				this.jacuzziSeat1 = this.Base.GetOffsetInWorldCoords(vector);
				Vector3 vector2;
				vector2..ctor(-50f, -4f, -1.1f);
				this.jacuzziSeat2 = this.Base.GetOffsetInWorldCoords(vector2);
				Vector3 vector3;
				vector3..ctor(-50f, 0f, -1.1f);
				this.jacuzziSeat3 = this.Base.GetOffsetInWorldCoords(vector3);
				Vector3 vector4;
				vector4..ctor(-52f, 0f, -1.1f);
				this.jacuzziSeat4 = this.Base.GetOffsetInWorldCoords(vector4);
				Vector3 vector5;
				vector5..ctor(-52f, -4f, -1.1f);
				this.jacuzziSeat5 = this.Base.GetOffsetInWorldCoords(vector5);
				Vector3 vector6;
				vector6..ctor(-53f, -1.999345f, -1.1f);
				this.jacuzziSeat6 = this.Base.GetOffsetInWorldCoords(vector6);
				Vector3 vector7;
				vector7..ctor(27f, -4f, 0f);
				this.Bed1 = this.Base.GetOffsetInWorldCoords(vector7);
				Vector3 vector8;
				vector8..ctor(19f, -6.5f, 0f);
				this.Bed2 = this.Base.GetOffsetInWorldCoords(vector8);
				Vector3 vector9;
				vector9..ctor(0f, -2f, 0f);
				this.Bed3 = this.Base.GetOffsetInWorldCoords(vector9);
				Vector3 vector10;
				vector10..ctor(23.2f, -2.026101f, 2.5f);
				this.BarPos = this.Base.GetOffsetInWorldCoords(vector10);
				Vector3 vector11;
				vector11..ctor(21.66955f, -2.026101f, 2.5f);
				this.BarDrinkPos = this.Base.GetOffsetInWorldCoords(vector11);
				Vector3 vector12;
				vector12..ctor(31.5f, -6.5f, -0.5f);
				Vector3 vector13;
				vector13..ctor(30.5f, -7.5f, -0.5f);
				this.ShowerAPos = this.Base.GetOffsetInWorldCoords(vector12);
				this.ShowerAPosEnter = this.Base.GetOffsetInWorldCoords(vector13);
				Vector3 vector14;
				vector14..ctor(20.5f, 0.2f, -0.5f);
				Vector3 vector15;
				vector15..ctor(19.5f, -1f, -0.5f);
				this.ShowerBPos = this.Base.GetOffsetInWorldCoords(vector14);
				this.ShowerBPosEnter = this.Base.GetOffsetInWorldCoords(vector15);
				Vector3 vector16;
				vector16..ctor(8.5f, -1f, -0.5f);
				Vector3 vector17;
				vector17..ctor(7f, -2.026101f, -0.5f);
				this.ShowerCPos = this.Base.GetOffsetInWorldCoords(vector16);
				this.ShowerCPosEnter = this.Base.GetOffsetInWorldCoords(vector17);
				this.BarEnter = this.Base.GetOffsetInWorldCoords(this.BackEntranceOffset);
				this.BarExit = this.Base.GetOffsetInWorldCoords(this.BackIntOffset);
				this.CaptinsQuartersEnter = this.Base.GetOffsetInWorldCoords(this.CaptEntranceOffset);
				this.CaptinsQuartersExit = this.Base.GetOffsetInWorldCoords(this.CaptIntOffset);
				Vector3 vector18;
				vector18..ctor(-62f, 1f, -5.6f);
				this.SeaSharkPosA = this.Base.GetOffsetInWorldCoords(vector18);
				Vector3 vector19;
				vector19..ctor(-62f, -1f, -5.6f);
				this.SeaSharkPosB = this.Base.GetOffsetInWorldCoords(vector19);
				Vector3 vector20;
				vector20..ctor(-62f, -3f, -5.6f);
				this.SeaSharkPosC = this.Base.GetOffsetInWorldCoords(vector20);
				Vector3 vector21;
				vector21..ctor(-62f, -5f, -5.6f);
				this.SeaSharkPosD = this.Base.GetOffsetInWorldCoords(vector21);
				Vector3 vector22;
				vector22..ctor(-58f, -12f, -5.6f);
				this.BoatAPos = this.Base.GetOffsetInWorldCoords(vector22);
				Vector3 vector23;
				vector23..ctor(-58f, 8f, -5.6f);
				this.BoatBPos = this.Base.GetOffsetInWorldCoords(vector23);
				this.ChangeLocMarker = this.Base.GetOffsetInWorldCoords(this.CaptComputerOffset);
				Vector3 vector24;
				vector24..ctor(23f, -4f, -0.5f);
				this.WoredrobeAPos = this.Base.GetOffsetInWorldCoords(vector24);
				Vector3 vector25;
				vector25..ctor(17f, -6f, -0.5f);
				this.WoredrobeBPos = this.Base.GetOffsetInWorldCoords(vector25);
				Vector3 vector26;
				vector26..ctor(-1f, -6f, -0.5f);
				this.WoredrobeCPos = this.Base.GetOffsetInWorldCoords(vector26);
				bool flag5 = this.FlagA != null;
				if (flag5)
				{
					this.FlagA.Delete();
				}
				bool flag6 = this.FlagB != null;
				if (flag6)
				{
					this.FlagB.Delete();
				}
				bool flag7 = this.FlagC != null;
				if (flag7)
				{
					this.FlagC.Delete();
				}
				bool flag8 = this.DoorC != null;
				if (flag8)
				{
					this.DoorC.Delete();
				}
				bool flag9 = this.DoorB != null;
				if (flag9)
				{
					this.DoorB.Delete();
				}
				bool flag10 = this.Bargirl != null;
				if (flag10)
				{
					this.Bargirl.Delete();
				}
				bool flag11 = this.DoorType == 0 && this.Base != null;
				if (flag11)
				{
					this.SpawnDoor("apa_mp_apa_yacht_door", this.Base.GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0f, 0f, this.Base.Rotation.Z - 90f), 4);
					this.SpawnDoor("apa_mp_apa_yacht_door", this.Base.GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0f, 0f, this.Base.Rotation.Z - 90f), 5);
				}
				bool flag12 = this.DoorType == 1 && this.Base != null;
				if (flag12)
				{
					this.SpawnDoor("apa_mp_apa_yacht_door2", this.Base.GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0f, 0f, this.Base.Rotation.Z - 90f), 4);
					this.SpawnDoor("apa_mp_apa_yacht_door2", this.Base.GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0f, 0f, this.Base.Rotation.Z - 90f), 5);
				}
				bool flag13 = this.CurrentFlag != 0;
				if (flag13)
				{
					this.SpawnFlagA(this.FlagList[this.CurrentFlag], this.Base.GetOffsetInWorldCoords(new Vector3(-3f, -0.45f, 9.8f)), new Vector3(0f, -50f, this.Base.Rotation.Z + 0f), 5);
					this.SpawnFlagB(this.FlagList[this.CurrentFlag], this.Base.GetOffsetInWorldCoords(new Vector3(-3f, -3.55f, 9.8f)), new Vector3(0f, -50f, this.Base.Rotation.Z + 0f), 5);
					this.SpawnFlagC(this.FlagList[this.CurrentFlag], this.Base.GetOffsetInWorldCoords(new Vector3(-56.5f, -1.996299f, 0.5f)), new Vector3(0f, -50f, this.Base.Rotation.Z - 0f), 5);
				}
				bool flag14 = this.DoorB != null;
				if (flag14)
				{
					this.DoorB.Detach();
					this.DoorB.AttachTo(this.Base, 0, new Vector3(0f, -3.3f, 6.6f), new Vector3(0f, 0f, 90f));
					this.DoorB.HasCollision = true;
					this.Props.Add(this.DoorB);
					Function.Call(-7557708654927622093L, new InputArgument[]
					{
						this.DoorB,
						this.ShipColor
					});
				}
				Script.Wait(1);
				bool flag15 = this.DoorC != null;
				if (flag15)
				{
					this.DoorC.Detach();
					this.DoorC.AttachTo(this.Base, 0, new Vector3(0f, -0.6f, 6.6f), new Vector3(0f, 0f, -90f));
					this.DoorC.HasCollision = true;
					this.Props.Add(this.DoorC);
					Function.Call(-7557708654927622093L, new InputArgument[]
					{
						this.DoorC,
						this.ShipColor
					});
				}
				this.RadioPos.Clear();
				Vector3 vector27;
				vector27..ctor(27.5f, -8f, -0.5f);
				this.RadioPos.Add(this.Base.GetOffsetInWorldCoords(vector27));
				Vector3 vector28;
				vector28..ctor(12f, -1f, -0.5f);
				this.RadioPos.Add(this.Base.GetOffsetInWorldCoords(vector28));
				Vector3 vector29;
				vector29..ctor(4.5f, -1.5f, -0.5f);
				this.RadioPos.Add(this.Base.GetOffsetInWorldCoords(vector29));
				Vector3 vector30;
				vector30..ctor(3f, -2.2f, 2.8f);
				this.RadioPos.Add(this.Base.GetOffsetInWorldCoords(vector30));
				Vector3 vector31;
				vector31..ctor(5.2f, -4.1f, 2.8f);
				this.RadioPos.Add(this.Base.GetOffsetInWorldCoords(vector31));
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0001D270 File Offset: 0x0001B470
		public Vector3 GetYachtRotation(int ID)
		{
			Vector3 result = default(Vector3);
			bool flag = ID == 1;
			if (flag)
			{
				result = default(Vector3);
			}
			bool flag2 = ID == 2;
			if (flag2)
			{
				result = default(Vector3);
			}
			bool flag3 = ID == 3;
			if (flag3)
			{
				result = default(Vector3);
			}
			bool flag4 = ID == 4;
			if (flag4)
			{
				result = default(Vector3);
			}
			bool flag5 = ID == 5;
			if (flag5)
			{
				result = default(Vector3);
			}
			bool flag6 = ID == 6;
			if (flag6)
			{
				result = default(Vector3);
			}
			bool flag7 = ID == 7;
			if (flag7)
			{
				result = default(Vector3);
			}
			bool flag8 = ID == 8;
			if (flag8)
			{
				result = default(Vector3);
			}
			bool flag9 = ID == 9;
			if (flag9)
			{
				result = default(Vector3);
			}
			bool flag10 = ID == 10;
			if (flag10)
			{
				result = default(Vector3);
			}
			bool flag11 = ID == 11;
			if (flag11)
			{
				result = default(Vector3);
			}
			bool flag12 = ID == 12;
			if (flag12)
			{
				result = default(Vector3);
			}
			bool flag13 = ID == 13;
			if (flag13)
			{
				result = default(Vector3);
			}
			bool flag14 = ID == 14;
			if (flag14)
			{
				result = default(Vector3);
			}
			bool flag15 = ID == 15;
			if (flag15)
			{
				result = default(Vector3);
			}
			bool flag16 = ID == 16;
			if (flag16)
			{
				result = default(Vector3);
			}
			bool flag17 = ID == 17;
			if (flag17)
			{
				result = default(Vector3);
			}
			bool flag18 = ID == 18;
			if (flag18)
			{
				result = default(Vector3);
			}
			bool flag19 = ID == 19;
			if (flag19)
			{
				result = default(Vector3);
			}
			bool flag20 = ID == 20;
			if (flag20)
			{
				result = default(Vector3);
			}
			bool flag21 = ID == 21;
			if (flag21)
			{
				result = default(Vector3);
			}
			bool flag22 = ID == 22;
			if (flag22)
			{
				result = default(Vector3);
			}
			bool flag23 = ID == 23;
			if (flag23)
			{
				result = default(Vector3);
			}
			bool flag24 = ID == 24;
			if (flag24)
			{
				result = default(Vector3);
			}
			bool flag25 = ID == 25;
			if (flag25)
			{
				result = default(Vector3);
			}
			bool flag26 = ID == 26;
			if (flag26)
			{
				result = default(Vector3);
			}
			bool flag27 = ID == 27;
			if (flag27)
			{
				result = default(Vector3);
			}
			bool flag28 = ID == 28;
			if (flag28)
			{
				result = default(Vector3);
			}
			bool flag29 = ID == 29;
			if (flag29)
			{
				result = default(Vector3);
			}
			bool flag30 = ID == 30;
			if (flag30)
			{
				result = default(Vector3);
			}
			bool flag31 = ID == 31;
			if (flag31)
			{
				result = default(Vector3);
			}
			bool flag32 = ID == 32;
			if (flag32)
			{
				result = default(Vector3);
			}
			bool flag33 = ID == 33;
			if (flag33)
			{
				result = default(Vector3);
			}
			bool flag34 = ID == 34;
			if (flag34)
			{
				result = default(Vector3);
			}
			bool flag35 = ID == 35;
			if (flag35)
			{
				result = default(Vector3);
			}
			bool flag36 = ID == 36;
			if (flag36)
			{
				result = default(Vector3);
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0001D574 File Offset: 0x0001B774
		public Vector3 GetYachtIPLPosition(int ID)
		{
			Vector3 result = default(Vector3);
			bool flag = ID == 1;
			if (flag)
			{
				result = default(Vector3);
			}
			bool flag2 = ID == 2;
			if (flag2)
			{
				result = default(Vector3);
			}
			bool flag3 = ID == 3;
			if (flag3)
			{
				result = default(Vector3);
			}
			bool flag4 = ID == 4;
			if (flag4)
			{
				result = default(Vector3);
			}
			bool flag5 = ID == 5;
			if (flag5)
			{
				result = default(Vector3);
			}
			bool flag6 = ID == 6;
			if (flag6)
			{
				result = default(Vector3);
			}
			bool flag7 = ID == 7;
			if (flag7)
			{
				result = default(Vector3);
			}
			bool flag8 = ID == 8;
			if (flag8)
			{
				result = default(Vector3);
			}
			bool flag9 = ID == 9;
			if (flag9)
			{
				result = default(Vector3);
			}
			bool flag10 = ID == 10;
			if (flag10)
			{
				result = default(Vector3);
			}
			bool flag11 = ID == 11;
			if (flag11)
			{
				result = default(Vector3);
			}
			bool flag12 = ID == 12;
			if (flag12)
			{
				result = default(Vector3);
			}
			bool flag13 = ID == 13;
			if (flag13)
			{
				result = default(Vector3);
			}
			bool flag14 = ID == 14;
			if (flag14)
			{
				result = default(Vector3);
			}
			bool flag15 = ID == 15;
			if (flag15)
			{
				result = default(Vector3);
			}
			bool flag16 = ID == 16;
			if (flag16)
			{
				result = default(Vector3);
			}
			bool flag17 = ID == 17;
			if (flag17)
			{
				result = default(Vector3);
			}
			bool flag18 = ID == 18;
			if (flag18)
			{
				result = default(Vector3);
			}
			bool flag19 = ID == 19;
			if (flag19)
			{
				result = default(Vector3);
			}
			bool flag20 = ID == 20;
			if (flag20)
			{
				result = default(Vector3);
			}
			bool flag21 = ID == 21;
			if (flag21)
			{
				result = default(Vector3);
			}
			bool flag22 = ID == 22;
			if (flag22)
			{
				result = default(Vector3);
			}
			bool flag23 = ID == 23;
			if (flag23)
			{
				result = default(Vector3);
			}
			bool flag24 = ID == 24;
			if (flag24)
			{
				result = default(Vector3);
			}
			bool flag25 = ID == 25;
			if (flag25)
			{
				result = default(Vector3);
			}
			bool flag26 = ID == 26;
			if (flag26)
			{
				result = default(Vector3);
			}
			bool flag27 = ID == 27;
			if (flag27)
			{
				result = default(Vector3);
			}
			bool flag28 = ID == 28;
			if (flag28)
			{
				result = default(Vector3);
			}
			bool flag29 = ID == 29;
			if (flag29)
			{
				result = default(Vector3);
			}
			bool flag30 = ID == 30;
			if (flag30)
			{
				result = default(Vector3);
			}
			bool flag31 = ID == 31;
			if (flag31)
			{
				result = default(Vector3);
			}
			bool flag32 = ID == 32;
			if (flag32)
			{
				result = default(Vector3);
			}
			bool flag33 = ID == 33;
			if (flag33)
			{
				result = default(Vector3);
			}
			bool flag34 = ID == 34;
			if (flag34)
			{
				result = default(Vector3);
			}
			bool flag35 = ID == 35;
			if (flag35)
			{
				result = default(Vector3);
			}
			bool flag36 = ID == 36;
			if (flag36)
			{
				result = default(Vector3);
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0001D878 File Offset: 0x0001BA78
		public void SpawnYacht()
		{
			try
			{
				bool flag = this.Base2 != null;
				if (flag)
				{
					this.Base2.Delete();
				}
				this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
				for (int i = 1; i < 37; i++)
				{
					bool flag2 = i != this.Location;
					if (flag2)
					{
						foreach (Prop prop in this.Props)
						{
							bool flag3 = prop != null;
							if (flag3)
							{
								prop.Delete();
							}
						}
					}
				}
				string text = this.YachtHashs[this.Location];
				string text2 = this.YachtHashs2[this.Location];
				int location = this.Location;
				bool flag4 = this.Location > 0 && this.Location < 38;
				if (flag4)
				{
					bool flag5 = this.YachtType == 0;
					if (flag5)
					{
						bool flag6 = !this.GoldRails;
						if (flag6)
						{
							this.Rail = "apa_mp_apa_yacht_o1_rail_a";
						}
						else
						{
							bool goldRails = this.GoldRails;
							if (goldRails)
							{
								this.Rail = "apa_mp_apa_yacht_o1_rail_b";
							}
						}
						this.Rail = "apa_MP_Apa_Yacht_O1_Rail_B";
						this.YachtTop = "apa_mp_apa_yacht_option1";
						this.YachtLauncher = "apa_mp_apa_yacht_launcher_01a";
					}
					bool flag7 = this.YachtType == 1;
					if (flag7)
					{
						bool flag8 = !this.GoldRails;
						if (flag8)
						{
							this.Rail = "apa_mp_apa_yacht_o2_rail_a";
						}
						else
						{
							bool goldRails2 = this.GoldRails;
							if (goldRails2)
							{
								this.Rail = "apa_mp_apa_yacht_o2_rail_b";
							}
						}
						this.YachtTop = "apa_mp_apa_yacht_option2";
						this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
					}
					bool flag9 = this.YachtType == 2;
					if (flag9)
					{
						bool flag10 = !this.GoldRails;
						if (flag10)
						{
							this.Rail = "apa_mp_apa_yacht_o3_rail_a";
						}
						else
						{
							bool goldRails3 = this.GoldRails;
							if (goldRails3)
							{
								this.Rail = "apa_mp_apa_yacht_o3_rail_b";
							}
						}
						this.YachtTop = "apa_mp_apa_yacht_option3";
						this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
					}
					bool flag11 = this.Base != null;
					if (flag11)
					{
						UI.Notify("~b~ Starting Yacht Spawning, please be patient");
						this.SpawnProp(this.YachtTop, this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 1);
						this.SpawnProp(this.Rail, this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 2);
						bool flag12 = this.YachtType == 0;
						if (flag12)
						{
							bool flag13 = this.Lighting == 1;
							if (flag13)
							{
								bool flag14 = this.LightingColor == 1;
								if (flag14)
								{
									this.SpawnProp("apa_mp_apa_y1_l1a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag15 = this.LightingColor == 2;
								if (flag15)
								{
									this.SpawnProp("apa_mp_apa_y1_l1b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag16 = this.LightingColor == 3;
								if (flag16)
								{
									this.SpawnProp("apa_mp_apa_y1_l1c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag17 = this.LightingColor == 4;
								if (flag17)
								{
									this.SpawnProp("apa_mp_apa_y1_l1d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag18 = this.Lighting == 2;
							if (flag18)
							{
								bool flag19 = this.LightingColor == 1;
								if (flag19)
								{
									this.SpawnProp("apa_mp_apa_y1_l2a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag20 = this.LightingColor == 2;
								if (flag20)
								{
									this.SpawnProp("apa_mp_apa_y1_l2b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag21 = this.LightingColor == 3;
								if (flag21)
								{
									this.SpawnProp("apa_mp_apa_y1_l2c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag22 = this.LightingColor == 4;
								if (flag22)
								{
									this.SpawnProp("apa_mp_apa_y1_l2d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag23 = this.DoorType == 0;
							if (flag23)
							{
								this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							bool flag24 = this.DoorType == 1;
							if (flag24)
							{
								this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
						}
						bool flag25 = this.YachtType == 1;
						if (flag25)
						{
							this.SpawnProp("apa_mp_apa_yacht_option2_cola", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 1);
							this.SpawnProp("apa_mp_apa_yacht_option2_colb", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 2);
							bool flag26 = this.Lighting == 1;
							if (flag26)
							{
								bool flag27 = this.LightingColor == 1;
								if (flag27)
								{
									this.SpawnProp("apa_mp_apa_y2_l1a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag28 = this.LightingColor == 2;
								if (flag28)
								{
									this.SpawnProp("apa_mp_apa_y2_l1b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag29 = this.LightingColor == 3;
								if (flag29)
								{
									this.SpawnProp("apa_mp_apa_y2_l1c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag30 = this.LightingColor == 4;
								if (flag30)
								{
									this.SpawnProp("apa_mp_apa_y2_l1d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag31 = this.Lighting == 2;
							if (flag31)
							{
								bool flag32 = this.LightingColor == 1;
								if (flag32)
								{
									this.SpawnProp("apa_mp_apa_y2_l2a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag33 = this.LightingColor == 2;
								if (flag33)
								{
									this.SpawnProp("apa_mp_apa_y2_l2b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag34 = this.LightingColor == 3;
								if (flag34)
								{
									this.SpawnProp("apa_mp_apa_y2_l2c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag35 = this.LightingColor == 4;
								if (flag35)
								{
									this.SpawnProp("apa_mp_apa_y2_l2d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag36 = this.DoorType == 0;
							if (flag36)
							{
								this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							bool flag37 = this.DoorType == 1;
							if (flag37)
							{
								this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
						}
						bool flag38 = this.YachtType == 2;
						if (flag38)
						{
							this.SpawnProp("apa_mp_apa_yacht_option3_cola", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 1);
							this.SpawnProp("apa_mp_apa_yacht_option3_colb", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 2);
							this.SpawnProp("apa_mp_apa_yacht_option3_colc", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 1);
							this.SpawnProp("apa_mp_apa_yacht_option3_cold", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 2);
							this.SpawnProp("apa_mp_apa_yacht_option3_cole", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 1);
							bool flag39 = this.Lighting == 1;
							if (flag39)
							{
								bool flag40 = this.LightingColor == 1;
								if (flag40)
								{
									this.SpawnProp("apa_mp_apa_y3_l1a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag41 = this.LightingColor == 2;
								if (flag41)
								{
									this.SpawnProp("apa_mp_apa_y3_l1b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag42 = this.LightingColor == 3;
								if (flag42)
								{
									this.SpawnProp("apa_mp_apa_y3_l1c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag43 = this.LightingColor == 4;
								if (flag43)
								{
									this.SpawnProp("apa_mp_apa_y3_l1d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag44 = this.Lighting == 2;
							if (flag44)
							{
								bool flag45 = this.LightingColor == 1;
								if (flag45)
								{
									this.SpawnProp("apa_mp_apa_y3_l2a", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag46 = this.LightingColor == 2;
								if (flag46)
								{
									this.SpawnProp("apa_mp_apa_y3_l2b", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag47 = this.LightingColor == 3;
								if (flag47)
								{
									this.SpawnProp("apa_mp_apa_y3_l2c", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
								bool flag48 = this.LightingColor == 4;
								if (flag48)
								{
									this.SpawnProp("apa_mp_apa_y3_l2d", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 3);
								}
							}
							bool flag49 = this.DoorType == 0;
							if (flag49)
							{
								this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							bool flag50 = this.DoorType == 1;
							if (flag50)
							{
								this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 6);
							}
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
							this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0f, 0f, 0f), 7);
						}
					}
					bool flag51 = this.Base == null;
					if (flag51)
					{
						UI.Notify("Test Case Scenario Failed");
					}
				}
			}
			catch
			{
				UI.Notify("~r~ Failed to Spawn Yacht~w~, Attempting again!");
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0001E6A4 File Offset: 0x0001C8A4
		public void OnKeyDown()
		{
			bool flag = this.Missionnum == 13;
			if (flag)
			{
				bool flag2 = Game.IsControlJustPressed(2, 51);
				if (flag2)
				{
					bool flag3 = World.GetDistance(Game.Player.Character.Position, new Vector3(213f, -936f, 24f)) < 3f;
					if (flag3)
					{
						Game.Player.Character.Position = new Vector3(227f, -1001f, -99f);
					}
					else
					{
						bool flag4 = World.GetDistance(Game.Player.Character.Position, new Vector3(227f, -1001f, -99f)) < 4f;
						if (flag4)
						{
							bool flag5 = Game.Player.Character.CurrentVehicle != null;
							if (flag5)
							{
								Game.Player.Character.CurrentVehicle.Position = new Vector3(213f, -936f, 24f);
								Game.Player.Character.CurrentVehicle.Rotation = new Vector3(0f, 0f, -34f);
								Game.Player.WantedLevel = 2;
							}
							else
							{
								Game.Player.Character.Position = new Vector3(213f, -936f, 24f);
							}
						}
					}
				}
			}
			bool flag6 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeAPos) < 2f;
			if (flag6)
			{
				bool flag7 = Game.IsControlJustPressed(2, 51);
				if (flag7)
				{
					this.WoredrobeMainMenu.Visible = !this.WoredrobeMainMenu.Visible;
				}
			}
			bool flag8 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeBPos) < 2f;
			if (flag8)
			{
				bool flag9 = Game.IsControlJustPressed(2, 51);
				if (flag9)
				{
					this.WoredrobeMainMenu.Visible = !this.WoredrobeMainMenu.Visible;
				}
			}
			bool flag10 = World.GetDistance(Game.Player.Character.Position, this.WoredrobeCPos) < 2f;
			if (flag10)
			{
				bool flag11 = Game.IsControlJustPressed(2, 51);
				if (flag11)
				{
					this.WoredrobeMainMenu.Visible = !this.WoredrobeMainMenu.Visible;
				}
			}
			bool flag12 = World.GetDistance(Game.Player.Character.Position, this.ShowerAPos) < 3f;
			if (flag12)
			{
				bool flag13 = Game.IsControlJustPressed(2, 51);
				if (flag13)
				{
					bool flag14 = !this.InShower;
					if (flag14)
					{
						Function.Call(-5184338789570016586L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(7798175403732277905L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(960291159887317458L, new InputArgument[]
						{
							"scr_fbi5_ped_water_splash",
							Game.Player.Character,
							0.0,
							0.0,
							-0.5,
							0.0,
							0.0,
							0.0,
							1.0,
							false,
							false,
							false
						});
						this.InShower = true;
						Game.Player.Character.Position = this.ShowerAPos;
						Game.Player.Character.FreezePosition = true;
						bool flag15 = Game.Player.Character.Model == -1692214353 || Game.Player.Character.Model == 225514697;
						if (flag15)
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								26,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								5,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								15,
								0,
								1
							});
						}
						else
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								16,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								19,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								16,
								17,
								1
							});
						}
						Game.Player.Character.Task.PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
					}
					else
					{
						bool inShower = this.InShower;
						if (inShower)
						{
							this.InShower = false;
							Game.Player.Character.Position = this.ShowerAPosEnter;
							Game.Player.Character.FreezePosition = false;
							Game.Player.Character.Health = 500;
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								0,
								0,
								1
							});
							Game.Player.Character.Task.ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
							Function.Call(-5116459798881995739L, new InputArgument[]
							{
								Game.Player.Character
							});
						}
					}
				}
			}
			bool flag16 = World.GetDistance(Game.Player.Character.Position, this.ShowerBPos) < 3f;
			if (flag16)
			{
				bool flag17 = Game.IsControlJustPressed(2, 51);
				if (flag17)
				{
					bool flag18 = !this.InShower;
					if (flag18)
					{
						Function.Call(-5184338789570016586L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(7798175403732277905L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(960291159887317458L, new InputArgument[]
						{
							"scr_fbi5_ped_water_splash",
							Game.Player.Character,
							0.0,
							0.0,
							-0.5,
							0.0,
							0.0,
							0.0,
							1.0,
							false,
							false,
							false
						});
						this.InShower = true;
						Game.Player.Character.Position = this.ShowerBPos;
						Game.Player.Character.FreezePosition = true;
						bool flag19 = Game.Player.Character.Model == -1692214353 || Game.Player.Character.Model == 225514697;
						if (flag19)
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								26,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								5,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								15,
								0,
								1
							});
						}
						else
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								16,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								19,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								16,
								17,
								1
							});
						}
						Game.Player.Character.Task.PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
					}
					else
					{
						bool inShower2 = this.InShower;
						if (inShower2)
						{
							this.InShower = false;
							Game.Player.Character.Position = this.ShowerBPosEnter;
							Game.Player.Character.FreezePosition = false;
							Game.Player.Character.Health = 500;
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								0,
								0,
								1
							});
							Game.Player.Character.Task.ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
							Function.Call(-5116459798881995739L, new InputArgument[]
							{
								Game.Player.Character
							});
						}
					}
				}
			}
			bool flag20 = World.GetDistance(Game.Player.Character.Position, this.ShowerCPos) < 3f;
			if (flag20)
			{
				bool flag21 = Game.IsControlJustPressed(2, 51);
				if (flag21)
				{
					bool flag22 = !this.InShower;
					if (flag22)
					{
						Function.Call(-5184338789570016586L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(7798175403732277905L, new InputArgument[]
						{
							"scr_fbi5a"
						});
						Function.Call(960291159887317458L, new InputArgument[]
						{
							"scr_fbi5_ped_water_splash",
							Game.Player.Character,
							0.0,
							0.0,
							-0.5,
							0.0,
							0.0,
							0.0,
							1.0,
							false,
							false,
							false
						});
						this.InShower = true;
						Game.Player.Character.Position = this.ShowerCPos;
						Game.Player.Character.FreezePosition = true;
						bool flag23 = Game.Player.Character.Model == -1692214353 || Game.Player.Character.Model == 225514697;
						if (flag23)
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								26,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								5,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								15,
								0,
								1
							});
						}
						else
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								16,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								19,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								16,
								17,
								1
							});
						}
						Game.Player.Character.Task.PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
					}
					else
					{
						bool inShower3 = this.InShower;
						if (inShower3)
						{
							this.InShower = false;
							Game.Player.Character.Position = this.ShowerCPosEnter;
							Game.Player.Character.FreezePosition = false;
							Game.Player.Character.Health = 500;
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								0,
								0,
								1
							});
							Game.Player.Character.Task.ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
							Function.Call(-5116459798881995739L, new InputArgument[]
							{
								Game.Player.Character
							});
						}
					}
				}
			}
			bool flag24 = Game.IsControlJustPressed(2, 51);
			if (flag24)
			{
				bool flag25 = World.GetDistance(Game.Player.Character.Position, this.BarDrinkPos) < 2f;
				if (flag25)
				{
					this.DrinksMenu.Visible = !this.DrinksMenu.Visible;
				}
			}
			bool flag26 = Game.IsControlJustPressed(2, 51);
			if (flag26)
			{
				bool flag27 = World.GetDistance(Game.Player.Character.Position, this.jacuzziSeat1) < 4f;
				if (flag27)
				{
					bool flag28 = !this.IsinHottub;
					if (flag28)
					{
						Game.Player.Character.Position = this.jacuzziSeat1;
						Game.Player.Character.Rotation = new Vector3(0f, 0f, this.Base.Rotation.Z + 90f);
						bool flag29 = Game.Player.Character.Model == -1692214353 || Game.Player.Character.Model == 225514697;
						if (flag29)
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								26,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								5,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								15,
								0,
								1
							});
						}
						else
						{
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								16,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								19,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								16,
								17,
								1
							});
						}
						this.PlayAnim(Game.Player.Character, 2);
						this.IsinHottub = true;
					}
					else
					{
						bool isinHottub = this.IsinHottub;
						if (isinHottub)
						{
							Game.Player.Character.Position = this.jacuzziSeat1;
							Game.Player.Character.Task.ClearAllImmediately();
							Game.Player.Character.Task.ClearAll();
							Game.Player.Character.FreezePosition = false;
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								3,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								4,
								0,
								0,
								1
							});
							Function.Call(2750315038012726912L, new InputArgument[]
							{
								Game.Player.Character,
								6,
								0,
								0,
								1
							});
							this.IsinHottub = false;
						}
					}
				}
			}
			bool flag30 = Game.IsControlJustPressed(2, 51);
			if (flag30)
			{
				bool flag31 = World.GetDistance(Game.Player.Character.Position, this.ChangeLocMarker) < 2f;
				if (flag31)
				{
					this.DisplayHelpTextThisFrame("Change Location");
					this.ChangePosMainMenu.Visible = !this.ChangePosMainMenu.Visible;
				}
			}
			bool flag32 = Game.IsControlJustPressed(2, 51);
			if (flag32)
			{
				bool flag33 = World.GetDistance(Game.Player.Character.Position, this.MenuMarker) < 2f;
				if (flag33)
				{
					this.mainMenu.Visible = !this.mainMenu.Visible;
				}
			}
			bool flag34 = Game.IsControlJustPressed(2, 51);
			if (flag34)
			{
				bool flag35 = World.GetDistance(Game.Player.Character.Position, this.BarEnter) < 2f;
				if (flag35)
				{
					Game.FadeScreenOut(300);
					Script.Wait(300);
					Game.Player.Character.Position = this.BarExit;
					Script.Wait(300);
					Game.FadeScreenIn(300);
				}
				else
				{
					bool flag36 = World.GetDistance(Game.Player.Character.Position, this.BarExit) < 2f;
					if (flag36)
					{
						Game.FadeScreenOut(300);
						Script.Wait(300);
						Game.Player.Character.Position = this.BarEnter;
						Script.Wait(300);
						Game.FadeScreenIn(300);
					}
				}
				bool flag37 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersEnter) < 2f;
				if (flag37)
				{
					Game.FadeScreenOut(300);
					Script.Wait(300);
					Game.Player.Character.Position = this.CaptinsQuartersExit;
					Script.Wait(300);
					Game.FadeScreenIn(300);
				}
				else
				{
					bool flag38 = World.GetDistance(Game.Player.Character.Position, this.CaptinsQuartersExit) < 2f;
					if (flag38)
					{
						Game.FadeScreenOut(300);
						Script.Wait(300);
						Game.Player.Character.Position = this.CaptinsQuartersEnter;
						Script.Wait(300);
						Game.FadeScreenIn(300);
					}
				}
				bool flag39 = World.GetDistance(Game.Player.Character.Position, this.Bed1) < 2f;
				if (flag39)
				{
					bool flag40 = Game.IsControlJustPressed(2, 51);
					if (flag40)
					{
						Game.Player.Character.FreezePosition = true;
						Game.FadeScreenOut(500);
						Script.Wait(500);
						Function.Call(-3978201909929952453L, new InputArgument[]
						{
							6,
							0,
							0
						});
						Game.Player.WantedLevel = 0;
						Function.Call(-8078852494817208297L, new InputArgument[]
						{
							Game.Player.Character
						});
						Function.Call(-7173663049392046466L, new InputArgument[]
						{
							Game.Player.Character
						});
						Game.Player.Character.Position = this.Bed1;
						Game.Player.Character.Heading = 248.15f;
						Function.Call(-5409910488053730831L, new InputArgument[]
						{
							0f
						});
						Function.Call(7856627101237848957L, new InputArgument[]
						{
							0f
						});
						Game.Player.Character.FreezePosition = false;
						Script.Wait(1500);
						Game.FadeScreenIn(500);
					}
				}
				bool flag41 = World.GetDistance(Game.Player.Character.Position, this.Bed2) < 2f;
				if (flag41)
				{
					bool flag42 = Game.IsControlJustPressed(2, 51);
					if (flag42)
					{
						Game.Player.Character.FreezePosition = true;
						Game.FadeScreenOut(500);
						Script.Wait(500);
						Function.Call(-3978201909929952453L, new InputArgument[]
						{
							6,
							0,
							0
						});
						Game.Player.WantedLevel = 0;
						Function.Call(-8078852494817208297L, new InputArgument[]
						{
							Game.Player.Character
						});
						Function.Call(-7173663049392046466L, new InputArgument[]
						{
							Game.Player.Character
						});
						Game.Player.Character.Position = this.Bed2;
						Game.Player.Character.Heading = 248.15f;
						Function.Call(-5409910488053730831L, new InputArgument[]
						{
							0f
						});
						Function.Call(7856627101237848957L, new InputArgument[]
						{
							0f
						});
						Game.Player.Character.FreezePosition = false;
						Script.Wait(1500);
						Game.FadeScreenIn(500);
					}
				}
				bool flag43 = World.GetDistance(Game.Player.Character.Position, this.Bed3) < 2f;
				if (flag43)
				{
					bool flag44 = Game.IsControlJustPressed(2, 51);
					if (flag44)
					{
						Game.Player.Character.FreezePosition = true;
						Game.FadeScreenOut(500);
						Script.Wait(500);
						Function.Call(-3978201909929952453L, new InputArgument[]
						{
							6,
							0,
							0
						});
						Game.Player.WantedLevel = 0;
						Function.Call(-8078852494817208297L, new InputArgument[]
						{
							Game.Player.Character
						});
						Function.Call(-7173663049392046466L, new InputArgument[]
						{
							Game.Player.Character
						});
						Game.Player.Character.Position = this.Bed3;
						Game.Player.Character.Heading = 248.15f;
						Function.Call(-5409910488053730831L, new InputArgument[]
						{
							0f
						});
						Function.Call(7856627101237848957L, new InputArgument[]
						{
							0f
						});
						Game.Player.Character.FreezePosition = false;
						Script.Wait(1500);
						Game.FadeScreenIn(500);
					}
				}
			}
		}

		// Token: 0x0400002A RID: 42
		private Vector3 PlayerYachtPos1 = new Vector3(-3551.974f, 1477.896f, 12.77976f);

		// Token: 0x0400002B RID: 43
		private Vector3 PlayerYachtPos2 = new Vector3(-3148.379f, 2807.555f, 5.42997f);

		// Token: 0x0400002C RID: 44
		private Vector3 PlayerYachtPos3 = new Vector3(-3280.501f, 2140.507f, 5.42997f);

		// Token: 0x0400002D RID: 45
		private Vector3 PlayerYachtPos4 = new Vector3(-2814.49f, 4072.74f, 5.42997f);

		// Token: 0x0400002E RID: 46
		private Vector3 PlayerYachtPos5 = new Vector3(-3254.552f, 3685.677f, 5.42997f);

		// Token: 0x0400002F RID: 47
		private Vector3 PlayerYachtPos6 = new Vector3(-2368.441f, 4697.874f, 5.42997f);

		// Token: 0x04000030 RID: 48
		private Vector3 PlayerYachtPos7 = new Vector3(-3205.344f, -219.0104f, 5.42997f);

		// Token: 0x04000031 RID: 49
		private Vector3 PlayerYachtPos8 = new Vector3(-3448.254f, 311.5018f, 5.42997f);

		// Token: 0x04000032 RID: 50
		private Vector3 PlayerYachtPos9 = new Vector3(-2697.862f, -540.6123f, 5.42997f);

		// Token: 0x04000033 RID: 51
		private Vector3 PlayerYachtPos10 = new Vector3(-1995.725f, -1523.694f, 5.429955f);

		// Token: 0x04000034 RID: 52
		private Vector3 PlayerYachtPos11 = new Vector3(-2117.581f, -2543.346f, 5.42997f);

		// Token: 0x04000035 RID: 53
		private Vector3 PlayerYachtPos12 = new Vector3(-1605.074f, -1872.468f, 5.42997f);

		// Token: 0x04000036 RID: 54
		private Vector3 PlayerYachtPos13 = new Vector3(-753.0817f, -3919.068f, 5.42997f);

		// Token: 0x04000037 RID: 55
		private Vector3 PlayerYachtPos14 = new Vector3(-351.0608f, -3553.323f, 5.42997f);

		// Token: 0x04000038 RID: 56
		private Vector3 PlayerYachtPos15 = new Vector3(-1460.536f, -3761.467f, 5.42997f);

		// Token: 0x04000039 RID: 57
		private Vector3 PlayerYachtPos16 = new Vector3(1546.892f, -3045.627f, 5.42997f);

		// Token: 0x0400003A RID: 58
		private Vector3 PlayerYachtPos17 = new Vector3(2490.885f, -2428.848f, 5.42997f);

		// Token: 0x0400003B RID: 59
		private Vector3 PlayerYachtPos18 = new Vector3(2049.79f, -2821.624f, 5.42997f);

		// Token: 0x0400003C RID: 60
		private Vector3 PlayerYachtPos19 = new Vector3(3029.018f, -1495.702f, 5.42997f);

		// Token: 0x0400003D RID: 61
		private Vector3 PlayerYachtPos20 = new Vector3(3021.254f, -723.3903f, 5.42997f);

		// Token: 0x0400003E RID: 62
		private Vector3 PlayerYachtPos21 = new Vector3(2976.622f, -1994.76f, 5.42997f);

		// Token: 0x0400003F RID: 63
		private Vector3 PlayerYachtPos22 = new Vector3(3404.51f, 1977.044f, 5.42997f);

		// Token: 0x04000040 RID: 64
		private Vector3 PlayerYachtPos23 = new Vector3(3411.1f, 1193.445f, 5.42997f);

		// Token: 0x04000041 RID: 65
		private Vector3 PlayerYachtPos24 = new Vector3(3784.802f, 2548.541f, 5.42997f);

		// Token: 0x04000042 RID: 66
		private Vector3 PlayerYachtPos25 = new Vector3(4225.028f, 3988.002f, 5.42997f);

		// Token: 0x04000043 RID: 67
		private Vector3 PlayerYachtPos26 = new Vector3(4250.581f, 4576.565f, 5.42997f);

		// Token: 0x04000044 RID: 68
		private Vector3 PlayerYachtPos27 = new Vector3(4204.355f, 3373.7f, 5.42997f);

		// Token: 0x04000045 RID: 69
		private Vector3 PlayerYachtPos28 = new Vector3(3751.681f, 5753.501f, 5.42997f);

		// Token: 0x04000046 RID: 70
		private Vector3 PlayerYachtPos29 = new Vector3(3490.105f, 6305.785f, 5.42997f);

		// Token: 0x04000047 RID: 71
		private Vector3 PlayerYachtPos30 = new Vector3(3684.853f, 5212.238f, 5.42997f);

		// Token: 0x04000048 RID: 72
		private Vector3 PlayerYachtPos31 = new Vector3(581.5955f, 7124.558f, 5.42997f);

		// Token: 0x04000049 RID: 73
		private Vector3 PlayerYachtPos32 = new Vector3(2004.462f, 6907.157f, 5.429955f);

		// Token: 0x0400004A RID: 74
		private Vector3 PlayerYachtPos33 = new Vector3(1396.638f, 6860.203f, 5.42997f);

		// Token: 0x0400004B RID: 75
		private Vector3 PlayerYachtPos34 = new Vector3(-1170.69f, 5980.682f, 5.42997f);

		// Token: 0x0400004C RID: 76
		private Vector3 PlayerYachtPos35 = new Vector3(-777.4865f, 6566.907f, 5.42997f);

		// Token: 0x0400004D RID: 77
		private Vector3 PlayerYachtPos36 = new Vector3(-381.7739f, 6946.96f, 5.42997f);

		// Token: 0x0400004E RID: 78
		public List<Vector3> YachtPos = new List<Vector3>();

		// Token: 0x0400004F RID: 79
		public List<string> YachtHashs = new List<string>();

		// Token: 0x04000050 RID: 80
		public List<string> YachtHashs2 = new List<string>();

		// Token: 0x04000051 RID: 81
		public List<Blip> Blips = new List<Blip>();

		// Token: 0x04000052 RID: 82
		public List<string> YachtLocSring = new List<string>();

		// Token: 0x04000053 RID: 83
		public List<Prop> Props = new List<Prop>();

		// Token: 0x04000054 RID: 84
		private string Rail = "apa_MP_Apa_Yacht_O3_Rail_B";

		// Token: 0x04000055 RID: 85
		private string YachtTop = "apa_mp_apa_yacht_option3";

		// Token: 0x04000056 RID: 86
		private string YachtLauncher = "apa_mp_apa_yacht_launcher_01a";

		// Token: 0x04000057 RID: 87
		private ScriptSettings Config;

		// Token: 0x04000058 RID: 88
		public Vector3 MenuMarker;

		// Token: 0x04000059 RID: 89
		public Vector3 SleepPos1;

		// Token: 0x0400005A RID: 90
		public Vector3 SleepPos2;

		// Token: 0x0400005B RID: 91
		public Vector3 HeliPosA;

		// Token: 0x0400005C RID: 92
		public Vector3 HeliPosB;

		// Token: 0x0400005D RID: 93
		public Vehicle HeliA;

		// Token: 0x0400005E RID: 94
		public Vehicle HeliB;

		// Token: 0x0400005F RID: 95
		public Vector3 Jacuzzi;

		// Token: 0x04000060 RID: 96
		public Vector3 BarEnter;

		// Token: 0x04000061 RID: 97
		public Vector3 BarExit;

		// Token: 0x04000062 RID: 98
		public Vector3 CaptinsQuartersEnter;

		// Token: 0x04000063 RID: 99
		public Vector3 CaptinsQuartersExit;

		// Token: 0x04000064 RID: 100
		public Vector3 BackEntranceOffset = new Vector3(-37.78258f, -1.999345f, -0.5f);

		// Token: 0x04000065 RID: 101
		public Vector3 BackIntOffset = new Vector3(-12.50842f, -1.944044f, -0.5f);

		// Token: 0x04000066 RID: 102
		public Vector3 CaptEntranceOffset = new Vector3(-1.029798f, -1.807718f, 5.5f);

		// Token: 0x04000067 RID: 103
		public Vector3 CaptIntOffset = new Vector3(5.697177f, -1.996299f, 5.5f);

		// Token: 0x04000068 RID: 104
		public Vector3 CaptComputerOffset = new Vector3(13.66955f, -2.026101f, 6.5f);

		// Token: 0x04000069 RID: 105
		public Vector3 MenuOffset = new Vector3(13.66955f, -6.5f, -0.5f);

		// Token: 0x0400006A RID: 106
		public Vector3 HeliPadAOffset;

		// Token: 0x0400006B RID: 107
		public Vector3 HeliPadBOffset;

		// Token: 0x0400006C RID: 108
		public int MaxHelis;

		// Token: 0x0400006D RID: 109
		public bool GoldRails;

		// Token: 0x0400006E RID: 110
		public int ShipColor;

		// Token: 0x0400006F RID: 111
		public int RailsColor;

		// Token: 0x04000070 RID: 112
		public Vector3 ChangeLocMarker;

		// Token: 0x04000071 RID: 113
		public int Purchased;

		// Token: 0x04000072 RID: 114
		public int YachtType;

		// Token: 0x04000073 RID: 115
		public int Location;

		// Token: 0x04000074 RID: 116
		public int Lighting;

		// Token: 0x04000075 RID: 117
		public int LightingColor;

		// Token: 0x04000076 RID: 118
		public bool Created;

		// Token: 0x04000077 RID: 119
		public int DoorType;

		// Token: 0x04000078 RID: 120
		public Prop DoorA;

		// Token: 0x04000079 RID: 121
		public Prop DoorB;

		// Token: 0x0400007A RID: 122
		public Prop DoorC;

		// Token: 0x0400007B RID: 123
		public int H1;

		// Token: 0x0400007C RID: 124
		public int H2;

		// Token: 0x0400007D RID: 125
		public Vector3 jacuzziSeat1 = new Vector3(950.1906f, 8.564717f, 115f);

		// Token: 0x0400007E RID: 126
		public float J_rot1 = 40f;

		// Token: 0x0400007F RID: 127
		public Vector3 jacuzziSeat2 = new Vector3(950.6779f, 9.216393f, 115f);

		// Token: 0x04000080 RID: 128
		public float J_rot2 = 71f;

		// Token: 0x04000081 RID: 129
		public Vector3 jacuzziSeat3 = new Vector3(949.2539f, 8.049603f, 115f);

		// Token: 0x04000082 RID: 130
		public float J_rot3 = -5.3f;

		// Token: 0x04000083 RID: 131
		public Vector3 jacuzziSeat4 = new Vector3(947.048f, 10.22428f, 115f);

		// Token: 0x04000084 RID: 132
		public float J_rot4 = -117f;

		// Token: 0x04000085 RID: 133
		public Vector3 jacuzziSeat5 = new Vector3(947.7902f, 9.3316f, 115f);

		// Token: 0x04000086 RID: 134
		public float J_rot5 = -71f;

		// Token: 0x04000087 RID: 135
		public Vector3 jacuzziSeat6 = new Vector3(950.5591f, 10.92737f, 115f);

		// Token: 0x04000088 RID: 136
		public float J_rot6 = 103f;

		// Token: 0x04000089 RID: 137
		public bool IsinHottub;

		// Token: 0x0400008A RID: 138
		public List<Ped> Peds = new List<Ped>();

		// Token: 0x0400008B RID: 139
		private float Speed;

		// Token: 0x0400008C RID: 140
		private Vehicle Car;

		// Token: 0x0400008D RID: 141
		public int PedType = 1;

		// Token: 0x0400008E RID: 142
		private MenuPool ChangePosPool;

		// Token: 0x0400008F RID: 143
		private UIMenu ChangePosMainMenu;

		// Token: 0x04000090 RID: 144
		private UIMenu ChangePosMenu;

		// Token: 0x04000091 RID: 145
		public WeaponTint Liv;

		// Token: 0x04000092 RID: 146
		public int ID_O;

		// Token: 0x04000093 RID: 147
		public string ID_C;

		// Token: 0x04000094 RID: 148
		public int Comp;

		// Token: 0x04000095 RID: 149
		public Vector3 Bed1;

		// Token: 0x04000096 RID: 150
		public Vector3 Bed2;

		// Token: 0x04000097 RID: 151
		public Vector3 Bed3;

		// Token: 0x04000098 RID: 152
		public Vector3 BarPos;

		// Token: 0x04000099 RID: 153
		public Vector3 BarDrinkPos;

		// Token: 0x0400009A RID: 154
		public Ped Bargirl;

		// Token: 0x0400009B RID: 155
		public List<string> FlagList = new List<string>();

		// Token: 0x0400009C RID: 156
		public int CurrentFlag = 2;

		// Token: 0x0400009D RID: 157
		public Prop FlagA;

		// Token: 0x0400009E RID: 158
		public Prop FlagB;

		// Token: 0x0400009F RID: 159
		public Prop FlagC;

		// Token: 0x040000A0 RID: 160
		public Vector3 FlagPosA;

		// Token: 0x040000A1 RID: 161
		public Vector3 FlagPosB;

		// Token: 0x040000A2 RID: 162
		public Vector3 FlagPosC;

		// Token: 0x040000A3 RID: 163
		public Vector3 ShowerAPos;

		// Token: 0x040000A4 RID: 164
		public Vector3 ShowerAPosEnter;

		// Token: 0x040000A5 RID: 165
		public Vector3 ShowerBPos;

		// Token: 0x040000A6 RID: 166
		public Vector3 ShowerBPosEnter;

		// Token: 0x040000A7 RID: 167
		public Vector3 ShowerCPos;

		// Token: 0x040000A8 RID: 168
		public Vector3 ShowerCPosEnter;

		// Token: 0x040000A9 RID: 169
		public bool InShower;

		// Token: 0x040000AA RID: 170
		public int AmountOfSeaSharks;

		// Token: 0x040000AB RID: 171
		public Vector3 SeaSharkPosA;

		// Token: 0x040000AC RID: 172
		public Vector3 SeaSharkPosB;

		// Token: 0x040000AD RID: 173
		public Vector3 SeaSharkPosC;

		// Token: 0x040000AE RID: 174
		public Vector3 SeaSharkPosD;

		// Token: 0x040000AF RID: 175
		public Vehicle SeaSharkA;

		// Token: 0x040000B0 RID: 176
		public Vehicle SeaSharkB;

		// Token: 0x040000B1 RID: 177
		public Vehicle SeaSharkC;

		// Token: 0x040000B2 RID: 178
		public Vehicle SeaSharkD;

		// Token: 0x040000B3 RID: 179
		public Vector3 BoatAPos;

		// Token: 0x040000B4 RID: 180
		public Vector3 BoatBPos;

		// Token: 0x040000B5 RID: 181
		public Vehicle BoatA;

		// Token: 0x040000B6 RID: 182
		public Vehicle BoatB;

		// Token: 0x040000B7 RID: 183
		public int BoatAType;

		// Token: 0x040000B8 RID: 184
		public int BoatBType;

		// Token: 0x040000B9 RID: 185
		public bool ShowTestBlips;

		// Token: 0x040000BA RID: 186
		public bool WaitForCreated;

		// Token: 0x040000BB RID: 187
		public Vector3 WoredrobeAPos;

		// Token: 0x040000BC RID: 188
		public Vector3 WoredrobeBPos;

		// Token: 0x040000BD RID: 189
		public Vector3 WoredrobeCPos;

		// Token: 0x040000BE RID: 190
		public MenuPool Woredrobepool;

		// Token: 0x040000BF RID: 191
		public UIMenu WoredrobeMainMenu;

		// Token: 0x040000C0 RID: 192
		public UIMenu WoredrobeMenu;

		// Token: 0x040000C1 RID: 193
		public int CompMax;

		// Token: 0x040000C2 RID: 194
		public int DrawableMax;

		// Token: 0x040000C3 RID: 195
		public Model OldCharacter;

		// Token: 0x040000C4 RID: 196
		public MenuPool DrinksPool;

		// Token: 0x040000C5 RID: 197
		public UIMenu DrinksMenu;

		// Token: 0x040000C6 RID: 198
		public UIMenu DrinksMainMenu;

		// Token: 0x040000C7 RID: 199
		public Prop Champaine;

		// Token: 0x040000C8 RID: 200
		public bool IsDrinking;

		// Token: 0x040000C9 RID: 201
		public int DrinkTimer;

		// Token: 0x040000CA RID: 202
		public List<Prop> Champ = new List<Prop>();

		// Token: 0x040000CB RID: 203
		public int Effect;

		// Token: 0x040000CC RID: 204
		public bool RadioOn;

		// Token: 0x040000CD RID: 205
		public int Station;

		// Token: 0x040000CE RID: 206
		public List<Vector3> RadioPos = new List<Vector3>();

		// Token: 0x040000CF RID: 207
		public Vector3 CurrentRadio;

		// Token: 0x040000D0 RID: 208
		public int CurrentInt;

		// Token: 0x040000D1 RID: 209
		public float Z_min;

		// Token: 0x040000D2 RID: 210
		public float Z_max;

		// Token: 0x040000D3 RID: 211
		public bool isDrinking;

		// Token: 0x040000D4 RID: 212
		public Prop Base;

		// Token: 0x040000D5 RID: 213
		public Prop Base2;

		// Token: 0x040000D6 RID: 214
		public Prop YachtBase;

		// Token: 0x040000D7 RID: 215
		private string YachtHash;

		// Token: 0x040000D8 RID: 216
		public int SpawnDist;

		// Token: 0x040000D9 RID: 217
		public bool ShowDistWhenClose;

		// Token: 0x040000DA RID: 218
		public int LoadTime;

		// Token: 0x040000DB RID: 219
		public Vector3 MarkerEnter;

		// Token: 0x040000DC RID: 220
		public Vector3 MarkerExit;

		// Token: 0x040000DD RID: 221
		public Vector3 RoofEnterMarker;

		// Token: 0x040000DE RID: 222
		public Vector3 RoofExitMarker;

		// Token: 0x040000DF RID: 223
		public Vector3 HeliSpawn;

		// Token: 0x040000E0 RID: 224
		public Vector3 GarageMarker;

		// Token: 0x040000E1 RID: 225
		public Vector3 CarSpawn;

		// Token: 0x040000E2 RID: 226
		public Vector3 WherehouseMarker;

		// Token: 0x040000E3 RID: 227
		public Vector3 WherehouseEnter;

		// Token: 0x040000E4 RID: 228
		private Keys Key1;

		// Token: 0x040000E5 RID: 229
		public Vector3 BuyMarker;

		// Token: 0x040000E6 RID: 230
		public Vector3 BuyMarker2;

		// Token: 0x040000E7 RID: 231
		public int num;

		// Token: 0x040000E8 RID: 232
		private MenuPool modMenuPool;

		// Token: 0x040000E9 RID: 233
		private UIMenu mainMenu;

		// Token: 0x040000EA RID: 234
		private UIMenu methgarage;

		// Token: 0x040000EB RID: 235
		private UIMenu ProductStock;

		// Token: 0x040000EC RID: 236
		public bool bought;

		// Token: 0x040000ED RID: 237
		public int purchaselvl;

		// Token: 0x040000EE RID: 238
		public int maxstocks;

		// Token: 0x040000EF RID: 239
		public float stocksvalue;

		// Token: 0x040000F0 RID: 240
		public float profitMargin;

		// Token: 0x040000F1 RID: 241
		public int stockscount;

		// Token: 0x040000F2 RID: 242
		public int stockstimer;

		// Token: 0x040000F3 RID: 243
		public int waittime = 3200;

		// Token: 0x040000F4 RID: 244
		public int DisplayWait;

		// Token: 0x040000F5 RID: 245
		public bool EnemySetup;

		// Token: 0x040000F6 RID: 246
		public int Chooseenemynum;

		// Token: 0x040000F7 RID: 247
		public Vehicle VehicleId;

		// Token: 0x040000F8 RID: 248
		public bool VehicleSetup;

		// Token: 0x040000F9 RID: 249
		private List<WeaponHash> weapons = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>().ToList<WeaponHash>();

		// Token: 0x040000FA RID: 250
		public string carid;

		// Token: 0x040000FB RID: 251
		public int vehiclemissionid;

		// Token: 0x040000FC RID: 252
		public bool setupdelivery;

		// Token: 0x040000FD RID: 253
		public Vector3 DeliveryMaker;

		// Token: 0x040000FE RID: 254
		public Blip DeliveryLoc;

		// Token: 0x040000FF RID: 255
		public Blip ballasBlip1;

		// Token: 0x04000100 RID: 256
		public Vector3 Deliverypoint;

		// Token: 0x04000101 RID: 257
		public UIMenu Garage;

		// Token: 0x04000102 RID: 258
		public UIMenu Sourcingmenu;

		// Token: 0x04000103 RID: 259
		public UIMenu SupplyRunsmenu;

		// Token: 0x04000104 RID: 260
		public UIMenu OrganizationOptions;

		// Token: 0x04000105 RID: 261
		public bool setupwantedfordelivery;

		// Token: 0x04000106 RID: 262
		public int waittimeforwanted;

		// Token: 0x04000107 RID: 263
		public Vehicle AirVehicle;

		// Token: 0x04000108 RID: 264
		public int BuzzardBought;

		// Token: 0x04000109 RID: 265
		public int FMJBought;

		// Token: 0x0400010A RID: 266
		public int A911Bought;

		// Token: 0x0400010B RID: 267
		public int X80Bought;

		// Token: 0x0400010C RID: 268
		public int SEVEN70Bought;

		// Token: 0x0400010D RID: 269
		public int wherehosuebought;

		// Token: 0x0400010E RID: 270
		public int cargaragebought;

		// Token: 0x0400010F RID: 271
		public VehicleHash VehicleIdentifier;

		// Token: 0x04000110 RID: 272
		public Vehicle VehicleName;

		// Token: 0x04000111 RID: 273
		public bool foundvehicleyet;

		// Token: 0x04000112 RID: 274
		public Vector3 Vehicleloc;

		// Token: 0x04000113 RID: 275
		public Blip VehicleMarker;

		// Token: 0x04000114 RID: 276
		public Vehicle Vehicletoget;

		// Token: 0x04000115 RID: 277
		public Vector3 VehicleSpawn;

		// Token: 0x04000116 RID: 278
		public bool hasgotvehicle;

		// Token: 0x04000117 RID: 279
		public Random VehicleLoc;

		// Token: 0x04000118 RID: 280
		public Random VehicleRan;

		// Token: 0x04000119 RID: 281
		public Vehicle VehicleMissioncar;

		// Token: 0x0400011A RID: 282
		public Vector3 VehicleLocation;

		// Token: 0x0400011B RID: 283
		public int Missionnum;

		// Token: 0x0400011C RID: 284
		public Blip DestoryVehicle;

		// Token: 0x0400011D RID: 285
		public int Aircraftstorage;

		// Token: 0x0400011E RID: 286
		public bool warnedplayer;

		// Token: 0x0400011F RID: 287
		public Vector3 AircraftStorageLoc;

		// Token: 0x04000120 RID: 288
		public Blip AircraftStorageMarker;

		// Token: 0x04000121 RID: 289
		public Blip VehicleWarehouseMarker;

		// Token: 0x04000122 RID: 290
		public int GunLockerBought;

		// Token: 0x04000123 RID: 291
		public int MoneyVaultBought;

		// Token: 0x04000124 RID: 292
		public int DockBought;

		// Token: 0x04000125 RID: 293
		public int VehicleLotBought;

		// Token: 0x04000126 RID: 294
		public Vector3 Dockloc;

		// Token: 0x04000127 RID: 295
		public Blip DockBlip;

		// Token: 0x04000128 RID: 296
		public Vector3 LotLoc;

		// Token: 0x04000129 RID: 297
		public Blip LotBlip;

		// Token: 0x0400012A RID: 298
		public float SourcingPayout;

		// Token: 0x0400012B RID: 299
		public bool SourcingCheckingforDamage;

		// Token: 0x0400012C RID: 300
		public int AATrailerABought;

		// Token: 0x0400012D RID: 301
		public int AATrailerBBought;

		// Token: 0x0400012E RID: 302
		public int AATrailerCBought;

		// Token: 0x0400012F RID: 303
		public string OrganizationName;

		// Token: 0x04000130 RID: 304
		public UIMenu AssetRecoveryMenu;

		// Token: 0x04000131 RID: 305
		public bool TriggeredWanted;

		// Token: 0x04000132 RID: 306
		public int ValkyrieBought;

		// Token: 0x04000133 RID: 307
		public int AkulaBought;

		// Token: 0x04000134 RID: 308
		public int HunterBought;

		// Token: 0x04000135 RID: 309
		public int SavageBought;

		// Token: 0x04000136 RID: 310
		public int AnnihilatorBought;

		// Token: 0x04000137 RID: 311
		public Vehicle Vehicle1;

		// Token: 0x04000138 RID: 312
		public Vehicle Vehicle2;

		// Token: 0x04000139 RID: 313
		public Vehicle Vehicle3;

		// Token: 0x0400013A RID: 314
		public Blip ConvoyBlip1;

		// Token: 0x0400013B RID: 315
		public Blip ConvoyBlip2;

		// Token: 0x0400013C RID: 316
		public Blip ConvoyBlip3;

		// Token: 0x0400013D RID: 317
		public int convoysetup;

		// Token: 0x0400013E RID: 318
		public bool checkforconvoy;

		// Token: 0x0400013F RID: 319
		public int UseCustomWaitTime;

		// Token: 0x04000140 RID: 320
		public bool setWaittime;

		// Token: 0x04000141 RID: 321
		public Vector3 Radiopos;

		// Token: 0x04000142 RID: 322
		public int turretedlimo;

		// Token: 0x04000143 RID: 323
		public int assassinationmission;

		// Token: 0x04000144 RID: 324
		public int assassinationpayout;

		// Token: 0x04000145 RID: 325
		public Blip TowerBlip;

		// Token: 0x04000146 RID: 326
		public string Design;

		// Token: 0x04000147 RID: 327
		public Vector3 SleepPos;

		// Token: 0x04000148 RID: 328
		public Vector3 MBTOfficeSitRespawnPos;

		// Token: 0x04000149 RID: 329
		public Vector3 MBTOfficeSitPos;

		// Token: 0x0400014A RID: 330
		public bool sitting;

		// Token: 0x0400014B RID: 331
		public UIMenu Sourcingmenu2;

		// Token: 0x0400014C RID: 332
		public string SourcedVehicle;

		// Token: 0x0400014D RID: 333
		public bool NewVehicleSourcing;

		// Token: 0x0400014E RID: 334
		public float increaseGain;

		// Token: 0x0400014F RID: 335
		public bool ShowMarker;

		// Token: 0x04000150 RID: 336
		public bool InModGarage;

		// Token: 0x04000151 RID: 337
		public UIMenu SpecialMissions;

		// Token: 0x04000152 RID: 338
		public List<Ped> Guards = new List<Ped>();

		// Token: 0x04000153 RID: 339
		public List<Ped> Driver = new List<Ped>();

		// Token: 0x04000154 RID: 340
		public Vehicle VtoGet;

		// Token: 0x04000155 RID: 341
		public Blip VtoGetBlip;

		// Token: 0x04000156 RID: 342
		public bool GotCar;

		// Token: 0x04000157 RID: 343
		public Vehicle VtoGet1;

		// Token: 0x04000158 RID: 344
		public Vehicle VtoGet2;

		// Token: 0x04000159 RID: 345
		public Vehicle VtoGet3;

		// Token: 0x0400015A RID: 346
		public int Vehiclesleft;

		// Token: 0x0400015B RID: 347
		public Blip DropzoneBlip;

		// Token: 0x0400015C RID: 348
		public Vector3 Dropzone;

		// Token: 0x0400015D RID: 349
		public bool VehicleisDamaged;

		// Token: 0x0400015E RID: 350
		public int Vehiclehealth;

		// Token: 0x0400015F RID: 351
		public Vehicle RentedVehicle;

		// Token: 0x04000160 RID: 352
		public bool startedRent;

		// Token: 0x04000161 RID: 353
		public int RentTimer;

		// Token: 0x04000162 RID: 354
		public int RentalvehicleHealth;

		// Token: 0x04000163 RID: 355
		public bool ISinPiracyScamMission;

		// Token: 0x04000164 RID: 356
		public int Piracymission;

		// Token: 0x04000165 RID: 357
		public int TimerLeft;

		// Token: 0x04000166 RID: 358
		public VehicleHash RandomVehicle;

		// Token: 0x04000167 RID: 359
		public bool HackhasStarted;

		// Token: 0x04000168 RID: 360
		public Vector3 GoPoint;

		// Token: 0x04000169 RID: 361
		public int StockTimer;

		// Token: 0x0400016A RID: 362
		public int StockTimer2;

		// Token: 0x0400016B RID: 363
		public float stocktoloose;

		// Token: 0x0400016C RID: 364
		public bool IsScriptEnabled;

		// Token: 0x0400016D RID: 365
		public Vector3 ChairPos = new Vector3(-1555.582f, -575.1f, 107.1f);

		// Token: 0x0400016E RID: 366
		public float P_Rotation = 124f;

		// Token: 0x0400016F RID: 367
		public bool IsSittinginCeoSeat;

		// Token: 0x04000170 RID: 368
		public string WarehousePos;

		// Token: 0x04000171 RID: 369
		public Camera WarehouseCam;

		// Token: 0x04000172 RID: 370
		public bool WCamOn;

		// Token: 0x04000173 RID: 371
		public bool MenuOn;

		// Token: 0x04000174 RID: 372
		public bool Foundyacht;

		// Token: 0x04000175 RID: 373
		public bool DeletedYacht;

		// Token: 0x04000176 RID: 374
		public Prop PropYachtBase;

		// Token: 0x04000177 RID: 375
		public bool Firsttime = false;
	}
}
op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
          }
          else
          {
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(3),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(4),
              InputArgument.op_Implicit(19),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(6),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(17),
              InputArgument.op_Implicit(1)
            });
          }
          Game.get_Player().get_Character().get_Task().PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
        }
        else if (this.InShower)
        {
          this.InShower = false;
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerBPosEnter);
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
          ((Entity) Game.get_Player().get_Character()).set_Health(500);
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Game.get_Player().get_Character().get_Task().ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
          Function.Call((Hash) -5116459798881995739L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character())
          });
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerCPos) < 3.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        if (!this.InShower)
        {
          Function.Call((Hash) -5184338789570016586L, new InputArgument[1]
          {
            InputArgument.op_Implicit("scr_fbi5a")
          });
          Function.Call((Hash) 7798175403732277905L, new InputArgument[1]
          {
            InputArgument.op_Implicit("scr_fbi5a")
          });
          Function.Call((Hash) 960291159887317458L, new InputArgument[12]
          {
            InputArgument.op_Implicit("scr_fbi5_ped_water_splash"),
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(-0.5),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(0.0),
            InputArgument.op_Implicit(1.0),
            InputArgument.op_Implicit(false),
            InputArgument.op_Implicit(false),
            InputArgument.op_Implicit(false)
          });
          this.InShower = true;
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerCPos);
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
          if (Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) -1692214353)) || Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 225514697)))
          {
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(3),
              InputArgument.op_Implicit(26),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(4),
              InputArgument.op_Implicit(5),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(6),
              InputArgument.op_Implicit(15),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
          }
          else
          {
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(3),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(4),
              InputArgument.op_Implicit(19),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(6),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(17),
              InputArgument.op_Implicit(1)
            });
          }
          Game.get_Player().get_Character().get_Task().PlayAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a", 8f, -1, true, -1f);
        }
        else if (this.InShower)
        {
          this.InShower = false;
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerCPosEnter);
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
          ((Entity) Game.get_Player().get_Character()).set_Health(500);
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Game.get_Player().get_Character().get_Task().ClearAnimation("anim@mp_yacht@shower@male@", "male_shower_idle_a");
          Function.Call((Hash) -5116459798881995739L, new InputArgument[1]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character())
          });
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarDrinkPos) < 2.0)
        this.DrinksMenu.set_Visible(!this.DrinksMenu.get_Visible());
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 4.0)
      {
        if (!this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat1);
          ((Entity) Game.get_Player().get_Character()).set_Rotation(new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z + 90.0)));
          if (Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) -1692214353)) || Model.op_Equality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 225514697)))
          {
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(3),
              InputArgument.op_Implicit(26),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(4),
              InputArgument.op_Implicit(5),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(6),
              InputArgument.op_Implicit(15),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
          }
          else
          {
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(3),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(4),
              InputArgument.op_Implicit(19),
              InputArgument.op_Implicit(0),
              InputArgument.op_Implicit(1)
            });
            Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
            {
              InputArgument.op_Implicit(Game.get_Player().get_Character()),
              InputArgument.op_Implicit(6),
              InputArgument.op_Implicit(16),
              InputArgument.op_Implicit(17),
              InputArgument.op_Implicit(1)
            });
          }
          this.PlayAnim(Game.get_Player().get_Character(), 2);
          this.IsinHottub = true;
        }
        else if (this.IsinHottub)
        {
          ((Entity) Game.get_Player().get_Character()).set_Position(this.jacuzziSeat1);
          Game.get_Player().get_Character().get_Task().ClearAllImmediately();
          Game.get_Player().get_Character().get_Task().ClearAll();
          ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          this.IsinHottub = false;
        }
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChangeLocMarker) < 2.0)
      {
        this.DisplayHelpTextThisFrame("Change Location");
        this.ChangePosMainMenu.set_Visible(!this.ChangePosMainMenu.get_Visible());
      }
      if (Game.IsControlJustPressed(2, (Control) 51) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MenuMarker) < 2.0)
        this.mainMenu.set_Visible(!this.mainMenu.get_Visible());
      if (!Game.IsControlJustPressed(2, (Control) 51))
        return;
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarEnter) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.BarExit);
        Script.Wait(300);
        Game.FadeScreenIn(300);
      }
      else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarExit) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.BarEnter);
        Script.Wait(300);
        Game.FadeScreenIn(300);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersEnter) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.CaptinsQuartersExit);
        Script.Wait(300);
        Game.FadeScreenIn(300);
      }
      else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersExit) < 2.0)
      {
        Game.FadeScreenOut(300);
        Script.Wait(300);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.CaptinsQuartersEnter);
        Script.Wait(300);
        Game.FadeScreenIn(300);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed1) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        Game.FadeScreenOut(500);
        Script.Wait(500);
        Function.Call((Hash) -3978201909929952453L, new InputArgument[3]
        {
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Game.get_Player().set_WantedLevel(0);
        Function.Call((Hash) -8078852494817208297L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        Function.Call((Hash) -7173663049392046466L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        ((Entity) Game.get_Player().get_Character()).set_Position(this.Bed1);
        ((Entity) Game.get_Player().get_Character()).set_Heading(248.15f);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        Script.Wait(1500);
        Game.FadeScreenIn(500);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed2) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        Game.FadeScreenOut(500);
        Script.Wait(500);
        Function.Call((Hash) -3978201909929952453L, new InputArgument[3]
        {
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Game.get_Player().set_WantedLevel(0);
        Function.Call((Hash) -8078852494817208297L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        Function.Call((Hash) -7173663049392046466L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        ((Entity) Game.get_Player().get_Character()).set_Position(this.Bed2);
        ((Entity) Game.get_Player().get_Character()).set_Heading(248.15f);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        Script.Wait(1500);
        Game.FadeScreenIn(500);
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed3) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
      {
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(true);
        Game.FadeScreenOut(500);
        Script.Wait(500);
        Function.Call((Hash) -3978201909929952453L, new InputArgument[3]
        {
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Game.get_Player().set_WantedLevel(0);
        Function.Call((Hash) -8078852494817208297L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        Function.Call((Hash) -7173663049392046466L, new InputArgument[1]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character())
        });
        ((Entity) Game.get_Player().get_Character()).set_Position(this.Bed3);
        ((Entity) Game.get_Player().get_Character()).set_Heading(248.15f);
        Function.Call((Hash) -5409910488053730831L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        Function.Call((Hash) 7856627101237848957L, new InputArgument[1]
        {
          InputArgument.op_Implicit(0.0f)
        });
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        Script.Wait(1500);
        Game.FadeScreenIn(500);
      }
    }
  }
}
