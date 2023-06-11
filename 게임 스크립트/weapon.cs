using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public GameObject[] weapons; //���� ������Ʈ�� �迭�� ����
    public GameObject equipWeapon; //���� ���� ���� ���� ������Ʈ
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
                if (equipWeapon != null) equipWeapon.SetActive(false); //�̹� ���⸦ ��� �ִٸ�, �������̾��� ���� ��Ȱ��ȭ
                equipWeapon = weapons[weaponIndex]; //������ ����� ����
                equipWeapon.SetActive(true); //Ȱ��ȭ
            }
        }
    }

    public void zoominWeapon()
    {
        if (weaponIndex == 0) weaponIndex = 3;
        if (weaponIndex == 1) weaponIndex = 4;
        if (weapons[weaponIndex] != null)
        {
            if (equipWeapon != null) equipWeapon.SetActive(false); //�̹� ���⸦ ��� �ִٸ�, �������̾��� ���� ��Ȱ��ȭ
            equipWeapon = weapons[weaponIndex]; //������ ����� ����
            equipWeapon.SetActive(true); //Ȱ��ȭ
        }
        if (weaponIndex == 3)
        {
            weapons[6].SetActive(false);
            weapons[5].SetActive(true); //Ȱ��ȭ
        }
        if (weaponIndex == 4)
        {
            weapons[5].SetActive(false);
            weapons[6].SetActive(true); //Ȱ��ȭ
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
                if (equipWeapon != null) equipWeapon.SetActive(false); //�̹� ���⸦ ��� �ִٸ�, �������̾��� ���� ��Ȱ��ȭ
                equipWeapon = weapons[weaponIndex]; //������ ����� ����
                equipWeapon.SetActive(true); //Ȱ��ȭ
            }
        }
    }

    public void zoomoutWeapon()
    {
        if (weaponIndex == 3) weaponIndex = 0;
        if (weaponIndex == 4) weaponIndex = 1;
        if (weapons[weaponIndex] != null)
        {
            if (equipWeapon != null) equipWeapon.SetActive(false); //�̹� ���⸦ ��� �ִٸ�, �������̾��� ���� ��Ȱ��ȭ
            equipWeapon = weapons[weaponIndex]; //������ ����� ����
            equipWeapon.SetActive(true); //Ȱ��ȭ
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
