using UnityEngine;

public class DestroyDelay : MonoBehaviour {

    public float lifeSpan = 3;

	void Start () {
        Destroy(gameObject, lifeSpan);
	}
	
}