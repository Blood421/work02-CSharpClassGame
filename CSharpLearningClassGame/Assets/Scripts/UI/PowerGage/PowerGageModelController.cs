using UniRx;
using UnityEngine;

namespace CsharpLearningGame.UI.PowerGage
{
    public class PowerGageModelController : MonoBehaviour
    {
        private PowerGageModel powerGageModel;
        private void Awake()
        {
            //èâä˙âª
            powerGageModel = new PowerGageModel();
            PowerGageModelPresenter.SetPowerGageModelController(this);
            PowerGageModelPresenter.SetIPowerGagePresenter(new PowerGagePresenterWorker());
        }

        //Get Set
        public IReadOnlyReactiveProperty<float> GetPowerGage => powerGageModel.roPower;
        public void SetPowerGage(float value) => powerGageModel.SetPower(value);

    }
}
