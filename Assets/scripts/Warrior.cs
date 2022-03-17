using Assets.scripts1;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior :Player, IAttack
{
    [SerializeField] private float attackRadius = 1;
    public float AttackRadius => attackRadius;
    public new CircleCollider2D collider;

    

    public int _damage => 3;
    public void Start()
    {
        
        collider = GetComponent<CircleCollider2D>();
    }
 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Mob player))
        {
            player.ApplyDamage(_damage);
        }
    }

    public void MelleAttack()
    {
        collider.radius = attackRadius;
    }

    public void RangeAttack()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        throw new NotImplementedException();
    }
}
