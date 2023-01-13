using CsharpLearningGame.Player;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.MoveTiming
{
    public class MoveTimingController2PlayerControllerPresenter : MonoBehaviour
    {
        //MoveTimingController -> PlayerController
        [SerializeField] private MoveTimingController moveTimingController;
        [SerializeField] private PlayerController playerController;
        private void Start()
        {
            //w“Ç
            moveTimingController
                .OnMoveTiming()
                .Subscribe(value =>
                {
                    //“®‚©‚·
                    playerController.Move(value.dir,value.power);
                })
                .AddTo(this);
        }
    }
}
