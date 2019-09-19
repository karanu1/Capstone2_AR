using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Bullet;
    public Text CText;
    public int i;
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
            i++;
            CText.text = "MOUSE TOUCH: "+i;
            CText.color = new Color(Random.Range(0, 256), Random.Range(0, 256), Random.Range(0, 256), 255);
           
         }
        if (Input.touchCount>0)

        {
            CText.text = "SCREEn TOUCH:"+Input.touchCount;
        }
        if (Bullet)
        {
            //Instantiate(Bullet, transform.parent);
        }
    }
}
