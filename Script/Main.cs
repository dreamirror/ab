using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigiSky.AssetBundleKit;
using UnityEngine.UI;
public class Main : MonoBehaviour {
    public GameObject myGgameObj;     //先创建个Sprite  设置上图片 
    public Image image;            // Use this for initialization

    void Start () {


	}
    public System.Action<Object> call;

    public void Call_back(Object obj) {
        Debug.Log("call back");
        //Object pic = obj.LoadAsset("1.jpg");
        var texture = obj as Texture2D;
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, 2048, 1024), Vector2.zero);
        if (sp != null) {
            Debug.Log("******************");
        }
        image.sprite = sp;
    }

    private void Awake()
    {
        // 创建GameObject对象                 

        GameObject gameObj = GameObject.Find("Image");
        image = gameObj.GetComponent<Image>();
        if (image != null) {
            Debug.Log("@@@@@@@@@@@@@");
        }
        System.Action<Object> calls = Call_back;
        AssetBundleManager.Initialization();
        AssetBundleManager mgr = AssetBundleManager.GetSingel();
        mgr.InitManifest();
        mgr.LoadAssetAsyc("Assets/StreamingAssets/assetbundles/pic/bg/","1", calls);
        //UnityEngine.Object pic = mgr._LoadSingleAssetInternal("Assets/StreamingAssets/assetbundles/pic/","2.jpg");
    }



    // Update is called once per frame
    void Update () {
		
	}
}
