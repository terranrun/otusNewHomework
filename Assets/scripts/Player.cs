using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.scripts1;




    public class Player : MonoBehaviour
    {
        //    Описание/Пошаговая инструкция выполнения домашнего задания:
        //Создать класс Enemy.
        //Наделить его способностью передвигаться в заданные координаты.
        //Наделить его способностью атаковать всех в заданной области вокруг себя
        //Наделить его способностью принимать команды ввода от игрока\компьютера
        //Наделить его способностью получать урон
        [SerializeField] private float _speed;
        [SerializeField] private Transform _targetPoint;
        [SerializeField] private Warrior warrior;
        [SerializeField] private Archer archer;
        private IAttack attack;
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
        public void Move()
        {
            transform.position = Vector3.Lerp(transform.position, _targetPoint.position, _speed * Time.deltaTime);
        }

        [ContextMenu("ChangeArcher")]// можно заменить выбор юнита через UI
        private void ChangeToArcher() 
        {
        player.GetComponent<SpriteRenderer>().color = new Color(0, 100, 0);
        //Archer archer = new Archer();
        attack = archer;
        }
        [ContextMenu("ChangeWarrior")]
        private void ChangeToWarrior()
        {
        player.GetComponent<SpriteRenderer>().color = new Color(0, 0, 100);
        //  Warrior warrior = new Warrior();
           attack = warrior;
        }
        [ContextMenu("Attack")]
        private void Attack() // атака через маусБатон
        {
            attack.Attack();
        }







        //Создать класс Warrior, который будет наследовать Enemy
        //Наделить его способностью перемещаться в заданные координаты и атаковать всех кого он встретит на пути

        //Создать класс Archer, который будет наследовать Enemy
        //Наделить его способностью  атаковать всех в заданной области в радиусе атаки

        //Доп задание.
        //Создать сцену и расставить кубы разного цвета (враги). Дать возможность игроку выбирать куб и применять его способности

        //Критерии оценки:
        //Создать класс Enemy и все под задания - 5
        //Создать класс Warrior и все под задания - 3
        //Создать класс Archer и все под задания - 3
    }
