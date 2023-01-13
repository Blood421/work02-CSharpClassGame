using System;
using CsharpLearningGame.UI.PowerGage;
using UniRx;
using UnityEngine;

namespace CsharpLearningGame.MoveTiming
{
    public class MoveTimingController : MonoBehaviour
    {
        private Subject<(Vector2 dir,float power)> onMoveTiming = new Subject<(Vector2 dir, float power)>();
        public IObservable<(Vector2 dir, float power)> OnMoveTiming() => onMoveTiming;
        public void Move(Vector2 dir)
        {
            //•ûŒü‚Æ—Í
            onMoveTiming.OnNext((dir,PowerGageModelPresenter.GetPower()));
        }
    }
}
