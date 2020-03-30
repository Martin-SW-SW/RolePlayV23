namespace RolePlayV23
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            CharacterGroup redTeam = new CharacterGroup("Team Red");
            redTeam.AddCharacter(new damager("Angor", 100, 15, 25));
            redTeam.AddCharacter(new defender("Zurin", 85, 18, 30));

            CharacterGroup greenTeam = new CharacterGroup("Team Green");
            greenTeam.AddCharacter(new damager ("Baldur", 120, 12, 18));
            greenTeam.AddCharacter(new defender("Eliza", 80, 20, 35));

            BattleHandler.DoBattle(redTeam, greenTeam);

            // The LAST line of code should be ABOVE this line
        }
    }
}