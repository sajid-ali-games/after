using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyCon : MonoBehaviour
{
    public float LookRedius = 10f;
    public float attacktime = 2f;
    public int damageE = 20;

    float time;

   // public Animator animator;

    Transform Target;
    NavMeshAgent Agent;
    //public PlayerHealth player;
    // Start is called before the first frame update
    void Start()
    {
        time = attacktime;
       // Target = PlayerManager.intance.Player.transform;
       Target = GameObject.FindGameObjectWithTag("subject").transform;
        Agent = GetComponent<NavMeshAgent>();

      /**  if(player == null)
        {
            player = GetComponent<PlayerHealth>();
        }**/
    }

    // Update is called once per frame
   // [System.Obsolete]
    void Update()
    {
        time -= Time.deltaTime;
        float Dis = Vector3.Distance(Target.position, transform.position);

        if(Dis < LookRedius)
        {
           // Agent.SetDestination(Target.position);

            //Play Run Animation
           // animator.SetBool("Run",true);

            if(Dis >= Agent .stoppingDistance)
            {
                FaceTarget();
                
                if (time <= 0)
                {
                    
                    //Play Attack & Stop Run Animation
                   // animator.SetBool("Run", false);
                    //animator.SetTrigger("enemyAttack");

                    //Give Player Damage if hits
                    //player.getDamage(damageE);

                    //Reset Attack
                    time = attacktime;

                }
            }
        }
        else
        {
            //To Stop Agent Immediately
            Agent.velocity = Vector3.zero;
            //Play Idle Animation
           // animator.SetBool("Run", false);
        }
        
    }

    //Rotate Enemy Towards Player
    void FaceTarget()
    {
        Vector3 direction = (Target.position - transform.position).normalized;
        Quaternion LookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, LookRotation, Time.deltaTime * 5f);
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRedius);
    }

    
}
