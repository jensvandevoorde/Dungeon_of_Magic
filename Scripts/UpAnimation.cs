using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAnimation : MonoBehaviour
{
    Vector3 startPos;
    Vector3 destinationPos;
    float totalTime = 4f;
    float timePassed;
    bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        destinationPos = new Vector3(startPos.x, startPos.y, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        isMoving = true;


        if (isMoving)
        {
            timePassed += Time.deltaTime;
            AnimateSpear();
        }
    }

    void AnimateSpear()
    {
        if (timePassed < totalTime)
        {
            float percentagePassed = timePassed / totalTime;
            transform.position = Vector3.Lerp(startPos, destinationPos, percentagePassed);

        }
        else
        {
            transform.position = destinationPos;
            // Debug.Log(Time.time);
            isMoving = false;
        }
    }
}
