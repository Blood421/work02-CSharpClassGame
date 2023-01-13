using CsharpLearningGame.UI.PowerGage;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.PowerGage
{
    public class PowerGageController : MonoBehaviour
    {
        //力を溜める曲線と溜まるまでの時間
        [SerializeField] private AnimationCurve powerChargeCurve;
        [SerializeField] private float duration = 1f;
        private ReactiveProperty<float> power = new ReactiveProperty<float>(0);
        private float time = 0;

        private void Awake()
        {
            //初期化
            power.Value = 0;
            time = 0;
        }

        private void Start()
        {
            //力が変わった時の処理
            power
                .Subscribe(x =>
                {
                    PowerGageModelPresenter.SetPower(x);
                })
                .AddTo(this);
        }

        private void Update()
        {
            //時間経過
            time += Time.deltaTime;

            //チャージ
            float chargeCurveTime = time / duration;
            float charge = powerChargeCurve.Evaluate(chargeCurveTime);
            Mathf.Clamp01(charge);
            //0~1で設定
            power.Value = charge;


            if (time >= duration)
            {
                //時間リセット
                time = 0;
            }
        }

        public void Reset()
        {
            //リセット
            power.Value = 0;
            time = 0;
        }
    }
}
