using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GTA;
using GTA.Math;
using GTA.Native;
using NativeUI;

namespace GalaxyClassSuperYacht
{
	// Token: 0x02000002 RID: 2
	internal class Class1 : Script
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		private void LoadIniFile(string iniName)
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
				UI.Notify("~r~Error~w~: MazeBank.ini Failed To Load.");
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000022EC File Offset: 0x000004EC
		public Class1()
		{
			this.LoadIniFile("scripts//GalaxyClassSuperYacht//Yacht.ini");
			this.Setup();
			base.Tick += this.OnTick;
			base.Aborted += this.OnShutdown;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000023FB File Offset: 0x000005FB
		private void SetupMarker()
		{
			this.purchaseBlip = World.CreateBlip(this.YachtPurchaseLoc);
			this.purchaseBlip.Sprite = 455;
			this.purchaseBlip.Name = "Purchase Yacht Here";
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002434 File Offset: 0x00000634
		private void Setup()
		{
			this.SetupMarker();
			this.modMenuPool = new MenuPool();
			this.mainMenu = new UIMenu("Galaxy Super Yacht", "Select an Option");
			this.modMenuPool.Add(this.mainMenu);
			this.methgarage = this.modMenuPool.AddSubMenu(this.mainMenu, "Purchase Options");
			this.Setupbuisness();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000024A0 File Offset: 0x000006A0
		private void Setupbuisness()
		{
			List<object> list = new List<object>();
			list.Add("The Orion Yacht");
			list.Add("The Pisces Yacht");
			list.Add("The Aquarius Yacht");
			List<object> list2 = new List<object>();
			list2.Add("");
			list2.Add("Wales");
			list2.Add("USA");
			list2.Add("United Kingdom");
			list2.Add("Turkey");
			list2.Add("Switzerland");
			list2.Add("Sweden");
			list2.Add("Spain");
			list2.Add("South Korea");
			list2.Add("South Africa");
			list2.Add("Slovenia");
			list2.Add("Slovakia");
			list2.Add("Script");
			list2.Add("Scotland");
			list2.Add("Russia");
			list2.Add("Puertorico");
			list2.Add("Portugal");
			list2.Add("Poland");
			list2.Add("Palestine");
			list2.Add("Norway");
			list2.Add("Nigeria");
			list2.Add("New Zealand");
			list2.Add("Netherlands");
			list2.Add("Mexico");
			list2.Add("Malta");
			list2.Add("Istein");
			list2.Add("Japan");
			list2.Add("Jamaica");
			list2.Add("Italy");
			list2.Add("Israel");
			list2.Add("Ireland");
			list2.Add("Hungary");
			list2.Add("German");
			list2.Add("France");
			list2.Add("Finland");
			list2.Add("EU");
			list2.Add("England");
			list2.Add("Denmark");
			list2.Add("Czech Republic");
			list2.Add("Croatia");
			list2.Add("Colombia");
			list2.Add("China");
			list2.Add("Canada");
			list2.Add("Brazil");
			list2.Add("Belgium");
			list2.Add("Austria");
			list2.Add("Australia");
			list2.Add("Argentina");
			List<object> list3 = new List<object>();
			list3.Add("");
			list3.Add(" Zancudo River 1 ");
			list3.Add("Zancudo River 2 ");
			list3.Add("Zancudo River 3 ");
			list3.Add("Zancudo Base 1 ");
			list3.Add("Zancudo Base 2 ");
			list3.Add("Zancudo Base 3 ");
			list3.Add("North Chumash 1 ");
			list3.Add("North Chumash 2 ");
			list3.Add("North Chumash 3 ");
			list3.Add("Vespucci Beach 1 ");
			list3.Add("Vespucci Beach 2 ");
			list3.Add("Vespucci Beach 3 ");
			list3.Add("LSIA 1 ");
			list3.Add("LSIA 2 ");
			list3.Add("LSIA 3 ");
			list3.Add("Docks 1 ");
			list3.Add("Docks 2 ");
			list3.Add("Docks 3 ");
			list3.Add("Palomino Highlands 1 ");
			list3.Add("Palomino Highlands 2 ");
			list3.Add("Palomino Highlands 3 ");
			list3.Add("Tavarium Mountains 1 ");
			list3.Add("Tavarium Mountains 2 ");
			list3.Add("Tavarium Mountains 3 ");
			list3.Add("San Chianski Mountain Range 1 ");
			list3.Add("San Chianski Mountain Range 2 ");
			list3.Add("San Chianski Mountain Range 3 ");
			list3.Add("Mount Gordo 1 ");
			list3.Add("Mount Gordo 2 ");
			list3.Add("Mount Gordo 3 ");
			list3.Add("Propocio Beach 1 ");
			list3.Add("Propocio Beach 2 ");
			list3.Add("Propocio Beach 3 ");
			list3.Add("Paleto Bay 1 ");
			list3.Add("Paleto Bay 2 ");
			list3.Add("Paleto Bay 3 ");
			list3.Add("Summer Update Location");
			List<object> list4 = new List<object>();
			list4.Add(false);
			list4.Add(true);
			List<object> list5 = new List<object>();
			list5.Add("Presidential Green");
			list5.Add("Presidential Blue");
			list5.Add("Presidential Rose");
			list5.Add("Presidential Gold");
			list5.Add("Vivacious Green");
			list5.Add("Vivacious Blue");
			list5.Add("Vivacious Rose");
			list5.Add("Vivacious Gold");
			List<object> list6 = new List<object>();
			list6.Add("Pacific - White/Blue");
			list6.Add("Nautical - White/Blue");
			list6.Add("Mariner - White/Green");
			list6.Add("Merchant - White/Red");
			list6.Add("Pristine - White");
			list6.Add("Azure - White/Blue");
			list6.Add("Uniform - White/Black");
			list6.Add("Ruby - White/Red");
			list6.Add("Mediterranean - White/Red");
			list6.Add("Vintage - Cream/Beige & Blue");
			list6.Add("Continental - Cream/Beige & Gray");
			list6.Add("Battleship - Dark Gray");
			list6.Add("Command - Dark Gray/Light Gray");
			list6.Add("Classico - White/Dark Gray ");
			list6.Add("Intrepid - Black/Red");
			list6.Add("Voyager - Green/Yellow");
			List<object> list7 = new List<object>();
			list7.Add("None");
			list7.Add("Swift");
			list7.Add("Maverick");
			list7.Add("Supervolto");
			list7.Add("Volatus");
			list7.Add("Supervolto Carbon");
			list7.Add("Swift Deluxe");
			List<object> list8 = new List<object>();
			list8.Add("None");
			list8.Add("Speeder");
			list8.Add("Jetmax");
			list8.Add("Dinghy 2 seater");
			list8.Add("Dinghy 4 seater");
			list8.Add("Toro ");
			list8.Add("Toro (Yacht Version)");
			list8.Add("Marquis");
			List<object> list9 = new List<object>();
			list9.Add("None");
			list9.Add("1");
			list9.Add("2");
			list9.Add("3");
			list9.Add("4");
			float YachtPrice = 0f;
			float GoldRailingPrice = 0f;
			float LightsPrice = 0f;
			float DesignPrice = 0f;
			float HeliAPrice = 0f;
			float HeliBPrice = 0f;
			float SeaSharkPrice = 0f;
			float BoatAPrice = 0f;
			float BoatBPrice = 0f;
			UIMenu uimenu = this.modMenuPool.AddSubMenu(this.methgarage, "Buy/Change Yacht ");
			UIMenuListItem YT = new UIMenuListItem("Yacht Type : ", list, 0);
			uimenu.AddItem(YT);
			UIMenuListItem Yloc = new UIMenuListItem("Location : ", list3, 0);
			uimenu.AddItem(Yloc);
			UIMenuListItem Goldbars = new UIMenuListItem("Gold Railings : ", list4, 0);
			uimenu.AddItem(Goldbars);
			UIMenuListItem Lighting = new UIMenuListItem("Lighting : ", list5, 0);
			uimenu.AddItem(Lighting);
			UIMenuListItem Design = new UIMenuListItem("Design : ", list6, 0);
			uimenu.AddItem(Design);
			UIMenuListItem Flag = new UIMenuListItem("Flag : ", list2, 0);
			uimenu.AddItem(Flag);
			UIMenuListItem HeliA = new UIMenuListItem("Heli A : ", list7, 0);
			uimenu.AddItem(HeliA);
			UIMenuListItem HeliB = new UIMenuListItem("Heli B : ", list7, 0);
			uimenu.AddItem(HeliB);
			UIMenuListItem SShark = new UIMenuListItem("Amount of Sea Sharks : ", list9, 0);
			uimenu.AddItem(SShark);
			UIMenuListItem BA = new UIMenuListItem("Boat A : ", list8, 0);
			uimenu.AddItem(BA);
			UIMenuListItem BB = new UIMenuListItem("Boat B : ", list8, 0);
			uimenu.AddItem(BB);
			UIMenuItem YCost = new UIMenuItem("Cost : $");
			uimenu.AddItem(YCost);
			UIMenuItem YBuy = new UIMenuItem("Buy Yacht");
			uimenu.AddItem(YBuy);
			uimenu.OnListChange += delegate(UIMenu sender, UIMenuListItem item, int index)
			{
				bool flag = BA.Index == 0;
				if (flag)
				{
					BoatAPrice = 0f;
				}
				bool flag2 = BA.Index == 1;
				if (flag2)
				{
					BoatAPrice = 325000f;
				}
				bool flag3 = BA.Index == 2;
				if (flag3)
				{
					BoatAPrice = 300000f;
				}
				bool flag4 = BA.Index == 3;
				if (flag4)
				{
					BoatAPrice = 105000f;
				}
				bool flag5 = BA.Index == 4;
				if (flag5)
				{
					BoatAPrice = 125000f;
				}
				bool flag6 = BA.Index == 5;
				if (flag6)
				{
					BoatAPrice = 1750000f;
				}
				bool flag7 = BA.Index == 6;
				if (flag7)
				{
					BoatAPrice = 1750000f;
				}
				bool flag8 = BA.Index == 7;
				if (flag8)
				{
					BoatAPrice = 413000f;
				}
				bool flag9 = BB.Index == 0;
				if (flag9)
				{
					BoatBPrice = 0f;
				}
				bool flag10 = BB.Index == 1;
				if (flag10)
				{
					BoatBPrice = 325000f;
				}
				bool flag11 = BB.Index == 2;
				if (flag11)
				{
					BoatBPrice = 300000f;
				}
				bool flag12 = BB.Index == 3;
				if (flag12)
				{
					BoatBPrice = 105000f;
				}
				bool flag13 = BB.Index == 4;
				if (flag13)
				{
					BoatBPrice = 125000f;
				}
				bool flag14 = BB.Index == 5;
				if (flag14)
				{
					BoatBPrice = 1750000f;
				}
				bool flag15 = BB.Index == 6;
				if (flag15)
				{
					BoatBPrice = 1900000f;
				}
				bool flag16 = BB.Index == 7;
				if (flag16)
				{
					BoatBPrice = 413000f;
				}
				bool flag17 = SShark.Index == 0;
				if (flag17)
				{
					SeaSharkPrice = 0f;
				}
				bool flag18 = SShark.Index == 1;
				if (flag18)
				{
					SeaSharkPrice = 18000f;
				}
				bool flag19 = SShark.Index == 2;
				if (flag19)
				{
					SeaSharkPrice = 36000f;
				}
				bool flag20 = SShark.Index == 3;
				if (flag20)
				{
					SeaSharkPrice = 54000f;
				}
				bool flag21 = SShark.Index == 3;
				if (flag21)
				{
					SeaSharkPrice = 90000f;
				}
				bool flag22 = YT.Index == 0;
				if (flag22)
				{
					YachtPrice = 6000000f;
				}
				bool flag23 = YT.Index == 1;
				if (flag23)
				{
					YachtPrice = 7000000f;
				}
				bool flag24 = YT.Index == 2;
				if (flag24)
				{
					YachtPrice = 8000000f;
				}
				bool flag25 = Goldbars.Index == 0;
				if (flag25)
				{
					GoldRailingPrice = 100000f;
				}
				bool flag26 = Goldbars.Index == 1;
				if (flag26)
				{
					GoldRailingPrice = 750000f;
				}
				bool flag27 = Lighting.Index == 0;
				if (flag27)
				{
					LightsPrice = 300000f;
				}
				bool flag28 = Lighting.Index == 1;
				if (flag28)
				{
					LightsPrice = 315000f;
				}
				bool flag29 = Lighting.Index == 2;
				if (flag29)
				{
					LightsPrice = 330000f;
				}
				bool flag30 = Lighting.Index == 3;
				if (flag30)
				{
					LightsPrice = 350000f;
				}
				bool flag31 = Lighting.Index == 4;
				if (flag31)
				{
					LightsPrice = 500000f;
				}
				bool flag32 = Lighting.Index == 5;
				if (flag32)
				{
					LightsPrice = 525000f;
				}
				bool flag33 = Lighting.Index == 6;
				if (flag33)
				{
					LightsPrice = 550000f;
				}
				bool flag34 = Lighting.Index == 7;
				if (flag34)
				{
					LightsPrice = 600000f;
				}
				bool flag35 = Design.Index == 0;
				if (flag35)
				{
					DesignPrice = 100000f;
				}
				bool flag36 = Design.Index == 1;
				if (flag36)
				{
					DesignPrice = 135000f;
				}
				bool flag37 = Design.Index == 2;
				if (flag37)
				{
					DesignPrice = 170000f;
				}
				bool flag38 = Design.Index == 3;
				if (flag38)
				{
					DesignPrice = 195000f;
				}
				bool flag39 = Design.Index == 4;
				if (flag39)
				{
					DesignPrice = 220000f;
				}
				bool flag40 = Design.Index == 5;
				if (flag40)
				{
					DesignPrice = 300000f;
				}
				bool flag41 = Design.Index == 6;
				if (flag41)
				{
					DesignPrice = 315000f;
				}
				bool flag42 = Design.Index == 7;
				if (flag42)
				{
					DesignPrice = 340000f;
				}
				bool flag43 = Design.Index == 8;
				if (flag43)
				{
					DesignPrice = 365000f;
				}
				bool flag44 = Design.Index == 9;
				if (flag44)
				{
					DesignPrice = 425000f;
				}
				bool flag45 = Design.Index == 10;
				if (flag45)
				{
					DesignPrice = 450000f;
				}
				bool flag46 = Design.Index == 11;
				if (flag46)
				{
					DesignPrice = 475000f;
				}
				bool flag47 = Design.Index == 12;
				if (flag47)
				{
					DesignPrice = 495000f;
				}
				bool flag48 = Design.Index == 13;
				if (flag48)
				{
					DesignPrice = 620000f;
				}
				bool flag49 = Design.Index == 14;
				if (flag49)
				{
					DesignPrice = 635000f;
				}
				bool flag50 = Design.Index == 15;
				if (flag50)
				{
					DesignPrice = 650000f;
				}
				bool flag51 = Design.Index == 16;
				if (flag51)
				{
					DesignPrice = 680000f;
				}
				bool flag52 = HeliA.Index == 0;
				if (flag52)
				{
					HeliAPrice = 0f;
				}
				bool flag53 = HeliA.Index == 1;
				if (flag53)
				{
					HeliAPrice = 100000f;
				}
				bool flag54 = HeliA.Index == 2;
				if (flag54)
				{
					HeliAPrice = 780000f;
				}
				bool flag55 = HeliA.Index == 3;
				if (flag55)
				{
					HeliAPrice = 800000f;
				}
				bool flag56 = HeliA.Index == 4;
				if (flag56)
				{
					HeliAPrice = 1100000f;
				}
				bool flag57 = HeliA.Index == 5;
				if (flag57)
				{
					HeliAPrice = 1400000f;
				}
				bool flag58 = HeliA.Index == 6;
				if (flag58)
				{
					HeliAPrice = 5150000f;
				}
				bool flag59 = HeliB.Index == 0;
				if (flag59)
				{
					HeliBPrice = 0f;
				}
				bool flag60 = HeliB.Index == 1;
				if (flag60)
				{
					HeliBPrice = 100000f;
				}
				bool flag61 = HeliB.Index == 1;
				if (flag61)
				{
					HeliBPrice = 780000f;
				}
				bool flag62 = HeliB.Index == 2;
				if (flag62)
				{
					HeliBPrice = 800000f;
				}
				bool flag63 = HeliB.Index == 3;
				if (flag63)
				{
					HeliBPrice = 1100000f;
				}
				bool flag64 = HeliB.Index == 4;
				if (flag64)
				{
					HeliBPrice = 1400000f;
				}
				bool flag65 = HeliB.Index == 5;
				if (flag65)
				{
					HeliBPrice = 5150000f;
				}
				YCost.Text = "Cost : $" + (YachtPrice + GoldRailingPrice + LightsPrice + DesignPrice + HeliAPrice + HeliBPrice + SeaSharkPrice + BoatAPrice + BoatBPrice).ToString("N");
			};
			uimenu.OnItemSelect += delegate(UIMenu sender, UIMenuItem item, int index)
			{
				bool flag = item == YBuy;
				if (flag)
				{
					bool flag2 = BA.Index == 0;
					if (flag2)
					{
						BoatAPrice = 0f;
					}
					bool flag3 = BA.Index == 1;
					if (flag3)
					{
						BoatAPrice = 325000f;
					}
					bool flag4 = BA.Index == 2;
					if (flag4)
					{
						BoatAPrice = 300000f;
					}
					bool flag5 = BA.Index == 3;
					if (flag5)
					{
						BoatAPrice = 105000f;
					}
					bool flag6 = BA.Index == 4;
					if (flag6)
					{
						BoatAPrice = 125000f;
					}
					bool flag7 = BA.Index == 5;
					if (flag7)
					{
						BoatAPrice = 1750000f;
					}
					bool flag8 = BA.Index == 6;
					if (flag8)
					{
						BoatAPrice = 1750000f;
					}
					bool flag9 = BA.Index == 7;
					if (flag9)
					{
						BoatAPrice = 413000f;
					}
					bool flag10 = BB.Index == 0;
					if (flag10)
					{
						BoatBPrice = 0f;
					}
					bool flag11 = BB.Index == 1;
					if (flag11)
					{
						BoatBPrice = 325000f;
					}
					bool flag12 = BB.Index == 2;
					if (flag12)
					{
						BoatBPrice = 300000f;
					}
					bool flag13 = BB.Index == 3;
					if (flag13)
					{
						BoatBPrice = 105000f;
					}
					bool flag14 = BB.Index == 4;
					if (flag14)
					{
						BoatBPrice = 125000f;
					}
					bool flag15 = BB.Index == 5;
					if (flag15)
					{
						BoatBPrice = 1750000f;
					}
					bool flag16 = BB.Index == 6;
					if (flag16)
					{
						BoatBPrice = 1900000f;
					}
					bool flag17 = BB.Index == 7;
					if (flag17)
					{
						BoatBPrice = 413000f;
					}
					bool flag18 = SShark.Index == 0;
					if (flag18)
					{
						SeaSharkPrice = 0f;
					}
					bool flag19 = SShark.Index == 1;
					if (flag19)
					{
						SeaSharkPrice = 18000f;
					}
					bool flag20 = SShark.Index == 2;
					if (flag20)
					{
						SeaSharkPrice = 36000f;
					}
					bool flag21 = SShark.Index == 3;
					if (flag21)
					{
						SeaSharkPrice = 54000f;
					}
					bool flag22 = SShark.Index == 3;
					if (flag22)
					{
						SeaSharkPrice = 90000f;
					}
					bool flag23 = YT.Index == 0;
					if (flag23)
					{
						YachtPrice = 6000000f;
					}
					bool flag24 = YT.Index == 1;
					if (flag24)
					{
						YachtPrice = 7000000f;
					}
					bool flag25 = YT.Index == 2;
					if (flag25)
					{
						YachtPrice = 8000000f;
					}
					bool flag26 = Goldbars.Index == 0;
					if (flag26)
					{
						GoldRailingPrice = 100000f;
					}
					bool flag27 = Goldbars.Index == 1;
					if (flag27)
					{
						GoldRailingPrice = 750000f;
					}
					bool flag28 = Lighting.Index == 0;
					if (flag28)
					{
						LightsPrice = 300000f;
					}
					bool flag29 = Lighting.Index == 1;
					if (flag29)
					{
						LightsPrice = 315000f;
					}
					bool flag30 = Lighting.Index == 2;
					if (flag30)
					{
						LightsPrice = 330000f;
					}
					bool flag31 = Lighting.Index == 3;
					if (flag31)
					{
						LightsPrice = 350000f;
					}
					bool flag32 = Lighting.Index == 4;
					if (flag32)
					{
						LightsPrice = 500000f;
					}
					bool flag33 = Lighting.Index == 5;
					if (flag33)
					{
						LightsPrice = 525000f;
					}
					bool flag34 = Lighting.Index == 6;
					if (flag34)
					{
						LightsPrice = 550000f;
					}
					bool flag35 = Lighting.Index == 7;
					if (flag35)
					{
						LightsPrice = 600000f;
					}
					bool flag36 = Design.Index == 0;
					if (flag36)
					{
						DesignPrice = 100000f;
					}
					bool flag37 = Design.Index == 1;
					if (flag37)
					{
						DesignPrice = 135000f;
					}
					bool flag38 = Design.Index == 2;
					if (flag38)
					{
						DesignPrice = 170000f;
					}
					bool flag39 = Design.Index == 3;
					if (flag39)
					{
						DesignPrice = 195000f;
					}
					bool flag40 = Design.Index == 4;
					if (flag40)
					{
						DesignPrice = 220000f;
					}
					bool flag41 = Design.Index == 5;
					if (flag41)
					{
						DesignPrice = 300000f;
					}
					bool flag42 = Design.Index == 6;
					if (flag42)
					{
						DesignPrice = 315000f;
					}
					bool flag43 = Design.Index == 7;
					if (flag43)
					{
						DesignPrice = 340000f;
					}
					bool flag44 = Design.Index == 8;
					if (flag44)
					{
						DesignPrice = 365000f;
					}
					bool flag45 = Design.Index == 9;
					if (flag45)
					{
						DesignPrice = 425000f;
					}
					bool flag46 = Design.Index == 10;
					if (flag46)
					{
						DesignPrice = 450000f;
					}
					bool flag47 = Design.Index == 11;
					if (flag47)
					{
						DesignPrice = 475000f;
					}
					bool flag48 = Design.Index == 12;
					if (flag48)
					{
						DesignPrice = 495000f;
					}
					bool flag49 = Design.Index == 13;
					if (flag49)
					{
						DesignPrice = 620000f;
					}
					bool flag50 = Design.Index == 14;
					if (flag50)
					{
						DesignPrice = 635000f;
					}
					bool flag51 = Design.Index == 15;
					if (flag51)
					{
						DesignPrice = 650000f;
					}
					bool flag52 = HeliA.Index == 0;
					if (flag52)
					{
						HeliAPrice = 0f;
					}
					bool flag53 = HeliA.Index == 1;
					if (flag53)
					{
						HeliAPrice = 100000f;
					}
					bool flag54 = HeliA.Index == 2;
					if (flag54)
					{
						HeliAPrice = 780000f;
					}
					bool flag55 = HeliA.Index == 3;
					if (flag55)
					{
						HeliAPrice = 800000f;
					}
					bool flag56 = HeliA.Index == 4;
					if (flag56)
					{
						HeliAPrice = 1100000f;
					}
					bool flag57 = HeliA.Index == 5;
					if (flag57)
					{
						HeliAPrice = 1400000f;
					}
					bool flag58 = HeliA.Index == 6;
					if (flag58)
					{
						HeliAPrice = 5150000f;
					}
					bool flag59 = HeliB.Index == 0;
					if (flag59)
					{
						HeliBPrice = 0f;
					}
					bool flag60 = HeliB.Index == 1;
					if (flag60)
					{
						HeliBPrice = 100000f;
					}
					bool flag61 = HeliB.Index == 1;
					if (flag61)
					{
						HeliBPrice = 780000f;
					}
					bool flag62 = HeliB.Index == 2;
					if (flag62)
					{
						HeliBPrice = 800000f;
					}
					bool flag63 = HeliB.Index == 3;
					if (flag63)
					{
						HeliBPrice = 1100000f;
					}
					bool flag64 = HeliB.Index == 4;
					if (flag64)
					{
						HeliBPrice = 1400000f;
					}
					bool flag65 = HeliB.Index == 5;
					if (flag65)
					{
						HeliBPrice = 5150000f;
					}
					YCost.Text = "Cost : $" + (YachtPrice + GoldRailingPrice + LightsPrice + DesignPrice + HeliAPrice + HeliBPrice + SeaSharkPrice + BoatAPrice + BoatBPrice).ToString("N");
					bool flag66 = (float)Game.Player.Money >= YachtPrice + GoldRailingPrice + LightsPrice + DesignPrice + HeliAPrice + HeliBPrice + SeaSharkPrice + BoatAPrice + BoatBPrice;
					if (flag66)
					{
						this.LoadIniFile("scripts//GalaxyClassSuperYacht//Yacht.ini");
						Game.Player.Money -= (int)(YachtPrice + GoldRailingPrice + LightsPrice + DesignPrice + HeliAPrice + HeliBPrice);
						int num = 1;
						int num2 = num;
						this.Config.SetValue<int>("Yacht", "Purchased", num2);
						bool flag67 = Goldbars.Index == 0;
						if (flag67)
						{
						}
						this.Config.SetValue<bool>("Yacht", "GoldRails", false);
						bool flag68 = Goldbars.Index == 1;
						if (flag68)
						{
						}
						this.Config.SetValue<bool>("Yacht", "GoldRails", true);
						bool flag69 = Design.Index == 0;
						if (flag69)
						{
							int num3 = 0;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag70 = Design.Index == 1;
						if (flag70)
						{
							int num3 = 2;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag71 = Design.Index == 2;
						if (flag71)
						{
							int num3 = 10;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag72 = Design.Index == 3;
						if (flag72)
						{
							int num3 = 14;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag73 = Design.Index == 4;
						if (flag73)
						{
							int num3 = 13;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag74 = Design.Index == 5;
						if (flag74)
						{
							int num3 = 1;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag75 = Design.Index == 6;
						if (flag75)
						{
							int num3 = 6;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag76 = Design.Index == 7;
						if (flag76)
						{
							int num3 = 11;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag77 = Design.Index == 8;
						if (flag77)
						{
							int num3 = 8;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag78 = Design.Index == 9;
						if (flag78)
						{
							int num3 = 12;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag79 = Design.Index == 10;
						if (flag79)
						{
							int num3 = 3;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag80 = Design.Index == 12;
						if (flag80)
						{
							int num3 = 4;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag81 = Design.Index == 13;
						if (flag81)
						{
							int num3 = 9;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag82 = Design.Index == 14;
						if (flag82)
						{
							int num3 = 7;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag83 = Design.Index == 15;
						if (flag83)
						{
							int num3 = 5;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						bool flag84 = Design.Index == 16;
						if (flag84)
						{
							int num3 = 15;
							this.Config.SetValue<int>("Yacht", "ShipColor", num3);
							this.Config.Save();
						}
						int index2 = YT.Index;
						this.Config.SetValue<int>("Yacht", "YachtType", index2);
						int index3 = Yloc.Index;
						this.Config.SetValue<int>("Yacht", "Location", index3);
						bool flag85 = Lighting.Index <= 3;
						if (flag85)
						{
							int num4 = 1;
							this.Config.SetValue<int>("Yacht", "Lighting", num4);
							this.Config.Save();
						}
						bool flag86 = Lighting.Index >= 4;
						if (flag86)
						{
							int num4 = 2;
							this.Config.SetValue<int>("Yacht", "Lighting", num4);
							this.Config.Save();
						}
						UI.Notify("test4");
						bool flag87 = Lighting.Index == 0;
						if (flag87)
						{
							int num5 = 1;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag88 = Lighting.Index == 1;
						if (flag88)
						{
							int num5 = 2;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag89 = Lighting.Index == 2;
						if (flag89)
						{
							int num5 = 3;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag90 = Lighting.Index == 3;
						if (flag90)
						{
							int num5 = 4;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag91 = Lighting.Index == 4;
						if (flag91)
						{
							int num5 = 1;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag92 = Lighting.Index == 5;
						if (flag92)
						{
							int num5 = 2;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag93 = Lighting.Index == 6;
						if (flag93)
						{
							int num5 = 3;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						bool flag94 = Lighting.Index == 7;
						if (flag94)
						{
							int num5 = 4;
							this.Config.SetValue<int>("Yacht", "LightingColor", num5);
							this.Config.Save();
						}
						this.Config.Save();
						int num6 = Flag.Index - 1;
						this.Config.SetValue<int>("Yacht", "CurrentFlag", num6);
						int index4 = HeliA.Index;
						this.Config.SetValue<int>("Yacht", "HeliA", index4);
						this.Config.Save();
						int index5 = HeliB.Index;
						this.Config.SetValue<int>("Yacht", "HeliB", index5);
						this.Config.Save();
						int index6 = SShark.Index;
						this.Config.SetValue<int>("Yacht", "AmountOfSeaSharks", index6);
						int index7 = BA.Index;
						this.Config.SetValue<int>("Yacht", "BoatAType", index7);
						int index8 = BB.Index;
						this.Config.SetValue<int>("Yacht", "BoatBType", index8);
						this.Config.Save();
						this.modMenuPool.CloseAllMenus();
						Game.Player.Character.Position = new Vector3(2000f, 2000f, 1000f);
						UI.Notify("Purchase Successful, you new Yacht is at the designated location!, if you didnt own a Yacht before, please reload the mod, if not it should spawn ");
						Script.Wait(1);
						Game.Player.Character.Position = this.YachtPurchaseLoc;
					}
					else
					{
						UI.Notify("You dont have enough money to purchase a Yacht");
					}
				}
			};
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002DCC File Offset: 0x00000FCC
		private void OnTick(object sender, EventArgs e)
		{
			this.OnKeyDown();
			bool flag = this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen();
			if (flag)
			{
				this.modMenuPool.ProcessMenus();
			}
			bool flag2 = World.GetDistance(Game.Player.Character.Position, this.YachtPurchaseLoc) < 2f;
			if (flag2)
			{
				this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to open the Menu to Purchase a ~g~ Galaxy Super Yacht ~w~");
			}
			bool flag3 = World.GetDistance(Game.Player.Character.Position, this.YachtPurchaseLoc) < 60f;
			if (flag3)
			{
				World.DrawMarker(1, this.YachtPurchaseLoc, Vector3.Zero, Vector3.Zero, new Vector3(1f, 1f, 1f), Color.Green);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002E94 File Offset: 0x00001094
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

		// Token: 0x06000008 RID: 8 RVA: 0x00002F24 File Offset: 0x00001124
		private void OnKeyDown()
		{
			bool flag = World.GetDistance(Game.Player.Character.Position, this.YachtPurchaseLoc) < 3f;
			if (flag)
			{
				bool flag2 = Game.IsControlJustPressed(2, 51);
				if (flag2)
				{
					this.mainMenu.Visible = !this.mainMenu.Visible;
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002F84 File Offset: 0x00001184
		private void OnShutdown(object sender, EventArgs e)
		{
			bool flag = true;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = this.purchaseBlip != null;
				if (flag3)
				{
					this.purchaseBlip.Remove();
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private ScriptSettings Config;

		// Token: 0x04000002 RID: 2
		private MenuPool modMenuPool;

		// Token: 0x04000003 RID: 3
		private UIMenu mainMenu;

		// Token: 0x04000004 RID: 4
		private UIMenu methgarage;

		// Token: 0x04000005 RID: 5
		private List<WeaponHash> weapons = Enum.GetValues(typeof(WeaponHash)).Cast<WeaponHash>().ToList<WeaponHash>();

		// Token: 0x04000006 RID: 6
		public Vector3 Dockloc;

		// Token: 0x04000007 RID: 7
		public Vector3 LotLoc;

		// Token: 0x04000008 RID: 8
		public List<Ped> Guards = new List<Ped>();

		// Token: 0x04000009 RID: 9
		public List<Ped> Driver = new List<Ped>();

		// Token: 0x0400000A RID: 10
		public bool Foundoldchair = false;

		// Token: 0x0400000B RID: 11
		public string officetext = "Office";

		// Token: 0x0400000C RID: 12
		public bool CleanUpO1 = false;

		// Token: 0x0400000D RID: 13
		public bool CleanUpO2 = false;

		// Token: 0x0400000E RID: 14
		public bool CleanUpO3 = false;

		// Token: 0x0400000F RID: 15
		public bool CleanUpO4 = false;

		// Token: 0x04000010 RID: 16
		public string CurrentText = "HKH";

		// Token: 0x04000011 RID: 17
		public int currentFont = 5;

		// Token: 0x04000012 RID: 18
		public int currentColor = 1;

		// Token: 0x04000013 RID: 19
		public bool CreatedAssistant = false;

		// Token: 0x04000014 RID: 20
		public bool GoldRails;

		// Token: 0x04000015 RID: 21
		public int ShipColor;

		// Token: 0x04000016 RID: 22
		public int RailsColor;

		// Token: 0x04000017 RID: 23
		public int Purchased;

		// Token: 0x04000018 RID: 24
		public int YachtType;

		// Token: 0x04000019 RID: 25
		public int Location;

		// Token: 0x0400001A RID: 26
		public int Lighting;

		// Token: 0x0400001B RID: 27
		public int LightingColor;

		// Token: 0x0400001C RID: 28
		public int H1;

		// Token: 0x0400001D RID: 29
		public int H2;

		// Token: 0x0400001E RID: 30
		public List<Ped> Peds = new List<Ped>();

		// Token: 0x0400001F RID: 31
		public int PedType = 1;

		// Token: 0x04000020 RID: 32
		public List<string> FlagList = new List<string>();

		// Token: 0x04000021 RID: 33
		public int CurrentFlag = 2;

		// Token: 0x04000022 RID: 34
		public int AmountOfSeaSharks;

		// Token: 0x04000023 RID: 35
		public int BoatAType;

		// Token: 0x04000024 RID: 36
		public int BoatBType;

		// Token: 0x04000025 RID: 37
		public bool ShowTestBlips;

		// Token: 0x04000026 RID: 38
		public int SpawnDist;

		// Token: 0x04000027 RID: 39
		public bool ShowDistWhenClose;

		// Token: 0x04000028 RID: 40
		public Vector3 YachtPurchaseLoc = new Vector3(-714.5474f, -1297.115f, 4f);

		// Token: 0x04000029 RID: 41
		public Blip purchaseBlip;
	}
}
