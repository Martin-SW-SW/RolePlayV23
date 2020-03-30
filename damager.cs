namespace RolePlayV23
{
    public class damager : Character
    {
        public damager(string name, int hitpoints, int minDamage, int maxDamage) : base(name, hitpoints, minDamage, maxDamage)
        {}
        protected override int DealDamageModifyChance
         {
             get {return 40;}
         }
         protected override int CalculateModifiedDealDamage(int DealtDamage)
        {
            return DealtDamage *2;
        }


    }
}