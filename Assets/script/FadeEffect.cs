using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeEffect : MonoBehaviour
{ 
    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime; // fadeSpeed 값이 10이면 1초 (값이 클수록 빠름)
    public Image image; // 페이드 효과에 사용되는 검은 바탕 이미지
    
    public void Awake()
    {
        // Fade In. 배경의 알파값이 1에서 0으로 (화면이 점점 밝아진다)
        StartCoroutine(Fade(1, 0));

        // Fade Out. 배경으 알파값이 0에서 1로 (화면이 점점 어두워진다)
        // StartCoroutine(Fade(0, 1));
    }
    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while ( percent < 1)
        {
            // fadeTime으로 나누어서 fadeTime 시간 동안
            // percent 값이 0에서 1로 증가하도록 함
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            // 알파값을 start부터 end 까지 fadeTime 시간 동안 변화시킨다
            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }
}
