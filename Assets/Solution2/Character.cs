using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string playerClass;
    public string name;
    public string race;
    public int conScore;
    public int playerLevel;
    public bool isAverage;
    public List<string> feats;
    public Character()
    {
        playerClass = "fighter";
    }

    public Character(string playerClass)
    {
        this.playerClass = playerClass;
    }
}
