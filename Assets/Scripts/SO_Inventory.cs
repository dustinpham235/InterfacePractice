using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory_", menuName = "Data/SO_Inventory")]
public class SO_Inventory : ScriptableObject {
    public List<SO_Item> Items;
}