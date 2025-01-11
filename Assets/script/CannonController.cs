using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 1;

    

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalRotation = Input.GetAxis("Horizontal");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
            new Vector3(0, HorizontalRotation * rotationSpeed,0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Screenshake.ShakeAmount = 1;
        }
        
    }
}
