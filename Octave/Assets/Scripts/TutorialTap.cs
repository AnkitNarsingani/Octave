using System.Collections;
using UnityEngine;

public class TutorialTap : MonoBehaviour
{

    [SerializeField]
    GameObject thumbs, powerups;

    [SerializeField]
    AudioSource aS;

    [SerializeField]
    GameObject lM;

    int n = 0;

    private void Start()
    {
        Time.timeScale = 0;
    }
    void Update()
    {
		if (Input.touchCount > 1 && n == 0)
        {
            aS.Play();
            Time.timeScale = 1;
            lM.GetComponent<LevelMove>().enabled = true;
            thumbs.SetActive(false);
            StartCoroutine("Powerups");
            n++;
        }
    }

    IEnumerator Powerups()
    {
        powerups.SetActive(true);
        yield return new WaitForSeconds(3);
        powerups.SetActive(false);
        gameObject.SetActive(false);
    }
}