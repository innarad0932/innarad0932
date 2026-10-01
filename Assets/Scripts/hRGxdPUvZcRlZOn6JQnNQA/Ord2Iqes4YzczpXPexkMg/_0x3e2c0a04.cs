using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xcb53ffe7;

public class _0x3e2c0a04 : MonoBehaviour
{
    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void _0x674800a7()
    {
        this._0x9e377206(_0x51899f64.SPLASH);
        if (_0xbecc5006.Instance._0xc3eb6597 == _0xd8635e47.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x2849c271.Instance.DefaultAnimationTime);
        }
    }

    public int CurrentPanelIndex;
    public void _0x83b29986(int _0xccd8d988)
    {
        this._0x9e7f8fe6(_0xccd8d988);
        this._0x05c4e894(_0xccd8d988);
        this.CurrentPanelIndex = _0xccd8d988;
        this.Panels[_0xccd8d988].Show();
    }

    private void _0x9e7f8fe6(int _0x73914bb2)
    {
        this.LastPanelIndexes.Add(_0x73914bb2);
        this.CurrentPanelIndex = _0x73914bb2;
        for (int _0x858ea9c8 = 0; _0x858ea9c8 < this.Panels.Count; _0x858ea9c8++)
            if (_0x858ea9c8 != _0x73914bb2 && this.Panels[_0x858ea9c8] != null)
                this.Panels[_0x858ea9c8]._0x518dbc39();
    }

    public void _0xb81dd567()
    {
        this.LastPanelIndexes.RemoveAll(_0x4ed26cd9 => _0x4ed26cd9 == this.CurrentPanelIndex);
        int _0x6ad60dbf = this.LastPanelIndexes.Last();
        this._0x05c4e894(_0x6ad60dbf);
        this._0x60fdbbd7(_0x6ad60dbf);
        this.CurrentPanelIndex = _0x6ad60dbf;
        this.Panels[_0x6ad60dbf].Show();
    }

    public List<_0x64710ced> Panels;
    private void _0x9e377206(int _0x79ccbaca)
    {
        this._0x9e7f8fe6(_0x79ccbaca);
        this._0x05c4e894(_0x79ccbaca);
        this.CurrentPanelIndex = _0x79ccbaca;
        this.Panels[_0x79ccbaca]._0x2b9b4b04();
    }

    public bool IsShowSplashOnStart = true;
    public void _0x6cb9a7a8(int _0x1c21f81c)
    {
        if (_0x1c21f81c == _0x51899f64.SPLASH && _0xbecc5006.Instance._0xc3eb6597 != _0xd8635e47.SCENE_0)
            _0x2849c271.Instance._0x752c90c0();
        if (_0xbecc5006.Instance._0xc3eb6597 != _0xd8635e47.SCENE_0)
        {
            if (_0x1c21f81c == _0x51899f64.SPLASH || _0x1c21f81c == _0x51899f64.TUTORIAL0)
                _0xbecc5006.Instance._0x217d0da4(false);
            else if (_0x1c21f81c == _0x51899f64.DEFAULT)
                _0xbecc5006.Instance._0x217d0da4(true);
        }
    }

    private void SwitchSplash()
    {
        if (_0x921a4263.Instance.IsTutorialEnabled && !_0xbecc5006._0x07e12f3a._0xa6621840)
            this._0x83b29986(_0x51899f64.TUTORIAL0);
        else
            this._0x83b29986(_0x51899f64.DEFAULT);
    }

    public float StaticBlurMaterialInitialValue;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x3e2c0a04>();
    }

    private void Start()
    {
        this._0x674800a7();
    }

    private _0x64710ced _0xed49765c(int _0x9d6f134d)
    {
        return this.Panels[_0x9d6f134d];
    }

    public static _0x3e2c0a04 Instance;
    public float ScaleDuration = 0.4f;
    private void _0x05c4e894(int _0x5c0a6f46)
    {
        if (_0x5c0a6f46 == _0x51899f64.SPLASH)
            _0x2849c271.Instance._0xce8e70b8();
        if (_0xbecc5006.Instance._0xc3eb6597 == _0xd8635e47.SCENE_0)
        {
        }
    }

    private void _0x60fdbbd7(int _0xdc90179b)
    {
        this.LastPanelIndexes.Add(_0xdc90179b);
        this.CurrentPanelIndex = _0xdc90179b;
        for (int _0x781a89ee = 0; _0x781a89ee < this.Panels.Count; _0x781a89ee++)
            if (_0x781a89ee != _0xdc90179b && this.Panels[_0x781a89ee] != null)
                this.Panels[_0x781a89ee]._0x518dbc39();
    }
}