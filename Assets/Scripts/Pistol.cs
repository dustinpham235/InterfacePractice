using UnityEngine;

public class Pistol : MonoBehaviour, IWeapons
{
    public ParticleSystem _ps;
    public int _ammo = 50;


    private void OnEnable()
    {
        _ammo = 50;
    }

    public void Shoot()
    {
        if (_ammo > 0)
        {
            print("Pistol Shooting");
            var clone = Instantiate(_ps, transform.position, Quaternion.identity);
            Destroy(clone, 1f);
            _ammo --;
        }
        else
        {
            InventoryManager.instance.removeItem();
        }
    }
}
