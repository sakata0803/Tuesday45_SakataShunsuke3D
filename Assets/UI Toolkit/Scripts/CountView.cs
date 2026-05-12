using UnityEngine;
using UnityEngine.UIElements;

public class CountView : MonoBehaviour
{
    [SerializeField] private CountModel _countModel;
    [SerializeField] private UIDocument _uiDoc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // UI Document の root を取得
        var root = _uiDoc.rootVisualElement;
        // ボタンを取得
        var countUpButton = root.Q<Button>("button-countup");
        var countDownButton = root.Q<Button>("button-countdown");
        // ボタンを押したときの処理
        countUpButton.clickable.clicked += () =>
        {
            if (_countModel.Counter < 100)
                _countModel.Counter++;
        };
        countDownButton.clickable.clicked += () =>
        {
            if (_countModel.Counter > 0)
                _countModel.Counter--;
        };
    }
}
