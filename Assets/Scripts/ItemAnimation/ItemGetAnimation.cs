using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEditor.Animations;

namespace Item
{
    public class ItemGetAnimation : MonoBehaviour
    {
        [SerializeField]
        GameObject target;

        [SerializeField]
        GameObject itemPrefab;

        /// <summary>
        /// アイテム取得時のアニメーション
        /// </summary>
        /// <returns></returns>
        public void ItemGetAsync()
        {

        }
    }
}
