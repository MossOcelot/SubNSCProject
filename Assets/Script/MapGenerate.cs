using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerate : MonoBehaviour
{
    public GameObject[] objects;

    private void Start()
    {
        int show = Random.Range(0, 2);
        if(show != 0)
        {
            int rand = Random.Range(0, objects.Length);
            Instantiate(objects[rand], transform.position, Quaternion.identity);
        } else
        {
            gameObject.SetActive(false);
        }
        
    }
}
