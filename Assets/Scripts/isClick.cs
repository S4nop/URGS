﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isClick : MonoBehaviour {
    private bool isClicked = false;

    private void Start()
    {
        isClicked = false;
    }

    public void onClicked()
    {
        isClicked = true;
        StartCoroutine("clickWait");
    }

    IEnumerator clickWait()
    {
        yield return new WaitForSeconds(0.5f);
        isClicked = false;
    }

    public bool getIsClicked()
    {
        return isClicked;
    }
}
