using UnityEngine;

public class PlayerCollision : MonoBehaviour
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
    GameObject gameOverUI;

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
            if (timer > 0.031)
            {
                Vibration.Vibrate(30);
                timer = 0;
            }
            score.AddScore(5);
            Instantiate(beatRed, collision.gameObject.transform.position, Quaternion.identity);
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Time.timeScale = 0;
            move.SetActive(false);
            sound.GetComponent<AudioSource>().Pause();
            movement.SetActive(false);
            inGameUI.SetActive(false);
            gameOverUI.SetActive(true);
            pauseBackground.SetActive(true);
        }
    }
}
