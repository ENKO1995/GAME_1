using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Animator Animator;

    public int MaxHealth = 100;
    private int CurrentHealth;
   
    private float CanAttack;
    public float Speed;
    //private Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
        //if (Target != null)
        //{
        //    float step = Speed * Time.fixedDeltaTime;
        //    transform.position = Vector2.MoveTowards(transform.position, Target.position, step);
        //}
    }
    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;

        // Play hurt animation
        Animator.SetTrigger("Hurt");

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject);
        Animator.SetBool("IsDead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;

    }
}
