using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLineUI : MonoBehaviour
{
    public Text successText;

    public void ShowSuccessMessage()
    {
        successText.text = "Success!";
    }
}