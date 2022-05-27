using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();


    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(0, 0, 3f, ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigidBody.AddForce(0, 5f, -0.15f, ForceMode.Impulse);
        }

    }
}
