/*
name: Army Hollowborn Rep
description: Farm reputation with your army. Faction: Hollowborn
tags: army, reputation, hollowborn
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/Story/LordsofChaos/Core13LoC.cs
//cs_include Scripts/Army/CoreArmyLite.cs
//cs_include Scripts/Story/RavenlossSaga.cs
//cs_include Scripts/Story/PockeymogsStory.cs
//cs_include Scripts/Army/ArmyFarm/Rep/CoreArmyRep.cs
using Skua.Core.Interfaces;
using Skua.Core.Models.Items;
using Skua.Core.Options;

public class ArmyHollowbornRep
{
    private IScriptInterface Bot => IScriptInterface.Instance;
    private CoreBots Core => CoreBots.Instance;
    private CoreFarms Farm = new();
    private CoreAdvanced Adv = new();
    private CoreArmyLite Army = new();
    private CoreArmyRep CAR = new();
    private static CoreBots sCore = new();
    private static CoreArmyLite sArmy = new();

    public string OptionsStorage = "ArmyHollowbornRep";
    public bool DontPreconfigure = true;
    public List<IOption> Options = new List<IOption>()
    {
        sArmy.player1,
        sArmy.player2,
        sArmy.player3,
        sArmy.player4,
        sArmy.packetDelay,
        CoreBots.Instance.SkipOptions
    };

    public void ScriptMain(IScriptInterface bot)
    {
        Core.BankingBlackList.Add("Hollow Soul");

        Core.SetOptions();

        Setup();

        Core.SetOptions(false);
    }

    public void Setup() => CAR.ArmyHollowbornRep();
}
