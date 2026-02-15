using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class SolutionOne : MonoBehaviour
{

    // String Variables
    public string playerClass;
    public string playerRace;
    public string playerName;

    // Integer Variables
    public int playerLevel;
    public int conScore;
    private int hp;

    // Lists
    [SerializeField] List<string> playerFeat;

    // Boolean Variables
    public bool isAverage;

    // Arrays
    private string[] raceArray = {"aasimar", "dragonborn", "dwarf", "elf", "gnome", "goliath", "halfling", "human", "orc", "tiefling"};

    // Dictionary. String is Classes, Integer is Hit Dice
    Dictionary<string, int> classesDict = new Dictionary<string, int>()
    {
        {"artificer", 8},
        {"barbarian", 12},
        {"bard", 8},
        {"cleric", 8},
        {"druid", 8},
        {"fighter", 10},
        {"monk", 8},
        {"ranger", 10},
        {"rogue", 8},
        {"paladin", 10},
        {"sorcerer", 6},
        {"wizard", 6},
        {"warlock", 8}
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // First, the program checks to see if all of your variables are valid.
    // Then, the program calculates your health based of the variables and options selected.
    // Finally, the program prints your information and HP.
    void Start()
    {
        CheckVariables();
        CalculateHealth();
        Debug.Log("Your character is " + playerName + ", a level " + playerLevel + " " + playerRace + " " + playerClass);
        Debug.Log("Your Constitution score is: " + conScore);
        if (playerFeat.Contains("tough"))
        {
            Debug.Log("You have the feat 'tough'.");
        }
        if (playerFeat.Contains("stout"))
        {
            Debug.Log("You have the feat 'stout'.");
        }
        if (isAverage)
        {
            Debug.Log("You chose to have their Hit Points be determined via dice roll average.");
        }
        else
        {
            Debug.Log("You chose to have their Hit Points be determined via random dice rolling.");
        }
        Debug.Log("Your Hit Point amount is: " + hp);
    }

    // Checks all inputs from the user. If any inputs do not match, the values below are used in place
    // Converts all strings to lower case, so that the user does not produce an error if writing an upper case input
    void CheckVariables()
    {
        Convert.ToInt32(playerLevel);
        Convert.ToInt32(conScore);

        playerClass = playerClass.ToLower();
        playerRace = playerRace.ToLower();
        for (int i = 0; i < playerFeat.Count; i++)
        {
            playerFeat[i] = playerFeat[i].ToLower();
        }

        if (!classesDict.ContainsKey(playerClass))
        {
            Debug.Log("Gave invalid class, your class is fighter.");
            playerClass = "fighter";
        }

        if (playerLevel > 20)
        {
            Debug.Log("Level cannot be greater than 20 you cheater. It has been set to 20.");
            playerLevel = 20;
        }
        else if (playerLevel < 1)
        {
            Debug.Log("Level cannot be lower than 1. It has been set to 1.");
    
        playerLevel = 1;
        }

        if (conScore > 30)
        {
            Debug.Log("Your Constitution Score is too high. It has been set to 30.");
            conScore = 30;
        }
        else if (conScore < 1)
        {
            Debug.Log("Your Constitution Score is too low. It has been set to 1.");
            conScore = 1;
        }

        if (!raceArray.Contains(playerRace))
        {
            Debug.Log("Invalid race. You are now a human.");
            playerRace = "human";
        }
    }

    void CalculateHealth()
    {
        // Uses 'if' if user checks the 'Is Average' button. Calculates average HP instead of rolling.
        // Otherwise, uses 'else' to generate random values for health calculations, according to the playerClass variable.
        if (isAverage)
        {
            int totalNumber = 0;
            for (int i = 1; i <= classesDict[playerClass]; i++)
            {
                totalNumber += i;
            }
            int average = Convert.ToInt32(totalNumber / classesDict[playerClass]);
            hp += average * playerLevel;
        }
        else
        {
            int totalNumber = 0;
            for (int i = 0; i < playerLevel; i++)
            {
                totalNumber += UnityEngine.Random.Range(1, classesDict[playerClass]);
            }
            hp += totalNumber;
        }

        // Uses a Switch statment to give each possible Consitution Score a Case.
        // This Case will then give the player the proper modifier, along with having the modifier affect each Level of the character.
        switch (conScore)
            {
            case 1:
                hp += -5 * playerLevel;
                break;
            case 2:
            case 3:
                hp += -4 * playerLevel;
                break;
            case 4:
            case 5:
                hp += -3 * playerLevel;
                break;
            case 6:
            case 7:
                hp += -2 * playerLevel;
                break;
            case 8:
            case 9:
                hp += -1 * playerLevel;
                break;
            case 10:
            case 11:
                hp += 0 * playerLevel;
                break;
            case 12:
            case 13:
                hp += 1 * playerLevel;
                break;
            case 14:
            case 15:
                hp += 2 * playerLevel;
                break;
            case 16:
            case 17:
                hp += 3 * playerLevel;
                break;
            case 18:
            case 19:
                hp += 4 * playerLevel;
                break;
            case 20:
            case 21:
                hp += 5 * playerLevel;
                break;
            case 22:
            case 23:
                hp += 6 * playerLevel;
                break;
            case 24:
            case 25:
                hp += 7 * playerLevel;
                break;
            case 26:
            case 27:
                hp += 8 * playerLevel;
                break;
            case 28:
            case 29:
                hp += 9 * playerLevel;
                break;
            case 30:
                hp += 10 * playerLevel;
                break;
        }

        // Checks if the player has input any Feats that matter to health caculation.
        if (playerFeat.Contains("tough"))
        {
            hp += 2 * playerLevel;
    
        }
        if (playerFeat.Contains("stout"))
        {
            hp += playerLevel;
    
        }

        // If the player inputs a race which affects health calculations, it will be added here.
        if (playerRace == "dwarf")
        {
            hp += playerLevel * 2;
    
        }
        else if (playerRace == "orc" || playerRace == "goliath")
        {
            hp += playerLevel;
    
        }

        // This check makes sure your hit points never go into the negatives, as that would mean a dead character.
        if (hp <= 0)
        {
            hp = 1;
            Debug.Log("Your Hit Points came out to less than 1!");
            Debug.Log("Because this would mean your character is dead, we will bring your hit points up to 1 instead.");
        }
    }
}
