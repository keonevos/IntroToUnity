using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedInMeterPerSecond = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lInputVector = new Vector3(0.0f, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("KeyCode.W");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (SpeedInMeterPerSecond * Time.deltaTime) );
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("KeyCode.S");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (SpeedInMeterPerSecond * Time.deltaTime) );
        }

        // On ecoute les Input
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("KeyCode.A");
            transform.position = new Vector3(transform.position.x - (SpeedInMeterPerSecond * Time.deltaTime), transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("KeyCode.D");
            transform.position = new Vector3(transform.position.x + (SpeedInMeterPerSecond * Time.deltaTime), transform.position.y, transform.position.z);
        }


    }
}
