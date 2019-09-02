using UnityEngine;
using System.Collections;

public class TutorialCollision : MonoBehaviour
{

    [SerializeField]
    GameObject beatBlue;

    [SerializeField]
    GameObject beatRed;

    [SerializeField]
    GameObject move;

    [SerializeField]
    GameObject sound;

    [SerializeField]
    GameObject movement;

    [SerializeField]
    GameObject pauseBackground;

    [SerializeField]
    GameObject beCarefulUI;

    double timer = 0;

    [SerializeField]
    GameObject inGameUI;
    Score score;
    int trackScore;


    void Start()
    {
        score = inGameUI.GetComponent<Score>();
    }

    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable Blue"))
        {
            Destroy(collision.gameObject);
            Instantiate(beatBlue, collision.gameObject.transform.position, Quaternion.identity);
            score.AddScore(1);
        }
        else if (collision.gameObject.CompareTag("Collectable Red"))
        {
            Destroy(collision.gameObject);
            if (timer > 0.03)
            {
                Vibration.Vibrate(30);
                timer = 0;
            }
            score.AddScore(5);
            Instantiate(beatRed, collision.gameObject.transform.position, Quaternion.identity);

        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(GameoverUI());
        }
    }

    IEnumerator GameoverUI()
    {
        beCarefulUI.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        beCarefulUI.SetActive(false);
    }
}

