using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToScene : MonoBehaviour
{
    [SerializeField] private string sceneName;

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
