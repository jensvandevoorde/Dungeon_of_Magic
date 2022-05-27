using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Evader : MonoBehaviour
{


    public GameObject powerUp;
    public int powerActivate;
    public GameObject destroyer;



    Animator animator;
    float xPos;
    float zPos;
    float yPos;
    public float forward = 1;
    public int numbLane = 2;


    // Start is called before the first frame update
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        // CHARACTER MOVEMENT
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;

        Vector3 movingForward = new Vector3(0, 0, forward);
        transform.Translate(movingForward * forward * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetTrigger("JumpUp");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetTrigger("RollDown");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && numbLane < 3)
        {
            animator.SetTrigger("RightStep");
            transform.position = new Vector3(xPos, yPos, zPos - 1);
            numbLane += 1;

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && numbLane > 1)
        {
            animator.SetTrigger("LeftStep");
            transform.position = new Vector3(xPos, yPos, zPos + 1);
            numbLane -= 1;
        }
        //POWER ACTIVATION INVINCIBILITY
        if (powerActivate >= 2)
        {
            powerUp.SetActive(true);
        }

        else
        {
            powerUp.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider collider)
    {
        //POWER ACTIVATION INVINCIBILITY
        if (collider.gameObject.tag.Equals("Finish") && powerActivate < 2)
        {

            SceneManager.LoadScene("GameOver");

        }
        if (collider.gameObject.tag.Equals("Finish") && powerActivate >= 2)
        {
            forward = 3;
        }

        if (collider.gameObject.tag.Equals("newPower"))
        {
            Destroy(collider.gameObject);
            powerActivate += 1;
        }


    }

}
