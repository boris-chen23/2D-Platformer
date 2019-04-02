using System.Collections;
using UnityEngine;

public class attack : MonoBehaviour
{
    // Start is called before the first frame update
    private float TimeBtwAttack;
    public float StartTimeBtwAttack;
    public Transform attackPos;
    public float attackRange;
    public LayerMask whatIsEnemies;
    public int damage;
    Animator animator;

     void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // animator.SetBool("isAttacking", true);
        if (TimeBtwAttack <= 0)
        {
            if (Input.GetKeyDown("c"))
            {
        animator.SetBool("isAttacking", true);

                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for(int i = 0; i<enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                }
            }
            TimeBtwAttack = StartTimeBtwAttack;
        }
        else
        {
        animator.SetBool("isAttacking", false);
            TimeBtwAttack -= Time.deltaTime;
        }

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}