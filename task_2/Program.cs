namespace task_2
{
    internal class Program
    {
        public class Player
        {
            public delegate void PlayerDamaged(int dmg, int currentHP);
            public event PlayerDamaged DamageReceived;
            public int HP { get; private set; } = 100;
            public void TakeDamage(int dmg)
            {
                HP -= dmg;
                if (HP < 0) HP = 0;
                DamageReceived?.Invoke(dmg, HP);
            }

        }
        public class GameLogger
        {
            public void Damage(int dmg, int hp)
            {
                Console.WriteLine($"dmg: {dmg}, hp: {hp}");
            }
        }
        public class SoundSystem
        {
            public void DamageSound(int dmg, int hp)
            {
                if (hp <= 20) Console.WriteLine("big ew");
                else Console.WriteLine("lil ew");
            }
        }
        public class AchivementSystem
        {
            public void DamageAchivements(int dmg, int hp)
            {
                if (hp <= 50) Console.WriteLine("half death");
                else if (hp <= 0) Console.WriteLine("first death");
            }
        }
        public class UIHealthBar
        {
            public void ShowHealth(int dmg, int hp)
            {
                Console.WriteLine($"HP: {hp}");
            }
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            GameLogger gameLogger = new GameLogger();
            SoundSystem soundSystem = new SoundSystem();
            AchivementSystem achivementSystem = new AchivementSystem();
            UIHealthBar healthBar = new UIHealthBar();

            player.DamageReceived += gameLogger.Damage;
            player.DamageReceived += soundSystem.DamageSound;
            player.DamageReceived += achivementSystem.DamageAchivements;
            player.DamageReceived += healthBar.ShowHealth;

            player.TakeDamage(10);
            player.TakeDamage(20);
            player.TakeDamage(30);
            player.TakeDamage(25);
        }
    }
}
