using Portal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Portal.Domain.Entities
{
    public class PollVotingRecord : BaseEntity
    {
        public int PollAnswerId { get; set; }

        public virtual PollAnswer PollAnswer { get; set; }

        public int PollId { get; set; }

        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}