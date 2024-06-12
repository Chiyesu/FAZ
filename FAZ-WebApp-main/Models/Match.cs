public class Match{
    public int MatchId { get; set; }
    public int HostTeamId { get; set; }
    public int GuestTeamId { get; set; }
    public DateOnly DatePlayed { get; set; }
    public string RefereeId { get; set; }
}