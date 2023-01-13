using UnityEngine;

namespace CsharpLearningGame.UI.Goal
{
    public class GoalTextController : MonoBehaviour
    {
        private void Awake()
        {
            //非表示に
            gameObject.SetActive(false);
        }

        public void SetEnableGoalText()
        {
            //ゴールしたら表示
            gameObject.SetActive(true);
        }
    }
}
