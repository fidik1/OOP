using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EntityData", menuName = "ScriptableObjects/EntityDataScriptableObject")]
public class EntityData : ScriptableObject
{
    [field: SerializeField] public string Name { get; set; }
    [field: SerializeField] public Sprite Icon { get; set; }
    [field: SerializeField] public Sprite IconFullHeight { get; set; }
    [field: SerializeField] public float Health { get; private set; }
    [field: SerializeField] public float Damage { get; private set; }
    [field: SerializeField] public int Level { get; private set; }
}
