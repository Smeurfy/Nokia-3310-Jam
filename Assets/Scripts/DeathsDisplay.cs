using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathsDisplay : MonoBehaviour
{
    [SerializeField]
    private Text deathsText;
    // Start is called before the first frame update
    void Start()
    {
        deathsText.text = DeathCounter.Instance.deaths.ToString();
    }
}
