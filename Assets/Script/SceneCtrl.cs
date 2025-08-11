using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCtrl : MonoBehaviour
{
    private void Awake()
    {
        SoundManager.instance.PlayBGM(0);
    }
    public void optBnt() => SoundManager.instance.muteBGM();
    public void Quit() => Application.Quit();
    public void toSceneA()
    {
        SoundManager.instance.stopSound();
        SceneManager.LoadScene("ModeA");
    }
    public void toSceneB()
    {
        SoundManager.instance.stopSound();
        SceneManager.LoadScene("ModeB");
    }
}
