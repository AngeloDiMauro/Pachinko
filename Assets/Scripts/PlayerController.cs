using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public float verticalInput;
    public float leftSide = 32;
    public float rightSide = 30;
    public float topLimit = 5;
    public float bottomLimit = 3;
    
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // Move balls left and right

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);

        // Move balls up and down
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * verticalInput * Time.deltaTime * speed);

        // Limits ball position within bounds before dropped

        if (transform.position.z < -leftSide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -leftSide);
        }

        if (transform.position.z > rightSide)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rightSide);
        }

        if (transform.position.y < -bottomLimit)
        {
            transform.position = new Vector3(transform.position.x, -bottomLimit, transform.position.z);
        }

        if (transform.position.y > topLimit)
        {
            transform.position = new Vector3(transform.position.x, topLimit, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(CompareTag("Gold"))
            {
                Debug.Log("gold enters");
            }
        }
    }
}
