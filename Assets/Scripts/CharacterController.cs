using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(50, 0, 0);
        }else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-50, 0, 0);
        }



    }
}
