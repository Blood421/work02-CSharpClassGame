using UnityEngine;
using UniRx;

namespace CsharpLearningGame.UI.PowerGage
{
    public class PowerGageOutputViewPresenter : MonoBehaviour
    {
        //PowerGageModelController -> PowerGageOutputViewController
        [SerializeField] private PowerGageOutputViewController powerGageOutputViewController;
        [SerializeField] private PowerGageModelController powerGageModelController;

        private void Start()
        {
            //購読
            powerGageModelController
                .GetPowerGage
                .Subscribe(power =>
                {
                    //表示させよう
                    powerGageOutputViewController.UpdatePowerGageView(power);
                })
                .AddTo(this);
        }
    }
}
