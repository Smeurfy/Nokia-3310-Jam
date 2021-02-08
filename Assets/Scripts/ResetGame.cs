using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour
{
    private bool loadNextScene = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DeathCounter.Instance.deaths += 1;
        GetComponent<AudioSource>().Play();
        loadNextScene = true;
    }

    private void Update()
    {
        if(!GetComponent<AudioSource>().isPlaying && loadNextScene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
