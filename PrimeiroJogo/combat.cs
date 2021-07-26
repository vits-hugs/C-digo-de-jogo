using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour
{
    public Animator socobelo;

    public Transform AttackPoint;
    public float AttackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 30;
    public float attackRate = 3f;
    float nextAttackTime = 0f;
    public int vidachar = 100;

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                Attack();
                nextAttackTime = Time.time +1f / attackRate;
            }
        }
    }
    void Attack()
    {
        socobelo.SetTrigger("Attack");
 
    }
    void Ataquimachion()
    {
        //detectar inimigos no range do ataque
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, AttackRange, enemyLayers);
        //dano
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<quebravel>().TakeDamage(attackDamage);
        }

    }
    void OnDrawGizmos() // fazer area de ataque aparecer
    { 
        if(AttackPoint == null)
        return;
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }

    void OnCollisionEnter2D (Collision2D col)
    { 
        if (col.gameObject.tag == "morre")
        {
            vidachar -= 40;
            Debug.Log("ai");
        }
        if (vidachar < 0)
        {
            Destroy(gameObject,0.1f);
        }
    }
}
