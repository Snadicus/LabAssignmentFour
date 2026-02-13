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
    public int hitDie;
    public int hp;

    public Character()
    {

    }

    public Character(string playerClass, int hitDie)
    {
        this.playerClass = playerClass;
        this.hitDie = hitDie;
        Debug.Log(this.playerClass);
        Debug.Log(this.hitDie);
    }
}
