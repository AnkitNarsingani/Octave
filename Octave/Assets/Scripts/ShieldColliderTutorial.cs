using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldColliderTutorial : MonoBehaviour
{
    [SerializeField]
    GameObject beatBlue;

    [SerializeField]
    GameObject beatRed;

    [SerializeField]
    GameObject inGameUI;

    Score score;

    double timer = 0;

    [HideInInspector]
    public int breakCount = 1;

    [SerializeField]
    TutorialShield disableObject;

	void Update()
	{
		timer += Time.deltaTime;
	}

    void Start()
    {
        score = inGameUI.GetComponent<Score>();
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
            switch (breakCount)
            {
                case 1:
                    Destroy(collision.gameObject);
                    breakCount++;
                    break;
                case 2:
                    Destroy(collision.gameObject);
                    breakCount++;
                    break;
                case 3:
                    Destroy(collision.gameObject);
                    disableObject.isActive = false;
                    gameObject.SetActive(false);
                    break;
            }
        }
    }
}
