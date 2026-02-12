using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
public class PlayerClass : MonoBehaviour
{
    public static string chosenClass;
    Character character = new Character();

    public void ChangeClass(string chosenClass)
    {
        character.playerClass = chosenClass;
    }
}
