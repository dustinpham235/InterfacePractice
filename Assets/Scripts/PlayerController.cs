using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    private List<GameObject> _weaponsLists;
    private IWeapons _currentWeapon;
    private bool _alreadyHave;

    private void Start()
    {
        _weaponsLists = InventoryManager.instance.weaponsList;
        _currentWeapon = _weaponsLists[0].GetComponent<IWeapons>();
    }

    private void OnEnable()
    {
        InventoryManager.OnItemAdded += NewWeaponPickedUp;
        InventoryManager.OnItemRemoved += OutAmmoAutoRemove;
    }

    private void OnDisable()
    {
        InventoryManager.OnItemAdded -= NewWeaponPickedUp;
        InventoryManager.OnItemRemoved -= OutAmmoAutoRemove;
    }

    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     InventoryManager.instance.addItem(items[0]);
        //     print(items[0].ItemName);
        //     _currentWeapon = Instantiate<GameObject>(items[0].ActionableItem, transform.position, Quaternion.identity).GetComponent<IWeapons>();
        // }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InventoryManager.instance.addItem(_weaponsLists[1]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            InventoryManager.instance.addItem(_weaponsLists[2]);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            InventoryManager.instance.removeItem();
        }

        if (Input.GetMouseButtonDown(0))
        {
            _currentWeapon.Shoot();
        }
    }

    private void NewWeaponPickedUp()
    {
        _currentWeapon = InventoryManager._currentWeaponClone.GetComponent<IWeapons>();
    }

    private void OutAmmoAutoRemove()
    {
        _currentWeapon = InventoryManager._currentWeaponClone.GetComponent<IWeapons>();
    }
}