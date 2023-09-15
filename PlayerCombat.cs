using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator Animator;

    public Transform AttackPoint;
    public float AttackRange = 1f;
    public LayerMask EnemyLayers;

    public int AttackDamage = 40;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }
    void Attack()
    {
        //Play an attack animation.
        Animator.SetTrigger("Attack");

        //Detect enemies in range of attack.
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, EnemyLayers);

        //Damage enemies.
        foreach (BoxCollider2D enemy in hitEnemies)
        {
            SoundManager.PlaySound("Hit");

            enemy.GetComponent<EnemyBehavior>().TakeDamage(AttackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}
