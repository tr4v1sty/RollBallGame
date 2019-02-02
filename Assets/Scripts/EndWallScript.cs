using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndWallScript : MonoBehaviour
{
    private int count = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            count++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
