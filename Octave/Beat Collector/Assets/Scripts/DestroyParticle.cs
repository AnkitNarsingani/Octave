using UnityEngine;

public class DestroyParticle : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, 0.11f);
	}
}
