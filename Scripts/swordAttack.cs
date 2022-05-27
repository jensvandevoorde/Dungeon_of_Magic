using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAttack : MonoBehaviour
{


    float forward = 2;

    // Update is called once per frame
    void Update()
    {

        Vector3 movingForward = new Vector3(-forward, 0, 0);
        transform.Translate(movingForward * forward * Time.deltaTime);
    }


}
