using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalFlag : MonoBehaviour
{
    [SerializeField] private string nextSceneName;

    private bool isTriggered = false;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (isTriggered) return;

        if (collision.CompareTag("Player"))
        {
            isTriggered = true;
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
