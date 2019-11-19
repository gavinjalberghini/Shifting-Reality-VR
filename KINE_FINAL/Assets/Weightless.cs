﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weightless : MonoBehaviour
{

    private SteamVR_TrackedController _controller;
    private GameObject _player;
    private Rigidbody _playerRigid;
    private bool toggled = true;

    // Start is called before the first frame update
    void Start()
    {

        _controller = GetComponent<SteamVR_TrackedController>();
        _player = GameObject.Find("/Player");
        _playerRigid = _player.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_controller.gripped)
        {
            if (!toggled)
            {
                if(_playerRigid.useGravity)
                    _playerRigid.useGravity = false;
                else
                    _playerRigid.useGravity = true;
            }

            toggled = true;
        }
        else
        {
            toggled = false;
        }
    }
}
