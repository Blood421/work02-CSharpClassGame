using UnityEngine;

namespace CsharpLearningGame.UI.PowerGage
{
    public static class PowerGageModelPresenter
    {
        //初期化されるインスタンス
        private static PowerGageModelController powerGageModelController;
        private static IPowerGagePresenterWorker iPowerGagePresenterWorker;

        //エラーハンドリング
        private static PowerGageModelController GetPowerGageModelController()
        {
            if (powerGageModelController == null)
            {
                Debug.LogError( powerGageModelController + "がnull");
            }
            return powerGageModelController;
        }
        private static IPowerGagePresenterWorker GetIPowerGagePresenterWorker()
        {
            if (iPowerGagePresenterWorker == null)
            {
                Debug.LogError(iPowerGagePresenterWorker + "がnull");
            }
            return iPowerGagePresenterWorker;
        }

        //初期化用
        public static void SetPowerGageModelController(PowerGageModelController controller) =>
            powerGageModelController = controller;
        public static void SetIPowerGagePresenter (IPowerGagePresenterWorker presenter) =>
            iPowerGagePresenterWorker = presenter;

        //外部からはこれを呼ぶ
        public static float GetPower()
        {
            return GetIPowerGagePresenterWorker().GetPower(GetPowerGageModelController());
        }

        public static void SetPower(float power)
        {
            GetIPowerGagePresenterWorker().SetPowerValue(power, GetPowerGageModelController());
        }
    }

    public interface IPowerGagePresenterWorker
    {
        public void SetPowerValue(float power,PowerGageModelController powerGageModelController);
        public float GetPower(PowerGageModelController powerGageModelController);
    }

    public class PowerGagePresenterWorker : IPowerGagePresenterWorker
    {
        public void SetPowerValue(float power, PowerGageModelController powerGageModelController)
        {
            if (power > 1)
            {
                Debug.Log("1を超えたから修正したよ before:" + power);
                power = 1;
            }
            powerGageModelController.SetPowerGage(power);
        }
        public float GetPower(PowerGageModelController powerGageModelController)
        {
            return powerGageModelController.GetPowerGage.Value;
        }

    }
}
