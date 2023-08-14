using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{ Id = 1, Name = "Pool View", Sqft = 100, Occupancy = 2 },
                new VillaDTO{ Id = 2, Name = "Beach View", Sqft = 300, Occupancy = 3 },
                new VillaDTO{ Id = 3, Name = "Pier View", Sqft = 250, Occupancy = 3 },
                new VillaDTO{ Id = 4, Name = "Ocean View", Sqft = 420, Occupancy = 5 },
                new VillaDTO{ Id = 5, Name = "Garden Window", Sqft = 400, Occupancy = 5 }
            };
    }
}
