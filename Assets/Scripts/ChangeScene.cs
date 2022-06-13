using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene: MonoBehaviour
{
    public string sceneToLoad;

    public void OpenTheDoor()
    {
        SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Single);
    }
}