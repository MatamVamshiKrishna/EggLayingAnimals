using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void On3stageButtonClick()
    {
        Stage.type = Stage.Type.Stage_3;
        SceneManager.LoadScene("3Stage");
    }

    public void On4stageButtonClick()
    {
        Stage.type = Stage.Type.Stage_4;
        SceneManager.LoadScene("4Stage");
    }
    
    public void OnExitButtonClick()
    {
        Application.Quit();
    }

}
