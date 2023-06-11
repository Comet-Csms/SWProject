using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public static class CameraSwitcher 
{
    static List<CinemachineVirtualCamera> cameras = new List<CinemachineVirtualCamera>(); //�ó׸ӽ� ����ī�޶� ��� ����Ʈ ����

    public static CinemachineVirtualCamera ActiveCamera = null; //Ȱ��ȭ�� ī�޶�

    public static bool IsActiveCamera(CinemachineVirtualCamera camera) // �Ű������� ���� ����ī�޶� Ȱ���� ī�޶����� üũ
    {
        return camera == ActiveCamera;
    }
    public static void SwitchCamera(CinemachineVirtualCamera camera) // mainī�޶� �Ű������� ī�޶�� �ٲ��ִ� �Լ�
    {
        camera.Priority = 10; // �Ű������� ���� ����ī�޶��� Priority�� ����( ���� Ŭ ���� �켱������ ī�޶��̴�)
        ActiveCamera = camera; // �Ű������� ���� ī�޶� Ȱ��ȭ

        foreach (CinemachineVirtualCamera c in cameras) //foreach������ ����Ʈ���� ī�޶���� ���� Ž���� ��
        {
            if (c != camera && c.Priority != 0) //����Ʈ�ȿ� ���� ������ Priority���� �ִ� �ֵ��� ���� 0���� �����. == ��Ȱ��ȭ
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
