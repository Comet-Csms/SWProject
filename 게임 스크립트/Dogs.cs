using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dogs : MonoBehaviour
{
    [SerializeField] GameObject DogSkill;
    [SerializeField] GameObject Dog;
    [SerializeField] GameObject Player;
    [SerializeField] int MaxTime = 20;
    // Start is called before the first frame update

    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        if (DogSkill.activeSelf == true && GameObject.Find("DogSkillTimeManager").GetComponent <DogSkillTimer>().timeRemaining <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject.Find("DogSkillTimeManager").GetComponent<DogSkillTimer>().timeRemaining = MaxTime;
                //GameObject go = Instantiate(Dog, Player.transform.position, Player.transform.rotation);
                Vector3 position = Player.transform.position;
                Vector3 alpha = new Vector3(1, 0, 1);
                GameObject go = Instantiate(Dog, position + alpha, Player.transform.rotation);
            }
        }
    }
}