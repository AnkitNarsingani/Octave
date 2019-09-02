using UnityEngine;

public class FormOctave : MonoBehaviour
{
    public Transform endPos;
    public Vector3 size;
    void Start()
    {
        
    }


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPos.position, 100 * Time.deltaTime);
        //transform.localPosition = Vector3.Lerp(transform.localPosition, size, 5 * Time.deltaTime);
    }
}
