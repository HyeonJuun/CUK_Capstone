using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PW_check : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] InputField inputpw;
    [SerializeField] Text text;
    [SerializeField] string pw = "1221830";

    public void input()
    {
        if(inputpw.text == pw)
        {
            //if (backmusic.isPlaying) backmusic.Pause();
            SceneManager.LoadScene("Firstgame_main");
        }
        else
        {
            text.text = "비밀번호가 틀렸습니다.";
        }
    }

}
