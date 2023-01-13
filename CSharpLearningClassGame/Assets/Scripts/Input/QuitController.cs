using UnityEngine;

namespace CsharpLearningGame.Input
{
    public class QuitController : MonoBehaviour
    {
        //ÉLÅ[
        [SerializeField] private KeyCode quitKey;
        void Update()
        {
            if (UnityEngine.Input.GetKeyDown(quitKey))
            {
                //èIóπ
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif
            }
        }
    }
}
