namespace PaddleHanks.Attributes.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Class holds player attributes
    /// </summary>
    public class PlayerAttribute
    {
        private float _bottomValueRange, _topValueRange, _attribute;

        public PlayerAttribute(float topValueRange, float attributeValue)
        {
            _topValueRange = topValueRange;
            Attribute = attributeValue;
        }

        public float Attribute
        {
            get => _attribute;
            set
            {
                if (_attribute + value > _topValueRange)
                {
                    _attribute = _topValueRange;
                }
                else
                {
                    _attribute += value;
                }
            }
        }
    }
}