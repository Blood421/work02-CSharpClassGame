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
            //‰Šú‰»
            moveTimingButtonInputController = GetComponent<MoveTimingButtonInputController>();
        }

        private void Start()
        {

            //w“Ç
            moveTimingButtonInputController
                .GetButton()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    //ƒNƒŠƒbƒN‚µ‚½‚ç“®‚©‚»‚¤
                    moveTimingController.Move(moveTimingButtonInputController.GetDir());
                })
                .AddTo(this);
        }
    }
}
