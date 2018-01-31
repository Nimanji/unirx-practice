// ==============================
// @author Nimanji (Indies a.k.a)
// ==============================

using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

using Assets.Scripts.Models;

// ==============================
// ButtonPresenter
// ==============================
namespace Assets.Scripts.Presenters
{
    public class ButtonPresenter : MonoBehaviour
    {
        // View (UI)
        public Button up_button;
        public Button down_button;
        public Text count_text;

        // Model
        private ButtonModel _btn_model;

        // start
        void Start ()
        {
            // Model登録
            this._btn_model = new ButtonModel();
            // 加算ボタン押下時のアクション作成
            this.up_button.OnClickAsObservable()
                .Subscribe(_ => this._btn_model.upCounter());
            // 減少ボタン押下時のアクション作成
            this.down_button.OnClickAsObservable()
                .Subscribe(_ => this._btn_model.downCounter());
            // ButtonModelのpush_countが変化したらテキストを更新
            this._btn_model.push_count
                .Subscribe(num => this.count_text.text = num.ToString());
        }
    }
}