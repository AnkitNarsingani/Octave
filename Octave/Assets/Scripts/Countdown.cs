using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    [SerializeField]
    Text startText;
    [SerializeField]
    float timeLeft;

    [SerializeField]
    GameObject gamewinUI, winBackground;


    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
            startText.text = (timeLeft).ToString("0");
        else
        {
            gamewinUI.SetActive(true);
            gameObject.SetActive(false);
            winBackground.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
