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

        // Printing chosen Con and its modifier
        if (chosenCon < 1 || chosenCon > 30)
        {
            chosenCon = 1;
        }
        Debug.Log(this.chosenCon);
        Debug.Log(this.conModifier);

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

        /*
        // adding a modifer to the character based on what the players chosen constitution is
        switch (chosenCon)
        {
            default:
            case 1:
                ConScore1 conScore1 = new ConScore1();
                break;
            case 2:
                ConScore2 conScore2 = new ConScore2();
                break;
            case 3:
                ConScore3 conScore3 = new ConScore3();
                break;
            case 4:
                ConScore4 conScore4 = new ConScore4();
                break;
            case 5:
                ConScore5 conScore5 = new ConScore5();
                break;
            case 6:
                ConScore6 conScore6 = new ConScore6();
                break;
            case 7:
                ConScore7 conScore7 = new ConScore7();
                break;
            case 8:
                ConScore8 conScore8 = new ConScore8();
                break;
            case 9:
                ConScore9 conScore9 = new ConScore9();
                break;
            case 10:
                ConScore10 conScore10 = new ConScore10();
                break;
            case 11:
                ConScore11 conScore11 = new ConScore11();
                break;
            case 12:
                ConScore12 conScore12 = new ConScore12();
                break;
            case 13:
                ConScore13 conScore13 = new ConScore13();
                break;
            case 14:
                ConScore14 conScore14 = new ConScore14();
                break;
            case 15:
                ConScore15 conScore15 = new ConScore15();
                break;
            case 16:
                ConScore16 conScore16 = new ConScore16();
                break;
            case 17:
                ConScore17 conScore17 = new ConScore17();
                break;
            case 18:
                ConScore18 conScore18 = new ConScore18();
                break;
            case 19:
                ConScore19 conScore19 = new ConScore19();
                break;
            case 20:
                ConScore20 conScore20 = new ConScore20();
                break;
            case 21:
                ConScore21 conScore21 = new ConScore21();
                break;
            case 22:
                ConScore22 conScore22 = new ConScore22();
                break;
            case 23:
                ConScore23 conScore23 = new ConScore23();
                break;
            case 24:
                ConScore24 conScore24 = new ConScore24();
                break;
            case 25:
                ConScore25 conScore25 = new ConScore25();
                break;
            case 26:
                ConScore26 conScore26 = new ConScore26();
                break;
            case 27:
                ConScore27 conScore27 = new ConScore27();
                break;
            case 28:
                ConScore28 conScore28 = new ConScore28();
                break;
            case 29:
                ConScore29 conScore29 = new ConScore29();
                break;
            case 30:
                ConScore30 conScore30 = new ConScore30();
                break;

        }
        */

    }

}
