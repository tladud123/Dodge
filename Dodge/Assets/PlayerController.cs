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
    void Directinput()
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
    {   //수평축과 수직축의 입력값을 감지해서 저장
        float xInput = Input.GetAxis("Horizontal");
        //키보드 'A'.<- :음의 방향 : -1.0f
        float ZInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;

        float zSpeed = ZInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);

        PlayerRigidbody.velocity = newVelocity;


    }


    public void Die()
    {
        my.SetActive(false);
    }

}
