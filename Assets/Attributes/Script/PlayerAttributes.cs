namespace PaddleHanks.Attributes.Script
{
    /// <summary>
    /// Lewis Simmonds
    /// 16/03/2021
    /// Class that controls all of the player attributes
    /// </summary>
    public class PlayerAttributesController
    {
        public PlayerAttribute Comfort;
        public PlayerAttribute Health;
        public PlayerAttribute Hunger;
        public PlayerAttribute Thirst;


        public PlayerAttributesController(float comfort, float health, float hunger, float thirst)
        {
            Comfort = new PlayerAttribute(5f, comfort);
            Health = new PlayerAttribute(10f, health);
            Hunger = new PlayerAttribute(5f, hunger);
            Thirst = new PlayerAttribute(5f, thirst);
        }
    }
}
