using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public NavMeshPath path;
    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(target.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            agent.isStopped = true;
            timer.isTiming = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = gameObject.GetComponent<MeshRenderer>().material.color;
    }
}
