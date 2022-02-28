using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   //�̵��� ����� ������ٵ� ������Ʈ
    private Rigidbody bulletRigdbody;
    // Start is called before the first frame update
    //ź�� �̵� �ӷ�
    public float speed = 8f;
    void Start()
    {
        //���� ������Ʈ���� Rigdbody ������Ʈ�� ã�� bulletRigdbody�� �Ҵ�
        bulletRigdbody = GetComponent<Rigidbody>();

        //������ٵ��� �ӵ� = ���� ���� * �̵� �ӷ�;
        bulletRigdbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);


    }

    //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �޼���
    private void OnTriggerEnter(Collider other)
    {
        //�浿�� ���� ���� ������Ʈ�� player �±׸� ��������?
        if (other.tag == "Player")
        {
            //����(�浿��) ���� ������Ʈ���� playerController ������Ʈ ��������
            PlayerController palyerController = other.GetComponent<PlayerController>();
            //�������κ��� PlayerController ������Ʈ�� �������µ� �����ߴٸ� 
            if(palyerController !=null)
            {
                //playercontroll ������Ʈ�� Die()�޼��� ����
                palyerController.Die();



            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
