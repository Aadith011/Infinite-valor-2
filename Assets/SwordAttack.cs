using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Collider2D swordCollider;
    Vector2 rightAttackOffset;
    public float damage = 3;
    /*public enum AttackDirection { 
        left, right
    }*/
    //public AttackDirection attackDirection;
    // Start is called before the first frame update
    public void Start()
    {
        rightAttackOffset = transform.position;
    }
    /*public void Attack()
    {
        switch(attackDirection)
        {
            case AttackDirection.left:
                AttackLeft();
                break;
            case AttackDirection.right: 
                AttackRight();
                break;
        }
    }*/
    public void AttackRight()
    {
        print("Attack right");
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;
    }
    public void AttackLeft() {
        print("Attack left");   
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }
    public void StopAttack()
    {
        swordCollider.enabled =false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Player's sword collided with: " + other.gameObject.name);
        if(other.CompareTag("Enemy"))
        {
            //deal damage to enemy
            Debug.Log("Enemy detected");
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                //enemy.Health -= damage;
                enemy.TakeDamage(damage);
                Debug.Log("Enemy health: " + enemy.Health);
            }
        }
    }
}
