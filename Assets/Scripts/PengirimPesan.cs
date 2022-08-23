using System.Collections;
using System.Collections.Generic;
using Agate.MVC.Core;
using UnityEngine;

public class PengirimPesan : MonoBehaviour
{
    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            PublishSubscribe.Instance.Publish<SomePesan>(new SomePesan(5, "test"));
        }
    }
}

public struct SomePesan{
    public int idPesan;
    public string isiPesan;

    public SomePesan(int idPesan, string isiPesan){
        this.idPesan = idPesan;
        this.isiPesan = isiPesan;
    }
}