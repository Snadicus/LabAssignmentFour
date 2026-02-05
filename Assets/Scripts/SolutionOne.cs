using NUnit.Framework;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SolutionOne : MonoBehaviour
{

    // String Variables
    public string playerClass;
    public string playerRace;

    // Integer Variables
    public int playerLevel;
    public int constitutionScore;
    private int hitPoints;

    // Lists
    [SerializeField] List<string> playerFeat;

    // Boolean Variables
    public bool average;

    // Arrays
    private string[] raceArray = {"Aasimar", "Dragonborn", "Dwarf", "Elf", "Gnome", "Goliath", "Halfling", "Human", "Orc", "Tiefling"};

    // Multidimensional Arrays
    /*int[,] conBonuses = new int[,]
    {
        {1,-5},
        {2,-4},
        {3,-4},
        {4,-3},
        {5,-3},
        {6,-2},
        {7,-2},
        {8,-1},
        {9,-1},
        {10,0},
        {11,0},
        {12,1},
        {13,1},
        {14,2},
        {15,2},
        {16,3},
        {17,3},
        {18,4},
        {19,4},
        {20,5},
        {21,5},
        {22,6},
        {23,6},
        {24,7},
        {25,7},
        {26,8},
        {27,8},
        {28,9},
        {29,9},
        {30,10}
    }; */

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
