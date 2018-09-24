using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour {

    public NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent.GetComponent<NavMeshAgent>();
	}
    public void MoveToTarget(Vector3 target)
    {
        agent.SetDestination(target);
    }
}
