using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeakEnemyHealth : MonoBehaviour
{
    public UnityEvent OnBulletTrigger;

    private float enemyHealth = 100;
    public int bulletDamage = 50;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            enemyHealth = enemyHealth - bulletDamage;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
