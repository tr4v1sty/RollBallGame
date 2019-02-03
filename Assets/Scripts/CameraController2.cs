using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = player.transform.position + offset;
        Camera mycam = GetComponent<Camera>();


        if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        {

            mycam.transform.Rotate(player.transform.position.x + 0.0f, player.transform.position.y + 9.0f, player.transform.position.z + 0.0f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true) {
            
            mycam.transform.Rotate(player.transform.position.x + 0.0f, player.transform.position.y - 9.0f, player.transform.position.z + 0.0f);
        }
    }
}
