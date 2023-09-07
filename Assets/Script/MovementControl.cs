using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public float moveSpeed = 10f; // 캐릭터 이동 속도
    

   



    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       

    }

    void Update()
    {
        // 키보드 입력 처리
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // 이동 벡터 계산 및 이동
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;
        rb.velocity = movement;

        // 현재 마우스 포인터 위치를 가져옵니다.
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // 캐릭터의 위치를 2D로 설정합니다.
        Vector3 characterPosition = transform.position;
        characterPosition.z = 0;

        // 마우스 포인터가 캐릭터의 왼쪽에 있는지 오른쪽에 있는지 확인합니다.
        bool mouseIsLeft = mousePosition.x < characterPosition.x;

        // 캐릭터의 스케일을 조절하여 좌우 방향을 변경합니다.
        if (mouseIsLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1); // 캐릭터를 좌측으로 향하게 만듭니다.
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1); // 캐릭터를 우측으로 향하게 만듭니다.
        }
    }
}