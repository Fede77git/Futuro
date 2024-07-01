using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGame1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Game1"))
        {
            SceneManager.LoadScene("bug1");
        }
        else if (other.gameObject.CompareTag("Game2"))
        {
            SceneManager.LoadScene("bug2");

        }
    }

}
