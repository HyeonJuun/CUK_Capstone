using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class locate01 : MonoBehaviour
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
    public GameObject line1;
    public GameObject line2;
    public GameObject line3;

    
    bool check = true;
    bool once = false;
    bool once1 = false;
    bool check_button = false;
    bool timer = false;
    int level = 1;
    bool level_check = true;
    private int[] val;
    int cnt1 = 0;
    int cnt2 = 0;
    int cnt3 = 0;

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
        line1 = GameObject.Find("line1");
        line2 = GameObject.Find("line2");
        line3 = GameObject.Find("line3");
        value0=GameObject.Find("value0").GetComponent<Text>();
        value1=GameObject.Find("value1").GetComponent<Text>();
        value2=GameObject.Find("value2").GetComponent<Text>();
        value3=GameObject.Find("value3").GetComponent<Text>();
        value4=GameObject.Find("value4").GetComponent<Text>();
        value5=GameObject.Find("value5").GetComponent<Text>();
        value6=GameObject.Find("value6").GetComponent<Text>();
        value7=GameObject.Find("value7").GetComponent<Text>();
        value8=GameObject.Find("value8").GetComponent<Text>();
        value9=GameObject.Find("value9").GetComponent<Text>();
        value10=GameObject.Find("value10").GetComponent<Text>();
        value11=GameObject.Find("value11").GetComponent<Text>();
        value12=GameObject.Find("value12").GetComponent<Text>();
        value13=GameObject.Find("value13").GetComponent<Text>();
        value14=GameObject.Find("value14").GetComponent<Text>();
        //node0 = GameObject.Find("node");

        // node01[0]=GameObject.Find("node");
        for (int i=0; i<15; i++)
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
        if (line3)
        {
            Color color = line3.GetComponent<Image>().color;
            color.a = 0.0f;
            line3.GetComponent<Image>().color = color;

        }

        cnt2 = 0;
        cnt3 = 0;
        level = 1;
        Debug.Log("level click");

        Vector3 position = line1.transform.localPosition;
        position.x = 40;
        position.y = -140;
        line1.transform.localPosition = position;

        position = line2.transform.localPosition;
        position.x = 70;
        position.y = -140;
        line2.transform.localPosition = position;


        if (value0)
            value0.text = 30.ToString();
        if (value1)
            value1.text = 25.ToString();
        if (value3)
            value3.text = 20.ToString();
       // if (value9)
        //    value9.text = 16.ToString();

        for (int i = 0; i < 15; i++)
            val[i] = 0;

        val[0] = 30;
        val[1] = 25;
        val[3] = 20;
       // val[9] = 16;

        for(int i=0; i<15; i++)
        {
            if (i == 0 || i == 1 || i == 3  )
                continue;
            if (node01[i])
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 0.0f;
                node01[i].GetComponent<Image>().color = color;

            }
                //node01[i].SetActive(false);
        }

        if (value0) value0.color = new Color(0, 0, 0, 255);
        if (value1) value1.color = new Color(0, 0, 0, 255);
        if (value2) value2.color = new Color(255, 255, 255, 0);
        if (value3) value3.color = new Color(0, 0, 0, 255);
        if (value4) value4.color = new Color(255, 255, 255, 0);
        if (value5) value5.color = new Color(255, 255, 255, 0);
        if (value6) value6.color = new Color(255, 255, 255, 0);
        if (value7) value7.color = new Color(255, 255, 255, 0);
        if (value8) value8.color = new Color(255, 255, 255, 0);
        if (value9) value9.color = new Color(255, 255, 255, 0);
        if (value10) value10.color = new Color(255, 255, 255, 0);
        if (value11) value11.color = new Color(255, 255, 255, 0);
        if (value12) value12.color = new Color(255, 255, 255, 0);
        if (value13) value13.color = new Color(255, 255, 255, 0);
        if (value14) value14.color = new Color(255, 255, 255, 0);

        //value0.color = new Color(255, 255, 255, 0);
        level_check = false;
    }
    void level02()
    {
        if (line3)
        {
            Color color = line3.GetComponent<Image>().color;
            color.a = 0.0f;
            line3.GetComponent<Image>().color = color;

        }

        level = 2;
        Vector3 position = line1.transform.localPosition;
        position.x = 170;
        position.y = -140;
        line1.transform.localPosition = position;

        position = line2.transform.localPosition;
        position.x = 210;
        position.y = -140;
        line2.transform.localPosition = position;

        if (value0)
            value0.text = 20.ToString();
        if (value1)
            value1.text = 10.ToString();
        if (value2)
            value2.text = 30.ToString();
         if (value5)
            value5.text = 25.ToString();
        // if (value9)
        //    value9.text = 16.ToString();

        

        val[0] = 20;
        val[1] = 10;
        val[2] = 30; 
        val[5] = 25;
        // val[9] = 16;

        for (int i = 0; i < 15; i++)
        {
            if (i == 0 || i == 1  || i==2 || i==5)
            {
                /* Color color = node01[i].GetComponent<Image>().color;
                 color.a = 1.0f;
                 node01[i].GetComponent<Image>().color = color;*/
                continue;
            }
                
            if (node01[i])
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 0.0f;
                node01[i].GetComponent<Image>().color = color;

            }
            //node01[i].SetActive(false);
        }

        if (value0) value0.color = new Color(0, 0, 0, 255);
        if (value1) value1.color = new Color(0, 0, 0, 255);
        if (value2) value2.color = new Color(0, 0, 0, 255);
        if (value3) value3.color = new Color(255, 255, 255, 0);
        if (value4) value4.color = new Color(255, 255, 255, 0);
        if (value5) value5.color = new Color(0, 0, 0, 255);
        if (value6) value6.color = new Color(255, 255, 255, 0);
        if (value7) value7.color = new Color(255, 255, 255, 0);
        if (value8) value8.color = new Color(255, 255, 255, 0);
        if (value9) value9.color = new Color(255, 255, 255, 0);
        if (value10) value10.color = new Color(255, 255, 255, 0);
        if (value11) value11.color = new Color(255, 255, 255, 0);
        if (value12) value12.color = new Color(255, 255, 255, 0);
        if (value13) value13.color = new Color(255, 255, 255, 0);
        if (value14) value14.color = new Color(255, 255, 255, 0);

        //value0.color = new Color(255, 255, 255, 0);
        level_check = false;
    }
    void level03()
    {
        if (line3)
        {
            Color color = line3.GetComponent<Image>().color;
            color.a = 1.0f;
            line3.GetComponent<Image>().color = color;

        }

        level = 3;
        Vector3 position = line1.transform.localPosition;
        position.x = 80;
        position.y = -140;
        line1.transform.localPosition = position;

        position = line2.transform.localPosition;
        position.x = 120;
        position.y = -140;
        line2.transform.localPosition = position;

        position = line3.transform.localPosition;
        position.x = 250;
        position.y = -140;
        line3.transform.localPosition = position;

        if (value0)
            value0.text = 25.ToString();
        if (value1)
            value1.text = 15.ToString();
        if (value2)
            value2.text = 35.ToString();
       



        val[0] = 25;
        val[1] = 15;
        val[2] = 35;
       
        // val[9] = 16;

        for (int i = 0; i < 15; i++)
        {
            if (i == 0 || i == 1 || i == 2 || i == 5)
            {
                /* Color color = node01[i].GetComponent<Image>().color;
                 color.a = 1.0f;
                 node01[i].GetComponent<Image>().color = color;*/
                continue;
            }

            if (node01[i])
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 0.0f;
                node01[i].GetComponent<Image>().color = color;

            }
            //node01[i].SetActive(false);
        }

        if (value0) value0.color = new Color(0, 0, 0, 255);
        if (value1) value1.color = new Color(0, 0, 0, 255);
        if (value2) value2.color = new Color(0, 0, 0, 255);
        if (value3) value3.color = new Color(255, 255, 255, 0);
        if (value4) value4.color = new Color(255, 255, 255, 0);
        if (value5) value5.color = new Color(255, 255, 255, 0);
        if (value6) value6.color = new Color(255, 255, 255, 0);
        if (value7) value7.color = new Color(255, 255, 255, 0);
        if (value8) value8.color = new Color(255, 255, 255, 0);
        if (value9) value9.color = new Color(255, 255, 255, 0);
        if (value10) value10.color = new Color(255, 255, 255, 0);
        if (value11) value11.color = new Color(255, 255, 255, 0);
        if (value12) value12.color = new Color(255, 255, 255, 0);
        if (value13) value13.color = new Color(255, 255, 255, 0);
        if (value14) value14.color = new Color(255, 255, 255, 0);

        //value0.color = new Color(255, 255, 255, 0);
        level_check = false;
    }
    void  Update_level01(float st)
    {
        once = true;
        check = true;
        int t = (int)st;
        if (t < val[0])
        {
            if (val[1] == 0)
            {
                val[1] = t;
                if (value1)
                    value1.text = t.ToString();
               
                if (value1) value1.color = new Color(0, 0, 0, 255);
                return;
            }
            else
            {
                if (t < val[1])
                {
                    if (val[3] == 0)
                    {
                        val[3] = t;
                        if (value3)
                            value3.text = t.ToString();
                        if (value3) value3.color = new Color(0, 0, 0, 255);
                        return;
                    }
                    else
                    {
                        if (t < val[3])
                        {
                            if (val[7] == 0)
                            {
                                val[7] = t;
                                if (value7)
                                    value7.text = t.ToString();
                                if (value7) value7.color = new Color(0, 0, 0, 255);
                                if (level == 1)
                                    cnt1++;

                                return;
                            }
                            else
                            {

                                level01();//gameover;
                            }
                        }
                        else
                        {
                            if (val[8] == 0)
                            {
                                val[8] = t;
                                if (value8)
                                    value8.text = t.ToString();
                                if (value8) value8.color = new Color(0, 0, 0, 255);
                                if (level == 1)
                                    cnt1++;
                                if (level == 3)
                                    cnt3++;
                                return;
                            }
                            else
                            {
                                level01(); //gameover;
                            }
                        }
                    }
                }
                else
                {
                    if (val[4] == 0)
                    {
                        val[4] = t;
                        if (value4)
                            value4.text = t.ToString();
                        if (value4) value4.color = new Color(0, 0, 0, 255);
                        return;
                    }
                    else
                    {
                        if (t < val[4]) //9
                        {
                            if (val[9] == 0)
                            {
                                val[9] = t;
                                if (value9)
                                    value9.text = t.ToString();
                                if (value9) value9.color = new Color(0, 0, 0, 255);
                                if (level == 3)
                                    cnt3++;
                                return;
                            }
                            else
                            {
                                level01();//gameover;
                            }
                        }
                        else //10
                        {
                            if (val[10] == 0)
                            {
                                val[10] = t;
                                if (value10)
                                    value10.text = t.ToString();
                                if (value10) value10.color = new Color(0, 0, 0, 255);
                                if (level == 2)
                                    cnt2++;
                                return;
                            }
                            else
                            {
                                level01();//gameover;
                            }
                        }
                    }
                }
            }
        }
        else
        {
            if (val[2] == 0)
            {
                val[2] = t;
                if (value2)
                    value2.text = t.ToString();
                if (value2) value2.color = new Color(0, 0, 0, 255);
                return;
            }
            else
            {
                if (t < val[2])
                {
                    if (val[5] == 0)
                    {
                        val[5] = t;
                        if (value5)
                            value5.text = t.ToString();
                        if (value5) value5.color = new Color(0, 0, 0, 255);
                        return;
                    }
                    else
                    {
                        if (t < val[5])
                        {
                            if (val[11] == 0)
                            {
                                val[11] = t;
                                if (value11)
                                    value11.text = t.ToString();
                                if (value11) value11.color = new Color(0, 0, 0, 255);
                                if (level == 2)
                                    cnt2++;
                                return;
                            }
                            else
                            {
                                level01();//gameover;
                            }
                        }
                        else
                        {
                            if (val[12] == 0)
                            {
                                val[12] = t;
                                if (value12)
                                    value12.text = t.ToString();
                                if (value12) value12.color = new Color(0, 0, 0, 255);
                                if (level == 3)
                                    cnt3++;
                                return;
                            }
                            else
                            {
                                level01();//gameover;
                            }
                        }
                    }
                }
                else
                {
                    if (val[6] == 0)
                    {
                        val[6] = t;
                        if (value6)
                            value6.text = t.ToString();
                        if (value6) value6.color = new Color(0, 0, 0, 255);
                        return;
                    }
                    else
                    {
                        if (t < val[6]) //9
                        {
                            if (val[13] == 0)
                            {
                                val[13] = t;
                                if (value13)
                                    value13.text = t.ToString();
                                if (value13) value13.color = new Color(0, 0, 0, 255);
                                return;
                            }
                            else
                            {
                                level01(); //gameover;
                            }
                        }
                        else //10
                        {
                            if (val[14] == 0)
                            {
                                val[14] = t;
                                if (value14)
                                    value14.text = t.ToString();
                                if (value14) value14.color = new Color(0, 0, 0, 255);
                                return;
                            }
                            else
                            {
                                level01();//gameover;
                            }
                        }
                    }
                }
            }
        }
       
    }


    // Update is called once per frame
    void Update()
    {

         Debug.Log("val[3]: "+val[3]);
        if(cnt1==2)
        {
            for (int i = 0; i < 15; i++)
                val[i] = 0;
           
            cnt1 = 0;
            level++;
            level02();
        
            

        }
        if(cnt2==2)
        {

            for (int i = 0; i < 15; i++)
                val[i] = 0;

            cnt1 = 0;
            cnt2 = 0;
            level++;

            Color color = line3.GetComponent<Image>().color;
            color.a = 255.0f;
            line3.GetComponent<Image>().color = color;

            level03();

        }
        if(cnt3==3)
        {
            //�Ѿ
        }
        if (level == 1 && level_check)
            level01();
        int n=0;
        if (check)
        {
            n =  Random.Range(1, 7);
            setTime = 40.0f;// Random.Range(30, 45);
            check_button = false;
            timer = false;
            once = true;
            Time.timeScale = 1.0f;
            switch (n)
            {
                case 1:
                    trans(-310, 90);
                    break;
                case 2:
                    trans(-170, 110);
                    break;
                case 3:
                    trans(-30, 110);
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
                    trans(-30, -120);
                    break;
            }
        }
     

        if (check_button.Equals(false) )
        {
            Debug.Log("in false");

            if (setTime > 0)
                setTime -= Time.deltaTime;
            //else if (setTime <= 0)
             //   Time.timeScale = 0.0f;
        }
        else if(check_button && once)
        {
            Time.timeScale = 0.0f;
           
            Update_level01(Mathf.Round(setTime));
            check = true;
            once = false;

        }
       

        if (countdownText)
            countdownText.text = Mathf.Round(setTime).ToString();

        // if (val[2]!=0)

        
        for (int i=0; i<15; i++)
        {
            if (val[i] != 0)
            {
               
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 255.0f;
                node01[i].GetComponent<Image>().color = color;

               
            }
            else
            {
                Color color = node01[i].GetComponent<Image>().color;
                color.a = 0.0f;
                node01[i].GetComponent<Image>().color = color;
            }
                
        }
        
         
        
       
    }
}
