using UnityEngine;

public class GamePause : MonoBehaviour {

    public bool paused = false;

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
			inGameUI.GetComponent<Canvas>().enabled = false;
            movement.SetActive(false);
            Time.timeScale = 0;
            lM.SetActive(false);
            aS.Pause();
        }
        else if (!paused)
        {
            pauseBackground.SetActive(false);
            pauseUI.SetActive(false);
			inGameUI.GetComponent<Canvas>().enabled = true;
            movement.SetActive(true);
            Time.timeScale = 1;
            lM.SetActive(true);
            aS.Play();
        }
    }
}
