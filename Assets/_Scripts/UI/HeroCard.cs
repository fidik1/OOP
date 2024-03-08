using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class HeroCard : MonoBehaviour
{
    public Hero Hero { get; set; }
    [SerializeField] private Image _image;
    [SerializeField] private TMP_Text _nameText;

    public event Action<HeroCard> Clicked;

    public void SetHero(Hero hero)
    {
        Hero = hero;
        _image.sprite = Hero.EntityData.Icon;
        _nameText.text = Hero.EntityData.Name;
    }

    public void OnClick()
    {
        Clicked?.Invoke(this);
    }
}
