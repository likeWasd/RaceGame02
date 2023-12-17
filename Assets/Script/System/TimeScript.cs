using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text Time_Text;
    public CountDownScript countdownscript;
    float time2;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time2 = Time.time - 4f;
        if (countdownscript.isZero == true)
        {
            Time_Text.text = time2.ToString("F3");
        }
    }
}
