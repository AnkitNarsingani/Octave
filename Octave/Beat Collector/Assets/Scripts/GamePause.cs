using UnityEngine;
using UnityEngine.UI;

public class GamePause : MonoBehaviour {

    private bool paused = false;

    [SerializeField]
    GameObject lM;

    [SerializeField]
    GameObject pauseBackground;

    [SerializeField]
    AudioSource aS;

    [SerializeField]
    GameObject inGameUI;

    [SerializeField]
    GameObject pauseUI;

    [SerializeField]
    GameObject movement;


    public void OnTouchPause()
    {
        paused = !paused;
        if (paused)
        {
            pauseBackground.SetActive(true);
            pauseUI.SetActive(true);
            inGameUI.SetActive(false);
            movement.SetActive(false);
            Time.timeScale = 0;
            lM.SetActive(false);
            aS.Pause();
        }
        else if (!paused)
        {
            pauseBackground.SetActive(false);
            pauseUI.SetActive(false);
            inGameUI.SetActive(true);
            movement.SetActive(true);
            Time.timeScale = 1;
            lM.SetActive(true);
            aS.Play();
        }
    }
}
