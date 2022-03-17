using Assets.scripts1;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Archer : Player , IAttack
{
    [SerializeField] private float attackRadius = 3;
    public float AttackRadius => attackRadius;
    public new CircleCollider2D collider;
    public event UnityAction _targetPosInstalled;

    public int _damage => 1;
    public void Start()
    {
        collider = GetComponent<CircleCollider2D>();
        _targetPosInstalled += Move;
        RangeAttack();
    }
   
    public void Update()
    {
        _targetPosInstalled?.Invoke();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Mob player))
        {
            player.ApplyDamage(_damage);
        }
    }

    

    public void RangeAttack()
    {
        collider.radius = attackRadius;
    }

    public void MelleAttack()
    {
        throw new NotImplementedException();
    }

    public override void Move()
    {
        transform.position = Vector3.Lerp(transform.position, _targetPoint.position, _speed * Time.deltaTime);
    }
}
