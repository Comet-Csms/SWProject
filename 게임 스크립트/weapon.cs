using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public GameObject[] weapons; //무기 오브젝트를 배열로 받음
    public GameObject equipWeapon; //현재 장착 중인 무기 오브젝트
    [SerializeField] CameraController cameraController;

    public int weaponIndex = 0;

    void Start()
    {

    }

    void Update()
    {
        if (cameraController.first == true)
        {
            SwitchingWeapon2();
            zoominWeapon();
        }
        else
        {
            SwitchingWeapon();
            zoomoutWeapon();
        }
        //SwitchingWeapon();
    }

    public void SwitchingWeapon()
    {
        if (Input.GetKey(KeyCode.Alpha1)) weaponIndex = 0;
        if (Input.GetKey(KeyCode.Alpha2)) weaponIndex = 1;
        if (Input.GetKey(KeyCode.Alpha3)) weaponIndex = 2;

        if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Alpha3))
        {
            if (weapons[weaponIndex] != null)
            {
                if (equipWeapon != null) equipWeapon.SetActive(false); //이미 무기를 들고 있다면, 장착중이었던 무기 비활성화
                equipWeapon = weapons[weaponIndex]; //선택한 무기로 변경
                equipWeapon.SetActive(true); //활성화
            }
        }
    }

    public void zoominWeapon()
    {
        if (weaponIndex == 0) weaponIndex = 3;
        if (weaponIndex == 1) weaponIndex = 4;
        if (weapons[weaponIndex] != null)
        {
            if (equipWeapon != null) equipWeapon.SetActive(false); //이미 무기를 들고 있다면, 장착중이었던 무기 비활성화
            equipWeapon = weapons[weaponIndex]; //선택한 무기로 변경
            equipWeapon.SetActive(true); //활성화
        }
        if (weaponIndex == 3)
        {
            weapons[6].SetActive(false);
            weapons[5].SetActive(true); //활성화
        }
        if (weaponIndex == 4)
        {
            weapons[5].SetActive(false);
            weapons[6].SetActive(true); //활성화
        }
    }

    public void SwitchingWeapon2()
    {
        if (Input.GetKey(KeyCode.Alpha1)) weaponIndex = 3;
        if (Input.GetKey(KeyCode.Alpha2)) weaponIndex = 4;
        if (Input.GetKey(KeyCode.Alpha3)) weaponIndex = 5;

        if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Alpha3))
        {
            if (weapons[weaponIndex] != null)
            {
                if (equipWeapon != null) equipWeapon.SetActive(false); //이미 무기를 들고 있다면, 장착중이었던 무기 비활성화
                equipWeapon = weapons[weaponIndex]; //선택한 무기로 변경
                equipWeapon.SetActive(true); //활성화
            }
        }
    }

    public void zoomoutWeapon()
    {
        if (weaponIndex == 3) weaponIndex = 0;
        if (weaponIndex == 4) weaponIndex = 1;
        if (weapons[weaponIndex] != null)
        {
            if (equipWeapon != null) equipWeapon.SetActive(false); //이미 무기를 들고 있다면, 장착중이었던 무기 비활성화
            equipWeapon = weapons[weaponIndex]; //선택한 무기로 변경
            equipWeapon.SetActive(true); //활성화
        }
        if (weaponIndex == 0)
        {
            weapons[5].SetActive(false);
        }
        if (weaponIndex == 1)
        {
            weapons[6].SetActive(false);
        }
    }
}
