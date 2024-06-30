using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class BulletBug : MonoBehaviour
{

    public TMP_Text countText;
    public TMP_Text winText;
    private int count;
    private void Start()
    {
        count = 0;

        SetCountText();

        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
           
            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Bugs reported: " + count.ToString();


        if (count >= 2)
        {
            winText.text = "Found all bugs";

            Invoke("Delay", 2);
        }
    }

    private void Delay()
    {
        SceneManager.LoadScene("Futuro");

    }
}
