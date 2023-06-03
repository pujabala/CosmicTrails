using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPrefab : MonoBehaviour
{
    public GameObject prefab;
    private Vector2 SpawnPosition;
    private bool random;
    //private Transform temppos;
    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition = new Vector2(21f,0f);
        //Instantiate(prefab,SpawnPosition, Quaternion.identity);
        StartCoroutine(prefabSpawnning());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSpawnPreFab(){
        if(random){
            float y = Random.Range(1.0f,9.0f);
            //temppos = new Vector2(15.0f,y,0);
            Instantiate(prefab,new Vector2(27.0f,y), Quaternion.identity);
        }
        else{
            Instantiate(prefab,SpawnPosition, Quaternion.identity);
            random = true;
        }
        
    }

    IEnumerator prefabSpawnning(){
        while (true){
            yield return new WaitForSeconds(Random.Range(1,5));
            OnSpawnPreFab();
        }
    }

    //TO DO
    //Add the onspawn function into update
    //Random time spawn
    //creation and destroy
    //avoid null errors.
}
