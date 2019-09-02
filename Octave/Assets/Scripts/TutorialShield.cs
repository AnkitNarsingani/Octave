using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TutorialShield : MonoBehaviour
{
    [SerializeField]
    GameObject shieldLeft;

    [SerializeField]
    GameObject shieldRight;

    [HideInInspector]
    public bool isActive = false;

    int noOfPowerUps = 2;

    [SerializeField]
    Text powerCount;

    [SerializeField]
    TutorialCollision playerScriptLeft, playerScriptRight;

    [SerializeField]
    ShieldColliderTutorial shieldCountLeft, shieldCountRight;

    void Start()
    {
        UpdateText();
    }


    void Update()
    {

    }

    public void OnTouchShield()
    {
        if (!isActive && noOfPowerUps > 0)
        {
            isActive = true;
            noOfPowerUps--;
            UpdateText();
            int token = Random.Range(1, 3);
            switch (token)
            {
                case 1:
                    StartCoroutine(DisableShieldLeft());
                    shieldLeft.SetActive(true);
                    playerScriptLeft.enabled = false;
                    break;
                case 2:
                    StartCoroutine(DisableShieldRight());
                    playerScriptRight.enabled = false;
                    shieldRight.SetActive(true);
                    break;
            }

        }
    }

    IEnumerator DisableShieldLeft()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            if (!isActive)
            {
                shieldLeft.SetActive(false);
                playerScriptLeft.enabled = true;
                shieldCountLeft.breakCount = 1;
                isActive = false;
                break;
            }
        }
        isActive = false;
        playerScriptLeft.enabled = true;
        shieldCountLeft.breakCount = 1;
        shieldLeft.SetActive(false);
    }

    IEnumerator DisableShieldRight()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSecondsRealtime(1);
            if (!isActive)
            {
                shieldRight.SetActive(false);
                playerScriptRight.enabled = true;
                shieldCountRight.breakCount = 1;
                isActive = false;
                break;
            }

        }
        isActive = false;
        playerScriptRight.enabled = true;
        shieldCountRight.breakCount = 1;
        shieldRight.SetActive(false);
    }

    void UpdateText()
    {
        powerCount.text = noOfPowerUps.ToString();
    }
}
