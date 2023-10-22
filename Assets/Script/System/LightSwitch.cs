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
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 15; i++)
        {
            if (PlayerTestController.engineRot > 530 * (i + 1) + 3000)
            {
                renderer[i].enabled = true;
            } else
            {
                renderer[i].enabled = false;
            }
        }
    }
}
