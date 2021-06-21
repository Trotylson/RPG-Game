namespace GameByMe
{
    interface ISpells
    {
        string Spell { get; set; }
        string SpellName { get; set; }
        int LowerHitTreshold { get; set; }
        int UpperHitTreshold { get; set; }
        int ManaUsage { get; set; }
        int Damage { get; set; }
        int Healing { get; set; }
        string KindOfSpell { get; set; }

        void UseSpell(Character character1, Character character2);
        void AskForSpell();
        void CastingBuffor();
        void ShowEffectDamage(Character character1, Character character2);
        void ShowEffectHealing(Character character1, Character character2);
        void Cast(Character character1, Character character2);
    }
}
