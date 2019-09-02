using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivationHandClap : MonoBehaviour
{
    [SerializeField]
    GameObject set1Left;
    [SerializeField]
    GameObject set1Right;
    [SerializeField]
    GameObject set1Obsticle;
    [SerializeField]
    GameObject set2Left;
    [SerializeField]
    GameObject set2Right;
    [SerializeField]
    GameObject set3;
    [SerializeField]
    GameObject set3Obsticle;
    [SerializeField]
    GameObject set4Left;
    [SerializeField]
    GameObject set4Right;
    [SerializeField]
    GameObject set4Obstacle;
    [SerializeField]
    GameObject set5Left;
    [SerializeField]
    GameObject set5Right;
    [SerializeField]
    GameObject set5Obstacle;
    [SerializeField]
    GameObject set6;
    [SerializeField]
    GameObject set6Obstacle;
    [SerializeField]
    GameObject set7;
    [SerializeField]
    GameObject set7Obstacle;

    void Start()
    {
        StartCoroutine(Set1());
        StartCoroutine(Set2());
        StartCoroutine(Set3());
        StartCoroutine(Set4());
        StartCoroutine(Set5());
        StartCoroutine(Set6());
        StartCoroutine(Set7());
    }

    private void Update()
    {
        Debug.Log(Time.time);
    }


    IEnumerator Set1() //Start2
    {
        yield return new WaitForSeconds(31);
        set1Left.SetActive(true);
        set1Right.SetActive(true);
        set1Obsticle.SetActive(true);
    }

    IEnumerator Set2() //Build up
    {
        yield return new WaitForSeconds(67);
        set2Left.SetActive(true);
        set2Right.SetActive(true);
    }

    IEnumerator Set3() //Drop
    {
        yield return new WaitForSeconds(80);
        set3.SetActive(true);
        set3Obsticle.SetActive(true);
    }

    IEnumerator Set4() //Start1
    {
        yield return new WaitForSeconds(97);
        set4Left.SetActive(true);
        set4Right.SetActive(true);
        set4Obstacle.SetActive(true);
    }

    IEnumerator Set5() //Build up
    {
        yield return new WaitForSeconds(120);
        set5Left.SetActive(true);
        set5Right.SetActive(true);
        set5Obstacle.SetActive(true);
    }

    IEnumerator Set6() //Drop
    {
        yield return new WaitForSeconds(145);
        set6.SetActive(true);
        set6Obstacle.SetActive(true);
    }

    IEnumerator Set7() //2nd Drop
    {
        yield return new WaitForSeconds(163);
        set7.SetActive(true);
        set7Obstacle.SetActive(true);
    }
}
