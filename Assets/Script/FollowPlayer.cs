using UnityEngine;

public class 카메라추적 : MonoBehaviour
{
    public Transform 캐릭터; // 카메라가 따라갈 캐릭터의 Transform

    private Vector3 offset; // 카메라와 캐릭터 간의 거리

    void Start()
    {
        // 초기 카메라와 캐릭터 간의 거리 계산
        offset = transform.position - 캐릭터.position;
    }

    void LateUpdate()
    {
        // 카메라 위치를 캐릭터 위치에 맞게 업데이트
        transform.position = 캐릭터.position + offset;
    }
}