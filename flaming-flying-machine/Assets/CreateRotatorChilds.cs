using UnityEngine;
using System.Collections;

public class CreateRotatorChilds : MonoBehaviour
{

		public GameObject player;
		public GameObject rotatorChild;
		private ArrayList childs;
		private int aliveChilds;
		private int aliveAndKicking;
		
		// Use this for initialization
		void Start ()
		{
				childs = new ArrayList ();
				for (int i = 1; i < 4; i++) {
						GameObject child = (GameObject)Instantiate (rotatorChild, gameObject.transform.position, Quaternion.identity);
						child.GetComponent<OrbitAroundParent> ().index = i;
						child.GetComponent<OrbitAroundParent> ().parent = gameObject;
						child.GetComponent<EnemyShooting> ().player = player;
						childs.Add (child);
						aliveChilds = i;
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
				aliveAndKicking = 0;
				foreach (GameObject child in childs) {
						if (child.gameObject) {
								aliveAndKicking++;
						}
				}
				if (aliveAndKicking < 1) {
						// delay for slight epicness
						Destroy (this.gameObject, 0.1f);
				}
		}
}