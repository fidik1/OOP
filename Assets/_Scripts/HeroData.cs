using UnityEngine;

[CreateAssetMenu(fileName = "HeroData", menuName = "ScriptableObjects/HeroDataScriptableObject")]
public class HeroData : ScriptableObject
{
    [field: SerializeField] public GradeEnum Grade { get; set; }
    [field: SerializeField] public WeaponEnum WeaponType { get; set; }
    [field: SerializeField] public ElementsEnum ElementType { get; set; }
}
