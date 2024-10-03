using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AdiveryUnity;

public class MyAdvirey : MonoBehaviour
{
string APP_ID = "42f8fcf3-7729-42d9-9e74-66750c7ef016";
 string PLACEMENT_ID = "ea8dbbe3-4197-4bc4-9a39-1283f1a11f70";




   

    AdiveryListener listener;

    public void Start()
    {
        Adivery.Configure(APP_ID);

        Adivery.PrepareInterstitialAd(PLACEMENT_ID);
        listener = new AdiveryListener();

        listener.OnError += OnError;
        listener.OnInterstitialAdLoaded += OnInterstitialAdLoaded;

        Adivery.AddListener(listener);
    }

    public void OnInterstitialAdLoaded(object caller, string placementId)
    {
        // Interstitial ad loaded
    }

    public void OnError(object caller, AdiveryError error)
    {
        Debug.Log("placement: " + error.PlacementId + " error: " + error.Reason);
    }





    public void AdCopy()
    {
        Adivery.PrepareInterstitialAd(PLACEMENT_ID);

    }



    public void ShowAd()
    {

        if (Adivery.IsLoaded(PLACEMENT_ID))
        {
            Adivery.Show(PLACEMENT_ID);
        }

    }
}
