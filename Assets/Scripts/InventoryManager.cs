using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    #region Singleton
    public static InventoryManager instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
            return;
        }
        instance = this;
    }
    #endregion

    #region Events
    public delegate void InventoryModified();
    public static event InventoryModified OnItemAdded;
    public static event InventoryModified OnItemRemoved;
    #endregion

    public List<GameObject> weaponsList;
    public Stack<GameObject> playerInventory = new Stack<GameObject>();
    public static GameObject _currentWeaponClone;

    private void Start()
    {
        playerInventory.Push(weaponsList[0]);
        _currentWeaponClone = playerInventory.Peek();
        _currentWeaponClone.SetActive(true);
        
        print(playerInventory.Count);
    }

    public GameObject addItem(GameObject itemToAdd)
    {
        //If the item to add is Null, then cant add any item
        if (itemToAdd == null)
            return null;

        if (playerInventory.Count < 2)
        {
            _currentWeaponClone.SetActive(false);
            playerInventory.Push(itemToAdd);

            _currentWeaponClone = itemToAdd;
            _currentWeaponClone.SetActive(true);
            OnItemAdded();
            return _currentWeaponClone;
        }

        if (playerInventory.Count == 2)
        {
            playerInventory.Pop();
            _currentWeaponClone.SetActive(false);
            playerInventory.Push(itemToAdd);


            _currentWeaponClone = itemToAdd;
            _currentWeaponClone.SetActive(true);
            OnItemAdded();
            return _currentWeaponClone;
        }
        return null;
    }

    public GameObject removeItem()
    {
        // if (itemToRemove == null)
        //     return null;

        playerInventory.Pop();
        _currentWeaponClone.SetActive(false);
        _currentWeaponClone = playerInventory.Peek();
        _currentWeaponClone.SetActive(true);
        OnItemRemoved();
        return _currentWeaponClone;
    }

}