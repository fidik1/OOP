using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ultimate : Ability
{
    protected override void AbilityLogic()
    {
        Debug.Log($"Used ultimate {Name}");
    }
}
