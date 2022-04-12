using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class TargetNavigation : MonoBehaviour
{

    [SerializeField] private Transform movePositionTransform;

    

    public Transform player;
    public Transform enemy;

    private NavMeshAgent navMeshAgent;
    private Sanity sanity;

    private void Start()
    {
        sanity = player.GetComponent<Sanity>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.stoppingDistance = 10;
    }

    private void Update()
    {
        // tell the agent where to go
        navMeshAgent.destination = movePositionTransform.position;

        // check follow distance
        CheckFollowDistance();
    }

    private void CheckFollowDistance()
    {
        switch (sanity.CurrentSanity)
        {
            case 100:
                navMeshAgent.stoppingDistance = 10;
                break;

        }
    }

}