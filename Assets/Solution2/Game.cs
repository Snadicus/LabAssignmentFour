using UnityEngine;
using System.Collections.Generic;

public class Game : MonoBehaviour
{

    public string chosenClass;

    void Start()
    {
        chosenClass == chosenClass.ToLower();
        switch (chosenClass)
        {
            case default:
            case "fighter":
                Fighter playerClass = new Fighter();
                break;
            case "artificer":
                Artificer playerClass = new Artificer();
                break;
            case "barbarian":
                Barbarian playerClass = new Barbarian();
                break;
            case "bard":
                Bard playerClass = new Bard();
                break;
            case "druid":
                Druid playerClass = new Druid();
                break;
            case "fighter":
                Fighter playerClass = new Fighter();
                break;
            case "monk":
                Monk playerClass = new Monk();
                break;
            case "ranger":
                Ranger playerClass = new Ranger();
                break;
            case "rogue":
                Rogue playerClass = new Rogue();
                break;
            case "paladin":
                Paladin playerClass = new Paladin();
                break;
            case "sorcerer":
                Sorcerer playerClass = new Sorcerer();
                break;
            case "wizard":
                Wizard playerClass = new Wizard();
                break;
            case "warlock":
                Warlock playerClass = new Warlock();
                break;
        }
    }
    
}
