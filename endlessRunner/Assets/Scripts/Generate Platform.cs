using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawner : MonoBehaviour
{
    public Character characterScript;
    public GameObject Platform;
    public float maxWidth;
    public float minWidth;
    public float maxHeight;
    public float minHeight;
    public float time;
   
    
    
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    

    public IEnumerator SpawnObject(float time)
    {   
        while (!characterScript.isDead) 
        {

            Instantiate(Platform, new Vector2(Random.Range(minWidth, maxWidth),Random.Range(minHeight, maxHeight)), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        
    }
}
