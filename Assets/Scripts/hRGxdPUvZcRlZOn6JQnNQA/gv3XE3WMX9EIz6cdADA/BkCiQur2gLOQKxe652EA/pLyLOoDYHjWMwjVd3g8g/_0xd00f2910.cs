using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0xd00f2910 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public int LoadSceneId;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0xbecc5006.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0xbecc5006.Instance.LoadSceneByIndex(this.LoadSceneId));
    }

    public Button Button;
    public bool IsLoadCurrentScene;
}