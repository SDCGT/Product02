using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnBtnClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Text textOfBtn;
    public Text textOfText;

    public void ClickBtn()
    {
        textOfBtn.text = "你点你马呢";
        textOfText.text = "继续睡觉";
    }
}
