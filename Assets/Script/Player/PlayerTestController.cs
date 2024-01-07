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
    public float engineRotKeisu; // 5013Ç≠ÇÁÇ¢Ç™ÇøÇÂÇ§Ç«Ç¢Ç¢
    Vector3 moveDirection = Vector3.zero;
    GameObject Gravity_Hantei;
    public bool isGravity;
    public float fuel;
    public float maxFuel;
    /// <summary>
    /// îRóøè¡îÔó 
    /// </summary>
    [Tooltip("îRóøè¡îÔó ")] public float fuelConsumptionQuantity;


    public CountDownScript countdownscript;
    // Start is called before the first frame update
    void Start()
    {
        fuel = maxFuel;
        cc = GetComponent<CharacterController>();
        engineRot = 0f;
        gear = 1;
        speed = 0f;
        isGearChange = false;
        Gravity_Hantei = GameObject.Find("Gravity_Hantei");
        StartCoroutine(Fuel());
    }

    // Update is called once per frame
    void Update()
    {
        if (isGravity == true)
        {
            moveDirection.y -= 5 * Time.deltaTime;
        }
        if (countdownscript.isZero == true)
        {
            cc.Move(this.gameObject.transform.forward * speed * Time.deltaTime / 200);
            EngineRot();
            Gear();
            Speed();
            if (Input.GetKey(KeyCode.A) == true)
            {
                transform.Rotate(0f, -1.5f, 0f);
            }
            if (Input.GetKey(KeyCode.D) == true)
            {
                transform.Rotate(0f, 1.5f, 0f);
            }
        }
        cc.Move(moveDirection * Time.deltaTime);
    }

    void EngineRot()
    {
        if (Input.GetKey(KeyCode.W) == true && isGearChange == false)
        {
            if (gear == 0)
            {
                engineRot += engineRotKeisu * Time.deltaTime;
            }
            else
            {
                engineRot += engineRotKeisu * Time.deltaTime;
            }
        }
        else
        {
            engineRot -= engineRotKeisu * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) == true && isGearChange == false)
        {
            engineRot -= engineRotKeisu * 1.5f * Time.deltaTime;
        }
        engineRot = Mathf.Clamp(engineRot, 1250, 12000);
        if (fuel <= 0f)
        {
            engineRot = 1250f;
        }
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
            else if (Input.GetKeyDown(KeyCode.I) == true && gear == 0 && engineRot < 3000)
            {
                gear++;
                StartCoroutine(ChangeGear());
            }
            if (Input.GetKeyDown(KeyCode.K) == true && gear > 1 && speed < 12000 * (gear - 1))
            {
                gear--;
                StartCoroutine(ChangeGear());
            }
            else if (Input.GetKeyDown(KeyCode.K) == true && gear == 1 && speed < 12000)
            {
                gear--;
                StartCoroutine(ChangeGear());
            }
        }
    }

    void Speed()
    {
        speed = engineRot * gear;
        if (gear == 0)
        {
            speed = -engineRot;
        }
    }

    private IEnumerator ChangeGear()
    {
        isGearChange = true;
        yield return new WaitForSeconds(1);
        isGearChange = false;
    }

    private void OnTriggerStay(Collider other)
    {
        isGravity = false;
        if (other.gameObject.tag == "Refueling" && fuel < maxFuel)
        {
            fuel += 0.04f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isGravity = true;
    }

    private IEnumerator Fuel()
    {
        while (countdownscript.isZero == false)
        {
            yield return null;
        }
        while (countdownscript.isZero == true)
        {
            yield return new WaitForSeconds(1);
            if (fuel > 0f)
            {
                fuel -= fuelConsumptionQuantity;
            }
        }
    }
}
