using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroCardPlacer : MonoBehaviour
{
    [SerializeField] private Hero[] _heroes;
    [SerializeField] private HeroCard _heroCardPrefab;
    [SerializeField] private Transform _parent;

    [SerializeField] private Image _imageFullHeight;

    private void Start()
    {
        foreach (Hero hero in _heroes)
        {
            HeroCard heroCard = Instantiate(_heroCardPrefab, _parent);
            heroCard.SetHero(hero);
            heroCard.Clicked += ChangeImageFullHeight;
        }
    }

    private void ChangeImageFullHeight(HeroCard heroCard)
    {
        _imageFullHeight.sprite = heroCard.Hero.EntityData.IconFullHeight;
    }
}
