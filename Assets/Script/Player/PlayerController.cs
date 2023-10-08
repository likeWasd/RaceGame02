using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rigid;
    float movePower = 1000f;
    float movePower2;
    float rotPower = 900000f;
    // 配列を使ったスピード
    int[] speed = { -1, 47, 87, 134, 200, 260, 350 };
    float[] speedKasoku = { 0, 3.5f, 3.2f, 3f, 2.6f, 2.3f, 1.55f };
    float hoseiKasoku = 60;
    float hoseiGyaku = 30;
    int engineRot = 0;
    // 最大12000rpm
    public CountDownScript countdownscript;
    public SpeedScript speedscript;
    public int gear;
    // Start is called before the first frame update
    void Start()
    {
        movePower2 = movePower * hoseiKasoku;
        gear = 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (countdownscript.isZero == true)
        {
            MoveUpdate();
            RotationUpdate();
        }
    }

    void MoveUpdate()
    {
        // movePower2 += 10000;
        /*
        if (Input.GetKey(KeyCode.F) == true)
        {
            movePower2 *= 1.5f;
        }
        */
        for (int i=1; i<=6; i++)
        {
            Gear(i);
        }
        rigid.AddForce(-transform.forward * speedscript.Speed_int * hoseiGyaku, ForceMode.Force);
        if (Input.GetKey(KeyCode.S) == true)
        {
            rigid.AddForce(transform.forward * movePower2 * -speedKasoku[1], ForceMode.Force);
        }
    }

    void RotationUpdate()
    {
        if (Input.GetKey(KeyCode.A) == true)
        {
            rigid.AddTorque(-transform.up * rotPower, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            rigid.AddTorque(transform.up * rotPower, ForceMode.Force);
        }
    }
    
    void Gear(int gearHikisu)
    {
        if (speed[gearHikisu - 1] < speedscript.Speed_int && speedscript.Speed_int <= speed[gearHikisu])
        {
            if (Input.GetKey(KeyCode.Space) == true)
            {
                rigid.AddForce(transform.forward * movePower2 * speedKasoku[gearHikisu], ForceMode.Force);
            }
            gear = gearHikisu;
        }
    }
}
