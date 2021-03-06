﻿using UnityEngine;

public class BattleEntrance : MonoBehaviour
{
    public static BattleEntrance Instance { private set; get; }

    [SerializeField]
    private GameObject container;

    void Awake()
    {
        Instance = this;

        Application.targetFrameRate = 60;

        container.SetActive(false);

        ResourceLoader.Load(LoadOver);
    }

    private void LoadOver()
    {
        container.SetActive(true);
    }

    public void Online()
    {
        container.SetActive(false);

        BattleOnline.Instance.Init();
    }

    public void Local()
    {
        container.SetActive(false);

        BattleLocal.Instance.ServerStart();
    }

    public void Show()
    {
        container.SetActive(true);
    }
}
