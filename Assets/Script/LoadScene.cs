using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private void Start()
    {
        Invoke(nameof(LoadScene), 5f);
    }
    private void LoadScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
