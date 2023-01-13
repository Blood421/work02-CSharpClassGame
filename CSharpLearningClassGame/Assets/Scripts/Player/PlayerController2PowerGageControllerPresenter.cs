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
            //������
            playerController = GetComponent<PlayerController>();
        }

        private void Start()
        {
            //�w��
            playerController
                .OnMoveMethodFinish()
                .Subscribe(_ =>
                {
                    //���������烊�Z�b�g
                    powerGageController.Reset();
                })
                .AddTo(this);
        }
    }
}
