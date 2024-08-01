using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class MoveToDestination : MonoBehaviour
{
    private NavMeshAgent thisAgent = null;
    public Transform Dest = null;
    // Start is called before the first frame update
    void Start()
    {
        thisAgent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        thisAgent.SetDestination(Dest.position);
    }
}
