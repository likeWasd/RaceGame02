using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedScript : MonoBehaviour
{
    public GameObject Speed;
    [SerializeField] private GameObject F1;
    Rigidbody rb;
    public float Speed_int;
    // Start is called before the first frame update
    void Start()
    {
        rb = F1.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Text Speed_Text = Speed.GetComponent<Text>();
        Speed_int = Mathf.Floor(rb.velocity.magnitude * 2f);
        string Speed_string = Speed_int.ToString();
        Speed_Text.text = Speed_string;
    }
}
