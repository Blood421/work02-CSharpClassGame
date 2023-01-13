using CsharpLearningGame.UI.Goal;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CsharpLearningGame.Goal
{
    [RequireComponent(typeof(Collider2D))]
    [RequireComponent(typeof(Rigidbody2D))]
    public class GoalController : MonoBehaviour
    {
        //�S�[�����ɏo���e�L�X�g�p
        [SerializeField] private GoalTextController goalTextController;
        private void Awake()
        {
            //������
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<Collider2D>().isTrigger = true;
        }

        void Start()
        {
            //�w��
            GetComponent<Collider2D>()
                .OnTriggerEnter2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(col =>
                {
                    //�����ɃS�[�����������
                    //�v���C���[���G�ꂽ��S�[��
                    Debug.Log("Goal!!");
                    goalTextController.SetEnableGoalText();
                })
                .AddTo(this);
        }
    }
}
