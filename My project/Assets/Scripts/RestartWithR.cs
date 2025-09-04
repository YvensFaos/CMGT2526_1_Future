using UnityEngine;
using UnityEngine.SceneManagement;

namespace DefaultNamespace
{
    public class RestartWithR : MonoBehaviour
    {
        private void Update()
        {
            if (!Input.GetKeyUp(KeyCode.R)) return;
            var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex);
        }
    }
}