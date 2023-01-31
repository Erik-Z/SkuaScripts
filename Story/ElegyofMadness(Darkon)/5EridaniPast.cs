/*
name: Eridani Past
description: This will finish the Eridani Past quest.
tags: story, quest, elegy-of-madness, darkon, eridani-past
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/Story/ElegyofMadness(Darkon)/CoreAstravia.cs
using Skua.Core.Interfaces;

public class CompleteEridaniPast
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreStory Story = new CoreStory();
    public CoreAstravia Astravia => new CoreAstravia();
    public void ScriptMain(IScriptInterface bot)
    {
        Core.SetOptions();

        Astravia.EridaniPast();

        Core.SetOptions(false);
    }
}
