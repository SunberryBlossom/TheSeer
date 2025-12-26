using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialMeanings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Meanings",
                columns: new[] { "Id", "CardId", "Category", "Content", "DeckId", "IsReversed", "KeyWords" },
                values: new object[,]
                {
                    { 1, 1, "Love", "A new romantic adventure begins. Trust the journey and stay open.", 1, false, "New Love, Spontaneity" },
                    { 2, 1, "Love", "Recklessness in love. Ignoring red flags due to naivety.", 1, true, "Risky, Folly" },
                    { 3, 1, "Career", "A new professional path. High potential if you dare to take the leap.", 1, false, "Entrepreneurship, Risk" },
                    { 4, 1, "Career", "Stagnation due to fear of the unknown. Reluctance to start over.", 1, true, "Indecision, Fear" },
                    { 5, 1, "Finances", "Unexpected financial opportunities. Trust your gut with new investments.", 1, false, "Windfall, Optimism" },
                    { 6, 1, "Finances", "Careless spending. Gambling with resources you cannot afford to lose.", 1, true, "Irresponsibility, Loss" },
                    { 7, 1, "Spiritual", "The start of a soul journey. A leap of faith leads to awakening.", 1, false, "Faith, Awakening" },
                    { 8, 1, "Spiritual", "Disconnection from your path. Fear blocks spiritual progress.", 1, true, "Doubt, Blockage" },
                    { 9, 2, "Love", "Magnetism and initiative. You have the power to manifest a deep connection.", 1, false, "Manifestation, Charm" },
                    { 10, 2, "Love", "Manipulation or trickery. Using charm to hide true intentions.", 1, true, "Deceit, Illusion" },
                    { 11, 2, "Career", "Mastery of skills. High productivity and successful implementation of ideas.", 1, false, "Skill, Resourcefulness" },
                    { 12, 2, "Career", "Wasted talent or poor execution. Lack of focus on the task at hand.", 1, true, "Inefficiency, Latent power" },
                    { 13, 2, "Finances", "Financial goals are within reach. Act decisively to secure resources.", 1, false, "Willpower, Success" },
                    { 14, 2, "Finances", "Financial confusion. Being misled by 'get-rich-quick' schemes.", 1, true, "Scams, Misdirection" },
                    { 15, 2, "Spiritual", "Realizing your divine potential. Connecting thought with action.", 1, false, "Alchemy, Agency" },
                    { 16, 2, "Spiritual", "Ego-driven spiritual practice. Misusing knowledge for personal gain.", 1, true, "Ego, Manipulation" },
                    { 17, 3, "Love", "Intuitive connection. Secrets may be revealed through dreams.", 1, false, "Intuition, Mystery" },
                    { 18, 3, "Love", "Hidden issues surfacing. Ignoring your inner voice about a partner.", 1, true, "Repression, Secrets" },
                    { 19, 3, "Career", "Success through patience and intuition rather than aggressive action.", 1, false, "Passivity, Knowledge" },
                    { 20, 3, "Career", "A lack of professional clarity. Information is being withheld from you.", 1, true, "Confusion, Hidden agendas" },
                    { 21, 3, "Finances", "Keep your financial plans private. Trust your instincts on a deal.", 1, false, "Discretion, Prudence" },
                    { 22, 3, "Finances", "Hidden costs or fine print. Financial intuition is being clouded.", 1, true, "Oversight, Deception" },
                    { 23, 3, "Spiritual", "Deep connection to the subconscious. Divine feminine energy flows.", 1, false, "Subconscious, Wisdom" },
                    { 24, 3, "Spiritual", "Spiritual withdrawal. Refusal to look inward or face the shadow.", 1, true, "Surface-level, Blocked intuition" },
                    { 25, 4, "Love", "Nurturing and abundant love. Sensuality and fertility in relationships.", 1, false, "Abundance, Care" },
                    { 26, 4, "Love", "Suffocating affection or neglecting self-care for a partner.", 1, true, "Codependency, Smothering" },
                    { 27, 4, "Career", "A period of creativity and growth. Projects are coming to fruition.", 1, false, "Creativity, Harvest" },
                    { 28, 4, "Career", "Creative blockages. Feeling uninspired or stifled in your work.", 1, true, "Barrenness, Frustration" },
                    { 29, 4, "Finances", "Financial security and luxury. A good time for steady investments.", 1, false, "Prosperity, Comfort" },
                    { 30, 4, "Finances", "Financial overindulgence. Relying too much on material comfort.", 1, true, "Extravagance, Waste" },
                    { 31, 4, "Spiritual", "Connecting with Mother Earth. Spirituality through the senses.", 1, false, "Nature, Connection" },
                    { 32, 4, "Spiritual", "Neglecting the physical body. Disconnect from the natural world.", 1, true, "Imbalance, Disconnect" },
                    { 33, 5, "Love", "Stability and protection. A relationship built on solid foundations.", 1, false, "Structure, Loyalty" },
                    { 34, 5, "Love", "Controlling behavior. Lack of emotional warmth or excessive rules.", 1, true, "Tyranny, Coldness" },
                    { 35, 5, "Career", "Leadership and authority. Taking control and establishing order.", 1, false, "Authority, Strategy" },
                    { 36, 5, "Career", "Abuse of power. Ineffective leadership due to rigidity.", 1, true, "Rigidity, Power-struggle" },
                    { 37, 5, "Finances", "Disciplined financial management. Long-term planning pays off.", 1, false, "Control, Discipline" },
                    { 38, 5, "Finances", "Financial chaos due to lack of discipline. Poor management.", 1, true, "Chaos, Poor structure" },
                    { 39, 5, "Spiritual", "Finding divinity in structure and logic. Establishing a daily practice.", 1, false, "Paternal, Logic" },
                    { 40, 5, "Spiritual", "Dogmatic beliefs. Spiritual growth is stunted by intolerance.", 1, true, "Dogma, Inflexibility" },
                    { 41, 6, "Love", "Tradition and commitment. A mentor figure may guide your heart.", 1, false, "Tradition, Marriage" },
                    { 42, 6, "Love", "Rebellion against social norms. Disagreement over values in love.", 1, true, "Rebellion, Unconventional" },
                    { 43, 6, "Career", "Success through teamwork and following established protocols.", 1, false, "Mentorship, Education" },
                    { 44, 6, "Career", "Feeling trapped by bureaucracy. The need to innovate outside the box.", 1, true, "Restriction, Conformity" },
                    { 45, 6, "Finances", "Conventional investment strategies. Seek professional financial advice.", 1, false, "Safety, Advice" },
                    { 46, 6, "Finances", "Financial advice that is outdated. Breaking away from traditional banks.", 1, true, "Risk, Novelty" },
                    { 47, 6, "Spiritual", "Following a spiritual tradition or lineage. Sacred rituals.", 1, false, "Ritual, Institution" },
                    { 48, 6, "Spiritual", "Developing your own personal belief system. Rejection of organized religion.", 1, true, "Freedom, Self-belief" },
                    { 49, 7, "Love", "Harmonious union. A choice between two paths that defines your future.", 1, false, "Union, Alignment" },
                    { 50, 7, "Love", "Disharmony and imbalance. A difficult choice leads to temporary separation.", 1, true, "Imbalance, Conflict" },
                    { 51, 7, "Career", "Strong partnerships at work. Aligning values with your professional goals.", 1, false, "Partnership, Values" },
                    { 52, 7, "Career", "Conflict of interest. Poor communication with colleagues.", 1, true, "Misalignment, Friction" },
                    { 53, 7, "Finances", "Joint ventures are favored. Mutual financial goals bring stability.", 1, false, "Collaboration, Shared" },
                    { 54, 7, "Finances", "Financial disagreement in a partnership. Irresponsible joint spending.", 1, true, "Disparity, Debt" },
                    { 55, 7, "Spiritual", "Integrating the dualities of the self. Choice based on soul values.", 1, false, "Harmony, Duality" },
                    { 56, 7, "Spiritual", "Inner conflict. Being at odds with your own higher purpose.", 1, true, "Fragmentation, Soul-searching" },
                    { 57, 8, "Love", "Taking command of your emotions. Moving forward with confidence.", 1, false, "Victory, Momentum" },
                    { 58, 8, "Love", "Aggression or lack of direction. A relationship moving too fast.", 1, true, "Force, Deviation" },
                    { 59, 8, "Career", "Ambition and focus. Overcoming obstacles through sheer willpower.", 1, false, "Drive, Conquest" },
                    { 60, 8, "Career", "Losing control of a project. Lack of discipline leads to failure.", 1, true, "Defeat, Impotence" },
                    { 61, 8, "Finances", "Rapid financial growth through hard work. Success in competitive markets.", 1, false, "Ambition, Wealth" },
                    { 62, 8, "Finances", "Financial setbacks due to ego. Pushing a deal too hard.", 1, true, "Reversal, Failure" },
                    { 63, 8, "Spiritual", "Disciplining the spirit. Mastering the path toward higher truth.", 1, false, "Focus, Mastery" },
                    { 64, 8, "Spiritual", "Spiritual arrogance. Forgetting the heart while seeking power.", 1, true, "Ego, Misalignment" },
                    { 65, 9, "Love", "Compassion and inner strength. Influencing a partner with gentleness.", 1, false, "Courage, Patience" },
                    { 66, 9, "Love", "Insecurity and raw emotion. Letting fear or anger control the bond.", 1, true, "Weakness, Fear" },
                    { 67, 9, "Career", "Resilience in the face of stress. Leading through empathy and calm.", 1, false, "Fortitude, Empathy" },
                    { 68, 9, "Career", "Burnout or lack of confidence. Yielding to workplace pressure.", 1, true, "Exhaustion, Insecurity" },
                    { 69, 9, "Finances", "Prudent management. Resisting the urge for impulsive purchases.", 1, false, "Moderation, Prudence" },
                    { 70, 9, "Finances", "Financial panic. Making rash decisions based on temporary fear.", 1, true, "Impulse, Panic" },
                    { 71, 9, "Spiritual", "Taming the beast within. Finding power in stillness and love.", 1, false, "Inner-beast, Calm" },
                    { 72, 9, "Spiritual", "Spiritual weakness. Succumbing to base instincts or despair.", 1, true, "Self-doubt, Low vibration" },
                    { 73, 10, "Love", "Self-reflection in solitude. Taking a break to understand your heart.", 1, false, "Solitude, Insight" },
                    { 74, 10, "Love", "Isolation or loneliness. Refusing to connect with others.", 1, true, "Withdrawal, Rejection" },
                    { 75, 10, "Career", "Seeking wisdom or a mentor. A time for deep research and focus.", 1, false, "Guidance, Mastery" },
                    { 76, 10, "Career", "Over-analysis leading to paralysis. Ignoring practical advice.", 1, true, "Staleness, Detachment" },
                    { 77, 10, "Finances", "Careful financial scrutiny. Avoiding the noise of the market.", 1, false, "Caution, Analysis" },
                    { 78, 10, "Finances", "Financial ignorance. Ignoring your bank statements or reality.", 1, true, "Neglect, Avoidance" },
                    { 79, 10, "Spiritual", "Finding the light within. A solitary path toward enlightenment.", 1, false, "Enlightenment, Soul" },
                    { 80, 10, "Spiritual", "Spiritual disconnection. Being lost in the dark without a guide.", 1, true, "Alienation, Lost" },
                    { 81, 11, "Love", "A fated meeting. Luck brings a new cycle to your love life.", 1, false, "Fate, Change" },
                    { 82, 11, "Love", "Bad timing in romance. Cycles of old mistakes repeating.", 1, true, "Misfortune, Patterns" },
                    { 83, 11, "Career", "A sudden promotion or opportunity. Going with the flow of change.", 1, false, "Luck, Transition" },
                    { 84, 11, "Career", "Resistance to necessary change. External forces disrupting plans.", 1, true, "Obstacles, Setback" },
                    { 85, 11, "Finances", "Fluctuating wealth. The tide is turning in your favor.", 1, false, "Flow, Fortune" },
                    { 86, 11, "Finances", "Unexpected financial loss. A reminder that nothing is permanent.", 1, true, "Decline, Lessons" },
                    { 87, 11, "Spiritual", "Understanding karma. Recognizing the synchronicities of the universe.", 1, false, "Karma, Cycles" },
                    { 88, 11, "Spiritual", "Resisting the laws of nature. Feeling like a victim of fate.", 1, true, "Resistance, Victimhood" },
                    { 89, 12, "Love", "Honesty and fairness in relationships. Legalizing a union.", 1, false, "Truth, Balance" },
                    { 90, 12, "Love", "Injustice or unfair treatment. Blaming others for your own flaws.", 1, true, "Unfairness, Denial" },
                    { 91, 12, "Career", "Ethical behavior rewarded. Legal matters or contracts settled fairly.", 1, false, "Law, Integrity" },
                    { 92, 12, "Career", "Dishonesty at work. Legal complications or unfair criticism.", 1, true, "Corruption, Bias" },
                    { 93, 12, "Finances", "Financial balance. You get exactly what you have earned.", 1, false, "Fairness, Dues" },
                    { 94, 12, "Finances", "Unbalanced books. Legal fines or being cheated in a deal.", 1, true, "Inequity, Debt" },
                    { 95, 12, "Spiritual", "Spiritual accountability. Cause and effect are clearly seen.", 1, false, "Consequence, Truth" },
                    { 96, 12, "Spiritual", "Ignoring the truth. Karmic imbalance due to lack of self-honesty.", 1, true, "Disharmony, Evasion" },
                    { 97, 13, "Love", "Waiting for the right moment. Sacrifice for a deeper bond.", 1, false, "Pause, Devotion" },
                    { 98, 13, "Love", "Martyrdom in love. Waiting in vain for a change that won't come.", 1, true, "Sacrifice, Stalling" },
                    { 99, 13, "Career", "Looking at work from a new perspective. A necessary delay.", 1, false, "New Vision, Wait" },
                    { 100, 13, "Career", "Useless delay. Refusing to see the truth of a failing project.", 1, true, "Resistance, Blindness" },
                    { 101, 13, "Finances", "Financial sacrifice now for a future gain. A shift in priorities.", 1, false, "Delayed wealth, Shift" },
                    { 102, 13, "Finances", "Wasted resources. Being stuck in an old financial pattern.", 1, true, "Waste, Stagnation" },
                    { 103, 13, "Spiritual", "Letting go of the ego. Surrender to the divine flow.", 1, false, "Surrender, Release" },
                    { 104, 13, "Spiritual", "Spiritual egoism. Refusing to let go of material control.", 1, true, "Rigidity, Egotism" },
                    { 105, 14, "Love", "A relationship ending to make room for something better.", 1, false, "Ending, Transition" },
                    { 106, 14, "Love", "Clinging to a dead relationship. Fear of moving on.", 1, true, "Resistance, Decay" },
                    { 107, 14, "Career", "A major professional transformation. Out with the old.", 1, false, "Change, Renewal" },
                    { 108, 14, "Career", "Stagnation. Inability to accept that a job has run its course.", 1, true, "Inertia, Fear" },
                    { 109, 14, "Finances", "Radical financial change. Cutting out bad habits completely.", 1, false, "Purge, Rebirth" },
                    { 110, 14, "Finances", "Slow financial decline. Refusal to adapt to new realities.", 1, true, "Bleeding, Obsolescence" },
                    { 111, 14, "Spiritual", "Death of the old self. Rebirth into a higher state.", 1, false, "Metamorphosis, Rebirth" },
                    { 112, 14, "Spiritual", "Spiritual rot. Holding on to toxic beliefs that kill growth.", 1, true, "Decay, Stagnation" },
                    { 113, 15, "Love", "Balance and moderation. Two souls blending in perfect harmony.", 1, false, "Patience, Flow" },
                    { 114, 15, "Love", "Imbalance in love. Extreme emotions or lack of compromise.", 1, true, "Chaos, Friction" },
                    { 115, 15, "Career", "Steady progress through diplomacy and careful planning.", 1, false, "Alchemy, Diplomacy" },
                    { 116, 15, "Career", "Haste and volatility. Conflicts between colleagues or goals.", 1, true, "Impatience, Clashes" },
                    { 117, 15, "Finances", "Moderate growth. Balancing income and expenses effectively.", 1, false, "Frugality, Balance" },
                    { 118, 15, "Finances", "Unstable finances. Overspending followed by extreme saving.", 1, true, "Instability, Extremes" },
                    { 119, 15, "Spiritual", "Soul alchemy. Finding a middle path to enlightenment.", 1, false, "Middle-path, Soul" },
                    { 120, 15, "Spiritual", "Spiritual confusion. Seeking too many paths at once.", 1, true, "Scatter, Disharmony" },
                    { 121, 16, "Love", "Obsession and toxic bonds. Physical attraction masking pain.", 1, false, "Bondage, Lust" },
                    { 122, 16, "Love", "Breaking free from a toxic partner. Ending an unhealthy cycle.", 1, true, "Freedom, Recovery" },
                    { 123, 16, "Career", "Feeling trapped in a job. Workaholism or cutthroat politics.", 1, false, "Trap, Ambition" },
                    { 124, 16, "Career", "Leaving a high-stress role. Reclaiming your personal time.", 1, true, "Liberation, Balance" },
                    { 125, 16, "Finances", "Debt and material greed. Being a slave to money or status.", 1, false, "Debt, Materialism" },
                    { 126, 16, "Finances", "Paying off debt. Release from financial obligations.", 1, true, "Release, Solvency" },
                    { 127, 16, "Spiritual", "Facing your shadow self. Recognition of inner darkness.", 1, false, "Shadow-work, Truth" },
                    { 128, 16, "Spiritual", "Spiritual breakthrough. Overcoming addictions or dogma.", 1, true, "Ascension, Clarity" },
                    { 129, 17, "Love", "A sudden shock or breakup. The truth destroys a weak bond.", 1, false, "Upheaval, Chaos" },
                    { 130, 17, "Love", "Avoiding a necessary crisis. Delaying the inevitable end.", 1, true, "Dread, Denial" },
                    { 131, 17, "Career", "Total workplace upheaval. Losing a job or a failed project.", 1, false, "Disaster, Change" },
                    { 132, 17, "Career", "Rebuilding after a crash. Learning from professional failure.", 1, true, "Recovery, Lessons" },
                    { 133, 17, "Finances", "Financial collapse. A warning of sudden loss or bankruptcy.", 1, false, "Ruin, Shock" },
                    { 134, 17, "Finances", "Escaping a total loss. Narrowly avoiding financial disaster.", 1, true, "Escape, Warning" },
                    { 135, 17, "Spiritual", "Ego death. Sudden revelation that changes your worldview.", 1, false, "Revelation, Awakening" },
                    { 136, 17, "Spiritual", "Refusal to wake up. Holding on to a crumbling spiritual belief.", 1, true, "Fear, Stagnation" },
                    { 137, 18, "Love", "Hope and healing in love. A soulmate connection or deep peace.", 1, false, "Hope, Serenity" },
                    { 138, 18, "Love", "Lack of faith in love. Feeling unlovable or pessimistic.", 1, true, "Despair, Sadness" },
                    { 139, 18, "Career", "Inspiration and success. Recognition for your unique talents.", 1, false, "Fame, Purpose" },
                    { 140, 18, "Career", "Uninspired work. Feeling like your potential is being wasted.", 1, true, "Dullness, Boredom" },
                    { 141, 18, "Finances", "Abundance through positive mindset. Financial wishes fulfilled.", 1, false, "Good-luck, Flow" },
                    { 142, 18, "Finances", "Financial insecurity. Fear of the future blocking wealth.", 1, true, "Poverty-mindset, Fear" },
                    { 143, 18, "Spiritual", "Divine guidance. A deep sense of peace and cosmic connection.", 1, false, "Zen, Cosmos" },
                    { 144, 18, "Spiritual", "Spiritual emptiness. Feeling abandoned by the universe.", 1, true, "Dark-night, Void" },
                    { 145, 19, "Love", "Illusions and hidden fears. Uncertainty about a partner.", 1, false, "Confusion, Fear" },
                    { 146, 19, "Love", "Secrets coming to light. Clarity replacing confusion.", 1, true, "Truth, Relief" },
                    { 147, 19, "Career", "Misunderstandings at work. Not seeing the full picture.", 1, false, "Hidden-agendas, Fog" },
                    { 148, 19, "Career", "Finding your way out of a confusing situation. New clarity.", 1, true, "Resolution, Path" },
                    { 149, 19, "Finances", "Financial deception. Be careful of deals that seem too good.", 1, false, "Risks, Shadows" },
                    { 150, 19, "Finances", "Uncovering a scam or error. Financial fog lifting.", 1, true, "Vigilance, Reality" },
                    { 151, 19, "Spiritual", "Vivid dreams and intuition. The subconscious is speaking.", 1, false, "Dreams, Shadow" },
                    { 152, 19, "Spiritual", "Spiritual paranoia. Misinterpreting intuitive signs.", 1, true, "Anxiety, Distortion" },
                    { 153, 20, "Love", "Joy, vitality, and success in romance. A public celebration.", 1, false, "Happiness, Success" },
                    { 154, 20, "Love", "Temporary cloudiness. Jealousy or burnout in a bond.", 1, true, "Boredom, Ego" },
                    { 155, 20, "Career", "Brilliant success and recognition. Creative energy is high.", 1, false, "Victory, Fame" },
                    { 156, 20, "Career", "Delayed success. Arrogance causing issues with coworkers.", 1, true, "Arrogance, Delay" },
                    { 157, 20, "Finances", "Financial prosperity and abundance. Success in all ventures.", 1, false, "Wealth, Growth" },
                    { 158, 20, "Finances", "Short-lived success. Unrealistic expectations about money.", 1, true, "Hype, Vanity" },
                    { 159, 20, "Spiritual", "Radiant spiritual truth. Full alignment with your purpose.", 1, false, "Light, Presence" },
                    { 160, 20, "Spiritual", "Over-optimism. Ignoring the shadow for a false 'high'.", 1, true, "Superficiality, Ego" },
                    { 161, 21, "Love", "A soul's awakening. Forgiving a partner and starting fresh.", 1, false, "Reckoning, Forgiveness" },
                    { 162, 21, "Love", "Self-doubt in love. Refusing to hear the call for change.", 1, true, "Regret, Stalling" },
                    { 163, 21, "Career", "Answering your true professional calling. A major decision.", 1, false, "Vocation, Clarity" },
                    { 164, 21, "Career", "Career crossroads. Ignoring your conscience about a job.", 1, true, "Guilt, Indecision" },
                    { 165, 21, "Finances", "Financial legalities settled. A karmic reward for honesty.", 1, false, "Accountability, Settlement" },
                    { 166, 21, "Finances", "Avoiding financial truth. Failing to learn from past errors.", 1, true, "Denial, Debt" },
                    { 167, 21, "Spiritual", "Divine call to higher consciousness. Total transformation.", 1, false, "Absolution, Call" },
                    { 168, 21, "Spiritual", "Spiritual stagnation. Refusing to change despite inner signs.", 1, true, "Doubt, Blockage" },
                    { 169, 22, "Love", "Completion of a cycle. Total fulfillment and shared success.", 1, false, "Unity, Fulfillment" },
                    { 170, 22, "Love", "Incomplete closure. Feeling unfulfilled despite milestones.", 1, true, "Lack, Burden" },
                    { 171, 22, "Career", "Worldly success and travel. Reaching the peak of your field.", 1, false, "Peak, Mastery" },
                    { 172, 22, "Career", "A project nearly finished but stalled. Lack of final vision.", 1, true, "Shortfall, Delay" },
                    { 173, 22, "Finances", "Ultimate financial security. Wealth on a global or vast scale.", 1, false, "Completion, Fortune" },
                    { 174, 22, "Finances", "Financial goals not quite met. Missing the final piece.", 1, true, "Gap, Deficiency" },
                    { 175, 22, "Spiritual", "Cosmic consciousness. Understanding your place in the universe.", 1, false, "Wholeness, One" },
                    { 176, 22, "Spiritual", "Spiritual stagnation. Failing to integrate lessons learned.", 1, true, "Fragmented, Incomplete" },
                    { 177, 23, "Love", "A seed of passion is planted. A relationship with deep potential for growth.", 1, false, "Passion, Potential" },
                    { 178, 23, "Love", "Waning interest. A romantic idea that fails to take root.", 1, true, "Fading, No-roots" },
                    { 179, 23, "Career", "The birth of a legacy project. Long-term professional stability begins here.", 1, false, "Foundation, Vision" },
                    { 180, 23, "Career", "Lack of professional direction. A 'false start' in a new business venture.", 1, true, "False-start, Delays" },
                    { 181, 23, "Finances", "Investing in 'soil'. Putting money into assets that grow over decades.", 1, false, "Steady-growth, Asset" },
                    { 182, 23, "Finances", "Financial resources being wasted on temporary thrills. No long-term plan.", 1, true, "Waste, Short-sighted" },
                    { 183, 23, "Spiritual", "Connecting with your ancestral roots. Finding energy in the natural world.", 1, false, "Ancestry, Grounding" },
                    { 184, 23, "Spiritual", "Feeling spiritually uprooted. Disconnection from your origin or purpose.", 1, true, "Uprooted, Lost" },
                    { 185, 24, "Love", "Planning a future together. Deciding where to plant your shared lives.", 1, false, "Planning, Foresight" },
                    { 186, 24, "Love", "Disagreement on future goals. One wants to stay, the other wants to go.", 1, true, "Conflict, Doubt" },
                    { 187, 24, "Career", "Expanding your territory. Looking at the horizon for the next big move.", 1, false, "Expansion, Strategy" },
                    { 188, 24, "Career", "Playing it too safe. Fear of the unknown prevents professional growth.", 1, true, "Fear, Limitation" },
                    { 189, 24, "Finances", "Waiting for investments to mature. Watching your 'forest' grow from afar.", 1, false, "Patience, Prospect" },
                    { 190, 24, "Finances", "Poor financial timing. Missing the window for a lucrative expansion.", 1, true, "Bad-timing, Loss" },
                    { 191, 24, "Spiritual", "A soul's overview. Realizing that you are the architect of your own growth.", 1, false, "Architect, Self-will" },
                    { 192, 24, "Spiritual", "Spiritual impatience. Trying to force a tree to grow faster than it can.", 1, true, "Force, Impatience" },
                    { 193, 25, "Love", "Ships coming in. Love from a distance or a relationship reaching a new stage.", 1, false, "Arrival, Voyage" },
                    { 194, 25, "Love", "Expectations not being met. Disappointment in a partner's progress.", 1, true, "Delay, Letdown" },
                    { 195, 25, "Career", "Successful collaboration. Your branches are reaching out to new markets.", 1, false, "Commerce, Reach" },
                    { 196, 25, "Career", "Professional isolation. Refusing to network or branch out to others.", 1, true, "Isolation, Pride" },
                    { 197, 25, "Finances", "Rewards from past efforts. Seeing the fruits of long-term labor.", 1, false, "Fruition, Profit" },
                    { 198, 25, "Finances", "Unreliable income streams. Depending on 'trees' that haven't matured yet.", 1, true, "Uncertainty, Risk" },
                    { 199, 25, "Spiritual", "Gaining a higher perspective. Understanding the interconnectedness of all life.", 1, false, "Unity, Perspective" },
                    { 200, 25, "Spiritual", "Being lost in the canopy. Too much focus on the big picture, ignoring the roots.", 1, true, "Confusion, Overwhelm" },
                    { 201, 26, "Love", "Celebration of a home. A wedding, a new house, or a deep sense of belonging.", 1, false, "Home, Celebration" },
                    { 202, 26, "Love", "Tension at home. Feeling like a guest in your own relationship.", 1, true, "Unrest, Insecurity" },
                    { 203, 26, "Career", "A successful milestone. Completing a phase of a project with great results.", 1, false, "Milestone, Success" },
                    { 204, 26, "Career", "Lack of support from colleagues. A hollow victory that feels unearned.", 1, true, "Instability, Doubt" },
                    { 205, 26, "Finances", "Investing in property or sanctuary. Financial stability through your home.", 1, false, "Real-estate, Peace" },
                    { 206, 26, "Finances", "Hidden costs in a property. Financial 'cracks' in your foundation.", 1, true, "Repair, Hidden-cost" },
                    { 207, 26, "Spiritual", "Finding your sacred space. Inner peace that radiates outward.", 1, false, "Sanctuary, Peace" },
                    { 208, 26, "Spiritual", "A period of spiritual homelessness. Feeling like your rituals lack soul.", 1, true, "Void, Routine" },
                    { 209, 27, "Love", "Petty competition in a relationship. Trying to 'outgrow' your partner.", 1, false, "Conflict, Rivalry" },
                    { 210, 27, "Love", "Resolving a long-standing argument. Dropping the need to be right.", 1, true, "Peace, Truce" },
                    { 211, 27, "Career", "Healthy competition. Pushing yourself to be the tallest tree in the forest.", 1, false, "Ambition, Drive" },
                    { 212, 27, "Career", "Toxic workplace drama. Too many opinions, not enough action.", 1, true, "Chaos, Friction" },
                    { 213, 27, "Finances", "Aggressive financial moves. Fighting for your share of the market.", 1, false, "Aggression, Gain" },
                    { 214, 27, "Finances", "Financial disputes with others. Legal battles over small amounts.", 1, true, "Dispute, Legal" },
                    { 215, 27, "Spiritual", "Testing your beliefs. Spiritual growth through debate and challenge.", 1, false, "Test, Growth" },
                    { 216, 27, "Spiritual", "Spiritual exhaustion. Tired of fighting for your truth in a loud world.", 1, true, "Burnout, Noise" },
                    { 217, 28, "Love", "Being admired by many. Success in a relationship that others notice.", 1, false, "Victory, Pride" },
                    { 218, 28, "Love", "Public embarrassment in love. Feeling like a failure in the eyes of others.", 1, true, "Shame, Fall" },
                    { 219, 28, "Career", "Recognition for your achievements. Promotion or a successful launch.", 1, false, "Promotion, Honor" },
                    { 220, 28, "Career", "A hollow victory. Getting the title but not the respect you wanted.", 1, true, "Arrogance, Ego" },
                    { 221, 28, "Finances", "Financial visibility and success. Your wealth becomes evident.", 1, false, "Affluence, Status" },
                    { 222, 28, "Finances", "Loss of status. Financial decisions that hurt your reputation.", 1, true, "Disgrace, Debt" },
                    { 223, 28, "Spiritual", "Leading others toward the light. A time of spiritual confidence.", 1, false, "Leadership, Spirit" },
                    { 224, 28, "Spiritual", "False prophet energy. Caring more about being 'seen' than being 'holy'.", 1, true, "Vanity, Falsehood" },
                    { 225, 29, "Love", "Standing your ground in a relationship. Protecting your heart's territory.", 1, false, "Defense, Boundary" },
                    { 226, 29, "Love", "Giving in to pressure. Losing yourself to a partner's demands.", 1, true, "Surrender, Weakness" },
                    { 227, 29, "Career", "Defending your position or project against critics. You have the upper hand.", 1, false, "Resilience, Stand" },
                    { 228, 29, "Career", "Being overwhelmed by the workload. Losing a professional battle.", 1, true, "Defeat, Overwhelmed" },
                    { 229, 29, "Finances", "Protecting your savings. Resisting high-risk temptations.", 1, false, "Guard, Frugality" },
                    { 230, 29, "Finances", "Financial vulnerability. Your 'fence' has a hole in it.", 1, true, "Risk, Exposure" },
                    { 231, 29, "Spiritual", "Defending your spiritual integrity. Not compromising your soul.", 1, false, "Integrity, Truth" },
                    { 232, 29, "Spiritual", "Spiritual cowardice. Staying silent when you should speak your truth.", 1, true, "Silence, Fear" },
                    { 233, 30, "Love", "A sudden burst of communication. Love moves forward at lightning speed.", 1, false, "Speed, News" },
                    { 234, 30, "Love", "Communication breakdown. News that brings a relationship to a halt.", 1, true, "Delay, Ghosting" },
                    { 235, 30, "Career", "Fast-paced growth. A project moves into the fast lane.", 1, false, "Momentum, Action" },
                    { 236, 30, "Career", "Frustrating delays. Red tape stops your momentum.", 1, true, "Inertia, Red-tape" },
                    { 237, 30, "Finances", "Quick financial gains. Money flows in faster than expected.", 1, false, "Velocity, Profit" },
                    { 238, 30, "Finances", "Money flowing out rapidly. Expenses you didn't see coming.", 1, true, "Panic, Drain" },
                    { 239, 30, "Spiritual", "Spiritual downloads. Sudden clarity and alignment with the universe.", 1, false, "Clarity, Message" },
                    { 240, 30, "Spiritual", "Spiritual noise. Too many messages, not enough silence to hear them.", 1, true, "Confusion, Static" },
                    { 241, 31, "Love", "Resilience in love. You have been hurt, but your roots are strong.", 1, false, "Strength, Survival" },
                    { 242, 31, "Love", "Emotional walls. Refusing to let a partner in due to past pain.", 1, true, "Defense, Trauma" },
                    { 243, 31, "Career", "Persistence pays off. The final push before a major accomplishment.", 1, false, "Endurance, Grit" },
                    { 244, 31, "Career", "Giving up right before the finish line. Professional fatigue.", 1, true, "Fatigue, Quit" },
                    { 245, 31, "Finances", "Protecting the last of your resources. A period of survival.", 1, false, "Frugality, Buffer" },
                    { 246, 31, "Finances", "Financial burnout. Tired of fighting for every cent.", 1, true, "Burnout, Loss" },
                    { 247, 31, "Spiritual", "The battle-worn soul. Gaining wisdom from every scar.", 1, false, "Wisdom, Scar" },
                    { 248, 31, "Spiritual", "Spiritual defensiveness. Using your path as a shield, not a bridge.", 1, true, "Ego-shield, Fear" },
                    { 249, 32, "Love", "The weight of a relationship. Feeling responsible for your partner's happiness.", 1, false, "Burden, Duty" },
                    { 250, 32, "Love", "Dropping the burden. Realizing you can't carry a relationship alone.", 1, true, "Release, Freedom" },
                    { 251, 32, "Career", "Taking on too much. The 'oldest tree' carrying all the weight of the forest.", 1, false, "Overwork, Stress" },
                    { 252, 32, "Career", "Delegating tasks. Refusing to be the only one who works.", 1, true, "Relief, Share" },
                    { 253, 32, "Finances", "High maintenance costs. Your lifestyle is becoming a heavy load.", 1, false, "Debt, Load" },
                    { 254, 32, "Finances", "Downsizing. Cutting away dead branches to save the tree.", 1, true, "Scale-back, Cut" },
                    { 255, 32, "Spiritual", "Spiritual responsibility. Carrying the light for others in the dark.", 1, false, "Dharma, Weight" },
                    { 256, 32, "Spiritual", "Soul fatigue. Forgetting that spirituality should feel like flight, not a hike.", 1, true, "Exhaustion, Duty" },
                    { 257, 33, "Love", "A young, curious lover. A message of love that feels fresh and new.", 1, false, "Message, Spark" },
                    { 258, 33, "Love", "Immature romantic gestures. A message that causes confusion or hurt.", 1, true, "Gossip, Childish" },
                    { 259, 33, "Career", "A fresh apprentice or a new idea. Learning a new trade from the ground up.", 1, false, "Learning, Entry" },
                    { 260, 33, "Career", "Professional immaturity. Failing to take a new role seriously.", 1, true, "Lazy, Unfocused" },
                    { 261, 33, "Finances", "News about a small but promising investment. A time for curiosity.", 1, false, "Inquiry, Tiny-gain" },
                    { 262, 33, "Finances", "Bad news about a small investment. Financial naivety costing you.", 1, true, "Mistake, Error" },
                    { 263, 33, "Spiritual", "Spiritual curiosity. Exploring the basics of nature-based wisdom.", 1, false, "Novice, Nature" },
                    { 264, 33, "Spiritual", "Spiritual inconsistency. Jumping from one path to another too quickly.", 1, true, "Fickle, Surface" },
                    { 265, 34, "Love", "Chivalrous and daring love. A partner who sweeps you off your feet.", 1, false, "Adventurer, Dash" },
                    { 266, 34, "Love", "A 'hit and run' lover. Passion without commitment or stability.", 1, true, "Flighty, Inconstant" },
                    { 267, 34, "Career", "Rapid professional action. Charging toward a goal with great energy.", 1, false, "Brave, Action" },
                    { 268, 34, "Career", "Hasty professional mistakes. Charging into a project without a plan.", 1, true, "Rash, Blunder" },
                    { 269, 34, "Finances", "Bold financial moves. High risk for high reward.", 1, false, "Daring, Speculation" },
                    { 270, 34, "Finances", "Financial gambling. Losing money through impulsiveness.", 1, true, "Gambler, Loss" },
                    { 271, 34, "Spiritual", "The spiritual quest. Moving toward enlightenment with courage.", 1, false, "Quest, Courage" },
                    { 272, 34, "Spiritual", "Spiritual pride. Believing you are 'more advanced' than others.", 1, true, "Pride, Ego" },
                    { 273, 35, "Love", "Warm, confident, and magnetic love. A partner who is life-affirming.", 1, false, "Warmth, Magnetism" },
                    { 274, 35, "Love", "Jealousy or moodiness. Someone who demands to be the center of attention.", 1, true, "Selfish, Fickle" },
                    { 275, 35, "Career", "A female leader or a creative powerhouse. Mastering your craft with joy.", 1, false, "Mastery, Radiance" },
                    { 276, 35, "Career", "Professional manipulation. Using charm to get others to do your work.", 1, true, "Laziness, Deceit" },
                    { 277, 35, "Finances", "Prosperity through confidence. Knowing your worth and asking for it.", 1, false, "Self-worth, Gain" },
                    { 278, 35, "Finances", "Overspending on image. Caring more about looking rich than being rich.", 1, true, "Vanity, Debt" },
                    { 279, 35, "Spiritual", "Spiritual radiance. Your soul is in full bloom and attracts others.", 1, false, "Bloom, Soul" },
                    { 280, 35, "Spiritual", "Spiritual burnout. Trying to keep the 'fire' going when the wood is gone.", 1, true, "Burnout, Hollow" },
                    { 281, 36, "Love", "Strong, loyal, and visionary love. A relationship that builds a kingdom.", 1, false, "Loyalty, Vision" },
                    { 282, 36, "Love", "A domineering or aggressive partner. Love used as a tool for control.", 1, true, "Tyrant, Harsh" },
                    { 283, 36, "Career", "The CEO of the forest. Visionary leadership that lasts generations.", 1, false, "Leadership, Legacy" },
                    { 284, 36, "Career", "A boss who is out of touch. Rigidity that stops innovation.", 1, true, "Out-of-touch, Rigid" },
                    { 285, 36, "Finances", "Wealth and power. Managing large-scale resources successfully.", 1, false, "Power, Affluence" },
                    { 286, 36, "Finances", "Financial cruelty. Using your resources to hurt others or control them.", 1, true, "Cruelty, Greed" },
                    { 287, 36, "Spiritual", "The spiritual master. One who has integrated action with wisdom.", 1, false, "Master, Wisdom" },
                    { 288, 36, "Spiritual", "Spiritual tyranny. Believing your path is the only valid path for others.", 1, true, "Dogma, Arrogance" },
                    { 289, 37, "Love", "A new chapter in romance. Deep emotional discovery and poetic connection.", 1, false, "Intimacy, Discovery" },
                    { 290, 37, "Love", "Misread emotions. A romantic story that lacks a true foundation.", 1, true, "Confusion, Illusion" },
                    { 291, 37, "Career", "A creative epiphany. Beginning a project that requires deep research and soul.", 1, false, "Insight, Creative" },
                    { 292, 37, "Career", "Creative block. An idea that sounds good on paper but lacks practical heart.", 1, true, "Stagnation, Dryness" },
                    { 293, 37, "Finances", "Investing in education or intellectual property. Value found in information.", 1, false, "Knowledge, Worth" },
                    { 294, 37, "Finances", "Financial naivety. Not reading the contract or ignoring the fine print.", 1, true, "Ignorance, Oversight" },
                    { 295, 37, "Spiritual", "The first step into ancient wisdom. Your soul begins a new study.", 1, false, "Initiation, Wisdom" },
                    { 296, 37, "Spiritual", "Spiritual overwhelm. Trying to learn everything at once without feeling it.", 1, true, "Academic, Cold" },
                    { 297, 38, "Love", "Shared values and mutual understanding. Two stories becoming one.", 1, false, "Partnership, Synergy" },
                    { 298, 38, "Love", "A plot twist in love. Misunderstanding your partner’s core values.", 1, true, "Discord, Friction" },
                    { 299, 38, "Career", "A successful contract or partnership. Synergistic intellectual collaboration.", 1, false, "Agreement, Team" },
                    { 300, 38, "Career", "A broken professional promise. Falling out with a business partner.", 1, true, "Dispute, Breach" },
                    { 301, 38, "Finances", "A fair trade. Balancing the books and finding a harmonious financial deal.", 1, false, "Balance, Exchange" },
                    { 302, 38, "Finances", "Hidden inequality in a deal. One person benefits more than the other.", 1, true, "Unfair, Debt" },
                    { 303, 38, "Spiritual", "Finding your spiritual mirror. Learning through the reflection of others.", 1, false, "Mirror, Union" },
                    { 304, 38, "Spiritual", "Projecting your own dross onto others. Spiritual imbalance in relationships.", 1, true, "Projection, Shadow" },
                    { 305, 39, "Love", "A celebratory chapter. Friendship that turns into deep, shared love.", 1, false, "Community, Joy" },
                    { 306, 39, "Love", "Third-party interference. Too many opinions in a private relationship.", 1, true, "Gossip, Crowd" },
                    { 307, 39, "Career", "Success through networking. A group project that hits all its targets.", 1, false, "Network, Success" },
                    { 308, 39, "Career", "Over-socializing and under-working. Losing focus on the professional story.", 1, true, "Distraction, Play" },
                    { 309, 39, "Finances", "Shared financial rewards. A time to celebrate abundance with friends.", 1, false, "Sharing, Profit" },
                    { 310, 39, "Finances", "Excessive spending on social status. Wasting resources to impress others.", 1, true, "Extravagance, Debt" },
                    { 311, 39, "Spiritual", "Spiritual community. Finding your tribe and learning through group ritual.", 1, false, "Tribe, Ritual" },
                    { 312, 39, "Spiritual", "Losing your individual path in a group. Spiritual groupthink.", 1, true, "Conformity, Noise" },
                    { 313, 40, "Love", "Boredom or apathy. Not seeing the romantic offer right in front of you.", 1, false, "Stagnation, Sulking" },
                    { 314, 40, "Love", "Waking up to love. Realizing what you’ve been ignoring in your heart.", 1, true, "Awareness, Shift" },
                    { 315, 40, "Career", "Professional fatigue. Dissatisfaction with your current role or project.", 1, false, "Ennui, Boredom" },
                    { 316, 40, "Career", "A new interest sparks. Finally finding a reason to care about your work.", 1, true, "Spark, Energy" },
                    { 317, 40, "Finances", "Ignoring financial opportunities due to a negative mindset.", 1, false, "Missed-chance, Apathy" },
                    { 318, 40, "Finances", "Breaking out of a financial rut. Taking action after a long pause.", 1, true, "Action, Recovery" },
                    { 319, 40, "Spiritual", "Spiritual withdrawal. Looking inward but feeling only emptiness.", 1, false, "Introversion, Void" },
                    { 320, 40, "Spiritual", "Spiritual re-engagement. Finding meaning in the mundane again.", 1, true, "Renewal, Connection" },
                    { 321, 41, "Love", "Grief over a lost chapter. Focusing on the 'empty pages' of the heart.", 1, false, "Loss, Regret" },
                    { 322, 41, "Love", "Acceptance. Turning the page and seeing the love that still remains.", 1, true, "Moving-on, Hope" },
                    { 323, 41, "Career", "Professional setback. Regretting a choice that led to a failed project.", 1, false, "Disappointment, Error" },
                    { 324, 41, "Career", "Rebuilding from failure. Taking the lessons from the 'spilled ink'.", 1, true, "Resilience, Growth" },
                    { 325, 41, "Finances", "Financial loss that stings. Crying over spilled money instead of earning more.", 1, false, "Mourning, Loss" },
                    { 326, 41, "Finances", "Financial recovery begins. Realizing you still have assets to work with.", 1, true, "Recovery, Assets" },
                    { 327, 41, "Spiritual", "The dark night of the soul. Understanding that grief is a teacher.", 1, false, "Shadow, Grief" },
                    { 328, 41, "Spiritual", "Healing from emotional trauma. The soul begins to write a new story.", 1, true, "Healing, Rebirth" },
                    { 329, 42, "Love", "Nostalgia. A past lover returns or you find joy in childhood memories.", 1, false, "Past, Innocence" },
                    { 330, 42, "Love", "Stuck in the past. Living in a story that no longer exists.", 1, true, "Fantasy, Clinging" },
                    { 331, 42, "Career", "Returning to an old skill or company. Finding value in your history.", 1, false, "Legacy, Return" },
                    { 332, 42, "Career", "Outdated methods. Refusing to learn 'new books' in your field.", 1, true, "Stale, Obsolete" },
                    { 333, 42, "Finances", "An inheritance or money from a past source. Financial comfort from family.", 1, false, "Heritage, Gift" },
                    { 334, 42, "Finances", "Financial childishness. Not taking responsibility for your modern debts.", 1, true, "Immature, Debt" },
                    { 335, 42, "Spiritual", "Inner child work. Connecting with the pure soul you were at birth.", 1, false, "Child, Purity" },
                    { 336, 42, "Spiritual", "Childish spiritual views. Refusing to face the adult complexities of faith.", 1, true, "Naivety, Denial" },
                    { 337, 43, "Love", "Daydreaming about a future. Too many romantic options, too little action.", 1, false, "Choices, Fantasy" },
                    { 338, 43, "Love", "Clarity in love. Finally choosing one path and closing the other 'books'.", 1, true, "Decision, Focus" },
                    { 339, 43, "Career", "Multiple projects or ideas. Be careful of being a 'jack of all trades'.", 1, false, "Options, Scatter" },
                    { 340, 43, "Career", "Focusing on one goal. Moving from theory into practical reality.", 1, true, "Action, Realism" },
                    { 341, 43, "Finances", "Wishful thinking about wealth. Dreaming of money instead of earning it.", 1, false, "Illusion, Hopes" },
                    { 342, 43, "Finances", "Setting realistic financial goals. Seeing through a 'get rich' scheme.", 1, true, "Clarity, Truth" },
                    { 343, 43, "Spiritual", "Exploring different philosophies. A time of spiritual imagination.", 1, false, "Seeking, Astral" },
                    { 344, 43, "Spiritual", "Grounded spirituality. Escaping the trap of 'spiritual escapism'.", 1, true, "Grounded, Presence" },
                    { 345, 44, "Love", "Leaving a familiar story. Walking away from a bond that no longer grows.", 1, false, "Departure, Search" },
                    { 346, 44, "Love", "Fear of abandonment. Staying in a relationship because you're afraid to leave.", 1, true, "Stagnation, Fear" },
                    { 347, 44, "Career", "Leaving a stable job for a higher calling. Seeking a deeper truth.", 1, false, "Vocation, Change" },
                    { 348, 44, "Career", "Coming back to a project after failing to find something better.", 1, true, "Return, Defeat" },
                    { 349, 44, "Finances", "Walking away from a bad investment. Knowing when to cut your losses.", 1, false, "Release, Wisdom" },
                    { 350, 44, "Finances", "Clinging to financial ruin. Refusing to walk away from a sinking ship.", 1, true, "Denial, Loss" },
                    { 351, 44, "Spiritual", "The spiritual seeker. Leaving the material world to find the soul.", 1, false, "Quest, Ascetic" },
                    { 352, 44, "Spiritual", "Spiritual confusion. Abandoning your path too soon.", 1, true, "Lost, Fickle" },
                    { 353, 45, "Love", "Emotional wishes coming true. Satisfaction and comfort in your bond.", 1, false, "Contentment, Joy" },
                    { 354, 45, "Love", "Smugness or emotional greed. Taking a partner for granted.", 1, true, "Arrogance, Lack" },
                    { 355, 45, "Career", "A position of comfort and pride. Having everything you thought you wanted.", 1, false, "Pride, Success" },
                    { 356, 45, "Career", "Underachieving due to comfort. Losing your professional edge.", 1, true, "Lazy, Stagnant" },
                    { 357, 45, "Finances", "Financial abundance. A 'rich' life where all needs are met.", 1, false, "Plenty, Safety" },
                    { 358, 45, "Finances", "Materialistic greed. Having everything but feeling empty.", 1, true, "Void, Greed" },
                    { 359, 45, "Spiritual", "Soul satisfaction. Feeling at one with your current spiritual state.", 1, false, "Grace, Peace" },
                    { 360, 45, "Spiritual", "Spiritual vanity. Thinking you've reached the end of the book.", 1, true, "Ego, Static" },
                    { 361, 46, "Love", "Domestic bliss. A family story reaching its happiest peak.", 1, false, "Family, Home" },
                    { 362, 46, "Love", "Dysfunction in the home. A happy exterior masking a sad story.", 1, true, "Broken, False" },
                    { 363, 46, "Career", "Perfect professional alignment. Work that feels like home.", 1, false, "Alignment, Bliss" },
                    { 364, 46, "Career", "Losing the 'work-family' balance. Conflict between duty and home.", 1, true, "Imbalance, Stress" },
                    { 365, 46, "Finances", "Generational wealth. Financial security for the whole family.", 1, false, "Legacy, Wealth" },
                    { 366, 46, "Finances", "Family disputes over money. Fighting over the 'inheritance'.", 1, true, "Greed, Conflict" },
                    { 367, 46, "Spiritual", "Spiritual wholeness. Feeling connected to the entire universe.", 1, false, "Unity, Divine" },
                    { 368, 46, "Spiritual", "Disconnected from the source. Feeling like an outsider in the universe.", 1, true, "Isolation, Void" },
                    { 369, 47, "Love", "A romantic message or a poetic admirer. A new emotional study.", 1, false, "Message, Muse" },
                    { 370, 47, "Love", "Emotional manipulation through words. A 'player' or a false poet.", 1, true, "Deceit, Flattery" },
                    { 371, 47, "Career", "A creative apprentice. Starting to write your own professional book.", 1, false, "Scholar, Ideas" },
                    { 372, 47, "Career", "Creative immaturity. All ideas, no execution.", 1, true, "Draft, Lazy" },
                    { 373, 47, "Finances", "Small gains from a creative source. A financial 'intro' or lead.", 1, false, "Small-win, Lead" },
                    { 374, 47, "Finances", "Financial daydreaming. Buying things based on an emotional whim.", 1, true, "Impulse, Waste" },
                    { 375, 47, "Spiritual", "Intuitive study. Learning to read the 'unwritten' signs of the soul.", 1, false, "Psychic, Study" },
                    { 376, 47, "Spiritual", "Spiritual fantasy. Being lost in 'pretty' rituals without depth.", 1, true, "Shadow, Vague" },
                    { 377, 48, "Love", "A romantic proposal or a journey for love. Following your heart.", 1, false, "Proposal, Quest" },
                    { 378, 48, "Love", "Emotional inconstancy. Someone who loves the 'idea' of love but flees.", 1, true, "Fickle, Flight" },
                    { 379, 48, "Career", "Diplomatic professional moves. An artist or a visionary leader.", 1, false, "Diplomat, Artist" },
                    { 380, 48, "Career", "Passive-aggressive workplace behavior. Being too 'soft' to lead.", 1, true, "Weak, Avoidant" },
                    { 381, 48, "Finances", "Following a financial vision. Money used to fund art or travel.", 1, false, "Venture, Travel" },
                    { 382, 48, "Finances", "Financial escapism. Spending money to hide from emotional truth.", 1, true, "Waste, Avoidance" },
                    { 383, 48, "Spiritual", "Searching for the Holy Grail. A quest for the ultimate soul truth.", 1, false, "Grail, Purpose" },
                    { 384, 48, "Spiritual", "Spiritual vanity. Caring more about the 'robe' than the 'prayer'.", 1, true, "Vanity, Show" },
                    { 385, 49, "Love", "Deep empathy and nurturing love. A partner who reads your soul.", 1, false, "Healer, Muse" },
                    { 386, 49, "Love", "Emotional martyrdom. Smothering a partner with 'care' they didn't ask for.", 1, true, "Smother, Martyr" },
                    { 387, 49, "Career", "A compassionate leader. Success in healing, teaching, or art.", 1, false, "Mentor, Insight" },
                    { 388, 49, "Career", "Professional insecurity. Being too emotional to make a hard choice.", 1, true, "Soft, Fear" },
                    { 389, 49, "Finances", "Financial intuition. Trusting your gut about where to put your money.", 1, false, "Instinct, Grace" },
                    { 390, 49, "Finances", "Financial dependence. Using emotions to get others to pay your way.", 1, true, "Dependent, Drain" },
                    { 391, 49, "Spiritual", "Divine feminine wisdom. Full integration of emotion and spirit.", 1, false, "Goddess, Soul" },
                    { 392, 49, "Spiritual", "Psychic overload. Not having boundaries for other people's energy.", 1, true, "Absorb, Drain" },
                    { 393, 50, "Love", "Emotional mastery. A love that is both deep and stable.", 1, false, "Stable, Mature" },
                    { 394, 50, "Love", "Emotional coldness. A partner who uses logic to suppress feelings.", 1, true, "Cold, Rigid" },
                    { 395, 50, "Career", "The wise counselor. Leading with a balance of heart and mind.", 1, false, "Counsel, Leader" },
                    { 396, 50, "Career", "A boss who is emotionally manipulative or secretive.", 1, true, "Scheme, Control" },
                    { 397, 50, "Finances", "Calm financial leadership. Making money through wisdom and time.", 1, false, "Prudence, Wealth" },
                    { 398, 50, "Finances", "Hidden financial corruption. A 'quiet' loss that you didn't see coming.", 1, true, "Leak, Deceit" },
                    { 399, 50, "Spiritual", "Spiritual mastery. Being the 'author' of your own soul's philosophy.", 1, false, "Master, Author" },
                    { 400, 50, "Spiritual", "Spiritual detachment. Knowing the 'words' but having lost the 'feeling'.", 1, true, "Academic, Hollow" },
                    { 401, 51, "Love", "A breakthrough in understanding. Cutting through confusion to see your partner clearly.", 1, false, "Truth, Clarity" },
                    { 402, 51, "Love", "Sharp words that wound. Using honesty as a weapon instead of a bridge.", 1, true, "Hostility, Malice" },
                    { 403, 51, "Career", "A brilliant new strategy. Intellectual force solves a long-standing problem.", 1, false, "Logic, Focus" },
                    { 404, 51, "Career", "Mental fog. A plan that lacks the necessary edge to succeed.", 1, true, "Confusion, Failure" },
                    { 405, 51, "Finances", "Decisive action. Cutting out unnecessary expenses with surgical precision.", 1, false, "Pruning, Precision" },
                    { 406, 51, "Finances", "Hidden legal issues. A contract with 'teeth' that could bite you later.", 1, true, "Risk, Oversight" },
                    { 407, 51, "Spiritual", "Mental liberation. Using the sword of truth to slice through personal ego.", 1, false, "Insight, Awakening" },
                    { 408, 51, "Spiritual", "Intellectual pride. Believing logic is the only path to the divine.", 1, true, "Cynicism, Ego" },
                    { 409, 52, "Love", "A romantic stalemate. Keeping emotions guarded to avoid conflict.", 1, false, "Truce, Block" },
                    { 410, 52, "Love", "The pressure breaks. A sudden release of long-suppressed emotions.", 1, true, "Release, Outburst" },
                    { 411, 52, "Career", "Avoiding a difficult choice. Closing your eyes to workplace politics.", 1, false, "Avoidance, Pause" },
                    { 412, 52, "Career", "Forced clarity. Being pushed to make a decision you've been avoiding.", 1, true, "Action, Choice" },
                    { 413, 52, "Finances", "Financial balance through caution. Not making any moves until certain.", 1, false, "Wait, Stability" },
                    { 414, 52, "Finances", "Financial paralysis. Fear of the market preventing necessary steps.", 1, true, "Fear, Stagnation" },
                    { 415, 52, "Spiritual", "Inner stillness. Withdrawing from external noise to hear your own truth.", 1, false, "Peace, Isolation" },
                    { 416, 52, "Spiritual", "Mental turmoil. Your own thoughts are blocking your spiritual path.", 1, true, "Conflict, Noise" },
                    { 417, 53, "Love", "Heartbreak or a painful realization. The truth hurts but allows for healing.", 1, false, "Sorrow, Truth" },
                    { 418, 53, "Love", "Healing from a past wound. Releasing the pain to love again.", 1, true, "Recovery, Release" },
                    { 419, 53, "Career", "A difficult professional separation. Losing a contract or a partner.", 1, false, "Loss, Conflict" },
                    { 420, 53, "Career", "Resolving a deep conflict. Moving past a workplace betrayal.", 1, true, "Truce, Healing" },
                    { 421, 53, "Finances", "Financial loss due to a bad decision. A sharp sting to the wallet.", 1, false, "Drain, Lesson" },
                    { 422, 53, "Finances", "Minimizing a loss. Finding the 'silver lining' in a financial error.", 1, true, "Salvage, Repair" },
                    { 423, 53, "Spiritual", "Growth through pain. The soul expands by facing its deepest sorrows.", 1, false, "Shadow, Growth" },
                    { 424, 53, "Spiritual", "Refusing to grieve. Suppressing pain which then poisons the spirit.", 1, true, "Denial, Poison" },
                    { 425, 54, "Love", "Taking a break to think. A necessary period of rest in a relationship.", 1, false, "Rest, Solitude" },
                    { 426, 54, "Love", "Awakening from emotional isolation. Rejoining the world of love.", 1, true, "Re-entry, Life" },
                    { 427, 54, "Career", "Professional burnout requires a pause. Stepping back to regain focus.", 1, false, "Retreat, Recovery" },
                    { 428, 54, "Career", "Forced return to work before you are ready. Premature action.", 1, true, "Haste, Fatigue" },
                    { 429, 54, "Finances", "Financial hibernation. Watching your money but not spending it.", 1, false, "Prudence, Wait" },
                    { 430, 54, "Finances", "Sudden financial activity after a dry spell. Spending on recovery.", 1, true, "Activity, Outflow" },
                    { 431, 54, "Spiritual", "Meditation and sanctuary. Finding the sacred in silence.", 1, false, "Zen, Sanctuary" },
                    { 432, 54, "Spiritual", "Spiritual stagnation. Being so 'still' that you have stopped growing.", 1, true, "Lethargy, Void" },
                    { 433, 55, "Love", "A hollow victory in an argument. Winning the fight but hurting the bond.", 1, false, "Conflict, Pride" },
                    { 434, 55, "Love", "Making amends. Realizing that being right isn't worth being alone.", 1, true, "Regret, Peace" },
                    { 435, 55, "Career", "Workplace hostility. A situation where everyone is out for themselves.", 1, false, "Betrayal, Selfish" },
                    { 436, 55, "Career", "Exposing a toxic colleague. Moving toward a more ethical environment.", 1, true, "Expose, Truth" },
                    { 437, 55, "Finances", "Financial ruthlessness. Gaining at someone else's expense.", 1, false, "Greed, Exploitation" },
                    { 438, 55, "Finances", "Paying the price for past greed. Karma hitting the bank account.", 1, true, "Loss, Reversal" },
                    { 439, 55, "Spiritual", "Facing your inner 'bully'. Acknowledging your own capacity for malice.", 1, false, "Shadow, Ego" },
                    { 440, 55, "Spiritual", "Spiritual humiliation. A necessary ego-crushing moment for growth.", 1, true, "Humility, Lesson" },
                    { 441, 56, "Love", "Moving toward calmer waters. Leaving a turbulent relationship behind.", 1, false, "Transition, Peace" },
                    { 442, 56, "Love", "Emotional baggage. Trying to move forward but the past keeps pulling.", 1, true, "Stuck, Burden" },
                    { 443, 56, "Career", "Changing careers or roles. A necessary move to preserve your sanity.", 1, false, "Travel, Shift" },
                    { 444, 56, "Career", "Professional stagnation. A planned move that gets delayed or cancelled.", 1, true, "Delay, Trap" },
                    { 445, 56, "Finances", "Financial transition. Moving money to a safer place for the future.", 1, false, "Transfer, Safety" },
                    { 446, 56, "Finances", "Financial drift. Losing money slowly because you haven't taken control.", 1, true, "Leak, Drift" },
                    { 447, 56, "Spiritual", "A journey of the mind. Finding clarity through a change of environment.", 1, false, "Quest, Clarity" },
                    { 448, 56, "Spiritual", "Spiritual avoidance. Running away from your problems instead of solving them.", 1, true, "Evasion, Fear" },
                    { 449, 57, "Love", "Keeping secrets or avoiding the truth to protect yourself in love.", 1, false, "Secrets, Tactics" },
                    { 450, 57, "Love", "Confessing a secret. Coming clean to your partner about a hidden issue.", 1, true, "Honesty, Relief" },
                    { 451, 57, "Career", "Strategic professional moves. Working alone to gain an advantage.", 1, false, "Strategy, Solo" },
                    { 452, 57, "Career", "Being 'caught'. A shortcut or unprofessional tactic is revealed.", 1, true, "Exposed, Shame" },
                    { 453, 57, "Finances", "Hidden financial risks. Trying to 'game' the system for quick gain.", 1, false, "Gambling, Scheme" },
                    { 454, 57, "Finances", "A scam is uncovered. Losing money through someone else's deceit.", 1, true, "Fraud, Loss" },
                    { 455, 57, "Spiritual", "The clever soul. Learning through unconventional or hidden means.", 1, false, "Cunning, Insight" },
                    { 456, 57, "Spiritual", "Spiritual hypocrisy. Pretending to be on a path you don't actually walk.", 1, true, "Falsehood, Ego" },
                    { 457, 58, "Love", "Feeling trapped by your own thoughts or a partner's expectations.", 1, false, "Restraint, Fear" },
                    { 458, 58, "Love", "The blindfold comes off. Realizing the cage door was never locked.", 1, true, "Freedom, Sight" },
                    { 459, 58, "Career", "Professional paralysis. Feeling like there are no good moves left to make.", 1, false, "Trap, Doubt" },
                    { 460, 58, "Career", "Finding a way out of a dead-end job. New professional perspective.", 1, true, "Exit, Clarity" },
                    { 461, 58, "Finances", "Financial restriction. Feeling helpless against debt or obligations.", 1, false, "Debt, Burden" },
                    { 462, 58, "Finances", "Escaping a financial trap. Paying off the debt that held you back.", 1, true, "Solvency, Relief" },
                    { 463, 58, "Spiritual", "A victim mindset. The spirit feels bound by external circumstances.", 1, false, "Victimhood, Bound" },
                    { 464, 58, "Spiritual", "Taking power back. Realizing you are the creator of your own limits.", 1, true, "Agency, Power" },
                    { 465, 59, "Love", "Anxiety and nightmares. Worrying about a relationship more than living it.", 1, false, "Worry, Dread" },
                    { 466, 59, "Love", "The dawn after a dark night. Realizing your fears were exaggerated.", 1, true, "Relief, Light" },
                    { 467, 59, "Career", "Intense stress or 'imposter syndrome'. Sleepless nights over a deadline.", 1, false, "Stress, Fear" },
                    { 468, 59, "Career", "Finding perspective. Understanding that work is just one part of life.", 1, true, "Perspective, Calm" },
                    { 469, 59, "Finances", "Financial panic. The 'teeth' of debt are keeping you awake at night.", 1, false, "Panic, Loss" },
                    { 470, 59, "Finances", "Face your financial fears. They lose their power once you name them.", 1, true, "Coping, Reality" },
                    { 471, 59, "Spiritual", "The shadow of the mind. Facing the internal demons that cause suffering.", 1, false, "Shadow, Trauma" },
                    { 472, 59, "Spiritual", "Spiritual breakthrough. Emerging from a period of deep mental pain.", 1, true, "Survival, Wisdom" },
                    { 473, 60, "Love", "A final ending. The relationship has been 'bitten' to death. No way back.", 1, false, "End, Ruin" },
                    { 474, 60, "Love", "The bottom of the pit. You cannot fall further; the only way is up.", 1, true, "Hope, Rebirth" },
                    { 475, 60, "Career", "A project is completely killed. Total failure that forces a new start.", 1, false, "Defeat, Finish" },
                    { 476, 60, "Career", "A narrow escape from professional ruin. Rebuilding from the ashes.", 1, true, "Survival, New-path" },
                    { 477, 60, "Finances", "Financial rock bottom. Bankruptcy or a total loss of an asset.", 1, false, "Bankruptcy, Loss" },
                    { 478, 60, "Finances", "Coming back from the edge. A slow and painful financial recovery.", 1, true, "Recovery, Rise" },
                    { 479, 60, "Spiritual", "Ego death. The final release of a false identity that caused pain.", 1, false, "Transcendence, End" },
                    { 480, 60, "Spiritual", "Spiritual resurrection. Finding life after everything was destroyed.", 1, true, "Resurrection, Soul" },
                    { 481, 61, "Love", "An intellectual spark. A young, witty lover or a clever message.", 1, false, "Wit, Curiosity" },
                    { 482, 61, "Love", "A sharp-tongued person who enjoys gossip or causing drama.", 1, true, "Gossip, Spite" },
                    { 483, 61, "Career", "A sharp mind entering the field. Intellectual apprenticeship and ideas.", 1, false, "Ideas, Student" },
                    { 484, 61, "Career", "Professional immaturity. All talk and no action; empty threats.", 1, true, "Bluff, Laziness" },
                    { 485, 61, "Finances", "Analyzing the data. Finding a small but key insight in your accounts.", 1, false, "Analysis, Insight" },
                    { 486, 61, "Finances", "Financial misinformation. Listening to the wrong 'expert' or news.", 1, true, "Lies, Mistake" },
                    { 487, 61, "Spiritual", "Spiritual inquiry. Questioning everything to find the truth.", 1, false, "Skepticism, Truth" },
                    { 488, 61, "Spiritual", "Mental rigidity. Your logic is becoming a cage for your spirit.", 1, true, "Dogma, Dryness" },
                    { 489, 62, "Love", "Charging into love with intellectual passion. A swift romantic move.", 1, false, "Haste, Action" },
                    { 490, 62, "Love", "An aggressive lover. Someone who doesn't respect your mental boundaries.", 1, true, "Force, Tactless" },
                    { 491, 62, "Career", "A bold professional strike. Rapid progress through sheer brainpower.", 1, false, "Strike, Drive" },
                    { 492, 62, "Career", "Disastrous haste. Running into a project without checking the facts.", 1, true, "Rash, Blunder" },
                    { 493, 62, "Finances", "Aggressive financial tactics. Fast-paced trading or bidding.", 1, false, "Bold, Speed" },
                    { 494, 62, "Finances", "Financial recklessness. Charging toward a 'deal' that is actually a trap.", 1, true, "Impulse, Loss" },
                    { 495, 62, "Spiritual", "The spiritual warrior. Fighting for your beliefs and your truth.", 1, false, "War, Truth" },
                    { 496, 62, "Spiritual", "Spiritual fanaticism. Using your 'truth' to hurt or judge others.", 1, true, "Fanatic, Anger" },
                    { 497, 63, "Love", "An intelligent, independent, and honest partner. Direct communication.", 1, false, "Honesty, Clarity" },
                    { 498, 63, "Love", "An emotionally cold partner. Using logic to dismiss your feelings.", 1, true, "Coldness, Harsh" },
                    { 499, 63, "Career", "A sharp professional mentor. Success through objectivity and truth.", 1, false, "Objective, Truth" },
                    { 500, 63, "Career", "A cruel or overly critical boss. Perfectionism that kills creativity.", 1, true, "Critique, Bitter" },
                    { 501, 63, "Finances", "Smart financial planning. Seeing exactly where your money goes.", 1, false, "Prudence, Audit" },
                    { 502, 63, "Finances", "Unfair financial judgment. Being cheated due to a biased contract.", 1, true, "Bias, Deception" },
                    { 503, 63, "Spiritual", "Spiritual discernment. Knowing the difference between truth and ego.", 1, false, "Grace, Wisdom" },
                    { 504, 63, "Spiritual", "Spiritual bitterness. Using your knowledge to look down on others.", 1, true, "Arrogance, Ice" },
                    { 505, 64, "Love", "A bond based on truth and intellectual respect. Strong leadership.", 1, false, "Logic, Duty" },
                    { 506, 64, "Love", "A manipulative or tyrannical partner. Love as a mind game.", 1, true, "Tyranny, Games" },
                    { 507, 64, "Career", "Strategic professional leadership. Mastering your field through logic.", 1, false, "Power, Strategy" },
                    { 508, 64, "Career", "Professional abuse of power. Using your position to intimidate.", 1, true, "Malice, Control" },
                    { 509, 64, "Finances", "Financial mastery. Understanding the deep laws of the market.", 1, false, "Wealth, Law" },
                    { 510, 64, "Finances", "Financial corruption. Using the 'teeth' of the law to cheat others.", 1, true, "Corruption, Greed" },
                    { 511, 64, "Spiritual", "Mastery of the mind. Reaching a state of total mental clarity.", 1, false, "Master, Mind" },
                    { 512, 64, "Spiritual", "The false teacher. Using spiritual jargon to control or confuse.", 1, true, "Deceit, Power" },
                    { 513, 65, "Love", "A solid foundation for a new relationship. A love that is tangible and secure.", 1, false, "Solid, Grounded" },
                    { 514, 65, "Love", "A missed romantic opportunity. A relationship that fails to manifest in reality.", 1, true, "Missed, Ethereal" },
                    { 515, 65, "Career", "A new source of income or a lucrative job offer. Finding 'gold' in your work.", 1, false, "Prosperity, Seed" },
                    { 516, 65, "Career", "Lack of professional planning. A project that starts without proper funding.", 1, true, "Scarcity, Delay" },
                    { 517, 65, "Finances", "A significant financial gift or investment. Physical wealth is appearing.", 1, false, "Wealth, Asset" },
                    { 518, 65, "Finances", "Financial waste. Spending a rare resource on something worthless.", 1, true, "Greed, Loss" },
                    { 519, 65, "Spiritual", "Grounded spirituality. Recognizing the divine in the material world.", 1, false, "Nature, Presence" },
                    { 520, 65, "Spiritual", "Being too focused on physical gains. Forgetting the soul for the sake of gold.", 1, true, "Materialism, Heavy" },
                    { 521, 66, "Love", "Balancing life’s demands with a partner. Adapting to changes in the home.", 1, false, "Flow, Balance" },
                    { 522, 66, "Love", "Failing to prioritize love. Juggling too many external tasks at once.", 1, true, "Chaos, Neglect" },
                    { 523, 66, "Career", "Multitasking and flexibility. Managing multiple projects with grace.", 1, false, "Agility, Change" },
                    { 524, 66, "Career", "Taking on too much. Disorganization leads to professional embarrassment.", 1, true, "Mess, Overwhelm" },
                    { 525, 66, "Finances", "Fluid money management. Moving resources to stay ahead of the curve.", 1, false, "Trade, Flux" },
                    { 526, 66, "Finances", "Financial instability. Living paycheck to paycheck with poor timing.", 1, true, "Risk, Debt" },
                    { 527, 66, "Spiritual", "Finding rhythm in daily chores. Seeing work as a form of meditation.", 1, false, "Rhythm, Zen" },
                    { 528, 66, "Spiritual", "Spiritual inconsistency. Trying to 'balance' too many conflicting paths.", 1, true, "Surface, Scatter" },
                    { 529, 67, "Love", "Building a relationship with care. Showing love through teamwork and effort.", 1, false, "Teamwork, Build" },
                    { 530, 67, "Love", "A lack of cooperation. One person is doing all the emotional labor.", 1, true, "Discord, Ego" },
                    { 531, 67, "Career", "Mastery of a craft. Being recognized for your unique professional skills.", 1, false, "Skill, Craft" },
                    { 532, 67, "Career", "Poor quality work. Refusing to learn from mentors or follow the blueprint.", 1, true, "Lazy, Sloppy" },
                    { 533, 67, "Finances", "Collaborative investments. Success through professional consultation.", 1, false, "Advisory, Gain" },
                    { 534, 67, "Finances", "Financial disputes with partners. Misalignment on how to use resources.", 1, true, "Dispute, Error" },
                    { 535, 67, "Spiritual", "Building your temple. Realizing that spiritual growth requires discipline.", 1, false, "Discipline, Work" },
                    { 536, 67, "Spiritual", "Spiritual laziness. Expecting enlightenment without doing the inner work.", 1, true, "Stagnation, Pride" },
                    { 537, 68, "Love", "Guarding your heart. A stable relationship that needs more openness.", 1, false, "Stability, Guarded" },
                    { 538, 68, "Love", "Possessiveness. Trying to control a partner like a piece of property.", 1, true, "Control, Jealousy" },
                    { 539, 68, "Career", "Job security. Holding onto your position and protecting your ideas.", 1, false, "Security, Hold" },
                    { 540, 68, "Career", "Stifling innovation. Refusing to share resources or cooperate with others.", 1, true, "Stale, Greed" },
                    { 541, 68, "Finances", "Saving and conservatism. Accumulating wealth through frugality.", 1, false, "Hoarding, Save" },
                    { 542, 68, "Finances", "Extreme greed. Being 'penny wise and pound foolish'.", 1, true, "Greed, Loss" },
                    { 543, 68, "Spiritual", "Solid spiritual boundaries. Protecting your energy from external drain.", 1, false, "Boundaries, Self" },
                    { 544, 68, "Spiritual", "Spiritual rigidity. Clinging to old beliefs out of fear of the unknown.", 1, true, "Fear, Fixed" },
                    { 545, 69, "Love", "Facing hardship together. Finding warmth in a partner during cold times.", 1, false, "Support, Struggle" },
                    { 546, 69, "Love", "Feeling left out in the cold. A sense of loneliness within a relationship.", 1, true, "Isolation, Void" },
                    { 547, 69, "Career", "A period of unemployment or financial struggle at work. Lack of resources.", 1, false, "Poverty, Lack" },
                    { 548, 69, "Career", "Recovery from failure. Finding a new workplace after a long struggle.", 1, true, "Rebirth, Hope" },
                    { 549, 69, "Finances", "Financial loss or large debts. Feeling the weight of the material world.", 1, false, "Debt, Struggle" },
                    { 550, 69, "Finances", "Beginning to climb out of debt. Seeing the 'light in the window'.", 1, true, "Recovery, Aid" },
                    { 551, 69, "Spiritual", "The 'Dark Night' of the material soul. Learning that wealth isn't everything.", 1, false, "Humility, Spirit" },
                    { 552, 69, "Spiritual", "Spiritual victimhood. Blaming the universe for your physical problems.", 1, true, "Blame, Fear" },
                    { 553, 70, "Love", "Generosity of spirit. Giving your time and energy freely to a partner.", 1, false, "Giving, Grace" },
                    { 554, 70, "Love", "Strings attached to love. Giving only when you expect something back.", 1, true, "Strings, Debt" },
                    { 555, 70, "Career", "A mentor or investor aids you. Receiving the resources you need to grow.", 1, false, "Mentorship, Aid" },
                    { 556, 70, "Career", "Unfair distribution of work or credit. A boss who plays favorites.", 1, true, "Bias, Inequity" },
                    { 557, 70, "Finances", "Charity and balance. Being in a position to help others financially.", 1, false, "Charity, Flow" },
                    { 558, 70, "Finances", "Bad loans or predatory deals. Be careful who you borrow from.", 1, true, "Trap, Predatory" },
                    { 559, 70, "Spiritual", "Understanding the law of circulation. What you give, you receive.", 1, false, "Karma, Flow" },
                    { 560, 70, "Spiritual", "Spiritual superiority. Thinking you are holier because you help others.", 1, true, "Pride, Ego" },
                    { 561, 71, "Love", "Patience in romance. Waiting for a long-term connection to mature.", 1, false, "Patience, Growth" },
                    { 562, 71, "Love", "Frustration with a partner’s slow progress. Feeling love is a 'chore'.", 1, true, "Doubt, Fatigue" },
                    { 563, 71, "Career", "Reviewing your progress. Taking a moment to see if the work is paying off.", 1, false, "Review, Harvest" },
                    { 564, 71, "Career", "Lack of reward for your effort. Feeling stuck in a low-yield project.", 1, true, "Waste, Delay" },
                    { 565, 71, "Finances", "Long-term investments. Watching your 'ore' turn into 'gold' over years.", 1, false, "Profit, Time" },
                    { 566, 71, "Finances", "Impatience with investments. Selling too early and losing the gain.", 1, true, "Haste, Loss" },
                    { 567, 71, "Spiritual", "Spiritual persistence. Understanding that soul-work takes time.", 1, false, "Endurance, Soul" },
                    { 568, 71, "Spiritual", "Spiritual exhaustion. Tired of waiting for a sign from the universe.", 1, true, "Fatigue, Doubt" },
                    { 569, 72, "Love", "Dedication to a partner. Working hard to provide a good life together.", 1, false, "Work, Care" },
                    { 570, 72, "Love", "Boredom in a relationship. Too much focus on routine and not enough on heart.", 1, true, "Routine, Dull" },
                    { 571, 72, "Career", "Deep focus on a single craft. Refining your skills to a high level.", 1, false, "Detail, Mastery" },
                    { 572, 72, "Career", "Workaholism. Losing sight of the big picture by obsessing over details.", 1, true, "Stress, Narrow" },
                    { 573, 72, "Finances", "Earning money through hard work. A time of steady, reliable income.", 1, false, "Labor, Earn" },
                    { 574, 72, "Finances", "Financial penny-pinching. Obsessing over small costs while losing big ones.", 1, true, "Miser, Narrow" },
                    { 575, 72, "Spiritual", "The practice of ritual. Daily acts of devotion that build a soul.", 1, false, "Ritual, Practice" },
                    { 576, 72, "Spiritual", "Empty rituals. Going through the motions without any inner fire.", 1, true, "Hollow, Static" },
                    { 577, 73, "Love", "Enjoying your own company. A time of self-love and luxury.", 1, false, "Independence, Joy" },
                    { 578, 73, "Love", "Over-dependence on a partner’s money. Losing your identity in luxury.", 1, true, "Greed, Shallow" },
                    { 579, 73, "Career", "Financial independence. Reaching a level where you can choose your work.", 1, false, "Autonomy, Success" },
                    { 580, 73, "Career", "A 'golden cage'. Having a high-paying job but no personal freedom.", 1, true, "Trap, Hollow" },
                    { 581, 73, "Finances", "Wealth and abundance. Enjoying the fruits of your labor in solitude.", 1, false, "Abundance, Ease" },
                    { 582, 73, "Finances", "Reckless spending to maintain an image. The facade of wealth.", 1, true, "Waste, Vanity" },
                    { 583, 73, "Spiritual", "Spiritual refinement. Reaching a high state of peace and self-worth.", 1, false, "Grace, Worth" },
                    { 584, 73, "Spiritual", "Materialism disguised as spirituality. Caring about 'luxury' crystals only.", 1, true, "Vanity, False" },
                    { 585, 74, "Love", "A legacy of love. Building a family or a long-term home together.", 1, false, "Legacy, Family" },
                    { 586, 74, "Love", "Family burdens. Feeling trapped by old traditions or heritage.", 1, true, "Burden, Duty" },
                    { 587, 74, "Career", "A family business or a long-term institution. Lasting professional success.", 1, false, "Tradition, Build" },
                    { 588, 74, "Career", "Rigid professional structures. Stagnation due to 'how we've always done it'.", 1, true, "Rigid, Stale" },
                    { 589, 74, "Finances", "Generational wealth. Inheritance or permanent financial security.", 1, false, "Heritage, Wealth" },
                    { 590, 74, "Finances", "Family quarrels over money. Losing wealth through lack of planning.", 1, true, "Conflict, Loss" },
                    { 591, 74, "Spiritual", "Honoring the ancestors. Finding deep wisdom in your heritage.", 1, false, "Ancestry, Roots" },
                    { 592, 74, "Spiritual", "Feeling disconnected from your roots. A sense of being 'soulless'.", 1, true, "Lost, Empty" },
                    { 593, 75, "Love", "A practical romantic message. Someone offering a stable and real future.", 1, false, "Offer, Solid" },
                    { 594, 75, "Love", "A message about money that hurts love. Someone being too practical.", 1, true, "Dry, Cold" },
                    { 595, 75, "Career", "An apprentice in business. Learning the value of a dollar and a hard day.", 1, false, "Student, Value" },
                    { 596, 75, "Career", "Professional laziness. Someone who doesn't want to get their hands dirty.", 1, true, "Lazy, Soft" },
                    { 597, 75, "Finances", "Small but steady gains. Starting a savings account or a small investment.", 1, false, "Savings, Seed" },
                    { 598, 75, "Finances", "Financial immaturity. Wasting your seed money on things that rot.", 1, true, "Waste, Foolish" },
                    { 599, 75, "Spiritual", "Studying the laws of nature. Finding the divine in the dirt and stone.", 1, false, "Nature, Study" },
                    { 600, 75, "Spiritual", "Ignoring the material world. Forgetting that your body is also a temple.", 1, true, "Neglect, Vague" },
                    { 601, 76, "Love", "A reliable and loyal partner. Slow to love but love that lasts a lifetime.", 1, false, "Loyalty, Trust" },
                    { 602, 76, "Love", "A boring or stubborn partner. Resistance to any change in the relationship.", 1, true, "Stubborn, Dull" },
                    { 603, 76, "Career", "Hard work and reliability. The backbone of any project or company.", 1, false, "Reliable, Labor" },
                    { 604, 76, "Career", "Stagnation. Doing the same thing over and over with no innovation.", 1, true, "Boredom, Static" },
                    { 605, 76, "Finances", "Steady financial progress. Conservative moves that pay off slowly.", 1, false, "Steady, Safe" },
                    { 606, 76, "Finances", "Financial inertia. Refusing to move your money even when it’s losing value.", 1, true, "Stuck, Inertia" },
                    { 607, 76, "Spiritual", "Spiritual discipline. The long walk toward a goal with no shortcuts.", 1, false, "Path, Grunt" },
                    { 608, 76, "Spiritual", "Spiritual stubbornness. Refusing to see any other way but your own.", 1, true, "Closed, Fixed" },
                    { 609, 77, "Love", "A nurturing and practical love. A partner who creates a warm home.", 1, false, "Home, Nurture" },
                    { 610, 77, "Love", "Smothering or overprotective love. Putting material needs before soul needs.", 1, true, "Smother, Cold" },
                    { 611, 77, "Career", "Success in management or hospitality. Creating a fertile environment.", 1, false, "Fertile, Boss" },
                    { 612, 77, "Career", "Disorganized workspace or life. Failing to manage your resources.", 1, true, "Chaos, Mess" },
                    { 613, 77, "Finances", "Financial security and generosity. Using wealth to care for others.", 1, false, "Safety, Grace" },
                    { 614, 77, "Finances", "Financial insecurity disguised as wealth. Living beyond your means.", 1, true, "Facade, Debt" },
                    { 615, 77, "Spiritual", "Divine Mother energy. Connecting with the earth as a living being.", 1, false, "Gaea, Soul" },
                    { 616, 77, "Spiritual", "Spiritual imbalance. Neglecting your physical body for 'high' thoughts.", 1, true, "Neglect, Void" },
                    { 617, 78, "Love", "A love that is protective, providing, and deeply successful.", 1, false, "Security, Duty" },
                    { 618, 78, "Love", "A controlling partner who uses money to keep the relationship together.", 1, true, "Greed, Control" },
                    { 619, 78, "Career", "The King of Industry. Reaching the peak of your professional mountain.", 1, false, "Power, Mastery" },
                    { 620, 78, "Career", "Professional tyranny. A boss who values 'ores' more than 'people'.", 1, true, "Tyrant, Harsh" },
                    { 621, 78, "Finances", "Absolute financial mastery. Owning the mountain and the mine.", 1, false, "Wealth, Status" },
                    { 622, 78, "Finances", "Hoarding wealth at the cost of your health. A life of cold gold.", 1, true, "Miser, Loss" },
                    { 623, 78, "Spiritual", "Manifesting the highest soul in the heaviest matter. Spiritual King.", 1, false, "Master, Body" },
                    { 624, 78, "Spiritual", "Spiritual pride through material power. Thinking gold is a sign of grace.", 1, true, "Ego, False" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Meanings",
                keyColumn: "Id",
                keyValue: 624);
        }
    }
}
