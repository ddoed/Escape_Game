using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : ScriptableObject
{
    public string mName;
}

[CreateAssetMenu(fileName = "data", menuName = "ItemData/doorKey")]
public class DoorKey : ItemData
{
    public int doorId;
}
