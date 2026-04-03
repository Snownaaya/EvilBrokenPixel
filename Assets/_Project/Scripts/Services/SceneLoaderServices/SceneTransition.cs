using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets._Project.Scripts.Services.SceneLoaderServices
{
    public class SceneTransition
    {
        public void SceneLoader(SceneID sceneID)
        {
            string sceneName = sceneID.ToString();
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }

        public void ExitGame()
        {
            Debug.Log("ExitGame");
            Application.Quit();
        }
    }
}