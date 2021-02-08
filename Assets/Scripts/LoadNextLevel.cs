using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(SceneManager.GetActiveScene().name != "Thanks")
        {
            var indexNext = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(indexNext);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
       
    }
}
