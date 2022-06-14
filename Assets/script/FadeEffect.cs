using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeEffect : MonoBehaviour
{ 
    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime; // fadeSpeed ���� 10�̸� 1�� (���� Ŭ���� ����)
    public Image image; // ���̵� ȿ���� ���Ǵ� ���� ���� �̹���
    
    public void Awake()
    {
        // Fade In. ����� ���İ��� 1���� 0���� (ȭ���� ���� �������)
        StartCoroutine(Fade(1, 0));

        // Fade Out. ����� ���İ��� 0���� 1�� (ȭ���� ���� ��ο�����)
        // StartCoroutine(Fade(0, 1));
    }
    private IEnumerator Fade(float start, float end)
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while ( percent < 1)
        {
            // fadeTime���� ����� fadeTime �ð� ����
            // percent ���� 0���� 1�� �����ϵ��� ��
            currentTime += Time.deltaTime;
            percent = currentTime / fadeTime;

            // ���İ��� start���� end ���� fadeTime �ð� ���� ��ȭ��Ų��
            Color color = image.color;
            color.a = Mathf.Lerp(start, end, percent);
            image.color = color;

            yield return null;
        }
    }
}
