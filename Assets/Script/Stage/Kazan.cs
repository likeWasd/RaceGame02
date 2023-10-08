using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kazan : MonoBehaviour
{
    public GameObject KazanBai;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generate", 0.1F, 0.1F);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generate()
    {

        Instantiate(KazanBai, new Vector3(403.2F, 172, 929.5F), Quaternion.identity);
    }
}
