using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RotateDisc : MonoBehaviour
{

    [SerializeField]
    Animator animHandClap, animFuckItUp;

    [SerializeField]
    AudioSource aS;

    bool playHc = false, playFu = false;

    [SerializeField]
    AudioClip handClap, fuckItUp;

    bool handClapRot = false;
    bool fuckItUpRot = false;

    GameObject coverHC, coverFU;
    RectTransform hC, fU;

    Coroutine coroutine = null;

    public Slider sr;

    [SerializeField]
    Button h, f;

    void Start()
    {
        coverHC = animHandClap.gameObject;
        coverFU = animFuckItUp.gameObject;

        hC = coverHC.GetComponent<RectTransform>();
        fU = coverFU.GetComponent<RectTransform>();
    }


    void Update()
    {
        if (fuckItUpRot)
        {
            f.interactable = false;
        }
        if(handClapRot)
        {
            h.interactable = false;
        }
        if (fU.localEulerAngles.z > 355 && fuckItUpRot)
        {
            animFuckItUp.Play("New State");
            fuckItUpRot = false;
            f.interactable = true;
        }
        if (hC.localEulerAngles.z > 355 && handClapRot)
        {
            animHandClap.Play("New State");
            handClapRot = false;
            h.interactable = true;
        }
    }

    public void OnTouchHandClap()
    {
        playHc = !playHc;
        if (playHc)
        {
            aS.clip = handClap;
            coroutine = StartCoroutine(PlayClipHC());
        }
        else
        {
            aS.Stop();
            handClapRot = true;
            StopCoroutine(coroutine);
        }
    }

    public void OnTouchFuckItUp()
    {
        playFu = !playFu;
        if (playFu)
        {
            aS.clip = fuckItUp;
            coroutine = StartCoroutine(PlayClipFU());
        }
        else
        {
            aS.Stop();
            fuckItUpRot = true;
            StopCoroutine(coroutine);
        }
    }

    IEnumerator PlayClipFU()
    {
        animFuckItUp.Play("Rotate FU");
        aS.Play();
        for (int i = 0; i < aS.clip.length * 2; i++)
        {
            yield return new WaitForSeconds(0.5f);
            if (sr.swipeValue > 0)
            {
                animFuckItUp.Play("New State");
                fU.localEulerAngles = Vector3.zero;
                playFu = false;
                aS.Stop();
                StopCoroutine(coroutine);
            }
        }
        animFuckItUp.Play("New State");
        playFu = false;
        aS.Stop();
    }

    IEnumerator PlayClipHC()
    {
        animHandClap.Play("Rotate HC");
        aS.Play();
        for (int i = 0; i < aS.clip.length * 2; i++)
        {
            yield return new WaitForSeconds(1);
            if (sr.swipeValue < 0)
            {
                animHandClap.Play("New State");
                hC.localEulerAngles = Vector3.zero;
                playHc = false;
                aS.Stop();
                StopCoroutine(coroutine);
            }
        }
        animHandClap.Play("New State");
        playHc = false;
        aS.Stop();
    }
}
