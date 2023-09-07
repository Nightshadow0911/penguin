using UnityEngine;
using UnityEngine.UI;
using System;

public class CurrentTimeUI : MonoBehaviour
{
    public Text currentTimeText; // UI �ؽ�Ʈ ��ҿ� ���� ����

    private void Start()
    {
        // ���� ��¥�� �ð��� �����ɴϴ�.
        DateTime currentTime = DateTime.Now;

        // ���� �ð��� �ؽ�Ʈ�� ��ȯ�Ͽ� UI �ؽ�Ʈ�� ǥ���մϴ�.
        currentTimeText.text = "���� �ð�: " + currentTime.ToString("HH:mm");
    }
}