using UnityEngine;
using System.Collections.Generic;

public class Character2
{
    // Characters values
    // String Variables
    public string playerClass;
    public string playerRace;
    public string playerName;

    // Integer Variables
    public int playerLevel;
    public int conScore;
    public int hp;
    public int raceBonus;

    // Lists
    [SerializeField] List<string> playerFeat;

    // Boolean Variables
    public bool isAverage;
   

    // Dictionary. String is Classes, Integer is Hit Dice
    Dictionary<string, int> classesDict = new Dictionary<string, int>()
    {
        {"artificer", 8},
        {"barbarian", 12},
        {"bard", 8},
        {"cleric", 8},
        {"druid", 8},
        {"fighter", 10},
        {"monk", 8},
        {"ranger", 10},
        {"rogue", 8},
        {"paladin", 10},
        {"sorcerer", 6},
        {"wizard", 6},
        {"warlock", 8}
    };

    public Character2()
    {

    }

    public Character2(string playerClass, string playerRace, string playerName, int playerLevel, int conScore, List<string> playerFeat, bool isAverage)
    {
        this.playerClass = playerClass;
        this.playerRace = playerRace;
        this.playerName = playerName;
        this.playerLevel = playerLevel;
        this.conScore = conScore;
        this.playerFeat = playerFeat;
        this.isAverage = isAverage;
        // Quick check to make sure chosen class is valid
        if (!classesDict.ContainsKey(playerClass))
        {
            Debug.Log("Gave invalid class, your class is fighter.");
            this.playerClass = "fighter";
        }
        if (playerRace == "dwarf")
        {
            raceBonus = 2;
        }
        else if (playerRace == "orc" || playerRace == "goliath")
        {
            raceBonus = 1;
        }
    }

    public int GetHitDie()
    {
        return classesDict[playerClass];
    }

    public int GetRaceBonus()
    {
        return raceBonus;
    }

    public List<string> GetFeats()
    {
        return playerFeat;
    }

}
