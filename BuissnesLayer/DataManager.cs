using BuissnesLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuissnesLayer
{
    public class DataManager
    {
        private IDirectorysRepository _directorysRepository;
        private IMaterialsRepository _materialsRepository;
        private IPartcipantRepository _partcipantRepository;

        public DataManager(IDirectorysRepository directorysRepository, IMaterialsRepository materialsRepository, IPartcipantRepository partcipantRepository)
        {
            _directorysRepository = directorysRepository;
            _materialsRepository = materialsRepository;
            _partcipantRepository = partcipantRepository;
        }

        public IDirectorysRepository Directorys { get { return _directorysRepository; } }
        public IMaterialsRepository Materials { get { return _materialsRepository; } }
        public IPartcipantRepository Partcipant { get { return _partcipantRepository; } }

    }
}
