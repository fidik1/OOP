using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Entity
{
    [field: SerializeField] public HeroData HeroData { get; set; }
    public GradeEnum Grade { get; set; }
    public WeaponEnum WeaponType { get; set; }
    public ElementsEnum ElementType { get; set; }
    [field: SerializeField] public List<Ability> Abilities { get; set; }
    [field: SerializeField] public Ultimate Ultimate { get; set; }

    protected override void Initialize()
    {
        base.Initialize();
        Grade = HeroData.Grade;
        WeaponType = HeroData.WeaponType;
        ElementType = HeroData.ElementType;
    }

    public void UseUltimate()
    {
        Ultimate.Use();
    }

    public void UseAbility(int index)
    {
        if (index >= 0 && index < Abilities.Count && Abilities[index].CanUse())
        {
            Abilities[index].Use();
        }
    }
}
