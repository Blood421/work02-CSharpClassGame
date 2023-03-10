using CsharpLearningGame.MoveTiming;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.UI.MoveTiming
{
    [RequireComponent(typeof(MoveTimingButtonInputController))]
    public class MoveTimingButton2ControllerPresenter : MonoBehaviour
    {
        //MoveTimingButtonInputController -> MoveTimingButtonInputController
        private MoveTimingButtonInputController moveTimingButtonInputController;
        [SerializeField] private MoveTimingController moveTimingController;

        private void Awake()
        {
            //初期化
            moveTimingButtonInputController = GetComponent<MoveTimingButtonInputController>();
        }

        private void Start()
        {

            //購読
            moveTimingButtonInputController
                .GetButton()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    //クリックしたら動かそう
                    moveTimingController.Move(moveTimingButtonInputController.GetDir());
                })
                .AddTo(this);
        }
    }
}
