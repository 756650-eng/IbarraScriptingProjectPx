using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awaking : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        Debug.Log("Awake called");
    }
}
