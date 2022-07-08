using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowTarget : FindTargetForEnemy
{
    public Vector3 destination;
    public NavMeshAgent agent;
    public FindTargetForEnemy FindTarget;
    public GameObject Target;


    void Start()
    {  
        FindTarget = GetComponent<FindTargetForEnemy>();
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    void Update()
    {   
        if(Target == null)
        {
        Target = null;
        Target = FindTarget.TargetForEnemy;
        }
        if(Target != null)
        {
                if (Vector3.Distance(destination, Target.transform.position) > 1.0f)
             {
                     destination = Target.transform.position;
                     agent.destination = destination;
             }
        }      
        
    }
}