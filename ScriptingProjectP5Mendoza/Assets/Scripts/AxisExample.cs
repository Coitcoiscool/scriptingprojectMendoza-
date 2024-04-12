using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class AxisExample : MonoBehaviour
{
    // Start is called before the first frame update
    public float range;
   
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("Value returned" + h.ToString("F2"));
    }
}
