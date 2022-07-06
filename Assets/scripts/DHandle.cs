using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DHandle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.name;
        Debug.Log(message:"1=>"+this.transform.name);//D
        Debug.Log(message:"2=>"+this.transform.parent.name);//B
        Debug.Log(message:"3=>"+this.transform.parent.parent.name);//A
        Debug.Log(message:"4=>"+this.transform.parent.parent.parent.name);
        GameObject a = this.transform.parent.parent.gameObject;
        int childCount = a.transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            string name = a.transform.GetChild(i).name;
            switch(name)
            {
                case"B":
                    break;
                case"C":
                    Debug.Log(message:"抓到了");
                    break;
            }
        }
        //------------------------------------------/
            this.transform.parent = a.transform;//瞬間移動
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
