using UnityEngine;

namespace PaddleHanks.Items.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Base class for all materials.
    /// </summary>
    [CreateAssetMenu(fileName = "Material",menuName = "ScriptableObjects/Items/Material")]
    public class Material : Item
    {
        [Tooltip("What type of material should this item be.")]
        public MaterialType typeOfMaterial;
        public enum MaterialType
        {
            Wood,
            Metal
        }
    }
}