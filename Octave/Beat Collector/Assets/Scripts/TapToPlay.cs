using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TapToPlay : MonoBehaviour {

    [SerializeField] Text TapToPlayText;
    int n;

    private void Start()
    {
        n = PlayerPrefs.GetInt("n", 0);
    }
    void Update ()
    {
        if (Input.touchCount > 0)
        {
            if(n == 0)
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
}
