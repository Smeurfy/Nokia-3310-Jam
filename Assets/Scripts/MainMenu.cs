using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.name == "Start")
        {
            DeathCounter.Instance.deaths = 0;
            var indexNext = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(indexNext);
        }
        else
        {
            Application.Quit();
        }
    }

}
