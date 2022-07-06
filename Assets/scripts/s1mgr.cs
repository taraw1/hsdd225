using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class s1mgr : MonoBehaviour
{
    public Image kikfj;
    public Button btnGo;

    
    // Start is called before the first frame update
    private void Awake()
    {
        btnGo.onClick.AddListener(oncilk);
    }

    void Start()
    {
        //int childCount=this.transform.childCount;
       // Debug.Log(childCount);
        //for (int i = 0; i < childCount; i++)
       // {
          //  Transform temp = this.transform.GetChild(i);
          //  Debug.Log(temp.name);
           // if (temp.name=="Main Camera")
           // {
            //    Camera c = temp.GetComponent<Camera>();
              //  c.fieldOfView = 30;
           // }
       // }
    }

    public void oncilk()
    {
        Debug.Log("smsmsm");
        kikfj.color = new Color(50.0f, 0.0f, 0.0f);
        kikfj.transform.localPosition = new Vector3(10, 12,10);

    }

    //// Update is called once per frame
    void Update()
    {
        
    }
}
