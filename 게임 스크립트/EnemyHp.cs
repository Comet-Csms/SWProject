using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int MaxHP = 2;
    //Renderer capsuleColor;
    Color Defalut;
    // Start is called before the first frame update
    void Start()
    {
        //capsuleColor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (MaxHP == 0)
        {
            
            Destroy(this.gameObject);
            //this.gameObject.SetActive(true);
        }

        if (this.gameObject.transform.position.y < -500)
        {
            Destroy(this.gameObject);
        }
        
    }

    public void Damage(int damage)
    {
        //Defalut = capsuleColor.material.color;
        //capsuleColor.material.color = Color.red;
        MaxHP -= damage;
        Debug.Log("데미지 1이 들어갔습니다");
    }
}
