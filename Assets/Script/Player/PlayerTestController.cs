using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTestController : MonoBehaviour
{
    CharacterController cc;
    public float engineRot;
    public int gear;
    public float speed;
    public bool isGearChange;
    public float engineRotKeisu; // 5013‚­‚ç‚¢‚ª‚¿‚å‚¤‚Ç‚¢‚¢
    // Start is called before the first frame update
    void Start()
    {
        engineRot = 0f;
        gear = 1;
        speed = 0f;
        isGearChange = false;
    }

    // Update is called once per frame
    void Update()
    {
        cc.Move(this.gameObject.transform.forward * speed * Time.deltaTime / 200);
        EngineRot();
        Gear();
        Speed();
    }

    void EngineRot()
    {
        if (Input.GetKey(KeyCode.E) == true && isGearChange == false)
        {
            engineRot += engineRotKeisu * Time.deltaTime;
        }
        else
        {
            engineRot -= engineRotKeisu * Time.deltaTime;
        }
        engineRot = Mathf.Clamp(engineRot, 1250, 12000);
    }

    void Gear()
    {
        if (isGearChange == false)
        {
            if (Input.GetKeyDown(KeyCode.I) == true && gear < 6 && speed > 1250 * (gear + 1))
            {
                gear++;
                StartCoroutine(ChangeGear());
            }
            if (Input.GetKeyDown(KeyCode.K) == true && gear > 1 && speed < 12000 * (gear - 1))
            {
                gear--;
                StartCoroutine(ChangeGear());
            }
        }
    }

    void Speed()
    {
        speed = engineRot * gear;
    }

    private IEnumerator ChangeGear()
    {
        isGearChange = true;
        yield return new WaitForSeconds(1);
        isGearChange = false;
    }
}
