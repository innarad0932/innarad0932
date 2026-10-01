using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xcb53ffe7;

public class _0xf905b1bd : MonoBehaviour
{
    public int CurrentPopIndex;
    private void _0xeb9b7953()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public List<int> LastPopIndexes = new();
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xf905b1bd>();
    }

    public void _0x4a3f24e3()
    {
        this.LastPopIndexes.Clear();
        this._0x4d46994f();
        foreach (GameObject _0x5ecbf2d6 in this.GameObjectsToHide)
            if (_0x5ecbf2d6 != null)
                _0x5ecbf2d6.SetActive(true);
        this._0x63ea31b6();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x673f471c _0xdad5f404 in this.Pops)
            if (_0xdad5f404 != null)
                _0xdad5f404.gameObject.SetActive(true);
    }

    public static _0xf905b1bd Instance;
    public void _0x4d015912()
    {
        this.LastPopIndexes.RemoveAll(_0x4ed26cd9 => _0x4ed26cd9 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x4a3f24e3();
        else
            this._0x6698f986(this.LastPopIndexes.Last());
    }

    public void _0x6698f986(int _0x51ab9445)
    {
        this.CurrentPopIndex = _0x51ab9445;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x4d46994f(true);
        this._0xeb9b7953();
        this.Pops[_0x51ab9445].Show();
        foreach (GameObject _0x0dd4aea0 in this.GameObjectsToHide)
            _0x0dd4aea0.SetActive(false);
    }

    private void _0x63ea31b6()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    private void _0x4d46994f(bool _0xa74a2f37 = false)
    {
        for (int _0x587ffc45 = 0; _0x587ffc45 < this.Pops.Count; ++_0x587ffc45)
            if (this.Pops[_0x587ffc45] != null && !(_0x587ffc45 == this.CurrentPopIndex && _0xa74a2f37))
                this.Pops[_0x587ffc45]._0x41aed204();
    }

    public _0x673f471c _0x399c969a(int _0x87dad27b)
    {
        return this.Pops[_0x87dad27b];
    }

    public float ScaleDuration = 0.4f;
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public List<GameObject> GameObjectsToHide;
    public GameObject BlurBackground;
    public List<_0x673f471c> Pops;
}