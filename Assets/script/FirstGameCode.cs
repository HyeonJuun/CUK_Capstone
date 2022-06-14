using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class locate : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] 
    float setTime = 40.0f;
    int count = 1;
    [SerializeField] Text countdownText;
    public Text value0;
    public Text value1;
    public Text value2;
    public Text value3;
    public Text value4;
    public Text value5;
    public Text value6;
    public Text value7;
    public Text value8;
    public Text value9;
    public Text value10;
    public Text value11;
    public Text value12;
    public Text value13;
    public Text value14;
    public GameObject[] node01;
    /*  public GameObject node0;
      public GameObject node1;
      public GameObject node2;
      public GameObject node3;
      public GameObject node4;
      public GameObject node5;
      public GameObject node6;
      public GameObject node7;
      public GameObject node8;
      public GameObject node9;
      public GameObject node10;
      public GameObject node11;
      public GameObject node12;
      public GameObject node13;
      public GameObject node14;*/


    public GameObject button;
    public GameObject obj;

    bool check = true;
    bool once = false;
    bool once1 = false;
    bool check_button = false;
    bool timer = false;
    int level = 1;
    bool level_check = true;
    public int[] val;
    string s = "";

    int test = 0;
    public void OnClickButton()
    {
        //Debug.Log("button click");
        if (button != null)
        {
            check_button = true;
            Debug.Log("button click");
            //GameObject.Find("latter1").SetActive(true);

        }
    }

    void Start()
    {

        node01 = new GameObject[15];
        val = new int[15];

        obj = GameObject.Find("bomb");

        //node0 = GameObject.Find("node");

        // node01[0]=GameObject.Find("node");
        for (int i = 0; i < 15; i++)
        {
            node01[i] = GameObject.Find("node (" + i + ")");
            val[i] = 0;
        }




        if (countdownText)
            countdownText.text = setTime.ToString();



    }
    void trans(int x, int y)
    {
        Vector3 position = obj.transform.localPosition;
        position.x = x;
        position.y = y;
        obj.transform.localPosition = position;
        check = false;

    }

    void level01()
    {
        Debug.Log("level click");
        if (value0)
            value0.text = 32.ToString();
        if (value1)
            value1.text = 17.ToString();
        if (value3)
            value3.text = 8.ToString();
        if (value9)
            value9.text = 16.ToString();

        val[0] = 32;
        val[1] = 17;
        val[3] = 8;
        val[9] = 16;
        for (int i = 0; i < 15; i++)
        {
            if (i == 0 || i == 1 || i == 3 || i == 9)
                continue;
            if (node01[i])
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 0.0f;
                node01[i].GetComponent<Image>().color = color;

            }
            //node01[i].SetActive(false);
        }

        //if (value0) value0.color = new Color(255, 255, 255, 0);
        // if (value1) value1.color = new Color(255, 255, 255, 0
        //  if (value2) value2.color = new Color(255, 255, 255, 0);
        //if (value3) value3.color = new Color(255, 255, 255, 0);
        if (value4) value4.color = new Color(255, 255, 255, 0);
        if (value5) value5.color = new Color(255, 255, 255, 0);
        if (value6) value6.color = new Color(255, 255, 255, 0);
        if (value7) value7.color = new Color(255, 255, 255, 0);
        if (value8) value8.color = new Color(255, 255, 255, 0);
        //if (value9) value9.color = new Color(255, 255, 255, 0);
        if (value10) value10.color = new Color(255, 255, 255, 0);
        if (value11) value11.color = new Color(255, 255, 255, 0);
        if (value12) value12.color = new Color(255, 255, 255, 0);
        if (value13) value13.color = new Color(255, 255, 255, 0);
        if (value14) value14.color = new Color(255, 255, 255, 0);

        //value0.color = new Color(255, 255, 255, 0);
        level_check = false;
    }


    void Update_level01(float st)
    {

        Debug.Log("Update_level01");
        int t = (int)st;
        if (t > val[0])
        {
            if (val[2] == 0)
            {
                val[2] = t;

            }
        }
        //check = true;
    }


    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Input.mousePosition);
        if (level == 1 && level_check)
            level01();
        int n = 0;
        if (check)
        {
            n = Random.Range(1, 7);
            setTime = 40.0f;// Random.Range(30, 45);
            check_button = false;
            timer = false;
            once = true;
            switch (n)
            {
                case 1:
                    trans(-310, 90);
                    break;
                case 2:
                    trans(-170, 110);
                    break;
                case 3:
                    trans(30, 90);
                    break;
                case 4:
                    trans(-300, 0);
                    break;
                case 5:
                    trans(-130, -20);
                    break;
                case 6:
                    trans(-300, -120);
                    break;
                case 7:
                    trans(30, -120);
                    break;
            }
        }


        if (check_button.Equals(false))
        {
            Debug.Log("in false");

            if (setTime > 0)
                setTime -= Time.deltaTime;
            else if (setTime <= 0)
                Time.timeScale = 0.0f;
        }
        else if (check_button && once)
        {
            Time.timeScale = 0.0f;
            // check_button = false;
            // if (count == 1)
            //     stage01();
            //timer = (int)Mathf.Round(setTime);
            // timer = true;
            Update_level01(Mathf.Round(setTime));


            once1 = true;
            once = false;


        }
        // float st = Mathf.Round(setTime);

        if (countdownText)
            countdownText.text = Mathf.Round(setTime).ToString();

        // if (val[2]!=0)


        for (int i = 0; i < 15; i++)
        {
            if (val[i] != 0)
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 255.0f;
                node01[i].GetComponent<Image>().color = color;

                //if (node01[i])
                //  node01[i].SetActive(true);
                //if (value2) value2.color = new Color(255, 255, 255, 255);
            }

        }
        Debug.Log("val[2]: " + val[2]);

        if (once1)
        {
            test = (int)Mathf.Round(setTime); //val[2] = (int)Mathf.Round(setTime);
        }


        if (value2)
            value2.text = val[2].ToString();//Mathf.Round(setTime).ToString();// val[2].ToString();    
        //여기서 set해야할듯 
    }
}