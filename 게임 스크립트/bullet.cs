using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{

    [SerializeField] float timeRemaining = 5.0f;
    EnemyHp enemy;
    Vector3 dir;
    Ray ray;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
        dir = Camera.main.ScreenPointToRay(Input.mousePosition).direction;
        ray = new Ray(this.transform.position + transform.forward, dir);
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
            Debug.Log("Object ¾ø¾îÁü");
        }
        transform.position += ray.direction * 50 * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
            //other.GetComponent<EnemyHp>().Damage(1);
        }
    }
}
