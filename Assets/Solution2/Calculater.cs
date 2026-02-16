using System;
using System.Collections.Generic;
using UnityEngine;

public class Calculater
{
    public int Calculatehp(Character2 character)
    {
        int hitDie = character.GetHitDie();
        int playerLevel = character.playerLevel;
        int raceBonus = character.GetRaceBonus();
        int conScore = character.conScore;
        bool isAverage = character.isAverage;
        List<string> feats = character.GetFeats();

        int hp = 0;
        // Uses 'if' if user checks the 'Is Average' button. Calculates average HP instead of rolling.
        // Otherwise, uses 'else' to generate random values for health calculations, according to the playerClass variable.
        if (isAverage)
        {
            int totalNumber = 0;
            for (int i = 1; i <= hitDie; i++)
            {
                totalNumber += i;
            }
            int average = Convert.ToInt32(totalNumber / hitDie);
            hp += average * playerLevel;
        }
        else
        {
            int totalNumber = 0;
            for (int i = 0; i < playerLevel; i++)
            {
                totalNumber += UnityEngine.Random.Range(1, hitDie+1);
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
        if (feats.Contains("tough"))
        {
            hp += 2 * playerLevel;

        }
        if (feats.Contains("stout"))
        {
            hp += playerLevel;

        }

        // If the player inputs a race which affects health calculations, it will be added here.
        hp += playerLevel * raceBonus;

        // This check makes sure your hit points never go into the negatives, as that would mean a dead character.
        if (hp <= 0)
        {
            hp = 1;
            Debug.Log("Your Hit Points came out to less than 1!");
            Debug.Log("Because this would mean your character is dead, we will bring your hit points up to 1 instead.");
        }
        return hp;
    }
}
