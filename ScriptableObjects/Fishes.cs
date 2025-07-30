using System.Collections.Generic;
using ScriptableObjects.Lists;
using UnityEngine;

[CreateAssetMenu(fileName = "Fishes", menuName = "Scriptable Objects/Fishes")]
public class Fishes : ScriptableObject
{
    
    public int ID;
    public Sprite Sprite;
    public string Name;
    public string Description;
    
    public string Buff;
    public float BuffQuantity;
}



