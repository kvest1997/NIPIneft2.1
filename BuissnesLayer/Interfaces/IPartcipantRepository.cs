using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IPartcipantRepository
    {
        IEnumerable<Participant> GetAllParticipant(bool include = false);
        Participant GetParticipantById(int id, bool include = false);
        void Save(Participant participant);
        void Delete(Participant participant);
    }
}
