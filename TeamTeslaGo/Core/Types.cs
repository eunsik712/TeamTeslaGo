using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamTeslaGo.Core
{
    // [시스템 동작 모드]
    public enum AppMode
    {
        IDLE,       // 대기 (아무것도 안 함)
        TRACK,      // 탐색 (YOLO로 사람 찾는 중)
        RUN,        // 주행 (찾은 타겟을 따라가는 중)
        LOST,       // 분실 (타겟 놓침 -> 정지 or 재탐색)
        STOP,       // 정지 (강제 종료/안전)
        ERROR       // 시스템 에러
    }

    // [추적 알고리즘 종류]
    // OpenCV 트래커들을 상황에 따라 골라 쓰기 위함
    public enum TrackerType
    {
        KCF,        // 빠름, 가림에 약함 (기본 추천)
        CSRT,       // 정확함, 느림 (PC 사양 좋으면 추천)
        MOSSE,      // 매우 빠름, 정확도 낮음
        MIL,        // 무난함
        YOLO_ONLY   // 트래커 안 쓰고 매 프레임 YOLO 돌리기 (가장 정확하나 무거움)
    }
}