using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // Important character information
    public string playerClass;
    public string name;
    public string race;
    public int conScore;
    public int playerLevel;
    public bool isAverage;
    public List<string> feats;
    public int hitDie;
    public int hp;

    public Character()
    {
        // When instantiating Character, calculate hp

        // Print character information
    }

    public void ChangeClass(string playerClass, int hitDie)
    {
        this.playerClass = playerClass;
        this.hitDie = hitDie;
        Debug.Log(this.playerClass);
        Debug.Log(this.hitDie);
    }
}
