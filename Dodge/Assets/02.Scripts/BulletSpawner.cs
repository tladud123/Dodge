using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    //������ ź���� ���� ������
    public GameObject bulletPrefab;
    //�ּ� ���� �ֱ�
    public float spawnRateMin = 0.5f;
    //�ִ� ���� �ֱ�
    public float spawnRateMax = 3f;

    //���� ���� �ֱ�
    private float spawnRate;
    //�ֱ� ���� �������� ���� �ð�
    private float timeAfterSpawn;

    //�߻��� ���
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0;
        //ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� �� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);


        //PlayerControll ������Ʈ�� ���� ���� ������Ʈ�� ã�Ƽ� �� ������Ʈ�� ��ġ���� ������
        target = FindObjectOfType<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        //timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        //�ֱ� ���� ������������ ������ �ð���
        //���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            //bulletPretfab�� �������� transform.position
            //��ġ�� transform.rotation�� ȸ������ ����

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);


            //������ bullet���� ������Ʈ�� ���� ������
            //target�� ���ϵ��� ȸ��
            bullet.transform.LookAt(target);


            //������ ���� ������ spawnReteMin, spawnReteMax ���̿��� ���� ����
            spawnRate = Random.Range(spawnRateMin, spawnRateMax);

            //������ �ð��� ����
            timeAfterSpawn = 0f;


        }
    }
}