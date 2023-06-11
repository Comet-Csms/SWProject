using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera firstPersonCam;
    [SerializeField] CinemachineVirtualCamera thirldPersonCam;
    [SerializeField] Animator _animator;
    public GameObject aimpoint;
   

    public bool third = false;
    public bool first = false;

    private void OnEnable()
    {
        CameraSwitcher.Resister(thirldPersonCam); //3��Ī ī�޶� ���
        CameraSwitcher.Resister(firstPersonCam); // 1��Ī ī�޶� ���
        CameraSwitcher.SwitchCamera(thirldPersonCam); //3��Ī ī�޶� Ȱ��ȭ


    }
    private void OnDisable()
    {
        CameraSwitcher.Unresister(thirldPersonCam); 
        CameraSwitcher.Unresister(firstPersonCam);
    }
    void Update()
    {
       
        if (Input.GetMouseButtonDown(1))
        {
            //ī�޶� ��ȯ
            print("camera switch requested");
            if (CameraSwitcher.IsActiveCamera(firstPersonCam)){
                print("camera switch 3rd");
                CameraSwitcher.SwitchCamera(thirldPersonCam);
                _animator.SetBool("Shoot", false);
                aimpoint.SetActive(false);
                third = true;
                first = false;
}
            else if (CameraSwitcher.IsActiveCamera(thirldPersonCam))
            {
                print("camera switch 1st");
                CameraSwitcher.SwitchCamera(firstPersonCam);
                _animator.SetBool("Shoot", true);
                aimpoint.SetActive(true);
                third = false;
                first = true;
            }
        }

        
       
    }
}
