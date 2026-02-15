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
    public int hitPointBonus;
    public int conScoreModifier;
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

    public void ChangeRace(string race, int hitPointBonus)
    {
        this.race = race;
        this.hitPointBonus = hitPointBonus;
        Debug.Log(this.race);
        Debug.Log(this.hitPointBonus);
    }

    public void AddFeat(string feat, int hitPointFeatBonus)
    {
        Debug.Log(feat);
        Debug.Log(hitPointFeatBonus);
    }

    /*
    public void ChangeCon(int conScore, int conScoreModifier)
    {
        this.conScore = conScore;
        this.conScoreModifier = conScoreModifier;
        Debug.Log(this.conScore);
        Debug.Log(this.conScoreModifier);
    }
    */
}
