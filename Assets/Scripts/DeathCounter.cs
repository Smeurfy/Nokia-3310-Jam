using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    private static DeathCounter _instance;

    public static DeathCounter Instance { get { return _instance; } }
    public int deaths { get; set; } = 0;
    // Start is called before the first frame update

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
