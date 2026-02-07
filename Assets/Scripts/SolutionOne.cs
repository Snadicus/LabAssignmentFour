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
    private string[] raceArray = {"Aasimar", "Dragonborn", "Dwarf", "Elf", "Gnome", "Goliath", "Halfling", "Human", "Orc", "Tiefling"};

    // Dictionary Variables
    Dictionary<string, int> classesDict = new Dictionary<string, int>()
    {
        {"Artificer", 8},
        {"Barbarian", 12},
        {"Bard", 8},
        {"Cleric", 8},
        {"Druid", 8},
        {"Fighter", 10},
        {"Monk", 8},
        {"Ranger", 10},
        {"Rogue", 8},
        {"Paladin", 10},
        {"Sorcerer", 6},
        {"Wizard", 6},
        {"Warlock", 8}
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CheckVariables();
        CalculateHealth();
        Debug.Log(hp);
    }

    void CheckVariables()
    {
        Convert.ToInt32(playerLevel);
        Convert.ToInt32(conScore);

        if (!classesDict.ContainsKey(playerClass))
        {
            Debug.Log("Gave invalid class, your class is Fighter");
            playerClass = "Fighter";
        }

        if (playerLevel > 20)
        {
            Debug.Log("Level cannot be greater than 20 you cheater.");
            playerLevel = 20;
        }
        else if (playerLevel < 1)
        {
            Debug.Log("Level cannot be lower than 1.");
    
        playerLevel = 1;
        }

        if (conScore > 30)
        {
            Debug.Log("conScore too high");
            conScore = 30;
        }
        else if (conScore < 1)
        {
            Debug.Log("conScore too low");
            conScore = 1;
        }

        if (!raceArray.Contains(playerRace))
        {
            Debug.Log("Invalid race. You are now a human.");
            playerRace = "Human";
        }
    }

    void CalculateHealth()
    {
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
                totalNumber += UnityEngine.Random.Range(1, classesDict[playerClass] + 1);
            }
            hp += totalNumber;
    
    }
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
        if (playerFeat.Contains("Tough"))
        {
            hp += 2 * playerLevel;
    
    }
        if (playerFeat.Contains("Stout"))
        {
            hp += playerLevel;
    
    }
        if (playerRace == "Dwarf")
        {
            hp += playerLevel * 2;
    
    }
        else if (playerRace == "Orc" || playerRace == "Goliath")
        {
            hp += playerLevel;
    
    }
    }
}
