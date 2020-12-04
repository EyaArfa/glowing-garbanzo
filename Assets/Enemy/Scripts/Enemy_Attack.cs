using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//[RequireComponent(typeof(Rigidbody)]
public class Enemy_Attack : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private float max_distance;
    [SerializeField]
    private float maxAngel;


    private NavMeshAgent nav;

    Vector3 distance_vector;

    [HideInInspector]
    public bool playerInRange = false;

    bool readyToAttack= false;

    [SerializeField]
    private WaitForSeconds delay;

    [SerializeField]
    private float attack_radius;

    [SerializeField]
    private float attackTime = .52f;


    private Rigidbody rb;
    private Animator anim;



    void Awake()
    {
        anim = this.gameObject.GetComponent<Animator>();
        nav = this.gameObject.GetComponent<NavMeshAgent>();
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        delay = new WaitForSeconds(1.5f);

        StartCoroutine("attack");

        anim.SetFloat("speed", 1);



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckForPlayer();

        Collider[] colliders = Physics.OverlapSphere(transform.position, attack_radius);

        foreach (Collider collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player"))
            {
                readyToAttack = true;
            }
        }


      




        
    }

    void CheckForPlayer()
    {
        distance_vector = transform.position - player.position;
        float distance = distance_vector.magnitude;
            

        if(distance < max_distance)
        {
            

            float angel = Vector3.Angle(-this.transform.forward, distance_vector);

            if(angel < maxAngel)
            {
                RaycastHit hit;
                Ray ray = new Ray(transform.position, new Vector3(-distance_vector.x , .2f , -distance_vector.z));

                if (Physics.Raycast(ray, out hit))
                {
                   
                    Debug.DrawRay(ray.origin, ray.direction);
                    {
                        if (hit.transform.gameObject.tag != "Wall")
                        {
                            playerInRange = true;

                        }
                    }                    

                }

               
            }

        }
        else
        {
            playerInRange = false;
        }



        if (playerInRange)
        {
            followPlayer();
        }

    }

    void followPlayer()
    {
        
        nav.SetDestination(player.position);

        if (nav.remainingDistance <= nav.stoppingDistance)
        {
            anim.SetFloat("speed", 0);
        }
        else
        {
            anim.SetFloat("speed", 1);
        }

    }

  

    IEnumerator attack()
    {
        while (true)
        {
            if (readyToAttack && playerInRange)
            {
                
                Debug.Log("ready!!!!");
                //transform.rotation = Quaternion.LookRotation(player.position , Vector3.up);
                anim.SetBool("attack", true);
                yield return new WaitForSeconds(attackTime);
                
                Life_counter.lifeDecrement();
                anim.SetBool("attack", false);

                Debug.Log("attack!!!!");
                yield return delay;
                
                Debug.Log("wait!!!!");                
                readyToAttack = false;
                
            }

            yield return new WaitForSeconds(.003f);
            
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, max_distance);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attack_radius);
    }

}
