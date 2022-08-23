using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Core;
using UnityEngine;
using UnityEngine.UI;

public class ShowImage : MonoBehaviour
{
    [SerializeField] private GameObject image;

    private void Awake()
    {
        PublishSubscribe.Instance.Subscribe<Show>(TerimaPesan);
    }
    private void OnDestroy()
    {
        PublishSubscribe.Instance.Unsubscribe<Show>(TerimaPesan);
    }
    public void TerimaPesan(Show pesan)
    {
        Debug.Log("Trigger");
        Debug.Log(pesan);

        if (image.activeInHierarchy){
            image.SetActive(false);
        }
        else{
            image.SetActive(true);
        }
    }
}
