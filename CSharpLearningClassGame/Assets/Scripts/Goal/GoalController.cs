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
        //ゴール時に出すテキスト用
        [SerializeField] private GoalTextController goalTextController;
        private void Awake()
        {
            //初期化
            GetComponent<Rigidbody2D>().isKinematic = true;
            GetComponent<Collider2D>().isTrigger = true;
        }

        void Start()
        {
            //購読
            GetComponent<Collider2D>()
                .OnTriggerEnter2DAsObservable()
                .Where(col => col.gameObject.CompareTag("Player"))
                .Subscribe(col =>
                {
                    //ここにゴール判定を書く
                    //プレイヤーが触れたらゴール
                    Debug.Log("Goal!!");
                    goalTextController.SetEnableGoalText();
                })
                .AddTo(this);
        }
    }
}
