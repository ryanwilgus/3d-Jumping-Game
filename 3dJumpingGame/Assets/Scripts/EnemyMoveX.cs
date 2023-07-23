using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveX : MonoBehaviour
{
    public int speed = 5;

    //Vector3 MoveVector = new Vector3(0, 1, 0);
    public bool facingRight = false;
    public float pos;

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(MoveVector * speed * Time.deltaTime);
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        Vector3 rot = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);

        if (transform.position.x <= pos - 5.0f && facingRight == true)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingRight = false;
        }

        if (transform.position.x >= pos + 10.0f && facingRight == false)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingRight = true;
        }
    }
}
