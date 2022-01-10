using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private Slider hpSlider;
    [SerializeField] private PlayerController player;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdateHealthUI()
    {
        hpSlider.maxValue = player.maxHealth;
        hpSlider.value = player.currentHealth;
    }
}
