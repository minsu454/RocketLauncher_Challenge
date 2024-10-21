# RocketLauncher 프로젝트

### 1-1. Action기반 연료바 및 높이 업적 시스템 구현하기
    * PackageManager에서 Input System 임포트 (Clear)
    * Move와 Boost로 구성된 Input Action을 제작하고, Boost는 스페이스바를 더블탭하면 부스터가 적용되도록 구현 (Clear)
    * EnergySystemC클래스와 EnergyDashboardC클래스를 완성하여 연료를 사용할 때 발생하는 event Action OnEnergyChanged를 통해 연료바 시스템 구현(Clear)
    * 매 최고 높이 갱신마다 업적을 체크하는 로직은 과부하를 발생시킬 우려가 있습니다. 이를 개선할 방법을 제안하여 적용

### 1-2. 팝업 및 간단 업적 시스템 UI 만들기
    * Scroll Rect 구성하고, Grid Layout Group 구성하기 (Clear)
    * AchievementView 컴포넌트를 완성하고, AchievementSlot 스크립트를 적용. (Clear)
    * 이미 구성되어 있는 AchievementSO를 활용하여 업적 정보를 불러오고, 클리어 시 체크표시하기 (AchievementView, AchievementSO 클래스 참고) (Clear)

### 1-3. 로켓 궤적 변경 기능 및 경보 기능 추가하기
    * 삼각함수와 Slerp를 활용하여 A/D키를 통해 궤도가 수정되는 로직을 구현. (Clear)
    * Vector2.Dot을 활용하여, RocketAlertSystem의 시야각 fov내부에 소행성이 포착되었는지 여부를 검사. (Clear)
    * 구현사항 2의 소행성(Aesteroid 게임오브젝트)이 포착되었다면 삼각형의 SpriteRenderer가 노란색으로 반짝거리게 애니메이션을 적용하세요(isBlinking). (Clear)

### 2-1 Input Rebinding
    * Input System을 import하고, Input Action Challenge를 구성 (Clrear)
    * InputRebinder클래스의 actionAsset에서 Space 액션을 찾고 활성화 (Clear)
    * InputRebinder클래스의 RebindSpaceToEscape 메서도를 ContextMenu 어트리뷰트를 활용해서 인스펙터창에서 우클릭으로 실행 (Clear)
    *InputRebinder 클래스의 RebindSpaceToEscape 함수는 기존 spacebar 키를 입력하던 액션을 Escape키를 입력했을 때 발생 (Clear)

### 2-2 Generic Singleton
    * Instance 프로퍼티의 get부분을 완성하세요. 이때 다양한 문제 상황에 대한 대응을 포함해야 함
    * Singleton<T>를 상속받는 컴포넌트를 포함한 게임오브젝트는 다른 씬으로 넘어가도 파괴되지 않게 설정(누군가의 자식일 때는 이에 대한 루트 컴포넌트 전체가 해당 특성이 적용)]
    * Singleton<T>를 상속받는 AudioManager를 처음부터 구현하세요. 간단한 bgm을 플레이 하도록 설정

### 2-3 Object Pool 끝장보기
    * 최소 50개의 오브젝트 수 보장, 부족할 경우 누적 300개까지 추가 생성, 300개가 넘어갈 경우 임시로 생성 후 반환시 파괴
    * 최소 50개의 오브젝트 수 보장, 부족할 경우 누적 300개까지 추가 생성, 300개가 넘어갈 경우 가장 오래전에 생성된 오브젝트를 반환 후 재사용
    * 오브젝트를 미리 생성하지 않고 부족할 경우 누적 100개까지 추가 생성, 100개가 넘어갈 경우 임시로 생성 후 반환시 파괴
    * 이 중 하나를 UnityEngine.Pool을 활용하여 구현

