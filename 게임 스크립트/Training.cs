using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Training : MonoBehaviour
{
    [SerializeField] GameObject obj1;
    [SerializeField] GameObject obj2;
    [SerializeField] GameObject obj3;
    [SerializeField] GameObject obj4;
    [SerializeField] GameObject obj5;
    [SerializeField] GameObject obj6;
    [SerializeField] GameObject obj7;
    [SerializeField] GameObject obj8;
    [SerializeField] GameObject obj9;
    [SerializeField] GameObject obj10;
    [SerializeField] GameObject obj11;
    [SerializeField] GameObject obj12;
    [SerializeField] GameObject obj13;
    [SerializeField] GameObject obj14;
    [SerializeField] GameObject obj15;
    //[SerializeField] GameObject NPC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("NPC1") == null && GameObject.Find("NPC1(Clone)") == null)
        {
            Vector3 position = obj1.transform.position;
            Quaternion quaternion = obj1.transform.rotation;
            //Vector3 position = NPC.transform.position;
            //Quaternion quaternion = NPC.transform.rotation;
            GameObject go = Instantiate(obj1, position, quaternion);
        }
        if (GameObject.Find("NPC2") == null && GameObject.Find("NPC2(Clone)") == null)
        {
            Vector3 position = obj2.transform.position;
            Quaternion quaternion = obj2.transform.rotation;
            GameObject go = Instantiate(obj2, position, quaternion);
        }
        if (GameObject.Find("NPC3") == null && GameObject.Find("NPC3(Clone)") == null)
        {
            Vector3 position = obj3.transform.position;
            Quaternion quaternion = obj3.transform.rotation;
            GameObject go = Instantiate(obj3, position, quaternion);
        }
        if (GameObject.Find("NPC4") == null && GameObject.Find("NPC4(Clone)") == null)
        {
            Vector3 position = obj4.transform.position;
            Quaternion quaternion = obj4.transform.rotation;
            GameObject go = Instantiate(obj4, position, quaternion);
        }
        if (GameObject.Find("NPC5") == null && GameObject.Find("NPC5(Clone)") == null)
        {
            Vector3 position = obj5.transform.position;
            Quaternion quaternion = obj5.transform.rotation;
            GameObject go = Instantiate(obj5, position, quaternion);
        }
        if (GameObject.Find("NPC6") == null && GameObject.Find("NPC6(Clone)") == null)
        {
            Vector3 position = obj6.transform.position;
            Quaternion quaternion = obj6.transform.rotation;
            GameObject go = Instantiate(obj6, position, quaternion);
        }
        if (GameObject.Find("NPC7") == null && GameObject.Find("NPC7(Clone)") == null)
        {
            Vector3 position = obj7.transform.position;
            Quaternion quaternion = obj7.transform.rotation;
            GameObject go = Instantiate(obj7, position, quaternion);
        }
        if (GameObject.Find("NPC8") == null && GameObject.Find("NPC8(Clone)") == null)
        {
            Vector3 position = obj8.transform.position;
            Quaternion quaternion = obj8.transform.rotation;
            GameObject go = Instantiate(obj8, position, quaternion);
        }
        if (GameObject.Find("NPC9") == null && GameObject.Find("NPC9(Clone)") == null)
        {
            Vector3 position = obj9.transform.position;
            Quaternion quaternion = obj9.transform.rotation;
            GameObject go = Instantiate(obj9, position, quaternion);
        }
        if (GameObject.Find("NPC10") == null && GameObject.Find("NPC10(Clone)") == null)
        {
            Vector3 position = obj10.transform.position;
            Quaternion quaternion = obj10.transform.rotation;
            GameObject go = Instantiate(obj10, position, quaternion);
        }
        if (GameObject.Find("NPC11") == null && GameObject.Find("NPC11(Clone)") == null)
        {
            Vector3 position = obj11.transform.position;
            Quaternion quaternion = obj11.transform.rotation;
            GameObject go = Instantiate(obj11, position, quaternion);
        }
        if (GameObject.Find("NPC12") == null && GameObject.Find("NPC12(Clone)") == null)
        {
            Vector3 position = obj12.transform.position;
            Quaternion quaternion = obj12.transform.rotation;
            GameObject go = Instantiate(obj12, position, quaternion);
        }
        if (GameObject.Find("NPC13") == null && GameObject.Find("NPC13(Clone)") == null)
        {
            Vector3 position = obj13.transform.position;
            Quaternion quaternion = obj13.transform.rotation;
            GameObject go = Instantiate(obj13, position, quaternion);
        }
        if (GameObject.Find("NPC14") == null && GameObject.Find("NPC14(Clone)") == null)
        {
            Vector3 position = obj14.transform.position;
            Quaternion quaternion = obj14.transform.rotation;
            GameObject go = Instantiate(obj14, position, quaternion);
        }
        if (GameObject.Find("NPC15") == null && GameObject.Find("NPC15(Clone)") == null)
        {
            Vector3 position = obj15.transform.position;
            Quaternion quaternion = obj15.transform.rotation;
            GameObject go = Instantiate(obj15, position, quaternion);
        }
    }
}
