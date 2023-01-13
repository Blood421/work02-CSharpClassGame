using UnityEngine;

namespace CsharpLearningGame.UI.PowerGage
{
    public static class PowerGageModelPresenter
    {
        //�����������C���X�^���X
        private static PowerGageModelController powerGageModelController;
        private static IPowerGagePresenterWorker iPowerGagePresenterWorker;

        //�G���[�n���h�����O
        private static PowerGageModelController GetPowerGageModelController()
        {
            if (powerGageModelController == null)
            {
                Debug.LogError( powerGageModelController + "��null");
            }
            return powerGageModelController;
        }
        private static IPowerGagePresenterWorker GetIPowerGagePresenterWorker()
        {
            if (iPowerGagePresenterWorker == null)
            {
                Debug.LogError(iPowerGagePresenterWorker + "��null");
            }
            return iPowerGagePresenterWorker;
        }

        //�������p
        public static void SetPowerGageModelController(PowerGageModelController controller) =>
            powerGageModelController = controller;
        public static void SetIPowerGagePresenter (IPowerGagePresenterWorker presenter) =>
            iPowerGagePresenterWorker = presenter;

        //�O������͂�����Ă�
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
                Debug.Log("1�𒴂�������C�������� before:" + power);
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
