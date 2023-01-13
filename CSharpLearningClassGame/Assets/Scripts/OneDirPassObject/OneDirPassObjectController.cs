using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace CsharpLearningGame.OneDirPassObject
{
    [RequireComponent(typeof(Collider2D))]
    public class OneDirPassObjectController : MonoBehaviour
    {
        //プレイヤー感知用のコライダー
        [SerializeField] private Collider2D playerSensingCollider;
        private Collider2D mainCollider;
        private float time = 0;
        private bool isPlayerCollide = false;

        private const float mainColliderEnableTime = 0.1f;

        private void Awake()
        {
            //初期化
            mainCollider = GetComponent<Collider2D>();
        }

        private void Start()
        {
            //購読
            playerSensingCollider
                .OnTriggerEnter2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(_ =>
                {
                    //プレイヤーが触れたらメインのコライダーをオンにする
                    Debug.Log("有効化");
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
                    //初期化
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
                //時間が経ったらメインのコライダーをオフにする
                mainCollider.enabled = false;
                Debug.Log("無効化");
                isPlayerCollide = true;
            }
        }
    }
}
