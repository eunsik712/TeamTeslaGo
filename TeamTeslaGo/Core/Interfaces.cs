using System;
using System.Collections.Generic;
using OpenCvSharp;

namespace TeamTeslaGo.Core
{
    // [1] 탐지기 설계도 (YOLO 구현체용)
    public interface IDetector : IDisposable
    {
        // 프레임 1장을 주면 -> 찾은 객체 리스트를 내놔라
        List<DetectionResult> Detect(Mat frame);
    }

    // [2] 추적기 설계도 (OpenCV Tracker 구현체용)
    public interface ITracker : IDisposable
    {
        // 추적 시작 (처음 박스 위치 알려주기)
        void Init(Mat frame, Rect initialBox);

        // 다음 프레임에서 위치 찾기 (새 박스 위치 반환)
        Rect Update(Mat frame);
    }

    // [3] 하드웨어 통신 설계도 (Serial 구현체용)
    public interface ICartLink : IDisposable
    {
        bool Connect(string portName, int baudRate); // 연결
        void Disconnect();                           // 해제
        void SendCommand(ControlCmd command);        // 명령 전송

        bool IsConnected { get; }                    // 연결 상태 확인
        event Action<string> OnDataReceived;         // 데이터 수신 이벤트 (로그용)
    }
}