using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Bullet;
    public Text CText;
    // Start is called before the first frame update
    void Start()
    {
        if (!CText)
        {
            CText = GameObject.FindGameObjectWithTag("Canvas").transform.Find("Text").gameObject.GetComponent<Text>();
        }   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) {
            CText.text = "MOUSE TOUCH";
        }
        if (Input.touchCount>0)

        {
            CText.text = "SCREEn TOUCH";
        }
        if (Bullet)
        {
            //Instantiate(Bullet, transform.parent);
        }
    }
}
