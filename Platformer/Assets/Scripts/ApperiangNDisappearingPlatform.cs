using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApperiangNDisappearingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject appNDisappPlatformPlatform;

    [SerializeField] private float intervalBetweenAppNDisapp;

    IEnumerator Start()
    {
        while (true)
        { 
        yield return new WaitForSeconds(intervalBetweenAppNDisapp);
        appNDisappPlatformPlatform.SetActive(!appNDisappPlatformPlatform.activeSelf);
        }
    }
}
