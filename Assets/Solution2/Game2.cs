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

    void Start()
    {
        CheckVariables();
        Debug.Log(chosenClass);
        Debug.Log(chosenRace);
        Debug.Log(chosenName);
        Debug.Log(chosenLevel);
        Debug.Log(chosenConScore);
        Debug.Log(chosenFeat);
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

        Debug.Log("Final HP: " + hp);
    }

    // Check variables input by the player and gives invalid values defualt values
    void CheckVariables()
    {
        Convert.ToInt32(chosenLevel);
        Convert.ToInt32(chosenConScore);

        chosenClass = chosenClass.ToLower();
        chosenRace = chosenRace.ToLower();
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

        if (!raceArray.Contains(chosenRace))
        {
            Debug.Log("Invalid race. You are now a human.");
            chosenRace = "human";
        }
    }
}
