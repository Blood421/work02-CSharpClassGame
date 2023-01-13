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
            //‰Šú‰»
            playerController = GetComponent<PlayerController>();
        }

        private void Start()
        {
            //w“Ç
            playerController
                .OnMoveMethodFinish()
                .Subscribe(_ =>
                {
                    //“®‚©‚µ‚½‚çƒŠƒZƒbƒg
                    powerGageController.Reset();
                })
                .AddTo(this);
        }
    }
}
