using Assets.scripts1;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour, RangeAttack
{
    [SerializeField] private float attackRadius = 3;
    public float AttackRadius => attackRadius;
    private new CircleCollider2D collider;

    public int _damage => 1;
    public void Start()
    {
        collider = GetComponent<CircleCollider2D>();
    }
    public void Attack()
    {
        collider.radius = attackRadius;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Mob player))
        {
            player.ApplyDamage(_damage);
        }
    }
}
