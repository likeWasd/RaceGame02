using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshControl : MonoBehaviour
{
    [SerializeField]
    [Tooltip("èÑâÒÇ∑ÇÈínì_ÇÃîzóÒ")]
    Transform[] target;
    NavMeshAgent myAgent;
    int currentTargetIntex;
    public CountDownScript countdownscript;

    private float speed = 0.0f;
    bool stopdistance_flag = false;
    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        speed = myAgent.speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (countdownscript.isZero == true)
        {
            myAgent.SetDestination(target[0].position);
        }
        /*
        if (myAgent.remainingDistance > myAgent.stoppingDistance)
        {
            stopdistance_flag = false;
        }
        /*
        if (myAgent.remainingDistance <= myAgent.stoppingDistance && stopdistance_flag == false)
        {
            stopdistance_flag = true;
            currentTargetIntex = (currentTargetIntex + 1) % target.Length;
            myAgent.SetDestination(target[currentTargetIntex].position);
        }
        if (Vector3.Distance(myAgent.steeringTarget, transform.position) < 150.0f)
        {
            myAgent.speed = 30.0f;
        } else
        {
            myAgent.speed = speed;
        }
        Debug.Log(currentTargetIntex);
        */
    }
}