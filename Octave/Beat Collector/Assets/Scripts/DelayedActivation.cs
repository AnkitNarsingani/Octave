using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedActivation : MonoBehaviour {
    [SerializeField]
    GameObject set1Left;
    [SerializeField]
    GameObject set1Right;
    [SerializeField]
    GameObject set2;
    [SerializeField]
    GameObject set2Obsticle;
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
    GameObject set6;
    [SerializeField]
    GameObject set6Obstacle;
    [SerializeField]
    GameObject set7;
    [SerializeField]
    GameObject set7Obstacle;
    [SerializeField]
    GameObject set8Left;
    [SerializeField]
    GameObject set8Right;
    [SerializeField]
    GameObject set8Obstacle;
    [SerializeField]
    GameObject set9;
    [SerializeField]
    GameObject set9Obstacle;
    [SerializeField]
    GameObject set10;
    [SerializeField]
    GameObject set10Obstalce;

	void Start ()
    {
        StartCoroutine(Set1());
        StartCoroutine(Set2());
        StartCoroutine(Set3());
        StartCoroutine(Set4());
        StartCoroutine(Set5());
        StartCoroutine(Set6());
        StartCoroutine(Set7());
        StartCoroutine(Set8());
        StartCoroutine(Set9());
        StartCoroutine(Set10());
    }


    IEnumerator Set1 () //Buildup
    {
        yield return new WaitForSecondsRealtime(32);
        set1Left.SetActive(true);
        set1Right.SetActive(true);
    }

    IEnumerator Set2 () //Drop
    {
        yield return new WaitForSecondsRealtime(55);
        set2.SetActive(true);
        set2Obsticle.SetActive(true);
    }

    IEnumerator Set3() //Drop1
    {
        yield return new WaitForSecondsRealtime(69);
        set3.SetActive(true);
        set3Obsticle.SetActive(true);
    }

    IEnumerator Set4() //End
    {
        yield return new WaitForSecondsRealtime(81);
        set4Left.SetActive(true);
        set4Right.SetActive(true);
        set4Obstacle.SetActive(true);
    }

    IEnumerator Set5() //2nd Build up
    {
        yield return new WaitForSecondsRealtime(105);
        set5Left.SetActive(true);
        set5Right.SetActive(true);
    }

    IEnumerator Set6() //2nd Drop
    {
        yield return new WaitForSecondsRealtime(125);
        set6.SetActive(true);
        set6Obstacle.SetActive(true);
    }

    IEnumerator Set7() //2nd Drop (1)
    {
        yield return new WaitForSecondsRealtime(140);
        set7.SetActive(true);
        set7Obstacle.SetActive(true);
    }

    IEnumerator Set8() //Late Buildup
    {
        yield return new WaitForSecondsRealtime(156);
        set8Left.SetActive(true);
        set8Right.SetActive(true);
        set8Obstacle.SetActive(true);
    }

    IEnumerator Set9() //3rd Drop
    {
        yield return new WaitForSecondsRealtime(180);
        set9.SetActive(true);
        set9Obstacle.SetActive(true);
    }

    IEnumerator Set10() //3rd Drop(1)
    {
        yield return new WaitForSecondsRealtime(193);
        set10.SetActive(true);
        set10Obstalce.SetActive(true);
    }

}
