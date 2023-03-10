using CsharpLearningGame.PowerGage;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.Player
{
    [RequireComponent(typeof(PlayerController))]
    public class PlayerController2PowerGageControllerPresenter : MonoBehaviour
    {
        //PlayerController -> PowerGageController
        [SerializeField] private PowerGageController powerGageController;

        private PlayerController playerController;

        private void Awake()
        {
            //初期化
            playerController = GetComponent<PlayerController>();
        }

        private void Start()
        {
            //購読
            playerController
                .OnMoveMethodFinish()
                .Subscribe(_ =>
                {
                    //動かしたらリセット
                    powerGageController.Reset();
                })
                .AddTo(this);
        }
    }
}
