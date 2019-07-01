// using UnityEngine;

// public class Pickable : MonoBehaviour {

//     public SO_Item refItem;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.transform.CompareTag("Player") && InventoryManager.instance.addItem(refItem))
//         {
//             print("Picked "+ refItem.ItemName);
//             Destroy(gameObject);
//         }
//     }

// }