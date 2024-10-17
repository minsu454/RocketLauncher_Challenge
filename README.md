# RocketLauncher 프로젝트

### 1. Action기반 연료바 및 높이 업적 시스템 구현하기
    * PackageManager에서 Input System 임포트 (Clear)
    * Move와 Boost로 구성된 Input Action을 제작하고, Boost는 스페이스바를 더블탭하면 부스터가 적용되도록 구현 (Clear)
    * EnergySystemC클래스와 EnergyDashboardC클래스를 완성하여 연료를 사용할 때 발생하는 event Action OnEnergyChanged를 통해 연료바 시스템 구현(Clear)
    * 매 최고 높이 갱신마다 업적을 체크하는 로직은 과부하를 발생시킬 우려가 있습니다. 이를 개선할 방법을 제안하여 적용

### 2. 팝업 및 간단 업적 시스템 UI 만들기
    * Scroll Rect 구성하고, Grid Layout Group 구성하기(Clear)
    * AchievementView 컴포넌트를 완성하고, AchievementSlot 스크립트를 적용.(Clear)
    * 이미 구성되어 있는 AchievementSO를 활용하여 업적 정보를 불러오고, 클리어 시 체크표시하기 (AchievementView, AchievementSO 클래스 참고)(Clear)

### 3. 로켓 궤적 변경 기능 및 경보 기능 추가하기
    * 삼각함수와 Slerp를 활용하여 A/D키를 통해 궤도가 수정되는 로직을 구현.
    * Vector2.Dot을 활용하여, RocketAlertSystem의 시야각 fov내부에 소행성이 포착되었는지 여부를 검사.
    * 구현사항 2의 소행성(Aesteroid 게임오브젝트)이 포착되었다면 삼각형의 SpriteRenderer가 노란색으로 반짝거리게 애니메이션을 적용하세요(isBlinking).