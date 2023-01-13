using UnityEngine;
using UnityEngine.UI;

namespace CsharpLearningGame.UI.PowerGage
{
    [RequireComponent(typeof(Slider))]
    public class PowerGageOutputView : MonoBehaviour
    {
        private Slider powerGageSlider;
        private void Awake()
        {
            //初期化
            powerGageSlider = GetComponent<Slider>();
        }

        public void UpdatePowerGageSlider(float power)
        {
            //スライダーに値を入れる
            powerGageSlider.value = power;
        }
    }
}
