using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AArabaHareket : MonoBehaviour
{

    bool oyunbitti = false;
    Rigidbody rb;
    public int puan = 0;
    AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        puan = 0;
        rb = GetComponent<Rigidbody>();
        audioSource = rb.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (oyunbitti == false)
        {
            rb.AddForce(Vector3.left * 15, ForceMode.Force);
        }
        else if (oyunbitti == true)
        {
            rb.velocity = Vector3.zero;
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, 10, ForceMode.Force);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -10, ForceMode.Force);
        }

        if (Input.GetKey("s"))
        {
            rb.velocity *= 0.95f; // Yavaşlatma faktörünü istediğiniz gibi ayarlayabilirsiniz
        }
        if (GetComponent<Rigidbody>().position.x <= -120)
        {
            oyunbitti |= true;
          rb.velocity = Vector3.zero;
           Invoke("Restart", 2f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Engel")
        {

            Invoke("Restart", 2f);
            oyunbitti = true;
            audioSource.Play();
        }
        if (collision.collider.tag == "Para")
        {
             Destroy(collision.gameObject);
            ScoreManager.instance.AddPoint();
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        oyunbitti = false;
        ScoreManager.score = 0;



    }
}
