using BuissnesLayer.Interfaces;
using DataLayer;
using DataLayer.Entityes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BuissnesLayer.Implementations
{
    public class EFPartcipantRepository : IPartcipantRepository
    {
        private EFDBContext context;
        public EFPartcipantRepository(EFDBContext context)
        {
            this.context = context;
        }


        public void Delete(Participant participant)
        {
            context.Participant.Remove(participant);
            context.SaveChanges();
        }

        public IEnumerable<Participant> GetAllParticipant(bool include = false)
        {
            if (include)
                return context.Set<Participant>().Include(x => x.Id).AsNoTracking().ToList();
            else
                return context.Participant.ToList();

        }

        public Participant GetParticipantById(int id, bool include = false)
        {
            if (include)
                return context.Set<Participant>().Include(x => x.Id).AsNoTracking().FirstOrDefault(x => x.Id == id);
            else
                return context.Participant.FirstOrDefault(x => x.Id == id);

        }

        public void Save(Participant participant)
        {
            if (participant.Id == 0)
                context.Participant.Add(participant);
            else
                context.Entry(participant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
