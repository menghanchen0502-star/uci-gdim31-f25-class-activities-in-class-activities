using UnityEngine;
using UnityEngine.AI;

public class DeerW5 : MonoBehaviour
{
    // The Transform of the GameObject the deer will walk towards (set in the Inspector)
    [SerializeField] Transform target;

    // The NavMeshAgent component on the Deer
    NavMeshAgent agent;

    void Start()
    {
        // Get the NavMeshAgent component on the Deer
        agent = GetComponent<NavMeshAgent>();

        // Tell the deer where to walk
        agent.SetDestination(target.position);
    }
}