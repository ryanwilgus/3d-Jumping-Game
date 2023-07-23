using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    public UnityEvent onShoot;
    public GameObject Bullet;

    public bool canShoot;
    public float timeBetweenShots;
    private float timeUntilNextShot;
    private int bulletCount = 0;

    private void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
    }

    public void Shoot()
    {
        onShoot.Invoke();
    }

    public void Fire()
    {
        if(bulletCount >= 15)
        {
            canShoot = false;
            timeUntilNextShot = (Time.time / 2) + timeUntilNextShot;
            bulletCount = 0;
        }

        if (canShoot == true)
        {
            Instantiate(Bullet, this.transform.position, this.transform.rotation);
            bulletCount += 1;
        }
    }
}
