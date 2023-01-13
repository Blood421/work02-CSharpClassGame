using UniRx;

namespace CsharpLearningGame.UI.PowerGage
{
    public class PowerGageModel
    {
        //—Í Get Set
        public IReadOnlyReactiveProperty<float> roPower => power;
        private readonly ReactiveProperty<float> power = new ReactiveProperty<float>(0);
        public void SetPower(float power) => this.power.Value = power;
    }
}
