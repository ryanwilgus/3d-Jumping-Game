using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorSpawn : MonoBehaviour
{
    public UnityEvent OnCollide;
    public UnityEvent OnPlayerCollide;
    public GameObject Door;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnPlayerCollide.Invoke();
            Instantiate(Door, this.transform.position, this.transform.rotation);
        }

        OnCollide.Invoke();
    }
}
