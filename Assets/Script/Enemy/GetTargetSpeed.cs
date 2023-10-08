using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GetTargetSpeed : MonoBehaviour
{
    public GameObject Target;
    public GameObject CarRed;
    CinemachineDollyCart cinemachineDollyCart;
    // Start is called before the first frame update
    void Start()
    {
        cinemachineDollyCart = Target.GetComponent<CinemachineDollyCart>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CarPos = CarRed.transform.position;
        Vector3 TargetPos = Target.transform.position;
        float dis = Vector3.Distance(CarPos, TargetPos);
        if (dis > 100)
        {
            cinemachineDollyCart.m_Speed = 0;
        }
        if (dis < 90)
        {
            cinemachineDollyCart.m_Speed = 200;
        }
    }
}
