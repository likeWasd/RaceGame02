using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartANDGoal : MonoBehaviour
{
    GameObject checkpoint;
    CheckPointScr checkpointscr;
    public int Syukaisu = 1;
    // Start is called before the first frame update
    void Start()
    {
        checkpoint = GameObject.Find("CheckPoint1");
        checkpointscr = checkpoint.GetComponent<CheckPointScr>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (checkpointscr.TriggerCheck == true)
        {
            if (other.gameObject.tag == "Player")
            {
                checkpointscr.TriggerCheck = false;
                Syukaisu++;
            }
        }
    }
}
