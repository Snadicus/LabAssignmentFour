using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    // Player input
    public string chosenClass;
    public int playerLevel;

    void Start()
    {
        // puts player input into lowercase to account for accidentle or wrong capitilization
        chosenClass = chosenClass.ToLower();
        // adding a class to the character class based on what the players chosen class is
        switch (chosenClass)
        {
            default:
            case "fighter":
                Fighter fighter = new Fighter();
                break;
            case "artificer":
                Artificer artificer = new Artificer();
                break;
            case "barbarian":
                Barbarian barbarian = new Barbarian();
                break;
            case "bard":
                Bard bard = new Bard();
                break;
            case "cleric":
                Cleric cleric = new Cleric();
                break;
            case "druid":
                Druid druid = new Druid();
                break;
            case "monk":
                Monk monk = new Monk();
                break;
            case "ranger":
                Ranger ranger = new Ranger();
                break;
            case "rogue":
                Rogue rogue = new Rogue();
                break;
            case "paladin":
                Paladin paladin = new Paladin();
                break;
            case "sorcerer":
                Sorcerer sorcerer = new Sorcerer();
                break;
            case "wizard":
                Wizard wizard = new Wizard();
                break;
            case "warlock":
                Warlock warlock = new Warlock();
                break;
        }
    }
    
}
