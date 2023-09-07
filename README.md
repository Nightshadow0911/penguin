# 펭귄이 움직일뿐인 프로그램

## 기능 구현내용


1. 캐릭터의 이동 및 얼굴 방향
   
float horizontalInput = Input.GetAxis("Horizontal");

float verticalInput = Input.GetAxis("Vertical");

을 통해 캐릭터의 이동 방향을 입력받고 이동하는 기능과


마우스 위치를 인식하게 만든 후

bool mouseIsLeft = mousePosition.x < characterPosition.x;

if (mouseIsLeft)

{

    transform.localScale = new Vector3(-1, 1, 1);

}

else

{

    transform.localScale = new Vector3(1, 1, 1);

}

위 함수를 통해 마우스 포인터를 향해 캐릭터의 얼굴이 향하도록 했습니다.


2. 맵 만들기 및 벽 충돌
 
   다운받은 에셋을 타일 팔레트에 등록해서 타일 맵을 작성.

   바닥과 벽을 분리하고 벽에 콜라이더를 추가하고

   캐릭터에는 collider와 rigid body를 추가하여 충돌 시 멈출 수 있게 하였지만 이것만으로는 지속적인 키보드 입력 시 관통하는 현상이 있습니다.

   rb = GetComponent<Rigidbody2D>();와 위에 1번에서 설명한 항목을 통해 캐릭터 움직임에 추가하여 충돌 시 멈추도록 기능합니다.


4. 캐릭터가 움직일때 따라가는 카메라 기능

void Update()

{

    transform.position = 캐릭터.position + offset;

}

를 통해 캐릭터가 움직이면 카메라가 따라가도록 설정했습니다.



5. 캐릭터 애니메이션

   캐릭터 에셋을 다운받을때 같이 있던 애니메이션을 캐릭터에게 넣어줘서 움직임을 보여줍니다.


6. 시간 표시

private void Start()

{

    DateTime currentTime = DateTime.Now;
    
    currentTimeText.text = "현재 시간: " + currentTime.ToString("HH:mm");

}

현재 시간을 데이터를 받아서 출력하도록 설정하였습니다.
