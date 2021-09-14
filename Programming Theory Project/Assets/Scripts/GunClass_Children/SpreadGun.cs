using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class SpreadGun : GunClass
{
    [SerializeField] private int newBulletCount = 5;

    [SerializeField] private float angleMaximum = 45;

    private void Start()
    {
        bulletCount = newBulletCount;
    }

    // POLYMORPHISM
    protected override void ShootingMethod(int number)
    {
        // spawning many preFabs ammos directed right

        // ABSTRACTION
        float[] ar_shootAngles = ShootAngles(bulletCount, angleMaximum);

        for (int i = 0; i < number; i++)
        {
            Instantiate(ammo, spawnPoint.transform.position, Quaternion.Euler(0, 0, ar_shootAngles[i]));
        }
    }

    // ABSTRACTED METHOD
    private float[] ShootAngles(int shootNumber, float angleMax)
    {
        float[] shootAngles = new float[shootNumber];

        float increment = angleMax / (1 + shootNumber);

        for (int i = 0; i < shootNumber; i++)
        {
            shootAngles[i] = -angleMax / 2 + increment * (i + 1);
        }

        return shootAngles;
    }

}
