using UnityEngine;

namespace CsharpLearningGame.UI.Goal
{
    public class GoalTextController : MonoBehaviour
    {
        private void Awake()
        {
            //��\����
            gameObject.SetActive(false);
        }

        public void SetEnableGoalText()
        {
            //�S�[��������\��
            gameObject.SetActive(true);
        }
    }
}
