using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControl : MonoBehaviour
{
    public float moveSpeed = 10f; // ĳ���� �̵� �ӵ�
    

   



    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       

    }

    void Update()
    {
        // Ű���� �Է� ó��
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // �̵� ���� ��� �� �̵�
        Vector2 movement = new Vector2(horizontalInput, verticalInput) * moveSpeed;
        rb.velocity = movement;

        // ���� ���콺 ������ ��ġ�� �����ɴϴ�.
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // ĳ������ ��ġ�� 2D�� �����մϴ�.
        Vector3 characterPosition = transform.position;
        characterPosition.z = 0;

        // ���콺 �����Ͱ� ĳ������ ���ʿ� �ִ��� �����ʿ� �ִ��� Ȯ���մϴ�.
        bool mouseIsLeft = mousePosition.x < characterPosition.x;

        // ĳ������ �������� �����Ͽ� �¿� ������ �����մϴ�.
        if (mouseIsLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1); // ĳ���͸� �������� ���ϰ� ����ϴ�.
        }
        else
        {
            transform.localScale = new Vector3(1, 1, 1); // ĳ���͸� �������� ���ϰ� ����ϴ�.
        }
    }
}