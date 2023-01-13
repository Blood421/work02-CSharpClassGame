using UnityEngine;

namespace CsharpLearningGame.UI.PowerGage
{
    public class PowerGageOutputViewController : MonoBehaviour
    {
        [SerializeField] private PowerGageOutputView powerGageOutputView;

        public void UpdatePowerGageView(float power)
        {
            //ƒƒ“ƒNƒbƒVƒ‡ƒ“‹²‚Ş
            powerGageOutputView.UpdatePowerGageSlider(power);
        }
    }
}
