using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsteroidSpawner : Asteroid
{
    // Start is called before the first frame update

    public GameObject[] AsteroidRef;
    //public Transform uppos,downpos;7
    public int randomy;
    

    void Start()
    {
        StartCoroutine(SpawnAsts());
        var spawnedAsteroid = (GameObject) Instantiate(AsteroidRef[0]);
        spawnedAsteroid.SetActive(false);
    }


    IEnumerator SpawnAsts(){
        while (true){

            yield return new WaitForSeconds(Random.Range(1,5));

            float y = Random.Range(-3.3f,3.3f);
            //float randSpeed = (float)Random.Range(0.01f,0.02f);

            var spawnedAsteroid = (GameObject) Instantiate(AsteroidRef[0]);
            spawnedAsteroid.SetActive(true);
            spawnedAsteroid.transform.position = new Vector3(15.0f,y,0f);
           
           //spawnedAsteroid.GetComponent<Asteroid>().speed = randSpeed;   

       
        }
    }
}
