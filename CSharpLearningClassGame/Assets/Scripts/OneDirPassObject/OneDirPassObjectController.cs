using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CsharpLearningGame.OneDirPassObject
{
    [RequireComponent(typeof(Collider2D))]
    public class OneDirPassObjectController : MonoBehaviour
    {
        //�v���C���[���m�p�̃R���C�_�[
        [SerializeField] private Collider2D playerSensingCollider;
        private Collider2D mainCollider;
        private float time = 0;
        private bool isPlayerCollide = false;

        private const float mainColliderEnableTime = 0.1f;

        private void Awake()
        {
            //������
            mainCollider = GetComponent<Collider2D>();
        }

        private void Start()
        {
            //�w��
            playerSensingCollider
                .OnTriggerEnter2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(_ =>
                {
                    //�v���C���[���G�ꂽ�烁�C���̃R���C�_�[���I���ɂ���
                    Debug.Log("�L����");
                    mainCollider.enabled = true;
                    isPlayerCollide = true;
                    time = 0;
                })
                .AddTo(this);

            playerSensingCollider
                .OnTriggerExit2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(_ =>
                {
                    //������
                    isPlayerCollide = false;
                    time = 0;
                })
                .AddTo(this);
        }

        private void Update()
        {
            if (isPlayerCollide) return;

            time += Time.deltaTime;

            if (time >= mainColliderEnableTime)
            {
                //���Ԃ��o�����烁�C���̃R���C�_�[���I�t�ɂ���
                mainCollider.enabled = false;
                Debug.Log("������");
                isPlayerCollide = true;
            }
        }
    }
}
