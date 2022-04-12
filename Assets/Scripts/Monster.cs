using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // Monster HAS a Goblin
    [SerializeField] private DefaultScriptableObject _scriptableObject;
    
    void Start()
    {
        Debug.Log(_scriptableObject.monsterName);
    }
}
