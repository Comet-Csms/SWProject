using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CameraSwitcher 
{
    static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>(); //시네머신 가상카메라를 담는 리스트 선언

    public static CinemachineVirtualCamera ActiveCamera = null; //활성화된 카메라

    public static bool IsActiveCamera(CinemachineVirtualCamera camera) // 매개변수로 들어온 가상카메라가 활성된 카메라인지 체크
    {
        return camera == ActiveCamera;
    }
    public static void SwitchCamera(CinemachineVirtualCamera camera) // main카메라를 매개변수의 카메라로 바꿔주는 함수
    {
        camera.Priority = 10; // 매개변수로 들어온 가상카메라의 Priority값 조정( 값이 클 수록 우선순위의 카메라이다)
        ActiveCamera = camera; // 매개변수로 들어온 카메라를 활성화

        foreach (CinemachineVirtualCamera c in cameras) //foreach문으로 리스트내의 카메라들을 전부 탐색한 후
        {
            if (c != camera && c.Priority != 0) //리스트안에 없는 주제에 Priority값이 있는 애들은 전부 0으로 만든다. == 비활성화
            {
                c.Priority = 0;
            }
        }
    }
     public static void Resister(CinemachineVirtualCamera camera)
    {
        cameras.Add(camera);
    }

    public static void Unresister(CinemachineVirtualCamera camera)
    {
        cameras.Remove(camera);
    }

}
