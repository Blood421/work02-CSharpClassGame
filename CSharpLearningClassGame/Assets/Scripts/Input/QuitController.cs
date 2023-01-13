using UnityEngine;

namespace CsharpLearningGame.Input
{
    public class QuitController : MonoBehaviour
    {
        //�L�[
        [SerializeField] private KeyCode quitKey;
        void Update()
        {
            if (UnityEngine.Input.GetKeyDown(quitKey))
            {
                //�I��
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
            }
        }
    }
}
