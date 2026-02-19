using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Game2 : MonoBehaviour
{
    // Player Input
    // String Variables
    public string chosenClass;
    public string chosenRace;
    public string chosenName;

    // Integer Variables
    public int chosenLevel;
    public int chosenConScore;

    // Lists
    public List<string> chosenFeat;

    // Boolean Variables
    public bool chosenAverage;

    // Arrays
    private string[] raceArray = { "aasimar", "dragonborn", "dwarf", "elf", "gnome", "goliath", "halfling", "human", "orc", "tiefling" };
    private string[] classArray = { "artificer", "barbarian", "bard", "cleric", "druid", "fighter", "monk", "paladin", "ranger", "rogue", "sorcerer", "warlock", "wizard"};

    void Start()
    {
        // Build Character with chosen variables
        CheckVariables();
        Debug.Log("Your character is a level " + chosenLevel + " " + chosenRace + " " + chosenClass + " named " + chosenName + ".");
        Debug.Log("Their Constitution Score is " + chosenConScore + ".");
        if (chosenFeat.Contains("tough"))
        {
            Debug.Log("You have the feat 'tough'.");
        }
        if (chosenFeat.Contains("stout"))
        {
            Debug.Log("You have the feat 'stout'.");
        }
        if (chosenAverage == true)
        {
            Debug.Log("You chose to have their Hit Points be determined via dice roll average.");
        }
        else
        {
            Debug.Log("You chose to have their Hit Points be determined via random dice rolling.");
        }
        Character2 character = new Character2(
            chosenClass,
            chosenRace,
            chosenName,
            chosenLevel,
            chosenConScore,
            chosenFeat,
            chosenAverage
            );

        Calculater calc = new Calculater();
        int hp = calc.Calculatehp(character);

        Debug.Log("The Hit Point total of your character is: " + hp);
    }

    // Check variables input by the player and gives invalid values defualt values
    void CheckVariables()
    {
        Convert.ToInt32(chosenLevel);
        Convert.ToInt32(chosenConScore);

        chosenClass = chosenClass.ToLower();
        chosenRace = chosenRace.ToLower();

        if (!raceArray.Contains(chosenRace))
        {
            Debug.Log("Invalid race. You are now a human.");
            chosenRace = "human";
        }
        if (!classArray.Contains(chosenClass))
        {
            Debug.Log("Invalid class. You are now a fighter.");
            chosenClass = "fighter";
        }
        for (int i = 0; i < chosenFeat.Count; i++)
        {
            chosenFeat[i] = chosenFeat[i].ToLower();
        }
        if (chosenLevel > 20)
        {
            Debug.Log("Level cannot be greater than 20 you cheater. It has been set to 20.");
            chosenLevel = 20;
        }
        else if (chosenLevel < 1)
        {
            Debug.Log("Level cannot be lower than 1. It has been set to 1.");

            chosenLevel = 1;
        }

        if (chosenConScore > 30)
        {
            Debug.Log("Your Constitution Score is too high. It has been set to 30.");
            chosenConScore = 30;
        }
        else if (chosenConScore < 1)
        {
            Debug.Log("Your Constitution Score is too low. It has been set to 1.");
            chosenConScore = 1;
        }
    }
}
