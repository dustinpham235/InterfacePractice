
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// [RequireComponent(typeof(InventoryManager))]
// public class UIManager : MonoBehaviour {
    
//     #region Events
//     private void OnEnable()
//     {
//         InventoryManager.OnItemAdded += OnItemAdded;
//         InventoryManager.OnItemRemoved += OnItemRemoved;
//     }
//     private void OnDisable()
//     {
//         InventoryManager.OnItemAdded -= OnItemAdded;
//         InventoryManager.OnItemRemoved -= OnItemRemoved;
//     }
//     #endregion

//     public Image itemTemplate;
//     Dictionary<SO_Item, Image> existingItems = new Dictionary<SO_Item, Image>();

//     void OnItemAdded(SO_Item item, int count)
//     {
//         if (existingItems.ContainsKey(item))
//         {
//             existingItems[item].GetComponentInChildren<Text>().text = count.ToString();
//             return;
//         }

//         Image tmp = Instantiate<Image>(itemTemplate);
//         tmp.transform.SetParent(itemTemplate.transform.parent);
//         tmp.GetComponentInChildren<Text>().text = count.ToString();
//         tmp.color = item.ButtonColor;
//         tmp.gameObject.SetActive(true);
//         existingItems.Add(item, tmp);
//     }

//     void OnItemRemoved(SO_Item item, int count)
//     {
//         if (existingItems.ContainsKey(item))
//         {
//             if (count <= 0)
//             {
//                 Destroy(existingItems[item].gameObject);
//                 existingItems.Remove(item);
//                 return;
//             }
//             existingItems[item].GetComponentInChildren<Text>().text = count.ToString();
//         }
//     }

// }