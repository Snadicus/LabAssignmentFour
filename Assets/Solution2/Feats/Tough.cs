using UnityEngine;

public class Tough : Character
{
    public Tough()
    {
        // Add to the Character's feat and the amount of extra hit points recieved
        AddFeat("Tough", 2);
    }
}
