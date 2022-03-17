using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.scripts1;




    public abstract class Player : MonoBehaviour // вместо класса Enemy
    {
        public float _speed;
        public Transform _targetPoint;        
        public IAttack attack;
        public GameObject player;
        public event UnityAction _targetPosInstalled;

    private void Start()
    {
        _targetPosInstalled += Move;

    }
    public void Update()
    {
        _targetPosInstalled?.Invoke();
    }
    public virtual void Move()
    {
            transform.position = Vector3.Lerp(transform.position, _targetPoint.position, _speed * Time.deltaTime);

    }
        
        

        
   
    }
