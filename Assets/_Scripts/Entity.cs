using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [field: SerializeField] public EntityData EntityData {get; set;}
    public string Name { get; set; }
    public Sprite Icon { get; set; }
    public float Health { get; protected set; }
    public float Damage { get; protected set; }
    public int Level { get; protected set; }

    private void Start()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        Name = EntityData.Name;
        Icon = EntityData.Icon;
        Health = EntityData.Health;
        Damage = EntityData.Damage;
        Level = EntityData.Level;
    }

    public bool IsDead { get; protected set; }

    public void SetHealth(float health)
    {
        if (health > 0)
        {
            Health = health;
        }
        else
        {
            Health = 1;
        }
    }

    public void SetDamage(float damage)
    {
        if (damage > 0)
        {
            Damage = damage;
        }
        else
        {
            Damage = 1;
        }
    }

    public void TakeDamage(float damage)
    {
        if (Health - damage > 0)
        {
            Health -= damage;
        }
        else
        {
            IsDead = true;
            Health = 0;
        }
        Debug.Log($"{Name} get {damage} damage. Current health: {Health}");
    }

    public virtual void Die()
    {
        Debug.Log($"{Name} dead");
    }
}
