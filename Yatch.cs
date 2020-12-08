// Decompiled with JetBrains decompiler
// Type: GalaxyClassSuperYacht.Yacht
// Assembly: GalaxyClassSuperYacht, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 42A2DBA5-30B0-484C-8C74-FA366416FDCC
// Assembly location: C:\Users\Ekinoxx\Desktop\GalaxyClassSuperYacht.dll

using GTA;
using GTA.Math;
using GTA.Native;
using Microsoft.CSharp.RuntimeBinder;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GalaxyClassSuperYacht
{
  public class Yacht : Script
  {
    private Vector3 PlayerYachtPos1;
    private Vector3 PlayerYachtPos2;
    private Vector3 PlayerYachtPos3;
    private Vector3 PlayerYachtPos4;
    private Vector3 PlayerYachtPos5;
    private Vector3 PlayerYachtPos6;
    private Vector3 PlayerYachtPos7;
    private Vector3 PlayerYachtPos8;
    private Vector3 PlayerYachtPos9;
    private Vector3 PlayerYachtPos10;
    private Vector3 PlayerYachtPos11;
    private Vector3 PlayerYachtPos12;
    private Vector3 PlayerYachtPos13;
    private Vector3 PlayerYachtPos14;
    private Vector3 PlayerYachtPos15;
    private Vector3 PlayerYachtPos16;
    private Vector3 PlayerYachtPos17;
    private Vector3 PlayerYachtPos18;
    private Vector3 PlayerYachtPos19;
    private Vector3 PlayerYachtPos20;
    private Vector3 PlayerYachtPos21;
    private Vector3 PlayerYachtPos22;
    private Vector3 PlayerYachtPos23;
    private Vector3 PlayerYachtPos24;
    private Vector3 PlayerYachtPos25;
    private Vector3 PlayerYachtPos26;
    private Vector3 PlayerYachtPos27;
    private Vector3 PlayerYachtPos28;
    private Vector3 PlayerYachtPos29;
    private Vector3 PlayerYachtPos30;
    private Vector3 PlayerYachtPos31;
    private Vector3 PlayerYachtPos32;
    private Vector3 PlayerYachtPos33;
    private Vector3 PlayerYachtPos34;
    private Vector3 PlayerYachtPos35;
    private Vector3 PlayerYachtPos36;
    public List<Vector3> YachtPos;
    public List<string> YachtHashs;
    public List<string> YachtHashs2;
    public List<Blip> Blips;
    public List<string> YachtLocSring;
    public List<Prop> Props;
    private string Rail;
    private string YachtTop;
    private string YachtLauncher;
    private ScriptSettings Config;
    public Vector3 MenuMarker;
    public Vector3 SleepPos1;
    public Vector3 SleepPos2;
    public Vector3 HeliPosA;
    public Vector3 HeliPosB;
    public Vehicle HeliA;
    public Vehicle HeliB;
    public Vector3 Jacuzzi;
    public Vector3 BarEnter;
    public Vector3 BarExit;
    public Vector3 CaptinsQuartersEnter;
    public Vector3 CaptinsQuartersExit;
    public Vector3 BackEntranceOffset;
    public Vector3 BackIntOffset;
    public Vector3 CaptEntranceOffset;
    public Vector3 CaptIntOffset;
    public Vector3 CaptComputerOffset;
    public Vector3 MenuOffset;
    public Vector3 HeliPadAOffset;
    public Vector3 HeliPadBOffset;
    public int MaxHelis;
    public bool GoldRails;
    public int ShipColor;
    public int RailsColor;
    public Vector3 ChangeLocMarker;
    public int Purchased;
    public int YachtType;
    public int Location;
    public int Lighting;
    public int LightingColor;
    public bool Created;
    public int DoorType;
    public Prop DoorA;
    public Prop DoorB;
    public Prop DoorC;
    public int H1;
    public int H2;
    public Vector3 jacuzziSeat1;
    public float J_rot1;
    public Vector3 jacuzziSeat2;
    public float J_rot2;
    public Vector3 jacuzziSeat3;
    public float J_rot3;
    public Vector3 jacuzziSeat4;
    public float J_rot4;
    public Vector3 jacuzziSeat5;
    public float J_rot5;
    public Vector3 jacuzziSeat6;
    public float J_rot6;
    public bool IsinHottub;
    public List<Ped> Peds;
    private float Speed;
    private Vehicle Car;
    public int PedType;
    private MenuPool ChangePosPool;
    private UIMenu ChangePosMainMenu;
    private UIMenu ChangePosMenu;
    public WeaponTint Liv;
    public int ID_O;
    public string ID_C;
    public int Comp;
    public Vector3 Bed1;
    public Vector3 Bed2;
    public Vector3 Bed3;
    public Vector3 BarPos;
    public Vector3 BarDrinkPos;
    public Ped Bargirl;
    public List<string> FlagList;
    public int CurrentFlag;
    public Prop FlagA;
    public Prop FlagB;
    public Prop FlagC;
    public Vector3 FlagPosA;
    public Vector3 FlagPosB;
    public Vector3 FlagPosC;
    public Vector3 ShowerAPos;
    public Vector3 ShowerAPosEnter;
    public Vector3 ShowerBPos;
    public Vector3 ShowerBPosEnter;
    public Vector3 ShowerCPos;
    public Vector3 ShowerCPosEnter;
    public bool InShower;
    public int AmountOfSeaSharks;
    public Vector3 SeaSharkPosA;
    public Vector3 SeaSharkPosB;
    public Vector3 SeaSharkPosC;
    public Vector3 SeaSharkPosD;
    public Vehicle SeaSharkA;
    public Vehicle SeaSharkB;
    public Vehicle SeaSharkC;
    public Vehicle SeaSharkD;
    public Vector3 BoatAPos;
    public Vector3 BoatBPos;
    public Vehicle BoatA;
    public Vehicle BoatB;
    public int BoatAType;
    public int BoatBType;
    public bool ShowTestBlips;
    public bool WaitForCreated;
    public Vector3 WoredrobeAPos;
    public Vector3 WoredrobeBPos;
    public Vector3 WoredrobeCPos;
    public MenuPool Woredrobepool;
    public UIMenu WoredrobeMainMenu;
    public UIMenu WoredrobeMenu;
    public int CompMax;
    public int DrawableMax;
    public Model OldCharacter;
    public MenuPool DrinksPool;
    public UIMenu DrinksMenu;
    public UIMenu DrinksMainMenu;
    public Prop Champaine;
    public bool IsDrinking;
    public int DrinkTimer;
    public List<Prop> Champ;
    public int Effect;
    public bool RadioOn;
    public int Station;
    public List<Vector3> RadioPos;
    public Vector3 CurrentRadio;
    public int CurrentInt;
    public float Z_min;
    public float Z_max;
    public bool isDrinking;
    public Prop Base;
    public Prop Base2;
    public Prop YachtBase;
    private string YachtHash;
    public int SpawnDist;
    public bool ShowDistWhenClose;
    public int LoadTime;
    public Vector3 MarkerEnter;
    public Vector3 MarkerExit;
    public Vector3 RoofEnterMarker;
    public Vector3 RoofExitMarker;
    public Vector3 HeliSpawn;
    public Vector3 GarageMarker;
    public Vector3 CarSpawn;
    public Vector3 WherehouseMarker;
    public Vector3 WherehouseEnter;
    private Keys Key1;
    public Vector3 BuyMarker;
    public Vector3 BuyMarker2;
    public int num;
    private MenuPool modMenuPool;
    private UIMenu mainMenu;
    private UIMenu methgarage;
    private UIMenu ProductStock;
    public bool bought;
    public int purchaselvl;
    public int maxstocks;
    public float stocksvalue;
    public float profitMargin;
    public int stockscount;
    public int stockstimer;
    public int waittime;
    public int DisplayWait;
    public bool EnemySetup;
    public int Chooseenemynum;
    public Vehicle VehicleId;
    public bool VehicleSetup;
    private List<WeaponHash> weapons;
    public string carid;
    public int vehiclemissionid;
    public bool setupdelivery;
    public Vector3 DeliveryMaker;
    public Blip DeliveryLoc;
    public Blip ballasBlip1;
    public Vector3 Deliverypoint;
    public UIMenu Garage;
    public UIMenu Sourcingmenu;
    public UIMenu SupplyRunsmenu;
    public UIMenu OrganizationOptions;
    public bool setupwantedfordelivery;
    public int waittimeforwanted;
    public Vehicle AirVehicle;
    public int BuzzardBought;
    public int FMJBought;
    public int A911Bought;
    public int X80Bought;
    public int SEVEN70Bought;
    public int wherehosuebought;
    public int cargaragebought;
    public VehicleHash VehicleIdentifier;
    public Vehicle VehicleName;
    public bool foundvehicleyet;
    public Vector3 Vehicleloc;
    public Blip VehicleMarker;
    public Vehicle Vehicletoget;
    public Vector3 VehicleSpawn;
    public bool hasgotvehicle;
    public Random VehicleLoc;
    public Random VehicleRan;
    public Vehicle VehicleMissioncar;
    public Vector3 VehicleLocation;
    public int Missionnum;
    public Blip DestoryVehicle;
    public int Aircraftstorage;
    public bool warnedplayer;
    public Vector3 AircraftStorageLoc;
    public Blip AircraftStorageMarker;
    public Blip VehicleWarehouseMarker;
    public int GunLockerBought;
    public int MoneyVaultBought;
    public int DockBought;
    public int VehicleLotBought;
    public Vector3 Dockloc;
    public Blip DockBlip;
    public Vector3 LotLoc;
    public Blip LotBlip;
    public float SourcingPayout;
    public bool SourcingCheckingforDamage;
    public int AATrailerABought;
    public int AATrailerBBought;
    public int AATrailerCBought;
    public string OrganizationName;
    public UIMenu AssetRecoveryMenu;
    public bool TriggeredWanted;
    public int ValkyrieBought;
    public int AkulaBought;
    public int HunterBought;
    public int SavageBought;
    public int AnnihilatorBought;
    public Vehicle Vehicle1;
    public Vehicle Vehicle2;
    public Vehicle Vehicle3;
    public Blip ConvoyBlip1;
    public Blip ConvoyBlip2;
    public Blip ConvoyBlip3;
    public int convoysetup;
    public bool checkforconvoy;
    public int UseCustomWaitTime;
    public bool setWaittime;
    public Vector3 Radiopos;
    public int turretedlimo;
    public int assassinationmission;
    public int assassinationpayout;
    public Blip TowerBlip;
    public string Design;
    public Vector3 SleepPos;
    public Vector3 MBTOfficeSitRespawnPos;
    public Vector3 MBTOfficeSitPos;
    public bool sitting;
    public UIMenu Sourcingmenu2;
    public string SourcedVehicle;
    public bool NewVehicleSourcing;
    public float increaseGain;
    public bool ShowMarker;
    public bool InModGarage;
    public UIMenu SpecialMissions;
    public List<Ped> Guards;
    public List<Ped> Driver;
    public Vehicle VtoGet;
    public Blip VtoGetBlip;
    public bool GotCar;
    public Vehicle VtoGet1;
    public Vehicle VtoGet2;
    public Vehicle VtoGet3;
    public int Vehiclesleft;
    public Blip DropzoneBlip;
    public Vector3 Dropzone;
    public bool VehicleisDamaged;
    public int Vehiclehealth;
    public Vehicle RentedVehicle;
    public bool startedRent;
    public int RentTimer;
    public int RentalvehicleHealth;
    public bool ISinPiracyScamMission;
    public int Piracymission;
    public int TimerLeft;
    public VehicleHash RandomVehicle;
    public bool HackhasStarted;
    public Vector3 GoPoint;
    public int StockTimer;
    public int StockTimer2;
    public float stocktoloose;
    public bool IsScriptEnabled;
    public Vector3 ChairPos;
    public float P_Rotation;
    public bool IsSittinginCeoSeat;
    public string WarehousePos;
    public Camera WarehouseCam;
    public bool WCamOn;
    public bool MenuOn;
    public bool Foundyacht;
    public bool DeletedYacht;
    public Prop PropYachtBase;
    public bool Firsttime;

    public Model RequestModel(int Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(100);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(string Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(100);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(VehicleHash Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public Model RequestModel(PedHash Name)
    {
      Model model;
      ((Model) ref model).\u002Ector(Name);
      ((Model) ref model).Request(10000);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(50);
        return model;
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      return model;
    }

    public void Drinks()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass166_0 displayClass1660 = new Yacht.\u003C\u003Ec__DisplayClass166_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1660.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.DrinksPool.AddSubMenu(this.DrinksMenu, nameof (Drinks));
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkA = new UIMenuItem("Pisswasser                                               $25");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkA);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkB = new UIMenuItem("Vodka Shot                                              $75");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkB);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkC = new UIMenuItem("The Mount Whiskey Shot                       $250");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkC);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkD = new UIMenuItem("Richard's Whiskey Shot                       $1,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkD);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkE = new UIMenuItem("Macbeth Whiskey Shot                       $5,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkE);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkF = new UIMenuItem("Bleuter'd Champaine Slver                $30,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkF);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkG = new UIMenuItem("Bleuter'd Champaine Gold                $50,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkG);
      // ISSUE: reference to a compiler-generated field
      displayClass1660.DrinkH = new UIMenuItem("Bleuter'd Champaine Diamond        $150,000");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass1660.DrinkH);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass1660, __methodptr(\u003CDrinks\u003Eb__0)));
    }

    public int CheckClothes(int T, int RComp, int RDraw)
    {
      int num = 0;
      if (T == 1)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character()),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) 2834476523764480066L, new InputArgument[2]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(RComp)
          });
      }
      if (T == 2)
      {
        if ((bool) Function.Call<bool>((Hash) -1718696417760418019L, new InputArgument[3]
        {
          InputArgument.op_Implicit(Game.get_Player().get_Character()),
          InputArgument.op_Implicit(RComp),
          InputArgument.op_Implicit(RDraw)
        }))
          num = (int) Function.Call<int>((Hash) -8110606195499570259L, new InputArgument[3]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(RComp),
            InputArgument.op_Implicit(RDraw)
          });
      }
      return num;
    }

    public void Setoutfit(int i)
    {
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character()),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0)
      });
      if (Model.op_Inequality(((Entity) Game.get_Player().get_Character()).get_Model(), Model.op_Implicit((PedHash) 1885233650)))
        this.OldCharacter = ((Entity) Game.get_Player().get_Character()).get_Model();
      Function.Call((Hash) -6164042450715612628L, new InputArgument[2]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character()),
        InputArgument.op_Implicit(1.0)
      });
      Function.Call((Hash) 2328651364711703671L, new InputArgument[1]
      {
        InputArgument.op_Implicit(Game.get_Player().get_Character())
      });
      Model model;
      ((Model) ref model).\u002Ector((PedHash) 1885233650);
      ((Model) ref model).Request(500);
      if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
      {
        while (!((Model) ref model).get_IsLoaded())
          Script.Wait(100);
        Function.Call((Hash) 45540521788082230L, new InputArgument[2]
        {
          InputArgument.op_Implicit(Game.get_Player()),
          InputArgument.op_Implicit(((Model) ref model).get_Hash())
        });
      }
      ((Model) ref model).MarkAsNoLongerNeeded();
      Ped character = Game.get_Player().get_Character();
      Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
      {
        InputArgument.op_Implicit(character),
        InputArgument.op_Implicit(-1),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(17)
      });
      bool flag = false;
      string idC = this.ID_C;
      if (i == 0)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(125),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 1)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(89),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(55),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(54),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 2 && idC.Equals("Outfit Default"))
      {
        if (!flag && !idC.Equals("Outfit Default"))
          UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        int num = new Random().Next(1, 100);
        if (num <= 25)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(38),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 25 && num <= 50)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(112),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 50 && num <= 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        if (num > 75)
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(104),
            InputArgument.op_Implicit(25),
            InputArgument.op_Implicit(1)
          });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(34),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(69),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(125),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(68),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (i == 3)
      {
        if (idC.Equals("Blue"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Black") || idC.Equals("Outfit Default"))
        {
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(91),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(46),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(97),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(186),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(Game.get_Player().get_Character()),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 4)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(275),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 5)
      {
        if (idC.Equals("Black"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("White"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(13),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(14),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(15),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Red"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(142),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(19),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(107),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(84),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(276),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 6)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(134),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(147),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(167),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(113),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(90),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(286),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(135),
            InputArgument.op_Implicit(0)
          });
        }
      }
      if (i == 7)
      {
        if (idC.Equals("Outfit Default"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(115),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(17),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(34),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(69),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(128),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(130),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i == 8)
      {
        if (idC.Equals("Green"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Purple"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Pink"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Orange"))
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (!flag)
        {
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
        if (idC.Equals("Outfit Default") || !flag)
        {
          if (!flag && !idC.Equals("Outfit Default"))
            UI.Notify("~y~Warning~w~ this Outfit did not have the specified color, setting to default, color chosen : " + idC);
          flag = true;
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(133),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(17)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(1),
            InputArgument.op_Implicit(108),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(3),
            InputArgument.op_Implicit(166),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(4),
            InputArgument.op_Implicit(110),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(5),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(6),
            InputArgument.op_Implicit(88),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(7),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(8),
            InputArgument.op_Implicit(2),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(9),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(10),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(11),
            InputArgument.op_Implicit(283),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
          Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
          {
            InputArgument.op_Implicit(character),
            InputArgument.op_Implicit(12),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(0),
            InputArgument.op_Implicit(1)
          });
        }
      }
      if (i != 9)
        return;
      if (idC.Equals("Outfit Default"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Green"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("White"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Blue"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (idC.Equals("Black"))
      {
        flag = true;
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
      if (!flag)
      {
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) -7838678542154536097L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(91),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(17)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(2),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(3),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(4),
          InputArgument.op_Implicit(77),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(5),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(6),
          InputArgument.op_Implicit(55),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(7),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(8),
          InputArgument.op_Implicit(130),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(9),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(10),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(11),
          InputArgument.op_Implicit(178),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
        Function.Call((Hash) 2750315038012726912L, new InputArgument[5]
        {
          InputArgument.op_Implicit(character),
          InputArgument.op_Implicit(12),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(1)
        });
      }
    }

    public void WareDrobe()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass176_0 displayClass1760 = new Yacht.\u003C\u003Ec__DisplayClass176_0();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Save");
      objectList1.Add((object) "Load");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot1.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot2.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot3.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot4.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot5.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot6.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot7.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot8.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot9.ini");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Slots.Add((object) "Slot10.ini");
      List<object> objectList2 = new List<object>()
      {
        (object) (WeaponHash) -1569615261,
        (object) (WeaponHash) -1716189206,
        (object) (WeaponHash) 1737195953,
        (object) (WeaponHash) 1317494643,
        (object) (WeaponHash) -102973651,
        (object) (WeaponHash) -656458692,
        (object) (WeaponHash) -581044007,
        (object) (WeaponHash) -1810795771,
        (object) (WeaponHash) 419712736,
        (object) (WeaponHash) -538741184,
        (object) (WeaponHash) 1141786504,
        (object) (WeaponHash) -1951375401
      };
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Outfit Default");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Blue");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Green");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Red");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Orange");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Pink");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Purple");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "White");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Colours.Add((object) "Black");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Soldier");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Cloaker");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Hacker");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Juggernaut");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Arena War A");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Arena War B");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Space Marine");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Commando");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Space Suit");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Outfits.Add((object) "Tron");
      List<object> objectList3 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Draw = new List<object>();
      List<object> objectList4 = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Tex = new List<object>();
      for (int index = 0; index < 999; ++index)
      {
        // ISSUE: reference to a compiler-generated field
        displayClass1760.Tex.Add((object) index);
        // ISSUE: reference to a compiler-generated field
        displayClass1760.Draw.Add((object) index);
        objectList4.Add((object) index);
        objectList3.Add((object) index);
      }
      List<object> objectList5 = new List<object>();
      objectList5.Add((object) " 0 FACE");
      objectList5.Add((object) "1 BEARD");
      objectList5.Add((object) "2 HAIRCUT");
      objectList5.Add((object) "3 SHIRT");
      objectList5.Add((object) "4 PANTS");
      objectList5.Add((object) "5 Hands / Gloves");
      objectList5.Add((object) "6 SHOES");
      objectList5.Add((object) "7 Eyes");
      objectList5.Add((object) "8 Accessories");
      objectList5.Add((object) "9 Mission Items/ Tasks");
      objectList5.Add((object) "10 Decals");
      objectList5.Add((object) "11 Collars and Inner Shirts");
      UIMenu uiMenu1 = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Change Outfit");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1760.O = new UIMenuListItem("", displayClass1760.Outfits, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass1760.O);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass1760.O).set_Description("While Using this outfit you will not be able to purchase anything due to being the MP male");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1760.C = new UIMenuListItem("Color : ", displayClass1760.Colours, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass1760.C);
      // ISSUE: reference to a compiler-generated field
      ((UIMenuItem) displayClass1760.C).set_Description("Use this Colour Whenever possible or use Default");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Set = new UIMenuItem("Wear Outfit ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1760.Set);
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Set.set_Description("~y~ Warning ~w~ Lag is normal while applying outfits, simple alt tab out to avoid crash");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Remove = new UIMenuItem("Remove Outift ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass1760.Remove);
      UIMenu uiMenu2 = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Change Clothes");
      UIMenu uiMenu3 = this.Woredrobepool.AddSubMenu(this.WoredrobeMenu, "Save/Load Outfit");
      // ISSUE: reference to a compiler-generated field
      displayClass1760.SVL = new UIMenuListItem("Function ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass1760.SVL);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Sl = new UIMenuListItem("Slot ", displayClass1760.Slots, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass1760.Sl);
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Get = new UIMenuItem("Save");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass1760.Get);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass1760, __methodptr(\u003CWareDrobe\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu3.add_OnListChange(new ListChangedEvent((object) displayClass1760, __methodptr(\u003CWareDrobe\u003Eb__1)));
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Comp1 = new UIMenuListItem("", objectList5, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1760.Comp1);
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Drawable = new UIMenuListItem("Item : ", objectList3, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1760.Drawable);
      // ISSUE: reference to a compiler-generated field
      displayClass1760.Texture = new UIMenuListItem("Texture : ", objectList4, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass1760.Texture);
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass1760, __methodptr(\u003CWareDrobe\u003Eb__2)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass1760, __methodptr(\u003CWareDrobe\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) displayClass1760, __methodptr(\u003CWareDrobe\u003Eb__4)));
    }

    private void LoadIniFile(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.LoadTime = (int) this.Config.GetValue<int>("SPAWN - SETNOLOWERTHAN_ONE", "TIME", (M0) this.LoadTime);
        this.Key1 = (Keys) this.Config.GetValue<Keys>("Configurations", "Key1", (M0) this.Key1);
        this.purchaselvl = (int) this.Config.GetValue<int>("Setup", "BuisnessLevel", (M0) this.purchaselvl);
        this.stockscount = (int) this.Config.GetValue<int>("Setup", "stockslevel", (M0) this.stockscount);
        this.stocksvalue = (float) this.Config.GetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
        this.BuzzardBought = (int) this.Config.GetValue<int>("Setup", "BuzzardBought", (M0) this.BuzzardBought);
        this.FMJBought = (int) this.Config.GetValue<int>("Setup", "FMJBought", (M0) this.FMJBought);
        this.A911Bought = (int) this.Config.GetValue<int>("Setup", "911Bought", (M0) this.A911Bought);
        this.X80Bought = (int) this.Config.GetValue<int>("Setup", "X80Bought", (M0) this.X80Bought);
        this.SEVEN70Bought = (int) this.Config.GetValue<int>("Setup", "SEVEN70Bought", (M0) this.SEVEN70Bought);
        this.GunLockerBought = (int) this.Config.GetValue<int>("Setup", "GunLockerBought", (M0) this.GunLockerBought);
        this.MoneyVaultBought = (int) this.Config.GetValue<int>("Setup", " MoneyVaultBought", (M0) this.MoneyVaultBought);
        this.AATrailerABought = (int) this.Config.GetValue<int>("Setup", "AATrailerABought", (M0) this.AATrailerABought);
        this.AATrailerBBought = (int) this.Config.GetValue<int>("Setup", "AATrailerBBought", (M0) this.AATrailerBBought);
        this.AATrailerCBought = (int) this.Config.GetValue<int>("Setup", " AATrailerCBought", (M0) this.AATrailerCBought);
        this.ValkyrieBought = (int) this.Config.GetValue<int>("Setup", "ValkyrieBought", (M0) this.ValkyrieBought);
        this.SavageBought = (int) this.Config.GetValue<int>("Setup", "SavageBought", (M0) this.SavageBought);
        this.HunterBought = (int) this.Config.GetValue<int>("Setup", "HunterBought", (M0) this.HunterBought);
        this.AkulaBought = (int) this.Config.GetValue<int>("Setup", "AkulaBought", (M0) this.AkulaBought);
        this.AnnihilatorBought = (int) this.Config.GetValue<int>("Setup", "AnnihilatorBought", (M0) this.AnnihilatorBought);
        this.UseCustomWaitTime = (int) this.Config.GetValue<int>("Setup", "UseCustomWaitTime", (M0) this.UseCustomWaitTime);
        this.turretedlimo = (int) this.Config.GetValue<int>("Setup", "turretedlimo", (M0) this.turretedlimo);
        this.Design = (string) this.Config.GetValue<string>("Design", "InteriorDesign", (M0) this.Design);
        this.maxstocks = 10 * this.purchaselvl;
        float num = (float) (125000 * this.purchaselvl) / 0.75f;
        this.profitMargin = (float) (0.85 * (double) this.purchaselvl + 0.0);
        this.increaseGain = num;
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: ArcadiusTower.ini Failed To Load.");
      }
    }

    private void LoadIniFile2(string iniName)
    {
      try
      {
        this.Config = ScriptSettings.Load(iniName);
        this.Purchased = (int) this.Config.GetValue<int>(nameof (Yacht), "Purchased", (M0) this.Purchased);
        this.GoldRails = (bool) this.Config.GetValue<bool>(nameof (Yacht), "GoldRails", (M0) (this.GoldRails ? 1 : 0));
        this.ShipColor = (int) this.Config.GetValue<int>(nameof (Yacht), "ShipColor", (M0) this.ShipColor);
        this.RailsColor = (int) this.Config.GetValue<int>(nameof (Yacht), "RailsColor", (M0) this.RailsColor);
        this.YachtType = (int) this.Config.GetValue<int>(nameof (Yacht), "YachtType", (M0) this.YachtType);
        this.Location = (int) this.Config.GetValue<int>(nameof (Yacht), "Location", (M0) this.Location);
        this.Lighting = (int) this.Config.GetValue<int>(nameof (Yacht), "Lighting", (M0) this.Lighting);
        this.LightingColor = (int) this.Config.GetValue<int>(nameof (Yacht), "LightingColor", (M0) this.LightingColor);
        this.H1 = (int) this.Config.GetValue<int>(nameof (Yacht), "HeliA", (M0) this.H1);
        this.H2 = (int) this.Config.GetValue<int>(nameof (Yacht), "HeliB", (M0) this.H2);
        this.PedType = (int) this.Config.GetValue<int>(nameof (Yacht), "PedType", (M0) this.PedType);
        this.CurrentFlag = (int) this.Config.GetValue<int>(nameof (Yacht), "CurrentFlag", (M0) this.CurrentFlag);
        this.ShowTestBlips = (bool) this.Config.GetValue<bool>(nameof (Yacht), "ShowTestBlips", (M0) (this.ShowTestBlips ? 1 : 0));
        this.AmountOfSeaSharks = (int) this.Config.GetValue<int>(nameof (Yacht), "AmountOfSeaSharks", (M0) this.AmountOfSeaSharks);
        this.BoatAType = (int) this.Config.GetValue<int>(nameof (Yacht), "BoatAType", (M0) this.BoatAType);
        this.BoatBType = (int) this.Config.GetValue<int>(nameof (Yacht), "BoatBType", (M0) this.BoatBType);
        this.SpawnDist = (int) this.Config.GetValue<int>(nameof (Yacht), "SpawnDist", (M0) this.SpawnDist);
        this.ShowDistWhenClose = (bool) this.Config.GetValue<bool>(nameof (Yacht), "ShowDistWhenClose", (M0) (this.ShowDistWhenClose ? 1 : 0));
      }
      catch (Exception ex)
      {
        UI.Notify("~r~Error~w~: ArcadiusTower.ini Failed To Load.");
      }
    }

    public void Reset()
    {
      this.Delete();
      this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
      this.Created = false;
      Blip blip = World.CreateBlip(new Vector3((float) this.YachtPos[this.Location].X, (float) this.YachtPos[this.Location].Y, (float) this.YachtPos[this.Location].Z));
      blip.set_Sprite((BlipSprite) 455);
      blip.set_Name("Yacht : " + this.Location.ToString() + ", " + this.YachtLocSring[this.Location]);
      blip.set_Color((BlipColor) 2);
      this.Blips.Add(blip);
    }

    public void SpawnProp(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          World.CreateProp(model, Pos, true, false);
          Prop[] propArray = i == 4 || i == 5 || i == 6 ? World.GetNearbyProps(Pos, 2f, model) : World.GetNearbyProps(Pos, 100f, model);
          if (i != 4 && i != 5)
          {
            foreach (Prop prop in propArray)
            {
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
              {
                if (i == 1)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                  Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(prop),
                    InputArgument.op_Implicit(this.ShipColor)
                  });
                }
                if (i == 2)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                  if (!this.GoldRails)
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(prop),
                      InputArgument.op_Implicit(this.RailsColor)
                    });
                  else if (this.GoldRails)
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(prop),
                      InputArgument.op_Implicit(0)
                    });
                }
                if (i == 3)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, 0.0f, 14.5f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                }
                if (i == 6)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(-36.8f, -2.7f, 0.6f), new Vector3(0.0f, 0.0f, 90f));
                  ((Entity) prop).set_HasCollision(true);
                  if (Entity.op_Equality((Entity) this.DoorA, (Entity) null))
                    this.DoorA = prop;
                  this.Props.Add(prop);
                  Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                  {
                    InputArgument.op_Implicit(prop),
                    InputArgument.op_Implicit(this.ShipColor)
                  });
                }
                if (i == 7)
                {
                  ((Entity) prop).AttachTo((Entity) this.Base, 0, new Vector3(-51f, -2f, 0.3f), new Vector3(0.0f, 0.0f, this.GetRoationalAxis()));
                  ((Entity) prop).set_HasCollision(true);
                  this.Props.Add(prop);
                }
              }
            }
          }
          else if (i == 4 || i == 5)
          {
            foreach (Prop prop in propArray)
            {
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
              {
                switch (i)
                {
                  case 4:
                    if (Entity.op_Equality((Entity) this.DoorB, (Entity) null))
                    {
                      this.DoorB = prop;
                      goto label_36;
                    }
                    else
                      goto label_36;
                  case 5:
                    if (Entity.op_Equality((Entity) this.DoorC, (Entity) null))
                    {
                      this.DoorC = prop;
                      goto label_36;
                    }
                    else
                      goto label_36;
                  default:
                    continue;
                }
              }
            }
label_36:;
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnDoor(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.DoorB, (Entity) null))
            this.DoorB = World.CreateProp(model, Pos, false, false);
          if (Entity.op_Equality((Entity) this.DoorC, (Entity) null))
            this.DoorC = World.CreateProp(model, Pos, false, false);
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagA(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagA, (Entity) null))
          {
            this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagA).Delete();
            this.FlagA = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagB(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagB, (Entity) null))
          {
            this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagB).Delete();
            this.FlagB = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public void SpawnFlagC(string Prop, Vector3 Pos, Vector3 Rot, int i)
    {
      try
      {
        Model model;
        ((Model) ref model).\u002Ector(Prop);
        ((Model) ref model).Request(250);
        if (((Model) ref model).get_IsInCdImage() && ((Model) ref model).get_IsValid())
        {
          while (!((Model) ref model).get_IsLoaded())
            Script.Wait(50);
          World.GetNearbyProps(Pos, 100f, model);
          if (Entity.op_Equality((Entity) this.FlagC, (Entity) null))
          {
            this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
          }
          else
          {
            ((Entity) this.FlagC).Delete();
            this.FlagC = World.CreateProp(model, Pos, Rot, false, false);
          }
        }
        ((Model) ref model).MarkAsNoLongerNeeded();
      }
      catch (Exception ex)
      {
        UI.Notify("~r~ Prop : ~w~" + Prop + "~r~ Failed to spawn");
      }
    }

    public Yacht()
    {
      base.\u002Ector();
      this.add_Tick(new EventHandler(this.OnTick));
      this.add_Aborted(new EventHandler(this.OnShutdown));
      this.set_Interval(1);
      this.Setup();
    }

    public void AddPeds()
    {
      this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.Bargirl, (Entity) null))
        ((Entity) this.Bargirl).Delete();
      if (this.PedType != 0)
        ;
      if (this.PedType == 1)
      {
        Random random = new Random();
        int num1 = random.Next(1, 100);
        if (num1 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 2);
        else if (num1 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 1);
        Script.Wait(1);
        this.IsinHottub = false;
        int num2 = random.Next(1, 100);
        if (num2 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 2);
        else if (num2 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 1);
        Script.Wait(1);
        int num3 = random.Next(1, 100);
        if (num3 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 220.0)), 2);
        else if (num3 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 200.0)), 1);
        Script.Wait(1);
        int num4 = random.Next(1, 100);
        if (num4 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 2);
        else if (num4 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 1);
        Script.Wait(1);
        int num5 = random.Next(1, 100);
        if (num5 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 2);
        else if (num5 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 1);
        Script.Wait(1);
      }
      if (this.PedType == 2)
      {
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 1);
        Script.Wait(1);
        this.IsinHottub = false;
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 220.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat6, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 1);
        Script.Wait(1);
      }
      if (this.PedType == 3)
      {
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 1);
        Script.Wait(1);
        this.IsinHottub = false;
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 220.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -945854168), this.jacuzziSeat6, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 1);
        Script.Wait(1);
      }
      if (this.PedType == 4)
      {
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 1);
        Script.Wait(1);
        this.IsinHottub = false;
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 220.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 1);
        Script.Wait(1);
        this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat6, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 1);
        Script.Wait(1);
      }
      if (this.PedType == 5)
      {
        Random random = new Random();
        int num1 = random.Next(1, 100);
        if (num1 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 2);
        else if (num1 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat2, (float) (((Entity) this.Base).get_Rotation().Z - 5.0)), 1);
        Script.Wait(1);
        this.IsinHottub = false;
        int num2 = random.Next(1, 100);
        if (num2 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 2);
        else if (num2 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat3, (float) (((Entity) this.Base).get_Rotation().Z + 150.0)), 1);
        Script.Wait(1);
        int num3 = random.Next(1, 100);
        if (num3 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 220.0)), 2);
        else if (num3 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat4, (float) (((Entity) this.Base).get_Rotation().Z + 200.0)), 1);
        Script.Wait(1);
        int num4 = random.Next(1, 100);
        if (num4 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 2);
        else if (num4 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat5, (float) (((Entity) this.Base).get_Rotation().Z - 30.0)), 1);
        Script.Wait(1);
        int num5 = random.Next(1, 100);
        if (num5 < 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) 1077785853), this.jacuzziSeat6, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 2);
        else if (num5 > 50)
          this.PlayAnim(World.CreatePed(Model.op_Implicit((PedHash) -1661836925), this.jacuzziSeat6, (float) (((Entity) this.Base).get_Rotation().Z + 280.0)), 1);
        Script.Wait(1);
      }
      this.Bargirl = World.CreatePed(Model.op_Implicit((PedHash) 848542158), this.BarPos);
      ((Entity) this.Bargirl).set_Rotation(new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z + 90.0)));
      this.Bargirl.get_Task().PlayAnimation("anim@amb@yacht@bow@female@variation_01@", "base", 8f, -1, true, -1f);
    }

    public void YachtMenu()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass348_0 displayClass3480 = new Yacht.\u003C\u003Ec__DisplayClass348_0()
      {
        \u003C\u003E4__this = this,
        Dist = new List<object>()
      };
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 200);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 250);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 300);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 350);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 400);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 450);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 500);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 550);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 600);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 650);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 700);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 750);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 800);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 900);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1000);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1100);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1200);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1300);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1400);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1500);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1600);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1700);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1800);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 1900);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2000);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2100);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2200);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2300);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2400);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) 2500);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Dist.Add((object) "Spawn on game Load");
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "None");
      objectList1.Add((object) "Male & Female");
      objectList1.Add((object) "Male");
      objectList1.Add((object) "Female");
      objectList1.Add((object) "Female - Topless");
      objectList1.Add((object) "Male & Female - Topless");
      // ISSUE: reference to a compiler-generated field
      displayClass3480.TF = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3480.TF.Add((object) false);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.TF.Add((object) true);
      List<object> objectList2 = new List<object>();
      foreach (string str in this.YachtLocSring)
        objectList2.Add((object) str);
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Change Position");
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Yloc = new UIMenuListItem("Location : ", objectList2, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass3480.Yloc);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.ChangeLoc = new UIMenuItem("Change Location  -$25000");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3480.ChangeLoc);
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass3480, __methodptr(\u003CYachtMenu\u003Eb__0)));
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Jacuzzi Options");
      // ISSUE: reference to a compiler-generated field
      displayClass3480.PedO = new UIMenuListItem("Ped  : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3480.PedO);
      // ISSUE: reference to a compiler-generated field
      displayClass3480.ChangePeds = new UIMenuItem("Change peds in Jacuzzi");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass3480.ChangePeds);
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass3480, __methodptr(\u003CYachtMenu\u003Eb__1)));
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.ChangePosMenu, "Misc");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3480.TM = new UIMenuListItem("Show Test Markers  : ", displayClass3480.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3480.TM);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Int = new UIMenuListItem("Spawn Dist : ", displayClass3480.Dist, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3480.Int);
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3480.Sd = new UIMenuListItem("Show Dist When Close : ", displayClass3480.TF, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3480.Sd);
      // ISSUE: method pointer
      uiMenu3.add_OnListChange(new ListChangedEvent((object) displayClass3480, __methodptr(\u003CYachtMenu\u003Eb__2)));
    }

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
      this.YachtPos.Add(new Vector3(0.0f, 0.0f, 0.0f));
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
      if (this.Purchased == 1)
      {
        Blip blip = World.CreateBlip(new Vector3((float) this.YachtPos[this.Location].X, (float) this.YachtPos[this.Location].Y, (float) this.YachtPos[this.Location].Z));
        blip.set_Sprite((BlipSprite) 455);
        blip.set_Name("Yacht : " + this.Location.ToString() + ", " + this.YachtLocSring[this.Location]);
        blip.set_Color((BlipColor) 2);
        this.Blips.Add(blip);
      }
      this.ChangePosPool = new MenuPool();
      this.ChangePosMainMenu = new UIMenu(nameof (Yacht), "Select an Option");
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

    public void ShowIncrease()
    {
      UI.Notify("Level: " + this.purchaselvl.ToString());
      UI.Notify("Max Stocks: " + this.maxstocks.ToString());
      UI.Notify("Annual Gain: $" + this.increaseGain.ToString("N"));
      UI.Notify("Mission Gain: " + this.profitMargin.ToString() + "%");
      UI.Notify("Stock Value: $" + this.stocksvalue.ToString("N"));
    }

    public VehicleHash RandomVehicleFun()
    {
      int num = new Random().Next(1, 13);
      if (num == 1)
        this.RandomVehicle = (VehicleHash) -808831384;
      if (num == 2)
        this.RandomVehicle = (VehicleHash) 80636076;
      if (num == 3)
        this.RandomVehicle = (VehicleHash) 723973206;
      if (num == 4)
        this.RandomVehicle = (VehicleHash) -1045541610;
      if (num == 5)
        this.RandomVehicle = (VehicleHash) -1685021548;
      if (num == 6)
        this.RandomVehicle = (VehicleHash) -1255452397;
      if (num == 7)
        this.RandomVehicle = (VehicleHash) 1923400478;
      if (num == 8)
        this.RandomVehicle = (VehicleHash) 1951180813;
      if (num == 9)
        this.RandomVehicle = (VehicleHash) -1622444098;
      if (num == 10)
        this.RandomVehicle = (VehicleHash) 1203490606;
      if (num == 11)
        this.RandomVehicle = (VehicleHash) -140902153;
      if (num == 12)
        this.RandomVehicle = (VehicleHash) 970598228;
      if (num == 13)
        this.RandomVehicle = (VehicleHash) 788045382;
      if (num > 13)
        this.RandomVehicle = (VehicleHash) 349605904;
      return this.RandomVehicle;
    }

    public Vector3 Randomlocation()
    {
      Random random = new Random();
      int num = random.Next(1, 13);
      if (num == 1)
        this.VehicleSpawn = new Vector3(-1069.32f, -72.28f, 19f);
      if (num == 2)
        this.VehicleSpawn = new Vector3(-1579.93f, -155.28f, 55f);
      if (num == 3)
        this.VehicleSpawn = new Vector3(-711.74f, -28.28f, 37f);
      if (num == 4)
        this.VehicleSpawn = new Vector3(6f, 253.58f, 109f);
      if (num == 5)
        this.VehicleSpawn = new Vector3(703f, 32f, 84f);
      if (num == 6)
        this.VehicleSpawn = new Vector3(1197f, -421.5f, 68f);
      if (num == 7)
        this.VehicleSpawn = new Vector3(1257f, -1428f, 35f);
      if (num == 8)
        this.VehicleSpawn = new Vector3(1264f, -2039f, 45f);
      if (num == 9)
        this.VehicleSpawn = new Vector3(527f, -2052f, 28f);
      if (num == 10)
        this.VehicleSpawn = new Vector3(-161f, -2087.8f, 26f);
      if (random.Next(1, 13) == 11)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      if (num == 12)
        this.VehicleSpawn = new Vector3(-816f, -2300f, 11f);
      if (num == 13)
        this.VehicleSpawn = new Vector3(-1839f, 136f, 78f);
      if (num > 13)
        this.VehicleSpawn = new Vector3(756f, -1723f, 30f);
      return this.VehicleSpawn;
    }

    public VehicleColor GetColor()
    {
      List<object> objectList = new List<object>();
      VehicleColor[] values = (VehicleColor[]) Enum.GetValues(typeof (VehicleColor));
      for (int index = 0; index < values.Length; ++index)
        objectList.Add((object) (VehicleColor) (int) values[index]);
      int index1 = new Random().Next(1, values.Length);
      // ISSUE: reference to a compiler-generated field
      if (Yacht.\u003C\u003Eo__353.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        Yacht.\u003C\u003Eo__353.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, VehicleColor>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (VehicleColor), typeof (Yacht)));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return Yacht.\u003C\u003Eo__353.\u003C\u003Ep__0.Target((CallSite) Yacht.\u003C\u003Eo__353.\u003C\u003Ep__0, objectList[index1]);
    }

    public void SetupSpecialMissions()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass354_0 displayClass3540 = new Yacht.\u003C\u003Ec__DisplayClass354_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3540.\u003C\u003E4__this = this;
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.SpecialMissions, "Special Missions");
      // ISSUE: reference to a compiler-generated field
      displayClass3540.Race1 = new UIMenuItem("ExPatriot");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3540.Race1);
      // ISSUE: reference to a compiler-generated field
      displayClass3540.Race2 = new UIMenuItem("Electrical Discharge");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3540.Race2);
      // ISSUE: reference to a compiler-generated field
      displayClass3540.Race3 = new UIMenuItem("Piracy Scam ");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3540.Race3);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass3540, __methodptr(\u003CSetupSpecialMissions\u003Eb__0)));
    }

    public void OpenMenu()
    {
      Script.Wait(25);
      UI.Notify("Menu");
      this.MenuOn = true;
    }

    public void ChooseVehicle(int i)
    {
      if (i == 1)
      {
        this.carid = "Mogul";
        this.VehicleMissioncar = World.CreateVehicle(new Model(-749299473), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i == 2)
      {
        this.carid = "Cuban 800";
        this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) -644710429), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i == 3)
      {
        this.carid = "Duster";
        this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) 970356638), this.VehicleLocation);
        this.VehicleMissioncar.PlaceOnGround();
      }
      if (i != 4)
        return;
      this.carid = "Mammatus";
      this.VehicleMissioncar = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1746576111), this.VehicleLocation);
      this.VehicleMissioncar.PlaceOnGround();
    }

    public void SetupProduct()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass357_0 displayClass3570 = new Yacht.\u003C\u003Ec__DisplayClass357_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3570.\u003C\u003E4__this = this;
      List<object> objectList = new List<object>();
      objectList.Add((object) "Maze Bank");
      objectList.Add((object) "Arcadius");
      objectList.Add((object) "Maze Bank West");
      objectList.Add((object) "Lombok");
      UIMenu uiMenu = this.modMenuPool.AddSubMenu(this.ProductStock, "Buy/Sell Product");
      // ISSUE: reference to a compiler-generated field
      displayClass3570.B = new UIMenuListItem("Business : ", objectList, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem((UIMenuItem) displayClass3570.B);
      // ISSUE: reference to a compiler-generated field
      displayClass3570.Buy2 = new UIMenuItem("Buy X10: -$" + 500000.ToString());
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3570.Buy2);
      // ISSUE: reference to a compiler-generated field
      displayClass3570.Buy = new UIMenuItem("Buy X1: -$" + 100000.ToString());
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3570.Buy);
      // ISSUE: reference to a compiler-generated field
      displayClass3570.Sell = new UIMenuItem("Sell - All Stocks (Low)");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3570.Sell);
      // ISSUE: reference to a compiler-generated field
      displayClass3570.Sell2 = new UIMenuItem("Sell - All Stocks (High)");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3570.Sell2);
      // ISSUE: reference to a compiler-generated field
      displayClass3570.Show = new UIMenuItem("Show Product Value/Count");
      // ISSUE: reference to a compiler-generated field
      uiMenu.AddItem(displayClass3570.Show);
      // ISSUE: method pointer
      uiMenu.add_OnItemSelect(new ItemSelectEvent((object) displayClass3570, __methodptr(\u003CSetupProduct\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu.add_OnListChange(new ListChangedEvent((object) displayClass3570, __methodptr(\u003CSetupProduct\u003Eb__1)));
    }

    public void Setupbuisness()
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      Yacht.\u003C\u003Ec__DisplayClass358_0 displayClass3580 = new Yacht.\u003C\u003Ec__DisplayClass358_0();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.\u003C\u003E4__this = this;
      List<object> objectList1 = new List<object>();
      objectList1.Add((object) "Maze Bank");
      objectList1.Add((object) "Arcadius");
      objectList1.Add((object) "Maze Bank West");
      objectList1.Add((object) "Lombok");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location = new List<object>();
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option1");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 1580000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Elysian Island");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(296f, -3092f, 8f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 43);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option2");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2380000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "La Mesa");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(946f, -1506f, 32f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 11);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option3");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2675000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Cypress Flats");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(795f, -2243f, 33f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -15);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option4");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 1635000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "El Burro Heights");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(1778f, -1665f, 116f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 39);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option5");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 1950000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Elysian Island");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(158f, -2962f, 14f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 160);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option6");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 1500000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "La Mesa");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(999f, -1875f, 37f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -8);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option7");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2730000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "La Puerta");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(-648f, -1793f, 27f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -61);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option8");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2170000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "LSIA");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(-1171f, -2195f, 20f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -42);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option9");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2300000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "LSIA");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(-489f, -2178f, 10f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 128);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option10");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2850000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Murrieta Heights");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(1200f, -1273f, 37f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -43);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option11");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 4550000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Pacific Bluffs");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(-2059f, -257f, 26.5f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -113);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option12");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 4850000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Hawick");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(541.3f, -229f, 56f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) -22);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option13");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 2350000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "Strawberry");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(62f, -1283f, 32f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 85);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Options.Add((object) "Option14");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Price.Add((object) 1150000);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Location.Add((object) "La Mesa");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamP.Add((object) new Vector3(511f, -624f, 28f));
      // ISSUE: reference to a compiler-generated field
      displayClass3580.CamR.Add((object) 129);
      UIMenu uiMenu1 = this.modMenuPool.AddSubMenu(this.methgarage, "Change Warehouse Position");
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Positions = new UIMenuListItem("Option : ", displayClass3580.Options, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem((UIMenuItem) displayClass3580.Positions);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Loc = new UIMenuItem("Location : ");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3580.Loc);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.pr1 = new UIMenuItem("Price : $0");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3580.pr1);
      UIMenuItem uiMenuItem = new UIMenuItem("Current");
      uiMenu1.AddItem(uiMenuItem);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Set = new UIMenuItem("Set");
      // ISSUE: reference to a compiler-generated field
      uiMenu1.AddItem(displayClass3580.Set);
      // ISSUE: method pointer
      uiMenu1.add_OnItemSelect(new ItemSelectEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__0)));
      // ISSUE: method pointer
      uiMenu1.add_OnListChange(new ListChangedEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__1)));
      List<object> objectList2 = new List<object>();
      int num = 1;
      for (int index = 1; index < 100; ++index)
        objectList2.Add((object) (num + index));
      UIMenu uiMenu2 = this.modMenuPool.AddSubMenu(this.methgarage, "Expand Business ");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.B = new UIMenuListItem("Business : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3580.B);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Update = new UIMenuItem("Update Stats");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass3580.Update);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.BuyNewLevel = new UIMenuItem(" Buy Level ");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass3580.BuyNewLevel);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.list2 = new UIMenuListItem("Select Level: ", objectList2, 1);
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem((UIMenuItem) displayClass3580.list2);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Jump = new UIMenuItem("Jump Straight to Level");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass3580.Jump);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Show = new UIMenuItem("Show Level");
      // ISSUE: reference to a compiler-generated field
      uiMenu2.AddItem(displayClass3580.Show);
      // ISSUE: method pointer
      uiMenu2.add_OnListChange(new ListChangedEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__2)));
      UIMenu uiMenu3 = this.modMenuPool.AddSubMenu(this.methgarage, "Sell  Business");
      // ISSUE: reference to a compiler-generated field
      displayClass3580.B1 = new UIMenuListItem("Business : ", objectList1, 0);
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem((UIMenuItem) displayClass3580.B1);
      // ISSUE: reference to a compiler-generated field
      displayClass3580.Sell = new UIMenuItem("Sell");
      // ISSUE: reference to a compiler-generated field
      uiMenu3.AddItem(displayClass3580.Sell);
      // ISSUE: method pointer
      uiMenu3.add_OnItemSelect(new ItemSelectEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__3)));
      // ISSUE: method pointer
      uiMenu3.add_OnListChange(new ListChangedEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__4)));
      // ISSUE: method pointer
      uiMenu2.add_OnItemSelect(new ItemSelectEvent((object) displayClass3580, __methodptr(\u003CSetupbuisness\u003Eb__5)));
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

    private void DisplayHelpTextThisFrameNoSound(string text)
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
        InputArgument.op_Implicit(0),
        InputArgument.op_Implicit(-1)
      });
    }

    public void Delete()
    {
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.YachtHashs[this.Location])
      });
      Function.Call((Hash) -1266537528939206611L, new InputArgument[1]
      {
        InputArgument.op_Implicit(this.YachtHashs2[this.Location])
      });
      if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
        ((Entity) this.Base).Delete();
      this.Created = false;
      this.DeletedYacht = false;
      this.Foundyacht = false;
      if (Entity.op_Inequality((Entity) this.Base2, (Entity) null))
        ((Entity) this.Base2).Delete();
      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
        ((Entity) this.BoatA).Delete();
      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
        ((Entity) this.BoatB).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
        ((Entity) this.SeaSharkA).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
        ((Entity) this.SeaSharkB).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
        ((Entity) this.SeaSharkC).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
        ((Entity) this.SeaSharkD).Delete();
      if (Entity.op_Inequality((Entity) this.FlagA, (Entity) null))
        ((Entity) this.FlagA).Delete();
      if (Entity.op_Inequality((Entity) this.FlagB, (Entity) null))
        ((Entity) this.FlagB).Delete();
      if (Entity.op_Inequality((Entity) this.FlagC, (Entity) null))
        ((Entity) this.FlagC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorC, (Entity) null))
        ((Entity) this.DoorC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorB, (Entity) null))
        ((Entity) this.DoorB).Delete();
      if (Entity.op_Inequality((Entity) this.Bargirl, (Entity) null))
        ((Entity) this.Bargirl).Delete();
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
        ((Entity) this.HeliA).Delete();
      if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
        ((Entity) this.HeliB).Delete();
      if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
        ((Entity) this.Base).Delete();
      foreach (Prop nearbyProp in World.GetNearbyProps(this.YachtPos[this.Location], 500f))
      {
        if (Entity.op_Inequality((Entity) nearbyProp, (Entity) null))
          ((Entity) nearbyProp).Delete();
      }
      using (List<Prop>.Enumerator enumerator = this.Props.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
    }

    private void OnShutdown(object sender, EventArgs e)
    {
      if (false)
        return;
      using (List<Prop>.Enumerator enumerator = this.Champ.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Camera.op_Inequality(this.WarehouseCam, (Camera) null))
      {
        World.set_RenderingCamera(this.WarehouseCam);
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        this.WarehouseCam.set_IsActive(false);
        this.WarehouseCam.Destroy();
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
      }
      if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
        this.DestoryVehicle.Remove();
      if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
        ((Entity) this.VehicleMissioncar).Delete();
      if (Entity.op_Inequality((Entity) this.VehicleId, (Entity) null))
        ((Entity) this.VehicleId).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet, (Entity) null))
        ((Entity) this.VtoGet).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet1, (Entity) null))
        ((Entity) this.VtoGet1).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet2, (Entity) null))
        ((Entity) this.VtoGet2).Delete();
      if (Entity.op_Inequality((Entity) this.VtoGet3, (Entity) null))
        ((Entity) this.VtoGet3).Delete();
      if (Blip.op_Inequality(this.VtoGetBlip, (Blip) null))
        this.VtoGetBlip.Remove();
      if (Blip.op_Inequality(this.DropzoneBlip, (Blip) null))
        this.DropzoneBlip.Remove();
      if (Entity.op_Inequality((Entity) this.RentedVehicle, (Entity) null))
        ((Entity) this.RentedVehicle).Delete();
      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
        ((Entity) this.BoatA).Delete();
      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
        ((Entity) this.BoatB).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
        ((Entity) this.SeaSharkA).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
        ((Entity) this.SeaSharkB).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
        ((Entity) this.SeaSharkC).Delete();
      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
        ((Entity) this.SeaSharkD).Delete();
      if (Entity.op_Inequality((Entity) this.FlagA, (Entity) null))
        ((Entity) this.FlagA).Delete();
      if (Entity.op_Inequality((Entity) this.FlagB, (Entity) null))
        ((Entity) this.FlagB).Delete();
      if (Entity.op_Inequality((Entity) this.FlagC, (Entity) null))
        ((Entity) this.FlagC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorC, (Entity) null))
        ((Entity) this.DoorC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorB, (Entity) null))
        ((Entity) this.DoorB).Delete();
      if (Entity.op_Inequality((Entity) this.Bargirl, (Entity) null))
        ((Entity) this.Bargirl).Delete();
      using (List<Ped>.Enumerator enumerator = this.Peds.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Ped current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
        ((Entity) this.HeliA).Delete();
      if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
        ((Entity) this.HeliB).Delete();
      using (List<Prop>.Enumerator enumerator = this.Props.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Prop current = enumerator.Current;
          if (Entity.op_Inequality((Entity) current, (Entity) null))
            ((Entity) current).Delete();
        }
      }
      using (List<Blip>.Enumerator enumerator = this.Blips.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Blip current = enumerator.Current;
          if (Blip.op_Inequality(current, (Blip) null))
            current.Remove();
        }
      }
    }

    public void PlayAnim(Ped p, int Gender)
    {
      Random random = new Random();
      int num1 = random.Next(1, 5);
      ((Entity) p).set_FreezePosition(true);
      p.set_AlwaysKeepTask(true);
      if (Gender == 1)
      {
        if (num1 == 1)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_01@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 2)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_02@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 3)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_03@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 4)
          p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_04@", "base", 8f, -1, true, -1f);
        if (num1 == 5)
          p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@female@variation_05@", "base", 8f, -1, true, -1f);
      }
      if (Gender == 2)
      {
        if (num1 == 1)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_01@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 2)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_02@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 3)
        {
          int num2 = random.Next(1, 4);
          if (num2 == 1)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base", 8f, -1, true, -1f);
          if (num2 == 2)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_a", 8f, -1, true, -1f);
          if (num2 == 3)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_b", 8f, -1, true, -1f);
          if (num2 == 4)
            p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_03@", "base_c", 8f, -1, true, -1f);
        }
        if (num1 == 4)
          p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
        if (num1 == 5)
          p.get_Task().PlayAnimation("anim@amb@yacht@jacuzzi@seated@male@variation_05@", "base", 8f, -1, true, -1f);
      }
      this.Peds.Add(p);
      p = (Ped) null;
    }

    public float GetRoationalAxis()
    {
      float z = (float) ((Entity) this.Base).get_Rotation().Z;
      return 0.0f;
    }

    public void OnTick(object sender, EventArgs e)
    {
      if (this.ChangePosPool != null && this.ChangePosPool.IsAnyMenuOpen())
        this.ChangePosPool.ProcessMenus();
      if (this.Woredrobepool != null && this.Woredrobepool.IsAnyMenuOpen())
        this.Woredrobepool.ProcessMenus();
      this.OnKeyDown();
      if (this.DrinksPool != null && this.DrinksPool.IsAnyMenuOpen())
        this.DrinksPool.ProcessMenus();
      using (List<Vector3>.Enumerator enumerator = this.RadioPos.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          Vector3 current = enumerator.Current;
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 80.0)
            World.DrawMarker((MarkerType) 1, current, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.4f, 0.4f, 0.3f), Color.Yellow);
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to turn Radio On/Off, ~INPUT_COVER~ to change station");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), current) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
          {
            if (this.RadioOn)
            {
              this.RadioOn = false;
              Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
              {
                InputArgument.op_Implicit(false)
              });
              Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
              {
                InputArgument.op_Implicit(false)
              });
            }
            else if (!this.RadioOn)
            {
              this.CurrentRadio = ((Entity) Game.get_Player().get_Character()).get_Position();
              Vector3 position = ((Entity) Game.get_Player().get_Character()).get_Position();
              this.CurrentInt = (int) Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
              {
                InputArgument.op_Implicit((float) position.X),
                InputArgument.op_Implicit((float) position.Y),
                InputArgument.op_Implicit((float) position.Z)
              });
              this.Z_min = (float) (((Entity) Game.get_Player().get_Character()).get_Position().Z - 7.0);
              this.Z_max = (float) (((Entity) Game.get_Player().get_Character()).get_Position().Z + 7.0);
              this.RadioOn = true;
              Function.Call((Hash) -6477951525662992625L, new InputArgument[1]
              {
                InputArgument.op_Implicit(1)
              });
              Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
              {
                InputArgument.op_Implicit(true)
              });
            }
          }
        }
      }
      if (this.RadioOn)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CurrentRadio) > 150.0)
        {
          UI.Notify("Radio Off, due to Player being to far away from Radio");
          this.RadioOn = false;
          Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1869590208789261902L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
        }
        Vector3 position = ((Entity) Game.get_Player().get_Character()).get_Position();
        if (position.Z > (double) this.Z_max || position.Z < (double) this.Z_min)
        {
          UI.Notify("Radio Off, due to Player Height, being too low or too High");
          this.RadioOn = false;
          Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1869590208789261902L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
        }
        if (Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit((float) position.X),
          InputArgument.op_Implicit((float) position.Y),
          InputArgument.op_Implicit((float) position.Z)
        }) != Function.Call<int>((Hash) -5694810085874607677L, new InputArgument[3]
        {
          InputArgument.op_Implicit((float) this.CurrentRadio.X),
          InputArgument.op_Implicit((float) this.CurrentRadio.Y),
          InputArgument.op_Implicit((float) this.CurrentRadio.Z)
        }))
        {
          UI.Notify("Radio Off, due to exiting Interior");
          this.RadioOn = false;
          Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1869590208789261902L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
        }
        if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
        {
          UI.Notify("Radio Off, due to being in Vehicle");
          this.RadioOn = false;
          Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1195764362099706803L, new InputArgument[1]
          {
            InputArgument.op_Implicit(false)
          });
          Function.Call((Hash) 1869590208789261902L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
        }
        if (Entity.op_Equality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
          Function.Call((Hash) -4672365499868974113L, new InputArgument[1]
          {
            InputArgument.op_Implicit(true)
          });
      }
      if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
      {
        if (!Game.IsControlJustPressed(2, (Control) 51))
          ;
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) < 200.0)
          Game.get_Player().get_Character().get_Weapons().Select((WeaponHash) -1569615261);
      }
      if (this.ShowDistWhenClose && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) < (double) (this.SpawnDist + 200) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) > (double) this.SpawnDist)
        this.DisplayHelpTextThisFrameNoSound("Distance to Yacht ~b~" + World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]).ToString() + "m ~w~, Dist to spawn :~b~" + this.SpawnDist.ToString() + "m~w~");
      if (this.Purchased == 1)
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(2000f, 2000f, 1000f)) < 2.0)
          this.Reset();
        if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
        {
          if (this.ShowTestBlips)
          {
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeBPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.WoredrobeBPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Pink);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeCPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.WoredrobeCPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Purple);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeAPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.WoredrobeAPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Lime);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeaSharkPosA) < 80.0)
              World.DrawMarker((MarkerType) 1, this.SeaSharkPosA, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeaSharkPosB) < 80.0)
              World.DrawMarker((MarkerType) 1, this.SeaSharkPosB, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeaSharkPosC) < 80.0)
              World.DrawMarker((MarkerType) 1, this.SeaSharkPosC, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.SeaSharkPosD) < 80.0)
              World.DrawMarker((MarkerType) 1, this.SeaSharkPosD, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BoatAPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.BoatAPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BoatBPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.BoatBPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerAPos) < 80.0)
            {
              World.DrawMarker((MarkerType) 1, this.ShowerAPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
              World.DrawMarker((MarkerType) 1, this.ShowerAPosEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            }
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerBPos) < 80.0)
            {
              World.DrawMarker((MarkerType) 1, this.ShowerBPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
              World.DrawMarker((MarkerType) 1, this.ShowerBPosEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            }
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerCPos) < 80.0)
            {
              World.DrawMarker((MarkerType) 1, this.ShowerCPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
              World.DrawMarker((MarkerType) 1, this.ShowerCPosEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            }
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.BarPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.BarPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarDrinkPos) < 80.0)
              World.DrawMarker((MarkerType) 1, this.BarDrinkPos, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed1) < 80.0)
              World.DrawMarker((MarkerType) 1, this.Bed1, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Green);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed2) < 80.0)
              World.DrawMarker((MarkerType) 1, this.Bed2, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed3) < 80.0)
              World.DrawMarker((MarkerType) 1, this.Bed3, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
            if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.HeliB).get_Position()) < 80.0)
              World.DrawMarker((MarkerType) 1, ((Entity) this.HeliB).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 10f), Color.Red);
            if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.HeliA).get_Position()) < 80.0)
              World.DrawMarker((MarkerType) 1, ((Entity) this.HeliA).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 10f), Color.Red);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.HeliPosA) < 80.0)
              World.DrawMarker((MarkerType) 1, this.HeliPosA, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.HeliPosB) < 80.0 && this.MaxHelis != 1)
              World.DrawMarker((MarkerType) 1, this.HeliPosB, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat1, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Yellow);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat2) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat2, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat3) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat3, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat4) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat4, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Green);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat5) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat5, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Purple);
            if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat6) < 80.0)
              World.DrawMarker((MarkerType) 1, this.jacuzziSeat6, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.YellowGreen);
            if (Entity.op_Inequality((Entity) this.DoorC, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.DoorC).get_Position()) < 80.0)
              World.DrawMarker((MarkerType) 1, ((Entity) this.DoorC).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Blue);
            if (Entity.op_Inequality((Entity) this.DoorB, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.DoorB).get_Position()) < 80.0)
              World.DrawMarker((MarkerType) 1, ((Entity) this.DoorB).get_Position(), Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.7f, 0.7f, 1f), Color.Red);
          }
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChangeLocMarker) < 80.0)
            World.DrawMarker((MarkerType) 1, this.ChangeLocMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarEnter) < 80.0)
            World.DrawMarker((MarkerType) 1, this.BarEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarExit) < 80.0)
            World.DrawMarker((MarkerType) 1, this.BarExit, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersEnter) < 80.0)
            World.DrawMarker((MarkerType) 1, this.CaptinsQuartersEnter, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersExit) < 80.0)
            World.DrawMarker((MarkerType) 1, this.CaptinsQuartersExit, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MenuMarker) < 80.0)
            World.DrawMarker((MarkerType) 1, this.MenuMarker, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(0.6f, 0.6f, 0.4f), Color.FromArgb(0, 147, (int) byte.MaxValue));
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarDrinkPos) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to buy a drink");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerAPos) < 3.0 || (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerBPos) < 3.0 || (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerCPos) < 3.0)
          {
            if (this.InShower)
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to get out of shower");
            if (!this.InShower)
              this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to take a shower");
          }
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.jacuzziSeat1) < 4.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to sit in Jacuzzi ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ChangeLocMarker) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Open Menu to Change Location of Yacht ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarEnter) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Enter Bar and Lounge Area ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.BarExit) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Exit Bar and Lounge Area ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersEnter) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Enter Captain's Quarters ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.CaptinsQuartersExit) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Exit Captain's Quarters ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.MenuMarker) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Open the Business Menu ");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed1) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Sleep");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed2) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to Sleep");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Bed3) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to Sleep");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeAPos) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to access Wardrobe");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeBPos) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~  to access Wardrobe");
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeCPos) < 2.0)
            this.DisplayHelpTextThisFrame("Press ~INPUT_CONTEXT~ to access Wardrobe");
        }
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) < 750.0)
        {
          if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null) && !Entity.op_Inequality((Entity) this.BoatA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.BoatA).set_FreezePosition(false);
          if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null) && !Entity.op_Inequality((Entity) this.BoatB.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.BoatB).set_FreezePosition(false);
          if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null) && !Entity.op_Inequality((Entity) this.SeaSharkA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.SeaSharkA).set_FreezePosition(false);
          if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null) && !Entity.op_Inequality((Entity) this.SeaSharkB.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.SeaSharkB).set_FreezePosition(false);
          if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null) && !Entity.op_Inequality((Entity) this.SeaSharkC.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.SeaSharkC).set_FreezePosition(false);
          if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null) && !Entity.op_Inequality((Entity) this.HeliA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            ((Entity) this.SeaSharkD).set_FreezePosition(false);
        }
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) > (double) this.SpawnDist && this.Created)
          this.Delete();
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) < (double) this.SpawnDist)
        {
          if (!this.Created)
          {
            if (!this.DeletedYacht)
            {
              if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
                ((Entity) this.HeliA).Delete();
              if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
                ((Entity) this.HeliB).Delete();
              this.DoorA = (Prop) null;
              this.DoorB = (Prop) null;
              this.DoorC = (Prop) null;
              this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
              string str1 = this.YachtHashs[this.Location];
              string str2 = this.YachtHashs2[this.Location];
              Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
              {
                InputArgument.op_Implicit(str1)
              });
              Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
              {
                InputArgument.op_Implicit(str2)
              });
              int num;
              if (Function.Call<bool>((Hash) -8599832514687978347L, new InputArgument[1]
              {
                InputArgument.op_Implicit(str1)
              }) != null)
                num = (int) Function.Call<bool>((Hash) -8599832514687978347L, new InputArgument[1]
                {
                  InputArgument.op_Implicit(str2)
                });
              else
                num = 0;
              if (num != 0)
                this.DeletedYacht = true;
            }
            if (this.DeletedYacht)
            {
              string str1 = this.YachtHashs[this.Location];
              string str2 = this.YachtHashs2[this.Location];
              Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
              {
                InputArgument.op_Implicit(str1)
              });
              Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
              {
                InputArgument.op_Implicit(str2)
              });
              Script.Wait(500);
              int num = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
              {
                InputArgument.op_Implicit("apa_mp_apa_yacht")
              });
              this.Base = (Prop) Function.Call<Prop>((Hash) -2214651566572027031L, new InputArgument[8]
              {
                InputArgument.op_Implicit((float) this.YachtPos[this.Location].X),
                InputArgument.op_Implicit((float) this.YachtPos[this.Location].Y),
                InputArgument.op_Implicit((float) this.YachtPos[this.Location].Z),
                InputArgument.op_Implicit(25f),
                InputArgument.op_Implicit(num),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0),
                InputArgument.op_Implicit(0)
              });
              if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
              {
                this.Foundyacht = false;
                this.Created = true;
                Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                {
                  InputArgument.op_Implicit(this.Base),
                  InputArgument.op_Implicit(this.ShipColor)
                });
              }
            }
          }
          if (this.Created)
          {
            if (!this.Foundyacht)
            {
              try
              {
                if (this.Location != 37)
                {
                  string str1 = this.YachtHashs[this.Location];
                  string str2 = this.YachtHashs2[this.Location];
                  Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(str1)
                  });
                  Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(str2)
                  });
                  Script.Wait(500);
                  int num = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit("apa_mp_apa_yacht")
                  });
                  this.Base = (Prop) Function.Call<Prop>((Hash) -2214651566572027031L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].X),
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].Y),
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].Z),
                    InputArgument.op_Implicit(25f),
                    InputArgument.op_Implicit(num),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                  {
                    this.Foundyacht = false;
                    this.Created = true;
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(this.Base),
                      InputArgument.op_Implicit(this.ShipColor)
                    });
                  }
                  if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                  {
                    UI.Notify("Test Case Scenario Failed, Trying Again");
                    Prop[] nearbyProps = World.GetNearbyProps(this.YachtPos[this.Location], 50f, this.RequestModel(1338692320));
                    if ((uint) nearbyProps.Length > 0U)
                    {
                      foreach (Prop prop in nearbyProps)
                      {
                        if (Entity.op_Inequality((Entity) prop, (Entity) null))
                        {
                          this.Foundyacht = true;
                          this.Created = true;
                          this.Base = prop;
                          if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                            Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                            {
                              InputArgument.op_Implicit(this.Base),
                              InputArgument.op_Implicit(this.ShipColor)
                            });
                        }
                      }
                    }
                    if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                    {
                      UI.Notify("Test Case Scenario Failed, Trying Again (2)");
                      if ((uint) World.GetNearbyProps(this.YachtPos[this.Location], 100f).Length > 0U)
                      {
                        foreach (Prop prop in nearbyProps)
                        {
                          if (Entity.op_Inequality((Entity) prop, (Entity) null) && Model.op_Equality(((Entity) prop).get_Model(), this.RequestModel(1338692320)))
                          {
                            this.Foundyacht = true;
                            this.Created = true;
                            this.Base = prop;
                            if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                              Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                              {
                                InputArgument.op_Implicit(this.Base),
                                InputArgument.op_Implicit(this.ShipColor)
                              });
                          }
                        }
                      }
                    }
                  }
                  if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                    UI.Notify("Test Case Scenario Failed, Yacht Base Could not be found!");
                  if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                  {
                    if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                    {
                      this.PropYachtBase = this.Base;
                      UI.Notify("Test Case Scenario Succeeded");
                      this.SpawnYacht();
                    }
                    this.Foundyacht = true;
                    if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                    {
                      this.ChangeYachtPositions();
                      Script.Wait(500);
                      if (this.MaxHelis != 1)
                      {
                        if (this.H1 == 1)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosA);
                        if (this.H1 == 2)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosA);
                        if (this.H1 == 3)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosA);
                        if (this.H1 == 4)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosA);
                        if (this.H1 == 5)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosA);
                        if (this.H1 == 6)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosA);
                        if (this.H2 == 1)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosB);
                        if (this.H2 == 2)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosB);
                        if (this.H2 == 3)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosB);
                        if (this.H2 == 4)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosB);
                        if (this.H2 == 5)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosB);
                        if (this.H2 == 6)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosB);
                        if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
                        {
                          ((Entity) this.HeliA).set_IsInvincible(true);
                          ((Entity) this.HeliA).set_Position(this.HeliPosA);
                          ((Entity) this.HeliA).set_Rotation(((Entity) this.Base).get_Rotation());
                          ((Entity) this.HeliA).set_IsPersistent(true);
                          Vector3 rotation = ((Entity) this.HeliA).get_Rotation();
                          ((Entity) this.HeliA).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z - 90.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliA).set_IsInvincible(false);
                        }
                        if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
                        {
                          ((Entity) this.HeliB).set_Position(this.HeliPosB);
                          ((Entity) this.HeliB).set_IsInvincible(true);
                          ((Entity) this.HeliB).set_Rotation(((Entity) this.Base).get_Rotation());
                          Vector3 rotation = ((Entity) this.HeliB).get_Rotation();
                          ((Entity) this.HeliB).set_IsPersistent(true);
                          ((Entity) this.HeliB).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z + 150.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliB).set_IsInvincible(false);
                        }
                      }
                      else if (this.MaxHelis == 1)
                      {
                        if (this.H1 == 1)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosA);
                        if (this.H1 == 2)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosA);
                        if (this.H1 == 3)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosA);
                        if (this.H1 == 4)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosA);
                        if (this.H1 == 5)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosA);
                        if (this.H1 == 6)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosA);
                        if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
                        {
                          ((Entity) this.HeliA).set_Position(this.HeliPosA);
                          ((Entity) this.HeliA).set_IsInvincible(true);
                          ((Entity) this.HeliA).set_Rotation(((Entity) this.Base).get_Rotation());
                          ((Entity) this.HeliA).set_IsPersistent(true);
                          Vector3 rotation = ((Entity) this.HeliA).get_Rotation();
                          ((Entity) this.HeliA).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z - 90.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliA).set_IsInvincible(false);
                        }
                      }
                      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
                        ((Entity) this.BoatA).Delete();
                      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
                        ((Entity) this.BoatB).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
                        ((Entity) this.SeaSharkA).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
                        ((Entity) this.SeaSharkB).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
                        ((Entity) this.SeaSharkC).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
                        ((Entity) this.SeaSharkD).Delete();
                      if ((uint) this.BoatAType > 0U)
                      {
                        if (this.BoatAType == 1)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 231083307), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 2)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 3)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1033245328), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 4)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 509498602), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 5)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1070967343), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 6)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 908897389), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 7)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1043459709), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                      }
                      if ((uint) this.BoatBType > 0U)
                      {
                        if (this.BoatBType == 1)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 231083307), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 2)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 3)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1033245328), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 4)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 5)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1070967343), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 6)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 908897389), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 7)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1043459709), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z - 90.0));
                      }
                      if ((uint) this.AmountOfSeaSharks > 0U)
                      {
                        if (this.AmountOfSeaSharks >= 1)
                          this.SeaSharkA = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosA, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 2)
                          this.SeaSharkB = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosB, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 3)
                          this.SeaSharkC = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosC, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 4)
                          this.SeaSharkD = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosD, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                      }
                      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
                        ((Entity) this.BoatA).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
                        ((Entity) this.BoatB).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
                        ((Entity) this.SeaSharkA).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
                        ((Entity) this.SeaSharkB).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
                        ((Entity) this.SeaSharkC).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
                        ((Entity) this.SeaSharkD).set_FreezePosition(true);
                      this.AddPeds();
                      UI.Notify("~b~ Finished Spawning In Yacht~w~");
                      if (this.WaitForCreated)
                      {
                        this.WaitForCreated = false;
                        ((Entity) Game.get_Player().get_Character()).set_Position(this.YachtPos[this.Location]);
                        ((Entity) Game.get_Player().get_Character()).set_Position(this.ChangeLocMarker);
                      }
                    }
                    if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                      UI.Notify("Test Case Scenario Failed");
                  }
                }
                if (this.Location == 37)
                {
                  string str1 = this.YachtHashs[this.Location];
                  string str2 = this.YachtHashs2[this.Location];
                  Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(str1)
                  });
                  Function.Call((Hash) 4734559983020792692L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit(str2)
                  });
                  Script.Wait(500);
                  int num = (int) Function.Call<int>((Hash) -3292914402564945716L, new InputArgument[1]
                  {
                    InputArgument.op_Implicit("sum_mp_apa_yacht")
                  });
                  this.Base = (Prop) Function.Call<Prop>((Hash) -2214651566572027031L, new InputArgument[8]
                  {
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].X),
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].Y),
                    InputArgument.op_Implicit((float) this.YachtPos[this.Location].Z),
                    InputArgument.op_Implicit(25f),
                    InputArgument.op_Implicit(num),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0),
                    InputArgument.op_Implicit(0)
                  });
                  if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                  {
                    this.Foundyacht = false;
                    this.Created = true;
                    Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                    {
                      InputArgument.op_Implicit(this.Base),
                      InputArgument.op_Implicit(this.ShipColor)
                    });
                  }
                  if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                  {
                    UI.Notify("Test Case Scenario Failed, Trying Again");
                    Prop[] nearbyProps = World.GetNearbyProps(this.YachtPos[this.Location], 50f, this.RequestModel(1338692320));
                    if ((uint) nearbyProps.Length > 0U)
                    {
                      foreach (Prop prop in nearbyProps)
                      {
                        if (Entity.op_Inequality((Entity) prop, (Entity) null))
                        {
                          this.Foundyacht = true;
                          this.Created = true;
                          this.Base = prop;
                          if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                            Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                            {
                              InputArgument.op_Implicit(this.Base),
                              InputArgument.op_Implicit(this.ShipColor)
                            });
                        }
                      }
                    }
                    if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                    {
                      UI.Notify("Test Case Scenario Failed, Trying Again (2)");
                      if ((uint) World.GetNearbyProps(this.YachtPos[this.Location], 100f).Length > 0U)
                      {
                        foreach (Prop prop in nearbyProps)
                        {
                          if (Entity.op_Inequality((Entity) prop, (Entity) null) && Model.op_Equality(((Entity) prop).get_Model(), this.RequestModel(1338692320)))
                          {
                            this.Foundyacht = true;
                            this.Created = true;
                            this.Base = prop;
                            if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                              Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
                              {
                                InputArgument.op_Implicit(this.Base),
                                InputArgument.op_Implicit(this.ShipColor)
                              });
                          }
                        }
                      }
                    }
                  }
                  if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                    UI.Notify("Test Case Scenario Failed, Yacht Base Could not be found!");
                  if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                  {
                    if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                    {
                      this.PropYachtBase = this.Base;
                      UI.Notify("Test Case Scenario Succeeded");
                      this.SpawnYacht();
                    }
                    this.Foundyacht = true;
                    if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
                    {
                      this.ChangeYachtPositions();
                      Script.Wait(500);
                      if (this.MaxHelis != 1)
                      {
                        if (this.H1 == 1)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosA);
                        if (this.H1 == 2)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosA);
                        if (this.H1 == 3)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosA);
                        if (this.H1 == 4)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosA);
                        if (this.H1 == 5)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosA);
                        if (this.H1 == 6)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosA);
                        if (this.H2 == 1)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosB);
                        if (this.H2 == 2)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosB);
                        if (this.H2 == 3)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosB);
                        if (this.H2 == 4)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosB);
                        if (this.H2 == 5)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosB);
                        if (this.H2 == 6)
                          this.HeliB = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosB);
                        if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
                        {
                          ((Entity) this.HeliA).set_IsInvincible(true);
                          ((Entity) this.HeliA).set_Position(this.HeliPosA);
                          ((Entity) this.HeliA).set_Rotation(((Entity) this.Base).get_Rotation());
                          ((Entity) this.HeliA).set_IsPersistent(true);
                          Vector3 rotation = ((Entity) this.HeliA).get_Rotation();
                          ((Entity) this.HeliA).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z - 90.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliA).set_IsInvincible(false);
                        }
                        if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
                        {
                          ((Entity) this.HeliB).set_Position(this.HeliPosB);
                          ((Entity) this.HeliB).set_IsInvincible(true);
                          ((Entity) this.HeliB).set_Rotation(((Entity) this.Base).get_Rotation());
                          Vector3 rotation = ((Entity) this.HeliB).get_Rotation();
                          ((Entity) this.HeliB).set_IsPersistent(true);
                          ((Entity) this.HeliB).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z + 150.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliB).set_IsInvincible(false);
                        }
                      }
                      else if (this.MaxHelis == 1)
                      {
                        if (this.H1 == 1)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -339587598), this.HeliPosA);
                        if (this.H1 == 2)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1660661558), this.HeliPosA);
                        if (this.H1 == 3)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 710198397), this.HeliPosA);
                        if (this.H1 == 4)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1845487887), this.HeliPosA);
                        if (this.H1 == 5)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) -1671539132), this.HeliPosA);
                        if (this.H1 == 6)
                          this.HeliA = World.CreateVehicle(this.RequestModel((VehicleHash) 1075432268), this.HeliPosA);
                        if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
                        {
                          ((Entity) this.HeliA).set_Position(this.HeliPosA);
                          ((Entity) this.HeliA).set_IsInvincible(true);
                          ((Entity) this.HeliA).set_Rotation(((Entity) this.Base).get_Rotation());
                          ((Entity) this.HeliA).set_IsPersistent(true);
                          Vector3 rotation = ((Entity) this.HeliA).get_Rotation();
                          ((Entity) this.HeliA).set_Rotation(new Vector3((float) rotation.X, (float) rotation.Y, (float) (rotation.Z - 90.0)));
                          Script.Wait(25);
                          ((Entity) this.HeliA).set_IsInvincible(false);
                        }
                      }
                      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
                        ((Entity) this.BoatA).Delete();
                      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
                        ((Entity) this.BoatB).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
                        ((Entity) this.SeaSharkA).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
                        ((Entity) this.SeaSharkB).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
                        ((Entity) this.SeaSharkC).Delete();
                      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
                        ((Entity) this.SeaSharkD).Delete();
                      if ((uint) this.BoatAType > 0U)
                      {
                        if (this.BoatAType == 1)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 231083307), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 2)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 3)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1033245328), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 4)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 509498602), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 5)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1070967343), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 6)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) 908897389), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatAType == 7)
                          this.BoatA = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1043459709), this.BoatAPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                      }
                      if ((uint) this.BoatBType > 0U)
                      {
                        if (this.BoatBType == 1)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 231083307), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 2)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 3)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1033245328), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 4)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 861409633), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 5)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 1070967343), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 6)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) 908897389), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.BoatBType == 7)
                          this.BoatB = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1043459709), this.BoatBPos, (float) (((Entity) this.Base).get_Rotation().Z - 90.0));
                      }
                      if ((uint) this.AmountOfSeaSharks > 0U)
                      {
                        if (this.AmountOfSeaSharks >= 1)
                          this.SeaSharkA = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosA, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 2)
                          this.SeaSharkB = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosB, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 3)
                          this.SeaSharkC = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosC, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                        if (this.AmountOfSeaSharks >= 4)
                          this.SeaSharkD = World.CreateVehicle(Model.op_Implicit((VehicleHash) -1030275036), this.SeaSharkPosD, (float) (((Entity) this.Base).get_Rotation().Z + 90.0));
                      }
                      if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
                        ((Entity) this.BoatA).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
                        ((Entity) this.BoatB).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
                        ((Entity) this.SeaSharkA).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
                        ((Entity) this.SeaSharkB).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
                        ((Entity) this.SeaSharkC).set_FreezePosition(true);
                      if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
                        ((Entity) this.SeaSharkD).set_FreezePosition(true);
                      this.AddPeds();
                      UI.Notify("~b~ Finished Spawning In Yacht~w~");
                      if (this.WaitForCreated)
                      {
                        this.WaitForCreated = false;
                        ((Entity) Game.get_Player().get_Character()).set_Position(this.YachtPos[this.Location]);
                        ((Entity) Game.get_Player().get_Character()).set_Position(this.ChangeLocMarker);
                      }
                    }
                    if (Entity.op_Equality((Entity) this.Base, (Entity) null))
                      UI.Notify("Test Case Scenario Failed");
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
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.YachtPos[this.Location]) >= (double) this.SpawnDist && this.Created)
        {
          this.Created = false;
          if (Entity.op_Inequality((Entity) this.BoatA, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.BoatA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.BoatA).Delete();
            }
            else
            {
              ((Entity) this.BoatA).set_FreezePosition(false);
              ((Entity) this.BoatA).set_IsPersistent(false);
              this.BoatA = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.BoatB, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.BoatB.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.BoatB).Delete();
            }
            else
            {
              ((Entity) this.BoatB).set_FreezePosition(false);
              ((Entity) this.BoatB).set_IsPersistent(false);
              this.BoatB = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.SeaSharkA, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.SeaSharkA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.SeaSharkA).Delete();
            }
            else
            {
              ((Entity) this.SeaSharkA).set_FreezePosition(false);
              ((Entity) this.SeaSharkA).set_IsPersistent(false);
              this.SeaSharkA = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.SeaSharkB, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.SeaSharkB.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.SeaSharkB).Delete();
            }
            else
            {
              ((Entity) this.SeaSharkB).set_FreezePosition(false);
              ((Entity) this.SeaSharkB).set_IsPersistent(false);
              this.SeaSharkB = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.SeaSharkC, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.SeaSharkC.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.SeaSharkC).Delete();
            }
            else
            {
              ((Entity) this.SeaSharkC).set_FreezePosition(false);
              ((Entity) this.SeaSharkC).set_IsPersistent(false);
              this.SeaSharkC = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.SeaSharkD, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.HeliA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.SeaSharkD).Delete();
            }
            else
            {
              ((Entity) this.SeaSharkD).set_FreezePosition(false);
              ((Entity) this.SeaSharkD).set_IsPersistent(false);
              this.SeaSharkD = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.HeliA, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.HeliA.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.HeliA).Delete();
            }
            else
            {
              ((Entity) this.HeliA).set_IsPersistent(false);
              this.HeliA = (Vehicle) null;
            }
          }
          if (Entity.op_Inequality((Entity) this.HeliB, (Entity) null))
          {
            if (Entity.op_Inequality((Entity) this.HeliB.GetPedOnSeat((VehicleSeat) -1), (Entity) Game.get_Player().get_Character()))
            {
              ((Entity) this.HeliB).Delete();
            }
            else
            {
              ((Entity) this.HeliB).set_IsPersistent(false);
              this.HeliB = (Vehicle) null;
            }
          }
          this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
          int location = this.Location;
          for (int index = 1; index < 37; ++index)
          {
            using (List<Prop>.Enumerator enumerator = this.Props.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
          }
        }
      }
      if (this.modMenuPool != null)
        this.modMenuPool.ProcessMenus();
      if (Camera.op_Inequality(this.WarehouseCam, (Camera) null) && (this.WCamOn && !this.modMenuPool.IsAnyMenuOpen()))
      {
        this.WCamOn = false;
        this.modMenuPool.CloseAllMenus();
        this.WarehouseCam.set_IsActive(false);
        this.WarehouseCam.Destroy();
        Function.Call((Hash) 569060033405794044L, new InputArgument[5]
        {
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(0),
          InputArgument.op_Implicit(3000),
          InputArgument.op_Implicit(1),
          InputArgument.op_Implicit(0)
        });
        ((Entity) Game.get_Player().get_Character()).set_FreezePosition(false);
        ((Entity) Game.get_Player().get_Character()).set_IsVisible(true);
        ((Entity) Game.get_Player().get_Character()).set_Position(this.MenuMarker);
      }
      if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleMissioncar).get_Position()) < 100.0)
        ((Entity) this.VehicleMissioncar).set_IsInvincible(false);
      if (Entity.op_Inequality((Entity) this.RentedVehicle, (Entity) null) && this.startedRent)
      {
        if (this.RentalvehicleHealth != ((Entity) this.RentedVehicle).get_Health())
        {
          this.RentalvehicleHealth = ((Entity) this.RentedVehicle).get_Health();
          UI.Notify("Office Assistant : That is a rental!, be more carefull, we get billed each time you damage it! ");
          if (Game.get_Player().get_Money() >= 300)
          {
            Player player = Game.get_Player();
            player.set_Money(player.get_Money() - 300);
          }
        }
        if ((uint) this.RentTimer > 0U)
        {
          --this.RentTimer;
        }
        else
        {
          this.startedRent = false;
          UI.Notify("Office Assistant : ok Boss, the Rent for that vehicle has expired");
          this.RentedVehicle.GetPedOnSeat((VehicleSeat) -1).get_Task().LeaveVehicle((LeaveVehicleFlags) 4096);
          this.RentedVehicle.set_LockStatus((VehicleLockStatus) 2);
        }
      }
      if (this.checkforconvoy)
      {
        if (this.convoysetup == 1 || this.convoysetup == 2 || this.convoysetup == 3)
        {
          this.ConvoyBlip1.set_Position(((Entity) this.Vehicle1).get_Position());
          this.ConvoyBlip2.set_Position(((Entity) this.Vehicle2).get_Position());
          this.ConvoyBlip3.set_Position(((Entity) this.Vehicle3).get_Position());
        }
        if ((this.convoysetup == 1 || this.convoysetup == 2) && (!((Entity) this.Vehicle1).get_IsAlive() && !((Entity) this.Vehicle2).get_IsAlive() && !((Entity) this.Vehicle3).get_IsAlive()))
        {
          Game.FadeScreenOut(500);
          Script.Wait(500);
          if (Blip.op_Inequality(this.ConvoyBlip1, (Blip) null))
            this.ConvoyBlip1.Remove();
          if (Blip.op_Inequality(this.ConvoyBlip2, (Blip) null))
            this.ConvoyBlip2.Remove();
          if (Blip.op_Inequality(this.ConvoyBlip3, (Blip) null))
            this.ConvoyBlip3.Remove();
          if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null))
            ((Entity) this.Vehicle1).Delete();
          if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null))
            ((Entity) this.Vehicle2).Delete();
          if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null))
            ((Entity) this.Vehicle3).Delete();
          Script.Wait(500);
          Game.FadeScreenIn(500);
          this.stocksvalue = (float) ((double) this.stocksvalue + 750000.0 + 750000.0 * (double) this.profitMargin / 100.0);
          UI.Notify("Office Assistant: Great convoy Destoryed");
          UI.Notify("Office Assistant: Stocks just Increased");
          this.ShowIncrease();
          this.checkforconvoy = false;
          this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
          this.Config.Save();
        }
        if (this.convoysetup == 3 && (!((Entity) this.Vehicle1).get_IsAlive() && !((Entity) this.Vehicle2).get_IsAlive() && !((Entity) this.Vehicle3).get_IsAlive()))
        {
          Game.FadeScreenOut(500);
          Script.Wait(500);
          if (Blip.op_Inequality(this.ConvoyBlip1, (Blip) null))
            this.ConvoyBlip1.Remove();
          if (Blip.op_Inequality(this.ConvoyBlip2, (Blip) null))
            this.ConvoyBlip2.Remove();
          if (Blip.op_Inequality(this.ConvoyBlip3, (Blip) null))
            this.ConvoyBlip3.Remove();
          if (Entity.op_Inequality((Entity) this.Vehicle1, (Entity) null))
            ((Entity) this.Vehicle1).Delete();
          if (Entity.op_Inequality((Entity) this.Vehicle2, (Entity) null))
            ((Entity) this.Vehicle2).Delete();
          if (Entity.op_Inequality((Entity) this.Vehicle3, (Entity) null))
            ((Entity) this.Vehicle3).Delete();
          Script.Wait(500);
          Game.FadeScreenIn(500);
          this.stocksvalue = (float) ((double) this.stocksvalue + 500000.0 + 500000.0 * (double) this.profitMargin / 100.0);
          UI.Notify("Office Assistant: Great convoy Destoryed");
          UI.Notify("Office Assistant: Stocks just Increased");
          this.ShowIncrease();
          this.checkforconvoy = false;
          this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
          this.Config.Save();
        }
      }
      if (this.VehicleSetup)
      {
        if (this.Missionnum == 14)
        {
          if (!this.GotCar && ((Entity) this.VtoGet).get_IsAlive() && this.VtoGet.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
          {
            this.GotCar = true;
            Random random = new Random();
            if (random.Next(1, 100) < 20)
            {
              this.Dropzone = new Vector3(1737f, 3291f, 41f);
              this.DropzoneBlip = World.CreateBlip(this.Dropzone);
              this.DropzoneBlip.set_Name("Drop Zone");
              this.DropzoneBlip.set_Sprite((BlipSprite) 478);
              this.DropzoneBlip.set_Color((BlipColor) 0);
              this.DropzoneBlip.set_Name("Drop Zone");
            }
            if (random.Next(1, 100) > 20 && random.Next(1, 100) < 40)
            {
              this.Dropzone = new Vector3(141f, 6619f, 31f);
              this.DropzoneBlip = World.CreateBlip(this.Dropzone);
              this.DropzoneBlip.set_Name("Drop Zone");
              this.DropzoneBlip.set_Sprite((BlipSprite) 478);
              this.DropzoneBlip.set_Color((BlipColor) 0);
              this.DropzoneBlip.set_Name("Drop Zone");
            }
            if (random.Next(1, 100) > 40 && random.Next(1, 100) < 60)
            {
              this.Dropzone = new Vector3(2143f, 4801f, 41f);
              this.DropzoneBlip = World.CreateBlip(this.Dropzone);
              this.DropzoneBlip.set_Name("Drop Zone");
              this.DropzoneBlip.set_Sprite((BlipSprite) 478);
              this.DropzoneBlip.set_Color((BlipColor) 0);
              this.DropzoneBlip.set_Name("Drop Zone");
            }
            if (random.Next(1, 100) > 60 && random.Next(1, 100) < 80)
            {
              this.Dropzone = new Vector3(2817f, 1695f, 24f);
              this.DropzoneBlip = World.CreateBlip(this.Dropzone);
              this.DropzoneBlip.set_Name("Drop Zone");
              this.DropzoneBlip.set_Sprite((BlipSprite) 478);
              this.DropzoneBlip.set_Color((BlipColor) 0);
              this.DropzoneBlip.set_Name("Drop Zone");
            }
            if (random.Next(1, 100) > 80 && random.Next(1, 100) < 100)
            {
              this.Dropzone = new Vector3(-1154f, 2674f, 18f);
              this.DropzoneBlip = World.CreateBlip(this.Dropzone);
              this.DropzoneBlip.set_Name("Drop Zone");
              this.DropzoneBlip.set_Sprite((BlipSprite) 478);
              this.DropzoneBlip.set_Color((BlipColor) 0);
              this.DropzoneBlip.set_Name("Drop Zone");
            }
            if (Blip.op_Inequality(this.DropzoneBlip, (Blip) null))
              this.DropzoneBlip.set_ShowRoute(true);
          }
          if (((Entity) this.VtoGet).get_IsAlive())
          {
            if (this.VtoGet.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
            {
              if (Blip.op_Inequality(this.VtoGetBlip, (Blip) null))
                this.VtoGetBlip.set_Position(((Entity) this.VtoGet).get_Position());
              if (this.VtoGet.get_IsDamaged())
                this.VehicleisDamaged = true;
              if (this.Vehiclehealth != ((Entity) this.VtoGet).get_Health())
              {
                this.Vehiclehealth = ((Entity) this.VtoGet).get_Health();
                this.stocksvalue = (float) ((int) this.stocksvalue - (int) this.stocksvalue / 100);
                UI.Notify("Office Assistant : damaging the Mule, will decrease stock value, value : " + this.stocksvalue.ToString());
              }
              if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Dropzone) < 5.0)
              {
                if (Entity.op_Inequality((Entity) this.VtoGet, (Entity) null))
                  ((Entity) this.VtoGet).Delete();
                if (Blip.op_Inequality(this.VtoGetBlip, (Blip) null))
                  this.VtoGetBlip.Remove();
                if (Blip.op_Inequality(this.DropzoneBlip, (Blip) null))
                  this.DropzoneBlip.Remove();
                this.VehicleSetup = false;
                this.Missionnum = 0;
                this.stocksvalue = (float) ((int) this.stocksvalue + (int) this.stocksvalue / new Random().Next(5, 10));
                Script.Wait(200);
                Game.get_Player().set_Money(Game.get_Player().get_Money() + (int) this.stocksvalue);
                this.stocksvalue = 0.0f;
                this.stockscount = 0;
                this.Config.SetValue<int>("Setup", "stockslevel", (M0) this.stockscount);
                this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
                this.Config.Save();
                UI.Notify("Office Assistant : ok we got the delivery to the location, there is a little boost in there");
              }
              if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Dropzone) < 5.0)
                World.DrawMarker((MarkerType) 1, this.Dropzone, Vector3.get_Zero(), Vector3.get_Zero(), new Vector3(3f, 3f, 2f), Color.White);
            }
          }
          else
          {
            if (Entity.op_Inequality((Entity) this.VtoGet, (Entity) null))
              ((Entity) this.VtoGet).Delete();
            if (Blip.op_Inequality(this.VtoGetBlip, (Blip) null))
              this.VtoGetBlip.Remove();
            if (Blip.op_Inequality(this.DropzoneBlip, (Blip) null))
              this.DropzoneBlip.Remove();
            this.VehicleSetup = false;
            this.Missionnum = 0;
            this.stocksvalue = (float) ((int) this.stocksvalue - (int) this.stocksvalue / 2);
            Script.Wait(200);
            UI.Notify("Office Assistant : What were you doing out there we just lost 50% of out stock!");
          }
        }
        if (this.Missionnum == 11 && ((Entity) this.VehicleMissioncar).get_IsAlive())
        {
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
          {
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
            if (!this.TriggeredWanted)
            {
              Game.get_Player().set_WantedLevel(4);
              this.TriggeredWanted = true;
            }
          }
          if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
          if (this.warnedplayer)
          {
            UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
            this.warnedplayer = false;
          }
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer() && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.Dockloc) < 60.0)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            {
              this.VehicleMissioncar.set_IsDriveable(false);
              this.Missionnum = 0;
              Game.FadeScreenOut(300);
              Script.Wait(300);
              this.DestoryVehicle.Remove();
              this.VehicleSetup = false;
              Script.Wait(400);
              ((Entity) this.VehicleMissioncar).Delete();
              ((Entity) Game.get_Player().get_Character()).set_Position(this.Dockloc);
              Script.Wait(300);
              Game.FadeScreenIn(300);
            }
            this.stocksvalue = (float) ((double) this.stocksvalue + 325000.0 + 325000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
        }
        if (this.Missionnum == 10 && ((Entity) this.VehicleMissioncar).get_IsAlive())
        {
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
          {
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
            if (!this.TriggeredWanted)
            {
              Game.get_Player().set_WantedLevel(4);
              this.TriggeredWanted = true;
            }
          }
          if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
          if (this.warnedplayer)
          {
            UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
            this.warnedplayer = false;
          }
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            {
              this.VehicleMissioncar.set_IsDriveable(false);
              this.Missionnum = 0;
              Game.FadeScreenOut(300);
              Script.Wait(300);
              this.DestoryVehicle.Remove();
              this.VehicleSetup = false;
              Script.Wait(400);
              ((Entity) this.VehicleMissioncar).Delete();
              ((Entity) Game.get_Player().get_Character()).set_Position(this.AircraftStorageLoc);
              Script.Wait(300);
              Game.FadeScreenIn(300);
            }
            this.stocksvalue = (float) ((double) this.stocksvalue + 425000.0 + 425000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
        }
        if (this.Missionnum == 9 && ((Entity) this.VehicleMissioncar).get_IsAlive())
        {
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
          {
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
            if (!this.TriggeredWanted)
            {
              Game.get_Player().set_WantedLevel(4);
              this.TriggeredWanted = true;
            }
          }
          if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
          if (this.warnedplayer)
          {
            UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
            this.warnedplayer = false;
          }
          if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer() && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.LotLoc) < 60.0)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            {
              this.VehicleMissioncar.set_IsDriveable(false);
              this.Missionnum = 0;
              Game.FadeScreenOut(300);
              Script.Wait(300);
              this.DestoryVehicle.Remove();
              this.VehicleSetup = false;
              ((Entity) this.VehicleMissioncar).Delete();
              ((Entity) Game.get_Player().get_Character()).set_Position(this.LotLoc);
              Script.Wait(300);
              Game.FadeScreenIn(300);
            }
            this.stocksvalue = (float) ((double) this.stocksvalue + 225000.0 + 225000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
        }
        if ((this.Missionnum == 7 || this.Missionnum == 6 || this.Missionnum == 8) && Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
        {
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleMissioncar).get_Position()) < 500.0)
          {
            ((Entity) this.VehicleMissioncar).set_IsInvincible(false);
            ((Entity) this.VehicleMissioncar).set_IsVisible(true);
          }
          if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleMissioncar).get_Position()) > 500.0)
          {
            ((Entity) this.VehicleMissioncar).set_IsInvincible(true);
            ((Entity) this.VehicleMissioncar).set_IsVisible(true);
          }
          if (((Entity) this.VehicleMissioncar).get_IsAlive())
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null) && Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
            if (this.warnedplayer)
            {
              UI.Notify("Office Assistant: ok boss bring the vehicle to its designated storage and we can sell it ");
              this.warnedplayer = false;
            }
            if (this.VehicleMissioncar.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer())
            {
              Vector3 vector3 = this.LotLoc;
              if (this.Missionnum == 7)
                vector3 = this.LotLoc;
              if (this.Missionnum == 6)
                vector3 = this.AircraftStorageLoc;
              if (this.Missionnum == 8)
                vector3 = this.Dockloc;
              if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), vector3) < 60.0)
              {
                if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
                  this.DestoryVehicle.Remove();
                if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
                {
                  this.VehicleMissioncar.set_IsDriveable(false);
                  Game.FadeScreenOut(300);
                  Script.Wait(300);
                  this.VehicleSetup = false;
                  ((Entity) this.VehicleMissioncar).Delete();
                  ((Entity) Game.get_Player().get_Character()).set_Position(vector3);
                  Script.Wait(300);
                  Game.FadeScreenIn(300);
                }
                this.stocksvalue = (float) ((double) this.stocksvalue + 25000.0 + 25000.0 * (double) this.profitMargin / 100.0);
                UI.Notify("Office Assistant: ok good, the enemy vehicle is in our possesion we will sell it when we get a chance ");
                UI.Notify("Office Assistant: Stocks just Increased");
                this.ShowIncrease();
                this.VehicleSetup = false;
                this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
                this.Config.Save();
              }
            }
          }
          else
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
            {
              this.VehicleMissioncar.set_IsDriveable(false);
              Game.FadeScreenOut(300);
              Script.Wait(300);
              this.VehicleSetup = false;
              ((Entity) this.VehicleMissioncar).Delete();
              Script.Wait(300);
              Game.FadeScreenIn(300);
            }
            UI.Notify("Office Assistant: We lost the vehicle!, we will have to find another one! ");
            this.ShowIncrease();
            this.VehicleSetup = false;
          }
        }
        if (this.Missionnum == 5 && Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
          this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
        if (this.Missionnum == 5 && Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null) && (double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), ((Entity) this.VehicleMissioncar).get_Position()) < 500.0)
        {
          ((Entity) this.VehicleMissioncar).set_IsInvincible(false);
          ((Entity) this.VehicleMissioncar).set_IsVisible(true);
        }
        if (this.Missionnum == 2 || this.Missionnum == 3)
          this.DestoryVehicle.set_Position(((Entity) this.VehicleMissioncar).get_Position());
        if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null) && !((Entity) this.VehicleMissioncar).get_IsAlive())
        {
          if (this.Missionnum == 11)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            Game.FadeScreenOut(500);
            Script.Wait(500);
            Script.Wait(500);
            Game.FadeScreenIn(500);
            UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 10)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            Game.FadeScreenOut(500);
            Script.Wait(500);
            Script.Wait(500);
            Game.FadeScreenIn(500);
            UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 9)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            Game.FadeScreenOut(500);
            Script.Wait(500);
            ((Entity) this.VehicleMissioncar).Delete();
            Script.Wait(500);
            Game.FadeScreenIn(500);
            UI.Notify("Office Assistant: boss we needed that vehicle!, we will now have to do with out it ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 5)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            this.stocksvalue = (float) ((double) this.stocksvalue + 125000.0 + 125000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 4)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            this.stocksvalue = (float) ((double) this.stocksvalue + 75000.0 + 75000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 3)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            this.stocksvalue = (float) ((double) this.stocksvalue + 50000.0 + 50000.0 * (double) this.profitMargin / 100.0);
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 1)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            this.stocksvalue = (float) ((double) this.stocksvalue + 25000.0 + 25000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
          if (this.Missionnum == 2)
          {
            if (Blip.op_Inequality(this.DestoryVehicle, (Blip) null))
              this.DestoryVehicle.Remove();
            if (Entity.op_Inequality((Entity) this.VehicleMissioncar, (Entity) null))
              ((Entity) this.VehicleMissioncar).Delete();
            this.stocksvalue = (float) ((double) this.stocksvalue + 25000.0 + 25000.0 * (double) this.profitMargin / 100.0);
            UI.Notify("Office Assistant: ok good, the enemy vehicle is destoryed ");
            UI.Notify("Office Assistant: Stocks just Increased");
            this.ShowIncrease();
            this.VehicleSetup = false;
            this.Config.SetValue<float>("Setup", "StocksValue", (M0) (double) this.stocksvalue);
            this.Config.Save();
          }
        }
      }
      if (this.SourcingCheckingforDamage)
      {
        if (this.NewVehicleSourcing && Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null) && Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName() == this.SourcedVehicle)
          this.Vehicletoget = Game.get_Player().get_Character().get_CurrentVehicle();
        if (Entity.op_Inequality((Entity) this.Vehicletoget, (Entity) null) && this.Vehicletoget.get_IsDamaged())
        {
          this.SourcingCheckingforDamage = false;
          UI.Notify("Office Assistant: Be Carefull the Vehice is already damaged ");
        }
      }
      if (this.foundvehicleyet && !this.NewVehicleSourcing)
      {
        this.Vehicleloc = ((Entity) this.Vehicletoget).get_Position();
        if (Blip.op_Inequality(this.VehicleMarker, (Blip) null))
          this.VehicleMarker.set_Position(((Entity) this.Vehicletoget).get_Position());
        if (this.Vehicletoget.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer() && this.foundvehicleyet)
        {
          this.foundvehicleyet = true;
          this.Vehicletoget.set_IsDriveable(true);
          UI.Notify("Office Assistant: Boss that is the car we need, bring it back to the vehicle warehouse to sell it");
          this.foundvehicleyet = false;
          this.hasgotvehicle = true;
        }
      }
      if (!this.foundvehicleyet || !this.NewVehicleSourcing || !Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null) || !(Game.get_Player().get_Character().get_CurrentVehicle().get_DisplayName() == this.SourcedVehicle))
        return;
      this.Vehicletoget = Game.get_Player().get_Character().get_CurrentVehicle();
      if (this.Vehicletoget.GetPedOnSeat((VehicleSeat) -1).get_IsPlayer() && this.foundvehicleyet)
      {
        this.foundvehicleyet = true;
        this.Vehicletoget.set_IsDriveable(true);
        UI.Notify("Office Assistant: Boss that is the car we need, bring it back to the vehicle warehouse to sell it");
        this.foundvehicleyet = false;
        this.hasgotvehicle = true;
      }
    }

    public void ChangeYachtPositions()
    {
      this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
      if (!Entity.op_Inequality((Entity) this.Base, (Entity) null))
        return;
      this.MenuMarker = ((Entity) this.Base).GetOffsetInWorldCoords(this.MenuOffset);
      this.ChangeLocMarker = ((Entity) this.Base).GetOffsetInWorldCoords(this.CaptComputerOffset);
      this.SleepPos1 = new Vector3(0.0f, 0.0f, 0.0f);
      this.SleepPos2 = new Vector3(0.0f, 0.0f, 0.0f);
      if (this.YachtType == 0)
      {
        this.HeliPadAOffset = new Vector3(-51.5f, -1.999345f, 3f);
        this.HeliPadBOffset = new Vector3(-37.78258f, -1.999345f, -0.5f);
        this.MaxHelis = 1;
        this.HeliPosA = ((Entity) this.Base).GetOffsetInWorldCoords(this.HeliPadAOffset);
        this.HeliPosB = new Vector3(0.0f, 0.0f, 0.0f);
      }
      if (this.YachtType == 1)
      {
        this.HeliPadAOffset = new Vector3(-29.5f, -1.999345f, 6f);
        this.HeliPadBOffset = new Vector3(36f, -1.999345f, 4.5f);
        this.MaxHelis = 2;
        this.HeliPosA = ((Entity) this.Base).GetOffsetInWorldCoords(this.HeliPadAOffset);
        this.HeliPosB = ((Entity) this.Base).GetOffsetInWorldCoords(this.HeliPadBOffset);
      }
      if (this.YachtType == 2)
      {
        this.HeliPadAOffset = new Vector3(-29.5f, -1.999345f, 6f);
        this.HeliPadBOffset = new Vector3(36f, -1.999345f, 4.5f);
        this.MaxHelis = 2;
        this.HeliPosA = ((Entity) this.Base).GetOffsetInWorldCoords(this.HeliPadAOffset);
        this.HeliPosB = ((Entity) this.Base).GetOffsetInWorldCoords(this.HeliPadBOffset);
      }
      Vector3 vector3_1;
      ((Vector3) ref vector3_1).\u002Ector(-49f, -1.999345f, -1.1f);
      this.jacuzziSeat1 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_1);
      Vector3 vector3_2;
      ((Vector3) ref vector3_2).\u002Ector(-50f, -4f, -1.1f);
      this.jacuzziSeat2 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_2);
      Vector3 vector3_3;
      ((Vector3) ref vector3_3).\u002Ector(-50f, 0.0f, -1.1f);
      this.jacuzziSeat3 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_3);
      Vector3 vector3_4;
      ((Vector3) ref vector3_4).\u002Ector(-52f, 0.0f, -1.1f);
      this.jacuzziSeat4 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_4);
      Vector3 vector3_5;
      ((Vector3) ref vector3_5).\u002Ector(-52f, -4f, -1.1f);
      this.jacuzziSeat5 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_5);
      Vector3 vector3_6;
      ((Vector3) ref vector3_6).\u002Ector(-53f, -1.999345f, -1.1f);
      this.jacuzziSeat6 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_6);
      Vector3 vector3_7;
      ((Vector3) ref vector3_7).\u002Ector(27f, -4f, 0.0f);
      this.Bed1 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_7);
      Vector3 vector3_8;
      ((Vector3) ref vector3_8).\u002Ector(19f, -6.5f, 0.0f);
      this.Bed2 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_8);
      Vector3 vector3_9;
      ((Vector3) ref vector3_9).\u002Ector(0.0f, -2f, 0.0f);
      this.Bed3 = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_9);
      Vector3 vector3_10;
      ((Vector3) ref vector3_10).\u002Ector(23.2f, -2.026101f, 2.5f);
      this.BarPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_10);
      Vector3 vector3_11;
      ((Vector3) ref vector3_11).\u002Ector(21.66955f, -2.026101f, 2.5f);
      this.BarDrinkPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_11);
      Vector3 vector3_12;
      ((Vector3) ref vector3_12).\u002Ector(31.5f, -6.5f, -0.5f);
      Vector3 vector3_13;
      ((Vector3) ref vector3_13).\u002Ector(30.5f, -7.5f, -0.5f);
      this.ShowerAPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_12);
      this.ShowerAPosEnter = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_13);
      Vector3 vector3_14;
      ((Vector3) ref vector3_14).\u002Ector(20.5f, 0.2f, -0.5f);
      Vector3 vector3_15;
      ((Vector3) ref vector3_15).\u002Ector(19.5f, -1f, -0.5f);
      this.ShowerBPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_14);
      this.ShowerBPosEnter = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_15);
      Vector3 vector3_16;
      ((Vector3) ref vector3_16).\u002Ector(8.5f, -1f, -0.5f);
      Vector3 vector3_17;
      ((Vector3) ref vector3_17).\u002Ector(7f, -2.026101f, -0.5f);
      this.ShowerCPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_16);
      this.ShowerCPosEnter = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_17);
      this.BarEnter = ((Entity) this.Base).GetOffsetInWorldCoords(this.BackEntranceOffset);
      this.BarExit = ((Entity) this.Base).GetOffsetInWorldCoords(this.BackIntOffset);
      this.CaptinsQuartersEnter = ((Entity) this.Base).GetOffsetInWorldCoords(this.CaptEntranceOffset);
      this.CaptinsQuartersExit = ((Entity) this.Base).GetOffsetInWorldCoords(this.CaptIntOffset);
      Vector3 vector3_18;
      ((Vector3) ref vector3_18).\u002Ector(-62f, 1f, -5.6f);
      this.SeaSharkPosA = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_18);
      Vector3 vector3_19;
      ((Vector3) ref vector3_19).\u002Ector(-62f, -1f, -5.6f);
      this.SeaSharkPosB = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_19);
      Vector3 vector3_20;
      ((Vector3) ref vector3_20).\u002Ector(-62f, -3f, -5.6f);
      this.SeaSharkPosC = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_20);
      Vector3 vector3_21;
      ((Vector3) ref vector3_21).\u002Ector(-62f, -5f, -5.6f);
      this.SeaSharkPosD = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_21);
      Vector3 vector3_22;
      ((Vector3) ref vector3_22).\u002Ector(-58f, -12f, -5.6f);
      this.BoatAPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_22);
      Vector3 vector3_23;
      ((Vector3) ref vector3_23).\u002Ector(-58f, 8f, -5.6f);
      this.BoatBPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_23);
      this.ChangeLocMarker = ((Entity) this.Base).GetOffsetInWorldCoords(this.CaptComputerOffset);
      Vector3 vector3_24;
      ((Vector3) ref vector3_24).\u002Ector(23f, -4f, -0.5f);
      this.WoredrobeAPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_24);
      Vector3 vector3_25;
      ((Vector3) ref vector3_25).\u002Ector(17f, -6f, -0.5f);
      this.WoredrobeBPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_25);
      Vector3 vector3_26;
      ((Vector3) ref vector3_26).\u002Ector(-1f, -6f, -0.5f);
      this.WoredrobeCPos = ((Entity) this.Base).GetOffsetInWorldCoords(vector3_26);
      if (Entity.op_Inequality((Entity) this.FlagA, (Entity) null))
        ((Entity) this.FlagA).Delete();
      if (Entity.op_Inequality((Entity) this.FlagB, (Entity) null))
        ((Entity) this.FlagB).Delete();
      if (Entity.op_Inequality((Entity) this.FlagC, (Entity) null))
        ((Entity) this.FlagC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorC, (Entity) null))
        ((Entity) this.DoorC).Delete();
      if (Entity.op_Inequality((Entity) this.DoorB, (Entity) null))
        ((Entity) this.DoorB).Delete();
      if (Entity.op_Inequality((Entity) this.Bargirl, (Entity) null))
        ((Entity) this.Bargirl).Delete();
      if (this.DoorType == 0 && Entity.op_Inequality((Entity) this.Base, (Entity) null))
      {
        this.SpawnDoor("apa_mp_apa_yacht_door", ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z - 90.0)), 4);
        this.SpawnDoor("apa_mp_apa_yacht_door", ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z - 90.0)), 5);
      }
      if (this.DoorType == 1 && Entity.op_Inequality((Entity) this.Base, (Entity) null))
      {
        this.SpawnDoor("apa_mp_apa_yacht_door2", ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z - 90.0)), 4);
        this.SpawnDoor("apa_mp_apa_yacht_door2", ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-1f, -1.996299f, 5.5f)), new Vector3(0.0f, 0.0f, (float) (((Entity) this.Base).get_Rotation().Z - 90.0)), 5);
      }
      if ((uint) this.CurrentFlag > 0U)
      {
        this.SpawnFlagA(this.FlagList[this.CurrentFlag], ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-3f, -0.45f, 9.8f)), new Vector3(0.0f, -50f, (float) (((Entity) this.Base).get_Rotation().Z + 0.0)), 5);
        this.SpawnFlagB(this.FlagList[this.CurrentFlag], ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-3f, -3.55f, 9.8f)), new Vector3(0.0f, -50f, (float) (((Entity) this.Base).get_Rotation().Z + 0.0)), 5);
        this.SpawnFlagC(this.FlagList[this.CurrentFlag], ((Entity) this.Base).GetOffsetInWorldCoords(new Vector3(-56.5f, -1.996299f, 0.5f)), new Vector3(0.0f, -50f, (float) (((Entity) this.Base).get_Rotation().Z - 0.0)), 5);
      }
      if (Entity.op_Inequality((Entity) this.DoorB, (Entity) null))
      {
        ((Entity) this.DoorB).Detach();
        ((Entity) this.DoorB).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, -3.3f, 6.6f), new Vector3(0.0f, 0.0f, 90f));
        ((Entity) this.DoorB).set_HasCollision(true);
        this.Props.Add(this.DoorB);
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.DoorB),
          InputArgument.op_Implicit(this.ShipColor)
        });
      }
      Script.Wait(1);
      if (Entity.op_Inequality((Entity) this.DoorC, (Entity) null))
      {
        ((Entity) this.DoorC).Detach();
        ((Entity) this.DoorC).AttachTo((Entity) this.Base, 0, new Vector3(0.0f, -0.6f, 6.6f), new Vector3(0.0f, 0.0f, -90f));
        ((Entity) this.DoorC).set_HasCollision(true);
        this.Props.Add(this.DoorC);
        Function.Call((Hash) -7557708654927622093L, new InputArgument[2]
        {
          InputArgument.op_Implicit(this.DoorC),
          InputArgument.op_Implicit(this.ShipColor)
        });
      }
      this.RadioPos.Clear();
      Vector3 vector3_27;
      ((Vector3) ref vector3_27).\u002Ector(27.5f, -8f, -0.5f);
      this.RadioPos.Add(((Entity) this.Base).GetOffsetInWorldCoords(vector3_27));
      Vector3 vector3_28;
      ((Vector3) ref vector3_28).\u002Ector(12f, -1f, -0.5f);
      this.RadioPos.Add(((Entity) this.Base).GetOffsetInWorldCoords(vector3_28));
      Vector3 vector3_29;
      ((Vector3) ref vector3_29).\u002Ector(4.5f, -1.5f, -0.5f);
      this.RadioPos.Add(((Entity) this.Base).GetOffsetInWorldCoords(vector3_29));
      Vector3 vector3_30;
      ((Vector3) ref vector3_30).\u002Ector(3f, -2.2f, 2.8f);
      this.RadioPos.Add(((Entity) this.Base).GetOffsetInWorldCoords(vector3_30));
      Vector3 vector3_31;
      ((Vector3) ref vector3_31).\u002Ector(5.2f, -4.1f, 2.8f);
      this.RadioPos.Add(((Entity) this.Base).GetOffsetInWorldCoords(vector3_31));
    }

    public Vector3 GetYachtRotation(int ID)
    {
      Vector3 vector3 = (Vector3) null;
      if (ID == 1)
        vector3 = (Vector3) null;
      if (ID == 2)
        vector3 = (Vector3) null;
      if (ID == 3)
        vector3 = (Vector3) null;
      if (ID == 4)
        vector3 = (Vector3) null;
      if (ID == 5)
        vector3 = (Vector3) null;
      if (ID == 6)
        vector3 = (Vector3) null;
      if (ID == 7)
        vector3 = (Vector3) null;
      if (ID == 8)
        vector3 = (Vector3) null;
      if (ID == 9)
        vector3 = (Vector3) null;
      if (ID == 10)
        vector3 = (Vector3) null;
      if (ID == 11)
        vector3 = (Vector3) null;
      if (ID == 12)
        vector3 = (Vector3) null;
      if (ID == 13)
        vector3 = (Vector3) null;
      if (ID == 14)
        vector3 = (Vector3) null;
      if (ID == 15)
        vector3 = (Vector3) null;
      if (ID == 16)
        vector3 = (Vector3) null;
      if (ID == 17)
        vector3 = (Vector3) null;
      if (ID == 18)
        vector3 = (Vector3) null;
      if (ID == 19)
        vector3 = (Vector3) null;
      if (ID == 20)
        vector3 = (Vector3) null;
      if (ID == 21)
        vector3 = (Vector3) null;
      if (ID == 22)
        vector3 = (Vector3) null;
      if (ID == 23)
        vector3 = (Vector3) null;
      if (ID == 24)
        vector3 = (Vector3) null;
      if (ID == 25)
        vector3 = (Vector3) null;
      if (ID == 26)
        vector3 = (Vector3) null;
      if (ID == 27)
        vector3 = (Vector3) null;
      if (ID == 28)
        vector3 = (Vector3) null;
      if (ID == 29)
        vector3 = (Vector3) null;
      if (ID == 30)
        vector3 = (Vector3) null;
      if (ID == 31)
        vector3 = (Vector3) null;
      if (ID == 32)
        vector3 = (Vector3) null;
      if (ID == 33)
        vector3 = (Vector3) null;
      if (ID == 34)
        vector3 = (Vector3) null;
      if (ID == 35)
        vector3 = (Vector3) null;
      if (ID == 36)
        vector3 = (Vector3) null;
      return vector3;
    }

    public Vector3 GetYachtIPLPosition(int ID)
    {
      Vector3 vector3 = (Vector3) null;
      if (ID == 1)
        vector3 = (Vector3) null;
      if (ID == 2)
        vector3 = (Vector3) null;
      if (ID == 3)
        vector3 = (Vector3) null;
      if (ID == 4)
        vector3 = (Vector3) null;
      if (ID == 5)
        vector3 = (Vector3) null;
      if (ID == 6)
        vector3 = (Vector3) null;
      if (ID == 7)
        vector3 = (Vector3) null;
      if (ID == 8)
        vector3 = (Vector3) null;
      if (ID == 9)
        vector3 = (Vector3) null;
      if (ID == 10)
        vector3 = (Vector3) null;
      if (ID == 11)
        vector3 = (Vector3) null;
      if (ID == 12)
        vector3 = (Vector3) null;
      if (ID == 13)
        vector3 = (Vector3) null;
      if (ID == 14)
        vector3 = (Vector3) null;
      if (ID == 15)
        vector3 = (Vector3) null;
      if (ID == 16)
        vector3 = (Vector3) null;
      if (ID == 17)
        vector3 = (Vector3) null;
      if (ID == 18)
        vector3 = (Vector3) null;
      if (ID == 19)
        vector3 = (Vector3) null;
      if (ID == 20)
        vector3 = (Vector3) null;
      if (ID == 21)
        vector3 = (Vector3) null;
      if (ID == 22)
        vector3 = (Vector3) null;
      if (ID == 23)
        vector3 = (Vector3) null;
      if (ID == 24)
        vector3 = (Vector3) null;
      if (ID == 25)
        vector3 = (Vector3) null;
      if (ID == 26)
        vector3 = (Vector3) null;
      if (ID == 27)
        vector3 = (Vector3) null;
      if (ID == 28)
        vector3 = (Vector3) null;
      if (ID == 29)
        vector3 = (Vector3) null;
      if (ID == 30)
        vector3 = (Vector3) null;
      if (ID == 31)
        vector3 = (Vector3) null;
      if (ID == 32)
        vector3 = (Vector3) null;
      if (ID == 33)
        vector3 = (Vector3) null;
      if (ID == 34)
        vector3 = (Vector3) null;
      if (ID == 35)
        vector3 = (Vector3) null;
      if (ID == 36)
        vector3 = (Vector3) null;
      return vector3;
    }

    public void SpawnYacht()
    {
      try
      {
        if (Entity.op_Inequality((Entity) this.Base2, (Entity) null))
          ((Entity) this.Base2).Delete();
        this.LoadIniFile2("scripts//GalaxyClassSuperYacht//Yacht.ini");
        for (int index = 1; index < 37; ++index)
        {
          if (index != this.Location)
          {
            using (List<Prop>.Enumerator enumerator = this.Props.GetEnumerator())
            {
              while (enumerator.MoveNext())
              {
                Prop current = enumerator.Current;
                if (Entity.op_Inequality((Entity) current, (Entity) null))
                  ((Entity) current).Delete();
              }
            }
          }
        }
        string str1 = this.YachtHashs[this.Location];
        string str2 = this.YachtHashs2[this.Location];
        int location = this.Location;
        if (this.Location <= 0 || this.Location >= 38)
          return;
        if (this.YachtType == 0)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o1_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o1_rail_b";
          this.Rail = "apa_MP_Apa_Yacht_O1_Rail_B";
          this.YachtTop = "apa_mp_apa_yacht_option1";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_01a";
        }
        if (this.YachtType == 1)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o2_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o2_rail_b";
          this.YachtTop = "apa_mp_apa_yacht_option2";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
        }
        if (this.YachtType == 2)
        {
          if (!this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o3_rail_a";
          else if (this.GoldRails)
            this.Rail = "apa_mp_apa_yacht_o3_rail_b";
          this.YachtTop = "apa_mp_apa_yacht_option3";
          this.YachtLauncher = "apa_mp_apa_yacht_launcher_02a";
        }
        if (Entity.op_Inequality((Entity) this.Base, (Entity) null))
        {
          UI.Notify("~b~ Starting Yacht Spawning, please be patient");
          this.SpawnProp(this.YachtTop, this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 1);
          this.SpawnProp(this.Rail, this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 2);
          if (this.YachtType == 0)
          {
            if (this.Lighting == 1)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y1_l1a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y1_l1b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y1_l1c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y1_l1d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.Lighting == 2)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y1_l2a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y1_l2b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y1_l2c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y1_l2d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.DoorType == 0)
              this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            if (this.DoorType == 1)
              this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
          }
          if (this.YachtType == 1)
          {
            this.SpawnProp("apa_mp_apa_yacht_option2_cola", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 1);
            this.SpawnProp("apa_mp_apa_yacht_option2_colb", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 2);
            if (this.Lighting == 1)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y2_l1a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y2_l1b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y2_l1c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y2_l1d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.Lighting == 2)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y2_l2a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y2_l2b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y2_l2c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y2_l2d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.DoorType == 0)
              this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            if (this.DoorType == 1)
              this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
          }
          if (this.YachtType == 2)
          {
            this.SpawnProp("apa_mp_apa_yacht_option3_cola", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 1);
            this.SpawnProp("apa_mp_apa_yacht_option3_colb", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 2);
            this.SpawnProp("apa_mp_apa_yacht_option3_colc", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 1);
            this.SpawnProp("apa_mp_apa_yacht_option3_cold", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 2);
            this.SpawnProp("apa_mp_apa_yacht_option3_cole", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 1);
            if (this.Lighting == 1)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y3_l1a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y3_l1b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y3_l1c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y3_l1d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.Lighting == 2)
            {
              if (this.LightingColor == 1)
                this.SpawnProp("apa_mp_apa_y3_l2a", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 2)
                this.SpawnProp("apa_mp_apa_y3_l2b", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 3)
                this.SpawnProp("apa_mp_apa_y3_l2c", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
              if (this.LightingColor == 4)
                this.SpawnProp("apa_mp_apa_y3_l2d", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 3);
            }
            if (this.DoorType == 0)
              this.SpawnProp("apa_mp_apa_yacht_door", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            if (this.DoorType == 1)
              this.SpawnProp("apa_mp_apa_yacht_door2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 6);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple1", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
            this.SpawnProp("apa_mp_apa_yacht_jacuzzi_ripple2", this.YachtPos[this.Location], new Vector3(0.0f, 0.0f, 0.0f), 7);
          }
        }
        if (Entity.op_Equality((Entity) this.Base, (Entity) null))
          UI.Notify("Test Case Scenario Failed");
      }
      catch
      {
        UI.Notify("~r~ Failed to Spawn Yacht~w~, Attempting again!");
      }
    }

    public void OnKeyDown()
    {
      if (this.Missionnum == 13 && Game.IsControlJustPressed(2, (Control) 51))
      {
        if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(213f, -936f, 24f)) < 3.0)
          ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(227f, -1001f, -99f));
        else if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), new Vector3(227f, -1001f, -99f)) < 4.0)
        {
          if (Entity.op_Inequality((Entity) Game.get_Player().get_Character().get_CurrentVehicle(), (Entity) null))
          {
            ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).set_Position(new Vector3(213f, -936f, 24f));
            ((Entity) Game.get_Player().get_Character().get_CurrentVehicle()).set_Rotation(new Vector3(0.0f, 0.0f, -34f));
            Game.get_Player().set_WantedLevel(2);
          }
          else
            ((Entity) Game.get_Player().get_Character()).set_Position(new Vector3(213f, -936f, 24f));
        }
      }
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeAPos) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
        this.WoredrobeMainMenu.set_Visible(!this.WoredrobeMainMenu.get_Visible());
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeBPos) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
        this.WoredrobeMainMenu.set_Visible(!this.WoredrobeMainMenu.get_Visible());
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.WoredrobeCPos) < 2.0 && Game.IsControlJustPressed(2, (Control) 51))
        this.WoredrobeMainMenu.set_Visible(!this.WoredrobeMainMenu.get_Visible());
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerAPos) < 3.0 && Game.IsControlJustPressed(2, (Control) 51))
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
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerAPos);
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
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerAPosEnter);
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
      if ((double) World.GetDistance(((Entity) Game.get_Player().get_Character()).get_Position(), this.ShowerBPos) < 3.0 && Game.IsControlJustPressed(2, (Control) 51))
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
          ((Entity) Game.get_Player().get_Character()).set_Position(this.ShowerBPos);
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
