using DG.Tweening;
using UnityEngine;

namespace CsharpLearningGame.FloorAnimation
{
    public class FloorSwingAnimationController : MonoBehaviour
    {
        //アニメーション用
        [SerializeField] private float delay;
        [SerializeField] private Vector2 angleRange;
        [SerializeField] private float duration;
        [SerializeField] private Ease ease;

        private Sequence sq;
        private void Awake()
        {
            //初期化
            sq = DOTween.Sequence();
            transform.Rotate(0,0,angleRange.x);
        }

        private void Start()
        {
            //DOTweenアニメーション設定
            sq.Append(transform.DOLocalRotate(new Vector3(0, 0, angleRange.y), duration / 2));
            sq.Append(transform.DOLocalRotate(new Vector3(0, 0, angleRange.x), duration / 2));
            sq.SetEase(ease);
            sq.SetLoops(-1, LoopType.Restart);
            sq.SetDelay(delay);
        }

        private void OnDestroy()
        {
            //終わったら破棄
            sq.Kill();
        }
    }
}
