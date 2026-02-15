using System.Collections.Generic;
using UnityEngine;

public class Character
{
    // Important character information
    private string playerClass;
    private string race;
    private int conScore;
    private int playerLevel;
    private bool isAverage;
    private Dictionary<string, int> feats;
    private int hitDie;
    private int hitPointBonus;
    private int conScoreModifier;
    private int hp;


    public Character()
    {

    }

    public Character(int playerLevel, int conModifier, bool isAverage, string playerName)
    {
        List<string> currentFeats = new List<string> { "" };
        int total = 0;
        string isAverageString = "";
        var rand = new System.Random();
        // When instantiating Character, calculate hp
        if (isAverage)
        {
            isAverageString = "Averaged";
            for (int i = 1; i <= hitDie; i++)
            {
                total += i;
            }
            //hp += Convert.ToInt32(total/hitDie) * playerLevel;
        }
        else
        {
            isAverageString = "Random";
            for (int i = 1; i <= playerLevel; i++)
            {
                //total += rand.Next(1, hitDie);
                Debug.Log(total);
            }
            hp += total;
        }
        hp += (conModifier + hitPointBonus) * playerLevel;
        if (feats == null)
        {
            currentFeats.Add("no");
        }
        else
        {
            if (feats.ContainsKey("Stout"))
            {
                hp += playerLevel;
                currentFeats.Add("Stout");
            }
            if (feats.ContainsKey("Tough"))
            {
                hp += playerLevel * feats["Tough"];
                currentFeats.Add("Tough");
            }
        }
        // Print character information
        Debug.Log($"My character {playerName} is a level {playerLevel} {playerClass} with a CON score of {conScore} and is of {race} and has {currentFeats[0]} feat. I want the HP {isAverageString}.");
        Debug.Log($"Characters hp is {hp}.");
    }

    public void ChangeClass(string playerClass, int hitDie)
    {
        // Change the characters class and hit die for calculations
        this.playerClass = playerClass;
        this.hitDie = hitDie;
        Debug.Log(this.playerClass);
        Debug.Log(this.hitDie);
    }

    public void ChangeRace(string race, int hitPointBonus)
    {
        // Change the characters race and any hit point bonuses
        this.race = race;
        this.hitPointBonus = hitPointBonus;
        Debug.Log(this.race);
        Debug.Log(this.hitPointBonus);
    }

    public void AddFeat(string feat, int hitPointFeatBonus)
    {
        this.feats.Add(feat, hitPointFeatBonus);
        Debug.Log(this.feats);
    }
}
