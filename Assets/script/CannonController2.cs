using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController2 : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 2;

    private AudioSource audioSource;

    public GameObject Cannonball;
    public Transform ShotPoint;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float VericalRotation = Input.GetAxis("Vertical");

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + 
            new Vector3(VericalRotation * rotationSpeed,0,0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            audioSource.Play();

            GameObject CreatedCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            CreatedCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;

            
        }
        
    }
}
