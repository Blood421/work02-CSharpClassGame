using UnityEngine;

namespace CsharpLearningGame.UI.PowerGage
{
    public class PowerGageOutputViewController : MonoBehaviour
    {
        [SerializeField] private PowerGageOutputView powerGageOutputView;

        public void UpdatePowerGageView(float power)
        {
            //ワンクッション挟む
            powerGageOutputView.UpdatePowerGageSlider(power);
        }
    }
}
