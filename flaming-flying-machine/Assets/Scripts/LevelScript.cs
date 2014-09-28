using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;

public class LevelScript : MonoBehaviour
{
		public GameObject[] enemies;
		public GameObject player;
		private const float tick = 117.1875f;
		private Queue spawnSequence;
		private float timer;
	
		private bool LoadLevelSequence ()
		{

				spawnSequence = new Queue ();
				// Handle any problems that might arise when reading the text

				string line;
				// Create a new StreamReader, tell it which file to read and what encoding the file
				// was saved as
				StreamReader theReader = new StreamReader (Application.dataPath + "/Levels/1.txt", Encoding.Default);
			
				// Immediately clean up the reader after this block of code is done.
				// You generally use the "using" statement for potentially memory-intensive objects
				// instead of relying on garbage collection.
				// (Do not confuse this with the using directive for namespace at the 
				// beginning of a class!)
				using (theReader) {
						// While there's lines left in the text file, do this:
						do {
								line = theReader.ReadLine ();
					
								if (line != null) {
										// Do whatever you need to do with the text line, it's a string now
										// In this example, I split it into arguments based on comma
										// deliniators, then send that array to DoStuff()
										string[] entries = line.Split (':');
										if (entries.Length > 0)
												for (int i = 0; i < entries.Length; i++) {
														spawnSequence.Enqueue (int.Parse (entries [i]));
												}
								}
						} while (line != null);
				
						// Done reading, close the reader and return true to broadcast success    
						theReader.Close ();
						return true;
						
				}
		
				// If anything broke in the try block, we throw an exception with information
				// on what didn't work

		}

		void Start ()
		{
				timer = 0.0f;
				LoadLevelSequence ();
				

		}

		void SpawnEnemy ()
		{
				if (spawnSequence.Count > 0) {
						if (((int)spawnSequence.Peek () * tick) / 1000f <= timer) {
								spawnSequence.Dequeue ();
								int enemyType = (int)spawnSequence.Dequeue () % enemies.Length;
								int randomXMin = (int)spawnSequence.Dequeue ();
								int randomXMax = (int)spawnSequence.Dequeue ();

								Vector3 spawnPosition = new Vector3 (Random.Range (randomXMin, randomXMax), 16f, 0f);
								GameObject newEnemy = (GameObject)Instantiate (enemies [enemyType], spawnPosition, Quaternion.identity);
								newEnemy.GetComponent<EnemyShooting> ().player = player;
								if (newEnemy.GetComponent<CreateRotatorChilds> ()) {
										newEnemy.GetComponent<CreateRotatorChilds> ().player = player;
								}
						}
				}
		}

		// Update is called once per frame
		void Update ()
		{
				timer += Time.deltaTime;
				if (!player) {
						Application.LoadLevel (0);		
				} else {
						SpawnEnemy ();
				}
		}	
	
}
