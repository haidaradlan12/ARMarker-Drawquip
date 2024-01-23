using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public RectTransform PMenuG, PButton, PHint1, PHint2, PInfo1, PInfo2;

    // Start is called before the first frame update
    void Start()
    {
        PMenuG.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PHint1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PHint2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        PInfo1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PInfo2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
    }
    public void ButtonKembali()
    {
        PMenuG.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PButton.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PHint1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PHint2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        PInfo1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PInfo2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
    }
    public void ButtonHint()
    {
        PMenuG.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        PButton.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PHint1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PHint2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PInfo1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PInfo2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
    }
    public void ButtonInfo()
    {
        PMenuG.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        PButton.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PHint1.DOAnchorPos(new Vector2(2500, 0), 1.0f);
        PHint2.DOAnchorPos(new Vector2(-2500, 0), 1.0f);
        PInfo1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PInfo2.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }

    public void ButtonPindahScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ButtonKeluar()
    {
        Application.Quit();
    }
}