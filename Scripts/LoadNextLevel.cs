using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    int endGame;
    int currentLevel;
    int nextLevelload;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
        nextLevelload = SceneManager.GetActiveScene().buildIndex + 2;
        endGame = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") && currentLevel == 1)
        {
            SceneManager.LoadScene(nextLevelload);
        }
        if (other.gameObject.tag.Equals("Player") && currentLevel == 3)
        {
            SceneManager.LoadScene(endGame);
        }
    }
}
