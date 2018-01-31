// ==============================
// @author Nimanji (Indies a.k.a)
// ==============================

using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

// ==============================
// ButtonModel
// ==============================
namespace Assets.Scripts.Models
{
    public class ButtonModel
    {
        // プロパティ
        public ReactiveProperty<int> push_count {get; private set;}

        // コンストラクタ
        public ButtonModel ()
        {
            this.push_count = new ReactiveProperty<int>();
            this.push_count.Value = 0;
        }

        // カウントを加算する
        public void upCounter ()
        {
            this.push_count.Value++;
        }

        // カウントを減少する
        public void downCounter ()
        {
            this.push_count.Value--;
        }
    }
}