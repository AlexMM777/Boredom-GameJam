using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 5f;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyBody")
        {
            if (!(other.isTrigger))
            {
                other.gameObject.GetComponent<AIController>().enemyHealth -= 10;
                other.gameObject.GetComponent<AIController>().GotShot();
                Destroy(this.gameObject);
            }
        }
    }
}
