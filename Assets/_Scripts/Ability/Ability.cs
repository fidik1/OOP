using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : MonoBehaviour
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public float TimeCooldown { get; private set; }
    protected bool _onCooldown = false;

    public void Use()
    {
        if (CanUse())
        {
            AbilityLogic();
            _onCooldown = true;
            StartCoroutine(CooldownTimer());
        }
        else
        {
            Debug.Log($"Ability {Name} on cooldown");
        }
    }

    protected virtual void AbilityLogic()
    {
        Debug.Log($"Used ability {Name}");
    }

    public bool CanUse()
    {
        return !_onCooldown;
    }

    private IEnumerator CooldownTimer()
    {
        yield return new WaitForSecondsRealtime(TimeCooldown);
        _onCooldown = false;
    }
}
