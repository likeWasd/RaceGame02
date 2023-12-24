using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelScript : MonoBehaviour
{
    public PlayerTestController playertestcontroller;
    public Text Fuel_Text;
    float fuel2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playertestcontroller.fuel <= 0f)
        {
            playertestcontroller.fuel = 0f;
        }
        fuel2 = playertestcontroller.fuel / playertestcontroller.maxFuel * 100;
        Fuel_Text.text = fuel2.ToString("F0");
    }
}
