using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoadLevelScript : MonoBehaviour
{

    public GameObject inGameUI;
    public GameObject loading;

    public void LoadLevel(int index)
    {
        Camera.main.GetComponentInChildren<SpriteRenderer>().color = Color.black;
        inGameUI.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadSceneAsync(index);
        Time.timeScale = 1;
    }

    public void Retry(int index)
    {
        SceneManager.LoadScene(index);
        Time.timeScale = 1;
    }
}
