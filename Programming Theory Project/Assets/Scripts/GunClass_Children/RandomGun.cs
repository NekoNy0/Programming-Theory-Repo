using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RandomGun : GunClass
{
    [SerializeField] private float randomValue = 22.5f;
    
    // POLYMORPHISM
    protected override void ShootingMethod()
    {
        float randomDirection = Random.Range(-randomValue, randomValue);
        Instantiate(ammo, spawnPoint.transform.position, Quaternion.Euler(0, 0, randomDirection));
    }
}
