using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField] Renderer[] renderer;
    public PlayerTestController PlayerTestController;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i > 14; i++)
        {
            renderer[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
