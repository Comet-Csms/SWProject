using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wands : MonoBehaviour
{

    [SerializeField] GameObject Lasers;
    [SerializeField] GameObject LaserPoint;
    [SerializeField] CameraController cameraController;
    CinemachineVirtualCamera cameraC;
    // Start is called before the first frame update

    public AudioClip fireSfxGun;
    private AudioSource sourceGun = null;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        cameraC = GameObject.Find("PlayerFollowCamera1").GetComponent<CinemachineVirtualCamera>();

        sourceGun = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraController.first == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SoundOn();

                GameObject go = Instantiate(Lasers, cameraC.transform.position, cameraC.transform.rotation);

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                Debug.DrawRay(Camera.main.transform.position, ray.direction * 100.0f, Color.red, 1.0f); // 1초만 레이저 유지

                LayerMask mask = LayerMask.GetMask("Enemy");

                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 100.0f, mask)) // Monster 레이어만 연산
                {
                    //Debug.Log($"Raycast Camera @{hit.collider.gameObject.name}");
                    Debug.Log($"Raycast Camera @{hit.collider.gameObject.tag}"); // Object를 Tag이름으로 출력
                    hit.collider.gameObject.GetComponent<EnemyHp>().Damage(1);
                }
            }
        }
    }

    void SoundOn()
    {
        sourceGun.PlayOneShot(fireSfxGun, 0.9f);
    }

}
