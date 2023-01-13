using UnityEngine;
using UnityEngine.SceneManagement;

namespace CsharpLearningGame.Input
{
    public class ReStartController : MonoBehaviour
    {
        //キー
        [SerializeField] private KeyCode reStartKey;
        void Update()
        {
            if (UnityEngine.Input.GetKeyDown(reStartKey))
            {
                //リスタート
                SceneManager.LoadScene(0);
            }
        }
    }
}
