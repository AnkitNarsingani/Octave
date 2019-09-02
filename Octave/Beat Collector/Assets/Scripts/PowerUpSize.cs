using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpSize : MonoBehaviour {
    [SerializeField]
    Text powerCount;

    int noOfPowerUps = 2;

    [SerializeField]
    Vector3 powerUpSizeLeft, powerUpSizeRight;

    [SerializeField]
    GameObject ballLeft, ballRight;

    Vector3 OirginalSizeLeft = new Vector3(0.045f, 0.066f, 0);
    Vector3 OirginalSizeRight = new Vector3(13f, 13.5f, 0);

    bool usingPower = false;

    void Start ()
    {
        UpdateCount();
	}
	

	void Update () {
		
	}

    public void OnTouchSize()
    {
        if (noOfPowerUps > 0 && !usingPower)
        {
            noOfPowerUps--;
            UpdateCount();
            ballLeft.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, powerUpSizeLeft, 2);
            ballRight.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, powerUpSizeRight, 2);
            usingPower = true;
            StartCoroutine(OriginalSize());
        }
    }

    void UpdateCount()
    {
        powerCount.text = noOfPowerUps.ToString();
    }

    IEnumerator OriginalSize()
    {
        yield return new WaitForSeconds(10);
        ballLeft.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, OirginalSizeLeft, 2);
        ballRight.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, OirginalSizeRight, 2);
        usingPower = false;
    }
}
