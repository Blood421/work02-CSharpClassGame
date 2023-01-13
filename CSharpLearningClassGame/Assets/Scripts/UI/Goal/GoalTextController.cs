using UnityEngine;

namespace CsharpLearningGame.UI.Goal
{
    public class GoalTextController : MonoBehaviour
    {
        private void Awake()
        {
            //îÒï\é¶Ç…
            gameObject.SetActive(false);
        }

        public void SetEnableGoalText()
        {
            //ÉSÅ[ÉãÇµÇΩÇÁï\é¶
            gameObject.SetActive(true);
        }
    }
}
