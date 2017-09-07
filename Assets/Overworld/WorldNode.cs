﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class WorldNode : MonoBehaviour {
	public Connection[] connections;
	public string sceneName;
}

[Serializable]
public class Connection{
    public WorldNode node;
    public Vector2 direction = new Vector2(1, 0);
}