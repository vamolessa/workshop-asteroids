using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnarCirculo : MonoBehaviour
{
    public GameObject prefabCirculo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(prefabCirculo, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
        }
    }
}
