using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearScript : MonoBehaviour
{
    public PlayerTestController PlayerTestController;
    public Text Gear_Text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Gear_Text.text = PlayerTestController.gear.ToString();
    }
}
