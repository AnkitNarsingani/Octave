using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialTap : MonoBehaviour
{

    [SerializeField]
    GameObject thumbs, powerups;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 1)
        {
            thumbs.SetActive(false);
            StartCoroutine(Powerups());
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