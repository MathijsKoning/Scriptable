using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "ScriptableObjects/Monster")]
public class DefaultScriptableObject : ScriptableObject
{
    public string monsterName;
    public float hitpoints;
    public float damage;
}
