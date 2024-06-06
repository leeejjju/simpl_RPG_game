using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class IntroToVillage : MonoBehaviour
{
    [SerializeField] Image image = null;
    [SerializeField] TextMeshProUGUI text = null;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FadeTextToFullAlpha(1.5f, image, text));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator FadeTextToFullAlpha(float t, Image i, TextMeshProUGUI j)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        j.color = new Color(j.color.r, j.color.g, j.color.b, 0);

        while (i.color.a < 1.0f || j.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a + (Time.deltaTime / t));
            
            yield return null;
        }
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        j.color = new Color(j.color.r, j.color.g, j.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            j.color = new Color(j.color.r, j.color.g, j.color.b, j.color.a - (Time.deltaTime / t));
            yield return null;
        }
        // SceneManager.LoadScene("button_UI");
        SceneManager.LoadScene("login");
    }

}
