using UnityEngine;

public class Tough : Character
{
    public Tough()
    {
        // Change the Character's race and the amount of extra hit points recieved
        AddFeat("Tough", 2);
    }
}
