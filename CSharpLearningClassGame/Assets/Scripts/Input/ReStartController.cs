using UnityEngine;
using UnityEngine.SceneManagement;

namespace CsharpLearningGame.Input
{
    public class ReStartController : MonoBehaviour
    {
        //�L�[
        [SerializeField] private KeyCode reStartKey;
        void Update()
        {
            if (UnityEngine.Input.GetKeyDown(reStartKey))
            {
                //���X�^�[�g
                SceneManager.LoadScene(0);
            }
        }
    }
}
