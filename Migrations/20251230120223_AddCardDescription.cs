using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TheSeer.Migrations
{
    /// <inheritdoc />
    public partial class AddCardDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The Fool signifies a primary initiation sequence. It represents a state of total freedom from historical constraints and a leap into an uncalculated void.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Magician represents the manifestation of will through resource synchronization. It is the interface between pure potential and physical reality.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The High Priestess embodies the silent archive of the subconscious. She represents intuition and data points existing between binary states.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Empress signifies biological abundance and systemic growth. She is the nurturing force required for organic expansion within the void.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "The Emperor represents the ultimate structure and enforcement of order. He is the authority that stabilizes the system through strategic dominance.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "The Hierophant signifies alignment with established protocols and tradition. He provides the formal framework for collective human belief systems.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "The Lovers represent a critical convergence of paths. It signifies the harmony of dualities and the necessity of core-aligned choice.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "The Chariot signifies victory achieved through unwavering discipline. It represents the successful navigation of opposing forces under one will.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Strength represents the integration of instinct with higher consciousness. It is the power of courage and the mastery of internal impulses.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "The Hermit signifies withdrawal for deep-level data analysis. It represents the quest for truth through introspection and isolated wisdom.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "The Wheel of Fortune represents inevitable systemic cycles. It signifies that change is the only constant parameter in the grand design.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Justice represents the absolute law of cause and effect. It signifies impartial evaluation where truth is the only acceptable output.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "The Hanged Man signifies a period of deliberate suspension. It represents gaining a new perspective through sacrifice and non-action.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Death represents the termination of an obsolete cycle. It is the transition that clears the path for a more efficient iteration.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Temperance signifies the alchemy of balance. It represents the synthesis of disparate elements into a stable, harmonious whole.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "The Devil represents bondage to material data and primal impulses. It signifies the illusion of entrapment within a self-made system.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "The Tower signifies the violent disruption of false structures. It represents the collapse of hubris and the liberation found in ruin.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "The Star represents hope and the restoration of purpose. It is the beacon providing guidance and peace after a period of systemic chaos.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "The Moon signifies the realm of shadows and the unconscious. It represents uncertainty where logic is obscured by fluctuating data.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "The Sun represents total clarity and vitality. It is the source of energy that illuminates all hidden variables in the path.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 21,
                column: "Description",
                value: "Judgement signifies the final evaluation of the journey. It is the call to awakening based on the summary of all previous actions.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 22,
                column: "Description",
                value: "The World represents the absolute completion of the cycle. It signifies total integration and harmony within the cosmic mainframe.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 23,
                column: "Description",
                value: "The initial surge of creative potential. It signifies the planting of a new objective within the fertile mind.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 24,
                column: "Description",
                value: "Synchronization of intent with global strategy. It represents the observation of the horizon before deployment.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 25,
                column: "Description",
                value: "The expansion of Influence. It signifies the arrival of the first data points confirming successful growth.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 26,
                column: "Description",
                value: "A milestone of stability. It represents a temporary equilibrium and the celebration of structural integrity.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 27,
                column: "Description",
                value: "A conflict of priorities. It signifies the friction generated when multiple agents compete for the same sector.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 28,
                column: "Description",
                value: "Public validation of victory. It signifies the recognition of one's status following a successful operation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 29,
                column: "Description",
                value: "A defensive stance against overwhelming odds. It represents the maintenance of high ground under pressure.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 30,
                column: "Description",
                value: "High-velocity transmission. It signifies the rapid resolution of events and the swift approach of a conclusion.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 31,
                column: "Description",
                value: "The final resilience protocol. It signifies persistence in the face of exhaustion before the mission ends.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 32,
                column: "Description",
                value: "Maximum capacity reached. It signifies the heavy burden of total responsibility and the cost of over-extension.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 33,
                column: "Description",
                value: "An influx of new inspirational data. It represents the youthful enthusiasm for a fresh technical endeavor.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 34,
                column: "Description",
                value: "Aggressive pursuit of the objective. It signifies the rapid movement of an agent focused on sudden change.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 35,
                column: "Description",
                value: "Mastery of social radiance. She represents the command of focus and the efficient management of vibrant energy.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 36,
                column: "Description",
                value: "The ultimate visionary authority. He represents the strategic command of inspiration and long-term ambition.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 37,
                column: "Description",
                value: "The birth of a sharp, analytical truth. It signifies a breakthrough in logic that cuts through historical noise.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 38,
                column: "Description",
                value: "A stalemate in the decision-making process. It represents the suspension of action due to conflicting data.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 39,
                column: "Description",
                value: "Systemic heartbreak. It signifies the pain caused by the cold realization of a harsh, objective reality.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 40,
                column: "Description",
                value: "A tactical withdrawal into stasis. It represents the necessity of mental recovery and sensory deprivation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 41,
                column: "Description",
                value: "An inefficient victory. It signifies a conflict where the losses sustained negate the value of the outcome.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 42,
                column: "Description",
                value: "Transition to a more stable sector. It represents the movement away from chaos toward logical clarity.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 43,
                column: "Description",
                value: "Tactical deception. It signifies the attempt to achieve goals through stealth or the manipulation of data.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 44,
                column: "Description",
                value: "Cognitive entrapment. It represents the illusion of restricted movement within a self-imposed logical cage.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 45,
                column: "Description",
                value: "A loop of psychological distress. It signifies the overwhelming feedback of anxiety and projected failure.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 46,
                column: "Description",
                value: "Total systemic failure. It represents the absolute end of a struggle and the necessity of a hard reset.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 47,
                column: "Description",
                value: "The arrival of inquisitive new data. It signifies a mind prepared for rigorous analysis and learning.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 48,
                column: "Description",
                value: "The rapid deployment of logic. He signifies the aggressive pursuit of truth without regard for emotional variables.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 49,
                column: "Description",
                value: "Mastery of perception. She represents the ability to cut through deception with the cold blade of clarity.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 50,
                column: "Description",
                value: "The pinnacle of intellectual authority. He represents the impartial judge who operates on pure data.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 51,
                column: "Description",
                value: "The emergence of a primary emotional surge. It signifies the birth of a deep, intuitive connection.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 52,
                column: "Description",
                value: "Synchronization of dual emotional streams. It represents the creation of a stable, resonant bond.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 53,
                column: "Description",
                value: "Social integration and group harmony. It signifies the joy of shared experience within a collective.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 54,
                column: "Description",
                value: "Emotional saturation. It signifies a state of apathy where new inputs are rejected due to over-exposure.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 55,
                column: "Description",
                value: "A focus on depleted resources. It signifies mourning over lost connections while ignoring available data.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 56,
                column: "Description",
                value: "The retrieval of historical comfort. It signifies a return to the safety of genetic or childhood memory.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 57,
                column: "Description",
                value: "A conflict of projections. It represents the difficulty of choosing between multiple alluring illusions.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 58,
                column: "Description",
                value: "A voluntary departure from the current state. It signifies the search for a deeper meaning beyond the current horizon.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 59,
                column: "Description",
                value: "Total internal satisfaction. It represents the achievement of emotional self-reliance and independence.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 60,
                column: "Description",
                value: "Complete emotional integration. It represents the final alignment of the self with its social and environmental surroundings.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 61,
                column: "Description",
                value: "The arrival of intuitive signals. He represents the youthful explorer of the subconscious realm.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 62,
                column: "Description",
                value: "The pursuit of an emotional ideal. He signifies the movement toward a romantic or intuitive objective.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 63,
                column: "Description",
                value: "The master of empathy. She signifies the ability to reflect the emotions of the system with perfect fidelity.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 64,
                column: "Description",
                value: "The authority of emotional calm. He represents the mature management of feelings and the power of poise.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 65,
                column: "Description",
                value: "The birth of a physical resource. It signifies the initial manifestation of a tangible material opportunity.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 66,
                column: "Description",
                value: "The balancing of material priorities. It represents the fluid management of changing physical variables.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 67,
                column: "Description",
                value: "Collaborative production. It signifies the successful output of a team focused on technical mastery.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 68,
                column: "Description",
                value: "Material stasis. It represents a rigid defense of resources born from a fear of systemic loss.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 69,
                column: "Description",
                value: "A deficit of resources. It signifies a period of physical hardship and the exclusion from a secure sector.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 70,
                column: "Description",
                value: "The redistribution of wealth. It represents the systemic flow of support and the act of charitable input.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 71,
                column: "Description",
                value: "The evaluation of yield. It signifies a pause to assess the long-term viability of current material work.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 72,
                column: "Description",
                value: "The discipline of the craft. It represents the repetitive refinement of a technical skill until perfection.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 73,
                column: "Description",
                value: "Material independence. It signifies the achievement of luxury through the efficient management of the self.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 74,
                column: "Description",
                value: "Generational legacy. It signifies the accumulation of success that persists across historical timelines.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 75,
                column: "Description",
                value: "A student of the physical world. He represents the arrival of news concerning a practical, material venture.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 76,
                column: "Description",
                value: "The steady advancement of work. He represents the dutiful, slow progress toward a physical goal.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 77,
                column: "Description",
                value: "The master of pragmatism. She signifies the nurturing of the home and the security of grounded resources.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 78,
                column: "Description",
                value: "The supreme manager of physics. He represents the highest form of material power and stable success.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 79,
                column: "Description",
                value: "The Awakened Earth signifies a fundamental shift in the environment. It represents dormant forces becoming active, demanding reconfiguration.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 80,
                column: "Description",
                value: "The Water Debt represents the price of existence in an arid system. It signifies the inevitable settling of biological accounts.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 81,
                column: "Description",
                value: "A surge of hostile solar energy. It signifies a period of total exposure and the lethal clarity of an unblinking gaze.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 82,
                column: "Description",
                value: "Environmental instability. It represents a state of transition where the path is constantly re-forming beneath the traveler.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 83,
                column: "Description",
                value: "A necessity for protection. It signifies the filtering of noise to extract only the data essential for survival.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 84,
                column: "Description",
                value: "The extraction of value from a barren sector. It signifies the bitter reward found in the most hostile environments.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Description", "Name" },
                values: new object[] { "An approaching external crisis. It represents a force that cannot be diverted, only weathered through extreme preparation.", "The Storm Wall" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A rare surge of profound systemic insight. It represents the eruption of vast potential from the deep desert.", "The Spice Bloom" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A signal from the emptiness. It represents the feedback loop of a system left in isolation for an extended duration.", "The Void Echo" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Description", "Name" },
                values: new object[] { "A cognitive error. It signifies the projection of an objective that does not exist in objective, physical reality.", "The Heat Mirage" });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "Mastery over complex space-time calculations. He signifies the ability to guide the collective through the unmapped void.", "The Navigator", "Mystic Orders", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The storage of genetic and historical memory. She signifies the cold use of the past to manipulate the future.", "The Reverend Mother", "Mystic Orders", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The perfection of human analytical logic. He represents a state where calculation is the only valid response to data.", "The Mentat", "Mystic Orders", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The perfection of lethal physical discipline. He represents absolute tactical focus and mastery over the blade.", "The Swordmaster", "Mystic Orders", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The detection of deception within a system. She signifies a sensory array tuned to the frequency of human dishonesty.", "The Truthsayer", "Mystic Orders", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The enforcement of the supreme will. It represents a force that exists only to protect the architecture of power.", "The Imperial Guard", "Mystic Orders", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The gathering of clandestine intelligence. He signifies the ability to observe a sector without alerting its inhabitants.", "The Desert Scout", "Mystic Orders", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The drive for survival in extreme conditions. He signifies the relentless pursuit of the rarest life-sustaining resources.", "The Water Seeker", "Mystic Orders", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The control of vast, ancient forces. He signifies the synchronization of the individual with a titanic entity.", "The Sand Rider", "Mystic Orders", 9 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Description", "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The power of an invisible collective. It represents a force perfectly integrated with its environment.", "The Hidden Fremen", "Mystic Orders", 10 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 113,
                column: "Description",
                value: "The primary force of creation and destruction. It signifies the immense scale of the divine mechanics under the sand.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 114,
                column: "Description",
                value: "A rhythmic call to the unknown. It represents the attraction of powerful variables through consistent action.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 115,
                column: "Description",
                value: "A forgotten node of ancient belief. It represents the intersection of historical tradition and physical isolation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 116,
                column: "Description",
                value: "A catalyst for mechanical and spiritual initiation. It represents the lubrication of the grand machine's gears.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 117,
                column: "Description",
                value: "An unchanging reference point in a shifting world. It represents the absolute durability of a core conviction.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 118,
                column: "Description",
                value: "A data point on the failure of previous agents. It represents the lessons learned from those the desert claimed.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 124,
                column: "Description",
                value: "The flow of mobile wealth and basic energy. It signifies resources required for expansion, if managed with precision.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 125,
                column: "Description",
                value: "Raw, untamed strength. It represents the primordial energy that drives the machine of progress through the void.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 126,
                column: "Description",
                value: "A reactive defensive threshold. It signifies the thorny protection that both guards the core and wounds the intruder.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 127,
                column: "Description",
                value: "The transmission of divine intelligence. It represents signals from the origin and the power of creative speech.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 128,
                column: "Description",
                value: "The protocol of movement and rhythm. It signifies the alignment of the traveler's path with universal cycles.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 129,
                column: "Description",
                value: "Controlled ignition. It represents the light of human knowledge and the intentional application of thermal force.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 130,
                column: "Description",
                value: "The exchange of data and resources. It signifies the balance required in a contract between two entities.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 131,
                column: "Description",
                value: "Systemic harmony. It represents the successful integration of all parameters into a joyful, stable equilibrium.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 132,
                column: "Description",
                value: "Destructive disruption from the environment. It signifies the cold, structural failure that forces a total reset.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 133,
                column: "Description",
                value: "A state of acute resource deficiency. It represents the resistance that creates the necessity for innovation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 134,
                column: "Description",
                value: "Absolute stasis. It represents the ice-like pause in all processing where external movement is suspended.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 135,
                column: "Description",
                value: "The harvest cycle. It signifies the inevitable yield of a process and the rewards of consistent calculation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 136,
                column: "Description",
                value: "The vertical axis of the system. It represents the resilience and stability that bridges life and death.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 137,
                column: "Description",
                value: "The probability matrix and the roll of the dice. It signifies the hidden variables of fate governing the void.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 138,
                column: "Description",
                value: "The invocation of a protective field. It represents the connection to a higher shield and self-preservation.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 139,
                column: "Description",
                value: "A burst of radiant solar energy. It signifies the absolute success of the mission and the clarity of truth.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 140,
                column: "Description",
                value: "The warrior's code and strategic sacrifice. It represents the focus on justice and the power of the blade.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 141,
                column: "Description",
                value: "The regenerative force of birth. It signifies the concealment and nurturing of new organic potential.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 142,
                column: "Description",
                value: "Synchronization between rider and mount. It represents the efficient partnership required for transit.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 143,
                column: "Description",
                value: "The collective human entity. It signifies shared awareness and the complex social structures of the species.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 144,
                column: "Description",
                value: "The fluid dynamics of the subconscious. It represents the tidal forces that drive intuition.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 145,
                column: "Description",
                value: "The storage of potential energy. It signifies a state of gestation where power is accumulated for release.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 146,
                column: "Description",
                value: "The moment of total illumination. It signifies the transition from darkness to light and a new mission.");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 147,
                column: "Description",
                value: "The inheritance of ancestral space. It signifies the foundation of the home and the genetic line's legacy.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cards");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 85,
                column: "Name",
                value: "The Oasis Ghost");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 86,
                column: "Name",
                value: "The Sand Rose");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 87,
                column: "Name",
                value: "The Dry Lightning");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 88,
                column: "Name",
                value: "The Wind Carver");

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Nomad's Path", "Wild Elements", 11 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Throne of Glass", "Imperial Houses", 1 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Great Accord", "Imperial Houses", 2 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Poisoned Gift", "Imperial Houses", 3 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Heir Apparent", "Imperial Houses", 4 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Spy’s Whisper", "Imperial Houses", 5 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Blood Lineage", "Imperial Houses", 6 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The War Engine", "Imperial Houses", 7 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Golden Exile", "Imperial Houses", 8 });

            migrationBuilder.UpdateData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Name", "SuitOrGroup", "Value" },
                values: new object[] { "The Trade Route", "Imperial Houses", 9 });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "DeckId", "ImageKey", "Name", "SuitOrGroup", "Value" },
                values: new object[,]
                {
                    { 99, 3, "", "The Silent Regent", "Imperial Houses", 10 },
                    { 100, 3, "", "The Broken Banner", "Imperial Houses", 11 },
                    { 101, 3, "", "The Voice of Command", "Mystic Orders", 1 },
                    { 102, 3, "", "The Prescient Eye", "Mystic Orders", 2 },
                    { 103, 3, "", "The Blue Fever", "Mystic Orders", 3 },
                    { 104, 3, "", "The Folding Space", "Mystic Orders", 4 },
                    { 105, 3, "", "The Truth Sayer", "Mystic Orders", 5 },
                    { 106, 3, "", "The Ancestral Link", "Mystic Orders", 6 },
                    { 107, 3, "", "The Dream Walker", "Mystic Orders", 7 },
                    { 108, 3, "", "The Shadow Mission", "Mystic Orders", 8 },
                    { 109, 3, "", "The Genetic Thread", "Mystic Orders", 9 },
                    { 110, 3, "", "The Mental Wall", "Mystic Orders", 10 },
                    { 111, 3, "", "The Future Path", "Mystic Orders", 11 },
                    { 112, 3, "", "The Great Devourer", "Ancient Prophecies", 1 },
                    { 119, 3, "", "The Pillar of Fire", "Ancient Prophecies", 8 },
                    { 120, 3, "", "The White Sun", "Ancient Prophecies", 9 },
                    { 121, 3, "", "The Dark Star", "Ancient Prophecies", 10 },
                    { 122, 3, "", "The Final Horizon", "Ancient Prophecies", 11 }
                });
        }
    }
}
