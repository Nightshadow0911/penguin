using UnityEngine;
using UnityEngine.UI;
using System;

public class CurrentTimeUI : MonoBehaviour
{
    public Text currentTimeText; // UI 텍스트 요소에 대한 참조

    private void Start()
    {
        // 현재 날짜와 시간을 가져옵니다.
        DateTime currentTime = DateTime.Now;

        // 현재 시간을 텍스트로 변환하여 UI 텍스트에 표시합니다.
        currentTimeText.text = "현재 시간: " + currentTime.ToString("HH:mm");
    }
}