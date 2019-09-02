using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TapToPlay : MonoBehaviour
{
    int n;
    bool canTap = false;

    float waitTime = 0.7f;

    private void Start()
    {
        n = PlayerPrefs.GetInt("n", 0);
        StartCoroutine(AllowTap());
    }

    void Update()
    {
        if (Input.touchCount > 0 && canTap)
        {
            if (n == 0)
            {
                SceneManager.LoadScene(6);
                n++;
                PlayerPrefs.SetInt("n", n);
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }

    }

    IEnumerator AllowTap()
    {
        yield return new WaitForSeconds(waitTime);
        canTap = true;
    }
}
