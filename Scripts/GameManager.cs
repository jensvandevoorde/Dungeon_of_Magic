using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//based my code on this tutorial https://www.youtube.com/playlist?list=PL4UezTfGBADC6Li-b8uPptn1JsgFzUoXs

public class GameManager : MonoBehaviour
{

    public Transform dungeonNormal;
    public Transform dungeonWithFirepit;

    public Transform axe;
    public Transform sword;
    public Transform spear;
    public Transform fireball;
    public Transform magicPowerUp;
    float posXLevel = 12;
    int randomNum;
    public int randomLoc;
    int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 30;


    }

    // Update is called once per frame
    void Update()
    {

        //build of level 1
        if (currentLevel == 1)
        {
            if (posXLevel < 198)
            {
                randomNum = Random.Range(0, 20);
                Instantiate(dungeonNormal, new Vector3(posXLevel, 1.598171f, 5f), dungeonNormal.rotation);

                if (randomNum == 7)
                {
                    Instantiate(fireball, new Vector3(posXLevel, 1f, 4f), fireball.rotation);
                }
                if (randomNum == 8)
                {
                    Instantiate(sword, new Vector3(posXLevel, 1f, 5f), sword.rotation);
                }
                if (randomNum == 1)
                {
                    Instantiate(magicPowerUp, new Vector3(posXLevel, 0.5f, 6f), magicPowerUp.rotation);
                }
                if (randomNum == 0)
                {
                    Instantiate(magicPowerUp, new Vector3(posXLevel, 0.5f, 4f), magicPowerUp.rotation);
                }
                if (randomNum == 6)
                {
                    Instantiate(axe, new Vector3(posXLevel, 0, 5f), axe.rotation);
                }
                if (randomNum == 10)
                {
                    Instantiate(spear, new Vector3(posXLevel, 0.5f, 2f), spear.rotation);
                }
                posXLevel += 3;
            }
        }
        //Build level 2
        if (currentLevel == 3)
        {
            if (posXLevel < 198)
            {

                randomNum = Random.Range(0, 15);
                if (posXLevel % 2 == 0)
                {
                    Instantiate(dungeonNormal, new Vector3(posXLevel, 1.598171f, 5f), dungeonNormal.rotation);
                    if (randomNum == 2)
                    {
                        Instantiate(magicPowerUp, new Vector3(posXLevel, 0.5f, 5f), magicPowerUp.rotation);
                    }
                    if (randomNum == 5)
                    {
                        Instantiate(axe, new Vector3(posXLevel, 0.5f, 4f), axe.rotation);
                    }
                    if (randomNum == 7)
                    {
                        Instantiate(spear, new Vector3(posXLevel, 0.5f, 3f), spear.rotation);
                    }
                }
                if (posXLevel % 2 == 1)
                {
                    Instantiate(dungeonWithFirepit, new Vector3(posXLevel, 1.598171f, 5f), dungeonWithFirepit.rotation);
                    if (randomNum == 5)
                    {
                        Instantiate(fireball, new Vector3(posXLevel, 0.5f, 6f), fireball.rotation);
                    }
                }
                posXLevel += 3;
            }

        }

    }

}
