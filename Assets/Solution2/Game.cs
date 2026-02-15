using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour
{
    // Player input
    public string chosenClass;
    public string chosenRace;
    public int playerLevel;
    public int chosenCon;
    private int conModifier;
    public List<string> chosenFeats;
    public string playerName;
    public bool isAverage;

    void Start()
    {
        // puts player input into lowercase to account for accidentle or wrong capitilization
        chosenClass = chosenClass.ToLower();
        chosenRace = chosenRace.ToLower();
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

        // adding a race to the character race based on what the players chosen race is
        switch (chosenRace)
        {
            default:
            case "human":
                Human human = new Human();
                break;
            case "aasimar":
                Aasimar aasimar = new Aasimar();
                break;
            case "dragonborn":
                Dragonborn dragonborn = new Dragonborn();
                break;
            case "dwarf":
                Dwarf dwarf = new Dwarf();
                break;
            case "elf":
                Elf elf = new Elf();
                break;
            case "gnome":
                Gnome gnome = new Gnome();
                break;
            case "goliath":
                Goliath goliath = new Goliath();
                break;
            case "halfling":
                Halfling halfling = new Halfling();
                break;
            case "orc":
                Orc orc = new Orc();
                break;
            case "tiefling":
                Tiefling tiefling = new Tiefling();
                break;
        }
        // adding a modifer to the character based on what the players chosen constitution is
        switch (chosenCon)
        {
            default:
            case 1:
                conModifier = -5;
                break;
            case 2:
            case 3:
                conModifier = -4;
                break;
            case 4:
            case 5:
                conModifier = -3;
                break;
            case 6:
            case 7:
                conModifier = -2;
                break;
            case 8:
            case 9:
                conModifier = -1;
                break;
            case 10:
            case 11:
                conModifier = 0;
                break;
            case 12:
            case 13:
                conModifier = 1;
                break;
            case 14:
            case 15:
                conModifier = 2;
                break;
            case 16:
            case 17:
                conModifier = 3;
                break;
            case 18:
            case 19:
                conModifier = 4;
                break;
            case 20:
            case 21:
                conModifier = 5;
                break;
            case 22:
            case 23:
                conModifier = 6;
                break;
            case 24:
            case 25:
                conModifier = 7;
                break;
            case 26:
            case 27:
                conModifier = 8;
                break;
            case 28:
            case 29:
                conModifier = 9;
                break;
            case 30:
                conModifier = 10;
                break;
        }

        // Feats
        for (int i = 0; i < chosenFeats.Count; i++)
        {
            chosenFeats[i] = chosenFeats[i].ToLower();
        }

        if (chosenFeats.Contains("tough"))
        {
            Tough tough = new Tough();
        }
        if (chosenFeats.Contains("stout"))
        {
            Stout stout = new Stout();
        }

        if (playerName == null)
        {
            playerName = "John Doe";
        }

        if (playerLevel < 1)
        {
            playerLevel = 1;
        }
        else if(playerLevel > 20)
        {
            playerLevel = 20;
        }

        Character character = new Character(playerLevel, conModifier, isAverage, playerName);
    }
}
