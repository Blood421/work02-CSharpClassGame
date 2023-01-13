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
            //�w��
            powerGageModelController
                .GetPowerGage
                .Subscribe(power =>
                {
                    //�\�������悤
                    powerGageOutputViewController.UpdatePowerGageView(power);
                })
                .AddTo(this);
        }
    }
}
