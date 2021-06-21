namespace GameByMe
{
    class Fireball : Spells
    {
        public Fireball()
        {
            SpellName = "Fireball";
            KindOfSpell = "Damage";
            LowerHitTreshold = 20;
            UpperHitTreshold = 30;
            ManaUsage = 45;
        }
    }
}
