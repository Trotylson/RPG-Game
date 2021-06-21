namespace GameByMe
{ 
    class LightHealing : Spells
    {
        public LightHealing()
        {
            SpellName = "Light healing";
            KindOfSpell = "Heal";
            LowerHitTreshold = 20;
            UpperHitTreshold = 30;
            ManaUsage = 20;
        }
    }
}
