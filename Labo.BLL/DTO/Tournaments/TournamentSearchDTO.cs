using Labo.DL.Enums;

namespace Labo.BLL.DTO.Tournaments
{
    public class TournamentSearchDTO
    {
        public int Offset { get; set; } = 0;
        public DateTime? From { get; set; }
        public string? Name { get; set; }
        public bool WomenOnly { get; set; }
        public TournamentCategory? Category { get; set; }
        public List<TournamentStatus>? Statuses { get; set; } = [TournamentStatus.WaitingForPlayers, TournamentStatus.InProgress];
    }
}
