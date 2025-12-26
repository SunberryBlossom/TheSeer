using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class SeedAddRuneandOracleCardsandMeanings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckId", "ImageKey", "Name", "SuitOrGroup", "Value" },
                values: new object[,]
                {
                    { 124, 4, "", "Fehu", "Frey's Aett", 1 },
                    { 125, 4, "", "Uruz", "Frey's Aett", 2 },
                    { 126, 4, "", "Thurisaz", "Frey's Aett", 3 },
                    { 127, 4, "", "Ansuz", "Frey's Aett", 4 },
                    { 128, 4, "", "Raidho", "Frey's Aett", 5 },
                    { 129, 4, "", "Kenaz", "Frey's Aett", 6 },
                    { 130, 4, "", "Gebo", "Frey's Aett", 7 },
                    { 131, 4, "", "Wunjo", "Frey's Aett", 8 },
                    { 132, 4, "", "Hagalaz", "Hagal's Aett", 9 },
                    { 133, 4, "", "Nauthiz", "Hagal's Aett", 10 },
                    { 134, 4, "", "Isa", "Hagal's Aett", 11 },
                    { 135, 4, "", "Jera", "Hagal's Aett", 12 },
                    { 136, 4, "", "Eihwaz", "Hagal's Aett", 13 },
                    { 137, 4, "", "Perthro", "Hagal's Aett", 14 },
                    { 138, 4, "", "Algiz", "Hagal's Aett", 15 },
                    { 139, 4, "", "Sowilo", "Hagal's Aett", 16 },
                    { 140, 4, "", "Tiwaz", "Tyr's Aett", 17 },
                    { 141, 4, "", "Berkano", "Tyr's Aett", 18 },
                    { 142, 4, "", "Ehwaz", "Tyr's Aett", 19 },
                    { 143, 4, "", "Mannaz", "Tyr's Aett", 20 },
                    { 144, 4, "", "Laguz", "Tyr's Aett", 21 },
                    { 145, 4, "", "Ingwaz", "Tyr's Aett", 22 },
                    { 146, 4, "", "Dagaz", "Tyr's Aett", 23 },
                    { 147, 4, "", "Othala", "Tyr's Aett", 24 }
                });

            migrationBuilder.InsertData(
                table: "Spreads",
                columns: new[] { "Id", "Description", "ImageOverlay", "Name", "SystemTypeId" },
                values: new object[,]
                {
                    { 7, "A single rune for simple questions, daily guidance, or a focused motto to carry through the day.", "", "The Single Rune (Odin's Sight)", 2 },
                    { 8, "The most classic rune spread. It consults the three weavers of fate to show the past, the present, and the path being woven for the future.", "", "The Three Norns (Urd, Verdandi, Skuld)", 2 },
                    { 9, "A comprehensive layout that provides a deeper look into the challenges, influences, and potential outcomes of a complex situation.", "", "The Five Rune Cross", 2 }
                });

            migrationBuilder.InsertData(
                table: "Meanings",
                columns: new[] { "Id", "CardId", "Category", "Content", "DeckId", "IsReversed", "KeyWords" },
                values: new object[,]
                {
                    { 2001, 124, "Love", "A relationship is blossoming with abundance. Share your emotional wealth to attract more affection.", 4, false, "Abundance, Fertility" },
                    { 2002, 124, "Love", "Financial stress or greed is poisoning the romantic air. Be careful not to value possessions over your partner.", 4, true, "Loss, Greed" },
                    { 2003, 124, "Career", "Success is at hand. Hard work is finally paying off in tangible rewards and new opportunities.", 4, false, "Gain, Success" },
                    { 2004, 124, "Career", "Missed opportunities or professional stagnation. You are working hard but seeing little profit.", 4, true, "Stagnation, Setback" },
                    { 2005, 124, "Spiritualism", "Use your inner energy to manifest your desires. The power of creation flows through you.", 4, false, "Creation, Flow" },
                    { 2006, 124, "Spiritualism", "A block in your creative flow. You are focusing too much on the material, neglecting the spirit's fire.", 4, true, "Blocked Energy, Materialism" },
                    { 2007, 124, "Finance", "Steady growth and new income streams. A perfect time for calculated investments.", 4, false, "Wealth, Prosperity" },
                    { 2008, 124, "Finance", "Unexpected expenses or loss of assets. Re-evaluate your spending habits immediately.", 4, true, "Loss, Expenditure" },
                    { 2009, 125, "Love", "Physical attraction and raw passion are strong. A bold move will bring results.", 4, false, "Passion, Vitality" },
                    { 2010, 125, "Love", "Low energy or a lack of will. You may be letting fear or previous wounds dictate your romantic choices.", 4, true, "Weakness, Inhibitions" },
                    { 2011, 125, "Career", "A surge of productivity. You have the strength to tackle any project, no matter how daunting.", 4, false, "Strength, Power" },
                    { 2012, 125, "Career", "You are pushing against a brick wall. A lack of focus or brute force is causing more harm than good.", 4, true, "Misapplied Force, Fatigue" },
                    { 2013, 125, "Spiritualism", "Sudden changes are forcing you to grow. Embrace your wild, untamed nature to find the path.", 4, false, "Transition, Growth" },
                    { 2014, 125, "Spiritualism", "A crisis of confidence. You are disconnected from your primal strength and intuition.", 4, true, "Disconnection, Self-Doubt" },
                    { 2015, 125, "Finance", "Your financial health is improving. Strength lies in taking decisive action now.", 4, false, "Health, Resolve" },
                    { 2016, 125, "Finance", "Financial drain due to lack of oversight. You are losing power over your own resources.", 4, true, "Drain, Instability" },
                    { 2017, 126, "Love", "Protect your boundaries within a relationship, but don't become a wall.", 4, false, "Protection, Boundaries" },
                    { 2018, 126, "Love", "Vulnerability to outside influence. A 'thorn' in the side of the relationship is causing pain.", 4, true, "Betrayal, Defenseless" },
                    { 2019, 126, "Career", "A gateway is appearing. Be patient and wait for the right moment to strike.", 4, false, "Gateway, Patience" },
                    { 2020, 126, "Career", "Impulsive decisions will lead to disaster. You are trying to force a door that is currently locked.", 4, true, "Impulsiveness, Conflict" },
                    { 2021, 126, "Spiritualism", "The thorn protects the rose. Your challenges are teaching you valuable lessons in defense.", 4, false, "Wisdom, Shield" },
                    { 2022, 126, "Spiritualism", "Spiritual arrogance or over-defensiveness. You are creating enemies where none exist.", 4, true, "Ego, Aggression" },
                    { 2023, 126, "Finance", "Be wary of quick deals. A 'giant' risk may be hidden behind an attractive offer.", 4, false, "Caution, Risk" },
                    { 2024, 126, "Finance", "A financial attack or a hidden trap. Your defenses have been breached by negligence.", 4, true, "Trap, Vulnerability" },
                    { 2025, 127, "Love", "Communicate your feelings clearly. A wise conversation will heal a long-standing rift.", 4, false, "Communication, Wisdom" },
                    { 2026, 127, "Love", "Misunderstandings and deceit. Someone is not telling the whole truth in this partnership.", 4, true, "Deceit, Silence" },
                    { 2027, 127, "Career", "Listen to your mentors. An interview or speech will go exceptionally well.", 4, false, "Mentorship, Speech" },
                    { 2028, 127, "Career", "Bad advice or a failure to communicate at work. Watch out for 'word-tricks' from colleagues.", 4, true, "Manipulation, Bad Advice" },
                    { 2029, 127, "Spiritualism", "The voice of the divine. Pay attention to signs and messages from the elders.", 4, false, "Inspiration, Signs" },
                    { 2030, 127, "Spiritualism", "Spiritual confusion. You are ignoring the signs or being misled by a false teacher.", 4, true, "Confusion, Falsehood" },
                    { 2031, 127, "Finance", "A wise investment based on solid information. Ask for professional advice.", 4, false, "Advice, Insight" },
                    { 2032, 127, "Finance", "A financial contract with hidden clauses. Do not sign anything until you've verified the source.", 4, true, "Hidden Terms, Fraud" },
                    { 2033, 128, "Love", "A shared journey or vacation will strengthen your bond and bring new rhythm.", 4, false, "Journey, Progress" },
                    { 2034, 128, "Love", "You and your partner are moving in opposite directions. The path together is blocked.", 4, true, "Incompatibility, Blocked Path" },
                    { 2035, 128, "Career", "Keep your rhythm. Steady progress toward a goal is better than a chaotic sprint.", 4, false, "Rhythm, Strategy" },
                    { 2036, 128, "Career", "Travel delays or a project going off the rails. Your plans lack the necessary timing.", 4, true, "Delays, Chaos" },
                    { 2037, 128, "Spiritualism", "Trust the process. Your soul is on a journey that requires faith in the road ahead.", 4, false, "Faith, Path" },
                    { 2038, 128, "Spiritualism", "A feeling of being lost. You have wandered away from your inner compass.", 4, true, "Lost, Disorientation" },
                    { 2039, 128, "Finance", "Money is in motion. Expect transactions to clear or assets to shift favorably.", 4, false, "Transaction, Motion" },
                    { 2040, 128, "Finance", "A financial deal has stalled. Moving money now will result in losses or high fees.", 4, true, "Stalemate, Bad Timing" },
                    { 2041, 129, "Love", "A new light is being shed on your feelings. Passion is warming the heart.", 4, false, "Clarity, Attraction" },
                    { 2042, 129, "Love", "A flame is dying out. The spark has gone, leaving the relationship cold and dark.", 4, true, "Fading, Coldness" },
                    { 2043, 129, "Career", "Technical mastery. Your skills are sharp and you have the vision to create.", 4, false, "Skill, Vision" },
                    { 2044, 129, "Career", "Creative burnout. You are working in the dark without the right tools or inspiration.", 4, true, "Burnout, Darkness" },
                    { 2045, 129, "Spiritualism", "Enlightenment. A moment of clarity where spiritual concepts make sense.", 4, false, "Knowledge, Light" },
                    { 2046, 129, "Spiritualism", "Intellectual pride. You are blinded by your own 'light' and cannot see the truth.", 4, true, "Blight, Blindness" },
                    { 2047, 129, "Finance", "A bright idea for business. Follow the light of your intuition for profit.", 4, false, "Innovation, Idea" },
                    { 2048, 129, "Finance", "A business concept that lacks substance. Your 'bright idea' will burn out quickly.", 4, true, "Illusion, Failure" },
                    { 2049, 130, "Love", "A true partnership based on equality. Giving and receiving are in perfect harmony.", 4, false, "Partnership, Equality" },
                    { 2050, 130, "Career", "Successful collaborations and contracts. A business relationship will bring mutual profit.", 4, false, "Contract, Alliance" },
                    { 2051, 130, "Spiritualism", "The gift of life. Recognize the sacred exchange between you and the universe.", 4, false, "Sacred, Gift" },
                    { 2052, 130, "Finance", "An unexpected gift or financial support. Balance your books and show gratitude.", 4, false, "Gratitude, Support" },
                    { 2053, 131, "Love", "Happiness and bliss. Your domestic life is harmonious and filled with laughter.", 4, false, "Joy, Bliss" },
                    { 2054, 131, "Love", "Alienation and sorrow. A period of loneliness or a rift with a loved one.", 4, true, "Sorrow, Alienation" },
                    { 2055, 131, "Career", "Success and recognition. Your team is working well together with a positive atmosphere.", 4, false, "Harmony, Success" },
                    { 2056, 131, "Career", "Workplace friction. A project that brought joy has now become a source of anxiety.", 4, true, "Friction, Dissatisfaction" },
                    { 2057, 131, "Spiritualism", "Release of old burdens. You are entering a period of peace and spiritual satisfaction.", 4, false, "Peace, Contentment" },
                    { 2058, 131, "Spiritualism", "A dark night of the soul. You are struggling to find meaning in your current joyless path.", 4, true, "Despair, Darkness" },
                    { 2059, 131, "Finance", "Financial goals are being met. Enjoy the fruits of your labor.", 4, false, "Prosperity, Reward" },
                    { 2060, 131, "Finance", "Short-lived success. You may have the money, but it brings you no real security or happiness.", 4, true, "Empty Gains, Risk" },
                    { 2061, 132, "Love", "Sudden disruptions shake your foundation. A crisis that tests the strength of your bond.", 4, false, "Disruption, Crisis" },
                    { 2062, 132, "Career", "A career 'hailstorm'. Unexpected changes or loss of control that forces a new direction.", 4, false, "Change, Challenge" },
                    { 2063, 132, "Spiritualism", "The destructive force that clears the way for growth. Embrace the chaos as a necessary teacher.", 4, false, "Awakening, Nature" },
                    { 2064, 132, "Finance", "Financial instability due to external forces. Protect your assets from unpredictable shifts.", 4, false, "Instability, Protection" },
                    { 2065, 133, "Love", "A time of emotional need and friction. Patience and endurance are required to weather this period.", 4, false, "Necessity, Endurance" },
                    { 2066, 133, "Love", "Toxic dependency or extreme emotional hunger. You are looking for a partner to save you from yourself.", 4, true, "Dependency, Despair" },
                    { 2067, 133, "Career", "Hard work with little immediate reward. Focus on basic duties and stay disciplined despite the lack of progress.", 4, false, "Discipline, Restriction" },
                    { 2068, 133, "Career", "Avoiding necessary work or succumbing to stress. You are ignoring the lessons that hardship is trying to teach.", 4, true, "Avoidance, Failure" },
                    { 2069, 133, "Spiritualism", "The 'fire of necessity'. Use your struggles as fuel for spiritual transformation and inner strength.", 4, false, "Inner Fire, Growth" },
                    { 2070, 133, "Spiritualism", "Spiritual poverty. You are resisting your fate and causing yourself unnecessary suffering.", 4, true, "Resistance, Suffering" },
                    { 2071, 133, "Finance", "Tighten your belt. Manage 'needs' over 'wants' and survive through careful budgeting.", 4, false, "Frugality, Survival" },
                    { 2072, 133, "Finance", "A spiral of debt or desperate financial moves. You are acting out of panic rather than planning.", 4, true, "Debt, Panic" },
                    { 2073, 134, "Love", "Emotional cooling. The relationship is 'on ice'. Do not force heat; wait for the natural thaw.", 4, false, "Stillness, Delay" },
                    { 2074, 134, "Career", "Projects are stalled. Use this stagnation for internal planning rather than trying to force external action.", 4, false, "Stagnation, Reflection" },
                    { 2075, 134, "Spiritualism", "Deep meditation and absolute stillness. Go inward to find the unchanging core of your spirit.", 4, false, "Isolation, Clarity" },
                    { 2076, 134, "Finance", "A freeze on assets. Do not make any major financial moves until the economic climate changes.", 4, false, "Freeze, Wait" },
                    { 2077, 135, "Love", "The natural cycle of love is yielding results. A time of harmony, fertility, and long-term fruition.", 4, false, "Harvest, Rewards" },
                    { 2078, 135, "Career", "Past hard work pays off. Expect the 'harvest' of your professional efforts to manifest in success.", 4, false, "Success, Cycles" },
                    { 2079, 135, "Spiritualism", "Understanding the laws of the universe. You are in tune with the natural rhythms of life and death.", 4, false, "Natural Law, Justice" },
                    { 2080, 135, "Finance", "Steady, seasonal growth. A perfect time for long-term investments that pay out over time.", 4, false, "Profit, Prosperity" },
                    { 2081, 136, "Love", "A bond that endures through any weather. Soul-level connection that provides deep stability.", 4, false, "Endurance, Bond" },
                    { 2082, 136, "Career", "A challenge that requires both strength and flexibility. You are protected while navigating obstacles.", 4, false, "Flexibility, Defense" },
                    { 2083, 136, "Spiritualism", "Connection between worlds. The World Tree guides your transformation through life and death.", 4, false, "Transformation, Bridge" },
                    { 2084, 136, "Finance", "Resilience in your assets. You have built a foundation that can withstand market fluctuations.", 4, false, "Resilience, Security" },
                    { 2085, 137, "Love", "A mystery is unfolding. Enjoy the playfulness and the 'gamble' of a new romantic interest.", 4, false, "Fate, Mystery" },
                    { 2086, 137, "Love", "Disappointment or a secret that harms the bond. The dice have rolled against your heart.", 4, true, "Bad Luck, Secrets" },
                    { 2087, 137, "Career", "Hidden talents coming to light. A chance to take a calculated risk that leads to a windfall.", 4, false, "Potential, Chance" },
                    { 2088, 137, "Career", "Stagnant potential. You are waiting for luck rather than creating your own opportunities.", 4, true, "Stagnation, Risk" },
                    { 2089, 137, "Spiritualism", "The well of Wyrd. Divine laws are at work in ways you cannot yet fully see.", 4, false, "Destiny, Revelation" },
                    { 2090, 137, "Spiritualism", "Disconnected from fate. You are trying to force a path that is not meant for you.", 4, true, "Lost Path, Denial" },
                    { 2091, 137, "Finance", "Unexpected gains from a source you hadn't considered. A good time for a small gamble.", 4, false, "Windfall, Luck" },
                    { 2092, 137, "Finance", "Financial gambling leads to loss. Hidden information is working against your investments.", 4, true, "Loss, Deception" },
                    { 2093, 138, "Love", "Protection and high-minded love. You and your partner are guarding each other's peace.", 4, false, "Protection, Higher Love" },
                    { 2094, 138, "Love", "Emotional vulnerability. You are being drained by a partner or failing to set healthy boundaries.", 4, true, "Warning, Drain" },
                    { 2095, 138, "Career", "Professional sanctuary. Your current position is safe, and your reputation is well-protected.", 4, false, "Safety, Reputation" },
                    { 2096, 138, "Career", "Professional exposure. You are vulnerable to criticism or being used as a scapegoat.", 4, true, "Vulnerability, Warning" },
                    { 2097, 138, "Spiritualism", "Direct connection to the divine. Your intuition serves as a powerful shield against negativity.", 4, false, "Intuition, Shield" },
                    { 2098, 138, "Spiritualism", "Spiritual vulnerability. You have let down your guard and are absorbing negative energies.", 4, true, "Openness, Negativity" },
                    { 2099, 138, "Finance", "Safe investments. Your resources are well-guarded and should be kept in stable assets.", 4, false, "Security, Guarded" },
                    { 2100, 138, "Finance", "A breach of financial security. Watch out for scams or risky ventures that leave you exposed.", 4, true, "Scam, Exposure" },
                    { 2101, 139, "Love", "Total success and warmth. A relationship filled with life-giving energy and mutual admiration.", 4, false, "Vitality, Success" },
                    { 2102, 139, "Career", "Victory is yours. You have the clarity to lead others and achieve your highest goals.", 4, false, "Victory, Power" },
                    { 2103, 139, "Spiritualism", "The light of the sun within. Your higher self is fully integrated and radiant.", 4, false, "Wholeness, Light" },
                    { 2104, 139, "Finance", "A period of great prosperity. Your path to wealth is clear and highly energized.", 4, false, "Wealth, Energy" },
                    { 2105, 140, "Love", "A relationship built on loyalty and mutual respect. You are willing to fight for this bond.", 4, false, "Loyalty, Honor" },
                    { 2106, 140, "Love", "A lack of commitment or a 'lost battle' in romance. Communication is aggressive rather than constructive.", 4, true, "Conflict, Infidelity" },
                    { 2107, 140, "Career", "Justice and leadership. Your competitive spirit is high, and you will prevail through integrity.", 4, false, "Leadership, Victory" },
                    { 2108, 140, "Career", "Giving up too soon. You lack the stamina or the moral conviction to finish what you started.", 4, true, "Defeat, Over-analysis" },
                    { 2109, 140, "Spiritualism", "The spiritual warrior. Sacrifice for the greater good brings ultimate wisdom.", 4, false, "Sacrifice, Faith" },
                    { 2110, 140, "Spiritualism", "Misdirected willpower. You are fighting for the wrong cause or using spiritual power for ego.", 4, true, "Ego, Imbalance" },
                    { 2111, 140, "Finance", "Financial victory through legal means. A fair outcome in a dispute or contract.", 4, false, "Justice, Fairness" },
                    { 2112, 140, "Finance", "Legal setbacks or unfair deals. You are losing a financial struggle due to a lack of strategy.", 4, true, "Injustice, Loss" },
                    { 2113, 141, "Love", "New beginnings, birth, or the nurturing growth of a partnership. A deeply fertile time.", 4, false, "Growth, Nurturing" },
                    { 2114, 141, "Love", "Stifled growth or family issues. A relationship is being choked by past habits or possessiveness.", 4, true, "Stagnation, Friction" },
                    { 2115, 141, "Career", "A creative project is taking root. Your ideas are starting to manifest into something tangible.", 4, false, "Creativity, Manifestation" },
                    { 2116, 141, "Career", "Failure to launch. A project lacks the proper nurturing or foundation to grow successfully.", 4, true, "Decline, Blight" },
                    { 2117, 141, "Spiritualism", "Rebirth and healing. You are entering a phase of profound personal and spiritual renewal.", 4, false, "Rebirth, Healing" },
                    { 2118, 141, "Spiritualism", "Emotional blockage. You are resisting the natural process of growth and healing.", 4, true, "Resistance, Decay" },
                    { 2119, 141, "Finance", "Prosperity through new ventures. Small investments now will grow into great wealth later.", 4, false, "Fertility, Profit" },
                    { 2120, 141, "Finance", "Poor financial timing. What you 'planted' is not growing; re-examine the foundation.", 4, true, "Lack of Growth, Loss" },
                    { 2121, 142, "Love", "Mutual trust and partnership. You and your partner are moving forward in perfect harmony.", 4, false, "Trust, Cooperation" },
                    { 2122, 142, "Love", "Betrayal or a breakdown in trust. The 'horse' and 'rider' are no longer in sync.", 4, true, "Distrust, Disharmony" },
                    { 2123, 142, "Career", "A period of rapid progress through teamwork. Collaboration is the key to your success.", 4, false, "Movement, Collaboration" },
                    { 2124, 142, "Career", "Stalled progress or bad business partners. You are moving in circles instead of forward.", 4, true, "Restlessness, Blockage" },
                    { 2125, 142, "Spiritualism", "Shamanic journeying or soul-travel. You are learning to move between different states of consciousness.", 4, false, "Journey, Soul" },
                    { 2126, 142, "Finance", "Steady movement of wealth. A good time for shifting assets to more productive locations.", 4, false, "Transition, Progress" },
                    { 2127, 143, "Love", "Deep human connection and shared values. A relationship that feels intellectually and soulfully fulfilling.", 4, false, "Humanity, Connection" },
                    { 2128, 143, "Love", "Isolation within a relationship. You feel like a stranger to your partner, or they to you.", 4, true, "Isolation, Self-delusion" },
                    { 2129, 143, "Career", "Professional networking and social responsibility. Success comes through understanding others.", 4, false, "Networking, Community" },
                    { 2130, 143, "Career", "Interference from others or social alienation at work. You are struggling to find your place in the group.", 4, true, "Alienation, Sabotage" },
                    { 2131, 143, "Spiritualism", "The individual within the cosmos. Knowing yourself is the first step to knowing the gods.", 4, false, "Self-knowledge, Spirit" },
                    { 2132, 143, "Finance", "Wealth gained through community projects or social enterprises. People are your greatest asset.", 4, false, "Cooperation, Social Wealth" },
                    { 2133, 144, "Love", "Strong intuition and flowing emotions. Let your feelings guide you toward the right person.", 4, false, "Intuition, Flow" },
                    { 2134, 144, "Love", "Emotional overwhelm or drowning in a toxic relationship. You are ignoring your red flags.", 4, true, "Fear, Illusion" },
                    { 2135, 144, "Career", "A creative surge. Trust your 'gut feeling' about a project or a potential business partner.", 4, false, "Creativity, Instinct" },
                    { 2136, 144, "Career", "Confusion and poor judgment. You are being swept away by a situation you don't understand.", 4, true, "Error, Confusion" },
                    { 2137, 144, "Spiritualism", "Deep immersion in the subconscious. You are receiving powerful messages through dreams and water.", 4, false, "Dreams, Subconscious" },
                    { 2138, 144, "Finance", "Fluidity in finances. Money flows easily, but you must keep an eye on the current.", 4, false, "Liquidity, Flow" },
                    { 2139, 145, "Love", "A period of rest leading to a new level of commitment. Deep internal growth within the bond.", 4, false, "Potential, Maturation" },
                    { 2140, 145, "Career", "A breakthrough is coming. You have done the internal work, and the results are about to burst forth.", 4, false, "Completion, Seed" },
                    { 2141, 145, "Spiritualism", "Sacred space. You are cocooned in a period of gestation, preparing for a spiritual rebirth.", 4, false, "Gestation, Internal Growth" },
                    { 2142, 145, "Finance", "Stored wealth. Your investments are maturing and will soon be ready for harvest.", 4, false, "Saving, Maturity" },
                    { 2143, 146, "Love", "A sudden realization or a major breakthrough in your love life. Darkness turns to light.", 4, false, "Awakening, Clarity" },
                    { 2144, 146, "Career", "A complete transformation. A new day is dawning for your professional path with total clarity.", 4, false, "Breakthrough, Transformation" },
                    { 2145, 146, "Spiritualism", "Enlightenment and the balance of opposites. You are seeing the world with new eyes.", 4, false, "Light, Balance" },
                    { 2146, 146, "Finance", "A major shift in financial status. Success is guaranteed if you act with honesty and vision.", 4, false, "Prosperity, Daybreak" },
                    { 2147, 147, "Love", "Finding your 'home' in a partner. Shared heritage and building a lasting legacy together.", 4, false, "Home, Inheritance" },
                    { 2148, 147, "Love", "Family interference or a feeling of being 'homeless' in your heart. Past baggage is heavy.", 4, true, "Baggage, Alienation" },
                    { 2149, 147, "Career", "Working in a family business or an established institution. Respecting the legacy of your field.", 4, false, "Legacy, Foundation" },
                    { 2150, 147, "Career", "Outdated methods are holding you back. You are bound by a tradition that no longer serves you.", 4, true, "Obsolescence, Restriction" },
                    { 2151, 147, "Spiritualism", "Connecting with your ancestors. Their wisdom is your birthright and your greatest guide.", 4, false, "Ancestry, Heritage" },
                    { 2152, 147, "Spiritualism", "Karmic debt. You are being held back by the ghosts of the past or family traumas.", 4, true, "Karma, Shadow" },
                    { 2153, 147, "Finance", "Inheritance or real estate gains. Wealth that comes through family or long-term ownership.", 4, false, "Property, Legacy" },
                    { 2154, 147, "Finance", "Legal battles over property or loss of inheritance. Financial ties to the past are causing pain.", 4, true, "Loss, Legal Issues" }
                });

            migrationBuilder.InsertData(
                table: "SpreadPositions",
                columns: new[] { "Id", "Description", "Label", "RotationDegrees", "SequenceNumber", "SpreadId", "XPos", "YPos" },
                values: new object[,]
                {
                    { 22, "The core essence of your question or the energy to focus on today.", "The Oracle's Word", 0, 1, 7, 0, 0 },
                    { 23, "What has already been woven; the origins and past influences of your situation.", "Urd (The Past)", 0, 1, 8, 0, 0 },
                    { 24, "What is currently becoming; the energy and choices active right now.", "Verdandi (The Present)", 0, 2, 8, 0, 0 },
                    { 25, "What shall be; the likely outcome if the current path remains unchanged.", "Skuld (The Future)", 0, 3, 8, 0, 0 },
                    { 26, "The foundation and previous events that led you to this moment.", "The Past", 0, 1, 9, 0, 0 },
                    { 27, "The current situation and the central energy surrounding your query.", "The Present", 0, 2, 9, 0, 0 },
                    { 28, "The obstacles or hidden friction you are currently facing.", "The Challenge", 0, 3, 9, 0, 0 },
                    { 29, "The help, hidden strengths, or opportunities that can be utilized.", "The Potential", 0, 4, 9, 0, 0 },
                    { 30, "The final result or the resolution of the situation based on the other four runes.", "The Outcome", 0, 5, 9, 0, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SpreadPositions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Spreads",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Spreads",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Spreads",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
