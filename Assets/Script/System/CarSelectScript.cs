using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickNormal()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void ClickF1()
    {
        SceneManager.LoadScene("F1Scene");
    }
}
