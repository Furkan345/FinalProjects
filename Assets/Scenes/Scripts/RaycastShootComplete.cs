using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShootComplete : MonoBehaviour
{
    RaycastHit hit;
    public GameObject KursunPrefab;
    public Transform atesNoktasi;
    public float KursunHizi = 10f;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            AtesEt();
        }
    }

    void AtesEt()
    {
        GameObject Kursun = Instantiate(KursunPrefab, atesNoktasi.position, atesNoktasi.rotation);
        Rigidbody KursunRigidbody = Kursun.GetComponent<Rigidbody>();
        KursunRigidbody.velocity = atesNoktasi.forward * KursunHizi;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            if (Physics.Raycast(atesNoktasi.transform.position, atesNoktasi.transform.forward, out hit, Mathf.Infinity))
            {

                //can--;
                //print(can);
                // if (can==0)
                //{
                //if (hit.collider.gameObject.tag == "dusman")
                //{
                //    can--;
                //    if (can == 0)
                //    {

                
                //Debug.Log(hit.collider.gameObject.name);
                //if (hit.collider.gameObject.CompareTag("hedef"))
                //{
                //    Destroy(hit.collider.gameObject);
                //}
                //hit.collider.gameObject.CompareTag("hedef");
                //    }

                //}
            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
    }
}
