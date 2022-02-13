using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADSManager : MonoBehaviour
{

    private bool _isInterstitialReady = false;
    [SerializeField] Player player;
    [SerializeField] GameManager manager;
    private string AndroidKey = "85460dcd";
    void Start()
    {
        IronSource.Agent.init(AndroidKey);
        IronSource.Agent.loadBanner(new IronSourceBannerSize(320, 50), IronSourceBannerPosition.TOP);
        IronSourceEvents.onInterstitialAdReadyEvent += OnInterstitialLoaded;
        IronSourceEvents.onInterstitialAdLoadFailedEvent += OnLoadInterstitialFailed;
        IronSourceEvents.onInterstitialAdShowSucceededEvent += OnInterstitialShowSuccess;
        IronSourceEvents.onInterstitialAdClosedEvent += OnInterstitialClosed;
        player.DeadAction += ShowInterstitial;
        manager.GoToMenuAction += ShowInterstitial;
    }

    private void OnInterstitialLoaded()
    {
        _isInterstitialReady = true;
    }

    private void OnInterstitialClosed()
    {
        IronSource.Agent.loadInterstitial();
    }

    private void OnLoadInterstitialFailed(IronSourceError error)
    {
        Debug.LogError($"Interstitial load failed! Reason - {error.getDescription()}");
    }

    private void OnInterstitialShowSuccess()
    {
        _isInterstitialReady = false;
    }

    private void ShowInterstitial()
    {
        if (_isInterstitialReady)
        {
            IronSource.Agent.showInterstitial();
        }
    }
}

