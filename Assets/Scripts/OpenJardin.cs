using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenJardin : MonoBehaviour
{
    public void OpenTheDoor()
    {
        SceneManager.LoadScene("Jardin", LoadSceneMode.Single);
    }
}
