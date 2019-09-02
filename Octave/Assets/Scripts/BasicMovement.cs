using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public Transform bob;
    private Vector3 targetPos;
    public float speed = 17;
    [SerializeField]
    MeshRenderer mr;
    [SerializeField]
    Material defaultMaterial;
    [SerializeField]
    Material selectedMaterial;

    void Start()
    {
        targetPos = bob.position;
        mr.material = defaultMaterial;
    }


    void Update()
    {
        bob.position = Vector3.Lerp(bob.position, targetPos, speed * Time.deltaTime);
    }

    void OnTouchStay(Vector3 point)
    {
        targetPos = new Vector3(point.x, bob.position.y, 0);
        mr.material = selectedMaterial;
    }

    void OnTouchDown(Vector3 point)
    {
        targetPos = new Vector3(point.x, bob.position.y, 0);
        mr.material = selectedMaterial;
    }

    void OnTouchMoved(Vector3 point)
    {
        targetPos = new Vector3(point.x, bob.position.y, 0);
        mr.material = selectedMaterial;
    }

    void OnTouchUp(Vector3 point)
    {
        mr.material = defaultMaterial;
    }
}
