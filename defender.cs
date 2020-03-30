namespace RolePlayV23
{
    public class defender : Character
    {
        public defender(string name, int hitpoints, int minDamage, int maxDamage) : base(name, hitpoints, minDamage, maxDamage)
        {}
        protected override int ReceiveDamageModifyChance
         {
             get {return 45;}
         }
         protected override int CalculateModifiedReceivedDamage(int receivedDamage)
        {
            return receivedDamage/2;
        }


    }
}