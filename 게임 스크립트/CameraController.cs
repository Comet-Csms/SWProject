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
        CameraSwitcher.Resister(thirldPersonCam); //3인칭 카메라 등록
        CameraSwitcher.Resister(firstPersonCam); // 1인칭 카메라 등록
        CameraSwitcher.SwitchCamera(thirldPersonCam); //3인칭 카메라 활성화


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
            //카메라 전환
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
