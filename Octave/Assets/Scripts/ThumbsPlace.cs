using UnityEngine;
using System.Collections;

public class ThumbsPlace : MonoBehaviour
{
    [SerializeField]
    GameObject warningUI;

    private bool isActive = false;

    void OnTouchStay(Vector3 point)
    {

    }

    void OnTouchDown(Vector3 point)
    {
        if (!isActive)
            StartCoroutine(WarningUI());
    }

    void OnTouchMoved(Vector3 point)
    {

    }

    IEnumerator WarningUI()
    {
        warningUI.SetActive(true);
        isActive = true;
        yield return new WaitForSeconds(1.5f);
        isActive = false;
        warningUI.SetActive(false);
    }
}
