using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : InteractObjectScript
{
    public Item loot;
    public void Interact()
    {
        Debug.Log("You found " + loot.gameObject.name + " in the chest.");
    }

}
