using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UI 관련 라이브러리 사용할래~
using UnityEngine.UI;
//씬 관리 관련 라이브러리 사용할래~
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //게임오버시 활성화할 텍스트 게임 오브젝트
    public GameObject gameOverText;
    //생존 시간을 표시할 텍스트 컴포넌트
    public Text timeText;
    //최고 기록을 표시할 텍스트 캄퍼난ㅌ,
    public Text recordText;

    //생존시간
    private float surviveTime;
    //게임오버 상태
    private bool isGameover;

    // Start is called before the first frame update
    void Start()
    {
        //생존 시간과 게임오버 상태 초기화
        surviveTime = 0f;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        //게임오버가 아닌 동안
        if (!isGameover)
        {
            //생존 시간 갱신
            surviveTime += Time.deltaTime;
            //갱신한 생존 시간을 timeText
            //컴포넌트를 이용해 표시
            timeText.text = "Time :" + (int)surviveTime;

        }
    }
    //현재 게임을 게임오버 상태로 변경하는 메서드
    public void EndGame()
    {
        isGameover = true;
   
    }
}    
    