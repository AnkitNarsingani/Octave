using UnityEngine;

public class DestroyParticle : MonoBehaviour
{


    void Update()
    {
        Destroy(this.gameObject, 0.11f);
    }
}
