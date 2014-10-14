using UnityEngine;
using System.Collections;

public class CreateRotatorChilds : MonoBehaviour
{

		public GameObject player;
		public GameObject rotatorChild;
		private ArrayList childs;
		private int aliveChilds;
		public bool killIfChildsDie = true;
		
		// Use this for initialization
		void Start ()
		{
				childs = new ArrayList ();
				for (int i = 1; i < 4; i++) {
						GameObject child = (GameObject)Instantiate (rotatorChild, transform.position, Quaternion.identity);
						child.GetComponent<OrbitAroundParent> ().index = i;
						child.GetComponent<OrbitAroundParent> ().parent = gameObject;
						if (child.GetComponent<BurstTowardsPlayer> ()) {
								child.GetComponent<BurstTowardsPlayer> ().player = player;
						}
						childs.Add (child);
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (killIfChildsDie) {
						aliveChilds = 0;
						foreach (GameObject child in childs) {
								if (child.gameObject) {
										aliveChilds++;
								}
						}
						if (aliveChilds < 1) {
								// delay for slight epicness
								Destroy (this.gameObject, 0.1f);
						}
				}
		}
}