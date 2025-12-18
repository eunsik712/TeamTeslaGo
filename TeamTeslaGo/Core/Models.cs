using OpenCvSharp; // Rect, Point 사용을 위해 필수

namespace TeamTeslaGo.Core
{
    // [1] YOLO가 찾아낸 객체 정보 (B -> C)
    public class DetectionResult
    {
        public int Id { get; set; }           // 추적 ID (몇 번 사람인가)
        public string? Label { get; set; }     // "person" 등
        public float Confidence { get; set; } // 정확도 (0.0 ~ 1.0)
        public Rect BBox { get; set; }        // 위치 (x, y, w, h)

        // 박스의 중심점 (RC카 조향 계산할 때 이 좌표를 씁니다)
        public Point Center => new Point(BBox.X + BBox.Width / 2, BBox.Y + BBox.Height / 2);
    }

    // [2] PC가 아두이노에게 보낼 명령 (Logic -> A)
    public class ControlCmd
    {
        public int Steer { get; set; }    // 조향 (-100:좌, 0:직진, 100:우)
        public int Throttle { get; set; } // 속도 (-100:후진, 0:정지, 100:전진)
        public AppMode Mode { get; set; } // 현재 모드

        // 아두이노가 받을 문자열 프로토콜 ("DRV,조향,속도")
        // 예: DRV,-30,50 (왼쪽 30만큼 꺾고 속도 50으로 전진)
        public override string ToString()
        {
            return $"DRV,{Steer},{Throttle}";
        }
    }

    // [3] 아두이노 상태 정보 (A -> UI)
    public class CartStatus
    {
        public bool IsConnected { get; set; }    // 연결 여부
        public string? PortName { get; set; }     // "COM3" 등
        public float BatteryLevel { get; set; }  // 배터리 잔량 (%)
        public string? LastLog { get; set; }      // 마지막 수신 메시지
    }
}