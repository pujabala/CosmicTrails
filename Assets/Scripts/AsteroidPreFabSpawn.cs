using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidPreFabSpawn : MonoBehaviour
{
    public GameObject prefab;
    private Vector2 SpawnPosition;
    private bool random;
    private Transform temppos;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition = new Vector2(23f,5f);
        //Instantiate(prefab,SpawnPosition, Quaternion.identity);
        StartCoroutine(prefabSpawnning());
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnSpawnPreFab(){
        if(random){
            float y = Random.Range(1f,9f);
            Instantiate(prefab,new Vector2(27.0f,y), Quaternion.identity);
        }
        else{
            Instantiate(prefab,SpawnPosition, Quaternion.identity);
            random = true;
        }
        
    }

    IEnumerator prefabSpawnning(){
        while (true){
            yield return new WaitForSeconds(Random.Range(0.5f,2.0f));
            OnSpawnPreFab();
        }
    }

    //TO DO
    //Add the onspawn function into update
    //Random time spawn
    //creation and destroy
    //avoid null errors.
}
