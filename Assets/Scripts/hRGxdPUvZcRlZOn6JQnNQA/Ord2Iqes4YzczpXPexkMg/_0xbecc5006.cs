using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xcb53ffe7;

public class _0xbecc5006 : MonoBehaviour
{
    public void _0xdb555168()
    {
        _0x07e12f3a._0xa6621840 = true;
    }

    public void _0x2d4438f7()
    {
        this.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
    }

    public int _0xc3eb6597 => SceneManager.GetActiveScene().buildIndex;

    private static _0x34be3882 GAME_INDEX_SETTINGS(int _0xc2b6209c)
    {
        return _0x34be3882.ALL_SCENES_SETTING_SINGLETONS[_0xc2b6209c];
    }

    public static bool IsAfterLevelComplete;
    public Transform EnvironmentWithTweensToToggle;
    public Canvas MainCanvas;
    public void _0x934501b5()
    {
        foreach (_0x765db0bd _0xa52e7b81 in this.MoneyCountContainers)
            _0xa52e7b81._0x83e43a15();
    }

    public Button DeleteProgressDataButton;
    public Transform Environment;
    [HideInInspector]
    public List<_0x765db0bd> MoneyCountContainers = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xbecc5006>();
        this.RootGameObject = GameObject.FindWithTag(_0x33ffabcf._0x649fed74(new byte[4] { 1, 60, 60, 39 }, 83));
        if (this._0xc3eb6597 == _0xd8635e47.SCENE_0)
            this._0x217d0da4(true);
        else
            this._0x217d0da4(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x765db0bd>(true).ToList();
    }

    private void _0x39878121()
    {
        IsAfterLevelComplete = true;
        Instance.LoadSceneByIndex(_0xd8635e47.SCENE_0);
    }

    private static void MakeGrid(List<RectTransform> _0xe9e69ae1, AspectRatioFitter _0x0aaf32e7, float _0x8f6466e6, int _0x537edb41, int _0xb138d629)
    {
        _0x0aaf32e7.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x0aaf32e7.aspectRatio = _0x8f6466e6;
        foreach (RectTransform _0xfedf05b2 in _0xe9e69ae1)
        {
            int _0x24d2fd41 = _0xfedf05b2.transform.GetSiblingIndex();
            _0xfedf05b2.anchorMin = new Vector3(Mathf.FloorToInt((float)_0x24d2fd41 % _0x537edb41) * (1f / _0x537edb41), (_0xb138d629 - (Mathf.FloorToInt((float)_0x24d2fd41 / _0x537edb41) % _0xb138d629 + 1f)) * (1f / _0xb138d629));
            _0xfedf05b2.anchorMax = new Vector3(Mathf.FloorToInt((float)_0x24d2fd41 % _0x537edb41 + 1f) * (1f / _0x537edb41), (_0xb138d629 - Mathf.FloorToInt((float)_0x24d2fd41 / _0x537edb41) % _0xb138d629) * (1f / _0xb138d629));
            _0xfedf05b2.offsetMin = Vector2.zero;
            _0xfedf05b2.offsetMax = Vector2.zero;
        }
    }

    private void _0x5b47ee3f(Transform _0x9ab5f33c)
    {
        Transform[] _0x7e5cb3c7 = _0x9ab5f33c.GetComponentsInChildren<Transform>();
        foreach (Transform _0xe1acab26 in _0x7e5cb3c7)
            if (_0xe1acab26 != null && DOTween.IsTweening(_0xe1acab26))
            {
                if (this._0xfe7dd6e9)
                    DOTween.Play(_0xe1acab26);
                else
                    DOTween.Pause(_0xe1acab26);
            }
    }

    private IEnumerator _0x775809c0(string _0xe078448b)
    {
        _0x3e2c0a04.Instance._0x83b29986(_0x51899f64.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x85213f7c = SceneManager.LoadSceneAsync(_0xe078448b);
        while (!_0x85213f7c.isDone)
            yield return null;
    }

    private void _0xb594694f(bool _0x82ffcdf2)
    {
        Rigidbody2D[] _0xad2b788c = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0x9735c1d8 in _0xad2b788c)
            if (_0x82ffcdf2)
                _0x9735c1d8.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0x9735c1d8.constraints = RigidbodyConstraints2D.None;
    }

    public bool _0xfe7dd6e9 { get; private set; }

    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
    public static _0x34be3882 _0x07e12f3a => _0x34be3882.ALL_SCENES_SETTING_SINGLETONS[Instance._0xc3eb6597];

    private static void ExitGame()
    {
        Application.Quit();
    }

    public void LoadSceneByIndex(int _0x20d3d648)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0xe524f10b(_0x20d3d648));
    }

    public Button ShowResetTutorialButton;
    public static _0xbecc5006 Instance;
    public void _0x217d0da4(bool _0xc30fd2a9)
    {
        this._0xfe7dd6e9 = _0xc30fd2a9;
        this._0xb594694f(!this._0xfe7dd6e9);
        Physics2D.simulationMode = this._0xfe7dd6e9 ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0x5b47ee3f(this.EnvironmentWithTweensToToggle);
    }

    private static _0x34be3882 _0xc5fd7e1e => _0x34be3882.ALL_SCENES_SETTING_SINGLETONS[0];

    public static bool IsAfterLevelFailed = false;
    private void Start()
    {
        if (this._0xc3eb6597 != _0xd8635e47.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance.LoadSceneByIndex(_0xd8635e47.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0x07e12f3a._0xa6621840 = false;
            _0xf905b1bd.Instance._0x4a3f24e3();
            _0x3e2c0a04.Instance._0x83b29986(_0x51899f64.TUTORIAL0);
        });
    }

    private IEnumerator _0xe524f10b(int _0xf176e113)
    {
        _0x3e2c0a04.Instance._0x83b29986(_0x51899f64.SPLASH);
        AsyncOperation _0xe7f796d1 = SceneManager.LoadSceneAsync(_0xf176e113);
        while (!_0xe7f796d1.isDone)
            yield return null;
    }
}

internal static class _0x33ffabcf
{
    internal static string _0x649fed74(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}