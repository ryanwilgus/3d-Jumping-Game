using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BossHealth : MonoBehaviour
{
    public UnityEvent OnBulletTrigger;
    public GameObject Key;

    private float enemyHealth = 1500;
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
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
            Instantiate(Key, this.transform.position, this.transform.rotation);
        }
    }
}
