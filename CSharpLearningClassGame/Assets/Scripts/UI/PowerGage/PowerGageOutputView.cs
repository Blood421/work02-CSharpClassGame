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
            //������
            powerGageSlider = GetComponent<Slider>();
        }

        public void UpdatePowerGageSlider(float power)
        {
            //�X���C�_�[�ɒl������
            powerGageSlider.value = power;
        }
    }
}
