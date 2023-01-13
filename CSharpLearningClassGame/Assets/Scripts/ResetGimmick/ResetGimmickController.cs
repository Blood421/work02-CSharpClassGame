using CsharpLearningGame.Player;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CsharpLearningGame.ResetGimmick
{
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class ResetGimmickController : MonoBehaviour
    {
        private Collider2D mainCollider;

        private void Awake()
        {
            //������
            mainCollider = GetComponent<Collider2D>();
            GetComponent<Rigidbody2D>().isKinematic = true;
        }

        private void Start()
        {
            //�w��
            mainCollider
                .OnCollisionEnter2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(col =>
                {
                    //�v���C���[���G�ꂽ�烊�X�^�[�g������
                    Debug.Log("restart");
                    col.gameObject.GetComponent<PlayerController>().ReStart();
                })
                .AddTo(this);
        }
    }
}
