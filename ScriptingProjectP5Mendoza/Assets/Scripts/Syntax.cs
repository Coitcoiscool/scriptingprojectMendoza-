using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this  line is there to tell there to tell me the x position of my object

        /*Hi there!
         * this is two line 
         * */
        Debug.Log(transform.position.x);

        if(transform.position.y <=5f)
        {
            Debug.Log("I'm about hit the ground");
        }
          
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
