using UnityEngine;

//This adds an entry onto my editor -> Create/Data/SO_Item
[CreateAssetMenu(fileName ="Item_", menuName = "Data/SO_Item")]
public class SO_Item : ScriptableObject {
    public string ItemName;
    public int MaxAmount;
    public Texture Icon;
    public GameObject ActionableItem;
    public GameObject PickableItem;
    public Color ButtonColor;
}