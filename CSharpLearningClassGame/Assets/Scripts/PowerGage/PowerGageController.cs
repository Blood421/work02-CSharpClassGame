using CsharpLearningGame.UI.PowerGage;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.PowerGage
{
    public class PowerGageController : MonoBehaviour
    {
        //�͂𗭂߂�Ȑ��Ɨ��܂�܂ł̎���
        [SerializeField] private AnimationCurve powerChargeCurve;
        [SerializeField] private float duration = 1f;
        private ReactiveProperty<float> power = new ReactiveProperty<float>(0);
        private float time = 0;

        private void Awake()
        {
            //������
            power.Value = 0;
            time = 0;
        }

        private void Start()
        {
            //�͂��ς�������̏���
            power
                .Subscribe(x =>
                {
                    PowerGageModelPresenter.SetPower(x);
                })
                .AddTo(this);
        }

        private void Update()
        {
            //���Ԍo��
            time += Time.deltaTime;

            //�`���[�W
            float chargeCurveTime = time / duration;
            float charge = powerChargeCurve.Evaluate(chargeCurveTime);
            Mathf.Clamp01(charge);
            //0~1�Őݒ�
            power.Value = charge;


            if (time >= duration)
            {
                //���ԃ��Z�b�g
                time = 0;
            }
        }

        public void Reset()
        {
            //���Z�b�g
            power.Value = 0;
            time = 0;
        }
    }
}
