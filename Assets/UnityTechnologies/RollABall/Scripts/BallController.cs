using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;



public class BallController : MonoBehaviour
{
    public float speed;
    public TMP_Text countText;
    public TMP_Text winText;


    private Rigidbody rb;
    private int count;


    Vector3 posInicial;



    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        SetCountText();

        winText.text = "";


        posInicial = this.transform.position;


    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        
        rb.AddForce(movement * speed);
    }

  
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bug"))
        {
            other.gameObject.SetActive(false);

            count = count + 1;

            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Bugs reported: " + count.ToString();


        if (count >= 3)
        {
            winText.text = "Found a blocker X";

            Invoke("Delay", 2);
        }
    }

    public void ResetPosition()
    {
        this.transform.position = posInicial;
    }

    private void Delay()
    {
        SceneManager.LoadScene("Futuro");

    }
}
