using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimtTemperature = 70.0f;
    float coldLimtTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
         
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
}
// If the coffee's temperature is greater than the hottest drinking temperature
  if (coffeeTemperature > hotLimtTemperature) 
  {
    // ... do this.
   print("Coffee is too hot.");

  }

//if it isn't, but the coffe temperaature is less than the coldest temperature...
else if ( ()
{
    
}
 