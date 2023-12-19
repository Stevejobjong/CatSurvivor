using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject enemySpawn;

    [Header("Scene")]
    public GameObject _Player;
    public GameObject _NPC;
    public GameObject _Resources;
    public GameObject _CampFire;
    public GameObject _EventSystem;
    public GameObject _Airplane;
    public GameObject _Environments;
    public GameObject _UI;
    public GameObject _Water;
    public GameObject _Fishingrod;
    public GameObject _Pickaxe;

    private void Awake()
    {
        if(Instance == null)
            Instance = this;
        InitSceneInstance();
    }

    private void InitSceneInstance()
    {
        _Player = Instantiate(_Player, new Vector3(14.2f, 0.2f, 33.61f), Quaternion.identity);
        _NPC = Instantiate(_NPC, new Vector3(4.57f, 0f, 6.02f), Quaternion.identity);
        _Resources = Instantiate(_Resources);
        _CampFire = Instantiate(_CampFire, new Vector3(9.83f, 0.293f, 1.76f), Quaternion.identity);
        _EventSystem = Instantiate(_EventSystem);
        _Airplane = Instantiate(_Airplane, new Vector3(31.93f, 0f, -23.23f), Quaternion.identity);
        _Environments = Instantiate(_Environments);
        _UI = Instantiate(_UI);
        _Water = Instantiate(_Water);
        _Fishingrod = Instantiate(_Fishingrod, new Vector3(14.2f, 0.2f, 33.61f), Quaternion.identity);
        _Pickaxe = Instantiate(_Pickaxe, new Vector3(13.2f, 0.2f, 33.61f), Quaternion.identity);
    }

}