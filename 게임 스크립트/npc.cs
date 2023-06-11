using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc : MonoBehaviour
{
    [SerializeField] private string npc1; // X의 이름

    [SerializeField] private float walkSpeed;  // 걷기 속력

    private Vector3 direction;  // 방향

    // 상태 변수
    private bool isAction;  // 행동 중인지 아닌지 판별
    private bool isWalking; // 걷는지, 안 걷는지 판별


    [SerializeField] private float walkTime;  // 걷기 시간
    [SerializeField] private float waitTime;  // 대기 시간
    private float currentTime;

    // 필요한 컴포넌트
    //[SerializeField] private Animator anim;
    [SerializeField] private Rigidbody rigidl;
    [SerializeField] private CapsuleCollider boxCol;

    void Start()
    {
        currentTime = waitTime;   // 대기 시작
        isAction = true;   // 대기도 행동
    }

    void Update()
    {
        Move();
        Rotation();
        ElapseTime();
    }

    private void Move()
    {
        if (isWalking)
            rigidl.MovePosition(transform.position + transform.forward * walkSpeed * Time.deltaTime);
    }

    private void Rotation()
    {
        if (isWalking)
        {
            Vector3 _rotation = Vector3.Lerp(transform.eulerAngles, direction, 0.01f);
            rigidl.MoveRotation(Quaternion.Euler(_rotation));
        }
    }

    private void ElapseTime()
    {
        if (isAction)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)  // 랜덤하게 다음 행동을 개시
                ReSet();
        }
    }

    private void ReSet()  // 다음 행동 준비
    {
        isWalking = false;
        isAction = true;

        direction.Set(0f, Random.Range(0f, 360f), 0f);

        RandomAction();
    }

    private void RandomAction()
    {
        TryWalk();
        //int _random = Random.Range(0, 4); // 대기, 풀뜯기, 두리번, 걷기

        //if (_random == 0)
        //    Wait();
        //else if (_random == 1)
        //    Eat();
        //else if (_random == 2)
        //    Peek();
        //else if (_random == 3)
        //    TryWalk();
    }

    private void Wait()  // 대기
    {
        currentTime = waitTime;
        Debug.Log("대기");
    }

    private void Eat()  // 풀 뜯기
    {
        currentTime = waitTime;
        Debug.Log("풀 뜯기");
    }

    private void Peek()  // 두리번
    {
        currentTime = waitTime;
        Debug.Log("두리번");
    }

    private void TryWalk()  // 걷기
    {
        currentTime = walkTime;
        isWalking = true;
        //Debug.Log("걷기");
    }
}
