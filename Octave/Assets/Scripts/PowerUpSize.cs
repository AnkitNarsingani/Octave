using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpSize : MonoBehaviour {
    [SerializeField]
    Text powerCount;

    int noOfPowerUps = 2;

    [SerializeField]
    Vector3 powerUpSize;

    [SerializeField]
    GameObject ballLeft, ballRight;

    Vector3 originalSize = new Vector3(13f, 13.5f, 0);

    bool usingPower = false;

	GamePause gP;

    void Start ()
    {
		gP = gameObject.GetComponent<GamePause> ();
        UpdateCount();
	}

    public void OnTouchSize()
    {
        if (noOfPowerUps > 0 && !usingPower)
        {
            noOfPowerUps--;
            UpdateCount();
            ballLeft.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, powerUpSize, 2);
            ballRight.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, powerUpSize, 2);
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
		for (int i = 0; i < 7; i++) 
		{
			while (gP.paused) 
			{
				yield return null;
			}
			yield return new WaitForSeconds(1);
		}     
        ballLeft.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, originalSize, 2);
        ballRight.transform.localScale = Vector3.Lerp(gameObject.transform.localScale, originalSize, 2);
        usingPower = false;
    }
}
