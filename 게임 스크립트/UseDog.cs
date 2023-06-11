using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UseDog : MonoBehaviour
{

    [SerializeField] float timeRemaining = 7.0f;
    EnemyHp enemy;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

        }
        else
        {
            Destroy(this.gameObject);
            Debug.Log("¸Û¹¶ÀÌ ¾ø¾îÁü");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            //other.GetComponent<EnemyHp>().Damage(1);
        }
    }
}
