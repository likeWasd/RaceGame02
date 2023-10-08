using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EngineRotScript : MonoBehaviour
{
    public PlayerTestController PlayerTestController;
    public Text EngineRot_Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EngineRot_Text.text = PlayerTestController.engineRot.ToString();
    }
}
