using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A class that have functionalities shared by all guns
/// </summary>
public class GunClass : MonoBehaviour
{

    [SerializeField] protected GameObject ammo;
    [SerializeField] protected GameObject spawnPoint;

    protected int bulletCount;

    private void OnMouseDown()
    {
        if (bulletCount > 1)
        { ShootingMethod(bulletCount); }
        else { ShootingMethod(); }
    }

    protected virtual void ShootingMethod()
    {
        // spawning one preFab ammo directed right
        Instantiate(ammo, spawnPoint.transform.position, ammo.transform.rotation);
    }

    protected virtual void ShootingMethod(int number)
    {
        // spawning many preFabs ammos directed right
        for (int i = 0; i < number; i++)
        {
            if (i % 2 == 0)
            { Instantiate(ammo, spawnPoint.transform.position + new Vector3(0, i/4, 0), ammo.transform.rotation); }
            else
            { Instantiate(ammo, spawnPoint.transform.position - new Vector3(0, i/4, 0), ammo.transform.rotation); }
        }
    }


}
