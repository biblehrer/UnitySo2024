using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    public GameObject fireballPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(fireballPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(0,0,0);
        if (Input.GetKey("w"))
        {
            movement = movement + new Vector3(0f,1f,0f);
        }
        if (Input.GetKey("s"))
        {
            movement = movement + new Vector3(0f,-1f,0f);
        }
        if (Input.GetKey("a"))
        {
            movement = movement + new Vector3(-1f,0,0f);
        }
        if (Input.GetKey("d"))
        {
            movement = movement + new Vector3(1f,0,0f);
        }

        movement = movement.normalized;

        transform.position = transform.position + movement * Time.deltaTime * 2;
    }
}
