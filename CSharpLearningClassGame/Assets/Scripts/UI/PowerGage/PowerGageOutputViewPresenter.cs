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
            //w“Ç
            powerGageModelController
                .GetPowerGage
                .Subscribe(power =>
                {
                    //•\Ž¦‚³‚¹‚æ‚¤
                    powerGageOutputViewController.UpdatePowerGageView(power);
                })
                .AddTo(this);
        }
    }
}
