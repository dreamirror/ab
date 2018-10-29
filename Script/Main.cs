using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigiSky.AssetBundleKit;

public class Main : MonoBehaviour {
    public Sprite imgS;     //先创建个Sprite  设置上图片 
                            // Use this for initialization
    void Start () {


	}
    public System.Action<Object> call;

    public static void Call_back(Object obj) {
        Debug.Log("call back");

    }
   


    private void Awake()
    {
        // 创建GameObject对象                 

        GameObject gameObj = GameObject.Find("Cube");
        System.Action<Object> calls = Call_back;
        AssetBundleManager.Initialization();
        AssetBundleManager mgr = AssetBundleManager.GetSingel();
        mgr.InitManifest();
        mgr.LoadAssetAsyc("Assets/StreamingAssets/assetbundles/","pic", calls);
        UnityEngine.Object pic = mgr._LoadSingleAssetInternal("Assets/StreamingAssets/assetbundles/pic/","bg/2.jpg");
        if (pic != null) {
            Debug.Log("pic is not null");
        }
    }



    // Update is called once per frame
    void Update () {
		
	}
}
