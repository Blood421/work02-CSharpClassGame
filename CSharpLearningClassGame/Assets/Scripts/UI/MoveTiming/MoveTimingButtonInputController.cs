using UnityEngine;
using UnityEngine.UI;

namespace CsharpLearningGame.UI.MoveTiming
{
    [RequireComponent(typeof(Button))]
    public class MoveTimingButtonInputController : MonoBehaviour
    {
        //�����������ł����0~1
        [SerializeField] private Vector2 dir;
        public Vector2 GetDir() => dir;

        private Button moveTimingButton;
        public Button GetButton() => moveTimingButton;
        private void Awake()
        {
            //������
            moveTimingButton = GetComponent<Button>();
        }
    }
}
