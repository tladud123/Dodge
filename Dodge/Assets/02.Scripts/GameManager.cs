using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI ���� ���̺귯�� ����ҷ�~
using UnityEngine.UI;
//�� ���� ���� ���̺귯�� ����ҷ�~
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //���ӿ����� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public GameObject gameOverText;
    //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text timeText;
    //�ְ� ����� ǥ���� �ؽ�Ʈ į�۳���,
    public Text recordText;

    //�����ð�
    private float surviveTime;
    //���ӿ��� ����
    private bool isGameover;

    // Start is called before the first frame update
    void Start()
    {
        //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        surviveTime = 0f;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ����� �ƴ� ����
        if (!isGameover)
        {
            //���� �ð� ����
            surviveTime += Time.deltaTime;
            //������ ���� �ð��� timeText
            //������Ʈ�� �̿��� ǥ��
            timeText.text = "Time :" + (int)surviveTime;

        }
    }
    //���� ������ ���ӿ��� ���·� �����ϴ� �޼���
    public void EndGame()
    {
        isGameover = true;
   
    }
}    
    