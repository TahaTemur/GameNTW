using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public Character characterScript;
    public GameObject Platform;
    public float width;
    public float height;
    public float minWidth;
    public float time;
   
    
    
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    

    public IEnumerator SpawnObject(float time)
    {   
        while (!characterScript.isDead) 
        {

            Instantiate(Platform, new Vector2(Random.Range(minWidth, width), height), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
}
