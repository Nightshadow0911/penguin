using UnityEngine;

public class ī�޶����� : MonoBehaviour
{
    public Transform ĳ����; // ī�޶� ���� ĳ������ Transform

    private Vector3 offset; // ī�޶�� ĳ���� ���� �Ÿ�

    void Start()
    {
        // �ʱ� ī�޶�� ĳ���� ���� �Ÿ� ���
        offset = transform.position - ĳ����.position;
    }

    void LateUpdate()
    {
        // ī�޶� ��ġ�� ĳ���� ��ġ�� �°� ������Ʈ
        transform.position = ĳ����.position + offset;
    }
}