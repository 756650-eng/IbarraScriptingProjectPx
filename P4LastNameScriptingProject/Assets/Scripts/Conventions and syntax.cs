using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conventionsandsyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to tell me the x postion of mty object
        Debug.Log(transform.position.x);


    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm aboout to hit the ground!");
        }
        
    }
}
