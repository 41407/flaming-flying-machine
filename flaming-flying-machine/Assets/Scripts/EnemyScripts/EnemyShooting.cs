using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
	public float projectile;
	public float firingDelay;
	private float firingTimer = 0;

	void update() {
		if (firingTimer >= firingDelay) {
			shoot();		
		}
	}

	void shoot() {
		GameObject bullet = Instantiate (projectile, this.gameObject.transform.position, Quaternion.identity);

	}
}
