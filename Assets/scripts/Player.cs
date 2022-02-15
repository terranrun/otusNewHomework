using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Assets.scripts1;




    public class Player : MonoBehaviour
    {
        //    ��������/��������� ���������� ���������� ��������� �������:
        //������� ����� Enemy.
        //�������� ��� ������������ ������������� � �������� ����������.
        //�������� ��� ������������ ��������� ���� � �������� ������� ������ ����
        //�������� ��� ������������ ��������� ������� ����� �� ������\����������
        //�������� ��� ������������ �������� ����
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

        [ContextMenu("ChangeArcher")]// ����� �������� ����� ����� ����� UI
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
        private void Attack() // ����� ����� ���������
        {
            attack.Attack();
        }







        //������� ����� Warrior, ������� ����� ����������� Enemy
        //�������� ��� ������������ ������������ � �������� ���������� � ��������� ���� ���� �� �������� �� ����

        //������� ����� Archer, ������� ����� ����������� Enemy
        //�������� ��� ������������  ��������� ���� � �������� ������� � ������� �����

        //��� �������.
        //������� ����� � ���������� ���� ������� ����� (�����). ���� ����������� ������ �������� ��� � ��������� ��� �����������

        //�������� ������:
        //������� ����� Enemy � ��� ��� ������� - 5
        //������� ����� Warrior � ��� ��� ������� - 3
        //������� ����� Archer � ��� ��� ������� - 3
    }
