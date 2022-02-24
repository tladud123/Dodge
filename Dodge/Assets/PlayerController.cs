using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody PlayerRigidbody;
    public float speed = 8f;

    public GameObject my;
    private void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            PlayerRigidbody.AddForce(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            PlayerRigidbody.AddForce(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            PlayerRigidbody.AddForce(speed, 0f, 0f);
        }



    }
    void Update()
    {
        float xInput = Input.GetAxis("Horizontla");

        float ZInput = Input.GetAxis("Vertical");



    }


    void Die()
    {
        my.SetActive(false);
    }

}
