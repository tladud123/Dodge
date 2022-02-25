using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   //이동에 사용할 리지드바디 컴포넌트
    private Rigidbody bulletRigdbody;
    // Start is called before the first frame update
    //탄알 이동 속력
    public float speed = 8f;
    void Start()
    {
        //게임 오브젝트에서 Rigdbody 컴포넌트를 찾아 bulletRigdbody에 할당
        bulletRigdbody = GetComponent<Rigidbody>();

        //리지드바디의 속도 = 앞쪽 방향 * 이동 속력;
        bulletRigdbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);


    }

    //트리거 충돌 시 자동으로 실행되는 메서드
    private void OnTriggerEnter(Collider other)
    {
        //충동한 상대방 게임 오브젝트가 player 태그를 가졌나요?
        if (other.tag == "Player")
        {
            //상대방(충동한) 게임 오브젝트에서 playerController 컴포넌트 가져오기
            PlayerController palyerController = other.GetComponent<PlayerController>();
            //상대방으로부터 PlayerController 컴포넌트를 가져오는데 성공했다면 
            if(palyerController !=null)
            {
                //playercontroll 컴포넌트의 Die()메서드 실행
                palyerController.Die();



            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
