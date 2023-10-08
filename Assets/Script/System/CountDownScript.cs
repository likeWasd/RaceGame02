using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    public Text CountDownText;
    public float totalTime;
    public bool isZero;
    int seconds;
    // Start is called before the first frame update
    void Start()
    {
        isZero = false;
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        CountDownText.text = seconds.ToString();
        if (seconds <= 0)
        {
            isZero = true;
            CountDownText.enabled = false;
        }
    }
}
