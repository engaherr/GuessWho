﻿namespace GuessWhoServices
{
    public class MatchInformation
    {
        private string hostNickname;
        private string guestNickname;
        private IGameCallback hostChannel;
        private IGameCallback guestChannel;
        private bool isTournamentMatch;

        public string HostNickname { get { return hostNickname; } set { hostNickname = value; } }
        public string GuestNickname { get { return guestNickname; } set { guestNickname = value; } }
        public IGameCallback HostChannel { get { return hostChannel; } set { hostChannel = value; } }
        public IGameCallback GuestChannel { get { return guestChannel; } set { guestChannel = value; } }
        public bool IsTournamentMatch { get { return isTournamentMatch; } set { isTournamentMatch = value; } }
    }
}
