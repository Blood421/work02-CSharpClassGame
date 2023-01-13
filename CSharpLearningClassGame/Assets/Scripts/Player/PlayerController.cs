using System;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerController : MonoBehaviour
    {
        //�͂����{���邩
        [SerializeField] private float powerMultiplier;
        private Vector3 startPos;
        private Rigidbody2D playerRig;

        private Subject<Unit> onMoveMethodFinish = new Subject<Unit>();
        public IObservable<Unit> OnMoveMethodFinish() => onMoveMethodFinish;

        private void Awake()
        {
            //������
            playerRig = GetComponent<Rigidbody2D>();
            startPos = transform.position;
        }

        public void Move(Vector2  dir,float gagePower)
        {
            //������
            //�͂�������
            Debug.Log("dir : " + dir + " power : " + gagePower );
            Vector2 force = dir * powerMultiplier * gagePower;
            playerRig.AddForce(force);

            //�͂���������
            onMoveMethodFinish.OnNext(Unit.Default);
        }

        public void ReStart()
        {
            //���X�^�[�g
            transform.position = startPos;
            playerRig.velocity = Vector2.zero;
            playerRig.angularVelocity = 0;
        }
    }
}
