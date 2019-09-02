using UnityEngine;

public class LevelMove : MonoBehaviour {

    [SerializeField]
    Vector3 velocity = new Vector3(0, -6f,0);
    void Update ()
    {
        transform.SetPositionAndRotation(this.gameObject.transform.position + velocity, Quaternion.identity);
	}
}
