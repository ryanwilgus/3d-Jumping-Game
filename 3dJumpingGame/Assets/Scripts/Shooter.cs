using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public UnityEvent onShoot;
    public GameObject Bullet;

    public bool canShoot;
    public float timeBetweenShots;
    private float timeUntilNextShot;
    private int bulletCount = 0;
    public Text ammoDisplay;
    private int bulletDisplay = 15;

    private void Update()
    {
        if (Time.time > timeUntilNextShot)
        {
            canShoot = true;
        }
        ammoDisplay.text = bulletDisplay.ToString();
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
            bulletDisplay = 15;
        }
        if (canShoot == true)
        {
            Instantiate(Bullet, this.transform.position, this.transform.rotation);
            bulletCount += 1;
            bulletDisplay -= 1;
        }
    }
}
