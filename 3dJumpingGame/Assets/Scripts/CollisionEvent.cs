using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]


public class CollisionEvent : MonoBehaviour
{
    public UnityEvent OnCollide;
    public UnityEvent OnPlayerCollide;
    public UnityEvent OnEnemyCollide;
    public UnityEvent OnDoorTrigger;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnPlayerCollide.Invoke();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            OnEnemyCollide.Invoke();
        }

        OnCollide.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Door"))
        {
            OnDoorTrigger.Invoke();
        }
    }
}
