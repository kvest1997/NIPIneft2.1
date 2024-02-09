using DataLayer.Entityes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer.Interfaces
{
    public interface IGenderRepository
    {
        IEnumerable<Gender> GetAllParticipant(bool include = false);
        Gender GetParticipantById(int id, bool include = false);
        void Save(Gender participant);
        void Delete(Gender participant);
    }
}
