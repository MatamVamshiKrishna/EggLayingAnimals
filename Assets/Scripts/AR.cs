using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AR : MonoBehaviour
{
    public Text Message;
    public GameObject MessagePanel;
    public GameObject InstructionPanel;

    void Start()
    {
        if (Stage.type == Stage.Type.Stage_3)
            Message.text = "PLACE ANY ONE CARD ELA – 01 to ELA – 04";
        else if (Stage.type == Stage.Type.Stage_4)
            Message.text = "PLACE ANY ONE CARD ELA – 05 to ELA – 07";
    }

    public void OnClickBackButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnTarget()
    {
        MessagePanel.SetActive(false);
        InstructionPanel.SetActive(true);
    }
     
    public void OffTarget()
    {
        MessagePanel.SetActive(true);
        InstructionPanel.SetActive(false);
    }
}  



