using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Admob : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;

    void Start(){
         // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
        ShowAd();
        RequestInterstitial();
        ShowInterstitial();
    }

    // SHOW BANNER.
    public void ShowAd(){
        this.RequestBanner();
    }

        private void RequestBanner()
    {
        #if UNITY_ANDROID
            string adUnitId = "ca-app-pub-3940256099942544/6300978111";
        #elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
        #else
            string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    // SHOW INTERSTITIAL.
    private void ShowInterstitial(){
        if(this.interstitial.IsLoaded()){
            Time.timeScale = 0;
            this.interstitial.Show();
        }else{
            Debug.Log("Interstitial is not loaded");
        }
    }
    private void RequestInterstitial()
{
    #if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/1033173712";
    #elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
    #else
        string adUnitId = "unexpected_platform";
    #endif

    // Initialize an InterstitialAd.
    this.interstitial = new InterstitialAd(adUnitId);
    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the interstitial with the request.
    this.interstitial.LoadAd(request);
}

}
