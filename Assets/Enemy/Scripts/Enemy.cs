using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform[] target;
    public float speed;

    private int current = 0;

    [SerializeField]
    private float max_offset = .2f;

    NavMeshAgent nav;

    void Start()
    {
        nav = this.gameObject.GetComponent<NavMeshAgent>();
    }

    void Update()
    {

        if (!this.gameObject.GetComponent<Enemy_Attack>().playerInRange)
        {
            Move();
        }     
                   
        
    }

    void Move()
    {
     
        nav.SetDestination(target[current].position);

        if (Vector3.Distance(transform.position , nav.destination) <= nav.stoppingDistance)
        {

            current = (current + 1) % target.Length;          
        }
        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
       // Gizmos.DrawLine(transform.position , nav.destination);
    }
}
