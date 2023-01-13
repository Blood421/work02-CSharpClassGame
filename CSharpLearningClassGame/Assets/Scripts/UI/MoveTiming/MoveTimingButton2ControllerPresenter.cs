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
            //������
            moveTimingButtonInputController = GetComponent<MoveTimingButtonInputController>();
        }

        private void Start()
        {

            //�w��
            moveTimingButtonInputController
                .GetButton()
                .OnClickAsObservable()
                .Subscribe(_ =>
                {
                    //�N���b�N�����瓮������
                    moveTimingController.Move(moveTimingButtonInputController.GetDir());
                })
                .AddTo(this);
        }
    }
}
