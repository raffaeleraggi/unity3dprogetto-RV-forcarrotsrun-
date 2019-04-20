using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnScript : MonoBehaviour {
   public GameObject Carrot, Carrot1, Carrot2, Carrot3, Carrot4, CarrotBig, CarrotSpeedD;


	 public float spawnRate = 2f;

	 float nextSpawn = 0f;

	 int whatToSpawn;


	void Update () {

		if(Time.time > nextSpawn){
			whatToSpawn = Random.Range (1,8);

			switch (whatToSpawn){

				case 1:
				  Instantiate (Carrot,transform.position, Quaternion.identity);
					break;

				case 2:
					  Instantiate (Carrot1, transform.position, Quaternion.identity);
						break;

				case 3:
						  Instantiate (Carrot2, transform.position, Quaternion.identity);
							break;

				case 4:
							  Instantiate (Carrot3, transform.position, Quaternion.identity);
								break;

				case 5:
								Instantiate (Carrot4, transform.position, Quaternion.identity);
									break;

        case 6:
                Instantiate (CarrotBig, transform.position, Quaternion.identity);
                 break;
        case 7:
                Instantiate (CarrotSpeedD, transform.position, Quaternion.identity);
                 break;


			}

			nextSpawn = Time.time + spawnRate;

     }


	}
}
