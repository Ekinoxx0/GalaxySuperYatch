// Decompiled with JetBrains decompiler
// Type: GalaxyClassSuperYacht.Class1
// Assembly: GalaxyClassSuperYacht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42A2DBA5-30B0-484C-8C74-FA366416FDCC
// Assembly location: C:\Users\Ekinoxx\Desktop\GalaxyClassSuperYacht.dll

using GTA;
using GTA.Math;
using GTA.Native;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace GalaxyClassSuperYacht
{
  internal class Class1 : Script
  {
    private ScriptSettings Config;
    private MenuPool modMenuPool;
    private UIMenu mainMenu;
    private UIMenu methgarage;
    private List<WeaponHash> weapons;
    public Vector3 Dockloc;
    public Vector3 LotLoc;
    public List<Ped> Guards;
    public List<Ped> Driver;
    public bool Foundoldchair;
    public string officetext;
    public bool CleanUpO1;
    public bool CleanUpO2;
    public bool CleanUpO3;
    public bool CleanUpO4;
    public string CurrentText;
    public int currentFont;
    public int currentColor;
    public bool CreatedAssistant;
    public bool GoldRails;
    public int ShipColor;
    public int RailsColor;
    public int Purchased;
    public int YachtType;
    public int Location;
    public int Lighting;
    public int LightingColor;
    public int H1;
    public int H2;
    public List<Ped> Peds;
    public int PedType;
    public List<string> FlagList;
    public int CurrentFlag;
    public int AmountOfSeaSharks;
    public int BoatAType;
    public int BoatBType;
    public bool ShowTestBlips;
    public int SpawnDist;
    public bool ShowDistWhenClose;
    public Vector3 YachtPurchaseLoc;
    public Blip purchaseBlip;

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.Purchased = (int) this.Config.GetValue<int>("Yacht", "Purchased", (M0) this.Purchased);
        this.GoldRails = (bool) this.Config.GetValue<bool>("Yacht", "GoldRails", (M0) (this.GoldRails ? 1 : 0));
        this.ShipColor = (int) this.Config.GetValue<int>("Yacht", "ShipColor", (M0) this.ShipColor);
        this.RailsColor = (int) this.Config.GetValue<int>("Yacht", "RailsColor", (M0) this.RailsColor);
        this.YachtType = (int) this.Config.GetValue<int>("Yacht", "YachtType", (M0) this.YachtType);
        this.Location = (int) this.Config.GetValue<int>("Yacht", "Location", (M0) this.Location);
        this.Lighting = (int) this.Config.GetValue<int>("Yacht", "Lighting", (M0) this.Lighting);
        this.LightingColor = (int) this.Config.GetValue<int>("Yacht", "LightingColor", (M0) this.LightingColor);
        this.H1 = (int) this.Config.GetValue<int>("Yacht", "HeliA", (M0) this.H1);
        this.H2 = (int) this.Config.GetValue<int>("Yacht", "HeliB", (M0) this.H2);
        this.PedType = (int) this.Config.GetValue<int>("Yacht", "PedType", (M0) this.PedType);
        this.CurrentFlag = (int) this.Config.GetValue<int>("Yacht", "CurrentFlag", (M0) this.CurrentFlag);
        this.ShowTestBlips = (bool) this.Config.GetValue<bool>("Yacht", "ShowTestBlips", (M0) (this.ShowTestBlips ? 1 : 0));
        this.AmountOfSeaSharks = (int) this.Config.GetValue<int>("Yacht", "AmountOfSeaSharks", (M0) this.AmountOfSeaSharks);
        this.BoatAType = (int) this.Config.GetValue<int>("Yacht", "BoatAType", (M0) this.BoatAType);
        this.BoatBType = (int) this.Config.GetValue<int>("Yacht", "BoatBType", (M0) this.BoatBType);
        this.SpawnDist = (int) this.Config.GetValue<int>("Yacht", "SpawnDist", (M0) this.SpawnDist);
        this.ShowDistWhenClose = (bool) this.Config.GetValue<bool>("Yacht", "ShowDistWhenClose", (M0) (this.ShowDistWhenClose ? 1 : 0));
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: MazeBank.ini Failed To Load.");
      }
    }

    public Class1()
    {
      base.\u002Ector();
      this.LoadIniFile("scripts//GalaxyClassSuperYacht//Yacht.ini");
      this.Setup();
      this.add_Tick(new EventHandler(this.OnTick));
      this.add_Aborted(new EventHandler(this.OnShutdown));
    }

    private void SetupMarker()
    {
      this.purchaseBlip = World.CreateBlip(this.YachtPurchaseLoc);
      this.purchaseBlip.set_Sprite((BlipSprite) 455);
      this.purchaseBlip.set_Name("Purchase Yacht Here");
    }

    private void Setup()
    {
      this.SetupMarker();
      this.modMenuPool = new MenuPool();
      this.mainMenu = new UIMenu("Galaxy Super Yacht", "Select an Option");
      this.modMenuPool.Add(this.mainMenu);
      this.methgarage = this.modMenuPool.AddSubMenu(this.mainMenu, "Purchase Options");
      this.Setupbuisness();
    }

    private void Setupbuisness()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Class1.\u003C\u003Ec__DisplayClass45_0 cDisplayClass450 = new Class1.\u003C\u003Ec__DisplayClass45_0();
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "The Orion Yacht");
      objectList1.Add((object) "The Pisces Yacht");
      objectList1.Add((object) "The Aquarius Yacht");
      List<object> objectList2 = new List<object>();
      objectList2.Add((object) "");
      objectList2.Add((object) "Wales");
      objectList2.Add((object) "USA");
      objectList2.Add((object) "United Kingdom");
      objectList2.Add((object) "Turkey");
      objectList2.Add((object) "Switzerland");
      objectList2.Add((object) "Sweden");
      objectList2.Add((object) "Spain");
      objectList2.Add((object) "South Korea");
      objectList2.Add((object) "South Africa");
      objectList2.Add((object) "Slovenia");
      objectList2.Add((object) "Slovakia");
      objectList2.Add((object) "Script");
      objectList2.Add((object) "Scotland");
      objectList2.Add((object) "Russia");
      objectList2.Add((object) "Puertorico");
      objectList2.Add((object) "Portugal");
      objectList2.Add((object) "Poland");
      objectList2.Add((object) "Palestine");
      objectList2.Add((object) "Norway");
      objectList2.Add((object) "Nigeria");
      objectList2.Add((object) "New Zealand");
      objectList2.Add((object) "Netherlands");
      objectList2.Add((object) "Mexico");
      objectList2.Add((object) "Malta");
      objectList2.Add((object) "Istein");
      objectList2.Add((object) "Japan");
      objectList2.Add((object) "Jamaica");
      objectList2.Add((object) "Italy");
      objectList2.Add((object) "Israel");
      objectList2.Add((object) "Ireland");
      objectList2.Add((object) "Hungary");
      objectList2.Add((object) "German");
      objectList2.Add((object) "France");
      objectList2.Add((object) "Finland");
      objectList2.Add((object) "EU");
      objectList2.Add((object) "England");
      objectList2.Add((object) "Denmark");
      objectList2.Add((object) "Czech Republic");
      objectList2.Add((object) "Croatia");
      objectList2.Add((object) "Colombia");
      objectList2.Add((object) "China");
      objectList2.Add((object) "Canada");
      objectList2.Add((object) "Brazil");
      objectList2.Add((object) "Belgium");
      objectList2.Add((object) "Austria");
      objectList2.Add((object) "Australia");
      objectList2.Add((object) "Argentina");
      List<object> objectList3 = new List<object>();
      objectList3.Add((object) "");
      objectList3.Add((object) " Zancudo River 1 ");
      objectList3.Add((object) "Zancudo River 2 ");
      objectList3.Add((object) "Zancudo River 3 ");
      objectList3.Add((object) "Zancudo Base 1 ");
      objectList3.Add((object) "Zancudo Base 2 ");
      objectList3.Add((object) "Zancudo Base 3 ");
      objectList3.Add((object) "North Chumash 1 ");
      objectList3.Add((object) "North Chumash 2 ");
      objectList3.Add((object) "North Chumash 3 ");
      objectList3.Add((object) "Vespucci Beach 1 ");
      objectList3.Add((object) "Vespucci Beach 2 ");
      objectList3.Add((object) "Vespucci Beach 3 ");
      objectList3.Add((object) "LSIA 1 ");
      objectList3.Add((object) "LSIA 2 ");
      objectList3.Add((object) "LSIA 3 ");
      objectList3.Add((object) "Docks 1 ");
      objectList3.Add((object) "Docks 2 ");
      objectList3.Add((object) "Docks 3 ");
      objectList3.Add((object) "Palomino Highlands 1 ");
      objectList3.Add((object) "Palomino Highlands 2 ");
      objectList3.Add((object) "Palomino Highlands 3 ");
      objectList3.Add((object) "Tavarium Mountains 1 ");
      objectList3.Add((object) "Tavarium Mountains 2 ");
      objectList3.Add((object) "Tavarium Mountains 3 ");
      objectList3.Add((object) "San Chianski Mountain Range 1 ");
      objectList3.Add((object) "San Chianski Mountain Range 2 ");
      objectList3.Add((object) "San Chianski Mountain Range 3 ");
      objectList3.Add((object) "Mount Gordo 1 ");
      objectList3.Add((object) "Mount Gordo 2 ");
      objectList3.Add((object) "Mount Gordo 3 ");
      objectList3.Add((object) "Propocio Beach 1 ");
      objectList3.Add((object) "Propocio Beach 2 ");
      objectList3.Add((object) "Propocio Beach 3 ");
      objectList3.Add((object) "Paleto Bay 1 ");
      objectList3.Add((object) "Paleto Bay 2 ");
      objectList3.Add((object) "Paleto Bay 3 ");
      objectList3.Add((object) "Summer Update Location");
      List<object> objectList4 = new List<object>();
      objectList4.Add((object) false);
      objectList4.Add((object) true);
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) "Presidential Green");
      objectList5.Add((object) "Presidential Blue");
      objectList5.Add((object) "Presidential Rose");
      objectList5.Add((object) "Presidential Gold");
      objectList5.Add((object) "Vivacious Green");
      objectList5.Add((object) "Vivacious Blue");
      objectList5.Add((object) "Vivacious Rose");
      objectList5.Add((object) "Vivacious Gold");
      List<object> objectList6 = new List<object>();
      objectList6.Add((object) "Pacific - White/Blue");
      objectList6.Add((object) "Nautical - White/Blue");
      objectList6.Add((object) "Mariner - White/Green");
      objectList6.Add((object) "Merchant - White/Red");
      objectList6.Add((object) "Pristine - White");
      objectList6.Add((object) "Azure - White/Blue");
      objectList6.Add((object) "Uniform - White/Black");
      objectList6.Add((object) "Ruby - White/Red");
      objectList6.Add((object) "Mediterranean - White/Red");
      objectList6.Add((object) "Vintage - Cream/Beige & Blue");
      objectList6.Add((object) "Continental - Cream/Beige & Gray");
      objectList6.Add((object) "Battleship - Dark Gray");
      objectList6.Add((object) "Command - Dark Gray/Light Gray");
      objectList6.Add((object) "Classico - White/Dark Gray ");
      objectList6.Add((object) "Intrepid - Black/Red");
      objectList6.Add((object) "Voyager - Green/Yellow");
      List<object> objectList7 = new List<object>();
      objectList7.Add((object) "None");
      objectList7.Add((object) "Swift");
      objectList7.Add((object) "Maverick");
      objectList7.Add((object) "Supervolto");
      objectList7.Add((object) "Volatus");
      objectList7.Add((object) "Supervolto Carbon");
      objectList7.Add((object) "Swift Deluxe");
      List<object> objectList8 = new List<object>();
      objectList8.Add((object) "None");
      objectList8.Add((object) "Speeder");
      objectList8.Add((object) "Jetmax");
      objectList8.Add((object) "Dinghy 2 seater");
      objectList8.Add((object) "Dinghy 4 seater");
      objectList8.Add((object) "Toro ");
      objectList8.Add((object) "Toro (Yacht Version)");
      objectList8.Add((object) "Marquis");
      List<object> objectList9 = new List<object>();
      objectList9.Add((object) "None");
      objectList9.Add((object) "1");
      objectList9.Add((object) "2");
      objectList9.Add((object) "3");
      objectList9.Add((object) "4");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.YachtPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.GoldRailingPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.LightsPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.DesignPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.HeliAPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.HeliBPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.SeaSharkPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.BoatAPrice = 0.0f;
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.BoatBPrice = 0.0f;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.methgarage, "Buy/Change Yacht ");
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.YT = new UIMenuListItem("Yacht Type : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.YT);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.Yloc = new UIMenuListItem("Location : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.Yloc);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.Goldbars = new UIMenuListItem("Gold Railings : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.Goldbars);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.Lighting = new UIMenuListItem("Lighting : ", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.Lighting);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.Design = new UIMenuListItem("Design : ", objectList6, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.Design);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.Flag = new UIMenuListItem("Flag : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.Flag);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.HeliA = new UIMenuListItem("Heli A : ", objectList7, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.HeliA);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.HeliB = new UIMenuListItem("Heli B : ", objectList7, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.HeliB);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.SShark = new UIMenuListItem("Amount of Sea Sharks : ", objectList9, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.SShark);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.BA = new UIMenuListItem("Boat A : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.BA);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.BB = new UIMenuListItem("Boat B : ", objectList8, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) cDisplayClass450.BB);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.YCost = new UIMenuItem("Cost : $");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass450.YCost);
      // ISSUE: reference to a compiler-generated field
      cDisplayClass450.YBuy = new UIMenuItem("Buy Yacht");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(cDisplayClass450.YBuy);
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) cDisplayClass450, __methodptr(\u003CSetupbuisness\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) cDisplayClass450, __methodptr(\u003CSetupbuisness\u003Eb__1)));
    }

    private void OnTick(object sender, EventArgs e)
    {
      this.OnKeyDown();
      if (this.modMenuPool != null && this.modMenuPool.IsAnyMenuOpen())
        this.modMenuPool.ProcessMenus();
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPurchaseLoc) < 2.0)
        this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to open the Menu to Purchase a ~g~ Galaxy Super Yacht ~w~");
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPurchaseLoc) >= 60.0)
        return;
      World.DrawMarker((MarkerType) 1, this.YachtPurchaseLoc, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(1f, 1f, 1f), Color.Green);
    }

    private void DisplayHelpTextThisFrame(string text)
    {
      Function.Call((Hash) -8860350453193909743L, new InputArgument[1]
      {
        InputArgument.op_Implicit("STRING")
      });
      Function.Call((Hash) 7789129354908300458L, new InputArgument[1]
      {
        InputArgument.op_Implicit(text)
      });
      Function.Call((Hash) 2562546386151446694L, new InputArgument[4]
      {
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(1),
        InputArgument.op_Implicit(-1)
      });
    }

    private void OnKeyDown()
    {
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPurchaseLoc) >= 3.0 || !Game.IsControlJustPressed(2, (Control) 51))
        return;
      this.mainMenu.set_Visible(!this.mainMenu.get_Visible());
    }

    private void OnShutdown(object sender, EventArgs e)
    {
      if (!Blip.op_Inequality(this.purchaseBlip, (Blip) null))
        return;
      this.purchaseBlip.Remove();
    }
  }
}
