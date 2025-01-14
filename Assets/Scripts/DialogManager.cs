using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI subtitleText; 
    private Coroutine currentCoroutine;

    void Start()
    {
        // Пример вызова субтитров
        ShowSubtitle("Привет! Это пример субтитров.", 5f);
    }

    public void ShowSubtitle(string text, float duration)
    {
        if (currentCoroutine != null)
        {
            StopCoroutine(currentCoroutine);
        }
        currentCoroutine = StartCoroutine(ShowSubtitleCoroutine(text, duration));
    }

    private IEnumerator ShowSubtitleCoroutine(string text, float duration)
    {
        subtitleText.text = text;
        subtitleText.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(duration);
        
        subtitleText.gameObject.SetActive(false);
    }
}