using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float jumpGlobal;
    
    public Text countText;

    public Text winText;

    private bool isGrounded = false;

    private Rigidbody rb;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float jump;

        if (Input.GetKeyDown(KeyCode.Space)) {
            jump = jumpGlobal;
        }
        else{
            jump = 0;
        }
        Vector3 movement = new Vector3(moveHorizontal, jump, moveVertical);

        if (isGrounded == true) {
            rb.AddForce(movement * speed);
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
            Score.Set(1);
            SetCountText();
        }
    }
    void SetCountText() {

        countText.text = "Count: " + Score.Get().ToString();

        if (Score.Get() >= 12) {
            winText.text = "You win";
        }

    }

    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Terrain") {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Terrain") {
            isGrounded = false;
        }
    }
}


