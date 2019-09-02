using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;


public class Share : MonoBehaviour
{
    public Score sc;

    [SerializeField]
    GameObject shareUI, shareBackground, gameWinUI, gameOverUI;

    public void OnTouchShareGW()
    {
        shareUI.SetActive(true);
        gameWinUI.SetActive(false);
        shareBackground.SetActive(true);

		StartCoroutine(TakeScGameWin());
    }

	public void OnTouchShareGO()
	{
		shareUI.SetActive(true);
		gameOverUI.SetActive(false);
		shareBackground.SetActive(true);

		StartCoroutine(TakeScGameOver());
	}

    IEnumerator TakeScGameWin()
    {


        yield return new WaitForEndOfFrame();
        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        shareUI.SetActive(false);
        gameWinUI.SetActive(true);
        shareBackground.SetActive(false);

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        Destroy(ss);

        new NativeShare().AddFile(filePath).SetSubject("Octave").SetText("Check out what I achived in Octave!\nCan you \'beat\' my highscore?").Share();
    }

	IEnumerator TakeScGameOver()
	{


		yield return new WaitForEndOfFrame();
		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		shareUI.SetActive(false);
		gameOverUI.SetActive(true);
		shareBackground.SetActive(false);

		string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
		File.WriteAllBytes(filePath, ss.EncodeToPNG());

		Destroy(ss);

		new NativeShare().AddFile(filePath).SetSubject("Octave").SetText("Check out what I achived in Octave!\nCan you \'beat\' my highscore?").Share();
	}
}
