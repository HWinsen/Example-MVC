using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenerimaPesan : MonoBehaviour
{
    private void Awake()
    {
        PublishSubscribe.Instance.Subscribe<SomePesan>(TerimaPesan);
    }
    private void OnDestroy()
    {
        PublishSubscribe.Instance.Unsubscribe<SomePesan>(TerimaPesan);
    }
    public void TerimaPesan(SomePesan pesan)
    {
        Debug.Log("Pesan : " + pesan.idPesan + "|" + pesan.isiPesan);
    }
}
