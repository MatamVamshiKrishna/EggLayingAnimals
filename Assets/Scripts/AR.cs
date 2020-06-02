using UnityEngine;
using UnityEngine.UI;

public class AR : MonoBehaviour
{
    public Text Message;

    void Start()
    {
        if (Stage.type == Stage.Type.Stage_3)
            Message.text = "PLACE ANY ONE CARD ELA – 01 to ELA – 04";
        else if (Stage.type == Stage.Type.Stage_4)
            Message.text = "PLACE ANY ONE CARD ELA – 05 to ELA – 07";
    }
}
