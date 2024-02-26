using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;
    Collider2D slimeCollider;
    public float Health
    {
        set
        {
            health = value;
            if(health <= 0)
            {
                Defeated();
            }
        }
        get
        {
            return health;
        }
    }
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Enemy initialized");
        animator = GetComponent<Animator>();
        slimeCollider = GetComponent<Collider2D>();
    }
    public float health = 1;
    
    public void TakeDamage(float damage)
    {
        Health -= damage;
        Debug.Log("Enemy health reduced to: " + health);
    }

    public void Defeated()
    {
        Debug.Log("Enemy defeated!");
        animator.SetTrigger("Defeated");
    }
    public void RemoveEnemy()
    {
        Debug.Log("Removing enemy");
        Destroy(gameObject);
    }
}
